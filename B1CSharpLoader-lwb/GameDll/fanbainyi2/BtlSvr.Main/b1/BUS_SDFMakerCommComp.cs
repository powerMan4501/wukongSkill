using b1.BGW;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SDFMakerCommComp : UActorCompBaseCS
{
	private IBUC_TickRateData TickRateData;

	private BGW_DynamicSDFMgr SDFMgr;

	public override void OnAttach()
	{
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		SDFMgr = BGW_DynamicSDFMgr.Get(Owner);
		BGUSDFMaker bGUSDFMaker = Owner as BGUSDFMaker;
		if (!bGUSDFMaker.IsNullOrDestroyed())
		{
			bGUSDFMaker.GetInteractWorldPosAndScaledRadius(out var _, out var _, out var _, out var _);
		}
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (TickRateData != null && TickRateData.CanTickFor500msInterval(out var _, out var _, out var _, out var _, out var _))
		{
			UpdateLocalDistance();
		}
	}

	private void UpdateLocalDistance()
	{
		SDFMgr?.UpdateUnitLocalDistance(Owner);
	}
}
