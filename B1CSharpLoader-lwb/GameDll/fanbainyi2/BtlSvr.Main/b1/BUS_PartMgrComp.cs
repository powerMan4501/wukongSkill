using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PartMgrComp : UActorCompBaseCS
{
	private const float INV10000 = 0.0001f;

	protected BUC_PartMgrData PartMgrData;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_BeAttackData BeAttackData;

	private IBUC_SimpleStateData SimpleStateData;

	public override void OnAttach()
	{
		PartMgrData = RequireWritableData<BUC_PartMgrData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		base.BUSEventCollection.Evt_TriggerHitInPart += new Del_TriggerHitInPart(OnTriggerHitInPart);
		base.BUSEventCollection.Evt_PlayBreakPartMontage += new Del_PlayBreakPartMontage(OnPlayBreakPartMontage);
		base.BUSEventCollection.Evt_SetPartActive += new Del_Void_IntBool(OnSetPartActive);
		base.BUSEventCollection.Evt_SetLockPartHP += new Del_Void_IntBool(OnSetLockPartHP);
		base.BUSEventCollection.Evt_SetLockAllPartHP += new Del_Void_Bool(OnSetLockAllPartHP);
		base.BUSEventCollection.Evt_SetPartRuleID += new Del_Void_IntBool(SetPartRuleInfo);
		base.BUSEventCollection.Evt_ResetPartRuleID += new Del_Void(ResetPartRuleID);
		base.BUSEventCollection.Evt_RecoveryPartDamageValue += new Del_Void_Int(RecoveryPartDamageValue);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_AdvanceRemoveForcePerformanceState += new Del_Void(OnAdvanceRemoveForcePerformanceState);
		base.BUSEventCollection.Evt_RefreshCurPartRuleInfo += new Del_Void(RefreshCurPartRuleInfo);
	}

	public override void PreBeginPlay()
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(GetActorResID());
		if (unitCommDesc != null)
		{
			SetPartRuleID(unitCommDesc.DefaultPartRuleInfoID, WillUpdateDefaultRuleID: true);
		}
	}

	public override void OnBeginPlay()
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(GetActorResID());
		if (unitCommDesc != null)
		{
			AddPartsInfo(unitCommDesc.DefaultPartRuleInfoID);
			InitUIPartID();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		UpdateForRemoveSimpleState(DeltaTime);
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		ResetPartRuleID();
	}

	private void OnAdvanceRemoveForcePerformanceState()
	{
		AActor owner = GetOwner();
		if (!(owner == null) && !owner.IsPendingKill && SimpleStateData.HasSimpleState(EBGUSimpleState.BreakPart2Weak))
		{
			if (!PartMgrData.HasAlreadyRemoveForcePerformanceState)
			{
				base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ForcePerformance, IsRemove: true);
			}
			PartMgrData.HasAlreadyRemoveForcePerformanceState = true;
		}
	}

	private void UpdateForRemoveSimpleState(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (!(owner == null) && !owner.IsPendingKill && SimpleStateData.HasSimpleState(EBGUSimpleState.BreakPart2Weak) && PartMgrData.RemoveBreakPartWeakStateTimer > 0f)
		{
			PartMgrData.RemoveBreakPartWeakStateTimer -= DeltaTime;
			if (PartMgrData.RemoveBreakPartWeakStateTimer <= 0f)
			{
				RemovePartBreakSimpleState();
			}
		}
	}

	private void TryRemovePartBreakSimpleState()
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.BreakPart2Weak))
		{
			RemovePartBreakSimpleState();
		}
	}

	private void RemovePartBreakSimpleState()
	{
		base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakPart2Weak, IsRemove: true);
		if (!PartMgrData.HasAlreadyRemoveForcePerformanceState)
		{
			base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ForcePerformance, IsRemove: true);
		}
		PartMgrData.HasAlreadyRemoveForcePerformanceState = true;
		PartMgrData.RemoveBreakPartWeakStateTimer = 0f;
		PartMgrData.ResetLastBreakOrDamagedInfo();
	}

	private void SetPartRuleInfo(int PartRuleID, bool WillUpdateDefaultRuleID)
	{
		SetPartRuleID(PartRuleID, WillUpdateDefaultRuleID);
		AddPartsInfo(PartRuleID);
	}

	private void SetPartRuleID(int PartRuleID, bool WillUpdateDefaultRuleID)
	{
		if (BGW_GameDB.GetPartRuleInfoListByRuleID(GetActorResID(), PartRuleID) != null)
		{
			PartMgrData.ClearPartInfo();
			PartMgrData.PartRuleID = PartRuleID;
			if (WillUpdateDefaultRuleID)
			{
				PartMgrData.DefaultPartRuleID = PartRuleID;
			}
			PartMgrData.ShowUIPartID = -1;
			InitUIPartID();
		}
	}

	protected virtual void AddPartsInfo(int PartRuleID)
	{
		int actorResID = GetActorResID();
		GetFinalBattleInfoExtendID();
		List<int> partRuleInfoListByRuleID = BGW_GameDB.GetPartRuleInfoListByRuleID(actorResID, PartRuleID);
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(actorResID);
		if (partRuleInfoListByRuleID == null || unitCommDesc == null)
		{
			return;
		}
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.HpMaxBase);
		PartMgrData.PartDamageBaseValue = floatValue * unitCommDesc.PartDamageRadio * 0.0001f;
		foreach (int item in partRuleInfoListByRuleID)
		{
			FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(item, Owner);
			if (partRuleInfoDesc != null)
			{
				AddPart(partRuleInfoDesc.PartID, partRuleInfoDesc);
			}
		}
	}

	private void RefreshCurPartRuleInfo()
	{
		SetPartRuleInfo(PartMgrData.PartRuleID, WillUpdateDefaultRuleID: false);
	}

	protected virtual void ResetPartRuleID()
	{
		if (BGW_GameDB.GetPartRuleInfoListByRuleID(GetActorResID(), PartMgrData.DefaultPartRuleID) != null)
		{
			PartMgrData.ClearPartInfo();
			PartMgrData.PartRuleID = PartMgrData.DefaultPartRuleID;
			SetPartRuleInfo(PartMgrData.DefaultPartRuleID, WillUpdateDefaultRuleID: false);
		}
	}

	private void RecoveryPartDamageValue(int PartID)
	{
		PartMgrData.RecoveryPartDamageValue(PartID, Owner);
	}

	private void OnTriggerHitInPart(int PartID, float HitHP, int StiffLevel)
	{
		if (!(GetOwner() == null) && PartID != -1)
		{
			PartMgrData.ReducePartHP(PartID, HitHP, StiffLevel);
		}
	}

	private void OnPlayBreakPartMontage(int PartID, string BreakerGUID, EAttackerArea AttackerArea = EAttackerArea.Forward)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		int actorResID = GetActorResID();
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID) || !PartMgrData.GetPartInfo(PartID, out var PartInfoOut))
		{
			return;
		}
		FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(PartInfoOut.DescID, Owner);
		if (BGW_LogUtil.LogIfNull(partRuleInfoDesc, "Find PartRuleInfoDesc failed! DescID: {0}", PartInfoOut.DescID))
		{
			return;
		}
		int currentDamagedStage = PartInfoOut.CurrentDamagedStage;
		BGWDataAsset_PartBreakAMInfoConfig bGWDataAsset_PartBreakAMInfoConfig = BGW_PreloadAssetMgr.Get(aCharacter).TryGetCachedResourceObj<BGWDataAsset_PartBreakAMInfoConfig>(partRuleInfoDesc.DamagedAMDataAssetPath, ELoadResourceType.SyncLoadAndCache);
		UAnimMontage uAnimMontage = null;
		if (bGWDataAsset_PartBreakAMInfoConfig != null)
		{
			int num = currentDamagedStage - 1;
			if (partRuleInfoDesc.IsStageInRandomOrder == EGSYesNo.Yes && PartInfoOut.RandomOrderAvailableStages != null && PartInfoOut.RandomOrderAvailableStages.Count > 0)
			{
				int index = MathLib.RandomIntInRange(0, PartInfoOut.RandomOrderAvailableStages.Count - 1);
				num = PartInfoOut.RandomOrderAvailableStages[index];
				PartInfoOut.RandomOrderAvailableStages.RemoveAt(index);
			}
			if (num >= 0 && num < partRuleInfoDesc.PartDamagedInfoList.Count && num < bGWDataAsset_PartBreakAMInfoConfig.PartDamagedAMInfoList.Count)
			{
				if (bGWDataAsset_PartBreakAMInfoConfig.EnableExtraAreaSelectType)
				{
					AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner.World, BreakerGUID);
					if (actorByGuid != null)
					{
						FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner);
						FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
						float num2 = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(fVector.GetSafeNormal2D(), fVector2.GetSafeNormal2D());
						float pBAS_ForwardLeft_FNB = bGWDataAsset_PartBreakAMInfoConfig.PBAS_ForwardLeft_FNB;
						float pBAS_ForwardRight_FNB = bGWDataAsset_PartBreakAMInfoConfig.PBAS_ForwardRight_FNB;
						float pBAS_ForwardLeft_FourDir = bGWDataAsset_PartBreakAMInfoConfig.PBAS_ForwardLeft_FourDir;
						float pBAS_ForwardRight_FourDir = bGWDataAsset_PartBreakAMInfoConfig.PBAS_ForwardRight_FourDir;
						float pBAS_BackwardLeft_FourDir = bGWDataAsset_PartBreakAMInfoConfig.PBAS_BackwardLeft_FourDir;
						float pBAS_BackwardRight_FourDir = bGWDataAsset_PartBreakAMInfoConfig.PBAS_BackwardRight_FourDir;
						switch (bGWDataAsset_PartBreakAMInfoConfig.SectorsType)
						{
						case ENormalStiffSectorsType.AllForward:
							AttackerArea = EAttackerArea.Forward;
							break;
						case ENormalStiffSectorsType.ForwardAndBackward:
							AttackerArea = ((!(num2 >= pBAS_ForwardLeft_FNB) || !(num2 < pBAS_ForwardRight_FNB)) ? EAttackerArea.Backward : EAttackerArea.Forward);
							break;
						case ENormalStiffSectorsType.FourDir:
							AttackerArea = ((!(num2 >= pBAS_ForwardLeft_FourDir) || !(num2 < pBAS_ForwardRight_FourDir)) ? ((num2 >= pBAS_BackwardLeft_FourDir && num2 <= pBAS_ForwardLeft_FourDir) ? EAttackerArea.LeftSide : ((!(num2 <= pBAS_BackwardRight_FourDir) || !(num2 >= pBAS_ForwardRight_FourDir)) ? EAttackerArea.Backward : EAttackerArea.RightSide)) : EAttackerArea.Forward);
							break;
						}
					}
				}
				switch (AttackerArea)
				{
				case EAttackerArea.Forward:
					uAnimMontage = bGWDataAsset_PartBreakAMInfoConfig.PartDamagedAMInfoList[num].DamagedAMPathForward;
					break;
				case EAttackerArea.Backward:
					uAnimMontage = bGWDataAsset_PartBreakAMInfoConfig.PartDamagedAMInfoList[num].DamagedAMPathBackward;
					break;
				case EAttackerArea.LeftSide:
					uAnimMontage = bGWDataAsset_PartBreakAMInfoConfig.PartDamagedAMInfoList[num].DamagedAMPathLeftSide;
					break;
				case EAttackerArea.RightSide:
					uAnimMontage = bGWDataAsset_PartBreakAMInfoConfig.PartDamagedAMInfoList[num].DamagedAMPathRightSide;
					break;
				}
			}
		}
		if (uAnimMontage != null)
		{
			TryRemovePartBreakSimpleState();
			FGSMontageMoveData fGSMontageMoveData = default(FGSMontageMoveData);
			fGSMontageMoveData.Montage = uAnimMontage;
			fGSMontageMoveData.MontagePosOffset = 0f;
			fGSMontageMoveData.PlayTimeRate = 1f;
			fGSMontageMoveData.Scale = 1f;
			fGSMontageMoveData.StartSectionName = B1GlobalFNames.None;
			float num3 = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(Owner, uAnimMontage, 0);
			UGSE_AnimFuncLib.AnimMontageGetBlendInAndOutTime(uAnimMontage, out var BlendInTime, out var BlendOutTime);
			num3 -= BlendInTime + BlendOutTime;
			PartMgrData.RemoveBreakPartWeakStateTimer = num3;
			base.BUSEventCollection?.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection?.Evt_UnitTryBreakSkill.Invoke("部位破坏");
			base.BUSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, PartMgrData.RemoveBreakPartWeakStateTimer, NeedForceUpdate: true);
			base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakPart2Weak);
			base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ForcePerformance);
			PartMgrData.HasAlreadyRemoveForcePerformanceState = false;
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, fGSMontageMoveData.Montage, fGSMontageMoveData.StartSectionName, EMontageBindReason.Default, fGSMontageMoveData.Scale, fGSMontageMoveData.PlayTimeRate, fGSMontageMoveData.MontagePosOffset);
			SetPartIsBreak(PartID, BreakerGUID, Owner);
		}
	}

	private void OnSetPartActive(int PartID, bool bIsActive)
	{
		PartMgrData.SetPartActive(PartID, bIsActive);
		HandleBuffWithPartActive(PartID, bIsActive);
		PartMgrData.GetPartInfo(PartID, out var PartInfoOut);
		if (PartInfoOut != null && PartInfoOut.NeedShowUI)
		{
			SetUIPartID(PartID, PartInfoOut.MaxPartDamagedValue);
		}
		TriggerShowPartUI(PartID);
	}

	private void OnSetLockPartHP(int PartID, bool IsLocked)
	{
		PartMgrData.SetLockPartHP(PartID, IsLocked);
	}

	private void OnSetLockAllPartHP(bool IsLocked)
	{
		PartMgrData.SetLockAllPartHP(IsLocked);
	}

	private void InitUIPartID()
	{
		if (PartMgrData.PartInfoDataDic != null)
		{
			foreach (KeyValuePair<int, PartInfoData> item in PartMgrData.PartInfoDataDic)
			{
				FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(item.Value.DescID, Owner);
				if (partRuleInfoDesc != null && partRuleInfoDesc.NeedShowUI == EGSYesNo.Yes)
				{
					SetUIPartID(item.Key, item.Value.MaxPartDamagedValue);
					break;
				}
			}
		}
		TriggerShowPartUI(PartMgrData.ShowUIPartID);
	}

	private void HandleBuffWithPartActive(int PartID, bool bIsActive)
	{
		if (PartMgrData.PartInfoDataDic == null || !PartMgrData.PartInfoDataDic.TryGetValue(PartID, out var value) || value.BuffIDList == null)
		{
			return;
		}
		foreach (int buffID in value.BuffIDList)
		{
			if (bIsActive)
			{
				base.BUSEventCollection?.Evt_BuffAdd.Invoke(buffID, Owner, Owner, 0f, EBuffSourceType.PartMgr);
			}
			else
			{
				base.BUSEventCollection?.Evt_BuffRemove.Invoke(buffID, EBuffEffectTriggerType.None, 1);
			}
		}
	}

	private void AddPart(int PartID, FUStPartRuleInfoDesc PartRuleInfoDesc)
	{
		if (PartMgrData.PartInfoDataDic != null && !PartMgrData.PartInfoDataDic.TryGetValue(PartID, out var _))
		{
			FUStPartHitExpandDesc partHitExpandDesc = BGW_GameDB.GetPartHitExpandDesc(PartRuleInfoDesc.PartRuleID, PartRuleInfoDesc.PartID);
			PartMgrData.PartInfoDataDic.Add(PartID, new PartInfoData(GetActorResID(), BeAttackData.GetCurrentBeAttackedInfoID(), PartMgrData.PartDamageBaseValue, PartRuleInfoDesc, partHitExpandDesc));
			OnSetPartActive(PartID, PartRuleInfoDesc.IsActive == EGSYesNo.Yes);
		}
	}

	private void SetPartIsBreak(int PartID, string BreakerGUID, AActor Owner)
	{
		if (PartMgrData.PartInfoDataDic == null || !PartMgrData.PartInfoDataDic.TryGetValue(PartID, out var value) || !(value.CurrentPartDamagedValue <= 0f))
		{
			return;
		}
		PartMgrData.LastBreakOrDamagedPartID = PartID;
		PartMgrData.LastBreakerGUID = BreakerGUID;
		PartMgrData.LastIsTriggerBreak = false;
		PartMgrData.CanGetValidLastBreakOrDamagedInfo = true;
		if (value.CurrentDamagedStage == value.TotalDamagedStage)
		{
			PartMgrData.LastIsTriggerBreak = true;
			value.IsBreak = true;
			HandleBuffWithPartActive(PartID, bIsActive: false);
			return;
		}
		value.CurrentDamagedStage++;
		FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(value.DescID, Owner);
		if (partRuleInfoDesc != null)
		{
			value.CurrentPartDamagedValue = partRuleInfoDesc.PartDamagedInfoList[value.CurrentDamagedStage - 1].DamagedValueRatio * 0.0001f * value.PartDamagedBaseValue;
		}
	}

	private void TriggerShowPartUI(int PartID)
	{
		if (PartID == PartMgrData.ShowUIPartID && PartMgrData.ShowUIPartID >= 0)
		{
			PartMgrData.GetPartInfo(PartMgrData.ShowUIPartID, out var PartInfoOut);
			if (PartInfoOut != null)
			{
				base.BUSEventCollection?.Evt_TriggerShowUnitPartUI.Invoke(PartInfoOut.IsActive);
			}
		}
	}

	private void SetUIPartID(int PartID, float MaxPartDamagedValue)
	{
		PartMgrData.ShowUIPartID = PartID;
		base.BUSEventCollection?.Evt_UIPartIDChanged.Invoke(PartID, MaxPartDamagedValue);
	}
}
