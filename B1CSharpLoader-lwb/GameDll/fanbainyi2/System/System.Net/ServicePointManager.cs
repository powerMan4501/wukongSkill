using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Net.Configuration;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Threading;

namespace System.Net;

public class ServicePointManager
{
	public const int DefaultNonPersistentConnectionLimit = 4;

	public const int DefaultPersistentConnectionLimit = 2;

	private const int DefaultAspPersistentConnectionLimit = 10;

	internal static readonly string SpecialConnectGroupName = "/.NET/NetClasses/HttpWebRequest/CONNECT__Group$$/";

	internal static readonly TimerThread.Callback s_IdleServicePointTimeoutDelegate = IdleServicePointTimeoutCallback;

	private static Hashtable s_ServicePointTable = new Hashtable(10);

	private static volatile TimerThread.Queue s_ServicePointIdlingQueue = TimerThread.GetOrCreateQueue(100000);

	private static int s_MaxServicePoints = 0;

	private static volatile CertPolicyValidationCallback s_CertPolicyValidationCallback = new CertPolicyValidationCallback();

	private static volatile ServerCertValidationCallback s_ServerCertValidationCallback = null;

	private static SecurityProtocolType s_SecurityProtocolType;

	private static bool s_reusePort;

	private static bool? s_reusePortSupported = null;

	private static bool s_disableStrongCrypto;

	private static bool s_disableSendAuxRecord;

	private static bool s_disableSystemDefaultTlsVersions;

	private static SslProtocols s_defaultSslProtocols;

	private static bool s_disableCertificateEKUs;

	private static bool s_useHttpPipeliningAndBufferPooling;

	private static bool s_useSafeSynchronousClose;

	private static bool s_useStrictRfcInterimResponseHandling;

	private static bool s_allowDangerousUnicodeDecompositions;

	private static bool s_useStrictIPv6AddressParsing;

	private static bool s_allowAllUriEncodingExpansion;

	private static bool s_allowFullDomainLiterals;

	private static bool s_finishProxyTunnelConnectionEarly;

	private static bool s_allowNewLineInFtpCommand;

	private static volatile Hashtable s_ConfigTable = null;

	private static volatile int s_ConnectionLimit = PersistentConnectionLimit;

	internal static volatile bool s_UseTcpKeepAlive = false;

	internal static volatile int s_TcpKeepAliveTime;

	internal static volatile int s_TcpKeepAliveInterval;

	private static volatile bool s_UserChangedLimit;

	private static object s_configurationLoadedLock = new object();

	private static volatile bool s_configurationLoaded = false;

	private const string RegistryGlobalStrongCryptoName = "SchUseStrongCrypto";

	private const string RegistryGlobalReusePortName = "HWRPortReuseOnSocketBind";

	private const string RegistryGlobalSendAuxRecordName = "SchSendAuxRecord";

	private const string RegistryLocalSendAuxRecordName = "System.Net.ServicePointManager.SchSendAuxRecord";

	private const string RegistryGlobalSystemDefaultTlsVersionsName = "SystemDefaultTlsVersions";

	private const string RegistryLocalSystemDefaultTlsVersionsName = "System.Net.ServicePointManager.SystemDefaultTlsVersions";

	private const string RegistryLocalSecureProtocolName = "System.Net.ServicePointManager.SecurityProtocol";

	private const string RegistryGlobalRequireCertificateEKUs = "RequireCertificateEKUs";

	private const string RegistryLocalRequireCertificateEKUs = "System.Net.ServicePointManager.RequireCertificateEKUs";

	private const string RegistryGlobalUseHttpPipeliningAndBufferPooling = "UseHttpPipeliningAndBufferPooling";

	private const string RegistryLocalUseHttpPipeliningAndBufferPooling = "System.Net.ServicePointManager.UseHttpPipeliningAndBufferPooling";

	private const string RegistryGlobalUseSafeSynchronousClose = "UseSafeSynchronousClose";

	private const string RegistryLocalUseSafeSynchronousClose = "System.Net.ServicePointManager.UseSafeSynchronousClose";

	private const string RegistryGlobalUseStrictRfcInterimResponseHandling = "UseStrictRfcInterimResponseHandling";

	private const string RegistryLocalUseStrictRfcInterimResponseHandling = "System.Net.ServicePointManager.UseStrictRfcInterimResponseHandling";

	private const string RegistryGlobalAllowDangerousUnicodeDecompositions = "AllowDangerousUnicodeDecompositions";

	private const string RegistryLocalAllowDangerousUnicodeDecompositions = "System.Uri.AllowDangerousUnicodeDecompositions";

	private const string RegistryGlobalUseStrictIPv6AddressParsing = "UseStrictIPv6AddressParsing";

	private const string RegistryLocalUseStrictIPv6AddressParsing = "System.Uri.UseStrictIPv6AddressParsing";

	private const string RegistryGlobalAllowAllUriEncodingExpansion = "AllowAllUriEncodingExpansion";

	private const string RegistryLocalAllowAllUriEncodingExpansion = "System.Uri.AllowAllUriEncodingExpansion";

	private const string RegistryGlobalAllowFullDomainLiterals = "AllowFullDomainLiterals";

	private const string RegistryLocalAllowFullDomainLiterals = "System.Net.AllowFullDomainLiterals";

	private const string RegistryGlobalFinishProxyTunnelConnectionEarly = "FinishProxyTunnelConnectionEarly";

	private const string RegistryLocalFinishProxyTunnelConnectionEarly = "System.Net.ServicePointManager.FinishProxyTunnelConnectionEarly";

	private const string RegistryGlobalAllowNewLineInFtpCommand = "AllowNewLineInFtpCommand";

	private const string RegistryLocalAllowNewLineInFtpCommand = "System.Net.AllowNewLineInFtpCommand";

	private static int InternalConnectionLimit
	{
		get
		{
			if (s_ConfigTable == null)
			{
				s_ConfigTable = ConfigTable;
			}
			return s_ConnectionLimit;
		}
		set
		{
			if (s_ConfigTable == null)
			{
				s_ConfigTable = ConfigTable;
			}
			s_UserChangedLimit = true;
			s_ConnectionLimit = value;
		}
	}

	private static int PersistentConnectionLimit
	{
		get
		{
			if (ComNetOS.IsAspNetServer)
			{
				return 10;
			}
			return 2;
		}
	}

	private static Hashtable ConfigTable
	{
		get
		{
			if (s_ConfigTable == null)
			{
				lock (s_ServicePointTable)
				{
					if (s_ConfigTable == null)
					{
						ConnectionManagementSectionInternal section = ConnectionManagementSectionInternal.GetSection();
						Hashtable hashtable = null;
						if (section != null)
						{
							hashtable = section.ConnectionManagement;
						}
						if (hashtable == null)
						{
							hashtable = new Hashtable();
						}
						if (hashtable.ContainsKey("*"))
						{
							int num = (int)hashtable["*"];
							if (num < 1)
							{
								num = PersistentConnectionLimit;
							}
							s_ConnectionLimit = num;
						}
						s_ConfigTable = hashtable;
					}
				}
			}
			return s_ConfigTable;
		}
	}

	internal static TimerThread.Callback IdleServicePointTimeoutDelegate => s_IdleServicePointTimeoutDelegate;

	public static SecurityProtocolType SecurityProtocol
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_SecurityProtocolType;
		}
		set
		{
			EnsureConfigurationLoaded();
			ValidateSecurityProtocol(value);
			s_SecurityProtocolType = value;
		}
	}

	internal static bool DisableStrongCrypto
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_disableStrongCrypto;
		}
	}

	internal static bool DisableSystemDefaultTlsVersions
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_disableSystemDefaultTlsVersions;
		}
	}

	internal static bool DisableSendAuxRecord
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_disableSendAuxRecord;
		}
	}

	internal static bool DisableCertificateEKUs
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_disableCertificateEKUs;
		}
	}

	internal static SslProtocols DefaultSslProtocols
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_defaultSslProtocols;
		}
	}

	internal static bool UseHttpPipeliningAndBufferPooling
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_useHttpPipeliningAndBufferPooling;
		}
	}

	internal static bool UseSafeSynchronousClose
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_useSafeSynchronousClose;
		}
	}

	internal static bool UseStrictRfcInterimResponseHandling
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_useStrictRfcInterimResponseHandling;
		}
	}

	internal static bool AllowDangerousUnicodeDecompositions
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_allowDangerousUnicodeDecompositions;
		}
	}

	internal static bool AllowFullDomainLiterals
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_allowFullDomainLiterals;
		}
	}

	internal static bool UseStrictIPv6AddressParsing
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_useStrictIPv6AddressParsing;
		}
	}

	internal static bool AllowAllUriEncodingExpansion
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_allowAllUriEncodingExpansion;
		}
	}

	internal static bool FinishProxyTunnelConnectionEarly
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_finishProxyTunnelConnectionEarly;
		}
	}

	internal static bool AllowNewLineInFtpCommand
	{
		get
		{
			EnsureConfigurationLoaded();
			return s_allowNewLineInFtpCommand;
		}
	}

	public static int MaxServicePoints
	{
		get
		{
			return s_MaxServicePoints;
		}
		set
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			if (!ValidationHelper.ValidateRange(value, 0, int.MaxValue))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			s_MaxServicePoints = value;
		}
	}

	public static int DefaultConnectionLimit
	{
		get
		{
			return InternalConnectionLimit;
		}
		set
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			if (value > 0)
			{
				InternalConnectionLimit = value;
				return;
			}
			throw new ArgumentOutOfRangeException("value", SR.GetString("net_toosmall"));
		}
	}

	public static int MaxServicePointIdleTime
	{
		get
		{
			return s_ServicePointIdlingQueue.Duration;
		}
		set
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			if (!ValidationHelper.ValidateRange(value, -1, int.MaxValue))
			{
				throw new ArgumentOutOfRangeException("value");
			}
			if (s_ServicePointIdlingQueue.Duration != value)
			{
				s_ServicePointIdlingQueue = TimerThread.GetOrCreateQueue(value);
			}
		}
	}

	public static bool UseNagleAlgorithm
	{
		get
		{
			return SettingsSectionInternal.Section.UseNagleAlgorithm;
		}
		set
		{
			SettingsSectionInternal.Section.UseNagleAlgorithm = value;
		}
	}

	public static bool Expect100Continue
	{
		get
		{
			return SettingsSectionInternal.Section.Expect100Continue;
		}
		set
		{
			SettingsSectionInternal.Section.Expect100Continue = value;
		}
	}

	public static bool EnableDnsRoundRobin
	{
		get
		{
			return SettingsSectionInternal.Section.EnableDnsRoundRobin;
		}
		set
		{
			SettingsSectionInternal.Section.EnableDnsRoundRobin = value;
		}
	}

	public static int DnsRefreshTimeout
	{
		get
		{
			return SettingsSectionInternal.Section.DnsRefreshTimeout;
		}
		set
		{
			if (value < -1)
			{
				SettingsSectionInternal.Section.DnsRefreshTimeout = -1;
			}
			else
			{
				SettingsSectionInternal.Section.DnsRefreshTimeout = value;
			}
		}
	}

	[Obsolete("CertificatePolicy is obsoleted for this type, please use ServerCertificateValidationCallback instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static ICertificatePolicy CertificatePolicy
	{
		get
		{
			return GetLegacyCertificatePolicy();
		}
		set
		{
			ExceptionHelper.UnmanagedPermission.Demand();
			s_CertPolicyValidationCallback = new CertPolicyValidationCallback(value);
		}
	}

	internal static CertPolicyValidationCallback CertPolicyValidationCallback => s_CertPolicyValidationCallback;

	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		get
		{
			if (s_ServerCertValidationCallback == null)
			{
				return null;
			}
			return s_ServerCertValidationCallback.ValidationCallback;
		}
		set
		{
			ExceptionHelper.InfrastructurePermission.Demand();
			if (value == null)
			{
				s_ServerCertValidationCallback = null;
			}
			else
			{
				s_ServerCertValidationCallback = new ServerCertValidationCallback(value);
			}
		}
	}

	internal static ServerCertValidationCallback ServerCertValidationCallback => s_ServerCertValidationCallback;

	public static bool ReusePort
	{
		get
		{
			return s_reusePort;
		}
		set
		{
			s_reusePort = value;
		}
	}

	internal static bool? ReusePortSupported
	{
		get
		{
			return s_reusePortSupported;
		}
		set
		{
			s_reusePortSupported = value;
		}
	}

	public static bool CheckCertificateRevocationList
	{
		get
		{
			return SettingsSectionInternal.Section.CheckCertificateRevocationList;
		}
		set
		{
			ExceptionHelper.UnmanagedPermission.Demand();
			SettingsSectionInternal.Section.CheckCertificateRevocationList = value;
		}
	}

	public static EncryptionPolicy EncryptionPolicy => SettingsSectionInternal.Section.EncryptionPolicy;

	internal static bool CheckCertificateName => SettingsSectionInternal.Section.CheckCertificateName;

	[Conditional("DEBUG")]
	internal static void DebugMembers(int requestHash)
	{
		try
		{
			foreach (WeakReference item in s_ServicePointTable)
			{
				if (item != null && item.IsAlive)
				{
					ServicePoint servicePoint = (ServicePoint)item.Target;
				}
				else
				{
					ServicePoint servicePoint = null;
				}
			}
		}
		catch (Exception ex)
		{
			if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
			{
				throw;
			}
		}
	}

	private static void IdleServicePointTimeoutCallback(TimerThread.Timer timer, int timeNoticed, object context)
	{
		ServicePoint servicePoint = (ServicePoint)context;
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_closed_idle", "ServicePoint", servicePoint.GetHashCode()));
		}
		lock (s_ServicePointTable)
		{
			s_ServicePointTable.Remove(servicePoint.LookupString);
		}
		servicePoint.ReleaseAllConnectionGroups();
	}

	private ServicePointManager()
	{
	}

	private static void ValidateSecurityProtocol(SecurityProtocolType value)
	{
		SecurityProtocolType securityProtocolType = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls13;
		if ((value & ~securityProtocolType) != SecurityProtocolType.SystemDefault)
		{
			throw new NotSupportedException(SR.GetString("net_securityprotocolnotsupported"));
		}
	}

	internal static ICertificatePolicy GetLegacyCertificatePolicy()
	{
		if (s_CertPolicyValidationCallback == null)
		{
			return null;
		}
		return s_CertPolicyValidationCallback.CertificatePolicy;
	}

	internal static string MakeQueryString(Uri address)
	{
		if (address.IsDefaultPort)
		{
			return address.Scheme + "://" + address.DnsSafeHost;
		}
		return address.Scheme + "://" + address.DnsSafeHost + ":" + address.Port;
	}

	internal static string MakeQueryString(Uri address1, bool isProxy)
	{
		if (isProxy)
		{
			return MakeQueryString(address1) + "://proxy";
		}
		return MakeQueryString(address1);
	}

	public static ServicePoint FindServicePoint(Uri address)
	{
		return FindServicePoint(address, null);
	}

	public static ServicePoint FindServicePoint(string uriString, IWebProxy proxy)
	{
		Uri address = new Uri(uriString);
		return FindServicePoint(address, proxy);
	}

	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
	{
		HttpAbortDelegate abortDelegate = null;
		int abortState = 0;
		ProxyChain chain;
		return FindServicePoint(address, proxy, out chain, ref abortDelegate, ref abortState);
	}

	internal static ServicePoint FindServicePoint(Uri address, IWebProxy proxy, out ProxyChain chain, ref HttpAbortDelegate abortDelegate, ref int abortState)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		bool isProxyServicePoint = false;
		chain = null;
		Uri uri = null;
		if (proxy != null && !address.IsLoopback)
		{
			if (proxy is IAutoWebProxy autoWebProxy)
			{
				chain = autoWebProxy.GetProxies(address);
				abortDelegate = chain.HttpAbortDelegate;
				try
				{
					Thread.MemoryBarrier();
					if (abortState != 0)
					{
						Exception ex = new WebException(NetRes.GetWebStatusString(WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
						throw ex;
					}
					chain.Enumerator.MoveNext();
					uri = chain.Enumerator.Current;
				}
				finally
				{
					abortDelegate = null;
				}
			}
			else if (!proxy.IsBypassed(address))
			{
				uri = proxy.GetProxy(address);
			}
			if (uri != null)
			{
				address = uri;
				isProxyServicePoint = true;
			}
		}
		return FindServicePointHelper(address, isProxyServicePoint);
	}

	internal static ServicePoint FindServicePoint(ProxyChain chain)
	{
		if (!chain.Enumerator.MoveNext())
		{
			return null;
		}
		Uri current = chain.Enumerator.Current;
		return FindServicePointHelper((current == null) ? chain.Destination : current, current != null);
	}

	private static ServicePoint FindServicePointHelper(Uri address, bool isProxyServicePoint)
	{
		if (isProxyServicePoint && address.Scheme != Uri.UriSchemeHttp)
		{
			Exception ex = new NotSupportedException(SR.GetString("net_proxyschemenotsupported", address.Scheme));
			throw ex;
		}
		string text = MakeQueryString(address, isProxyServicePoint);
		ServicePoint servicePoint = null;
		lock (s_ServicePointTable)
		{
			if (s_ServicePointTable[text] is WeakReference weakReference)
			{
				servicePoint = (ServicePoint)weakReference.Target;
			}
			if (servicePoint == null)
			{
				if (s_MaxServicePoints > 0 && s_ServicePointTable.Count >= s_MaxServicePoints)
				{
					Exception ex2 = new InvalidOperationException(SR.GetString("net_maxsrvpoints"));
					throw ex2;
				}
				int defaultConnectionLimit = InternalConnectionLimit;
				string key = MakeQueryString(address);
				bool userChangedLimit = s_UserChangedLimit;
				if (ConfigTable.ContainsKey(key))
				{
					defaultConnectionLimit = (int)ConfigTable[key];
					userChangedLimit = true;
				}
				servicePoint = new ServicePoint(address, s_ServicePointIdlingQueue, defaultConnectionLimit, text, userChangedLimit, isProxyServicePoint);
				WeakReference value = new WeakReference(servicePoint);
				s_ServicePointTable[text] = value;
			}
		}
		return servicePoint;
	}

	internal static ServicePoint FindServicePoint(string host, int port)
	{
		if (host == null)
		{
			throw new ArgumentNullException("address");
		}
		string text = null;
		bool proxyServicePoint = false;
		text = "ByHost:" + host + ":" + port.ToString(CultureInfo.InvariantCulture);
		ServicePoint servicePoint = null;
		lock (s_ServicePointTable)
		{
			if (s_ServicePointTable[text] is WeakReference weakReference)
			{
				servicePoint = (ServicePoint)weakReference.Target;
			}
			if (servicePoint == null)
			{
				if (s_MaxServicePoints > 0 && s_ServicePointTable.Count >= s_MaxServicePoints)
				{
					Exception ex = new InvalidOperationException(SR.GetString("net_maxsrvpoints"));
					throw ex;
				}
				int defaultConnectionLimit = InternalConnectionLimit;
				bool userChangedLimit = s_UserChangedLimit;
				string key = host + ":" + port.ToString(CultureInfo.InvariantCulture);
				if (ConfigTable.ContainsKey(key))
				{
					defaultConnectionLimit = (int)ConfigTable[key];
					userChangedLimit = true;
				}
				servicePoint = new ServicePoint(host, port, s_ServicePointIdlingQueue, defaultConnectionLimit, text, userChangedLimit, proxyServicePoint);
				WeakReference value = new WeakReference(servicePoint);
				s_ServicePointTable[text] = value;
			}
		}
		return servicePoint;
	}

	[FriendAccessAllowed]
	internal static void CloseConnectionGroups(string connectionGroupName)
	{
		ServicePoint servicePoint = null;
		lock (s_ServicePointTable)
		{
			foreach (DictionaryEntry item in s_ServicePointTable)
			{
				if (item.Value is WeakReference weakReference)
				{
					((ServicePoint)weakReference.Target)?.CloseConnectionGroupInternal(connectionGroupName);
				}
			}
		}
	}

	public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
	{
		if (enabled)
		{
			s_UseTcpKeepAlive = true;
			if (keepAliveTime <= 0)
			{
				throw new ArgumentOutOfRangeException("keepAliveTime");
			}
			if (keepAliveInterval <= 0)
			{
				throw new ArgumentOutOfRangeException("keepAliveInterval");
			}
			s_TcpKeepAliveTime = keepAliveTime;
			s_TcpKeepAliveInterval = keepAliveInterval;
		}
		else
		{
			s_UseTcpKeepAlive = false;
			s_TcpKeepAliveTime = 0;
			s_TcpKeepAliveInterval = 0;
		}
	}

	private static void LoadConfiguration()
	{
		s_reusePort = TryInitialize(LoadReusePortConfiguration, fallbackDefault: false);
		s_useHttpPipeliningAndBufferPooling = TryInitialize(LoadUseHttpPipeliningAndBufferPoolingConfiguration, fallbackDefault: true);
		s_useSafeSynchronousClose = TryInitialize(LoadUseSafeSynchronousClose, fallbackDefault: true);
		s_useStrictRfcInterimResponseHandling = TryInitialize(LoadUseStrictRfcInterimResponseHandlingConfiguration, fallbackDefault: true);
		s_allowDangerousUnicodeDecompositions = TryInitialize(LoadAllowDangerousUnicodeDecompositionsConfiguration, fallbackDefault: false);
		s_useStrictIPv6AddressParsing = TryInitialize(LoadUseStrictIPv6AddressParsingConfiguration, fallbackDefault: true);
		s_allowAllUriEncodingExpansion = TryInitialize(LoadAllowAllUriEncodingExpansionConfiguration, fallbackDefault: false);
		s_allowFullDomainLiterals = TryInitialize(LoadAllowFullDomainLiteralsConfiguration, fallbackDefault: false);
		s_finishProxyTunnelConnectionEarly = TryInitialize(LoadFinishProxyTunnelConnectionEarlyConfiguration, fallbackDefault: true);
		s_allowNewLineInFtpCommand = TryInitialize(LoadAllowNewLineInFtpCommandConfiguration, fallbackDefault: false);
		s_disableStrongCrypto = TryInitialize(LoadDisableStrongCryptoConfiguration, fallbackDefault: true);
		s_disableSendAuxRecord = TryInitialize(LoadDisableSendAuxRecordConfiguration, fallbackDefault: false);
		s_disableSystemDefaultTlsVersions = TryInitialize(LoadDisableSystemDefaultTlsVersionsConfiguration, fallbackDefault: true);
		s_disableCertificateEKUs = TryInitialize(LoadDisableCertificateEKUsConfiguration, fallbackDefault: false);
		s_defaultSslProtocols = TryInitialize(LoadSecureProtocolConfiguration, SslProtocols.Default);
		s_SecurityProtocolType = (SecurityProtocolType)s_defaultSslProtocols;
	}

	private static bool LoadDisableStrongCryptoConfiguration(bool disable)
	{
		int num = 0;
		if (System.LocalAppContextSwitches.DontEnableSchUseStrongCrypto)
		{
			num = RegistryConfiguration.GlobalConfigReadInt("SchUseStrongCrypto", 0);
			disable = num != 1;
		}
		else
		{
			num = RegistryConfiguration.GlobalConfigReadInt("SchUseStrongCrypto", 1);
			disable = num == 0;
		}
		return disable;
	}

	private static bool LoadDisableSendAuxRecordConfiguration(bool disable)
	{
		if (System.LocalAppContextSwitches.DontEnableSchSendAuxRecord)
		{
			return true;
		}
		if (RegistryConfiguration.AppConfigReadInt("System.Net.ServicePointManager.SchSendAuxRecord", 1) == 0)
		{
			return true;
		}
		if (RegistryConfiguration.GlobalConfigReadInt("SchSendAuxRecord", 1) == 0)
		{
			return true;
		}
		return disable;
	}

	private static bool LoadDisableSystemDefaultTlsVersionsConfiguration(bool disable)
	{
		if (System.LocalAppContextSwitches.DontEnableSystemDefaultTlsVersions)
		{
			int num = RegistryConfiguration.GlobalConfigReadInt("SystemDefaultTlsVersions", 0);
			disable = num != 1;
		}
		else
		{
			int num2 = RegistryConfiguration.GlobalConfigReadInt("SystemDefaultTlsVersions", 1);
			disable = num2 == 0;
		}
		if (!disable)
		{
			int num3 = RegistryConfiguration.AppConfigReadInt("System.Net.ServicePointManager.SystemDefaultTlsVersions", 1);
			disable = num3 != 1;
		}
		return disable;
	}

	private static SslProtocols LoadSecureProtocolConfiguration(SslProtocols defaultValue)
	{
		defaultValue = (s_disableSystemDefaultTlsVersions ? (s_disableStrongCrypto ? SslProtocols.Default : (SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Tls13)) : SslProtocols.None);
		if (!s_disableStrongCrypto || !s_disableSystemDefaultTlsVersions)
		{
			string value = RegistryConfiguration.AppConfigReadString("System.Net.ServicePointManager.SecurityProtocol", null);
			if (Enum.TryParse<SecurityProtocolType>(value, out var result))
			{
				ValidateSecurityProtocol(result);
				defaultValue = (SslProtocols)result;
			}
		}
		return defaultValue;
	}

	private static bool LoadReusePortConfiguration(bool reusePortInternal)
	{
		int num = 0;
		num = RegistryConfiguration.GlobalConfigReadInt("HWRPortReuseOnSocketBind", 0);
		if (num == 1)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Web, typeof(ServicePointManager), SR.GetString("net_log_set_socketoption_reuseport_default_on"));
			}
			reusePortInternal = true;
		}
		return reusePortInternal;
	}

	private static bool LoadDisableCertificateEKUsConfiguration(bool disable)
	{
		if (System.LocalAppContextSwitches.DontCheckCertificateEKUs)
		{
			return true;
		}
		if (RegistryConfiguration.AppConfigReadInt("System.Net.ServicePointManager.RequireCertificateEKUs", 1) == 0)
		{
			return true;
		}
		if (RegistryConfiguration.GlobalConfigReadInt("RequireCertificateEKUs", 1) == 0)
		{
			return true;
		}
		return disable;
	}

	private static bool LoadUseHttpPipeliningAndBufferPoolingConfiguration(bool useFeature)
	{
		if (RegistryConfiguration.AppConfigReadInt("System.Net.ServicePointManager.UseHttpPipeliningAndBufferPooling", 1) == 0)
		{
			return false;
		}
		if (RegistryConfiguration.GlobalConfigReadInt("UseHttpPipeliningAndBufferPooling", 1) == 0)
		{
			return false;
		}
		return useFeature;
	}

	private static bool LoadUseSafeSynchronousClose(bool useFeature)
	{
		if (RegistryConfiguration.AppConfigReadInt("System.Net.ServicePointManager.UseSafeSynchronousClose", 1) == 0)
		{
			return false;
		}
		if (RegistryConfiguration.GlobalConfigReadInt("UseSafeSynchronousClose", 1) == 0)
		{
			return false;
		}
		return useFeature;
	}

	private static bool LoadUseStrictRfcInterimResponseHandlingConfiguration(bool useFeature)
	{
		if (RegistryConfiguration.AppConfigReadInt("System.Net.ServicePointManager.UseStrictRfcInterimResponseHandling", 1) == 0)
		{
			return false;
		}
		if (RegistryConfiguration.GlobalConfigReadInt("UseStrictRfcInterimResponseHandling", 1) == 0)
		{
			return false;
		}
		return useFeature;
	}

	private static bool LoadAllowDangerousUnicodeDecompositionsConfiguration(bool useFeature)
	{
		int num = RegistryConfiguration.AppConfigReadInt("System.Uri.AllowDangerousUnicodeDecompositions", 0);
		if (num == 1)
		{
			return true;
		}
		num = RegistryConfiguration.GlobalConfigReadInt("AllowDangerousUnicodeDecompositions", 0);
		if (num == 1)
		{
			return true;
		}
		return useFeature;
	}

	private static bool LoadUseStrictIPv6AddressParsingConfiguration(bool useFeature)
	{
		if (RegistryConfiguration.AppConfigReadInt("System.Uri.UseStrictIPv6AddressParsing", 1) == 0)
		{
			return false;
		}
		if (RegistryConfiguration.GlobalConfigReadInt("UseStrictIPv6AddressParsing", 1) == 0)
		{
			return false;
		}
		return useFeature;
	}

	private static bool LoadAllowAllUriEncodingExpansionConfiguration(bool useFeature)
	{
		int num = RegistryConfiguration.AppConfigReadInt("System.Uri.AllowAllUriEncodingExpansion", 0);
		if (num == 1)
		{
			return true;
		}
		num = RegistryConfiguration.GlobalConfigReadInt("AllowAllUriEncodingExpansion", 0);
		if (num == 1)
		{
			return true;
		}
		return useFeature;
	}

	private static bool LoadAllowFullDomainLiteralsConfiguration(bool useFeature)
	{
		int num = RegistryConfiguration.AppConfigReadInt("System.Net.AllowFullDomainLiterals", 0);
		if (num == 1)
		{
			return true;
		}
		num = RegistryConfiguration.GlobalConfigReadInt("AllowFullDomainLiterals", 0);
		if (num == 1)
		{
			return true;
		}
		return useFeature;
	}

	private static bool LoadFinishProxyTunnelConnectionEarlyConfiguration(bool useFeature)
	{
		if (RegistryConfiguration.AppConfigReadInt("System.Net.ServicePointManager.FinishProxyTunnelConnectionEarly", 1) == 0)
		{
			return false;
		}
		if (RegistryConfiguration.GlobalConfigReadInt("FinishProxyTunnelConnectionEarly", 1) == 0)
		{
			return false;
		}
		return useFeature;
	}

	private static bool LoadAllowNewLineInFtpCommandConfiguration(bool useFeature)
	{
		int num = RegistryConfiguration.AppConfigReadInt("System.Net.AllowNewLineInFtpCommand", 0);
		if (num == 1)
		{
			return true;
		}
		num = RegistryConfiguration.GlobalConfigReadInt("AllowNewLineInFtpCommand", 0);
		if (num == 1)
		{
			return true;
		}
		return useFeature;
	}

	private static void EnsureConfigurationLoaded()
	{
		if (s_configurationLoaded)
		{
			return;
		}
		lock (s_configurationLoadedLock)
		{
			if (!s_configurationLoaded)
			{
				LoadConfiguration();
				s_configurationLoaded = true;
			}
		}
	}

	private static T TryInitialize<T>(Func<T, T> loadConfiguration, T fallbackDefault)
	{
		try
		{
			return loadConfiguration(fallbackDefault);
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
			return fallbackDefault;
		}
	}
}
