using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Security.Cryptography.X509Certificates;

internal static class PrivateKeyEnforcer
{
	private static class Impl
	{
		private enum PrivateKeySetting
		{
			Uninitialized,
			Enabled,
			Disabled
		}

		[SecuritySafeCritical]
		[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
		internal static void VerifyNotPfx(byte[] rawData, string settingName, ref int setting)
		{
			PrivateKeySetting privateKeySetting = (PrivateKeySetting)setting;
			if (privateKeySetting == PrivateKeySetting.Uninitialized)
			{
				privateKeySetting = (PrivateKeySetting)(setting = (ReadPrivateKeySetting(settingName) ? 1 : 2));
			}
			if (privateKeySetting == PrivateKeySetting.Enabled)
			{
				X509ContentType certContentType = X509Certificate2.GetCertContentType(rawData);
				if (certContentType == X509ContentType.Pfx)
				{
					throw new CryptographicException(System.SR.GetString("Cryptography_X509_PfxBlobsNotAllowed"));
				}
			}
		}

		[SecuritySafeCritical]
		[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
		private static bool ReadPrivateKeySetting(string settingName)
		{
			bool result = false;
			string environmentVariable = Environment.GetEnvironmentVariable("COMPlus_" + settingName);
			if (environmentVariable != null && bool.TryParse(environmentVariable, out result))
			{
				return result;
			}
			if (TryReadSettingFromRegistry(settingName, Registry.CurrentUser, ref result))
			{
				return result;
			}
			if (TryReadSettingFromRegistry(settingName, Registry.LocalMachine, ref result))
			{
				return result;
			}
			return true;
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		[RegistryPermission(SecurityAction.Assert, Unrestricted = true)]
		private static bool TryReadSettingFromRegistry(string regValueName, RegistryKey regKey, ref bool value)
		{
			try
			{
				using RegistryKey registryKey = regKey.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework", writable: false);
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue(regValueName);
					if (value2 != null)
					{
						value = Convert.ToBoolean(value2, CultureInfo.InvariantCulture);
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyNotPfx(byte[] rawData, string settingName, ref int setting)
	{
		Impl.VerifyNotPfx(rawData, settingName, ref setting);
	}
}
