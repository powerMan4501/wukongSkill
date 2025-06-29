using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MasterComp : UActorCompBaseCS
{
	private BUC_MasterData MasterData;

	public override void OnAttach()
	{
		MasterData = RequireWritableData<BUC_MasterData>();
		base.BUSEventCollection.Evt_SetMaster += new Del_Void_Actor(OnSetMaster);
		base.BGSEventCollection.Evt_BGS_MasterChangeTeam += new Del_Void_Chr(OnMasterChangeTeam);
	}

	public override void OnBeginPlay()
	{
		if (!(Owner is BGUProjectileBaseActor) && !(Owner is BGUWeaponBase))
		{
			MasterData?.SetMaster(GetOwner());
		}
	}

	private void OnSetMaster(AActor Master)
	{
		if (!GetOwner().IsNullOrDestroyed() && !(Master as BGUCharacterCS).IsNullOrDestroyed())
		{
			MasterData?.SetMaster(Master);
			base.BUSEventCollection.Evt_NotifyMasterChanged.Invoke();
			OnReCacheTeamID(Master);
		}
	}

	private void OnReCacheTeamID(AActor Master)
	{
		if (Master is ITeamCS teamCS && Owner is ITeamCS teamCS2)
		{
			teamCS2.SetTeamIDInCS(teamCS.GetTeamIDInCS());
		}
	}

	private void OnMasterChangeTeam(BGUCharacterCS Master)
	{
		if (!(MasterData.GetMasterActor() == GetOwner()) && !(MasterData.GetMasterActor() != Master))
		{
			OnReCacheTeamID(Master);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_MasterChangeTeam -= new Del_Void_Chr(OnMasterChangeTeam);
	}
}
