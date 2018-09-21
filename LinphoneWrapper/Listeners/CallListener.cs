using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class CallListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_snapshot_taken(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnSnapshotTakenDelegatePrivate(IntPtr call, string filepath);

        public delegate void OnSnapshotTakenDelegate(Call call, string filepath);
        private OnSnapshotTakenDelegatePrivate on_snapshot_taken_private;
        private OnSnapshotTakenDelegate on_snapshot_taken_public;

        private static void on_snapshot_taken(IntPtr call, string filepath)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_snapshot_taken_public?.Invoke(thiz, filepath);
        }

        public OnSnapshotTakenDelegate OnSnapshotTaken
        {
            get
            {
                return on_snapshot_taken_public;
            }
            set
            {
                on_snapshot_taken_public = value;

                on_snapshot_taken_private = on_snapshot_taken;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_snapshot_taken_private);
                linphone_call_cbs_set_snapshot_taken(nativePtr, cb);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnStateChangedDelegatePrivate(IntPtr call, int cstate, string message);

        public delegate void OnStateChangedDelegate(Call call, CallState cstate, string message);
        private OnStateChangedDelegatePrivate on_state_changed_private;
        private OnStateChangedDelegate on_state_changed_public;

        private static void on_state_changed(IntPtr call, int cstate, string message)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_state_changed_public?.Invoke(thiz, (CallState)cstate, message);
        }

        public OnStateChangedDelegate OnStateChanged
        {
            get
            {
                return on_state_changed_public;
            }
            set
            {
                on_state_changed_public = value;

                on_state_changed_private = on_state_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_state_changed_private);
                linphone_call_cbs_set_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_transfer_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnTransferStateChangedDelegatePrivate(IntPtr call, int cstate);

        public delegate void OnTransferStateChangedDelegate(Call call, CallState cstate);
        private OnTransferStateChangedDelegatePrivate on_transfer_state_changed_private;
        private OnTransferStateChangedDelegate on_transfer_state_changed_public;

        private static void on_transfer_state_changed(IntPtr call, int cstate)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_transfer_state_changed_public?.Invoke(thiz, (CallState)cstate);
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
                linphone_call_cbs_set_transfer_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_tmmbr_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnTmmbrReceivedDelegatePrivate(IntPtr call, int streamIndex, int tmmbr);

        public delegate void OnTmmbrReceivedDelegate(Call call, int streamIndex, int tmmbr);
        private OnTmmbrReceivedDelegatePrivate on_tmmbr_received_private;
        private OnTmmbrReceivedDelegate on_tmmbr_received_public;

        private static void on_tmmbr_received(IntPtr call, int streamIndex, int tmmbr)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_tmmbr_received_public?.Invoke(thiz, streamIndex, tmmbr);
        }

        public OnTmmbrReceivedDelegate OnTmmbrReceived
        {
            get
            {
                return on_tmmbr_received_public;
            }
            set
            {
                on_tmmbr_received_public = value;

                on_tmmbr_received_private = on_tmmbr_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_tmmbr_received_private);
                linphone_call_cbs_set_tmmbr_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_info_message_received(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnInfoMessageReceivedDelegatePrivate(IntPtr call, IntPtr msg);

        public delegate void OnInfoMessageReceivedDelegate(Call call, InfoMessage msg);
        private OnInfoMessageReceivedDelegatePrivate on_info_message_received_private;
        private OnInfoMessageReceivedDelegate on_info_message_received_public;

        private static void on_info_message_received(IntPtr call, IntPtr msg)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_info_message_received_public?.Invoke(thiz, fromNativePtr<InfoMessage>(msg));
        }

        public OnInfoMessageReceivedDelegate OnInfoMessageReceived
        {
            get
            {
                return on_info_message_received_public;
            }
            set
            {
                on_info_message_received_public = value;

                on_info_message_received_private = on_info_message_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_info_message_received_private);
                linphone_call_cbs_set_info_message_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_encryption_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnEncryptionChangedDelegatePrivate(IntPtr call, char on, string authenticationToken);

        public delegate void OnEncryptionChangedDelegate(Call call, bool on, string authenticationToken);
        private OnEncryptionChangedDelegatePrivate on_encryption_changed_private;
        private OnEncryptionChangedDelegate on_encryption_changed_public;

        private static void on_encryption_changed(IntPtr call, char on, string authenticationToken)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_encryption_changed_public?.Invoke(thiz, on == 0, authenticationToken);
        }

        public OnEncryptionChangedDelegate OnEncryptionChanged
        {
            get
            {
                return on_encryption_changed_public;
            }
            set
            {
                on_encryption_changed_public = value;

                on_encryption_changed_private = on_encryption_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_encryption_changed_private);
                linphone_call_cbs_set_encryption_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_ack_processing(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnAckProcessingDelegatePrivate(IntPtr call, IntPtr ack, char isReceived);

        public delegate void OnAckProcessingDelegate(Call call, Headers ack, bool isReceived);
        private OnAckProcessingDelegatePrivate on_ack_processing_private;
        private OnAckProcessingDelegate on_ack_processing_public;

        private static void on_ack_processing(IntPtr call, IntPtr ack, char isReceived)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_ack_processing_public?.Invoke(thiz, fromNativePtr<Headers>(ack), isReceived == 0);
        }

        public OnAckProcessingDelegate OnAckProcessing
        {
            get
            {
                return on_ack_processing_public;
            }
            set
            {
                on_ack_processing_public = value;
                on_ack_processing_private = on_ack_processing;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_ack_processing_private);
                linphone_call_cbs_set_ack_processing(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_dtmf_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnDtmfReceivedDelegatePrivate(IntPtr call, int dtmf);

        public delegate void OnDtmfReceivedDelegate(Call call, int dtmf);
        private OnDtmfReceivedDelegatePrivate on_dtmf_received_private;
        private OnDtmfReceivedDelegate on_dtmf_received_public;

        private static void on_dtmf_received(IntPtr call, int dtmf)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_dtmf_received_public?.Invoke(thiz, dtmf);
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
                linphone_call_cbs_set_dtmf_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_next_video_frame_decoded(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnNextVideoFrameDecodedDelegatePrivate(IntPtr call);

        public delegate void OnNextVideoFrameDecodedDelegate(Call call);
        private OnNextVideoFrameDecodedDelegatePrivate on_next_video_frame_decoded_private;
        private OnNextVideoFrameDecodedDelegate on_next_video_frame_decoded_public;

        private static void on_next_video_frame_decoded(IntPtr call)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_next_video_frame_decoded_public?.Invoke(thiz);
        }

        public OnNextVideoFrameDecodedDelegate OnNextVideoFrameDecoded
        {
            get
            {
                return on_next_video_frame_decoded_public;
            }
            set
            {
                on_next_video_frame_decoded_public = value;

                on_next_video_frame_decoded_private = on_next_video_frame_decoded;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_next_video_frame_decoded_private);
                linphone_call_cbs_set_next_video_frame_decoded(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_call_cbs_set_stats_updated(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnStatsUpdatedDelegatePrivate(IntPtr call, IntPtr stats);

        public delegate void OnStatsUpdatedDelegate(Call call, CallStats stats);
        private OnStatsUpdatedDelegatePrivate on_stats_updated_private;
        private OnStatsUpdatedDelegate on_stats_updated_public;

        private static void on_stats_updated(IntPtr call, IntPtr stats)
        {
            Call thiz = fromNativePtr<Call>(call);

            CallListener listener = thiz.CurrentCallbacks;
            listener.on_stats_updated_public?.Invoke(thiz, fromNativePtr<CallStats>(stats));
        }

        public OnStatsUpdatedDelegate OnStatsUpdated
        {
            get
            {
                return on_stats_updated_public;
            }
            set
            {
                on_stats_updated_public = value;

                on_stats_updated_private = on_stats_updated;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_stats_updated_private);
                linphone_call_cbs_set_stats_updated(nativePtr, cb);
            }
        }
    }
}
