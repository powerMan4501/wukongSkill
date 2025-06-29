using b1.EventDelDefine;
using BtlShare;

namespace b1;

internal class BUS_TeamIDManageComp : UActorCompBaseCS
{
	private IBUC_GuidData GuidData;

	public override void OnAttach()
	{
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_ResetTeamID += new Del_Void(OnResetTeamID);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
	}

	public override void LateBeginPlay()
	{
		SetDefaultTeamIDInternal();
	}

	private void SetDefaultTeamIDInternal()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			int teamIDInCS = int.MinValue;
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(GetOwner()));
			if (unitCommDesc != null)
			{
				teamIDInCS = unitCommDesc.TeamID;
			}
			IBIC_TaskData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(bGUCharacterCS);
			if (gameInstanceReadonlyData != null && GuidData != null && gameInstanceReadonlyData.TryGetCacheNPCTeamID(GuidData.GetFinalGuid(), out var CacheTeamID))
			{
				teamIDInCS = CacheTeamID;
			}
			OwnerAsCharacterCS.SetTeamIDInCS(teamIDInCS);
		}
	}

	private void OnResetTeamID()
	{
		SetDefaultTeamIDInternal();
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		OnResetTeamID();
	}
}
