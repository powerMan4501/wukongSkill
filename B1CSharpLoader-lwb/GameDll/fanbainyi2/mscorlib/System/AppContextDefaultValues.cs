using System.Runtime.Versioning;
using System.Security;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System;

internal static class AppContextDefaultValues
{
	internal static readonly string SwitchNoAsyncCurrentCulture = "Switch.System.Globalization.NoAsyncCurrentCulture";

	internal static readonly string SwitchEnforceJapaneseEraYearRanges = "Switch.System.Globalization.EnforceJapaneseEraYearRanges";

	internal static readonly string SwitchFormatJapaneseFirstYearAsANumber = "Switch.System.Globalization.FormatJapaneseFirstYearAsANumber";

	internal static readonly string SwitchEnforceLegacyJapaneseDateParsing = "Switch.System.Globalization.EnforceLegacyJapaneseDateParsing";

	internal static readonly string SwitchThrowExceptionIfDisposedCancellationTokenSource = "Switch.System.Threading.ThrowExceptionIfDisposedCancellationTokenSource";

	internal static readonly string SwitchPreserveEventListnerObjectIdentity = "Switch.System.Diagnostics.EventSource.PreserveEventListnerObjectIdentity";

	internal static readonly string SwitchUseLegacyPathHandling = "Switch.System.IO.UseLegacyPathHandling";

	internal static readonly string SwitchBlockLongPaths = "Switch.System.IO.BlockLongPaths";

	internal static readonly string SwitchDoNotAddrOfCspParentWindowHandle = "Switch.System.Security.Cryptography.DoNotAddrOfCspParentWindowHandle";

	internal static readonly string SwitchSetActorAsReferenceWhenCopyingClaimsIdentity = "Switch.System.Security.ClaimsIdentity.SetActorAsReferenceWhenCopyingClaimsIdentity";

	internal static readonly string SwitchIgnorePortablePDBsInStackTraces = "Switch.System.Diagnostics.IgnorePortablePDBsInStackTraces";

	internal static readonly string SwitchUseNewMaxArraySize = "Switch.System.Runtime.Serialization.UseNewMaxArraySize";

	internal static readonly string SwitchUseConcurrentFormatterTypeCache = "Switch.System.Runtime.Serialization.UseConcurrentFormatterTypeCache";

	internal static readonly string SwitchUseLegacyExecutionContextBehaviorUponUndoFailure = "Switch.System.Threading.UseLegacyExecutionContextBehaviorUponUndoFailure";

	internal static readonly string SwitchCryptographyUseLegacyFipsThrow = "Switch.System.Security.Cryptography.UseLegacyFipsThrow";

	internal static readonly string SwitchDoNotMarshalOutByrefSafeArrayOnInvoke = "Switch.System.Runtime.InteropServices.DoNotMarshalOutByrefSafeArrayOnInvoke";

	internal static readonly string SwitchUseNetCoreTimer = "Switch.System.Threading.UseNetCoreTimer";

	private static volatile bool s_errorReadingRegistry;

	public static void PopulateDefaultValues()
	{
		ParseTargetFrameworkName(out var identifier, out var profile, out var version);
		PopulateDefaultValuesPartial(identifier, profile, version);
	}

	private static void ParseTargetFrameworkName(out string identifier, out string profile, out int version)
	{
		string targetFrameworkName = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
		if (!TryParseFrameworkName(targetFrameworkName, out identifier, out version, out profile))
		{
			identifier = ".NETFramework";
			version = 40000;
			profile = string.Empty;
		}
	}

	private static bool TryParseFrameworkName(string frameworkName, out string identifier, out int version, out string profile)
	{
		identifier = (profile = string.Empty);
		version = 0;
		if (frameworkName == null || frameworkName.Length == 0)
		{
			return false;
		}
		string[] array = frameworkName.Split(',');
		version = 0;
		if (array.Length < 2 || array.Length > 3)
		{
			return false;
		}
		identifier = array[0].Trim();
		if (identifier.Length == 0)
		{
			return false;
		}
		bool flag = false;
		profile = null;
		for (int i = 1; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('=');
			if (array2.Length != 2)
			{
				return false;
			}
			string text = array2[0].Trim();
			string text2 = array2[1].Trim();
			if (text.Equals("Version", StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
				if (text2.Length > 0 && (text2[0] == 'v' || text2[0] == 'V'))
				{
					text2 = text2.Substring(1);
				}
				Version version2 = new Version(text2);
				version = version2.Major * 10000;
				if (version2.Minor > 0)
				{
					version += version2.Minor * 100;
				}
				if (version2.Build > 0)
				{
					version += version2.Build;
				}
			}
			else
			{
				if (!text.Equals("Profile", StringComparison.OrdinalIgnoreCase))
				{
					return false;
				}
				if (!string.IsNullOrEmpty(text2))
				{
					profile = text2;
				}
			}
		}
		if (!flag)
		{
			return false;
		}
		return true;
	}

	[SecuritySafeCritical]
	private static void TryGetSwitchOverridePartial(string switchName, ref bool overrideFound, ref bool overrideValue)
	{
		string text = null;
		overrideFound = false;
		if (!s_errorReadingRegistry)
		{
			text = GetSwitchValueFromRegistry(switchName);
		}
		if (text == null)
		{
			text = CompatibilitySwitch.GetValue(switchName);
		}
		if (text != null && bool.TryParse(text, out var result))
		{
			overrideValue = result;
			overrideFound = true;
		}
	}

	private static void PopulateDefaultValuesPartial(string platformIdentifier, string profile, int version)
	{
		switch (platformIdentifier)
		{
		case ".NETCore":
		case ".NETFramework":
			if (version <= 40502)
			{
				AppContext.DefineSwitchDefault(SwitchNoAsyncCurrentCulture, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchThrowExceptionIfDisposedCancellationTokenSource, isEnabled: true);
			}
			if (version <= 40601)
			{
				AppContext.DefineSwitchDefault(SwitchUseLegacyPathHandling, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchBlockLongPaths, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchSetActorAsReferenceWhenCopyingClaimsIdentity, isEnabled: true);
			}
			if (version <= 40602)
			{
				AppContext.DefineSwitchDefault(SwitchDoNotAddrOfCspParentWindowHandle, isEnabled: true);
			}
			if (version <= 40701)
			{
				AppContext.DefineSwitchDefault(SwitchIgnorePortablePDBsInStackTraces, isEnabled: true);
			}
			if (version <= 40702)
			{
				AppContext.DefineSwitchDefault(SwitchCryptographyUseLegacyFipsThrow, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchDoNotMarshalOutByrefSafeArrayOnInvoke, isEnabled: true);
			}
			break;
		case "WindowsPhone":
		case "WindowsPhoneApp":
			if (version <= 80100)
			{
				AppContext.DefineSwitchDefault(SwitchNoAsyncCurrentCulture, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchThrowExceptionIfDisposedCancellationTokenSource, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchUseLegacyPathHandling, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchBlockLongPaths, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchDoNotAddrOfCspParentWindowHandle, isEnabled: true);
				AppContext.DefineSwitchDefault(SwitchIgnorePortablePDBsInStackTraces, isEnabled: true);
			}
			break;
		}
		PopulateOverrideValuesPartial();
	}

	[SecuritySafeCritical]
	private static void PopulateOverrideValuesPartial()
	{
		string appContextOverridesInternalCall = CompatibilitySwitch.GetAppContextOverridesInternalCall();
		if (string.IsNullOrEmpty(appContextOverridesInternalCall))
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int num = -1;
		int num2 = -1;
		for (int i = 0; i <= appContextOverridesInternalCall.Length; i++)
		{
			if (i == appContextOverridesInternalCall.Length || appContextOverridesInternalCall[i] == ';')
			{
				if (flag && flag2 && flag3)
				{
					int startIndex = num + 1;
					int length = num2 - num - 1;
					string switchName = appContextOverridesInternalCall.Substring(startIndex, length);
					int startIndex2 = num2 + 1;
					int length2 = i - num2 - 1;
					string value = appContextOverridesInternalCall.Substring(startIndex2, length2);
					if (bool.TryParse(value, out var result))
					{
						AppContext.DefineSwitchOverride(switchName, result);
					}
				}
				num = i;
				flag2 = (flag3 = (flag = false));
			}
			else if (appContextOverridesInternalCall[i] == '=')
			{
				if (!flag)
				{
					flag = true;
					num2 = i;
				}
			}
			else if (flag)
			{
				flag3 = true;
			}
			else
			{
				flag2 = true;
			}
		}
	}

	public static bool TryGetSwitchOverride(string switchName, out bool overrideValue)
	{
		overrideValue = false;
		bool overrideFound = false;
		TryGetSwitchOverridePartial(switchName, ref overrideFound, ref overrideValue);
		return overrideFound;
	}

	[SecuritySafeCritical]
	private static string GetSwitchValueFromRegistry(string switchName)
	{
		try
		{
			using SafeRegistryHandle hKey = new SafeRegistryHandle((IntPtr)(-2147483646), ownsHandle: true);
			SafeRegistryHandle hkResult = null;
			if (Win32Native.RegOpenKeyEx(hKey, "SOFTWARE\\Microsoft\\.NETFramework\\AppContext", 0, 131097, out hkResult) == 0)
			{
				int lpcbData = 12;
				int lpType = 0;
				StringBuilder stringBuilder = new StringBuilder(lpcbData);
				if (Win32Native.RegQueryValueEx(hkResult, switchName, null, ref lpType, stringBuilder, ref lpcbData) == 0)
				{
					return stringBuilder.ToString();
				}
			}
			else
			{
				s_errorReadingRegistry = true;
			}
		}
		catch
		{
			s_errorReadingRegistry = true;
		}
		return null;
	}
}
