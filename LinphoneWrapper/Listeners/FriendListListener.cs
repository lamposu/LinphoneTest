using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class FriendListListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_friend_list_cbs_set_sync_status_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnSyncStatusChangedDelegatePrivate(IntPtr list, int status, string msg);

        public delegate void OnSyncStatusChangedDelegate(FriendList list, FriendListSyncStatus status, string msg);
        private OnSyncStatusChangedDelegatePrivate on_sync_status_changed_private;
        private OnSyncStatusChangedDelegate on_sync_status_changed_public;

        private static void on_sync_status_changed(IntPtr list, int status, string msg)
        {
            FriendList thiz = fromNativePtr<FriendList>(list);
            FriendListListener listener = thiz.Listener;

            listener.on_sync_status_changed_public?.Invoke(thiz, (FriendListSyncStatus)status, msg);
        }

        public OnSyncStatusChangedDelegate OnSyncStatusChanged
        {
            get
            {
                return on_sync_status_changed_public;
            }
            set
            {
                on_sync_status_changed_public = value;

                on_sync_status_changed_private = on_sync_status_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_sync_status_changed_private);
                linphone_friend_list_cbs_set_sync_status_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_friend_list_cbs_set_contact_created(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnContactCreatedDelegatePrivate(IntPtr list, IntPtr lf);

        public delegate void OnContactCreatedDelegate(FriendList list, Friend lf);
        private OnContactCreatedDelegatePrivate on_contact_created_private;
        private OnContactCreatedDelegate on_contact_created_public;

        private static void on_contact_created(IntPtr list, IntPtr lf)
        {
            FriendList thiz = fromNativePtr<FriendList>(list);
            FriendListListener listener = thiz.Listener;

            listener.on_contact_created_public?.Invoke(thiz, fromNativePtr<Friend>(lf));
        }

        public OnContactCreatedDelegate OnContactCreated
        {
            get
            {
                return on_contact_created_public;
            }
            set
            {
                on_contact_created_public = value;

                on_contact_created_private = on_contact_created;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_contact_created_private);
                linphone_friend_list_cbs_set_contact_created(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_friend_list_cbs_set_contact_updated(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnContactUpdatedDelegatePrivate(IntPtr list, IntPtr newFriend, IntPtr oldFriend);

        public delegate void OnContactUpdatedDelegate(FriendList list, Friend newFriend, Friend oldFriend);
        private OnContactUpdatedDelegatePrivate on_contact_updated_private;
        private OnContactUpdatedDelegate on_contact_updated_public;

        private static void on_contact_updated(IntPtr list, IntPtr newFriend, IntPtr oldFriend)
        {
            FriendList thiz = fromNativePtr<FriendList>(list);
            FriendListListener listener = thiz.Listener;

            listener.on_contact_updated_public?.Invoke(thiz, fromNativePtr<Friend>(newFriend), fromNativePtr<Friend>(oldFriend));
        }

        public OnContactUpdatedDelegate OnContactUpdated
        {
            get
            {
                return on_contact_updated_public;
            }
            set
            {
                on_contact_updated_public = value;

                on_contact_updated_private = on_contact_updated;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_contact_updated_private);
                linphone_friend_list_cbs_set_contact_updated(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_friend_list_cbs_set_contact_deleted(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnContactDeletedDelegatePrivate(IntPtr list, IntPtr lf);

        public delegate void OnContactDeletedDelegate(FriendList list, Friend lf);
        private OnContactDeletedDelegatePrivate on_contact_deleted_private;
        private OnContactDeletedDelegate on_contact_deleted_public;

        private static void on_contact_deleted(IntPtr list, IntPtr lf)
        {
            FriendList thiz = fromNativePtr<FriendList>(list);
            FriendListListener listener = thiz.Listener;

            listener.on_contact_deleted_public?.Invoke(thiz, fromNativePtr<Friend>(lf));
        }

        public OnContactDeletedDelegate OnContactDeleted
        {
            get
            {
                return on_contact_deleted_public;
            }
            set
            {
                on_contact_deleted_public = value;

                on_contact_deleted_private = on_contact_deleted;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_contact_deleted_private);
                linphone_friend_list_cbs_set_contact_deleted(nativePtr, cb);
            }
        }
    }
}
