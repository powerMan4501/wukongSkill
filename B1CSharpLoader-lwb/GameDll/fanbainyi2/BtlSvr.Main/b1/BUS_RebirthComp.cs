using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_RebirthComp : UActorCompBaseCS
{
	public BPC_RebirthPointData RebirthPointData;

	private IBUC_GuidData GuidData;

	private BUC_UnitDebugData UnitDebugData;

	private BIC_GMRebirthData GMRebirthData;

	private BPS_GSEventCollection BPSEventCollection;

	public override void OnAttach()
	{
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		UnitDebugData = RequireWritableData<BUC_UnitDebugData>();
		RebirthPointData = BGU_DataUtil.GetReadOnlyData<BPC_RebirthPointData>(GetOwner().GetInstigatorController());
		GMRebirthData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(GetOwner()).GetGameInstanceWritableData<BIC_GMRebirthData>();
		base.BUSEventCollection.Evt_UnitRebirth += new Del_UnitRebirth(OnUnitRebirth);
		base.BUSEventCollection.Evt_UnitRebirth_ByItem += new Del_UnitRebirth(OnUnitRebirthByItem);
		base.BUSEventCollection.Evt_RebirthTeleportFinish += (Del_Void_RebirthType)delegate(ERebirthType Type)
		{
			ProcessUnitRebirth(Type);
		};
		base.BUSEventCollection.Evt_TeleportWithRebirthPointFailed += new Del_TeleportWithRebirthPointCallback(OnTeleportWithRebirthPointFailed);
		base.BUSEventCollection.Evt_TeleportWithRebirthPointStreamingLevelLoaded += new Del_TeleportWithRebirthPointCallback(OnTeleportWithRebirthPointStreamingLevelLoaded);
		base.BUSEventCollection.Evt_GMRecordRebirthPos += new Del_Void(OnGMRecordRebirthPos);
		base.BUSEventCollection.Evt_GMRecordRebirthPosWithDetailData += new Del_GMRecordRebirthPosWithDetailData(OnGMRecordRebirthPosWithDetailData);
		base.BUSEventCollection.Evt_TriggerResetAllActors += new Del_Void(OnTriggerResetAllActors);
		APawn aPawn = Owner as APawn;
		if (aPawn != null)
		{
			BPSEventCollection = BPS_EventCollectionCS.Get(aPawn.PlayerState);
		}
	}

	public override void OnBeginPlay()
	{
	}

	private void OnTeleportWithRebirthPointFailed(int RebirthPointID, ETeleportReason Reason)
	{
		if (Reason == ETeleportReason.Rebirth)
		{
			ProcessUnitRebirth(ERebirthType.RebirthPoint);
		}
	}

	private void OnUnitRebirthByItem(ERebirthType RebirthType)
	{
		APawn worldContext = GetOwner() as APawn;
		int overrideRebirthPointId = 0;
		if (RebirthPointData != null)
		{
			int currentRebirthPointID = RebirthPointData.GetCurrentRebirthPointID(worldContext);
			if (currentRebirthPointID == 3028 || currentRebirthPointID == 3029)
			{
				overrideRebirthPointId = 3026;
			}
		}
		UnitRebirthLogic(RebirthType, overrideRebirthPointId);
	}

	private void OnUnitRebirth(ERebirthType RebirthType)
	{
		UnitRebirthLogic(RebirthType);
	}

	private void UnitRebirthLogic(ERebirthType RebirthType, int OverrideRebirthPointId = 0)
	{
		if (B1Global.GIsBossRushMode)
		{
			return;
		}
		if (RebirthType == ERebirthType.RebirthPoint || RebirthType == ERebirthType.SelfRescue)
		{
			APawn aPawn = GetOwner() as APawn;
			if (UnitDebugData != null && GMRebirthData.UseGMRebirthTeleport)
			{
				BPSEventCollection?.Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.SimpleLevelIdAndTransform, new TeleportParam_SimpleLevelIdAndTransform
				{
					LevelId = GMRebirthData.GMRebirthLevelID,
					TeleportTransform = new FTransform(GMRebirthData.GMRebirthRot, GMRebirthData.GMRebirthPos),
					TeleportFinishCallback = delegate
					{
						ProcessUnitRebirth(RebirthType);
					}
				}, EPlayerTeleportReason.Rebirth);
			}
			else if (RebirthPointData != null && aPawn != null)
			{
				int num = RebirthPointData.GetCurrentRebirthPointID(aPawn);
				if (OverrideRebirthPointId > 0)
				{
					num = OverrideRebirthPointId;
				}
				BPSEventCollection?.Evt_SetCurrentRebirthPoint.Invoke(num);
				BPSEventCollection?.Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.RebirthPoint, new TeleportParam_RebirthPoint
				{
					RebirthPointId = num,
					RebirthType = RebirthType
				}, EPlayerTeleportReason.Rebirth);
			}
			else
			{
				BGW_LogUtil.LogError("OnUnitRebirth 无法获取当前复活点数据！");
			}
		}
		else
		{
			ProcessUnitRebirth(RebirthType);
		}
	}

	private void OnTeleportWithRebirthPointStreamingLevelLoaded(int RebirthPointConfigID, ETeleportReason Reason)
	{
		if (Reason == ETeleportReason.Rebirth)
		{
			ProcessUnitRebirth(ERebirthType.RebirthPoint);
		}
	}

	private void ProcessUnitRebirth(ERebirthType RebirthType)
	{
		switch (RebirthType)
		{
		case ERebirthType.RebirthPoint:
			OnRebirthPointRebirth();
			break;
		case ERebirthType.Quick:
			OnQuickRebirth();
			break;
		case ERebirthType.SelfRescue:
			OnQuickRebirth();
			break;
		}
		base.BUSEventCollection.Evt_AfterUnitRebirth.Invoke(RebirthType);
		string finalGuid = GuidData.GetFinalGuid();
		base.BGWEventCollection.Evt_SetActorAliveState(finalGuid, P2: true);
	}

	private void OnSetCurrentRebirthPointInfo(int RebirthPointID)
	{
		BPSEventCollection.Evt_SetCurrentRebirthPoint.Invoke(RebirthPointID);
	}

	private void OnQuickRebirth()
	{
		CommonRebirthLogic();
	}

	private void OnRebirthPointRebirth()
	{
		CommonRebirthLogic();
	}

	private void OnTriggerResetAllActors()
	{
		base.BGWEventCollection.Evt_TriggerResetAllActors(EResetActorReason.Rebirth);
	}

	private bool CheckIsStandAloneGame()
	{
		return UGSE_EngineFuncLib.IsStandAlone(GetOwner().World);
	}

	private void CommonRebirthLogic()
	{
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc((GetOwner() as BGUCharacterCS).GetResID(), Owner);
		if (playerCommDesc == null || !(base.BUSEventCollection != null))
		{
			return;
		}
		base.BUSEventCollection.Evt_NotifyCanAddBuff.Invoke();
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Rebirth, -1f);
		if (B1Global.GIsBossRushMode)
		{
			BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
			if (bGUCharacterCS != null && bGUCharacterCS.Mesh != null)
			{
				bGUCharacterCS.Mesh.GetAnimInstance()?.Montage_Stop(0f, null);
			}
		}
		else
		{
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(playerCommDesc.RebirthSkillID, ECastSkillSourceType.Rebirth));
		}
		base.BUSEventCollection.Evt_UnitRebirthFinished.Invoke();
		BPSEventCollection?.Evt_BPS_UnitRebirthFinished.Invoke();
		base.BUSEventCollection.Evt_TriggerPlayerRestByReBirth.Invoke();
		base.BUSEventCollection.Evt_EnableCanSetTarget.Invoke(P1: true);
		base.BGWEventCollection?.Evt_SetAllUnitCannotDead(P1: false);
		base.BGWEventCollection?.Evt_IgnoreAllOverlapEvent(P1: false);
	}

	private void OnGMRecordRebirthPos()
	{
		GMRebirthData.UseGMRebirthTeleport = true;
		GMRebirthData.GMRebirthLevelID = 0;
		GMRebirthData.GMRebirthPos = GetOwner().GetActorLocation();
		GMRebirthData.GMRebirthRot = GetOwner().GetActorRotation();
	}

	private void OnGMRecordRebirthPosWithDetailData(int LevelID, FVector Location, FRotator Rotator)
	{
		GMRebirthData.UseGMRebirthTeleport = true;
		GMRebirthData.GMRebirthLevelID = LevelID;
		GMRebirthData.GMRebirthPos = GetOwner().GetActorLocation();
		GMRebirthData.GMRebirthRot = GetOwner().GetActorRotation();
	}
}
