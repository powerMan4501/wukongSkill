using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ProjectileDispInteractComp : UActorCompBaseCS
{
	private b1.BUC_ProjectileDispInteractData ProjectileDispInteractData;

	private IBUC_TickRateData TickRateData;

	private BGW_DynamicSDFMgr SDFMgr;

	public override void OnAttach()
	{
		ProjectileDispInteractData = RequireWritableData<b1.BUC_ProjectileDispInteractData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		if (!(GetOwner() as BGUProjectileBaseActor).IsNullOrDestroyed())
		{
			if (ProjectileDispInteractData.Interact_Start_SphereRadius <= 0.01f || ProjectileDispInteractData.Interact_End_SphereRadius <= 0.01f)
			{
				SetProjectileDispInteractInfo(bEnable: false);
				return;
			}
			SetProjectileDispInteractInfo(bEnable: true);
			SDFMgr = BGW_DynamicSDFMgr.Get(Owner);
			BUS_EventCollectionCS.Get(this).Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
		}
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
		if (TickRateData.CanTickFor500msInterval(out var _, out var _, out var _, out var _, out var _) && ProjectileDispInteractData.EnableInteract)
		{
			UpdateLocalDistance();
		}
	}

	private void SetProjectileDispInteractInfo(bool bEnable)
	{
		ProjectileDispInteractData.EnableInteract = bEnable;
		SetCanTick(bEnable);
	}

	private void UpdateLocalDistance()
	{
		SDFMgr?.UpdateUnitLocalDistance(Owner);
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
		SetProjectileDispInteractInfo(bEnable: false);
	}
}
