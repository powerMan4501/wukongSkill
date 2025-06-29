namespace b1;

public static class B1Global
{
	public static bool GIsMovieRendering { get; set; } = false;

	public static bool GIsBenchmarkMode { get; set; } = false;

	public static bool GIsBossRushMode { get; set; }

	public static bool GIsBossRushSettlementMode { get; set; } = false;

	public static int GOverrideLevelNumericalStrength { get; set; } = 0;

	public static float GBossRushBattleReadyTime { get; set; } = 3f;

	public static bool GIsGameReleased
	{
		get
		{
			if (GIsGameReleasedReally_Just4DevSimulation)
			{
				return true;
			}
			return DebugConfig.Environment == "prod";
		}
	}

	public static bool GIsGameReleasedReally_Just4DevSimulation
	{
		get
		{
			if (DebugConfig.GSSdkLoginChannel == "ps5" || DebugConfig.GSSdkLoginChannel == "steam" || DebugConfig.GSSdkLoginChannel == "wegame" || DebugConfig.GSSdkLoginChannel == "epic" || DebugConfig.GSSdkLoginChannel == "xsx")
			{
				if (DebugConfig.Environment == "prod-dev")
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}
}
