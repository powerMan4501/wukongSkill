using UnrealEngine.Runtime;

namespace b1;

public class GMFlag
{
	public const int GM_None = 1;

	public const int GM_CHEAT = 2;

	public const int GM_DEBUG = 4;

	public const int GM_UEDEBUG = 8;

	public const int GM_DEBUG_DISPLAY = 16;

	public const int GM_Max = int.MaxValue;

	public static int GetValueByName(string Name)
	{
		return StringParseHelper.SafeToLower(Name) switch
		{
			"gm_none" => 1, 
			"gm_cheat" => 2, 
			"gm_debug" => 4, 
			"gm_uedebug" => 8, 
			"gm_debug_display" => 16, 
			"gm_max" => int.MaxValue, 
			_ => 0, 
		};
	}
}
