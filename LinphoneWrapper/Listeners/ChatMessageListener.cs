using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class ChatMessageListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_message_cbs_set_participant_imdn_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantImdnStateChangedDelegatePrivate(IntPtr msg, IntPtr state);

        public delegate void OnParticipantImdnStateChangedDelegate(ChatMessage msg, ParticipantImdnState state);
        private OnParticipantImdnStateChangedDelegatePrivate on_participant_imdn_state_changed_private;
        private OnParticipantImdnStateChangedDelegate on_participant_imdn_state_changed_public;

        private static void on_participant_imdn_state_changed(IntPtr msg, IntPtr state)
        {
            ChatMessage thiz = fromNativePtr<ChatMessage>(msg);
            ChatMessageListener listener = thiz.Listener;

            listener.on_participant_imdn_state_changed_public?.Invoke(thiz, fromNativePtr<ParticipantImdnState>(state));
        }

        public OnParticipantImdnStateChangedDelegate OnParticipantImdnStateChanged
        {
            get
            {
                return on_participant_imdn_state_changed_public;
            }
            set
            {
                on_participant_imdn_state_changed_public = value;

                on_participant_imdn_state_changed_private = on_participant_imdn_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_imdn_state_changed_private);
                linphone_chat_message_cbs_set_participant_imdn_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_message_cbs_set_file_transfer_recv(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnFileTransferRecvDelegatePrivate(IntPtr message, IntPtr content, IntPtr buffer);

        public delegate void OnFileTransferRecvDelegate(ChatMessage message, Content content, Buffer buffer);
        private OnFileTransferRecvDelegatePrivate on_file_transfer_recv_private;
        private OnFileTransferRecvDelegate on_file_transfer_recv_public;

        private static void on_file_transfer_recv(IntPtr message, IntPtr content, IntPtr buffer)
        {
            ChatMessage thiz = fromNativePtr<ChatMessage>(message);
            ChatMessageListener listener = thiz.Listener;

            listener.on_file_transfer_recv_public?.Invoke(thiz, fromNativePtr<Content>(content), fromNativePtr<Buffer>(buffer));
        }

        public OnFileTransferRecvDelegate OnFileTransferRecv
        {
            get
            {
                return on_file_transfer_recv_public;
            }
            set
            {
                on_file_transfer_recv_public = value;

                on_file_transfer_recv_private = on_file_transfer_recv;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_file_transfer_recv_private);
                linphone_chat_message_cbs_set_file_transfer_recv(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_message_cbs_set_file_transfer_send(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnFileTransferSendDelegatePrivate(IntPtr message, IntPtr content, long offset, long size);

        public delegate void OnFileTransferSendDelegate(ChatMessage message, Content content, long offset, long size);
        private OnFileTransferSendDelegatePrivate on_file_transfer_send_private;
        private OnFileTransferSendDelegate on_file_transfer_send_public;

        private static void on_file_transfer_send(IntPtr message, IntPtr content, long offset, long size)
        {
            ChatMessage thiz = fromNativePtr<ChatMessage>(message);
            ChatMessageListener listener = thiz.Listener;

            listener.on_file_transfer_send_public?.Invoke(thiz, fromNativePtr<Content>(content), offset, size);
        }

        public OnFileTransferSendDelegate OnFileTransferSend
        {
            get
            {
                return on_file_transfer_send_public;
            }
            set
            {
                on_file_transfer_send_public = value;

                on_file_transfer_send_private = on_file_transfer_send;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_file_transfer_send_private);
                linphone_chat_message_cbs_set_file_transfer_send(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_message_cbs_set_file_transfer_progress_indication(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnFileTransferProgressIndicationDelegatePrivate(IntPtr message, IntPtr content, long offset, long total);

        public delegate void OnFileTransferProgressIndicationDelegate(ChatMessage message, Content content, long offset, long total);
        private OnFileTransferProgressIndicationDelegatePrivate on_file_transfer_progress_indication_private;
        private OnFileTransferProgressIndicationDelegate on_file_transfer_progress_indication_public;

        private static void on_file_transfer_progress_indication(IntPtr message, IntPtr content, long offset, long total)
        {
            ChatMessage thiz = fromNativePtr<ChatMessage>(message);
            ChatMessageListener listener = thiz.Listener;

            listener.on_file_transfer_progress_indication_public?.Invoke(thiz, fromNativePtr<Content>(content), offset, total);
        }

        public OnFileTransferProgressIndicationDelegate OnFileTransferProgressIndication
        {
            get
            {
                return on_file_transfer_progress_indication_public;
            }
            set
            {
                on_file_transfer_progress_indication_public = value;

                on_file_transfer_progress_indication_private = on_file_transfer_progress_indication;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_file_transfer_progress_indication_private);
                linphone_chat_message_cbs_set_file_transfer_progress_indication(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_message_cbs_set_msg_state_changed(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnMsgStateChangedDelegatePrivate(IntPtr msg, int state);

        public delegate void OnMsgStateChangedDelegate(ChatMessage msg, ChatMessageState state);
        private OnMsgStateChangedDelegatePrivate on_msg_state_changed_private;
        private OnMsgStateChangedDelegate on_msg_state_changed_public;

        private static void on_msg_state_changed(IntPtr msg, int state)
        {
            ChatMessage thiz = fromNativePtr<ChatMessage>(msg);
            ChatMessageListener listener = thiz.Listener;

            listener.on_msg_state_changed_public?.Invoke(thiz, (ChatMessageState)state);
        }

        public OnMsgStateChangedDelegate OnMsgStateChanged
        {
            get
            {
                return on_msg_state_changed_public;
            }
            set
            {
                on_msg_state_changed_public = value;

                on_msg_state_changed_private = on_msg_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_msg_state_changed_private);
                linphone_chat_message_cbs_set_msg_state_changed(nativePtr, cb);
            }
        }
    }
}
