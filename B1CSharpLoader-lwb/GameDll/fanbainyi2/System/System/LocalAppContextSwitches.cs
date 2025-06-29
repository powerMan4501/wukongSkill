using System.Runtime.CompilerServices;

namespace System;

internal static class LocalAppContextSwitches
{
	private static int _memberDescriptorEqualsReturnsFalseIfEquivalent;

	internal const string MemberDescriptorEqualsReturnsFalseIfEquivalentName = "Switch.System.MemberDescriptorEqualsReturnsFalseIfEquivalent";

	private static int _dontEnableStrictRFC3986ReservedCharacterSets;

	internal const string DontEnableStrictRFC3986ReservedCharacterSetsName = "Switch.System.Uri.DontEnableStrictRFC3986ReservedCharacterSets";

	private static int _dontKeepUnicodeBidiFormattingCharacters;

	internal const string DontKeepUnicodeBidiFormattingCharactersName = "Switch.System.Uri.DontKeepUnicodeBidiFormattingCharacters";

	private static int _disableTempFileCollectionDirectoryFeature;

	internal const string DisableTempFileCollectionDirectoryFeatureName = "Switch.System.DisableTempFileCollectionDirectoryFeature";

	private static int _disableEventLogRegistryKeysFiltering;

	private const string DisableEventLogRegistryKeysFilteringName = "Switch.System.Diagnostics.EventLog.DisableEventLogRegistryKeysFiltering";

	private static int _dontEnableSchUseStrongCrypto;

	internal const string DontEnableSchUseStrongCryptoName = "Switch.System.Net.DontEnableSchUseStrongCrypto";

	private static int _allocateOverlappedOnDemand;

	internal const string AllocateOverlappedOnDemandName = "Switch.System.Net.WebSockets.HttpListenerAsyncEventArgs.AllocateOverlappedOnDemand";

	private static int _dontEnableSchSendAuxRecord;

	internal const string DontEnableSchSendAuxRecordName = "Switch.System.Net.DontEnableSchSendAuxRecord";

	private static int _dontEnableSystemSystemDefaultTlsVersions;

	internal const string DontEnableSystemDefaultTlsVersionsName = "Switch.System.Net.DontEnableSystemDefaultTlsVersions";

	private static int _dontEnableTlsAlerts;

	internal const string DontEnableTlsAlertsName = "Switch.System.Net.DontEnableTlsAlerts";

	private static int _dontEnableTls13;

	internal const string DontEnableTls13Name = "Switch.System.Net.DontEnableTls13";

	private static int _dontCheckCertificateEKUs;

	internal const string DontCheckCertificateEKUsName = "Switch.System.Net.DontCheckCertificateEKUs";

	private static int _dontCheckCertificateRevocation;

	internal const string DontCheckCertificateRevocationName = "System.Net.Security.SslStream.AuthenticateAsClient.DontCheckCertificateRevocation";

	private static int _doNotCatchSerialStreamThreadExceptions;

	internal const string DoNotCatchSerialStreamThreadExceptionsName = "Switch.System.IO.Ports.DoNotCatchSerialStreamThreadExceptions";

	private static int _doNotValidateX509KeyStorageFlags;

	internal const string DoNotValidateX509KeyStorageFlagsName = "Switch.System.Security.Cryptography.X509Cerificates.X509Certificate2Collection.DoNotValidateX509KeyStorageFlags";

	private static int _doNotUseNativeZipLibraryForDecompression;

	internal const string DoNotUseNativeZipLibraryForDecompressionName = "Switch.System.IO.Compression.DoNotUseNativeZipLibraryForDecompression";

	private static int _useLegacyTimeoutCheck;

	internal const string UseLegacyTimeoutCheckName = "Switch.System.Text.RegularExpressions.UseLegacyTimeoutCheck";

	private static int _doNotValidatePerformanceCounterData;

	internal const string DoNotValidatePerformanceCounterDataName = "Switch.System.Diagnostics.DoNotValidatePerformanceCounterData";

	public static bool MemberDescriptorEqualsReturnsFalseIfEquivalent
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.MemberDescriptorEqualsReturnsFalseIfEquivalent", ref _memberDescriptorEqualsReturnsFalseIfEquivalent);
		}
	}

	public static bool DontEnableStrictRFC3986ReservedCharacterSets
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Uri.DontEnableStrictRFC3986ReservedCharacterSets", ref _dontEnableStrictRFC3986ReservedCharacterSets);
		}
	}

	public static bool DontKeepUnicodeBidiFormattingCharacters
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Uri.DontKeepUnicodeBidiFormattingCharacters", ref _dontKeepUnicodeBidiFormattingCharacters);
		}
	}

	public static bool DisableTempFileCollectionDirectoryFeature
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.DisableTempFileCollectionDirectoryFeature", ref _disableTempFileCollectionDirectoryFeature);
		}
	}

	public static bool DisableEventLogRegistryKeysFiltering
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Diagnostics.EventLog.DisableEventLogRegistryKeysFiltering", ref _disableEventLogRegistryKeysFiltering);
		}
	}

	public static bool DontEnableSchUseStrongCrypto
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Net.DontEnableSchUseStrongCrypto", ref _dontEnableSchUseStrongCrypto);
		}
	}

	public static bool AllocateOverlappedOnDemand
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Net.WebSockets.HttpListenerAsyncEventArgs.AllocateOverlappedOnDemand", ref _allocateOverlappedOnDemand);
		}
	}

	public static bool DontEnableSchSendAuxRecord
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Net.DontEnableSchSendAuxRecord", ref _dontEnableSchSendAuxRecord);
		}
	}

	public static bool DontEnableSystemDefaultTlsVersions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Net.DontEnableSystemDefaultTlsVersions", ref _dontEnableSystemSystemDefaultTlsVersions);
		}
	}

	public static bool DontEnableTlsAlerts
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Net.DontEnableTlsAlerts", ref _dontEnableTlsAlerts);
		}
	}

	public static bool DontEnableTls13
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Net.DontEnableTls13", ref _dontEnableTls13);
		}
	}

	public static bool DontCheckCertificateEKUs
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Net.DontCheckCertificateEKUs", ref _dontCheckCertificateEKUs);
		}
	}

	public static bool DontCheckCertificateRevocation
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("System.Net.Security.SslStream.AuthenticateAsClient.DontCheckCertificateRevocation", ref _dontCheckCertificateRevocation);
		}
	}

	public static bool DoNotCatchSerialStreamThreadExceptions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.IO.Ports.DoNotCatchSerialStreamThreadExceptions", ref _doNotCatchSerialStreamThreadExceptions);
		}
	}

	public static bool DoNotValidateX509KeyStorageFlags
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Security.Cryptography.X509Cerificates.X509Certificate2Collection.DoNotValidateX509KeyStorageFlags", ref _doNotValidateX509KeyStorageFlags);
		}
	}

	public static bool DoNotUseNativeZipLibraryForDecompression
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.IO.Compression.DoNotUseNativeZipLibraryForDecompression", ref _doNotUseNativeZipLibraryForDecompression);
		}
	}

	public static bool UseLegacyTimeoutCheck
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Text.RegularExpressions.UseLegacyTimeoutCheck", ref _useLegacyTimeoutCheck);
		}
	}

	public static bool DoNotValidatePerformanceCounterData
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Diagnostics.DoNotValidatePerformanceCounterData", ref _doNotValidatePerformanceCounterData);
		}
	}
}
