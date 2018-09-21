using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class CoreListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_transfer_state_changed(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnTransferStateChangedDelegatePrivate(IntPtr lc, IntPtr transfered, int newCallState);

        public delegate void OnTransferStateChangedDelegate(Core lc, Call transfered, CallState newCallState);
        private OnTransferStateChangedDelegatePrivate on_transfer_state_changed_private;
        private OnTransferStateChangedDelegate on_transfer_state_changed_public;

        private static void on_transfer_state_changed(IntPtr lc, IntPtr transfered, int newCallState)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_transfer_state_changed_public?.Invoke(thiz, fromNativePtr<Call>(transfered), (CallState)newCallState);
        }

        public OnTransferStateChangedDelegate OnTransferStateChanged
        {
            get
            {
                return on_transfer_state_changed_public;
            }
            set
            {
                on_transfer_state_changed_public = value;

                on_transfer_state_changed_private = on_transfer_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_transfer_state_changed_private);
                linphone_core_cbs_set_transfer_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_friend_list_created(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnFriendListCreatedDelegatePrivate(IntPtr lc, IntPtr list);

        public delegate void OnFriendListCreatedDelegate(Core lc, FriendList list);
        private OnFriendListCreatedDelegatePrivate on_friend_list_created_private;
        private OnFriendListCreatedDelegate on_friend_list_created_public;

        private static void on_friend_list_created(IntPtr lc, IntPtr list)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_friend_list_created_public?.Invoke(thiz, fromNativePtr<FriendList>(list));
        }

        public OnFriendListCreatedDelegate OnFriendListCreated
        {
            get
            {
                return on_friend_list_created_public;
            }
            set
            {
                on_friend_list_created_public = value;

                on_friend_list_created_private = on_friend_list_created;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_friend_list_created_private);
                linphone_core_cbs_set_friend_list_created(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_subscription_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnSubscriptionStateChangedDelegatePrivate(IntPtr lc, IntPtr lev, int state);

        public delegate void OnSubscriptionStateChangedDelegate(Core lc, Event lev, SubscriptionState state);
        private OnSubscriptionStateChangedDelegatePrivate on_subscription_state_changed_private;
        private OnSubscriptionStateChangedDelegate on_subscription_state_changed_public;

        private static void on_subscription_state_changed(IntPtr lc, IntPtr lev, int state)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_subscription_state_changed_public?.Invoke(thiz, fromNativePtr<Event>(lev), (SubscriptionState)state);
        }

        public OnSubscriptionStateChangedDelegate OnSubscriptionStateChanged
        {
            get
            {
                return on_subscription_state_changed_public;
            }
            set
            {
                on_subscription_state_changed_public = value;

                on_subscription_state_changed_private = on_subscription_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_subscription_state_changed_private);
                linphone_core_cbs_set_subscription_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_call_log_updated(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnCallLogUpdatedDelegatePrivate(IntPtr lc, IntPtr newcl);

        public delegate void OnCallLogUpdatedDelegate(Core lc, CallLog newcl);
        private OnCallLogUpdatedDelegatePrivate on_call_log_updated_private;
        private OnCallLogUpdatedDelegate on_call_log_updated_public;

        private static void on_call_log_updated(IntPtr lc, IntPtr newcl)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_call_log_updated_public?.Invoke(thiz, fromNativePtr<CallLog>(newcl));
        }

        public OnCallLogUpdatedDelegate OnCallLogUpdated
        {
            get
            {
                return on_call_log_updated_public;
            }
            set
            {
                on_call_log_updated_public = value;

                on_call_log_updated_private = on_call_log_updated;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_call_log_updated_private);
                linphone_core_cbs_set_call_log_updated(nativePtr, cb);
            }
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_call_state_changed(IntPtr thiz, IntPtr cb);
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnCallStateChangedDelegatePrivate(IntPtr lc, IntPtr call, int cstate, string message);

        public delegate void OnCallStateChangedDelegate(Core lc, Call call, CallState cstate, string message);
        private OnCallStateChangedDelegatePrivate on_call_state_changed_private;
        private OnCallStateChangedDelegate on_call_state_changed_public;

        private static void on_call_state_changed(IntPtr lc, IntPtr call, int cstate, string message)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_call_state_changed_public?.Invoke(thiz, fromNativePtr<Call>(call), (CallState)cstate, message);
        }

        public OnCallStateChangedDelegate OnCallStateChanged
        {
            get
            {
                return on_call_state_changed_public;
            }
            set
            {
                on_call_state_changed_public = value;

                on_call_state_changed_private = on_call_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_call_state_changed_private);
                linphone_core_cbs_set_call_state_changed(nativePtr, cb);
            }
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_authentication_requested(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnAuthenticationRequestedDelegatePrivate(IntPtr lc, IntPtr authInfo, int method);

        public delegate void OnAuthenticationRequestedDelegate(Core lc, AuthInfo authInfo, AuthMethod method);
        private OnAuthenticationRequestedDelegatePrivate on_authentication_requested_private;
        private OnAuthenticationRequestedDelegate on_authentication_requested_public;

        private static void on_authentication_requested(IntPtr lc, IntPtr authInfo, int method)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_authentication_requested_public?.Invoke(thiz, fromNativePtr<AuthInfo>(authInfo), (AuthMethod)method);
        }

        public OnAuthenticationRequestedDelegate OnAuthenticationRequested
        {
            get
            {
                return on_authentication_requested_public;
            }
            set
            {
                on_authentication_requested_public = value;

                on_authentication_requested_private = on_authentication_requested;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_authentication_requested_private);
                linphone_core_cbs_set_authentication_requested(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_notify_presence_received_for_uri_or_tel(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnNotifyPresenceReceivedForUriOrTelDelegatePrivate(IntPtr lc, IntPtr lf, string uriOrTel, IntPtr presenceModel);

        public delegate void OnNotifyPresenceReceivedForUriOrTelDelegate(Core lc, Friend lf, string uriOrTel, PresenceModel presenceModel);
        private OnNotifyPresenceReceivedForUriOrTelDelegatePrivate on_notify_presence_received_for_uri_or_tel_private;
        private OnNotifyPresenceReceivedForUriOrTelDelegate on_notify_presence_received_for_uri_or_tel_public;

        private static void on_notify_presence_received_for_uri_or_tel(IntPtr lc, IntPtr lf, string uriOrTel, IntPtr presenceModel)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_notify_presence_received_for_uri_or_tel_public?.Invoke(thiz, fromNativePtr<Friend>(lf), uriOrTel, fromNativePtr<PresenceModel>(presenceModel));
        }

        public OnNotifyPresenceReceivedForUriOrTelDelegate OnNotifyPresenceReceivedForUriOrTel
        {
            get
            {
                return on_notify_presence_received_for_uri_or_tel_public;
            }
            set
            {
                on_notify_presence_received_for_uri_or_tel_public = value;

                on_notify_presence_received_for_uri_or_tel_private = on_notify_presence_received_for_uri_or_tel;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_notify_presence_received_for_uri_or_tel_private);
                linphone_core_cbs_set_notify_presence_received_for_uri_or_tel(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_chat_room_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnChatRoomStateChangedDelegatePrivate(IntPtr lc, IntPtr cr, int state);

        public delegate void OnChatRoomStateChangedDelegate(Core lc, ChatRoom cr, ChatRoomState state);
        private OnChatRoomStateChangedDelegatePrivate on_chat_room_state_changed_private;
        private OnChatRoomStateChangedDelegate on_chat_room_state_changed_public;

        private static void on_chat_room_state_changed(IntPtr lc, IntPtr cr, int state)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_chat_room_state_changed_public?.Invoke(thiz, fromNativePtr<ChatRoom>(cr), (ChatRoomState)state);
        }

        public OnChatRoomStateChangedDelegate OnChatRoomStateChanged
        {
            get
            {
                return on_chat_room_state_changed_public;
            }
            set
            {
                on_chat_room_state_changed_public = value;

                on_chat_room_state_changed_private = on_chat_room_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_chat_room_state_changed_private);
                linphone_core_cbs_set_chat_room_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_buddy_info_updated(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnBuddyInfoUpdatedDelegatePrivate(IntPtr lc, IntPtr lf);

        public delegate void OnBuddyInfoUpdatedDelegate(Core lc, Friend lf);
        private OnBuddyInfoUpdatedDelegatePrivate on_buddy_info_updated_private;
        private OnBuddyInfoUpdatedDelegate on_buddy_info_updated_public;

        private static void on_buddy_info_updated(IntPtr lc, IntPtr lf)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_buddy_info_updated_public?.Invoke(thiz, fromNativePtr<Friend>(lf));
        }

        public OnBuddyInfoUpdatedDelegate OnBuddyInfoUpdated
        {
            get
            {
                return on_buddy_info_updated_public;
            }
            set
            {
                on_buddy_info_updated_public = value;

                on_buddy_info_updated_private = on_buddy_info_updated;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_buddy_info_updated_private);
                linphone_core_cbs_set_buddy_info_updated(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_network_reachable(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnNetworkReachableDelegatePrivate(IntPtr lc, char reachable);

        public delegate void OnNetworkReachableDelegate(Core lc, bool reachable);
        private OnNetworkReachableDelegatePrivate on_network_reachable_private;
        private OnNetworkReachableDelegate on_network_reachable_public;


        private static void on_network_reachable(IntPtr lc, char reachable)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_network_reachable_public?.Invoke(thiz, reachable == 0);
        }

        public OnNetworkReachableDelegate OnNetworkReachable
        {
            get
            {
                return on_network_reachable_public;
            }
            set
            {
                on_network_reachable_public = value;

                on_network_reachable_private = on_network_reachable;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_network_reachable_private);
                linphone_core_cbs_set_network_reachable(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_notify_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnNotifyReceivedDelegatePrivate(IntPtr lc, IntPtr lev, string notifiedEvent, IntPtr body);

        public delegate void OnNotifyReceivedDelegate(Core lc, Event lev, string notifiedEvent, Content body);
        private OnNotifyReceivedDelegatePrivate on_notify_received_private;
        private OnNotifyReceivedDelegate on_notify_received_public;


        private static void on_notify_received(IntPtr lc, IntPtr lev, string notifiedEvent, IntPtr body)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_notify_received_public?.Invoke(thiz, fromNativePtr<Event>(lev), notifiedEvent, fromNativePtr<Content>(body));
        }

        public OnNotifyReceivedDelegate OnNotifyReceived
        {
            get
            {
                return on_notify_received_public;
            }
            set
            {
                on_notify_received_public = value;

                on_notify_received_private = on_notify_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_notify_received_private);
                linphone_core_cbs_set_notify_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_new_subscription_requested(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnNewSubscriptionRequestedDelegatePrivate(IntPtr lc, IntPtr lf, string url);

        public delegate void OnNewSubscriptionRequestedDelegate(Core lc, Friend lf, string url);
        private OnNewSubscriptionRequestedDelegatePrivate on_new_subscription_requested_private;
        private OnNewSubscriptionRequestedDelegate on_new_subscription_requested_public;

        private static void on_new_subscription_requested(IntPtr lc, IntPtr lf, string url)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_new_subscription_requested_public?.Invoke(thiz, fromNativePtr<Friend>(lf), url);
        }

        public OnNewSubscriptionRequestedDelegate OnNewSubscriptionRequested
        {
            get
            {
                return on_new_subscription_requested_public;
            }
            set
            {
                on_new_subscription_requested_public = value;

                on_new_subscription_requested_private = on_new_subscription_requested;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_new_subscription_requested_private);
                linphone_core_cbs_set_new_subscription_requested(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_registration_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnRegistrationStateChangedDelegatePrivate(IntPtr lc, IntPtr cfg, int cstate, string message);

        public delegate void OnRegistrationStateChangedDelegate(Core lc, ProxyConfig cfg, RegistrationState cstate, string message);
        private OnRegistrationStateChangedDelegatePrivate on_registration_state_changed_private;
        private OnRegistrationStateChangedDelegate on_registration_state_changed_public;

        private static void on_registration_state_changed(IntPtr lc, IntPtr cfg, int cstate, string message)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_registration_state_changed_public?.Invoke(thiz, fromNativePtr<ProxyConfig>(cfg), (RegistrationState)cstate, message);
        }

        public OnRegistrationStateChangedDelegate OnRegistrationStateChanged
        {
            get
            {
                return on_registration_state_changed_public;
            }
            set
            {
                on_registration_state_changed_public = value;

                on_registration_state_changed_private = on_registration_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_registration_state_changed_private);
                linphone_core_cbs_set_registration_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_notify_presence_received(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnNotifyPresenceReceivedDelegatePrivate(IntPtr lc, IntPtr lf);

        public delegate void OnNotifyPresenceReceivedDelegate(Core lc, Friend lf);
        private OnNotifyPresenceReceivedDelegatePrivate on_notify_presence_received_private;
        private OnNotifyPresenceReceivedDelegate on_notify_presence_received_public;

        private static void on_notify_presence_received(IntPtr lc, IntPtr lf)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_notify_presence_received_public?.Invoke(thiz, fromNativePtr<Friend>(lf));
        }

        public OnNotifyPresenceReceivedDelegate OnNotifyPresenceReceived
        {
            get
            {
                return on_notify_presence_received_public;
            }
            set
            {
                on_notify_presence_received_public = value;

                on_notify_presence_received_private = on_notify_presence_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_notify_presence_received_private);
                linphone_core_cbs_set_notify_presence_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_ec_calibration_audio_init(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnEcCalibrationAudioInitDelegatePrivate(IntPtr lc);

        public delegate void OnEcCalibrationAudioInitDelegate(Core lc);
        private OnEcCalibrationAudioInitDelegatePrivate on_ec_calibration_audio_init_private;
        private OnEcCalibrationAudioInitDelegate on_ec_calibration_audio_init_public;


        private static void on_ec_calibration_audio_init(IntPtr lc)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_ec_calibration_audio_init_public?.Invoke(thiz);
        }

        public OnEcCalibrationAudioInitDelegate OnEcCalibrationAudioInit
        {
            get
            {
                return on_ec_calibration_audio_init_public;
            }
            set
            {
                on_ec_calibration_audio_init_public = value;

                on_ec_calibration_audio_init_private = on_ec_calibration_audio_init;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_ec_calibration_audio_init_private);
                linphone_core_cbs_set_ec_calibration_audio_init(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_message_received(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnMessageReceivedDelegatePrivate(IntPtr lc, IntPtr room, IntPtr message);

        public delegate void OnMessageReceivedDelegate(Core lc, ChatRoom room, ChatMessage message);
        private OnMessageReceivedDelegatePrivate on_message_received_private;
        private OnMessageReceivedDelegate on_message_received_public;

        private static void on_message_received(IntPtr lc, IntPtr room, IntPtr message)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_message_received_public?.Invoke(thiz, fromNativePtr<ChatRoom>(room), fromNativePtr<ChatMessage>(message));
        }

        public OnMessageReceivedDelegate OnMessageReceived
        {
            get
            {
                return on_message_received_public;
            }
            set
            {
                on_message_received_public = value;
                on_message_received_private = on_message_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_message_received_private);
                linphone_core_cbs_set_message_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_ec_calibration_result(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnEcCalibrationResultDelegatePrivate(IntPtr lc, int status, int delayMs);

        public delegate void OnEcCalibrationResultDelegate(Core lc, EcCalibratorStatus status, int delayMs);
        private OnEcCalibrationResultDelegatePrivate on_ec_calibration_result_private;
        private OnEcCalibrationResultDelegate on_ec_calibration_result_public;


        private static void on_ec_calibration_result(IntPtr lc, int status, int delayMs)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_ec_calibration_result_public?.Invoke(thiz, (EcCalibratorStatus)status, delayMs);
        }

        public OnEcCalibrationResultDelegate OnEcCalibrationResult
        {
            get
            {
                return on_ec_calibration_result_public;
            }
            set
            {
                on_ec_calibration_result_public = value;

                on_ec_calibration_result_private = on_ec_calibration_result;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_ec_calibration_result_private);
                linphone_core_cbs_set_ec_calibration_result(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_subscribe_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnSubscribeReceivedDelegatePrivate(IntPtr lc, IntPtr lev, string subscribeEvent, IntPtr body);

        public delegate void OnSubscribeReceivedDelegate(Core lc, Event lev, string subscribeEvent, Content body);
        private OnSubscribeReceivedDelegatePrivate on_subscribe_received_private;
        private OnSubscribeReceivedDelegate on_subscribe_received_public;


        private static void on_subscribe_received(IntPtr lc, IntPtr lev, string subscribeEvent, IntPtr body)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_subscribe_received_public?.Invoke(thiz, fromNativePtr<Event>(lev), subscribeEvent, fromNativePtr<Content>(body));
        }

        public OnSubscribeReceivedDelegate OnSubscribeReceived
        {
            get
            {
                return on_subscribe_received_public;
            }
            set
            {
                on_subscribe_received_public = value;

                on_subscribe_received_private = on_subscribe_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_subscribe_received_private);
                linphone_core_cbs_set_subscribe_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_info_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnInfoReceivedDelegatePrivate(IntPtr lc, IntPtr call, IntPtr msg);

        public delegate void OnInfoReceivedDelegate(Core lc, Call call, InfoMessage msg);
        private OnInfoReceivedDelegatePrivate on_info_received_private;
        private OnInfoReceivedDelegate on_info_received_public;

        private static void on_info_received(IntPtr lc, IntPtr call, IntPtr msg)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_info_received_public?.Invoke(thiz, fromNativePtr<Call>(call), fromNativePtr<InfoMessage>(msg));
        }

        public OnInfoReceivedDelegate OnInfoReceived
        {
            get
            {
                return on_info_received_public;
            }
            set
            {
                on_info_received_public = value;

                on_info_received_private = on_info_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_info_received_private);
                linphone_core_cbs_set_info_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_call_stats_updated(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnCallStatsUpdatedDelegatePrivate(IntPtr lc, IntPtr call, IntPtr stats);

        public delegate void OnCallStatsUpdatedDelegate(Core lc, Call call, CallStats stats);
        private OnCallStatsUpdatedDelegatePrivate on_call_stats_updated_private;
        private OnCallStatsUpdatedDelegate on_call_stats_updated_public;

        private static void on_call_stats_updated(IntPtr lc, IntPtr call, IntPtr stats)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_call_stats_updated_public?.Invoke(thiz, fromNativePtr<Call>(call), fromNativePtr<CallStats>(stats));
        }

        public OnCallStatsUpdatedDelegate OnCallStatsUpdated
        {
            get
            {
                return on_call_stats_updated_public;
            }
            set
            {
                on_call_stats_updated_public = value;

                on_call_stats_updated_private = on_call_stats_updated;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_call_stats_updated_private);
                linphone_core_cbs_set_call_stats_updated(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_friend_list_removed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnFriendListRemovedDelegatePrivate(IntPtr lc, IntPtr list);

        public delegate void OnFriendListRemovedDelegate(Core lc, FriendList list);
        private OnFriendListRemovedDelegatePrivate on_friend_list_removed_private;
        private OnFriendListRemovedDelegate on_friend_list_removed_public;

        private static void on_friend_list_removed(IntPtr lc, IntPtr list)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_friend_list_removed_public?.Invoke(thiz, fromNativePtr<FriendList>(list));
        }

        public OnFriendListRemovedDelegate OnFriendListRemoved
        {
            get
            {
                return on_friend_list_removed_public;
            }
            set
            {
                on_friend_list_removed_public = value;

                on_friend_list_removed_private = on_friend_list_removed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_friend_list_removed_private);
                linphone_core_cbs_set_friend_list_removed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_refer_received(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnReferReceivedDelegatePrivate(IntPtr lc, string referTo);

        public delegate void OnReferReceivedDelegate(Core lc, string referTo);
        private OnReferReceivedDelegatePrivate on_refer_received_private;
        private OnReferReceivedDelegate on_refer_received_public;

        private static void on_refer_received(IntPtr lc, string referTo)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_refer_received_public?.Invoke(thiz, referTo);
        }

        public OnReferReceivedDelegate OnReferReceived
        {
            get
            {
                return on_refer_received_public;
            }
            set
            {
                on_refer_received_public = value;

                on_refer_received_private = on_refer_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_refer_received_private);
                linphone_core_cbs_set_refer_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_qrcode_found(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnQrcodeFoundDelegatePrivate(IntPtr lc, string result);

        public delegate void OnQrcodeFoundDelegate(Core lc, string result);
        private OnQrcodeFoundDelegatePrivate on_qrcode_found_private;
        private OnQrcodeFoundDelegate on_qrcode_found_public;

        private static void on_qrcode_found(IntPtr lc, string result)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_qrcode_found_public?.Invoke(thiz, result);
        }

        public OnQrcodeFoundDelegate OnQrcodeFound
        {
            get
            {
                return on_qrcode_found_public;
            }
            set
            {
                on_qrcode_found_public = value;

                on_qrcode_found_private = on_qrcode_found;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_qrcode_found_private);
                linphone_core_cbs_set_qrcode_found(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_configuring_status(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnConfiguringStatusDelegatePrivate(IntPtr lc, int status, string message);

        public delegate void OnConfiguringStatusDelegate(Core lc, ConfiguringState status, string message);
        private OnConfiguringStatusDelegatePrivate on_configuring_status_private;
        private OnConfiguringStatusDelegate on_configuring_status_public;

        private static void on_configuring_status(IntPtr lc, int status, string message)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_configuring_status_public?.Invoke(thiz, (ConfiguringState)status, message);
        }

        public OnConfiguringStatusDelegate OnConfiguringStatus
        {
            get
            {
                return on_configuring_status_public;
            }
            set
            {
                on_configuring_status_public = value;

                on_configuring_status_private = on_configuring_status;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_configuring_status_private);
                linphone_core_cbs_set_configuring_status(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_call_created(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnCallCreatedDelegatePrivate(IntPtr lc, IntPtr call);

        public delegate void OnCallCreatedDelegate(Core lc, Call call);
        private OnCallCreatedDelegatePrivate on_call_created_private;
        private OnCallCreatedDelegate on_call_created_public;

        private static void on_call_created(IntPtr lc, IntPtr call)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_call_created_public?.Invoke(thiz, fromNativePtr<Call>(call));
        }

        public OnCallCreatedDelegate OnCallCreated
        {
            get
            {
                return on_call_created_public;
            }
            set
            {
                on_call_created_public = value;

                on_call_created_private = on_call_created;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_call_created_private);
                linphone_core_cbs_set_call_created(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_publish_state_changed(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnPublishStateChangedDelegatePrivate(IntPtr lc, IntPtr lev, int state);

        public delegate void OnPublishStateChangedDelegate(Core lc, Event lev, PublishState state);
        private OnPublishStateChangedDelegatePrivate on_publish_state_changed_private;
        private OnPublishStateChangedDelegate on_publish_state_changed_public;

        private static void on_publish_state_changed(IntPtr lc, IntPtr lev, int state)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_publish_state_changed_public?.Invoke(thiz, fromNativePtr<Event>(lev), (PublishState)state);
        }

        public OnPublishStateChangedDelegate OnPublishStateChanged
        {
            get
            {
                return on_publish_state_changed_public;
            }
            set
            {
                on_publish_state_changed_public = value;

                on_publish_state_changed_private = on_publish_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_publish_state_changed_private);
                linphone_core_cbs_set_publish_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_call_encryption_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnCallEncryptionChangedDelegatePrivate(IntPtr lc, IntPtr call, char on, string authenticationToken);

        public delegate void OnCallEncryptionChangedDelegate(Core lc, Call call, bool on, string authenticationToken);
        private OnCallEncryptionChangedDelegatePrivate on_call_encryption_changed_private;
        private OnCallEncryptionChangedDelegate on_call_encryption_changed_public;

        private static void on_call_encryption_changed(IntPtr lc, IntPtr call, char on, string authenticationToken)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_call_encryption_changed_public?.Invoke(thiz, fromNativePtr<Call>(call), on == 0, authenticationToken);
        }

        public OnCallEncryptionChangedDelegate OnCallEncryptionChanged
        {
            get
            {
                return on_call_encryption_changed_public;
            }
            set
            {
                on_call_encryption_changed_public = value;

                on_call_encryption_changed_private = on_call_encryption_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_call_encryption_changed_private);
                linphone_core_cbs_set_call_encryption_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_is_composing_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnIsComposingReceivedDelegatePrivate(IntPtr lc, IntPtr room);

        public delegate void OnIsComposingReceivedDelegate(Core lc, ChatRoom room);
        private OnIsComposingReceivedDelegatePrivate on_is_composing_received_private;
        private OnIsComposingReceivedDelegate on_is_composing_received_public;

        private static void on_is_composing_received(IntPtr lc, IntPtr room)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_is_composing_received_public?.Invoke(thiz, fromNativePtr<ChatRoom>(room));
        }

        public OnIsComposingReceivedDelegate OnIsComposingReceived
        {
            get
            {
                return on_is_composing_received_public;
            }
            set
            {
                on_is_composing_received_public = value;

                on_is_composing_received_private = on_is_composing_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_is_composing_received_private);
                linphone_core_cbs_set_is_composing_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_message_received_unable_decrypt(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnMessageReceivedUnableDecryptDelegatePrivate(IntPtr lc, IntPtr room, IntPtr message);

        public delegate void OnMessageReceivedUnableDecryptDelegate(Core lc, ChatRoom room, ChatMessage message);
        private OnMessageReceivedUnableDecryptDelegatePrivate on_message_received_unable_decrypt_private;
        private OnMessageReceivedUnableDecryptDelegate on_message_received_unable_decrypt_public;

        private static void on_message_received_unable_decrypt(IntPtr lc, IntPtr room, IntPtr message)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_message_received_unable_decrypt_public?.Invoke(thiz, fromNativePtr<ChatRoom>(room), fromNativePtr<ChatMessage>(message));
        }

        public OnMessageReceivedUnableDecryptDelegate OnMessageReceivedUnableDecrypt
        {
            get
            {
                return on_message_received_unable_decrypt_public;
            }
            set
            {
                on_message_received_unable_decrypt_public = value;

                on_message_received_unable_decrypt_private = on_message_received_unable_decrypt;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_message_received_unable_decrypt_private);
                linphone_core_cbs_set_message_received_unable_decrypt(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_log_collection_upload_progress_indication(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnLogCollectionUploadProgressIndicationDelegatePrivate(IntPtr lc, long offset, long total);

        public delegate void OnLogCollectionUploadProgressIndicationDelegate(Core lc, long offset, long total);
        private OnLogCollectionUploadProgressIndicationDelegatePrivate on_log_collection_upload_progress_indication_private;
        private OnLogCollectionUploadProgressIndicationDelegate on_log_collection_upload_progress_indication_public;

        private static void on_log_collection_upload_progress_indication(IntPtr lc, long offset, long total)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_log_collection_upload_progress_indication_public?.Invoke(thiz, offset, total);
        }

        public OnLogCollectionUploadProgressIndicationDelegate OnLogCollectionUploadProgressIndication
        {
            get
            {
                return on_log_collection_upload_progress_indication_public;
            }
            set
            {
                on_log_collection_upload_progress_indication_public = value;

                on_log_collection_upload_progress_indication_private = on_log_collection_upload_progress_indication;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_log_collection_upload_progress_indication_private);
                linphone_core_cbs_set_log_collection_upload_progress_indication(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_version_update_check_result_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnVersionUpdateCheckResultReceivedDelegatePrivate(IntPtr lc, int result, string version, string url);

        public delegate void OnVersionUpdateCheckResultReceivedDelegate(Core lc, VersionUpdateCheckResult result, string version, string url);
        private OnVersionUpdateCheckResultReceivedDelegatePrivate on_version_update_check_result_received_private;
        private OnVersionUpdateCheckResultReceivedDelegate on_version_update_check_result_received_public;

        private static void on_version_update_check_result_received(IntPtr lc, int result, string version, string url)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_version_update_check_result_received_public?.Invoke(thiz, (VersionUpdateCheckResult)result, version, url);
        }

        public OnVersionUpdateCheckResultReceivedDelegate OnVersionUpdateCheckResultReceived
        {
            get
            {
                return on_version_update_check_result_received_public;
            }
            set
            {
                on_version_update_check_result_received_public = value;

                on_version_update_check_result_received_private = on_version_update_check_result_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_version_update_check_result_received_private);
                linphone_core_cbs_set_version_update_check_result_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_ec_calibration_audio_uninit(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnEcCalibrationAudioUninitDelegatePrivate(IntPtr lc);

        public delegate void OnEcCalibrationAudioUninitDelegate(Core lc);
        private OnEcCalibrationAudioUninitDelegatePrivate on_ec_calibration_audio_uninit_private;
        private OnEcCalibrationAudioUninitDelegate on_ec_calibration_audio_uninit_public;

        private static void on_ec_calibration_audio_uninit(IntPtr lc)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_ec_calibration_audio_uninit_public?.Invoke(thiz);
        }

        public OnEcCalibrationAudioUninitDelegate OnEcCalibrationAudioUninit
        {
            get
            {
                return on_ec_calibration_audio_uninit_public;
            }
            set
            {
                on_ec_calibration_audio_uninit_public = value;

                on_ec_calibration_audio_uninit_private = on_ec_calibration_audio_uninit;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_ec_calibration_audio_uninit_private);
                linphone_core_cbs_set_ec_calibration_audio_uninit(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_global_state_changed(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnGlobalStateChangedDelegatePrivate(IntPtr lc, int gstate, string message);

        public delegate void OnGlobalStateChangedDelegate(Core lc, GlobalState gstate, string message);
        private OnGlobalStateChangedDelegatePrivate on_global_state_changed_private;
        private OnGlobalStateChangedDelegate on_global_state_changed_public;

        private static void on_global_state_changed(IntPtr lc, int gstate, string message)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_global_state_changed_public?.Invoke(thiz, (GlobalState)gstate, message);
        }

        public OnGlobalStateChangedDelegate OnGlobalStateChanged
        {
            get
            {
                return on_global_state_changed_public;
            }
            set
            {
                on_global_state_changed_public = value;

                on_global_state_changed_private = on_global_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_global_state_changed_private);
                linphone_core_cbs_set_global_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_log_collection_upload_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnLogCollectionUploadStateChangedDelegatePrivate(IntPtr lc, int state, string info);

        public delegate void OnLogCollectionUploadStateChangedDelegate(Core lc, CoreLogCollectionUploadState state, string info);
        private OnLogCollectionUploadStateChangedDelegatePrivate on_log_collection_upload_state_changed_private;
        private OnLogCollectionUploadStateChangedDelegate on_log_collection_upload_state_changed_public;

        private static void on_log_collection_upload_state_changed(IntPtr lc, int state, string info)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_log_collection_upload_state_changed_public?.Invoke(thiz, (CoreLogCollectionUploadState)state, info);
        }

        public OnLogCollectionUploadStateChangedDelegate OnLogCollectionUploadStateChanged
        {
            get
            {
                return on_log_collection_upload_state_changed_public;
            }
            set
            {
                on_log_collection_upload_state_changed_public = value;

                on_log_collection_upload_state_changed_private = on_log_collection_upload_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_log_collection_upload_state_changed_private);
                linphone_core_cbs_set_log_collection_upload_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_core_cbs_set_dtmf_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnDtmfReceivedDelegatePrivate(IntPtr lc, IntPtr call, int dtmf);

        public delegate void OnDtmfReceivedDelegate(Core lc, Call call, int dtmf);
        private OnDtmfReceivedDelegatePrivate on_dtmf_received_private;
        private OnDtmfReceivedDelegate on_dtmf_received_public;

        private static void on_dtmf_received(IntPtr lc, IntPtr call, int dtmf)
        {
            Core thiz = fromNativePtr<Core>(lc);

            CoreListener listener = thiz.CurrentCallbacks;
            listener.on_dtmf_received_public?.Invoke(thiz, fromNativePtr<Call>(call), dtmf);
        }

        public OnDtmfReceivedDelegate OnDtmfReceived
        {
            get
            {
                return on_dtmf_received_public;
            }
            set
            {
                on_dtmf_received_public = value;

                on_dtmf_received_private = on_dtmf_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_dtmf_received_private);
                linphone_core_cbs_set_dtmf_received(nativePtr, cb);
            }
        }
    }
}
