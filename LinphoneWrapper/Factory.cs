using LinphoneWrapper.Listeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper
{
    /// <summary>
	/// <see cref="Factory" /> is a singleton object devoted to the creation
	/// of all the object of Liblinphone that cannot be created by <see
	/// cref="Core" /> itself. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
    public class Factory : LinphoneObject
    {
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_core_cbs(IntPtr factory);

        public CoreListener CreateCoreListener()
        {
            IntPtr coreCbsPtr = linphone_factory_create_core_cbs(nativePtr);
            return fromNativePtr<CoreListener>(coreCbsPtr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_clean();

        /// <summary>
        /// Clean the factory. 
        /// </summary>
        public static void Clean()
        {
            linphone_factory_clean();

        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get();

        /// <summary>
        /// Create the <see cref="Factory" /> if that has not been done and return
        /// a pointer on it. 
        /// </summary>
        static public Factory Instance
        {
            get
            {
                IntPtr ptr = linphone_factory_get();
                return fromNativePtr<Factory>(ptr, true);
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_data_resources_dir(IntPtr thiz);
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_set_data_resources_dir(IntPtr thiz, string path);

        /// <summary>
        /// Get the directory where the data resources are located. 
        /// </summary>
        public string DataResourcesDir
        {
            get
            {
                IntPtr stringPtr = linphone_factory_get_data_resources_dir(nativePtr);
                return Marshal.PtrToStringAnsi(stringPtr);
            }
            set
            {
                linphone_factory_set_data_resources_dir(nativePtr, value);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_dial_plans(IntPtr thiz);

        /// <summary>
        /// Returns a bctbx_list_t of all DialPlans. 
        /// </summary>
        public IEnumerable<DialPlan> DialPlans
        {
            get
            {
                return MarshalBctbxList<DialPlan>(linphone_factory_get_dial_plans(nativePtr));
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_image_resources_dir(IntPtr thiz);
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_set_image_resources_dir(IntPtr thiz, string path);

        /// <summary>
        /// Get the directory where the image resources are located. 
        /// </summary>
        public string ImageResourcesDir
        {
            get
            {
                IntPtr stringPtr = linphone_factory_get_image_resources_dir(nativePtr);
                return Marshal.PtrToStringAnsi(stringPtr);
            }
            set
            {
                linphone_factory_set_image_resources_dir(nativePtr, value);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_set_log_collection_path(IntPtr thiz, string path);

        /// <summary>
        /// Sets the log collection path. 
        /// </summary>
        public string LogCollectionPath
        {
            set
            {
                linphone_factory_set_log_collection_path(nativePtr, value);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_msplugins_dir(IntPtr thiz);
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_set_msplugins_dir(IntPtr thiz, string path);

        /// <summary>
        /// Get the directory where the mediastreamer2 plugins are located. 
        /// </summary>
        public string MspluginsDir
        {
            get
            {
                IntPtr stringPtr = linphone_factory_get_msplugins_dir(nativePtr);
                return Marshal.PtrToStringAnsi(stringPtr);
            }
            set
            {
                linphone_factory_set_msplugins_dir(nativePtr, value);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_ring_resources_dir(IntPtr thiz);
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_set_ring_resources_dir(IntPtr thiz, string path);

        /// <summary>
        /// Get the directory where the ring resources are located. 
        /// </summary>
        public string RingResourcesDir
        {
            get
            {
                IntPtr stringPtr = linphone_factory_get_ring_resources_dir(nativePtr);
                return Marshal.PtrToStringAnsi(stringPtr);
            }
            set
            {
                linphone_factory_set_ring_resources_dir(nativePtr, value);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_sound_resources_dir(IntPtr thiz);
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_set_sound_resources_dir(IntPtr thiz, string path);

        /// <summary>
        /// Get the directory where the sound resources are located. 
        /// </summary>
        public string SoundResourcesDir
        {
            get
            {
                IntPtr stringPtr = linphone_factory_get_sound_resources_dir(nativePtr);
                return Marshal.PtrToStringAnsi(stringPtr);
            }
            set
            {
                linphone_factory_set_sound_resources_dir(nativePtr, value);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_supported_video_definitions(IntPtr thiz);

        /// <summary>
        /// Get the list of standard video definitions supported by  
        /// </summary>
        public IEnumerable<VideoDefinition> SupportedVideoDefinitions
        {
            get
            {
                return MarshalBctbxList<VideoDefinition>(linphone_factory_get_supported_video_definitions(nativePtr));
            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_get_top_resources_dir(IntPtr thiz);
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_set_top_resources_dir(IntPtr thiz, string path);

        /// <summary>
        /// Get the top directory where the resources are located. 
        /// </summary>
        public string TopResourcesDir
        {
            get
            {
                IntPtr stringPtr = linphone_factory_get_top_resources_dir(nativePtr);
                return Marshal.PtrToStringAnsi(stringPtr);
            }
            set
            {
                linphone_factory_set_top_resources_dir(nativePtr, value);

            }
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_address(IntPtr thiz, string addr);

        /// <summary>
        /// Parse a string holding a SIP URI and create the according <see
        /// cref="Address" /> object. 
        /// </summary>
        public Address CreateAddress(string addr)
        {
            IntPtr ptr = linphone_factory_create_address(nativePtr, addr);
            return fromNativePtr<Address>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_auth_info(IntPtr thiz, string username, string userid, string passwd, string ha1, string realm, string domain);

        /// <summary>
        /// Creates a <see cref="AuthInfo" /> object. 
        /// </summary>
        public AuthInfo CreateAuthInfo(string username, string userid, string passwd, string ha1, string realm, string domain)
        {
            IntPtr ptr = linphone_factory_create_auth_info(nativePtr, username, userid, passwd, ha1, realm, domain);
            return fromNativePtr<AuthInfo>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_buffer(IntPtr thiz);

        /// <summary>
        /// Creates an object <see cref="Buffer" />. 
        /// </summary>
        public Buffer CreateBuffer()
        {
            IntPtr ptr = linphone_factory_create_buffer(nativePtr);
            return fromNativePtr<Buffer>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_buffer_from_data(IntPtr thiz, uint data, long size);

        /// <summary>
        /// Creates an object <see cref="Buffer" />. 
        /// </summary>
        public Buffer CreateBufferFromData(uint data, long size)
        {
            IntPtr ptr = linphone_factory_create_buffer_from_data(nativePtr, data, size);
            return fromNativePtr<Buffer>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_buffer_from_string(IntPtr thiz, string data);

        /// <summary>
        /// Creates an object <see cref="Buffer" />. 
        /// </summary>
        public Buffer CreateBufferFromString(string data)
        {
            IntPtr ptr = linphone_factory_create_buffer_from_string(nativePtr, data);
            return fromNativePtr<Buffer>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_config(IntPtr thiz, string path);

        /// <summary>
        /// Creates an object <see cref="Config" />. 
        /// </summary>
        public Config CreateConfig(string path)
        {
            IntPtr ptr = linphone_factory_create_config(nativePtr, path);
            return fromNativePtr<Config>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_config_from_string(IntPtr thiz, string data);

        /// <summary>
        /// Creates an object <see cref="Config" />. 
        /// </summary>
        public Config CreateConfigFromString(string data)
        {
            IntPtr ptr = linphone_factory_create_config_from_string(nativePtr, data);
            return fromNativePtr<Config>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_config_with_factory(IntPtr thiz, string path, string factoryPath);

        /// <summary>
        /// Creates an object <see cref="Config" />. 
        /// </summary>
        public Config CreateConfigWithFactory(string path, string factoryPath)
        {
            IntPtr ptr = linphone_factory_create_config_with_factory(nativePtr, path, factoryPath);
            return fromNativePtr<Config>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_content(IntPtr thiz);

        /// <summary>
        /// Creates an object <see cref="Content" />. 
        /// </summary>
        public Content CreateContent()
        {
            IntPtr ptr = linphone_factory_create_content(nativePtr);
            return fromNativePtr<Content>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_core(IntPtr thiz, IntPtr cbs, string configPath, string factoryConfigPath);

        /// <summary>
        /// Instanciate a <see cref="Core" /> object. 
        /// </summary>
        public Core CreateCore(CoreListener cbs, string configPath, string factoryConfigPath)
        {
            IntPtr ptr = linphone_factory_create_core(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero, configPath, factoryConfigPath);
            return fromNativePtr<Core>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_core_2(IntPtr thiz, IntPtr cbs, string configPath, string factoryConfigPath, IntPtr userData, IntPtr systemContext);

        /// <summary>
        /// Instanciate a <see cref="Core" /> object. 
        /// </summary>
        public Core CreateCore(CoreListener cbs, string configPath, string factoryConfigPath, IntPtr userData, IntPtr systemContext)
        {
            IntPtr ptr = linphone_factory_create_core_2(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero, configPath, factoryConfigPath, userData, systemContext);
            return fromNativePtr<Core>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_core_3(IntPtr thiz, string configPath, string factoryConfigPath, IntPtr systemContext);

        /// <summary>
        /// Instantiate a <see cref="Core" /> object. 
        /// </summary>
        public Core CreateCore(string configPath, string factoryConfigPath, IntPtr systemContext)
        {
            IntPtr ptr = linphone_factory_create_core_3(nativePtr, configPath, factoryConfigPath, systemContext);
            return fromNativePtr<Core>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_core_with_config_2(IntPtr thiz, IntPtr cbs, IntPtr config, IntPtr userData, IntPtr systemContext);

        /// <summary>
        /// Instantiates a <see cref="Core" /> object with a given LpConfig. 
        /// </summary>
        public Core CreateCoreWithConfig(CoreListener cbs, Config config, IntPtr userData, IntPtr systemContext)
        {
            IntPtr ptr = linphone_factory_create_core_with_config_2(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero, config != null ? config.nativePtr : IntPtr.Zero, userData, systemContext);
            return fromNativePtr<Core>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_core_with_config_3(IntPtr thiz, IntPtr config, IntPtr systemContext);

        /// <summary>
        /// Instantiate a <see cref="Core" /> object with a given LinphoneConfig. 
        /// </summary>
        public Core CreateCoreWithConfig(Config config, IntPtr systemContext)
        {
            IntPtr ptr = linphone_factory_create_core_with_config_3(nativePtr, config != null ? config.nativePtr : IntPtr.Zero, systemContext);
            return fromNativePtr<Core>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_core_with_config(IntPtr thiz, IntPtr cbs, IntPtr config);

        /// <summary>
        /// Instantiates a <see cref="Core" /> object with a given LpConfig. 
        /// </summary>
        public Core CreateCoreWithConfig(CoreListener cbs, Config config)
        {
            IntPtr ptr = linphone_factory_create_core_with_config(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero, config != null ? config.nativePtr : IntPtr.Zero);
            return fromNativePtr<Core>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_error_info(IntPtr thiz);

        /// <summary>
        /// Creates an object LinphoneErrorInfo. 
        /// </summary>
        public ErrorInfo CreateErrorInfo()
        {
            IntPtr ptr = linphone_factory_create_error_info(nativePtr);
            return fromNativePtr<ErrorInfo>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_range(IntPtr thiz);

        /// <summary>
        /// Creates an object LinphoneRange. 
        /// </summary>
        public Range CreateRange()
        {
            IntPtr ptr = linphone_factory_create_range(nativePtr);
            return fromNativePtr<Range>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_transports(IntPtr thiz);

        /// <summary>
        /// Creates an object LinphoneTransports. 
        /// </summary>
        public Transports CreateTransports()
        {
            IntPtr ptr = linphone_factory_create_transports(nativePtr);
            return fromNativePtr<Transports>(ptr, false);
        }

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_tunnel_config(IntPtr thiz);

        /// <summary>
        /// Creates an object <see cref="TunnelConfig" />. 
        /// </summary>
        public TunnelConfig CreateTunnelConfig()
        {
            IntPtr ptr = linphone_factory_create_tunnel_config(nativePtr);
            return fromNativePtr<TunnelConfig>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_vcard(IntPtr thiz);

        /// <summary>
        /// Create an empty <see cref="Vcard" />. 
        /// </summary>
        public Vcard CreateVcard()
        {
            IntPtr ptr = linphone_factory_create_vcard(nativePtr);
            return fromNativePtr<Vcard>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_video_activation_policy(IntPtr thiz);

        /// <summary>
        /// Creates an object LinphoneVideoActivationPolicy. 
        /// </summary>
        public VideoActivationPolicy CreateVideoActivationPolicy()
        {
            IntPtr ptr = linphone_factory_create_video_activation_policy(nativePtr);
            return fromNativePtr<VideoActivationPolicy>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_video_definition(IntPtr thiz, uint width, uint height);

        /// <summary>
        /// Create a <see cref="VideoDefinition" /> from a given width and height. 
        /// </summary>
        public VideoDefinition CreateVideoDefinition(uint width, uint height)
        {
            IntPtr ptr = linphone_factory_create_video_definition(nativePtr, width, height);
            return fromNativePtr<VideoDefinition>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_factory_create_video_definition_from_name(IntPtr thiz, string name);

        /// <summary>
        /// Create a <see cref="VideoDefinition" /> from a given standard
        /// definition name. 
        /// </summary>
        public VideoDefinition CreateVideoDefinitionFromName(string name)
        {
            IntPtr ptr = linphone_factory_create_video_definition_from_name(nativePtr, name);
            return fromNativePtr<VideoDefinition>(ptr, false);
        }
        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern void linphone_factory_enable_log_collection(IntPtr thiz, int state);

        /// <summary>
        /// Enables or disables log collection. 
        /// </summary>
        public void EnableLogCollection(LogCollectionState state)
        {
            linphone_factory_enable_log_collection(nativePtr, (int)state);

        }
    }
}
