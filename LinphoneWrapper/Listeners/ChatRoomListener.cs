using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LinphoneWrapper.Listeners
{
    [StructLayout(LayoutKind.Sequential)]
    public class ChatRoomListener : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_undecryptable_message_received(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnUndecryptableMessageReceivedDelegatePrivate(IntPtr cr, IntPtr msg);

        public delegate void OnUndecryptableMessageReceivedDelegate(ChatRoom cr, ChatMessage msg);
        private OnUndecryptableMessageReceivedDelegatePrivate on_undecryptable_message_received_private;
        private OnUndecryptableMessageReceivedDelegate on_undecryptable_message_received_public;

        private static void on_undecryptable_message_received(IntPtr cr, IntPtr msg)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_undecryptable_message_received_public?.Invoke(thiz, fromNativePtr<ChatMessage>(msg));
        }

        public OnUndecryptableMessageReceivedDelegate OnUndecryptableMessageReceived
        {
            get
            {
                return on_undecryptable_message_received_public;
            }
            set
            {
                on_undecryptable_message_received_public = value;

                on_undecryptable_message_received_private = on_undecryptable_message_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_undecryptable_message_received_private);
                linphone_chat_room_cbs_set_undecryptable_message_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_conference_left(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnConferenceLeftDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnConferenceLeftDelegate(ChatRoom cr, EventLog eventLog);
        private OnConferenceLeftDelegatePrivate on_conference_left_private;
        private OnConferenceLeftDelegate on_conference_left_public;

        private static void on_conference_left(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_conference_left_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnConferenceLeftDelegate OnConferenceLeft
        {
            get
            {
                return on_conference_left_public;
            }
            set
            {
                on_conference_left_public = value;

                on_conference_left_private = on_conference_left;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_conference_left_private);
                linphone_chat_room_cbs_set_conference_left(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_state_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnStateChangedDelegatePrivate(IntPtr cr, int newState);

        public delegate void OnStateChangedDelegate(ChatRoom cr, ChatRoomState newState);
        private OnStateChangedDelegatePrivate on_state_changed_private;
        private OnStateChangedDelegate on_state_changed_public;

        private static void on_state_changed(IntPtr cr, int newState)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_state_changed_public?.Invoke(thiz, (ChatRoomState)newState);
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
                linphone_chat_room_cbs_set_state_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_added(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantAddedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnParticipantAddedDelegate(ChatRoom cr, EventLog eventLog);
        private OnParticipantAddedDelegatePrivate on_participant_added_private;
        private OnParticipantAddedDelegate on_participant_added_public;

        private static void on_participant_added(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_added_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnParticipantAddedDelegate OnParticipantAdded
        {
            get
            {
                return on_participant_added_public;
            }
            set
            {
                on_participant_added_public = value;

                on_participant_added_private = on_participant_added;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_added_private);
                linphone_chat_room_cbs_set_participant_added(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_subject_changed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnSubjectChangedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnSubjectChangedDelegate(ChatRoom cr, EventLog eventLog);
        private OnSubjectChangedDelegatePrivate on_subject_changed_private;
        private OnSubjectChangedDelegate on_subject_changed_public;

        private static void on_subject_changed(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_subject_changed_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnSubjectChangedDelegate OnSubjectChanged
        {
            get
            {
                return on_subject_changed_public;
            }
            set
            {
                on_subject_changed_public = value;

                on_subject_changed_private = on_subject_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_subject_changed_private);
                linphone_chat_room_cbs_set_subject_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_is_composing_received(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnIsComposingReceivedDelegatePrivate(IntPtr cr, IntPtr remoteAddr, char isComposing);

        public delegate void OnIsComposingReceivedDelegate(ChatRoom cr, Address remoteAddr, bool isComposing);
        private OnIsComposingReceivedDelegatePrivate on_is_composing_received_private;
        private OnIsComposingReceivedDelegate on_is_composing_received_public;

        private static void on_is_composing_received(IntPtr cr, IntPtr remoteAddr, char isComposing)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_is_composing_received_public?.Invoke(thiz, fromNativePtr<Address>(remoteAddr), isComposing == 0);
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
                linphone_chat_room_cbs_set_is_composing_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_conference_address_generation(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnConferenceAddressGenerationDelegatePrivate(IntPtr cr);

        public delegate void OnConferenceAddressGenerationDelegate(ChatRoom cr);
        private OnConferenceAddressGenerationDelegatePrivate on_conference_address_generation_private;
        private OnConferenceAddressGenerationDelegate on_conference_address_generation_public;

        private static void on_conference_address_generation(IntPtr cr)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_conference_address_generation_public?.Invoke(thiz);
        }

        public OnConferenceAddressGenerationDelegate OnConferenceAddressGeneration
        {
            get
            {
                return on_conference_address_generation_public;
            }
            set
            {
                on_conference_address_generation_public = value;

                on_conference_address_generation_private = on_conference_address_generation;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_conference_address_generation_private);
                linphone_chat_room_cbs_set_conference_address_generation(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_chat_message_sent(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnChatMessageSentDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnChatMessageSentDelegate(ChatRoom cr, EventLog eventLog);
        private OnChatMessageSentDelegatePrivate on_chat_message_sent_private;
        private OnChatMessageSentDelegate on_chat_message_sent_public;

        private static void on_chat_message_sent(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_chat_message_sent_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnChatMessageSentDelegate OnChatMessageSent
        {
            get
            {
                return on_chat_message_sent_public;
            }
            set
            {
                on_chat_message_sent_public = value;
                on_chat_message_sent_private = on_chat_message_sent;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_chat_message_sent_private);
                linphone_chat_room_cbs_set_chat_message_sent(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_registration_subscription_requested(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantRegistrationSubscriptionRequestedDelegatePrivate(IntPtr cr, IntPtr participantAddr);

        public delegate void OnParticipantRegistrationSubscriptionRequestedDelegate(ChatRoom cr, Address participantAddr);
        private OnParticipantRegistrationSubscriptionRequestedDelegatePrivate on_participant_registration_subscription_requested_private;
        private OnParticipantRegistrationSubscriptionRequestedDelegate on_participant_registration_subscription_requested_public;

        private static void on_participant_registration_subscription_requested(IntPtr cr, IntPtr participantAddr)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_registration_subscription_requested_public?.Invoke(thiz, fromNativePtr<Address>(participantAddr));
        }

        public OnParticipantRegistrationSubscriptionRequestedDelegate OnParticipantRegistrationSubscriptionRequested
        {
            get
            {
                return on_participant_registration_subscription_requested_public;
            }
            set
            {
                on_participant_registration_subscription_requested_public = value;

                on_participant_registration_subscription_requested_private = on_participant_registration_subscription_requested;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_registration_subscription_requested_private);
                linphone_chat_room_cbs_set_participant_registration_subscription_requested(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_chat_message_received(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnChatMessageReceivedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnChatMessageReceivedDelegate(ChatRoom cr, EventLog eventLog);
        private OnChatMessageReceivedDelegatePrivate on_chat_message_received_private;
        private OnChatMessageReceivedDelegate on_chat_message_received_public;

        private static void on_chat_message_received(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_chat_message_received_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnChatMessageReceivedDelegate OnChatMessageReceived
        {
            get
            {
                return on_chat_message_received_public;
            }
            set
            {
                on_chat_message_received_public = value;

                on_chat_message_received_private = on_chat_message_received;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_chat_message_received_private);
                linphone_chat_room_cbs_set_chat_message_received(nativePtr, cb);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_chat_message_should_be_stored(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnChatMessageShouldBeStoredDelegatePrivate(IntPtr cr, IntPtr msg);

        public delegate void OnChatMessageShouldBeStoredDelegate(ChatRoom cr, ChatMessage msg);
        private OnChatMessageShouldBeStoredDelegatePrivate on_chat_message_should_be_stored_private;
        private OnChatMessageShouldBeStoredDelegate on_chat_message_should_be_stored_public;

        private static void on_chat_message_should_be_stored(IntPtr cr, IntPtr msg)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_chat_message_should_be_stored_public?.Invoke(thiz, fromNativePtr<ChatMessage>(msg));
        }

        public OnChatMessageShouldBeStoredDelegate OnChatMessageShouldBeStored
        {
            get
            {
                return on_chat_message_should_be_stored_public;
            }
            set
            {
                on_chat_message_should_be_stored_public = value;

                on_chat_message_should_be_stored_private = on_chat_message_should_be_stored;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_chat_message_should_be_stored_private);
                linphone_chat_room_cbs_set_chat_message_should_be_stored(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_admin_status_changed(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantAdminStatusChangedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnParticipantAdminStatusChangedDelegate(ChatRoom cr, EventLog eventLog);
        private OnParticipantAdminStatusChangedDelegatePrivate on_participant_admin_status_changed_private;
        private OnParticipantAdminStatusChangedDelegate on_participant_admin_status_changed_public;

        private static void on_participant_admin_status_changed(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_admin_status_changed_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnParticipantAdminStatusChangedDelegate OnParticipantAdminStatusChanged
        {
            get
            {
                return on_participant_admin_status_changed_public;
            }
            set
            {
                on_participant_admin_status_changed_public = value;

                on_participant_admin_status_changed_private = on_participant_admin_status_changed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_admin_status_changed_private);
                linphone_chat_room_cbs_set_participant_admin_status_changed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_message_received(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnMessageReceivedDelegatePrivate(IntPtr cr, IntPtr msg);

        public delegate void OnMessageReceivedDelegate(ChatRoom cr, ChatMessage msg);
        private OnMessageReceivedDelegatePrivate on_message_received_private;
        private OnMessageReceivedDelegate on_message_received_public;

        private static void on_message_received(IntPtr cr, IntPtr msg)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_message_received_public?.Invoke(thiz, fromNativePtr<ChatMessage>(msg));
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
                linphone_chat_room_cbs_set_message_received(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_device_removed(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantDeviceRemovedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnParticipantDeviceRemovedDelegate(ChatRoom cr, EventLog eventLog);
        private OnParticipantDeviceRemovedDelegatePrivate on_participant_device_removed_private;
        private OnParticipantDeviceRemovedDelegate on_participant_device_removed_public;

        private static void on_participant_device_removed(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_device_removed_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnParticipantDeviceRemovedDelegate OnParticipantDeviceRemoved
        {
            get
            {
                return on_participant_device_removed_public;
            }
            set
            {
                on_participant_device_removed_public = value;

                on_participant_device_removed_private = on_participant_device_removed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_device_removed_private);
                linphone_chat_room_cbs_set_participant_device_removed(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participants_capabilities_checked(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantsCapabilitiesCheckedDelegatePrivate(IntPtr cr, IntPtr deviceAddr, IntPtr participantsAddr);

        public delegate void OnParticipantsCapabilitiesCheckedDelegate(ChatRoom cr, Address deviceAddr, IEnumerable<Address> participantsAddr);
        private OnParticipantsCapabilitiesCheckedDelegatePrivate on_participants_capabilities_checked_private;
        private OnParticipantsCapabilitiesCheckedDelegate on_participants_capabilities_checked_public;

        private static void on_participants_capabilities_checked(IntPtr cr, IntPtr deviceAddr, IntPtr participantsAddr)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participants_capabilities_checked_public?.Invoke(thiz, fromNativePtr<Address>(deviceAddr), MarshalBctbxList<Address>(participantsAddr));
        }

        public OnParticipantsCapabilitiesCheckedDelegate OnParticipantsCapabilitiesChecked
        {
            get
            {
                return on_participants_capabilities_checked_public;
            }
            set
            {
                on_participants_capabilities_checked_public = value;

                on_participants_capabilities_checked_private = on_participants_capabilities_checked;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participants_capabilities_checked_private);
                linphone_chat_room_cbs_set_participants_capabilities_checked(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_removed(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantRemovedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnParticipantRemovedDelegate(ChatRoom cr, EventLog eventLog);
        private OnParticipantRemovedDelegatePrivate on_participant_removed_private;
        private OnParticipantRemovedDelegate on_participant_removed_public;

        private static void on_participant_removed(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_removed_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnParticipantRemovedDelegate OnParticipantRemoved
        {
            get
            {
                return on_participant_removed_public;
            }
            set
            {
                on_participant_removed_public = value;

                on_participant_removed_private = on_participant_removed;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_removed_private);
                linphone_chat_room_cbs_set_participant_removed(nativePtr, cb);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_registration_unsubscription_requested(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantRegistrationUnsubscriptionRequestedDelegatePrivate(IntPtr cr, IntPtr participantAddr);

        public delegate void OnParticipantRegistrationUnsubscriptionRequestedDelegate(ChatRoom cr, Address participantAddr);
        private OnParticipantRegistrationUnsubscriptionRequestedDelegatePrivate on_participant_registration_unsubscription_requested_private;
        private OnParticipantRegistrationUnsubscriptionRequestedDelegate on_participant_registration_unsubscription_requested_public;

        private static void on_participant_registration_unsubscription_requested(IntPtr cr, IntPtr participantAddr)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_registration_unsubscription_requested_public?.Invoke(thiz, fromNativePtr<Address>(participantAddr));
        }

        public OnParticipantRegistrationUnsubscriptionRequestedDelegate OnParticipantRegistrationUnsubscriptionRequested
        {
            get
            {
                return on_participant_registration_unsubscription_requested_public;
            }
            set
            {
                on_participant_registration_unsubscription_requested_public = value;

                on_participant_registration_unsubscription_requested_private = on_participant_registration_unsubscription_requested;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_registration_unsubscription_requested_private);
                linphone_chat_room_cbs_set_participant_registration_unsubscription_requested(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_conference_joined(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnConferenceJoinedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnConferenceJoinedDelegate(ChatRoom cr, EventLog eventLog);
        private OnConferenceJoinedDelegatePrivate on_conference_joined_private;
        private OnConferenceJoinedDelegate on_conference_joined_public;

        private static void on_conference_joined(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_conference_joined_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnConferenceJoinedDelegate OnConferenceJoined
        {
            get
            {
                return on_conference_joined_public;
            }
            set
            {
                on_conference_joined_public = value;

                on_conference_joined_private = on_conference_joined;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_conference_joined_private);
                linphone_chat_room_cbs_set_conference_joined(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_device_fetch_requested(IntPtr thiz, IntPtr cb);


        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantDeviceFetchRequestedDelegatePrivate(IntPtr cr, IntPtr participantAddr);

        public delegate void OnParticipantDeviceFetchRequestedDelegate(ChatRoom cr, Address participantAddr);
        private OnParticipantDeviceFetchRequestedDelegatePrivate on_participant_device_fetch_requested_private;
        private OnParticipantDeviceFetchRequestedDelegate on_participant_device_fetch_requested_public;

        private static void on_participant_device_fetch_requested(IntPtr cr, IntPtr participantAddr)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_device_fetch_requested_public?.Invoke(thiz, fromNativePtr<Address>(participantAddr));
        }

        public OnParticipantDeviceFetchRequestedDelegate OnParticipantDeviceFetchRequested
        {
            get
            {
                return on_participant_device_fetch_requested_public;
            }
            set
            {
                on_participant_device_fetch_requested_public = value;
                on_participant_device_fetch_requested_private = on_participant_device_fetch_requested;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_device_fetch_requested_private);
                linphone_chat_room_cbs_set_participant_device_fetch_requested(nativePtr, cb);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_chat_room_cbs_set_participant_device_added(IntPtr thiz, IntPtr cb);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void OnParticipantDeviceAddedDelegatePrivate(IntPtr cr, IntPtr eventLog);

        public delegate void OnParticipantDeviceAddedDelegate(ChatRoom cr, EventLog eventLog);
        private OnParticipantDeviceAddedDelegatePrivate on_participant_device_added_private;
        private OnParticipantDeviceAddedDelegate on_participant_device_added_public;

        private static void on_participant_device_added(IntPtr cr, IntPtr eventLog)
        {
            ChatRoom thiz = fromNativePtr<ChatRoom>(cr);

            ChatRoomListener listener = thiz.CurrentCallbacks;
            listener.on_participant_device_added_public?.Invoke(thiz, fromNativePtr<EventLog>(eventLog));
        }

        public OnParticipantDeviceAddedDelegate OnParticipantDeviceAdded
        {
            get
            {
                return on_participant_device_added_public;
            }
            set
            {
                on_participant_device_added_public = value;

                on_participant_device_added_private = on_participant_device_added;
                IntPtr cb = Marshal.GetFunctionPointerForDelegate(on_participant_device_added_private);
                linphone_chat_room_cbs_set_participant_device_added(nativePtr, cb);
            }
        }
    }
}
