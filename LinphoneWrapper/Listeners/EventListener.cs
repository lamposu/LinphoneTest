using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class EventListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_event_cbs_set_notify_response(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnNotifyResponseDelegatePrivate(IntPtr ev);

        public delegate void OnNotifyResponseDelegate(Event ev);
        private OnNotifyResponseDelegatePrivate on_notify_response_private;
        private OnNotifyResponseDelegate on_notify_response_public;

        private static void on_notify_response(IntPtr ev)
        {
            Event thiz = fromNativePtr<Event>(ev);
            EventListener listener = thiz.Listener;

            listener.on_notify_response_public?.Invoke(thiz);
        }

        public OnNotifyResponseDelegate OnNotifyResponse
        {
            get
            {
                return on_notify_response_public;
            }
            set
            {
                on_notify_response_public = value;

                on_notify_response_private = on_notify_response;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_notify_response_private);
                linphone_event_cbs_set_notify_response(nativePtr, cb);
            }
        }
    }
}
