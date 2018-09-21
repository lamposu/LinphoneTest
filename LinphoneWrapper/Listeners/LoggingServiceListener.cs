using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class LoggingServiceListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_logging_service_cbs_set_log_message_written(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnLogMessageWrittenDelegatePrivate(IntPtr logService, string domain, int lev, string message);

        public delegate void OnLogMessageWrittenDelegate(LoggingService logService, string domain, LogLevel lev, string message);
        private OnLogMessageWrittenDelegatePrivate on_log_message_written_private;
        private OnLogMessageWrittenDelegate on_log_message_written_public;

        private static void on_log_message_written(IntPtr logService, string domain, int lev, string message)
        {
            LoggingService thiz = fromNativePtr<LoggingService>(logService);
            LoggingServiceListener listener = thiz.Listener;

            listener.on_log_message_written_public?.Invoke(thiz, domain, (LogLevel)lev, message);
        }

        public OnLogMessageWrittenDelegate OnLogMessageWritten
        {
            get
            {
                return on_log_message_written_public;
            }
            set
            {
                on_log_message_written_public = value;

                on_log_message_written_private = on_log_message_written;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_log_message_written_private);
                linphone_logging_service_cbs_set_log_message_written(nativePtr, cb);
            }
        }
    }
}
