using System.Configuration;
using System.Net.Security;
using System.Net.Sockets;
using System.Threading;

namespace System.Net.Configuration;

internal sealed class SettingsSectionInternal
{
	private static object s_InternalSyncObject;

	private static volatile SettingsSectionInternal s_settings;

	private bool alwaysUseCompletionPortsForAccept;

	private bool alwaysUseCompletionPortsForConnect;

	private bool checkCertificateName;

	private bool checkCertificateRevocationList;

	private int defaultCredentialsHandleCacheSize;

	private int autoConfigUrlRetryInterval;

	private int downloadTimeout;

	private int dnsRefreshTimeout;

	private bool enableDnsRoundRobin;

	private EncryptionPolicy encryptionPolicy;

	private bool expect100Continue;

	private IPProtectionLevel ipProtectionLevel;

	private bool ipv6Enabled;

	private int maximumResponseHeadersLength;

	private int maximumErrorResponseLength;

	private int maximumUnauthorizedUploadLength;

	private bool useUnsafeHeaderParsing;

	private bool useNagleAlgorithm;

	private bool performanceCountersEnabled;

	private bool httpListenerUnescapeRequestUrl;

	private long[] httpListenerTimeouts;

	internal static SettingsSectionInternal Section
	{
		get
		{
			if (s_settings == null)
			{
				lock (InternalSyncObject)
				{
					if (s_settings == null)
					{
						s_settings = new SettingsSectionInternal((SettingsSection)System.Configuration.PrivilegedConfigurationManager.GetSection(ConfigurationStrings.SettingsSectionPath));
					}
				}
			}
			return s_settings;
		}
	}

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	internal bool AlwaysUseCompletionPortsForAccept => alwaysUseCompletionPortsForAccept;

	internal bool AlwaysUseCompletionPortsForConnect => alwaysUseCompletionPortsForConnect;

	internal int AutoConfigUrlRetryInterval => autoConfigUrlRetryInterval;

	internal bool CheckCertificateName => checkCertificateName;

	internal bool CheckCertificateRevocationList
	{
		get
		{
			return checkCertificateRevocationList;
		}
		set
		{
			checkCertificateRevocationList = value;
		}
	}

	internal int DefaultCredentialsHandleCacheSize
	{
		get
		{
			return defaultCredentialsHandleCacheSize;
		}
		set
		{
			defaultCredentialsHandleCacheSize = value;
		}
	}

	internal int DnsRefreshTimeout
	{
		get
		{
			return dnsRefreshTimeout;
		}
		set
		{
			dnsRefreshTimeout = value;
		}
	}

	internal int DownloadTimeout => downloadTimeout;

	internal bool EnableDnsRoundRobin
	{
		get
		{
			return enableDnsRoundRobin;
		}
		set
		{
			enableDnsRoundRobin = value;
		}
	}

	internal EncryptionPolicy EncryptionPolicy => encryptionPolicy;

	internal bool Expect100Continue
	{
		get
		{
			return expect100Continue;
		}
		set
		{
			expect100Continue = value;
		}
	}

	internal IPProtectionLevel IPProtectionLevel => ipProtectionLevel;

	internal bool Ipv6Enabled => ipv6Enabled;

	internal int MaximumResponseHeadersLength
	{
		get
		{
			return maximumResponseHeadersLength;
		}
		set
		{
			maximumResponseHeadersLength = value;
		}
	}

	internal int MaximumUnauthorizedUploadLength => maximumUnauthorizedUploadLength;

	internal int MaximumErrorResponseLength
	{
		get
		{
			return maximumErrorResponseLength;
		}
		set
		{
			maximumErrorResponseLength = value;
		}
	}

	internal bool UseUnsafeHeaderParsing => useUnsafeHeaderParsing;

	internal bool UseNagleAlgorithm
	{
		get
		{
			return useNagleAlgorithm;
		}
		set
		{
			useNagleAlgorithm = value;
		}
	}

	internal bool PerformanceCountersEnabled => performanceCountersEnabled;

	internal bool HttpListenerUnescapeRequestUrl => httpListenerUnescapeRequestUrl;

	internal long[] HttpListenerTimeouts => httpListenerTimeouts;

	internal UnicodeDecodingConformance WebUtilityUnicodeDecodingConformance { get; private set; }

	internal UnicodeEncodingConformance WebUtilityUnicodeEncodingConformance { get; private set; }

	internal SettingsSectionInternal(SettingsSection section)
	{
		if (section == null)
		{
			section = new SettingsSection();
		}
		alwaysUseCompletionPortsForConnect = section.Socket.AlwaysUseCompletionPortsForConnect;
		alwaysUseCompletionPortsForAccept = section.Socket.AlwaysUseCompletionPortsForAccept;
		checkCertificateName = section.ServicePointManager.CheckCertificateName;
		checkCertificateRevocationList = section.ServicePointManager.CheckCertificateRevocationList;
		dnsRefreshTimeout = section.ServicePointManager.DnsRefreshTimeout;
		ipProtectionLevel = section.Socket.IPProtectionLevel;
		ipv6Enabled = section.Ipv6.Enabled;
		enableDnsRoundRobin = section.ServicePointManager.EnableDnsRoundRobin;
		encryptionPolicy = section.ServicePointManager.EncryptionPolicy;
		expect100Continue = section.ServicePointManager.Expect100Continue;
		maximumUnauthorizedUploadLength = section.HttpWebRequest.MaximumUnauthorizedUploadLength;
		maximumResponseHeadersLength = section.HttpWebRequest.MaximumResponseHeadersLength;
		maximumErrorResponseLength = section.HttpWebRequest.MaximumErrorResponseLength;
		useUnsafeHeaderParsing = section.HttpWebRequest.UseUnsafeHeaderParsing;
		useNagleAlgorithm = section.ServicePointManager.UseNagleAlgorithm;
		autoConfigUrlRetryInterval = section.WebProxyScript.AutoConfigUrlRetryInterval;
		TimeSpan timeSpan = section.WebProxyScript.DownloadTimeout;
		downloadTimeout = ((timeSpan == TimeSpan.MaxValue || timeSpan == TimeSpan.Zero) ? (-1) : ((int)timeSpan.TotalMilliseconds));
		performanceCountersEnabled = section.PerformanceCounters.Enabled;
		httpListenerUnescapeRequestUrl = section.HttpListener.UnescapeRequestUrl;
		httpListenerTimeouts = section.HttpListener.Timeouts.GetTimeouts();
		defaultCredentialsHandleCacheSize = section.WindowsAuthentication.DefaultCredentialsHandleCacheSize;
		WebUtilityElement webUtility = section.WebUtility;
		WebUtilityUnicodeDecodingConformance = webUtility.UnicodeDecodingConformance;
		WebUtilityUnicodeEncodingConformance = webUtility.UnicodeEncodingConformance;
	}

	internal static SettingsSectionInternal GetSection()
	{
		return new SettingsSectionInternal((SettingsSection)System.Configuration.PrivilegedConfigurationManager.GetSection(ConfigurationStrings.SettingsSectionPath));
	}
}
