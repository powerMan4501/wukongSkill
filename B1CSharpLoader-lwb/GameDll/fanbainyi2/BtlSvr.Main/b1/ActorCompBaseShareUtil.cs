namespace b1;

internal static class ActorCompBaseShareUtil
{
	public static void RecalculateCanTick(bool HasBeginPlay, IActorCompBase Comp, IBUC_TickRateData TickRateData, BGW_PauseGameMgr PauseGameMgr, out IBUC_TickRateData TickRateDataForAccumlateDeltaTime)
	{
		bool flag = HasBeginPlay && Comp.CanTick() && Comp.IsNetActive();
		if (flag && PauseGameMgr.IsBattlePaused)
		{
			flag = TickRateData?.bTickEvenWhenPaused ?? false;
		}
		if (flag && !BGWGameInstanceCS.EnableCSharpTick)
		{
			flag = Comp.CanTickForDebug();
		}
		if (!flag)
		{
			TickRateDataForAccumlateDeltaTime = BUC_TickRateData.TickDisabledVersion;
		}
		else if (Comp.AllowTRO() && TickRateData != null)
		{
			TickRateDataForAccumlateDeltaTime = TickRateData;
		}
		else
		{
			TickRateDataForAccumlateDeltaTime = BUC_TickRateData.TRODisabledVersion;
		}
	}
}
