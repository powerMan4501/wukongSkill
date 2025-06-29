namespace b1;

public static class SelectRangeDebugInfo
{
	private static bool bHasInitDebugForSelectRange;

	private static bool bEnableDebugForSelectRange;

	private static bool bHasInitDebugForSelectUnit;

	private static bool bEnableDebugForSelectUnit;

	public static bool EnableDebugForSelectRange
	{
		get
		{
			if (!bHasInitDebugForSelectRange)
			{
				bEnableDebugForSelectRange = GSGameplayCVar.CVar_ShowShapeSelectRange.GetValueInGameThread() == 1;
			}
			return bEnableDebugForSelectRange;
		}
		set
		{
			bHasInitDebugForSelectRange = true;
			bEnableDebugForSelectRange = value;
		}
	}

	public static bool EnableDebugForSelectUnit
	{
		get
		{
			if (!bHasInitDebugForSelectUnit)
			{
				bEnableDebugForSelectUnit = GSGameplayCVar.CVar_ShowShapeSelectUnit.GetValueInGameThread() == 1;
			}
			return bEnableDebugForSelectUnit;
		}
		set
		{
			bHasInitDebugForSelectUnit = true;
			bEnableDebugForSelectUnit = value;
		}
	}
}
