using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_FootStepCompImpl : UActorCompBaseCS
{
	private struct FFootStepInfoCached
	{
		public EFootStepType FootStepType;

		public float ProtectTime;

		public bool bEnableMontageFootDecal;

		public bool bEnableMontageFootstepAudio;

		public bool bEnableMontageFootsetpFX;

		public FName FootFrontSocketName;

		public bool IsFromNotify;
	}

	private BUC_FootStepData FootStepData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_SpeedCtrlData SpeedCtrlData;

	private IBUC_TickRateData TickRateData;

	private IBUC_MovementData MovementData;

	private IBUC_EnvironmentInteractionMgrData EnvInteractionMgrData;

	private IBUC_ABPHelperData AnimHumanoidHelperData;

	private IBUC_ABPPlayerLocomotionData PlayerLocomotionData;

	private IBUC_ABPCharacterData ChrData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private LinkedList<int> FootstepSettingID;

	private Dictionary<int, b1.FMontageFootstepSetting> MontageFootstepSetting;

	private FName root = B1GlobalFNames.root;

	private FName LeftFootSpeedRefBoneName;

	private FName RightFootSpeedRefBoneName;

	private FName LeftFootLineTraceBoneName;

	private FName RightFootLineTraceBoneName;

	private FName LeftFootFrontSocket;

	private FName RightFootFrontSocket;

	private bool L_FootMoving;

	private bool R_FootMoving;

	private const float SprintProtectTime = 0.3f;

	private const float NormalProtectTime = 0.5f;

	private const float WalkProtectTime = 1f;

	private const float SprintFootSpeedThreshold = 800f;

	private const float NormalFootSpeedThreshold = 500f;

	private const float WalkFootSpeedThreshold = 200f;

	private float L_Protect_Timer;

	private float R_Protect_Timer;

	private FVector L_FootLastPos;

	private FVector R_FootLastPos;

	private Dictionary<int, FFootStepInfoCached> ASyncLineTraceMap_FootStep = new Dictionary<int, FFootStepInfoCached>();

	public override void OnAttach()
	{
		FootStepData = RequireWritableData<BUC_FootStepData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SpeedCtrlData = RequireReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		EnvInteractionMgrData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		AnimHumanoidHelperData = RequireReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>();
		PlayerLocomotionData = RequireReadOnlyData<IBUC_ABPPlayerLocomotionData, BUC_ABPPlayerLocomotionData>();
		ChrData = RequireReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.BUSEventCollection.Evt_FootSlideBegin += new Del_Void_Float(OnFootSlideBegin);
		base.BUSEventCollection.Evt_TriggerFootStep += new Del_TriggerFootStep(OnTriggerFootStep);
		base.BUSEventCollection.Evt_EnableMontageFootstepBegin += new Del_Void_BoolBoolBoolInt(OnEnableMontageFootstepBegin);
		base.BUSEventCollection.Evt_EnableMontageFootstepEnd += new Del_Void_Int(OnEnableMontageFootstepEnd);
		base.BUSEventCollection.Evt_MyriapodsFootStepBegin += new Del_Void(OnMyriapodsFootStepBegin);
		base.BUSEventCollection.Evt_MyriapodsFootStepEnd += new Del_Void(OnMyriapodsFootStepEnd);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Combine(bGWEventCollection.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnCurrentLevelChanged));
	}

	public override void PreBeginPlay()
	{
		FootstepSettingID = new LinkedList<int>();
		MontageFootstepSetting = new Dictionary<int, b1.FMontageFootstepSetting>();
		FootStepData.MyriapodsFootStepEventID = 0;
	}

	public override void OnBeginPlay()
	{
		if (!FootStepData.DecalMaterialPath.Path.Equals(string.Empty))
		{
			BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UMaterial>(FootStepData.DecalMaterialPath.Path, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low, DecalMaterialAsyncLoadFinishCallback);
		}
		if (!FootStepData.StepAudioPath.Path.Equals(string.Empty))
		{
			BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UAkAudioEvent>(FootStepData.StepAudioPath.Path, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low, StepAudioAsyncLoadFinishCallback);
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(GetActorResID());
		if (unitCommDesc != null)
		{
			LeftFootSpeedRefBoneName = new FName(unitCommDesc.LeftFootSpeedRefBone);
			RightFootSpeedRefBoneName = new FName(unitCommDesc.RightFootSpeedRefBone);
			LeftFootLineTraceBoneName = new FName(unitCommDesc.LeftFootBone);
			RightFootLineTraceBoneName = new FName(unitCommDesc.RightFootBone);
			LeftFootFrontSocket = new FName(unitCommDesc.LeftFootFrontSocket);
			RightFootFrontSocket = new FName(unitCommDesc.RightFootFrontSocket);
		}
		FootStepData.CurLevelID = BGUFuncLibMap.GetCurLevelId(Owner);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickMyriapodsFootStep();
		if ((FootStepData.DrawDebugLine || FootStepData.bShowFootSpeed || FootStepData.bShowFootHeight || !(FootStepData.DecalMaterial == null) || !(FootStepData.StepAudio == null)) && !(ChrData.Velocity.Size() < 0.1f) && !FootStepData.bMyriapods && (FootStepData.bUseFarStepAudio || TickRateData.CanTickFor6000Distance()))
		{
			FootStepTick(DeltaTime);
		}
	}

	public void OnCurrentLevelChanged(int LevelID)
	{
		FootStepData.CurLevelID = LevelID;
	}

	private void TickMyriapodsFootStep()
	{
		if (FootStepData.bMyriapods)
		{
			bool num = MovementData.GetMoveType() == EBGUMoveMode.AIPathMove;
			if (num && !FootStepData.bMyriapodsMoving)
			{
				FootStepData.bMyriapodsMoving = true;
				OnMyriapodsFootStepBegin();
			}
			if (!num && FootStepData.bMyriapodsMoving)
			{
				FootStepData.bMyriapodsMoving = false;
				OnMyriapodsFootStepEnd();
			}
		}
	}

	private void DecalMaterialAsyncLoadFinishCallback(int ReqID, UObject Obj)
	{
		FootStepData.DecalMaterial = Obj as UMaterial;
	}

	private void StepAudioAsyncLoadFinishCallback(int ReqID, UObject Obj)
	{
		FootStepData.StepAudio = Obj as UAkAudioEvent;
	}

	private void FootStepTick(float DeltaTime)
	{
		FootStepTickByFootSpeed(DeltaTime);
	}

	private void FootStepTickByFootSpeed(float DeltaTime)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || bGUCharacterCS.Mesh == null)
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(bGUCharacterCS));
		if (unitCommDesc == null || unitCommDesc.FootHeightThreshold <= 0f || (unitCommDesc.LeftFootSpeedRefBone.Length == 0 && unitCommDesc.RightFootSpeedRefBone.Length == 0))
		{
			return;
		}
		AnimHumanoidHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.DisableProceduralFootStep, out var OutCurveValue);
		if (OutCurveValue > 0.5f)
		{
			return;
		}
		float num = unitCommDesc.RunFootSpeedThreshold;
		if (UnitStateData.HasState(EBGUUnitState.Sprinting))
		{
			num = unitCommDesc.SprintFootSpeedThreshold;
		}
		else if (UnitStateData.HasState(EBGUUnitState.Walking))
		{
			num = unitCommDesc.WalkFootSpeedThreshold;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly))
		{
			num = unitCommDesc.WalkFootSpeedThreshold;
		}
		float footHeightThreshold = unitCommDesc.FootHeightThreshold;
		float num2 = 0.3f;
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		float z = mesh.GetWorldScale().Z;
		footHeightThreshold *= z;
		FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref LeftFootSpeedRefBoneName);
		if (L_FootLastPos.IsNearlyZero())
		{
			L_FootLastPos = fVector;
		}
		FVector fVector2 = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref RightFootSpeedRefBoneName);
		if (R_FootLastPos.IsNearlyZero())
		{
			R_FootLastPos = fVector2;
		}
		if (L_Protect_Timer > num2)
		{
			L_Protect_Timer = num2;
		}
		if (R_Protect_Timer > num2)
		{
			R_Protect_Timer = num2;
		}
		FVector fVector3 = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref root);
		float num3 = FMath.Abs(fVector.Z - fVector3.Z);
		float num4 = FMath.Abs(fVector2.Z - fVector3.Z);
		float val = ((PlayerLocomotionData.GaitGroundedState != EGaitGroundedState.Run && PlayerLocomotionData.GaitGroundedState != EGaitGroundedState.Rush) ? 0f : (PlayerLocomotionData.FreeAdditiveMovingLeanAlpha * FMath.Max(FMath.Abs(PlayerLocomotionData.FreeAdditiveMovingLeanX), PlayerLocomotionData.FreeAdditiveMovingLeanY)));
		float val2 = FMath.Max(0f, PlayerLocomotionData.SlopeAngle) / 30f;
		float num5 = FMath.Max(val, val2);
		footHeightThreshold *= 1f + num5 * 2f;
		FVector fVector4 = fVector - L_FootLastPos;
		FVector fVector5 = fVector2 - R_FootLastPos;
		float num6 = fVector4.Size() / DeltaTime;
		float num7 = fVector5.Size() / DeltaTime;
		_ = FootStepData.bShowFootSpeed;
		_ = FootStepData.bShowFootHeight;
		if (L_Protect_Timer > 0f)
		{
			L_Protect_Timer -= DeltaTime;
		}
		if (R_Protect_Timer > 0f)
		{
			R_Protect_Timer -= DeltaTime;
		}
		if (L_FootMoving && num6 <= num && num3 <= footHeightThreshold)
		{
			L_FootMoving = false;
			if (L_Protect_Timer <= 0f)
			{
				OnFootStep(EFootStepType.LeftFoot, IsFromNotify: false, num2);
			}
		}
		if (R_FootMoving && num7 <= num && num4 <= footHeightThreshold)
		{
			R_FootMoving = false;
			if (R_Protect_Timer <= 0f)
			{
				OnFootStep(EFootStepType.RightFoot, IsFromNotify: false, num2);
			}
		}
		if (!L_FootMoving && num3 > footHeightThreshold)
		{
			L_FootMoving = true;
		}
		if (!R_FootMoving && num4 > footHeightThreshold)
		{
			R_FootMoving = true;
		}
		L_FootLastPos = fVector;
		R_FootLastPos = fVector2;
	}

	private void TriggerSurfaceBuffEffect(BGUCharacterCS Character, ESceneItemSurfaceType SurfaceType)
	{
		if (!(Character != null) || !(Character.World != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Character);
		if (bUS_GSEventCollection != null)
		{
			switch (SurfaceType)
			{
			}
			_ = bUS_GSEventCollection != null;
		}
	}

	private void OnTriggerFootStep(EFootStepType FootStepType, bool IsFromNotify)
	{
		OnFootStep(FootStepType, IsFromNotify);
	}

	private void OnFootStep(EFootStepType FootStepType, bool IsFromNotify, float ProtectTime = -1f)
	{
		FName SocketName;
		FName footFrontSocketName;
		switch (FootStepType)
		{
		case EFootStepType.LeftFoot:
			SocketName = LeftFootLineTraceBoneName;
			footFrontSocketName = LeftFootFrontSocket;
			break;
		case EFootStepType.RightFoot:
			SocketName = RightFootLineTraceBoneName;
			footFrontSocketName = RightFootFrontSocket;
			break;
		default:
			SocketName = LeftFootLineTraceBoneName;
			footFrontSocketName = LeftFootFrontSocket;
			break;
		}
		if (Owner == null || Owner.IsPendingKill)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || bGUCharacterCS.IsPendingKill)
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		if (mesh == null)
		{
			return;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		if (FootstepSettingID.Count > 0)
		{
			int value = FootstepSettingID.Last.Value;
			flag = MontageFootstepSetting[value].bEnableMontageFootDecal;
			flag2 = MontageFootstepSetting[value].bEnableMontageFootstepAudio;
			flag3 = MontageFootstepSetting[value].bEnableMontageFootstepFX;
		}
		if (IsFromNotify)
		{
			flag = true;
			flag2 = true;
			flag3 = true;
		}
		UAnimInstance animInstance = mesh.GetAnimInstance();
		if (!(animInstance != null) || !animInstance.IsAnyMontagePlaying() || !ChrData.MoveAcceleration.IsNearlyZero() || flag || flag2 || flag3)
		{
			float num = OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight() / 2f;
			FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName);
			BGUFuncLibComponentCS.BGUGetSocketRotation(mesh, ref SocketName);
			FVector fVector2 = fVector;
			FVector fVector3 = fVector2;
			fVector2.Z += num;
			fVector3.Z -= num;
			if (FootStepData.DrawDebugLine)
			{
				USystemLibrary.DrawDebugLine(Owner, fVector2, fVector3, FLinearColor.Red, 3f);
			}
			int num2 = b1.BGS_LineTraceMgr.RequestNewUniqueID_Sync();
			base.BGSEventCollection.Evt_RequestAsyncLineTrace_ByChannelSingle.Invoke(num2, fVector2, fVector3, ECollisionChannel.ECC_GameTraceChannel17, null, bTraceComplex: true, ASyncLineTraceFinish_CallBack, FootStepData.DrawDebugLine);
			FFootStepInfoCached value2 = new FFootStepInfoCached
			{
				FootStepType = FootStepType,
				ProtectTime = ProtectTime,
				bEnableMontageFootDecal = flag,
				bEnableMontageFootstepAudio = flag2,
				bEnableMontageFootsetpFX = flag3,
				FootFrontSocketName = footFrontSocketName,
				IsFromNotify = IsFromNotify
			};
			ASyncLineTraceMap_FootStep.Add(num2, value2);
		}
	}

	private void ASyncLineTraceFinish_CallBack(Result_LineTrace Result)
	{
		if (!ASyncLineTraceMap_FootStep.ContainsKey(Result.ReqID))
		{
			return;
		}
		FFootStepInfoCached fFootStepInfoCached = ASyncLineTraceMap_FootStep[Result.ReqID];
		EFootStepType footStepType = fFootStepInfoCached.FootStepType;
		float protectTime = fFootStepInfoCached.ProtectTime;
		bool bEnableMontageFootDecal = fFootStepInfoCached.bEnableMontageFootDecal;
		bool bEnableMontageFootstepAudio = fFootStepInfoCached.bEnableMontageFootstepAudio;
		bool bEnableMontageFootsetpFX = fFootStepInfoCached.bEnableMontageFootsetpFX;
		FName SocketName = fFootStepInfoCached.FootFrontSocketName;
		bool isFromNotify = fFootStepInfoCached.IsFromNotify;
		ASyncLineTraceMap_FootStep.Remove(Result.ReqID);
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || bGUCharacterCS.IsPendingKill)
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		if (mesh == null)
		{
			return;
		}
		UAnimInstance animInstance = mesh.GetAnimInstance();
		if (!Result.bHasResult())
		{
			return;
		}
		FHitResult fHitResult = Result.HitResults[0];
		UPhysicalMaterial uPhysicalMaterial = fHitResult.PhysMaterial.Get();
		ESceneItemSurfaceType eSceneItemSurfaceType = (ESceneItemSurfaceType)((!(uPhysicalMaterial == null)) ? uPhysicalMaterial.SurfaceType : EPhysicalSurface.SurfaceType_Default);
		FVector fVector = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in fHitResult.ImpactPoint);
		FVector fVector2 = fVector;
		if (EnvInteractionMgrData != null)
		{
			eSceneItemSurfaceType = EnvInteractionMgrData.ResultSurfaceType;
			fVector2 = EnvInteractionMgrData.PhySurfaceHitPoint;
		}
		if (FootStepData.DrawDebugLine)
		{
			USystemLibrary.DrawDebugPoint(Owner, fVector, 10f, FLinearColor.Red, 3f);
		}
		bool flag = true;
		bool flag2 = true;
		bool flag3 = true;
		TriggerSurfaceBuffEffect(bGUCharacterCS, eSceneItemSurfaceType);
		if (animInstance != null && animInstance.IsAnyMontagePlaying() && ChrData.MoveAcceleration.IsNearlyZero())
		{
			flag = bEnableMontageFootDecal;
			flag2 = bEnableMontageFootstepAudio;
			flag3 = bEnableMontageFootsetpFX;
		}
		if (true && FootStepData.CameraShake != null && UnrealGameplayData.GetFirstLocalPlayerController() != null)
		{
			UBUS_UtilComm.PlayCameraShakeByClass(Owner, FootStepData.CameraShake.Value);
		}
		FVector fVector3 = ((!SocketName.Equals(FName.None) && mesh.DoesSocketExist(SocketName)) ? (BGUFuncLibComponentCS.BGUGetSocketLocation(mesh, ref SocketName) - fVector) : Owner.GetActorForwardVector());
		fVector3.Z = 0f;
		FUStUnitFootstepDesc unitFootstepDesc = BGW_GameDB.GetUnitFootstepDesc(BGU_DataUtil.GetActorResID(Owner) * 100 + (int)eSceneItemSurfaceType);
		if (unitFootstepDesc == null)
		{
			unitFootstepDesc = BGW_GameDB.GetUnitFootstepDesc(BGU_DataUtil.GetActorResID(Owner) * 100);
		}
		if (flag3 && unitFootstepDesc != null)
		{
			FTransform spawnTransform = new FTransform(fVector3.Rotation(), fVector);
			string text = "";
			if (eSceneItemSurfaceType == ESceneItemSurfaceType.WaterSurface)
			{
				spawnTransform.Translation.Z = fVector2.Z;
			}
			if (footStepType == EFootStepType.LeftFoot)
			{
				if (UnitStateData.HasState(EBGUUnitState.Sprinting) && unitFootstepDesc.SprintLeftFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.SprintLeftFootFXPath;
				}
				else if (UnitStateData.HasState(EBGUUnitState.Walking) && unitFootstepDesc.WalkLeftFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.WalkLeftFootFXPath;
				}
				else if (unitFootstepDesc.RunLeftFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.RunLeftFootFXPath;
				}
				if (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly) && unitFootstepDesc.WalkLeftFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.WalkLeftFootFXPath;
				}
			}
			if (footStepType == EFootStepType.RightFoot)
			{
				if (UnitStateData.HasState(EBGUUnitState.Sprinting) && unitFootstepDesc.SprintRightFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.SprintRightFootFXPath;
				}
				else if (UnitStateData.HasState(EBGUUnitState.Walking) && unitFootstepDesc.WalkRightFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.WalkRightFootFXPath;
				}
				else if (unitFootstepDesc.RunRightFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.RunRightFootFXPath;
				}
				if (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly) && unitFootstepDesc.WalkRightFootFXPath.Length > 0)
				{
					text = unitFootstepDesc.WalkRightFootFXPath;
				}
			}
			if (text.Length > 0)
			{
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var _, null, NeedSetSpawnTransform: true, spawnTransform);
			}
		}
		if (flag2)
		{
			UAkComponent akComp = GetAkComp();
			if (!akComp.IsNullOrDestroyed())
			{
				string text2 = eSceneItemSurfaceType.ToString();
				text2 = text2.Substring(0, FMath.Clamp(text2.Length - 7, 0, 99));
				akComp.SetSwitch(null, "Surface_Foot", text2);
				akComp.SetSwitch(null, "LevelID", $"Level_{FootStepData.CurLevelID}");
				if (FootStepData.StepAudio != null)
				{
					akComp.PostAkEvent(FootStepData.StepAudio, 0, null, "");
					_ = FootStepData.bPrintStepAudioSwitchState;
				}
				base.BUSEventCollection.Evt_PlayMappedSoundFX.Invoke(EquipPosition.Upwear, FootStepData.MoveActionTypeID, bIsFollow: true, B1GlobalFNames.spine_01);
				if (FootStepData.bMultiSpdForStepAK)
				{
					float num = 0f;
					num = (UnitStateData.HasState(EBGUUnitState.Sprinting) ? SpeedCtrlData.GetMoveSpeedFast() : ((!UnitStateData.HasState(EBGUUnitState.Walking)) ? SpeedCtrlData.GetMoveSpeedNormal() : SpeedCtrlData.GetMoveSpeedSlow()));
					if (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly))
					{
						num = SpeedCtrlData.GetMoveSpeedSlow();
					}
					akComp.SetRTPCValue(null, num, 0, "Player_Mvmt_Speed");
				}
			}
		}
		if (FootStepData.DecalMaterial != null && flag && ((unitFootstepDesc != null && unitFootstepDesc.ShowFootDecal == EGSYesNo.Yes) || isFromNotify))
		{
			float lifeSpan = 1f + FootStepData.FootStepDecalStartFadeOutTime + FootStepData.FootStepDecalFadeOutDuration;
			FTransform t = new FTransform(fVector3.Rotation());
			FVector fVector4 = MathLib.TransformDirection(t, FootStepData.FootStepDecalOffset);
			fVector += fVector4;
			fVector.Z -= FootStepData.FootStepDecalSize.X / 2f;
			UDecalComponent uDecalComponent = UGameplayStatics.SpawnDecalAtLocation(Owner, FootStepData.DecalMaterial, FootStepData.FootStepDecalSize, fVector, new FRotator(-90.0, -0.0, fVector3.Rotation().Yaw - 90f), lifeSpan);
			if (uDecalComponent != null)
			{
				uDecalComponent.SetFadeOut(FootStepData.FootStepDecalStartFadeOutTime, FootStepData.FootStepDecalFadeOutDuration);
			}
		}
		if (flag && unitFootstepDesc != null)
		{
			FTransform spawnTransform2 = new FTransform(fVector3.Rotation(), fVector);
			if (footStepType == EFootStepType.LeftFoot && unitFootstepDesc.LeftFootDecalDBC.Length > 0)
			{
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(unitFootstepDesc.LeftFootDecalDBC, out var _, null, NeedSetSpawnTransform: true, spawnTransform2);
			}
			if (footStepType == EFootStepType.RightFoot && unitFootstepDesc.RightFootDecalDBC.Length > 0)
			{
				base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(unitFootstepDesc.RightFootDecalDBC, out var _, null, NeedSetSpawnTransform: true, spawnTransform2);
			}
		}
		if (protectTime > 0f)
		{
			switch (footStepType)
			{
			case EFootStepType.LeftFoot:
				L_Protect_Timer = protectTime;
				break;
			case EFootStepType.RightFoot:
				R_Protect_Timer = protectTime;
				break;
			}
		}
	}

	private void OnFootSlideBegin(float Duration)
	{
	}

	private void OnEnableMontageFootstepBegin(bool bEnableFootDecal, bool bEnableFootstepAudio, bool bEnableFootstepFX, int InstanceID)
	{
		if (!MontageFootstepSetting.ContainsKey(InstanceID))
		{
			b1.FMontageFootstepSetting value = new b1.FMontageFootstepSetting(bEnableFootDecal, bEnableFootstepAudio, bEnableFootstepFX);
			MontageFootstepSetting.Add(InstanceID, value);
			FootstepSettingID.AddLast(InstanceID);
		}
		else
		{
			b1.FMontageFootstepSetting value2 = new b1.FMontageFootstepSetting(bEnableFootDecal, bEnableFootstepAudio, bEnableFootstepFX);
			MontageFootstepSetting[InstanceID] = value2;
		}
	}

	private void OnEnableMontageFootstepEnd(int InstanceID)
	{
		if (MontageFootstepSetting.ContainsKey(InstanceID))
		{
			MontageFootstepSetting.Remove(InstanceID);
			FootstepSettingID.Remove(InstanceID);
		}
	}

	private void OnMyriapodsFootStepBegin()
	{
		if (FootStepData.StepAudio != null)
		{
			UAkComponent akComp = GetAkComp();
			if (FootStepData.MyriapodsFootStepEventID > 0)
			{
				OnMyriapodsFootStepEnd();
			}
			FootStepData.MyriapodsFootStepEventID = akComp.PostAkEvent(FootStepData.StepAudio, 0, null, "");
		}
	}

	private void OnMyriapodsFootStepEnd()
	{
		UBGUFunctionLibAK.BGUAKStopPlayingID(FootStepData.MyriapodsFootStepEventID, 500, 4);
		FootStepData.MyriapodsFootStepEventID = 0;
	}

	private UAkComponent GetAkComp()
	{
		bool ComponentCreated;
		UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(OwnerAsCharacterCS.Mesh, out ComponentCreated, B1GlobalFNames.Root, FVector.ZeroVector, EAttachLocation.SnapToTarget);
		if (!akComponent.IsNullOrDestroyed() && ComponentCreated)
		{
			akComponent.OcclusionCollisionChannel = (EAkCollisionChannel)27;
			akComponent.SetAutoDestroyCS(_bAutoDestory: true);
		}
		return akComponent;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_OnCurrentLevelChanged = (Del_Void_Int)Delegate.Remove(bGWEventCollection.Evt_OnCurrentLevelChanged, new Del_Void_Int(OnCurrentLevelChanged));
		}
	}
}
