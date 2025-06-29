using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.TressFX;
using BtlB1;
using BtlShare;
using GSDispLib;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_MagicallyChangeComp : UActorCompBaseCS
{
	private BUC_MagicallyChangeData MagicallyChangeData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_SkillInstsData SkillInstsData;

	private b1.IBUC_SmartCastSkillData SmartCastSkillData;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_PropMgrData PropMgrData;

	private IBUC_AbnormalStateHandlers AbnormalStateHandlers;

	private IBUC_ActorBasicData ActorBasicData;

	private BUAttrCostTemplate AttrCostTemplate;

	private IBPC_BattleMainInfoData BattleMainInfoData;

	private IBIC_LevelData LevelData;

	private BPS_GSEventCollection BPSEventCollection { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		MagicallyChangeData = RequireWritableData<BUC_MagicallyChangeData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		SmartCastSkillData = RequireReadOnlyData<b1.IBUC_SmartCastSkillData, b1.BUC_SmartCastSkillData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		AbnormalStateHandlers = RequireReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>();
		ActorBasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
		AttrCostTemplate = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(EAttrCostType.VigorEnergy);
		BattleMainInfoData = RequireReadOnlyControlledPlayerControlData<IBPC_BattleMainInfoData, BPC_BattleMainInfoData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		base.BUSEventCollection.Evt_OnCastMagicallyChangeSkill += new Del_OnCastMagicallyChangeSkill(OnCastMagicallyChangeSkill);
		base.BUSEventCollection.Evt_OnMagicallyChangeRecover += new Del_Void_Int(OnMagicallyChangeRecover);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		base.BUSEventCollection.Evt_TriggerVigorSkill += new Del_Void_Int(OnTriggerVigorSkill);
		base.BUSEventCollection.Evt_ChangeVigorSkill += new Del_Void_IntBool(OnChangeVigorSkill);
		base.BUSEventCollection.Evt_SetVigorSkillWhiteList += new Del_Void_IntList(OnSetVigorSkillWhiteList);
		base.BUSEventCollection.Evt_OnMagicallyChangeFadeOut += new Del_Void(OnMagicallyChangeFadeOut);
		base.BUSEventCollection.Evt_OnMagicallyChangeBreak += new Del_Void(OnMagicallyChangeBreak);
		base.BUSEventCollection.Evt_UnitCastSkillBeforePlayMontage += new Del_Void_Int(OnUnitCastSkillBeforePlayMontage);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_OnJumpStart += new Del_Void_Vector(OnJumpStart);
		BPSEventCollection = BPS_GSEventCollection.Get(Owner.GetInstigatorController() as APlayerController);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		foreach (UActorComponent item in Owner.GetComponentsByClass(UClass.GetClass<UActorComponent>()))
		{
			if (item is UTressFXComponent obj)
			{
				MagicallyChangeData.TFXComponents.Add(new TStrongObjectPtr<UTressFXComponent>(obj));
			}
			if (item.GetName().Equals("Collision_Root"))
			{
				MagicallyChangeData.HitMoveCollision.Set(item as UCapsuleComponent);
			}
			if (item.ComponentHasTag(B1GlobalFNames.mimicry))
			{
				MagicallyChangeData.StaticMeshComp.Set(item as UStaticMeshComponent);
			}
		}
		MagicallyChangeData.DefaultConfig = new MagicallyChangeDefaultConfig();
		MagicallyChangeData.DefaultConfig.Init(OwnerAsCharacterCS, MagicallyChangeData.HitMoveCollision.Get(), MagicallyChangeData.TFXComponents);
		if (Owner is BGUPlayerCharacterCS)
		{
			MagicallyChangeData.ChrMeshProfileName = "CharacterMesh_Query";
		}
	}

	public override void OnBeginPlay()
	{
		InitWearSoulSkill();
	}

	private void InitWearSoulSkill()
	{
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(GetOwner()?.GetInstigatorController());
		if (readOnlyData != null && readOnlyData.RoleData != null)
		{
			int soulSkillId = readOnlyData.RoleData.RoleCs.Actor.Wear.WearSoulSkill.SoulSkillId;
			if (soulSkillId > 0)
			{
				SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(soulSkillId);
				base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.VigorEnergyMax, soulSkillDesc.CastEnergy);
			}
		}
	}

	private void OnCastMagicallyChangeSkill(BGWDataAsset_MagicallyChangeConfig Config, int SkillID, int RecoverSkillID)
	{
		if (UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			ClearVigorSkillData();
			return;
		}
		if (MagicallyChangeData.CastReason == ECastReason_MagicallyChange.None)
		{
			MagicallyChangeData.CastReason = ECastReason_MagicallyChange.NormalSkill;
		}
		UBGWDataAsset config = Config;
		if (MagicallyChangeData.CastReason == ECastReason_MagicallyChange.VigorSkill)
		{
			SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(MagicallyChangeData.CurVigorSkillID);
			if (soulSkillDesc == null)
			{
				ClearVigorSkillData();
				return;
			}
			switch (soulSkillDesc.Type)
			{
			case SoulSkillType.MagicallyChange:
				config = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);
				break;
			case SoulSkillType.Mimicry:
			{
				FUStSoulSkillMimicryDesc soulSkillMimicryDescWithDefaultLevelID = BGW_GameDB.GetSoulSkillMimicryDescWithDefaultLevelID(MagicallyChangeData.CurVigorSkillID, LevelData.CurrentLevelID);
				if (soulSkillMimicryDescWithDefaultLevelID != null)
				{
					config = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UBGWDataAsset>(soulSkillMimicryDescWithDefaultLevelID.DAPath, ELoadResourceType.SyncLoadAndCache);
				}
				break;
			}
			}
			SkillID = soulSkillDesc.SkillId;
			RecoverSkillID = soulSkillDesc.SkillIdReEnter;
		}
		DoCastMagicallyChangeSkill_PendingCast(config, SkillID, RecoverSkillID);
	}

	private void DoCastMagicallyChangeSkill(UBGWDataAsset Config, int SkillID, int RecoverSkillID)
	{
		if (Config == null)
		{
			return;
		}
		UGSE_AnimFuncLib.StopAllMontages(Owner, 0f);
		UGSE_AnimFuncLib.TickAnimationAndRefreshBone(Owner);
		base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("触发幻化变身技能，打断当前技能");
		MagicallyChangeData.RecoverSkillID = RecoverSkillID;
		if (MagicallyChangeData.CastReason == ECastReason_MagicallyChange.VigorSkill)
		{
			SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(MagicallyChangeData.CurVigorSkillID);
			if (soulSkillDesc != null)
			{
				MagicallyChangeData.VigorSkillReEnterWaitTime = soulSkillDesc.ReEnterWaitTime;
				if (soulSkillDesc.BuffId > 0)
				{
					base.BUSEventCollection.Evt_BuffAdd.Invoke(soulSkillDesc.BuffId, Owner, Owner, -1f, EBuffSourceType.MagicallyChange);
				}
				if (soulSkillDesc.Type == SoulSkillType.Mimicry)
				{
					DoCastMimicrySkill(Config as BGWDataAsset_VigorSkillMimicryConfig, soulSkillDesc.MimicryMaxTime);
					return;
				}
			}
		}
		DoCastNormalMagicallyChangeSkill(Config as BGWDataAsset_MagicallyChangeConfig, SkillID);
	}

	private void DoCastNormalMagicallyChangeSkill(BGWDataAsset_MagicallyChangeConfig Config, int SkillID)
	{
		if (Config == null)
		{
			return;
		}
		_ = MagicallyChangeData.DurMagicallyChange;
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, Owner);
		UAnimMontage montage_CurrentMontageEndEventBinded = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
		MagicallyChangeData.Montage_CurrentMontageEndEventBinded = montage_CurrentMontageEndEventBinded;
		if (Config.UnitScale > 0f)
		{
			UCapsuleComponent capsuleComponent = OwnerAsCharacterCS.CapsuleComponent;
			USkeletalMeshComponent mesh = OwnerAsCharacterCS.Mesh;
			float num = Config.UnitScale / MagicallyChangeData.DefaultConfig.UnitScale.X;
			float num2 = Config.UnitScale / MagicallyChangeData.DefaultConfig.UnitScale.Z;
			float inRadius = MagicallyChangeData.DefaultConfig.CapsuleRadius / num;
			float num3 = MagicallyChangeData.DefaultConfig.CapsuleHalfHeight / num2;
			Owner.SetActorScale3D(new FVector(Config.UnitScale));
			capsuleComponent.SetCapsuleSize(inRadius, num3, bUpdateOverlaps: false);
			if (mesh != null)
			{
				FVector location = mesh.GetRelativeTransform().GetLocation();
				location.Z = 0f - num3;
				mesh.SetRelativeLocation(location, bSweep: false, out var _, bTeleport: true);
			}
		}
		SetSKMesh(Config.SKMesh, Config.ABPClass, Config.Materials.ToList());
		UpdateAbnormalDispID(bReset: false, Config.Override_AbnormalDispID_Attacker, Config.Override_AbnormalDispID_Victim);
		UpdateMeshInfo(bCastMagicallyChange: true);
		UpdateHitMoveCollision(bCastMagicallyChange: true, Config.CapsuleHalfHeight, Config.CapsuleRadius);
		UpdateTressFXInfo(bCastMagicallyChange: true, Config);
		UpdateWeapons(bCastMagicallyChange: true, Config);
		UpdateDispInteractInfo(bCastMagicallyChange: true, Config);
		bool flag = false;
		if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			base.BUSEventCollection?.Evt_RequestSmartCastSkill.Invoke(SkillID, null, EMontageBindReason.MagicallyChange, bNeedCheckSkillCanCast: false, ECastSkillSourceType.MagicallyChange);
			flag = SmartCastSkillData.LastAutoActionType == ECtrlActionType.CatAttack && SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK;
		}
		else
		{
			FCastSkillInfo fCastSkillInfo = new FCastSkillInfo(SkillID, ECastSkillSourceType.MagicallyChange);
			fCastSkillInfo.NeedCheckSkillCanCast = false;
			fCastSkillInfo.Reason = EMontageBindReason.MagicallyChange;
			fCastSkillInfo.MontageStartSectionName = B1GlobalFNames.ing;
			FCastSkillInfo cSI = fCastSkillInfo;
			base.BUSEventCollection?.Evt_UnitCastSkillTry.Invoke(cSI);
			flag = SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK;
		}
		if (flag)
		{
			MagicallyChangeData.DurMagicallyChange = true;
			MagicallyChangeData.bIsPendingReset = false;
			if (MagicallyChangeData.CastReason == ECastReason_MagicallyChange.VigorSkill)
			{
				AttrCostTemplate.DoCostAttrValue(Owner, AttrContainer, AttrContainer.GetFloatValue(EBGUAttrFloat.VigorEnergy), 0f);
				base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainVigorEnergy);
				BPSEventCollection.Evt_EnterSkillCameraConversionParam.Invoke(MagicallyChangeData.CurVigorSkillID);
				base.BUSEventCollection?.Evt_RequestHideOldBuffDisp.Invoke(P1: true);
			}
		}
		else
		{
			PendingReset(EResetReason_MagicallyChange.CastChangeSkillFailed);
		}
	}

	private void DoCastMimicrySkill(BGWDataAsset_VigorSkillMimicryConfig Config, float MimicryMaxTime)
	{
		if (!(Config == null))
		{
			SetSKMesh(Config.SKMesh, Config.ABPClass, Config.Materials.ToList());
			UpdateAbnormalDispID(bReset: false, Config.Override_AbnormalDispID_Attacker, Config.Override_AbnormalDispID_Victim);
			UpdateMeshInfo(bCastMagicallyChange: true);
			UpdateHitMoveCollision(bCastMagicallyChange: true, Config.CapsuleHalfHeight, Config.CapsuleRadius);
			SetTressFXCompVisibility(bVisible: false);
			SetWeaponVisibility(bVisible: false);
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, Config.AnimMimicryStart, FName.None);
			MagicallyChangeData.DurMagicallyChange = true;
			MagicallyChangeData.MimicrySkillTimer = MimicryMaxTime;
			AttrCostTemplate.DoCostAttrValue(Owner, AttrContainer, AttrContainer.GetFloatValue(EBGUAttrFloat.VigorEnergy), 0f);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainVigorEnergy);
			BPSEventCollection.Evt_EnterSkillCameraConversionParam.Invoke(MagicallyChangeData.CurVigorSkillID);
			base.BUSEventCollection.Evt_RequestHideOldBuffDisp.Invoke(P1: true);
			FUStSoulSkillMimicryDesc soulSkillMimicryDescWithDefaultLevelID = BGW_GameDB.GetSoulSkillMimicryDescWithDefaultLevelID(MagicallyChangeData.CurVigorSkillID, LevelData.CurrentLevelID);
			if (soulSkillMimicryDescWithDefaultLevelID != null && soulSkillMimicryDescWithDefaultLevelID.Buff != 0)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(soulSkillMimicryDescWithDefaultLevelID.Buff, Owner, Owner, -1f, EBuffSourceType.MagicallyChange);
			}
		}
	}

	private void SetSKMeshVisibility(bool bVisible)
	{
		if (bVisible)
		{
			if (MagicallyChangeData.MeshVisibilityHandleID != 0)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(MagicallyChangeData.MeshVisibilityHandleID);
				MagicallyChangeData.MeshVisibilityHandleID = 0u;
			}
		}
		else if (MagicallyChangeData.MeshVisibilityHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_Visibility, Value: false);
			MagicallyChangeData.MeshVisibilityHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_Visibility, Value: false, MagicallyChangeData.MeshVisibilityHandleID);
		}
		base.BUSEventCollection.Evt_SetModularMeshVisibility.Invoke(bVisible);
	}

	private void SetTressFXCompVisibility(bool bVisible)
	{
		if (MagicallyChangeData.TFXComponents == null || MagicallyChangeData.TFXComponents.Count == 0)
		{
			return;
		}
		for (int i = 0; i < MagicallyChangeData.TFXComponents.Count; i++)
		{
			UTressFXComponent uTressFXComponent = MagicallyChangeData.TFXComponents[i].Get();
			if (!uTressFXComponent.IsNullOrDestroyed())
			{
				if (i >= MagicallyChangeData.DefaultConfig.TFXConfig.Count)
				{
					break;
				}
				uTressFXComponent.SetVisibility(bVisible);
			}
		}
	}

	private void SetWeaponVisibility(bool bVisible)
	{
		if (bVisible)
		{
			base.BUSEventCollection.Evt_ToggleWeaponsStatus_ByOtherComp.Invoke(new List<int> { -1 }, TriggerActivate: true, NeedOverride: true, EToggleWeaponStatusCompType.MagicallyChange);
		}
		else
		{
			base.BUSEventCollection.Evt_ToggleWeaponsStatus_ByOtherComp.Invoke(new List<int> { -1 }, TriggerActivate: false, NeedOverride: false, EToggleWeaponStatusCompType.MagicallyChange);
		}
	}

	private void SetStaticMesh(UStaticMesh StaticMesh, in FTransform RelativeTransform)
	{
		if (MagicallyChangeData.StaticMeshComp.IsValid())
		{
			UStaticMeshComponent uStaticMeshComponent = MagicallyChangeData.StaticMeshComp.Get();
			uStaticMeshComponent.SetStaticMesh(StaticMesh);
			uStaticMeshComponent.SetRelativeTransform(RelativeTransform, bSweep: false, out var _, bTeleport: false);
		}
	}

	private void PendingReset(EResetReason_MagicallyChange Reason)
	{
		MagicallyChangeData.bIsPendingReset = true;
		MagicallyChangeData.bIsPendingCast = false;
		MagicallyChangeData.ResetReason = Reason;
	}

	private void ClearVigorSkillData()
	{
		MagicallyChangeData.CastReason = ECastReason_MagicallyChange.None;
		MagicallyChangeData.CurVigorSkillID = 0;
		MagicallyChangeData.VigorSkillDelayTimer = 0f;
		MagicallyChangeData.MimicrySkillTimer = 0f;
		MagicallyChangeData.VigorSkillReEnterWaitTime = 0f;
	}

	private void Reset(EResetReason_MagicallyChange Reason)
	{
		MagicallyChangeData.bIsPendingReset = false;
		MagicallyChangeData.DurMagicallyChange = false;
		bool flag = false;
		if (MagicallyChangeData.CastReason == ECastReason_MagicallyChange.VigorSkill)
		{
			SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(MagicallyChangeData.CurVigorSkillID);
			if (soulSkillDesc != null)
			{
				if (soulSkillDesc.Type == SoulSkillType.Mimicry)
				{
					flag = true;
				}
				if (MagicallyChangeData.FadeOutFXRequestID > 0)
				{
					base.BUSEventCollection.Evt_RequestDestroyByFXRequestID.Invoke(MagicallyChangeData.FadeOutFXRequestID);
					MagicallyChangeData.FadeOutFXRequestID = 0;
				}
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(soulSkillDesc.LeaveFXPath, out var _);
				if (soulSkillDesc.BuffId > 0)
				{
					base.BUSEventCollection.Evt_BuffRemove.Invoke(soulSkillDesc.BuffId, EBuffEffectTriggerType.None, 1);
				}
			}
			base.BUSEventCollection?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CantGainVigorEnergy, IsRemove: true);
			BPSEventCollection.Evt_ExitSkillCameraConversionParam.Invoke(MagicallyChangeData.CurVigorSkillID);
			base.BUSEventCollection?.Evt_RequestHideOldBuffDisp.Invoke(P1: false);
		}
		UGSE_AnimFuncLib.StopAllMontages(Owner, 0f);
		UGSE_AnimFuncLib.TickAnimationAndRefreshBone(Owner);
		base.BUSEventCollection?.Evt_UnitTryBreakSkill.Invoke("幻化变身技能结束，打断当前技能");
		if (flag)
		{
			MimicrySkillReset();
		}
		else
		{
			NormalMagicallyChangeSkillReset();
		}
		if (Reason == EResetReason_MagicallyChange.Normal && MagicallyChangeData.RecoverSkillID > 0)
		{
			FCastSkillInfo cSI = new FCastSkillInfo(MagicallyChangeData.RecoverSkillID, ECastSkillSourceType.MagicallyChangeReset);
			cSI.NeedCheckSkillCanCast = false;
			cSI.Reason = EMontageBindReason.MagicallyChange;
			cSI.MontageStartSectionName = B1GlobalFNames.ing;
			base.BUSEventCollection?.Evt_UnitCastSkillTry.Invoke(cSI);
		}
		MagicallyChangeData.ResetReason = EResetReason_MagicallyChange.None;
		MagicallyChangeData.CastReason = ECastReason_MagicallyChange.None;
		ClearPrepareData();
		ClearVigorSkillData();
	}

	private void NormalMagicallyChangeSkillReset()
	{
		BGWDataAsset_MagicallyChangeConfig bGWDataAsset_MagicallyChangeConfig = MagicallyChangeData.PendingConfig as BGWDataAsset_MagicallyChangeConfig;
		if (bGWDataAsset_MagicallyChangeConfig == null)
		{
			return;
		}
		if (bGWDataAsset_MagicallyChangeConfig.UnitScale > 0f)
		{
			UCapsuleComponent capsuleComponent = OwnerAsCharacterCS.CapsuleComponent;
			USkeletalMeshComponent mesh = OwnerAsCharacterCS.Mesh;
			Owner.SetActorScale3D(MagicallyChangeData.DefaultConfig.UnitScale);
			capsuleComponent.SetCapsuleSize(MagicallyChangeData.DefaultConfig.CapsuleRadius, MagicallyChangeData.DefaultConfig.CapsuleHalfHeight, bUpdateOverlaps: false);
			if (mesh != null)
			{
				FVector location = mesh.GetRelativeTransform().GetLocation();
				location.Z = 0f - MagicallyChangeData.DefaultConfig.CapsuleHalfHeight;
				mesh.SetRelativeLocation(location, bSweep: false, out var _, bTeleport: true);
			}
		}
		SetSKMesh(MagicallyChangeData.DefaultConfig.SKMesh.Get(), MagicallyChangeData.DefaultConfig.ABPClass);
		UpdateAbnormalDispID(bReset: true);
		UpdateMeshInfo(bCastMagicallyChange: false);
		UpdateHitMoveCollision(bCastMagicallyChange: false, MagicallyChangeData.DefaultConfig.HitMoveCollisionHalfHeight, MagicallyChangeData.DefaultConfig.HitMoveCollisionRadius);
		UpdateTressFXInfo(bCastMagicallyChange: false, bGWDataAsset_MagicallyChangeConfig);
		UpdateWeapons(bCastMagicallyChange: false, bGWDataAsset_MagicallyChangeConfig);
		UpdateDispInteractInfo(bCastMagicallyChange: false, bGWDataAsset_MagicallyChangeConfig);
	}

	private void MimicrySkillReset()
	{
		SetSKMesh(MagicallyChangeData.DefaultConfig.SKMesh.Get(), MagicallyChangeData.DefaultConfig.ABPClass);
		UpdateAbnormalDispID(bReset: true);
		UpdateMeshInfo(bCastMagicallyChange: false);
		UpdateHitMoveCollision(bCastMagicallyChange: false, MagicallyChangeData.DefaultConfig.HitMoveCollisionHalfHeight, MagicallyChangeData.DefaultConfig.HitMoveCollisionRadius);
		SetTressFXCompVisibility(bVisible: true);
		SetWeaponVisibility(bVisible: true);
		FUStSoulSkillMimicryDesc soulSkillMimicryDescWithDefaultLevelID = BGW_GameDB.GetSoulSkillMimicryDescWithDefaultLevelID(MagicallyChangeData.CurVigorSkillID, LevelData.CurrentLevelID);
		if (soulSkillMimicryDescWithDefaultLevelID != null && soulSkillMimicryDescWithDefaultLevelID.Buff != 0)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(soulSkillMimicryDescWithDefaultLevelID.Buff, EBuffEffectTriggerType.None, 1);
		}
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (Reason == EMontageBindReason.MagicallyChange && Montage == MagicallyChangeData.Montage_CurrentMontageEndEventBinded && (State == EMontageCallbackState.OnBlendOut || State == EMontageCallbackState.OnInterrupted) && MagicallyChangeData.DurMagicallyChange)
		{
			PendingReset(EResetReason_MagicallyChange.Normal);
		}
	}

	private void DoCastMagicallyChangeSkill_PendingCast(UBGWDataAsset _Config, int _SkillID, int _RecoverSkillID)
	{
		MagicallyChangeData.bIsPendingCast = true;
		MagicallyChangeData.bIsPendingReset = false;
		MagicallyChangeData.PendingConfig = _Config;
		MagicallyChangeData.MagicallyChangeSkillID = _SkillID;
		MagicallyChangeData.RecoverSkillID = _RecoverSkillID;
	}

	private void OnMagicallyChangeRecover(int RecoverSkillID)
	{
		if ((MagicallyChangeData.CurVigorSkillID != 0 || MagicallyChangeData.DurMagicallyChange) && MagicallyChangeData.CastReason != ECastReason_MagicallyChange.None)
		{
			if (MagicallyChangeData.CastReason == ECastReason_MagicallyChange.NormalSkill && RecoverSkillID > 0)
			{
				MagicallyChangeData.RecoverSkillID = RecoverSkillID;
			}
			PendingReset(EResetReason_MagicallyChange.Normal);
		}
	}

	private void ClearPrepareData()
	{
		MagicallyChangeData.PendingConfig = null;
		MagicallyChangeData.Montage_CurrentMontageEndEventBinded = null;
		MagicallyChangeData.MagicallyChangeSkillID = 0;
		MagicallyChangeData.RecoverSkillID = 0;
		MagicallyChangeData.bIsPendingCast = false;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForHiddenEvent();
		TickForDisableVigorSkill();
		UpdateMimicrySkill(DeltaTime);
		UpdateDelayVigorSkill(DeltaTime);
		if (MagicallyChangeData.bIsPendingCast)
		{
			MagicallyChangeData.bIsPendingCast = false;
			DoCastMagicallyChangeSkill(MagicallyChangeData.PendingConfig, MagicallyChangeData.MagicallyChangeSkillID, MagicallyChangeData.RecoverSkillID);
		}
		if (MagicallyChangeData.bIsPendingReset)
		{
			Reset(MagicallyChangeData.ResetReason);
		}
	}

	private void TickForDisableVigorSkill()
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantInVigorSkill) && MagicallyChangeData.CurVigorSkillID > 0)
		{
			OnMagicallyChangeRecover(0);
		}
	}

	private void UpdateMimicrySkill(float DeltaTime)
	{
		if (MagicallyChangeData.DurMagicallyChange && MagicallyChangeData.MimicrySkillTimer > 0f)
		{
			MagicallyChangeData.MimicrySkillTimer -= DeltaTime;
			if (MagicallyChangeData.MimicrySkillTimer <= 0f)
			{
				MagicallyChangeData.MimicrySkillTimer = 0f;
				PendingReset(EResetReason_MagicallyChange.Normal);
			}
		}
	}

	private void UpdateDelayVigorSkill(float DeltaTime)
	{
		if (MagicallyChangeData.VigorSkillDelayTimer > 0f)
		{
			MagicallyChangeData.VigorSkillDelayTimer -= DeltaTime;
			if (MagicallyChangeData.VigorSkillDelayTimer <= 0f)
			{
				MagicallyChangeData.VigorSkillDelayTimer = 0f;
				CastMagicallyChangeByVigorSkill(MagicallyChangeData.CurVigorSkillID);
			}
		}
	}

	private void CastMagicallyChangeByVigorSkill(int VigorSkillID)
	{
		if (UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			ClearVigorSkillData();
			return;
		}
		SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);
		if (soulSkillDesc == null)
		{
			ClearVigorSkillData();
			return;
		}
		MagicallyChangeData.CastReason = ECastReason_MagicallyChange.VigorSkill;
		UBGWDataAsset config = null;
		switch (soulSkillDesc.Type)
		{
		case SoulSkillType.MagicallyChange:
			config = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_MagicallyChangeConfig>(soulSkillDesc.DAPath, ELoadResourceType.SyncLoadAndCache);
			break;
		case SoulSkillType.Mimicry:
		{
			FUStSoulSkillMimicryDesc soulSkillMimicryDescWithDefaultLevelID = BGW_GameDB.GetSoulSkillMimicryDescWithDefaultLevelID(VigorSkillID, LevelData.CurrentLevelID);
			if (soulSkillMimicryDescWithDefaultLevelID != null)
			{
				config = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UBGWDataAsset>(soulSkillMimicryDescWithDefaultLevelID.DAPath, ELoadResourceType.SyncLoadAndCache);
			}
			break;
		}
		}
		DoCastMagicallyChangeSkill_PendingCast(config, soulSkillDesc.SkillId, soulSkillDesc.SkillIdReEnter);
	}

	public void SetSKMesh(USkeletalMesh NewSkeltalMesh, TSubclassOf<UAnimInstance> NewABPClass, List<UMaterialInterface> Materials = null)
	{
		if (NewSkeltalMesh == null)
		{
			return;
		}
		USkeletalMesh skeletalMesh = OwnerAsCharacterCS.Mesh.SkeletalMesh;
		if (skeletalMesh == NewSkeltalMesh)
		{
			return;
		}
		base.BGSEventCollection?.Evt_BGS_ClearAttachedProjectiles_OnUnit.Invoke(Owner);
		HiddenMainMesh(bHidden: true);
		base.BUSEventCollection?.Evt_ChangeSkeletalMeshWithABP.Invoke(NewSkeltalMesh, NewABPClass);
		List<FSkeletalMaterial> materials = NewSkeltalMesh.GetMaterials();
		for (int i = 0; i < materials.Count; i++)
		{
			if (Materials != null && Materials.Count > 0)
			{
				if (i >= Materials.Count)
				{
					break;
				}
				OwnerAsCharacterCS.Mesh.SetMaterial(i, Materials[i]);
			}
			else
			{
				OwnerAsCharacterCS.Mesh.SetMaterial(i, materials[i].MaterialInterface);
			}
		}
		BUS_DispLibEventCollection.Get(Owner)?.Evt_OnSkeletalMeshAssetChanged?.Invoke(OwnerAsCharacterCS.Mesh, skeletalMesh, NewSkeltalMesh);
	}

	private void UpdateAbnormalDispID(bool bReset, int OverrideDispID_Attacker = -1, int OverrideDispID_Victim = -1)
	{
		if (bReset)
		{
			if (MagicallyChangeData.AbnormalDispID_AsAttacker_Override_HanldeID != 0)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(MagicallyChangeData.AbnormalDispID_AsAttacker_Override_HanldeID);
				MagicallyChangeData.AbnormalDispID_AsAttacker_Override_HanldeID = 0u;
			}
			if (OwnerAsCharacterCS.AbnormalDispID_AsVictim_Override >= 0)
			{
				OwnerAsCharacterCS.AbnormalDispID_AsVictim_Override = -1;
				AbnormalStateHandlers.UpdateCurLoopAbnormalDisp();
			}
		}
		else
		{
			if (MagicallyChangeData.AbnormalDispID_AsAttacker_Override_HanldeID == 0)
			{
				base.BUSEventCollection.Evt_SetIntProperty.Invoke(EPropType.Actor_AttackerAbnormalDispID_Override, OverrideDispID_Attacker);
				MagicallyChangeData.AbnormalDispID_AsAttacker_Override_HanldeID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetIntProperty.Invoke(EPropType.Actor_AttackerAbnormalDispID_Override, OverrideDispID_Attacker, MagicallyChangeData.AbnormalDispID_AsAttacker_Override_HanldeID);
			}
			if (OwnerAsCharacterCS.AbnormalDispID_AsVictim_Override != OverrideDispID_Victim)
			{
				OwnerAsCharacterCS.AbnormalDispID_AsVictim_Override = OverrideDispID_Victim;
				AbnormalStateHandlers.UpdateCurLoopAbnormalDisp();
			}
		}
	}

	private void UpdateMeshInfo(bool bCastMagicallyChange)
	{
		USkeletalMeshComponent mesh = OwnerAsCharacterCS.Mesh;
		if (bCastMagicallyChange)
		{
			mesh.CastShadow = true;
			mesh.VisibleInRayTracing = true;
			mesh.RenderInMainPass = true;
			mesh.RenderInDepthPass = true;
			if (MagicallyChangeData.MeshCollisionProfileHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, MagicallyChangeData.ChrMeshProfileName);
				MagicallyChangeData.MeshCollisionProfileHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, MagicallyChangeData.ChrMeshProfileName, MagicallyChangeData.MeshCollisionProfileHandleID);
			}
		}
		else
		{
			mesh.CastShadow = MagicallyChangeData.DefaultConfig.MeshProperty.CastShadow;
			mesh.VisibleInRayTracing = MagicallyChangeData.DefaultConfig.MeshProperty.VisibleInRayTracing;
			mesh.RenderInMainPass = MagicallyChangeData.DefaultConfig.MeshProperty.RenderInMainPass;
			mesh.RenderInDepthPass = MagicallyChangeData.DefaultConfig.MeshProperty.RenderInDepthPass;
			if (MagicallyChangeData.MeshCollisionProfileHandleID != 0)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(MagicallyChangeData.MeshCollisionProfileHandleID);
				MagicallyChangeData.MeshCollisionProfileHandleID = 0u;
			}
		}
		MagicallyChangeData.ModularMeshRemainHiddenFrame = -1;
		if (bCastMagicallyChange)
		{
			base.BUSEventCollection.Evt_SetModularMeshVisibility.Invoke(P1: false);
		}
		else
		{
			MagicallyChangeData.ModularMeshRemainHiddenFrame = MagicallyChangeData.RemainHiddenFrame;
		}
	}

	private void HiddenMainMesh(bool bHidden)
	{
		if (bHidden)
		{
			MagicallyChangeData.RemainHiddenFrame = 2;
			if (MagicallyChangeData.MainMeshHiddenInGameHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_HiddenInGame, Value: true);
				MagicallyChangeData.MainMeshHiddenInGameHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_HiddenInGame, Value: true, MagicallyChangeData.MainMeshHiddenInGameHandleID);
			}
		}
		else
		{
			MagicallyChangeData.RemainHiddenFrame = -1;
			if (MagicallyChangeData.MainMeshHiddenInGameHandleID != 0)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(MagicallyChangeData.MainMeshHiddenInGameHandleID);
				MagicallyChangeData.MainMeshHiddenInGameHandleID = 0u;
			}
		}
	}

	private void TickForHiddenEvent()
	{
		if (MagicallyChangeData.RemainHiddenFrame > 0)
		{
			MagicallyChangeData.RemainHiddenFrame--;
			if (MagicallyChangeData.RemainHiddenFrame <= 0)
			{
				HiddenMainMesh(bHidden: false);
			}
		}
		if (MagicallyChangeData.ModularMeshRemainHiddenFrame > 0 && --MagicallyChangeData.ModularMeshRemainHiddenFrame <= 0)
		{
			MagicallyChangeData.ModularMeshRemainHiddenFrame = -1;
			base.BUSEventCollection.Evt_SetModularMeshVisibility.Invoke(P1: true);
		}
	}

	private void UpdateHitMoveCollision(bool bCastMagicallyChange, float InCapsuleHalfHeight, float InCapsuleRadius)
	{
		if (MagicallyChangeData.HitMoveCollision.IsValid() && InCapsuleHalfHeight != 0f && InCapsuleRadius != 0f)
		{
			float inRadius = (bCastMagicallyChange ? InCapsuleRadius : MagicallyChangeData.DefaultConfig.HitMoveCollisionRadius);
			float num = (bCastMagicallyChange ? InCapsuleHalfHeight : MagicallyChangeData.DefaultConfig.HitMoveCollisionHalfHeight);
			UCapsuleComponent uCapsuleComponent = MagicallyChangeData.HitMoveCollision.Get();
			uCapsuleComponent.SetCapsuleSize(inRadius, num);
			FVector location = uCapsuleComponent.GetRelativeTransform().GetLocation();
			location.Z = num;
			uCapsuleComponent.SetRelativeLocation(location, bSweep: false, out var _, bTeleport: false);
		}
	}

	private void UpdateTressFXInfo(bool bCastMagicallyChange, BGWDataAsset_MagicallyChangeConfig Config)
	{
		if (MagicallyChangeData.TFXComponents == null || MagicallyChangeData.TFXComponents.Count == 0)
		{
			return;
		}
		for (int i = 0; i < MagicallyChangeData.TFXComponents.Count; i++)
		{
			UTressFXComponent uTressFXComponent = MagicallyChangeData.TFXComponents[i].Get();
			if (!uTressFXComponent.IsNullOrDestroyed())
			{
				float num = (bCastMagicallyChange ? Config.TFXConfig.Count : MagicallyChangeData.DefaultConfig.TFXConfig.Count);
				if ((float)i >= num)
				{
					uTressFXComponent.SetVisibility(bNewVisibility: false);
					uTressFXComponent.Asset = null;
					uTressFXComponent.HairMaterial = null;
					UGSE_RenderUtilFuncLib.MarkRenderStateDirty(uTressFXComponent);
					continue;
				}
				FMagicallyChangeConfig_TFXConfig fMagicallyChangeConfig_TFXConfig = (bCastMagicallyChange ? Config.TFXConfig[i] : default(FMagicallyChangeConfig_TFXConfig));
				MagicallyChangeTFXConfig magicallyChangeTFXConfig = (bCastMagicallyChange ? null : MagicallyChangeData.DefaultConfig.TFXConfig[i]);
				UTressFXAsset asset = (bCastMagicallyChange ? fMagicallyChangeConfig_TFXConfig.TFXAsset : magicallyChangeTFXConfig.TFXAsset.Get());
				UMaterialInterface hairMaterial = (bCastMagicallyChange ? fMagicallyChangeConfig_TFXConfig.HairMaterial : magicallyChangeTFXConfig.HairMaterial.Get());
				FTressFXShadeSettings shadeSettings = (bCastMagicallyChange ? fMagicallyChangeConfig_TFXConfig.ShadeSettings : magicallyChangeTFXConfig.ShadeSettings);
				float lodScreenSize = (bCastMagicallyChange ? fMagicallyChangeConfig_TFXConfig.LodScreenSize : magicallyChangeTFXConfig.LodScreenSize);
				bool enableSimulation = (bCastMagicallyChange ? fMagicallyChangeConfig_TFXConfig.bEnableSimulation : magicallyChangeTFXConfig.bEnableSimulation);
				BUS_DispLibEventCollection.Get(Owner)?.Evt_RemoveMeshCompFromManager(uTressFXComponent);
				uTressFXComponent.SetVisibility(bNewVisibility: true);
				uTressFXComponent.Asset = asset;
				uTressFXComponent.ShadeSettings = shadeSettings;
				uTressFXComponent.LodScreenSize = lodScreenSize;
				uTressFXComponent.EnableSimulation = enableSimulation;
				uTressFXComponent.HairMaterial = hairMaterial;
				UGSE_RenderUtilFuncLib.MarkRenderStateDirty(uTressFXComponent);
				BUS_DispLibEventCollection.Get(Owner)?.Evt_AddNewMeshCompToManager(uTressFXComponent);
			}
		}
	}

	private void UpdateWeapons(bool bCastMagicallyChange, BGWDataAsset_MagicallyChangeConfig Config)
	{
		if (bCastMagicallyChange)
		{
			base.BUSEventCollection.Evt_AddTempOverrideWeapon.Invoke(Config.Weapons.ToList());
		}
		else
		{
			base.BUSEventCollection.Evt_ClearTempOverrideWeapon.Invoke();
		}
	}

	private void UpdateDispInteractInfo(bool bCastMagicallyChange, BGWDataAsset_MagicallyChangeConfig Config)
	{
		if (bCastMagicallyChange)
		{
			base.BUSEventCollection.Evt_SwitchDispInteractConfig.Invoke(Config.InteractBones.ToList());
		}
		else
		{
			base.BUSEventCollection.Evt_ResetDispInteractConfig.Invoke();
		}
	}

	private int GetMappingRandomVigorSkilID(int OriVigorSkillID)
	{
		SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(OriVigorSkillID);
		if (soulSkillDesc == null)
		{
			return OriVigorSkillID;
		}
		if (soulSkillDesc.MappingRandomId.Length == 0)
		{
			return OriVigorSkillID;
		}
		float num = 0f;
		Dictionary<int, float> dictionary = new Dictionary<int, float>();
		string[] array = soulSkillDesc.MappingRandomId.Split(';');
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(',');
			if (array2.Length == 2)
			{
				int num2 = int.Parse(array2[0]);
				float num3 = StringParseHelper.SafeFloatParse(array2[1]);
				if (num2 > 0)
				{
					dictionary.Add(num2, num3);
					num += num3;
				}
			}
		}
		float num4 = 0f;
		float num5 = FMath.FRand();
		foreach (KeyValuePair<int, float> item in dictionary)
		{
			num4 += ((num <= 0f) ? 1f : (item.Value / num));
			if (num5 <= num4)
			{
				return item.Key;
			}
		}
		return OriVigorSkillID;
	}

	private void OnTriggerVigorSkill(int VigorSkillID)
	{
		if (MagicallyChangeData.CurVigorSkillID > 0 || BattleMainInfoData == null || MathLib.Abs(BattleMainInfoData.VigorSkillCDPercent) > 1E-08f)
		{
			return;
		}
		if ((UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.Beatback)) && UnitStateData.HasState(EBGUUnitState.InVigorWindow) && MagicallyChangeData.VigorSkillWhiteList.Count > 0 && !MagicallyChangeData.VigorSkillWhiteList.Contains(VigorSkillID))
		{
			ClearVigorSkillData();
			return;
		}
		VigorSkillID = GetMappingRandomVigorSkilID(VigorSkillID);
		SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(VigorSkillID);
		if (soulSkillDesc == null)
		{
			return;
		}
		if (BGU_CommonUtil.CheckSkillCanCast(Owner, soulSkillDesc.SkillId, soulSkillDesc.SkillId) != ECanCastSkillResult.CCSR_OK)
		{
			ClearVigorSkillData();
			return;
		}
		if (soulSkillDesc.SkillIdWhenLeave <= 0 || IsInComboAttack())
		{
			base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(soulSkillDesc.LeaveFXPath, out var _);
			MagicallyChangeData.CurVigorSkillID = VigorSkillID;
			if (soulSkillDesc.DelayTimeWithoutLeave > 0f)
			{
				MagicallyChangeData.VigorSkillDelayTimer = soulSkillDesc.DelayTimeWithoutLeave;
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f);
			}
			else
			{
				CastMagicallyChangeByVigorSkill(VigorSkillID);
			}
			return;
		}
		FCastSkillInfo cSI = new FCastSkillInfo(soulSkillDesc.SkillIdWhenLeave, ECastSkillSourceType.VigorLeaveSkill);
		cSI.NeedCheckSkillCanCast = false;
		base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(cSI);
		if (SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK)
		{
			MagicallyChangeData.CurVigorSkillID = VigorSkillID;
			MagicallyChangeData.CastReason = ECastReason_MagicallyChange.VigorSkill;
		}
		else
		{
			ClearVigorSkillData();
		}
	}

	private bool IsInComboAttack()
	{
		if (UnitStateData.HasState(EBGUUnitState.Attacking) && UnitStateData.HasState(EBGUUnitState.InVigorWindow))
		{
			return true;
		}
		return false;
	}

	private void OnChangeVigorSkill(int NewVigorSkillID, bool bUpgrade)
	{
		SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(NewVigorSkillID);
		if (soulSkillDesc != null)
		{
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.VigorEnergyMax, soulSkillDesc.CastEnergy);
			if (!bUpgrade)
			{
				base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.VigorEnergy, 0f);
			}
			base.BGWEventCollection.Evt_BGW_PlayerAbilityChangeRequestPreload(GetOwnerEntity(), EPreloadPlayerAbilityType.Vigor);
		}
	}

	private void OnSetVigorSkillWhiteList(List<int> WhiteList)
	{
		MagicallyChangeData.VigorSkillWhiteList = WhiteList;
	}

	private void OnMagicallyChangeBreak()
	{
		if (MagicallyChangeData.CurVigorSkillID != 0 || MagicallyChangeData.DurMagicallyChange)
		{
			MagicallyChangeData.ResetReason = EResetReason_MagicallyChange.Break;
			Reset(MagicallyChangeData.ResetReason);
		}
	}

	private void OnUnitCastSkillBeforePlayMontage(int SkillID)
	{
		if (!(MagicallyChangeData.MimicrySkillTimer <= 0f))
		{
			OnMagicallyChangeBreak();
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgId)
	{
		OnMagicallyChangeBreak();
	}

	private void OnJumpStart(FVector JumpDir)
	{
		OnMagicallyChangeBreak();
	}

	private void OnMagicallyChangeFadeOut()
	{
		if (MagicallyChangeData.DurMagicallyChange && MagicallyChangeData.CastReason == ECastReason_MagicallyChange.VigorSkill)
		{
			SoulSkillDesc soulSkillDesc = GameDBRuntime.GetSoulSkillDesc(MagicallyChangeData.CurVigorSkillID);
			if (soulSkillDesc != null)
			{
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(soulSkillDesc.ReEnterFadeOutFXPath, out MagicallyChangeData.FadeOutFXRequestID);
			}
		}
	}
}
