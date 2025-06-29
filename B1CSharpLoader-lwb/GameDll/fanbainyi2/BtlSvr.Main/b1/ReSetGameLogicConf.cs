namespace b1;

public static class ReSetGameLogicConf
{
	public static void Reset()
	{
		DebugConfig.TopdownBattleMode = false;
		DebugConfig.IsTmpTestFlag = false;
		DebugConfigDev.DevInEditorReset();
	}
}
