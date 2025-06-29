using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using GSDispLib;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_EventCollectionCS")]
public class BUS_EventCollectionCS : UBUS_EventCollection
{
	[UDelegate]
	[USharpPath("/Script/b1-Managed.Del_SetFloatValueToSimulateFog__DelegateSignature")]
	public class Del_SetFloatValueToSimulateFog : FMulticastDelegate<Del_SetFloatValueToSimulateFog.Signature>
	{
		public delegate void Signature(FName ParamName, float FloatParam);

		private static bool Invoke_IsValid;

		private static IntPtr Invoke_FunctionAddress;

		private static int Invoke_ParamsSize;

		private static bool Invoke_ParamName_IsValid;

		private static int Invoke_ParamName_Offset;

		private static bool Invoke_FloatParam_IsValid;

		private static int Invoke_FloatParam_Offset;

		private unsafe void Invoker(FName ParamName, float FloatParam)
		{
			if (!Invoke_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.Del_SetFloatValueToSimulateFog__DelegateSignature:Invoke");
			}
			else if (IsBound)
			{
				byte* value = stackalloc byte[(int)(uint)Invoke_ParamsSize];
				IntPtr intPtr = new IntPtr(value);
				FMemory.Memzero(intPtr, Invoke_ParamsSize);
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Invoke_ParamName_Offset), ParamName);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Invoke_FloatParam_Offset), FloatParam);
				ProcessDelegate(intPtr);
			}
		}

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		private static void LoadNativeType()
		{
			Invoke_FunctionAddress = NativeReflection.GetFunction("/Script/b1-Managed.Del_SetFloatValueToSimulateFog__DelegateSignature");
			Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Invoke_FunctionAddress);
			Invoke_ParamName_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "ParamName");
			Invoke_ParamName_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "ParamName", Classes.FNameProperty);
			Invoke_FloatParam_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "FloatParam");
			Invoke_FloatParam_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "FloatParam", Classes.FFloatProperty);
			Invoke_IsValid = Invoke_FunctionAddress != IntPtr.Zero && Invoke_ParamName_IsValid && Invoke_FloatParam_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.Del_SetFloatValueToSimulateFog__DelegateSignature", Invoke_IsValid);
		}

		static Del_SetFloatValueToSimulateFog()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(Del_SetFloatValueToSimulateFog)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(Del_SetFloatValueToSimulateFog));
		}
	}

	[UDelegate]
	[USharpPath("/Script/b1-Managed.Del_TriggerFrozenFractureBreak__DelegateSignature")]
	public class Del_TriggerFrozenFractureBreak : FMulticastDelegate<Del_TriggerFrozenFractureBreak.Signature>
	{
		public delegate void Signature(AActor FractureActor, FPoseSnapshot Snapshot, FVector HitDir);

		private static bool Invoke_IsValid;

		private static IntPtr Invoke_FunctionAddress;

		private static int Invoke_ParamsSize;

		private static bool Invoke_FractureActor_IsValid;

		private static int Invoke_FractureActor_Offset;

		private static bool Invoke_Snapshot_IsValid;

		private static int Invoke_Snapshot_Offset;

		private static FFieldAddress Invoke_Snapshot_PropertyAddress;

		private static bool Invoke_HitDir_IsValid;

		private static int Invoke_HitDir_Offset;

		private static FFieldAddress Invoke_HitDir_PropertyAddress;

		private unsafe void Invoker(AActor FractureActor, FPoseSnapshot Snapshot, FVector HitDir)
		{
			if (!Invoke_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.Del_TriggerFrozenFractureBreak__DelegateSignature:Invoke");
			}
			else if (IsBound)
			{
				byte* value = stackalloc byte[(int)(uint)Invoke_ParamsSize];
				IntPtr intPtr = new IntPtr(value);
				FMemory.Memzero(intPtr, Invoke_ParamsSize);
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Invoke_FractureActor_Offset), FractureActor);
				NativeReflection.InitializeValue_InContainer(Invoke_Snapshot_PropertyAddress.Address, intPtr);
				FPoseSnapshot.ToNative(IntPtr.Add(intPtr, Invoke_Snapshot_Offset), Snapshot);
				NativeReflection.InitializeValue_InContainer(Invoke_HitDir_PropertyAddress.Address, intPtr);
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Invoke_HitDir_Offset), HitDir);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(Invoke_Snapshot_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(Invoke_HitDir_PropertyAddress.Address, intPtr);
			}
		}

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		private static void LoadNativeType()
		{
			Invoke_FunctionAddress = NativeReflection.GetFunction("/Script/b1-Managed.Del_TriggerFrozenFractureBreak__DelegateSignature");
			Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Invoke_FunctionAddress);
			Invoke_FractureActor_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "FractureActor");
			Invoke_FractureActor_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "FractureActor", Classes.FObjectProperty);
			NativeReflection.GetPropertyRef(ref Invoke_Snapshot_PropertyAddress, Invoke_FunctionAddress, "Snapshot");
			Invoke_Snapshot_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "Snapshot");
			Invoke_Snapshot_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "Snapshot", Classes.FStructProperty);
			NativeReflection.GetPropertyRef(ref Invoke_HitDir_PropertyAddress, Invoke_FunctionAddress, "HitDir");
			Invoke_HitDir_Offset = NativeReflection.GetPropertyOffset(Invoke_FunctionAddress, "HitDir");
			Invoke_HitDir_IsValid = NativeReflection.ValidatePropertyClass(Invoke_FunctionAddress, "HitDir", Classes.FStructProperty);
			Invoke_IsValid = Invoke_FunctionAddress != IntPtr.Zero && Invoke_FractureActor_IsValid && Invoke_Snapshot_IsValid && Invoke_HitDir_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/b1-Managed.Del_TriggerFrozenFractureBreak__DelegateSignature", Invoke_IsValid);
		}

		static Del_TriggerFrozenFractureBreak()
		{
			if (UnrealTypes.CanLazyLoadManagedType(typeof(Del_TriggerFrozenFractureBreak)))
			{
				LoadNativeType();
			}
			UnrealTypes.OnCCtorCalled(typeof(Del_TriggerFrozenFractureBreak));
		}
	}

	public Del_Void_Int Evt_InputRoll;

	public Del_InputTryQTE Evt_InputTryQTE;

	public Del_StartSceneQTE Evt_StartSceneQTE;

	public Del_Void_FloatInt Evt_QTEDecHP;

	[UINeedEvent]
	public Del_UnitCastSkillSuccess Evt_UnitCastSkillSuccess;

	public Del_Void_Int Evt_UnitCastSkillBeforePlayMontage;

	public Del_Void_Int Evt_OnSkillEnd;

	[UINeedEvent]
	public Del_UnitCastSkillFail Evt_UnitCastSkillFail;

	public Del_UnitTryBreakSkill Evt_UnitTryBreakSkill;

	public Del_UnitSkillBreak Evt_UnitSkillBreak;

	public Del_Void_Transform Evt_G4CameraTurnToTarget;

	public Del_Void_Float Evt_DecreaseFreeCameraArmLength;

	public Del_Void_Float Evt_ForceSetFreeCameraArmLength;

	public Del_Void_FreeCameraMode Evt_SwitchFreeCameraMode;

	public Del_Bool_Vector Evt_G4CameraTurnToLocation = (FVector _003Cp0_003E) => false;

	public Del_Void_Vector Evt_SetShootSuctionTargetDir;

	public Del_Void_FloatFloat Evt_CameraDrag;

	public Del_Void Evt_CameraDragEnterFocus;

	public Del_Void_Bool Evt_CameraDragClearFocus;

	public Del_PlayCameraSequence Evt_PlayCameraSequence;

	public Del_Void_PlayerCameraParam Evt_SetPlayerCameraParam;

	public Del_Void_StraightCameraParam Evt_SetStraightCameraParam;

	public Del_Void_DiagonalCameraParam Evt_SetDiagonalCameraParam;

	public Del_Void_GiantCameraParam Evt_SetGiantCameraParam;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_UnitSetSimpleState Evt_UnitSetSimpleState;

	public Del_CastDingShenToTarget Evt_CastDingShenToTarget;

	public Del_Void_Int Evt_CastImmobilize;

	public Del_TriggerTargetImmobilize Evt_TriggerImmobilize;

	public Del_Void_Int Evt_TriggerAttackStiffForBeImmobilized;

	public Del_RequestOneUniversalUAF Evt_RequestOneUniversalUAFFX;

	public Del_Void_Bool Evt_ActorGlowRequest;

	public Del_AiBreakInteract Evt_AiBreakInteract;

	public Del_AiBreakInteract Evt_AiDisengageInteract;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_SkillRotateTraceActor Evt_SkillRotateTraceActor;

	public Del_SkillRotateTraceLocation Evt_SkillRotateTraceLocation;

	public Del_MontageRotateTraceActor Evt_MontageRotateTraceActor;

	public Del_MontageRotateAroundLocation Evt_MontageRotateAroundLocation;

	public Del_Void_Float Evt_SwitchToCamera4GMode;

	public Del_MovementRotateToPos Evt_AttackRotateToPos;

	public Del_MovementRotateToPos Evt_ActorRotateToPos;

	public Del_MovementRotateToTarget Evt_ActorRotateToTarget;

	public Del_Void_Float Evt_PlayerSkillDirFixed;

	public Del_Void Evt_MovementForceStop;

	public Del_Void_Int Evt_MovementStopWithIdx;

	public Del_Void Evt_StopCurrentMove;

	public Del_Void_Bool Evt_MovementSwitchWalkType;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_MoveWithAnimMontage Evt_MoveWithAnimMontage;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Reliable = true, Predictable = true)]
	public Del_MoveWithAnimMontage Evt_MoveWithAnimMontageCMultiCast;

	public Del_MoveWithAnimMontage Evt_MoveWithAnimMontage_BeAttackedClient;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Reliable = true, Predictable = true)]
	public Del_CastSkillWithAnimMontage Evt_CastSkillWithAnimMontage;

	public Del_SetOffsetRotationAxis Evt_SetOffsetRotationAxis;

	public Del_SetOffsetRotationAxisComp Evt_SetOffsetRotationAxisComp;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_SetAMScaleRateByPosMultCast Evt_SetAMScaleRateByPosMultiCast;

	public Del_Void_Float Evt_SetAMScaleMaxRate;

	public Del_DragFarCamera Evt_DragFarCamera;

	public Del_OnTeleport Evt_OnTeleport;

	public Del_TeleportMove Evt_TeleportMove;

	public Del_Void Evt_ComboGraphReset;

	public Del_Void Evt_ComboGraphTryTriggerChargeSkillTimeOut;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_UnitDead Evt_UnitDead;

	public Del_Void Evt_ThrowUpDeadUnit;

	public Del_Void Evt_TriggerDeadWaitingBeAttackedAM;

	public Del_Void Evt_TriggerDeadDissolve;

	public Del_Void_BoolBool Evt_TriggerDeadBlendPhysic;

	public Del_FakeDeadForSkillDamage Evt_FakeDeadForSkillDamage;

	[UINeedEvent]
	public Del_UnitTriggerDead Evt_UnitTriggerDead;

	public Del_Void Evt_UnitTriggerDeadPreDestroy;

	public Del_OnSkillCostDmg Evt_OnSkillCostDmg;

	public Del_Void Evt_OnSkillValidAttackEnded;

	public Del_Void Evt_CastDodgeSkillSuccess;

	public Del_OnCastMagicallyChangeSkill Evt_OnCastMagicallyChangeSkill = delegate
	{
	};

	public Del_Void_Int Evt_OnMagicallyChangeRecover = delegate
	{
	};

	public Del_Void Evt_OnMagicallyChangeFadeOut = delegate
	{
	};

	public Del_Void Evt_OnMagicallyChangeBreak = delegate
	{
	};

	public Del_Void_Actor Evt_OnPlayerApproached = delegate
	{
	};

	public Del_Void Evt_OnAreaAnimalAllDead = delegate
	{
	};

	public Del_Void_FVector Evt_NeutralFXAnimalSpawnAreaInitSize = delegate
	{
	};

	public Del_Void Evt_DestroyNeutralFXAnimalSpawnner = delegate
	{
	};

	public Del_FXAnimalBeginMoveWithSplined Evt_FXAnimalBeginMoveWithSpline = delegate
	{
	};

	public Del_Void Evt_OnWeaponStanceSwitchSuccess = delegate
	{
	};

	public Del_PoleDrinkStateBegin Evt_PoleDrinkStateBegin = delegate
	{
	};

	public Del_Void Evt_PoleDrinkStateEnd = delegate
	{
	};

	public Del_DoPoleDrink Evt_DoPoleDrink = delegate
	{
	};

	public Del_WaterSplashSweepBegin Evt_WaterSplashSweepBegin = delegate
	{
	};

	public Del_Void_IntInt Evt_WaterSplashSweepEnd = delegate
	{
	};

	public Del_Void_PlayFacialAnim Evt_PlayFacialAnim = delegate
	{
	};

	public Del_Void Evt_StopFacialAnim = delegate
	{
	};

	public Del_Void Evt_PlayPigsyStory = delegate
	{
	};

	public Del_Void Evt_BeAttackedByPlayer_ForUI = delegate
	{
	};

	public Del_Void Evt_OnPreciseDodgeSuccess;

	[UINeedEvent]
	public Del_Void Evt_Camera_SwitchHideUILockPoint;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void Evt_Camera_ClearCamLock;

	public Del_Void_ActorString Evt_Camera_ManualLock;

	public Del_FloatCurve Evt_EnableCameraPitchCurve;

	public Del_Void Evt_DisableCameraPitchCurve;

	public Del_FloatCurve Evt_EnableCameraArmLengthCurve;

	public Del_Void_Float Evt_DisableCameraArmLengthCurve;

	public Del_VectorCurve Evt_EnableCameraSASOCurve;

	public Del_Void_Float Evt_DisableCameraSASOCurve;

	public Del_FloatCurve Evt_EnableCameraArmLocationZCurve;

	public Del_Void_Float Evt_DisableCameraArmLocationZCurve;

	public Del_Void_IntCastSkill Evt_AICastSkillWithSkillID;

	public Del_AICastBestComboSkill Evt_AICastBestComboSkill;

	public Del_AICastBestSkillByScore Evt_AICastBestSkillByScore;

	public Del_Void_Bool Evt_AIPauseBT;

	public Del_Void_Bool Evt_AIPauseFsm;

	public Del_Void_Bool Evt_AIPauseFsmInstance;

	public Del_Void Evt_BeHitSetInfo;

	public Del_Void_Actor Evt_SetLastHitActor;

	public Del_Void Evt_UpdatePerceptionConfig;

	public Del_Void_Bool Evt_AIPerceptionSetting;

	public Del_Void Evt_ResetAIInfo;

	public Del_SwitchFsmSolver Evt_SwitchFsmSolver;

	public Del_Void Evt_ResetToDefaultFsmSolver;

	public Del_Void_Float Evt_UpdateFsmSolver;

	public Del_AICatchTarget Evt_AICatchTarget;

	public Del_AISearchAndCatchTarget Evt_AISearchAndCatchTarget;

	public Del_SetGroupAISkill Evt_SetGroupAISkill;

	public Del_SetGroupAIWanderHotZonePoint Evt_SetGroupAIWanderHotZonePoint;

	public Del_Void Evt_ClearMeleeAttackGroupAIHotZonePoint;

	public Del_ModifySkillScore Evt_ModifySkillScore;

	public Del_GroupAIRequestTask Evt_GroupAIRequestTask;

	public Del_Actor Evt_MarkLastTargetInfoForAI;

	public Del_Void_Bool Evt_NotifyPlayBornAnim;

	public Del_IncreaseAttrFloat Evt_IncreaseAttrFloat;

	public Del_SetAttrFloat Evt_SetAttrFloat;

	public Del_IncreaseFloatValueDelayTick Evt_IncreaseFloatValueDelayTick;

	public Del_InitAbnormalAttrs Evt_InitAbnormalAttrs;

	public Del_Void Evt_DrinkHpBottomFailed;

	public Del_Void_FloatFloat Evt_AISideWalk;

	public Del_AIMoveTo Evt_AIMoveTo;

	public Del_Void_InRotator Evt_ForceSetAIMoveFacingTargetRotation;

	public Del_AIWallAndCellMoveTo Evt_AIWallAndCellMoveTo;

	public Del_Void_IntFloatFloat Evt_SetAMSectionSpeedRate;

	public Del_Void_IntInt Evt_UpdateSpeedCtrlInfoByResID;

	public Del_Void Evt_ResetSpeedCtrlInfo;

	public Del_Void_FloatFloatFloat Evt_UpdateSpeedCtrlInfoBySpdInfo;

	public Del_Void_FloatFloatFloat Evt_UpdateSpeedCtrlInfoBaseBySpdInfo;

	public Del_Void_Float Evt_SetMoveSpeedAddValue;

	public Del_SetCurveMoveInfo Evt_SetCurveMoveInfo;

	public Del_SetCurveMoveBeHitInfo Evt_SetCurveMoveBeHitInfo;

	public Del_SetCurveMoveScaleInfo Evt_SetCurveMoveScaleInfo;

	public Del_BeginFloatingHit Evt_BeginFloatingHit;

	public Del_AdditionFloatingHit Evt_AdditionFloatingHit;

	public Del_Void Evt_OnSetCurveMoveEnd;

	public Del_SetSplineFlyControlInfo Evt_SetSplineFlyControlInfo;

	public Del_OnRotateWithCam Evt_OnRotateWithCam;

	public Del_Void Evt_OnRotateWithCamEnded;

	public Del_OnPlayRotAMByCamRotBegind Evt_OnPlayRotAMByCamRotBegin;

	public Del_Void Evt_OnPlayRotAMByCamRotEnded;

	public Del_MagicFieldInitialization Evt_MagicFieldInitialization;

	public Del_Void Evt_DebugEnableVerboseLog;

	public Del_Void Evt_ResetBlockInfo;

	public Del_SetNewBlockInfoConfig Evt_SetNewBlockInfoConfig;

	public Del_Void Evt_AddCounterAttackTimes;

	public Del_Void Evt_CastSkillToBreakHitRecover;

	public Del_Void Evt_ResetCounterAttack;

	public Del_Void Evt_CounterAttackSuperArmor;

	public Del_Void_Bool Evt_TriggerCounterAttack;

	public Del_PlayBreakPartMontage Evt_PlayBreakPartMontage;

	public Del_Void_IntBool Evt_SetPartActive;

	public Del_Void_IntBool Evt_SetPartRuleID;

	public Del_Void Evt_ResetPartRuleID;

	public Del_Void Evt_RefreshCurPartRuleInfo;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_Int Evt_RecoveryPartDamageValue;

	public Del_Void Evt_AdvanceRemoveForcePerformanceState;

	public Del_Void Evt_PlayBRKSuperSkillArmorMontage;

	public Del_TriggerBlock Evt_TriggerBlock;

	public Del_TriggerBlockInSPState Evt_TriggerBlockInSPState;

	public Del_ReleaseBlockInSPState Evt_ReleaseBlockInSPState;

	public Del_Void_Actor Evt_PlayBlockBouncedMontage;

	public Del_Void_Actor Evt_PlayBRKBlockCollapseArmorMontage;

	public Del_Void_Actor Evt_PlayBRKBlockArmor2WeakMontage;

	public Del_Void Evt_ReleaseBlockState;

	public Del_Void_BoolFloat Evt_SwitchCameraMode;

	public Del_SetCameraArmMode Evt_SetCameraArmMode;

	public Del_SetCameraArmMode Evt_SetLockCameraArmMode;

	public Del_Void_Bool Evt_EnableCustomFOV;

	public Del_Void_BoolFloat Evt_EnableCustomCamPitch;

	public Del_Void Evt_ShootLightBegin;

	public Del_Void Evt_ShootLightEnd;

	public Del_Void Evt_ShootHeavy;

	[UINeedEvent]
	public Del_Void Evt_ShootUIChangeScale;

	[UINeedEvent]
	public Del_Void_Bool Evt_ShootUIChangeColor;

	public Del_Void_FloatFloat Evt_UnitLightShootSuccess;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_BuffAdd Evt_BuffAdd;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_BuffRemove Evt_BuffRemove;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_BuffRemoveImmediately Evt_BuffRemoveImmediately;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_BuffAllRemove Evt_BuffAllRemove;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	[UINeedEvent]
	public Del_AddBuffNotify Evt_AddBuffNotify;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	[UINeedEvent]
	public Del_Void_IntInt Evt_RemoveBuffNotify;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_BuffInstsDictOnAdd Evt_BuffInstsDictOnAdd;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void_Int Evt_BuffInstsDictOnRemove;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void_Bool Evt_ShouledUpdateBuffTime;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void_ActorActorInt Evt_UpdateBuffCaster;

	public Del_Void_IntInt Evt_TriggerBuffAlmostEndFX;

	public Del_Void_IntInt Evt_TriggerBuffDamageFX;

	public Del_CopyBuffFromOtherUnit Evt_CopyBuffFromOtherUnit;

	public Del_OnBuffLayerChanged Evt_OnBuffLayerChanged;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_OnBuffLayerChangedNotify Evt_OnBuffLayerChangedNotify;

	public Del_Void Evt_NotifyCanAddBuff;

	public Del_Void_Actor Evt_SetMaster;

	public Del_Void Evt_NotifyMasterChanged;

	public Del_UnitStateTrigger Evt_UnitStateTrigger;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_UnitStateTrigger Evt_UnitStateTriggerCMultiCast;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Reliable = true, Predictable = true)]
	public Del_UnitStatePredic Evt_UnitStatePredic;

	public Del_OnProjectileBeHitted Evt_OnProjectileBeHitted;

	public Del_HandleReactionWhenBeHitted_ByEffect Evt_HandleReactionWhenBeHitted_ByEffect;

	public Del_OnNotifyStateSpawnProjectileObj Evt_OnNotifyStateSpawnProjectileObj;

	public Del_OnNotifyStateSpawnProjectileObjEnd Evt_OnNotifyStateSpawnProjectileObjEnd;

	public Del_Void_Int Evt_NotifyBulletMarkDBCReqID;

	public Del_Void Evt_NotifyBulletIsDead;

	public Del_PCSEW_Regist Evt_PCSEW_Regist;

	public Del_PCSEW_Regist Evt_PCSEW_Destroy;

	public Del_Void Evt_ResetMeshEasingDataZ;

	public Del_Void_BoolInt Evt_ReplaceCharacter;

	public Del_Void_BoolString Evt_SwitchBehaviourTree;

	public Del_Void_BoolString Evt_HideOrShowMesh;

	public Del_Void_String Evt_ResetHideOrShowMesh;

	public Del_Void Evt_EnableTransUnitPhysicsAsset;

	public Del_Void Evt_TriggerTransBack;

	public Del_Void_Int_Actor Evt_TriggerTransBackByInteract;

	public Del_Evt_NotifyUnitTrans_BeforePosses Evt_NotifyUnitTrans_BeforePosses;

	public Del_TransBack_PreUnitTrans Evt_TransBack_PreUnitTrans;

	public Del_Void_Float Evt_FootSlideBegin;

	public Del_TriggerFootStep Evt_TriggerFootStep;

	public Del_Void_BoolBoolBoolInt Evt_EnableMontageFootstepBegin;

	public Del_Void_Int Evt_EnableMontageFootstepEnd;

	public Del_Void Evt_MyriapodsFootStepBegin;

	public Del_Void Evt_MyriapodsFootStepEnd;

	public Del_Void Evt_ResetBeAttackedInfoID;

	public Del_Void_Int Evt_SetNewBeAttackedInfoID;

	public Del_MarkBeAttackedWarnningProtectTime Evt_MarkBeAttackedProtectTime;

	public Del_PlayAttackHitAudioByRule Evt_PlayAttackHitAudioByRule;

	public Del_BeAttackedVisualEffect Evt_BeAttackedVisualEffect;

	public Del_PlayBeAttackedPhysicalAnim Evt_PlayBeAttackedPhysicalAnim;

	public Del_PlayBeAttackedPhysAnim Evt_PlayBeAttackedPhysAnim;

	public Del_PlayBeAttackedPhysAnim Evt_PlayBeAttackedPhysAnimForDead;

	public Del_Void_Vector Evt_PlayBeAttackedAdditiveAnim;

	public Del_Void_Vector Evt_PlayBeAttackedAdditiveAnim_Jump;

	public Del_Void_VectorVector Evt_CacheBeHitBoneLocTransform;

	public Del_Void_Bool Evt_SetTriggerMontage;

	public Del_Void_Vector Evt_SetAttractionLocation;

	public Del_TriggerAttachBehitComp Evt_TriggerAttachBehitComp;

	public Del_NotifyTriggerBuffWhenConditionMet Evt_NotifyTriggerBuffWhenConditionMet;

	public Del_NotifyRemoveBuffWhenConditionMet Evt_NotifyRemoveBuffWhenConditionMet;

	public Del_DeadWhenInImmobilized Evt_DeadWhenInImmobilized;

	public Del_HitWhenInImmobilized Evt_HitWhenInImmobilized;

	public Del_TriggerImmobilizedBreak Evt_TriggerImmobilizedBreak;

	public Del_TriggerSkillSuperArmor Evt_TriggerSkillSuperArmor;

	public Del_Void_Int Evt_RemoveSkillSuperArmor;

	public Del_AttackFeedbackPerform Evt_AttackFeedbackPerform;

	public Del_OnHitGroundPerform Evt_OnHitGroundPerform;

	public Del_OnHitWorldItemPerform Evt_OnHitWorldItemPerform;

	public Del_ActivatePhysicBlend Evt_ActivatePhysicBlend;

	public Del_ActivatePhysicBlendForDeath Evt_ActivatePhysicBlendForDeath;

	public Del_HandleSlowIK Evt_HandleSlowIK;

	public Del_SetSlowIKConfig Evt_SetSlowIKConfig;

	public Del_Void Evt_DisableSlowIK;

	public Del_TriggerFreezeFrame Evt_TriggerFreezeFrame;

	public Del_TriggerSlowIK Evt_TriggerSlowIK;

	public Del_SetMatsScalarParam Evt_SetMatsScalarParam;

	public Del_SetMatsVectorParam Evt_SetMatsVectorParam;

	public Del_SetMatsParam Evt_SetMatsParam;

	public Del_SetMatsLayerParam Evt_SetMatsLayerParam;

	public Del_ResetMatsParam Evt_ResetMatsParam;

	public Del_ResetMatsLayerParam Evt_ResetMatsLayerParam;

	public Del_Void_Bool Evt_RefreshAllCacheMatsParam;

	public Del_TriggerMPCScalarParamTick Evt_TriggerMPCScalarParamTick;

	public Del_TriggerMPCScalarParamTickWithObj Evt_TriggerMPCScalarParamTickWithObj;

	public Del_SetMPCLinearColorParam Evt_SetMPCLinearColorParam;

	public Del_SetMPCScalarParam Evt_SetMPCScalarParam;

	public Del_BeginForSetCurveValueToMesh Evt_BeginForSetCurveValueToMesh;

	public Del_OverForSetCurveValueToMesh Evt_OverForSetCurveValueToMesh;

	public Del_Void Evt_PrintWukongMatQualityInfo;

	public Del_BeginForSetCurveValueToHair Evt_BeginForSetCurveValueToHair;

	public Del_OverForSetCurveValueToHair Evt_OverForSetCurveValueToHair;

	public Del_CreateTireMark Evt_CreateTireMark;

	public Del_OnEndTireMarkByID Evt_OnEndTireMarkByID;

	public Del_SetHitCollisionUpdateInfo Evt_SetHitCollisionUpdateInfo;

	public Del_Void_String Evt_ResetHitCollisionScaleInfo;

	public Del_ModifyCollisionHitWeight Evt_ModifyCollisionHitWeight;

	public Del_Void Evt_ResetCollisionHitWeight;

	public Del_HitDestructible Evt_HitDestructible;

	public Del_Void Evt_DestructibleDead;

	public Del_Void_Bool Evt_ResetDestructible;

	public Del_Void_Bool Evt_TriggerNextChargeSkillStage;

	public Del_Void Evt_TriggerCancelChargeSkill;

	public Del_Void_Int Evt_OnIncreaseChargeLevel;

	public Del_Void_Int Evt_OnDecreaseChargeLevel;

	public Del_Void_Int Evt_EnterPlayerSkillCamera;

	public Del_Void Evt_ExitPlayerSkillCamera;

	public Del_StartCamOffsetTick Evt_StartCamOffsetTick;

	public Del_Void Evt_StopCamOffsetTick;

	public Del_Void Evt_DetachCameraFromPlayer;

	public Del_Void Evt_ReAttachCameraToPlayer;

	public Del_Void_Bool Evt_ShowGameUI;

	public Del_TriggerCurveFlyAnim Evt_TriggerCurveFlyAnim;

	public Del_OnShowDialogueBuddle Evt_OnShowDialogueBuddle;

	public Del_Void Evt_EndAllVFX;

	public Del_SpawnGhostActor Evt_SpawnGhostActor;

	public Del_TriggerGhostActor Evt_TriggerGhostActor;

	public Del_PlayBeamFX Evt_PlayBeamFX;

	public Del_OnDestroyFXCompByTag Evt_OnDestroyFXCompByTag;

	public Del_SetMatchingPosInterpInfo Evt_SetMatchingPosInterpInfo;

	public Del_Void Evt_CallBPFunc;

	public Del_Void_Bool Evt_SetInteractActiveState;

	public Del_TriggerBeInteract Evt_TriggerBeInteract;

	public Del_Void_Actor Evt_TriggerPreInteract;

	public Del_Void_Actor Evt_TriggerPreInteractForAiInteract;

	public Del_Void Evt_OnAiMoveToInteractPoint;

	public Del_Void Evt_OnAiMoveToWaitPoint;

	public Del_Void Evt_TriggerInteractRollback;

	[UINeedEvent]
	public Del_Void_Actor Evt_TriggerBreakInteract;

	[UINeedEvent]
	public Del_Void_Actor Evt_OnPlayerBreakInteract;

	[UINeedEvent]
	public Del_Void_Actor Evt_TriggerFinishInteract;

	public Del_PostAkEvent_Follow Evt_PostAkEvent_Follow;

	public Del_PostAkEvent_AtLocation Evt_PostAkEvent_AtLocation;

	public Del_PostAkEvent_OnAkComp Evt_PostAkEvent_OnAkComp;

	public Del_PostAkEvent_AM Evt_PostAkEvent_AM;

	public Del_Void_BoolInt Evt_RemoveAkEventCtrl;

	public Del_Void_Int Evt_OnAkEventEnded;

	public Del_Void_Int Evt_StopAkEvent;

	public Del_JumpToNextSubtitleMarkerPos Evt_JumpToNextSubtitleMarkerPos;

	public Del_ScaleWeaponByCurve Evt_ScaleWeaponByCurve;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_Void Evt_ClearTargetInfo;

	public Del_SetTargetInfo Evt_SetTargetInfo;

	public Del_SetTargetInfoWithCameraLocking Evt_SetTargetInfoWithCameraLocking;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_SetTargetInfoServer Evt_SetTargetInfoServer;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_SetTargetInfoWithCameraLockingServer Evt_SetTargetInfoWithCameraLockingServer;

	public Del_Void_BoolActor Evt_ChangeTargetedCount;

	public Del_DoFreshMultiTarget Evt_DoFreshMultiTarget;

	public Del_SetSkillBaseTarget Evt_SetSkillBaseTarget;

	public Del_SetComboTarget Evt_SetComboTarget;

	public Del_Void Evt_ClearSkillBaseTarget;

	public Del_Void Evt_ClearComboTarget;

	public Del_Void_Bool Evt_EnableCanSetTarget;

	public Del_Void_Bool Evt_EnableCanUpdateHatred;

	public Del_Void_Bool Evt_SetCanSetTargetByHatred;

	public Del_Void Evt_DoCheckUpdateSideWalkingState;

	public Del_NotifyTargetInfoChanged Evt_NotifyTargetInfoChanged;

	public Del_Void_Bool Evt_SetLocalControlled;

	public Del_Void_Actor Evt_AddLastSkillHit;

	public Del_Void Evt_ClearLastSkillHit;

	public Del_RequestSpawnFXByDispConfig Evt_RequestSpawnFXByDispConfig = delegate(string DispConfigDAPath, out int RequestID, USceneComponent EmitterDispOwnerComp, bool NeedSetSpawnTransform, FTransform SpawnTransform)
	{
		RequestID = 0;
	};

	public Del_RequestSpawnFXByDispConfigDA Evt_RequestSpawnFXByDispConfigDA = delegate(UBGWDataAsset DispConfig, out int RequestID, USceneComponent EmitterDispOwnerComp, bool NeedSetSpawnTransform, FTransform SpawnTransform, DBCSetCallbackParams CallbackParams)
	{
		RequestID = 0;
	};

	public Del_RequestSpawnFXByDispConfigWithEmitterInfo Evt_RequestSpawnFXByDispConfigWithEmitterInfo = delegate(string DispConfigDAPath, out int RequestID, USceneComponent EmitterDispOwnerComp, FVector EmitterPosWSOnSpawn)
	{
		RequestID = 0;
	};

	public Del_Void_Int Evt_RequestDestroyByFXRequestID;

	public Del_OnSwitchSelfAssistState Evt_OnSwitchSelfAssistState;

	public Del_FireImpulseLikeRadialForceComp Evt_FireImpulseLikeRadialForceComp;

	public Del_Void_StringInt Evt_InitiatePriorityAction;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_TriggerHitInPart Evt_TriggerHitInPart;

	public Del_SetAimOffsetBlend Evt_SetAimOffsetBlend;

	public Del_SetUpperBodyAO Evt_SetUpperBodyAO;

	public Del_SetSpAtkReboundingAM Evt_SetSpAtkReboundingAM;

	public Del_RemoveSpAtkReboundingAM Evt_RemoveSpAtkReboundingAM;

	public Del_InputPhantomRush Evt_TriggerPhantomRush;

	public Del_Void_Int Evt_SetPhantomRushConfigID;

	public Del_Void Evt_RelievePhantomRush;

	public Del_Void_Bool Evt_SetPhantomRushImperceptible;

	public Del_Void Evt_TriggerSealingSpell;

	public Del_Void Evt_ResetSealingSpell;

	public Del_Void Evt_ResetDaShengStatus;

	public Del_SummonSkillCastByPhantomRush Evt_SummonSkillCastByPhantomRush;

	public Del_PhantomRushSummonBehavior Evt_PhantomRushSummonBehavior;

	public Del_CopySkillSummonBehavior Evt_CopySkillSummonBehavior;

	public Del_Void Evt_SummonSkillCastByHatch;

	public Del_Void_Bool Evt_MarkSummonCantLifeOver;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_SetActorTransform Evt_SetActorTransform;

	public Del_SetActorLocation Evt_SetActorLocation;

	public Del_SetActorRotation Evt_SetActorRotation;

	public Del_SetActorLocationAndRotation Evt_SetActorLocationAndRotation;

	public Del_Void Evt_ClearActorTransformCache;

	public Del_Void Evt_ResetCameraSpringArmRot;

	public Del_Void Evt_MoveCameraSpringArmRot2Nearest;

	public Del_Void_Rotator Evt_MoveCameraSpringArm2CustomRotation;

	public Del_TriggerIntimidation Evt_TriggerIntimidation;

	public Del_InitiateIntimidation Evt_InitiateIntimidation;

	public Del_Void_Actor Evt_CollectAddHatredUnitAsPlayerInfo;

	public Del_Void_Actor Evt_CollectCatchTargetAsPlayerInfo;

	public Del_Void_Actor Evt_ClearCollectedTargetInfo;

	public Del_Void_Actor Evt_ClearCollectedHatredInfo;

	public Del_NotifyBattleStateChange Evt_NotifyBattleStateChange;

	public Del_Void Evt_AddLocalPlayerIntoHatredList;

	public Del_Void_AnimSequence Evt_NPCReplaceIdleAnim;

	public Del_Void_Int Evt_ChangeIdleAnimByIdx;

	public Del_Void_Int Evt_ChangeLeisureAnimByIdx;

	public Del_ChangeNPCState Evt_ChangeNPCState;

	public Del_Void_AnimMontage Evt_NPCReplaceLeisureAnim;

	public Del_Void_IntIntIntInt Evt_NPCReplaceOnFightSkill;

	public Del_Void Evt_SetAIBTAborted;

	public Del_InitiateAINodeAction Evt_InitiateAINodeAction;

	public Del_Void_Bool Evt_SetAINodeActionPause;

	public Del_Void Evt_SetAINodeActionStop;

	public Del_NotifyAIActionFinish EVt_NotifyAIActionFinish;

	public Del_Void_Bool Evt_NotifyUnitReturnHome;

	public Del_Void Evt_NotifyUnitTriggerWakeupActivated;

	public Del_TriggerPerformerStateChange Evt_TriggerPerformerStateChange;

	public Del_TriggerNPCShowStateChange Evt_TriggerNPCShowStateChange;

	public Del_ScaleTime Evt_TriggerScaleTime;

	public Del_NotifyAssociationUnitActive Evt_NotifyAssociationUnitActive;

	public Del_Void Evt_BreakIdleDisp;

	public Del_Void_Float Evt_UpdateFollowPartnerIdleDisp;

	public Del_TriggerAiConversationForWeakInteract Evt_TriggerAiConversationForWeakInteract;

	public Del_TriggerAttackStiff Evt_TriggerAttackStiff;

	public Del_NotifyAttackerHitSuccess Evt_NotifyAttackerHitSuccess;

	public Del_TriggerInputActionImpl Evt_TriggerInputAction;

	public Del_TriggerItemSkillAction_ShortCut Evt_TriggerItemSkillAction_ShortCut;

	public Del_TriggerItemSkillAction_UseItem Evt_TriggerItemSkillAction_UseItem;

	public Del_MovementRotateToPos Evt_TPSRotateToPos;

	public Del_Void_Bool Evt_SetRootMotionFollowState;

	public Del_BeginPreMontageSectionJumpDetection Evt_BeginPreMontageSectionJumpDetection;

	public Del_MontageSectionJumpApproved Evt_MontageSectionJumpApproved;

	public Del_EndPreMontageSectionJumpDetection Evt_EndPreMontageSectionJumpDetection;

	public Del_NotifyEnterPreAnimationSyncingState Evt_NotifyEnterPreAnimationSyncingStateOnHost;

	public Del_NotifyEnterPreAnimationSyncingState Evt_NotifyEnterPreAnimationSyncingStateOnGuest;

	public Del_Void Evt_NotifyReactToAnimationSyncOnGuest;

	public Del_NotifyEnterAnimationSyncingStateOnHost Evt_NotifyEnterAnimationSyncingStateOnHost;

	public Del_NotifyEnterAnimationSyncingStateOnGuest Evt_NotifyEnterAnimationSyncingStateOnGuest;

	public Del_NotifyEndSyncAnimation Evt_NotifyEndSyncAnimationOnHost;

	public Del_NotifyEndSyncAnimation Evt_NotifyEndSyncAnimationOnGuest;

	public Del_NotifyBeginSyncAnimationOnHost Evt_NotifyBeginSyncAnimationOnHost;

	public Del_NotifyBeginSyncAnimationOnGuest Evt_NotifyBeginSyncAnimationOnGuest;

	public Del_NotifyBeginInteractSyncAnimationOnHost Evt_NotifyBeginInteractSyncAnimationOnHost;

	public Del_Void_Actor Evt_NotifyBeginInteractSyncAnimationOnGuest;

	public Del_Void Evt_NotifyEndInteractSyncAnimationOnHost;

	public Del_Void_Bool Evt_NotifyEndInteractSyncAnimationOnGuest;

	public Del_BeginSyncAnimationOnGuest Evt_BeginSyncAnimationOnGuest;

	public Del_SetSyncCamera Evt_SetSyncCamera;

	public Del_Void_FNameFloat Evt_SyncCameraSwitchSyncPoint;

	public Del_Void Evt_EndSyncAnimationOnGuest;

	public Del_BeginInteractSyncAnimation Evt_BeginInteractSyncAnimation;

	public Del_Void Evt_EndInteractSyncAnimation;

	public Del_UpdateDummyMeshInSyncAnimation Evt_UpdateDummyMeshInSyncAnimation;

	public Del_Void_Bool Evt_RespectCollisionInASS;

	public Del_Void_Actor Evt_SetPendingCatchTargetInASS;

	public Del_MontageSection Evt_MontageJumpToSection;

	public Del_MontageSection Evt_MontageSetNextSection;

	public Del_RequestSpawnSyncAnimActor Evt_RequestSpawnSyncAnimActor;

	public Del_RemoveSpawnedSyncAnimActor Evt_RemoveSpawnedSyncAnimActor;

	public Del_SwitchSyncGuest Evt_SwitchSyncGuest;

	public Del_SetFloatValueToMaterialAdvect Evt_SetFloatValueToMaterialAdvect;

	public Del_OnCurrentTargetChanged Evt_OnCurrentTargetChanged;

	public Del_SkillID Evt_BeginPhaseTransitionBySkill;

	public Del_EscapeAfterDeath Evt_EscapeAfterDeath;

	public Del_Void_Bool Evt_OverrideSpawnSwitch;

	public Del_StartWave Evt_StartWave;

	public Del_AddUnitToWave Evt_AddUnitToWave;

	public Del_Void_ActorInt Evt_OnWaveUnitAllDead;

	public Del_Void_Actor Evt_SpawnTriggerSpawnUnit;

	public Del_EnableCheckBuffGroup Evt_EnableCheckBuffGroup;

	public Del_DisableCheckBuffGroup Evt_DisableCheckBuffGroup;

	public Del_SwitchStateLib Evt_SwitchStateLib;

	public Del_ResetStateLib Evt_ResetStateLib;

	public Del_Void Evt_ResetStateLibAll;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_SetNewTurnSkillID Evt_SetNewTurnSkillID;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_Void Evt_ResetAllTurnSkillIDs;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_SetNewMoveSkillID Evt_SetNewMoveSkillID;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_Void Evt_ResetAllMoveSkillIDs;

	public Del_OverrideBlockFightBackSkillIDs Evt_OverrideBlockFightBackSkillIDs;

	public Del_Void Evt_ResetBlockFightBackSkillIDs;

	public Del_PlayPointAttractionMontage Evt_PlayPointAttractionMontage;

	public Del_BeginModularSimulation Evt_BeginModularSimulation;

	public Del_SyncModularData Evt_SyncModularData;

	public Del_SyncModularMgr Evt_SyncModularMgr;

	public Del_Void Evt_ResetModularActor;

	public Del_DetachModularParts Evt_DetachModularParts;

	public Del_DestroyModularParts Evt_DestroyModularParts;

	public Del_RestoreModularParts Evt_RestoreModularParts;

	public Del_Void Evt_TryToInterruptRestoreModularParts;

	public Del_ModularBreakDown Evt_ModularBreakDown;

	public Del_Void Evt_TryDestroyModularActors;

	public Del_Bool Evt_TryHideModularActors;

	public Del_Void_Actor Evt_SummonRecall;

	public Del_Void_Int Evt_SummonUseSkill;

	public Del_Void_IntIntFloat Evt_CacheFixFunctionReturnValue;

	public Del_ModifyCD Evt_ModifyCD;

	public Del_PassiveSkillModifyParam Evt_PassiveSkillModifyParam;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnSkillCooldownChanged;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnSkillMinAttrCostBase1Changed;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnSkillMinAttrCostBase2Changed;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnChargeSkillMaxChargeTimeChanged;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnPlayerSkillAttackRangeChanged;

	public Del_PassiveSkill1IDMoveSpeedTypeParamChanged Evt_OnChargeSkillMoveSpeedChanged;

	public Del_PassiveSkill1IDIntParamChanged Evt_OnBuffDurationChanged;

	public Del_PassiveSkill1IDIntParamChanged Evt_OnBuffIntervalChanged;

	public Del_PassiveSkill1IDIntParamChanged Evt_OnBuffMaxLayerChanged;

	public Del_PassiveSkill1IDIntParamChanged Evt_OnBuffTargetCountChanged;

	public Del_PassiveSkill1IDIntParamChanged Evt_OnBuffRangeChanged;

	public Del_PassiveSkill1IDIntParamChanged Evt_OnSkillEffectTargetCountChanged;

	public Del_PassiveSkill1IDIntParamChanged Evt_OnSkillEffectRangeChanged;

	public Del_PassiveSkill2IDFloatParamChanged Evt_OnSkillEffectFloatParamChanged;

	public Del_PassiveSkill2IDIntParamChanged Evt_OnSkillEffectIntParamChanged;

	public Del_PassiveSkill2IDFloatParamChanged Evt_OnSkillEffectActiveConditionParamsChanged;

	public Del_PassiveSkill2IDFloatParamChanged Evt_OnBuffActiveConditionParamsChanged;

	public Del_PassiveSkill3IDFloatParamChanged Evt_OnBuffEffectFloatParamChanged;

	public Del_PassiveSkill3IDIntParamChanged Evt_OnBuffEffectIntParamChanged;

	public Del_Void_Bool Evt_PauseUpdate;

	public Del_PerformCutDeath Evt_OnPerformCutDeath;

	public Del_Void Evt_DeadPreDestroyActor;

	public Del_ToggleSnapshotPose Evt_OnToggleSnapshotPose;

	public Del_PlayActorSequence Evt_PlayActorSequence;

	public Del_PlayDynamicSequence Evt_PlayDynamicSequence;

	public Del_SetDeadInfoID Evt_SetDeadInfoID;

	public Del_Void Evt_ResetDeadInfoID;

	public Del_OverrideArmorSetting Evt_OverrideArmorSetting;

	public Del_Void Evt_ResetArmorSetting;

	public Del_PushRenderTargetValuesToGroup Evt_PushRenderTargetValuesToGroup;

	public Del_ClearRenderTargetValuesForGroup Evt_ClearRenderTargetValuesForGroup;

	public Del_ClearAllRenderTargetValues Evt_ClearAllRenderTargetValues;

	public Del_ToggleWeaponsStatus_ByNotifyState Evt_ToggleWeaponsStatus_ByNotifyState;

	public Del_ToggleWeaponsStatus_ByEffect Evt_ToggleWeaponsStatus_ByEffect;

	public Del_ToggleWeaponsStatus_ByOtherComp Evt_ToggleWeaponsStatus_ByOtherComp;

	public Del_Void Evt_StopWeaponStatusSwitch;

	public Del_ApplyEnvironmentMask Evt_ApplyEnvironmentMask;

	public Del_SetMatsTextureParam Evt_SetMatsTextureParam;

	public Del_TriggerTTTBEffect Evt_TriggerTTTBEffect;

	public Del_Void_FloatFloat Evt_OnUpdateBulletRingFX;

	public Del_Void Evt_LeaveEnvironmentInteractionVolumeForMat;

	public Del_SetMaterialLayerParam Evt_SetMaterialLayerParam;

	public Del_MaterialLayerKeyData Evt_RemoveMaterialLayerTargetBlendOutValue;

	public Del_Void_Actor Evt_OnEnvironmentInteractionVolumeEnterForMat;

	public Del_Void_Actor Evt_OnEnvironmentInteractionVolumeLeaveForMat;

	public Del_ResetSceneItemsByTag Evt_ResetSceneItemsByTag;

	public Del_AddBattleInfoLog Evt_AddBattleInfoLog;

	public Del_TriggerScarFX Evt_TriggerScarFX;

	public Del_TriggerClearScar Evt_TriggerClearScar;

	public Del_EvaluatePositionByProceduralDatas Evt_EvaluatePositionByProceduralDatas = (FVector2D _003Cp0_003E) => ESceneItemSurfaceType.DefaultSurface;

	public Del_EvaluateSurfaceTypeMapping Evt_EvaluateSurfaceTypeMapping = (ESceneItemSurfaceType _003Cp0_003E) => ESceneItemSurfaceType.DefaultSurface;

	public Del_OnSweepHitWorldItemForProceduralFX Evt_OnSweepHitWorldItemForProceduralFX;

	public Del_OnSweepHitWorldItemForProcedural Evt_OnSweepHitWorldItemForProcedural;

	public Del_Void_Actor Evt_OnKillVictim;

	public Del_ChangeAimOffset Evt_ChangeAimOffset;

	public Del_Void_Bool Evt_ResetAimOffset;

	public Del_SurfaceType Evt_AddActiveSurfaceType;

	public Del_SurfaceType Evt_RemoveActiveSurfaceType;

	public Del_Void_Bool Evt_ToggleWeaponRenderStatic;

	public Del_HandleWeaponDetach Evt_HandleWeaponDetach;

	public Del_PlayOrStopAnimation Evt_PlayOrStopAnimation;

	public Del_Void_Bool Evt_ToggleWeaponActive;

	public Del_SetPendingDeathInASS Evt_SetPendingDeathInASS;

	public Del_SetPendingLifeSavingInASS Evt_SetPendingLifeSavingInASS;

	public Del_ProcessPendingDeathInASS Evt_ProcessPendingDeathInASS;

	public Del_Void_Bool Evt_TriggerSimpleJump;

	public Del_SetCustomDepthStencilByComp Evt_SetCustomDepthStencilByComp;

	public Del_SetCustomDepthStencilByClass Evt_SetCustomDepthStencilByClass;

	public Del_PlayMappedSoundFX Evt_PlayMappedSoundFX;

	public Del_Void_Actor Evt_ForceTrigger;

	public Del_PrepareCameraSequenceActor Evt_PrepareCameraSequenceActor;

	public Del_Void Evt_InitCameraSeqActors;

	public Del_SetUnitCameraID Evt_SetUnitCameraID;

	public Del_Void Evt_ResetUnitCameraID;

	public Del_UI_X2ToggleStealthPanel Evt_UI_X2ToggleStealthPanel;

	public Del_UI_X2ToggleEnableSwitchHero Evt_UI_X2ToggleEnableSwitchHero;

	public Del_Void Evt_UI_X2InitStealthAlertWidget;

	public Del_UI_X2UpdateAlertProgress Evt_UI_X2UpdateAlertProgress;

	public Del_Void_Actor Evt_UI_X2ReInitCtrlUI;

	public Del_Void_Bool Evt_UI_X2ShowUI;

	public Del_UI_CreateWidgetForInput Evt_UI_CreateWidgetForInput;

	public Del_Void Evt_UI_RemoveWidgetForInput;

	public Del_Void Evt_UI_OnMouseButtonUp;

	public Del_HandleConversationByContentIDList Evt_HandleConversationByContentIDList;

	public Del_ModifyAiConvBlackboardData Evt_ModifyAiConvBlackboardData;

	public Del_Void Evt_OnAiConversationListEnded;

	public Del_Void Evt_OnAiConversationListInteraputed;

	public Del_Void_BoolBoolFloat Evt_ActiveAiConversationDistanceInterruptCheck;

	public Del_Void_BoolStringFloat Evt_ActiveAiConversationListenerStateInterruptCheck;

	public Del_SummonSkillCast Evt_SummonSkillCast;

	public Del_Void Evt_OnSetJumpSpeedRate;

	public Del_AISetSpeedRate Evt_AISetSpeedRate;

	public Del_Void_Actor Evt_PerceptionFindTarget;

	public Del_Void_Float Evt_SetGMCustomTimeDilation;

	public Del_SetEnableAnimCurveBodyBlend Evt_SetEnableAnimCurveBodyBlend;

	public Del_Void_Bool Evt_SetEnterGlideMoveEnabled;

	public Del_Void Evt_NotifyEnterGlideMove;

	public Del_Void_AnimInstance Evt_CachePlayerLocomotionAnimInst;

	public Del_Void_AnimInstance Evt_CacheAdvancedMonsterLocomotionAnimInst;

	public Del_Void_AnimInstance Evt_CacheCloudLocomotionAnimInst;

	public Del_Void_AnimInstance Evt_CacheSpecialMoveAnimInst;

	public Del_Void_StringBool Evt_SetCameraLockPointEnabled;

	public Del_Void_StringBool Evt_SetAutoLockPointEnabled;

	public Del_Void Evt_FinishRotateMoveMode;

	public Del_Void_Bool Evt_DisablePhysicalMove;

	public Del_BeginManualSplineMoveWithSpecialAnimation Evt_BeginManualSplineMoveWithSpecialAnimation;

	public Del_SetSplineMoveAnimConfig Evt_SetSplineMoveAnimConfig;

	public Del_Void Evt_TriggerSplineMoveDBC;

	public Del_Void Evt_CricketMoveToNextPoint;

	public Del_Void Evt_CricketEnterJumpState;

	public Del_Void_Actor Evt_TriggerInteractCricket;

	public Del_Void Evt_BreakInteractCricket;

	public Del_Void Evt_FinishInteractCricket;

	public Del_Void_String Evt_CricketTriggerInteract;

	public Del_Void_String Evt_CricketBreakInteract;

	public Del_Void_String Evt_CricketFinishInteract;

	public Del_Void_Bool Evt_CricketJumpUp;

	public Del_Void Evt_CricketStartWeakIdle;

	public Del_Void Evt_FinishInteractCricketDisplay;

	public Del_Void_AnimMontage Evt_OnCricketStartWeakIdle;

	public Del_Void_AnimMontage Evt_OnCricketPrepareInteractFinish;

	public Del_Void Evt_OnInteractCricketSuccess;

	public Del_Void_Bool Evt_SetModularMeshVisibility;

	public Del_Void Evt_TriggerModularMeshTickAnimForCopyPose;

	public Del_Void Evt_OnStaminaDepleted;

	public Del_Void Evt_OnInteractActorDead;

	public Del_Void_Bool Evt_RequestHideOldBuffDisp;

	public Del_ResetProperty Evt_ResetProperty;

	public Del_SetBoolProperty Evt_SetBoolProperty;

	public Del_SetBoolBoolProperty Evt_SetBoolBoolProperty;

	public Del_SetVectorProperty Evt_SetVectorProperty;

	public Del_SetRotatorProperty Evt_SetRotatorProperty;

	public Del_SetFloatProperty Evt_SetFloatProperty;

	public Del_SetIntProperty Evt_SetIntProperty;

	public Del_SetEnumProperty Evt_SetEnumProperty;

	public Del_SetStringProperty Evt_SetStringProperty;

	public Del_SetCollisionResponseProperty Evt_SetCollisionResponseProperty;

	public Del_Void_IntInt Evt_SkillOverlyingPointInc;

	public Del_Void_IntInt Evt_SkillOverlyingPointDec;

	public Del_Void Evt_BePlayerAddTargeted;

	public Del_Void Evt_PreGainWeapon;

	public Del_Void_Int Evt_BMInputHeal;

	public Del_Void Evt_BMInputNormalAttack;

	public Del_Void_Int Evt_BMInputPressSkillButton;

	public Del_Void_Int Evt_BMInputRButton;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true)]
	public Del_SmartCastSkillTry Evt_SmartCastSkillTry;

	public Del_Void_Bool Evt_EnableDrawSkillArea;

	public Del_Void_Int Evt_SkillPrototypeKeyBinding;

	public Del_Void_Float Evt_UpdateCastingProgress;

	public Del_Void_Bool Evt_ToggleCastingProgressVisibility;

	public Del_Void_Bool Evt_OnAIRealJump;

	public Del_SkillDrag Evt_SkillDrag;

	public Del_SkillDragByRealDirection Evt_SkillDragByRealDirection;

	public Del_Void_Bool Evt_SkillDragWillCancel;

	public Del_Void Evt_SkillDragForceCancelled;

	public Del_Void Evt_HideAttackRange;

	public Del_Void_Int Evt_ShowAttackRange;

	public Del_Void Evt_ResetSkillSelectHelper;

	public Del_Void Evt_AIJumpEnd;

	public Del_Void Evt_PlaySequenceAnyway;

	public Del_Void_Int Evt_ProceduralMapLoaded;

	public Del_Void_Int Evt_ProceduralSpawnWave;

	public Del_Void Evt_ProceduralSpawnItem;

	public Del_QuerySpawnClass Evt_QuerySpawnClass = delegate(List<EMobAttackType> AttackTypes, in int WaveIndex, in int MinNum, in int MaxNum, FVector SpawnerLoc, out Dictionary<TSubclassOf<BGUCharacterCS>, int> OutSpawnClassNum)
	{
		OutSpawnClassNum = new Dictionary<TSubclassOf<BGUCharacterCS>, int>();
	};

	public Del_Void_ActorVector Evt_QueryEliteConversion;

	public Del_AttemptApplyDAEffect Evt_AttemptApplyDAEffect;

	public Del_OnSkillMappingStart Evt_OnSkillMappingStart;

	public Del_InputTouch Evt_InputTouchPress;

	public Del_InputTouch Evt_InputTouchRelease;

	public Del_InputTouch Evt_InputTouchRepeat;

	public Del_Void_FloatFloat Evt_InputTouchAxis;

	public Del_Void Evt_InputBMAttackPress;

	public Del_Void Evt_InputBMAttactRelease;

	public Del_SetEQSTarget Evt_SetEQSTarget;

	public Del_Void_Int Evt_SetMaxComboNum;

	public Del_Void_Int Evt_SetCurComboLength;

	public Del_Void_Float Evt_SetWatchTime;

	public Del_Void_Float Evt_SetLastAttackTime;

	public Del_Void_Float Evt_SetBeHitTime;

	public Del_Void_Actor Evt_SetLastAttackerID;

	public Del_Void_Float Evt_SetLastAtkDmgTime;

	public Del_Void_Bool Evt_ForceEnterStalemate;

	public Del_Void Evt_TriggerUltimatePanel;

	public Del_SwitchAnotherHero Evt_OnSwitchAnotherHero;

	public Del_Void Evt_ResetTeamID;

	public Del_OnGenerateSkillFeature Evt_OnGenerateSkillFeature;

	public Del_OnInitThink Evt_OnInitThink;

	public Del_Void Evt_OnActiveCurThink;

	public Del_Void Evt_OnExitActiveThink;

	public Del_Void Evt_OnExitThink;

	public Del_OnCreateRequest Evt_OnCreateRequest;

	public Del_OnExecuteBaseAction Evt_OnExecuteBaseAction;

	public Del_OnBasicActionFinish Evt_OnBasicActionFinish;

	public Del_OnBasicActionFailed Evt_OnBasicActionFailed;

	public Del_Void Evt_OnBasicActionAborted;

	public Del_OnActionExeFinish Evt_OnActionExeFinish;

	public Del_OnThinkFinish Evt_OnThinkFinish;

	public Del_RegisterAIElem Evt_RegisterAIElem;

	public Del_Void_Float Evt_SetObstacleCheckResult;

	public Del_Void_Vector Evt_SetEscapeLocation;

	public Del_Void_EscapeWay Evt_EscapeWayChanged;

	public Del_ExecuteMandatoryTask Evt_ExecuteMandatoryTask;

	public Del_SweepCheckInPreciseDodgeRange Evt_SweepCheckInPreciseDodgeRange;

	public Del_Void_Int Evt_SetPreciseDodgeAwardLevel;

	public Del_Void Evt_ResetPreciseDodgeAwardCount;

	public Del_TriggerRollSkill Evt_BeginPreciseDodge;

	public Del_Void_VectorList Evt_OnRecordLandingPoints;

	public Del_Void_VectorList Evt_OnAddAvailableLandingPoints;

	public Del_Void_VectorList Evt_OnRemoveAvailableLandingPoints;

	public Del_QueryConditionWithId Evt_OnTryCatchLandingPoint;

	public Del_Void Evt_OnPostLanding;

	public Del_Void_String Evt_OnSwitchComboGraph;

	public Del_Void_GameplayTag Evt_TriggerFsmEvent;

	public Del_Void_FsmEvent Evt_FSMEventTrigger;

	public Del_Void_Bool Evt_OnCharacterPhysicSimulateStateChanged;

	public Del_CopyAttr Evt_RequestCopyAttrFromSnapshot;

	public Del_MarkAsServant Evt_MarkAsServant;

	public Del_Void Evt_ActionLightAttackStartMultiCast;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Client)]
	public Del_Void_IntAActor Evt_ClientRPCTest;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server)]
	public Del_Void_IntVector Evt_ServerRPCTest;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_Void_IntVector Evt_ServerInternalRPCTest;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientInternal)]
	public Del_CastSkillWithAnimMontage Evt_ClientInternalInternalRPCTest;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_CastSkillWithAnimMontage Evt_ClientMultiCastRPCTest1;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, SPServerTransmit = true, Predictable = true)]
	public Del_CastSkillWithAnimMontage Evt_ClientMultiCastRPCTest2;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true)]
	public Del_Void Evt_TestPredict;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_BattleLogicChangeEquip Evt_BattleLogicChangeEquip;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_BattleLogicChangeEquipIllusion Evt_BattleLogicChangeEquipIllusion;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_BattleLogicResetEquipIllusion;

	[UINeedEvent]
	public Del_Void_Int Evt_SnapShotRecoverSkillCD;

	public Del_CollectAllRelatedActorForReplicated Evt_CollectAllRelatedActorForReplicated;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_StartSkillCD Evt_StartSkillCD;

	public Del_Camera_EnableGuiBeiCamera Evt_Camera_EnableGuiBeiCamera;

	public Del_Void Evt_Camera_DisableGuiBeiCamera;

	public Del_Void_Float Evt_Camera_SetCloudMoveCameraPitchLimit;

	public Del_Void_Bool Evt_Camera_SetCloudMoveCameraPitchLimitEnabled;

	public Del_BuffUpdated Evt_BuffUpdated;

	public Del_UnitStateUpdated Evt_UnitStateUpdated;

	public Del_UnitSimpleStateUpdated Evt_UnitSimpleStateUpdated;

	public Del_Void Evt_UnitCastFaBaoSkill;

	public Del_Void Evt_UnitCastFaBaoSkillSucceed;

	public Del_Void Evt_TryInterruptFaBaoCasting;

	public Del_Void Evt_ResetUnitFaBaoState;

	public Del_Void_Int Evt_OnUseFaBaoSuccess;

	public Del_Void_Bool Evt_UnitSetEnablePreciseDodge;

	public Del_Void Evt_ResetPreciseCompRelativeScale;

	public Del_Void_Vector Evt_SetPreciseCompRelativeScale;

	public Del_RequestSetEnableHitMoveCollision Evt_RequestSetEnableHitMoveCollision;

	public Del_PopRequestSetEnableHitMoveCollision Evt_PopRequestSetEnableHitMoveCollision;

	public Del_SetHitMoveIgnoreActor Evt_SetHitMoveIgnoreActor;

	public Del_ResetHitMoveCollisionInfo Evt_ResetHitMoveCollisionInfo;

	public Del_TriggerAtkRebounding Evt_TriggerAtkRebounding;

	public Del_TriggerAtkReboundingSuccess Evt_TriggerAtkReboundingSuccess;

	public Del_SetTrainDummyInfo Evt_SetTrainDummyInfo;

	public Del_TriggerJumpToPosition Evt_TriggerJumpToPosition;

	public Del_RequestSmartCastSkill Evt_RequestSmartCastSkill;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnSkillIsComboSkillChanged;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnRollSkillEnabledChanged;

	public Del_PassiveSkill1IDFloatParamChanged Evt_OnChargeSkillChargeLevelConfigIndexChanged;

	public Del_DestroyDestructible Evt_DestroyDestructible;

	public Del_ModifyDestructible Evt_ModifyDestructible;

	public Del_SetGroupPatrolLeader Evt_SetGroupPatrolLeader;

	public Del_SetGroupPatrolMember Evt_SetGroupPatrolMember;

	public Del_OnGroupPatrolMoveComplete Evt_OnGroupPatrolMoveComplete;

	public Del_Void Evt_GroupPatrolContinue;

	public Del_SetUnitBattleBGM Evt_SetUnitBattleBGM;

	public Del_AddAllSummonLifeTime Evt_AddAllSummonLifeTime;

	public Del_Bool Evt_SetImmuneHardMoveAll;

	public Del_Bool Evt_SetImmuneHardMoveFrozen;

	public Del_Bool Evt_SetImmuneHardMoveMuddy;

	public Del_Bool Evt_SetImmuneHardMoveWindy;

	public Del_Bool Evt_SetImmuneHardMoveSpiderSilk;

	public Del_SetSuperArmorLevelMapping Evt_SetSuperArmorLevelMapping;

	public Del_RemoveSuperArmorLevelMapping Evt_RemoveSuperArmorLevelMapping;

	public Del_Void_IntBool Evt_SetLockPartHP;

	public Del_Void_Bool Evt_SetLockAllPartHP;

	public Del_Void Evt_GateStateMachineOpen;

	public Del_Void Evt_GateStateMachineClose;

	public Del_Void Evt_GateStateMachineResetToOpen;

	public Del_Void Evt_GateStateMachineResetToClose;

	public Del_Void_Bool Evt_SetUnitWakeUpEnabled;

	public Del_Void_Int Evt_CastOnFightSkillSuccess;

	public Del_TriggerComboWindow Evt_TriggerComboWindow;

	public Del_Void_Bool Evt_SetBGUActorActive;

	public Del_SetNpcGuideSplineMoveInfo Evt_SetNpcGuideSplineMoveInfo;

	public Del_AISpiderMoveTo Evt_AISpiderMoveTo;

	public Del_SetMoveModeActive Evt_SetMoveModeActive;

	public Del_Void_Bool Evt_SetUnmovable;

	public Del_Void_Bool Evt_SetHitMoveUnmovable;

	public Del_Void Evt_CheckUnmovable;

	public Del_SwitchMoveAIType Evt_SwitchMoveAIType;

	public Del_AIChangeCrowdParam Evt_AIChangeCrowdParam;

	public Del_Void Evt_AIResetCrowdParam;

	public Del_SetIsEnableCollisionHitMove Evt_SetIsEnableCollisionHitMove;

	public Del_ResetIsEnableCollisionHitMove Evt_ResetIsEnableCollisionHitMove;

	public Del_Void_Bool Evt_SetCloudMoveEnabled;

	public Del_Void_Bool Evt_SetCloudMoveEnabledSafety;

	public Del_Void_Bool Evt_SetForbidEnableCloudMove;

	public Del_Void_Bool Evt_SetForbidDisableCloudMove;

	public Del_Void_Bool Evt_InputSwitchCloudMoveFreeLook;

	public Del_Void_Bool Evt_InputCloudMoveLift;

	[UINeedEvent]
	public Del_Void Evt_ToggleCloudMove;

	public Del_Void_Int Evt_BreakCloudMove;

	public Del_SetAutoCloudMove Evt_SetAutoCloudMove;

	public Del_Void_FVector Evt_Camera_EnableAutoMoveTrail;

	public Del_Void Evt_Camera_DisableAutoMoveTrail;

	public Del_PostCloudMoveAkEvent Evt_PostCloudMoveAkEvent;

	public Del_Void_Bool Evt_SetEnableVigourDropManually;

	public Del_SetPursuitRange Evt_SetPursuitRange;

	public Del_Void_Float Evt_DrawAxisX;

	public Del_Void_Float Evt_DrawAxisY;

	public Del_MovementRotateToPos Evt_X2InputRotateToPos;

	public Del_Void Evt_EnterMultiKillState;

	public Del_Void Evt_RefreshMultiKillState;

	public Del_MultiKill Evt_RefreshMultiKillStateSuccess;

	public Del_Void_Int Evt_MultiKillOneUnit;

	public Del_Void_IntBool Evt_EnterHintInteractiveArea;

	public Del_SetMovementInput Evt_SetMovementInput;

	[UINeedEvent]
	public Del_Void_Bool Evt_IsCtrlPlayer;

	public Del_ReSetMultiKillData Evt_ReSetMultiKillData;

	public Del_Void_Int Evt_CurSkillEnd;

	public Del_Void_Int Evt_SwitchHeroSetInteract;

	public Del_Void Evt_SetProjectileLifeTimerByCharge;

	public Del_ProjectileFeatureInfo Evt_SetProjectileChargeData;

	public Del_Void Evt_ChargeFailedRelease;

	public Del_Void Evt_WeaponTmpAttrChange;

	public Del_Void_Int Evt_WeaponDmgPercentage;

	public Del_Void_Int Evt_GMSwitchWeapon;

	public Del_Void Evt_WeaponSwitchCheck;

	public Del_Void Evt_GMGetAllRougelikeFeature;

	public Del_Void_IntInt Evt_TriggerNormalDamageFeature;

	public Del_Void_IntFloatFloat Evt_TriggerFeatureBeAttacked;

	public Del_NotifyrTriggerBuffSuccess Evt_TriggerBuffSuccess;

	public Del_Void_Int Evt_GMGetOneRougelikeFeature;

	public Del_Void_Int Evt_AddOneRougelikeFeature;

	public Del_Void Evt_ClearAllRougelikeFeature;

	public Del_Void_Float Evt_SetTimeRateBase;

	public Del_NotifySpawnOneNiagara Evt_NotifySpawnOneNiagara;

	public Del_UserTriggerDoor Evt_UserTriggerDoor;

	public Del_SetReCoverPart Evt_SetReCoverPart;

	public Del_Void Evt_DamageCritical;

	public Del_IncreaseAttrFloatTemp Evt_IncreaseAttrFloatTemp;

	public Del_Void Evt_CastSideRollSkill;

	public Del_Void Evt_LightAttackReleaseCache;

	public Del_Void Evt_UnparalleledSkillTrigger;

	public Del_Void Evt_UnparalleledSkillEnd;

	public Del_SwitchHeroByUnparalleled Evt_SwitchHeroByUnparalleled;

	public Del_Void Evt_TriggerPerfectRollFeature;

	public Del_Void_Int Evt_TriggerBeBreakFeature;

	public Del_NotifyrTriggerBuffWhenElementAttacked Evt_NotifyrTriggerBuffWhenElementAttacked;

	public Del_Void_Int Evt_SetSweepCheckIgnoreData;

	public Del_Void_BoolInt Evt_ReSetShieldPartState;

	public Del_Void Evt_ReSetABPSettingByShieldPart;

	public Del_SetProjectileEQSTarget Evt_SetProjectileEQSTarget;

	public Del_ProjectileSkillTarget Evt_SetProjectileSkillTarget;

	public Del_Void ReSetSkillTarget;

	public Del_Void_Vector Evt_SetProjectileSkillBasePos;

	public Del_Void Evt_GMSetUnparalleledMax;

	public Del_Void Evt_GMTestSweepCheck;

	public Del_BulletAttachTarget Evt_BulletAttachTarget;

	public Del_Void Evt_OnBulletAttachStopMove;

	public Del_Void_Float Evt_X2ComboWindowStart;

	public Del_StartChargeCanRota Evt_StartChargeCanRota;

	public Del_Void Evt_HeavyAttackReleaseCache;

	public Del_Void Evt_UnparalleledFreedomTrigger;

	public Del_Void_Int Evt_SetAlternativeSkillIndex;

	public Del_Void_Float Evt_ComboWindowProtect;

	public Del_Void_FloatFloat Evt_TriggerChargeSkill;

	public Del_Void_Bool Evt_SetPerfectChargeState;

	public Del_Void_Bool Evt_TriggerChargeKeyCache;

	public Del_Void_Int Evt_TriggerInputSelectingSkill;

	public Del_Void_ActorIntFloat Evt_CalculateTargetHatredValueByDamage;

	public Del_TriggerBeTaunted Evt_TriggerBeTaunted;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	[UINeedEvent]
	public Del_Void_Actor Evt_TriggerFallDying;

	[UINeedEvent]
	public Del_Void Evt_TriggerFallDyingToUI;

	public Del_Void Evt_FallDyingSaveSelf;

	public Del_Void_Actor Evt_FallDyingBeSaved;

	public Del_Bool Evt_EndSaveFallDying;

	public Del_Void_Int Evt_TriggerUseItem;

	public Del_Void Evt_TriggerCostItem;

	public Del_Void Evt_OnUseItemSuccess;

	public Del_Void Evt_TriggerHuluEffect;

	public Del_Void Evt_OnTriggerHuluEffectSuccess;

	public Del_TriggerCostItemSvr Evt_TriggerCostItemSvr;

	public Del_Void_IntInt Evt_TriggerSetShortCutItem;

	public Del_Void_Int Evt_TriggerWinePartner;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server, Reliable = true)]
	public Del_Actor Evt_FinishRescueInteract;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Actor Evt_FinishRescue;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_Actor_Bool Evt_FinishRescueServer;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_TriggerEndSave Evt_TriggerEndSave;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Int Evt_SkillRotate;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_Float Evt_RotateToTargetSvr;

	[UINeedEvent]
	public Del_Void_ActorActor Evt_TriggerBeSaving;

	[UINeedEvent]
	public Del_Void_ActorActor Evt_TriggerBreakBeSaving;

	[UINeedEvent]
	public Del_Void_ActorActor Evt_TriggerFinishBeSaving;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_TriggerPlayerRest Evt_TriggerPlayerRest;

	public Del_Void Evt_TriggerPlayerRestByReBirth;

	public Del_TriggerPlayerClearBattleState Evt_TriggerPlayerClearBattleState;

	public Del_Void Evt_TriggerPlayerRestToSvr;

	public Del_Void_Actor Evt_InteractCollection;

	public Del_Void_Actor Evt_InteractTaskCollection;

	[UINeedEvent]
	public Del_Void_Actor Evt_PlayerCollectedV2;

	public Del_Void_Int Evt_SetCollectionGroupId;

	public Del_Void_BoolBool Evt_SetRebirthPointActiveState;

	public Del_Void Evt_RefreshHatredInfo;

	public Del_OnlineUnitStateDebugInfo Evt_OnlineUnitStateDebugInfo;

	public Del_Void Evt_GMInitAttrByMaxAttr;

	public Del_Void_Int Evt_SwitchSpellSolution;

	public Del_GMLoadSnapshotAttr Evt_GMLoadSnapshotAttr;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_NotifyGraphClient Evt_NotifyGraphClient;

	[UINeedEvent]
	public Del_Void_Bool Evt_TriggerShowUnitPartUI;

	[UINeedEvent]
	public Del_Void_Bool Evt_PartUIValueChange;

	[UINeedEvent]
	public Del_Void_Float Evt_GM_SwitchHideUILockPoint;

	public Del_Void_IntFloat Evt_ReCoverLastSkillCastTime;

	public Del_ReCoverFaBaoSkillCDDict Evt_ReCoverFaBaoSkillCDDict;

	public Del_Void_Actor Evt_HitCollectionActor;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_Int Evt_ChargeSkillSuccess;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_RelieveImmobilizedClient;

	public Del_Void_Actor Evt_SetCollectionMaster;

	[UINeedEvent]
	public Del_Void_Int Evt_SwitchWeaponPoseByType;

	public Del_Void_String Evt_CreateNewPlayerForPartyRoom;

	[UINeedEvent]
	public Del_Void_RepPlayerLoc Evt_RepPlayerLoc;

	public Del_Void_String Evt_BindMemberId;

	public Del_Void Evt_ExitParty;

	public Del_Void_String Evt_RoomMemberExit;

	public Del_Void Evt_GMRecordRebirthPos;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	[UINeedEvent]
	public Del_Void_IntInt Evt_OnlineChallengeBeginToUI;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	[UINeedEvent]
	public Del_Void_Int Evt_OnlineChallengeEndToUI;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_IntInt Evt_OnlineChallengeBegin;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_String Evt_ChallenegeRebirthTeleport;

	public Del_GMRecordRebirthPosWithDetailData Evt_GMRecordRebirthPosWithDetailData;

	[UINeedEvent]
	public Del_UIShowMapTips Evt_UI_ShowMapTips;

	public Del_Void Evt_CheckFallDyingState;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_DropCollectionItem Evt_DropCollectionItem;

	public Del_Void Evt_PostLoginBindData;

	public Del_Void_Actor Evt_PostTransBindData;

	public Del_Void_Float Evt_GMSetFullEnergy;

	public Del_Void_Int Evt_SetEnergyInfo;

	public Del_Void_Float Evt_CostTransEnergyBySkill;

	public Del_Void Evt_UpdatePlayerBindData;

	public Del_Void Evt_TriggerTeleportResetPlayer;

	public Del_TransBeginSpawnNewOne Evt_TransBeginSpawnNewOne;

	public Del_TransBackSpawnNewOne Evt_TransBackSpawnNewOne;

	public Del_Void_Actor Evt_SetTaskCollectiontSpawner;

	public Del_Void Evt_TaskCollectiontSpawnerDestory;

	public Del_Void Evt_TaskCollectiontDestoryForever;

	public Del_Void_Int Evt_TaskCollectionInteracted;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_BattleLogicChangeEquip Evt_InitDaShenEquipData;

	public Del_GSItemTeleportTrigger Evt_GSItemTeleportTrigger;

	public Del_Void Evt_GSItemTeleportTriggerPrepare;

	public Del_Void_Int Evt_AddSpellItem;

	public Del_Void Evt_PlayerRebirthAddBuff;

	public Del_TriggerPlayerTranDmg Evt_TriggerPlayerTranDmg;

	public Del_Void Evt_PEValueFull;

	public Del_Void Evt_AddDetonate;

	public Del_Void Evt_RemoveDetonate;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Reliable = true)]
	public Del_Void_StringList Evt_ExecuteCommandGM;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void Evt_GMUnitSuicide;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_SetActorLocation Evt_SetActorLocationGM;

	public Del_Void_Bool Evt_PauseOrResumeAK;

	public Del_Void Evt_UpdateLoginData;

	public Del_Void Evt_UpdateLogoutData;

	public Del_OSSBattle Evt_UpdateOSSAttackData;

	public Del_OSSBattle Evt_UpdateOSSDefenceData;

	public Del_Void Evt_SwitchPlayerTransStateFinish;

	public Del_Void_Float Evt_TransferDamage;

	public Del_Void_ActorFloat Evt_BeHurt;

	public Del_CurveList Evt_CameraTriggerBox;

	public Del_CurveList Evt_CameraEndTriggerBox;

	public Del_Void_IntAActor Evt_EnableTransUnitPhysicsAssetWithImpulse;

	public Del_CurveFloat Evt_TriggetActorDown;

	public Del_Vector_Float Evt_AddImpulse;

	public Del_Void_Bool Evt_InputMoving;

	public Del_Void Evt_TriggerTrialRoom;

	public Del_Void_IntBool Evt_ActiveUIByID;

	public Del_Void_Int Evt_PressKeyInteract;

	public Del_Void_Int Evt_ReleaseKeyInteract;

	public Del_Void_Int Evt_SpawnUnitByTrigger;

	public Del_Void_Actor Evt_TaskTrigger;

	public Del_Void_Int Evt_InteractTaskTrigger;

	[UINeedEvent]
	public Del_Void_Int Evt_TaskByIDTrigger;

	public Del_Void_Bool Evt_SeqCameraBlendTrigger;

	public Del_Bool_FKey Evt_AnyKeyInput;

	public Del_Void_Int Evt_ChangeCameraIdx;

	public Del_Void_Int Evt_TriggerShop;

	public Del_Void_Int Evt_TriggerBlessing;

	public Del_Void_Int Evt_TriggerRecorveHP;

	public Del_Void_Actor Evt_ActiveRoguelikeRoom;

	public Del_SceneItemSurfaceType Evt_TriggerSurfaceType;

	public Del_Void Evt_BattleEnd;

	public Del_Void_Int Evt_TaskFlagTrigger;

	public Del_Void Evt_ActiveAllUITrigger;

	public Del_Void_Bool Evt_UnparalleledValueAddPause;

	public Del_Void Evt_ShowGMUITrigger;

	public Del_Void_Bool Evt_PauseScreenEffect;

	public Del_Void_Bool Evt_EnableInteract;

	[UINeedEvent]
	public Del_Void Evt_RebornInNearestRebirthPoint;

	[UINeedEvent]
	public Del_Void_BoolBoolInt Evt_InputSwitchHero;

	public Del_Void Evt_HideOldUI;

	[UINeedEvent]
	public Del_EnterInteractActiveArea Evt_EnterActiveArea;

	[UINeedEvent]
	public Del_EnterInteractActiveArea Evt_LeaveActiveArea;

	public Del_Void Evt_ReleaseInteractInput;

	[UINeedEvent]
	public Del_Void_Int Evt_EnterUninteractiveArea;

	[UINeedEvent]
	public Del_Void_Actor Evt_OpenToolNpcUI;

	[UINeedEvent]
	public Del_Void_Bool Evt_ActiveTPSReticle;

	[UINeedEvent]
	public Del_Void_Actor Evt_PlayerBeInteractInput;

	[UINeedEvent]
	public Del_Void_Actor Evt_PlayerBreakInteractInput;

	[UINeedEvent]
	public Del_Void_Actor Evt_PlayerFinishInteractInput;

	[UINeedEvent]
	public Del_Void_StringList Evt_TriggerInputCombie;

	[UINeedEvent]
	public Del_Void_StringList Evt_UnTriggerRealease;

	[UINeedEvent]
	public Del_Void_Int Evt_SwitchDefaultItem;

	[UINeedEvent]
	public Del_Void_Int Evt_SwitchDefaultSpell;

	[UINeedEvent]
	public Del_Void_Int Evt_TriggerUseDefaultShortcutItem;

	[UINeedEvent]
	public Del_Void_Int Evt_TriggerUseDefaultShortcutSpell;

	[UINeedEvent]
	public Del_Void_Bool Evt_ActiveNoSeqUI;

	[UINeedEvent]
	public Del_Void_FText Evt_TriggerInteactItemLack;

	[UINeedEvent]
	public Del_Void Evt_SwitchWeaponPose;

	[UINeedEvent]
	public Del_Void Evt_StartInteract;

	public Del_Void Evt_UnitRebirthFinished;

	public Del_TrySwitchCameraLockTarget Evt_TrySwitchCameraLockTarget;

	public Del_ScreenDebugDraw Evt_ScreenDebugDraw;

	public Del_Void Evt_ResetScreenDebugDraw;

	[UINeedEvent]
	public Del_Void Evt_FinishMedicineTalkAnim;

	public Del_Void Evt_TestEventCollection;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_TestEventCollectionMultiCast;

	public Del_Void_Int Evt_TestEventCollectionInt;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Int Evt_TestEventCollectionIntMultiCast;

	public Del_Void_Float Evt_TestEventCollectionFloat;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Float Evt_TestEventCollectionFloatMultiCast;

	public Del_Void_String Evt_TestEventCollectionString;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_String Evt_TestEventCollectionStringMultiCast;

	public Del_Void_ActorTest Evt_TestEventCollectionActor;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_ActorTest Evt_TestEventCollectionActorMultiCast;

	public Del_Void_UObject Evt_TestEventCollectionObject;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_UObject Evt_TestEventCollectionObjectMultiCast;

	public Del_Void_FVectorTest Evt_TestEventCollectionVector;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_FVectorTest Evt_TestEventCollectionVectorMultiCast;

	public Del_Void_FName Evt_TestEventCollectionName;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_FName Evt_TestEventCollectionNameMultiCast;

	public Del_Void Evt_AddToLock;

	public Del_Bool Evt_RemoveFromLock;

	public Del_Void Evt_UpdateLockBlood;

	public Del_ChangeBar Evt_ShowBar;

	public Del_ChangeBar Evt_HideBar;

	public Del_DisplayDamageNumUIV2 Evt_DisplayDamageNumUIV2;

	public Del_Void Evt_BreakInteract;

	public Del_Void Evt_SwitchDebugWidgetState;

	public Del_Void_Bool Evt_SetDebugWidgetState;

	public Del_UpdateDebugUIKeyValuePair Evt_UpdateDebugUIKeyValuePair;

	public Del_UpdateDebugUILog Evt_UpdateDebugUILog;

	public Del_UpdateDebugUILog Evt_UpdateDebugUITitle;

	public Del_UpdateDebugUIInfo Evt_UpdateDebugUIInfo;

	public Del_HideDebugUIInfo Evt_HideDebugUIInfo;

	public Del_UpdateDebugUILamp Evt_UpdateDebugUILamp;

	public Del_UpdateDebugUIProg Evt_UpdateDebugUIProg;

	public Del_SyncPlayerNameTmp Evt_SyncPlayerNameTmp;

	public Del_Void Evt_OnRep_PlayerState;

	public Del_OnPossessed Evt_OnPossessed;

	public Del_Void Evt_OnPickDropItem;

	public Del_ScaleWeaponByCurve Evt_ScaleDropItemByCurve;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server)]
	public Del_Void Evt_OnClientBeginPlayReqForInitEquip;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_UpdateInteractGroup Evt_InteractGroup_Update;

	public Del_UpdateInteractState Evt_InteractState_Update;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Actor Evt_TriggrtInteractOnOtherClient;

	public Del_Void_Int Evt_InteractGroup_Reset;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void_Bool Evt_SwitchNoInteraction;

	public Del_Void_Bool Evt_SwitchNoInteraction_Local;

	public Del_Void_IntInt Evt_InteractGroup_Complete;

	public Del_Void_Bool Evt_UpdateInteractable;

	public Del_Actor Evt_TriggerAiInteract;

	public Del_Actor Evt_AiComeCloseToInteractActor;

	public Del_Actor Evt_AiFinishComeCloseToInteractActor;

	public Del_Void_Bool Evt_RequestAudioEmitter;

	public Del_Void_Bool Evt_SwitchJJSObstacleState;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_Void Evt_TriggerResetAllActors;

	public Del_Void Evt_CircusRootDead;

	public Del_Void_Int Evt_HitJJSObstacle;

	public Del_SetAttackIKTargetActor Evt_SetAttackIKTargetActor;

	public Del_SetAttackIKAlpha Evt_SetAttackIKAlpha;

	public Del_SetAttackIKFishSpike Evt_SetAttackIKFishSpike;

	public Del_SetAttackIKFishSpikeAlpha Evt_SetAttackIKFishSpikeAlpha;

	public Del_DisableTargetAttackIK Evt_DisableTargetAttackIK;

	public Del_SetAttackIKBoneScale Evt_SetAttackIKBoneScale;

	public Del_SetAttackIKBoneScaleAlpha Evt_SetAttackIKBoneScaleAlpha;

	public Del_CastIronBody Evt_CastIronBody;

	public Del_Void Evt_IronBodyStart;

	public Del_Void_Actor Evt_OnWeaponSceneItemBeAttached;

	public Del_Void Evt_OnRemoveIronBodyStartBuff;

	public Del_FilterBuffAndSkillEffect Evt_FilterBuffAdd;

	public Del_FilterBuffAndSkillEffect Evt_FilterBuffRemove;

	public Del_FilterBuffAndSkillEffect Evt_FilterSkillEffectAdd;

	public Del_FilterBuffAndSkillEffect Evt_FilterSkillEffectRemove;

	public Del_Void Evt_OnSwitchBullet_Pre;

	public Del_Void Evt_NotifyBuffTrigger;

	public Del_SimpleOverlapActorsByMask Evt_GetSimpleOverlapActorsByMask;

	public Del_Void_Int Evt_SetOnFightSkillID;

	public Del_BulletHitInfo Evt_UnitBeHittedCountDic;

	public Del_Actor Evt_UpdateHittedInfo;

	public Del_Void_Int Evt_SetMultiTargetProjectileHitCount;

	public Del_Int_Void Evt_GetMultiTargetProjectileHitCount;

	public Del_Actor_Bool Evt_OperatorProjectileMultiTarget;

	public Del_Actor Evt_OneMultiTargetProjectileSpawned;

	public Del_Void Evt_UpdataTargetList;

	public Del_Void_ActorString Evt_SwitchMovementTarget;

	public Del_SwitchBulletTarget Evt_SwitchBulletTarget;

	public Del_Actor Evt_NotifyMasterProjectileSpawned;

	public Del_NotfiyProjectileHitInfo Evt_NotifyMasterProjectileHitted;

	public Del_Void_ActorInt Evt_NotifyMasterProjectileSwitchFinished;

	public Del_Void_Int Evt_SetInertialState;

	public Del_ObjMoveMode Evt_SetObjMoveMode;

	public Del_Actor Evt_BulletMissTarget;

	public Del_PlayMontageCallback Evt_PlayMontageCallback;

	public Del_Void_IntFloat Evt_UIPartIDChanged;

	public Del_Bool_Void Evt_ShowEliteBar;

	public Del_Bool_Void Evt_ShowBossBar;

	public Del_AIPerceptionConfig Evt_SetAIPerceptionConfig;

	public Del_Void_Float Evt_SetCurFlySpeedRate;

	public Del_Void_Int Evt_Detonate;

	public Del_AttachNiagaraByEventType Evt_AttachNiagaraByEventType;

	public Del_AttachNiagaraByEventTypeAndLocation Evt_AttachNiagaraByEventTypeAndLocation;

	public Del_DestroyNiagaraByEventType Evt_DestroyNiagaraByEventType;

	public Del_DestroyNiagaraByEventType Evt_DestroyAllNiagaraByEventType;

	public Del_DestroyNiagaraByEventType Evt_ResetAllInstByEventType;

	public Del_Void Evt_StopModControlleredNiagaraParam;

	public Del_Void Evt_TriggerPreciseDodgeSuccess;

	public Del_DestructionDropFail Evt_BGS_DestructionDropFail;

	[UINeedEvent]
	public Del_Void_Bool Evt_HoldingQTEInteract;

	public Del_Void Evt_OnInteractTriggerEcho;

	public Del_Void_Bool Evt_OnEchoPlaybackEnd;

	[UINeedEvent]
	public Del_Void Evt_FinishSeedSubmitAnim;

	public Del_Void_Actor Evt_StopInteractTargetIdleFX;

	public Del_Void Evt_ClearCameraLock;

	public Del_CameraLockTarget Evt_CameraLockTarget;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_Float Evt_StopSlotAnimation;

	public Del_Void_Bool Evt_SetPressedSprinting;

	public Del_Void Evt_CameraLockCleared;

	public Del_Void Evt_RelieveImmobilized;

	public Del_Void Evt_EnterDingShen;

	public Del_Void Evt_LeaveDingShen;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Local)]
	public Del_InputCastSkill Evt_InputCastSkill;

	public Del_Void_Int Evt_TriggerVigorSkill;

	public Del_Void_IntList Evt_SetVigorSkillWhiteList;

	public Del_Void_IntList Evt_SetItemSkillWhiteList;

	public Del_EnterInputKeyCacheWindow Evt_InputKeyCacheStart;

	public Del_Void Evt_DestroyAllSummons;

	public Del_Void_Int Evt_DestroySummonsByID;

	public Del_SetSummonBehaviorState Evt_SetSummonBehaviorState;

	public Del_SetSummonStateBehaviorTree Evt_SetSummonStateBehaviorTree;

	public Del_Void_Int Evt_CallSummonUseSkill;

	public Del_Void Evt_SummonBehaviorUseSkill;

	public Del_Void Evt_ResetMeleeAutoLockConfig;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_UnitCastSkillTry Evt_UnitCastSkillTry;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true)]
	public Del_UnitCastSkillTry Evt_UnitCastSkillTryCMultiCast;

	public Del_AttackFeedback Evt_AttackFeedback;

	public Del_Void Evt_DeathAnimPlayFinished;

	public Del_ProjectileInitialization Evt_ProjectileInitialization;

	public Del_CastSwitchBullet Evt_CastControllBullet;

	public Del_CastProjectileLifeOver Evt_CastProjectileLifeOver;

	public Del_CastBulletAuto Evt_CastBulletAuto;

	public Del_OnSwitchOneProjectile Evt_OnSwitchOneProjectile;

	public Del_Void Evt_DestroyAllCtrableBullet;

	public Del_DestroyProjectileByID Evt_DestroyProjectileByID;

	public Del_DestroyProjectile_ExceptID Evt_DestroyProjectile_ExceptID;

	public Del_BulletSimpleCreator Evt_BulletsSimpleCreator;

	public Del_Void_IntActor Evt_AddToPassiveQuene;

	public Del_Void_Int Evt_CheckProjectileNumLimit;

	public Del_Void_Actor Evt_AddCtrableBulletToPack;

	public Del_Void_Actor Evt_RemoveCtrableBulletFromPack;

	public Del_ProjectileMoveBackorOutNest Evt_ProjectileMoveBackorOutNest;

	public Del_ProjectileGetSlotNameToBack Evt_ProjectileGetSlotNameToBack = (string _003Cp0_003E) => FName.None;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_OnBulletDead Evt_OnProjectileDead;

	public Del_ProjectileAttachToTarget Evt_ProjectileAttachToTarget;

	public Del_Void Evt_ProjectileFinishAttach;

	public Del_Void Evt_ProjectileFinishAttachAndDestroyImmediatly;

	public Del_Void_Int Evt_OnProjectileIDChanged;

	public Del_OnBulletSpawnFinished Evt_OnBulletSpawnFinished;

	public Del_Void Evt_OnSwitchBullet_Begin;

	public Del_Void Evt_OnSwitchBullet_Finished;

	public Del_Void_IntInt Evt_SetBulletMatMgrData;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_SpawnBulletFXByReason Evt_SpawnBulletFXByReason;

	public Del_Void Evt_BulletFlyBackEnd;

	public Del_Void_Float Evt_OnSetBulletSpdScale;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true)]
	public Del_TriggerSkillEffectBySkill Evt_TriggerSkillEffectBySkill;

	public Del_TriggerSkillEffectBySkill_WithoutRPC Evt_TriggerSkillEffectBySkill_WithoutRPC;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_TriggerSkillEffectByBuff Evt_TriggerSkillEffectByBuff;

	public Del_TriggerSkillEffect Evt_TriggerSkillEffect;

	public Del_Void Evt_TriggerTrans2DaSheng;

	public Del_Void Evt_TriggerBanTrans2DaSheng;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true, SPServerTransmit = true)]
	public Del_TriggerSkillEffect Evt_TriggerSkillEffect_Transmit;

	public Del_Void_Actor Evt_OnTargetEnterMagicField;

	public Del_Void_Actor Evt_OnTargetLeaveMagicField;

	public Del_Void_Actor Evt_OnTargetExistedWhenMagicFieldBorn;

	public Del_Void_Actor Evt_OnTargetExistedWhenMagicFieldDead;

	public Del_TriggerMagicFieldEffect Evt_TriggerMagicFieldEffect;

	public Del_Void_ActorFieldBuffList Evt_AddFieldBuff2Target;

	public Del_Void_ActorFieldBuffList Evt_RemoveFieldBuff2Target;

	public Del_Void_Actor Evt_AddAvoidanceMagicField;

	public Del_Void_Actor Evt_RemoveAvoidanceMagicField;

	public Del_Void_ResetActorReason Evt_ResetActorStatusPre;

	public Del_Void_ResetActorReason Evt_ResetActorStatus;

	public Del_Void_ResetActorReason Evt_ResetActorStatusAfterAll;

	public Del_Void_Transform Evt_TeleportMoveByTrans;

	public Del_MatchingPositionMove Evt_MatchingPositionMove;

	public Del_InterpolationMove Evt_InterpolationMove;

	[UINeedEvent]
	public Del_Void_Actor Evt_EnterInteractiveArea;

	[UINeedEvent]
	public Del_Void_Actor Evt_LeaveInteractiveArea;

	public Del_Void Evt_InputInteract;

	public Del_Void_Int_Actor Evt_InteractSkipInput;

	public Del_Void_Actor Evt_InteractRebirthPoint;

	public Del_Void Evt_TriggerFinishInteractActionForce;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_Void Evt_ResetSkillCD;

	public Del_Void Evt_StopTracing;

	public Del_Void Evt_OnBackNestOver;

	public Del_Void Evt_OnTraceEndToStraight;

	public Del_AttachToTargetWhenTraceOver Evt_AttachToTargetWhenTraceOver = () => false;

	public Del_Void_Int Evt_SwitchBulletRecoveryMode;

	public Del_SwitchBulletPropertyInfo Evt_SwitchProjectilePropertyInfo;

	public Del_SwitchProjectileStatus Evt_SwitchProjectileStatus;

	public Del_EnableBulletCollision Evt_EnableBulletCollision;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true, SPServerTransmit = true)]
	public Del_TriggerNormalDamageEffect Evt_TriggerNormalDamageEffect;

	public Del_Void_CameraParamType Evt_AddFixedCameraParam;

	public Del_Void_CameraParamType Evt_RemoveFixedCameraParam;

	public Del_Void_Actor Evt_EnterSkillCam;

	public Del_Void_Actor Evt_ExitSkillCam;

	public Del_TryCatchSceneItemByCondition Evt_TryCatchSceneItemByCondition;

	public Del_TryCatchSceneItemByTag Evt_TryCatchSceneItemByTag;

	public Del_TryAttachSceneItem Evt_TryAttachSceneItem;

	public Del_DetachSceneItemAndAttachByProjectileActor Evt_DetachSceneItemAndAttachByProjectileActor;

	public Del_Void Evt_RemoveCatchedSceneItemAndReset;

	public Del_Void Evt_RemoveSceneItemAndDetach;

	public Del_Void_Bool Evt_SetSceneItemCanBeSelected;

	public Del_OverlapSceneItems Evt_OverlapSceneItems = (List<FUStCheckShape> _003Cp0_003E) => (List<AActor>)null;

	public Del_SetSkillPreviewConfig Evt_SetSkillPreviewConfig;

	public Del_Void_Actor Evt_OnSetZangBaBaOwner;

	public Del_OnSendInfoToZBB Evt_OnSendInfoToZBB;

	public Del_SceneItemAddImpulse Evt_SceneItemAddImpulse;

	public Del_Void_Float Evt_SceneItemSetDelayEnableCollTime;

	public Del_SceneItemAttach Evt_SceneItemAttach;

	public Del_ObjectActorSetVelocity Evt_ObjectActorSetVelocity;

	public Del_Void_Vector Evt_ProjectilePendingVelocity;

	public Del_InitObjectMoveProperty Evt_InitObjectMoveInfo;

	public Del_OnSwitchBulletMove Evt_OnSwitchBulletMove;

	public Del_Void Evt_ObjectActorDisablePhysics;

	public Del_SetObjectActorPhysics Evt_SetObjectActorPhysics;

	public Del_Void Evt_ReActiveProjectileTick;

	public Del_InputMove Evt_InputMoveForward;

	public Del_InputMove Evt_InputMoveRight;

	public Del_Void Evt_InputMoveForwardFinish;

	public Del_Void Evt_InputMoveRightFinish;

	public Del_InputMove Evt_InputCameraTurnRight;

	public Del_InputMove Evt_InputCameraLookUp;

	public Del_Void_Rotator Evt_InputRotforMM;

	public Del_Void Evt_ClearComboKeyCache;

	public Del_TriggerChargeSkillNextStageEvent Evt_TriggerChargeSkillNextStageEvent;

	public Del_TriggerRollSkill Evt_TriggerRollSkill;

	public Del_Void Evt_ReStartDodgeCombo;

	public Del_AIPathMoveComplete Evt_AIPathMoveComplete;

	public Del_Void_Int Evt_RotateToTargetComplete;

	public Del_Void Evt_StartPatrolAndLeisure;

	public Del_Void Evt_StopPatrolAndLeisure;

	public Del_Void_ActorVector Evt_NotifyFollowPatrol;

	public Del_Void Evt_ClearHatredList;

	[UINeedEvent]
	public Del_Void Evt_OnLeaveFight;

	public Del_Void Evt_ClearAllTarget;

	[UINeedEvent]
	public Del_Void_Actor Evt_OnEnterFight;

	public Del_Void_FloatFloat Evt_MakeInputPlayer;

	public Del_CharacterModuleChanged Evt_CharacterModuleChanged;

	public Del_RefreshCharacterModuleAttachment Evt_RefreshCharacterModuleAttachment;

	public Del_SetCharacterModuleConstraintProfile Evt_SetCharacterModuleConstraintProfile;

	public Del_BattleLogicChangeEquip Evt_ChangePreviewEquip;

	public Del_AttachEquipCompToSocket Evt_AttachEquipCompToSocket;

	public Del_SetBulletSweepCheckMode Evt_SetBulletSweepCheckMode;

	public Del_BulletTriggerEffectsByReson Evt_BulletTriggerEffectsByReson;

	public Del_Void_IntFloatFloatFloat Evt_ChangeEnvironment;

	public Del_RecoveryEnvironment Evt_RecoveryEnviroment;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_UnitRebirth Evt_UnitRebirth;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast, Reliable = true)]
	public Del_UnitRebirth Evt_UnitRebirth_ByItem;

	[UINeedEvent]
	public Del_UnitRebirth Evt_AfterUnitRebirth;

	public Del_Void Evt_PlayerResetRecoverTalent;

	public Del_Void Evt_PlayerResetRecoverEquipAndSuitTalent;

	public Del_FreezeCostAttr Evt_FreezeCostAttr;

	public Del_Void_Float Evt_OnSetStaminaRecoverMul;

	public Del_Void Evt_OnResetStaminaRecoverMul;

	public Del_SpawnAllNianhuiDropItem Evt_SpawnAllNianhuiDropItem;

	public Del_DisplayDamageNumUI Evt_DisplayDamageNumUI;

	public Del_Void Evt_HiddenBloodBar;

	public Del_Void Evt_ReShowBloodBar;

	public Del_Void_Int Evt_OpenBulletAuto;

	public Del_OnSwitchEnvironment Evt_OnSwitchEnvironment;

	public Del_ReleaseEnvironment Evt_ReleaseEnvironment;

	public Del_Void Evt_ResetAllEnvCtrl;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true)]
	public Del_TriggerJumpSkill Evt_TriggerJumpSkill;

	public Del_Void_Float Evt_TriggerStrideJump;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast, Predictable = true)]
	public Del_Void Evt_TriggerRootMotionJump;

	public Del_Void Evt_RootMotionJumpStart;

	public Del_Void Evt_RootMotionJumpEnd;

	public Del_Void_Bool Evt_OnRealJump;

	public Del_Void Evt_Jump_OnReleased;

	public Del_Void Evt_JumpBreak;

	public Del_Void_Vector Evt_OnJumpStart;

	public Del_Void Evt_OnJumpEnd;

	public Del_Void Evt_OnLeaveLand;

	public Del_SetBT Evt_SetBT;

	public Del_Void_Bool Evt_EnableCanSetBT;

	public Del_Void_Bool Evt_EnableCanSetCBG;

	public Del_Void Evt_TryRunDefaultBT;

	public Del_Void Evt_TryRunDefaultCBG;

	public Del_Void Evt_StopCurrentCBG;

	public Del_Void_Float Evt_UpdateCBG;

	public Del_Void Evt_ResetCBG;

	public Del_Void_Int Evt_TryRunAssignCBGTemplateByID;

	public Del_SetWeaponInfo Evt_SetWeaponInfo;

	public Del_Void_Int Evt_InitPartnerLeaderID;

	public Del_Void_Int Evt_SwitchPartnerLeader;

	public Del_SwitchHero Evt_SwitchHero;

	public Del_UnitRebirth Evt_AllPartnerRebirth;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_TeleportWithRebirthPointCallback Evt_TeleportWithRebirthPointFailed;

	public Del_TeleportWithRebirthPointCallback Evt_TeleportWithRebirthPointStreamingLevelLoaded;

	public Del_Void Evt_TeleportWithCheckPointFailed;

	public Del_Void Evt_TeleportWithCheckPointStreamingLevelLoaded;

	public Del_AttachWeapon Evt_AttachWeapon;

	public Del_DetachWeapon Evt_DetachWeapon;

	public Del_Void_Float Evt_DetachAllWeaponForDead;

	public Del_ChangeWeapon Evt_ChangeWeapon;

	public Del_SetWeaponInfo Evt_AddTempOverrideWeapon;

	public Del_Void Evt_ClearTempOverrideWeapon;

	public Del_OnChangeABP Evt_OnChangeABP;

	public Del_ChangeSkeletalMeshWithABP Evt_ChangeSkeletalMeshWithABP;

	public Del_ChangeAnimMode Evt_ChangeAnimMode;

	public Del_Void_Bool Evt_SetFootIKManualUpdateMode;

	public Del_Void_Vector Evt_ManualUpdateFootIKByZOffset;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_ChangeABPSetting Evt_ChangeABPSetting;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ServerInternal)]
	public Del_Void Evt_ResetABPSetting;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_ChangeMotionMatchingState Evt_ChangeMotionMatchingState;

	public Del_Void_Bool Evt_SetRecordMMAnimData;

	public Del_Void_Bool Evt_SetDisableLocomotionIdle;

	public Del_Void_Bool Evt_SetForceMMToIdle;

	public Del_OnAimToBegin Evt_OnAimToBegin;

	public Del_Void Evt_OnAimToEnd;

	public Del_Void_FloatFloat Evt_SetCarMoveInput;

	public Del_SetTouchIKInfo Evt_SetTouchIKInfo;

	public Del_Void_BoolBool Evt_SetTouchIKActive;

	public Del_Void_Actor Evt_SetTouchIKTargetActor;

	public Del_DoJumpAnim Evt_DoJumpAnim;

	public Del_Void_Float Evt_NotifyStrideJumpHeight;

	public Del_Void_Float Evt_NotifyAnimFallHeight;

	public Del_Void_Float Evt_CheckLittleFall;

	public Del_Void_BoolBool Evt_SetEnableIK;

	public Del_Void_Bool Evt_SetEnableSpineIK;

	public Del_SetPlayerLocomotionLockMoveDirection Evt_SetPlayerLocomotionLockMoveDirection;

	public Del_Void Evt_PlayerLocomotionStartIdle;

	public Del_Void Evt_PlayerLocomotionEnterLockMoveState;

	public Del_SetPlayerLocomotionLockMoveDirection Evt_SetPlayerLocomotionLockTurnStopDirection;

	public Del_Bool Evt_SetPlayerLocomotionInSequenceTransition;

	public Del_SetMonsterLocomotionLockMoveDir Evt_SetMonsterLocomotionLockMoveDir;

	public Del_Void_AnimInstance Evt_MonsterLocomotionLockStopLeft;

	public Del_Void_AnimInstance Evt_MonsterLocomotionLockStopRight;

	public Del_Void_AnimInstance Evt_MonsterLocomotionEnterMoveLoop;

	public Del_SetSpecialMovementMode Evt_SetSpecialMovementMode;

	public Del_SetGlideMoveAnimState Evt_SetGlideMoveAnimState;

	public Del_SetParkourMoveAnimState Evt_SetParkourMoveAnimState;

	public Del_Void Evt_SplineMoveEnterStopState;

	public Del_Void Evt_SetParkourLandCanMove;

	public Del_Void_Float Evt_SetAnimHumanoidAMMatryoshka;

	public Del_Void_Float Evt_SetAttackOffsetAlpha;

	public Del_SetAttackOffset Evt_SetAttackOffset;

	public Del_Void Evt_RemoveCheckPoint;

	public Del_Void_Float Evt_PartnerAutoRebirthTimeChanged;

	public Del_SweepCheckBegin Evt_SweepCheckBegin;

	public Del_SweepCheckEnd Evt_SweepCheckEnd;

	public Del_Void Evt_ShowSweepCheckShape;

	public Del_Void_Bool Evt_SetAllSweepCheckPaused;

	public Del_Void Evt_ClearSweepCheckData;

	public Del_OnProjectileCustomSweepHitWorldItem Evt_OnProjectileCustomSweepHitWorldItem;

	public Del_OnProjectileCustomSweepHitNormalUnit Evt_OnProjectileCustomSweepHitNormalUnit;

	public Del_AttackWarnningCheckBegin Evt_AttackWarnningCheckBegin;

	public Del_AttackWarnningCheckEnd Evt_AttackWarnningCheckEnd;

	public Del_Void_Bool Evt_SetAllAttackWarningPaused;

	public Del_Void_ActorInt Evt_RegisterTeamMngInfo;

	public Del_WakeUpPartnersInSameTeam Evt_WakeUpPartnersInSameTeam;

	public Del_Void_Actor Evt_OnTriggerWakeBroadCastToTeam;

	public Del_AddPointsToQuene Evt_AddPointsToQuene;

	public Del_CallPointsRegister Evt_CallPointsRegister;

	public Del_OnReqLightningSpawnPos Evt_OnReqLightningSpawnPos;

	public Del_DashWallCheckBegin Evt_DashWallCheckBegin;

	public Del_Void_Int Evt_DashWallCheckEnd;

	public Del_Void_Int Evt_InteractSweepEnd;

	public Del_InteractOverrideBegin Evt_InteractOverrideBegin;

	public Del_Void_Int Evt_InteractOverrideEnd;

	public Del_RegistExtraInteractBones Evt_RegistExtraInteractBones;

	public Del_Void_Int Evt_CancelExtraInteractBones;

	public Del_SwitchDispInteractConfig Evt_SwitchDispInteractConfig;

	public Del_Void Evt_ResetDispInteractConfig;

	public Del_OnPlayer0ReceiveInfo_Env Evt_OnPlayer0ReceiveInfo_Env;

	public Del_SetPhysAnimSetting Evt_SetPhysAnimSetting = (EPhysAnimType _003Cp0_003E) => false;

	public Del_Void Evt_ResetPhysicalAnim;

	public Del_Void_Bool Evt_SetLockPhysicalMoveSnapshot;

	public Del_Void_VectorVector Evt_AddPhysicsImpulse;

	public Del_OnBeatBackStartCheck Evt_OnBeatBackStartCheck;

	public Del_Void Evt_FallIntoDeadZone;

	public Del_Void Evt_PlayerFallCliffRollBack;

	public Del_Void_Bool Evt_OnEnableAssistCollision;

	public Del_OnSetBodiesCollisionEnable Evt_OnSetBodiesCollisionEnable;

	public Del_Void Evt_ResetBodiesCollisionEnable;

	public Del_TriggerInputActionImpl Evt_TriggerInputActionImpl;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_String Evt_InputActionPress;

	[GSRPCEvent(Endpoint = EGSRPCEventType.ClientMultiCast)]
	public Del_Void_String Evt_InputActionRelease;

	public Del_Void_Bool Evt_SetInputCompSkillDragEnabled;

	public Del_Void_Float Evt_SetAxisCamLookUp;

	public Del_Void_Float Evt_SetAxisCamTurnRight;

	public Del_Void_Int Evt_TriggerInputSkillSelect;

	public Del_Void_Int Evt_TriggerInputSkillRelease;

	public Del_ForceCancelSkillSelect Evt_ForceCancelSkillSelect;

	public Del_Void Evt_ResetAttackTracing;

	public Del_Void_String Evt_SetLastSkillKeyActionMapping;

	public Del_Void_IntListIntList Evt_SetMagicWindowSkillList;

	public Del_Void_Bool Evt_SetParkourMoveEnabled;

	public Del_Void_FloatFloatFloat Evt_ParkourCurveMove;

	public Del_Void_FloatFloatFloat Evt_SetParkourAnimTotalMovement;

	public Del_SetTraceVelocityCameraInfo Evt_SetTraceVelocityCameraInfo;

	[UINeedEvent]
	public Del_HandleAbnormal Evt_HandleAbnormal;

	public Del_DecreaseAbnormalAccValue Evt_DecreaseAbnormalAccValue;

	public Del_RemoveAbnormalFinalEffectByStep Evt_RemoveAbnormalFinalEffectByStep;

	public Del_ClearAbnormalState Evt_ClearAbnormalState;

	public Del_Void Evt_ClearAllAbnormalState;

	[UINeedEvent]
	public Del_AbnormalRemoved Evt_AbnormalRemoved;

	[UINeedEvent]
	public Del_OnTrigerAbnormalFinalEffect Evt_OnTrigerAbnormalFinalEffect;

	public Del_Void Evt_TriggerFrozen;

	public Del_Void Evt_OnFrozenEnded;

	public Del_HitWhenInFrozen Evt_HitWhenInFrozen;

	public Del_TriggerFrozenBreak Evt_TriggerFrozenBreak;

	public Del_TriggerFrozenBreakByAssist Evt_TriggerFrozenBreakByAssist;

	public Del_Void_Int Evt_OnUnFreezeCountAcc;

	public Del_Void Evt_EndFrozen;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Int Evt_OnIncreaseMaxPELevel;

	[UINeedEvent]
	public Del_Void Evt_OnIncreasePELevelNotify;

	[UINeedEvent]
	public Del_Void Evt_OnDecreasePELevelNotify;

	[UINeedEvent]
	public Del_Void_Int Evt_OnMaxPELevelHasChangedNotify;

	public Del_IncreasePEValue Evt_IncreasePEValue;

	public Del_Void Evt_ClearPEValue;

	public Del_Void Evt_ReloadPEConfig;

	public Del_Void_IntInt Evt_SwitchPEConfig;

	public Del_SwitchPEConfigByBuff Evt_SwitchPEConfigByBuff;

	public Del_Void_Int Evt_RevertPEConfig;

	public Del_EventOnPlayerChangeVolume Evt_EventOnPlayerChangeVolume;

	public Del_EventOnSendDispInteractInfo Evt_EventOnSendDispInteractInfo;

	public Del_EventOnUpdateDispInteractNSSystem Evt_EventOnUpdateDispInteractNSSystem;

	public Del_Void Evt_OnDisableDispInteractNSSystem;

	public Del_SetMagicFieldDirection Evt_SetMagicFieldDirection;

	public Del_Void_Actor Evt_LeaveMagicField;

	public Del_Void_IntInt Evt_ChangeDodgeSkill;

	public Del_Void Evt_ResetDodgeSkill;

	public Del_Void_Bool Evt_MarkRolling;

	public Del_Void Evt_FallingStart;

	public Del_Void Evt_OnLeaveFalling;

	public Del_Void Evt_OnLanded;

	public Del_Void Evt_OnJumpOff;

	public Del_Void_Bool Evt_PauseSafeFallingCheck;

	public Del_Void_Bool Evt_UpdateSafeLandFlag;

	public Del_Void Evt_ClearFallingHeight;

	public Del_Void_Bool Evt_Active_StopMontageWhenLand;

	public Del_Void_GameplayTag Evt_SceneObjDirectJumpToState;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_GameplayTag Evt_SceneObjTransitByEvent;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_GameplayTag Evt_SceneObjTransitByEventNoSaveState;

	public Del_Void Evt_NotifyStartObserve;

	public Del_Void_GameplayTagContainer Evt_NotifyFromGraph;

	public Del_Bool_DetectCondition Evt_FinishDetectCondition;

	public Del_Void_CircusEnterOverlapCondition Evt_FinishCircusEnterOverlapCondition;

	public Del_Void_BoolString Evt_EnterOrExitPhasePerformance;

	public Del_Void_GuidGameplayCounterTypeFloat Evt_StartGameplayCounter;

	public Del_Void_Guid Evt_StopGameplayCounter;

	public Del_Void_Guid Evt_GameplayCountCompleted;

	public Del_Void_StringList Evt_SetTriggerActors;

	public Del_PlaySkillSequence Evt_PlaySkillSequence;

	public Del_Void Evt_StopSkillSequence;

	public Del_Void_Float Evt_StopSkillSequenceWithBlendOutTime;

	public Del_Void Evt_UseLifeSavingHair_Effect;

	public Del_Void Evt_UseLifeSavingHair_PlayAnim;

	public Del_Void Evt_UseLifeSavingHair;

	public Del_Void Evt_LifeSavingHair_PendingStart;

	public Del_Void_Float Evt_RecoverLifeSavingHairCoolDown;

	public Del_Void_Float Evt_DecreaseLifeSavingHairCoolDown;

	public Del_Void_Float Evt_OnFakeDeadAMStart;

	public Del_Void_Bool Evt_Active_ExtLifeSaving;

	public Del_Void Evt_OnCastLifeSavingSuccess;

	public Del_Void Evt_OnWakeUp;

	public Del_Void Evt_ResetSpecialBoneList;

	public Del_SetSpecialBoneList Evt_SetSpecialBoneList;

	public Del_Void_String Evt_RegisterBattleSC;

	public Del_Void_FGameplayTag Evt_HandleBattleMessage;

	public Del_Void_Int Evt_MulticastCachedPointSet;

	public Del_Void_FGameplayTag Evt_OnFSMStateEnter;

	public Del_Void_FGameplayTag Evt_OnFSMStateExit;

	public Del_OnSpiderSilkEntangleStateEnter Evt_OnSpiderSilkEntangleStateEnter;

	public Del_Void Evt_OnSpiderSilkEntangleStateExit;

	public Del_Void Evt_OnSpiderSkillEntangleStiffEnded;

	public Del_Void Evt_EnableAreaOverlap;

	public Del_Void Evt_DisableAreaOverlap;

	public Del_Void_Actor Evt_OnActorEnterArea;

	public Del_Void_Actor Evt_OnActorLeaveArea;

	public Del_Void_BoolActor Evt_NotifyGraph;

	public Del_Void_Actor Evt_NotifyTransitToUnit;

	public Del_Void_Actor Evt_NotifyTransitFromUnit;

	public Del_Void Evt_ClearHasCastComboInfo;

	public Del_Void_Vector Evt_BeginRagDollDie;

	public Del_CollectReplicateData Evt_CollectReplicateData;

	public Del_DoReplicateData Evt_DoReplicateData;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server)]
	public Del_Void Evt_TeleportBegin;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server)]
	public Del_Void Evt_TeleportFinish;

	[GSRPCEvent(Endpoint = EGSRPCEventType.Server)]
	public Del_Void_RebirthType Evt_RebirthTeleportFinish;

	public Del_Void Evt_RBP_RebirthTeleportFinish;

	public Del_AAMotionMatchAssetPreloadRequire Evt_MotionMatchingAnimUsingPreLoad;

	public Del_AAMotionMatchAssetPreloadRequireFinished Evt_MotionMatchingAnimLoadFinished;

	public Del_SetMoveToTarget Evt_SetMoveToTarget;

	public Del_Void Evt_ClearMoveToTarget;

	public Del_Void_FloatBool Evt_SamplePointSurfaceType;

	public Del_Void Evt_ForceUpdateSurfaceType;

	public Del_SetIgnoredMappingTypeMap Evt_SetIgnoredMappingTypeMap;

	public Del_SetAllowUseSpecialItemMap Evt_SetAllowUseSpecialItemMap;

	[UINeedEvent]
	public Del_Void Evt_OnPEConfigChange;

	public Del_AITransformBySplineChange Evt_AITransformBySplineChange;

	public Del_AITransformBySplineStop Evt_AITransformBySplineStop;

	public Del_OnDummyMeshChange Evt_OnDummyMeshChange;

	public Del_Void Evt_OnDummyMeshSpeedRateChange;

	public Del_Bool Evt_OnMontagePausePlaying;

	public Del_Bool Evt_OnNavWalkOptMassiveModeChange;

	public Del_Void Evt_OnRefreshEquip;

	public Del_Void_Bool Evt_OnPhotoModeHeadEquipVisibleChange;

	public Del_OnWeaponDestroyed Evt_OnWeaponDestroyed;

	public Del_Void Evt_HandleWeaponReset;

	public Del_Void Evt_ActorForceUpdateTransform;

	public Del_OnSceneItemMatchTransformBegin Evt_OnSceneItemMatchTransformBegin;

	public Del_OnSceneItemMatchTransformEnd Evt_OnSceneItemMatchTransformEnd;

	public Del_OnSceneItemAttackRotationBegin Evt_OnSceneItemAttackRotationBegin;

	public Del_OnSceneItemAttackRotationEnd Evt_OnSceneItemAttackRotationEnd;

	public Del_TriggerItemEffectReal Evt_TriggerItemEffectReal;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Int Evt_UnitEquipFaBao;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_UnitUnequipFaBao;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_ActivateTalent Evt_ActivateTalent;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void_Int Evt_DeactivateTalent;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_RoleLevelChange Evt_RoleLevelChange;

	public Del_SwitchMagicConfInfo Evt_SwitchMagicConfInfo;

	public Del_SwitchMagicConfInfo Evt_TriggerSwitchMagicConfInfo;

	public Del_Void_Int Evt_TriggerSwitchSpellSolution;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_IncreaseAttrFloat Evt_FTB_IncreaseAttrFloat;

	[GSRPCEvent(Endpoint = EGSRPCEventType.MultiCast)]
	public Del_Void Evt_TriggerGainKeyItem;

	public Del_Void_IntBool Evt_ChangeVigorSkill;

	private static bool Evt_SetFloatValueToSimulateFog_IsValid;

	private static int Evt_SetFloatValueToSimulateFog_Offset;

	private Del_SetFloatValueToSimulateFog Evt_SetFloatValueToSimulateFog_DelegateCached;

	private static bool Evt_TriggerFrozenFractureBreak_IsValid;

	private static int Evt_TriggerFrozenFractureBreak_Offset;

	private Del_TriggerFrozenFractureBreak Evt_TriggerFrozenFractureBreak_DelegateCached;

	[UProperty(Flags = PropFlags.BlueprintAssignable)]
	[USharpPath("/Script/b1-Managed.BUS_EventCollectionCS:Evt_SetFloatValueToSimulateFog")]
	public Del_SetFloatValueToSimulateFog Evt_SetFloatValueToSimulateFog
	{
		get
		{
			CheckDestroyed();
			if (!Evt_SetFloatValueToSimulateFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EventCollectionCS:Evt_SetFloatValueToSimulateFog");
				return null;
			}
			if (Evt_SetFloatValueToSimulateFog_DelegateCached == null)
			{
				Evt_SetFloatValueToSimulateFog_DelegateCached = new Del_SetFloatValueToSimulateFog();
				Evt_SetFloatValueToSimulateFog_DelegateCached.SetAddress(IntPtr.Add(base.Address, Evt_SetFloatValueToSimulateFog_Offset));
			}
			return Evt_SetFloatValueToSimulateFog_DelegateCached;
		}
	}

	[UProperty(Flags = PropFlags.BlueprintAssignable)]
	[USharpPath("/Script/b1-Managed.BUS_EventCollectionCS:Evt_TriggerFrozenFractureBreak")]
	public Del_TriggerFrozenFractureBreak Evt_TriggerFrozenFractureBreak
	{
		get
		{
			CheckDestroyed();
			if (!Evt_TriggerFrozenFractureBreak_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_EventCollectionCS:Evt_TriggerFrozenFractureBreak");
				return null;
			}
			if (Evt_TriggerFrozenFractureBreak_DelegateCached == null)
			{
				Evt_TriggerFrozenFractureBreak_DelegateCached = new Del_TriggerFrozenFractureBreak();
				Evt_TriggerFrozenFractureBreak_DelegateCached.SetAddress(IntPtr.Add(base.Address, Evt_TriggerFrozenFractureBreak_Offset));
			}
			return Evt_TriggerFrozenFractureBreak_DelegateCached;
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public static BUS_GSEventCollection Get(AActor Actor)
	{
		if (Actor.IsNullOrDestroyed())
		{
			return null;
		}
		if (Actor is IECSWorldObj iECSWorldObj)
		{
			return iECSWorldObj.GetEventCollection() as BUS_GSEventCollection;
		}
		if (Actor is BUTamerActor bUTamerActor)
		{
			return bUTamerActor.GetMonster()?.GetEventCollection() as BUS_GSEventCollection;
		}
		return Actor.GetComponentByClass<BUS_GSEventCollection>();
	}

	public static BUS_GSEventCollection Get(UActorCompBaseCS Comp)
	{
		return GetWithECSObj(Comp.CachedOwnerECS);
	}

	public static BUS_GSEventCollection GetWithECSObj(IECSWorldObj EcsObj)
	{
		return EcsObj.GetEventCollection() as BUS_GSEventCollection;
	}

	public static BUS_GSEventCollection Get(UBaseActorComp Comp)
	{
		if (Comp == null)
		{
			return null;
		}
		return Get(Comp.GetOwner());
	}

	public static BUS_GSEventCollection Get(UActorCompBaseUObj Comp)
	{
		return GetWithECSObj(Comp.CachedOwnerECS);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_EventCollectionCS");
		Evt_SetFloatValueToSimulateFog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Evt_SetFloatValueToSimulateFog");
		Evt_SetFloatValueToSimulateFog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Evt_SetFloatValueToSimulateFog", Classes.FMulticastDelegateProperty);
		Evt_TriggerFrozenFractureBreak_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Evt_TriggerFrozenFractureBreak");
		Evt_TriggerFrozenFractureBreak_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Evt_TriggerFrozenFractureBreak", Classes.FMulticastDelegateProperty);
	}

	static BUS_EventCollectionCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_EventCollectionCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_EventCollectionCS));
	}
}
