using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using LinphoneWrapper.Listeners;

namespace LinphoneWrapper
{
	/// <summary>
	/// The <see cref="AccountCreator" /> object used to configure an account
	/// on a server via XML-RPC. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class AccountCreator : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_callbacks(IntPtr thiz);

		/// <summary>
		/// The <see cref="AccountCreator" /> object used to configure an account
		/// on a server via XML-RPC. 
		/// </summary>
		public AccountCreatorListener Listener
		{
			get
			{
				IntPtr ptr = linphone_account_creator_get_callbacks(nativePtr);
				return fromNativePtr<AccountCreatorListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_activation_code(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorActivationCodeStatus linphone_account_creator_set_activation_code(IntPtr thiz, string activationCode);

		/// <summary>
		/// Get the activation code. 
		/// </summary>
		public string ActivationCode
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_activation_code(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_activation_code(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_display_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorUsernameStatus linphone_account_creator_set_display_name(IntPtr thiz, string displayName);

		/// <summary>
		/// Get the display name. 
		/// </summary>
		public string DisplayName
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_display_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_display_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_domain(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorDomainStatus linphone_account_creator_set_domain(IntPtr thiz, string domain);

		/// <summary>
		/// Get the domain. 
		/// </summary>
		public string Domain
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_domain(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_domain(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_email(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorEmailStatus linphone_account_creator_set_email(IntPtr thiz, string email);

		/// <summary>
		/// Get the email. 
		/// </summary>
		public string Email
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_email(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_email(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_ha1(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorPasswordStatus linphone_account_creator_set_ha1(IntPtr thiz, string ha1);

		/// <summary>
		/// Get the ha1. 
		/// </summary>
		public string Ha1
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_ha1(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_ha1(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_language(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorLanguageStatus linphone_account_creator_set_language(IntPtr thiz, string lang);

		/// <summary>
		/// Get the language use in email of SMS. 
		/// </summary>
		public string Language
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_language(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_language(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_password(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorPasswordStatus linphone_account_creator_set_password(IntPtr thiz, string password);

		/// <summary>
		/// Get the password. 
		/// </summary>
		public string Password
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_password(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_password(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_phone_number(IntPtr thiz);

		/// <summary>
		/// Get the RFC 3966 normalized phone number. 
		/// </summary>
		public string PhoneNumber
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_phone_number(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_route(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_set_route(IntPtr thiz, string route);

		/// <summary>
		/// Get the route. 
		/// </summary>
		public string Route
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_route(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_route(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern TransportType linphone_account_creator_get_transport(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorTransportStatus linphone_account_creator_set_transport(IntPtr thiz, int transport);

		/// <summary>
		/// get Transport 
		/// </summary>
		public TransportType Transport
		{
			get
			{
				return linphone_account_creator_get_transport(nativePtr);
			}
			set
			{
				linphone_account_creator_set_transport(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_get_username(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorUsernameStatus linphone_account_creator_set_username(IntPtr thiz, string username);

		/// <summary>
		/// Get the username. 
		/// </summary>
		public string Username
		{
			get
			{
				IntPtr stringPtr = linphone_account_creator_get_username(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_account_creator_set_username(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_activate_account(IntPtr thiz);

		/// <summary>
		/// Send a request to activate an account on server. 
		/// </summary>
		public AccountCreatorStatus ActivateAccount()
		{
			return linphone_account_creator_activate_account(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_activate_alias(IntPtr thiz);

		/// <summary>
		/// Send a request to activate an alias. 
		/// </summary>
		public AccountCreatorStatus ActivateAlias()
		{
			return linphone_account_creator_activate_alias(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_configure(IntPtr thiz);

		/// <summary>
		/// Configure an account (create a proxy config and authentication info for it). 
		/// </summary>
		public ProxyConfig Configure()
		{
			IntPtr ptr = linphone_account_creator_configure(nativePtr);
			return fromNativePtr<ProxyConfig>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_create_account(IntPtr thiz);

		/// <summary>
		/// Send a request to create an account on server. 
		/// </summary>
		public AccountCreatorStatus CreateAccount()
		{
			return linphone_account_creator_create_account(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_account_creator_create_proxy_config(IntPtr thiz);

		/// <summary>
		/// Create and configure a proxy config and a authentication info for an account
		/// creator. 
		/// </summary>
		public ProxyConfig CreateProxyConfig()
		{
			IntPtr ptr = linphone_account_creator_create_proxy_config(nativePtr);
			return fromNativePtr<ProxyConfig>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_is_account_activated(IntPtr thiz);

		/// <summary>
		/// Send a request to know if an account is activated on server. 
		/// </summary>
		public AccountCreatorStatus IsAccountActivated()
		{
			return linphone_account_creator_is_account_activated(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_is_account_exist(IntPtr thiz);

		/// <summary>
		/// Send a request to know the existence of account on server. 
		/// </summary>
		public AccountCreatorStatus IsAccountExist()
		{
			return linphone_account_creator_is_account_exist(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_is_account_linked(IntPtr thiz);

		/// <summary>
		/// Send a request to know if an account is linked. 
		/// </summary>
		public AccountCreatorStatus IsAccountLinked()
		{
			return linphone_account_creator_is_account_linked(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_is_alias_used(IntPtr thiz);

		/// <summary>
		/// Send a request to know if an alias is used. 
		/// </summary>
		public AccountCreatorStatus IsAliasUsed()
		{
			return linphone_account_creator_is_alias_used(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_link_account(IntPtr thiz);

		/// <summary>
		/// Send a request to link an account to an alias. 
		/// </summary>
		public AccountCreatorStatus LinkAccount()
		{
			return linphone_account_creator_link_account(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_recover_account(IntPtr thiz);

		/// <summary>
		/// Send a request to recover an account. 
		/// </summary>
		public AccountCreatorStatus RecoverAccount()
		{
			return linphone_account_creator_recover_account(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_account_creator_reset(IntPtr thiz);

		/// <summary>
		/// Reset the account creator entries like username, password, phone number... 
		/// </summary>
		public void Reset()
		{
			linphone_account_creator_reset(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_account_creator_set_phone_number(IntPtr thiz, string phoneNumber, string countryCode);

		/// <summary>
		/// Set the phone number normalized. 
		/// </summary>
		public uint SetPhoneNumber(string phoneNumber, string countryCode)
		{
			return linphone_account_creator_set_phone_number(nativePtr, phoneNumber, countryCode);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AccountCreatorStatus linphone_account_creator_update_account(IntPtr thiz);

		/// <summary>
		/// Send a request to update an account. 
		/// </summary>
		public AccountCreatorStatus UpdateAccount()
		{
			return linphone_account_creator_update_account(nativePtr);
			
		}
	}

	/// <summary>
	/// Object that represents a SIP address. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Address : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_display_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_address_set_display_name(IntPtr thiz, string displayName);

		/// <summary>
		/// Returns the display name. 
		/// </summary>
		public string DisplayName
		{
			get
			{
				IntPtr stringPtr = linphone_address_get_display_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_address_set_display_name(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("DisplayName setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_domain(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_address_set_domain(IntPtr thiz, string domain);

		/// <summary>
		/// Returns the domain name. 
		/// </summary>
		public string Domain
		{
			get
			{
				IntPtr stringPtr = linphone_address_get_domain(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_address_set_domain(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Domain setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_address_is_sip(IntPtr thiz);

		/// <summary>
		/// returns true if address is a routable sip address 
		/// </summary>
		public bool IsSip
		{
			get
			{
				return linphone_address_is_sip(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_method_param(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_set_method_param(IntPtr thiz, string methodParam);

		/// <summary>
		/// Get the value of the method parameter. 
		/// </summary>
		public string MethodParam
		{
			get
			{
				IntPtr stringPtr = linphone_address_get_method_param(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_address_set_method_param(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_password(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_set_password(IntPtr thiz, string password);

		/// <summary>
		/// Get the password encoded in the address. 
		/// </summary>
		public string Password
		{
			get
			{
				IntPtr stringPtr = linphone_address_get_password(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_address_set_password(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_address_get_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_address_set_port(IntPtr thiz, int port);

		/// <summary>
		/// Get port number as an integer value, 0 if not present. 
		/// </summary>
		public int Port
		{
			get
			{
				return linphone_address_get_port(nativePtr);
			}
			set
			{
				int exception_result = linphone_address_set_port(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Port setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_scheme(IntPtr thiz);

		/// <summary>
		/// Returns the address scheme, normally "sip". 
		/// </summary>
		public string Scheme
		{
			get
			{
				IntPtr stringPtr = linphone_address_get_scheme(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_address_get_secure(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_set_secure(IntPtr thiz, char enabled);

		/// <summary>
		/// Returns true if address refers to a secure location (sips) 
		/// </summary>
		public bool Secure
		{
			get
			{
				return linphone_address_get_secure(nativePtr) != 0;
			}
			set
			{
				linphone_address_set_secure(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern TransportType linphone_address_get_transport(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_address_set_transport(IntPtr thiz, int transport);

		/// <summary>
		/// Get the transport. 
		/// </summary>
		public TransportType Transport
		{
			get
			{
				return linphone_address_get_transport(nativePtr);
			}
			set
			{
				int exception_result = linphone_address_set_transport(nativePtr, (int)value);
				if (exception_result != 0) throw new LinphoneException("Transport setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_username(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_address_set_username(IntPtr thiz, string username);

		/// <summary>
		/// Returns the username. 
		/// </summary>
		public string Username
		{
			get
			{
				IntPtr stringPtr = linphone_address_get_username(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_address_set_username(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Username setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_as_string(IntPtr thiz);

		/// <summary>
		/// Returns the address as a string. 
		/// </summary>
		public string AsString()
		{
			IntPtr stringPtr = linphone_address_as_string(nativePtr);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_as_string_uri_only(IntPtr thiz);

		/// <summary>
		/// Returns the SIP uri only as a string, that is display name is removed. 
		/// </summary>
		public string AsStringUriOnly()
		{
			IntPtr stringPtr = linphone_address_as_string_uri_only(nativePtr);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_clean(IntPtr thiz);

		/// <summary>
		/// Removes address's tags and uri headers so that it is displayable to the user. 
		/// </summary>
		public void Clean()
		{
			linphone_address_clean(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_clone(IntPtr thiz);

		/// <summary>
		/// Clones a <see cref="Address" /> object. 
		/// </summary>
		public Address Clone()
		{
			IntPtr ptr = linphone_address_clone(nativePtr);
			return fromNativePtr<Address>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_address_equal(IntPtr thiz, IntPtr address2);

		/// <summary>
		/// Compare two <see cref="Address" /> taking the tags and headers into
		/// account. 
		/// </summary>
		public bool Equal(Address address2)
		{
			return linphone_address_equal(nativePtr, address2 != null ? address2.nativePtr : IntPtr.Zero) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_header(IntPtr thiz, string headerName);

		/// <summary>
		/// Get the header encoded in the address. 
		/// </summary>
		public string GetHeader(string headerName)
		{
			IntPtr stringPtr = linphone_address_get_header(nativePtr, headerName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_param(IntPtr thiz, string paramName);

		/// <summary>
		/// Get the value of a parameter of the address. 
		/// </summary>
		public string GetParam(string paramName)
		{
			IntPtr stringPtr = linphone_address_get_param(nativePtr, paramName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_address_get_uri_param(IntPtr thiz, string uriParamName);

		/// <summary>
		/// Get the value of a parameter of the URI of the address. 
		/// </summary>
		public string GetUriParam(string uriParamName)
		{
			IntPtr stringPtr = linphone_address_get_uri_param(nativePtr, uriParamName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_address_has_param(IntPtr thiz, string paramName);

		/// <summary>
		/// Tell whether a parameter is present in the address. 
		/// </summary>
		public bool HasParam(string paramName)
		{
			return linphone_address_has_param(nativePtr, paramName) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_address_has_uri_param(IntPtr thiz, string uriParamName);

		/// <summary>
		/// Tell whether a parameter is present in the URI of the address. 
		/// </summary>
		public bool HasUriParam(string uriParamName)
		{
			return linphone_address_has_uri_param(nativePtr, uriParamName) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_remove_uri_param(IntPtr thiz, string uriParamName);

		/// <summary>
		/// Removes the value of a parameter of the URI of the address. 
		/// </summary>
		public void RemoveUriParam(string uriParamName)
		{
			linphone_address_remove_uri_param(nativePtr, uriParamName);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_set_header(IntPtr thiz, string headerName, string headerValue);

		/// <summary>
		/// Set a header into the address. 
		/// </summary>
		public void SetHeader(string headerName, string headerValue)
		{
			linphone_address_set_header(nativePtr, headerName, headerValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_set_param(IntPtr thiz, string paramName, string paramValue);

		/// <summary>
		/// Set the value of a parameter of the address. 
		/// </summary>
		public void SetParam(string paramName, string paramValue)
		{
			linphone_address_set_param(nativePtr, paramName, paramValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_address_set_uri_param(IntPtr thiz, string uriParamName, string uriParamValue);

		/// <summary>
		/// Set the value of a parameter of the URI of the address. 
		/// </summary>
		public void SetUriParam(string uriParamName, string uriParamValue)
		{
			linphone_address_set_uri_param(nativePtr, uriParamName, uriParamValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_address_weak_equal(IntPtr thiz, IntPtr address2);

		/// <summary>
		/// Compare two <see cref="Address" /> ignoring tags and headers,
		/// basically just domain, username, and port. 
		/// </summary>
		public bool WeakEqual(Address address2)
		{
			return linphone_address_weak_equal(nativePtr, address2 != null ? address2.nativePtr : IntPtr.Zero) == (char)0 ? false : true;
		}
	}

	/// <summary>
	/// Object holding authentication information. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class AuthInfo : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_domain(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_domain(IntPtr thiz, string domain);

		/// <summary>
		/// Gets the domain. 
		/// </summary>
		public string Domain
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_domain(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_domain(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_ha1(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_ha1(IntPtr thiz, string ha1);

		/// <summary>
		/// Gets the ha1. 
		/// </summary>
		public string Ha1
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_ha1(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_ha1(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_passwd(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_passwd(IntPtr thiz, string passwd);

		/// <summary>
		/// Gets the password. 
		/// </summary>
		public string Passwd
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_passwd(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_passwd(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_password(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_password(IntPtr thiz, string passwd);

		/// <summary>
		/// Gets the password. 
		/// </summary>
		public string Password
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_password(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_password(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_realm(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_realm(IntPtr thiz, string realm);

		/// <summary>
		/// Gets the realm. 
		/// </summary>
		public string Realm
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_realm(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_realm(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_tls_cert(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_tls_cert(IntPtr thiz, string tlsCert);

		/// <summary>
		/// Gets the TLS certificate. 
		/// </summary>
		public string TlsCert
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_tls_cert(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_tls_cert(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_tls_cert_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_tls_cert_path(IntPtr thiz, string tlsCertPath);

		/// <summary>
		/// Gets the TLS certificate path. 
		/// </summary>
		public string TlsCertPath
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_tls_cert_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_tls_cert_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_tls_key(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_tls_key(IntPtr thiz, string tlsKey);

		/// <summary>
		/// Gets the TLS key. 
		/// </summary>
		public string TlsKey
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_tls_key(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_tls_key(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_tls_key_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_tls_key_path(IntPtr thiz, string tlsKeyPath);

		/// <summary>
		/// Gets the TLS key path. 
		/// </summary>
		public string TlsKeyPath
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_tls_key_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_tls_key_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_userid(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_userid(IntPtr thiz, string userid);

		/// <summary>
		/// Gets the userid. 
		/// </summary>
		public string Userid
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_userid(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_userid(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_get_username(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_auth_info_set_username(IntPtr thiz, string username);

		/// <summary>
		/// Gets the username. 
		/// </summary>
		public string Username
		{
			get
			{
				IntPtr stringPtr = linphone_auth_info_get_username(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_auth_info_set_username(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_auth_info_clone(IntPtr thiz);

		/// <summary>
		/// Instantiates a new auth info with values from source. 
		/// </summary>
		public AuthInfo Clone()
		{
			IntPtr ptr = linphone_auth_info_clone(nativePtr);
			return fromNativePtr<AuthInfo>(ptr, true);
		}
	}

	/// <summary>
	/// The <see cref="Content" /> object representing a data buffer. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Buffer : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_buffer_new_from_data(uint data, long size);

		/// <summary>
		/// Create a new <see cref="Buffer" /> object from existing data. 
		/// </summary>
		public static Buffer NewFromData(uint data, long size)
		{
			IntPtr ptr = linphone_buffer_new_from_data(data, size);
			return fromNativePtr<Buffer>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_buffer_new_from_string(string data);

		/// <summary>
		/// Create a new <see cref="Buffer" /> object from a string. 
		/// </summary>
		public static Buffer NewFromString(string data)
		{
			IntPtr ptr = linphone_buffer_new_from_string(data);
			return fromNativePtr<Buffer>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_buffer_get_content(IntPtr thiz);

		/// <summary>
		/// Get the content of the data buffer. 
		/// </summary>
		public uint Content
		{
			get
			{
				return linphone_buffer_get_content(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_buffer_is_empty(IntPtr thiz);

		/// <summary>
		/// Tell whether the <see cref="Buffer" /> is empty. 
		/// </summary>
		public bool IsEmpty
		{
			get
			{
				return linphone_buffer_is_empty(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_buffer_get_size(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_buffer_set_size(IntPtr thiz, long size);

		/// <summary>
		/// Get the size of the content of the data buffer. 
		/// </summary>
		public long Size
		{
			get
			{
				return linphone_buffer_get_size(nativePtr);
			}
			set
			{
				linphone_buffer_set_size(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_buffer_get_string_content(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_buffer_set_string_content(IntPtr thiz, string content);

		/// <summary>
		/// Get the string content of the data buffer. 
		/// </summary>
		public string StringContent
		{
			get
			{
				IntPtr stringPtr = linphone_buffer_get_string_content(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_buffer_set_string_content(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_buffer_set_content(IntPtr thiz, uint content, long size);

		/// <summary>
		/// Set the content of the data buffer. 
		/// </summary>
		public void SetContent(uint content, long size)
		{
			linphone_buffer_set_content(nativePtr, content, size);
			
		}
	}

	/// <summary>
	/// The <see cref="Call" /> object represents a call issued or received by
	/// the <see cref="Core" />. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Call : LinphoneObject
	{

		/// Get the native window handle of the video window, casted as an unsigned long.
		public string NativeVideoWindowIdString
		{
			get
			{
				return Marshal.PtrToStringUni(linphone_call_get_native_video_window_id(nativePtr));
			}
			set
			{
				linphone_call_set_native_video_window_id(nativePtr, Marshal.StringToHGlobalUni(value));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_add_callbacks(IntPtr thiz, IntPtr cbs);

		/// <summary>
		/// The <see cref="Call" /> object represents a call issued or received by
		/// the <see cref="Core" />. 
		/// </summary>
		public void AddListener(CallListener cbs)
		{
			linphone_call_add_callbacks(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_remove_callbacks(IntPtr thiz, IntPtr cbs);

		/// <summary>
		/// The <see cref="Call" /> object represents a call issued or received by
		/// the <see cref="Core" />. 
		/// </summary>
		public void RemoveListener(CallListener cbs)
		{
			linphone_call_remove_callbacks(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_authentication_token(IntPtr thiz);

		/// <summary>
		/// Returns the ZRTP authentication token to verify. 
		/// </summary>
		public string AuthenticationToken
		{
			get
			{
				IntPtr stringPtr = linphone_call_get_authentication_token(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_get_authentication_token_verified(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_set_authentication_token_verified(IntPtr thiz, char verified);

		/// <summary>
		/// Returns whether ZRTP authentication token is verified. 
		/// </summary>
		public bool AuthenticationTokenVerified
		{
			get
			{
				return linphone_call_get_authentication_token_verified(nativePtr) != 0;
			}
			set
			{
				linphone_call_set_authentication_token_verified(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_get_average_quality(IntPtr thiz);

		/// <summary>
		/// Returns call quality averaged over all the duration of the call. 
		/// </summary>
		public float AverageQuality
		{
			get
			{
				return linphone_call_get_average_quality(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_call_log(IntPtr thiz);

		/// <summary>
		/// Gets the call log associated to this call. 
		/// </summary>
		public CallLog CallLog
		{
			get
			{
				IntPtr ptr = linphone_call_get_call_log(nativePtr);
				return fromNativePtr<CallLog>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_camera_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_enable_camera(IntPtr thiz, char enabled);

		/// <summary>
		/// Returns true if camera pictures are allowed to be sent to the remote party. 
		/// </summary>
		public bool CameraEnabled
		{
			get
			{
				return linphone_call_camera_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_enable_camera(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_chat_room(IntPtr thiz);

		/// <summary>
		/// Create a new chat room for messaging from a call if not already existing, else
		/// return existing one. 
		/// </summary>
		public ChatRoom ChatRoom
		{
			get
			{
				IntPtr ptr = linphone_call_get_chat_room(nativePtr);
				return fromNativePtr<ChatRoom>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_conference(IntPtr thiz);

		/// <summary>
		/// Return the associated conference object. 
		/// </summary>
		public Conference Conference
		{
			get
			{
				IntPtr ptr = linphone_call_get_conference(nativePtr);
				return fromNativePtr<Conference>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_core(IntPtr thiz);

		/// <summary>
		/// Get the core that has created the specified call. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_call_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_current_callbacks(IntPtr thiz);

		/// <summary>
		/// Gets the current LinphoneCallCbs. 
		/// </summary>
		public CallListener CurrentCallbacks
		{
			get
			{
				IntPtr ptr = linphone_call_get_current_callbacks(nativePtr);
				return fromNativePtr<CallListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_current_params(IntPtr thiz);

		/// <summary>
		/// Returns current parameters associated to the call. 
		/// </summary>
		public CallParams CurrentParams
		{
			get
			{
				IntPtr ptr = linphone_call_get_current_params(nativePtr);
				return fromNativePtr<CallParams>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_get_current_quality(IntPtr thiz);

		/// <summary>
		/// Obtain real-time quality rating of the call. 
		/// </summary>
		public float CurrentQuality
		{
			get
			{
				return linphone_call_get_current_quality(nativePtr);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern CallDir linphone_call_get_dir(IntPtr thiz);

		/// <summary>
		/// Returns direction of the call (incoming or outgoing). 
		/// </summary>
		public CallDir Dir
		{
			get
			{
				return linphone_call_get_dir(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_diversion_address(IntPtr thiz);

		/// <summary>
		/// Returns the diversion address associated to this call. 
		/// </summary>
		public Address DiversionAddress
		{
			get
			{
				IntPtr ptr = linphone_call_get_diversion_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_get_duration(IntPtr thiz);

		/// <summary>
		/// Returns call's duration in seconds. 
		/// </summary>
		public int Duration
		{
			get
			{
				return linphone_call_get_duration(nativePtr);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_echo_cancellation_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_enable_echo_cancellation(IntPtr thiz, char val);

		/// <summary>
		/// Returns true if echo cancellation is enabled. 
		/// </summary>
		public bool EchoCancellationEnabled
		{
			get
			{
				return linphone_call_echo_cancellation_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_enable_echo_cancellation(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_echo_limiter_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_enable_echo_limiter(IntPtr thiz, char val);

		/// <summary>
		/// Returns true if echo limiter is enabled. 
		/// </summary>
		public bool EchoLimiterEnabled
		{
			get
			{
				return linphone_call_echo_limiter_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_enable_echo_limiter(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_error_info(IntPtr thiz);

		/// <summary>
		/// Returns full details about call errors or termination reasons. 
		/// </summary>
		public ErrorInfo ErrorInfo
		{
			get
			{
				IntPtr ptr = linphone_call_get_error_info(nativePtr);
				return fromNativePtr<ErrorInfo>(ptr, true);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_get_microphone_volume_gain(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_set_microphone_volume_gain(IntPtr thiz, float volume);

		/// <summary>
		/// Get microphone volume gain. 
		/// </summary>
		public float MicrophoneVolumeGain
		{
			get
			{
				return linphone_call_get_microphone_volume_gain(nativePtr);
			}
			set
			{
				linphone_call_set_microphone_volume_gain(nativePtr, value);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_native_video_window_id(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_set_native_video_window_id(IntPtr thiz, IntPtr id);

		/// <summary>
		/// Get the native window handle of the video window, casted as an unsigned long. 
		/// </summary>
		public IntPtr NativeVideoWindowId
		{
			get
			{
				return linphone_call_get_native_video_window_id(nativePtr);
			}
			set
			{
				linphone_call_set_native_video_window_id(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_params(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_set_params(IntPtr thiz, IntPtr parameters);

		/// <summary>
		/// Returns local parameters associated with the call. 
		/// </summary>
		public CallParams Params
		{
			get
			{
				IntPtr ptr = linphone_call_get_params(nativePtr);
				return fromNativePtr<CallParams>(ptr, true);
			}
			set
			{
				linphone_call_set_params(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_get_play_volume(IntPtr thiz);

		/// <summary>
		/// Get the mesured playback volume level (received from remote) in dbm0. 
		/// </summary>
		public float PlayVolume
		{
			get
			{
				return linphone_call_get_play_volume(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_player(IntPtr thiz);

		/// <summary>
		/// Get a player associated with the call to play a local file and stream it to the
		/// remote peer. 
		/// </summary>
		public Player Player
		{
			get
			{
				IntPtr ptr = linphone_call_get_player(nativePtr);
				return fromNativePtr<Player>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern Reason linphone_call_get_reason(IntPtr thiz);

		/// <summary>
		/// Returns the reason for a call termination (either error or normal termination) 
		/// </summary>
		public Reason Reason
		{
			get
			{
				return linphone_call_get_reason(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_get_record_volume(IntPtr thiz);

		/// <summary>
		/// Get the mesured record volume level (sent to remote) in dbm0. 
		/// </summary>
		public float RecordVolume
		{
			get
			{
				return linphone_call_get_record_volume(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_refer_to(IntPtr thiz);

		/// <summary>
		/// Gets the refer-to uri (if the call was transfered). 
		/// </summary>
		public string ReferTo
		{
			get
			{
				IntPtr stringPtr = linphone_call_get_refer_to(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_remote_address(IntPtr thiz);

		/// <summary>
		/// Returns the remote address associated to this call. 
		/// </summary>
		public Address RemoteAddress
		{
			get
			{
				IntPtr ptr = linphone_call_get_remote_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_remote_address_as_string(IntPtr thiz);

		/// <summary>
		/// Returns the remote address associated to this call as a string. 
		/// </summary>
		public string RemoteAddressAsString
		{
			get
			{
				IntPtr stringPtr = linphone_call_get_remote_address_as_string(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_remote_contact(IntPtr thiz);

		/// <summary>
		/// Returns the far end's sip contact as a string, if available. 
		/// </summary>
		public string RemoteContact
		{
			get
			{
				IntPtr stringPtr = linphone_call_get_remote_contact(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_remote_params(IntPtr thiz);

		/// <summary>
		/// Returns call parameters proposed by remote. 
		/// </summary>
		public CallParams RemoteParams
		{
			get
			{
				IntPtr ptr = linphone_call_get_remote_params(nativePtr);
				return fromNativePtr<CallParams>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_remote_user_agent(IntPtr thiz);

		/// <summary>
		/// Returns the far end's user agent description string, if available. 
		/// </summary>
		public string RemoteUserAgent
		{
			get
			{
				IntPtr stringPtr = linphone_call_get_remote_user_agent(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_replaced_call(IntPtr thiz);

		/// <summary>
		/// Returns the call object this call is replacing, if any. 
		/// </summary>
		public Call ReplacedCall
		{
			get
			{
				IntPtr ptr = linphone_call_get_replaced_call(nativePtr);
				return fromNativePtr<Call>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_get_speaker_volume_gain(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_set_speaker_volume_gain(IntPtr thiz, float volume);

		/// <summary>
		/// Get speaker volume gain. 
		/// </summary>
		public float SpeakerVolumeGain
		{
			get
			{
				return linphone_call_get_speaker_volume_gain(nativePtr);
			}
			set
			{
				linphone_call_set_speaker_volume_gain(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern CallState linphone_call_get_state(IntPtr thiz);

		/// <summary>
		/// Retrieves the call's current state. 
		/// </summary>
		public CallState State
		{
			get
			{
				return linphone_call_get_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_get_stream_count(IntPtr thiz);

		/// <summary>
		/// Returns the number of stream for the given call. 
		/// </summary>
		public int StreamCount
		{
			get
			{
				return linphone_call_get_stream_count(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_to_address(IntPtr thiz);

		/// <summary>
		/// Returns the to address with its headers associated to this call. 
		/// </summary>
		public Address ToAddress
		{
			get
			{
				IntPtr ptr = linphone_call_get_to_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern CallState linphone_call_get_transfer_state(IntPtr thiz);

		/// <summary>
		/// Returns the current transfer state, if a transfer has been initiated from this
		/// call. 
		/// </summary>
		public CallState TransferState
		{
			get
			{
				return linphone_call_get_transfer_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_transfer_target_call(IntPtr thiz);

		/// <summary>
		/// When this call has received a transfer request, returns the new call that was
		/// automatically created as a result of the transfer. 
		/// </summary>
		public Call TransferTargetCall
		{
			get
			{
				IntPtr ptr = linphone_call_get_transfer_target_call(nativePtr);
				return fromNativePtr<Call>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_transferer_call(IntPtr thiz);

		/// <summary>
		/// Gets the transferer if this call was started automatically as a result of an
		/// incoming transfer request. 
		/// </summary>
		public Call TransfererCall
		{
			get
			{
				IntPtr ptr = linphone_call_get_transferer_call(nativePtr);
				return fromNativePtr<Call>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_accept(IntPtr thiz);

		/// <summary>
		/// Accept an incoming call. 
		/// </summary>
		public void Accept()
		{
			int exception_result = linphone_call_accept(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Accept returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_accept_early_media(IntPtr thiz);

		/// <summary>
		/// Accept an early media session for an incoming call. 
		/// </summary>
		public void AcceptEarlyMedia()
		{
			int exception_result = linphone_call_accept_early_media(nativePtr);
			if (exception_result != 0) throw new LinphoneException("AcceptEarlyMedia returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_accept_early_media_with_params(IntPtr thiz, IntPtr parameters);

		/// <summary>
		/// When receiving an incoming, accept to start a media session as early-media. 
		/// </summary>
		public void AcceptEarlyMediaWithParams(CallParams parameters)
		{
			int exception_result = linphone_call_accept_early_media_with_params(nativePtr, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptEarlyMediaWithParams returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_accept_update(IntPtr thiz, IntPtr parameters);

		/// <summary>
		/// Accept call modifications initiated by other end. 
		/// </summary>
		public void AcceptUpdate(CallParams parameters)
		{
			int exception_result = linphone_call_accept_update(nativePtr, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptUpdate returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_accept_with_params(IntPtr thiz, IntPtr parameters);

		/// <summary>
		/// Accept an incoming call, with parameters. 
		/// </summary>
		public void AcceptWithParams(CallParams parameters)
		{
			int exception_result = linphone_call_accept_with_params(nativePtr, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptWithParams returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_asked_to_autoanswer(IntPtr thiz);

		/// <summary>
		/// Tell whether a call has been asked to autoanswer. 
		/// </summary>
		public bool AskedToAutoanswer()
		{
			return linphone_call_asked_to_autoanswer(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_cancel_dtmfs(IntPtr thiz);

		/// <summary>
		/// Stop current DTMF sequence sending. 
		/// </summary>
		public void CancelDtmfs()
		{
			linphone_call_cancel_dtmfs(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_decline(IntPtr thiz, int reason);

		/// <summary>
		/// Decline a pending incoming call, with a reason. 
		/// </summary>
		public void Decline(Reason reason)
		{
			int exception_result = linphone_call_decline(nativePtr, (int)reason);
			if (exception_result != 0) throw new LinphoneException("Decline returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_decline_with_error_info(IntPtr thiz, IntPtr ei);

		/// <summary>
		/// Decline a pending incoming call, with a <see cref="ErrorInfo" />
		/// object. 
		/// </summary>
		public int DeclineWithErrorInfo(ErrorInfo ei)
		{
			return linphone_call_decline_with_error_info(nativePtr, ei != null ? ei.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_defer_update(IntPtr thiz);

		/// <summary>
		/// When receiving a #LinphoneCallUpdatedByRemote state notification, prevent <see
		/// cref="Core" /> from performing an automatic answer. 
		/// </summary>
		public void DeferUpdate()
		{
			int exception_result = linphone_call_defer_update(nativePtr);
			if (exception_result != 0) throw new LinphoneException("DeferUpdate returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_stats(IntPtr thiz, int type);

		/// <summary>
		/// Return a copy of the call statistics for a particular stream type. 
		/// </summary>
		public CallStats GetStats(StreamType type)
		{
			IntPtr ptr = linphone_call_get_stats(nativePtr, (int)type);
			return fromNativePtr<CallStats>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_get_to_header(IntPtr thiz, string name);

		/// <summary>
		/// Returns the value of the header name. 
		/// </summary>
		public string GetToHeader(string name)
		{
			IntPtr stringPtr = linphone_call_get_to_header(nativePtr, name);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_has_transfer_pending(IntPtr thiz);

		/// <summary>
		/// Returns true if this calls has received a transfer that has not been executed
		/// yet. 
		/// </summary>
		public bool HasTransferPending()
		{
			return linphone_call_has_transfer_pending(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_media_in_progress(IntPtr thiz);

		/// <summary>
		/// Indicates whether an operation is in progress at the media side. 
		/// </summary>
		public bool MediaInProgress()
		{
			return linphone_call_media_in_progress(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_ogl_render(IntPtr thiz);

		/// <summary>
		/// Call generic OpenGL render for a given call. 
		/// </summary>
		public void OglRender()
		{
			linphone_call_ogl_render(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_pause(IntPtr thiz);

		/// <summary>
		/// Pauses the call. 
		/// </summary>
		public void Pause()
		{
			int exception_result = linphone_call_pause(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Pause returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_redirect(IntPtr thiz, string redirectUri);

		/// <summary>
		/// Redirect the specified call to the given redirect URI. 
		/// </summary>
		public void Redirect(string redirectUri)
		{
			int exception_result = linphone_call_redirect(nativePtr, redirectUri);
			if (exception_result != 0) throw new LinphoneException("Redirect returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_request_notify_next_video_frame_decoded(IntPtr thiz);

		/// <summary>
		/// Request the callback passed to linphone_call_cbs_set_next_video_frame_decoded
		/// to be called the next time the video decoder properly decodes a video frame. 
		/// </summary>
		public void RequestNotifyNextVideoFrameDecoded()
		{
			linphone_call_request_notify_next_video_frame_decoded(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_resume(IntPtr thiz);

		/// <summary>
		/// Resumes a call. 
		/// </summary>
		public void Resume()
		{
			int exception_result = linphone_call_resume(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Resume returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_send_dtmf(IntPtr thiz, sbyte dtmf);

		/// <summary>
		/// Send the specified dtmf. 
		/// </summary>
		public void SendDtmf(sbyte dtmf)
		{
			int exception_result = linphone_call_send_dtmf(nativePtr, dtmf);
			if (exception_result != 0) throw new LinphoneException("SendDtmf returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_send_dtmfs(IntPtr thiz, string dtmfs);

		/// <summary>
		/// Send a list of dtmf. 
		/// </summary>
		public void SendDtmfs(string dtmfs)
		{
			int exception_result = linphone_call_send_dtmfs(nativePtr, dtmfs);
			if (exception_result != 0) throw new LinphoneException("SendDtmfs returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_send_info_message(IntPtr thiz, IntPtr info);

		/// <summary>
		/// Send a <see cref="InfoMessage" /> through an established call. 
		/// </summary>
		public void SendInfoMessage(InfoMessage info)
		{
			int exception_result = linphone_call_send_info_message(nativePtr, info != null ? info.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("SendInfoMessage returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_send_vfu_request(IntPtr thiz);

		/// <summary>
		/// Request remote side to send us a Video Fast Update. 
		/// </summary>
		public void SendVfuRequest()
		{
			linphone_call_send_vfu_request(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_start_recording(IntPtr thiz);

		/// <summary>
		/// Start call recording. 
		/// </summary>
		public void StartRecording()
		{
			linphone_call_start_recording(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_stop_recording(IntPtr thiz);

		/// <summary>
		/// Stop call recording. 
		/// </summary>
		public void StopRecording()
		{
			linphone_call_stop_recording(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_take_preview_snapshot(IntPtr thiz, string file);

		/// <summary>
		/// Take a photo of currently captured video and write it into a jpeg file. 
		/// </summary>
		public void TakePreviewSnapshot(string file)
		{
			int exception_result = linphone_call_take_preview_snapshot(nativePtr, file);
			if (exception_result != 0) throw new LinphoneException("TakePreviewSnapshot returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_take_video_snapshot(IntPtr thiz, string file);

		/// <summary>
		/// Take a photo of currently received video and write it into a jpeg file. 
		/// </summary>
		public void TakeVideoSnapshot(string file)
		{
			int exception_result = linphone_call_take_video_snapshot(nativePtr, file);
			if (exception_result != 0) throw new LinphoneException("TakeVideoSnapshot returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_terminate(IntPtr thiz);

		/// <summary>
		/// Terminates a call. 
		/// </summary>
		public void Terminate()
		{
			int exception_result = linphone_call_terminate(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Terminate returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_terminate_with_error_info(IntPtr thiz, IntPtr ei);

		/// <summary>
		/// Terminates a call. 
		/// </summary>
		public void TerminateWithErrorInfo(ErrorInfo ei)
		{
			int exception_result = linphone_call_terminate_with_error_info(nativePtr, ei != null ? ei.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("TerminateWithErrorInfo returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_transfer(IntPtr thiz, string referTo);

		/// <summary>
		/// Performs a simple call transfer to the specified destination. 
		/// </summary>
		public void Transfer(string referTo)
		{
			int exception_result = linphone_call_transfer(nativePtr, referTo);
			if (exception_result != 0) throw new LinphoneException("Transfer returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_transfer_to_another(IntPtr thiz, IntPtr dest);

		/// <summary>
		/// Transfers a call to destination of another running call. 
		/// </summary>
		public void TransferToAnother(Call dest)
		{
			int exception_result = linphone_call_transfer_to_another(nativePtr, dest != null ? dest.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("TransferToAnother returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_update(IntPtr thiz, IntPtr parameters);

		/// <summary>
		/// Updates a running call according to supplied call parameters or parameters
		/// changed in the LinphoneCore. 
		/// </summary>
		public void Update(CallParams parameters)
		{
			int exception_result = linphone_call_update(nativePtr, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("Update returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_zoom(IntPtr thiz, float zoomFactor, float cx, float cy);

		/// <summary>
		/// Perform a zoom of the video displayed during a call. 
		/// </summary>
		public void Zoom(float zoomFactor, float cx, float cy)
		{
			linphone_call_zoom(nativePtr, zoomFactor, cx, cy);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_zoom_video(IntPtr thiz, float zoomFactor, float cx, float cy);

		/// <summary>
		/// Perform a zoom of the video displayed during a call. 
		/// </summary>
		public void ZoomVideo(float zoomFactor, float cx, float cy)
		{
			linphone_call_zoom_video(nativePtr, zoomFactor, cx, cy);
			
		}
	}

	/// <summary>
	/// Structure representing a call log. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class CallLog : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_get_call_id(IntPtr thiz);

		/// <summary>
		/// Get the call ID used by the call. 
		/// </summary>
		public string CallId
		{
			get
			{
				IntPtr stringPtr = linphone_call_log_get_call_id(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern CallDir linphone_call_log_get_dir(IntPtr thiz);

		/// <summary>
		/// Get the direction of the call. 
		/// </summary>
		public CallDir Dir
		{
			get
			{
				return linphone_call_log_get_dir(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_log_get_duration(IntPtr thiz);

		/// <summary>
		/// Get the duration of the call since connected. 
		/// </summary>
		public int Duration
		{
			get
			{
				return linphone_call_log_get_duration(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_get_error_info(IntPtr thiz);

		/// <summary>
		/// When the call was failed, return an object describing the failure. 
		/// </summary>
		public ErrorInfo ErrorInfo
		{
			get
			{
				IntPtr ptr = linphone_call_log_get_error_info(nativePtr);
				return fromNativePtr<ErrorInfo>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_get_from_address(IntPtr thiz);

		/// <summary>
		/// Get the origin address (ie from) of the call. 
		/// </summary>
		public Address FromAddress
		{
			get
			{
				IntPtr ptr = linphone_call_log_get_from_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_get_local_address(IntPtr thiz);

		/// <summary>
		/// Get the local address (that is from or to depending on call direction) 
		/// </summary>
		public Address LocalAddress
		{
			get
			{
				IntPtr ptr = linphone_call_log_get_local_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_log_get_quality(IntPtr thiz);

		/// <summary>
		/// Get the overall quality indication of the call. 
		/// </summary>
		public float Quality
		{
			get
			{
				return linphone_call_log_get_quality(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_get_ref_key(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_log_set_ref_key(IntPtr thiz, string refkey);

		/// <summary>
		/// Get the persistent reference key associated to the call log. 
		/// </summary>
		public string RefKey
		{
			get
			{
				IntPtr stringPtr = linphone_call_log_get_ref_key(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_call_log_set_ref_key(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_get_remote_address(IntPtr thiz);

		/// <summary>
		/// Get the remote address (that is from or to depending on call direction). 
		/// </summary>
		public Address RemoteAddress
		{
			get
			{
				IntPtr ptr = linphone_call_log_get_remote_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_call_log_get_start_date(IntPtr thiz);

		/// <summary>
		/// Get the start date of the call. 
		/// </summary>
		public long StartDate
		{
			get
			{
				return linphone_call_log_get_start_date(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern CallStatus linphone_call_log_get_status(IntPtr thiz);

		/// <summary>
		/// Get the status of the call. 
		/// </summary>
		public CallStatus Status
		{
			get
			{
				return linphone_call_log_get_status(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_get_to_address(IntPtr thiz);

		/// <summary>
		/// Get the destination address (ie to) of the call. 
		/// </summary>
		public Address ToAddress
		{
			get
			{
				IntPtr ptr = linphone_call_log_get_to_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_log_video_enabled(IntPtr thiz);

		/// <summary>
		/// Tell whether video was enabled at the end of the call or not. 
		/// </summary>
		public bool VideoEnabled
		{
			get
			{
				return linphone_call_log_video_enabled(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_log_to_str(IntPtr thiz);

		/// <summary>
		/// Get a human readable string describing the call. 
		/// </summary>
		public string ToStr()
		{
			IntPtr stringPtr = linphone_call_log_to_str(nativePtr);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_log_was_conference(IntPtr thiz);

		/// <summary>
		/// Tells whether that call was a call to a conference server. 
		/// </summary>
		public bool WasConference()
		{
			return linphone_call_log_was_conference(nativePtr) == (char)0 ? false : true;
		}
	}

	/// <summary>
	/// The <see cref="CallParams" /> is an object containing various call
	/// related parameters. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class CallParams : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_set_audio_bandwidth_limit(IntPtr thiz, int bw);

		/// <summary>
		/// Refine bandwidth settings for this call by setting a bandwidth limit for audio
		/// streams. 
		/// </summary>
		public int AudioBandwidthLimit
		{
			set
			{
				linphone_call_params_set_audio_bandwidth_limit(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern MediaDirection linphone_call_params_get_audio_direction(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_set_audio_direction(IntPtr thiz, int dir);

		/// <summary>
		/// Get the audio stream direction. 
		/// </summary>
		public MediaDirection AudioDirection
		{
			get
			{
				return linphone_call_params_get_audio_direction(nativePtr);
			}
			set
			{
				linphone_call_params_set_audio_direction(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_audio_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_enable_audio(IntPtr thiz, char enabled);

		/// <summary>
		/// Tell whether audio is enabled or not. 
		/// </summary>
		public bool AudioEnabled
		{
			get
			{
				return linphone_call_params_audio_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_params_enable_audio(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_audio_multicast_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_enable_audio_multicast(IntPtr thiz, char yesno);

		/// <summary>
		/// Use to get multicast state of audio stream. 
		/// </summary>
		public bool AudioMulticastEnabled
		{
			get
			{
				return linphone_call_params_audio_multicast_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_params_enable_audio_multicast(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_early_media_sending_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_enable_early_media_sending(IntPtr thiz, char enabled);

		/// <summary>
		/// Indicate whether sending of early media was enabled. 
		/// </summary>
		public bool EarlyMediaSendingEnabled
		{
			get
			{
				return linphone_call_params_early_media_sending_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_params_enable_early_media_sending(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_get_local_conference_mode(IntPtr thiz);

		/// <summary>
		/// Tell whether the call is part of the locally managed conference. 
		/// </summary>
		public bool LocalConferenceMode
		{
			get
			{
				return linphone_call_params_get_local_conference_mode(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_low_bandwidth_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_enable_low_bandwidth(IntPtr thiz, char enabled);

		/// <summary>
		/// Tell whether the call has been configured in low bandwidth mode or not. 
		/// </summary>
		public bool LowBandwidthEnabled
		{
			get
			{
				return linphone_call_params_low_bandwidth_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_params_enable_low_bandwidth(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern MediaEncryption linphone_call_params_get_media_encryption(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_set_media_encryption(IntPtr thiz, int enc);

		/// <summary>
		/// Get the kind of media encryption selected for the call. 
		/// </summary>
		public MediaEncryption MediaEncryption
		{
			get
			{
				return linphone_call_params_get_media_encryption(nativePtr);
			}
			set
			{
				linphone_call_params_set_media_encryption(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_call_params_get_privacy(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_set_privacy(IntPtr thiz, uint privacy);

		/// <summary>
		/// Get requested level of privacy for the call. 
		/// </summary>
		public uint Privacy
		{
			get
			{
				return linphone_call_params_get_privacy(nativePtr);
			}
			set
			{
				linphone_call_params_set_privacy(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_realtime_text_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_call_params_enable_realtime_text(IntPtr thiz, char yesno);

		/// <summary>
		/// Use to get real time text following rfc4103. 
		/// </summary>
		public bool RealtimeTextEnabled
		{
			get
			{
				return linphone_call_params_realtime_text_enabled(nativePtr) != 0;
			}
			set
			{
				int exception_result = linphone_call_params_enable_realtime_text(nativePtr, value ? (char)1 : (char)0);
				if (exception_result != 0) throw new LinphoneException("RealtimeTextEnabled setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_params_get_received_framerate(IntPtr thiz);

		/// <summary>
		/// Get the framerate of the video that is received. 
		/// </summary>
		public float ReceivedFramerate
		{
			get
			{
				return linphone_call_params_get_received_framerate(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_received_video_definition(IntPtr thiz);

		/// <summary>
		/// Get the definition of the received video. 
		/// </summary>
		public VideoDefinition ReceivedVideoDefinition
		{
			get
			{
				IntPtr ptr = linphone_call_params_get_received_video_definition(nativePtr);
				return fromNativePtr<VideoDefinition>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_record_file(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_set_record_file(IntPtr thiz, string path);

		/// <summary>
		/// Get the path for the audio recording of the call. 
		/// </summary>
		public string RecordFile
		{
			get
			{
				IntPtr stringPtr = linphone_call_params_get_record_file(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_call_params_set_record_file(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_rtp_profile(IntPtr thiz);

		/// <summary>
		/// Get the RTP profile being used. 
		/// </summary>
		public string RtpProfile
		{
			get
			{
				IntPtr stringPtr = linphone_call_params_get_rtp_profile(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_params_get_sent_framerate(IntPtr thiz);

		/// <summary>
		/// Get the framerate of the video that is sent. 
		/// </summary>
		public float SentFramerate
		{
			get
			{
				return linphone_call_params_get_sent_framerate(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_sent_video_definition(IntPtr thiz);

		/// <summary>
		/// Get the definition of the sent video. 
		/// </summary>
		public VideoDefinition SentVideoDefinition
		{
			get
			{
				IntPtr ptr = linphone_call_params_get_sent_video_definition(nativePtr);
				return fromNativePtr<VideoDefinition>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_session_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_set_session_name(IntPtr thiz, string name);

		/// <summary>
		/// Get the session name of the media session (ie in SDP). 
		/// </summary>
		public string SessionName
		{
			get
			{
				IntPtr stringPtr = linphone_call_params_get_session_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_call_params_set_session_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_used_audio_payload_type(IntPtr thiz);

		/// <summary>
		/// Get the audio payload type that has been selected by a call. 
		/// </summary>
		public PayloadType UsedAudioPayloadType
		{
			get
			{
				IntPtr ptr = linphone_call_params_get_used_audio_payload_type(nativePtr);
				return fromNativePtr<PayloadType>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_used_text_payload_type(IntPtr thiz);

		/// <summary>
		/// Get the text payload type that has been selected by a call. 
		/// </summary>
		public PayloadType UsedTextPayloadType
		{
			get
			{
				IntPtr ptr = linphone_call_params_get_used_text_payload_type(nativePtr);
				return fromNativePtr<PayloadType>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_used_video_payload_type(IntPtr thiz);

		/// <summary>
		/// Get the video payload type that has been selected by a call. 
		/// </summary>
		public PayloadType UsedVideoPayloadType
		{
			get
			{
				IntPtr ptr = linphone_call_params_get_used_video_payload_type(nativePtr);
				return fromNativePtr<PayloadType>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern MediaDirection linphone_call_params_get_video_direction(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_set_video_direction(IntPtr thiz, int dir);

		/// <summary>
		/// Get the video stream direction. 
		/// </summary>
		public MediaDirection VideoDirection
		{
			get
			{
				return linphone_call_params_get_video_direction(nativePtr);
			}
			set
			{
				linphone_call_params_set_video_direction(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_video_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_enable_video(IntPtr thiz, char enabled);

		/// <summary>
		/// Tell whether video is enabled or not. 
		/// </summary>
		public bool VideoEnabled
		{
			get
			{
				return linphone_call_params_video_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_params_enable_video(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_call_params_video_multicast_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_enable_video_multicast(IntPtr thiz, char yesno);

		/// <summary>
		/// Use to get multicast state of video stream. 
		/// </summary>
		public bool VideoMulticastEnabled
		{
			get
			{
				return linphone_call_params_video_multicast_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_call_params_enable_video_multicast(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_add_custom_header(IntPtr thiz, string headerName, string headerValue);

		/// <summary>
		/// Add a custom SIP header in the INVITE for a call. 
		/// </summary>
		public void AddCustomHeader(string headerName, string headerValue)
		{
			linphone_call_params_add_custom_header(nativePtr, headerName, headerValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_add_custom_sdp_attribute(IntPtr thiz, string attributeName, string attributeValue);

		/// <summary>
		/// Add a custom attribute related to all the streams in the SDP exchanged within
		/// SIP messages during a call. 
		/// </summary>
		public void AddCustomSdpAttribute(string attributeName, string attributeValue)
		{
			linphone_call_params_add_custom_sdp_attribute(nativePtr, attributeName, attributeValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_add_custom_sdp_media_attribute(IntPtr thiz, int type, string attributeName, string attributeValue);

		/// <summary>
		/// Add a custom attribute related to a specific stream in the SDP exchanged within
		/// SIP messages during a call. 
		/// </summary>
		public void AddCustomSdpMediaAttribute(StreamType type, string attributeName, string attributeValue)
		{
			linphone_call_params_add_custom_sdp_media_attribute(nativePtr, (int)type, attributeName, attributeValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_clear_custom_sdp_attributes(IntPtr thiz);

		/// <summary>
		/// Clear the custom SDP attributes related to all the streams in the SDP exchanged
		/// within SIP messages during a call. 
		/// </summary>
		public void ClearCustomSdpAttributes()
		{
			linphone_call_params_clear_custom_sdp_attributes(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_call_params_clear_custom_sdp_media_attributes(IntPtr thiz, int type);

		/// <summary>
		/// Clear the custom SDP attributes related to a specific stream in the SDP
		/// exchanged within SIP messages during a call. 
		/// </summary>
		public void ClearCustomSdpMediaAttributes(StreamType type)
		{
			linphone_call_params_clear_custom_sdp_media_attributes(nativePtr, (int)type);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_copy(IntPtr thiz);

		/// <summary>
		/// Copy an existing <see cref="CallParams" /> object to a new <see
		/// cref="CallParams" /> object. 
		/// </summary>
		public CallParams Copy()
		{
			IntPtr ptr = linphone_call_params_copy(nativePtr);
			return fromNativePtr<CallParams>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_custom_header(IntPtr thiz, string headerName);

		/// <summary>
		/// Get a custom SIP header. 
		/// </summary>
		public string GetCustomHeader(string headerName)
		{
			IntPtr stringPtr = linphone_call_params_get_custom_header(nativePtr, headerName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_custom_sdp_attribute(IntPtr thiz, string attributeName);

		/// <summary>
		/// Get a custom SDP attribute that is related to all the streams. 
		/// </summary>
		public string GetCustomSdpAttribute(string attributeName)
		{
			IntPtr stringPtr = linphone_call_params_get_custom_sdp_attribute(nativePtr, attributeName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_call_params_get_custom_sdp_media_attribute(IntPtr thiz, int type, string attributeName);

		/// <summary>
		/// Get a custom SDP attribute that is related to a specific stream. 
		/// </summary>
		public string GetCustomSdpMediaAttribute(StreamType type, string attributeName)
		{
			IntPtr stringPtr = linphone_call_params_get_custom_sdp_media_attribute(nativePtr, (int)type, attributeName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
	}

	/// <summary>
	/// The <see cref="CallStats" /> objects carries various statistic
	/// informations regarding quality of audio or video streams. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class CallStats : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_download_bandwidth(IntPtr thiz);

		/// <summary>
		/// Get the bandwidth measurement of the received stream, expressed in kbit/s,
		/// including IP/UDP/RTP headers. 
		/// </summary>
		public float DownloadBandwidth
		{
			get
			{
				return linphone_call_stats_get_download_bandwidth(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_estimated_download_bandwidth(IntPtr thiz);

		/// <summary>
		/// Get the estimated bandwidth measurement of the received stream, expressed in
		/// kbit/s, including IP/UDP/RTP headers. 
		/// </summary>
		public float EstimatedDownloadBandwidth
		{
			get
			{
				return linphone_call_stats_get_estimated_download_bandwidth(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IceState linphone_call_stats_get_ice_state(IntPtr thiz);

		/// <summary>
		/// Get the state of ICE processing. 
		/// </summary>
		public IceState IceState
		{
			get
			{
				return linphone_call_stats_get_ice_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AddressFamily linphone_call_stats_get_ip_family_of_remote(IntPtr thiz);

		/// <summary>
		/// Get the IP address family of the remote peer. 
		/// </summary>
		public AddressFamily IpFamilyOfRemote
		{
			get
			{
				return linphone_call_stats_get_ip_family_of_remote(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_jitter_buffer_size_ms(IntPtr thiz);

		/// <summary>
		/// Get the jitter buffer size in ms. 
		/// </summary>
		public float JitterBufferSizeMs
		{
			get
			{
				return linphone_call_stats_get_jitter_buffer_size_ms(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_call_stats_get_late_packets_cumulative_number(IntPtr thiz);

		/// <summary>
		/// Gets the cumulative number of late packets. 
		/// </summary>
		public uint LatePacketsCumulativeNumber
		{
			get
			{
				return linphone_call_stats_get_late_packets_cumulative_number(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_local_late_rate(IntPtr thiz);

		/// <summary>
		/// Gets the local late rate since last report. 
		/// </summary>
		public float LocalLateRate
		{
			get
			{
				return linphone_call_stats_get_local_late_rate(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_local_loss_rate(IntPtr thiz);

		/// <summary>
		/// Get the local loss rate since last report. 
		/// </summary>
		public float LocalLossRate
		{
			get
			{
				return linphone_call_stats_get_local_loss_rate(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_receiver_interarrival_jitter(IntPtr thiz);

		/// <summary>
		/// Gets the remote reported interarrival jitter. 
		/// </summary>
		public float ReceiverInterarrivalJitter
		{
			get
			{
				return linphone_call_stats_get_receiver_interarrival_jitter(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_receiver_loss_rate(IntPtr thiz);

		/// <summary>
		/// Gets the remote reported loss rate since last report. 
		/// </summary>
		public float ReceiverLossRate
		{
			get
			{
				return linphone_call_stats_get_receiver_loss_rate(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_round_trip_delay(IntPtr thiz);

		/// <summary>
		/// Get the round trip delay in s. 
		/// </summary>
		public float RoundTripDelay
		{
			get
			{
				return linphone_call_stats_get_round_trip_delay(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_rtcp_download_bandwidth(IntPtr thiz);

		/// <summary>
		/// Get the bandwidth measurement of the received RTCP, expressed in kbit/s,
		/// including IP/UDP/RTP headers. 
		/// </summary>
		public float RtcpDownloadBandwidth
		{
			get
			{
				return linphone_call_stats_get_rtcp_download_bandwidth(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_rtcp_upload_bandwidth(IntPtr thiz);

		/// <summary>
		/// Get the bandwidth measurement of the sent RTCP, expressed in kbit/s, including
		/// IP/UDP/RTP headers. 
		/// </summary>
		public float RtcpUploadBandwidth
		{
			get
			{
				return linphone_call_stats_get_rtcp_upload_bandwidth(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_sender_interarrival_jitter(IntPtr thiz);

		/// <summary>
		/// Gets the local interarrival jitter. 
		/// </summary>
		public float SenderInterarrivalJitter
		{
			get
			{
				return linphone_call_stats_get_sender_interarrival_jitter(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_sender_loss_rate(IntPtr thiz);

		/// <summary>
		/// Get the local loss rate since last report. 
		/// </summary>
		public float SenderLossRate
		{
			get
			{
				return linphone_call_stats_get_sender_loss_rate(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern StreamType linphone_call_stats_get_type(IntPtr thiz);

		/// <summary>
		/// Get the type of the stream the stats refer to. 
		/// </summary>
		public StreamType Type
		{
			get
			{
				return linphone_call_stats_get_type(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_call_stats_get_upload_bandwidth(IntPtr thiz);

		/// <summary>
		/// Get the bandwidth measurement of the sent stream, expressed in kbit/s,
		/// including IP/UDP/RTP headers. 
		/// </summary>
		public float UploadBandwidth
		{
			get
			{
				return linphone_call_stats_get_upload_bandwidth(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern UpnpState linphone_call_stats_get_upnp_state(IntPtr thiz);

		/// <summary>
		/// Get the state of uPnP processing. 
		/// </summary>
		public UpnpState UpnpState
		{
			get
			{
				return linphone_call_stats_get_upnp_state(nativePtr);
			}
		}
	}

	/// <summary>
	/// An chat message is the object that is sent and received through
	/// LinphoneChatRooms. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class ChatMessage : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_callbacks(IntPtr thiz);

		/// <summary>
		/// An chat message is the object that is sent and received through
		/// LinphoneChatRooms. 
		/// </summary>
		public ChatMessageListener Listener
		{
			get
			{
				IntPtr ptr = linphone_chat_message_get_callbacks(nativePtr);
				return fromNativePtr<ChatMessageListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_appdata(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_set_appdata(IntPtr thiz, string data);

		/// <summary>
		/// Linphone message has an app-specific field that can store a text. 
		/// </summary>
		public string Appdata
		{
			get
			{
				IntPtr stringPtr = linphone_chat_message_get_appdata(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_chat_message_set_appdata(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_chat_room(IntPtr thiz);

		/// <summary>
		/// Returns the chatroom this message belongs to. 
		/// </summary>
		public ChatRoom ChatRoom
		{
			get
			{
				IntPtr ptr = linphone_chat_message_get_chat_room(nativePtr);
				return fromNativePtr<ChatRoom>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_content_type(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_set_content_type(IntPtr thiz, string contentType);

		/// <summary>
		/// Get the content type of a chat message. 
		/// </summary>
		public string ContentType
		{
			get
			{
				IntPtr stringPtr = linphone_chat_message_get_content_type(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_chat_message_set_content_type(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_contents(IntPtr thiz);

		/// <summary>
		/// Returns the list of contents in the message. 
		/// </summary>
		public IEnumerable<Content> Contents
		{
			get
			{
				return MarshalBctbxList<Content>(linphone_chat_message_get_contents(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_error_info(IntPtr thiz);

		/// <summary>
		/// Get full details about delivery error of a chat message. 
		/// </summary>
		public ErrorInfo ErrorInfo
		{
			get
			{
				IntPtr ptr = linphone_chat_message_get_error_info(nativePtr);
				return fromNativePtr<ErrorInfo>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_external_body_url(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_set_external_body_url(IntPtr thiz, string url);

		/// <summary>
		/// Linphone message can carry external body as defined by rfc2017. 
		/// </summary>
		public string ExternalBodyUrl
		{
			get
			{
				IntPtr stringPtr = linphone_chat_message_get_external_body_url(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_chat_message_set_external_body_url(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_file_transfer_filepath(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_set_file_transfer_filepath(IntPtr thiz, string filepath);

		/// <summary>
		/// Get the path to the file to read from or write to during the file transfer. 
		/// </summary>
		public string FileTransferFilepath
		{
			get
			{
				IntPtr stringPtr = linphone_chat_message_get_file_transfer_filepath(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_chat_message_set_file_transfer_filepath(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_file_transfer_information(IntPtr thiz);

		/// <summary>
		/// Get the file_transfer_information (used by call backs to recover informations
		/// during a rcs file transfer) 
		/// </summary>
		public Content FileTransferInformation
		{
			get
			{
				IntPtr ptr = linphone_chat_message_get_file_transfer_information(nativePtr);
				return fromNativePtr<Content>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_from_address(IntPtr thiz);

		/// <summary>
		/// Get origin of the message. 
		/// </summary>
		public Address FromAddress
		{
			get
			{
				IntPtr ptr = linphone_chat_message_get_from_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_is_file_transfer(IntPtr thiz);

		/// <summary>
		/// Return whether or not a chat message is a file transfer. 
		/// </summary>
		public bool IsFileTransfer
		{
			get
			{
				return linphone_chat_message_is_file_transfer(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_is_file_transfer_in_progress(IntPtr thiz);

		/// <summary>
		/// Gets whether or not a file is currently being downloaded or uploaded. 
		/// </summary>
		public bool IsFileTransferInProgress
		{
			get
			{
				return linphone_chat_message_is_file_transfer_in_progress(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_is_outgoing(IntPtr thiz);

		/// <summary>
		/// Returns true if the message has been sent, returns true if the message has been
		/// received. 
		/// </summary>
		public bool IsOutgoing
		{
			get
			{
				return linphone_chat_message_is_outgoing(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_is_read(IntPtr thiz);

		/// <summary>
		/// Returns true if the message has been read, otherwise returns true. 
		/// </summary>
		public bool IsRead
		{
			get
			{
				return linphone_chat_message_is_read(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_is_secured(IntPtr thiz);

		/// <summary>
		/// Get if the message was encrypted when transfered. 
		/// </summary>
		public bool IsSecured
		{
			get
			{
				return linphone_chat_message_is_secured(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_is_text(IntPtr thiz);

		/// <summary>
		/// Return whether or not a chat message is a text. 
		/// </summary>
		public bool IsText
		{
			get
			{
				return linphone_chat_message_is_text(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_local_address(IntPtr thiz);

		/// <summary>
		/// Returns the origin address of a message if it was a outgoing message, or the
		/// destination address if it was an incoming message. 
		/// </summary>
		public Address LocalAddress
		{
			get
			{
				IntPtr ptr = linphone_chat_message_get_local_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_message_id(IntPtr thiz);

		/// <summary>
		/// Get the message identifier. 
		/// </summary>
		public string MessageId
		{
			get
			{
				IntPtr stringPtr = linphone_chat_message_get_message_id(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern ChatMessageState linphone_chat_message_get_state(IntPtr thiz);

		/// <summary>
		/// Get the state of the message. 
		/// </summary>
		public ChatMessageState State
		{
			get
			{
				return linphone_chat_message_get_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_text(IntPtr thiz);

		/// <summary>
		/// Get text part of this message. 
		/// </summary>
		public string Text
		{
			get
			{
				IntPtr stringPtr = linphone_chat_message_get_text(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_text_content(IntPtr thiz);

		/// <summary>
		/// Gets the text content if available as a string. 
		/// </summary>
		public string TextContent
		{
			get
			{
				IntPtr stringPtr = linphone_chat_message_get_text_content(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_chat_message_get_time(IntPtr thiz);

		/// <summary>
		/// Get the time the message was sent. 
		/// </summary>
		public long Time
		{
			get
			{
				return linphone_chat_message_get_time(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_to_address(IntPtr thiz);

		/// <summary>
		/// Get destination of the message. 
		/// </summary>
		public Address ToAddress
		{
			get
			{
				IntPtr ptr = linphone_chat_message_get_to_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_get_to_be_stored(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_set_to_be_stored(IntPtr thiz, char toBeStored);

		/// <summary>
		/// Get if a chat message is to be stored. 
		/// </summary>
		public bool ToBeStored
		{
			get
			{
				return linphone_chat_message_get_to_be_stored(nativePtr) != 0;
			}
			set
			{
				linphone_chat_message_set_to_be_stored(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_add_custom_header(IntPtr thiz, string headerName, string headerValue);

		/// <summary>
		/// Add custom headers to the message. 
		/// </summary>
		public void AddCustomHeader(string headerName, string headerValue)
		{
			linphone_chat_message_add_custom_header(nativePtr, headerName, headerValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_add_file_content(IntPtr thiz, IntPtr cContent);

		/// <summary>
		/// Adds a file content to the ChatMessage. 
		/// </summary>
		public void AddFileContent(Content cContent)
		{
			linphone_chat_message_add_file_content(nativePtr, cContent != null ? cContent.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_add_text_content(IntPtr thiz, string text);

		/// <summary>
		/// Adds a text content to the ChatMessage. 
		/// </summary>
		public void AddTextContent(string text)
		{
			linphone_chat_message_add_text_content(nativePtr, text);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_cancel_file_transfer(IntPtr thiz);

		/// <summary>
		/// Cancel an ongoing file transfer attached to this message. 
		/// </summary>
		public void CancelFileTransfer()
		{
			linphone_chat_message_cancel_file_transfer(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_download_content(IntPtr thiz, IntPtr cContent);

		/// <summary>
		/// Start the download of the <see cref="Content" /> referenced in the
		/// <see cref="ChatMessage" /> from remote server. 
		/// </summary>
		public bool DownloadContent(Content cContent)
		{
			return linphone_chat_message_download_content(nativePtr, cContent != null ? cContent.nativePtr : IntPtr.Zero) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_download_file(IntPtr thiz);

		/// <summary>
		/// Start the download of the file referenced in a <see cref="ChatMessage"
		/// /> from remote server. 
		/// </summary>
		public bool DownloadFile()
		{
			return linphone_chat_message_download_file(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_custom_header(IntPtr thiz, string headerName);

		/// <summary>
		/// Retrieve a custom header value given its name. 
		/// </summary>
		public string GetCustomHeader(string headerName)
		{
			IntPtr stringPtr = linphone_chat_message_get_custom_header(nativePtr, headerName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_message_get_participants_by_imdn_state(IntPtr thiz, int state);

		/// <summary>
		/// Gets the list of participants for which the imdn state has reached the
		/// specified state and the time at which they did. 
		/// </summary>
		public IEnumerable<ParticipantImdnState> GetParticipantsByImdnState(ChatMessageState state)
		{
			return MarshalBctbxList<ParticipantImdnState>(linphone_chat_message_get_participants_by_imdn_state(nativePtr, (int)state));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_message_has_text_content(IntPtr thiz);

		/// <summary>
		/// Returns true if the chat message has a text content. 
		/// </summary>
		public bool HasTextContent()
		{
			return linphone_chat_message_has_text_content(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_chat_message_put_char(IntPtr thiz, uint character);

		/// <summary>
		/// Fulfill a chat message char by char. 
		/// </summary>
		public void PutChar(uint character)
		{
			int exception_result = linphone_chat_message_put_char(nativePtr, character);
			if (exception_result != 0) throw new LinphoneException("PutChar returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_remove_content(IntPtr thiz, IntPtr content);

		/// <summary>
		/// Removes a content from the ChatMessage. 
		/// </summary>
		public void RemoveContent(Content content)
		{
			linphone_chat_message_remove_content(nativePtr, content != null ? content.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_remove_custom_header(IntPtr thiz, string headerName);

		/// <summary>
		/// Removes a custom header from the message. 
		/// </summary>
		public void RemoveCustomHeader(string headerName)
		{
			linphone_chat_message_remove_custom_header(nativePtr, headerName);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_resend_2(IntPtr thiz);

		/// <summary>
		/// Resend a chat message if it is in the 'not delivered' state for whatever
		/// reason. 
		/// </summary>
		public void Resend()
		{
			linphone_chat_message_resend_2(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_message_send(IntPtr thiz);

		/// <summary>
		/// Send a chat message. 
		/// </summary>
		public void Send()
		{
			linphone_chat_message_send(nativePtr);
			
		}
	}

	/// <summary>
	/// A chat room is the place where text messages are exchanged. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class ChatRoom : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_add_callbacks(IntPtr thiz, IntPtr cbs);

		/// <summary>
		/// A chat room is the place where text messages are exchanged. 
		/// </summary>
		public void AddListener(ChatRoomListener cbs)
		{
			linphone_chat_room_add_callbacks(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_remove_callbacks(IntPtr thiz, IntPtr cbs);

		/// <summary>
		/// A chat room is the place where text messages are exchanged. 
		/// </summary>
		public void RemoveListener(ChatRoomListener cbs)
		{
			linphone_chat_room_remove_callbacks(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_call(IntPtr thiz);

		/// <summary>
		/// get Curent Call associated to this chatroom if any To commit a message, use
		/// linphone_chat_room_send_message 
		/// </summary>
		public Call Call
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_call(nativePtr);
				return fromNativePtr<Call>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_chat_room_get_capabilities(IntPtr thiz);

		/// <summary>
		/// Get the capabilities of a chat room. 
		/// </summary>
		public uint Capabilities
		{
			get
			{
				return linphone_chat_room_get_capabilities(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_chat_room_get_char(IntPtr thiz);

		/// <summary>
		/// When realtime text is enabled linphone_call_params_realtime_text_enabled,
		/// LinphoneCoreIsComposingReceivedCb is call everytime a char is received from
		/// peer. 
		/// </summary>
		public uint Char
		{
			get
			{
				return linphone_chat_room_get_char(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_composing_addresses(IntPtr thiz);

		/// <summary>
		/// Gets the list of participants that are currently composing. 
		/// </summary>
		public IEnumerable<Address> ComposingAddresses
		{
			get
			{
				return MarshalBctbxList<Address>(linphone_chat_room_get_composing_addresses(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_conference_address(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_set_conference_address(IntPtr thiz, IntPtr confAddr);

		/// <summary>
		/// Get the conference address of the chat room. 
		/// </summary>
		public Address ConferenceAddress
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_conference_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
			set
			{
				linphone_chat_room_set_conference_address(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_core(IntPtr thiz);

		/// <summary>
		/// Returns back pointer to <see cref="Core" /> object. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_current_callbacks(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_set_current_callbacks(IntPtr thiz, IntPtr cbs);

		/// <summary>
		/// Gets the current LinphoneChatRoomCbs. 
		/// </summary>
		public ChatRoomListener CurrentCallbacks
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_current_callbacks(nativePtr);
				return fromNativePtr<ChatRoomListener>(ptr, true);
			}
			set
			{
				linphone_chat_room_set_current_callbacks(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_chat_room_get_history_events_size(IntPtr thiz);

		/// <summary>
		/// Gets the number of events in a chat room. 
		/// </summary>
		public int HistoryEventsSize
		{
			get
			{
				return linphone_chat_room_get_history_events_size(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_chat_room_get_history_size(IntPtr thiz);

		/// <summary>
		/// Gets the number of messages in a chat room. 
		/// </summary>
		public int HistorySize
		{
			get
			{
				return linphone_chat_room_get_history_size(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_room_is_remote_composing(IntPtr thiz);

		/// <summary>
		/// Tells whether the remote is currently composing a message. 
		/// </summary>
		public bool IsRemoteComposing
		{
			get
			{
				return linphone_chat_room_is_remote_composing(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_last_message_in_history(IntPtr thiz);

		/// <summary>
		/// Gets the last chat message sent or received in this chat room. 
		/// </summary>
		public ChatMessage LastMessageInHistory
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_last_message_in_history(nativePtr);
				return fromNativePtr<ChatMessage>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_chat_room_get_last_update_time(IntPtr thiz);

		/// <summary>
		/// Return the last updated time for the chat room. 
		/// </summary>
		public long LastUpdateTime
		{
			get
			{
				return linphone_chat_room_get_last_update_time(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_local_address(IntPtr thiz);

		/// <summary>
		/// get local address associated to  this <see cref="ChatRoom" /> 
		/// </summary>
		public Address LocalAddress
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_local_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_me(IntPtr thiz);

		/// <summary>
		/// Get the participant representing myself in the chat room. 
		/// </summary>
		public Participant Me
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_me(nativePtr);
				return fromNativePtr<Participant>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_chat_room_get_nb_participants(IntPtr thiz);

		/// <summary>
		/// Get the number of participants in the chat room (that is without ourselves). 
		/// </summary>
		public int NbParticipants
		{
			get
			{
				return linphone_chat_room_get_nb_participants(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_participants(IntPtr thiz);

		/// <summary>
		/// Get the list of participants of a chat room. 
		/// </summary>
		public IEnumerable<Participant> Participants
		{
			get
			{
				return MarshalBctbxList<Participant>(linphone_chat_room_get_participants(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_peer_address(IntPtr thiz);

		/// <summary>
		/// get peer address associated to  this <see cref="ChatRoom" /> 
		/// </summary>
		public Address PeerAddress
		{
			get
			{
				IntPtr ptr = linphone_chat_room_get_peer_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern ChatRoomState linphone_chat_room_get_state(IntPtr thiz);

		/// <summary>
		/// Get the state of the chat room. 
		/// </summary>
		public ChatRoomState State
		{
			get
			{
				return linphone_chat_room_get_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_subject(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_set_subject(IntPtr thiz, string subject);

		/// <summary>
		/// Get the subject of a chat room. 
		/// </summary>
		public string Subject
		{
			get
			{
				IntPtr stringPtr = linphone_chat_room_get_subject(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_chat_room_set_subject(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_chat_room_get_unread_messages_count(IntPtr thiz);

		/// <summary>
		/// Gets the number of unread messages in the chatroom. 
		/// </summary>
		public int UnreadMessagesCount
		{
			get
			{
				return linphone_chat_room_get_unread_messages_count(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_add_compatible_participants(IntPtr thiz, IntPtr deviceAddr, IntPtr participantsCompatible);

		/// <summary>
		/// Set the participant device. 
		/// </summary>
		public void AddCompatibleParticipants(Address deviceAddr, IEnumerable<Address> participantsCompatible)
		{
			linphone_chat_room_add_compatible_participants(nativePtr, deviceAddr != null ? deviceAddr.nativePtr : IntPtr.Zero, ObjectArrayToBctbxList<Address>(participantsCompatible));
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_add_participant(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Add a participant to a chat room. 
		/// </summary>
		public void AddParticipant(Address addr)
		{
			linphone_chat_room_add_participant(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_add_participant_device(IntPtr thiz, IntPtr participantAddress, IntPtr deviceAddress);

		/// <summary>
		/// Add a participant device. 
		/// </summary>
		public void AddParticipantDevice(Address participantAddress, Address deviceAddress)
		{
			linphone_chat_room_add_participant_device(nativePtr, participantAddress != null ? participantAddress.nativePtr : IntPtr.Zero, deviceAddress != null ? deviceAddress.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_add_participants(IntPtr thiz, IntPtr addresses);

		/// <summary>
		/// Add several participants to a chat room at once. 
		/// </summary>
		public void AddParticipants(IEnumerable<Address> addresses)
		{
			linphone_chat_room_add_participants(nativePtr, ObjectArrayToBctbxList<Address>(addresses));
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_room_can_handle_participants(IntPtr thiz);

		/// <summary>
		/// Tells whether a chat room is able to handle participants. 
		/// </summary>
		public bool CanHandleParticipants()
		{
			return linphone_chat_room_can_handle_participants(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_compose(IntPtr thiz);

		/// <summary>
		/// Notifies the destination of the chat message being composed that the user is
		/// typing a new message. 
		/// </summary>
		public void Compose()
		{
			linphone_chat_room_compose(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_create_empty_message(IntPtr thiz);

		/// <summary>
		/// Creates an empty message attached to a dedicated chat room. 
		/// </summary>
		public ChatMessage CreateEmptyMessage()
		{
			IntPtr ptr = linphone_chat_room_create_empty_message(nativePtr);
			return fromNativePtr<ChatMessage>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_create_file_transfer_message(IntPtr thiz, IntPtr initialContent);

		/// <summary>
		/// Creates a message attached to a dedicated chat room with a particular content. 
		/// </summary>
		public ChatMessage CreateFileTransferMessage(Content initialContent)
		{
			IntPtr ptr = linphone_chat_room_create_file_transfer_message(nativePtr, initialContent != null ? initialContent.nativePtr : IntPtr.Zero);
			return fromNativePtr<ChatMessage>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_create_message(IntPtr thiz, string message);

		/// <summary>
		/// Creates a message attached to a dedicated chat room. 
		/// </summary>
		public ChatMessage CreateMessage(string message)
		{
			IntPtr ptr = linphone_chat_room_create_message(nativePtr, message);
			return fromNativePtr<ChatMessage>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_delete_history(IntPtr thiz);

		/// <summary>
		/// Delete all messages from the history. 
		/// </summary>
		public void DeleteHistory()
		{
			linphone_chat_room_delete_history(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_delete_message(IntPtr thiz, IntPtr msg);

		/// <summary>
		/// Delete a message from the chat room history. 
		/// </summary>
		public void DeleteMessage(ChatMessage msg)
		{
			linphone_chat_room_delete_message(nativePtr, msg != null ? msg.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_find_message(IntPtr thiz, string messageId);

		/// <summary>
		/// Gets the chat message sent or received in this chat room that matches the
		/// message_id. 
		/// </summary>
		public ChatMessage FindMessage(string messageId)
		{
			IntPtr ptr = linphone_chat_room_find_message(nativePtr, messageId);
			return fromNativePtr<ChatMessage>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_find_participant(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Find a participant of a chat room from its address. 
		/// </summary>
		public Participant FindParticipant(Address addr)
		{
			IntPtr ptr = linphone_chat_room_find_participant(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero);
			return fromNativePtr<Participant>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_history(IntPtr thiz, int nbMessage);

		/// <summary>
		/// Gets nb_message most recent messages from cr chat room, sorted from oldest to
		/// most recent. 
		/// </summary>
		public IEnumerable<ChatMessage> GetHistory(int nbMessage)
		{
			return MarshalBctbxList<ChatMessage>(linphone_chat_room_get_history(nativePtr, nbMessage));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_history_events(IntPtr thiz, int nbEvents);

		/// <summary>
		/// Gets nb_events most recent events from cr chat room, sorted from oldest to most
		/// recent. 
		/// </summary>
		public IEnumerable<EventLog> GetHistoryEvents(int nbEvents)
		{
			return MarshalBctbxList<EventLog>(linphone_chat_room_get_history_events(nativePtr, nbEvents));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_history_message_events(IntPtr thiz, int nbEvents);

		/// <summary>
		/// Gets nb_events most recent chat message events from cr chat room, sorted from
		/// oldest to most recent. 
		/// </summary>
		public IEnumerable<EventLog> GetHistoryMessageEvents(int nbEvents)
		{
			return MarshalBctbxList<EventLog>(linphone_chat_room_get_history_message_events(nativePtr, nbEvents));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_history_range(IntPtr thiz, int begin, int end);

		/// <summary>
		/// Gets the partial list of messages in the given range, sorted from oldest to
		/// most recent. 
		/// </summary>
		public IEnumerable<ChatMessage> GetHistoryRange(int begin, int end)
		{
			return MarshalBctbxList<ChatMessage>(linphone_chat_room_get_history_range(nativePtr, begin, end));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_history_range_events(IntPtr thiz, int begin, int end);

		/// <summary>
		/// Gets the partial list of events in the given range, sorted from oldest to most
		/// recent. 
		/// </summary>
		public IEnumerable<EventLog> GetHistoryRangeEvents(int begin, int end)
		{
			return MarshalBctbxList<EventLog>(linphone_chat_room_get_history_range_events(nativePtr, begin, end));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_chat_room_get_history_range_message_events(IntPtr thiz, int begin, int end);

		/// <summary>
		/// Gets the partial list of chat message events in the given range, sorted from
		/// oldest to most recent. 
		/// </summary>
		public IEnumerable<EventLog> GetHistoryRangeMessageEvents(int begin, int end)
		{
			return MarshalBctbxList<EventLog>(linphone_chat_room_get_history_range_message_events(nativePtr, begin, end));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_room_has_been_left(IntPtr thiz);

		/// <summary>
		/// Return whether or not the chat room has been left. 
		/// </summary>
		public bool HasBeenLeft()
		{
			return linphone_chat_room_has_been_left(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_room_has_capability(IntPtr thiz, int mask);

		/// <summary>
		/// Check if a chat room has given capabilities. 
		/// </summary>
		public bool HasCapability(int mask)
		{
			return linphone_chat_room_has_capability(nativePtr, mask) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_leave(IntPtr thiz);

		/// <summary>
		/// Leave a chat room. 
		/// </summary>
		public void Leave()
		{
			linphone_chat_room_leave(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_chat_room_lime_available(IntPtr thiz);

		/// <summary>
		/// Returns true if lime is available for given peer. 
		/// </summary>
		public bool LimeAvailable()
		{
			return linphone_chat_room_lime_available(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_mark_as_read(IntPtr thiz);

		/// <summary>
		/// Mark all messages of the conversation as read. 
		/// </summary>
		public void MarkAsRead()
		{
			linphone_chat_room_mark_as_read(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_receive_chat_message(IntPtr thiz, IntPtr msg);

		/// <summary>
		/// Used to receive a chat message when using async mechanism with IM encryption
		/// engine. 
		/// </summary>
		public void ReceiveChatMessage(ChatMessage msg)
		{
			linphone_chat_room_receive_chat_message(nativePtr, msg != null ? msg.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_remove_participant(IntPtr thiz, IntPtr participant);

		/// <summary>
		/// Remove a participant of a chat room. 
		/// </summary>
		public void RemoveParticipant(Participant participant)
		{
			linphone_chat_room_remove_participant(nativePtr, participant != null ? participant.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_remove_participants(IntPtr thiz, IntPtr participants);

		/// <summary>
		/// Remove several participants of a chat room at once. 
		/// </summary>
		public void RemoveParticipants(IEnumerable<Participant> participants)
		{
			linphone_chat_room_remove_participants(nativePtr, ObjectArrayToBctbxList<Participant>(participants));
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_send_chat_message_2(IntPtr thiz, IntPtr msg);

		/// <summary>
		/// Send a message to peer member of this chat room. 
		/// </summary>
		public void SendChatMessage(ChatMessage msg)
		{
			linphone_chat_room_send_chat_message_2(nativePtr, msg != null ? msg.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_set_participant_admin_status(IntPtr thiz, IntPtr participant, char isAdmin);

		/// <summary>
		/// Change the admin status of a participant of a chat room (you need to be an
		/// admin yourself to do this). 
		/// </summary>
		public void SetParticipantAdminStatus(Participant participant, bool isAdmin)
		{
			linphone_chat_room_set_participant_admin_status(nativePtr, participant != null ? participant.nativePtr : IntPtr.Zero, isAdmin ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_chat_room_set_participant_devices(IntPtr thiz, IntPtr partAddr, IntPtr partDevices);

		/// <summary>
		/// Set the participant device. 
		/// </summary>
		public void SetParticipantDevices(Address partAddr, IEnumerable<Address> partDevices)
		{
			linphone_chat_room_set_participant_devices(nativePtr, partAddr != null ? partAddr.nativePtr : IntPtr.Zero, ObjectArrayToBctbxList<Address>(partDevices));
			
		}
	}

	/// <summary>
	/// <see cref="Conference" /> class The _LinphoneConference struct does
	/// not exists, it's the Conference C++ class that is used behind 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Conference : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_conference_get_ID(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_conference_set_ID(IntPtr thiz, string conferenceID);

		/// <summary>
		/// Get the conference id as string. 
		/// </summary>
		public string Id
		{
			get
			{
				IntPtr stringPtr = linphone_conference_get_ID(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_conference_set_ID(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_conference_get_participants(IntPtr thiz);

		/// <summary>
		/// Get URIs of all participants of one conference The returned bctbx_list_t
		/// contains URIs of all participant. 
		/// </summary>
		public IEnumerable<Address> Participants
		{
			get
			{
				return MarshalBctbxList<Address>(linphone_conference_get_participants(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_conference_invite_participants(IntPtr thiz, IntPtr addresses, IntPtr parameters);

		/// <summary>
		/// Invite participants to the conference, by supplying a list of <see
		/// cref="Address" />. 
		/// </summary>
		public void InviteParticipants(IEnumerable<Address> addresses, CallParams parameters)
		{
			int exception_result = linphone_conference_invite_participants(nativePtr, ObjectArrayToBctbxList<Address>(addresses), parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("InviteParticipants returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_conference_remove_participant(IntPtr thiz, IntPtr uri);

		/// <summary>
		/// Remove a participant from a conference. 
		/// </summary>
		public void RemoveParticipant(Address uri)
		{
			int exception_result = linphone_conference_remove_participant(nativePtr, uri != null ? uri.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("RemoveParticipant returned value" + exception_result);
		}
	}

	/// <summary>
	/// Parameters for initialization of conferences The _LinphoneConferenceParams
	/// struct does not exists, it's the ConferenceParams C++ class that is used
	/// behind. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class ConferenceParams : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_conference_params_enable_video(IntPtr thiz, char enable);

		/// <summary>
		/// Enable video when starting a conference. 
		/// </summary>
		public bool VideoEnabled
		{
			set
			{
				linphone_conference_params_enable_video(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_conference_params_clone(IntPtr thiz);

		/// <summary>
		/// Clone a <see cref="ConferenceParams" />. 
		/// </summary>
		public ConferenceParams Clone()
		{
			IntPtr ptr = linphone_conference_params_clone(nativePtr);
			return fromNativePtr<ConferenceParams>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_conference_params_video_requested(IntPtr thiz);

		/// <summary>
		/// Check whether video will be enable at conference starting. 
		/// </summary>
		public bool VideoRequested()
		{
			return linphone_conference_params_video_requested(nativePtr) == (char)0 ? false : true;
		}
	}

	/// <summary>
	/// The <see cref="Config" /> object is used to manipulate a configuration
	/// file. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Config : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_new_from_buffer(string buffer);

		/// <summary>
		/// Instantiates a <see cref="Config" /> object from a user provided
		/// buffer. 
		/// </summary>
		public static Config NewFromBuffer(string buffer)
		{
			IntPtr ptr = linphone_config_new_from_buffer(buffer);
			return fromNativePtr<Config>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_new_with_factory(string configFilename, string factoryConfigFilename);

		/// <summary>
		/// Instantiates a <see cref="Config" /> object from a user config file
		/// and a factory config file. 
		/// </summary>
		public static Config NewWithFactory(string configFilename, string factoryConfigFilename)
		{
			IntPtr ptr = linphone_config_new_with_factory(configFilename, factoryConfigFilename);
			return fromNativePtr<Config>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_get_sections_names_list(IntPtr thiz);

		/// <summary>
		/// Returns the list of sections' names in the LinphoneConfig. 
		/// </summary>
		public IEnumerable<string> SectionsNamesList
		{
			get
			{
				return MarshalStringArray(linphone_config_get_sections_names_list(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_clean_entry(IntPtr thiz, string section, string key);

		/// <summary>
		/// Removes entries for key,value in a section. 
		/// </summary>
		public void CleanEntry(string section, string key)
		{
			linphone_config_clean_entry(nativePtr, section, key);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_clean_section(IntPtr thiz, string section);

		/// <summary>
		/// Removes every pair of key,value in a section and remove the section. 
		/// </summary>
		public void CleanSection(string section)
		{
			linphone_config_clean_section(nativePtr, section);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_dump(IntPtr thiz);

		/// <summary>
		/// Dumps the <see cref="Config" /> as INI into a buffer. 
		/// </summary>
		public string Dump()
		{
			IntPtr stringPtr = linphone_config_dump(nativePtr);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_dump_as_xml(IntPtr thiz);

		/// <summary>
		/// Dumps the <see cref="Config" /> as XML into a buffer. 
		/// </summary>
		public string DumpAsXml()
		{
			IntPtr stringPtr = linphone_config_dump_as_xml(nativePtr);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_config_get_bool(IntPtr thiz, string section, string key, char defaultValue);

		/// <summary>
		/// Retrieves a configuration item as a boolean, given its section, key, and
		/// default value. 
		/// </summary>
		public bool GetBool(string section, string key, bool defaultValue)
		{
			return linphone_config_get_bool(nativePtr, section, key, defaultValue ? (char)1 : (char)0) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_config_get_default_float(IntPtr thiz, string section, string key, float defaultValue);

		/// <summary>
		/// Retrieves a default configuration item as a float, given its section, key, and
		/// default value. 
		/// </summary>
		public float GetDefaultFloat(string section, string key, float defaultValue)
		{
			return linphone_config_get_default_float(nativePtr, section, key, defaultValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_get_default_int(IntPtr thiz, string section, string key, int defaultValue);

		/// <summary>
		/// Retrieves a default configuration item as an integer, given its section, key,
		/// and default value. 
		/// </summary>
		public int GetDefaultInt(string section, string key, int defaultValue)
		{
			return linphone_config_get_default_int(nativePtr, section, key, defaultValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_get_default_int64(IntPtr thiz, string section, string key, int defaultValue);

		/// <summary>
		/// Retrieves a default configuration item as a 64 bit integer, given its section,
		/// key, and default value. 
		/// </summary>
		public int GetDefaultInt64(string section, string key, int defaultValue)
		{
			return linphone_config_get_default_int64(nativePtr, section, key, defaultValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_get_default_string(IntPtr thiz, string section, string key, string defaultValue);

		/// <summary>
		/// Retrieves a default configuration item as a string, given its section, key, and
		/// default value. 
		/// </summary>
		public string GetDefaultString(string section, string key, string defaultValue)
		{
			IntPtr stringPtr = linphone_config_get_default_string(nativePtr, section, key, defaultValue);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_config_get_float(IntPtr thiz, string section, string key, float defaultValue);

		/// <summary>
		/// Retrieves a configuration item as a float, given its section, key, and default
		/// value. 
		/// </summary>
		public float GetFloat(string section, string key, float defaultValue)
		{
			return linphone_config_get_float(nativePtr, section, key, defaultValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_get_int(IntPtr thiz, string section, string key, int defaultValue);

		/// <summary>
		/// Retrieves a configuration item as an integer, given its section, key, and
		/// default value. 
		/// </summary>
		public int GetInt(string section, string key, int defaultValue)
		{
			return linphone_config_get_int(nativePtr, section, key, defaultValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_get_int64(IntPtr thiz, string section, string key, int defaultValue);

		/// <summary>
		/// Retrieves a configuration item as a 64 bit integer, given its section, key, and
		/// default value. 
		/// </summary>
		public int GetInt64(string section, string key, int defaultValue)
		{
			return linphone_config_get_int64(nativePtr, section, key, defaultValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_config_get_overwrite_flag_for_entry(IntPtr thiz, string section, string key);

		/// <summary>
		/// Retrieves the overwrite flag for a config item. 
		/// </summary>
		public bool GetOverwriteFlagForEntry(string section, string key)
		{
			return linphone_config_get_overwrite_flag_for_entry(nativePtr, section, key) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_config_get_overwrite_flag_for_section(IntPtr thiz, string section);

		/// <summary>
		/// Retrieves the overwrite flag for a config section. 
		/// </summary>
		public bool GetOverwriteFlagForSection(string section)
		{
			return linphone_config_get_overwrite_flag_for_section(nativePtr, section) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_config_get_range(IntPtr thiz, string section, string key, int min, int max, int defaultMin, int defaultMax);

		/// <summary>
		/// Retrieves a configuration item as a range, given its section, key, and default
		/// min and max values. 
		/// </summary>
		public bool GetRange(string section, string key, int min, int max, int defaultMin, int defaultMax)
		{
			return linphone_config_get_range(nativePtr, section, key, min, max, defaultMin, defaultMax) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_get_section_param_string(IntPtr thiz, string section, string key, string defaultValue);

		/// <summary>
		/// Retrieves a section parameter item as a string, given its section and key. 
		/// </summary>
		public string GetSectionParamString(string section, string key, string defaultValue)
		{
			IntPtr stringPtr = linphone_config_get_section_param_string(nativePtr, section, key, defaultValue);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_config_get_skip_flag_for_entry(IntPtr thiz, string section, string key);

		/// <summary>
		/// Retrieves the skip flag for a config item. 
		/// </summary>
		public bool GetSkipFlagForEntry(string section, string key)
		{
			return linphone_config_get_skip_flag_for_entry(nativePtr, section, key) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_config_get_skip_flag_for_section(IntPtr thiz, string section);

		/// <summary>
		/// Retrieves the skip flag for a config section. 
		/// </summary>
		public bool GetSkipFlagForSection(string section)
		{
			return linphone_config_get_skip_flag_for_section(nativePtr, section) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_get_string(IntPtr thiz, string section, string key, string defaultString);

		/// <summary>
		/// Retrieves a configuration item as a string, given its section, key, and default
		/// value. 
		/// </summary>
		public string GetString(string section, string key, string defaultString)
		{
			IntPtr stringPtr = linphone_config_get_string(nativePtr, section, key, defaultString);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_get_string_list(IntPtr thiz, string section, string key, IntPtr defaultList);

		/// <summary>
		/// Retrieves a configuration item as a list of strings, given its section, key,
		/// and default value. 
		/// </summary>
		public IEnumerable<string> GetStringList(string section, string key, IEnumerable<string> defaultList)
		{
			return MarshalStringArray(linphone_config_get_string_list(nativePtr, section, key, StringArrayToBctbxList(defaultList)));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_has_entry(IntPtr thiz, string section, string key);

		/// <summary>
		/// Returns 1 if a given section with a given key is present in the configuration. 
		/// </summary>
		public int HasEntry(string section, string key)
		{
			return linphone_config_has_entry(nativePtr, section, key);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_has_section(IntPtr thiz, string section);

		/// <summary>
		/// Returns 1 if a given section is present in the configuration. 
		/// </summary>
		public int HasSection(string section)
		{
			return linphone_config_has_section(nativePtr, section);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_config_load_from_xml_file(IntPtr thiz, string filename);

		/// <summary>
		/// Reads a xml config file and fill the <see cref="Config" /> with the
		/// read config dynamic values. 
		/// </summary>
		public string LoadFromXmlFile(string filename)
		{
			IntPtr stringPtr = linphone_config_load_from_xml_file(nativePtr, filename);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_load_from_xml_string(IntPtr thiz, string buffer);

		/// <summary>
		/// Reads a xml config string and fill the <see cref="Config" /> with the
		/// read config dynamic values. 
		/// </summary>
		public void LoadFromXmlString(string buffer)
		{
			int exception_result = linphone_config_load_from_xml_string(nativePtr, buffer);
			if (exception_result != 0) throw new LinphoneException("LoadFromXmlString returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_read_file(IntPtr thiz, string filename);

		/// <summary>
		/// Reads a user config file and fill the <see cref="Config" /> with the
		/// read config values. 
		/// </summary>
		public void ReadFile(string filename)
		{
			int exception_result = linphone_config_read_file(nativePtr, filename);
			if (exception_result != 0) throw new LinphoneException("ReadFile returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_config_relative_file_exists(IntPtr thiz, string filename);

		public bool RelativeFileExists(string filename)
		{
			return linphone_config_relative_file_exists(nativePtr, filename) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_bool(IntPtr thiz, string section, string key, char val);

		/// <summary>
		/// Sets a boolean config item. 
		/// </summary>
		public void SetBool(string section, string key, bool val)
		{
			linphone_config_set_bool(nativePtr, section, key, val ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_float(IntPtr thiz, string section, string key, float val);

		/// <summary>
		/// Sets a float config item. 
		/// </summary>
		public void SetFloat(string section, string key, float val)
		{
			linphone_config_set_float(nativePtr, section, key, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_int(IntPtr thiz, string section, string key, int val);

		/// <summary>
		/// Sets an integer config item. 
		/// </summary>
		public void SetInt(string section, string key, int val)
		{
			linphone_config_set_int(nativePtr, section, key, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_int64(IntPtr thiz, string section, string key, int val);

		/// <summary>
		/// Sets a 64 bits integer config item. 
		/// </summary>
		public void SetInt64(string section, string key, int val)
		{
			linphone_config_set_int64(nativePtr, section, key, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_int_hex(IntPtr thiz, string section, string key, int val);

		/// <summary>
		/// Sets an integer config item, but store it as hexadecimal. 
		/// </summary>
		public void SetIntHex(string section, string key, int val)
		{
			linphone_config_set_int_hex(nativePtr, section, key, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_overwrite_flag_for_entry(IntPtr thiz, string section, string key, char val);

		/// <summary>
		/// Sets the overwrite flag for a config item (used when dumping config as xml) 
		/// </summary>
		public void SetOverwriteFlagForEntry(string section, string key, bool val)
		{
			linphone_config_set_overwrite_flag_for_entry(nativePtr, section, key, val ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_overwrite_flag_for_section(IntPtr thiz, string section, char val);

		/// <summary>
		/// Sets the overwrite flag for a config section (used when dumping config as xml) 
		/// </summary>
		public void SetOverwriteFlagForSection(string section, bool val)
		{
			linphone_config_set_overwrite_flag_for_section(nativePtr, section, val ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_range(IntPtr thiz, string section, string key, int minValue, int maxValue);

		/// <summary>
		/// Sets a range config item. 
		/// </summary>
		public void SetRange(string section, string key, int minValue, int maxValue)
		{
			linphone_config_set_range(nativePtr, section, key, minValue, maxValue);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_skip_flag_for_entry(IntPtr thiz, string section, string key, char val);

		/// <summary>
		/// Sets the skip flag for a config item (used when dumping config as xml) 
		/// </summary>
		public void SetSkipFlagForEntry(string section, string key, bool val)
		{
			linphone_config_set_skip_flag_for_entry(nativePtr, section, key, val ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_skip_flag_for_section(IntPtr thiz, string section, char val);

		/// <summary>
		/// Sets the skip flag for a config section (used when dumping config as xml) 
		/// </summary>
		public void SetSkipFlagForSection(string section, bool val)
		{
			linphone_config_set_skip_flag_for_section(nativePtr, section, val ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_string(IntPtr thiz, string section, string key, string val);

		/// <summary>
		/// Sets a string config item. 
		/// </summary>
		public void SetString(string section, string key, string val)
		{
			linphone_config_set_string(nativePtr, section, key, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_set_string_list(IntPtr thiz, string section, string key, IntPtr val);

		/// <summary>
		/// Sets a string list config item. 
		/// </summary>
		public void SetStringList(string section, string key, IEnumerable<string> val)
		{
			linphone_config_set_string_list(nativePtr, section, key, StringArrayToBctbxList(val));
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_config_sync(IntPtr thiz);

		/// <summary>
		/// Writes the config file to disk. 
		/// </summary>
		public void Sync()
		{
			int exception_result = linphone_config_sync(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Sync returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_config_write_relative_file(IntPtr thiz, string filename, string data);

		/// <summary>
		/// Write a string in a file placed relatively with the Linphone configuration
		/// file. 
		/// </summary>
		public void WriteRelativeFile(string filename, string data)
		{
			linphone_config_write_relative_file(nativePtr, filename, data);
			
		}
	}

	/// <summary>
	/// The LinphoneContent object holds data that can be embedded in a signaling
	/// message. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Content : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_content_get_buffer(IntPtr thiz);

		/// <summary>
		/// Get the content data buffer, usually a string. 
		/// </summary>
		public uint Buffer
		{
			get
			{
				return linphone_content_get_buffer(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_encoding(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_encoding(IntPtr thiz, string encoding);

		/// <summary>
		/// Get the encoding of the data buffer, for example "gzip". 
		/// </summary>
		public string Encoding
		{
			get
			{
				IntPtr stringPtr = linphone_content_get_encoding(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_content_set_encoding(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_file_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_file_path(IntPtr thiz, string filePath);

		/// <summary>
		/// Get the file transfer filepath set for this content (replace
		/// linphone_chat_message_get_file_transfer_filepath). 
		/// </summary>
		public string FilePath
		{
			get
			{
				IntPtr stringPtr = linphone_content_get_file_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_content_set_file_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_content_get_file_size(IntPtr thiz);

		/// <summary>
		/// Get the file size if content is either a FileContent or a FileTransferContent. 
		/// </summary>
		public long FileSize
		{
			get
			{
				return linphone_content_get_file_size(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_content_is_file(IntPtr thiz);

		/// <summary>
		/// Tells whether or not this content contains a file. 
		/// </summary>
		public bool IsFile
		{
			get
			{
				return linphone_content_is_file(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_content_is_file_transfer(IntPtr thiz);

		/// <summary>
		/// Tells whether or not this content is a file transfer. 
		/// </summary>
		public bool IsFileTransfer
		{
			get
			{
				return linphone_content_is_file_transfer(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_content_is_multipart(IntPtr thiz);

		/// <summary>
		/// Tell whether a content is a multipart content. 
		/// </summary>
		public bool IsMultipart
		{
			get
			{
				return linphone_content_is_multipart(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_content_is_text(IntPtr thiz);

		/// <summary>
		/// Tells whether or not this content contains text. 
		/// </summary>
		public bool IsText
		{
			get
			{
				return linphone_content_is_text(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_key(IntPtr thiz);

		/// <summary>
		/// Get the key associated with a RCS file transfer message if encrypted. 
		/// </summary>
		public string Key
		{
			get
			{
				IntPtr stringPtr = linphone_content_get_key(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_content_get_key_size(IntPtr thiz);

		/// <summary>
		/// Get the size of key associated with a RCS file transfer message if encrypted. 
		/// </summary>
		public long KeySize
		{
			get
			{
				return linphone_content_get_key_size(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_name(IntPtr thiz, string name);

		/// <summary>
		/// Get the name associated with a RCS file transfer message. 
		/// </summary>
		public string Name
		{
			get
			{
				IntPtr stringPtr = linphone_content_get_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_content_set_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_content_get_size(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_size(IntPtr thiz, long size);

		/// <summary>
		/// Get the content data buffer size, excluding null character despite null
		/// character is always set for convenience. 
		/// </summary>
		public long Size
		{
			get
			{
				return linphone_content_get_size(nativePtr);
			}
			set
			{
				linphone_content_set_size(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_string_buffer(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_string_buffer(IntPtr thiz, string buffer);

		/// <summary>
		/// Get the string content data buffer. 
		/// </summary>
		public string StringBuffer
		{
			get
			{
				IntPtr stringPtr = linphone_content_get_string_buffer(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_content_set_string_buffer(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_subtype(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_subtype(IntPtr thiz, string subtype);

		/// <summary>
		/// Get the mime subtype of the content data. 
		/// </summary>
		public string Subtype
		{
			get
			{
				IntPtr stringPtr = linphone_content_get_subtype(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_content_set_subtype(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_type(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_type(IntPtr thiz, string type);

		/// <summary>
		/// Get the mime type of the content data. 
		/// </summary>
		public string Type
		{
			get
			{
				IntPtr stringPtr = linphone_content_get_type(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_content_set_type(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_add_content_type_parameter(IntPtr thiz, string name, string val);

		/// <summary>
		/// Adds a parameter to the ContentType header. 
		/// </summary>
		public void AddContentTypeParameter(string name, string val)
		{
			linphone_content_add_content_type_parameter(nativePtr, name, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_find_part_by_header(IntPtr thiz, string headerName, string headerValue);

		/// <summary>
		/// Find a part from a multipart content looking for a part header with a specified
		/// value. 
		/// </summary>
		public Content FindPartByHeader(string headerName, string headerValue)
		{
			IntPtr ptr = linphone_content_find_part_by_header(nativePtr, headerName, headerValue);
			return fromNativePtr<Content>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_custom_header(IntPtr thiz, string headerName);

		/// <summary>
		/// Get a custom header value of a content. 
		/// </summary>
		public string GetCustomHeader(string headerName)
		{
			IntPtr stringPtr = linphone_content_get_custom_header(nativePtr, headerName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_content_get_part(IntPtr thiz, int idx);

		/// <summary>
		/// Get a part from a multipart content according to its index. 
		/// </summary>
		public Content GetPart(int idx)
		{
			IntPtr ptr = linphone_content_get_part(nativePtr, idx);
			return fromNativePtr<Content>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_buffer(IntPtr thiz, uint buffer, long size);

		/// <summary>
		/// Set the content data buffer, usually a string. 
		/// </summary>
		public void SetBuffer(uint buffer, long size)
		{
			linphone_content_set_buffer(nativePtr, buffer, size);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_content_set_key(IntPtr thiz, string key, long keyLength);

		/// <summary>
		/// Set the key associated with a RCS file transfer message if encrypted. 
		/// </summary>
		public void SetKey(string key, long keyLength)
		{
			linphone_content_set_key(nativePtr, key, keyLength);
			
		}
	}

	/// <summary>
	/// Linphone core main object created by function linphone_core_new . 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Core : LinphoneObject
	{

		/// Get the native window handle of the video window.
		public string NativeVideoWindowIdString
		{
			get
			{
				return Marshal.PtrToStringUni(linphone_core_get_native_video_window_id(nativePtr));
			}
			set
			{
				linphone_core_set_native_video_window_id(nativePtr, Marshal.StringToHGlobalUni(value));
			}
		}

		/// Get the native window handle of the video preview window.
		public string NativePreviewWindowIdString
		{
			get
			{
				return Marshal.PtrToStringUni(linphone_core_get_native_preview_window_id(nativePtr));
			}
			set
			{
				linphone_core_set_native_preview_window_id(nativePtr, Marshal.StringToHGlobalUni(value));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_add_callbacks(IntPtr thiz, IntPtr cbs);

		/// <summary>
		/// Linphone core main object created by function linphone_core_new . 
		/// </summary>
		public void AddListener(CoreListener cbs)
		{
			linphone_core_add_callbacks(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_remove_callbacks(IntPtr thiz, IntPtr cbs);

		/// <summary>
		/// Linphone core main object created by function linphone_core_new . 
		/// </summary>
		public void RemoveListener(CoreListener cbs)
		{
			linphone_core_remove_callbacks(nativePtr, cbs != null ? cbs.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_compress_log_collection();

		/// <summary>
		/// Compress the log collection in a single file. 
		/// </summary>
		public static string CompressLogCollection()
		{
			IntPtr stringPtr = linphone_core_compress_log_collection();
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_log_collection(int state);

		/// <summary>
		/// Enable the linphone core log collection to upload logs on a server. 
		/// </summary>
		public static void EnableLogCollection(LogCollectionState state)
		{
			linphone_core_enable_log_collection((int)state);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_core_get_log_collection_max_file_size();

		/// <summary>
		/// Get the max file size in bytes of the files used for log collection. 
		/// </summary>
		static public long LogCollectionMaxFileSize
		{
			get
			{
				return linphone_core_get_log_collection_max_file_size();
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_log_collection_path();

		/// <summary>
		/// Get the path where the log files will be written for log collection. 
		/// </summary>
		static public string LogCollectionPath
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_log_collection_path();
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_log_collection_prefix();

		/// <summary>
		/// Get the prefix of the filenames that will be used for log collection. 
		/// </summary>
		static public string LogCollectionPrefix
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_log_collection_prefix();
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_core_get_log_level_mask();

		/// <summary>
		/// Get defined log level mask. 
		/// </summary>
		static public uint LogLevelMask
		{
			get
			{
				return linphone_core_get_log_level_mask();
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_version();

		/// <summary>
		/// Returns liblinphone's version as a string. 
		/// </summary>
		static public string Version
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_version();
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern LogCollectionState linphone_core_log_collection_enabled();

		/// <summary>
		/// Tells whether the linphone core log collection is enabled. 
		/// </summary>
		public static LogCollectionState LogCollectionEnabled()
		{
			return linphone_core_log_collection_enabled();
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_reset_log_collection();

		/// <summary>
		/// Reset the log collection by removing the log files. 
		/// </summary>
		public static void ResetLogCollection()
		{
			linphone_core_reset_log_collection();
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_serialize_logs();

		/// <summary>
		/// Enable logs serialization (output logs from either the thread that creates the
		/// linphone core or the thread that calls <see cref="Core.Iterate()" />). 
		/// </summary>
		public static void SerializeLogs()
		{
			linphone_core_serialize_logs();
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_log_collection_max_file_size(long size);

		/// <summary>
		/// Set the max file size in bytes of the files used for log collection. 
		/// </summary>
		public static void SetLogCollectionMaxFileSize(long size)
		{
			linphone_core_set_log_collection_max_file_size(size);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_log_collection_path(string path);

		/// <summary>
		/// Set the path of a directory where the log files will be written for log
		/// collection. 
		/// </summary>
		public static void SetLogCollectionPath(string path)
		{
			linphone_core_set_log_collection_path(path);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_log_collection_prefix(string prefix);

		/// <summary>
		/// Set the prefix of the filenames that will be used for log collection. 
		/// </summary>
		public static void SetLogCollectionPrefix(string prefix)
		{
			linphone_core_set_log_collection_prefix(prefix);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_log_level_mask(uint mask);
		/// <summary>
		/// Define the log level using mask. 
		/// </summary>
		public static void SetLogLevelMask(uint mask)
		{
			linphone_core_set_log_level_mask(mask);
		}

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        public static extern void linphone_core_set_log_level(OrtpLogLevel loglevel);
        /// <summary>
        /// Define the log level.
        /// </summary>
        /// <param name="level"></param>
        public static void SetLogLevel(OrtpLogLevel level)
        {
            linphone_core_set_log_level(level);
        }

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_tunnel_available();
		/// <summary>
		/// True if tunnel support was compiled. 
		/// </summary>
		public static bool TunnelAvailable()
		{
			return linphone_core_tunnel_available() == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_upnp_available();

		/// <summary>
		/// Return the availability of uPnP. 
		/// </summary>
		public static bool UpnpAvailable()
		{
			return linphone_core_upnp_available() == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_vcard_supported();

		/// <summary>
		/// Tells whether VCARD support is builtin. 
		/// </summary>
		public static bool VcardSupported()
		{
			return linphone_core_vcard_supported() == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_adaptive_rate_algorithm(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_adaptive_rate_algorithm(IntPtr thiz, string algorithm);

		/// <summary>
		/// Returns which adaptive rate algorithm is currently configured for future calls. 
		/// </summary>
		public string AdaptiveRateAlgorithm
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_adaptive_rate_algorithm(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_adaptive_rate_algorithm(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_adaptive_rate_control_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_adaptive_rate_control(IntPtr thiz, char enabled);

		/// <summary>
		/// Returns whether adaptive rate control is enabled. 
		/// </summary>
		public bool AdaptiveRateControlEnabled
		{
			get
			{
				return linphone_core_adaptive_rate_control_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_adaptive_rate_control(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_audio_adaptive_jittcomp_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_audio_adaptive_jittcomp(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether the audio adaptive jitter compensation is enabled. 
		/// </summary>
		public bool AudioAdaptiveJittcompEnabled
		{
			get
			{
				return linphone_core_audio_adaptive_jittcomp_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_audio_adaptive_jittcomp(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_audio_dscp(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_audio_dscp(IntPtr thiz, int dscp);

		/// <summary>
		/// Get the DSCP field for outgoing audio streams. 
		/// </summary>
		public int AudioDscp
		{
			get
			{
				return linphone_core_get_audio_dscp(nativePtr);
			}
			set
			{
				linphone_core_set_audio_dscp(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_audio_jittcomp(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_audio_jittcomp(IntPtr thiz, int milliseconds);

		/// <summary>
		/// Returns the nominal audio jitter buffer size in milliseconds. 
		/// </summary>
		public int AudioJittcomp
		{
			get
			{
				return linphone_core_get_audio_jittcomp(nativePtr);
			}
			set
			{
				linphone_core_set_audio_jittcomp(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_audio_multicast_addr(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_audio_multicast_addr(IntPtr thiz, string ip);

		/// <summary>
		/// Use to get multicast address to be used for audio stream. 
		/// </summary>
		public string AudioMulticastAddr
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_audio_multicast_addr(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_audio_multicast_addr(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("AudioMulticastAddr setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_audio_multicast_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_audio_multicast(IntPtr thiz, char yesno);

		/// <summary>
		/// Use to get multicast state of audio stream. 
		/// </summary>
		public bool AudioMulticastEnabled
		{
			get
			{
				return linphone_core_audio_multicast_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_audio_multicast(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_audio_multicast_ttl(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_audio_multicast_ttl(IntPtr thiz, int ttl);

		/// <summary>
		/// Use to get multicast ttl to be used for audio stream. 
		/// </summary>
		public int AudioMulticastTtl
		{
			get
			{
				return linphone_core_get_audio_multicast_ttl(nativePtr);
			}
			set
			{
				int exception_result = linphone_core_set_audio_multicast_ttl(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("AudioMulticastTtl setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_audio_payload_types(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_audio_payload_types(IntPtr thiz, IntPtr payloadTypes);

		/// <summary>
		/// Return the list of the available audio payload types. 
		/// </summary>
		public IEnumerable<PayloadType> AudioPayloadTypes
		{
			get
			{
				return MarshalBctbxList<PayloadType>(linphone_core_get_audio_payload_types(nativePtr));
			}
			set
			{
				linphone_core_set_audio_payload_types(nativePtr, ObjectArrayToBctbxList<PayloadType>(value));
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_audio_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_audio_port(IntPtr thiz, int port);

		/// <summary>
		/// Gets the UDP port used for audio streaming. 
		/// </summary>
		public int AudioPort
		{
			get
			{
				return linphone_core_get_audio_port(nativePtr);
			}
			set
			{
				linphone_core_set_audio_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_audio_ports_range(IntPtr thiz);

		/// <summary>
		/// Get the audio port range from which is randomly chosen the UDP port used for
		/// audio streaming. 
		/// </summary>
		public Range AudioPortsRange
		{
			get
			{
				IntPtr ptr = linphone_core_get_audio_ports_range(nativePtr);
				return fromNativePtr<Range>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_auth_info_list(IntPtr thiz);

		/// <summary>
		/// Returns an unmodifiable list of currently entered <see cref="AuthInfo"
		/// />. 
		/// </summary>
		public IEnumerable<AuthInfo> AuthInfoList
		{
			get
			{
				return MarshalBctbxList<AuthInfo>(linphone_core_get_auth_info_list(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AVPFMode linphone_core_get_avpf_mode(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_avpf_mode(IntPtr thiz, int mode);

		/// <summary>
		/// Return AVPF enablement. 
		/// </summary>
		public AVPFMode AvpfMode
		{
			get
			{
				return linphone_core_get_avpf_mode(nativePtr);
			}
			set
			{
				linphone_core_set_avpf_mode(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_avpf_rr_interval(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_avpf_rr_interval(IntPtr thiz, int interval);

		/// <summary>
		/// Return the avpf report interval in seconds. 
		/// </summary>
		public int AvpfRrInterval
		{
			get
			{
				return linphone_core_get_avpf_rr_interval(nativePtr);
			}
			set
			{
				linphone_core_set_avpf_rr_interval(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_call_logs(IntPtr thiz);

		/// <summary>
		/// Get the list of call logs (past calls). 
		/// </summary>
		public IEnumerable<CallLog> CallLogs
		{
			get
			{
				return MarshalBctbxList<CallLog>(linphone_core_get_call_logs(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_call_logs_database_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_call_logs_database_path(IntPtr thiz, string path);

		/// <summary>
		/// Gets the database filename where call logs will be stored. 
		/// </summary>
		public string CallLogsDatabasePath
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_call_logs_database_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_call_logs_database_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_calls(IntPtr thiz);

		/// <summary>
		/// Gets the current list of calls. 
		/// </summary>
		public IEnumerable<Call> Calls
		{
			get
			{
				return MarshalBctbxList<Call>(linphone_core_get_calls(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_calls_nb(IntPtr thiz);

		/// <summary>
		/// Get the number of Call. 
		/// </summary>
		public int CallsNb
		{
			get
			{
				return linphone_core_get_calls_nb(nativePtr);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_camera_sensor_rotation(IntPtr thiz);

		/// <summary>
		/// Get the camera sensor rotation. 
		/// </summary>
		public int CameraSensorRotation
		{
			get
			{
				return linphone_core_get_camera_sensor_rotation(nativePtr);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_capture_device(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_capture_device(IntPtr thiz, string devid);

		/// <summary>
		/// Gets the name of the currently assigned sound device for capture. 
		/// </summary>
		public string CaptureDevice
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_capture_device(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_capture_device(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("CaptureDevice setter returned value " + exception_result);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_chat_database_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_chat_database_path(IntPtr thiz, string path);

		/// <summary>
		/// Get path to the database file used for storing chat messages. 
		/// </summary>
		public string ChatDatabasePath
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_chat_database_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_chat_database_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_chat_enabled(IntPtr thiz);

		/// <summary>
		/// Returns whether chat is enabled. 
		/// </summary>
		public bool ChatEnabled
		{
			get
			{
				return linphone_core_chat_enabled(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_chat_rooms(IntPtr thiz);

		/// <summary>
		/// Returns an list of chat rooms. 
		/// </summary>
		public IEnumerable<ChatRoom> ChatRooms
		{
			get
			{
				return MarshalBctbxList<ChatRoom>(linphone_core_get_chat_rooms(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_conference(IntPtr thiz);

		/// <summary>
		/// Get a pointer on the internal conference object. 
		/// </summary>
		public Conference Conference
		{
			get
			{
				IntPtr ptr = linphone_core_get_conference(nativePtr);
				return fromNativePtr<Conference>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_core_get_conference_local_input_volume(IntPtr thiz);

		/// <summary>
		/// Get the set input volume of the local participant. 
		/// </summary>
		public float ConferenceLocalInputVolume
		{
			get
			{
				return linphone_core_get_conference_local_input_volume(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_conference_server_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_conference_server(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether the conference server feature is enabled. 
		/// </summary>
		public bool ConferenceServerEnabled
		{
			get
			{
				return linphone_core_conference_server_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_conference_server(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_conference_size(IntPtr thiz);

		/// <summary>
		/// Get the number of participant in the running conference. 
		/// </summary>
		public int ConferenceSize
		{
			get
			{
				return linphone_core_get_conference_size(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_config(IntPtr thiz);

		/// <summary>
		/// Returns the LpConfig object used to manage the storage (config) file. 
		/// </summary>
		public Config Config
		{
			get
			{
				IntPtr ptr = linphone_core_get_config(nativePtr);
				return fromNativePtr<Config>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern ConsolidatedPresence linphone_core_get_consolidated_presence(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_consolidated_presence(IntPtr thiz, int presence);

		/// <summary>
		/// Get my consolidated presence. 
		/// </summary>
		public ConsolidatedPresence ConsolidatedPresence
		{
			get
			{
				return linphone_core_get_consolidated_presence(nativePtr);
			}
			set
			{
				linphone_core_set_consolidated_presence(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_current_call(IntPtr thiz);

		/// <summary>
		/// Gets the current call. 
		/// </summary>
		public Call CurrentCall
		{
			get
			{
				IntPtr ptr = linphone_core_get_current_call(nativePtr);
				return fromNativePtr<Call>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_current_call_remote_address(IntPtr thiz);

		/// <summary>
		/// Get the remote address of the current call. 
		/// </summary>
		public Address CurrentCallRemoteAddress
		{
			get
			{
				IntPtr ptr = linphone_core_get_current_call_remote_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_current_callbacks(IntPtr thiz);

		/// <summary>
		/// Gets the current LinphoneCoreCbs. 
		/// </summary>
		public CoreListener CurrentCallbacks
		{
			get
			{
				IntPtr ptr = linphone_core_get_current_callbacks(nativePtr);
				return fromNativePtr<CoreListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_current_preview_video_definition(IntPtr thiz);

		/// <summary>
		/// Get the effective video definition provided by the camera for the captured
		/// video. 
		/// </summary>
		public VideoDefinition CurrentPreviewVideoDefinition
		{
			get
			{
				IntPtr ptr = linphone_core_get_current_preview_video_definition(nativePtr);
				return fromNativePtr<VideoDefinition>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_default_friend_list(IntPtr thiz);

		/// <summary>
		/// Retrieves the first list of <see cref="Friend" /> from the core. 
		/// </summary>
		public FriendList DefaultFriendList
		{
			get
			{
				IntPtr ptr = linphone_core_get_default_friend_list(nativePtr);
				return fromNativePtr<FriendList>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_default_proxy_config(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_default_proxy_config(IntPtr thiz, IntPtr config);

		public ProxyConfig DefaultProxyConfig
		{
			get
			{
				IntPtr ptr = linphone_core_get_default_proxy_config(nativePtr);
				return fromNativePtr<ProxyConfig>(ptr, true);
			}
			set
			{
				linphone_core_set_default_proxy_config(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_delayed_timeout(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_delayed_timeout(IntPtr thiz, int seconds);

		/// <summary>
		/// Gets the delayed timeout See <see cref="Core.SetDelayedTimeout()" />
		/// for details. 
		/// </summary>
		public int DelayedTimeout
		{
			get
			{
				return linphone_core_get_delayed_timeout(nativePtr);
			}
			set
			{
				linphone_core_set_delayed_timeout(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_device_rotation(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_device_rotation(IntPtr thiz, int rotation);

		/// <summary>
		/// Gets the current device orientation. 
		/// </summary>
		public int DeviceRotation
		{
			get
			{
				return linphone_core_get_device_rotation(nativePtr);
			}
			set
			{
				linphone_core_set_device_rotation(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_dns_search_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_dns_search(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether DNS search (use of local domain if the fully qualified name did
		/// return results) is enabled. 
		/// </summary>
		public bool DnsSearchEnabled
		{
			get
			{
				return linphone_core_dns_search_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_dns_search(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_dns_servers(IntPtr thiz, IntPtr servers);

		/// <summary>
		/// Forces liblinphone to use the supplied list of dns servers, instead of system's
		/// ones. 
		/// </summary>
		public IEnumerable<string> DnsServers
		{
			set
			{
				linphone_core_set_dns_servers(nativePtr, StringArrayToBctbxList(value));
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_dns_servers_app(IntPtr thiz, IntPtr servers);

		/// <summary>
		/// Forces liblinphone to use the supplied list of dns servers, instead of system's
		/// ones and set dns_set_by_app at true or false according to value of servers
		/// list. 
		/// </summary>
		public IEnumerable<string> DnsServersApp
		{
			set
			{
				linphone_core_set_dns_servers_app(nativePtr, StringArrayToBctbxList(value));
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_get_dns_set_by_app(IntPtr thiz);

		/// <summary>
		/// Tells if the DNS was set by an application. 
		/// </summary>
		public bool DnsSetByApp
		{
			get
			{
				return linphone_core_get_dns_set_by_app(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_dns_srv_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_dns_srv(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether DNS SRV resolution is enabled. 
		/// </summary>
		public bool DnsSrvEnabled
		{
			get
			{
				return linphone_core_dns_srv_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_dns_srv(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_download_bandwidth(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_download_bandwidth(IntPtr thiz, int bw);

		/// <summary>
		/// Retrieve the maximum available download bandwidth. 
		/// </summary>
		public int DownloadBandwidth
		{
			get
			{
				return linphone_core_get_download_bandwidth(nativePtr);
			}
			set
			{
				linphone_core_set_download_bandwidth(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_download_ptime(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_download_ptime(IntPtr thiz, int ptime);

		/// <summary>
		/// Get audio packetization time linphone expects to receive from peer. 
		/// </summary>
		public int DownloadPtime
		{
			get
			{
				return linphone_core_get_download_ptime(nativePtr);
			}
			set
			{
				linphone_core_set_download_ptime(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_echo_cancellation_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_echo_cancellation(IntPtr thiz, char val);

		/// <summary>
		/// Returns true if echo cancellation is enabled. 
		/// </summary>
		public bool EchoCancellationEnabled
		{
			get
			{
				return linphone_core_echo_cancellation_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_echo_cancellation(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_echo_canceller_filter_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_echo_canceller_filter_name(IntPtr thiz, string filtername);

		/// <summary>
		/// Get the name of the mediastreamer2 filter used for echo cancelling. 
		/// </summary>
		public string EchoCancellerFilterName
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_echo_canceller_filter_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_echo_canceller_filter_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_echo_limiter_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_echo_limiter(IntPtr thiz, char val);

		/// <summary>
		/// Tells whether echo limiter is enabled. 
		/// </summary>
		public bool EchoLimiterEnabled
		{
			get
			{
				return linphone_core_echo_limiter_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_echo_limiter(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_expected_bandwidth(IntPtr thiz, int bw);

		/// <summary>
		/// Sets expected available upload bandwidth This is IP bandwidth, in kbit/s. 
		/// </summary>
		public int ExpectedBandwidth
		{
			set
			{
				linphone_core_set_expected_bandwidth(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_file_transfer_server(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_file_transfer_server(IntPtr thiz, string serverUrl);

		/// <summary>
		/// Get the globaly set http file transfer server to be used for content type
		/// application/vnd.gsma.rcs-ft-http+xml. 
		/// </summary>
		public string FileTransferServer
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_file_transfer_server(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_file_transfer_server(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_friends_database_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_friends_database_path(IntPtr thiz, string path);

		/// <summary>
		/// Gets the database filename where friends will be stored. 
		/// </summary>
		public string FriendsDatabasePath
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_friends_database_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_friends_database_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_friends_lists(IntPtr thiz);

		/// <summary>
		/// Retrieves the list of <see cref="FriendList" /> from the core. 
		/// </summary>
		public IEnumerable<FriendList> FriendsLists
		{
			get
			{
				return MarshalBctbxList<FriendList>(linphone_core_get_friends_lists(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_get_guess_hostname(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_guess_hostname(IntPtr thiz, char val);

		/// <summary>
		/// Returns true if hostname part of primary contact is guessed automatically. 
		/// </summary>
		public bool GuessHostname
		{
			get
			{
				return linphone_core_get_guess_hostname(nativePtr) != 0;
			}
			set
			{
				linphone_core_set_guess_hostname(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_http_proxy_host(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_http_proxy_host(IntPtr thiz, string host);

		/// <summary>
		/// Get http proxy address to be used for signaling. 
		/// </summary>
		public string HttpProxyHost
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_http_proxy_host(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_http_proxy_host(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_http_proxy_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_http_proxy_port(IntPtr thiz, int port);

		/// <summary>
		/// Get http proxy port to be used for signaling. 
		/// </summary>
		public int HttpProxyPort
		{
			get
			{
				return linphone_core_get_http_proxy_port(nativePtr);
			}
			set
			{
				linphone_core_set_http_proxy_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_identity(IntPtr thiz);

		/// <summary>
		/// Gets the default identity SIP address. 
		/// </summary>
		public string Identity
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_identity(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_im_notif_policy(IntPtr thiz);

		/// <summary>
		/// Get the <see cref="ImNotifPolicy" /> object controlling the instant
		/// messaging notifications. 
		/// </summary>
		public ImNotifPolicy ImNotifPolicy
		{
			get
			{
				IntPtr ptr = linphone_core_get_im_notif_policy(nativePtr);
				return fromNativePtr<ImNotifPolicy>(ptr, true);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_in_call_timeout(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_in_call_timeout(IntPtr thiz, int seconds);

		/// <summary>
		/// Gets the in call timeout See <see cref="Core.SetInCallTimeout()" />
		/// for details. 
		/// </summary>
		public int InCallTimeout
		{
			get
			{
				return linphone_core_get_in_call_timeout(nativePtr);
			}
			set
			{
				linphone_core_set_in_call_timeout(nativePtr, value);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_inc_timeout(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_inc_timeout(IntPtr thiz, int seconds);

		/// <summary>
		/// Returns the incoming call timeout See <see cref="Core.SetIncTimeout()"
		/// /> for details. 
		/// </summary>
		public int IncTimeout
		{
			get
			{
				return linphone_core_get_inc_timeout(nativePtr);
			}
			set
			{
				linphone_core_set_inc_timeout(nativePtr, value);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_ipv6_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_ipv6(IntPtr thiz, char val);

		/// <summary>
		/// Tells whether IPv6 is enabled or not. 
		/// </summary>
		public bool Ipv6Enabled
		{
			get
			{
				return linphone_core_ipv6_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_ipv6(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_is_echo_canceller_calibration_required(IntPtr thiz);

		/// <summary>
		/// Check whether the device is echo canceller calibration is required. 
		/// </summary>
		public bool IsEchoCancellerCalibrationRequired
		{
			get
			{
				return linphone_core_is_echo_canceller_calibration_required(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_is_in_conference(IntPtr thiz);

		/// <summary>
		/// Indicates whether the local participant is part of a conference. 
		/// </summary>
		public bool IsInConference
		{
			get
			{
				return linphone_core_is_in_conference(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_is_incoming_invite_pending(IntPtr thiz);

		/// <summary>
		/// Tells whether there is an incoming invite pending. 
		/// </summary>
		public bool IsIncomingInvitePending
		{
			get
			{
				return linphone_core_is_incoming_invite_pending(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_is_media_encryption_mandatory(IntPtr thiz);

		/// <summary>
		/// Get behaviour when encryption parameters negociation fails on outgoing call. 
		/// </summary>
		public bool IsMediaEncryptionMandatory
		{
			get
			{
				return linphone_core_is_media_encryption_mandatory(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_is_network_reachable(IntPtr thiz);

		/// <summary>
		/// return network state either as positioned by the application or by linphone
		/// itself. 
		/// </summary>
		public bool IsNetworkReachable
		{
			get
			{
				return linphone_core_is_network_reachable(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_keep_alive_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_keep_alive(IntPtr thiz, char enable);

		/// <summary>
		/// Is signaling keep alive enabled. 
		/// </summary>
		public bool KeepAliveEnabled
		{
			get
			{
				return linphone_core_keep_alive_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_keep_alive(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_last_outgoing_call_log(IntPtr thiz);

		/// <summary>
		/// Get the latest outgoing call log. 
		/// </summary>
		public CallLog LastOutgoingCallLog
		{
			get
			{
				IntPtr ptr = linphone_core_get_last_outgoing_call_log(nativePtr);
				return fromNativePtr<CallLog>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_linphone_specs(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_linphone_specs(IntPtr thiz, string specs);

		/// <summary>
		/// Get the linphone specs value telling what functionalities the linphone client
		/// supports. 
		/// </summary>
		public string LinphoneSpecs
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_linphone_specs(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_linphone_specs(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_log_collection_upload_server_url(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_log_collection_upload_server_url(IntPtr thiz, string serverUrl);

		/// <summary>
		/// Gets the url of the server where to upload the collected log files. 
		/// </summary>
		public string LogCollectionUploadServerUrl
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_log_collection_upload_server_url(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_log_collection_upload_server_url(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_max_calls(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_max_calls(IntPtr thiz, int max);

		/// <summary>
		/// Get the maximum number of simultaneous calls Linphone core can manage at a
		/// time. 
		/// </summary>
		public int MaxCalls
		{
			get
			{
				return linphone_core_get_max_calls(nativePtr);
			}
			set
			{
				linphone_core_set_max_calls(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern MediaEncryption linphone_core_get_media_encryption(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_media_encryption(IntPtr thiz, int menc);

		/// <summary>
		/// Get the media encryption policy being used for RTP packets. 
		/// </summary>
		public MediaEncryption MediaEncryption
		{
			get
			{
				return linphone_core_get_media_encryption(nativePtr);
			}
			set
			{
				int exception_result = linphone_core_set_media_encryption(nativePtr, (int)value);
				if (exception_result != 0) throw new LinphoneException("MediaEncryption setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_media_encryption_mandatory(IntPtr thiz, char m);

		/// <summary>
		/// Define behaviour when encryption parameters negociation fails on outgoing call. 
		/// </summary>
		public bool MediaEncryptionMandatory
		{
			set
			{
				linphone_core_set_media_encryption_mandatory(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_media_network_reachable(IntPtr thiz, char val);

		/// <summary>
		/// This method is called by the application to notify the linphone core library
		/// when the media (RTP) network is reachable. 
		/// </summary>
		public bool MediaNetworkReachable
		{
			set
			{
				linphone_core_set_media_network_reachable(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_mic_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_mic(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether the microphone is enabled. 
		/// </summary>
		public bool MicEnabled
		{
			get
			{
				return linphone_core_mic_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_mic(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_core_get_mic_gain_db(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_mic_gain_db(IntPtr thiz, float level);

		/// <summary>
		/// Get microphone gain in db. 
		/// </summary>
		public float MicGainDb
		{
			get
			{
				return linphone_core_get_mic_gain_db(nativePtr);
			}
			set
			{
				linphone_core_set_mic_gain_db(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_missed_calls_count(IntPtr thiz);

		/// <summary>
		/// Get the number of missed calls. 
		/// </summary>
		public int MissedCallsCount
		{
			get
			{
				return linphone_core_get_missed_calls_count(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_mtu(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_mtu(IntPtr thiz, int mtu);

		/// <summary>
		/// Returns the maximum transmission unit size in bytes. 
		/// </summary>
		public int Mtu
		{
			get
			{
				return linphone_core_get_mtu(nativePtr);
			}
			set
			{
				linphone_core_set_mtu(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_nat_address(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_nat_address(IntPtr thiz, string addr);

		/// <summary>
		/// Get the public IP address of NAT being used. 
		/// </summary>
		public string NatAddress
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_nat_address(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_nat_address(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_nat_policy(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_nat_policy(IntPtr thiz, IntPtr policy);

		/// <summary>
		/// Get The policy that is used to pass through NATs/firewalls. 
		/// </summary>
		public NatPolicy NatPolicy
		{
			get
			{
				IntPtr ptr = linphone_core_get_nat_policy(nativePtr);
				return fromNativePtr<NatPolicy>(ptr, true);
			}
			set
			{
				linphone_core_set_nat_policy(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_native_preview_window_id(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_native_preview_window_id(IntPtr thiz, IntPtr id);

		/// <summary>
		/// Get the native window handle of the video preview window. 
		/// </summary>
		public IntPtr NativePreviewWindowId
		{
			get
			{
				return linphone_core_get_native_preview_window_id(nativePtr);
			}
			set
			{
				linphone_core_set_native_preview_window_id(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_native_video_window_id(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_native_video_window_id(IntPtr thiz, IntPtr id);

		/// <summary>
		/// Get the native window handle of the video window. 
		/// </summary>
		public IntPtr NativeVideoWindowId
		{
			get
			{
				return linphone_core_get_native_video_window_id(nativePtr);
			}
			set
			{
				linphone_core_set_native_video_window_id(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_network_reachable(IntPtr thiz, char val);

		/// <summary>
		/// This method is called by the application to notify the linphone core library
		/// when network is reachable. 
		/// </summary>
		public bool NetworkReachable
		{
			set
			{
				linphone_core_set_network_reachable(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_nortp_timeout(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_nortp_timeout(IntPtr thiz, int seconds);

		/// <summary>
		/// Gets the value of the no-rtp timeout. 
		/// </summary>
		public int NortpTimeout
		{
			get
			{
				return linphone_core_get_nortp_timeout(nativePtr);
			}
			set
			{
				linphone_core_set_nortp_timeout(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_play_file(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_play_file(IntPtr thiz, string file);

		/// <summary>
		/// Get the wav file that is played when putting somebody on hold, or when files
		/// are used instead of soundcards (see <see cref="Core.SetUseFiles()"
		/// />). 
		/// </summary>
		public string PlayFile
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_play_file(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_play_file(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_playback_device(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_playback_device(IntPtr thiz, string devid);

		/// <summary>
		/// Gets the name of the currently assigned sound device for playback. 
		/// </summary>
		public string PlaybackDevice
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_playback_device(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_playback_device(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("PlaybackDevice setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_core_get_playback_gain_db(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_playback_gain_db(IntPtr thiz, float level);

		/// <summary>
		/// Get playback gain in db before entering sound card. 
		/// </summary>
		public float PlaybackGainDb
		{
			get
			{
				return linphone_core_get_playback_gain_db(nativePtr);
			}
			set
			{
				linphone_core_set_playback_gain_db(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_core_get_preferred_framerate(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_preferred_framerate(IntPtr thiz, float fps);

		/// <summary>
		/// Returns the preferred video framerate, previously set by <see
		/// cref="Core.SetPreferredFramerate()" />. 
		/// </summary>
		public float PreferredFramerate
		{
			get
			{
				return linphone_core_get_preferred_framerate(nativePtr);
			}
			set
			{
				linphone_core_set_preferred_framerate(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_preferred_video_definition(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_preferred_video_definition(IntPtr thiz, IntPtr vdef);

		/// <summary>
		/// Get the preferred video definition for the stream that is captured and sent to
		/// the remote party. 
		/// </summary>
		public VideoDefinition PreferredVideoDefinition
		{
			get
			{
				IntPtr ptr = linphone_core_get_preferred_video_definition(nativePtr);
				return fromNativePtr<VideoDefinition>(ptr, true);
			}
			set
			{
				linphone_core_set_preferred_video_definition(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_preferred_video_size_by_name(IntPtr thiz, string name);

		/// <summary>
		/// Sets the preferred video size by its name. 
		/// </summary>
		public string PreferredVideoSizeByName
		{
			set
			{
				linphone_core_set_preferred_video_size_by_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_presence_model(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_presence_model(IntPtr thiz, IntPtr presence);

		/// <summary>
		/// Get my presence model. 
		/// </summary>
		public PresenceModel PresenceModel
		{
			get
			{
				IntPtr ptr = linphone_core_get_presence_model(nativePtr);
				return fromNativePtr<PresenceModel>(ptr, true);
			}
			set
			{
				linphone_core_set_presence_model(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_preview_video_definition(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_preview_video_definition(IntPtr thiz, IntPtr vdef);

		/// <summary>
		/// Get the definition of the captured video. 
		/// </summary>
		public VideoDefinition PreviewVideoDefinition
		{
			get
			{
				IntPtr ptr = linphone_core_get_preview_video_definition(nativePtr);
				return fromNativePtr<VideoDefinition>(ptr, true);
			}
			set
			{
				linphone_core_set_preview_video_definition(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_preview_video_size_by_name(IntPtr thiz, string name);

		/// <summary>
		/// Sets the preview video size by its name. 
		/// </summary>
		public string PreviewVideoSizeByName
		{
			set
			{
				linphone_core_set_preview_video_size_by_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_primary_contact(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_primary_contact(IntPtr thiz, string contact);

		/// <summary>
		/// Returns the default identity when no proxy configuration is used. 
		/// </summary>
		public string PrimaryContact
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_primary_contact(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_primary_contact(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("PrimaryContact setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_primary_contact_parsed(IntPtr thiz);

		/// <summary>
		/// Same as <see cref="Core.GetPrimaryContact()" /> but the result is a
		/// <see cref="Address" /> object instead of const char*. 
		/// </summary>
		public Address PrimaryContactParsed
		{
			get
			{
				IntPtr ptr = linphone_core_get_primary_contact_parsed(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_provisioning_uri(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_provisioning_uri(IntPtr thiz, string uri);

		/// <summary>
		/// Get provisioning URI. 
		/// </summary>
		public string ProvisioningUri
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_provisioning_uri(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_provisioning_uri(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("ProvisioningUri setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_proxy_config_list(IntPtr thiz);

		/// <summary>
		/// Returns an unmodifiable list of entered proxy configurations. 
		/// </summary>
		public IEnumerable<ProxyConfig> ProxyConfigList
		{
			get
			{
				return MarshalBctbxList<ProxyConfig>(linphone_core_get_proxy_config_list(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_qrcode_video_preview_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_qrcode_video_preview(IntPtr thiz, char val);

		/// <summary>
		/// Tells whether QRCode is enabled in the preview. 
		/// </summary>
		public bool QrcodeVideoPreviewEnabled
		{
			get
			{
				return linphone_core_qrcode_video_preview_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_qrcode_video_preview(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_realtime_text_enabled(IntPtr thiz);

		/// <summary>
		/// Gets if realtime text is enabled or not. 
		/// </summary>
		public bool RealtimeTextEnabled
		{
			get
			{
				return linphone_core_realtime_text_enabled(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_record_file(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_record_file(IntPtr thiz, string file);

		/// <summary>
		/// Get the wav file where incoming stream is recorded, when files are used instead
		/// of soundcards (see <see cref="Core.SetUseFiles()" />). 
		/// </summary>
		public string RecordFile
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_record_file(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_record_file(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_remote_ringback_tone(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_remote_ringback_tone(IntPtr thiz, string ring);

		/// <summary>
		/// Get the ring back tone played to far end during incoming calls. 
		/// </summary>
		public string RemoteRingbackTone
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_remote_ringback_tone(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_remote_ringback_tone(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_ring(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_ring(IntPtr thiz, string path);

		/// <summary>
		/// Returns the path to the wav file used for ringing. 
		/// </summary>
		public string Ring
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_ring(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_ring(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_get_ring_during_incoming_early_media(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_ring_during_incoming_early_media(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether the ring play is enabled during an incoming early media call. 
		/// </summary>
		public bool RingDuringIncomingEarlyMedia
		{
			get
			{
				return linphone_core_get_ring_during_incoming_early_media(nativePtr) != 0;
			}
			set
			{
				linphone_core_set_ring_during_incoming_early_media(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_ringback(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_ringback(IntPtr thiz, string path);

		/// <summary>
		/// Returns the path to the wav file used for ringing back. 
		/// </summary>
		public string Ringback
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_ringback(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_ringback(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_ringer_device(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_ringer_device(IntPtr thiz, string devid);

		/// <summary>
		/// Gets the name of the currently assigned sound device for ringing. 
		/// </summary>
		public string RingerDevice
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_ringer_device(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_ringer_device(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("RingerDevice setter returned value " + exception_result);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_root_ca(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_root_ca(IntPtr thiz, string path);

		/// <summary>
		/// Gets the path to a file or folder containing the trusted root CAs (PEM format) 
		/// </summary>
		public string RootCa
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_root_ca(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_root_ca(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_root_ca_data(IntPtr thiz, string data);

		/// <summary>
		/// Sets the trusted root CAs (PEM format) 
		/// </summary>
		public string RootCaData
		{
			set
			{
				linphone_core_set_root_ca_data(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_sdp_200_ack_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_sdp_200_ack(IntPtr thiz, char enable);

		/// <summary>
		/// Media offer control param for SIP INVITE. 
		/// </summary>
		public bool Sdp200AckEnabled
		{
			get
			{
				return linphone_core_sdp_200_ack_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_sdp_200_ack(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_self_view_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_self_view(IntPtr thiz, char val);

		/// <summary>
		/// Tells whether video self view during call is enabled or not. 
		/// </summary>
		public bool SelfViewEnabled
		{
			get
			{
				return linphone_core_self_view_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_self_view(nativePtr, value ? (char)1 : (char)0);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_sip_dscp(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_sip_dscp(IntPtr thiz, int dscp);

		/// <summary>
		/// Get the DSCP field for SIP signaling channel. 
		/// </summary>
		public int SipDscp
		{
			get
			{
				return linphone_core_get_sip_dscp(nativePtr);
			}
			set
			{
				linphone_core_set_sip_dscp(nativePtr, value);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_sip_network_reachable(IntPtr thiz, char val);

		/// <summary>
		/// This method is called by the application to notify the linphone core library
		/// when the SIP network is reachable. 
		/// </summary>
		public bool SipNetworkReachable
		{
			set
			{
				linphone_core_set_sip_network_reachable(nativePtr, value ? (char)1 : (char)0);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_sip_transport_timeout(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_sip_transport_timeout(IntPtr thiz, int timeoutMs);

		/// <summary>
		/// Get the SIP transport timeout. 
		/// </summary>
		public int SipTransportTimeout
		{
			get
			{
				return linphone_core_get_sip_transport_timeout(nativePtr);
			}
			set
			{
				linphone_core_set_sip_transport_timeout(nativePtr, value);
				
			}
		}

        [DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr linphone_core_get_sound_devices(IntPtr thiz);

		/// <summary>
		/// Gets the list of the available sound devices. 
		/// </summary>
		public IEnumerable<string> SoundDevicesList
		{
            get
            {
                List<string> devList = new List<string>();

                IntPtr listPtr = linphone_core_get_sound_devices(nativePtr);

                if (listPtr != IntPtr.Zero)
                {
                    IntPtr ptr = Marshal.ReadIntPtr(listPtr);
                    while (ptr != IntPtr.Zero)
                    {
                        string device = Marshal.PtrToStringAnsi(ptr);

                        devList.Add(device);

                        listPtr = new IntPtr(listPtr.ToInt64() + IntPtr.Size);
                        ptr = Marshal.ReadIntPtr(listPtr);
                    }
                }
                return devList;
                //return MarshalStringArray(linphone_core_get_sound_devices(nativePtr));
            }
        }

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_static_picture(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_static_picture(IntPtr thiz, string path);

		/// <summary>
		/// Get the path to the image file streamed when "Static picture" is set as the
		/// video device. 
		/// </summary>
		public string StaticPicture
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_static_picture(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_static_picture(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("StaticPicture setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern float linphone_core_get_static_picture_fps(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_static_picture_fps(IntPtr thiz, float fps);

		/// <summary>
		/// Get the frame rate for static picture. 
		/// </summary>
		public float StaticPictureFps
		{
			get
			{
				return linphone_core_get_static_picture_fps(nativePtr);
			}
			set
			{
				int exception_result = linphone_core_set_static_picture_fps(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("StaticPictureFps setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_stun_server(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_stun_server(IntPtr thiz, string server);

		/// <summary>
		/// Get the STUN server address being used. 
		/// </summary>
		public string StunServer
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_stun_server(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_stun_server(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_supported_file_formats_list(IntPtr thiz);

		/// <summary>
		/// Returns a null terminated table of strings containing the file format extension
		/// supported for call recording. 
		/// </summary>
		public IEnumerable<string> SupportedFileFormatsList
		{
			get
			{
				return MarshalStringArray(linphone_core_get_supported_file_formats_list(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_text_payload_types(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_text_payload_types(IntPtr thiz, IntPtr payloadTypes);

		/// <summary>
		/// Return the list of the available text payload types. 
		/// </summary>
		public IEnumerable<PayloadType> TextPayloadTypes
		{
			get
			{
				return MarshalBctbxList<PayloadType>(linphone_core_get_text_payload_types(nativePtr));
			}
			set
			{
				linphone_core_set_text_payload_types(nativePtr, ObjectArrayToBctbxList<PayloadType>(value));
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_text_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_text_port(IntPtr thiz, int port);

		/// <summary>
		/// Gets the UDP port used for text streaming. 
		/// </summary>
		public int TextPort
		{
			get
			{
				return linphone_core_get_text_port(nativePtr);
			}
			set
			{
				linphone_core_set_text_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_text_ports_range(IntPtr thiz);

		/// <summary>
		/// Get the text port range from which is randomly chosen the UDP port used for
		/// text streaming. 
		/// </summary>
		public Range TextPortsRange
		{
			get
			{
				IntPtr ptr = linphone_core_get_text_ports_range(nativePtr);
				return fromNativePtr<Range>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_tls_cert(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_tls_cert(IntPtr thiz, string tlsCert);

		/// <summary>
		/// Gets the TLS certificate. 
		/// </summary>
		public string TlsCert
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_tls_cert(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_tls_cert(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_tls_cert_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_tls_cert_path(IntPtr thiz, string tlsCertPath);

		/// <summary>
		/// Gets the path to the TLS certificate file. 
		/// </summary>
		public string TlsCertPath
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_tls_cert_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_tls_cert_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_tls_key(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_tls_key(IntPtr thiz, string tlsKey);

		/// <summary>
		/// Gets the TLS key. 
		/// </summary>
		public string TlsKey
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_tls_key(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_tls_key(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_tls_key_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_tls_key_path(IntPtr thiz, string tlsKeyPath);

		/// <summary>
		/// Gets the path to the TLS key file. 
		/// </summary>
		public string TlsKeyPath
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_tls_key_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_tls_key_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_transports(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_transports(IntPtr thiz, IntPtr transports);

		/// <summary>
		/// Retrieves the port configuration used for each transport (udp, tcp, tls). 
		/// </summary>
		public Transports Transports
		{
			get
			{
				IntPtr ptr = linphone_core_get_transports(nativePtr);
				return fromNativePtr<Transports>(ptr, true);
			}
			set
			{
				int exception_result = linphone_core_set_transports(nativePtr, value.nativePtr);
				if (exception_result != 0) throw new LinphoneException("Transports setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_transports_used(IntPtr thiz);

		/// <summary>
		/// Retrieves the real port number assigned for each sip transport (udp, tcp, tls). 
		/// </summary>
		public Transports TransportsUsed
		{
			get
			{
				IntPtr ptr = linphone_core_get_transports_used(nativePtr);
				return fromNativePtr<Transports>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_tunnel(IntPtr thiz);

		/// <summary>
		/// get tunnel instance if available 
		/// </summary>
		public Tunnel Tunnel
		{
			get
			{
				IntPtr ptr = linphone_core_get_tunnel(nativePtr);
				return fromNativePtr<Tunnel>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_upload_bandwidth(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_upload_bandwidth(IntPtr thiz, int bw);

		/// <summary>
		/// Retrieve the maximum available upload bandwidth. 
		/// </summary>
		public int UploadBandwidth
		{
			get
			{
				return linphone_core_get_upload_bandwidth(nativePtr);
			}
			set
			{
				linphone_core_set_upload_bandwidth(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_upload_ptime(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_upload_ptime(IntPtr thiz, int ptime);

		/// <summary>
		/// Set audio packetization time linphone will send (in absence of requirement from
		/// peer) A value of 0 stands for the current codec default packetization time. 
		/// </summary>
		public int UploadPtime
		{
			get
			{
				return linphone_core_get_upload_ptime(nativePtr);
			}
			set
			{
				linphone_core_set_upload_ptime(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_upnp_external_ipaddress(IntPtr thiz);

		/// <summary>
		/// Return the external ip address of router. 
		/// </summary>
		public string UpnpExternalIpaddress
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_upnp_external_ipaddress(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern UpnpState linphone_core_get_upnp_state(IntPtr thiz);

		/// <summary>
		/// Return the internal state of uPnP. 
		/// </summary>
		public UpnpState UpnpState
		{
			get
			{
				return linphone_core_get_upnp_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_get_use_files(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_use_files(IntPtr thiz, char yesno);

		/// <summary>
		/// Gets whether linphone is currently streaming audio from and to files, rather
		/// than using the soundcard. 
		/// </summary>
		public bool UseFiles
		{
			get
			{
				return linphone_core_get_use_files(nativePtr) != 0;
			}
			set
			{
				linphone_core_set_use_files(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_get_use_info_for_dtmf(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_use_info_for_dtmf(IntPtr thiz, char useInfo);

		/// <summary>
		/// Indicates whether SIP INFO is used to send digits. 
		/// </summary>
		public bool UseInfoForDtmf
		{
			get
			{
				return linphone_core_get_use_info_for_dtmf(nativePtr) != 0;
			}
			set
			{
				linphone_core_set_use_info_for_dtmf(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_get_use_rfc2833_for_dtmf(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_use_rfc2833_for_dtmf(IntPtr thiz, char useRfc2833);

		/// <summary>
		/// Indicates whether RFC2833 is used to send digits. 
		/// </summary>
		public bool UseRfc2833ForDtmf
		{
			get
			{
				return linphone_core_get_use_rfc2833_for_dtmf(nativePtr) != 0;
			}
			set
			{
				linphone_core_set_use_rfc2833_for_dtmf(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_user_agent(IntPtr thiz);

		public string UserAgent
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_user_agent(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_user_certificates_path(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_user_certificates_path(IntPtr thiz, string path);

		/// <summary>
		/// Get the path to the directory storing the user's certificates. 
		/// </summary>
		public string UserCertificatesPath
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_user_certificates_path(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_user_certificates_path(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_activation_policy(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_activation_policy(IntPtr thiz, IntPtr policy);

		/// <summary>
		/// Get the default policy for video. 
		/// </summary>
		public VideoActivationPolicy VideoActivationPolicy
		{
			get
			{
				IntPtr ptr = linphone_core_get_video_activation_policy(nativePtr);
				return fromNativePtr<VideoActivationPolicy>(ptr, true);
			}
			set
			{
				linphone_core_set_video_activation_policy(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_video_adaptive_jittcomp_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_video_adaptive_jittcomp(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether the video adaptive jitter compensation is enabled. 
		/// </summary>
		public bool VideoAdaptiveJittcompEnabled
		{
			get
			{
				return linphone_core_video_adaptive_jittcomp_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_video_adaptive_jittcomp(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_video_capture_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_video_capture(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether video capture is enabled. 
		/// </summary>
		public bool VideoCaptureEnabled
		{
			get
			{
				return linphone_core_video_capture_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_video_capture(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_device(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_video_device(IntPtr thiz, string id);

		/// <summary>
		/// Returns the name of the currently active video device. 
		/// </summary>
		public string VideoDevice
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_video_device(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_video_device(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("VideoDevice setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_devices_list(IntPtr thiz);

		/// <summary>
		/// Gets the list of the available video capture devices. 
		/// </summary>
		public IEnumerable<string> VideoDevicesList
		{
			get
			{
				return MarshalStringArray(linphone_core_get_video_devices_list(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_video_display_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_video_display(IntPtr thiz, char enable);

		/// <summary>
		/// Tells whether video display is enabled. 
		/// </summary>
		public bool VideoDisplayEnabled
		{
			get
			{
				return linphone_core_video_display_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_video_display(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_display_filter(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_display_filter(IntPtr thiz, string filtername);

		/// <summary>
		/// Get the name of the mediastreamer2 filter used for rendering video. 
		/// </summary>
		public string VideoDisplayFilter
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_video_display_filter(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_video_display_filter(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_video_dscp(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_dscp(IntPtr thiz, int dscp);

		/// <summary>
		/// Get the DSCP field for outgoing video streams. 
		/// </summary>
		public int VideoDscp
		{
			get
			{
				return linphone_core_get_video_dscp(nativePtr);
			}
			set
			{
				linphone_core_set_video_dscp(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_video_enabled(IntPtr thiz);

		/// <summary>
		/// Returns true if either capture or display is enabled, true otherwise. 
		/// </summary>
		public bool VideoEnabled
		{
			get
			{
				return linphone_core_video_enabled(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_video_jittcomp(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_jittcomp(IntPtr thiz, int milliseconds);

		/// <summary>
		/// Returns the nominal video jitter buffer size in milliseconds. 
		/// </summary>
		public int VideoJittcomp
		{
			get
			{
				return linphone_core_get_video_jittcomp(nativePtr);
			}
			set
			{
				linphone_core_set_video_jittcomp(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_multicast_addr(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_video_multicast_addr(IntPtr thiz, string ip);

		/// <summary>
		/// Use to get multicast address to be used for video stream. 
		/// </summary>
		public string VideoMulticastAddr
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_video_multicast_addr(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_core_set_video_multicast_addr(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("VideoMulticastAddr setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_video_multicast_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_video_multicast(IntPtr thiz, char yesno);

		/// <summary>
		/// Use to get multicast state of video stream. 
		/// </summary>
		public bool VideoMulticastEnabled
		{
			get
			{
				return linphone_core_video_multicast_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_video_multicast(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_video_multicast_ttl(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_set_video_multicast_ttl(IntPtr thiz, int ttl);

		/// <summary>
		/// Use to get multicast ttl to be used for video stream. 
		/// </summary>
		public int VideoMulticastTtl
		{
			get
			{
				return linphone_core_get_video_multicast_ttl(nativePtr);
			}
			set
			{
				int exception_result = linphone_core_set_video_multicast_ttl(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("VideoMulticastTtl setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_payload_types(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_payload_types(IntPtr thiz, IntPtr payloadTypes);

		/// <summary>
		/// Return the list of the available video payload types. 
		/// </summary>
		public IEnumerable<PayloadType> VideoPayloadTypes
		{
			get
			{
				return MarshalBctbxList<PayloadType>(linphone_core_get_video_payload_types(nativePtr));
			}
			set
			{
				linphone_core_set_video_payload_types(nativePtr, ObjectArrayToBctbxList<PayloadType>(value));
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_get_video_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_port(IntPtr thiz, int port);

		/// <summary>
		/// Gets the UDP port used for video streaming. 
		/// </summary>
		public int VideoPort
		{
			get
			{
				return linphone_core_get_video_port(nativePtr);
			}
			set
			{
				linphone_core_set_video_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_ports_range(IntPtr thiz);

		/// <summary>
		/// Get the video port range from which is randomly chosen the UDP port used for
		/// video streaming. 
		/// </summary>
		public Range VideoPortsRange
		{
			get
			{
				IntPtr ptr = linphone_core_get_video_ports_range(nativePtr);
				return fromNativePtr<Range>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_video_preset(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_preset(IntPtr thiz, string preset);

		/// <summary>
		/// Get the video preset used for video calls. 
		/// </summary>
		public string VideoPreset
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_video_preset(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_video_preset(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_video_preview_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_video_preview(IntPtr thiz, char val);

		/// <summary>
		/// Tells whether video preview is enabled. 
		/// </summary>
		public bool VideoPreviewEnabled
		{
			get
			{
				return linphone_core_video_preview_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_core_enable_video_preview(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_video_source_reuse(IntPtr thiz, char enable);

		/// <summary>
		/// Enable or disable video source reuse when switching from preview to actual
		/// video call. 
		/// </summary>
		public bool VideoSourceReuseEnabled
		{
			set
			{
				linphone_core_enable_video_source_reuse(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_zrtp_cache_db(IntPtr thiz);

		/// <summary>
		/// Get a pointer to the sqlite db holding zrtp/lime cache. 
		/// </summary>
		public IntPtr ZrtpCacheDb
		{
			get
			{
				return linphone_core_get_zrtp_cache_db(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_zrtp_secrets_file(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_zrtp_secrets_file(IntPtr thiz, string file);

		/// <summary>
		/// Get the path to the file storing the zrtp secrets cache. 
		/// </summary>
		public string ZrtpSecretsFile
		{
			get
			{
				IntPtr stringPtr = linphone_core_get_zrtp_secrets_file(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_core_set_zrtp_secrets_file(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_accept_call(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Accept an incoming call. 
		/// </summary>
		public void AcceptCall(Call call)
		{
			int exception_result = linphone_core_accept_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptCall returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_accept_call_update(IntPtr thiz, IntPtr call, IntPtr parameters);

		/// <summary>
		/// Accept call modifications initiated by other end. 
		/// </summary>
		public void AcceptCallUpdate(Call call, CallParams parameters)
		{
			int exception_result = linphone_core_accept_call_update(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptCallUpdate returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_accept_call_with_params(IntPtr thiz, IntPtr call, IntPtr parameters);

		/// <summary>
		/// Accept an incoming call, with parameters. 
		/// </summary>
		public void AcceptCallWithParams(Call call, CallParams parameters)
		{
			int exception_result = linphone_core_accept_call_with_params(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptCallWithParams returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_accept_early_media(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Accept an early media session for an incoming call. 
		/// </summary>
		public void AcceptEarlyMedia(Call call)
		{
			int exception_result = linphone_core_accept_early_media(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptEarlyMedia returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_accept_early_media_with_params(IntPtr thiz, IntPtr call, IntPtr parameters);

		/// <summary>
		/// When receiving an incoming, accept to start a media session as early-media. 
		/// </summary>
		public void AcceptEarlyMediaWithParams(Call call, CallParams parameters)
		{
			int exception_result = linphone_core_accept_early_media_with_params(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AcceptEarlyMediaWithParams returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_add_all_to_conference(IntPtr thiz);

		/// <summary>
		/// Add all current calls into the conference. 
		/// </summary>
		public void AddAllToConference()
		{
			int exception_result = linphone_core_add_all_to_conference(nativePtr);
			if (exception_result != 0) throw new LinphoneException("AddAllToConference returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_add_auth_info(IntPtr thiz, IntPtr info);

		/// <summary>
		/// Adds authentication information to the <see cref="Core" />. 
		/// </summary>
		public void AddAuthInfo(AuthInfo info)
		{
			linphone_core_add_auth_info(nativePtr, info != null ? info.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_add_friend(IntPtr thiz, IntPtr fr);

		/// <summary>
		/// Add a friend to the current buddy list, if subscription attribute  is set, a
		/// SIP SUBSCRIBE message is sent. 
		/// </summary>
		public void AddFriend(Friend fr)
		{
			linphone_core_add_friend(nativePtr, fr != null ? fr.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_add_friend_list(IntPtr thiz, IntPtr list);

		/// <summary>
		/// Add a friend list. 
		/// </summary>
		public void AddFriendList(FriendList list)
		{
			linphone_core_add_friend_list(nativePtr, list != null ? list.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_add_proxy_config(IntPtr thiz, IntPtr config);

		/// <summary>
		/// Add a proxy configuration. 
		/// </summary>
		public void AddProxyConfig(ProxyConfig config)
		{
			int exception_result = linphone_core_add_proxy_config(nativePtr, config != null ? config.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddProxyConfig returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_add_supported_tag(IntPtr thiz, string tag);

		/// <summary>
		/// This function controls signaling features supported by the core. 
		/// </summary>
		public void AddSupportedTag(string tag)
		{
			linphone_core_add_supported_tag(nativePtr, tag);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_add_to_conference(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Add a participant to the conference. 
		/// </summary>
		public void AddToConference(Call call)
		{
			int exception_result = linphone_core_add_to_conference(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddToConference returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_check_for_update(IntPtr thiz, string currentVersion);

		/// <summary>
		/// Checks if a new version of the application is available. 
		/// </summary>
		public void CheckForUpdate(string currentVersion)
		{
			linphone_core_check_for_update(nativePtr, currentVersion);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_clear_all_auth_info(IntPtr thiz);

		/// <summary>
		/// Clear all authentication information. 
		/// </summary>
		public void ClearAllAuthInfo()
		{
			linphone_core_clear_all_auth_info(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_clear_call_logs(IntPtr thiz);

		/// <summary>
		/// Erase the call log. 
		/// </summary>
		public void ClearCallLogs()
		{
			linphone_core_clear_call_logs(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_clear_proxy_config(IntPtr thiz);

		/// <summary>
		/// Erase all proxies from config. 
		/// </summary>
		public void ClearProxyConfig()
		{
			linphone_core_clear_proxy_config(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_account_creator(IntPtr thiz, string xmlrpcUrl);

		/// <summary>
		/// Create a <see cref="AccountCreator" /> and set Linphone Request
		/// callbacks. 
		/// </summary>
		public AccountCreator CreateAccountCreator(string xmlrpcUrl)
		{
			IntPtr ptr = linphone_core_create_account_creator(nativePtr, xmlrpcUrl);
			return fromNativePtr<AccountCreator>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_address(IntPtr thiz, string address);

		/// <summary>
		/// Create a <see cref="Address" /> object by parsing the user supplied
		/// address, given as a string. 
		/// </summary>
		public Address CreateAddress(string address)
		{
			IntPtr ptr = linphone_core_create_address(nativePtr, address);
			return fromNativePtr<Address>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_auth_info(IntPtr thiz, string username, string userid, string passwd, string ha1, string realm, string domain);

		/// <summary>
		/// Create an authentication information with default values from Linphone core. 
		/// </summary>
		public AuthInfo CreateAuthInfo(string username, string userid, string passwd, string ha1, string realm, string domain)
		{
			IntPtr ptr = linphone_core_create_auth_info(nativePtr, username, userid, passwd, ha1, realm, domain);
			return fromNativePtr<AuthInfo>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_call_log(IntPtr thiz, IntPtr from, IntPtr to, int dir, int duration, long startTime, long connectedTime, int status, char videoEnabled, float quality);

		/// <summary>
		/// Creates a fake LinphoneCallLog. 
		/// </summary>
		public CallLog CreateCallLog(Address from, Address to, CallDir dir, int duration, long startTime, long connectedTime, CallStatus status, bool videoEnabled, float quality)
		{
			IntPtr ptr = linphone_core_create_call_log(nativePtr, from != null ? from.nativePtr : IntPtr.Zero, to != null ? to.nativePtr : IntPtr.Zero, (int)dir, duration, startTime, connectedTime, (int)status, videoEnabled ? (char)1 : (char)0, quality);
			return fromNativePtr<CallLog>(ptr, false);
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_call_params(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Create a <see cref="CallParams" /> suitable for <see
		/// cref="Core.InviteWithParams()" />, <see
		/// cref="Core.AcceptCallWithParams()" />, <see
		/// cref="Core.AcceptEarlyMediaWithParams()" />, <see
		/// cref="Core.AcceptCallUpdate()" />. 
		/// </summary>
		public CallParams CreateCallParams(Call call)
		{
			IntPtr ptr = linphone_core_create_call_params(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			return fromNativePtr<CallParams>(ptr, false);
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_client_group_chat_room(IntPtr thiz, string subject, char fallback);

		/// <summary>
		/// Create a client-side group chat room. 
		/// </summary>
		public ChatRoom CreateClientGroupChatRoom(string subject, bool fallback)
		{
			IntPtr ptr = linphone_core_create_client_group_chat_room(nativePtr, subject, fallback ? (char)1 : (char)0);
			return fromNativePtr<ChatRoom>(ptr, false);
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_conference_params(IntPtr thiz);

		/// <summary>
		/// Create some default conference parameters for instanciating a a conference with
		/// <see cref="Core.CreateConferenceWithParams()" />. 
		/// </summary>
		public ConferenceParams CreateConferenceParams()
		{
			IntPtr ptr = linphone_core_create_conference_params(nativePtr);
			return fromNativePtr<ConferenceParams>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_conference_with_params(IntPtr thiz, IntPtr parameters);

		/// <summary>
		/// Create a conference. 
		/// </summary>
		public Conference CreateConferenceWithParams(ConferenceParams parameters)
		{
			IntPtr ptr = linphone_core_create_conference_with_params(nativePtr, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			return fromNativePtr<Conference>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_config(IntPtr thiz, string filename);

		/// <summary>
		/// Create a <see cref="Config" /> object from a user config file. 
		/// </summary>
		public Config CreateConfig(string filename)
		{
			IntPtr ptr = linphone_core_create_config(nativePtr, filename);
			return fromNativePtr<Config>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_content(IntPtr thiz);

		/// <summary>
		/// Create a content with default values from Linphone core. 
		/// </summary>
		public Content CreateContent()
		{
			IntPtr ptr = linphone_core_create_content(nativePtr);
			return fromNativePtr<Content>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_friend(IntPtr thiz);

		/// <summary>
		/// Create a default LinphoneFriend. 
		/// </summary>
		public Friend CreateFriend()
		{
			IntPtr ptr = linphone_core_create_friend(nativePtr);
			return fromNativePtr<Friend>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_friend_list(IntPtr thiz);

		/// <summary>
		/// Create a new empty <see cref="FriendList" /> object. 
		/// </summary>
		public FriendList CreateFriendList()
		{
			IntPtr ptr = linphone_core_create_friend_list(nativePtr);
			return fromNativePtr<FriendList>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_friend_with_address(IntPtr thiz, string address);

		/// <summary>
		/// Create a <see cref="Friend" /> from the given address. 
		/// </summary>
		public Friend CreateFriendWithAddress(string address)
		{
			IntPtr ptr = linphone_core_create_friend_with_address(nativePtr, address);
			return fromNativePtr<Friend>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_info_message(IntPtr thiz);

		/// <summary>
		/// Creates an empty info message. 
		/// </summary>
		public InfoMessage CreateInfoMessage()
		{
			IntPtr ptr = linphone_core_create_info_message(nativePtr);
			return fromNativePtr<InfoMessage>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_local_player(IntPtr thiz, string soundCardName, string videoDisplayName, IntPtr windowId);

		/// <summary>
		/// Create an independent media file player. 
		/// </summary>
		public Player CreateLocalPlayer(string soundCardName, string videoDisplayName, IntPtr windowId)
		{
			IntPtr ptr = linphone_core_create_local_player(nativePtr, soundCardName, videoDisplayName, windowId);
			return fromNativePtr<Player>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_magic_search(IntPtr thiz);

		/// <summary>
		/// Create a <see cref="MagicSearch" /> object. 
		/// </summary>
		public MagicSearch CreateMagicSearch()
		{
			IntPtr ptr = linphone_core_create_magic_search(nativePtr);
			return fromNativePtr<MagicSearch>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_nat_policy(IntPtr thiz);

		/// <summary>
		/// Create a new <see cref="NatPolicy" /> object with every policies being
		/// disabled. 
		/// </summary>
		public NatPolicy CreateNatPolicy()
		{
			IntPtr ptr = linphone_core_create_nat_policy(nativePtr);
			return fromNativePtr<NatPolicy>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_nat_policy_from_config(IntPtr thiz, string reference);

		/// <summary>
		/// Create a new <see cref="NatPolicy" /> by reading the config of a <see
		/// cref="Core" /> according to the passed ref. 
		/// </summary>
		public NatPolicy CreateNatPolicyFromConfig(string reference)
		{
			IntPtr ptr = linphone_core_create_nat_policy_from_config(nativePtr, reference);
			return fromNativePtr<NatPolicy>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_notify(IntPtr thiz, IntPtr resource, string ev);

		/// <summary>
		/// Create an out-of-dialog notification, specifying the destination resource, the
		/// event name. 
		/// </summary>
		public Event CreateNotify(Address resource, string ev)
		{
			IntPtr ptr = linphone_core_create_notify(nativePtr, resource != null ? resource.nativePtr : IntPtr.Zero, ev);
			return fromNativePtr<Event>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_one_shot_publish(IntPtr thiz, IntPtr resource, string ev);

		/// <summary>
		/// Create a publish context for a one-shot publish. 
		/// </summary>
		public Event CreateOneShotPublish(Address resource, string ev)
		{
			IntPtr ptr = linphone_core_create_one_shot_publish(nativePtr, resource != null ? resource.nativePtr : IntPtr.Zero, ev);
			return fromNativePtr<Event>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_presence_activity(IntPtr thiz, int acttype, string description);

		/// <summary>
		/// Create a <see cref="PresenceActivity" /> with the given type and
		/// description. 
		/// </summary>
		public PresenceActivity CreatePresenceActivity(PresenceActivityType acttype, string description)
		{
			IntPtr ptr = linphone_core_create_presence_activity(nativePtr, (int)acttype, description);
			return fromNativePtr<PresenceActivity>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_presence_model(IntPtr thiz);

		/// <summary>
		/// Create a default LinphonePresenceModel. 
		/// </summary>
		public PresenceModel CreatePresenceModel()
		{
			IntPtr ptr = linphone_core_create_presence_model(nativePtr);
			return fromNativePtr<PresenceModel>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_presence_model_with_activity(IntPtr thiz, int acttype, string description);

		/// <summary>
		/// Create a <see cref="PresenceModel" /> with the given activity type and
		/// activity description. 
		/// </summary>
		public PresenceModel CreatePresenceModelWithActivity(PresenceActivityType acttype, string description)
		{
			IntPtr ptr = linphone_core_create_presence_model_with_activity(nativePtr, (int)acttype, description);
			return fromNativePtr<PresenceModel>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_presence_model_with_activity_and_note(IntPtr thiz, int acttype, string description, string note, string lang);

		/// <summary>
		/// Create a <see cref="PresenceModel" /> with the given activity type,
		/// activity description, note content and note language. 
		/// </summary>
		public PresenceModel CreatePresenceModelWithActivityAndNote(PresenceActivityType acttype, string description, string note, string lang)
		{
			IntPtr ptr = linphone_core_create_presence_model_with_activity_and_note(nativePtr, (int)acttype, description, note, lang);
			return fromNativePtr<PresenceModel>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_presence_note(IntPtr thiz, string content, string lang);

		/// <summary>
		/// Create a <see cref="PresenceNote" /> with the given content and
		/// language. 
		/// </summary>
		public PresenceNote CreatePresenceNote(string content, string lang)
		{
			IntPtr ptr = linphone_core_create_presence_note(nativePtr, content, lang);
			return fromNativePtr<PresenceNote>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_presence_person(IntPtr thiz, string id);

		/// <summary>
		/// Create a <see cref="PresencePerson" /> with the given id. 
		/// </summary>
		public PresencePerson CreatePresencePerson(string id)
		{
			IntPtr ptr = linphone_core_create_presence_person(nativePtr, id);
			return fromNativePtr<PresencePerson>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_presence_service(IntPtr thiz, string id, int basicStatus, string contact);

		/// <summary>
		/// Create a <see cref="PresenceService" /> with the given id, basic
		/// status and contact. 
		/// </summary>
		public PresenceService CreatePresenceService(string id, PresenceBasicStatus basicStatus, string contact)
		{
			IntPtr ptr = linphone_core_create_presence_service(nativePtr, id, (int)basicStatus, contact);
			return fromNativePtr<PresenceService>(ptr, false);
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_proxy_config(IntPtr thiz);

		/// <summary>
		/// Create a proxy config with default values from Linphone core. 
		/// </summary>
		public ProxyConfig CreateProxyConfig()
		{
			IntPtr ptr = linphone_core_create_proxy_config(nativePtr);
			return fromNativePtr<ProxyConfig>(ptr, false);
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_publish(IntPtr thiz, IntPtr resource, string ev, int expires);

		/// <summary>
		/// Create a publish context for an event state. 
		/// </summary>
		public Event CreatePublish(Address resource, string ev, int expires)
		{
			IntPtr ptr = linphone_core_create_publish(nativePtr, resource != null ? resource.nativePtr : IntPtr.Zero, ev, expires);
			return fromNativePtr<Event>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_subscribe(IntPtr thiz, IntPtr resource, string ev, int expires);

		/// <summary>
		/// Create an outgoing subscription, specifying the destination resource, the event
		/// name, and an optional content body. 
		/// </summary>
		public Event CreateSubscribe(Address resource, string ev, int expires)
		{
			IntPtr ptr = linphone_core_create_subscribe(nativePtr, resource != null ? resource.nativePtr : IntPtr.Zero, ev, expires);
			return fromNativePtr<Event>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_create_xml_rpc_session(IntPtr thiz, string url);

		/// <summary>
		/// Create a <see cref="XmlRpcSession" /> for a given url. 
		/// </summary>
		public XmlRpcSession CreateXmlRpcSession(string url)
		{
			IntPtr ptr = linphone_core_create_xml_rpc_session(nativePtr, url);
			return fromNativePtr<XmlRpcSession>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_decline_call(IntPtr thiz, IntPtr call, int reason);

		/// <summary>
		/// Decline a pending incoming call, with a reason. 
		/// </summary>
		public void DeclineCall(Call call, Reason reason)
		{
			int exception_result = linphone_core_decline_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, (int)reason);
			if (exception_result != 0) throw new LinphoneException("DeclineCall returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_defer_call_update(IntPtr thiz, IntPtr call);

		/// <summary>
		/// When receiving a #LinphoneCallUpdatedByRemote state notification, prevent <see
		/// cref="Core" /> from performing an automatic answer. 
		/// </summary>
		public void DeferCallUpdate(Call call)
		{
			int exception_result = linphone_core_defer_call_update(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("DeferCallUpdate returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_delete_chat_room(IntPtr thiz, IntPtr cr);

		/// <summary>
		/// Removes a chatroom including all message history from the LinphoneCore. 
		/// </summary>
		public void DeleteChatRoom(ChatRoom cr)
		{
			linphone_core_delete_chat_room(nativePtr, cr != null ? cr.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_disable_chat(IntPtr thiz, int denyReason);

		/// <summary>
		/// Inconditionnaly disable incoming chat messages. 
		/// </summary>
		public void DisableChat(Reason denyReason)
		{
			linphone_core_disable_chat(nativePtr, (int)denyReason);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_chat(IntPtr thiz);

		/// <summary>
		/// Enable reception of incoming chat messages. 
		/// </summary>
		public void EnableChat()
		{
			linphone_core_enable_chat(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enable_lime(IntPtr thiz, int val);

		/// <summary>
		/// Tells to <see cref="Core" /> to use Linphone Instant Messaging
		/// encryption. 
		/// </summary>
		public void EnableLime(LimeState val)
		{
			linphone_core_enable_lime(nativePtr, (int)val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enter_background(IntPtr thiz);

		/// <summary>
		/// This method is called by the application to notify the linphone core library
		/// when it enters background mode. 
		/// </summary>
		public void EnterBackground()
		{
			linphone_core_enter_background(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_enter_conference(IntPtr thiz);

		/// <summary>
		/// Join the local participant to the running conference. 
		/// </summary>
		public void EnterConference()
		{
			int exception_result = linphone_core_enter_conference(nativePtr);
			if (exception_result != 0) throw new LinphoneException("EnterConference returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_enter_foreground(IntPtr thiz);

		/// <summary>
		/// This method is called by the application to notify the linphone core library
		/// when it enters foreground mode. 
		/// </summary>
		public void EnterForeground()
		{
			linphone_core_enter_foreground(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_file_format_supported(IntPtr thiz, string fmt);

		/// <summary>
		/// Returns whether a specific file format is supported. 
		/// </summary>
		public bool FileFormatSupported(string fmt)
		{
			return linphone_core_file_format_supported(nativePtr, fmt) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_find_auth_info(IntPtr thiz, string realm, string username, string sipDomain);

		/// <summary>
		/// Find authentication info matching realm, username, domain criteria. 
		/// </summary>
		public AuthInfo FindAuthInfo(string realm, string username, string sipDomain)
		{
			IntPtr ptr = linphone_core_find_auth_info(nativePtr, realm, username, sipDomain);
			return fromNativePtr<AuthInfo>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_find_call_from_uri(IntPtr thiz, string uri);

		/// <summary>
		/// Search from the list of current calls if a remote address match uri. 
		/// </summary>
		public Call FindCallFromUri(string uri)
		{
			IntPtr ptr = linphone_core_find_call_from_uri(nativePtr, uri);
			return fromNativePtr<Call>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_find_call_log_from_call_id(IntPtr thiz, string callId);

		/// <summary>
		/// Get the call log matching the call id, or null if can't be found. 
		/// </summary>
		public CallLog FindCallLogFromCallId(string callId)
		{
			IntPtr ptr = linphone_core_find_call_log_from_call_id(nativePtr, callId);
			return fromNativePtr<CallLog>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_find_chat_room(IntPtr thiz, IntPtr peerAddr, IntPtr localAddr);

		/// <summary>
		/// Find a chat room. 
		/// </summary>
		public ChatRoom FindChatRoom(Address peerAddr, Address localAddr)
		{
			IntPtr ptr = linphone_core_find_chat_room(nativePtr, peerAddr != null ? peerAddr.nativePtr : IntPtr.Zero, localAddr != null ? localAddr.nativePtr : IntPtr.Zero);
			return fromNativePtr<ChatRoom>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_find_contacts_by_char(IntPtr thiz, string filter, char sipOnly);

		/// <summary>
		/// Retrieves a list of <see cref="Address" /> sort and filter. 
		/// </summary>
		public IEnumerable<Address> FindContactsByChar(string filter, bool sipOnly)
		{
			return MarshalBctbxList<Address>(linphone_core_find_contacts_by_char(nativePtr, filter, sipOnly ? (char)1 : (char)0));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_find_friend(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Search a <see cref="Friend" /> by its address. 
		/// </summary>
		public Friend FindFriend(Address addr)
		{
			IntPtr ptr = linphone_core_find_friend(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero);
			return fromNativePtr<Friend>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_find_one_to_one_chat_room(IntPtr thiz, IntPtr localAddr, IntPtr participantAddr);

		/// <summary>
		/// Find a one to one chat room. 
		/// </summary>
		public ChatRoom FindOneToOneChatRoom(Address localAddr, Address participantAddr)
		{
			IntPtr ptr = linphone_core_find_one_to_one_chat_room(nativePtr, localAddr != null ? localAddr.nativePtr : IntPtr.Zero, participantAddr != null ? participantAddr.nativePtr : IntPtr.Zero);
			return fromNativePtr<ChatRoom>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_call_by_remote_address(IntPtr thiz, string remoteAddress);

		/// <summary>
		/// Get the call with the remote_address specified. 
		/// </summary>
		public Call GetCallByRemoteAddress(string remoteAddress)
		{
			IntPtr ptr = linphone_core_get_call_by_remote_address(nativePtr, remoteAddress);
			return fromNativePtr<Call>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_call_by_remote_address2(IntPtr thiz, IntPtr remoteAddress);

		/// <summary>
		/// Get the call with the remote_address specified. 
		/// </summary>
		public Call GetCallByRemoteAddress2(Address remoteAddress)
		{
			IntPtr ptr = linphone_core_get_call_by_remote_address2(nativePtr, remoteAddress != null ? remoteAddress.nativePtr : IntPtr.Zero);
			return fromNativePtr<Call>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_call_history_for_address(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Get the list of call logs (past calls) that matches the given <see
		/// cref="Address" />. 
		/// </summary>
		public IEnumerable<CallLog> GetCallHistoryForAddress(Address addr)
		{
			return MarshalBctbxList<CallLog>(linphone_core_get_call_history_for_address(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_chat_room(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Get a basic chat room whose peer is the supplied address. 
		/// </summary>
		public ChatRoom GetChatRoom(Address addr)
		{
			IntPtr ptr = linphone_core_get_chat_room(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero);
			return fromNativePtr<ChatRoom>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_chat_room_from_uri(IntPtr thiz, string to);

		/// <summary>
		/// Get a basic chat room for messaging from a sip uri like
		/// sip:joe@sip.org. 
		/// </summary>
		public ChatRoom GetChatRoomFromUri(string to)
		{
			IntPtr ptr = linphone_core_get_chat_room_from_uri(nativePtr, to);
			return fromNativePtr<ChatRoom>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_friend_by_ref_key(IntPtr thiz, string key);

		/// <summary>
		/// Search a <see cref="Friend" /> by its reference key. 
		/// </summary>
		public Friend GetFriendByRefKey(string key)
		{
			IntPtr ptr = linphone_core_get_friend_by_ref_key(nativePtr, key);
			return fromNativePtr<Friend>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_get_payload_type(IntPtr thiz, string type, int rate, int channels);

		/// <summary>
		/// Get payload type from mime type and clock rate. 
		/// </summary>
		public PayloadType GetPayloadType(string type, int rate, int channels)
		{
			IntPtr ptr = linphone_core_get_payload_type(nativePtr, type, rate, channels);
			return fromNativePtr<PayloadType>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_has_builtin_echo_canceller(IntPtr thiz);

		/// <summary>
		/// Check whether the device has a hardware echo canceller. 
		/// </summary>
		public bool HasBuiltinEchoCanceller()
		{
			return linphone_core_has_builtin_echo_canceller(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_has_crappy_opengl(IntPtr thiz);

		/// <summary>
		/// Check whether the device is flagged has crappy opengl. 
		/// </summary>
		public bool HasCrappyOpengl()
		{
			return linphone_core_has_crappy_opengl(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_in_call(IntPtr thiz);

		/// <summary>
		/// Tells whether there is a call running. 
		/// </summary>
		public bool InCall()
		{
			return linphone_core_in_call(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_interpret_url(IntPtr thiz, string url);

		/// <summary>
		/// See linphone_proxy_config_normalize_sip_uri for documentation. 
		/// </summary>
		public Address InterpretUrl(string url)
		{
			IntPtr ptr = linphone_core_interpret_url(nativePtr, url);
			return fromNativePtr<Address>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_invite(IntPtr thiz, string url);

		/// <summary>
		/// Initiates an outgoing call. 
		/// </summary>
		public Call Invite(string url)
		{
			IntPtr ptr = linphone_core_invite(nativePtr, url);
			return fromNativePtr<Call>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_invite_address(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Initiates an outgoing call given a destination <see cref="Address" />
		/// The <see cref="Address" /> can be constructed directly using
		/// linphone_address_new, or created by <see cref="Core.InterpretUrl()"
		/// />. 
		/// </summary>
		public Call InviteAddress(Address addr)
		{
			IntPtr ptr = linphone_core_invite_address(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero);
			return fromNativePtr<Call>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_invite_address_with_params(IntPtr thiz, IntPtr addr, IntPtr parameters);

		/// <summary>
		/// Initiates an outgoing call given a destination <see cref="Address" />
		/// The <see cref="Address" /> can be constructed directly using
		/// linphone_address_new, or created by <see cref="Core.InterpretUrl()"
		/// />. 
		/// </summary>
		public Call InviteAddressWithParams(Address addr, CallParams parameters)
		{
			IntPtr ptr = linphone_core_invite_address_with_params(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			return fromNativePtr<Call>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_invite_with_params(IntPtr thiz, string url, IntPtr parameters);

		/// <summary>
		/// Initiates an outgoing call according to supplied call parameters The
		/// application doesn't own a reference to the returned <see cref="Call"
		/// /> object. 
		/// </summary>
		public Call InviteWithParams(string url, CallParams parameters)
		{
			IntPtr ptr = linphone_core_invite_with_params(nativePtr, url, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			return fromNativePtr<Call>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_iterate(IntPtr thiz);

		/// <summary>
		/// Main loop function. 
		/// </summary>
		public void Iterate()
		{
			linphone_core_iterate(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_leave_conference(IntPtr thiz);

		/// <summary>
		/// Make the local participant leave the running conference. 
		/// </summary>
		public void LeaveConference()
		{
			int exception_result = linphone_core_leave_conference(nativePtr);
			if (exception_result != 0) throw new LinphoneException("LeaveConference returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_lime_available(IntPtr thiz);

		/// <summary>
		/// Tells if lime is available. 
		/// </summary>
		public bool LimeAvailable()
		{
			return linphone_core_lime_available(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern LimeState linphone_core_lime_enabled(IntPtr thiz);

		/// <summary>
		/// Returns the lime state. 
		/// </summary>
		public LimeState LimeEnabled()
		{
			return linphone_core_lime_enabled(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_media_encryption_supported(IntPtr thiz, int menc);

		/// <summary>
		/// Check if a media encryption type is supported. 
		/// </summary>
		public bool MediaEncryptionSupported(MediaEncryption menc)
		{
			return linphone_core_media_encryption_supported(nativePtr, (int)menc) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_migrate_logs_from_rc_to_db(IntPtr thiz);

		/// <summary>
		/// Migrates the call logs from the linphonerc to the database if not done yet. 
		/// </summary>
		public void MigrateLogsFromRcToDb()
		{
			linphone_core_migrate_logs_from_rc_to_db(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_migrate_to_multi_transport(IntPtr thiz);

		/// <summary>
		/// Migrate configuration so that all SIP transports are enabled. 
		/// </summary>
		public void MigrateToMultiTransport()
		{
			int exception_result = linphone_core_migrate_to_multi_transport(nativePtr);
			if (exception_result != 0) throw new LinphoneException("MigrateToMultiTransport returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_notify_all_friends(IntPtr thiz, IntPtr presence);

		/// <summary>
		/// Notify all friends that have subscribed. 
		/// </summary>
		public void NotifyAllFriends(PresenceModel presence)
		{
			linphone_core_notify_all_friends(nativePtr, presence != null ? presence.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_notify_notify_presence_received(IntPtr thiz, IntPtr lf);

		/// <summary>
		/// Notifies the upper layer that a presence status has been received by calling
		/// the appropriate callback if one has been set. 
		/// </summary>
		public void NotifyNotifyPresenceReceived(Friend lf)
		{
			linphone_core_notify_notify_presence_received(nativePtr, lf != null ? lf.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_notify_notify_presence_received_for_uri_or_tel(IntPtr thiz, IntPtr lf, string uriOrTel, IntPtr presenceModel);

		/// <summary>
		/// Notifies the upper layer that a presence model change has been received for the
		/// uri or telephone number given as a parameter, by calling the appropriate
		/// callback if one has been set. 
		/// </summary>
		public void NotifyNotifyPresenceReceivedForUriOrTel(Friend lf, string uriOrTel, PresenceModel presenceModel)
		{
			linphone_core_notify_notify_presence_received_for_uri_or_tel(nativePtr, lf != null ? lf.nativePtr : IntPtr.Zero, uriOrTel, presenceModel != null ? presenceModel.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_pause_all_calls(IntPtr thiz);

		/// <summary>
		/// Pause all currently running calls. 
		/// </summary>
		public void PauseAllCalls()
		{
			int exception_result = linphone_core_pause_all_calls(nativePtr);
			if (exception_result != 0) throw new LinphoneException("PauseAllCalls returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_pause_call(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Pauses the call. 
		/// </summary>
		public void PauseCall(Call call)
		{
			int exception_result = linphone_core_pause_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("PauseCall returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_play_dtmf(IntPtr thiz, sbyte dtmf, int durationMs);

		/// <summary>
		/// Plays a dtmf sound to the local user. 
		/// </summary>
		public void PlayDtmf(sbyte dtmf, int durationMs)
		{
			linphone_core_play_dtmf(nativePtr, dtmf, durationMs);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_play_local(IntPtr thiz, string audiofile);

		/// <summary>
		/// Plays an audio file to the local user. 
		/// </summary>
		public void PlayLocal(string audiofile)
		{
			int exception_result = linphone_core_play_local(nativePtr, audiofile);
			if (exception_result != 0) throw new LinphoneException("PlayLocal returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_preview_ogl_render(IntPtr thiz);

		/// <summary>
		/// Call generic OpenGL render for a given core. 
		/// </summary>
		public void PreviewOglRender()
		{
			linphone_core_preview_ogl_render(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_publish(IntPtr thiz, IntPtr resource, string ev, int expires, IntPtr body);

		/// <summary>
		/// Publish an event state. 
		/// </summary>
		public Event Publish(Address resource, string ev, int expires, Content body)
		{
			IntPtr ptr = linphone_core_publish(nativePtr, resource != null ? resource.nativePtr : IntPtr.Zero, ev, expires, body != null ? body.nativePtr : IntPtr.Zero);
			return fromNativePtr<Event>(ptr, true);
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_redirect_call(IntPtr thiz, IntPtr call, string redirectUri);

		/// <summary>
		/// Redirect the specified call to the given redirect URI. 
		/// </summary>
		public void RedirectCall(Call call, string redirectUri)
		{
			int exception_result = linphone_core_redirect_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, redirectUri);
			if (exception_result != 0) throw new LinphoneException("RedirectCall returned value" + exception_result);
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_refresh_registers(IntPtr thiz);

		/// <summary>
		/// force registration refresh to be initiated upon next iterate 
		/// </summary>
		public void RefreshRegisters()
		{
			linphone_core_refresh_registers(nativePtr);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_reject_subscriber(IntPtr thiz, IntPtr lf);

		/// <summary>
		/// Black list a friend. 
		/// </summary>
		public void RejectSubscriber(Friend lf)
		{
			linphone_core_reject_subscriber(nativePtr, lf != null ? lf.nativePtr : IntPtr.Zero);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_reload_ms_plugins(IntPtr thiz, string path);

		/// <summary>
		/// Reload mediastreamer2 plugins from specified directory. 
		/// </summary>
		public void ReloadMsPlugins(string path)
		{
			linphone_core_reload_ms_plugins(nativePtr, path);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_reload_sound_devices(IntPtr thiz);

		/// <summary>
		/// Update detection of sound devices. 
		/// </summary>
		public void ReloadSoundDevices()
		{
			linphone_core_reload_sound_devices(nativePtr);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_reload_video_devices(IntPtr thiz);

		/// <summary>
		/// Update detection of camera devices. 
		/// </summary>
		public void ReloadVideoDevices()
		{
			linphone_core_reload_video_devices(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_remove_auth_info(IntPtr thiz, IntPtr info);

		/// <summary>
		/// Removes an authentication information object. 
		/// </summary>
		public void RemoveAuthInfo(AuthInfo info)
		{
			linphone_core_remove_auth_info(nativePtr, info != null ? info.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_remove_call_log(IntPtr thiz, IntPtr callLog);

		/// <summary>
		/// Remove a specific call log from call history list. 
		/// </summary>
		public void RemoveCallLog(CallLog callLog)
		{
			linphone_core_remove_call_log(nativePtr, callLog != null ? callLog.nativePtr : IntPtr.Zero);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_remove_friend_list(IntPtr thiz, IntPtr list);

		/// <summary>
		/// Removes a friend list. 
		/// </summary>
		public void RemoveFriendList(FriendList list)
		{
			linphone_core_remove_friend_list(nativePtr, list != null ? list.nativePtr : IntPtr.Zero);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_remove_from_conference(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Remove a call from the conference. 
		/// </summary>
		public void RemoveFromConference(Call call)
		{
			int exception_result = linphone_core_remove_from_conference(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("RemoveFromConference returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_remove_proxy_config(IntPtr thiz, IntPtr config);

		/// <summary>
		/// Removes a proxy configuration. 
		/// </summary>
		public void RemoveProxyConfig(ProxyConfig config)
		{
			linphone_core_remove_proxy_config(nativePtr, config != null ? config.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_remove_supported_tag(IntPtr thiz, string tag);

		/// <summary>
		/// Remove a supported tag. 
		/// </summary>
		public void RemoveSupportedTag(string tag)
		{
			linphone_core_remove_supported_tag(nativePtr, tag);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_reset_missed_calls_count(IntPtr thiz);

		/// <summary>
		/// Reset the counter of missed calls. 
		/// </summary>
		public void ResetMissedCallsCount()
		{
			linphone_core_reset_missed_calls_count(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_resume_call(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Resumes a call. 
		/// </summary>
		public void ResumeCall(Call call)
		{
			int exception_result = linphone_core_resume_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("ResumeCall returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_audio_port_range(IntPtr thiz, int minPort, int maxPort);

		/// <summary>
		/// Sets the UDP port range from which to randomly select the port used for audio
		/// streaming. 
		/// </summary>
		public void SetAudioPortRange(int minPort, int maxPort)
		{
			linphone_core_set_audio_port_range(nativePtr, minPort, maxPort);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_call_error_tone(IntPtr thiz, int reason, string audiofile);

		/// <summary>
		/// Assign an audio file to be played locally upon call failure, for a given
		/// reason. 
		/// </summary>
		public void SetCallErrorTone(Reason reason, string audiofile)
		{
			linphone_core_set_call_error_tone(nativePtr, (int)reason, audiofile);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_qrcode_decode_rect(IntPtr thiz, int x, int y, int w, int h);

		/// <summary>
		/// Set the rectangle where the decoder will search a QRCode. 
		/// </summary>
		public void SetQrcodeDecodeRect(int x, int y, int w, int h)
		{
			linphone_core_set_qrcode_decode_rect(nativePtr, x, y, w, h);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_text_port_range(IntPtr thiz, int minPort, int maxPort);

		/// <summary>
		/// Sets the UDP port range from which to randomly select the port used for text
		/// streaming. 
		/// </summary>
		public void SetTextPortRange(int minPort, int maxPort)
		{
			linphone_core_set_text_port_range(nativePtr, minPort, maxPort);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_user_agent(IntPtr thiz, string uaName, string version);

		/// <summary>
		/// Sets the user agent string used in SIP messages, ideally called just after
		/// linphone_core_new or linphone_core_init(). 
		/// </summary>
		public void SetUserAgent(string uaName, string version)
		{
			linphone_core_set_user_agent(nativePtr, uaName, version);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_set_video_port_range(IntPtr thiz, int minPort, int maxPort);

		/// <summary>
		/// Sets the UDP port range from which to randomly select the port used for video
		/// streaming. 
		/// </summary>
		public void SetVideoPortRange(int minPort, int maxPort)
		{
			linphone_core_set_video_port_range(nativePtr, minPort, maxPort);
			
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_sound_device_can_capture(IntPtr thiz, string device);

		/// <summary>
		/// Tells whether a specified sound device can capture sound. 
		/// </summary>
		public bool SoundDeviceCanCapture(string device)
		{
			return linphone_core_sound_device_can_capture(nativePtr, device) == (char)0 ? false : true;
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_sound_device_can_playback(IntPtr thiz, string device);

		/// <summary>
		/// Tells whether a specified sound device can play sound. 
		/// </summary>
		public bool SoundDeviceCanPlayback(string device)
		{
			return linphone_core_sound_device_can_playback(nativePtr, device) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_sound_resources_locked(IntPtr thiz);

		/// <summary>
		/// Check if a call will need the sound resources in near future (typically an
		/// outgoing call that is awaiting response). 
		/// </summary>
		public bool SoundResourcesLocked()
		{
			return linphone_core_sound_resources_locked(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_start(IntPtr thiz);

		/// <summary>
		/// Start a <see cref="Core" /> object after it has been instantiated. 
		/// </summary>
		public void Start()
		{
			linphone_core_start(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_start_conference_recording(IntPtr thiz, string path);

		/// <summary>
		/// Start recording the running conference. 
		/// </summary>
		public void StartConferenceRecording(string path)
		{
			int exception_result = linphone_core_start_conference_recording(nativePtr, path);
			if (exception_result != 0) throw new LinphoneException("StartConferenceRecording returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_start_dtmf_stream(IntPtr thiz);

		/// <summary>
		/// Special function to warm up dtmf feeback stream. 
		/// </summary>
		public void StartDtmfStream()
		{
			linphone_core_start_dtmf_stream(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_start_echo_canceller_calibration(IntPtr thiz);

		/// <summary>
		/// Starts an echo calibration of the sound devices, in order to find adequate
		/// settings for the echo canceler automatically. 
		/// </summary>
		public void StartEchoCancellerCalibration()
		{
			int exception_result = linphone_core_start_echo_canceller_calibration(nativePtr);
			if (exception_result != 0) throw new LinphoneException("StartEchoCancellerCalibration returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_start_echo_tester(IntPtr thiz, uint rate);

		/// <summary>
		/// Start the simulation of call to test the latency with an external device. 
		/// </summary>
		public void StartEchoTester(uint rate)
		{
			int exception_result = linphone_core_start_echo_tester(nativePtr, rate);
			if (exception_result != 0) throw new LinphoneException("StartEchoTester returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_stop_conference_recording(IntPtr thiz);

		/// <summary>
		/// Stop recording the running conference. 
		/// </summary>
		public void StopConferenceRecording()
		{
			int exception_result = linphone_core_stop_conference_recording(nativePtr);
			if (exception_result != 0) throw new LinphoneException("StopConferenceRecording returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_stop_dtmf(IntPtr thiz);

		/// <summary>
		/// Stops playing a dtmf started by <see cref="Core.PlayDtmf()" />. 
		/// </summary>
		public void StopDtmf()
		{
			linphone_core_stop_dtmf(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_stop_dtmf_stream(IntPtr thiz);

		/// <summary>
		/// Special function to stop dtmf feed back function. 
		/// </summary>
		public void StopDtmfStream()
		{
			linphone_core_stop_dtmf_stream(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_stop_echo_tester(IntPtr thiz);

		/// <summary>
		/// Stop the simulation of call. 
		/// </summary>
		public void StopEchoTester()
		{
			int exception_result = linphone_core_stop_echo_tester(nativePtr);
			if (exception_result != 0) throw new LinphoneException("StopEchoTester returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_stop_ringing(IntPtr thiz);

		/// <summary>
		/// Whenever the liblinphone is playing a ring to advertise an incoming call or
		/// ringback of an outgoing call, this function stops the ringing. 
		/// </summary>
		public void StopRinging()
		{
			linphone_core_stop_ringing(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_core_subscribe(IntPtr thiz, IntPtr resource, string ev, int expires, IntPtr body);

		/// <summary>
		/// Create an outgoing subscription, specifying the destination resource, the event
		/// name, and an optional content body. 
		/// </summary>
		public Event Subscribe(Address resource, string ev, int expires, Content body)
		{
			IntPtr ptr = linphone_core_subscribe(nativePtr, resource != null ? resource.nativePtr : IntPtr.Zero, ev, expires, body != null ? body.nativePtr : IntPtr.Zero);
			return fromNativePtr<Event>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_take_preview_snapshot(IntPtr thiz, string file);

		/// <summary>
		/// Take a photo of currently from capture device and write it into a jpeg file. 
		/// </summary>
		public void TakePreviewSnapshot(string file)
		{
			int exception_result = linphone_core_take_preview_snapshot(nativePtr, file);
			if (exception_result != 0) throw new LinphoneException("TakePreviewSnapshot returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_terminate_all_calls(IntPtr thiz);

		/// <summary>
		/// Terminates all the calls. 
		/// </summary>
		public void TerminateAllCalls()
		{
			int exception_result = linphone_core_terminate_all_calls(nativePtr);
			if (exception_result != 0) throw new LinphoneException("TerminateAllCalls returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_terminate_call(IntPtr thiz, IntPtr call);

		/// <summary>
		/// Terminates a call. 
		/// </summary>
		public void TerminateCall(Call call)
		{
			int exception_result = linphone_core_terminate_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("TerminateCall returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_terminate_conference(IntPtr thiz);

		/// <summary>
		/// Terminate the running conference. 
		/// </summary>
		public void TerminateConference()
		{
			int exception_result = linphone_core_terminate_conference(nativePtr);
			if (exception_result != 0) throw new LinphoneException("TerminateConference returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_transfer_call(IntPtr thiz, IntPtr call, string referTo);

		/// <summary>
		/// Performs a simple call transfer to the specified destination. 
		/// </summary>
		public void TransferCall(Call call, string referTo)
		{
			int exception_result = linphone_core_transfer_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, referTo);
			if (exception_result != 0) throw new LinphoneException("TransferCall returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_transfer_call_to_another(IntPtr thiz, IntPtr call, IntPtr dest);

		/// <summary>
		/// Transfers a call to destination of another running call. 
		/// </summary>
		public void TransferCallToAnother(Call call, Call dest)
		{
			int exception_result = linphone_core_transfer_call_to_another(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, dest != null ? dest.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("TransferCallToAnother returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_core_update_call(IntPtr thiz, IntPtr call, IntPtr parameters);

		/// <summary>
		/// Updates a running call according to supplied call parameters or parameters
		/// changed in the LinphoneCore. 
		/// </summary>
		public void UpdateCall(Call call, CallParams parameters)
		{
			int exception_result = linphone_core_update_call(nativePtr, call != null ? call.nativePtr : IntPtr.Zero, parameters != null ? parameters.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("UpdateCall returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_upload_log_collection(IntPtr thiz);

		/// <summary>
		/// Upload the log collection to the configured server url. 
		/// </summary>
		public void UploadLogCollection()
		{
			linphone_core_upload_log_collection(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_use_preview_window(IntPtr thiz, char yesno);

		/// <summary>
		/// Tells the core to use a separate window for local camera preview video, instead
		/// of inserting local view within the remote video window. 
		/// </summary>
		public void UsePreviewWindow(bool yesno)
		{
			linphone_core_use_preview_window(nativePtr, yesno ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_verify_server_certificates(IntPtr thiz, char yesno);

		/// <summary>
		/// Specify whether the tls server certificate must be verified when connecting to
		/// a SIP/TLS server. 
		/// </summary>
		public void VerifyServerCertificates(bool yesno)
		{
			linphone_core_verify_server_certificates(nativePtr, yesno ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_core_verify_server_cn(IntPtr thiz, char yesno);

		/// <summary>
		/// Specify whether the tls server certificate common name must be verified when
		/// connecting to a SIP/TLS server. 
		/// </summary>
		public void VerifyServerCn(bool yesno)
		{
			linphone_core_verify_server_cn(nativePtr, yesno ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_core_video_supported(IntPtr thiz);

		/// <summary>
		/// Test if video is supported. 
		/// </summary>
		public bool VideoSupported()
		{
			return linphone_core_video_supported(nativePtr) == (char)0 ? false : true;
		}
	}

	/// <summary>
	/// Represents a dial plan. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class DialPlan : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_dial_plan_by_ccc(string ccc);

		/// <summary>
		/// Find best match for given CCC. 
		/// </summary>
		public static DialPlan ByCcc(string ccc)
		{
			IntPtr ptr = linphone_dial_plan_by_ccc(ccc);
			return fromNativePtr<DialPlan>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_dial_plan_by_ccc_as_int(int ccc);

		/// <summary>
		/// Find best match for given CCC. 
		/// </summary>
		public static DialPlan ByCccAsInt(int ccc)
		{
			IntPtr ptr = linphone_dial_plan_by_ccc_as_int(ccc);
			return fromNativePtr<DialPlan>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_dial_plan_get_all_list();

		static public IEnumerable<DialPlan> AllList
		{
			get
			{
				return MarshalBctbxList<DialPlan>(linphone_dial_plan_get_all_list());
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_dial_plan_lookup_ccc_from_e164(string e164);

		/// <summary>
		/// Function to get call country code from an e164 number, ex: +33952650121 will
		/// return 33. 
		/// </summary>
		public static int LookupCccFromE164(string e164)
		{
			return linphone_dial_plan_lookup_ccc_from_e164(e164);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_dial_plan_lookup_ccc_from_iso(string iso);

		/// <summary>
		/// Function to get call country code from ISO 3166-1 alpha-2 code, ex: FR returns
		/// 33. 
		/// </summary>
		public static int LookupCccFromIso(string iso)
		{
			return linphone_dial_plan_lookup_ccc_from_iso(iso);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_dial_plan_get_country(IntPtr thiz);

		/// <summary>
		/// Returns the country name of the dialplan. 
		/// </summary>
		public string Country
		{
			get
			{
				IntPtr stringPtr = linphone_dial_plan_get_country(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_dial_plan_get_country_calling_code(IntPtr thiz);

		/// <summary>
		/// Returns the country calling code of the dialplan. 
		/// </summary>
		public string CountryCallingCode
		{
			get
			{
				IntPtr stringPtr = linphone_dial_plan_get_country_calling_code(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_dial_plan_get_international_call_prefix(IntPtr thiz);

		/// <summary>
		/// Returns the international call prefix of the dialplan. 
		/// </summary>
		public string InternationalCallPrefix
		{
			get
			{
				IntPtr stringPtr = linphone_dial_plan_get_international_call_prefix(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_dial_plan_is_generic(IntPtr thiz);

		/// <summary>
		/// Return if given plan is generic. 
		/// </summary>
		public bool IsGeneric
		{
			get
			{
				return linphone_dial_plan_is_generic(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_dial_plan_get_iso_country_code(IntPtr thiz);

		/// <summary>
		/// Returns the iso country code of the dialplan. 
		/// </summary>
		public string IsoCountryCode
		{
			get
			{
				IntPtr stringPtr = linphone_dial_plan_get_iso_country_code(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_dial_plan_get_national_number_length(IntPtr thiz);

		/// <summary>
		/// Returns the national number length of the dialplan. 
		/// </summary>
		public int NationalNumberLength
		{
			get
			{
				return linphone_dial_plan_get_national_number_length(nativePtr);
			}
		}
	}

	/// <summary>
	/// Object representing full details about a signaling error or status. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class ErrorInfo : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_error_info_get_phrase(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_error_info_set_phrase(IntPtr thiz, string phrase);

		/// <summary>
		/// Get textual phrase from the error info. 
		/// </summary>
		public string Phrase
		{
			get
			{
				IntPtr stringPtr = linphone_error_info_get_phrase(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_error_info_set_phrase(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_error_info_get_protocol(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_error_info_set_protocol(IntPtr thiz, string proto);

		/// <summary>
		/// Get protocol from the error info. 
		/// </summary>
		public string Protocol
		{
			get
			{
				IntPtr stringPtr = linphone_error_info_get_protocol(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_error_info_set_protocol(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_error_info_get_protocol_code(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_error_info_set_protocol_code(IntPtr thiz, int code);

		/// <summary>
		/// Get the status code from the low level protocol (ex a SIP status code). 
		/// </summary>
		public int ProtocolCode
		{
			get
			{
				return linphone_error_info_get_protocol_code(nativePtr);
			}
			set
			{
				linphone_error_info_set_protocol_code(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern Reason linphone_error_info_get_reason(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_error_info_set_reason(IntPtr thiz, int reason);

		/// <summary>
		/// Get reason code from the error info. 
		/// </summary>
		public Reason Reason
		{
			get
			{
				return linphone_error_info_get_reason(nativePtr);
			}
			set
			{
				linphone_error_info_set_reason(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_error_info_get_sub_error_info(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_error_info_set_sub_error_info(IntPtr thiz, IntPtr appendedEi);

		/// <summary>
		/// Get pointer to chained <see cref="ErrorInfo" /> set in sub_ei. 
		/// </summary>
		public ErrorInfo SubErrorInfo
		{
			get
			{
				IntPtr ptr = linphone_error_info_get_sub_error_info(nativePtr);
				return fromNativePtr<ErrorInfo>(ptr, true);
			}
			set
			{
				linphone_error_info_set_sub_error_info(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_error_info_get_warnings(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_error_info_set_warnings(IntPtr thiz, string warnings);

		/// <summary>
		/// Provides additional information regarding the failure. 
		/// </summary>
		public string Warnings
		{
			get
			{
				IntPtr stringPtr = linphone_error_info_get_warnings(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_error_info_set_warnings(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_error_info_set(IntPtr thiz, string protocol, int reason, int code, string statusString, string warning);

		/// <summary>
		/// Assign information to a <see cref="ErrorInfo" /> object. 
		/// </summary>
		public void Set(string protocol, Reason reason, int code, string statusString, string warning)
		{
			linphone_error_info_set(nativePtr, protocol, (int)reason, code, statusString, warning);
			
		}
	}

	/// <summary>
	/// Object representing an event state, which is subcribed or published. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Event : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_callbacks(IntPtr thiz);

		/// <summary>
		/// Object representing an event state, which is subcribed or published. 
		/// </summary>
		public EventListener Listener
		{
			get
			{
				IntPtr ptr = linphone_event_get_callbacks(nativePtr);
				return fromNativePtr<EventListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_core(IntPtr thiz);

		/// <summary>
		/// Returns back pointer to the <see cref="Core" /> that created this <see
		/// cref="Event" />. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_event_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_error_info(IntPtr thiz);

		/// <summary>
		/// Get full details about an error occured. 
		/// </summary>
		public ErrorInfo ErrorInfo
		{
			get
			{
				IntPtr ptr = linphone_event_get_error_info(nativePtr);
				return fromNativePtr<ErrorInfo>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_from(IntPtr thiz);

		/// <summary>
		/// Get the "from" address of the subscription. 
		/// </summary>
		public Address From
		{
			get
			{
				IntPtr ptr = linphone_event_get_from(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_name(IntPtr thiz);

		/// <summary>
		/// Get the name of the event as specified in the event package RFC. 
		/// </summary>
		public string Name
		{
			get
			{
				IntPtr stringPtr = linphone_event_get_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern PublishState linphone_event_get_publish_state(IntPtr thiz);

		/// <summary>
		/// Get publish state. 
		/// </summary>
		public PublishState PublishState
		{
			get
			{
				return linphone_event_get_publish_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern Reason linphone_event_get_reason(IntPtr thiz);

		/// <summary>
		/// Return reason code (in case of error state reached). 
		/// </summary>
		public Reason Reason
		{
			get
			{
				return linphone_event_get_reason(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_remote_contact(IntPtr thiz);

		/// <summary>
		/// Get the "contact" address of the subscription. 
		/// </summary>
		public Address RemoteContact
		{
			get
			{
				IntPtr ptr = linphone_event_get_remote_contact(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_resource(IntPtr thiz);

		/// <summary>
		/// Get the resource address of the subscription or publish. 
		/// </summary>
		public Address Resource
		{
			get
			{
				IntPtr ptr = linphone_event_get_resource(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern SubscriptionDir linphone_event_get_subscription_dir(IntPtr thiz);

		/// <summary>
		/// Get subscription direction. 
		/// </summary>
		public SubscriptionDir SubscriptionDir
		{
			get
			{
				return linphone_event_get_subscription_dir(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern SubscriptionState linphone_event_get_subscription_state(IntPtr thiz);

		/// <summary>
		/// Get subscription state. 
		/// </summary>
		public SubscriptionState SubscriptionState
		{
			get
			{
				return linphone_event_get_subscription_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_accept_subscription(IntPtr thiz);

		/// <summary>
		/// Accept an incoming subcription. 
		/// </summary>
		public void AcceptSubscription()
		{
			int exception_result = linphone_event_accept_subscription(nativePtr);
			if (exception_result != 0) throw new LinphoneException("AcceptSubscription returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_event_add_custom_header(IntPtr thiz, string name, string val);

		/// <summary>
		/// Add a custom header to an outgoing susbscription or publish. 
		/// </summary>
		public void AddCustomHeader(string name, string val)
		{
			linphone_event_add_custom_header(nativePtr, name, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_deny_subscription(IntPtr thiz, int reason);

		/// <summary>
		/// Deny an incoming subscription with given reason. 
		/// </summary>
		public void DenySubscription(Reason reason)
		{
			int exception_result = linphone_event_deny_subscription(nativePtr, (int)reason);
			if (exception_result != 0) throw new LinphoneException("DenySubscription returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_get_custom_header(IntPtr thiz, string name);

		/// <summary>
		/// Obtain the value of a given header for an incoming subscription. 
		/// </summary>
		public string GetCustomHeader(string name)
		{
			IntPtr stringPtr = linphone_event_get_custom_header(nativePtr, name);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_notify(IntPtr thiz, IntPtr body);

		/// <summary>
		/// Send a notification. 
		/// </summary>
		public void Notify(Content body)
		{
			int exception_result = linphone_event_notify(nativePtr, body != null ? body.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("Notify returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_event_pause_publish(IntPtr thiz);

		/// <summary>
		/// Prevent an event from refreshing its publish. 
		/// </summary>
		public void PausePublish()
		{
			linphone_event_pause_publish(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_refresh_publish(IntPtr thiz);

		/// <summary>
		/// Refresh an outgoing publish keeping the same body. 
		/// </summary>
		public void RefreshPublish()
		{
			int exception_result = linphone_event_refresh_publish(nativePtr);
			if (exception_result != 0) throw new LinphoneException("RefreshPublish returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_refresh_subscribe(IntPtr thiz);

		/// <summary>
		/// Refresh an outgoing subscription keeping the same body. 
		/// </summary>
		public void RefreshSubscribe()
		{
			int exception_result = linphone_event_refresh_subscribe(nativePtr);
			if (exception_result != 0) throw new LinphoneException("RefreshSubscribe returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_send_publish(IntPtr thiz, IntPtr body);

		/// <summary>
		/// Send a publish created by <see cref="Core.CreatePublish()" />. 
		/// </summary>
		public void SendPublish(Content body)
		{
			int exception_result = linphone_event_send_publish(nativePtr, body != null ? body.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("SendPublish returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_send_subscribe(IntPtr thiz, IntPtr body);

		/// <summary>
		/// Send a subscription previously created by <see
		/// cref="Core.CreateSubscribe()" />. 
		/// </summary>
		public void SendSubscribe(Content body)
		{
			int exception_result = linphone_event_send_subscribe(nativePtr, body != null ? body.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("SendSubscribe returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_event_terminate(IntPtr thiz);

		/// <summary>
		/// Terminate an incoming or outgoing subscription that was previously acccepted,
		/// or a previous publication. 
		/// </summary>
		public void Terminate()
		{
			linphone_event_terminate(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_update_publish(IntPtr thiz, IntPtr body);

		/// <summary>
		/// Update (refresh) a publish. 
		/// </summary>
		public void UpdatePublish(Content body)
		{
			int exception_result = linphone_event_update_publish(nativePtr, body != null ? body.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("UpdatePublish returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_event_update_subscribe(IntPtr thiz, IntPtr body);

		/// <summary>
		/// Update (refresh) an outgoing subscription, changing the body. 
		/// </summary>
		public void UpdateSubscribe(Content body)
		{
			int exception_result = linphone_event_update_subscribe(nativePtr, body != null ? body.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("UpdateSubscribe returned value" + exception_result);
		}
	}

	/// <summary>
	/// Base object of events. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class EventLog : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_log_get_call(IntPtr thiz);

		/// <summary>
		/// Returns the call of a conference call event. 
		/// </summary>
		public Call Call
		{
			get
			{
				IntPtr ptr = linphone_event_log_get_call(nativePtr);
				return fromNativePtr<Call>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_log_get_chat_message(IntPtr thiz);

		/// <summary>
		/// Returns the chat message of a conference chat message event. 
		/// </summary>
		public ChatMessage ChatMessage
		{
			get
			{
				IntPtr ptr = linphone_event_log_get_chat_message(nativePtr);
				return fromNativePtr<ChatMessage>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_event_log_get_creation_time(IntPtr thiz);

		/// <summary>
		/// Returns the creation time of a event log. 
		/// </summary>
		public long CreationTime
		{
			get
			{
				return linphone_event_log_get_creation_time(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_log_get_device_address(IntPtr thiz);

		/// <summary>
		/// Returns the device address of a conference participant device event. 
		/// </summary>
		public Address DeviceAddress
		{
			get
			{
				IntPtr ptr = linphone_event_log_get_device_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_log_get_local_address(IntPtr thiz);

		/// <summary>
		/// Returns the local address of a conference event. 
		/// </summary>
		public Address LocalAddress
		{
			get
			{
				IntPtr ptr = linphone_event_log_get_local_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_event_log_get_notify_id(IntPtr thiz);

		/// <summary>
		/// Returns the notify id of a conference notified event. 
		/// </summary>
		public uint NotifyId
		{
			get
			{
				return linphone_event_log_get_notify_id(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_log_get_participant_address(IntPtr thiz);

		/// <summary>
		/// Returns the participant address of a conference participant event. 
		/// </summary>
		public Address ParticipantAddress
		{
			get
			{
				IntPtr ptr = linphone_event_log_get_participant_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_log_get_peer_address(IntPtr thiz);

		/// <summary>
		/// Returns the peer address of a conference event. 
		/// </summary>
		public Address PeerAddress
		{
			get
			{
				IntPtr ptr = linphone_event_log_get_peer_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_event_log_get_subject(IntPtr thiz);

		/// <summary>
		/// Returns the subject of a conference subject event. 
		/// </summary>
		public string Subject
		{
			get
			{
				IntPtr stringPtr = linphone_event_log_get_subject(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern EventLogType linphone_event_log_get_type(IntPtr thiz);

		/// <summary>
		/// Returns the type of a event log. 
		/// </summary>
		public EventLogType Type
		{
			get
			{
				return linphone_event_log_get_type(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_event_log_delete_from_database(IntPtr thiz);

		/// <summary>
		/// Delete event log from database. 
		/// </summary>
		public void DeleteFromDatabase()
		{
			linphone_event_log_delete_from_database(nativePtr);
			
		}
	}
    
	/// <summary>
	/// Represents a buddy, all presence actions like subscription and status change
	/// notification are performed on this object. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Friend : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_new_from_vcard(IntPtr vcard);

		/// <summary>
		/// Contructor same as linphone_friend_new + <see
		/// cref="Friend.SetAddress()" /> 
		/// </summary>
		public static Friend NewFromVcard(Vcard vcard)
		{
			IntPtr ptr = linphone_friend_new_from_vcard(vcard != null ? vcard.nativePtr : IntPtr.Zero);
			return fromNativePtr<Friend>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_address(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_friend_set_address(IntPtr thiz, IntPtr address);

		/// <summary>
		/// Get address of this friend. 
		/// </summary>
		public Address Address
		{
			get
			{
				IntPtr ptr = linphone_friend_get_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
			set
			{
				int exception_result = linphone_friend_set_address(nativePtr, value.nativePtr);
				if (exception_result != 0) throw new LinphoneException("Address setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_addresses(IntPtr thiz);

		/// <summary>
		/// Returns a list of <see cref="Address" /> for this friend. 
		/// </summary>
		public IEnumerable<Address> Addresses
		{
			get
			{
				return MarshalBctbxList<Address>(linphone_friend_get_addresses(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern ConsolidatedPresence linphone_friend_get_consolidated_presence(IntPtr thiz);

		/// <summary>
		/// Get the consolidated presence of a friend. 
		/// </summary>
		public ConsolidatedPresence ConsolidatedPresence
		{
			get
			{
				return linphone_friend_get_consolidated_presence(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_core(IntPtr thiz);

		/// <summary>
		/// Returns the <see cref="Core" /> object managing this friend, if any. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_friend_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern SubscribePolicy linphone_friend_get_inc_subscribe_policy(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_friend_set_inc_subscribe_policy(IntPtr thiz, int pol);

		/// <summary>
		/// get current subscription policy for this <see cref="Friend" /> 
		/// </summary>
		public SubscribePolicy IncSubscribePolicy
		{
			get
			{
				return linphone_friend_get_inc_subscribe_policy(nativePtr);
			}
			set
			{
				int exception_result = linphone_friend_set_inc_subscribe_policy(nativePtr, (int)value);
				if (exception_result != 0) throw new LinphoneException("IncSubscribePolicy setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_friend_is_presence_received(IntPtr thiz);

		/// <summary>
		/// Tells whether we already received presence information for a friend. 
		/// </summary>
		public bool IsPresenceReceived
		{
			get
			{
				return linphone_friend_is_presence_received(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_friend_set_name(IntPtr thiz, string name);

		/// <summary>
		/// Get the display name for this friend. 
		/// </summary>
		public string Name
		{
			get
			{
				IntPtr stringPtr = linphone_friend_get_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_friend_set_name(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Name setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_phone_numbers(IntPtr thiz);

		/// <summary>
		/// Returns a list of phone numbers for this friend. 
		/// </summary>
		public IEnumerable<string> PhoneNumbers
		{
			get
			{
				return MarshalStringArray(linphone_friend_get_phone_numbers(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_presence_model(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_set_presence_model(IntPtr thiz, IntPtr presence);

		/// <summary>
		/// Get the presence model of a friend. 
		/// </summary>
		public PresenceModel PresenceModel
		{
			get
			{
				IntPtr ptr = linphone_friend_get_presence_model(nativePtr);
				return fromNativePtr<PresenceModel>(ptr, true);
			}
			set
			{
				linphone_friend_set_presence_model(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_ref_key(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_set_ref_key(IntPtr thiz, string key);

		/// <summary>
		/// Get the reference key of a friend. 
		/// </summary>
		public string RefKey
		{
			get
			{
				IntPtr stringPtr = linphone_friend_get_ref_key(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_friend_set_ref_key(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_friend_subscribes_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_friend_enable_subscribes(IntPtr thiz, char val);

		/// <summary>
		/// get subscription flag value 
		/// </summary>
		public bool SubscribesEnabled
		{
			get
			{
				return linphone_friend_subscribes_enabled(nativePtr) != 0;
			}
			set
			{
				int exception_result = linphone_friend_enable_subscribes(nativePtr, value ? (char)1 : (char)0);
				if (exception_result != 0) throw new LinphoneException("SubscribesEnabled setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern SubscriptionState linphone_friend_get_subscription_state(IntPtr thiz);

		/// <summary>
		/// Get subscription state of a friend. 
		/// </summary>
		public SubscriptionState SubscriptionState
		{
			get
			{
				return linphone_friend_get_subscription_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_vcard(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_set_vcard(IntPtr thiz, IntPtr vcard);

		/// <summary>
		/// Returns the vCard object associated to this friend, if any. 
		/// </summary>
		public Vcard Vcard
		{
			get
			{
				IntPtr ptr = linphone_friend_get_vcard(nativePtr);
				return fromNativePtr<Vcard>(ptr, true);
			}
			set
			{
				linphone_friend_set_vcard(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_add_address(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Adds an address in this friend. 
		/// </summary>
		public void AddAddress(Address addr)
		{
			linphone_friend_add_address(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_add_phone_number(IntPtr thiz, string phone);

		/// <summary>
		/// Adds a phone number in this friend. 
		/// </summary>
		public void AddPhoneNumber(string phone)
		{
			linphone_friend_add_phone_number(nativePtr, phone);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_friend_create_vcard(IntPtr thiz, string name);

		/// <summary>
		/// Creates a vCard object associated to this friend if there isn't one yet and if
		/// the full name is available, either by the parameter or the one in the friend's
		/// SIP URI. 
		/// </summary>
		public bool CreateVcard(string name)
		{
			return linphone_friend_create_vcard(nativePtr, name) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_done(IntPtr thiz);

		/// <summary>
		/// Commits modification made to the friend configuration. 
		/// </summary>
		public void Done()
		{
			linphone_friend_done(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_edit(IntPtr thiz);

		/// <summary>
		/// Starts editing a friend configuration. 
		/// </summary>
		public void Edit()
		{
			linphone_friend_edit(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_get_presence_model_for_uri_or_tel(IntPtr thiz, string uriOrTel);

		/// <summary>
		/// Get the presence model for a specific SIP URI or phone number of a friend. 
		/// </summary>
		public PresenceModel GetPresenceModelForUriOrTel(string uriOrTel)
		{
			IntPtr ptr = linphone_friend_get_presence_model_for_uri_or_tel(nativePtr, uriOrTel);
			return fromNativePtr<PresenceModel>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_friend_in_list(IntPtr thiz);

		/// <summary>
		/// Check that the given friend is in a friend list. 
		/// </summary>
		public bool InList()
		{
			return linphone_friend_in_list(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_remove_address(IntPtr thiz, IntPtr addr);

		/// <summary>
		/// Removes an address in this friend. 
		/// </summary>
		public void RemoveAddress(Address addr)
		{
			linphone_friend_remove_address(nativePtr, addr != null ? addr.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_remove_phone_number(IntPtr thiz, string phone);

		/// <summary>
		/// Removes a phone number in this friend. 
		/// </summary>
		public void RemovePhoneNumber(string phone)
		{
			linphone_friend_remove_phone_number(nativePtr, phone);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_save(IntPtr thiz, IntPtr lc);

		/// <summary>
		/// Saves a friend either in database if configured, otherwise in linphonerc. 
		/// </summary>
		public void Save(Core lc)
		{
			linphone_friend_save(nativePtr, lc != null ? lc.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_set_presence_model_for_uri_or_tel(IntPtr thiz, string uriOrTel, IntPtr presence);

		/// <summary>
		/// Set the presence model for a specific SIP URI or phone number of a friend. 
		/// </summary>
		public void SetPresenceModelForUriOrTel(string uriOrTel, PresenceModel presence)
		{
			linphone_friend_set_presence_model_for_uri_or_tel(nativePtr, uriOrTel, presence != null ? presence.nativePtr : IntPtr.Zero);
			
		}
	}

	/// <summary>
	/// The <see cref="FriendList" /> object representing a list of friends. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class FriendList : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_get_callbacks(IntPtr thiz);

		/// <summary>
		/// The <see cref="FriendList" /> object representing a list of friends. 
		/// </summary>
		public FriendListListener Listener
		{
			get
			{
				IntPtr ptr = linphone_friend_list_get_callbacks(nativePtr);
				return fromNativePtr<FriendListListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_get_core(IntPtr thiz);

		/// <summary>
		/// Returns the <see cref="Core" /> object attached to this
		/// LinphoneFriendList. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_friend_list_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_get_display_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_set_display_name(IntPtr thiz, string displayName);

		/// <summary>
		/// Get the display name of the friend list. 
		/// </summary>
		public string DisplayName
		{
			get
			{
				IntPtr stringPtr = linphone_friend_list_get_display_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_friend_list_set_display_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_get_friends(IntPtr thiz);

		/// <summary>
		/// Retrieves the list of <see cref="Friend" /> from this
		/// LinphoneFriendList. 
		/// </summary>
		public IEnumerable<Friend> Friends
		{
			get
			{
				return MarshalBctbxList<Friend>(linphone_friend_list_get_friends(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_get_rls_address(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_set_rls_address(IntPtr thiz, IntPtr rlsAddr);

		/// <summary>
		/// Get the RLS (Resource List Server) URI associated with the friend list to
		/// subscribe to these friends presence. 
		/// </summary>
		public Address RlsAddress
		{
			get
			{
				IntPtr ptr = linphone_friend_list_get_rls_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
			set
			{
				linphone_friend_list_set_rls_address(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_get_rls_uri(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_set_rls_uri(IntPtr thiz, string rlsUri);

		/// <summary>
		/// Get the RLS (Resource List Server) URI associated with the friend list to
		/// subscribe to these friends presence. 
		/// </summary>
		public string RlsUri
		{
			get
			{
				IntPtr stringPtr = linphone_friend_list_get_rls_uri(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_friend_list_set_rls_uri(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_friend_list_subscriptions_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_enable_subscriptions(IntPtr thiz, char enabled);

		/// <summary>
		/// Gets whether subscription to NOTIFYes of all friends list are enabled or not. 
		/// </summary>
		public bool SubscriptionsEnabled
		{
			get
			{
				return linphone_friend_list_subscriptions_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_friend_list_enable_subscriptions(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_get_uri(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_set_uri(IntPtr thiz, string uri);

		/// <summary>
		/// Get the URI associated with the friend list. 
		/// </summary>
		public string Uri
		{
			get
			{
				IntPtr stringPtr = linphone_friend_list_get_uri(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_friend_list_set_uri(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern FriendListStatus linphone_friend_list_add_friend(IntPtr thiz, IntPtr lf);

		/// <summary>
		/// Add a friend to a friend list. 
		/// </summary>
		public FriendListStatus AddFriend(Friend lf)
		{
			return linphone_friend_list_add_friend(nativePtr, lf != null ? lf.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern FriendListStatus linphone_friend_list_add_local_friend(IntPtr thiz, IntPtr lf);

		/// <summary>
		/// Add a friend to a friend list. 
		/// </summary>
		public FriendListStatus AddLocalFriend(Friend lf)
		{
			return linphone_friend_list_add_local_friend(nativePtr, lf != null ? lf.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_export_friends_as_vcard4_file(IntPtr thiz, string vcardFile);

		/// <summary>
		/// Creates and export <see cref="Friend" /> objects from <see
		/// cref="FriendList" /> to a file using vCard 4 format. 
		/// </summary>
		public void ExportFriendsAsVcard4File(string vcardFile)
		{
			linphone_friend_list_export_friends_as_vcard4_file(nativePtr, vcardFile);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_find_friend_by_address(IntPtr thiz, IntPtr address);

		/// <summary>
		/// Find a friend in the friend list using a LinphoneAddress. 
		/// </summary>
		public Friend FindFriendByAddress(Address address)
		{
			IntPtr ptr = linphone_friend_list_find_friend_by_address(nativePtr, address != null ? address.nativePtr : IntPtr.Zero);
			return fromNativePtr<Friend>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_find_friend_by_ref_key(IntPtr thiz, string refKey);

		/// <summary>
		/// Find a friend in the friend list using a ref key. 
		/// </summary>
		public Friend FindFriendByRefKey(string refKey)
		{
			IntPtr ptr = linphone_friend_list_find_friend_by_ref_key(nativePtr, refKey);
			return fromNativePtr<Friend>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_friend_list_find_friend_by_uri(IntPtr thiz, string uri);

		/// <summary>
		/// Find a friend in the friend list using an URI string. 
		/// </summary>
		public Friend FindFriendByUri(string uri)
		{
			IntPtr ptr = linphone_friend_list_find_friend_by_uri(nativePtr, uri);
			return fromNativePtr<Friend>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_friend_list_import_friends_from_vcard4_buffer(IntPtr thiz, string vcardBuffer);

		/// <summary>
		/// Creates and adds <see cref="Friend" /> objects to <see
		/// cref="FriendList" /> from a buffer that contains the vCard(s) to
		/// parse. 
		/// </summary>
		public void ImportFriendsFromVcard4Buffer(string vcardBuffer)
		{
			int exception_result = linphone_friend_list_import_friends_from_vcard4_buffer(nativePtr, vcardBuffer);
			if (exception_result != 0) throw new LinphoneException("ImportFriendsFromVcard4Buffer returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_friend_list_import_friends_from_vcard4_file(IntPtr thiz, string vcardFile);

		/// <summary>
		/// Creates and adds <see cref="Friend" /> objects to <see
		/// cref="FriendList" /> from a file that contains the vCard(s) to parse. 
		/// </summary>
		public void ImportFriendsFromVcard4File(string vcardFile)
		{
			int exception_result = linphone_friend_list_import_friends_from_vcard4_file(nativePtr, vcardFile);
			if (exception_result != 0) throw new LinphoneException("ImportFriendsFromVcard4File returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_notify_presence(IntPtr thiz, IntPtr presence);

		/// <summary>
		/// Notify our presence to all the friends in the friend list that have subscribed
		/// to our presence directly (not using a RLS). 
		/// </summary>
		public void NotifyPresence(PresenceModel presence)
		{
			linphone_friend_list_notify_presence(nativePtr, presence != null ? presence.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern FriendListStatus linphone_friend_list_remove_friend(IntPtr thiz, IntPtr lf);

		/// <summary>
		/// Remove a friend from a friend list. 
		/// </summary>
		public FriendListStatus RemoveFriend(Friend lf)
		{
			return linphone_friend_list_remove_friend(nativePtr, lf != null ? lf.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_synchronize_friends_from_server(IntPtr thiz);

		/// <summary>
		/// Starts a CardDAV synchronization using value set using
		/// linphone_friend_list_set_uri. 
		/// </summary>
		public void SynchronizeFriendsFromServer()
		{
			linphone_friend_list_synchronize_friends_from_server(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_update_dirty_friends(IntPtr thiz);

		/// <summary>
		/// Goes through all the <see cref="Friend" /> that are dirty and does a
		/// CardDAV PUT to update the server. 
		/// </summary>
		public void UpdateDirtyFriends()
		{
			linphone_friend_list_update_dirty_friends(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_update_revision(IntPtr thiz, int rev);

		/// <summary>
		/// Sets the revision from the last synchronization. 
		/// </summary>
		public void UpdateRevision(int rev)
		{
			linphone_friend_list_update_revision(nativePtr, rev);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_friend_list_update_subscriptions(IntPtr thiz);

		/// <summary>
		/// Update presence subscriptions for the entire list. 
		/// </summary>
		public void UpdateSubscriptions()
		{
			linphone_friend_list_update_subscriptions(nativePtr);
			
		}
	}

	/// <summary>
	/// Object representing a chain of protocol headers. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Headers : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_headers_add(IntPtr thiz, string name, string val);

		/// <summary>
		/// Add given header name and corresponding value. 
		/// </summary>
		public void Add(string name, string val)
		{
			linphone_headers_add(nativePtr, name, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_headers_get_value(IntPtr thiz, string headerName);

		/// <summary>
		/// Search for a given header name and return its value. 
		/// </summary>
		public string GetValue(string headerName)
		{
			IntPtr stringPtr = linphone_headers_get_value(nativePtr, headerName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_headers_remove(IntPtr thiz, string name);

		/// <summary>
		/// Add given header name and corresponding value. 
		/// </summary>
		public void Remove(string name)
		{
			linphone_headers_remove(nativePtr, name);
			
		}
	}

	/// <summary>
	/// Policy to use to send/receive instant messaging composing/delivery/display
	/// notifications. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class ImNotifPolicy : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_im_notif_policy_get_recv_imdn_delivered(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_set_recv_imdn_delivered(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether imdn delivered notifications are being notified when received. 
		/// </summary>
		public bool RecvImdnDelivered
		{
			get
			{
				return linphone_im_notif_policy_get_recv_imdn_delivered(nativePtr) != 0;
			}
			set
			{
				linphone_im_notif_policy_set_recv_imdn_delivered(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_im_notif_policy_get_recv_imdn_displayed(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_set_recv_imdn_displayed(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether imdn displayed notifications are being notified when received. 
		/// </summary>
		public bool RecvImdnDisplayed
		{
			get
			{
				return linphone_im_notif_policy_get_recv_imdn_displayed(nativePtr) != 0;
			}
			set
			{
				linphone_im_notif_policy_set_recv_imdn_displayed(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_im_notif_policy_get_recv_is_composing(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_set_recv_is_composing(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether is_composing notifications are being notified when received. 
		/// </summary>
		public bool RecvIsComposing
		{
			get
			{
				return linphone_im_notif_policy_get_recv_is_composing(nativePtr) != 0;
			}
			set
			{
				linphone_im_notif_policy_set_recv_is_composing(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_im_notif_policy_get_send_imdn_delivered(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_set_send_imdn_delivered(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether imdn delivered notifications are being sent. 
		/// </summary>
		public bool SendImdnDelivered
		{
			get
			{
				return linphone_im_notif_policy_get_send_imdn_delivered(nativePtr) != 0;
			}
			set
			{
				linphone_im_notif_policy_set_send_imdn_delivered(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_im_notif_policy_get_send_imdn_displayed(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_set_send_imdn_displayed(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether imdn displayed notifications are being sent. 
		/// </summary>
		public bool SendImdnDisplayed
		{
			get
			{
				return linphone_im_notif_policy_get_send_imdn_displayed(nativePtr) != 0;
			}
			set
			{
				linphone_im_notif_policy_set_send_imdn_displayed(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_im_notif_policy_get_send_is_composing(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_set_send_is_composing(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether is_composing notifications are being sent. 
		/// </summary>
		public bool SendIsComposing
		{
			get
			{
				return linphone_im_notif_policy_get_send_is_composing(nativePtr) != 0;
			}
			set
			{
				linphone_im_notif_policy_set_send_is_composing(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_clear(IntPtr thiz);

		/// <summary>
		/// Clear an IM notif policy (deactivate all receiving and sending of
		/// notifications). 
		/// </summary>
		public void Clear()
		{
			linphone_im_notif_policy_clear(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_im_notif_policy_enable_all(IntPtr thiz);

		/// <summary>
		/// Enable all receiving and sending of notifications. 
		/// </summary>
		public void EnableAll()
		{
			linphone_im_notif_policy_enable_all(nativePtr);
			
		}
	}

	/// <summary>
	/// The <see cref="InfoMessage" /> is an object representing an
	/// informational message sent or received by the core. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class InfoMessage : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_info_message_get_content(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_info_message_set_content(IntPtr thiz, IntPtr content);

		/// <summary>
		/// Returns the info message's content as a <see cref="Content" />
		/// structure. 
		/// </summary>
		public Content Content
		{
			get
			{
				IntPtr ptr = linphone_info_message_get_content(nativePtr);
				return fromNativePtr<Content>(ptr, true);
			}
			set
			{
				linphone_info_message_set_content(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_info_message_add_header(IntPtr thiz, string name, string val);

		/// <summary>
		/// Add a header to an info message to be sent. 
		/// </summary>
		public void AddHeader(string name, string val)
		{
			linphone_info_message_add_header(nativePtr, name, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_info_message_get_header(IntPtr thiz, string name);

		/// <summary>
		/// Obtain a header value from a received info message. 
		/// </summary>
		public string GetHeader(string name)
		{
			IntPtr stringPtr = linphone_info_message_get_header(nativePtr, name);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
	}

	/// <summary>
	/// Singleton class giving access to logging features. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class LoggingService : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_logging_service_get_callbacks(IntPtr thiz);

		/// <summary>
		/// Singleton class giving access to logging features. 
		/// </summary>
		public LoggingServiceListener Listener
		{
			get
			{
				IntPtr ptr = linphone_logging_service_get_callbacks(nativePtr);
				return fromNativePtr<LoggingServiceListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_logging_service_get();

		/// <summary>
		/// Gets the singleton logging service object. 
		/// </summary>
		static public LoggingService Instance
		{
			get
			{
				IntPtr ptr = linphone_logging_service_get();
				return fromNativePtr<LoggingService>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_logging_service_set_log_level(IntPtr thiz, int level);

		/// <summary>
		/// Set the verbosity of the log. 
		/// </summary>
		public LogLevel LogLevel
		{
			set
			{
				linphone_logging_service_set_log_level(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_logging_service_get_log_level_mask(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_logging_service_set_log_level_mask(IntPtr thiz, uint mask);

		/// <summary>
		/// Gets the log level mask. 
		/// </summary>
		public uint LogLevelMask
		{
			get
			{
				return linphone_logging_service_get_log_level_mask(nativePtr);
			}
			set
			{
				linphone_logging_service_set_log_level_mask(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_logging_service_set_log_file(IntPtr thiz, string dir, string filename, long maxSize);

		/// <summary>
		/// Enables logging in a file. 
		/// </summary>
		public void SetLogFile(string dir, string filename, long maxSize)
		{
			linphone_logging_service_set_log_file(nativePtr, dir, filename, maxSize);
			
		}
	}

	/// <summary>
	/// A <see cref="MagicSearch" /> is used to do specifics searchs. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class MagicSearch : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_magic_search_get_delimiter(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_magic_search_set_delimiter(IntPtr thiz, string delimiter);

		public string Delimiter
		{
			get
			{
				IntPtr stringPtr = linphone_magic_search_get_delimiter(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_magic_search_set_delimiter(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_magic_search_get_limited_search(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_magic_search_set_limited_search(IntPtr thiz, char limited);

		public bool LimitedSearch
		{
			get
			{
				return linphone_magic_search_get_limited_search(nativePtr) != 0;
			}
			set
			{
				linphone_magic_search_set_limited_search(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_magic_search_get_max_weight(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_magic_search_set_max_weight(IntPtr thiz, uint weight);

		public uint MaxWeight
		{
			get
			{
				return linphone_magic_search_get_max_weight(nativePtr);
			}
			set
			{
				linphone_magic_search_set_max_weight(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_magic_search_get_min_weight(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_magic_search_set_min_weight(IntPtr thiz, uint weight);

		public uint MinWeight
		{
			get
			{
				return linphone_magic_search_get_min_weight(nativePtr);
			}
			set
			{
				linphone_magic_search_set_min_weight(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_magic_search_get_search_limit(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_magic_search_set_search_limit(IntPtr thiz, uint limit);

		public uint SearchLimit
		{
			get
			{
				return linphone_magic_search_get_search_limit(nativePtr);
			}
			set
			{
				linphone_magic_search_set_search_limit(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_magic_search_get_use_delimiter(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_magic_search_set_use_delimiter(IntPtr thiz, char enable);

		public bool UseDelimiter
		{
			get
			{
				return linphone_magic_search_get_use_delimiter(nativePtr) != 0;
			}
			set
			{
				linphone_magic_search_set_use_delimiter(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_magic_search_get_contact_list_from_filter(IntPtr thiz, string filter, string domain);

		/// <summary>
		/// Create a sorted list of SearchResult from SipUri, Contact name, Contact
		/// displayname, Contact phone number, which match with a filter word The last item
		/// list will be an address formed with "filter" if a proxy config exist During the
		/// first search, a cache is created and used for the next search Use <see
		/// cref="MagicSearch.ResetSearchCache()" /> to begin a new search. 
		/// </summary>
		public IEnumerable<SearchResult> GetContactListFromFilter(string filter, string domain)
		{
			return MarshalBctbxList<SearchResult>(linphone_magic_search_get_contact_list_from_filter(nativePtr, filter, domain));
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_magic_search_reset_search_cache(IntPtr thiz);

		/// <summary>
		/// Reset the cache to begin a new search. 
		/// </summary>
		public void ResetSearchCache()
		{
			linphone_magic_search_reset_search_cache(nativePtr);
			
		}
	}

	/// <summary>
	/// Policy to use to pass through NATs/firewalls. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class NatPolicy : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_nat_policy_get_core(IntPtr thiz);

		/// <summary>
		/// Returns the <see cref="Core" /> object managing this nat policy, if
		/// any. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_nat_policy_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_nat_policy_ice_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_enable_ice(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether ICE is enabled. 
		/// </summary>
		public bool IceEnabled
		{
			get
			{
				return linphone_nat_policy_ice_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_nat_policy_enable_ice(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_nat_policy_stun_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_enable_stun(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether STUN is enabled. 
		/// </summary>
		public bool StunEnabled
		{
			get
			{
				return linphone_nat_policy_stun_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_nat_policy_enable_stun(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_nat_policy_get_stun_server(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_set_stun_server(IntPtr thiz, string stunServer);

		/// <summary>
		/// Get the STUN/TURN server to use with this NAT policy. 
		/// </summary>
		public string StunServer
		{
			get
			{
				IntPtr stringPtr = linphone_nat_policy_get_stun_server(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_nat_policy_set_stun_server(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_nat_policy_get_stun_server_username(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_set_stun_server_username(IntPtr thiz, string username);

		/// <summary>
		/// Get the username used to authenticate with the STUN/TURN server. 
		/// </summary>
		public string StunServerUsername
		{
			get
			{
				IntPtr stringPtr = linphone_nat_policy_get_stun_server_username(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_nat_policy_set_stun_server_username(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_nat_policy_turn_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_enable_turn(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether TURN is enabled. 
		/// </summary>
		public bool TurnEnabled
		{
			get
			{
				return linphone_nat_policy_turn_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_nat_policy_enable_turn(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_nat_policy_upnp_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_enable_upnp(IntPtr thiz, char enable);

		/// <summary>
		/// Tell whether uPnP is enabled. 
		/// </summary>
		public bool UpnpEnabled
		{
			get
			{
				return linphone_nat_policy_upnp_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_nat_policy_enable_upnp(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_clear(IntPtr thiz);

		/// <summary>
		/// Clear a NAT policy (deactivate all protocols and unset the STUN server). 
		/// </summary>
		public void Clear()
		{
			linphone_nat_policy_clear(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_nat_policy_resolve_stun_server(IntPtr thiz);

		/// <summary>
		/// Start a STUN server DNS resolution. 
		/// </summary>
		public void ResolveStunServer()
		{
			linphone_nat_policy_resolve_stun_server(nativePtr);
			
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class Participant : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_participant_get_address(IntPtr thiz);

		/// <summary>
		/// Get the address of a conference participant. 
		/// </summary>
		public Address Address
		{
			get
			{
				IntPtr ptr = linphone_participant_get_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_participant_is_admin(IntPtr thiz);

		/// <summary>
		/// Tells whether a conference participant is an administrator of the conference. 
		/// </summary>
		public bool IsAdmin
		{
			get
			{
				return linphone_participant_is_admin(nativePtr) != 0;
			}
		}
	}

	/// <summary>
	/// The LinphoneParticipantImdnState object represents the state of chat message
	/// for a participant of a conference chat room. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class ParticipantImdnState : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_participant_imdn_state_get_participant(IntPtr thiz);

		/// <summary>
		/// Get the participant concerned by a LinphoneParticipantImdnState. 
		/// </summary>
		public Participant Participant
		{
			get
			{
				IntPtr ptr = linphone_participant_imdn_state_get_participant(nativePtr);
				return fromNativePtr<Participant>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern ChatMessageState linphone_participant_imdn_state_get_state(IntPtr thiz);

		/// <summary>
		/// Get the chat message state the participant is in. 
		/// </summary>
		public ChatMessageState State
		{
			get
			{
				return linphone_participant_imdn_state_get_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_participant_imdn_state_get_state_change_time(IntPtr thiz);

		/// <summary>
		/// Get the timestamp at which a participant has reached the state described by a
		/// LinphoneParticipantImdnState. 
		/// </summary>
		public long StateChangeTime
		{
			get
			{
				return linphone_participant_imdn_state_get_state_change_time(nativePtr);
			}
		}
	}

	/// <summary>
	/// Object representing an RTP payload type. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class PayloadType : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_payload_type_get_channels(IntPtr thiz);

		/// <summary>
		/// Get the number of channels. 
		/// </summary>
		public int Channels
		{
			get
			{
				return linphone_payload_type_get_channels(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_payload_type_get_clock_rate(IntPtr thiz);

		/// <summary>
		/// Get the clock rate of a payload type. 
		/// </summary>
		public int ClockRate
		{
			get
			{
				return linphone_payload_type_get_clock_rate(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_payload_type_get_description(IntPtr thiz);

		/// <summary>
		/// Return a string describing a payload type. 
		/// </summary>
		public string Description
		{
			get
			{
				IntPtr stringPtr = linphone_payload_type_get_description(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_payload_type_get_encoder_description(IntPtr thiz);

		/// <summary>
		/// Get a description of the encoder used to provide a payload type. 
		/// </summary>
		public string EncoderDescription
		{
			get
			{
				IntPtr stringPtr = linphone_payload_type_get_encoder_description(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_payload_type_is_usable(IntPtr thiz);

		/// <summary>
		/// Check whether the payload is usable according the bandwidth targets set in the
		/// core. 
		/// </summary>
		public bool IsUsable
		{
			get
			{
				return linphone_payload_type_is_usable(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_payload_type_is_vbr(IntPtr thiz);

		/// <summary>
		/// Tells whether the specified payload type represents a variable bitrate codec. 
		/// </summary>
		public bool IsVbr
		{
			get
			{
				return linphone_payload_type_is_vbr(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_payload_type_get_mime_type(IntPtr thiz);

		/// <summary>
		/// Get the mime type. 
		/// </summary>
		public string MimeType
		{
			get
			{
				IntPtr stringPtr = linphone_payload_type_get_mime_type(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_payload_type_get_normal_bitrate(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_payload_type_set_normal_bitrate(IntPtr thiz, int bitrate);

		/// <summary>
		/// Get the normal bitrate in bits/s. 
		/// </summary>
		public int NormalBitrate
		{
			get
			{
				return linphone_payload_type_get_normal_bitrate(nativePtr);
			}
			set
			{
				linphone_payload_type_set_normal_bitrate(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_payload_type_get_number(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_payload_type_set_number(IntPtr thiz, int number);

		/// <summary>
		/// Returns the payload type number assigned for this codec. 
		/// </summary>
		public int Number
		{
			get
			{
				return linphone_payload_type_get_number(nativePtr);
			}
			set
			{
				linphone_payload_type_set_number(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_payload_type_get_recv_fmtp(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_payload_type_set_recv_fmtp(IntPtr thiz, string recvFmtp);

		/// <summary>
		/// Get the format parameters for incoming streams. 
		/// </summary>
		public string RecvFmtp
		{
			get
			{
				IntPtr stringPtr = linphone_payload_type_get_recv_fmtp(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_payload_type_set_recv_fmtp(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_payload_type_get_send_fmtp(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_payload_type_set_send_fmtp(IntPtr thiz, string sendFmtp);

		/// <summary>
		/// Get the format parameters for outgoing streams. 
		/// </summary>
		public string SendFmtp
		{
			get
			{
				IntPtr stringPtr = linphone_payload_type_get_send_fmtp(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_payload_type_set_send_fmtp(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_payload_type_get_type(IntPtr thiz);

		/// <summary>
		/// Get the type of a payload type. 
		/// </summary>
		public int Type
		{
			get
			{
				return linphone_payload_type_get_type(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_payload_type_enable(IntPtr thiz, char enabled);

		/// <summary>
		/// Enable/disable a payload type. 
		/// </summary>
		public int Enable(bool enabled)
		{
			return linphone_payload_type_enable(nativePtr, enabled ? (char)1 : (char)0);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_payload_type_enabled(IntPtr thiz);

		/// <summary>
		/// Check whether a palyoad type is enabled. 
		/// </summary>
		public bool Enabled()
		{
			return linphone_payload_type_enabled(nativePtr) == (char)0 ? false : true;
		}
	}

	/// <summary>
	/// Player interface. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Player : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_player_get_callbacks(IntPtr thiz);

		/// <summary>
		/// Player interface. 
		/// </summary>
		public PlayerListener Listener
		{
			get
			{
				IntPtr ptr = linphone_player_get_callbacks(nativePtr);
				return fromNativePtr<PlayerListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_player_get_core(IntPtr thiz);

		/// <summary>
		/// Returns the <see cref="Core" /> object managing this player's call, if
		/// any. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_player_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_player_get_current_position(IntPtr thiz);

		/// <summary>
		/// Get the current position in the opened file. 
		/// </summary>
		public int CurrentPosition
		{
			get
			{
				return linphone_player_get_current_position(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_player_get_duration(IntPtr thiz);

		/// <summary>
		/// Get the duration of the opened file. 
		/// </summary>
		public int Duration
		{
			get
			{
				return linphone_player_get_duration(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern PlayerState linphone_player_get_state(IntPtr thiz);

		/// <summary>
		/// Get the current state of a player. 
		/// </summary>
		public PlayerState State
		{
			get
			{
				return linphone_player_get_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_player_close(IntPtr thiz);

		/// <summary>
		/// Close the opened file. 
		/// </summary>
		public void Close()
		{
			linphone_player_close(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_player_open(IntPtr thiz, string filename);

		/// <summary>
		/// Open a file for playing. 
		/// </summary>
		public void Open(string filename)
		{
			int exception_result = linphone_player_open(nativePtr, filename);
			if (exception_result != 0) throw new LinphoneException("Open returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_player_pause(IntPtr thiz);

		/// <summary>
		/// Pause the playing of a file. 
		/// </summary>
		public void Pause()
		{
			int exception_result = linphone_player_pause(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Pause returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_player_seek(IntPtr thiz, int timeMs);

		/// <summary>
		/// Seek in an opened file. 
		/// </summary>
		public void Seek(int timeMs)
		{
			int exception_result = linphone_player_seek(nativePtr, timeMs);
			if (exception_result != 0) throw new LinphoneException("Seek returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_player_start(IntPtr thiz);

		/// <summary>
		/// Start playing a file that has been opened with <see
		/// cref="Player.Open()" />. 
		/// </summary>
		public void Start()
		{
			int exception_result = linphone_player_start(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Start returned value" + exception_result);
		}
	}

	/// <summary>
	/// Presence activity type holding information about a presence activity. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class PresenceActivity : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_activity_get_description(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_activity_set_description(IntPtr thiz, string description);

		/// <summary>
		/// Gets the description of a presence activity. 
		/// </summary>
		public string Description
		{
			get
			{
				IntPtr stringPtr = linphone_presence_activity_get_description(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_presence_activity_set_description(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Description setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern PresenceActivityType linphone_presence_activity_get_type(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_activity_set_type(IntPtr thiz, int acttype);

		/// <summary>
		/// Gets the activity type of a presence activity. 
		/// </summary>
		public PresenceActivityType Type
		{
			get
			{
				return linphone_presence_activity_get_type(nativePtr);
			}
			set
			{
				int exception_result = linphone_presence_activity_set_type(nativePtr, (int)value);
				if (exception_result != 0) throw new LinphoneException("Type setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_activity_to_string(IntPtr thiz);

		/// <summary>
		/// Gets the string representation of a presence activity. 
		/// </summary>
		public override string ToString()
		{
			IntPtr stringPtr = linphone_presence_activity_to_string(nativePtr);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
	}

	/// <summary>
	/// Presence model type holding information about the presence of a person. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class PresenceModel : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_new_with_activity(int activity, string description);

		/// <summary>
		/// Creates a presence model specifying an activity. 
		/// </summary>
		public static PresenceModel NewWithActivity(PresenceActivityType activity, string description)
		{
			IntPtr ptr = linphone_presence_model_new_with_activity((int)activity, description);
			return fromNativePtr<PresenceModel>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_new_with_activity_and_note(int activity, string description, string note, string lang);

		/// <summary>
		/// Creates a presence model specifying an activity and adding a note. 
		/// </summary>
		public static PresenceModel NewWithActivityAndNote(PresenceActivityType activity, string description, string note, string lang)
		{
			IntPtr ptr = linphone_presence_model_new_with_activity_and_note((int)activity, description, note, lang);
			return fromNativePtr<PresenceModel>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_get_activity(IntPtr thiz);

		/// <summary>
		/// Gets the first activity of a presence model (there is usually only one). 
		/// </summary>
		public PresenceActivity Activity
		{
			get
			{
				IntPtr ptr = linphone_presence_model_get_activity(nativePtr);
				return fromNativePtr<PresenceActivity>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern PresenceBasicStatus linphone_presence_model_get_basic_status(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_set_basic_status(IntPtr thiz, int basicStatus);

		/// <summary>
		/// Gets the basic status of a presence model. 
		/// </summary>
		public PresenceBasicStatus BasicStatus
		{
			get
			{
				return linphone_presence_model_get_basic_status(nativePtr);
			}
			set
			{
				int exception_result = linphone_presence_model_set_basic_status(nativePtr, (int)value);
				if (exception_result != 0) throw new LinphoneException("BasicStatus setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern ConsolidatedPresence linphone_presence_model_get_consolidated_presence(IntPtr thiz);

		/// <summary>
		/// Get the consolidated presence from a presence model. 
		/// </summary>
		public ConsolidatedPresence ConsolidatedPresence
		{
			get
			{
				return linphone_presence_model_get_consolidated_presence(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_get_contact(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_set_contact(IntPtr thiz, string contact);

		/// <summary>
		/// Gets the contact of a presence model. 
		/// </summary>
		public string Contact
		{
			get
			{
				IntPtr stringPtr = linphone_presence_model_get_contact(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_presence_model_set_contact(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Contact setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_presence_model_is_online(IntPtr thiz);

		/// <summary>
		/// Tells whether a presence model is considered online. 
		/// </summary>
		public bool IsOnline
		{
			get
			{
				return linphone_presence_model_is_online(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_presence_model_get_nb_activities(IntPtr thiz);

		/// <summary>
		/// Gets the number of activities included in the presence model. 
		/// </summary>
		public uint NbActivities
		{
			get
			{
				return linphone_presence_model_get_nb_activities(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_presence_model_get_nb_persons(IntPtr thiz);

		/// <summary>
		/// Gets the number of persons included in the presence model. 
		/// </summary>
		public uint NbPersons
		{
			get
			{
				return linphone_presence_model_get_nb_persons(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_presence_model_get_nb_services(IntPtr thiz);

		/// <summary>
		/// Gets the number of services included in the presence model. 
		/// </summary>
		public uint NbServices
		{
			get
			{
				return linphone_presence_model_get_nb_services(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_get_presentity(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_set_presentity(IntPtr thiz, IntPtr presentity);

		/// <summary>
		/// Gets the presentity of a presence model. 
		/// </summary>
		public Address Presentity
		{
			get
			{
				IntPtr ptr = linphone_presence_model_get_presentity(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
			set
			{
				int exception_result = linphone_presence_model_set_presentity(nativePtr, value.nativePtr);
				if (exception_result != 0) throw new LinphoneException("Presentity setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern long linphone_presence_model_get_timestamp(IntPtr thiz);

		/// <summary>
		/// Gets the timestamp of a presence model. 
		/// </summary>
		public long Timestamp
		{
			get
			{
				return linphone_presence_model_get_timestamp(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_add_activity(IntPtr thiz, IntPtr activity);

		/// <summary>
		/// Adds an activity to a presence model. 
		/// </summary>
		public void AddActivity(PresenceActivity activity)
		{
			int exception_result = linphone_presence_model_add_activity(nativePtr, activity != null ? activity.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddActivity returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_add_note(IntPtr thiz, string noteContent, string lang);

		/// <summary>
		/// Adds a note to a presence model. 
		/// </summary>
		public void AddNote(string noteContent, string lang)
		{
			int exception_result = linphone_presence_model_add_note(nativePtr, noteContent, lang);
			if (exception_result != 0) throw new LinphoneException("AddNote returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_add_person(IntPtr thiz, IntPtr person);

		/// <summary>
		/// Adds a person to a presence model. 
		/// </summary>
		public void AddPerson(PresencePerson person)
		{
			int exception_result = linphone_presence_model_add_person(nativePtr, person != null ? person.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddPerson returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_add_service(IntPtr thiz, IntPtr service);

		/// <summary>
		/// Adds a service to a presence model. 
		/// </summary>
		public void AddService(PresenceService service)
		{
			int exception_result = linphone_presence_model_add_service(nativePtr, service != null ? service.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddService returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_clear_activities(IntPtr thiz);

		/// <summary>
		/// Clears the activities of a presence model. 
		/// </summary>
		public void ClearActivities()
		{
			int exception_result = linphone_presence_model_clear_activities(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearActivities returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_clear_notes(IntPtr thiz);

		/// <summary>
		/// Clears all the notes of a presence model. 
		/// </summary>
		public void ClearNotes()
		{
			int exception_result = linphone_presence_model_clear_notes(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearNotes returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_clear_persons(IntPtr thiz);

		/// <summary>
		/// Clears the persons of a presence model. 
		/// </summary>
		public void ClearPersons()
		{
			int exception_result = linphone_presence_model_clear_persons(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearPersons returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_clear_services(IntPtr thiz);

		/// <summary>
		/// Clears the services of a presence model. 
		/// </summary>
		public void ClearServices()
		{
			int exception_result = linphone_presence_model_clear_services(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearServices returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_get_note(IntPtr thiz, string lang);

		/// <summary>
		/// Gets the first note of a presence model (there is usually only one). 
		/// </summary>
		public PresenceNote GetNote(string lang)
		{
			IntPtr ptr = linphone_presence_model_get_note(nativePtr, lang);
			return fromNativePtr<PresenceNote>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_get_nth_activity(IntPtr thiz, uint idx);

		/// <summary>
		/// Gets the nth activity of a presence model. 
		/// </summary>
		public PresenceActivity GetNthActivity(uint idx)
		{
			IntPtr ptr = linphone_presence_model_get_nth_activity(nativePtr, idx);
			return fromNativePtr<PresenceActivity>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_get_nth_person(IntPtr thiz, uint idx);

		/// <summary>
		/// Gets the nth person of a presence model. 
		/// </summary>
		public PresencePerson GetNthPerson(uint idx)
		{
			IntPtr ptr = linphone_presence_model_get_nth_person(nativePtr, idx);
			return fromNativePtr<PresencePerson>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_model_get_nth_service(IntPtr thiz, uint idx);

		/// <summary>
		/// Gets the nth service of a presence model. 
		/// </summary>
		public PresenceService GetNthService(uint idx)
		{
			IntPtr ptr = linphone_presence_model_get_nth_service(nativePtr, idx);
			return fromNativePtr<PresenceService>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_model_set_activity(IntPtr thiz, int activity, string description);

		/// <summary>
		/// Sets the activity of a presence model (limits to only one activity). 
		/// </summary>
		public void SetActivity(PresenceActivityType activity, string description)
		{
			int exception_result = linphone_presence_model_set_activity(nativePtr, (int)activity, description);
			if (exception_result != 0) throw new LinphoneException("SetActivity returned value" + exception_result);
		}
	}

	/// <summary>
	/// Presence note type holding information about a presence note. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class PresenceNote : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_note_get_content(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_note_set_content(IntPtr thiz, string content);

		/// <summary>
		/// Gets the content of a presence note. 
		/// </summary>
		public string Content
		{
			get
			{
				IntPtr stringPtr = linphone_presence_note_get_content(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_presence_note_set_content(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Content setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_note_get_lang(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_note_set_lang(IntPtr thiz, string lang);

		/// <summary>
		/// Gets the language of a presence note. 
		/// </summary>
		public string Lang
		{
			get
			{
				IntPtr stringPtr = linphone_presence_note_get_lang(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_presence_note_set_lang(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Lang setter returned value " + exception_result);
			}
		}
	}

	/// <summary>
	/// Presence person holding information about a presence person. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class PresencePerson : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_person_get_id(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_person_set_id(IntPtr thiz, string id);

		/// <summary>
		/// Gets the id of a presence person. 
		/// </summary>
		public string Id
		{
			get
			{
				IntPtr stringPtr = linphone_presence_person_get_id(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_presence_person_set_id(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Id setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_presence_person_get_nb_activities(IntPtr thiz);

		/// <summary>
		/// Gets the number of activities included in the presence person. 
		/// </summary>
		public uint NbActivities
		{
			get
			{
				return linphone_presence_person_get_nb_activities(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_presence_person_get_nb_activities_notes(IntPtr thiz);

		/// <summary>
		/// Gets the number of activities notes included in the presence person. 
		/// </summary>
		public uint NbActivitiesNotes
		{
			get
			{
				return linphone_presence_person_get_nb_activities_notes(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_presence_person_get_nb_notes(IntPtr thiz);

		/// <summary>
		/// Gets the number of notes included in the presence person. 
		/// </summary>
		public uint NbNotes
		{
			get
			{
				return linphone_presence_person_get_nb_notes(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_person_add_activities_note(IntPtr thiz, IntPtr note);

		/// <summary>
		/// Adds an activities note to a presence person. 
		/// </summary>
		public void AddActivitiesNote(PresenceNote note)
		{
			int exception_result = linphone_presence_person_add_activities_note(nativePtr, note != null ? note.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddActivitiesNote returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_person_add_activity(IntPtr thiz, IntPtr activity);

		/// <summary>
		/// Adds an activity to a presence person. 
		/// </summary>
		public void AddActivity(PresenceActivity activity)
		{
			int exception_result = linphone_presence_person_add_activity(nativePtr, activity != null ? activity.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddActivity returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_person_add_note(IntPtr thiz, IntPtr note);

		/// <summary>
		/// Adds a note to a presence person. 
		/// </summary>
		public void AddNote(PresenceNote note)
		{
			int exception_result = linphone_presence_person_add_note(nativePtr, note != null ? note.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddNote returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_person_clear_activities(IntPtr thiz);

		/// <summary>
		/// Clears the activities of a presence person. 
		/// </summary>
		public void ClearActivities()
		{
			int exception_result = linphone_presence_person_clear_activities(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearActivities returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_person_clear_activities_notes(IntPtr thiz);

		/// <summary>
		/// Clears the activities notes of a presence person. 
		/// </summary>
		public void ClearActivitiesNotes()
		{
			int exception_result = linphone_presence_person_clear_activities_notes(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearActivitiesNotes returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_person_clear_notes(IntPtr thiz);

		/// <summary>
		/// Clears the notes of a presence person. 
		/// </summary>
		public void ClearNotes()
		{
			int exception_result = linphone_presence_person_clear_notes(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearNotes returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_person_get_nth_activities_note(IntPtr thiz, uint idx);

		/// <summary>
		/// Gets the nth activities note of a presence person. 
		/// </summary>
		public PresenceNote GetNthActivitiesNote(uint idx)
		{
			IntPtr ptr = linphone_presence_person_get_nth_activities_note(nativePtr, idx);
			return fromNativePtr<PresenceNote>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_person_get_nth_activity(IntPtr thiz, uint idx);

		/// <summary>
		/// Gets the nth activity of a presence person. 
		/// </summary>
		public PresenceActivity GetNthActivity(uint idx)
		{
			IntPtr ptr = linphone_presence_person_get_nth_activity(nativePtr, idx);
			return fromNativePtr<PresenceActivity>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_person_get_nth_note(IntPtr thiz, uint idx);

		/// <summary>
		/// Gets the nth note of a presence person. 
		/// </summary>
		public PresenceNote GetNthNote(uint idx)
		{
			IntPtr ptr = linphone_presence_person_get_nth_note(nativePtr, idx);
			return fromNativePtr<PresenceNote>(ptr, true);
		}
	}

	/// <summary>
	/// Presence service type holding information about a presence service. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class PresenceService : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern PresenceBasicStatus linphone_presence_service_get_basic_status(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_service_set_basic_status(IntPtr thiz, int basicStatus);

		/// <summary>
		/// Gets the basic status of a presence service. 
		/// </summary>
		public PresenceBasicStatus BasicStatus
		{
			get
			{
				return linphone_presence_service_get_basic_status(nativePtr);
			}
			set
			{
				int exception_result = linphone_presence_service_set_basic_status(nativePtr, (int)value);
				if (exception_result != 0) throw new LinphoneException("BasicStatus setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_service_get_contact(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_service_set_contact(IntPtr thiz, string contact);

		/// <summary>
		/// Gets the contact of a presence service. 
		/// </summary>
		public string Contact
		{
			get
			{
				IntPtr stringPtr = linphone_presence_service_get_contact(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_presence_service_set_contact(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Contact setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_service_get_id(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_service_set_id(IntPtr thiz, string id);

		/// <summary>
		/// Gets the id of a presence service. 
		/// </summary>
		public string Id
		{
			get
			{
				IntPtr stringPtr = linphone_presence_service_get_id(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_presence_service_set_id(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Id setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_presence_service_get_nb_notes(IntPtr thiz);

		/// <summary>
		/// Gets the number of notes included in the presence service. 
		/// </summary>
		public uint NbNotes
		{
			get
			{
				return linphone_presence_service_get_nb_notes(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_service_add_note(IntPtr thiz, IntPtr note);

		/// <summary>
		/// Adds a note to a presence service. 
		/// </summary>
		public void AddNote(PresenceNote note)
		{
			int exception_result = linphone_presence_service_add_note(nativePtr, note != null ? note.nativePtr : IntPtr.Zero);
			if (exception_result != 0) throw new LinphoneException("AddNote returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_presence_service_clear_notes(IntPtr thiz);

		/// <summary>
		/// Clears the notes of a presence service. 
		/// </summary>
		public void ClearNotes()
		{
			int exception_result = linphone_presence_service_clear_notes(nativePtr);
			if (exception_result != 0) throw new LinphoneException("ClearNotes returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_presence_service_get_nth_note(IntPtr thiz, uint idx);

		/// <summary>
		/// Gets the nth note of a presence service. 
		/// </summary>
		public PresenceNote GetNthNote(uint idx)
		{
			IntPtr ptr = linphone_presence_service_get_nth_note(nativePtr, idx);
			return fromNativePtr<PresenceNote>(ptr, true);
		}
	}

	/// <summary>
	/// The <see cref="ProxyConfig" /> object represents a proxy configuration
	/// to be used by the <see cref="Core" /> object. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class ProxyConfig : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_proxy_config_avpf_enabled(IntPtr thiz);

		/// <summary>
		/// Indicates whether AVPF/SAVPF is being used for calls using this proxy config. 
		/// </summary>
		public bool AvpfEnabled
		{
			get
			{
				return linphone_proxy_config_avpf_enabled(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern AVPFMode linphone_proxy_config_get_avpf_mode(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_avpf_mode(IntPtr thiz, int mode);

		/// <summary>
		/// Get enablement status of RTCP feedback (also known as AVPF profile). 
		/// </summary>
		public AVPFMode AvpfMode
		{
			get
			{
				return linphone_proxy_config_get_avpf_mode(nativePtr);
			}
			set
			{
				linphone_proxy_config_set_avpf_mode(nativePtr, (int)value);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_proxy_config_get_avpf_rr_interval(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_avpf_rr_interval(IntPtr thiz, uint interval);

		/// <summary>
		/// Get the interval between regular RTCP reports when using AVPF/SAVPF. 
		/// </summary>
		public uint AvpfRrInterval
		{
			get
			{
				return linphone_proxy_config_get_avpf_rr_interval(nativePtr);
			}
			set
			{
				linphone_proxy_config_set_avpf_rr_interval(nativePtr, value);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_conference_factory_uri(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_conference_factory_uri(IntPtr thiz, string uri);

		/// <summary>
		/// Get the conference factory uri. 
		/// </summary>
		public string ConferenceFactoryUri
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_conference_factory_uri(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_proxy_config_set_conference_factory_uri(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_contact(IntPtr thiz);

		/// <summary>
		/// Return the contact address of the proxy config. 
		/// </summary>
		public Address Contact
		{
			get
			{
				IntPtr ptr = linphone_proxy_config_get_contact(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_contact_parameters(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_contact_parameters(IntPtr thiz, string contactParams);

		public string ContactParameters
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_contact_parameters(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_proxy_config_set_contact_parameters(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_contact_uri_parameters(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_contact_uri_parameters(IntPtr thiz, string contactUriParams);

		public string ContactUriParameters
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_contact_uri_parameters(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_proxy_config_set_contact_uri_parameters(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_core(IntPtr thiz);

		/// <summary>
		/// Get the <see cref="Core" /> object to which is associated the <see
		/// cref="ProxyConfig" />. 
		/// </summary>
		public Core Core
		{
			get
			{
				IntPtr ptr = linphone_proxy_config_get_core(nativePtr);
				return fromNativePtr<Core>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_proxy_config_get_dial_escape_plus(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_dial_escape_plus(IntPtr thiz, char val);

		public bool DialEscapePlus
		{
			get
			{
				return linphone_proxy_config_get_dial_escape_plus(nativePtr) != 0;
			}
			set
			{
				linphone_proxy_config_set_dial_escape_plus(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_dial_prefix(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_dial_prefix(IntPtr thiz, string prefix);

		public string DialPrefix
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_dial_prefix(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_proxy_config_set_dial_prefix(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_domain(IntPtr thiz);

		/// <summary>
		/// Get the domain name of the given proxy config. 
		/// </summary>
		public string Domain
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_domain(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern Reason linphone_proxy_config_get_error(IntPtr thiz);

		/// <summary>
		/// Get the reason why registration failed when the proxy config state is
		/// LinphoneRegistrationFailed. 
		/// </summary>
		public Reason Error
		{
			get
			{
				return linphone_proxy_config_get_error(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_error_info(IntPtr thiz);

		/// <summary>
		/// Get detailed information why registration failed when the proxy config state is
		/// LinphoneRegistrationFailed. 
		/// </summary>
		public ErrorInfo ErrorInfo
		{
			get
			{
				IntPtr ptr = linphone_proxy_config_get_error_info(nativePtr);
				return fromNativePtr<ErrorInfo>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_get_expires(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_expires(IntPtr thiz, int expires);

		public int Expires
		{
			get
			{
				return linphone_proxy_config_get_expires(nativePtr);
			}
			set
			{
				linphone_proxy_config_set_expires(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_identity_address(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_set_identity_address(IntPtr thiz, IntPtr identity);

		public Address IdentityAddress
		{
			get
			{
				IntPtr ptr = linphone_proxy_config_get_identity_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
			set
			{
				int exception_result = linphone_proxy_config_set_identity_address(nativePtr, value.nativePtr);
				if (exception_result != 0) throw new LinphoneException("IdentityAddress setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_proxy_config_is_push_notification_allowed(IntPtr thiz);

		/// <summary>
		/// Indicates whether to add to the contact parameters the push notification
		/// information. 
		/// </summary>
		public bool IsPushNotificationAllowed
		{
			get
			{
				return linphone_proxy_config_is_push_notification_allowed(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_nat_policy(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_nat_policy(IntPtr thiz, IntPtr policy);

		/// <summary>
		/// Get The policy that is used to pass through NATs/firewalls when using this
		/// proxy config. 
		/// </summary>
		public NatPolicy NatPolicy
		{
			get
			{
				IntPtr ptr = linphone_proxy_config_get_nat_policy(nativePtr);
				return fromNativePtr<NatPolicy>(ptr, true);
			}
			set
			{
				linphone_proxy_config_set_nat_policy(nativePtr, value.nativePtr);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_proxy_config_get_privacy(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_privacy(IntPtr thiz, uint privacy);

		/// <summary>
		/// Get default privacy policy for all calls routed through this proxy. 
		/// </summary>
		public uint Privacy
		{
			get
			{
				return linphone_proxy_config_get_privacy(nativePtr);
			}
			set
			{
				linphone_proxy_config_set_privacy(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_proxy_config_publish_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_enable_publish(IntPtr thiz, char val);

		public bool PublishEnabled
		{
			get
			{
				return linphone_proxy_config_publish_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_proxy_config_enable_publish(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_get_publish_expires(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_publish_expires(IntPtr thiz, int expires);

		/// <summary>
		/// get the publish expiration time in second. 
		/// </summary>
		public int PublishExpires
		{
			get
			{
				return linphone_proxy_config_get_publish_expires(nativePtr);
			}
			set
			{
				linphone_proxy_config_set_publish_expires(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_push_notification_allowed(IntPtr thiz, char allow);

		/// <summary>
		/// Indicates whether to add to the contact parameters the push notification
		/// information. 
		/// </summary>
		public bool PushNotificationAllowed
		{
			set
			{
				linphone_proxy_config_set_push_notification_allowed(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_quality_reporting_collector(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_quality_reporting_collector(IntPtr thiz, string collector);

		/// <summary>
		/// Get the route of the collector end-point when using quality reporting. 
		/// </summary>
		public string QualityReportingCollector
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_quality_reporting_collector(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_proxy_config_set_quality_reporting_collector(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_proxy_config_quality_reporting_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_enable_quality_reporting(IntPtr thiz, char enable);

		/// <summary>
		/// Indicates whether quality statistics during call should be stored and sent to a
		/// collector according to RFC 6035. 
		/// </summary>
		public bool QualityReportingEnabled
		{
			get
			{
				return linphone_proxy_config_quality_reporting_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_proxy_config_enable_quality_reporting(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_get_quality_reporting_interval(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_quality_reporting_interval(IntPtr thiz, int interval);

		/// <summary>
		/// Get the interval between interval reports when using quality reporting. 
		/// </summary>
		public int QualityReportingInterval
		{
			get
			{
				return linphone_proxy_config_get_quality_reporting_interval(nativePtr);
			}
			set
			{
				linphone_proxy_config_set_quality_reporting_interval(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_realm(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_realm(IntPtr thiz, string realm);

		/// <summary>
		/// Get the realm of the given proxy config. 
		/// </summary>
		public string Realm
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_realm(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_proxy_config_set_realm(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_ref_key(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_ref_key(IntPtr thiz, string refkey);

		/// <summary>
		/// Get the persistent reference key associated to the proxy config. 
		/// </summary>
		public string RefKey
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_ref_key(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_proxy_config_set_ref_key(nativePtr, value);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_proxy_config_register_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_enable_register(IntPtr thiz, char val);

		public bool RegisterEnabled
		{
			get
			{
				return linphone_proxy_config_register_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_proxy_config_enable_register(nativePtr, value ? (char)1 : (char)0);
				
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_route(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_set_route(IntPtr thiz, string route);

		public string Route
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_route(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_proxy_config_set_route(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("Route setter returned value " + exception_result);
			}
		}

		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_routes(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_set_routes(IntPtr thiz, IntPtr routes);

		/// <summary>
		/// Gets the list of the routes set for this proxy config. 
		/// </summary>
		public IEnumerable<string> Routes
		{
			get
			{
				return MarshalStringArray(linphone_proxy_config_get_routes(nativePtr));
			}
			set
			{
				int exception_result = linphone_proxy_config_set_routes(nativePtr, StringArrayToBctbxList(value));
				if (exception_result != 0) throw new LinphoneException("Routes setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_server_addr(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_set_server_addr(IntPtr thiz, string serverAddr);

		public string ServerAddr
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_server_addr(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				int exception_result = linphone_proxy_config_set_server_addr(nativePtr, value);
				if (exception_result != 0) throw new LinphoneException("ServerAddr setter returned value " + exception_result);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern RegistrationState linphone_proxy_config_get_state(IntPtr thiz);

		/// <summary>
		/// Get the registration state of the given proxy config. 
		/// </summary>
		public RegistrationState State
		{
			get
			{
				return linphone_proxy_config_get_state(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_transport(IntPtr thiz);

		/// <summary>
		/// Get the transport from either service route, route or addr. 
		/// </summary>
		public string Transport
		{
			get
			{
				IntPtr stringPtr = linphone_proxy_config_get_transport(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_proxy_config_done(IntPtr thiz);

		/// <summary>
		/// Commits modification made to the proxy configuration. 
		/// </summary>
		public void Done()
		{
			int exception_result = linphone_proxy_config_done(nativePtr);
			if (exception_result != 0) throw new LinphoneException("Done returned value" + exception_result);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_edit(IntPtr thiz);

		/// <summary>
		/// Starts editing a proxy configuration. 
		/// </summary>
		public void Edit()
		{
			linphone_proxy_config_edit(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_find_auth_info(IntPtr thiz);

		/// <summary>
		/// Find authentication info matching proxy config, if any, similarly to
		/// linphone_core_find_auth_info. 
		/// </summary>
		public AuthInfo FindAuthInfo()
		{
			IntPtr ptr = linphone_proxy_config_find_auth_info(nativePtr);
			return fromNativePtr<AuthInfo>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_get_custom_header(IntPtr thiz, string headerName);

		/// <summary>
		/// Obtain the value of a header sent by the server in last answer to REGISTER. 
		/// </summary>
		public string GetCustomHeader(string headerName)
		{
			IntPtr stringPtr = linphone_proxy_config_get_custom_header(nativePtr, headerName);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_proxy_config_is_phone_number(IntPtr thiz, string username);

		/// <summary>
		/// Detect if the given input is a phone number or not. 
		/// </summary>
		public bool IsPhoneNumber(string username)
		{
			return linphone_proxy_config_is_phone_number(nativePtr, username) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_normalize_phone_number(IntPtr thiz, string username);

		/// <summary>
		/// Normalize a human readable phone number into a basic string. 
		/// </summary>
		public string NormalizePhoneNumber(string username)
		{
			IntPtr stringPtr = linphone_proxy_config_normalize_phone_number(nativePtr, username);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_proxy_config_normalize_sip_uri(IntPtr thiz, string username);

		/// <summary>
		/// Normalize a human readable sip uri into a fully qualified LinphoneAddress. 
		/// </summary>
		public Address NormalizeSipUri(string username)
		{
			IntPtr ptr = linphone_proxy_config_normalize_sip_uri(nativePtr, username);
			return fromNativePtr<Address>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_pause_register(IntPtr thiz);

		/// <summary>
		/// Prevent a proxy config from refreshing its registration. 
		/// </summary>
		public void PauseRegister()
		{
			linphone_proxy_config_pause_register(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_refresh_register(IntPtr thiz);

		/// <summary>
		/// Refresh a proxy registration. 
		/// </summary>
		public void RefreshRegister()
		{
			linphone_proxy_config_refresh_register(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_proxy_config_set_custom_header(IntPtr thiz, string headerName, string headerValue);

		/// <summary>
		/// Set the value of a custom header sent to the server in REGISTERs request. 
		/// </summary>
		public void SetCustomHeader(string headerName, string headerValue)
		{
			linphone_proxy_config_set_custom_header(nativePtr, headerName, headerValue);
			
		}
	}

	/// <summary>
	/// Structure describing a range of integers. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Range : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_range_get_max(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_range_set_max(IntPtr thiz, int max);

		/// <summary>
		/// Gets the higher value of the range. 
		/// </summary>
		public int Max
		{
			get
			{
				return linphone_range_get_max(nativePtr);
			}
			set
			{
				linphone_range_set_max(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_range_get_min(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_range_set_min(IntPtr thiz, int min);

		/// <summary>
		/// Gets the lower value of the range. 
		/// </summary>
		public int Min
		{
			get
			{
				return linphone_range_get_min(nativePtr);
			}
			set
			{
				linphone_range_set_min(nativePtr, value);
				
			}
		}
	}

	/// <summary>
	/// The LinphoneSearchResult object represents a result of a search. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class SearchResult : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_search_result_get_address(IntPtr thiz);

		public Address Address
		{
			get
			{
				IntPtr ptr = linphone_search_result_get_address(nativePtr);
				return fromNativePtr<Address>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_search_result_get_friend(IntPtr thiz);

		public Friend Friend
		{
			get
			{
				IntPtr ptr = linphone_search_result_get_friend(nativePtr);
				return fromNativePtr<Friend>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_search_result_get_phone_number(IntPtr thiz);

		public string PhoneNumber
		{
			get
			{
				IntPtr stringPtr = linphone_search_result_get_phone_number(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_search_result_get_weight(IntPtr thiz);

		public uint Weight
		{
			get
			{
				return linphone_search_result_get_weight(nativePtr);
			}
		}
	}

	/// <summary>
	/// Linphone core SIP transport ports. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Transports : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_transports_get_dtls_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_transports_set_dtls_port(IntPtr thiz, int port);

		/// <summary>
		/// Gets the DTLS port in the <see cref="Transports" /> object. 
		/// </summary>
		public int DtlsPort
		{
			get
			{
				return linphone_transports_get_dtls_port(nativePtr);
			}
			set
			{
				linphone_transports_set_dtls_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_transports_get_tcp_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_transports_set_tcp_port(IntPtr thiz, int port);

		/// <summary>
		/// Gets the TCP port in the <see cref="Transports" /> object. 
		/// </summary>
		public int TcpPort
		{
			get
			{
				return linphone_transports_get_tcp_port(nativePtr);
			}
			set
			{
				linphone_transports_set_tcp_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_transports_get_tls_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_transports_set_tls_port(IntPtr thiz, int port);

		/// <summary>
		/// Gets the TLS port in the <see cref="Transports" /> object. 
		/// </summary>
		public int TlsPort
		{
			get
			{
				return linphone_transports_get_tls_port(nativePtr);
			}
			set
			{
				linphone_transports_set_tls_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_transports_get_udp_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_transports_set_udp_port(IntPtr thiz, int port);

		/// <summary>
		/// Gets the UDP port in the <see cref="Transports" /> object. 
		/// </summary>
		public int UdpPort
		{
			get
			{
				return linphone_transports_get_udp_port(nativePtr);
			}
			set
			{
				linphone_transports_set_udp_port(nativePtr, value);
				
			}
		}
	}

	/// <summary>
	/// Linphone tunnel object. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Tunnel : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_tunnel_get_activated(IntPtr thiz);

		/// <summary>
		/// Returns whether the tunnel is activated. 
		/// </summary>
		public bool Activated
		{
			get
			{
				return linphone_tunnel_get_activated(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_tunnel_dual_mode_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_enable_dual_mode(IntPtr thiz, char dualModeEnabled);

		/// <summary>
		/// Get the dual tunnel client mode. 
		/// </summary>
		public bool DualModeEnabled
		{
			get
			{
				return linphone_tunnel_dual_mode_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_tunnel_enable_dual_mode(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern TunnelMode linphone_tunnel_get_mode(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_set_mode(IntPtr thiz, int mode);

		/// <summary>
		/// Get the tunnel mode. 
		/// </summary>
		public TunnelMode Mode
		{
			get
			{
				return linphone_tunnel_get_mode(nativePtr);
			}
			set
			{
				linphone_tunnel_set_mode(nativePtr, (int)value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_tunnel_get_servers(IntPtr thiz);

		/// <summary>
		/// Get added servers. 
		/// </summary>
		public IEnumerable<TunnelConfig> Servers
		{
			get
			{
				return MarshalBctbxList<TunnelConfig>(linphone_tunnel_get_servers(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_tunnel_sip_enabled(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_enable_sip(IntPtr thiz, char enable);

		/// <summary>
		/// Check whether tunnel is set to transport SIP packets. 
		/// </summary>
		public bool SipEnabled
		{
			get
			{
				return linphone_tunnel_sip_enabled(nativePtr) != 0;
			}
			set
			{
				linphone_tunnel_enable_sip(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_add_server(IntPtr thiz, IntPtr tunnelConfig);

		/// <summary>
		/// Add a tunnel server configuration. 
		/// </summary>
		public void AddServer(TunnelConfig tunnelConfig)
		{
			linphone_tunnel_add_server(nativePtr, tunnelConfig != null ? tunnelConfig.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_clean_servers(IntPtr thiz);

		/// <summary>
		/// Remove all tunnel server addresses previously entered with <see
		/// cref="Tunnel.AddServer()" /> 
		/// </summary>
		public void CleanServers()
		{
			linphone_tunnel_clean_servers(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_tunnel_connected(IntPtr thiz);

		/// <summary>
		/// Check whether the tunnel is connected. 
		/// </summary>
		public bool Connected()
		{
			return linphone_tunnel_connected(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_reconnect(IntPtr thiz);

		/// <summary>
		/// Force reconnection to the tunnel server. 
		/// </summary>
		public void Reconnect()
		{
			linphone_tunnel_reconnect(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_remove_server(IntPtr thiz, IntPtr tunnelConfig);

		/// <summary>
		/// Remove a tunnel server configuration. 
		/// </summary>
		public void RemoveServer(TunnelConfig tunnelConfig)
		{
			linphone_tunnel_remove_server(nativePtr, tunnelConfig != null ? tunnelConfig.nativePtr : IntPtr.Zero);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_set_http_proxy(IntPtr thiz, string host, int port, string username, string passwd);

		/// <summary>
		/// Set an optional http proxy to go through when connecting to tunnel server. 
		/// </summary>
		public void SetHttpProxy(string host, int port, string username, string passwd)
		{
			linphone_tunnel_set_http_proxy(nativePtr, host, port, username, passwd);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_set_http_proxy_auth_info(IntPtr thiz, string username, string passwd);

		/// <summary>
		/// Set authentication info for the http proxy. 
		/// </summary>
		public void SetHttpProxyAuthInfo(string username, string passwd)
		{
			linphone_tunnel_set_http_proxy_auth_info(nativePtr, username, passwd);
			
		}
	}

	/// <summary>
	/// Tunnel settings. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class TunnelConfig : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_tunnel_config_get_delay(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_config_set_delay(IntPtr thiz, int delay);

		/// <summary>
		/// Get the UDP packet round trip delay in ms for a tunnel configuration. 
		/// </summary>
		public int Delay
		{
			get
			{
				return linphone_tunnel_config_get_delay(nativePtr);
			}
			set
			{
				linphone_tunnel_config_set_delay(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_tunnel_config_get_host(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_config_set_host(IntPtr thiz, string host);

		/// <summary>
		/// Get the IP address or hostname of the tunnel server. 
		/// </summary>
		public string Host
		{
			get
			{
				IntPtr stringPtr = linphone_tunnel_config_get_host(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_tunnel_config_set_host(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_tunnel_config_get_host2(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_config_set_host2(IntPtr thiz, string host);

		/// <summary>
		/// Get the IP address or hostname of the second tunnel server when using dual
		/// tunnel client. 
		/// </summary>
		public string Host2
		{
			get
			{
				IntPtr stringPtr = linphone_tunnel_config_get_host2(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_tunnel_config_set_host2(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_tunnel_config_get_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_config_set_port(IntPtr thiz, int port);

		/// <summary>
		/// Get the TLS port of the tunnel server. 
		/// </summary>
		public int Port
		{
			get
			{
				return linphone_tunnel_config_get_port(nativePtr);
			}
			set
			{
				linphone_tunnel_config_set_port(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_tunnel_config_get_port2(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_config_set_port2(IntPtr thiz, int port);

		/// <summary>
		/// Get the TLS port of the second tunnel server when using dual tunnel client. 
		/// </summary>
		public int Port2
		{
			get
			{
				return linphone_tunnel_config_get_port2(nativePtr);
			}
			set
			{
				linphone_tunnel_config_set_port2(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_tunnel_config_get_remote_udp_mirror_port(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_tunnel_config_set_remote_udp_mirror_port(IntPtr thiz, int remoteUdpMirrorPort);

		/// <summary>
		/// Get the remote port on the tunnel server side used to test UDP reachability. 
		/// </summary>
		public int RemoteUdpMirrorPort
		{
			get
			{
				return linphone_tunnel_config_get_remote_udp_mirror_port(nativePtr);
			}
			set
			{
				linphone_tunnel_config_set_remote_udp_mirror_port(nativePtr, value);
				
			}
		}
	}

	/// <summary>
	/// The <see cref="Vcard" /> object. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class Vcard : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_etag(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_etag(IntPtr thiz, string etag);

		/// <summary>
		/// Gets the eTag of the vCard. 
		/// </summary>
		public string Etag
		{
			get
			{
				IntPtr stringPtr = linphone_vcard_get_etag(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_vcard_set_etag(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_family_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_family_name(IntPtr thiz, string name);

		/// <summary>
		/// Returns the family name in the N attribute of the vCard, or null if it isn't
		/// set yet. 
		/// </summary>
		public string FamilyName
		{
			get
			{
				IntPtr stringPtr = linphone_vcard_get_family_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_vcard_set_family_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_full_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_full_name(IntPtr thiz, string name);

		/// <summary>
		/// Returns the FN attribute of the vCard, or null if it isn't set yet. 
		/// </summary>
		public string FullName
		{
			get
			{
				IntPtr stringPtr = linphone_vcard_get_full_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_vcard_set_full_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_given_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_given_name(IntPtr thiz, string name);

		/// <summary>
		/// Returns the given name in the N attribute of the vCard, or null if it isn't set
		/// yet. 
		/// </summary>
		public string GivenName
		{
			get
			{
				IntPtr stringPtr = linphone_vcard_get_given_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_vcard_set_given_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_organization(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_organization(IntPtr thiz, string organization);

		/// <summary>
		/// Gets the Organization of the vCard. 
		/// </summary>
		public string Organization
		{
			get
			{
				IntPtr stringPtr = linphone_vcard_get_organization(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_vcard_set_organization(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_phone_numbers(IntPtr thiz);

		/// <summary>
		/// Returns the list of phone numbers (as string) in the vCard (all the TEL
		/// attributes) or null. 
		/// </summary>
		public IEnumerable<string> PhoneNumbers
		{
			get
			{
				return MarshalStringArray(linphone_vcard_get_phone_numbers(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_sip_addresses(IntPtr thiz);

		/// <summary>
		/// Returns the list of SIP addresses (as LinphoneAddress) in the vCard (all the
		/// IMPP attributes that has an URI value starting by "sip:") or null. 
		/// </summary>
		public IEnumerable<Address> SipAddresses
		{
			get
			{
				return MarshalBctbxList<Address>(linphone_vcard_get_sip_addresses(nativePtr));
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_vcard_get_skip_validation(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_skip_validation(IntPtr thiz, char skip);

		/// <summary>
		/// Returns the skipFieldValidation property of the vcard. 
		/// </summary>
		public bool SkipValidation
		{
			get
			{
				return linphone_vcard_get_skip_validation(nativePtr) != 0;
			}
			set
			{
				linphone_vcard_set_skip_validation(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_uid(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_uid(IntPtr thiz, string uid);

		/// <summary>
		/// Gets the UID of the vCard. 
		/// </summary>
		public string Uid
		{
			get
			{
				IntPtr stringPtr = linphone_vcard_get_uid(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_vcard_set_uid(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_get_url(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_set_url(IntPtr thiz, string url);

		/// <summary>
		/// Gets the URL of the vCard. 
		/// </summary>
		public string Url
		{
			get
			{
				IntPtr stringPtr = linphone_vcard_get_url(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_vcard_set_url(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_add_phone_number(IntPtr thiz, string phone);

		/// <summary>
		/// Adds a phone number in the vCard, using the TEL property. 
		/// </summary>
		public void AddPhoneNumber(string phone)
		{
			linphone_vcard_add_phone_number(nativePtr, phone);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_add_sip_address(IntPtr thiz, string sipAddress);

		/// <summary>
		/// Adds a SIP address in the vCard, using the IMPP property. 
		/// </summary>
		public void AddSipAddress(string sipAddress)
		{
			linphone_vcard_add_sip_address(nativePtr, sipAddress);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_as_vcard4_string(IntPtr thiz);

		/// <summary>
		/// Returns the vCard4 representation of the LinphoneVcard. 
		/// </summary>
		public string AsVcard4String()
		{
			IntPtr stringPtr = linphone_vcard_as_vcard4_string(nativePtr);
			return Marshal.PtrToStringAnsi(stringPtr);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_vcard_clone(IntPtr thiz);

		/// <summary>
		/// Clone a <see cref="Vcard" />. 
		/// </summary>
		public Vcard Clone()
		{
			IntPtr ptr = linphone_vcard_clone(nativePtr);
			return fromNativePtr<Vcard>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_edit_main_sip_address(IntPtr thiz, string sipAddress);

		/// <summary>
		/// Edits the preferred SIP address in the vCard (or the first one), using the IMPP
		/// property. 
		/// </summary>
		public void EditMainSipAddress(string sipAddress)
		{
			linphone_vcard_edit_main_sip_address(nativePtr, sipAddress);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_vcard_generate_unique_id(IntPtr thiz);

		/// <summary>
		/// Generates a random unique id for the vCard. 
		/// </summary>
		public bool GenerateUniqueId()
		{
			return linphone_vcard_generate_unique_id(nativePtr) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_remove_phone_number(IntPtr thiz, string phone);

		/// <summary>
		/// Removes a phone number in the vCard (if it exists), using the TEL property. 
		/// </summary>
		public void RemovePhoneNumber(string phone)
		{
			linphone_vcard_remove_phone_number(nativePtr, phone);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_vcard_remove_sip_address(IntPtr thiz, string sipAddress);

		/// <summary>
		/// Removes a SIP address in the vCard (if it exists), using the IMPP property. 
		/// </summary>
		public void RemoveSipAddress(string sipAddress)
		{
			linphone_vcard_remove_sip_address(nativePtr, sipAddress);
			
		}
	}

	/// <summary>
	/// Structure describing policy regarding video streams establishments. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class VideoActivationPolicy : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_video_activation_policy_get_automatically_accept(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_video_activation_policy_set_automatically_accept(IntPtr thiz, char enable);

		/// <summary>
		/// Gets the value for the automatically accept video policy. 
		/// </summary>
		public bool AutomaticallyAccept
		{
			get
			{
				return linphone_video_activation_policy_get_automatically_accept(nativePtr) != 0;
			}
			set
			{
				linphone_video_activation_policy_set_automatically_accept(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_video_activation_policy_get_automatically_initiate(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_video_activation_policy_set_automatically_initiate(IntPtr thiz, char enable);

		/// <summary>
		/// Gets the value for the automatically initiate video policy. 
		/// </summary>
		public bool AutomaticallyInitiate
		{
			get
			{
				return linphone_video_activation_policy_get_automatically_initiate(nativePtr) != 0;
			}
			set
			{
				linphone_video_activation_policy_set_automatically_initiate(nativePtr, value ? (char)1 : (char)0);
				
			}
		}
	}

	/// <summary>
	/// The <see cref="VideoDefinition" /> object represents a video
	/// definition, eg. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class VideoDefinition : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_video_definition_get_height(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_video_definition_set_height(IntPtr thiz, uint height);

		/// <summary>
		/// Get the height of the video definition. 
		/// </summary>
		public uint Height
		{
			get
			{
				return linphone_video_definition_get_height(nativePtr);
			}
			set
			{
				linphone_video_definition_set_height(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_video_definition_is_undefined(IntPtr thiz);

		/// <summary>
		/// Tells whether a <see cref="VideoDefinition" /> is undefined. 
		/// </summary>
		public bool IsUndefined
		{
			get
			{
				return linphone_video_definition_is_undefined(nativePtr) != 0;
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_video_definition_get_name(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_video_definition_set_name(IntPtr thiz, string name);

		/// <summary>
		/// Get the name of the video definition. 
		/// </summary>
		public string Name
		{
			get
			{
				IntPtr stringPtr = linphone_video_definition_get_name(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
			set
			{
				linphone_video_definition_set_name(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern uint linphone_video_definition_get_width(IntPtr thiz);
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_video_definition_set_width(IntPtr thiz, uint width);

		/// <summary>
		/// Get the width of the video definition. 
		/// </summary>
		public uint Width
		{
			get
			{
				return linphone_video_definition_get_width(nativePtr);
			}
			set
			{
				linphone_video_definition_set_width(nativePtr, value);
				
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_video_definition_clone(IntPtr thiz);

		/// <summary>
		/// Clone a video definition. 
		/// </summary>
		public VideoDefinition Clone()
		{
			IntPtr ptr = linphone_video_definition_clone(nativePtr);
			return fromNativePtr<VideoDefinition>(ptr, true);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_video_definition_equals(IntPtr thiz, IntPtr vdef2);

		/// <summary>
		/// Tells whether two <see cref="VideoDefinition" /> objects are equal
		/// (the widths and the heights are the same but can be switched). 
		/// </summary>
		public bool Equals(VideoDefinition vdef2)
		{
			return linphone_video_definition_equals(nativePtr, vdef2 != null ? vdef2.nativePtr : IntPtr.Zero) == (char)0 ? false : true;
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_video_definition_set_definition(IntPtr thiz, uint width, uint height);

		/// <summary>
		/// Set the width and the height of the video definition. 
		/// </summary>
		public void SetDefinition(uint width, uint height)
		{
			linphone_video_definition_set_definition(nativePtr, width, height);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern char linphone_video_definition_strict_equals(IntPtr thiz, IntPtr vdef2);

		/// <summary>
		/// Tells whether two <see cref="VideoDefinition" /> objects are strictly
		/// equal (the widths are the same and the heights are the same). 
		/// </summary>
		public bool StrictEquals(VideoDefinition vdef2)
		{
			return linphone_video_definition_strict_equals(nativePtr, vdef2 != null ? vdef2.nativePtr : IntPtr.Zero) == (char)0 ? false : true;
		}
	}

	/// <summary>
	/// The <see cref="XmlRpcRequest" /> object representing a XML-RPC request
	/// to be sent. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class XmlRpcRequest : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_xml_rpc_request_get_callbacks(IntPtr thiz);

		/// <summary>
		/// The <see cref="XmlRpcRequest" /> object representing a XML-RPC request
		/// to be sent. 
		/// </summary>
		public XmlRpcRequestListener Listener
		{
			get
			{
				IntPtr ptr = linphone_xml_rpc_request_get_callbacks(nativePtr);
				return fromNativePtr<XmlRpcRequestListener>(ptr, true);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_xml_rpc_request_get_content(IntPtr thiz);

		/// <summary>
		/// Get the content of the XML-RPC request. 
		/// </summary>
		public string Content
		{
			get
			{
				IntPtr stringPtr = linphone_xml_rpc_request_get_content(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern int linphone_xml_rpc_request_get_int_response(IntPtr thiz);

		/// <summary>
		/// Get the response to an XML-RPC request sent with <see
		/// cref="XmlRpcSession.SendRequest()" /> and returning an integer
		/// response. 
		/// </summary>
		public int IntResponse
		{
			get
			{
				return linphone_xml_rpc_request_get_int_response(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern XmlRpcStatus linphone_xml_rpc_request_get_status(IntPtr thiz);

		/// <summary>
		/// Get the status of the XML-RPC request. 
		/// </summary>
		public XmlRpcStatus Status
		{
			get
			{
				return linphone_xml_rpc_request_get_status(nativePtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_xml_rpc_request_get_string_response(IntPtr thiz);

		/// <summary>
		/// Get the response to an XML-RPC request sent with <see
		/// cref="XmlRpcSession.SendRequest()" /> and returning a string response. 
		/// </summary>
		public string StringResponse
		{
			get
			{
				IntPtr stringPtr = linphone_xml_rpc_request_get_string_response(nativePtr);
				return Marshal.PtrToStringAnsi(stringPtr);
			}
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_xml_rpc_request_add_int_arg(IntPtr thiz, int val);

		/// <summary>
		/// Add an integer argument to an XML-RPC request. 
		/// </summary>
		public void AddIntArg(int val)
		{
			linphone_xml_rpc_request_add_int_arg(nativePtr, val);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_xml_rpc_request_add_string_arg(IntPtr thiz, string val);

		/// <summary>
		/// Add a string argument to an XML-RPC request. 
		/// </summary>
		public void AddStringArg(string val)
		{
			linphone_xml_rpc_request_add_string_arg(nativePtr, val);
			
		}
	}

	/// <summary>
	/// The <see cref="XmlRpcSession" /> object used to send XML-RPC requests
	/// and handle their responses. 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public class XmlRpcSession : LinphoneObject
	{
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr linphone_xml_rpc_session_create_request(IntPtr thiz, int returnType, string method);

		/// <summary>
		/// Creates a <see cref="XmlRpcRequest" /> from a <see
		/// cref="XmlRpcSession" />. 
		/// </summary>
		public XmlRpcRequest CreateRequest(XmlRpcArgType returnType, string method)
		{
			IntPtr ptr = linphone_xml_rpc_session_create_request(nativePtr, (int)returnType, method);
			return fromNativePtr<XmlRpcRequest>(ptr, false);
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_xml_rpc_session_release(IntPtr thiz);

		/// <summary>
		/// Stop and unref an XML rpc session. 
		/// </summary>
		public void Release()
		{
			linphone_xml_rpc_session_release(nativePtr);
			
		}
		[DllImport(Utils.LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		static extern void linphone_xml_rpc_session_send_request(IntPtr thiz, IntPtr request);

		/// <summary>
		/// Send an XML-RPC request. 
		/// </summary>
		public void SendRequest(XmlRpcRequest request)
		{
			linphone_xml_rpc_session_send_request(nativePtr, request != null ? request.nativePtr : IntPtr.Zero);
			
		}
	}
}
