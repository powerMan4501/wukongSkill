using System.Runtime.CompilerServices;

namespace System;

internal static class LocalAppContextSwitches
{
	internal const string DontReliablyClonePrivateKeyStr = "Switch.System.Security.Cryptography.X509Certificates.RSACertificateExtensions.DontReliablyClonePrivateKey";

	private static int _dontReliablyClonePrivateKeyName;

	internal const string UseLegacyPublicKeyBehaviorStr = "Switch.System.Security.Cryptography.X509Certificates.ECDsaCertificateExtensions.UseLegacyPublicKeyBehavior";

	private static int _useLegacyPublicKeyBehavior;

	internal const string AesCryptoServiceProviderDontCorrectlyResetDecryptorStr = "Switch.System.Security.Cryptography.AesCryptoServiceProvider.DontCorrectlyResetDecryptor";

	private static int _aesCryptoServiceProviderDontCorrectlyResetDecryptorName;

	internal const string SymmetricCngAlwaysUseNCryptStr = "Switch.System.Security.Cryptography.SymmetricCng.AlwaysUseNCrypt";

	private static int _symmetricCngAlwaysUseNCryptName;

	internal static readonly string SwitchCryptographyUseLegacyFipsThrow = "Switch.System.Security.Cryptography.UseLegacyFipsThrow";

	private static int _useLegacyFipsThrow;

	public static bool DontReliablyClonePrivateKey
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Security.Cryptography.X509Certificates.RSACertificateExtensions.DontReliablyClonePrivateKey", ref _dontReliablyClonePrivateKeyName);
		}
	}

	public static bool UseLegacyPublicKeyBehavior
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Security.Cryptography.X509Certificates.ECDsaCertificateExtensions.UseLegacyPublicKeyBehavior", ref _useLegacyPublicKeyBehavior);
		}
	}

	public static bool AesCryptoServiceProviderDontCorrectlyResetDecryptor
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Security.Cryptography.AesCryptoServiceProvider.DontCorrectlyResetDecryptor", ref _aesCryptoServiceProviderDontCorrectlyResetDecryptorName);
		}
	}

	public static bool SymmetricCngAlwaysUseNCrypt
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue("Switch.System.Security.Cryptography.SymmetricCng.AlwaysUseNCrypt", ref _symmetricCngAlwaysUseNCryptName);
		}
	}

	public static bool UseLegacyFipsThrow
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return System.LocalAppContext.GetCachedSwitchValue(SwitchCryptographyUseLegacyFipsThrow, ref _useLegacyFipsThrow);
		}
	}
}
