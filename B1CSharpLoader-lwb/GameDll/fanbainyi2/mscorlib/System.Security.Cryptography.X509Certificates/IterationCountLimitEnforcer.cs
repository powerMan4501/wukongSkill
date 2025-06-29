using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using Microsoft.Win32;

namespace System.Security.Cryptography.X509Certificates;

internal static class IterationCountLimitEnforcer
{
	private static class Impl
	{
		private const long DefaultPkcs12UnspecifiedPasswordIterationLimit = 600000L;

		private static long s_pkcs12UnspecifiedPasswordIterationLimit = ReadSecuritySwitch();

		[SecuritySafeCritical]
		[EnvironmentPermission(SecurityAction.Assert, Unrestricted = true)]
		private static long ReadSecuritySwitch()
		{
			long result = 0L;
			string environmentVariable = Environment.GetEnvironmentVariable("COMPlus_Pkcs12UnspecifiedPasswordIterationLimit");
			if (environmentVariable != null && long.TryParse(environmentVariable, out result))
			{
				return result;
			}
			if (ReadSettingsFromRegistry(Registry.CurrentUser, ref result))
			{
				return result;
			}
			if (ReadSettingsFromRegistry(Registry.LocalMachine, ref result))
			{
				return result;
			}
			return 600000L;
		}

		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
		[RegistryPermission(SecurityAction.Assert, Unrestricted = true)]
		private static bool ReadSettingsFromRegistry(RegistryKey regKey, ref long value)
		{
			try
			{
				using RegistryKey registryKey = regKey.OpenSubKey("SOFTWARE\\Microsoft\\.NETFramework", writable: false);
				if (registryKey != null)
				{
					object value2 = registryKey.GetValue("Pkcs12UnspecifiedPasswordIterationLimit");
					if (value2 != null)
					{
						value = Convert.ToInt64(value2, CultureInfo.InvariantCulture);
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		internal static void EnforceIterationCountLimit(byte[] pkcs12, bool readingFromFile, bool passwordProvided)
		{
			if (readingFromFile || passwordProvided)
			{
				return;
			}
			long num = s_pkcs12UnspecifiedPasswordIterationLimit;
			if (num == -1)
			{
				return;
			}
			if (num < 0)
			{
				num = 600000L;
			}
			checked
			{
				try
				{
					try
					{
						KdfWorkLimiter.SetIterationLimit((ulong)num);
						ulong iterationCount = GetIterationCount(pkcs12);
						if (iterationCount > (ulong)num || KdfWorkLimiter.WasWorkLimitExceeded())
						{
							throw new CryptographicException();
						}
					}
					finally
					{
						KdfWorkLimiter.ResetIterationLimit();
					}
				}
				catch (Exception inner)
				{
					throw new CryptographicException(Environment.GetResourceString("Cryptography_X509_PfxWithoutPassword"), inner);
				}
			}
		}

		private static ulong GetIterationCount(byte[] pkcs12)
		{
			ReadOnlyMemory<byte> rebind = new ReadOnlyMemory<byte>(pkcs12);
			AsnValueReader reader = new AsnValueReader(pkcs12, AsnEncodingRules.BER);
			PfxAsn.Decode(ref reader, rebind, out var decoded);
			return decoded.CountTotalIterations();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnforceIterationCountLimit(byte[] pkcs12, bool readingFromFile, bool passwordProvided)
	{
		Impl.EnforceIterationCountLimit(pkcs12, readingFromFile, passwordProvided);
	}
}
