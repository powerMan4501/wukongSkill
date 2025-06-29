using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_BulletSweepCheckCompImpl : UActorCompBaseCS
{
	private IBUC_MasterData MasterData;

	private b1.IBUC_ObjActorCompsData ObjActorComps;

	private BUC_BulletSweepCheckData BulletSweepCheckData;

	private BUC_ProjectileScaleMgrData ProjectileScaleMgrData;

	private BUC_ProjectileBasicData ProjectileBasicData;

	private List<ECollisionChannel> BlockChannelsForFilter { get; set; }

	private List<ECollisionChannel> BlockChannelsForFilter_AttackWarning { get; set; }

	public override void OnAttach()
	{
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		ObjActorComps = RequireReadOnlyData<b1.IBUC_ObjActorCompsData, BUC_ObjActorCompsData>();
		BulletSweepCheckData = RequireWritableData<BUC_BulletSweepCheckData>();
		ProjectileScaleMgrData = RequireWritableData<BUC_ProjectileScaleMgrData>();
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		base.BUSEventCollection.Evt_OnProjectileIDChanged += new Del_Void_Int(SetSweepCheckData);
		base.BUSEventCollection.Evt_SetBulletSweepCheckMode += new Del_SetBulletSweepCheckMode(OnSetSweepCheckMode);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnBulletDead);
		BlockChannelsForFilter = new List<ECollisionChannel>
		{
			ECollisionChannel.ECC_PhysicsBody,
			ECollisionChannel.ECC_WorldDynamic,
			ECollisionChannel.ECC_GameTraceChannel8
		};
		if (BulletSweepCheckData.NeedCheckWorldStatic_BP)
		{
			BlockChannelsForFilter.Add(ECollisionChannel.ECC_WorldStatic);
		}
		BlockChannelsForFilter_AttackWarning = new List<ECollisionChannel> { ECollisionChannel.ECC_PhysicsBody };
	}

	public override void OnBeginPlay()
	{
		CheckShapeIsValid();
	}

	private void CheckShapeIsValid()
	{
		bool checkShapeIsValid = false;
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (!bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			switch (ProjectileBasicData.CheckShapeType)
			{
			case EProjectileCheckShapeType.SphereShape:
				if (!bGUProjectileBaseActor.GetSphereCollisionComp().IsNullOrDestroyed())
				{
					checkShapeIsValid = true;
				}
				break;
			case EProjectileCheckShapeType.BoxShape:
				if (!bGUProjectileBaseActor.GetBoxCollisionComp().IsNullOrDestroyed())
				{
					checkShapeIsValid = true;
				}
				break;
			case EProjectileCheckShapeType.CapsuleShape:
				if (!bGUProjectileBaseActor.GetCapsuleCollisionComp().IsNullOrDestroyed())
				{
					checkShapeIsValid = true;
				}
				break;
			case EProjectileCheckShapeType.SceneItem:
				if (!bGUProjectileBaseActor.GetBoxCollisionComp().IsNullOrDestroyed())
				{
					checkShapeIsValid = true;
				}
				break;
			case EProjectileCheckShapeType.CustomShape:
				if (!bGUProjectileBaseActor.GetCustomCollisionComp().IsNullOrDestroyed())
				{
					checkShapeIsValid = true;
				}
				break;
			}
		}
		BulletSweepCheckData.CheckShapeIsValid = checkShapeIsValid;
	}

	public override int GetTickGroupMask()
	{
		return 10;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.DefaultShape || !BulletSweepCheckData.CheckShapeIsValid || !BulletSweepCheckData.EnableSweepCheck)
		{
			return;
		}
		switch (TickGroup)
		{
		case 2:
			UpdateLastTransform();
			if (BulletSweepCheckData.SweepDelayTimer <= 0f)
			{
				SweepProtectTimerUpdate(DeltaTime);
				BulletSweepCheckData.BeDamagedEntities.Clear();
				AttackWarningUpdate();
			}
			break;
		case 8:
			if (BulletSweepDelayTimeTick(DeltaTime))
			{
				switch (BulletSweepCheckData.CheckMode)
				{
				case BulletSweepCheckMode.Normal:
					SweepCheckUpdate();
					break;
				}
			}
			BulletSweepCheckData.PreTransform = BulletSweepCheckData.CurTransform;
			break;
		}
	}

	private void UpdateLastTransform()
	{
		UpdateSweepTransformInfo(ref BulletSweepCheckData.CurTransform, ref BulletSweepCheckData.SweepCheckShapeRot, ref BulletSweepCheckData.SweepCheckShapeInfo);
		if (MathLib.Dist(BulletSweepCheckData.CurTransform.Translation, BulletSweepCheckData.PreTransform.Translation) == 0f)
		{
			BulletSweepCheckData.PreTransform.SetLocation(BulletSweepCheckData.PreTransform.Translation - FVector.OneVector);
		}
	}

	private bool BulletSweepDelayTimeTick(float DeltaTime)
	{
		if (BulletSweepCheckData.SweepDelayTimer > 0f)
		{
			BulletSweepCheckData.SweepDelayTimer -= DeltaTime;
			return false;
		}
		return true;
	}

	private void SweepProtectTimerUpdate(float DeltaTime)
	{
		int[] array = BulletSweepCheckData.HitActorTimer.Keys.ToArray();
		foreach (int key in array)
		{
			if (BulletSweepCheckData.HitActorTimer[key] > 0f)
			{
				BulletSweepCheckData.HitActorTimer[key] -= DeltaTime;
			}
			else
			{
				BulletSweepCheckData.HitActorTimer.Remove(key);
			}
		}
		if (BulletSweepCheckData.HitItemTimer > 0f)
		{
			BulletSweepCheckData.HitItemTimer -= DeltaTime;
		}
	}

	private void AttackWarningUpdate()
	{
		BGUBulletBaseCS bGUBulletBaseCS = GetOwner() as BGUBulletBaseCS;
		if (bGUBulletBaseCS.IsNullOrDestroyed() || !BulletSweepCheckData.bEnableAttackWarning || !BulletSweepCheckData.bHasDmgEffect)
		{
			return;
		}
		List<AActor> list = new List<AActor> { bGUBulletBaseCS };
		AActor attachParentActor = bGUBulletBaseCS.GetAttachParentActor();
		if (!attachParentActor.IsNullOrDestroyed())
		{
			list.Add(attachParentActor);
		}
		if ((BulletSweepCheckData.HitCheckConf.ResultFilterType == ESweepCheckHitFilterType.NotInSameTeam || BulletSweepCheckData.HitCheckConf.ResultFilterType == ESweepCheckHitFilterType.FilterMaster) && MasterData != null && MasterData.GetMasterActor() != null)
		{
			list.Add(MasterData.GetMasterActor());
		}
		foreach (AActor beDamagedEntity in BulletSweepCheckData.BeDamagedEntities)
		{
			list.Add(beDamagedEntity);
		}
		FRotator fRotator = default(FRotator);
		FVector fVector = default(FVector);
		USceneComponent uSceneComponent;
		switch (ProjectileBasicData.CheckShapeType)
		{
		default:
			return;
		case EProjectileCheckShapeType.BoxShape:
			uSceneComponent = bGUBulletBaseCS.GetBoxCollisionComp();
			break;
		case EProjectileCheckShapeType.SphereShape:
			uSceneComponent = bGUBulletBaseCS.GetSphereCollisionComp();
			break;
		case EProjectileCheckShapeType.CapsuleShape:
			uSceneComponent = bGUBulletBaseCS.GetCapsuleCollisionComp();
			break;
		case EProjectileCheckShapeType.CustomShape:
			uSceneComponent = bGUBulletBaseCS.GetCustomCollisionComp();
			break;
		case EProjectileCheckShapeType.SceneItem:
			return;
		}
		if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.LineTrace)
		{
			fVector = bGUBulletBaseCS.GetWorldTransform_LineTracePoint().Translation;
		}
		else
		{
			fRotator = uSceneComponent.GetWorldRotation();
			fVector = uSceneComponent.GetWorldLocation();
		}
		FVector v = ((BulletSweepCheckData.AttackWarningOffset.Size() <= 0f) ? FVector.ForwardVector : BulletSweepCheckData.AttackWarningOffset);
		FVector fVector2 = fVector + BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUBulletBaseCS).TransformVectorNoScale(v);
		if (!Optimize_bySimpleOverlap_AttackWarning(fVector, fVector2, ProjectileBasicData.CheckShapeType))
		{
			return;
		}
		List<FUStGSHitResult> SweepResults = new List<FUStGSHitResult>();
		if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.LineTrace)
		{
			UBGUFuncLibSelectTargets.BGULineTraceMultiByCollisionChannel(Owner, fVector, fVector2, BulletSweepCheckData.SweepCheckChannel, out SweepResults, list, BlockChannelsForFilter, null, BulletSweepCheckData.bEnableDebug);
		}
		else
		{
			FGSSweepCheckShapeInfo sweepCheckShapeInfo;
			if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.CustomShape)
			{
				sweepCheckShapeInfo = new FGSSweepCheckShapeInfo
				{
					SweepCheckShapeType = EGSSweepCheckShapeType.BoxShape,
					ShapeParamFloat = 0f,
					ShapeParamVector = bGUBulletBaseCS.GetCustomCollisionComp().StaticMesh.GetBoundingBox().GetExtent() + BulletSweepCheckData.AttackWarningExtendSize
				};
			}
			else
			{
				sweepCheckShapeInfo = BulletSweepCheckData.SweepCheckShapeInfo;
				sweepCheckShapeInfo.ShapeParamFloat += BulletSweepCheckData.AttackWarningExtendSize;
				sweepCheckShapeInfo.ShapeParamVector += (double)BulletSweepCheckData.AttackWarningExtendSize;
			}
			ECollisionChannel collisionChannel = ECollisionChannel.ECC_GameTraceChannel6;
			UBGUFuncLibSelectTargets.BGUGetSweepCheckResultsByCollisionChannel(Owner, new FTransform(fVector), new FTransform(fVector2), fRotator.Quaternion(), collisionChannel, sweepCheckShapeInfo, out SweepResults, list, BlockChannelsForFilter_AttackWarning, null, BulletSweepCheckData.bEnableDebug);
		}
		foreach (FUStGSHitResult item in SweepResults)
		{
			OnSweepCheckHitPreciseDodge(item.Actor);
		}
	}

	private void SweepCheckUpdate()
	{
		BGUBulletBaseCS bGUBulletBaseCS = GetOwner() as BGUBulletBaseCS;
		if (bGUBulletBaseCS.IsNullOrDestroyed())
		{
			return;
		}
		FTransform preTransform = BulletSweepCheckData.PreTransform;
		FTransform curTransform = BulletSweepCheckData.CurTransform;
		FQuat sweepCheckShapeRot = BulletSweepCheckData.SweepCheckShapeRot;
		FGSSweepCheckShapeInfo SweepCheckShapeInfo = BulletSweepCheckData.SweepCheckShapeInfo;
		List<AActor> IgnoreActors = new List<AActor>();
		WrapSweepCheckIgnoreActorList(ref IgnoreActors);
		List<FUStGSHitResult> SweepResults = new List<FUStGSHitResult>();
		if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.LineTrace)
		{
			UBGUFuncLibSelectTargets.BGULineTraceMultiByCollisionChannel(Owner, preTransform.Translation, curTransform.Translation, BulletSweepCheckData.SweepCheckChannel, out SweepResults, IgnoreActors, BlockChannelsForFilter, null);
		}
		else if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.CustomShape)
		{
			UBGUFuncLibSelectTargets.BGUComponentSweepMulti(Owner, BulletSweepCheckData.SweepCheckChannel, bGUBulletBaseCS.GetCustomCollisionComp(), preTransform.Translation, curTransform.Translation, sweepCheckShapeRot, out SweepResults, IgnoreActors, BlockChannelsForFilter, null);
		}
		else
		{
			UBGUFuncLibSelectTargets.BGUGetSweepCheckResultsByCollisionChannel(Owner, preTransform, curTransform, sweepCheckShapeRot, BulletSweepCheckData.SweepCheckChannel, SweepCheckShapeInfo, out SweepResults, IgnoreActors, BlockChannelsForFilter, null);
		}
		if (SweepResults.Count < 1)
		{
			return;
		}
		bool flag = false;
		List<Entity> HandledEntitys = new List<Entity>();
		FUStGSHitResult gSHitResult = default(FUStGSHitResult);
		foreach (FUStGSHitResult item in SweepResults)
		{
			FUStGSHitResult GSHitResult = item;
			SolveCanBeHit(bGUBulletBaseCS, GSHitResult.Actor, out var HitUnit, out var HitItem);
			if (HitUnit)
			{
				UnitSweepCheck(ref HandledEntitys, in GSHitResult, in SweepCheckShapeInfo, in BulletSweepCheckData.SweepCheckShapeRot);
			}
			else if (HitItem)
			{
				flag = true;
				gSHitResult = GSHitResult;
			}
		}
		if (flag)
		{
			OnCustomSweepHitWorldItem(gSHitResult);
		}
	}

	private List<ECollisionChannel> Optimize_bySimpleOverlap(FVector PrePos, FVector CurPos, EProjectileCheckShapeType ProjectileCheckShapeType)
	{
		List<ECollisionChannel> list = new List<ECollisionChannel>();
		list.AddRange(BlockChannelsForFilter);
		return list;
	}

	private bool Optimize_bySimpleOverlap_AttackWarning(FVector PrePos, FVector CurPos, EProjectileCheckShapeType ProjectileCheckShapeType)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		FVector targetBaseLoc = (PrePos * 0.5 + CurPos * 1.5) / 2.0;
		int num = 0;
		num++;
		float num2 = (CurPos - PrePos).Size() + 500f;
		switch (ProjectileCheckShapeType)
		{
		case EProjectileCheckShapeType.BoxShape:
			num2 += (float)bGUProjectileBaseActor.GetBoxCollisionComp().GetScaledBoxExtent().GetMax() / 2f;
			break;
		case EProjectileCheckShapeType.SphereShape:
			num2 += bGUProjectileBaseActor.GetSphereCollisionComp().GetScaledSphereRadius();
			break;
		case EProjectileCheckShapeType.CapsuleShape:
			num2 += bGUProjectileBaseActor.GetCapsuleCollisionComp().GetScaledCapsuleHalfHeight() + bGUProjectileBaseActor.GetCapsuleCollisionComp().GetScaledCapsuleRadius();
			break;
		case EProjectileCheckShapeType.CustomShape:
		{
			bGUProjectileBaseActor.GetCustomCollisionComp().GetLocalBounds(out var _, out var Max);
			num2 += (float)Max.GetMax() / 2f;
			break;
		}
		}
		List<AActor> OutActors;
		bool allActorsBySimpleOverlapWithTypeFilter = BGUFuncLibSelectTargetsCS.GetAllActorsBySimpleOverlapWithTypeFilter(Owner, Owner, targetBaseLoc, num, num2, 0f, 0f, FVector2D.ZeroVector, bIsSphere: true, out OutActors);
		bool flag = false;
		AActor aActor = null;
		if (MasterData != null && MasterData.GetMasterActor() != null)
		{
			aActor = MasterData.GetMasterActor();
		}
		if (OutActors.Count > 0)
		{
			foreach (AActor item in OutActors)
			{
				BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
				if (bGUCharacterCS != null && (!(aActor != null) || !(aActor == bGUCharacterCS)))
				{
					if (bGUCharacterCS is BGUPlayerCharacterCS)
					{
						flag = true;
						break;
					}
					if (BGUFuncLibActorTransformCS.BGUGetCharacterHasBlockConfig(bGUCharacterCS))
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (!flag)
		{
			return !allActorsBySimpleOverlapWithTypeFilter;
		}
		return true;
	}

	private void WrapSweepCheckIgnoreActorList(ref List<AActor> IgnoreActors)
	{
		BGUBulletBaseCS bGUBulletBaseCS = GetOwner() as BGUBulletBaseCS;
		IgnoreActors.Add(bGUBulletBaseCS);
		if (BulletSweepCheckData.ProjectileType == EBGUBulletType.SceneItem)
		{
			AActor attachParentActor = bGUBulletBaseCS.GetAttachParentActor();
			if (!attachParentActor.IsNullOrDestroyed())
			{
				IgnoreActors.Add(attachParentActor);
			}
		}
		if ((BulletSweepCheckData.HitCheckConf.ResultFilterType == ESweepCheckHitFilterType.NotInSameTeam || BulletSweepCheckData.HitCheckConf.ResultFilterType == ESweepCheckHitFilterType.FilterMaster) && MasterData != null && MasterData.GetMasterActor() != null)
		{
			IgnoreActors.Add(MasterData.GetMasterActor());
		}
	}

	private void OnSweepCheckHitPreciseDodge(AActor Victim)
	{
		BGUBulletBaseCS bGUBulletBaseCS = GetOwner() as BGUBulletBaseCS;
		if (!(bGUBulletBaseCS == null) && !BGUFuncLibSelectTargetsCS.FilterSweepCheck(bGUBulletBaseCS, Victim, BulletSweepCheckData.HitCheckConf.ResultFilterType))
		{
			BUS_EventCollectionCS.Get(Victim).Evt_SweepCheckInPreciseDodgeRange.Invoke(Owner, 0, -1, 0, 5f);
		}
	}

	private void UpdateSweepTransformInfo(ref FTransform NewCurTransform, ref FQuat SweepCheckShapeRot, ref FGSSweepCheckShapeInfo SweepCheckShapeInfo)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.LineTrace)
		{
			NewCurTransform = bGUProjectileBaseActor.GetWorldTransform_LineTracePoint();
		}
		else if (ProjectileBasicData.CheckShapeType == EProjectileCheckShapeType.CustomShape)
		{
			if (!(bGUProjectileBaseActor.GetCustomCollisionComp().StaticMesh == null))
			{
				SweepCheckShapeRot = bGUProjectileBaseActor.GetCustomCollisionComp().GetWorldRotation().Quaternion();
				NewCurTransform = BGUFuncLibActorTransformCS.BGUGetWorldTransform(bGUProjectileBaseActor.GetCustomCollisionComp());
			}
		}
		else
		{
			BGU_ObjActorUtil.CreateSweepCheckShapeAndRot(bGUProjectileBaseActor, ProjectileBasicData.CheckShapeType, out SweepCheckShapeInfo, out var CurTransform);
			NewCurTransform = CurTransform;
			SweepCheckShapeRot = CurTransform.Rotation;
		}
	}

	private bool UnitSweepCheck(ref List<Entity> HandledEntitys, in FUStGSHitResult GSHitResult, in FGSSweepCheckShapeInfo SweepCheckShapeInfo, in FQuat SweepCheckShapeRot)
	{
		Entity item = ECSUtil.ToEntity(GSHitResult.Actor);
		if (!HandledEntitys.Contains(item))
		{
			HandledEntitys.Add(item);
			IBUC_SpecialBoneListData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SpecialBoneListData, BUC_SpecialBoneListData>(GSHitResult.Actor);
			if (readOnlyData != null && readOnlyData.ExcludedBonesFromSweepCheck.Contains(GSHitResult.BoneName))
			{
				return false;
			}
			int entityHash = AActorStatics.GetEntityHash(GSHitResult.Actor);
			BulletSweepCheckData.HitActorTimer.Add(entityHash, BulletSweepCheckData.BulletSweepCheckGap);
			if (MasterData != null && MasterData.GetMasterActor() != null)
			{
				BUC_UnitDebugData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitDebugData>(MasterData.GetMasterActor());
				UWorld world = Owner.World;
				if (readOnlyData2 != null && readOnlyData2.DrawBulletCollision)
				{
					UBGUFunctionLibraryForCS.BGUDrawSweepCheckShape(world, GSHitResult.ImpactPoint, SweepCheckShapeRot, SweepCheckShapeInfo);
				}
			}
			OnCustomSweepHitNormalUnit(in GSHitResult);
			return true;
		}
		return false;
	}

	private void PhyHitEvent(FUStGSHitResult GSHitResult)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		BGUBulletBaseCS bGUBulletBaseCS = owner as BGUBulletBaseCS;
		if (bGUBulletBaseCS == null)
		{
			return;
		}
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(bGUBulletBaseCS.GetProjectileID());
		if (bulletExpandDesc != null && BulletSweepCheckData.CheckMode == BulletSweepCheckMode.Bounce)
		{
			SolveCanBeHit(owner, GSHitResult.Actor, out var HitUnit, out var HitItem);
			if (HitUnit)
			{
				int entityHash = AActorStatics.GetEntityHash(GSHitResult.Actor);
				BulletSweepCheckData.HitActorTimer.Add(entityHash, bulletExpandDesc.BulletSweepCheckGap);
				OnCustomSweepHitNormalUnit(in GSHitResult);
			}
			else if (HitItem)
			{
				OnCustomSweepHitWorldItem(GSHitResult);
			}
		}
	}

	private void SolveCanBeHit(AActor OwnerActor, AActor BeHitActor, out bool HitUnit, out bool HitItem, bool ShouldDoSweepCheck = true)
	{
		HitUnit = false;
		HitItem = false;
		if (BeHitActor is IECSWorldObj iECSWorldObj && !iECSWorldObj.IsBeginPlayFinished())
		{
			return;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = OwnerActor as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor.IsNullOrDestroyed())
		{
			return;
		}
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(bGUProjectileBaseActor.GetProjectileID());
		if (bulletExpandDesc == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = BeHitActor as BGUCharacterCS;
		BGUProjectileBaseActor bGUProjectileBaseActor2 = BeHitActor as BGUProjectileBaseActor;
		b1.IBUC_DestructibleData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(BeHitActor);
		if (bGUCharacterCS != null)
		{
			if (!ShouldDoSweepCheck || BGUFuncLibSelectTargetsCS.FilterSweepCheck(OwnerActor, bGUCharacterCS, BulletSweepCheckData.HitCheckConf.ResultFilterType) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeSweepChecked))
			{
				return;
			}
			if (ProjectileScaleMgrData.InnerRadiusCurve != null)
			{
				float distanceTo = bGUCharacterCS.GetDistanceTo(bGUProjectileBaseActor);
				float scaledCapsuleRadius = bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius();
				if (distanceTo + scaledCapsuleRadius < ProjectileScaleMgrData.InnerRadiusCurveValue)
				{
					return;
				}
			}
			if (MasterData != null && bulletExpandDesc.BulletIsOnlyHitTarget == EGSYesNo.Yes)
			{
				BUC_ObjActorMovementData bUC_ObjActorMovementData = RequireWritableData<BUC_ObjActorMovementData>();
				if (bUC_ObjActorMovementData.TargetActor == null || bUC_ObjActorMovementData.TargetActor != bGUCharacterCS)
				{
					return;
				}
			}
			int entityHash = AActorStatics.GetEntityHash(BeHitActor);
			if (!BulletSweepCheckData.HitActorTimer.ContainsKey(entityHash))
			{
				HitUnit = true;
			}
		}
		else if (bGUProjectileBaseActor2 != null)
		{
			int entityHash2 = AActorStatics.GetEntityHash(BeHitActor);
			if (BulletSweepCheckData.HitActorTimer.ContainsKey(entityHash2))
			{
				return;
			}
			if (ProjectileScaleMgrData.InnerRadiusCurve != null)
			{
				float distanceTo2 = bGUProjectileBaseActor2.GetDistanceTo(bGUProjectileBaseActor);
				float actorBoundingSphereRadius = UGSE_CharacterFuncLib.GetActorBoundingSphereRadius(bGUProjectileBaseActor2);
				if (distanceTo2 + actorBoundingSphereRadius < ProjectileScaleMgrData.InnerRadiusCurveValue)
				{
					HitUnit = false;
					return;
				}
			}
			HitUnit = true;
		}
		else if (readOnlyData != null && (BeHitActor is BGUFXActorBase || readOnlyData.CanBeHitByBullet))
		{
			int entityHash3 = AActorStatics.GetEntityHash(BeHitActor);
			if (!BulletSweepCheckData.HitActorTimer.ContainsKey(entityHash3))
			{
				HitUnit = true;
			}
		}
		else if (BeHitActor != null && (bulletExpandDesc == null || bulletExpandDesc.BulletCanThroughBlockage != EGSYesNo.Yes) && BeHitActor as BGUWeaponBase == null && BulletSweepCheckData.HitItemTimer <= 0f)
		{
			HitItem = true;
		}
	}

	private void OnCustomSweepHitWorldItem(FUStGSHitResult GSHitResult)
	{
		BGUBulletBaseCS bGUBulletBaseCS = GetOwner() as BGUBulletBaseCS;
		if (!bGUBulletBaseCS.IsNullOrDestroyed())
		{
			FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(bGUBulletBaseCS.GetProjectileID());
			BulletSweepCheckData.HitItemTimer = bulletExpandDesc.BulletSweepCheckGap;
			AActor actor = GSHitResult.Actor;
			FEffectInstReq EffectInstReq = new FEffectInstReq
			{
				HitLocation = GSHitResult.ImpactPoint,
				HitPointNormalDir = GSHitResult.Normal.Rotation(),
				HitComp = GSHitResult.HitComponent,
				HitBoneName = new FName(StringParseHelper.SafeToLower(GSHitResult.BoneName.ToString())),
				SweepCheckBegin = BulletSweepCheckData.PreTransform.GetLocation(),
				SweepCheckEnd = BulletSweepCheckData.CurTransform.GetLocation()
			};
			BUS_EventCollectionCS.Get(this)?.Evt_OnProjectileCustomSweepHitWorldItem.Invoke(EffectInstReq, actor);
			TriggerHitEffectAndPlayFX(ref EffectInstReq, IsHitUnit: false, actor);
		}
	}

	private void OnCustomSweepHitNormalUnit(in FUStGSHitResult GSHitResult)
	{
		if (BUS_EventCollectionCS.Get(this) == null || !(GSHitResult.Actor != null))
		{
			return;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(GSHitResult.Actor, EBGUSimpleState.CanHitBullet))
		{
			int projectileID = ProjectileBasicData.ProjectileID;
			base.BUSEventCollection.Evt_OnProjectileBeHitted.Invoke(GSHitResult.Actor, null);
			int projectileID2 = ProjectileBasicData.ProjectileID;
			if (projectileID != projectileID2 || !BulletSweepCheckData.EnableSweepCheck)
			{
				return;
			}
		}
		if (GSHitResult.Actor is BGUCharacterCS)
		{
			BUS_EventCollectionCS.Get(this)?.Evt_OnProjectileCustomSweepHitNormalUnit.Invoke(GSHitResult);
		}
		FEffectInstReq EffectInstReq = new FEffectInstReq
		{
			HitLocation = GSHitResult.ImpactPoint,
			HitPointNormalDir = GSHitResult.Normal.Rotation(),
			HitActionDir = EHitActionDir.Default,
			HitBoneName = new FName(StringParseHelper.SafeToLower(GSHitResult.BoneName.ToString())),
			HitComp = GSHitResult.HitComponent,
			SweepCheckBegin = BulletSweepCheckData.PreTransform.GetLocation(),
			SweepCheckEnd = BulletSweepCheckData.CurTransform.GetLocation()
		};
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(ProjectileBasicData.ProjectileID);
		if (bulletExpandDesc != null && bulletExpandDesc.IsLaserType == EGSYesNo.Yes)
		{
			FRotator laserStiffDir = default(FRotator);
			BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
			if (bGUProjectileBaseActor != null)
			{
				UBoxComponent boxCollisionComp = bGUProjectileBaseActor.GetBoxCollisionComp();
				float num = boxCollisionComp.GetScaledBoxExtent().Y * 0.8f;
				FVector fVector = boxCollisionComp.GetWorldTransform().InverseTransformPosition(BGUFuncLibActorTransformCS.BGUGetActorLocation(GSHitResult.Actor));
				laserStiffDir = ((fVector.Y > num / 2f) ? UMathLibrary.MakeRotFromX(boxCollisionComp.GetWorldTransform().TransformDirection(new FVector(0.0, -1.0, 0.0))) : ((!(fVector.Y < (0f - num) / 2f)) ? UMathLibrary.MakeRotFromX(boxCollisionComp.GetWorldTransform().TransformDirection(new FVector(1.0, 0.0, 0.0))) : UMathLibrary.MakeRotFromX(boxCollisionComp.GetWorldTransform().TransformDirection(new FVector(0.0, 1.0, 0.0)))));
			}
			EffectInstReq.LaserStiffDir = laserStiffDir;
		}
		FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(ProjectileBasicData.ProjectileID);
		if (projectileDispDesc != null)
		{
			EffectInstReq.AudioID_HitChr = projectileDispDesc.HitChrAudioID;
			EffectInstReq.FXWeight_HitChr = -1;
		}
		TriggerHitEffectAndPlayFX(ref EffectInstReq, IsHitUnit: true, GSHitResult.Actor);
	}

	private void TriggerHitEffectAndPlayFX(ref FEffectInstReq EffectInstReq, bool IsHitUnit, AActor BeHitActor = null)
	{
		if (GetOwner().IsNullOrDestroyed())
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		if (IsHitUnit)
		{
			if (BeHitActor as BGUCharacterCS != null)
			{
				flag = true;
			}
			else if (BeHitActor as BGUProjectileBaseActor != null)
			{
				flag2 = true;
			}
			else if (BGU_DataUtil.GetReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(BeHitActor) != null)
			{
				flag3 = true;
			}
		}
		EBGUBulletDispReason bulletDispReason = EBGUBulletDispReason.None;
		EBGUBulletTriggerEffectReason eBGUBulletTriggerEffectReason = EBGUBulletTriggerEffectReason.None;
		if (flag)
		{
			bulletDispReason = EBGUBulletDispReason.HitChr;
			eBGUBulletTriggerEffectReason = EBGUBulletTriggerEffectReason.HitCharacter;
			if (BulletSweepCheckData.bHitChrAttach)
			{
				base.BUSEventCollection.Evt_ProjectileAttachToTarget.Invoke(BeHitActor, BulletSweepCheckData.HitChrAttachTime, BulletSweepCheckData.AttachOffset, in EffectInstReq);
			}
		}
		else if (flag2)
		{
			eBGUBulletTriggerEffectReason = EBGUBulletTriggerEffectReason.HitProjectile;
		}
		else if (flag3)
		{
			bulletDispReason = EBGUBulletDispReason.HitSceneItem;
			eBGUBulletTriggerEffectReason = EBGUBulletTriggerEffectReason.HitDestructible;
		}
		else
		{
			bulletDispReason = EBGUBulletDispReason.HitSceneItem;
			eBGUBulletTriggerEffectReason = EBGUBulletTriggerEffectReason.HitItem;
			if (BulletSweepCheckData.bHitItemAttach)
			{
				base.BUSEventCollection?.Evt_ProjectileAttachToTarget.Invoke(BeHitActor, BulletSweepCheckData.HitItemAttachTime, BulletSweepCheckData.AttachOffset, in EffectInstReq);
			}
		}
		base.BUSEventCollection.Evt_SpawnBulletFXByReason.Invoke(bulletDispReason, EffectInstReq, BeHitActor);
		if (GetOwner() as BGUBulletBaseCS != null && BeHitActor != null && BulletSweepCheckData.bHasDmgEffect)
		{
			BulletSweepCheckData.BeDamagedEntities.Add(BeHitActor);
		}
		base.BUSEventCollection.Evt_BulletTriggerEffectsByReson.Invoke(eBGUBulletTriggerEffectReason, ref EffectInstReq, BeHitActor);
	}

	private void OnSetSweepCheckMode(BulletSweepCheckMode CheckMode)
	{
		_ = BulletSweepCheckData.CheckMode;
		BulletSweepCheckData.CheckMode = CheckMode;
		_ = BulletSweepCheckData.CheckMode;
	}

	private void SetSweepCheckData(int BulletCommID)
	{
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(BulletCommID, MasterData.GetMasterActor());
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(BulletCommID);
		if (projectileCommDesc == null || bulletExpandDesc == null)
		{
			return;
		}
		BulletSweepCheckData.SweepDelayTimer = bulletExpandDesc.BulletSweepCheckDelayTime;
		BulletSweepCheckData.BulletSweepCheckGap = bulletExpandDesc.BulletSweepCheckGap;
		BulletSweepCheckData.bHasDmgEffect = BGU_CommonUtil.HasDamageSkillEffect(bulletExpandDesc.HitEffectsforChr.ToList());
		if (bulletExpandDesc.HitItemEffectsforSelf.Count > 0 && BulletSweepCheckData.NeedCheckWorldStatic_BP)
		{
			if (!BlockChannelsForFilter.Contains(ECollisionChannel.ECC_WorldStatic))
			{
				BlockChannelsForFilter.Add(ECollisionChannel.ECC_WorldStatic);
			}
		}
		else if (BlockChannelsForFilter.Contains(ECollisionChannel.ECC_WorldStatic))
		{
			BlockChannelsForFilter.Remove(ECollisionChannel.ECC_WorldStatic);
		}
		BulletSweepCheckData.ProjectileType = projectileCommDesc.ProjectileType;
		BGUBulletBaseCS bGUBulletBaseCS = GetOwner() as BGUBulletBaseCS;
		if (!bGUBulletBaseCS.IsNullOrDestroyed())
		{
			BGU_ObjActorUtil.CreateSweepCheckShapeAndRot(bGUBulletBaseCS, ProjectileBasicData.CheckShapeType, out var _, out var CurTransform);
			BulletSweepCheckData.PreTransform = CurTransform;
		}
	}

	private void OnBulletDead(EBGUBulletDestroyReason DestroyReason)
	{
		BulletSweepCheckData.EnableSweepCheck = false;
	}
}
