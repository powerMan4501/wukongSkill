using System.Runtime.CompilerServices;

namespace System;

[FriendAccessAllowed]
internal static class CompatibilitySwitches
{
	private static bool s_AreSwitchesSet;

	private static bool s_isNetFx40TimeSpanLegacyFormatMode;

	private static bool s_isNetFx40LegacySecurityPolicy;

	private static bool s_isNetFx45LegacyManagedDeflateStream;

	public static bool IsCompatibilityBehaviorDefined => s_AreSwitchesSet;

	public static bool IsAppEarlierThanSilverlight4 => false;

	public static bool IsAppEarlierThanWindowsPhone8 => false;

	public static bool IsAppEarlierThanWindowsPhoneMango => false;

	public static bool IsNetFx40TimeSpanLegacyFormatMode => s_isNetFx40TimeSpanLegacyFormatMode;

	public static bool IsNetFx40LegacySecurityPolicy => s_isNetFx40LegacySecurityPolicy;

	public static bool IsNetFx45LegacyManagedDeflateStream => s_isNetFx45LegacyManagedDeflateStream;

	private static bool IsCompatibilitySwitchSet(string compatibilitySwitch)
	{
		bool? flag = AppDomain.CurrentDomain.IsCompatibilitySwitchSet(compatibilitySwitch);
		if (flag.HasValue)
		{
			return flag.Value;
		}
		return false;
	}

	internal static void InitializeSwitches()
	{
		s_isNetFx40TimeSpanLegacyFormatMode = IsCompatibilitySwitchSet("NetFx40_TimeSpanLegacyFormatMode");
		s_isNetFx40LegacySecurityPolicy = IsCompatibilitySwitchSet("NetFx40_LegacySecurityPolicy");
		s_isNetFx45LegacyManagedDeflateStream = IsCompatibilitySwitchSet("NetFx45_LegacyManagedDeflateStream");
		s_AreSwitchesSet = true;
	}
}
