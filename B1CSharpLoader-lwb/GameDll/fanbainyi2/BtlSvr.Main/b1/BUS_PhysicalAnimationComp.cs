using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PhysicalAnimationComp : UActorCompBaseCS
{
	private b1.BUC_PhysAnimData PhysAnimData;

	private BUC_PhysicBlendData PhysicBlendData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_BattleStateData BattleStateData;

	private IBUC_PropMgrData PropMgrData;

	public override void OnAttach()
	{
		PhysAnimData = RequireWritableData<b1.BUC_PhysAnimData>();
		PhysicBlendData = RequireWritableData<BUC_PhysicBlendData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_PlayBeAttackedPhysAnim += new Del_PlayBeAttackedPhysAnim(PlayBeAttackedPhysicalAnim);
		base.BUSEventCollection.Evt_PlayBeAttackedPhysAnimForDead += new Del_PlayBeAttackedPhysAnim(PlayBeAttackedPhysicalAnimForDead);
		base.BUSEventCollection.Evt_SetPhysAnimSetting += new Del_SetPhysAnimSetting(SetPhysAnimSetting);
		base.BUSEventCollection.Evt_SetNewBeAttackedInfoID += new Del_Void_Int(SetNewBeAttackedInfoID);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_ActivatePhysicBlend += new Del_ActivatePhysicBlend(OnActivatePhysicBlend);
		base.BUSEventCollection.Evt_ActivatePhysicBlendForDeath += new Del_ActivatePhysicBlendForDeath(OnActivatePhysicBlendForDeath);
		base.BUSEventCollection.Evt_ResetPhysicalAnim += new Del_Void(ResetPhysicalAnim);
		base.BUSEventCollection.Evt_SetLockPhysicalMoveSnapshot += new Del_Void_Bool(OnSetLockPhysicalMoveSnapshot);
		base.BUSEventCollection.Evt_AddPhysicsImpulse += new Del_Void_VectorVector(OnAddPhysicsImpulse);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnPlayerRebirth);
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection != null)
		{
			bUS_DispLibEventCollection.Evt_OnSkeletalMeshAssetChanged = (BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged)Delegate.Combine(bUS_DispLibEventCollection.Evt_OnSkeletalMeshAssetChanged, new BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged(OnMeshChanged));
		}
	}

	public override void PreBeginPlay()
	{
		PhysAnimData.Init();
		PhysAnimData.MeshRelTrf = OwnerAsCharacterCS.Mesh.GetRelativeTransform();
		SetPhysAnimSetting(EPhysAnimType.Normal);
		if ((PhysAnimData.TryGetSetting(EPhysAnimType.BeAttack, Owner, out var _) as b1.BeAtkPhysAnimSetting).bUseCurveBlend)
		{
			SetCurveCallback();
		}
	}

	private void SetCurveCallback()
	{
		if (PhysAnimData.BeAtkPhysWeightTL.TimelineInterpFunc.GetInvocationList().Length <= 1)
		{
			b1.BGU_Timeline beAtkPhysWeightTL = PhysAnimData.BeAtkPhysWeightTL;
			beAtkPhysWeightTL.TimelineInterpFunc = (b1.BGU_Timeline.Del_Void_Float)Delegate.Combine(beAtkPhysWeightTL.TimelineInterpFunc, new b1.BGU_Timeline.Del_Void_Float(UpdateBeAtkPhysWeight));
		}
		if (PhysAnimData.BeAtkPhysWeightTL.TimelineFinishedFunc.GetInvocationList().Length <= 1)
		{
			b1.BGU_Timeline beAtkPhysWeightTL2 = PhysAnimData.BeAtkPhysWeightTL;
			beAtkPhysWeightTL2.TimelineFinishedFunc = (b1.BGU_Timeline.Del_Void)Delegate.Combine(beAtkPhysWeightTL2.TimelineFinishedFunc, new b1.BGU_Timeline.Del_Void(FinishBeAtkPhysBlendWeight));
		}
	}

	public override void OnBeginPlay()
	{
		ResetPhysicalAnim();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (GSGameplayCVar.CVar_PhysAnimEnableBeAttack.GetValueInGameThread() == 1 && PhysAnimData.MapPhysAnimSettingInitState[EPhysAnimType.BeAttack] && ((b1.BeAtkPhysAnimSetting)PhysAnimData.TryGetSetting(EPhysAnimType.BeAttack, Owner, out var _)).bUseCurveBlend)
		{
			PhysAnimData.BeAtkPhysWeightTL.TickTimeline(DeltaTime);
		}
		TickPhysicsSimulationMove();
		PhysicBlendTick(DeltaTime);
		PhysicBlendForDeathTick(DeltaTime);
	}

	private void TickPhysicsSimulationMove()
	{
		if (PhysAnimData.bPhysicalMoveSnapshot && !PhysAnimData.bLockPhysicalMoveSnapshot)
		{
			BGUFuncLibAnim.BGUSetUseSnapshotPose(GetOwner(), bUseSnapshot: false, 0.3f);
			PhysAnimData.bPhysicalMoveSnapshot = false;
		}
	}

	private void OnSetLockPhysicalMoveSnapshot(bool bLock)
	{
		PhysAnimData.bLockPhysicalMoveSnapshot = bLock;
	}

	private void SetNewBeAttackedInfoID(int NewID)
	{
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		ResetPhysicalAnim();
	}

	private void OnPlayerRebirth(ERebirthType RebirthType = ERebirthType.RebirthPoint)
	{
		ResetPhysicalAnim();
	}

	private void ResetPhysicalAnim()
	{
		ClearPhysAnimSetting();
		SetPhysAnimSetting(EPhysAnimType.Normal);
	}

	private bool IsInSpine(FName BoneName)
	{
		if (!BoneName.Equals(B1GlobalFNames.bip) && !BoneName.Equals(B1GlobalFNames.pelvis) && !BoneName.Equals(B1GlobalFNames.root) && !BoneName.Equals(FName.None))
		{
			return BoneName.ToString().Contains("spine");
		}
		return true;
	}

	private void PlayBeAttackedPhysicalAnim(int HitWeight, FEffectInstReq HitInfo, float PhysAnimImpulseScale = 1f)
	{
		if (GSGameplayCVar.CVar_PhysAnimEnableBeAttack.GetValueInGameThread() == 0)
		{
			return;
		}
		bool bLoadThisTime = false;
		b1.BeAtkPhysAnimSetting beAtkPhysAnimSetting = PhysAnimData.TryGetSetting(EPhysAnimType.BeAttack, GetOwner(), out bLoadThisTime) as b1.BeAtkPhysAnimSetting;
		if (bLoadThisTime)
		{
			SetCurveCallback();
		}
		if (!PhysAnimData.MapPhysAnimSettingInitState[EPhysAnimType.BeAttack])
		{
			return;
		}
		SetPhysAnimSetting(EPhysAnimType.BeAttack);
		if (GSGameplayCVar.CVar_PhysAnimDebug.GetValueInGameThread() == 1)
		{
			FName hitBoneName = HitInfo.HitBoneName;
			_ = "HitBone:" + hitBoneName.ToString() + " bPartPhysics:" + beAtkPhysAnimSetting.bPartPhysics;
		}
		if (beAtkPhysAnimSetting.bPartPhysics)
		{
			FName hitBoneName2 = HitInfo.HitBoneName;
			FName fName = hitBoneName2;
			OwnerAsCharacterCS.Mesh.SetSimulatePhysics(bSimulate: true);
			while (!IsInSpine(fName))
			{
				hitBoneName2 = fName;
				fName = OwnerAsCharacterCS.Mesh.GetParentBone(hitBoneName2);
			}
		}
		if (beAtkPhysAnimSetting.bUseCurveBlend)
		{
			PhysAnimData.BeAtkPhysWeightTL.SetTimelineLength(beAtkPhysAnimSetting.PhysWeightCurve);
			PhysAnimData.BeAtkPhysWeightTL.PlayFromStart();
		}
		else
		{
			OwnerAsCharacterCS.Mesh.SetAllBodiesPhysicsBlendWeight(1f, bSkipCustomPhysicsType: true);
		}
		float strength = beAtkPhysAnimSetting.HitImpulse * PhysAnimImpulseScale;
		float radius = 300f;
		GsCvarData cVar_PhysAnimBeAtkRadius = GSGameplayCVar.CVar_PhysAnimBeAtkRadius;
		if (cVar_PhysAnimBeAtkRadius != null)
		{
			radius = cVar_PhysAnimBeAtkRadius.GetValueInGameThread();
		}
		FVector origin = HitInfo.HitLocation;
		if (beAtkPhysAnimSetting.bHitOnPelvis)
		{
			origin = OwnerAsCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.pelvis);
		}
		OwnerAsCharacterCS.Mesh.AddRadialImpulse(origin, radius, strength, ERadialImpulseFalloff.RIF_Linear, bVelChange: true);
	}

	private void PlayBeAttackedPhysicalAnimForDead(int HitWeight, FEffectInstReq HitInfo, float PhysAnimImpulseScale = 1f)
	{
		if (GSGameplayCVar.CVar_PhysAnimEnableBeAttack.GetValueInGameThread() == 0)
		{
			return;
		}
		bool bLoadThisTime = false;
		b1.BeAtkPhysAnimSetting beAtkPhysAnimSetting = PhysAnimData.TryGetSetting(EPhysAnimType.BeAttack, GetOwner(), out bLoadThisTime) as b1.BeAtkPhysAnimSetting;
		if (bLoadThisTime)
		{
			SetCurveCallback();
		}
		if (!PhysAnimData.MapPhysAnimSettingInitState[EPhysAnimType.BeAttack])
		{
			return;
		}
		SetPhysAnimSetting(EPhysAnimType.BeAttack);
		if (GSGameplayCVar.CVar_PhysAnimDebug.GetValueInGameThread() == 1)
		{
			FName hitBoneName = HitInfo.HitBoneName;
			_ = "HitBone:" + hitBoneName.ToString() + " bPartPhysics:" + beAtkPhysAnimSetting.bPartPhysics;
		}
		if (beAtkPhysAnimSetting.bPartPhysics)
		{
			FName hitBoneName2 = HitInfo.HitBoneName;
			FName fName = hitBoneName2;
			OwnerAsCharacterCS.Mesh.SetSimulatePhysics(bSimulate: true);
			while (!IsInSpine(fName))
			{
				hitBoneName2 = fName;
				fName = OwnerAsCharacterCS.Mesh.GetParentBone(hitBoneName2);
			}
		}
		OwnerAsCharacterCS.Mesh.SetAllBodiesPhysicsBlendWeight(1f, bSkipCustomPhysicsType: true);
		float strength = beAtkPhysAnimSetting.HitImpulse * PhysAnimImpulseScale;
		float radius = 300f;
		GsCvarData cVar_PhysAnimBeAtkRadius = GSGameplayCVar.CVar_PhysAnimBeAtkRadius;
		if (cVar_PhysAnimBeAtkRadius != null)
		{
			radius = cVar_PhysAnimBeAtkRadius.GetValueInGameThread();
		}
		FVector origin = HitInfo.HitLocation;
		if (beAtkPhysAnimSetting.bHitOnPelvis)
		{
			origin = OwnerAsCharacterCS.Mesh.GetSocketLocation(B1GlobalFNames.pelvis);
		}
		OwnerAsCharacterCS.Mesh.AddRadialImpulse(origin, radius, strength, ERadialImpulseFalloff.RIF_Linear, bVelChange: true);
	}

	public void OnMeshChanged(USkeletalMeshComponent MeshComp, USkeletalMesh OldSKMeshAsset, USkeletalMesh NewSKMeshAsset)
	{
		if (MeshComp.ComponentHasTag(B1GlobalFNames.upwear) && PhysAnimData.CurrentType == EPhysAnimType.Normal)
		{
			bool bLoadThisTime;
			PhysAnimSetting setting = PhysAnimData.TryGetSetting(EPhysAnimType.Normal, GetOwner(), out bLoadThisTime);
			StartPhysAnim(setting);
		}
	}

	public bool SetPhysAnimSetting(EPhysAnimType SourceType)
	{
		if (!DoPhyAnimTypeStateRule(SourceType))
		{
			return false;
		}
		BeforeSetPhyAnimType(SourceType);
		switch (SourceType)
		{
		case EPhysAnimType.Normal:
			if (PhysAnimData.bHasNormal)
			{
				OwnerAsCharacterCS.Mesh.SetAllowRigidBodyAnimNode(bInAllow: false, bReinitAnim: false);
				break;
			}
			PhysAnimData.CurrentType = SourceType;
			if (OwnerAsCharacterCS.Mesh.GetAttachParent() == null)
			{
				OwnerAsCharacterCS.Mesh.AttachTo(Owner.GetRootComponent(), FName.None, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: true);
			}
			return true;
		case EPhysAnimType.None:
			ClearPhysAnimSetting();
			PhysAnimData.CurrentType = SourceType;
			if (OwnerAsCharacterCS.Mesh.GetAttachParent() == null)
			{
				OwnerAsCharacterCS.Mesh.AttachTo(Owner.GetRootComponent(), FName.None, EAttachLocation.SnapToTarget, bWeldSimulatedBodies: true);
			}
			return true;
		case EPhysAnimType.PhysicBlend:
			ClearPhysAnimSetting(ClearPhyBlendBoneInfo: false);
			PhysAnimData.CurrentType = SourceType;
			return true;
		case EPhysAnimType.DeathPhysicBlend:
			ClearPhysAnimSetting(ClearPhyBlendBoneInfo: false);
			PhysAnimData.CurrentType = SourceType;
			base.BUSEventCollection?.Evt_ResetProperty.Invoke(PhysAnimData.HandleID_CollisionProfile);
			base.BUSEventCollection?.Evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, "CharacterMesh_Death");
			PhysAnimData.HandleID_CollisionProfile = PropMgrData.GetLastHandleID();
			return true;
		case EPhysAnimType.Death:
		{
			ClearPhysAnimSetting();
			PhysAnimData.CurrentType = SourceType;
			float physicsBlendWeight = (float)GSGameplayCVar.CVar_DeadAnimPhyBlendWeight.GetValueInGameThread() / 100f;
			base.BUSEventCollection?.Evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, "CharacterMesh_Death");
			PhysAnimData.HandleID_CollisionProfile = PropMgrData.GetLastHandleID();
			OwnerAsCharacterCS.Mesh.SetAllBodiesBelowSimulatePhysics(B1GlobalFNames.root, bNewSimulate: true, bIncludeSelf: false);
			OwnerAsCharacterCS.Mesh.SetAllBodiesBelowPhysicsBlendWeight(B1GlobalFNames.root, physicsBlendWeight, bSkipCustomPhysicsType: true, bIncludeSelf: false);
			base.BUSEventCollection?.Evt_OnCharacterPhysicSimulateStateChanged.Invoke(P1: true);
			return true;
		}
		case EPhysAnimType.ThrowUpDeath:
			ClearPhysAnimSetting();
			PhysAnimData.CurrentType = SourceType;
			OwnerAsCharacterCS.Mesh.SetAllBodiesBelowSimulatePhysics(B1GlobalFNames.root, bNewSimulate: true, bIncludeSelf: false);
			base.BUSEventCollection?.Evt_OnCharacterPhysicSimulateStateChanged.Invoke(P1: true);
			return true;
		}
		bool bLoadThisTime;
		PhysAnimSetting physAnimSetting = PhysAnimData.TryGetSetting(SourceType, GetOwner(), out bLoadThisTime);
		PhysAnimData.CurrentType = SourceType;
		SetPhysType(physAnimSetting);
		StartJointMotors(physAnimSetting);
		StartPhysAnim(physAnimSetting);
		return true;
	}

	private bool DoPhyAnimTypeStateRule(EPhysAnimType DesireType)
	{
		if ((int)DesireType <= (int)PhysAnimData.CurrentType)
		{
			return false;
		}
		return true;
	}

	private void BeforeSetPhyAnimType(EPhysAnimType DesireType)
	{
		PhysAnimData.TryGetSetting(DesireType, Owner, out var _);
		if (PhysAnimData.CurrentType == EPhysAnimType.PhysicsSimulationMove)
		{
			BGUFuncLibAnim.BGUSetUseSnapshotPose(GetOwner(), bUseSnapshot: true, 0f);
			PhysAnimData.bPhysicalMoveSnapshot = true;
		}
	}

	private void SetPhysType(PhysAnimSetting Setting)
	{
		if (PhysAnimData.CurrentType != EPhysAnimType.None)
		{
			OwnerAsCharacterCS.Mesh.DeferKinematicBoneUpdate = false;
		}
		if (PhysAnimData.CurrentType == EPhysAnimType.BeAttack)
		{
			if (Setting is b1.BeAtkPhysAnimSetting { bPartPhysics: false })
			{
				OwnerAsCharacterCS.Mesh.SetSimulatePhysics(bSimulate: true);
				OwnerAsCharacterCS.Mesh.SetAllBodiesBelowSimulatePhysics(B1GlobalFNames.weapon_l, bNewSimulate: false);
				OwnerAsCharacterCS.Mesh.SetAllBodiesBelowSimulatePhysics(B1GlobalFNames.weapon_r, bNewSimulate: false);
			}
			return;
		}
		if (PhysAnimData.CurrentType == EPhysAnimType.BeCatchThrow)
		{
			if (Setting is b1.BeCatchThrowPhysAnimSetting beCatchThrowPhysAnimSetting)
			{
				OwnerAsCharacterCS.Mesh.SetAllBodiesBelowSimulatePhysics(beCatchThrowPhysAnimSetting.BoneNameBelowToSimulatePhysics, bNewSimulate: true, bIncludeSelf: false);
				OwnerAsCharacterCS.Mesh.SetAllBodiesBelowPhysicsBlendWeight(beCatchThrowPhysAnimSetting.BoneNameBelowToSimulatePhysics, beCatchThrowPhysAnimSetting.PhysicsBlendWeight, bSkipCustomPhysicsType: false, bIncludeSelf: false);
			}
			return;
		}
		if (PhysAnimData.CurrentType == EPhysAnimType.PhysicsSimulationMove)
		{
			if (Setting is b1.PhysMoveAnimSetting physMoveAnimSetting)
			{
				OwnerAsCharacterCS.Mesh.SetAllBodiesBelowSimulatePhysics(physMoveAnimSetting.BoneNameToSimulatePhysics, bNewSimulate: true);
			}
			return;
		}
		OwnerAsCharacterCS.Mesh.SetSimulatePhysics(bSimulate: false);
		if (Setting.KinematicBones == null)
		{
			return;
		}
		foreach (FName kinematicBone in Setting.KinematicBones)
		{
			UBGUFunctionLibrary.SetBodyBonePhysic(OwnerAsCharacterCS.Mesh, kinematicBone, NewBool: false);
		}
	}

	private void StartJointMotors(PhysAnimSetting Setting)
	{
		OwnerAsCharacterCS.Mesh.SetConstraintProfileForAll(Setting.ConstraintProfile, bDefaultIfNotFound: true);
		OwnerAsCharacterCS.Mesh.UpdateJointsFromAnimation = true;
	}

	private void StartPhysAnim(PhysAnimSetting Setting)
	{
		List<UActorComponent> componentsByTag = Owner.GetComponentsByTag(UClass.GetClass<UPhysicalAnimationComponent>(), B1GlobalFNames.PhysicalAnimation);
		if (componentsByTag.Count == 0)
		{
			return;
		}
		UPhysicalAnimationComponent uPhysicalAnimationComponent = (UPhysicalAnimationComponent)componentsByTag[0];
		if (!(uPhysicalAnimationComponent == null))
		{
			List<UActorComponent> componentsByTag2 = Owner.GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), B1GlobalFNames.PhysicalAnimation);
			if (componentsByTag2.Count == 0)
			{
				uPhysicalAnimationComponent.SetSkeletalMeshComponent(OwnerAsCharacterCS.Mesh);
			}
			else
			{
				USkeletalMeshComponent skeletalMeshComponent = componentsByTag2[0] as USkeletalMeshComponent;
				uPhysicalAnimationComponent.SetSkeletalMeshComponent(skeletalMeshComponent);
			}
			uPhysicalAnimationComponent.ApplyPhysicalAnimationProfileBelow(FName.None, Setting.PhysAnimProfile);
		}
	}

	private void FinishBeAtkPhysBlendWeight()
	{
		if (GSGameplayCVar.CVar_PhysAnimDebug.GetValueInGameThread() == 0)
		{
			ClearPhysAnimSetting();
			SetPhysAnimSetting(EPhysAnimType.Normal);
		}
	}

	private void ClearPhysAnimSetting(bool ClearPhyBlendBoneInfo = true)
	{
		if (PhysAnimData.HandleID_CollisionProfile != 0)
		{
			base.BUSEventCollection?.Evt_ResetProperty.Invoke(PhysAnimData.HandleID_CollisionProfile);
			PhysAnimData.HandleID_CollisionProfile = 0u;
		}
		PhysAnimData.BeAtkPhysWeightTL.Stop();
		OwnerAsCharacterCS.Mesh.ResetAllBodiesSimulatePhysics();
		OwnerAsCharacterCS.Mesh.SetSimulatePhysics(bSimulate: false);
		base.BUSEventCollection?.Evt_OnCharacterPhysicSimulateStateChanged.Invoke(P1: false);
		OwnerAsCharacterCS.Mesh.SetConstraintProfileForAll(FName.None, bDefaultIfNotFound: true);
		UPhysicalAnimationComponent componentByClass = Owner.GetComponentByClass<UPhysicalAnimationComponent>();
		if (componentByClass != null)
		{
			componentByClass.SetSkeletalMeshComponent(null);
		}
		if (ClearPhyBlendBoneInfo)
		{
			ResetPhyBlendBoneInfo();
			PhysicBlendData.PhysicBlendAlpha_ForRigidBody = 1f;
		}
		BeforeSetPhyAnimType(EPhysAnimType.None);
		PhysAnimData.CurrentType = EPhysAnimType.None;
	}

	private void UpdateBeAtkPhysWeight(float Time)
	{
		if (GSGameplayCVar.CVar_PhysAnimDebug.GetValueInGameThread() == 1)
		{
			OwnerAsCharacterCS.Mesh.SetAllBodiesPhysicsBlendWeight(1f, bSkipCustomPhysicsType: true);
			return;
		}
		bool bLoadThisTime;
		b1.BeAtkPhysAnimSetting beAtkPhysAnimSetting = PhysAnimData.TryGetSetting(EPhysAnimType.BeAttack, GetOwner(), out bLoadThisTime) as b1.BeAtkPhysAnimSetting;
		if (beAtkPhysAnimSetting.bUseCurveBlend)
		{
			float floatValue = beAtkPhysAnimSetting.PhysWeightCurve.GetFloatValue(Time);
			OwnerAsCharacterCS.Mesh.SetAllBodiesPhysicsBlendWeight(floatValue, bSkipCustomPhysicsType: true);
		}
	}

	private void OnAddPhysicsImpulse(FVector Impulse, FVector Position)
	{
		FName boneName = FName.None;
		switch (PhysAnimData.CurrentType)
		{
		case EPhysAnimType.PhysicsSimulationMove:
		{
			if (PhysAnimData.TryGetSetting(EPhysAnimType.PhysicsSimulationMove, GetOwner(), out var _) is b1.PhysMoveAnimSetting physMoveAnimSetting)
			{
				boneName = physMoveAnimSetting.BoneNameToSimulatePhysics;
			}
			break;
		}
		case EPhysAnimType.Death:
			boneName = B1GlobalFNames.root;
			break;
		}
		if (OwnerAsCharacterCS.Mesh.IsSimulatingPhysics(boneName))
		{
			OwnerAsCharacterCS.Mesh.AddImpulse(Impulse, boneName, bVelChange: true);
		}
	}

	private void PhysicBlendTick(float DeltaTime)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null || PhysicBlendData.NeedBlendBoneInfoList == null || PhysicBlendData.NeedBlendBoneInfoList.Count <= 0 || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return;
		}
		for (int num = PhysicBlendData.NeedBlendBoneInfoList.Count - 1; num >= 0; num--)
		{
			PhysicBlendBoneInfo physicBlendBoneInfo = PhysicBlendData.NeedBlendBoneInfoList[num];
			if (physicBlendBoneInfo.CurrentTime <= physicBlendBoneInfo.TotalTime)
			{
				bool flag = false;
				if (physicBlendBoneInfo.BlendInTimer >= 0f)
				{
					flag = true;
					if (physicBlendBoneInfo.TotalBlendInTime <= 0f)
					{
						physicBlendBoneInfo.CurBlendWeight = physicBlendBoneInfo.TargetBlendWeight;
					}
					else
					{
						physicBlendBoneInfo.CurBlendWeight += physicBlendBoneInfo.BlendInSpd * DeltaTime;
					}
				}
				else if (physicBlendBoneInfo.BlendOutTimer <= physicBlendBoneInfo.TotalBlendOutTime)
				{
					flag = true;
					if (physicBlendBoneInfo.BlendOutTimer <= 0f)
					{
						physicBlendBoneInfo.CurBlendWeight = physicBlendBoneInfo.FromBlendWeight;
					}
					else
					{
						physicBlendBoneInfo.CurBlendWeight += physicBlendBoneInfo.BlendOutSpd * DeltaTime;
					}
				}
				if (flag && PhysAnimData.CurrentType == EPhysAnimType.PhysicBlend)
				{
					physicBlendBoneInfo.CurBlendWeight = FMath.Clamp(physicBlendBoneInfo.CurBlendWeight, 0f, 1f);
					PhysicBlendData.PhysicBlendAlpha_ForRigidBody = ((physicBlendBoneInfo.CurBlendWeight > 0f) ? 1f : 0f);
					aCharacter.Mesh.SetAllBodiesBelowSimulatePhysics(physicBlendBoneInfo.BoneName, bNewSimulate: true);
					aCharacter.Mesh.SetAllBodiesBelowPhysicsBlendWeight(physicBlendBoneInfo.BoneName, physicBlendBoneInfo.CurBlendWeight);
				}
				physicBlendBoneInfo.BlendInTimer -= DeltaTime;
				physicBlendBoneInfo.BlendOutTimer -= DeltaTime;
				physicBlendBoneInfo.TotalBlendInTime -= DeltaTime;
			}
			else
			{
				PhysicBlendData.NeedBlendBoneInfoList.RemoveAt(num);
			}
			physicBlendBoneInfo.CurrentTime += DeltaTime;
		}
		if (PhysicBlendData.NeedBlendBoneInfoList.Count == 0 && PhysAnimData.CurrentType == EPhysAnimType.PhysicBlend)
		{
			ClearPhysAnimSetting();
		}
	}

	private void PhysicBlendForDeathTick(float DeltaTime)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null || PhysicBlendData.NeedBlendBoneInfoForDeathList == null || PhysicBlendData.NeedBlendBoneInfoForDeathList.Count <= 0)
		{
			return;
		}
		int num = 0;
		foreach (PhysicBlendBoneInfoForDeath needBlendBoneInfoForDeath in PhysicBlendData.NeedBlendBoneInfoForDeathList)
		{
			if (needBlendBoneInfoForDeath.BlendInTimer < 0f)
			{
				num++;
				continue;
			}
			needBlendBoneInfoForDeath.BlendInTimer -= DeltaTime;
			if (needBlendBoneInfoForDeath.BlendInTimer > 0f)
			{
				needBlendBoneInfoForDeath.CurBlendWeight += needBlendBoneInfoForDeath.BlendInSpd * DeltaTime;
			}
			else
			{
				needBlendBoneInfoForDeath.CurBlendWeight = needBlendBoneInfoForDeath.TargetBlendWeight;
			}
			GSGameplayCVar.CVar_DeathBlendPhysicDebug.GetValueInGameThread();
			_ = 1;
			if (PhysAnimData.CurrentType == EPhysAnimType.DeathPhysicBlend)
			{
				needBlendBoneInfoForDeath.CurBlendWeight = FMath.Clamp(needBlendBoneInfoForDeath.CurBlendWeight, 0f, 1f);
				PhysicBlendData.PhysicBlendAlpha_ForRigidBody = ((needBlendBoneInfoForDeath.CurBlendWeight > 0f) ? 1f : 0f);
				aCharacter.Mesh.SetAllowRigidBodyAnimNode(bInAllow: false, bReinitAnim: false);
				aCharacter.Mesh.SetAllBodiesBelowSimulatePhysics(needBlendBoneInfoForDeath.BoneName, bNewSimulate: true);
				aCharacter.Mesh.SetAllBodiesBelowPhysicsBlendWeight(needBlendBoneInfoForDeath.BoneName, needBlendBoneInfoForDeath.CurBlendWeight, bSkipCustomPhysicsType: true);
			}
		}
		if (num == PhysicBlendData.NeedBlendBoneInfoForDeathList.Count && PhysicBlendData.CallDissolveWhenPhysicsFinish)
		{
			base.BUSEventCollection?.Evt_TriggerDeadDissolve.Invoke();
		}
	}

	private void OnActivatePhysicBlend(List<FPhysicBlendInfo> PhysicBlendInfoList, bool EnableSimulate, float TotalTime)
	{
		if (Owner as ACharacter == null)
		{
			return;
		}
		foreach (FPhysicBlendInfo PhysicBlendInfo in PhysicBlendInfoList)
		{
			PhysicBlendBoneInfo physicBlendBoneInfo = new PhysicBlendBoneInfo
			{
				BoneName = PhysicBlendInfo.BoneName,
				TotalTime = TotalTime,
				CurrentTime = 0f,
				TargetBlendWeight = (EnableSimulate ? 1 : 0),
				CurBlendWeight = ((!EnableSimulate) ? 1 : 0),
				FromBlendWeight = ((!EnableSimulate) ? 1 : 0),
				BlendInSpd = 0f,
				BlendOutSpd = 0f
			};
			if (PhysicBlendInfo.PhysicBlendInType == EPhysicBlendInType.Immediately)
			{
				physicBlendBoneInfo.TotalBlendInTime = (physicBlendBoneInfo.BlendInTimer = 0f);
			}
			else if (PhysicBlendInfo.PhysicBlendInType == EPhysicBlendInType.BlendByTime)
			{
				physicBlendBoneInfo.TotalBlendInTime = (physicBlendBoneInfo.BlendInTimer = PhysicBlendInfo.BlendInTime);
			}
			if (PhysicBlendInfo.PhysicBlendOutType == EPhysicBlendOutType.Immediately)
			{
				if (physicBlendBoneInfo.TotalTime >= 0f)
				{
					physicBlendBoneInfo.BlendOutTimer = physicBlendBoneInfo.TotalTime;
					physicBlendBoneInfo.TotalBlendOutTime = 0f;
				}
				else
				{
					physicBlendBoneInfo.TotalBlendOutTime = (physicBlendBoneInfo.BlendOutTimer = 0f);
				}
			}
			else if (PhysicBlendInfo.PhysicBlendOutType == EPhysicBlendOutType.BlendByTimeBeforeEnd)
			{
				if (physicBlendBoneInfo.TotalTime >= 0f)
				{
					physicBlendBoneInfo.TotalBlendOutTime = PhysicBlendInfo.BlendOutTime;
					physicBlendBoneInfo.BlendOutTimer = physicBlendBoneInfo.TotalTime;
				}
				else
				{
					physicBlendBoneInfo.TotalBlendOutTime = (physicBlendBoneInfo.BlendOutTimer = 0f);
				}
			}
			else if (PhysicBlendInfo.PhysicBlendOutType == EPhysicBlendOutType.BlendByTimeAfterEnd)
			{
				if (physicBlendBoneInfo.TotalTime >= 0f)
				{
					physicBlendBoneInfo.TotalBlendOutTime = PhysicBlendInfo.BlendOutTime;
					physicBlendBoneInfo.TotalTime += PhysicBlendInfo.BlendOutTime;
					physicBlendBoneInfo.BlendOutTimer = physicBlendBoneInfo.TotalTime;
				}
				else
				{
					physicBlendBoneInfo.TotalBlendOutTime = (physicBlendBoneInfo.BlendOutTimer = 0f);
				}
			}
			if (PhysicBlendInfo.BlendOutTime > 0f)
			{
				physicBlendBoneInfo.BlendOutSpd = (physicBlendBoneInfo.FromBlendWeight - physicBlendBoneInfo.TotalBlendInTime) / PhysicBlendInfo.BlendOutTime;
			}
			if (PhysicBlendInfo.BlendInTime > 0f)
			{
				physicBlendBoneInfo.BlendInSpd = (physicBlendBoneInfo.TargetBlendWeight - physicBlendBoneInfo.FromBlendWeight) / PhysicBlendInfo.BlendInTime;
			}
			PhysicBlendData.NeedBlendBoneInfoList.Add(physicBlendBoneInfo);
		}
		if (PhysicBlendData.NeedBlendBoneInfoList.Count > 0)
		{
			if (!EnableSimulate)
			{
				PhysicBlendData.PhysicBlendAlpha_ForRigidBody = 0f;
			}
			SetPhysAnimSetting(EPhysAnimType.PhysicBlend);
		}
	}

	private void OnActivatePhysicBlendForDeath(List<FPhysicBlendInfoForDeath> PhysicBlendInfoList, float TotalTime, bool CallDissolveWhenPhysicsFinish)
	{
		if (Owner as ACharacter == null)
		{
			return;
		}
		PhysicBlendData.CallDissolveWhenPhysicsFinish = CallDissolveWhenPhysicsFinish;
		foreach (FPhysicBlendInfoForDeath PhysicBlendInfo in PhysicBlendInfoList)
		{
			PhysicBlendBoneInfoForDeath physicBlendBoneInfoForDeath = new PhysicBlendBoneInfoForDeath
			{
				BoneName = PhysicBlendInfo.BoneName,
				TargetBlendWeight = PhysicBlendInfo.BlendFinalValue,
				CurBlendWeight = 0f,
				FromBlendWeight = 0f,
				BlendInSpd = 0f
			};
			if (PhysicBlendInfo.PhysicBlendInType == EPhysicBlendInType.Immediately)
			{
				physicBlendBoneInfoForDeath.BlendInTimer = 0f;
				physicBlendBoneInfoForDeath.BlendInSpd = 0f;
			}
			else if (PhysicBlendInfo.PhysicBlendInType == EPhysicBlendInType.BlendByTime)
			{
				physicBlendBoneInfoForDeath.BlendInTimer = TotalTime;
				if (TotalTime > 0f)
				{
					physicBlendBoneInfoForDeath.BlendInSpd = (physicBlendBoneInfoForDeath.TargetBlendWeight - physicBlendBoneInfoForDeath.FromBlendWeight) / TotalTime;
				}
			}
			PhysicBlendData.NeedBlendBoneInfoForDeathList.Add(physicBlendBoneInfoForDeath);
		}
		if (PhysicBlendData.NeedBlendBoneInfoForDeathList.Count > 0)
		{
			PhysicBlendData.PhysicBlendAlpha_ForRigidBody = 1f;
			SetPhysAnimSetting(EPhysAnimType.DeathPhysicBlend);
		}
	}

	private void ResetPhyBlendBoneInfo()
	{
		PhysicBlendData.NeedBlendBoneInfoList.Clear();
		PhysicBlendData.NeedBlendBoneInfoForDeathList.Clear();
	}
}
