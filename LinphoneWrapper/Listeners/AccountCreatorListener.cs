using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class AccountCreatorListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_activate_account(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnActivateAccountDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnActivateAccountDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnActivateAccountDelegatePrivate on_activate_account_private;
        private OnActivateAccountDelegate on_activate_account_public;

        private static void on_activate_account(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_activate_account_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnActivateAccountDelegate OnActivateAccount
        {
            get
            {
                return on_activate_account_public;
            }
            set
            {
                on_activate_account_public = value;
                on_activate_account_private = on_activate_account;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_activate_account_private);
                linphone_account_creator_cbs_set_activate_account(nativePtr, cb);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_activate_alias(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnActivateAliasDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnActivateAliasDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnActivateAliasDelegatePrivate on_activate_alias_private;
        private OnActivateAliasDelegate on_activate_alias_public;

        private static void on_activate_alias(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_activate_alias_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnActivateAliasDelegate OnActivateAlias
        {
            get
            {
                return on_activate_alias_public;
            }
            set
            {
                on_activate_alias_public = value;
                on_activate_alias_private = on_activate_alias;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_activate_alias_private);
                linphone_account_creator_cbs_set_activate_alias(nativePtr, cb);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_is_account_linked(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnIsAccountLinkedDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnIsAccountLinkedDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnIsAccountLinkedDelegatePrivate on_is_account_linked_private;
        private OnIsAccountLinkedDelegate on_is_account_linked_public;

        private static void on_is_account_linked(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_is_account_linked_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnIsAccountLinkedDelegate OnIsAccountLinked
        {
            get
            {
                return on_is_account_linked_public;
            }
            set
            {
                on_is_account_linked_public = value;

                on_is_account_linked_private = on_is_account_linked;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_is_account_linked_private);
                linphone_account_creator_cbs_set_is_account_linked(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_link_account(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnLinkAccountDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnLinkAccountDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnLinkAccountDelegatePrivate on_link_account_private;
        private OnLinkAccountDelegate on_link_account_public;

        private static void on_link_account(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_link_account_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnLinkAccountDelegate OnLinkAccount
        {
            get
            {
                return on_link_account_public;
            }
            set
            {
                on_link_account_public = value;

                on_link_account_private = on_link_account;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_link_account_private);
                linphone_account_creator_cbs_set_link_account(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_is_alias_used(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnIsAliasUsedDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnIsAliasUsedDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnIsAliasUsedDelegatePrivate on_is_alias_used_private;
        private OnIsAliasUsedDelegate on_is_alias_used_public;

        private static void on_is_alias_used(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_is_alias_used_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnIsAliasUsedDelegate OnIsAliasUsed
        {
            get
            {
                return on_is_alias_used_public;
            }
            set
            {
                on_is_alias_used_public = value;

                on_is_alias_used_private = on_is_alias_used;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_is_alias_used_private);
                linphone_account_creator_cbs_set_is_alias_used(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_is_account_activated(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnIsAccountActivatedDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnIsAccountActivatedDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnIsAccountActivatedDelegatePrivate on_is_account_activated_private;
        private OnIsAccountActivatedDelegate on_is_account_activated_public;

        private static void on_is_account_activated(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_is_account_activated_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnIsAccountActivatedDelegate OnIsAccountActivated
        {
            get
            {
                return on_is_account_activated_public;
            }
            set
            {
                on_is_account_activated_public = value;

                on_is_account_activated_private = on_is_account_activated;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_is_account_activated_private);
                linphone_account_creator_cbs_set_is_account_activated(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_is_account_exist(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnIsAccountExistDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnIsAccountExistDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnIsAccountExistDelegatePrivate on_is_account_exist_private;
        private OnIsAccountExistDelegate on_is_account_exist_public;

        private static void on_is_account_exist(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_is_account_exist_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnIsAccountExistDelegate OnIsAccountExist
        {
            get
            {
                return on_is_account_exist_public;
            }
            set
            {
                on_is_account_exist_public = value;

                on_is_account_exist_private = on_is_account_exist;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_is_account_exist_private);
                linphone_account_creator_cbs_set_is_account_exist(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_update_account(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnUpdateAccountDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnUpdateAccountDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnUpdateAccountDelegatePrivate on_update_account_private;
        private OnUpdateAccountDelegate on_update_account_public;

        private static void on_update_account(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_update_account_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnUpdateAccountDelegate OnUpdateAccount
        {
            get
            {
                return on_update_account_public;
            }
            set
            {
                on_update_account_public = value;

                on_update_account_private = on_update_account;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_update_account_private);
                linphone_account_creator_cbs_set_update_account(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_recover_account(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnRecoverAccountDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnRecoverAccountDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnRecoverAccountDelegatePrivate on_recover_account_private;
        private OnRecoverAccountDelegate on_recover_account_public;

        private static void on_recover_account(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_recover_account_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnRecoverAccountDelegate OnRecoverAccount
        {
            get
            {
                return on_recover_account_public;
            }
            set
            {
                on_recover_account_public = value;

                on_recover_account_private = on_recover_account;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_recover_account_private);
                linphone_account_creator_cbs_set_recover_account(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_account_creator_cbs_set_create_account(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnCreateAccountDelegatePrivate(IntPtr creator, int status, string resp);

        public delegate void OnCreateAccountDelegate(AccountCreator creator, AccountCreatorStatus status, string resp);
        private OnCreateAccountDelegatePrivate on_create_account_private;
        private OnCreateAccountDelegate on_create_account_public;

        private static void on_create_account(IntPtr creator, int status, string resp)
        {
            AccountCreator thiz = fromNativePtr<AccountCreator>(creator);
            AccountCreatorListener listener = thiz.Listener;

            listener.on_create_account_public?.Invoke(thiz, (AccountCreatorStatus)status, resp);
        }

        public OnCreateAccountDelegate OnCreateAccount
        {
            get
            {
                return on_create_account_public;
            }
            set
            {
                on_create_account_public = value;

                on_create_account_private = on_create_account;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_create_account_private);
                linphone_account_creator_cbs_set_create_account(nativePtr, cb);

            }
        }
    }
}
