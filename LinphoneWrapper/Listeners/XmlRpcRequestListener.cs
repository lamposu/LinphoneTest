using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class XmlRpcRequestListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_xml_rpc_request_cbs_set_response(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnResponseDelegatePrivate(IntPtr request);

        public delegate void OnResponseDelegate(XmlRpcRequest request);
        private OnResponseDelegatePrivate on_response_private;
        private OnResponseDelegate on_response_public;

        private static void on_response(IntPtr request)
        {
            XmlRpcRequest thiz = fromNativePtr<XmlRpcRequest>(request);
            XmlRpcRequestListener listener = thiz.Listener;

            listener.on_response_public?.Invoke(thiz);
        }

        public OnResponseDelegate OnResponse
        {
            get
            {
                return on_response_public;
            }
            set
            {
                on_response_public = value;

                on_response_private = on_response;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_response_private);
                linphone_xml_rpc_request_cbs_set_response(nativePtr, cb);
            }
        }
    }
}
