using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.Versioning;

[FriendAccessAllowed]
internal static class BinaryCompatibility
{
	private sealed class BinaryCompatibilityMap
	{
		internal bool TargetsAtLeast_Phone_V7_1;

		internal bool TargetsAtLeast_Phone_V8_0;

		internal bool TargetsAtLeast_Phone_V8_1;

		internal bool TargetsAtLeast_Desktop_V4_5;

		internal bool TargetsAtLeast_Desktop_V4_5_1;

		internal bool TargetsAtLeast_Desktop_V4_5_2;

		internal bool TargetsAtLeast_Desktop_V4_5_3;

		internal bool TargetsAtLeast_Desktop_V4_5_4;

		internal bool TargetsAtLeast_Desktop_V5_0;

		internal bool TargetsAtLeast_Silverlight_V4;

		internal bool TargetsAtLeast_Silverlight_V5;

		internal bool TargetsAtLeast_Silverlight_V6;

		internal BinaryCompatibilityMap()
		{
			AddQuirksForFramework(AppWasBuiltForFramework, AppWasBuiltForVersion);
		}

		private void AddQuirksForFramework(TargetFrameworkId builtAgainstFramework, int buildAgainstVersion)
		{
			switch (builtAgainstFramework)
			{
			case TargetFrameworkId.NetFramework:
			case TargetFrameworkId.NetCore:
				if (buildAgainstVersion >= 50000)
				{
					TargetsAtLeast_Desktop_V5_0 = true;
				}
				if (buildAgainstVersion >= 40504)
				{
					TargetsAtLeast_Desktop_V4_5_4 = true;
				}
				if (buildAgainstVersion >= 40503)
				{
					TargetsAtLeast_Desktop_V4_5_3 = true;
				}
				if (buildAgainstVersion >= 40502)
				{
					TargetsAtLeast_Desktop_V4_5_2 = true;
				}
				if (buildAgainstVersion >= 40501)
				{
					TargetsAtLeast_Desktop_V4_5_1 = true;
				}
				if (buildAgainstVersion >= 40500)
				{
					TargetsAtLeast_Desktop_V4_5 = true;
					AddQuirksForFramework(TargetFrameworkId.Phone, 70100);
					AddQuirksForFramework(TargetFrameworkId.Silverlight, 50000);
				}
				break;
			case TargetFrameworkId.Phone:
				if (buildAgainstVersion >= 80000)
				{
					TargetsAtLeast_Phone_V8_0 = true;
				}
				if (buildAgainstVersion >= 80100)
				{
					TargetsAtLeast_Desktop_V4_5 = true;
					TargetsAtLeast_Desktop_V4_5_1 = true;
				}
				if (buildAgainstVersion >= 710)
				{
					TargetsAtLeast_Phone_V7_1 = true;
				}
				break;
			case TargetFrameworkId.Silverlight:
				if (buildAgainstVersion >= 40000)
				{
					TargetsAtLeast_Silverlight_V4 = true;
				}
				if (buildAgainstVersion >= 50000)
				{
					TargetsAtLeast_Silverlight_V5 = true;
				}
				if (buildAgainstVersion >= 60000)
				{
					TargetsAtLeast_Silverlight_V6 = true;
				}
				break;
			case TargetFrameworkId.NotYetChecked:
			case TargetFrameworkId.Unrecognized:
			case TargetFrameworkId.Unspecified:
			case TargetFrameworkId.Portable:
				break;
			}
		}
	}

	private static TargetFrameworkId s_AppWasBuiltForFramework;

	private static int s_AppWasBuiltForVersion;

	private static readonly BinaryCompatibilityMap s_map = new BinaryCompatibilityMap();

	private const char c_componentSeparator = ',';

	private const char c_keyValueSeparator = '=';

	private const char c_versionValuePrefix = 'v';

	private const string c_versionKey = "Version";

	private const string c_profileKey = "Profile";

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Phone_V7_1
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Phone_V7_1;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Phone_V8_0
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Phone_V8_0;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Desktop_V4_5
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Desktop_V4_5;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Desktop_V4_5_1
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Desktop_V4_5_1;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Desktop_V4_5_2
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Desktop_V4_5_2;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Desktop_V4_5_3
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Desktop_V4_5_3;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Desktop_V4_5_4
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Desktop_V4_5_4;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Desktop_V5_0
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Desktop_V5_0;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Silverlight_V4
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Silverlight_V4;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Silverlight_V5
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Silverlight_V5;
		}
	}

	[FriendAccessAllowed]
	internal static bool TargetsAtLeast_Silverlight_V6
	{
		[FriendAccessAllowed]
		get
		{
			return s_map.TargetsAtLeast_Silverlight_V6;
		}
	}

	[FriendAccessAllowed]
	internal static TargetFrameworkId AppWasBuiltForFramework
	{
		[FriendAccessAllowed]
		get
		{
			if (s_AppWasBuiltForFramework == TargetFrameworkId.NotYetChecked)
			{
				ReadTargetFrameworkId();
			}
			return s_AppWasBuiltForFramework;
		}
	}

	[FriendAccessAllowed]
	internal static int AppWasBuiltForVersion
	{
		[FriendAccessAllowed]
		get
		{
			if (s_AppWasBuiltForFramework == TargetFrameworkId.NotYetChecked)
			{
				ReadTargetFrameworkId();
			}
			return s_AppWasBuiltForVersion;
		}
	}

	private static bool ParseTargetFrameworkMonikerIntoEnum(string targetFrameworkMoniker, out TargetFrameworkId targetFramework, out int targetFrameworkVersion)
	{
		targetFramework = TargetFrameworkId.NotYetChecked;
		targetFrameworkVersion = 0;
		string identifier = null;
		string profile = null;
		ParseFrameworkName(targetFrameworkMoniker, out identifier, out targetFrameworkVersion, out profile);
		switch (identifier)
		{
		case ".NETFramework":
			targetFramework = TargetFrameworkId.NetFramework;
			break;
		case ".NETPortable":
			targetFramework = TargetFrameworkId.Portable;
			break;
		case ".NETCore":
			targetFramework = TargetFrameworkId.NetCore;
			break;
		case "WindowsPhone":
			if (targetFrameworkVersion >= 80100)
			{
				targetFramework = TargetFrameworkId.Phone;
			}
			else
			{
				targetFramework = TargetFrameworkId.Unspecified;
			}
			break;
		case "WindowsPhoneApp":
			targetFramework = TargetFrameworkId.Phone;
			break;
		case "Silverlight":
			targetFramework = TargetFrameworkId.Silverlight;
			if (string.IsNullOrEmpty(profile))
			{
				break;
			}
			switch (profile)
			{
			case "WindowsPhone":
				targetFramework = TargetFrameworkId.Phone;
				targetFrameworkVersion = 70000;
				break;
			case "WindowsPhone71":
				targetFramework = TargetFrameworkId.Phone;
				targetFrameworkVersion = 70100;
				break;
			case "WindowsPhone8":
				targetFramework = TargetFrameworkId.Phone;
				targetFrameworkVersion = 80000;
				break;
			default:
				if (profile.StartsWith("WindowsPhone", StringComparison.Ordinal))
				{
					targetFramework = TargetFrameworkId.Unrecognized;
					targetFrameworkVersion = 70100;
				}
				else
				{
					targetFramework = TargetFrameworkId.Unrecognized;
				}
				break;
			}
			break;
		default:
			targetFramework = TargetFrameworkId.Unrecognized;
			break;
		}
		return true;
	}

	private static void ParseFrameworkName(string frameworkName, out string identifier, out int version, out string profile)
	{
		if (frameworkName == null)
		{
			throw new ArgumentNullException("frameworkName");
		}
		if (frameworkName.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_StringZeroLength"), "frameworkName");
		}
		string[] array = frameworkName.Split(',');
		version = 0;
		if (array.Length < 2 || array.Length > 3)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_FrameworkNameTooShort"), "frameworkName");
		}
		identifier = array[0].Trim();
		if (identifier.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_FrameworkNameInvalid"), "frameworkName");
		}
		bool flag = false;
		profile = null;
		for (int i = 1; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('=');
			if (array2.Length != 2)
			{
				throw new ArgumentException(Environment.GetResourceString("SR.Argument_FrameworkNameInvalid"), "frameworkName");
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
					throw new ArgumentException(Environment.GetResourceString("Argument_FrameworkNameInvalid"), "frameworkName");
				}
				if (!string.IsNullOrEmpty(text2))
				{
					profile = text2;
				}
			}
		}
		if (!flag)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_FrameworkNameMissingVersion"), "frameworkName");
		}
	}

	[SecuritySafeCritical]
	private static void ReadTargetFrameworkId()
	{
		string text = AppDomain.CurrentDomain.GetTargetFrameworkName();
		string valueInternal = CompatibilitySwitch.GetValueInternal("TargetFrameworkMoniker");
		if (!string.IsNullOrEmpty(valueInternal))
		{
			text = valueInternal;
		}
		int targetFrameworkVersion = 0;
		TargetFrameworkId targetFramework;
		if (text == null)
		{
			targetFramework = TargetFrameworkId.Unspecified;
		}
		else if (!ParseTargetFrameworkMonikerIntoEnum(text, out targetFramework, out targetFrameworkVersion))
		{
			targetFramework = TargetFrameworkId.Unrecognized;
		}
		s_AppWasBuiltForFramework = targetFramework;
		s_AppWasBuiltForVersion = targetFrameworkVersion;
	}
}
