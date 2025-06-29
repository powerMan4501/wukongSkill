using System;
using b1.EventDelDefine;
using b1.Plugins.AsyncLoadingScreen;
using BtlB1;
using UnrealEngine.Engine;

namespace b1;

public class BPS_ClientRoleStateDataMgrSystem : PlayerStateSystemBase
{
	private BPC_PlayerRoleData PlayerRoleData;

	private IBIC_LevelData LevelData;

	private b1.IBPC_MapAreaData MapAreaData;

	private BGUCharacterCS Player => (Owner as BGP_PlayerStateCS)?.GetPawn() as BGUCharacterCS;

	public override void OnAttach()
	{
		PlayerRoleData = RequireWritableLocalPlayerControlData<BPC_PlayerRoleData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		MapAreaData = RequireReadOnlyLocalPlayerStateData<b1.IBPC_MapAreaData, BPC_MapAreaData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Combine(bGW_EventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(OnPostSeamlessTravel));
		GetPlayerEventCollection().Evt_ForceSetRebirthPoint += new Del_Void_Int(OnForceSetRebirthPoint);
	}

	public override void OnBeginPlay()
	{
		UpdateMapIdImpl();
	}

	private void OnForceSetRebirthPoint(int RebirthPointId)
	{
		FUStRebirthPointDesc fUStRebirthPointDesc = GameDBRuntime.GetFUStRebirthPointDesc(RebirthPointId);
		if (fUStRebirthPointDesc != null && BGUFuncLibMap.IsValidLevelId(fUStRebirthPointDesc.MapID))
		{
			PlayerRoleData.MapId = fUStRebirthPointDesc.MapID;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Remove(bGW_EventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(OnPostSeamlessTravel));
	}

	private void UpdateMapIdImpl()
	{
		if (PlayerRoleData != null && !(Player == null))
		{
			PlayerRoleData.MapId = LevelData.CurrentLevelID;
			PlayerRoleData.MapAreaId = MapAreaData.CurrentAreaId.Value;
			UpdateMaxMapAreaId();
		}
	}

	private void OnPostSeamlessTravel()
	{
		UpdateMapIdImpl();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateLocationAndRotation();
		UpdateMapInfo();
	}

	private void UpdateLocationAndRotation()
	{
		if (PlayerRoleData != null)
		{
			_ = Player != null;
		}
	}

	private void UpdateMapInfo()
	{
		if (BGWGameInstanceCS.Get(Owner).GetCurLoadingScreenState() == EGSLoadingScreenState.Idle && PlayerRoleData != null && !(Player == null) && PlayerRoleData.MapId >= 0)
		{
			int value = MapAreaData.CurrentAreaId.Value;
			if (value != 0 && PlayerRoleData.MapAreaId != value)
			{
				int mapAreaId = PlayerRoleData.MapAreaId;
				PlayerRoleData.MapAreaId = value;
				UpdateMaxMapAreaId();
				GetPlayerEventCollection().Evt_SetOSSSlevelLeaveData.Invoke(PlayerRoleData.MapId, mapAreaId);
				PlayerRoleData.BeginAreaStayTime = PlayerRoleData.GetGameTotalTime();
			}
		}
	}

	private void UpdateMaxMapAreaId()
	{
		if (PlayerRoleData != null)
		{
			if (PlayerRoleData.MapId > PlayerRoleData.MaxMapId)
			{
				PlayerRoleData.MaxMapAreaId = PlayerRoleData.MapAreaId;
				PlayerRoleData.MaxMapId = PlayerRoleData.MapId;
			}
			else if (PlayerRoleData.MapId == PlayerRoleData.MaxMapId && PlayerRoleData.MapAreaId > PlayerRoleData.MaxMapAreaId)
			{
				PlayerRoleData.MaxMapAreaId = PlayerRoleData.MapAreaId;
			}
		}
	}
}
