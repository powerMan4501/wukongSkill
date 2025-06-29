using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.TressFX;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_AbnormalStateCompImpl : UActorCompBaseCS
{
	private BUC_AbnormalStateData AbnormalStateData;

	private BUC_AbnormalStateHandlers AbnormalStateHanddlers;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_GuidData GuidData;

	private IBUC_BeAttackData BeAttackData;

	private IBUC_PropMgrData PropMgrData;

	private BUS_DispLibEventCollection DispLibEventCollection;

	private T CreateAbnormalStateHanddler<T>() where T : BGU_AbnormalStateHandlerBase, new()
	{
		T val = new T();
		val.InitData(Owner as BGUCharacterCS, this, AbnormalStateData.DefaultAbnormalAttrConfig);
		return val;
	}

	public override void OnAttach()
	{
		AbnormalStateData = RequireWritableData<BUC_AbnormalStateData>();
		AbnormalStateHanddlers = RequireWritableData<BUC_AbnormalStateHandlers>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_HandleAbnormal += new Del_HandleAbnormal(HandleAbnormal);
		base.BUSEventCollection.Evt_DecreaseAbnormalAccValue += new Del_DecreaseAbnormalAccValue(DecreaseAbnormalAccValue);
		base.BUSEventCollection.Evt_RemoveAbnormalFinalEffectByStep += new Del_RemoveAbnormalFinalEffectByStep(RemoveAbnormalFinalEffectByStep);
		base.BUSEventCollection.Evt_ClearAbnormalState += new Del_ClearAbnormalState(ClearAbnormalState);
		base.BUSEventCollection.Evt_ClearAllAbnormalState += new Del_Void(ClearAllAbnormalState);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_TriggerFrozen += new Del_Void(OnTriggerFrozen);
		base.BUSEventCollection.Evt_HitWhenInFrozen += new Del_HitWhenInFrozen(OnHitWhenInFrozen);
		base.BUSEventCollection.Evt_TriggerFrozenBreak += new Del_TriggerFrozenBreak(OnTriggerFrozenBreakByHit);
		base.BUSEventCollection.Evt_TriggerFrozenBreakByAssist += new Del_TriggerFrozenBreakByAssist(OnTriggerFrozenBreakByAssist);
		base.BUSEventCollection.Evt_OnUnFreezeCountAcc += new Del_Void_Int(OnUnFreezeCountAcc);
		base.BUSEventCollection.Evt_EndFrozen += new Del_Void(interface_EndFrozen);
		DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
	}

	public override void PreBeginPlay()
	{
		if (BGU_DataUtil.GetActorType(Owner) == BGU_ActorType.CharacterPlayer)
		{
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(OwnerAsCharacterCS.GetResID(), Owner);
			if (playerCommDesc != null)
			{
				AbnormalStateData.UnFreezeCount = playerCommDesc.UnFreezeCount;
				AbnormalStateData.UnFreezeAdditiveAMPath = playerCommDesc.UnFreezeAdditiveAMPath;
				AbnormalStateData.UnFreezeEventGap = playerCommDesc.UnFreezeEventGap;
				AbnormalStateData.UnFreezeFXPath = playerCommDesc.UnFreezeFXPath;
			}
		}
		InitAttr();
		AbnormalStateHanddlers.AbnormalHanddler_Freeze = CreateAbnormalStateHanddler<BGU_AbnormalStateHanddler_Freeze>();
		AbnormalStateHanddlers.AbnormalHanddler_Burn = CreateAbnormalStateHanddler<BGU_AbnormalStateHanddler_Burn>();
		AbnormalStateHanddlers.AbnormalHanddler_Poison = CreateAbnormalStateHanddler<BGU_AbnormalStateHanddler_Poison>();
		AbnormalStateHanddlers.AbnormalHanddler_Thunder = CreateAbnormalStateHanddler<BGU_AbnormalStateHanddler_Thunder>();
		AbnormalStateHanddlers.AbnormalHanddler_Yin = CreateAbnormalStateHanddler<BGU_AbnormalStateHanddler_Yin>();
		AbnormalStateHanddlers.AbnormalHanddler_Yang = CreateAbnormalStateHanddler<BGU_AbnormalStateHanddler_Yang>();
	}

	public override void OnBeginPlay()
	{
		InitImmueInfo();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		AbnormalStateHanddlers.AbnormalHanddler_Freeze?.Release();
		AbnormalStateHanddlers.AbnormalHanddler_Burn?.Release();
		AbnormalStateHanddlers.AbnormalHanddler_Poison?.Release();
		AbnormalStateHanddlers.AbnormalHanddler_Thunder?.Release();
		AbnormalStateHanddlers.AbnormalHanddler_Yin?.Release();
		AbnormalStateHanddlers.AbnormalHanddler_Yang?.Release();
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		FrozenBreakProtectTick();
		if (AbnormalStateData.bActive_AbnormalState)
		{
			AbnormalStateHanddlers.AbnormalHanddler_Freeze.DoUpdate(DeltaTime);
			AbnormalStateHanddlers.AbnormalHanddler_Burn.DoUpdate(DeltaTime);
			AbnormalStateHanddlers.AbnormalHanddler_Poison.DoUpdate(DeltaTime);
			AbnormalStateHanddlers.AbnormalHanddler_Thunder.DoUpdate(DeltaTime);
			AbnormalStateHanddlers.AbnormalHanddler_Yin.DoUpdate(DeltaTime);
			AbnormalStateHanddlers.AbnormalHanddler_Yang.DoUpdate(DeltaTime);
			UpdateUIData();
			Update_Active_AbnormalState();
		}
	}

	internal BUS_GSEventCollection GetBUSEventCollection()
	{
		return base.BUSEventCollection;
	}

	internal BUS_DispLibEventCollection GetDispLibEventCollection()
	{
		return DispLibEventCollection;
	}

	private void UpdateUIData()
	{
		List<EAbnormalStateType> allActiveAbnormalState = AbnormalStateHanddlers.GetAllActiveAbnormalState();
		foreach (EAbnormalStateType item in allActiveAbnormalState)
		{
			if (AbnormalStateData.AbnormalStateUIInfoDic.ContainsKey(item))
			{
				AbnormalStateData.AbnormalStateUIInfoDic[item].bIsInFinalState.SetValue(EChangeReason.ManualSet, AbnormalStateHanddlers.IsInFinalState(item));
				AbnormalStateData.AbnormalStateUIInfoDic[item].TotalTime_FinalEffectBuff = AbnormalStateHanddlers.GetFinalEffectTotalTime(item);
				AbnormalStateData.AbnormalStateUIInfoDic[item].RemainTime_FinalEffectBuff = AbnormalStateHanddlers.GetFinalEffectRemainTime(item);
				AbnormalStateData.AbnormalStateUIInfoDic[item].FinalEffectBuffID.SetValue(EChangeReason.ManualSet, AbnormalStateHanddlers.GetCurFinalEffectBuffID(item));
			}
			else
			{
				FAbnormalStateUIInfo fAbnormalStateUIInfo = new FAbnormalStateUIInfo();
				fAbnormalStateUIInfo.bIsInFinalState.SetValue(EChangeReason.ManualSet, AbnormalStateHanddlers.IsInFinalState(item));
				fAbnormalStateUIInfo.TotalTime_FinalEffectBuff = AbnormalStateHanddlers.GetFinalEffectTotalTime(item);
				fAbnormalStateUIInfo.RemainTime_FinalEffectBuff = AbnormalStateHanddlers.GetFinalEffectRemainTime(item);
				fAbnormalStateUIInfo.FinalEffectBuffID.SetValue(EChangeReason.ManualSet, AbnormalStateHanddlers.GetCurFinalEffectBuffID(item));
				AbnormalStateData.AbnormalStateUIInfoDic.Add(item, fAbnormalStateUIInfo);
			}
		}
		if (AbnormalStateData.AbnormalStateUIInfoDic.Count <= 0)
		{
			return;
		}
		foreach (EAbnormalStateType item2 in AbnormalStateData.AbnormalStateUIInfoDic.Keys.ToList())
		{
			if (!allActiveAbnormalState.Contains(item2))
			{
				AbnormalStateData.AbnormalStateUIInfoDic.Remove(item2);
			}
		}
	}

	private void InitAttr()
	{
		BGWDataAsset_AbnormalAttrConfig bGWDataAsset_AbnormalAttrConfig = AbnormalStateData.DefaultAbnormalAttrConfig;
		if (bGWDataAsset_AbnormalAttrConfig == null)
		{
			FUStUnitLevelUpDesc unitLevelUpDesc = BGW_GameDB.GetUnitLevelUpDesc(GetActorResID(), GetFinalBattleInfoExtendID());
			if (unitLevelUpDesc == null)
			{
				return;
			}
			string commAbnormalAttrConfigPath = unitLevelUpDesc.CommAbnormalAttrConfigPath;
			bGWDataAsset_AbnormalAttrConfig = PreloadAssetMgr.TryGetCachedResourceObj<BGWDataAsset_AbnormalAttrConfig>(commAbnormalAttrConfigPath, ELoadResourceType.SyncLoadAndCache);
			AbnormalStateData.DefaultAbnormalAttrConfig = bGWDataAsset_AbnormalAttrConfig;
		}
		base.BUSEventCollection.Evt_InitAbnormalAttrs.Invoke(bGWDataAsset_AbnormalAttrConfig);
	}

	private void InitImmueInfo()
	{
		if ((AbnormalStateData.AbnormalStateImmueList.Count < 1 && AbnormalStateData.BirthAbnormalStateList.Count < 1) || GetOwner().IsNullOrDestroyed())
		{
			return;
		}
		foreach (Birth_AbnormalStateImmueType abnormalStateImmue in AbnormalStateData.AbnormalStateImmueList)
		{
			EBGUSimpleState eBGUSimpleState = EBGUSimpleState.Normal;
			switch (abnormalStateImmue)
			{
			case Birth_AbnormalStateImmueType.FreezeImmue:
				eBGUSimpleState = EBGUSimpleState.FreezeImmue;
				break;
			case Birth_AbnormalStateImmueType.BurnImmue:
				eBGUSimpleState = EBGUSimpleState.BurnImmue;
				break;
			case Birth_AbnormalStateImmueType.PoisonImmue:
				eBGUSimpleState = EBGUSimpleState.PoisonImmue;
				break;
			case Birth_AbnormalStateImmueType.ThunderImmue:
				eBGUSimpleState = EBGUSimpleState.ThunderImmue;
				break;
			}
			if (eBGUSimpleState != EBGUSimpleState.Normal)
			{
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(eBGUSimpleState);
			}
		}
		foreach (Birth_AbnomalState birthAbnormalState in AbnormalStateData.BirthAbnormalStateList)
		{
			AbnormalStateHanddlers.GetAbnormalHanddler(birthAbnormalState.AbnormalStateType)?.TriggerFinalEffect_Immediately(birthAbnormalState.AbnormalStateLevel);
		}
	}

	private void HandleAbnormal(EAbnormalStateType AbnormalType, AActor Attacker, EAccAbnormalValueType AccType, float IncreaseValue, int AbnormalLevel)
	{
		if (IncreaseValue <= 0f)
		{
			return;
		}
		BGU_AbnormalStateHandlerBase bGU_AbnormalStateHandlerBase = null;
		switch (AbnormalType)
		{
		case EAbnormalStateType.Abnormal_Freeze:
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.ImmueFreezeAcc) || UnitStateData.HasState(EBGUUnitState.FreezeAccProtect) || SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) || SimpleStateData.HasSimpleState(EBGUSimpleState.InInteractAnimationSyncing))
			{
				return;
			}
			bGU_AbnormalStateHandlerBase = AbnormalStateHanddlers.AbnormalHanddler_Freeze;
			if (AbnormalStateHanddlers.AbnormalHanddler_Burn.IsInFinalEffect())
			{
				return;
			}
			if (AbnormalStateHanddlers.AbnormalHanddler_Burn.IsActive())
			{
				float RemainingIncreaseValue3;
				float accValueFroOppositeDecrease3 = AbnormalStateHanddlers.AbnormalHanddler_Freeze.GetAccValueFroOppositeDecrease(AccType, EBGUAttrFloat.BurnAbnormalAcc, IncreaseValue, out RemainingIncreaseValue3);
				DecreaseAbnormalAccValue(EAbnormalStateType.Abnormal_Burn, accValueFroOppositeDecrease3);
				if (!(RemainingIncreaseValue3 > 0f))
				{
					return;
				}
				AccType = EAccAbnormalValueType.IncreaseByValue;
				IncreaseValue = RemainingIncreaseValue3;
			}
			break;
		case EAbnormalStateType.Abnormal_Burn:
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.ImmueBurnAcc))
			{
				return;
			}
			bGU_AbnormalStateHandlerBase = AbnormalStateHanddlers.AbnormalHanddler_Burn;
			if (AbnormalStateHanddlers.AbnormalHanddler_Freeze.IsInFinalEffect())
			{
				return;
			}
			if (AbnormalStateHanddlers.AbnormalHanddler_Freeze.IsActive())
			{
				float RemainingIncreaseValue2;
				float accValueFroOppositeDecrease2 = AbnormalStateHanddlers.AbnormalHanddler_Burn.GetAccValueFroOppositeDecrease(AccType, EBGUAttrFloat.FreezeAbnormalAcc, IncreaseValue, out RemainingIncreaseValue2);
				DecreaseAbnormalAccValue(EAbnormalStateType.Abnormal_Freeze, accValueFroOppositeDecrease2);
				if (!(RemainingIncreaseValue2 > 0f))
				{
					return;
				}
				AccType = EAccAbnormalValueType.IncreaseByValue;
				IncreaseValue = RemainingIncreaseValue2;
			}
			break;
		case EAbnormalStateType.Abnormal_Thunder:
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.ImmueThunderAcc))
			{
				return;
			}
			bGU_AbnormalStateHandlerBase = AbnormalStateHanddlers.AbnormalHanddler_Thunder;
			break;
		case EAbnormalStateType.Abnormal_Poison:
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.ImmuePoisonAcc))
			{
				return;
			}
			bGU_AbnormalStateHandlerBase = AbnormalStateHanddlers.AbnormalHanddler_Poison;
			break;
		case EAbnormalStateType.Abnormal_Yin:
			bGU_AbnormalStateHandlerBase = AbnormalStateHanddlers.AbnormalHanddler_Yin;
			if (AbnormalStateHanddlers.AbnormalHanddler_Yang.IsInFinalEffect())
			{
				AbnormalStateHanddlers.AbnormalHanddler_Yang.OnClearAbnormal();
			}
			else if (AbnormalStateHanddlers.AbnormalHanddler_Yang.IsActive())
			{
				float RemainingIncreaseValue4;
				float accValueFroOppositeDecrease4 = AbnormalStateHanddlers.AbnormalHanddler_Yin.GetAccValueFroOppositeDecrease(AccType, EBGUAttrFloat.YangAbnormalAcc, IncreaseValue, out RemainingIncreaseValue4);
				DecreaseAbnormalAccValue(EAbnormalStateType.Abnormal_Yang, accValueFroOppositeDecrease4);
				if (!(RemainingIncreaseValue4 > 0f))
				{
					return;
				}
				AccType = EAccAbnormalValueType.IncreaseByValue;
				IncreaseValue = RemainingIncreaseValue4;
			}
			break;
		case EAbnormalStateType.Abnormal_Yang:
			bGU_AbnormalStateHandlerBase = AbnormalStateHanddlers.AbnormalHanddler_Yang;
			if (AbnormalStateHanddlers.AbnormalHanddler_Yin.IsInFinalEffect())
			{
				AbnormalStateHanddlers.AbnormalHanddler_Yin.OnClearAbnormal();
			}
			else if (AbnormalStateHanddlers.AbnormalHanddler_Yin.IsActive())
			{
				float RemainingIncreaseValue;
				float accValueFroOppositeDecrease = AbnormalStateHanddlers.AbnormalHanddler_Yang.GetAccValueFroOppositeDecrease(AccType, EBGUAttrFloat.YinAbnormalAcc, IncreaseValue, out RemainingIncreaseValue);
				DecreaseAbnormalAccValue(EAbnormalStateType.Abnormal_Yin, accValueFroOppositeDecrease);
				if (!(RemainingIncreaseValue > 0f))
				{
					return;
				}
				AccType = EAccAbnormalValueType.IncreaseByValue;
				IncreaseValue = RemainingIncreaseValue;
			}
			break;
		}
		bGU_AbnormalStateHandlerBase.IncreaseAccumulatedValue(Attacker, AccType, IncreaseValue, AbnormalLevel);
		Update_Active_AbnormalState();
	}

	private void Update_Active_AbnormalState()
	{
		if (AbnormalStateHanddlers.GetAllActiveAbnormalState().Count > 0)
		{
			AbnormalStateData.bActive_AbnormalState = true;
		}
	}

	private void DecreaseAbnormalAccValue(EAbnormalStateType AbnormalType, float DecreaseValue)
	{
		if (!(DecreaseValue <= 0f))
		{
			AbnormalStateHanddlers.GetAbnormalHanddler(AbnormalType).DecreaseAccumulatedValue(DecreaseValue);
		}
	}

	private void RemoveAbnormalFinalEffectByStep(EAbnormalStateType AbnormalType, int StepValue)
	{
		AbnormalStateHanddlers.GetAbnormalHanddler(AbnormalType).RemoveFinalEffectByStep(StepValue);
	}

	private void ClearAllAbnormalState()
	{
		int num = 7;
		for (int i = 1; i < num; i++)
		{
			EAbnormalStateType eAbnormalStateType = (EAbnormalStateType)i;
			AbnormalStateHanddlers.GetAbnormalHanddler(eAbnormalStateType).OnClearAbnormal();
			ClearAbnorml_ForUIData(eAbnormalStateType);
		}
	}

	private void ClearAbnormalState(HashSet<EAbnormalStateType> AbnormalStateTypeList)
	{
		foreach (EAbnormalStateType AbnormalStateType in AbnormalStateTypeList)
		{
			AbnormalStateHanddlers.GetAbnormalHanddler(AbnormalStateType).OnClearAbnormal();
			ClearAbnorml_ForUIData(AbnormalStateType);
		}
	}

	private void ClearAbnorml_ForUIData(EAbnormalStateType AbnormalStateType)
	{
		if (AbnormalStateData.AbnormalStateUIInfoDic.ContainsKey(AbnormalStateType))
		{
			AbnormalStateData.AbnormalStateUIInfoDic.Remove(AbnormalStateType);
		}
	}

	private void OnHitWhenInFrozen(float FinalDmgValue)
	{
		if (AbnormalStateData.IsInFrozen && !AbnormalStateData.FrozenBreakProtect)
		{
			AbnormalStateData.CurrentFrozenBrokenAccHP -= FinalDmgValue;
		}
	}

	private void OnTriggerFrozenBreakByHit(in FEffectInstReq EffectInstReq, UAnimMontage FrozenBreakAM, bool bIsNormalStiff)
	{
		if (!AbnormalStateData.IsInFrozen)
		{
			return;
		}
		AbnormalStateHanddlers.AbnormalHanddler_Freeze.PlayBrokenFX();
		EndFrozen();
		if (!bIsNormalStiff && FrozenBreakAM != null)
		{
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("冰冻击碎");
			float num = BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, FrozenBreakAM, FName.None);
			if (num > 0f)
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.FreezeAccProtectBegin, FMath.Min(0.2f, num));
			}
		}
		BUS_EventCollectionCS.Get(EffectInstReq.Attacker)?.Evt_TriggerSkillEffect.Invoke(AbnormalStateData.TriggerSkillEffectID_WhenFrozenBroken, EffectInstReq, Owner);
	}

	private void OnTriggerFrozenBreakByAssist(in FEffectInstReq EffectInstReq)
	{
		if (!AbnormalStateData.IsInFrozen)
		{
			return;
		}
		AbnormalStateHanddlers.AbnormalHanddler_Freeze.PlayBrokenFX();
		EndFrozen();
		if (BeAttackData == null)
		{
			return;
		}
		BGWDataAsset_UnitBeAttackedConfig uBAConfig = BGW_PreloadAssetMgr.Get(Owner).GetUBAConfig(GetActorResID(), GetFinalBattleInfoExtendID(), GuidData.GetFinalGuid(), BeAttackData.UnitBeAttackedConfigPath);
		if (!(uBAConfig != null))
		{
			return;
		}
		bool enable_Rotate_AssistBreakFrozen = uBAConfig.Enable_Rotate_AssistBreakFrozen;
		UAnimMontage assistBreakFrozenAM = uBAConfig.AssistBreakFrozenAM;
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		if (enable_Rotate_AssistBreakFrozen && EffectInstReq.Attacker != null)
		{
			FVector start = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
			FVector target = BGUFuncLibActorTransformCS.BGUGetActorLocation(EffectInstReq.Attacker);
			FRotator newRotation = UMathLibrary.FindLookAtRotation(start, target);
			newRotation.Pitch = 0f;
			newRotation.Roll = 0f;
			BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, newRotation, bTeleportPhysics: false);
		}
		if (assistBreakFrozenAM != null)
		{
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("援助冰冻破碎");
			float num = BGUFuncLibAnim.BGUActorTryPlayMontage(owner, assistBreakFrozenAM, FName.None);
			if (num > 0f)
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.FreezeAccProtectBegin, FMath.Min(0.2f, num));
			}
		}
	}

	private void FrozenBreakProtectTick()
	{
		if (AbnormalStateData.IsInFrozen && AbnormalStateData.FrozenBreakProtect)
		{
			AbnormalStateData.FrozenBreakProtect = false;
		}
	}

	private void OnUnFreezeCountAcc(int UnFreezeCount)
	{
		if (!AbnormalStateData.IsInFrozen || AbnormalStateData.UnFreezeCount <= 0)
		{
			return;
		}
		AbnormalStateData.UnFreezeCounter--;
		float timeSeconds = Owner.World.GetTimeSeconds();
		if (timeSeconds >= AbnormalStateData.UnFreeze_LastPlayAMTime + AbnormalStateData.UnFreezeEventGap)
		{
			AbnormalStateData.UnFreeze_LastPlayAMTime = timeSeconds;
			if (!SimpleStateData.HasSimpleState(EBGUSimpleState.CantPlayShakeFreezeAM))
			{
				UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UAnimMontage>(AbnormalStateData.UnFreezeAdditiveAMPath, ELoadResourceType.SyncLoadAndCache);
				if (uAnimMontage != null)
				{
					BGUFuncLibAnim.BGUActorTryPlayMontage(OwnerAsCharacterCS, uAnimMontage, FName.None);
				}
			}
			AbnormalStateHanddlers.AbnormalHanddler_Freeze.PlayShakeFX();
		}
		if (AbnormalStateData.UnFreezeCounter <= 0)
		{
			AbnormalStateHanddlers.AbnormalHanddler_Freeze.PlayAutoReleaseFX();
			EndFrozen();
		}
	}

	private void OnTriggerFrozen()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			base.BUSEventCollection.Evt_RelieveImmobilized.Invoke();
		}
		BGUFuncLibAnim.BGUSetCharacterMontagePlaying(bGUCharacterCS, IsPlaying: false);
		bGUCharacterCS.LaunchCharacter(FVector.ZeroVector, bXYOverride: true, bZOverride: true);
		bGUCharacterCS.CharacterMovement.Deactivate();
		BGUFuncLibAnim.BGUSetUseSnapshotPose(bGUCharacterCS, bUseSnapshot: true, 0f);
		base.BUSEventCollection.Evt_SetAllSweepCheckPaused.Invoke(P1: true);
		base.BUSEventCollection.Evt_SetAllAttackWarningPaused.Invoke(P1: true);
		if (!OwnerAsCharacterCS.IsPlayerCharacterCS())
		{
			List<UActorComponent> componentsByClass = OwnerAsCharacterCS.GetComponentsByClass(UClass.GetClass<UActorComponent>());
			if (componentsByClass != null && componentsByClass.Count > 0)
			{
				foreach (UActorComponent item in componentsByClass)
				{
					if (item is USkeletalMeshComponent uSkeletalMeshComponent)
					{
						uSkeletalMeshComponent.SuspendClothingSimulation();
					}
					else if (item is UTressFXComponent uTressFXComponent)
					{
						uTressFXComponent.SetSimulatePhysics(bSimulate: false);
					}
				}
			}
		}
		base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
		if (UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			if (AbnormalStateData.EnableIKHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetBoolBoolProperty.Invoke(EPropType.Mesh_EnableFootIK, Value1: false, Value2: false);
				AbnormalStateData.EnableIKHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetBoolBoolProperty.Invoke(EPropType.Mesh_EnableFootIK, Value1: false, Value2: false, AbnormalStateData.EnableIKHandleID);
			}
		}
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Frozen);
		AbnormalStateData.IsInFrozen = true;
		AbnormalStateData.FrozenBreakProtect = true;
		AbnormalStateData.UnFreezeCounter = AbnormalStateData.UnFreezeCount;
		if (BGU_DataUtil.GetActorType(Owner) == BGU_ActorType.CharacterPlayer && OwnerAsCharacterCS.IsLocallyControlled())
		{
			base.BGWEventCollection.Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.Unfreeze, bEnable: true);
		}
		BUS_DispLibEventCollection.Get(Owner)?.Evt_RequestSetDBCEffectsPause?.Invoke(0, Pause: true, -1, "FrozenAbnormalState");
		ResetFrozenInfo_WhenFrozenStart();
	}

	private void interface_EndFrozen()
	{
		if (AbnormalStateData.IsInFrozen)
		{
			AbnormalStateHanddlers.AbnormalHanddler_Freeze.PlayAutoReleaseFX();
			EndFrozen();
		}
	}

	private void EndFrozen()
	{
		AbnormalStateHanddlers.AbnormalHanddler_Freeze.OnClearAbnormal();
	}

	public void OnFrozenEnded()
	{
		if (!AbnormalStateData.IsInFrozen)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		BGUFuncLibAnim.BGUSetCharacterMontagePlaying(bGUCharacterCS, IsPlaying: true);
		bGUCharacterCS.CharacterMovement.Activate();
		if (!OwnerAsCharacterCS.IsPlayerCharacterCS())
		{
			List<UActorComponent> componentsByClass = OwnerAsCharacterCS.GetComponentsByClass(UClass.GetClass<UActorComponent>());
			if (componentsByClass != null && componentsByClass.Count > 0)
			{
				foreach (UActorComponent item in componentsByClass)
				{
					if (item is USkeletalMeshComponent uSkeletalMeshComponent)
					{
						uSkeletalMeshComponent.ResumeClothingSimulation();
					}
					else if (item is UTressFXComponent uTressFXComponent)
					{
						uTressFXComponent.SetSimulatePhysics(bSimulate: true);
					}
				}
			}
		}
		if (base.BUSEventCollection != null)
		{
			BGUFuncLibAnim.BGUSetUseSnapshotPose(bGUCharacterCS, bUseSnapshot: false, 0.3f);
			base.BUSEventCollection.Evt_SetAllSweepCheckPaused.Invoke(P1: false);
			base.BUSEventCollection.Evt_SetAllAttackWarningPaused.Invoke(P1: false);
			base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
			if (AbnormalStateData.EnableIKHandleID != 0)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(AbnormalStateData.EnableIKHandleID);
				AbnormalStateData.EnableIKHandleID = 0u;
			}
		}
		base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Frozen, IsRemove: true);
		AbnormalStateData.IsInFrozen = false;
		AbnormalStateData.FrozenBreakProtect = false;
		if (BGU_DataUtil.GetActorType(Owner) == BGU_ActorType.CharacterPlayer && OwnerAsCharacterCS.IsLocallyControlled())
		{
			base.BGWEventCollection.Evt_SetInputMappingContextEnable(EInputMappingContextTagV2.Unfreeze, bEnable: false);
		}
		BUS_DispLibEventCollection.Get(Owner)?.Evt_RequestSetDBCEffectsPause?.Invoke(0, Pause: false, -1, "FrozenAbnormalState");
	}

	private void ResetFrozenInfo_WhenFrozenStart()
	{
		if (!GetOwner().IsNullOrDestroyed() && !(AbnormalStateData.DefaultAbnormalAttrConfig == null))
		{
			float num = AbnormalStateData.DefaultAbnormalAttrConfig.AbnomalAttrConfigInfo_Freeze.BRKAbnormalNeedHP_INV10000;
			int bRKAbnormalTriggerSkillEffectID = AbnormalStateData.DefaultAbnormalAttrConfig.AbnomalAttrConfigInfo_Freeze.BRKAbnormalTriggerSkillEffectID;
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.HpMaxBase);
			AbnormalStateData.CurrentFrozenBrokenAccHP = floatValue * num / 10000f;
			AbnormalStateData.TriggerSkillEffectID_WhenFrozenBroken = bRKAbnormalTriggerSkillEffectID;
		}
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		ClearAllAbnormalState();
		int num = 7;
		for (int i = 1; i < num; i++)
		{
			EAbnormalStateType abnormalType = (EAbnormalStateType)i;
			AbnormalStateHanddlers.GetAbnormalHanddler(abnormalType).OnResetAccumulatedMaxValue();
		}
	}
}
