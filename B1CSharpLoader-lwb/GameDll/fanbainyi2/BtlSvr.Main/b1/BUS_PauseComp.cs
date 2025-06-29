using GSDispLib;

namespace b1;

public class BUS_PauseComp : UActorCompBaseCS
{
	private IBUC_TickRateData TickRateData;

	private IBUC_PropMgrData PropMgrData;

	private uint CustomTimeDilationHandleID;

	public override void OnAttach()
	{
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override float GetAccumulatedDeltaTime()
	{
		if (!HasBegunPlay())
		{
			return -1f;
		}
		return 0f;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PauseGameMgr.IsBattlePaused)
		{
			if (!TickRateData.bTickEvenWhenPaused && CustomTimeDilationHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, 0f);
				CustomTimeDilationHandleID = PropMgrData.GetLastHandleID();
				BUS_DispLibEventCollection.Get(Owner)?.Evt_RequestSetDBCEffectsPause?.Invoke(0, Pause: true, 100, "PauseFrom_BUS_PauseComp");
			}
		}
		else if (CustomTimeDilationHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(CustomTimeDilationHandleID);
			CustomTimeDilationHandleID = 0u;
			BUS_DispLibEventCollection.Get(Owner)?.Evt_RequestSetDBCEffectsPause?.Invoke(0, Pause: false, 100, "PauseFrom_BUS_PauseComp");
		}
	}
}
