using LinphoneWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                bool running = true;
                string userName = "3561012";
                string password = "34111774";
                string server = "10.10.3.89";
                int port = 19561;

                Core.SetLogLevel(OrtpLogLevel.DEBUG);


                var coreLisener = Factory.Instance.CreateCoreListener();

                coreLisener.OnCallStateChanged += delegate (Core lc, Call call, CallState cstate, string message)
                {
                    switch (cstate)
                    {
                        case CallState.OutgoingRinging:
                            Console.WriteLine("It is now ringing remotely !");
                            break;
                        case CallState.OutgoingEarlyMedia:
                            Console.WriteLine("Receiving some early media");
                            break;
                        case CallState.Connected:
                            Console.WriteLine("We are connected !");
                            break;
                        case CallState.StreamsRunning:
                            
                            Console.WriteLine("Media streams established !");
                            break;
                        case CallState.End:
                            Console.WriteLine("Call is End.");
                            break;
                        case CallState.Error:
                            Console.WriteLine("Call failure !");
                            break;
                        case CallState.IncomingReceived:

                            Console.WriteLine("Incomming call received!");

                            Console.WriteLine($"Microphone volume gain: {call.MicrophoneVolumeGain}");
                            
                            lc.AcceptCall(call);
                            
                            break;
                        case CallState.IncomingEarlyMedia:
                            Console.WriteLine("Incomming early media!");
                            break;
                        default:
                            Console.WriteLine($"Unhandled notification {cstate}\n");
                            break;
                    }
                };
                coreLisener.OnRegistrationStateChanged += delegate (Core lc, ProxyConfig cfg, RegistrationState cstate, string message)
                {
                    if (cstate == RegistrationState.Ok)
                    {
                        var param = lc.CreateCallParams(null);
                        param.AudioEnabled = true;
                        param.VideoEnabled = false;
                        param.LowBandwidthEnabled = true;
                        var call = lc.InviteWithParams("3560069", param);
                    }

                    Console.WriteLine($"Registation State changed: {cstate}");
                };
                var core = Factory.Instance.CreateCore(
                    coreLisener,
                    null, 
                    @"E:\Projects\sipdotnet-master\ConsoleApp1\bin\x86\share\Linphone\linphonerc-factory");

                core.ReloadMsPlugins(@"E:\Projects\sipdotnet-master\ConsoleApp1\bin\x86\lib\mediastreamer\plugins");
                core.ReloadSoundDevices();
                core.RootCa = @"E:\Projects\sipdotnet-master\ConsoleApp1\bin\x86\share\Linphone\rootca.pem";

                Thread coreLoop = new Thread(() =>
                {
                    while (running)
                    {
                        core.Iterate();
                        Thread.Sleep(200);
                    }
                    coreLisener.OnRegistrationStateChanged?.Invoke(null, null, RegistrationState.Cleared, null);
                })
                { IsBackground = false };
                coreLoop.Start();

                var transpors = Factory.Instance.CreateTransports();
                transpors.UdpPort = 0;
                transpors.TcpPort = -1;
                transpors.DtlsPort = -1;
                transpors.TlsPort = -1;
                core.Transports = transpors;

                core.SetUserAgent("Desktop", "1.5.0.9");
                core.Ring = @"E:\Projects\sipdotnet-master\ConsoleApp1\bin\x86\share/sounds\linphone\rings\its_a_game.mkv";
                core.Ringback = @"E:\Projects\sipdotnet-master\ConsoleApp1\bin\x86\share/sounds\linphone\ringback.wav";
                core.RingDuringIncomingEarlyMedia = true;
                core.EchoCancellationEnabled = true;
                core.MicEnabled = true;
                var soundDevices = core.SoundDevicesList;
                foreach (var device in soundDevices)
                {
                    if (core.SoundDeviceCanPlayback(device) && string.IsNullOrEmpty(core.PlaybackDevice))
                    {
                        core.PlaybackDevice = device;
                        core.RingerDevice = device;
                        break;
                    }

                    if (core.SoundDeviceCanCapture(device))
                    {
                        core.CaptureDevice = device;
                    }
                }

                core.AddAuthInfo(Factory.Instance.CreateAuthInfo(userName, null, password, null, null, null));

                string identity = "sip:" + userName + "@" + server;
                string server_addr = $"sip:{server}:{port};transport=tcp";
                var address = Factory.Instance.CreateAddress(identity);

                var nat = core.CreateNatPolicy();
                nat.IceEnabled = false;
                nat.StunEnabled = false;
                nat.TurnEnabled = false;
                nat.UpnpEnabled = false;
                core.NatPolicy = nat;

                core.SipDscp = 0x1A;
                core.AudioDscp = 0x2E;
                core.VideoDscp = 0;

                core.DnsSearchEnabled = true;
                core.DnsSrvEnabled = true;
                core.AdaptiveRateControlEnabled = true;
                core.UseInfoForDtmf = true;
                core.Ipv6Enabled = false;
                core.KeepAliveEnabled = true;

                var proxyCofig = core.CreateProxyConfig();
                proxyCofig.IdentityAddress = address;
                proxyCofig.ServerAddr = server_addr;
                proxyCofig.PublishEnabled = true;
                proxyCofig.RegisterEnabled = true;
                proxyCofig.AvpfMode = AVPFMode.Disabled;
                proxyCofig.Expires = 600;
                proxyCofig.AvpfRrInterval = 5;
                core.AddProxyConfig(proxyCofig);
                core.DefaultProxyConfig = proxyCofig;


                //Account account = new Account("3561012", "34111774", "10.10.3.89", 19561);
                //Phone phone = new Phone(account);
                //phone.PhoneConnectedEvent += delegate ()
                //{
                //    Console.WriteLine("Phone connected. Calling...");
                //    phone.MakeCall("3560069");
                //    //phone.MakeCallAndRecord("phonenumber", "/tmp/filename.wav");
                //};
                //phone.CallActiveEvent += delegate (Call call)
                //{
                //    Console.WriteLine("Answered. Call is active!");
                //};
                //phone.CallCompletedEvent += delegate (Call call)
                //{
                //    Console.WriteLine("Completed.");
                //};
                //phone.ErrorEvent += delegate (Call call, Phone.Error error)
                //{
                //    Console.WriteLine("Error: " + error.ToString());
                //};
                //phone.IncomingCallEvent += delegate (Call call)
                //{
                //    Console.WriteLine("IP phone call incomming...");
                //};
                //phone.Connect(); // connecting

                //phone.MicrophoneEnabled = true;
                //phone.PlaybackDevices();

                //Console.WriteLine(phone.RingerDevice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
            
        }


        

    }
}
