using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_OnlineTeammateMgr : GameStateSystemBase
{
	private BGC_OnlineTeammateData TeammateData;

	public override void OnAttach()
	{
		base.OnAttach();
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(this);
		TeammateData = RequireWritableData<BGC_OnlineTeammateData>();
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_PlayerJoin += new Del_PlayerState(OnPlayerJoin);
			bGS_GSEventCollection.Evt_BGS_PlayerLogOut += new Del_PlayerState(OnPlayerLogOut);
			bGS_GSEventCollection.Evt_PlayerActorLateBeginPlayFinish += new Del_PlayerState(OnLateBeginPlayFinish);
		}
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		List<APlayerState> allPlayerState = BGU_UnrealWorldUtil.GetAllPlayerState(Owner);
		if (allPlayerState == null)
		{
			return;
		}
		foreach (APlayerState item in allPlayerState)
		{
			OnPlayerJoin(item);
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		TeammateData.NeedUpdateTransition = true;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public void OnPlayerJoin(APlayerState PlayerState)
	{
		TeammateData.PlayerJoin(PlayerState as ABGPPlayerState);
	}

	public void OnPlayerLogOut(APlayerState PlayerState)
	{
		TeammateData.PlayerLogOut(PlayerState as ABGPPlayerState);
	}

	public void OnLateBeginPlayFinish(APlayerState PlayerState)
	{
		TeammateData.PlayerActorUpdate(PlayerState as ABGPPlayerState);
	}
}
