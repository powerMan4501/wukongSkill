using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PlayerTransComp : UActorCompBaseCS
{
	private UBUC_ACharacterComponent CharacterComps;

	private BUC_PlayerTransData PlayerTransData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_DeadData DeadData;

	private IBUC_PropMgrData PropMgrData;

	private IBIC_TeleportData TeleportData;

	private bool bHasForceLeaveChan;

	private IBUC_BuffData BuffData { get; set; }

	public override void OnAttach()
	{
		CharacterComps = RequireWritableData<UBUC_ACharacterComponent>();
		PlayerTransData = RequireWritableData<BUC_PlayerTransData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		DeadData = RequireReadOnlyData<IBUC_DeadData, BUC_DeadData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		TeleportData = RequireReadonlyGameInstanceData<IBIC_TeleportData, BIC_TeleportData>();
		base.BUSEventCollection.Evt_HideOrShowMesh += new Del_Void_BoolString(OnHideOrShowMesh);
		base.BUSEventCollection.Evt_ResetHideOrShowMesh += new Del_Void_String(OnResetHideOrShowMesh);
		base.BUSEventCollection.Evt_EnableTransUnitPhysicsAsset += new Del_Void(OnEnableTransUnitPhysicsAsset);
		base.BUSEventCollection.Evt_TransBeginSpawnNewOne += new Del_TransBeginSpawnNewOne(OnTransBeginSpawnNewOne);
		base.BUSEventCollection.Evt_TransBackSpawnNewOne += new Del_TransBackSpawnNewOne(OnTransBackSpawnNewOne);
		base.BUSEventCollection.Evt_TriggerTransBack += new Del_Void(OnTriggerTransBack);
		base.BUSEventCollection.Evt_TransBack_PreUnitTrans += new Del_TransBack_PreUnitTrans(TransBack_PreUnitTrans);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_DestoryWaitSeqOldTransActor = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_DestoryWaitSeqOldTransActor, new Del_Void(DestroyWaitSeqOldTransActor));
	}

	public override void OnBeginPlay()
	{
		InitData();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_DestoryWaitSeqOldTransActor = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_DestoryWaitSeqOldTransActor, new Del_Void(DestroyWaitSeqOldTransActor));
	}

	private void DestroyWaitSeqOldTransActor()
	{
		if (PlayerTransData != null && PlayerTransData.WaitSeqDestory)
		{
			DestroyOldUnit();
		}
	}

	private void InitData()
	{
		PlayerTransData.OriAnimInst = null;
		AActor owner = GetOwner();
		if (owner != null)
		{
			BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				PlayerTransData.OriAnimInst = bGUCharacterCS.Mesh.GetAnimInstance();
			}
		}
	}

	private void OnHideOrShowMesh(bool IsShow, string MeshName)
	{
		AActor owner = GetOwner();
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		List<UActorComponent> componentsByClass = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
		List<UActorComponent> componentsByClass2 = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>());
		componentsByClass.AddRange(componentsByClass2);
		foreach (UActorComponent item in componentsByClass)
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (uSceneComponent == null || !(uSceneComponent.GetName().ToString() == MeshName))
			{
				continue;
			}
			if (uSceneComponent == mesh)
			{
				if (PlayerTransData.HiddenInGameHandleID == 0)
				{
					base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_HiddenInGame, !IsShow);
					PlayerTransData.HiddenInGameHandleID = PropMgrData.GetLastHandleID();
				}
				else
				{
					base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_HiddenInGame, !IsShow, PlayerTransData.HiddenInGameHandleID);
				}
			}
			else
			{
				if (!PlayerTransData.OriMeshHiddenInGame.ContainsKey(MeshName))
				{
					PlayerTransData.OriMeshHiddenInGame.Add(MeshName, uSceneComponent.HiddenInGame);
				}
				uSceneComponent.SetHiddenInGame(!IsShow);
			}
			break;
		}
	}

	private void OnResetHideOrShowMesh(string MeshName)
	{
		AActor owner = GetOwner();
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		List<UActorComponent> componentsByClass = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
		List<UActorComponent> componentsByClass2 = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>());
		componentsByClass.AddRange(componentsByClass2);
		foreach (UActorComponent item in componentsByClass)
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (!(uSceneComponent == null) && uSceneComponent.GetName().ToString() == MeshName)
			{
				bool value;
				if (uSceneComponent == mesh)
				{
					base.BUSEventCollection.Evt_ResetProperty.Invoke(PlayerTransData.HiddenInGameHandleID);
					PlayerTransData.HiddenInGameHandleID = 0u;
				}
				else if (PlayerTransData.OriMeshHiddenInGame.TryGetValue(MeshName, out value))
				{
					uSceneComponent.SetHiddenInGame(value);
				}
				break;
			}
		}
	}

	private void OnTransBeginSpawnNewOne(int ToReplaceUnitResID, int ToReplaceUnitBornSkillID, bool EnableBlendViewTarget, EPlayerTransBeginType TransBeginType)
	{
		if (GetOwner() as BGUCharacterCS != null)
		{
			TriggerTransit(ToReplaceUnitResID, ToReplaceUnitBornSkillID, EnableBlendViewTarget);
		}
	}

	private void OnTransBackSpawnNewOne(int ToReplaceUnitResID, int ToReplaceUnitBornSkillID, bool EnableBlendViewTarget, EPlayerTransEndType TransEndType)
	{
		if (GetOwner() as BGUCharacterCS != null)
		{
			TriggerTransit(ToReplaceUnitResID, ToReplaceUnitBornSkillID, EnableBlendViewTarget, TransEndType == EPlayerTransEndType.CMGTransBack);
		}
	}

	private void TriggerTransit(int ToReplaceUnitResID, int ToReplaceUnitBornSkillID = 0, bool EnableBlendViewTarget = true, bool bSeqTransBack = false)
	{
		FUStUnitTransCommDesc unitTransCommDesc = BGW_GameDB.GetUnitTransCommDesc(BGU_DataUtil.GetActorResID(Owner));
		if (unitTransCommDesc == null)
		{
			_ = DebugConfig.DebugPlayerTransLog;
			return;
		}
		FUStUnitTransCommDesc unitTransCommDesc2 = BGW_GameDB.GetUnitTransCommDesc(ToReplaceUnitResID);
		if (unitTransCommDesc2 == null)
		{
			_ = DebugConfig.DebugPlayerTransLog;
			return;
		}
		UClass uClass = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UClass>(unitTransCommDesc2.BPPath, ELoadResourceType.SyncLoadAndCache);
		if (uClass == null || !uClass.IsChildOf<BGUCharacterCS>())
		{
			return;
		}
		_ = DebugConfig.DebugPlayerTransLog;
		BGUFuncLibPlayer.SpawnControlledPawnBlendParam spawnControlledPawnBlendParam = new BGUFuncLibPlayer.SpawnControlledPawnBlendParam
		{
			NeedBlend = EnableBlendViewTarget,
			PossessBlendFunc = unitTransCommDesc2.PossessBlendFunc,
			EnableBlendViewTarget = EnableBlendViewTarget,
			PossessBlendExp = unitTransCommDesc2.PossessBlendExp,
			PossessBlendTime = unitTransCommDesc2.PossessBlendTime
		};
		string locationOffsetStr = ((!unitTransCommDesc2.UnitSpawnLocationOffset.Equals("")) ? unitTransCommDesc2.UnitSpawnLocationOffset : unitTransCommDesc.NewUnitSpawnLocationOffset);
		bool bUseEQS = unitTransCommDesc2.IsUseEQS == EGSYesNo.Yes;
		FTransform bornTransform = CalcTransBornTransform(locationOffsetStr, bUseEQS);
		if (bSeqTransBack)
		{
			OwnerAsCharacterCS.GetController().GetPlayerViewPoint(out var Location, out var Rotation);
			bornTransform.SetLocation(Location - Rotation.Vector() * 1000.0);
			spawnControlledPawnBlendParam.EnableBlendViewTarget = false;
		}
		ABGUCharacter aBGUCharacter = SpawnAndPossessTransUnit(uClass, bornTransform, spawnControlledPawnBlendParam, ToReplaceUnitResID) as ABGUCharacter;
		if (!(aBGUCharacter == null))
		{
			float scale = ((unitTransCommDesc2.UnitSpawnScale != 0f) ? unitTransCommDesc2.UnitSpawnScale : unitTransCommDesc.NewUnitSpawnScale);
			AdjustTransUnitTransform(aBGUCharacter, bornTransform, scale);
			int toReplaceUnitBornSkillID = ((unitTransCommDesc2.UnitBornSkillID != 0) ? unitTransCommDesc2.UnitBornSkillID : unitTransCommDesc.NewUnitBornSkillID);
			if (ToReplaceUnitBornSkillID > 0)
			{
				toReplaceUnitBornSkillID = ToReplaceUnitBornSkillID;
			}
			if (bSeqTransBack)
			{
				toReplaceUnitBornSkillID = 0;
			}
			TransferData(toReplaceUnitBornSkillID, aBGUCharacter);
			if (bSeqTransBack)
			{
				PlayerTransData.WaitSeqDestory = true;
			}
			else
			{
				DestroyOldUnit();
			}
		}
	}

	private void TransferData(int ToReplaceUnitBornSkillID, ABGUCharacter ToReplaceUnitInst)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(ToReplaceUnitInst);
		IBUC_BattleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(Owner);
		if (readOnlyData != null && readOnlyData.IsUnitInBattle())
		{
			base.BGSEventCollection.Evt_BGS_OnBattlePlayerTransited.Invoke(Owner, ToReplaceUnitInst);
		}
		bool flag = true;
		BGUCharacterCS bGUCharacterCS = ToReplaceUnitInst as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			int resID = bGUCharacterCS.GetResID();
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.FtxdDefaultResid);
			if (resID == commLogicCfgValue)
			{
				flag = false;
			}
		}
		if (flag)
		{
			foreach (BuffInstData allBuffInstDatum in BuffData.GetAllBuffInstData())
			{
				int buffID = allBuffInstDatum.BuffID;
				IBUC_PassiveSkillData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(allBuffInstDatum.RootCasterRef));
				BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(buffID, readOnlyData2);
				if (buffDescRuntime != null && buffDescRuntime.GetCanBeInherited())
				{
					AActor aActor = EntitySharedRefFuncLib.Actor(allBuffInstDatum.CasterRef);
					if (aActor == Owner)
					{
						aActor = ToReplaceUnitInst;
					}
					AActor aActor2 = EntitySharedRefFuncLib.Actor(allBuffInstDatum.RootCasterRef);
					if (aActor2 == Owner)
					{
						aActor2 = ToReplaceUnitInst;
					}
					float duration = allBuffInstDatum.LeftTime * 1000f;
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID, aActor, aActor2, duration, EBuffSourceType.PlayerTrans);
				}
			}
		}
		BUS_BGUDataCompBase componentByClass = ToReplaceUnitInst.GetComponentByClass<BUS_BGUDataCompBase>();
		if (componentByClass != null && componentByClass.DataInitTemplate != null)
		{
			List<ECSDataInitTemplate> dataInitTemplate = componentByClass.DataInitTemplate;
			if (dataInitTemplate != null)
			{
				foreach (ECSDataInitTemplate item in dataInitTemplate)
				{
					(item as IPlayerDataInitTemplate)?.PostTrans(Owner);
				}
			}
		}
		bUS_GSEventCollection.Evt_PostTransBindData.Invoke(Owner);
		base.BUSEventCollection.Evt_NotifyTransitToUnit.Invoke(ToReplaceUnitInst);
		bUS_GSEventCollection.Evt_NotifyTransitFromUnit.Invoke(Owner);
		bUS_GSEventCollection.Evt_SwitchPlayerTransStateFinish.Invoke();
		base.BGSEventCollection.Evt_BGS_OnUnitTransited.Invoke(Owner, ToReplaceUnitInst);
		bUS_GSEventCollection.Evt_CameraLockTarget.Invoke(TargetInfoData.GetTargetInfo());
		if (ToReplaceUnitBornSkillID > 0)
		{
			bUS_GSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(ToReplaceUnitBornSkillID, ECastSkillSourceType.PlayerTrans));
		}
	}

	private void AdjustTransUnitTransform(ABGUCharacter ToReplaceUnitInst, FTransform BornTransform, float Scale)
	{
		FVector location = BornTransform.GetLocation();
		FRotator rotation = BornTransform.GetRotation().Rotator();
		float scaledCapsuleHalfHeight = OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
		location.Z -= scaledCapsuleHalfHeight;
		float scaledCapsuleHalfHeight2 = ToReplaceUnitInst.CapsuleComponent.GetScaledCapsuleHalfHeight();
		location.Z += scaledCapsuleHalfHeight2;
		Scale = ((Scale == 0f) ? 1f : Scale);
		FTransform newTransform = new FTransform(rotation, location, new FVector(Scale));
		BGUFuncLibActorTransformCS.BGUSetActorTransform(ToReplaceUnitInst, newTransform, bSweep: false, bTeleport: false);
	}

	private APawn SpawnAndPossessTransUnit(UClass CharacterClass, FTransform BornTransform, BGUFuncLibPlayer.SpawnControlledPawnBlendParam SpawnControlledPawnBlendParam, int ToReplaceUnitResID)
	{
		APawn PlayerPawn = null;
		EPlayerTransEndType unitTransType = ((PlayerTransData.TransTypeCached == EPlayerTransEndType.None) ? EPlayerTransEndType.CastSpell : PlayerTransData.TransTypeCached);
		base.BGWEventCollection.Evt_BGW_UnitTrans(Owner, unitTransType);
		base.BUSEventCollection.Evt_NotifyUnitTrans_BeforePosses.Invoke(unitTransType);
		APawn instigator = OwnerAsCharacterCS.Instigator;
		ABGPPlayerController PC = ((instigator != null) ? (instigator.GetController() as ABGPPlayerController) : null);
		if (PC == null)
		{
			return null;
		}
		BGUFuncLibPlayer.SpwanAndPossesPlayerContrlledPawn(PC, CharacterClass, BornTransform, delegate(APawn Pawn)
		{
			PlayerPawn = Pawn;
			BPS_EventCollectionCS.Get(PC)?.Evt_PlayerActorSpawn.Invoke();
			BPS_EventCollectionCS.Get(PC)?.Evt_BPS_SwitchPlayerTransState.Invoke(Owner, ToReplaceUnitResID);
		}, SpawnControlledPawnBlendParam);
		if (!SpawnControlledPawnBlendParam.EnableBlendViewTarget)
		{
			PC.SetViewTargetWithBlend(Owner);
		}
		return PlayerPawn;
	}

	private void DestroyOldUnit()
	{
		base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Actor_ActorHiddenInGame, Value: true);
		base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_PauseAnims, Value: true);
		base.BUSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, new Dictionary<ECollisionChannel, ECollisionResponseType> { 
		{
			ECollisionChannel.ECC_Pawn,
			ECollisionResponseType.ECR_Ignore
		} });
		base.BUSEventCollection.Evt_BuffAllRemove.Invoke(EBuffEffectTriggerType.None, WithTriggerRemmoveEffect: false);
		base.BUSEventCollection.Evt_UnitDead.Invoke(null, EDeadReason.PlayerTrans);
	}

	private FTransform CalcTransBornTransform(string LocationOffsetStr, bool bUseEQS)
	{
		FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner);
		FVector translation = fTransform.GetLocation();
		APawn instigator = Owner.Instigator;
		FRotator rotation = fTransform.GetRotation().Rotator();
		bool flag = true;
		if (TeleportData != null && TeleportData.IsTeleporting())
		{
			flag = false;
		}
		if (BGW_GameLifeTimeMgr.Get(GetOwner()).IsInTravelLevel())
		{
			flag = false;
		}
		ABGPPlayerController aBGPPlayerController = ((instigator != null) ? (instigator.GetController() as ABGPPlayerController) : null);
		if (flag && aBGPPlayerController != null)
		{
			FRotator cameraRotation = aBGPPlayerController.PlayerCameraManager.GetCameraRotation();
			cameraRotation.Pitch = 0f;
			cameraRotation.Roll = 0f;
			rotation = cameraRotation;
		}
		if (bUseEQS)
		{
			FVector fVector = FVector.ZeroVector;
			bool flag2 = false;
			List<FVector> list = BGUFunctionLibraryCS.BGUGetCachedPointSet(Owner, 19);
			if (list.Count > 0)
			{
				flag2 = true;
				fVector = list[0];
			}
			if (flag2)
			{
				float z = translation.Z;
				translation = fVector;
				translation.Z = z;
			}
		}
		else
		{
			FVector zeroVector = FVector.ZeroVector;
			if (!LocationOffsetStr.Equals(""))
			{
				string[] array = LocationOffsetStr.Split(',');
				if (array.Length == 3)
				{
					zeroVector.Set(StringParseHelper.SafeFloatParse(array[0]), StringParseHelper.SafeFloatParse(array[1]), StringParseHelper.SafeFloatParse(array[2]));
				}
			}
			translation += zeroVector;
		}
		return new FTransform(rotation, translation);
	}

	private void OnEnableTransUnitPhysicsAsset()
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		int actorResID = GetActorResID();
		int deadInfoID = DeadData.GetDeadInfoID();
		FUStUnitDeadDesc unitDeadDesc = BGW_GameDB.GetUnitDeadDesc(actorResID, deadInfoID);
		if (unitDeadDesc == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		if (mesh != null)
		{
			UPhysicsAsset uPhysicsAsset = BGW_PreloadAssetMgr.Get(bGUCharacterCS).TryGetCachedResourceObj<UPhysicsAsset>(unitDeadDesc.DeadPAPath, ELoadResourceType.SyncLoadAndCache);
			if (uPhysicsAsset != null)
			{
				mesh.SetPhysicsAsset(uPhysicsAsset);
				base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_PauseAnims, Value: true);
				base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Mesh_CollisionEnabled, 3);
			}
		}
	}

	private void OnTriggerTransBack()
	{
		if (PlayerTransData.TransBackSkillID != 0)
		{
			APlayerController playerController = UGameplayStatics.GetPlayerController(GetOwner(), 0);
			if (playerController != null)
			{
				BPS_EventCollectionCS.Get(playerController.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.CPGTransBack, default(PlayerTransParam));
			}
		}
	}

	private void TransBack_PreUnitTrans(EPlayerTransEndType TransType)
	{
		PlayerTransData.TransTypeCached = TransType;
	}
}
