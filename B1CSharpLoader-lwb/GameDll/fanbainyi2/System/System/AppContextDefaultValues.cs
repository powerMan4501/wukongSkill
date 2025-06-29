namespace System;

internal static class AppContextDefaultValues
{
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

	private static void PopulateDefaultValuesPartial(string platformIdentifier, string profile, int version)
	{
		switch (platformIdentifier)
		{
		case ".NETCore":
		case ".NETFramework":
			if (version <= 40502)
			{
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Net.DontEnableSchUseStrongCrypto", initialValue: true);
			}
			if (version <= 40601)
			{
				System.LocalAppContext.DefineSwitchDefault("Switch.System.MemberDescriptorEqualsReturnsFalseIfEquivalent", initialValue: true);
			}
			if (version <= 40602)
			{
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Net.DontEnableSystemDefaultTlsVersions", initialValue: true);
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Net.DontEnableTlsAlerts", initialValue: true);
			}
			if (version <= 40700)
			{
				System.LocalAppContext.DefineSwitchDefault("Switch.System.IO.Ports.DoNotCatchSerialStreamThreadExceptions", initialValue: true);
			}
			if (version <= 40701)
			{
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Uri.DontEnableStrictRFC3986ReservedCharacterSets", initialValue: true);
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Uri.DontKeepUnicodeBidiFormattingCharacters", initialValue: true);
				System.LocalAppContext.DefineSwitchDefault("Switch.System.IO.Compression.DoNotUseNativeZipLibraryForDecompression", initialValue: true);
			}
			break;
		case "WindowsPhone":
		case "WindowsPhoneApp":
			if (version <= 80100)
			{
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Net.DontEnableSchUseStrongCrypto", initialValue: true);
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Net.DontEnableSystemDefaultTlsVersions", initialValue: true);
				System.LocalAppContext.DefineSwitchDefault("Switch.System.Net.DontEnableTlsAlerts", initialValue: true);
			}
			break;
		}
	}
}
