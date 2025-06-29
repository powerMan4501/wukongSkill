using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ObjActorMovementComp : UActorCompBaseCS
{
	protected BUC_ObjActorMovementData MovementData;

	protected BUC_ObjActorCompsData ObjActorComps;

	private b1.IBUC_ProjectileSimpleMoveData ProjectileSimpleMoveData;

	private ProjectileMoveModeBase ActiveMover;

	private StraightMoveMode StraightMover;

	private TraceMoveMode TraceMover;

	private InertialSimulatingMoveMode InertialSimulatingMover;

	private PhysicsMoveMode PhysicsMover;

	private PhysicsSimulatingMoveMode PhysicsSimulatingMover;

	private RealPhysicsMoveMode RealPhysicsMoveMover;

	private CircleSurroundMoveMode CircleSurroundMover;

	private ManualCurveMoveMode ManualCurveMover;

	private ParabolaMoveMode ParabolaMover;

	private SplineMoveMode SplineMover;

	private InnerSplineMoveMode InnerSplineMover;

	private FBMMoveMode FBMMover;

	private FBMMoveMode_BYMJ FBMBYMJMover;

	public override void OnAttach()
	{
		ActiveMover = null;
		MovementData = RequireWritableData<BUC_ObjActorMovementData>();
		ObjActorComps = RequireWritableData<BUC_ObjActorCompsData>();
		ProjectileSimpleMoveData = RequireReadOnlyData<b1.IBUC_ProjectileSimpleMoveData, BUC_ProjectileSimpleMoveData>();
		base.BUSEventCollection.Evt_ObjectActorSetVelocity += new Del_ObjectActorSetVelocity(OnSetVelocity);
		base.BUSEventCollection.Evt_InitObjectMoveInfo += new Del_InitObjectMoveProperty(OnInitObjMoveInfo);
		base.BUSEventCollection.Evt_OnSwitchBulletMove += new Del_OnSwitchBulletMove(OnSwitchBulletMove);
		base.BUSEventCollection.Evt_StopTracing += new Del_Void(OnStopTracing);
		base.BUSEventCollection.Evt_OnBackNestOver += new Del_Void(OnBackNestOver);
		base.BUSEventCollection.Evt_OnTraceEndToStraight += new Del_Void(OnTraceEndToStraight);
		base.BUSEventCollection.Evt_ReActiveProjectileTick += new Del_Void(ReActiveProjectileTick);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnBulletDead);
		base.BUSEventCollection.Evt_OnSetBulletSpdScale += new Del_Void_Float(OnSetBulletSpdScale);
		base.BUSEventCollection.Evt_AttachToTargetWhenTraceOver += new Del_AttachToTargetWhenTraceOver(AttachToTargetWhenTraceOver);
		base.BUSEventCollection.Evt_SwitchMovementTarget += new Del_Void_ActorString(OnSwitchMovementTarget);
		base.BUSEventCollection.Evt_SetInertialState += new Del_Void_Int(OnSetInertialState);
		base.BUSEventCollection.Evt_SetObjMoveMode += new Del_ObjMoveMode(OnSetMoveMode);
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		MovementData.OnUseSimpleMoveChg += OnUseSimpleMoveChg;
	}

	public override void OnNetDeActive()
	{
		base.OnNetActive();
		MovementData.OnUseSimpleMoveChg -= OnUseSimpleMoveChg;
	}

	public void OnUseSimpleMoveChg(bool OldValue, bool Newvalue)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (Newvalue)
		{
			bGUProjectileBaseActor.GetProjectileMovement().SetActive(bNewActive: false);
		}
		else
		{
			bGUProjectileBaseActor.GetProjectileMovement().SetActive(bNewActive: true);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (ActiveMover != null)
		{
			ActiveMover.OnUpdate(DeltaTime);
			UpdateVelocityData();
			BulletSweepFlySpdTick(DeltaTime);
			if (MovementData.MoveClampToLand || MovementData.MoveAlignToLand)
			{
				BGUFunctionLibraryCS.ClampAndAlignToLandScape(Owner, MovementData.MoveClampToLand, MovementData.MoveAlignToLand, DeltaTime, 5f);
			}
		}
	}

	protected void SwitchMoverIfNeeded(ProjectileMoveModeBase NewMover)
	{
		if (ActiveMover != NewMover)
		{
			Reset();
		}
		ActiveMover = NewMover;
		MovementData.MoveMode = ActiveMover.GetMoveMode();
	}

	private void OnSetVelocity(FVector Velocity)
	{
		if (MovementData.UseSimpleMove)
		{
			base.BUSEventCollection.Evt_ProjectilePendingVelocity.Invoke(Velocity);
		}
		else
		{
			ObjActorComps.OwnerMovement.Velocity = Velocity;
		}
	}

	private void UpdateVelocityData()
	{
		AActor aActor = BGUFuncLibActorTransformCS.BGUGetAttachParentActor(Owner);
		if (aActor != null)
		{
			MovementData.CurVelocity = BGUFuncLibActorTransformCS.BGUGetVelocity(aActor);
		}
		else if (MovementData.UseSimpleMove)
		{
			MovementData.CurVelocity = ProjectileSimpleMoveData.Velocity;
		}
		else
		{
			MovementData.CurVelocity = BGUFuncLibActorTransformCS.BGUGetVelocity(Owner);
		}
	}

	private void OnSetInertialState(int State)
	{
		MovementData.InertialState = (EInertialState)State;
		if (State == 2)
		{
			MovementData.InertialDecreaseTime = MovementData.OriginalInertialDecreaseTime;
		}
		if (State == 3)
		{
			MovementData.InertialAdjustTransTime = MovementData.OriginalInertialAdjustTransTime;
		}
		switch (State)
		{
		case 4:
			OnSetVelocity(FVector.ZeroVector * 0.0);
			break;
		case 1:
			OnInertialProjectileResetTime();
			MovementData.InertialTraceTime = MovementData.OriginalInertialTraceTime;
			ActiveMover.BeginMove();
			break;
		}
	}

	private void OnInertialProjectileResetTime()
	{
		MovementData.ProjectileFlySpdCurveTimer = 0f;
		MovementData.ProjectileRotSpdCurveTimer = 0f;
		MovementData.FlyTime = MovementData.OriginalFlyTime;
	}

	private void OnSetMoveMode(EBulletOrMagicFieldMoveModeType MoveMode)
	{
		MovementData.MoveMode = MoveMode;
		switch (MoveMode)
		{
		case EBulletOrMagicFieldMoveModeType.StraightMode:
			Update_UseSimpleMoveComp();
			if (StraightMover == null)
			{
				StraightMover = CreateMoveMode<StraightMoveMode>(this);
			}
			SwitchMoverIfNeeded(StraightMover);
			break;
		case EBulletOrMagicFieldMoveModeType.TraceMode:
			Update_UseSimpleMoveComp();
			if (TraceMover == null)
			{
				TraceMover = CreateMoveMode<TraceMoveMode>(this);
			}
			SwitchMoverIfNeeded(TraceMover);
			break;
		case EBulletOrMagicFieldMoveModeType.PhysicsMode:
			Update_UseSimpleMoveComp();
			if (PhysicsMover == null)
			{
				PhysicsMover = CreateMoveMode<PhysicsMoveMode>(this);
			}
			SwitchMoverIfNeeded(PhysicsMover);
			break;
		case EBulletOrMagicFieldMoveModeType.PhysicsSimulatingMode:
			Update_UseSimpleMoveComp(bUseSimpleMove: false);
			if (PhysicsSimulatingMover == null)
			{
				PhysicsSimulatingMover = CreateMoveMode<PhysicsSimulatingMoveMode>(this);
			}
			SwitchMoverIfNeeded(PhysicsSimulatingMover);
			break;
		case EBulletOrMagicFieldMoveModeType.RealPhysicsMode:
			Update_UseSimpleMoveComp(bUseSimpleMove: false);
			if (RealPhysicsMoveMover == null)
			{
				RealPhysicsMoveMover = CreateMoveMode<RealPhysicsMoveMode>(this);
			}
			SwitchMoverIfNeeded(RealPhysicsMoveMover);
			break;
		case EBulletOrMagicFieldMoveModeType.CircleSurroundMoveMode:
			Update_UseSimpleMoveComp();
			if (CircleSurroundMover == null)
			{
				CircleSurroundMover = CreateMoveMode<CircleSurroundMoveMode>(this);
			}
			SwitchMoverIfNeeded(CircleSurroundMover);
			break;
		case EBulletOrMagicFieldMoveModeType.ManualCurveMoveMode:
			Update_UseSimpleMoveComp();
			if (ManualCurveMover == null)
			{
				ManualCurveMover = CreateMoveMode<ManualCurveMoveMode>(this);
			}
			SwitchMoverIfNeeded(ManualCurveMover);
			break;
		case EBulletOrMagicFieldMoveModeType.ParabolaMoveMode:
			Update_UseSimpleMoveComp();
			if (ParabolaMover == null)
			{
				ParabolaMover = CreateMoveMode<ParabolaMoveMode>(this);
			}
			SwitchMoverIfNeeded(ParabolaMover);
			break;
		case EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode:
			Update_UseSimpleMoveComp();
			if (InertialSimulatingMover == null)
			{
				InertialSimulatingMover = CreateMoveMode<InertialSimulatingMoveMode>(this);
			}
			SwitchMoverIfNeeded(InertialSimulatingMover);
			break;
		case EBulletOrMagicFieldMoveModeType.SplineMoveMode:
			Update_UseSimpleMoveComp();
			if (SplineMover == null)
			{
				SplineMover = CreateMoveMode<SplineMoveMode>(this);
			}
			SwitchMoverIfNeeded(SplineMover);
			break;
		case EBulletOrMagicFieldMoveModeType.InnerSplineMoveMode:
			Update_UseSimpleMoveComp();
			if (InnerSplineMover == null)
			{
				InnerSplineMover = CreateMoveMode<InnerSplineMoveMode>(this);
			}
			SwitchMoverIfNeeded(InnerSplineMover);
			break;
		case EBulletOrMagicFieldMoveModeType.FbmMoveMode:
			Update_UseSimpleMoveComp();
			if (FBMMover == null)
			{
				FBMMover = CreateMoveMode<FBMMoveMode>(this);
			}
			SwitchMoverIfNeeded(FBMMover);
			break;
		case EBulletOrMagicFieldMoveModeType.FbmBymjMoveMode:
			Update_UseSimpleMoveComp();
			if (FBMBYMJMover == null)
			{
				FBMBYMJMover = CreateMoveMode<FBMMoveMode_BYMJ>(this);
			}
			SwitchMoverIfNeeded(FBMBYMJMover);
			break;
		}
		if (ActiveMover != null)
		{
			ActiveMover.BeginMove();
		}
	}

	private void Update_UseSimpleMoveComp(bool bUseSimpleMove = true)
	{
		if (MovementData.bForceUseProjectileMovementComp)
		{
			bUseSimpleMove = false;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		MovementData.UseSimpleMove = bUseSimpleMove;
		if (!MovementData.UseSimpleMove)
		{
			bGUProjectileBaseActor.GetProjectileMovement().SetActive(bNewActive: true);
		}
		else
		{
			bGUProjectileBaseActor.GetProjectileMovement().SetActive(bNewActive: false);
		}
	}

	private void OnBeginMove(EBulletOrMagicFieldMoveModeType BulletOrMagicFieldMoveModeType)
	{
		OnSetMoveMode(BulletOrMagicFieldMoveModeType);
	}

	private void OnBackNestOver()
	{
		if (MovementData.TraceType != EBGUBulletTraceType.BackNest)
		{
			return;
		}
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill)
		{
			return;
		}
		BUC_ProjectileBasicData bUC_ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(owner);
		BGUCharacterCS bGUCharacterCS = readOnlyData.GetMasterActor() as BGUCharacterCS;
		if (bGUCharacterCS == null || bUC_ProjectileBasicData == null || readOnlyData == null)
		{
			return;
		}
		if (bUC_ProjectileBasicData.ProjectileType == EBGUBulletType.NormalSpawn)
		{
			FName nestName = MovementData.NestName;
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection == null)
			{
				return;
			}
			bUS_GSEventCollection.Evt_SwitchProjectileStatus.Invoke(EBGUProjectileStatus.InNest, -1f);
			OnSetVelocity(FVector.ZeroVector);
			USceneComponent SocketOwnerComp;
			FVector location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, bGUCharacterCS, nestName, out SocketOwnerComp).GetLocation();
			BGUFuncLibActorTransformCS.BGUSetActorLocation(owner, location, bSweep: false, bTeleport: false);
			BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, FRotator.ZeroRotator, bTeleportPhysics: false);
			BGUFuncLibActorTransformCS.BGUAttachToComp(owner, SocketOwnerComp, nestName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: true);
		}
		else if (bUC_ProjectileBasicData.ProjectileType == EBGUBulletType.Weapon)
		{
			FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(bUC_ProjectileBasicData.ProjectileID, bGUCharacterCS);
			BGUWeaponBase bGUWeaponBase = null;
			int num = 0;
			num = (int)projectileCommDesc.ProjectileTypeParam;
			owner.GetAttachedActors(out var OutActors);
			foreach (AActor item in OutActors)
			{
				BGUWeaponBase bGUWeaponBase2 = item as BGUWeaponBase;
				if (bGUWeaponBase2 != null)
				{
					bGUWeaponBase = bGUWeaponBase2;
					break;
				}
			}
			if (bGUWeaponBase != null)
			{
				BGUFunctionLibraryCS.BGUAttachWeapon(bGUCharacterCS, bGUWeaponBase, num);
				BUS_EventCollectionCS.Get(bGUWeaponBase)?.Evt_PlayOrStopAnimation.Invoke(IsPlay: false);
			}
			BUS_EventCollectionCS.Get(owner).Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.FlyBackDestroy);
		}
		else if (bUC_ProjectileBasicData.ProjectileType == EBGUBulletType.WeaponSceneItem)
		{
			BUC_SceneItemData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(bGUCharacterCS);
			FUStProjectileCommDesc projectileCommDesc2 = BGW_GameDB.GetProjectileCommDesc(bUC_ProjectileBasicData.ProjectileID, bGUCharacterCS);
			BGUWeaponBase bGUWeaponBase3 = null;
			int num2 = 0;
			num2 = (int)projectileCommDesc2.ProjectileTypeParam;
			owner.GetAttachedActors(out var OutActors2);
			foreach (AActor item2 in OutActors2)
			{
				BGUWeaponBase bGUWeaponBase4 = item2 as BGUWeaponBase;
				if (bGUWeaponBase4 != null)
				{
					bGUWeaponBase3 = bGUWeaponBase4;
					break;
				}
			}
			if (bGUWeaponBase3 != null)
			{
				BGUFunctionLibraryCS.BGUAttachWeapon(bGUCharacterCS, bGUWeaponBase3, num2);
				BUS_EventCollectionCS.Get(bGUWeaponBase3)?.Evt_PlayOrStopAnimation.Invoke(IsPlay: false);
			}
			base.BUSEventCollection.Evt_OnWeaponSceneItemBeAttached.Invoke(readOnlyData2.SceneItemCatch);
			base.BUSEventCollection.Evt_RemoveCatchedSceneItemAndReset.Invoke();
			BUS_EventCollectionCS.Get(owner).Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.FlyBackDestroy);
		}
		MovementData.TraceType = EBGUBulletTraceType.None;
	}

	private bool AttachToTargetWhenTraceOver()
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null || bGUProjectileBaseActor.IsPendingKill)
		{
			return false;
		}
		if (MovementData.TraceType == EBGUBulletTraceType.None)
		{
			return false;
		}
		if (!MovementData.AttachToTargetWhenTraceOver)
		{
			return false;
		}
		if (string.IsNullOrEmpty(MovementData.TargetSocketName))
		{
			BGUFuncLibActorTransformCS.BGUAttachToActor(bGUProjectileBaseActor, MovementData.TargetActor, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld);
		}
		else
		{
			BGUCharacterCS bGUCharacterCS = MovementData.TargetActor as BGUCharacterCS;
			FName socketName = new FName(MovementData.TargetSocketName);
			if (bGUCharacterCS != null)
			{
				_ = bGUCharacterCS.Mesh;
				BGU_ObjActorUtil.GetSocketOrCompTransform(MovementData.bUseSocket_Target, bGUCharacterCS, socketName, out var SocketOwnerComp);
				BGUFuncLibActorTransformCS.BGUAttachToComp(bGUProjectileBaseActor, SocketOwnerComp, socketName, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: true);
			}
			else
			{
				BGUFuncLibActorTransformCS.BGUAttachToActor(bGUProjectileBaseActor, MovementData.TargetActor, socketName, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld);
			}
		}
		return true;
	}

	private void OnInitObjMoveInfo(GSObjActorMoveInfo MoveInfo)
	{
		OnSetObjMoveInfoFromProjectileDesc(MoveInfo.ProjectileCommID);
		MovementData.TotalNumInAWave = MoveInfo.TotalNumInAWave;
		MovementData.SelfIndexInAWave = MoveInfo.SelfIndexInAWave;
		MovementData.BulletFlySpd = MoveInfo.ProjectileFlySpd;
		MovementData.BulletRotSpd = MoveInfo.ProjectileRotSpd;
		MovementData.TargetOffsetInfo = MoveInfo.TargetOffsetInfo;
		MovementData.TargetActor = MoveInfo.TargetActor;
		MovementData.bUseSocket_Target = MoveInfo.bUseSocket_Target;
		MovementData.TargetSocketName = MoveInfo.TargetActorSocketNameFromNotify;
		MovementData.NestName = MoveInfo.NestName;
		MovementData.StartLocation = MoveInfo.StartLocation;
		MovementData.TargetPosAtSpawn = MoveInfo.TargetPosAtSpawn;
		MovementData.TargetPos = MoveInfo.TargetPos;
		if ((MovementData.SpeedType == EProjectileObjSpdType.CurveByTime || MovementData.SpeedType == EProjectileObjSpdType.Normal) && MoveInfo.ProjectileFlySpd.SpdCurve != null)
		{
			MovementData.ProjectileFlySpdCurveTimer = 0f;
		}
		else
		{
			MovementData.ProjectileFlySpdCurveTimer = -1f;
		}
		if (MovementData.TraceType != EBGUBulletTraceType.None && MoveInfo.ProjectileRotSpd.SpdCurve != null)
		{
			MovementData.ProjectileRotSpdCurveTimer = 0f;
		}
		else
		{
			MovementData.ProjectileRotSpdCurveTimer = -1f;
		}
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(MoveInfo.ProjectileCommID);
		OnBeginMove(projectileMoveDesc.ProjectileMoveModeType);
	}

	private void OnSetObjMoveInfoFromProjectileDesc(int ProjectileCommID)
	{
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(ProjectileCommID);
		if (projectileMoveDesc == null)
		{
			return;
		}
		MovementData.SpeedType = projectileMoveDesc.ProjectileSpdType;
		MovementData.FlyTime = projectileMoveDesc.ProjectileFlyTime;
		MovementData.OriginalFlyTime = projectileMoveDesc.ProjectileFlyTime;
		if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.TraceMode || projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode)
		{
			MovementData.TraceType = (EBGUBulletTraceType)projectileMoveDesc.ProjectileMoveModeIntParam[0];
			if (projectileMoveDesc.ProjectileMoveModeIntParam.Count >= 2)
			{
				MovementData.InertialTraceRadius = projectileMoveDesc.ProjectileMoveModeIntParam[1];
			}
			MovementData.TraceTime = projectileMoveDesc.ProjectileMoveModeFloatParam[0];
			if (projectileMoveDesc.ProjectileMoveModeFloatParam.Count >= 2)
			{
				MovementData.InertialTraceTime = projectileMoveDesc.ProjectileMoveModeFloatParam[1];
				MovementData.OriginalInertialTraceTime = projectileMoveDesc.ProjectileMoveModeFloatParam[1];
			}
			if (projectileMoveDesc.ProjectileMoveModeFloatParam.Count >= 3)
			{
				MovementData.InertialDecreaseTime = projectileMoveDesc.ProjectileMoveModeFloatParam[2];
				MovementData.OriginalInertialDecreaseTime = projectileMoveDesc.ProjectileMoveModeFloatParam[2];
			}
			if (projectileMoveDesc.ProjectileMoveModeFloatParam.Count >= 4)
			{
				MovementData.InertialAdjustTransTime = projectileMoveDesc.ProjectileMoveModeFloatParam[3];
				MovementData.OriginalInertialAdjustTransTime = projectileMoveDesc.ProjectileMoveModeFloatParam[3];
			}
			if (projectileMoveDesc.ProjectileMoveModeStrParam.Count >= 2)
			{
				MovementData.InertialTraceSpdCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(projectileMoveDesc.ProjectileMoveModeStrParam[1], ELoadResourceType.SyncLoadAndCache);
			}
			MovementData.CloseZTrace = false;
			MovementData.TargetSocketName = null;
			if (projectileMoveDesc.ProjectileMoveModeYoNParam.Count > 1)
			{
				MovementData.TraceOverTriggerLifeOverEffect = projectileMoveDesc.ProjectileMoveModeYoNParam[1] == EGSYesNo.Yes;
			}
			else
			{
				MovementData.TraceOverTriggerLifeOverEffect = false;
			}
			if (projectileMoveDesc.ProjectileMoveModeYoNParam.Count > 3)
			{
				MovementData.TraceOverSwitchToStraightMode = projectileMoveDesc.ProjectileMoveModeYoNParam[3] == EGSYesNo.Yes;
			}
			else
			{
				MovementData.TraceOverSwitchToStraightMode = false;
			}
			if (MovementData.TraceType == EBGUBulletTraceType.BackNest)
			{
				MovementData.UseSocketAsNest = projectileMoveDesc.ProjectileMoveModeYoNParam[0] == EGSYesNo.Yes;
				MovementData.TraceTime = -1f;
			}
			else if (MovementData.TraceType == EBGUBulletTraceType.ToActor || MovementData.TraceType == EBGUBulletTraceType.InertialSimulating)
			{
				MovementData.CloseZTrace = projectileMoveDesc.ProjectileMoveModeYoNParam[0] == EGSYesNo.Yes;
				if (projectileMoveDesc.ProjectileMoveModeStrParam.Count > 0)
				{
					string text = projectileMoveDesc.ProjectileMoveModeStrParam[0];
					if (!string.IsNullOrEmpty(text))
					{
						MovementData.TargetSocketName = text;
						MovementData.bUseSocket_Target = true;
					}
				}
				if (projectileMoveDesc.ProjectileMoveModeYoNParam.Count > 2)
				{
					MovementData.AttachToTargetWhenTraceOver = projectileMoveDesc.ProjectileMoveModeYoNParam[1] == EGSYesNo.Yes;
				}
				else
				{
					MovementData.AttachToTargetWhenTraceOver = false;
				}
			}
		}
		else if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.CircleSurroundMoveMode)
		{
			if (projectileMoveDesc.ProjectileMoveModeIntParam.Count < 4)
			{
				return;
			}
			MovementData.CenterType = (ECircleSurround_CenterType)projectileMoveDesc.ProjectileMoveModeIntParam[0];
			MovementData.RadiusType = (ECircleSurround_RadiusType)projectileMoveDesc.ProjectileMoveModeIntParam[1];
			MovementData.SpdType = (ECircleSurround_SpdType)projectileMoveDesc.ProjectileMoveModeIntParam[2];
			MovementData.RotType = (ECircleSurround_RotType)projectileMoveDesc.ProjectileMoveModeIntParam[3];
			string text2 = ((projectileMoveDesc.ProjectileMoveModeStrParam.Count > 0) ? projectileMoveDesc.ProjectileMoveModeStrParam[0] : "");
			if (!string.IsNullOrEmpty(text2))
			{
				MovementData.RadiusCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(text2, ELoadResourceType.SyncLoadAndCache);
				MovementData.RadiusSurCurveTimer = 0f;
			}
			else
			{
				MovementData.StaticRadius = ((projectileMoveDesc.ProjectileMoveModeFloatParam.Count > 0) ? projectileMoveDesc.ProjectileMoveModeFloatParam[0] : 0f);
			}
			string text3 = ((projectileMoveDesc.ProjectileMoveModeStrParam.Count > 1) ? projectileMoveDesc.ProjectileMoveModeStrParam[1] : "");
			if (!string.IsNullOrEmpty(text3))
			{
				MovementData.SelfRotCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(text3, ELoadResourceType.SyncLoadAndCache);
			}
			MovementData.CircleHeightOffset = ((projectileMoveDesc.ProjectileMoveModeFloatParam.Count > 1) ? projectileMoveDesc.ProjectileMoveModeFloatParam[1] : 0f);
		}
		else if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.ManualCurveMoveMode)
		{
			string path = projectileMoveDesc.ProjectileMoveModeStrParam[0];
			MovementData.ManualMoveCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveVector>(path, ELoadResourceType.SyncLoadAndCache);
			MovementData.TargetVector = default(FVector);
			MovementData.BulletOriPos = default(FVector);
			MovementData.ManualMoveCurveTimer = 0f;
			MovementData.MaxCurveLen = 0f;
			MovementData.CurDis = 0f;
			MovementData.OriDis = 0f;
			MovementData.LastBulletPos = default(FVector);
			MovementData.IsFaceTarget = projectileMoveDesc.ProjectileMoveModeYoNParam[0] == EGSYesNo.Yes;
			if (projectileMoveDesc.ProjectileMoveModeIntParam.Count == 0 || projectileMoveDesc.ProjectileMoveModeIntParam[0] == 0)
			{
				MovementData.ByTimeOrDis = true;
			}
			else
			{
				MovementData.ByTimeOrDis = false;
				MovementData.MaxCurveLen = projectileMoveDesc.ProjectileMoveModeFloatParam[0];
				MovementData.DefaultOriDis = projectileMoveDesc.ProjectileMoveModeFloatParam[1];
			}
		}
		else if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.ParabolaMoveMode)
		{
			MovementData.Top_X = projectileMoveDesc.ProjectileMoveModeFloatParam[0];
			MovementData.Top_Y = projectileMoveDesc.ProjectileMoveModeFloatParam[1];
			MovementData.TargetShortestDist_Hor = ((projectileMoveDesc.ProjectileMoveModeFloatParam.Count > 2) ? projectileMoveDesc.ProjectileMoveModeFloatParam[2] : (-1f));
			MovementData.TargetFurthestDist_Hor = ((projectileMoveDesc.ProjectileMoveModeFloatParam.Count > 3) ? projectileMoveDesc.ProjectileMoveModeFloatParam[3] : (-1f));
		}
		else if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.SplineMoveMode)
		{
			string name = projectileMoveDesc.ProjectileMoveModeStrParam[0];
			UGameplayStatics.GetAllActorsOfClassWithTag(Owner, UClass.GetClass<BGUSplineActor>(), new FName(name), out var OutActors);
			if (OutActors.Count > 0)
			{
				BGUSplineActor bGUSplineActor = OutActors[0] as BGUSplineActor;
				MovementData.SplineCompPtr = new TWeakObject<USplineComponent>((bGUSplineActor != null) ? bGUSplineActor.SplineComp : null);
			}
			MovementData.TriggerLifeOver_SplineMoveEnd = true;
			MovementData.RotAlignToSpline = ((projectileMoveDesc.ProjectileMoveModeYoNParam.Count > 1 && projectileMoveDesc.ProjectileMoveModeYoNParam[1] == EGSYesNo.Yes) ? true : false);
		}
		else if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.InnerSplineMoveMode)
		{
			USplineComponent uSplineComponent = Owner.GetComponentByClass(UClass.GetClass<USplineComponent>()) as USplineComponent;
			if (uSplineComponent != null)
			{
				uSplineComponent.DetachFromParent(bMaintainWorldPosition: true);
				MovementData.SplineCompPtr = new TWeakObject<USplineComponent>(uSplineComponent);
			}
			MovementData.RotAlignToSpline = ((projectileMoveDesc.ProjectileMoveModeYoNParam.Count > 0 && projectileMoveDesc.ProjectileMoveModeYoNParam[0] == EGSYesNo.Yes) ? true : false);
			MovementData.TriggerLifeOver_SplineMoveEnd = ((projectileMoveDesc.ProjectileMoveModeYoNParam.Count > 1 && projectileMoveDesc.ProjectileMoveModeYoNParam[1] == EGSYesNo.Yes) ? true : false);
		}
		else if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.FbmMoveMode)
		{
			MovementData.MoveConstraintType_FBM = (FBM_MoveConstraintType)projectileMoveDesc.ProjectileMoveModeIntParam[0];
			MovementData.FractalLevel_FBM = projectileMoveDesc.ProjectileMoveModeIntParam[1];
			MovementData.MotionRadius_FBM = projectileMoveDesc.ProjectileMoveModeFloatParam[0];
			MovementData.SpdScale_FBM = projectileMoveDesc.ProjectileMoveModeFloatParam[1];
		}
		else if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.FbmBymjMoveMode)
		{
			MovementData.SpdType = (ECircleSurround_SpdType)projectileMoveDesc.ProjectileMoveModeIntParam[0];
			MovementData.RotType = (ECircleSurround_RotType)projectileMoveDesc.ProjectileMoveModeIntParam[1];
			MovementData.MoveConstraintType_FBM = (FBM_MoveConstraintType)projectileMoveDesc.ProjectileMoveModeIntParam[2];
			MovementData.FractalLevel_FBM = projectileMoveDesc.ProjectileMoveModeIntParam[3];
			MovementData.CircleHeightOffset = ((projectileMoveDesc.ProjectileMoveModeFloatParam.Count > 1) ? projectileMoveDesc.ProjectileMoveModeFloatParam[0] : 0f);
			MovementData.MotionRadius_FBM = projectileMoveDesc.ProjectileMoveModeFloatParam[1];
			MovementData.SpdScale_FBM = projectileMoveDesc.ProjectileMoveModeFloatParam[2];
		}
		MovementData.MoveClampToLand = projectileMoveDesc.MoveClampToLand == EGSYesNo.Yes;
		MovementData.MoveAlignToLand = projectileMoveDesc.MoveAlignToLand == EGSYesNo.Yes;
	}

	private void OnSwitchMovementTarget(AActor NewTarget, string SocketName = "")
	{
		MovementData.TargetActor = NewTarget;
		MovementData.TargetSocketName = SocketName;
		MovementData.bUseSocket_Target = true;
	}

	private void OnSwitchBulletMove(FGSwitchBulletMovableInfo MovableInfo, AActor Caster)
	{
		FUStBulletSwitchDesc bulletSwitchDesc = BGW_GameDB.GetBulletSwitchDesc(MovableInfo.BulletSwitchID);
		if (bulletSwitchDesc == null)
		{
			return;
		}
		if (ActiveMover != null)
		{
			ActiveMover.BeforeSwitch();
		}
		OnSetObjMoveInfoFromProjectileDesc(bulletSwitchDesc.BulletID);
		if (bulletSwitchDesc.ResetMoveProperty == EGSYesNo.Yes)
		{
			FSpawnBulletSpeed bulletFlySpd = default(FSpawnBulletSpeed);
			if (bulletSwitchDesc.BulletMoveModeFlySpdFloatParam.Count != 0)
			{
				bulletFlySpd.Spd.LeftValue = bulletSwitchDesc.BulletMoveModeFlySpdFloatParam[0];
				bulletFlySpd.Spd.RightValue = bulletSwitchDesc.BulletMoveModeFlySpdFloatParam[1];
				bulletFlySpd.AccelerationTime = bulletSwitchDesc.BulletMoveModeFlySpdFloatParam[2];
			}
			if (!string.IsNullOrEmpty(bulletSwitchDesc.BulletMoveModeFlySpdCurvePath))
			{
				bulletFlySpd.SpdCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(bulletSwitchDesc.BulletMoveModeFlySpdCurvePath, ELoadResourceType.SyncLoadAndCache);
			}
			if ((MovementData.SpeedType == EProjectileObjSpdType.CurveByTime || MovementData.SpeedType == EProjectileObjSpdType.Normal) && bulletFlySpd.SpdCurve != null)
			{
				MovementData.ProjectileFlySpdCurveTimer = 0f;
			}
			else
			{
				MovementData.ProjectileFlySpdCurveTimer = -1f;
			}
			FSpawnBulletSpeed bulletRotSpd = default(FSpawnBulletSpeed);
			if (bulletSwitchDesc.BulletMoveModeRotSpdFloatParam.Count != 0)
			{
				bulletRotSpd.Spd.LeftValue = bulletSwitchDesc.BulletMoveModeRotSpdFloatParam[0];
				bulletRotSpd.Spd.RightValue = bulletSwitchDesc.BulletMoveModeRotSpdFloatParam[1];
				bulletRotSpd.AccelerationTime = bulletSwitchDesc.BulletMoveModeRotSpdFloatParam[2];
			}
			if (!string.IsNullOrEmpty(bulletSwitchDesc.BulletMoveModeRotSpdCurvePath))
			{
				bulletRotSpd.SpdCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(bulletSwitchDesc.BulletMoveModeRotSpdCurvePath, ELoadResourceType.SyncLoadAndCache);
			}
			if (bulletRotSpd.SpdCurve != null)
			{
				MovementData.ProjectileRotSpdCurveTimer = 0f;
			}
			else
			{
				MovementData.ProjectileRotSpdCurveTimer = -1f;
			}
			MovementData.BulletFlySpd = bulletFlySpd;
			MovementData.BulletRotSpd = bulletRotSpd;
		}
		MovementData.TargetOffsetInfo = ((MovableInfo.TargetOffsetInfo != null) ? MovableInfo.TargetOffsetInfo : new FGSTargetOffsetInfo());
		MovementData.TargetPos = MovableInfo.TargetPos;
		MovementData.TargetActor = MovableInfo.TargetActor;
		if (bulletSwitchDesc.ResetDirectionType != EProjectileResetDirType.None)
		{
			FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			switch (bulletSwitchDesc.ResetDirectionType)
			{
			case EProjectileResetDirType.LookAtTarget:
				newRotation = UMathLibrary.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), MovementData.TargetPos);
				break;
			case EProjectileResetDirType.WorldSpace:
				newRotation = new FRotator(bulletSwitchDesc.NewDirPitch, bulletSwitchDesc.NewDirYaw, bulletSwitchDesc.NewDirRoll);
				break;
			case EProjectileResetDirType.CasterLocalSpace:
				if (Caster != null)
				{
					FTransform t = BGUFuncLibActorTransformCS.BGUGetActorTransform(Caster);
					FRotator rotation = new FRotator(bulletSwitchDesc.NewDirPitch, bulletSwitchDesc.NewDirYaw, bulletSwitchDesc.NewDirRoll);
					newRotation = t.TransformRotation(rotation);
				}
				break;
			case EProjectileResetDirType.CasterControllerLocalSpace:
			{
				ACharacter aCharacter = Caster as ACharacter;
				if (aCharacter != null)
				{
					FTransform t2 = BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter.GetController());
					FRotator rotation2 = new FRotator(bulletSwitchDesc.NewDirPitch, bulletSwitchDesc.NewDirYaw, bulletSwitchDesc.NewDirRoll);
					newRotation = t2.TransformRotation(rotation2);
				}
				break;
			}
			case EProjectileResetDirType.Fpstype:
			{
				APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(Caster);
				FVector forwardVector = localPlayerCameraManager.GetCameraRotation().GetForwardVector();
				FVector cameraLocation = localPlayerCameraManager.GetCameraLocation();
				FVector fVector = cameraLocation + forwardVector * 10000.0;
				newRotation = UMathLibrary.FindLookAtRotation(Target: (UBGUSelectUtil.LineTraceSimple(Caster, cameraLocation, fVector, ETraceTypeQuery.TraceTypeQuery7, bDebug: false, out var HitResult, null) != 1) ? fVector : HitResult.HitLocation, Start: BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()));
				break;
			}
			}
			BGUFuncLibActorTransformCS.BGUSetActorRotation(Owner, newRotation, bTeleportPhysics: true, bImmediateUpdate: true);
		}
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(bulletSwitchDesc.BulletID);
		if (projectileMoveDesc.ProjectileMoveModeType == EBulletOrMagicFieldMoveModeType.TraceMode && MovementData.TraceType == EBGUBulletTraceType.BackNest)
		{
			MovementData.NestName = MovableInfo.NestName;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = Owner as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor.GetAttachParentActorCached() != null)
		{
			BGUFuncLibActorTransformCS.BGUDetachFromActor(bGUProjectileBaseActor, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}
		OnBeginMove(projectileMoveDesc.ProjectileMoveModeType);
	}

	public void Reset()
	{
		if (ActiveMover != null)
		{
			ActiveMover.OnEnd();
			MovementData.MoveMode = EBulletOrMagicFieldMoveModeType.None;
			ActiveMover.bIsActive = false;
			ActiveMover = null;
		}
	}

	public void StopMove()
	{
		if (ActiveMover != null)
		{
			ActiveMover.OnEnd();
			MovementData.MoveMode = EBulletOrMagicFieldMoveModeType.None;
			ActiveMover = null;
		}
	}

	public UProjectileMovementComponent GetOwnerProjectleMovement()
	{
		return ObjActorComps.OwnerMovement;
	}

	private void ReActiveProjectileTick()
	{
		AActor owner = GetOwner();
		if (!(owner == null))
		{
			UStaticMeshComponent componentByClass = owner.GetComponentByClass<UStaticMeshComponent>();
			if (componentByClass != null)
			{
				ObjActorComps.OwnerMovement.SetUpdatedComponent(componentByClass);
			}
		}
	}

	private void BulletSweepFlySpdTick(float DeltaTime)
	{
		if (MovementData.FlyTime > 0f)
		{
			MovementData.FlyTime -= DeltaTime;
		}
		if (MovementData.TraceTime > 0f)
		{
			if (MovementData.ProjectileRotSpdCurveTimer != -1f)
			{
				MovementData.ProjectileRotSpdCurveTimer += DeltaTime;
			}
			MovementData.TraceTime -= DeltaTime;
		}
		if (MovementData.ProjectileFlySpdCurveTimer != -1f)
		{
			MovementData.ProjectileFlySpdCurveTimer += DeltaTime;
		}
		if (MovementData.RadiusSurCurveTimer != -1f)
		{
			MovementData.RadiusSurCurveTimer += DeltaTime;
		}
		if (MovementData.InertialDecreaseTime > 0f)
		{
			MovementData.InertialDecreaseTime -= DeltaTime;
		}
		if (MovementData.InertialAdjustTransTime > 0f)
		{
			MovementData.InertialAdjustTransTime -= DeltaTime;
		}
		if (MovementData.InertialTraceTime > 0f)
		{
			MovementData.InertialTraceTime -= DeltaTime;
		}
	}

	private void OnStopTracing()
	{
		if (RequireWritableData<BUC_ObjActorMovementData>().MoveMode == EBulletOrMagicFieldMoveModeType.TraceMode)
		{
			MovementData.FlyTime = -1f;
		}
	}

	protected MoveMode CreateMoveMode<MoveMode>(BUS_ObjActorMovementComp Parent) where MoveMode : ProjectileMoveModeBase, new()
	{
		MoveMode val = new MoveMode();
		val.Init(Parent, Owner);
		return val;
	}

	private void OnBulletDead(EBGUBulletDestroyReason DestroyReason)
	{
		StopMove();
	}

	private void OnSetBulletSpdScale(float BulletSpdScaleValue)
	{
		MovementData.SpdScaleValue = BulletSpdScaleValue;
	}

	private void OnTraceEndToStraight()
	{
		OnSetMoveMode(EBulletOrMagicFieldMoveModeType.StraightMode);
	}
}
