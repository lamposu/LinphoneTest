using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class PlayerListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_player_cbs_set_eof_reached(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnEofReachedDelegatePrivate(IntPtr obj);

        public delegate void OnEofReachedDelegate(Player obj);
        private OnEofReachedDelegatePrivate on_eof_reached_private;
        private OnEofReachedDelegate on_eof_reached_public;

        private static void on_eof_reached(IntPtr obj)
        {
            Player thiz = fromNativePtr<Player>(obj);
            PlayerListener listener = thiz.Listener;

            listener.on_eof_reached_public?.Invoke(thiz);
        }

        public OnEofReachedDelegate OnEofReached
        {
            get
            {
                return on_eof_reached_public;
            }
            set
            {
                on_eof_reached_public = value;

                on_eof_reached_private = on_eof_reached;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_eof_reached_private);
                linphone_player_cbs_set_eof_reached(nativePtr, cb);

            }
        }
    }
}
