using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper
{
    public enum OrtpLogLevel
    {
        DEBUG = 1,
        TRACE = 1 << 1,
        MESSAGE = 1 << 2,
        WARNING = 1 << 3,
        ERROR = 1 << 4,
        FATAL = 1 << 5,
        END = 1 << 6
    };

    /// <summary>
    /// Enum describing RTP AVPF activation modes. 
    /// </summary>
    public enum AVPFMode
    {
        /// <summary>
        /// Use default value defined at upper level. 
        /// </summary>
        Default = -1,
        /// <summary>
        /// AVPF is disabled. 
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// AVPF is enabled. 
        /// </summary>
        Enabled = 1,
    }

    /// <summary>
    /// Enum describing Activation code checking. 
    /// </summary>
    public enum AccountCreatorActivationCodeStatus
    {
        /// <summary>
        /// Activation code ok. 
        /// </summary>
        Ok = 0,
        /// <summary>
        /// Activation code too short. 
        /// </summary>
        TooShort = 1,
        /// <summary>
        /// Activation code too long. 
        /// </summary>
        TooLong = 2,
        /// <summary>
        /// Contain invalid characters. 
        /// </summary>
        InvalidCharacters = 3,
    }

    /// <summary>
    /// Enum describing Domain checking. 
    /// </summary>
    public enum AccountCreatorDomainStatus
    {
        /// <summary>
        /// Domain ok. 
        /// </summary>
        Ok = 0,
        /// <summary>
        /// Domain invalid. 
        /// </summary>
        Invalid = 1,
    }

    /// <summary>
    /// Enum describing Email checking. 
    /// </summary>
    public enum AccountCreatorEmailStatus
    {
        /// <summary>
        /// Email ok. 
        /// </summary>
        Ok = 0,
        /// <summary>
        /// Email malformed. 
        /// </summary>
        Malformed = 1,
        /// <summary>
        /// Contain invalid characters. 
        /// </summary>
        InvalidCharacters = 2,
    }

    /// <summary>
    /// Enum describing language checking. 
    /// </summary>
    public enum AccountCreatorLanguageStatus
    {
        /// <summary>
        /// Language ok. 
        /// </summary>
        Ok = 0,
    }

    /// <summary>
    /// Enum describing Password checking. 
    /// </summary>
    public enum AccountCreatorPasswordStatus
    {
        /// <summary>
        /// Password ok. 
        /// </summary>
        Ok = 0,
        /// <summary>
        /// Password too short. 
        /// </summary>
        TooShort = 1,
        /// <summary>
        /// Password too long. 
        /// </summary>
        TooLong = 2,
        /// <summary>
        /// Contain invalid characters. 
        /// </summary>
        InvalidCharacters = 3,
        /// <summary>
        /// Missing specific characters. 
        /// </summary>
        MissingCharacters = 4,
    }

    /// <summary>
    /// Enum describing Phone number checking. 
    /// </summary>
    public enum AccountCreatorPhoneNumberStatus
    {
        /// <summary>
        /// Phone number ok. 
        /// </summary>
        Ok = 1,
        /// <summary>
        /// Phone number too short. 
        /// </summary>
        TooShort = 2,
        /// <summary>
        /// Phone number too long. 
        /// </summary>
        TooLong = 4,
        /// <summary>
        /// Country code invalid. 
        /// </summary>
        InvalidCountryCode = 8,
        /// <summary>
        /// Phone number invalid. 
        /// </summary>
        Invalid = 16,
    }

    /// <summary>
    /// Enum describing the status of server request. 
    /// </summary>
    public enum AccountCreatorStatus
    {
        /// <summary>
        /// Request status. 
        /// </summary>
        RequestOk = 0,
        /// <summary>
        /// Request failed. 
        /// </summary>
        RequestFailed = 1,
        /// <summary>
        /// Request failed due to missing argument(s) 
        /// </summary>
        MissingArguments = 2,
        /// <summary>
        /// Request failed due to missing callback(s) 
        /// </summary>
        MissingCallbacks = 3,
        /// <summary>
        /// Account status. 
        /// </summary>
        AccountCreated = 4,
        /// <summary>
        /// Account not created. 
        /// </summary>
        AccountNotCreated = 5,
        /// <summary>
        /// Account exist. 
        /// </summary>
        AccountExist = 6,
        /// <summary>
        /// Account exist with alias. 
        /// </summary>
        AccountExistWithAlias = 7,
        /// <summary>
        /// Account not exist. 
        /// </summary>
        AccountNotExist = 8,
        /// <summary>
        /// Account was created with Alias. 
        /// </summary>
        AliasIsAccount = 9,
        /// <summary>
        /// Alias exist. 
        /// </summary>
        AliasExist = 10,
        /// <summary>
        /// Alias not exist. 
        /// </summary>
        AliasNotExist = 11,
        /// <summary>
        /// Account activated. 
        /// </summary>
        AccountActivated = 12,
        /// <summary>
        /// Account already activated. 
        /// </summary>
        AccountAlreadyActivated = 13,
        /// <summary>
        /// Account not activated. 
        /// </summary>
        AccountNotActivated = 14,
        /// <summary>
        /// Account linked. 
        /// </summary>
        AccountLinked = 15,
        /// <summary>
        /// Account not linked. 
        /// </summary>
        AccountNotLinked = 16,
        /// <summary>
        /// Server. 
        /// </summary>
        ServerError = 17,
    }

    /// <summary>
    /// Enum describing Transport checking. 
    /// </summary>
    public enum AccountCreatorTransportStatus
    {
        /// <summary>
        /// Transport ok. 
        /// </summary>
        Ok = 0,
        /// <summary>
        /// Transport invalid. 
        /// </summary>
        Unsupported = 1,
    }

    /// <summary>
    /// Enum describing Username checking. 
    /// </summary>
    public enum AccountCreatorUsernameStatus
    {
        /// <summary>
        /// Username ok. 
        /// </summary>
        Ok = 0,
        /// <summary>
        /// Username too short. 
        /// </summary>
        TooShort = 1,
        /// <summary>
        /// Username too long. 
        /// </summary>
        TooLong = 2,
        /// <summary>
        /// Contain invalid characters. 
        /// </summary>
        InvalidCharacters = 3,
        /// <summary>
        /// Invalid username. 
        /// </summary>
        Invalid = 4,
    }

    /// <summary>
    /// Enum describing Ip family. 
    /// </summary>
    public enum AddressFamily
    {
        /// <summary>
        /// IpV4. 
        /// </summary>
        Inet = 0,
        /// <summary>
        /// IpV6. 
        /// </summary>
        Inet6 = 1,
        /// <summary>
        /// Unknown. 
        /// </summary>
        Unspec = 2,
    }

    /// <summary>
    /// Enum describing type of audio route. 
    /// </summary>
    public enum AudioRoute
    {
        Earpiece = 0,
        Speaker = 1,
    }

    /// <summary>
    /// Enum describing the authentication methods. 
    /// </summary>
    public enum AuthMethod
    {
        /// <summary>
        /// Digest authentication requested. 
        /// </summary>
        HttpDigest = 0,
        /// <summary>
        /// Client certificate requested. 
        /// </summary>
        Tls = 1,
    }

    /// <summary>
    /// Enum representing the direction of a call. 
    /// </summary>
    public enum CallDir
    {
        /// <summary>
        /// outgoing calls 
        /// </summary>
        Outgoing = 0,
        /// <summary>
        /// incoming calls 
        /// </summary>
        Incoming = 1,
    }

    /// <summary>
    /// LinphoneCallState enum represents the different state a call can reach into. 
    /// </summary>
    public enum CallState
    {
        /// <summary>
        /// Initial state. 
        /// </summary>
        Idle = 0,
        /// <summary>
        /// Incoming call received. 
        /// </summary>
        IncomingReceived = 1,
        /// <summary>
        /// Outgoing call initialized. 
        /// </summary>
        OutgoingInit = 2,
        /// <summary>
        /// Outgoing call in progress. 
        /// </summary>
        OutgoingProgress = 3,
        /// <summary>
        /// Outgoing call ringing. 
        /// </summary>
        OutgoingRinging = 4,
        /// <summary>
        /// Outgoing call early media. 
        /// </summary>
        OutgoingEarlyMedia = 5,
        /// <summary>
        /// Connected. 
        /// </summary>
        Connected = 6,
        /// <summary>
        /// Streams running. 
        /// </summary>
        StreamsRunning = 7,
        /// <summary>
        /// Pausing. 
        /// </summary>
        Pausing = 8,
        /// <summary>
        /// Paused. 
        /// </summary>
        Paused = 9,
        /// <summary>
        /// Resuming. 
        /// </summary>
        Resuming = 10,
        /// <summary>
        /// Referred. 
        /// </summary>
        Referred = 11,
        /// <summary>
        /// Error. 
        /// </summary>
        Error = 12,
        /// <summary>
        /// Call end. 
        /// </summary>
        End = 13,
        /// <summary>
        /// Paused by remote. 
        /// </summary>
        PausedByRemote = 14,
        /// <summary>
        /// The call's parameters are updated for example when video is asked by remote. 
        /// </summary>
        UpdatedByRemote = 15,
        /// <summary>
        /// We are proposing early media to an incoming call. 
        /// </summary>
        IncomingEarlyMedia = 16,
        /// <summary>
        /// We have initiated a call update. 
        /// </summary>
        Updating = 17,
        /// <summary>
        /// The call object is now released. 
        /// </summary>
        Released = 18,
        /// <summary>
        /// The call is updated by remote while not yet answered (SIP UPDATE in early
        /// dialog received) 
        /// </summary>
        EarlyUpdatedByRemote = 19,
        /// <summary>
        /// We are updating the call while not yet answered (SIP UPDATE in early dialog
        /// sent) 
        /// </summary>
        EarlyUpdating = 20,
    }

    /// <summary>
    /// Enum representing the status of a call. 
    /// </summary>
    public enum CallStatus
    {
        /// <summary>
        /// The call was sucessful. 
        /// </summary>
        Success = 0,
        /// <summary>
        /// The call was aborted. 
        /// </summary>
        Aborted = 1,
        /// <summary>
        /// The call was missed (unanswered) 
        /// </summary>
        Missed = 2,
        /// <summary>
        /// The call was declined, either locally or by remote end. 
        /// </summary>
        Declined = 3,
        /// <summary>
        /// The call was aborted before being advertised to the application - for protocol
        /// reasons. 
        /// </summary>
        EarlyAborted = 4,
        /// <summary>
        /// The call was answered on another device. 
        /// </summary>
        AcceptedElsewhere = 5,
        /// <summary>
        /// The call was declined on another device. 
        /// </summary>
        DeclinedElsewhere = 6,
    }

    /// <summary>
    /// LinphoneChatMessageDirection is used to indicate if a message is outgoing or
    /// incoming. 
    /// </summary>
    public enum ChatMessageDirection
    {
        /// <summary>
        /// Incoming message. 
        /// </summary>
        Incoming = 0,
        /// <summary>
        /// Outgoing message. 
        /// </summary>
        Outgoing = 1,
    }

    /// <summary>
    /// LinphoneChatMessageState is used to notify if messages have been succesfully
    /// delivered or not. 
    /// </summary>
    public enum ChatMessageState
    {
        /// <summary>
        /// Initial state. 
        /// </summary>
        Idle = 0,
        /// <summary>
        /// Delivery in progress. 
        /// </summary>
        InProgress = 1,
        /// <summary>
        /// Message successfully delivered and acknowledged by the server. 
        /// </summary>
        Delivered = 2,
        /// <summary>
        /// Message was not delivered. 
        /// </summary>
        NotDelivered = 3,
        /// <summary>
        /// Message was received and acknowledged but cannot get file from server. 
        /// </summary>
        FileTransferError = 4,
        /// <summary>
        /// File transfer has been completed successfully. 
        /// </summary>
        FileTransferDone = 5,
        /// <summary>
        /// Message successfully delivered an acknowledged by the remote user. 
        /// </summary>
        DeliveredToUser = 6,
        /// <summary>
        /// Message successfully displayed to the remote user. 
        /// </summary>
        Displayed = 7,
    }

    /// <summary>
    /// LinphoneChatRoomCapabilities is used to indicated the capabilities of a chat
    /// room. 
    /// </summary>
    public enum ChatRoomCapabilities
    {
        /// <summary>
        /// No server. 
        /// </summary>
        Basic = 0,
        /// <summary>
        /// Supports RTT. 
        /// </summary>
        RealTimeText = 1,
        /// <summary>
        /// Use server (supports group chat) 
        /// </summary>
        Conference = 2,
        /// <summary>
        /// Special proxy chat room flag. 
        /// </summary>
        Proxy = 3,
        /// <summary>
        /// Chat room migratable from Basic to Conference. 
        /// </summary>
        Migratable = 4,
        /// <summary>
        /// A communication between two participants (can be Basic or Conference) 
        /// </summary>
        OneToOne = 5,
    }

    /// <summary>
    /// LinphoneChatRoomState is used to indicate the current state of a chat room. 
    /// </summary>
    public enum ChatRoomState
    {
        /// <summary>
        /// Initial state. 
        /// </summary>
        None = 0,
        /// <summary>
        /// Chat room is now instantiated on local. 
        /// </summary>
        Instantiated = 1,
        /// <summary>
        /// One creation request was sent to the server. 
        /// </summary>
        CreationPending = 2,
        /// <summary>
        /// Chat room was created on the server. 
        /// </summary>
        Created = 3,
        /// <summary>
        /// Chat room creation failed. 
        /// </summary>
        CreationFailed = 4,
        /// <summary>
        /// Wait for chat room termination. 
        /// </summary>
        TerminationPending = 5,
        /// <summary>
        /// Chat room exists on server but not in local. 
        /// </summary>
        Terminated = 6,
        /// <summary>
        /// The chat room termination failed. 
        /// </summary>
        TerminationFailed = 7,
        /// <summary>
        /// Chat room was deleted on the server. 
        /// </summary>
        Deleted = 8,
    }

    /// <summary>
    /// LinphoneGlobalState describes the global state of the <see cref="Linphone.Core"
    /// /> object. 
    /// </summary>
    public enum ConfiguringState
    {
        Successful = 0,
        Failed = 1,
        Skipped = 2,
    }

    /// <summary>
    /// Consolidated presence information: 'online' means the user is open for
    /// communication, 'busy' means the user is open for communication but involved in
    /// an other activity, 'do not disturb' means the user is not open for
    /// communication, and 'offline' means that no presence information is available. 
    /// </summary>
    public enum ConsolidatedPresence
    {
        Online = 0,
        Busy = 1,
        DoNotDisturb = 2,
        Offline = 3,
    }

    /// <summary>
    /// LinphoneCoreLogCollectionUploadState is used to notify if log collection upload
    /// have been succesfully delivered or not. 
    /// </summary>
    public enum CoreLogCollectionUploadState
    {
        /// <summary>
        /// Delivery in progress. 
        /// </summary>
        InProgress = 0,
        /// <summary>
        /// Log collection upload successfully delivered and acknowledged by remote end
        /// point. 
        /// </summary>
        Delivered = 1,
        /// <summary>
        /// Log collection upload was not delivered. 
        /// </summary>
        NotDelivered = 2,
    }

    /// <summary>
    /// Enum describing the result of the echo canceller calibration process. 
    /// </summary>
    public enum EcCalibratorStatus
    {
        /// <summary>
        /// The echo canceller calibration process is on going. 
        /// </summary>
        InProgress = 0,
        /// <summary>
        /// The echo canceller calibration has been performed and produced an echo delay
        /// measure. 
        /// </summary>
        Done = 1,
        /// <summary>
        /// The echo canceller calibration process has failed. 
        /// </summary>
        Failed = 2,
        /// <summary>
        /// The echo canceller calibration has been performed and no echo has been
        /// detected. 
        /// </summary>
        DoneNoEcho = 3,
    }

    /// <summary>
    /// LinphoneEventLogType is used to indicate the type of an event. 
    /// </summary>
    public enum EventLogType
    {
        /// <summary>
        /// No defined event. 
        /// </summary>
        None = 0,
        /// <summary>
        /// Conference (created) event. 
        /// </summary>
        ConferenceCreated = 1,
        /// <summary>
        /// Conference (terminated) event. 
        /// </summary>
        ConferenceTerminated = 2,
        /// <summary>
        /// Conference call (start) event. 
        /// </summary>
        ConferenceCallStart = 3,
        /// <summary>
        /// Conference call (end) event. 
        /// </summary>
        ConferenceCallEnd = 4,
        /// <summary>
        /// Conference chat message event. 
        /// </summary>
        ConferenceChatMessage = 5,
        /// <summary>
        /// Conference participant (added) event. 
        /// </summary>
        ConferenceParticipantAdded = 6,
        /// <summary>
        /// Conference participant (removed) event. 
        /// </summary>
        ConferenceParticipantRemoved = 7,
        /// <summary>
        /// Conference participant (set admin) event. 
        /// </summary>
        ConferenceParticipantSetAdmin = 8,
        /// <summary>
        /// Conference participant (unset admin) event. 
        /// </summary>
        ConferenceParticipantUnsetAdmin = 9,
        /// <summary>
        /// Conference participant device (added) event. 
        /// </summary>
        ConferenceParticipantDeviceAdded = 10,
        /// <summary>
        /// Conference participant device (removed) event. 
        /// </summary>
        ConferenceParticipantDeviceRemoved = 11,
        /// <summary>
        /// Conference subject event. 
        /// </summary>
        ConferenceSubjectChanged = 12,
    }

    /// <summary>
    /// Enum describing the status of a LinphoneFriendList operation. 
    /// </summary>
    public enum FriendListStatus
    {
        OK = 0,
        NonExistentFriend = 1,
        InvalidFriend = 2,
    }

    /// <summary>
    /// Enum describing the status of a CardDAV synchronization. 
    /// </summary>
    public enum FriendListSyncStatus
    {
        Started = 0,
        Successful = 1,
        Failure = 2,
    }

    /// <summary>
    /// LinphoneGlobalState describes the global state of the <see cref="Linphone.Core"
    /// /> object. 
    /// </summary>
    public enum GlobalState
    {
        Off = 0,
        Startup = 1,
        On = 2,
        Shutdown = 3,
        Configuring = 4,
    }

    /// <summary>
    /// Enum describing ICE states. 
    /// </summary>
    public enum IceState
    {
        /// <summary>
        /// ICE has not been activated for this call or stream. 
        /// </summary>
        NotActivated = 0,
        /// <summary>
        /// ICE processing has failed. 
        /// </summary>
        Failed = 1,
        /// <summary>
        /// ICE process is in progress. 
        /// </summary>
        InProgress = 2,
        /// <summary>
        /// ICE has established a direct connection to the remote host. 
        /// </summary>
        HostConnection = 3,
        /// <summary>
        /// ICE has established a connection to the remote host through one or several
        /// NATs. 
        /// </summary>
        ReflexiveConnection = 4,
        /// <summary>
        /// ICE has established a connection through a relay. 
        /// </summary>
        RelayConnection = 5,
    }

    public enum LimeState
    {
        /// <summary>
        /// Lime is not used at all. 
        /// </summary>
        Disabled = 0,
        /// <summary>
        /// Lime is always used. 
        /// </summary>
        Mandatory = 1,
        /// <summary>
        /// Lime is used only if we already shared a secret with remote. 
        /// </summary>
        Preferred = 2,
    }

    public enum LogCollectionState
    {
        Disabled = 0,
        Enabled = 1,
        EnabledWithoutPreviousLogHandler = 2,
    }

    /// <summary>
    /// Verbosity levels of log messages. 
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Level for debug messages. 
        /// </summary>
        Debug = 1,
        /// <summary>
        /// Level for traces. 
        /// </summary>
        Trace = 2,
        /// <summary>
        /// Level for information messages. 
        /// </summary>
        Message = 3,
        /// <summary>
        /// Level for warning messages. 
        /// </summary>
        Warning = 4,
        /// <summary>
        /// Level for error messages. 
        /// </summary>
        Error = 5,
        /// <summary>
        /// Level for fatal error messages. 
        /// </summary>
        Fatal = 6,
    }

    /// <summary>
    /// Indicates for a given media the stream direction. 
    /// </summary>
    public enum MediaDirection
    {
        Invalid = -1,
        Inactive = 0,
        /// <summary>
        /// No active media not supported yet. 
        /// </summary>
        SendOnly = 1,
        /// <summary>
        /// Send only mode. 
        /// </summary>
        RecvOnly = 2,
        /// <summary>
        /// recv only mode 
        /// </summary>
        SendRecv = 3,
    }

    /// <summary>
    /// Enum describing type of media encryption types. 
    /// </summary>
    public enum MediaEncryption
    {
        /// <summary>
        /// No media encryption is used. 
        /// </summary>
        None = 0,
        /// <summary>
        /// Use SRTP media encryption. 
        /// </summary>
        SRTP = 1,
        /// <summary>
        /// Use ZRTP media encryption. 
        /// </summary>
        ZRTP = 2,
        /// <summary>
        /// Use DTLS media encryption. 
        /// </summary>
        DTLS = 3,
    }

    /// <summary>
    /// The state of a LinphonePlayer. 
    /// </summary>
    public enum PlayerState
    {
        /// <summary>
        /// No file is opened for playing. 
        /// </summary>
        Closed = 0,
        /// <summary>
        /// The player is paused. 
        /// </summary>
        Paused = 1,
        /// <summary>
        /// The player is playing. 
        /// </summary>
        Playing = 2,
    }

    /// <summary>
    /// Activities as defined in section 3.2 of RFC 4480. 
    /// </summary>
    public enum PresenceActivityType
    {
        /// <summary>
        /// The person has a calendar appointment, without specifying exactly of what type. 
        /// </summary>
        Appointment = 0,
        /// <summary>
        /// The person is physically away from all interactive communication devices. 
        /// </summary>
        Away = 1,
        /// <summary>
        /// The person is eating the first meal of the day, usually eaten in the morning. 
        /// </summary>
        Breakfast = 2,
        /// <summary>
        /// The person is busy, without further details. 
        /// </summary>
        Busy = 3,
        /// <summary>
        /// The person is having his or her main meal of the day, eaten in the evening or
        /// at midday. 
        /// </summary>
        Dinner = 4,
        /// <summary>
        /// This is a scheduled national or local holiday. 
        /// </summary>
        Holiday = 5,
        /// <summary>
        /// The person is riding in a vehicle, such as a car, but not steering. 
        /// </summary>
        InTransit = 6,
        /// <summary>
        /// The person is looking for (paid) work. 
        /// </summary>
        LookingForWork = 7,
        /// <summary>
        /// The person is eating his or her midday meal. 
        /// </summary>
        Lunch = 8,
        /// <summary>
        /// The person is scheduled for a meal, without specifying whether it is breakfast,
        /// lunch, or dinner, or some other meal. 
        /// </summary>
        Meal = 9,
        /// <summary>
        /// The person is in an assembly or gathering of people, as for a business, social,
        /// or religious purpose. 
        /// </summary>
        Meeting = 10,
        /// <summary>
        /// The person is talking on the telephone. 
        /// </summary>
        OnThePhone = 11,
        /// <summary>
        /// The person is engaged in an activity with no defined representation. 
        /// </summary>
        Other = 12,
        /// <summary>
        /// A performance is a sub-class of an appointment and includes musical,
        /// theatrical, and cinematic performances as well as lectures. 
        /// </summary>
        Performance = 13,
        /// <summary>
        /// The person will not return for the foreseeable future, e.g., because it is no
        /// longer working for the company. 
        /// </summary>
        PermanentAbsence = 14,
        /// <summary>
        /// The person is occupying himself or herself in amusement, sport, or other
        /// recreation. 
        /// </summary>
        Playing = 15,
        /// <summary>
        /// The person is giving a presentation, lecture, or participating in a formal
        /// round-table discussion. 
        /// </summary>
        Presentation = 16,
        /// <summary>
        /// The person is visiting stores in search of goods or services. 
        /// </summary>
        Shopping = 17,
        /// <summary>
        /// The person is sleeping. 
        /// </summary>
        Sleeping = 18,
        /// <summary>
        /// The person is observing an event, such as a sports event. 
        /// </summary>
        Spectator = 19,
        /// <summary>
        /// The person is controlling a vehicle, watercraft, or plane. 
        /// </summary>
        Steering = 20,
        /// <summary>
        /// The person is on a business or personal trip, but not necessarily in-transit. 
        /// </summary>
        Travel = 21,
        /// <summary>
        /// The person is watching television. 
        /// </summary>
        TV = 22,
        /// <summary>
        /// The activity of the person is unknown. 
        /// </summary>
        Unknown = 23,
        /// <summary>
        /// A period of time devoted to pleasure, rest, or relaxation. 
        /// </summary>
        Vacation = 24,
        /// <summary>
        /// The person is engaged in, typically paid, labor, as part of a profession or
        /// job. 
        /// </summary>
        Working = 25,
        /// <summary>
        /// The person is participating in religious rites. 
        /// </summary>
        Worship = 26,
    }

    /// <summary>
    /// Basic status as defined in section 4.1.4 of RFC 3863. 
    /// </summary>
    public enum PresenceBasicStatus
    {
        /// <summary>
        /// This value means that the associated contact element, if any, is ready to
        /// accept communication. 
        /// </summary>
        Open = 0,
        /// <summary>
        /// This value means that the associated contact element, if any, is unable to
        /// accept communication. 
        /// </summary>
        Closed = 1,
    }

    /// <summary>
    /// Defines privacy policy to apply as described by rfc3323. 
    /// </summary>
    public enum Privacy
    {
        /// <summary>
        /// Privacy services must not perform any privacy function. 
        /// </summary>
        None = 0,
        /// <summary>
        /// Request that privacy services provide a user-level privacy function. 
        /// </summary>
        User = 1,
        /// <summary>
        /// Request that privacy services modify headers that cannot be set arbitrarily by
        /// the user (Contact/Via). 
        /// </summary>
        Header = 2,
        /// <summary>
        /// Request that privacy services provide privacy for session media. 
        /// </summary>
        Session = 4,
        /// <summary>
        /// rfc3325 The presence of this privacy type in a Privacy header field indicates
        /// that the user would like the Network Asserted Identity to be kept private with
        /// respect to SIP entities outside the Trust Domain with which the user
        /// authenticated. 
        /// </summary>
        Id = 8,
        /// <summary>
        /// Privacy service must perform the specified services or fail the request. 
        /// </summary>
        Critical = 16,
        /// <summary>
        /// Special keyword to use privacy as defined either globally or by proxy using
        /// <see cref="Linphone.ProxyConfig.SetPrivacy()" /> 
        /// </summary>
        Default = 32768,
    }

    /// <summary>
    /// Enum for publish states. 
    /// </summary>
    public enum PublishState
    {
        /// <summary>
        /// Initial state, do not use. 
        /// </summary>
        None = 0,
        /// <summary>
        /// An outgoing publish was created and submitted. 
        /// </summary>
        Progress = 1,
        /// <summary>
        /// Publish is accepted. 
        /// </summary>
        Ok = 2,
        /// <summary>
        /// Publish encoutered an error, <see cref="Linphone.Event.GetReason()" /> gives
        /// reason code. 
        /// </summary>
        Error = 3,
        /// <summary>
        /// Publish is about to expire, only sent if [sip]->refresh_generic_publish
        /// property is set to 0. 
        /// </summary>
        Expiring = 4,
        /// <summary>
        /// Event has been un published. 
        /// </summary>
        Cleared = 5,
    }

    /// <summary>
    /// Enum describing various failure reasons or contextual information for some
    /// events. 
    /// </summary>
    public enum Reason
    {
        /// <summary>
        /// No reason has been set by the core. 
        /// </summary>
        None = 0,
        /// <summary>
        /// No response received from remote. 
        /// </summary>
        NoResponse = 1,
        /// <summary>
        /// Authentication failed due to bad credentials or resource forbidden. 
        /// </summary>
        Forbidden = 2,
        /// <summary>
        /// The call has been declined. 
        /// </summary>
        Declined = 3,
        /// <summary>
        /// Destination of the call was not found. 
        /// </summary>
        NotFound = 4,
        /// <summary>
        /// The call was not answered in time (request timeout) 
        /// </summary>
        NotAnswered = 5,
        /// <summary>
        /// Phone line was busy. 
        /// </summary>
        Busy = 6,
        /// <summary>
        /// Unsupported content. 
        /// </summary>
        UnsupportedContent = 7,
        /// <summary>
        /// Transport error: connection failures, disconnections etc... 
        /// </summary>
        IOError = 8,
        /// <summary>
        /// Do not disturb reason. 
        /// </summary>
        DoNotDisturb = 9,
        /// <summary>
        /// Operation is unauthorized because missing credential. 
        /// </summary>
        Unauthorized = 10,
        /// <summary>
        /// Operation is rejected due to incompatible or unsupported media parameters. 
        /// </summary>
        NotAcceptable = 11,
        /// <summary>
        /// Operation could not be executed by server or remote client because it didn't
        /// have any context for it. 
        /// </summary>
        NoMatch = 12,
        /// <summary>
        /// Resource moved permanently. 
        /// </summary>
        MovedPermanently = 13,
        /// <summary>
        /// Resource no longer exists. 
        /// </summary>
        Gone = 14,
        /// <summary>
        /// Temporarily unavailable. 
        /// </summary>
        TemporarilyUnavailable = 15,
        /// <summary>
        /// Address incomplete. 
        /// </summary>
        AddressIncomplete = 16,
        /// <summary>
        /// Not implemented. 
        /// </summary>
        NotImplemented = 17,
        /// <summary>
        /// Bad gateway. 
        /// </summary>
        BadGateway = 18,
        /// <summary>
        /// Server timeout. 
        /// </summary>
        ServerTimeout = 19,
        /// <summary>
        /// Unknown reason. 
        /// </summary>
        Unknown = 20,
    }

    /// <summary>
    /// LinphoneRegistrationState describes proxy registration states. 
    /// </summary>
    public enum RegistrationState
    {
        /// <summary>
        /// Initial state for registrations. 
        /// </summary>
        None = 0,
        /// <summary>
        /// Registration is in progress. 
        /// </summary>
        Progress = 1,
        /// <summary>
        /// Registration is successful. 
        /// </summary>
        Ok = 2,
        /// <summary>
        /// Unregistration succeeded. 
        /// </summary>
        Cleared = 3,
        /// <summary>
        /// Registration failed. 
        /// </summary>
        Failed = 4,
    }

    /// <summary>
    /// Enum describing the stream types. 
    /// </summary>
    public enum StreamType
    {
        Audio = 0,
        Video = 1,
        Text = 2,
        Unknown = 3,
    }

    /// <summary>
    /// Enum controlling behavior for incoming subscription request. 
    /// </summary>
    public enum SubscribePolicy
    {
        /// <summary>
        /// Does not automatically accept an incoming subscription request. 
        /// </summary>
        SPWait = 0,
        /// <summary>
        /// Rejects incoming subscription request. 
        /// </summary>
        SPDeny = 1,
        /// <summary>
        /// Automatically accepts a subscription request. 
        /// </summary>
        SPAccept = 2,
    }

    /// <summary>
    /// Enum for subscription direction (incoming or outgoing). 
    /// </summary>
    public enum SubscriptionDir
    {
        /// <summary>
        /// Incoming subscription. 
        /// </summary>
        Incoming = 0,
        /// <summary>
        /// Outgoing subscription. 
        /// </summary>
        Outgoing = 1,
        /// <summary>
        /// Invalid subscription direction. 
        /// </summary>
        InvalidDir = 2,
    }

    /// <summary>
    /// Enum for subscription states. 
    /// </summary>
    public enum SubscriptionState
    {
        /// <summary>
        /// Initial state, should not be used. 
        /// </summary>
        None = 0,
        /// <summary>
        /// An outgoing subcription was sent. 
        /// </summary>
        OutgoingProgress = 1,
        /// <summary>
        /// An incoming subcription is received. 
        /// </summary>
        IncomingReceived = 2,
        /// <summary>
        /// Subscription is pending, waiting for user approval. 
        /// </summary>
        Pending = 3,
        /// <summary>
        /// Subscription is accepted. 
        /// </summary>
        Active = 4,
        /// <summary>
        /// Subscription is terminated normally. 
        /// </summary>
        Terminated = 5,
        /// <summary>
        /// Subscription was terminated by an error, indicated by <see
        /// cref="Linphone.Event.GetReason()" /> 
        /// </summary>
        Error = 6,
        /// <summary>
        /// Subscription is about to expire, only sent if [sip]->refresh_generic_subscribe
        /// property is set to 0. 
        /// </summary>
        Expiring = 7,
    }

    /// <summary>
    /// Enum listing frequent telephony tones. 
    /// </summary>
    public enum ToneID
    {
        /// <summary>
        /// Not a tone. 
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// Busy tone. 
        /// </summary>
        Busy = 1,
        CallWaiting = 2,
        /// <summary>
        /// Call waiting tone. 
        /// </summary>
        CallOnHold = 3,
        /// <summary>
        /// Call on hold tone. 
        /// </summary>
        CallLost = 4,
    }

    /// <summary>
    /// Enum describing transport type for LinphoneAddress. 
    /// </summary>
    public enum TransportType
    {
        Udp = 0,
        Tcp = 1,
        Tls = 2,
        Dtls = 3,
    }

    /// <summary>
    /// Enum describing the tunnel modes. 
    /// </summary>
    public enum TunnelMode
    {
        /// <summary>
        /// The tunnel is disabled. 
        /// </summary>
        Disable = 0,
        /// <summary>
        /// The tunnel is enabled. 
        /// </summary>
        Enable = 1,
        /// <summary>
        /// The tunnel is enabled automatically if it is required. 
        /// </summary>
        Auto = 2,
    }

    /// <summary>
    /// Enum describing uPnP states. 
    /// </summary>
    public enum UpnpState
    {
        /// <summary>
        /// uPnP is not activate 
        /// </summary>
        Idle = 0,
        /// <summary>
        /// uPnP process is in progress 
        /// </summary>
        Pending = 1,
        /// <summary>
        /// Internal use: Only used by port binding. 
        /// </summary>
        Adding = 2,
        /// <summary>
        /// Internal use: Only used by port binding. 
        /// </summary>
        Removing = 3,
        /// <summary>
        /// uPnP is not available 
        /// </summary>
        NotAvailable = 4,
        /// <summary>
        /// uPnP is enabled 
        /// </summary>
        Ok = 5,
        /// <summary>
        /// uPnP processing has failed 
        /// </summary>
        Ko = 6,
        /// <summary>
        /// IGD router is blacklisted. 
        /// </summary>
        Blacklisted = 7,
    }

    /// <summary>
    /// Enum describing the result of a version update check. 
    /// </summary>
    public enum VersionUpdateCheckResult
    {
        UpToDate = 0,
        NewVersionAvailable = 1,
        Error = 2,
    }

    /// <summary>
    /// Enum describing the types of argument for LinphoneXmlRpcRequest. 
    /// </summary>
    public enum XmlRpcArgType
    {
        None = 0,
        Int = 1,
        String = 2,
    }

    /// <summary>
    /// Enum describing the status of a LinphoneXmlRpcRequest. 
    /// </summary>
    public enum XmlRpcStatus
    {
        Pending = 0,
        Ok = 1,
        Failed = 2,
    }
    
}
