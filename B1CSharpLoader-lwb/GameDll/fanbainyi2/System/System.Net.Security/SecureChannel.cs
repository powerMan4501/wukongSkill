using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Principal;
using Microsoft.Win32;

namespace System.Net.Security;

internal class SecureChannel
{
	private static class UnmanagedCertificateContext
	{
		private struct _CERT_CONTEXT
		{
			internal int dwCertEncodingType;

			internal IntPtr pbCertEncoded;

			internal int cbCertEncoded;

			internal IntPtr pCertInfo;

			internal IntPtr hCertStore;
		}

		internal static X509Certificate2Collection GetStore(SafeFreeCertContext certContext)
		{
			X509Certificate2Collection result = new X509Certificate2Collection();
			if (certContext.IsInvalid)
			{
				return result;
			}
			_CERT_CONTEXT cERT_CONTEXT = (_CERT_CONTEXT)Marshal.PtrToStructure(certContext.DangerousGetHandle(), typeof(_CERT_CONTEXT));
			if (cERT_CONTEXT.hCertStore != IntPtr.Zero)
			{
				X509Store x509Store = null;
				try
				{
					x509Store = new X509Store(cERT_CONTEXT.hCertStore);
					result = x509Store.Certificates;
				}
				finally
				{
					x509Store?.Close();
				}
			}
			return result;
		}
	}

	internal const string SecurityPackage = "Microsoft Unified Security Protocol Provider";

	private static readonly object s_SyncObject = new object();

	private static readonly bool CanUseNewCryptoApi = CheckWindowsVersion();

	private const ContextFlags RequiredFlags = ContextFlags.ReplayDetect | ContextFlags.SequenceDetect | ContextFlags.Confidentiality | ContextFlags.AllocateMemory;

	private const ContextFlags ServerRequiredFlags = ContextFlags.ReplayDetect | ContextFlags.SequenceDetect | ContextFlags.Confidentiality | ContextFlags.AllocateMemory | ContextFlags.AcceptStream;

	private const int ChainRevocationCheckExcludeRoot = 1073741824;

	internal const int ReadHeaderSize = 5;

	private static volatile X509Store s_MyCertStoreEx;

	private static volatile X509Store s_MyMachineCertStoreEx;

	private SafeFreeCredentials m_CredentialsHandle;

	private SafeDeleteContext m_SecurityContext;

	private ContextFlags m_Attributes;

	private readonly string m_Destination;

	private readonly string m_HostName;

	private readonly bool m_ServerMode;

	private readonly bool m_RemoteCertRequired;

	private readonly SchProtocols m_ProtocolFlags;

	private readonly EncryptionPolicy m_EncryptionPolicy;

	private SslConnectionInfo m_ConnectionInfo;

	private X509Certificate m_ServerCertificate;

	private X509Certificate m_SelectedClientCertificate;

	private bool m_IsRemoteCertificateAvailable;

	private readonly X509CertificateCollection m_ClientCertificates;

	private LocalCertSelectionCallback m_CertSelectionDelegate;

	private int m_HeaderSize = 5;

	private int m_TrailerSize = 16;

	private int m_MaxDataSize = 16354;

	private bool m_CheckCertRevocation;

	private bool m_CheckCertName;

	private bool m_RefreshCredentialNeeded;

	private readonly Oid m_ServerAuthOid = new Oid("1.3.6.1.5.5.7.3.1", "1.3.6.1.5.5.7.3.1");

	private readonly Oid m_ClientAuthOid = new Oid("1.3.6.1.5.5.7.3.2", "1.3.6.1.5.5.7.3.2");

	internal X509Certificate LocalServerCertificate => m_ServerCertificate;

	internal X509Certificate LocalClientCertificate => m_SelectedClientCertificate;

	internal bool IsRemoteCertificateAvailable => m_IsRemoteCertificateAvailable;

	internal bool CheckCertRevocationStatus => m_CheckCertRevocation;

	internal X509CertificateCollection ClientCertificates => m_ClientCertificates;

	internal int HeaderSize => m_HeaderSize;

	internal int MaxDataSize => m_MaxDataSize;

	internal SslConnectionInfo ConnectionInfo => m_ConnectionInfo;

	internal bool IsValidContext
	{
		get
		{
			if (m_SecurityContext != null)
			{
				return !m_SecurityContext.IsInvalid;
			}
			return false;
		}
	}

	internal bool IsServer => m_ServerMode;

	internal bool RemoteCertRequired => m_RemoteCertRequired;

	internal SecureChannel(string hostname, bool serverMode, SchProtocols protocolFlags, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool remoteCertRequired, bool checkCertName, bool checkCertRevocationStatus, EncryptionPolicy encryptionPolicy, LocalCertSelectionCallback certSelectionDelegate)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, ".ctor", "hostname=" + hostname + ", #clientCertificates=" + ((clientCertificates == null) ? "0" : clientCertificates.Count.ToString(NumberFormatInfo.InvariantInfo)) + ", encryptionPolicy=" + encryptionPolicy);
		}
		SSPIWrapper.GetVerifyPackageInfo(GlobalSSPI.SSPISecureChannel, "Microsoft Unified Security Protocol Provider", throwIfMissing: true);
		m_Destination = hostname;
		m_HostName = hostname;
		m_ServerMode = serverMode;
		if (serverMode)
		{
			m_ProtocolFlags = protocolFlags & SchProtocols.ServerMask;
		}
		else
		{
			m_ProtocolFlags = protocolFlags & SchProtocols.ClientMask;
		}
		m_ServerCertificate = serverCertificate;
		m_ClientCertificates = clientCertificates;
		m_RemoteCertRequired = remoteCertRequired;
		m_SecurityContext = null;
		m_CheckCertRevocation = checkCertRevocationStatus;
		m_CheckCertName = checkCertName;
		m_CertSelectionDelegate = certSelectionDelegate;
		m_RefreshCredentialNeeded = true;
		m_EncryptionPolicy = encryptionPolicy;
	}

	private static bool CheckWindowsVersion()
	{
		try
		{
			if ((int)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentMajorVersionNumber", 0) >= 10 && int.TryParse((string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentBuildNumber", "0"), out var result) && result >= 18836)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal X509Certificate2 GetRemoteCertificate(out X509Certificate2Collection remoteCertificateStore)
	{
		remoteCertificateStore = null;
		if (m_SecurityContext == null)
		{
			return null;
		}
		X509Certificate2 x509Certificate = null;
		SafeFreeCertContext safeFreeCertContext = null;
		try
		{
			safeFreeCertContext = SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPISecureChannel, m_SecurityContext, ContextAttribute.RemoteCertificate) as SafeFreeCertContext;
			if (safeFreeCertContext != null && !safeFreeCertContext.IsInvalid)
			{
				x509Certificate = new X509Certificate2(safeFreeCertContext.DangerousGetHandle());
			}
		}
		finally
		{
			if (safeFreeCertContext != null)
			{
				remoteCertificateStore = UnmanagedCertificateContext.GetStore(safeFreeCertContext);
				safeFreeCertContext.Close();
			}
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_remote_certificate", (x509Certificate == null) ? "null" : x509Certificate.ToString(verbose: true)));
		}
		return x509Certificate;
	}

	internal ChannelBinding GetChannelBinding(ChannelBindingKind kind)
	{
		ChannelBinding result = null;
		if (m_SecurityContext != null)
		{
			result = SSPIWrapper.QueryContextChannelBinding(GlobalSSPI.SSPISecureChannel, m_SecurityContext, (ContextAttribute)kind);
		}
		return result;
	}

	internal void SetRefreshCredentialNeeded()
	{
		m_RefreshCredentialNeeded = true;
	}

	internal void Close()
	{
		if (m_SecurityContext != null)
		{
			m_SecurityContext.Close();
		}
		if (m_CredentialsHandle != null)
		{
			m_CredentialsHandle.Close();
		}
	}

	private X509Certificate2 EnsurePrivateKey(X509Certificate certificate)
	{
		if (certificate == null)
		{
			return null;
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_locating_private_key_for_certificate", certificate.ToString(fVerbose: true)));
		}
		try
		{
			X509Certificate2 x509Certificate = certificate as X509Certificate2;
			Type type = certificate.GetType();
			string findValue = null;
			if (type != typeof(X509Certificate2) && type != typeof(X509Certificate))
			{
				if (certificate.Handle != IntPtr.Zero)
				{
					x509Certificate = new X509Certificate2(certificate);
					findValue = x509Certificate.GetCertHashString();
				}
			}
			else
			{
				findValue = certificate.GetCertHashString();
			}
			if (x509Certificate != null)
			{
				if (x509Certificate.HasPrivateKey)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_cert_is_of_type_2"));
					}
					return x509Certificate;
				}
				if (certificate != x509Certificate)
				{
					x509Certificate.Reset();
				}
			}
			ExceptionHelper.KeyContainerPermissionOpen.Demand();
			X509Store x509Store = EnsureStoreOpened(m_ServerMode);
			if (x509Store != null)
			{
				X509Certificate2Collection x509Certificate2Collection = x509Store.Certificates.Find(X509FindType.FindByThumbprint, findValue, validOnly: false);
				if (x509Certificate2Collection.Count > 0 && x509Certificate2Collection[0].HasPrivateKey)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_found_cert_in_store", m_ServerMode ? "LocalMachine" : "CurrentUser"));
					}
					return x509Certificate2Collection[0];
				}
			}
			x509Store = EnsureStoreOpened(!m_ServerMode);
			if (x509Store != null)
			{
				X509Certificate2Collection x509Certificate2Collection = x509Store.Certificates.Find(X509FindType.FindByThumbprint, findValue, validOnly: false);
				if (x509Certificate2Collection.Count > 0 && x509Certificate2Collection[0].HasPrivateKey)
				{
					if (Logging.On)
					{
						Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_found_cert_in_store", m_ServerMode ? "CurrentUser" : "LocalMachine"));
					}
					return x509Certificate2Collection[0];
				}
			}
		}
		catch (CryptographicException)
		{
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_did_not_find_cert_in_store"));
		}
		return null;
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	internal static X509Store EnsureStoreOpened(bool isMachineStore)
	{
		X509Store x509Store = (isMachineStore ? s_MyMachineCertStoreEx : s_MyCertStoreEx);
		if (x509Store == null)
		{
			lock (s_SyncObject)
			{
				x509Store = (isMachineStore ? s_MyMachineCertStoreEx : s_MyCertStoreEx);
				if (x509Store == null)
				{
					StoreLocation storeLocation = ((!isMachineStore) ? StoreLocation.CurrentUser : StoreLocation.LocalMachine);
					x509Store = new X509Store(StoreName.My, storeLocation);
					try
					{
						try
						{
							using (WindowsIdentity.Impersonate(IntPtr.Zero))
							{
								x509Store.Open(OpenFlags.OpenExistingOnly);
							}
						}
						catch
						{
							throw;
						}
						if (isMachineStore)
						{
							s_MyMachineCertStoreEx = x509Store;
						}
						else
						{
							s_MyCertStoreEx = x509Store;
						}
						return x509Store;
					}
					catch (Exception ex)
					{
						if (ex is CryptographicException || ex is SecurityException)
						{
							return null;
						}
						if (Logging.On)
						{
							Logging.PrintError(Logging.Web, SR.GetString("net_log_open_store_failed", storeLocation, ex));
						}
						throw;
					}
				}
			}
		}
		return x509Store;
	}

	private static X509Certificate2 MakeEx(X509Certificate certificate)
	{
		if (certificate.GetType() == typeof(X509Certificate2))
		{
			return (X509Certificate2)certificate;
		}
		X509Certificate2 result = null;
		try
		{
			if (certificate.Handle != IntPtr.Zero)
			{
				result = new X509Certificate2(certificate);
			}
		}
		catch (SecurityException)
		{
		}
		catch (CryptographicException)
		{
		}
		return result;
	}

	private unsafe string[] GetIssuers()
	{
		string[] array = new string[0];
		if (IsValidContext)
		{
			if (!(SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPISecureChannel, m_SecurityContext, ContextAttribute.IssuerListInfoEx) is IssuerListInfoEx issuerListInfoEx))
			{
				return array;
			}
			try
			{
				if (issuerListInfoEx.cIssuers != 0)
				{
					uint cIssuers = issuerListInfoEx.cIssuers;
					array = new string[issuerListInfoEx.cIssuers];
					_CERT_CHAIN_ELEMENT* ptr = (_CERT_CHAIN_ELEMENT*)(void*)issuerListInfoEx.aIssuers.DangerousGetHandle();
					for (uint num = 0u; num < cIssuers; num++)
					{
						_CERT_CHAIN_ELEMENT* ptr2 = ptr + num;
						uint cbSize = ptr2->cbSize;
						byte* ptr3 = (byte*)(void*)ptr2->pCertContext;
						byte[] array2 = new byte[cbSize];
						for (uint num2 = 0u; num2 < cbSize; num2++)
						{
							array2[num2] = ptr3[num2];
						}
						X500DistinguishedName x500DistinguishedName = new X500DistinguishedName(array2);
						array[num] = x500DistinguishedName.Name;
					}
				}
			}
			finally
			{
				if (issuerListInfoEx.aIssuers != null)
				{
					issuerListInfoEx.aIssuers.Close();
				}
			}
		}
		return array;
	}

	[StorePermission(SecurityAction.Assert, Unrestricted = true)]
	private bool AcquireClientCredentials(ref byte[] thumbPrint)
	{
		X509Certificate x509Certificate = null;
		ArrayList arrayList = new ArrayList();
		string[] array = null;
		bool flag = false;
		if (m_CertSelectionDelegate != null)
		{
			if (array == null)
			{
				array = GetIssuers();
			}
			X509Certificate2 x509Certificate2 = null;
			try
			{
				x509Certificate2 = GetRemoteCertificate(out var _);
				x509Certificate = m_CertSelectionDelegate(m_HostName, ClientCertificates, x509Certificate2, array);
			}
			finally
			{
				x509Certificate2?.Reset();
			}
			if (x509Certificate != null)
			{
				if (m_CredentialsHandle == null)
				{
					flag = true;
				}
				arrayList.Add(x509Certificate);
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_got_certificate_from_delegate"));
				}
			}
			else if (ClientCertificates.Count == 0)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_no_delegate_and_have_no_client_cert"));
				}
				flag = true;
			}
			else if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_no_delegate_but_have_client_cert"));
			}
		}
		else if (m_CredentialsHandle == null && m_ClientCertificates != null && m_ClientCertificates.Count > 0)
		{
			x509Certificate = ClientCertificates[0];
			flag = true;
			if (x509Certificate != null)
			{
				arrayList.Add(x509Certificate);
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_attempting_restart_using_cert", (x509Certificate == null) ? "null" : x509Certificate.ToString(fVerbose: true)));
			}
		}
		else if (m_ClientCertificates != null && m_ClientCertificates.Count > 0)
		{
			if (array == null)
			{
				array = GetIssuers();
			}
			if (Logging.On)
			{
				if (array == null || array.Length == 0)
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_no_issuers_try_all_certs"));
				}
				else
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_server_issuers_look_for_matching_certs", array.Length));
				}
			}
			for (int i = 0; i < m_ClientCertificates.Count; i++)
			{
				if (array != null && array.Length != 0)
				{
					X509Certificate2 x509Certificate3 = null;
					X509Chain x509Chain = null;
					try
					{
						x509Certificate3 = MakeEx(m_ClientCertificates[i]);
						if (x509Certificate3 == null)
						{
							continue;
						}
						x509Chain = new X509Chain();
						x509Chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
						x509Chain.ChainPolicy.VerificationFlags = X509VerificationFlags.IgnoreInvalidName;
						x509Chain.Build(x509Certificate3);
						bool flag2 = false;
						if (x509Chain.ChainElements.Count > 0)
						{
							for (int j = 0; j < x509Chain.ChainElements.Count; j++)
							{
								string issuer = x509Chain.ChainElements[j].Certificate.Issuer;
								flag2 = Array.IndexOf(array, issuer) != -1;
								if (flag2)
								{
									break;
								}
							}
						}
						if (!flag2)
						{
							continue;
						}
						goto IL_02ba;
					}
					finally
					{
						x509Chain?.Reset();
						if (x509Certificate3 != null && x509Certificate3 != m_ClientCertificates[i])
						{
							x509Certificate3.Reset();
						}
					}
				}
				goto IL_02ba;
				IL_02ba:
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_selected_cert", m_ClientCertificates[i].ToString(fVerbose: true)));
				}
				arrayList.Add(m_ClientCertificates[i]);
			}
		}
		bool result = false;
		X509Certificate2 x509Certificate4 = null;
		x509Certificate = null;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_n_certs_after_filtering", arrayList.Count));
			if (arrayList.Count != 0)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_finding_matching_certs"));
			}
		}
		for (int k = 0; k < arrayList.Count; k++)
		{
			x509Certificate = arrayList[k] as X509Certificate;
			if ((x509Certificate4 = EnsurePrivateKey(x509Certificate)) != null)
			{
				break;
			}
			x509Certificate = null;
			x509Certificate4 = null;
		}
		try
		{
			byte[] array2 = x509Certificate4?.GetCertHash();
			SafeFreeCredentials safeFreeCredentials = SslSessionsCache.TryCachedCredential(array2, m_ProtocolFlags, m_EncryptionPolicy);
			if (flag && safeFreeCredentials == null && x509Certificate4 != null)
			{
				if (x509Certificate != x509Certificate4)
				{
					x509Certificate4.Reset();
				}
				array2 = null;
				x509Certificate4 = null;
				x509Certificate = null;
			}
			if (safeFreeCredentials != null)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, SR.GetString("net_log_using_cached_credential"));
				}
				m_CredentialsHandle = safeFreeCredentials;
				m_SelectedClientCertificate = x509Certificate;
				result = true;
			}
			else
			{
				SecureCredential.Flags flags = SecureCredential.Flags.ValidateManual | SecureCredential.Flags.NoDefaultCred;
				if (!ServicePointManager.DisableSendAuxRecord)
				{
					flags |= SecureCredential.Flags.SendAuxRecord;
				}
				if (!ServicePointManager.DisableStrongCrypto && (m_ProtocolFlags == SchProtocols.Zero || (m_ProtocolFlags & (SchProtocols.Tls10 | SchProtocols.Tls11 | SchProtocols.Tls12 | SchProtocols.Tls13)) != SchProtocols.Zero) && m_EncryptionPolicy != EncryptionPolicy.AllowNoEncryption && m_EncryptionPolicy != EncryptionPolicy.NoEncryption)
				{
					flags |= SecureCredential.Flags.UseStrongCrypto;
				}
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Web, this, ".AcquireClientCredentials, new SecureCredential() ", "flags=(" + flags.ToString() + "), m_ProtocolFlags=(" + m_ProtocolFlags.ToString() + "), m_EncryptionPolicy=" + m_EncryptionPolicy);
				}
				m_CredentialsHandle = AcquireCredentialsHandle(CredentialUse.Outbound, x509Certificate4, flags);
				thumbPrint = array2;
				m_SelectedClientCertificate = x509Certificate;
			}
		}
		finally
		{
			if (x509Certificate4 != null && x509Certificate != x509Certificate4)
			{
				x509Certificate4.Reset();
			}
		}
		return result;
	}

	[StorePermission(SecurityAction.Assert, Unrestricted = true)]
	private bool AcquireServerCredentials(ref byte[] thumbPrint)
	{
		X509Certificate x509Certificate = null;
		bool result = false;
		if (m_CertSelectionDelegate != null)
		{
			X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
			x509CertificateCollection.Add(m_ServerCertificate);
			x509Certificate = m_CertSelectionDelegate(string.Empty, x509CertificateCollection, null, new string[0]);
		}
		else
		{
			x509Certificate = m_ServerCertificate;
		}
		if (x509Certificate == null)
		{
			throw new NotSupportedException(SR.GetString("net_ssl_io_no_server_cert"));
		}
		X509Certificate2 x509Certificate2 = EnsurePrivateKey(x509Certificate);
		if (x509Certificate2 == null)
		{
			throw new NotSupportedException(SR.GetString("net_ssl_io_no_server_cert"));
		}
		byte[] certHash = x509Certificate2.GetCertHash();
		try
		{
			SafeFreeCredentials safeFreeCredentials = SslSessionsCache.TryCachedCredential(certHash, m_ProtocolFlags, m_EncryptionPolicy);
			if (safeFreeCredentials != null)
			{
				m_CredentialsHandle = safeFreeCredentials;
				m_ServerCertificate = x509Certificate;
				result = true;
			}
			else
			{
				SecureCredential.Flags flags = SecureCredential.Flags.Zero;
				if (!ServicePointManager.DisableSendAuxRecord)
				{
					flags |= SecureCredential.Flags.SendAuxRecord;
				}
				m_CredentialsHandle = AcquireCredentialsHandle(CredentialUse.Inbound, x509Certificate2, flags);
				thumbPrint = certHash;
				m_ServerCertificate = x509Certificate;
			}
		}
		finally
		{
			if (x509Certificate != x509Certificate2)
			{
				x509Certificate2.Reset();
			}
		}
		return result;
	}

	private unsafe SafeFreeCredentials AcquireCredentialsHandle(CredentialUse credUsage, X509Certificate2 selectedCert, SecureCredential.Flags flags)
	{
		if ((m_ProtocolFlags != SchProtocols.Zero && (m_ProtocolFlags & SchProtocols.Tls13) == 0) || !CanUseNewCryptoApi || m_EncryptionPolicy == EncryptionPolicy.NoEncryption || System.LocalAppContextSwitches.DontEnableTls13)
		{
			SecureCredential secureCredential = new SecureCredential(4, selectedCert, flags, m_ProtocolFlags, m_EncryptionPolicy);
			return AcquireCredentialsHandle(credUsage, ref secureCredential);
		}
		SecureCredential2 secureCredential2 = new SecureCredential2((SecureCredential2.Flags)flags, m_ProtocolFlags, m_EncryptionPolicy);
		if (m_ProtocolFlags != SchProtocols.Zero)
		{
			TlsParamaters tlsParamaters = new TlsParamaters(m_ProtocolFlags);
			secureCredential2.cTlsParameters = 1;
			secureCredential2.pTlsParameters = &tlsParamaters;
		}
		void* ptr = null;
		if (selectedCert != null)
		{
			ptr = (void*)selectedCert.Handle;
			secureCredential2.certContextArray = &ptr;
			secureCredential2.cCreds = 1;
		}
		return AcquireCredentialsHandle(credUsage, ref secureCredential2);
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	private SafeFreeCredentials AcquireCredentialsHandle(CredentialUse credUsage, ref SecureCredential secureCredential)
	{
		try
		{
			using (WindowsIdentity.Impersonate(IntPtr.Zero))
			{
				return SSPIWrapper.AcquireCredentialsHandle(GlobalSSPI.SSPISecureChannel, "Microsoft Unified Security Protocol Provider", credUsage, secureCredential);
			}
		}
		catch
		{
			return SSPIWrapper.AcquireCredentialsHandle(GlobalSSPI.SSPISecureChannel, "Microsoft Unified Security Protocol Provider", credUsage, secureCredential);
		}
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	private SafeFreeCredentials AcquireCredentialsHandle(CredentialUse credUsage, ref SecureCredential2 secureCredential)
	{
		try
		{
			using (WindowsIdentity.Impersonate(IntPtr.Zero))
			{
				return SSPIWrapper.AcquireCredentialsHandle(GlobalSSPI.SSPISecureChannel, "Microsoft Unified Security Protocol Provider", credUsage, secureCredential);
			}
		}
		catch
		{
			return SSPIWrapper.AcquireCredentialsHandle(GlobalSSPI.SSPISecureChannel, "Microsoft Unified Security Protocol Provider", credUsage, secureCredential);
		}
	}

	internal ProtocolToken NextMessage(byte[] incoming, int offset, int count)
	{
		byte[] output = null;
		SecurityStatus securityStatus = GenerateToken(incoming, offset, count, ref output);
		if (!m_ServerMode && securityStatus == SecurityStatus.CredentialsNeeded)
		{
			SetRefreshCredentialNeeded();
			securityStatus = GenerateToken(incoming, offset, count, ref output);
		}
		return new ProtocolToken(output, securityStatus);
	}

	private SecurityStatus GenerateToken(byte[] input, int offset, int count, ref byte[] output)
	{
		if (offset < 0 || offset > ((input != null) ? input.Length : 0))
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > ((input != null) ? (input.Length - offset) : 0))
		{
			throw new ArgumentOutOfRangeException("count");
		}
		SecurityBuffer securityBuffer = null;
		SecurityBuffer[] inputBuffers = null;
		if (input != null)
		{
			securityBuffer = new SecurityBuffer(input, offset, count, BufferType.Token);
			inputBuffers = new SecurityBuffer[2]
			{
				securityBuffer,
				new SecurityBuffer(null, 0, 0, BufferType.Empty)
			};
		}
		SecurityBuffer securityBuffer2 = new SecurityBuffer(null, BufferType.Token);
		int num = 0;
		bool flag = false;
		byte[] thumbPrint = null;
		try
		{
			do
			{
				thumbPrint = null;
				if (m_RefreshCredentialNeeded)
				{
					flag = (m_ServerMode ? AcquireServerCredentials(ref thumbPrint) : AcquireClientCredentials(ref thumbPrint));
				}
				if (m_ServerMode)
				{
					num = SSPIWrapper.AcceptSecurityContext(GlobalSSPI.SSPISecureChannel, ref m_CredentialsHandle, ref m_SecurityContext, (ContextFlags)(0x1011C | (m_RemoteCertRequired ? 2 : 0)), Endianness.Native, securityBuffer, securityBuffer2, ref m_Attributes);
				}
				else if (securityBuffer == null)
				{
					num = SSPIWrapper.InitializeSecurityContext(GlobalSSPI.SSPISecureChannel, ref m_CredentialsHandle, ref m_SecurityContext, m_Destination, ContextFlags.ReplayDetect | ContextFlags.SequenceDetect | ContextFlags.Confidentiality | ContextFlags.AllocateMemory | ContextFlags.InitManualCredValidation, Endianness.Native, securityBuffer, securityBuffer2, ref m_Attributes);
					if ((num == 0 || num == 590610) && ComNetOS.IsWin8orLater && Microsoft.Win32.UnsafeNativeMethods.IsPackagedProcess.Value)
					{
						int num2 = SSPIWrapper.SetContextAttributes(GlobalSSPI.SSPISecureChannel, m_SecurityContext, ContextAttribute.UiInfo, UnsafeNclNativeMethods.AppXHelper.PrimaryWindowHandle.Value);
					}
				}
				else
				{
					num = SSPIWrapper.InitializeSecurityContext(GlobalSSPI.SSPISecureChannel, m_CredentialsHandle, ref m_SecurityContext, m_Destination, ContextFlags.ReplayDetect | ContextFlags.SequenceDetect | ContextFlags.Confidentiality | ContextFlags.AllocateMemory | ContextFlags.InitManualCredValidation, Endianness.Native, inputBuffers, securityBuffer2, ref m_Attributes);
				}
			}
			while (flag && m_CredentialsHandle == null);
		}
		finally
		{
			if (m_RefreshCredentialNeeded)
			{
				m_RefreshCredentialNeeded = false;
				if (m_CredentialsHandle != null)
				{
					m_CredentialsHandle.Close();
				}
				if (!flag && m_SecurityContext != null && !m_SecurityContext.IsInvalid && !m_CredentialsHandle.IsInvalid)
				{
					SslSessionsCache.CacheCredential(m_CredentialsHandle, thumbPrint, m_ProtocolFlags, m_EncryptionPolicy);
				}
			}
		}
		output = securityBuffer2.token;
		return (SecurityStatus)num;
	}

	internal void ProcessHandshakeSuccess()
	{
		if (SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPISecureChannel, m_SecurityContext, ContextAttribute.StreamSizes) is StreamSizes streamSizes)
		{
			try
			{
				m_HeaderSize = streamSizes.header;
				m_TrailerSize = streamSizes.trailer;
				m_MaxDataSize = checked(streamSizes.maximumMessage - (m_HeaderSize + m_TrailerSize));
			}
			catch (Exception exception)
			{
				NclUtilities.IsFatal(exception);
				throw;
			}
		}
		m_ConnectionInfo = SSPIWrapper.QueryContextAttributes(GlobalSSPI.SSPISecureChannel, m_SecurityContext, ContextAttribute.ConnectionInfo) as SslConnectionInfo;
	}

	internal SecurityStatus Encrypt(byte[] buffer, int offset, int size, ref byte[] output, out int resultSize)
	{
		byte[] array;
		try
		{
			if (offset < 0 || offset > ((buffer != null) ? buffer.Length : 0))
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (size < 0 || size > ((buffer != null) ? (buffer.Length - offset) : 0))
			{
				throw new ArgumentOutOfRangeException("size");
			}
			resultSize = 0;
			int num = checked(size + m_HeaderSize + m_TrailerSize);
			array = ((output == null || num > output.Length) ? new byte[num] : output);
			Buffer.BlockCopy(buffer, offset, array, m_HeaderSize, size);
		}
		catch (Exception exception)
		{
			NclUtilities.IsFatal(exception);
			throw;
		}
		SecurityBuffer[] array2 = new SecurityBuffer[4]
		{
			new SecurityBuffer(array, 0, m_HeaderSize, BufferType.Header),
			new SecurityBuffer(array, m_HeaderSize, size, BufferType.Data),
			new SecurityBuffer(array, m_HeaderSize + size, m_TrailerSize, BufferType.Trailer),
			new SecurityBuffer(null, BufferType.Empty)
		};
		int num2 = SSPIWrapper.EncryptMessage(GlobalSSPI.SSPISecureChannel, m_SecurityContext, array2, 0u);
		if (num2 != 0)
		{
			return (SecurityStatus)num2;
		}
		output = array;
		resultSize = array2[0].size + array2[1].size + array2[2].size;
		return SecurityStatus.OK;
	}

	internal SecurityStatus Decrypt(byte[] payload, ref int offset, ref int count)
	{
		if (offset < 0 || offset > ((payload != null) ? payload.Length : 0))
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > ((payload != null) ? (payload.Length - offset) : 0))
		{
			throw new ArgumentOutOfRangeException("count");
		}
		SecurityBuffer[] array = new SecurityBuffer[4]
		{
			new SecurityBuffer(payload, offset, count, BufferType.Data),
			new SecurityBuffer(null, BufferType.Empty),
			new SecurityBuffer(null, BufferType.Empty),
			new SecurityBuffer(null, BufferType.Empty)
		};
		SecurityStatus securityStatus = (SecurityStatus)SSPIWrapper.DecryptMessage(GlobalSSPI.SSPISecureChannel, m_SecurityContext, array, 0u);
		count = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if ((securityStatus == SecurityStatus.OK && array[i].type == BufferType.Data) || (securityStatus != SecurityStatus.OK && array[i].type == BufferType.Extra))
			{
				offset = array[i].offset;
				count = array[i].size;
				break;
			}
		}
		return securityStatus;
	}

	[StorePermission(SecurityAction.Assert, Unrestricted = true)]
	internal unsafe bool VerifyRemoteCertificate(RemoteCertValidationCallback remoteCertValidationCallback, ref ProtocolToken alertToken)
	{
		SslPolicyErrors sslPolicyErrors = SslPolicyErrors.None;
		bool flag = false;
		X509Chain x509Chain = null;
		X509Certificate2 x509Certificate = null;
		try
		{
			x509Certificate = GetRemoteCertificate(out var remoteCertificateStore);
			if (x509Certificate == null)
			{
				sslPolicyErrors |= SslPolicyErrors.RemoteCertificateNotAvailable;
				m_IsRemoteCertificateAvailable = false;
			}
			else
			{
				if (m_IsRemoteCertificateAvailable)
				{
					SslConnectionInfo connectionInfo = m_ConnectionInfo;
					if (connectionInfo == null || (connectionInfo.Protocol & 0x3000) != 0)
					{
						return true;
					}
				}
				m_IsRemoteCertificateAvailable = true;
				x509Chain = new X509Chain();
				x509Chain.ChainPolicy.RevocationMode = (m_CheckCertRevocation ? X509RevocationMode.Online : X509RevocationMode.NoCheck);
				x509Chain.ChainPolicy.RevocationFlag = X509RevocationFlag.ExcludeRoot;
				if (!ServicePointManager.DisableCertificateEKUs)
				{
					x509Chain.ChainPolicy.ApplicationPolicy.Add(m_ServerMode ? m_ClientAuthOid : m_ServerAuthOid);
				}
				if (remoteCertificateStore != null)
				{
					x509Chain.ChainPolicy.ExtraStore.AddRange(remoteCertificateStore);
				}
				if (!x509Chain.Build(x509Certificate) && x509Chain.ChainContext == IntPtr.Zero)
				{
					throw new CryptographicException(Marshal.GetLastWin32Error());
				}
				if (m_CheckCertName)
				{
					uint num = 0u;
					ChainPolicyParameter cpp = new ChainPolicyParameter
					{
						cbSize = ChainPolicyParameter.StructSize,
						dwFlags = 0u
					};
					SSL_EXTRA_CERT_CHAIN_POLICY_PARA sSL_EXTRA_CERT_CHAIN_POLICY_PARA = new SSL_EXTRA_CERT_CHAIN_POLICY_PARA(IsServer);
					cpp.pvExtraPolicyPara = &sSL_EXTRA_CERT_CHAIN_POLICY_PARA;
					fixed (char* hostName = m_HostName)
					{
						sSL_EXTRA_CERT_CHAIN_POLICY_PARA.pwszServerName = hostName;
						cpp.dwFlags |= 4031u;
						SafeFreeCertChain chainContext = new SafeFreeCertChain(x509Chain.ChainContext);
						num = PolicyWrapper.VerifyChainPolicy(chainContext, ref cpp);
						if (num == 2148204815u)
						{
							sslPolicyErrors |= SslPolicyErrors.RemoteCertificateNameMismatch;
						}
					}
				}
				X509ChainStatus[] chainStatus = x509Chain.ChainStatus;
				if (chainStatus != null && chainStatus.Length != 0)
				{
					sslPolicyErrors |= SslPolicyErrors.RemoteCertificateChainErrors;
				}
			}
			flag = remoteCertValidationCallback?.Invoke(m_HostName, x509Certificate, x509Chain, sslPolicyErrors) ?? ((sslPolicyErrors == SslPolicyErrors.RemoteCertificateNotAvailable && !m_RemoteCertRequired) || sslPolicyErrors == SslPolicyErrors.None);
			if (Logging.On)
			{
				LogCertificateValidation(remoteCertValidationCallback, sslPolicyErrors, flag, x509Chain);
			}
			if (System.LocalAppContextSwitches.DontEnableTlsAlerts)
			{
				alertToken = null;
			}
			else if (!flag)
			{
				alertToken = CreateFatalHandshakeAlertToken(sslPolicyErrors, x509Chain);
			}
		}
		finally
		{
			x509Chain?.Reset();
			x509Certificate?.Reset();
		}
		return flag;
	}

	public ProtocolToken CreateFatalHandshakeAlertToken(SslPolicyErrors sslPolicyErrors, X509Chain chain)
	{
		SecurityStatus securityStatus = (SecurityStatus)SSPIWrapper.ApplyAlertToken(alertMessage: sslPolicyErrors switch
		{
			SslPolicyErrors.RemoteCertificateChainErrors => GetAlertMessageFromChain(chain), 
			SslPolicyErrors.RemoteCertificateNameMismatch => TlsAlertMessage.BadCertificate, 
			_ => TlsAlertMessage.CertificateUnknown, 
		}, secModule: GlobalSSPI.SSPISecureChannel, credentialsHandle: ref m_CredentialsHandle, securityContext: m_SecurityContext, alertType: TlsAlertType.Fatal);
		if (securityStatus != SecurityStatus.OK)
		{
			throw new Win32Exception((int)securityStatus);
		}
		return GenerateAlertToken();
	}

	public ProtocolToken CreateShutdownToken()
	{
		SecurityStatus securityStatus = (SecurityStatus)SSPIWrapper.ApplyShutdownToken(GlobalSSPI.SSPISecureChannel, ref m_CredentialsHandle, m_SecurityContext);
		if (securityStatus != SecurityStatus.OK)
		{
			throw new Win32Exception((int)securityStatus);
		}
		return GenerateAlertToken();
	}

	private ProtocolToken GenerateAlertToken()
	{
		byte[] output = null;
		SecurityStatus errorCode = GenerateToken(null, 0, 0, ref output);
		return new ProtocolToken(output, errorCode);
	}

	private static TlsAlertMessage GetAlertMessageFromChain(X509Chain chain)
	{
		X509ChainStatus[] chainStatus = chain.ChainStatus;
		for (int i = 0; i < chainStatus.Length; i++)
		{
			X509ChainStatus x509ChainStatus = chainStatus[i];
			if (x509ChainStatus.Status != X509ChainStatusFlags.NoError)
			{
				if ((x509ChainStatus.Status & (X509ChainStatusFlags.UntrustedRoot | X509ChainStatusFlags.Cyclic | X509ChainStatusFlags.PartialChain)) != X509ChainStatusFlags.NoError)
				{
					return TlsAlertMessage.UnknownCA;
				}
				if ((x509ChainStatus.Status & (X509ChainStatusFlags.Revoked | X509ChainStatusFlags.OfflineRevocation)) != X509ChainStatusFlags.NoError)
				{
					return TlsAlertMessage.CertificateRevoked;
				}
				if ((x509ChainStatus.Status & (X509ChainStatusFlags.NotTimeValid | X509ChainStatusFlags.NotTimeNested | X509ChainStatusFlags.CtlNotTimeValid)) != X509ChainStatusFlags.NoError)
				{
					return TlsAlertMessage.CertificateExpired;
				}
				if ((x509ChainStatus.Status & X509ChainStatusFlags.CtlNotValidForUsage) != X509ChainStatusFlags.NoError)
				{
					return TlsAlertMessage.UnsupportedCert;
				}
				if (((x509ChainStatus.Status & (X509ChainStatusFlags.NotSignatureValid | X509ChainStatusFlags.InvalidExtension | X509ChainStatusFlags.InvalidPolicyConstraints | X509ChainStatusFlags.CtlNotSignatureValid)) | X509ChainStatusFlags.NoIssuanceChainPolicy | X509ChainStatusFlags.NotValidForUsage) != X509ChainStatusFlags.NoError)
				{
					return TlsAlertMessage.BadCertificate;
				}
				return TlsAlertMessage.CertificateUnknown;
			}
		}
		return TlsAlertMessage.BadCertificate;
	}

	private void LogCertificateValidation(RemoteCertValidationCallback remoteCertValidationCallback, SslPolicyErrors sslPolicyErrors, bool success, X509Chain chain)
	{
		if (sslPolicyErrors != SslPolicyErrors.None)
		{
			Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_remote_cert_has_errors"));
			if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNotAvailable) != SslPolicyErrors.None)
			{
				Logging.PrintInfo(Logging.Web, this, "\t" + SR.GetString("net_log_remote_cert_not_available"));
			}
			if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNameMismatch) != SslPolicyErrors.None)
			{
				Logging.PrintInfo(Logging.Web, this, "\t" + SR.GetString("net_log_remote_cert_name_mismatch"));
			}
			if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateChainErrors) != SslPolicyErrors.None)
			{
				X509ChainStatus[] chainStatus = chain.ChainStatus;
				foreach (X509ChainStatus x509ChainStatus in chainStatus)
				{
					Logging.PrintInfo(Logging.Web, this, "\t" + x509ChainStatus.StatusInformation);
				}
			}
		}
		if (success)
		{
			if (remoteCertValidationCallback != null)
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_remote_cert_user_declared_valid"));
			}
			else
			{
				Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_remote_cert_has_no_errors"));
			}
		}
		else if (remoteCertValidationCallback != null)
		{
			Logging.PrintInfo(Logging.Web, this, SR.GetString("net_log_remote_cert_user_declared_invalid"));
		}
	}
}
