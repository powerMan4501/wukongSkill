using System;
using System.Collections.Generic;
using b1.Plugins.ConsoleVariableManager;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_TakePhotoSystemMgr")]
public class BGW_TakePhotoSystemMgr : GameInstanceSystemBaseUObj
{
	private BGUTakePhotoActor TakePhotoActor;

	private bool IsInTakePhotoMode;

	private bool IsNeedEnterTakePhotoMode;

	private int OpenCameraLagFlag;

	private BGUCharacterCS CachePlayerPawn;

	private FVector PlayerPawnPos;

	private double CameraMoveableHeight;

	private double CameraMoveableDistance;

	private double PhysicsAssetCheckRange;

	private FTransform ResetCameraActorTransform;

	private float ResetFOV;

	private AActor CacheCameraViewTarget;

	private bool CacheIsShouldPerformFullTickWhenPaused;

	private bool CacheIsCameraMoveableWhenPaused;

	private const string MotionBlur_Cvar = "r.motionblur.amount";

	private const string SimPause_Cvar = "tfx.SimPause";

	private const string DLSSGEnable_Cvar = "r.Streamline.DLSSG.Enable";

	private const string FidelityFXEnable_Cvar = "r.FidelityFX.FI.Enabled";

	private static bool TakePhotoSystemConfig_IsValid;

	private static int TakePhotoSystemConfig_Offset;

	public override bool bTickEnabled => true;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_TakePhotoSystemMgr:TakePhotoSystemConfig")]
	public BGWDataAsset_TakePhotoSystemConfig TakePhotoSystemConfig
	{
		get
		{
			CheckDestroyed();
			if (!TakePhotoSystemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_TakePhotoSystemMgr:TakePhotoSystemConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_TakePhotoSystemConfig>.FromNative(IntPtr.Add(base.Address, TakePhotoSystemConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TakePhotoSystemConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_TakePhotoSystemMgr:TakePhotoSystemConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_TakePhotoSystemConfig>.ToNative(IntPtr.Add(base.Address, TakePhotoSystemConfig_Offset), value);
			}
		}
	}

	public static BGW_TakePhotoSystemMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_TakePhotoSystemMgr>(WorldContext);
	}

	public override void OnInit()
	{
		base.OnInit();
		TakePhotoActor = null;
		IsInTakePhotoMode = false;
		IsNeedEnterTakePhotoMode = false;
		OpenCameraLagFlag = -1;
		CacheCameraViewTarget = null;
	}

	public override void OnShutdown()
	{
		base.OnShutdown();
		if (!TakePhotoActor.IsNullOrDestroyed())
		{
			BGU_UnrealWorldUtil.DestroyActor(TakePhotoActor);
		}
		TakePhotoActor = null;
		IsInTakePhotoMode = false;
		CacheCameraViewTarget = null;
	}

	public override int GetTickGroupMask()
	{
		return 3072;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		switch (TickGroup)
		{
		case 2048:
			if (!IsInTakePhotoMode && IsNeedEnterTakePhotoMode)
			{
				IsNeedEnterTakePhotoMode = false;
				BGW_EventCollection.Get(base.Owner)?.Evt_RealEnterTakePhotoMode?.Invoke();
			}
			break;
		case 1024:
			if (OpenCameraLagFlag > 0)
			{
				OpenCameraLagFlag--;
				if (OpenCameraLagFlag <= 0)
				{
					TakePhotoActor?.SetEnableCameraLag(IsEnable: true);
					OpenCameraLagFlag = -1;
				}
			}
			break;
		}
	}

	public void RequestEnterTakePhotoMode()
	{
		if (!IsInTakePhotoMode)
		{
			IsNeedEnterTakePhotoMode = true;
		}
	}

	public bool CheckEnterTakePhotoMode()
	{
		return IsNeedEnterTakePhotoMode;
	}

	public void EnterTakePhotoMode()
	{
		if (IsInTakePhotoMode)
		{
			return;
		}
		IsInTakePhotoMode = true;
		ABGPPlayerController aBGPPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this) as ABGPPlayerController;
		if (aBGPPlayerController.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[BGW_TakePhotoSystemMgr] EnterTakePhotoMode PlayerController IsNull");
			return;
		}
		CachePlayerPawn = aBGPPlayerController.GetControlledPawn() as BGUCharacterCS;
		if (CachePlayerPawn.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[BGW_TakePhotoSystemMgr] EnterTakePhotoMode PlayerPawn IsNull");
			return;
		}
		APlayerCameraManager localPlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(this);
		if (localPlayerCameraManager.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[BGW_TakePhotoSystemMgr] EnterTakePhotoMode PlayerCameraManager IsNull");
		}
		else
		{
			if (TakePhotoSystemConfig == null)
			{
				return;
			}
			if (TakePhotoActor.IsNullOrDestroyed())
			{
				if (TakePhotoSystemConfig.TakePhotoActor_BP == null || TakePhotoSystemConfig.TakePhotoActor_BP.Value == null)
				{
					return;
				}
				TakePhotoActor = BGU_UnrealWorldUtil.SpawnActor(UEngine.GEngine.GetWorldFromContextObject(this), TakePhotoSystemConfig.TakePhotoActor_BP.Value) as BGUTakePhotoActor;
			}
			if (TakePhotoActor.IsNullOrDestroyed())
			{
				BGW_LogUtil.LogError("[BGW_TakePhotoSystemMgr] EnterTakePhotoMode Spawn TakePhotoActor Failed");
				return;
			}
			TakePhotoActor.SetActorHiddenInGame(bNewHidden: false);
			TakePhotoActor.SetActorEnableCollision(bNewActorEnableCollision: true);
			CacheCameraViewTarget = aBGPPlayerController.GetViewTarget();
			CacheIsShouldPerformFullTickWhenPaused = aBGPPlayerController.GetIsShouldPerformFullTickWhenPaused();
			CacheIsCameraMoveableWhenPaused = UBGWFunctionLibrary.BGWGetIsCameraMoveableWhenPaused(this);
			CameraMoveableHeight = TakePhotoSystemConfig.CameraMoveableHeight;
			CameraMoveableDistance = TakePhotoSystemConfig.CameraMoveableDistance;
			PhysicsAssetCheckRange = TakePhotoSystemConfig.PhysicsAssetCheckRange;
			PlayerPawnPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(CachePlayerPawn);
			FVector cameraLocation = localPlayerCameraManager.GetCameraLocation();
			FRotator cameraRotation = localPlayerCameraManager.GetCameraRotation();
			ResetCameraActorTransform = new FTransform(cameraRotation, cameraLocation);
			ResetFOV = localPlayerCameraManager.GetFOVAngle();
			TakePhotoActor.SetActorLocationAndRotation(cameraLocation, cameraRotation, bSweep: false, out var _, bTeleport: true);
			TakePhotoActor.SetCameraFOV(ResetFOV);
			TakePhotoActor.SetEnableCameraLag(IsEnable: false);
			aBGPPlayerController.SetViewTargetWithBlend(TakePhotoActor);
			OpenCameraLagFlag = 3;
			BGW_CommLevelMgr.Get(this)?.TempClosePostProcessVolume(IsClose: true);
			if (GSGameplayCVar.CVar_RemovePauseTPMode.GetValueInGameThread() <= 0)
			{
				SetCvar("r.motionblur.amount", 0f, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("tfx.SimPause", 1, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.Streamline.DLSSG.Enable", 0, 1, -1, EConsoleVariablePriority.UI);
				SetCvar("r.FidelityFX.FI.Enabled", 0, 1, -1, EConsoleVariablePriority.UI);
				aBGPPlayerController.SetIsShouldPerformFullTickWhenPaused(IsShould: true);
				UBGWFunctionLibrary.BGWSetIsCameraMoveableWhenPaused(this, IsCameraMoveable: true);
				BGW_EventCollection.Get(this).Evt_SetGamePause(EPauseEvent.TakePhoto, bPause: true);
				BGWGameInstanceCS.Get(this).AddTickEvenWhenPausedList(BGW_UIMgr.Get(this));
				BGWGameInstanceCS.Get(this).AddTickEvenWhenPausedList(BGW_EnhancedInputMgrV2.Get(this));
				BGWGameInstanceCS.Get(this).AddTickEvenWhenPausedList(this);
				if (DebugConfig.ILRuntime)
				{
					BGWGameInstanceCS.Get(this).AddTickEvenWhenPausedList(BGW_ILRuntimeMgr.Get(this));
				}
				else
				{
					BGWGameInstanceCS.Get(this).AddTickEvenWhenPausedList(BGW_ManagedReflectMgr.Get(this));
				}
			}
			else
			{
				CameraMoveableHeight *= 10.0;
				CameraMoveableDistance *= 10.0;
			}
		}
	}

	public void LeaveTakePhotoMode()
	{
		if (!IsInTakePhotoMode)
		{
			return;
		}
		ABGPPlayerController aBGPPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this) as ABGPPlayerController;
		if (aBGPPlayerController.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[BGW_TakePhotoSystemMgr] LeaveTakePhotoMode PlayerController IsNull");
			return;
		}
		if (GSGameplayCVar.CVar_RemovePauseTPMode.GetValueInGameThread() <= 0)
		{
			BGWGameInstanceCS.Get(this).RemoveTickEvenWhenPausedList(this);
			BGWGameInstanceCS.Get(this).RemoveTickEvenWhenPausedList(BGW_EnhancedInputMgrV2.Get(this));
			BGWGameInstanceCS.Get(this).RemoveTickEvenWhenPausedList(BGW_UIMgr.Get(this));
			if (DebugConfig.ILRuntime)
			{
				BGWGameInstanceCS.Get(this).RemoveTickEvenWhenPausedList(BGW_ILRuntimeMgr.Get(this));
			}
			else
			{
				BGWGameInstanceCS.Get(this).RemoveTickEvenWhenPausedList(BGW_ManagedReflectMgr.Get(this));
			}
			BGW_EventCollection.Get(this).Evt_SetGamePause(EPauseEvent.TakePhoto, bPause: false);
			aBGPPlayerController.SetIsShouldPerformFullTickWhenPaused(CacheIsShouldPerformFullTickWhenPaused);
			UBGWFunctionLibrary.BGWSetIsCameraMoveableWhenPaused(this, CacheIsCameraMoveableWhenPaused);
			ResetAllManagedCvarByType(1);
		}
		BGW_CommLevelMgr.Get(this)?.TempClosePostProcessVolume(IsClose: false);
		if (CacheCameraViewTarget.IsNullOrDestroyed())
		{
			BGUCharacterCS bGUCharacterCS = aBGPPlayerController.GetControlledPawn() as BGUCharacterCS;
			if (bGUCharacterCS.IsNullOrDestroyed())
			{
				BGW_LogUtil.LogError("[BGW_TakePhotoSystemMgr] LeaveTakePhotoMode PlayerCharacter IsNull");
				return;
			}
			aBGPPlayerController.SetViewTargetWithBlend(bGUCharacterCS);
		}
		else
		{
			aBGPPlayerController.SetViewTargetWithBlend(CacheCameraViewTarget);
		}
		if (!TakePhotoActor.IsNullOrDestroyed())
		{
			BGU_UnrealWorldUtil.DestroyActor(TakePhotoActor);
		}
		TakePhotoActor = null;
		CachePlayerPawn = null;
		IsInTakePhotoMode = false;
	}

	public void MoveTakePhotoActor(FVector MoveOffset, bool IsLocal)
	{
		if (!IsInTakePhotoMode || TakePhotoActor.IsNullOrDestroyed())
		{
			return;
		}
		FVector actorLocation = TakePhotoActor.GetActorLocation();
		FVector moveOffset = (IsLocal ? TakePhotoActor.GetActorTransform().TransformVectorNoScale(MoveOffset) : MoveOffset);
		if (!MoveDetection(actorLocation, moveOffset, out var AdjustMoveOffset, 0, 0))
		{
			return;
		}
		TakePhotoActor.AddActorWorldOffset(AdjustMoveOffset, bSweep: true, out var SweepHitResult, bTeleport: false);
		if (SweepHitResult.BlockingHit)
		{
			FVector planeNormal = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in SweepHitResult.Normal);
			FVector moveOffset2 = FVector.VectorPlaneProject(AdjustMoveOffset, planeNormal);
			if (MoveDetection(actorLocation, moveOffset2, out var AdjustMoveOffset2, 0, 1))
			{
				TakePhotoActor.AddActorWorldOffset(AdjustMoveOffset2, bSweep: true, out var _, bTeleport: false);
			}
		}
	}

	private bool MoveDetection(FVector CurrentCameraPos, FVector MoveOffset, out FVector AdjustMoveOffset, int ReTryFlag, int TraceNum)
	{
		AdjustMoveOffset = MoveOffset;
		FVector fVector = CurrentCameraPos + MoveOffset;
		if (CameraMoveableHeight > 0.0 && (double)(fVector.Z - PlayerPawnPos.Z) > CameraMoveableHeight && MoveOffset.Z > 0f)
		{
			return false;
		}
		double num = fVector.Vector_Distance(PlayerPawnPos);
		if (num > CameraMoveableDistance)
		{
			double num2 = CurrentCameraPos.Vector_Distance(PlayerPawnPos);
			if (num > num2)
			{
				return false;
			}
		}
		FVector fVector2 = MoveOffset;
		fVector2.Normalize();
		USystemLibrary.SphereTraceSingle(this, CurrentCameraPos + fVector2, fVector, 10f, ETraceTypeQuery.TraceTypeQuery2, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 1f);
		TraceNum++;
		if (OutHit.BlockingHit)
		{
			if (TraceNum < 2)
			{
				FVector planeNormal = BGUFunctionLibraryCS.BGUGetVectorFromNetQuantizeVector(in OutHit.Normal);
				FVector moveOffset = FVector.VectorPlaneProject(MoveOffset, planeNormal);
				return MoveDetection(CurrentCameraPos, moveOffset, out AdjustMoveOffset, ReTryFlag, TraceNum);
			}
			return false;
		}
		if (!CachePlayerPawn.IsNullOrDestroyed() && !CachePlayerPawn.Mesh.IsNullOrDestroyed() && CachePlayerPawn.Mesh.GetClosestPointOnPhysicsAsset(fVector, out var _, out var Normal, out var BoneName, out var Distance) && (double)Distance <= PhysicsAssetCheckRange && CachePlayerPawn.Mesh.GetClosestPointOnPhysicsAsset(CurrentCameraPos, out Normal, out var Normal2, out BoneName, out var Distance2) && Distance < Distance2)
		{
			switch (ReTryFlag)
			{
			case 0:
			{
				FVector safeNormal2 = Normal2.GetSafeNormal();
				FVector fVector3 = FVector.DotProduct(MoveOffset, safeNormal2) * safeNormal2;
				FVector moveOffset2 = MoveOffset - fVector3;
				return MoveDetection(CurrentCameraPos, moveOffset2, out AdjustMoveOffset, 1, TraceNum);
			}
			case 1:
			{
				FVector safeNormal = Normal2.GetSafeNormal();
				return MoveDetection(CurrentCameraPos, safeNormal, out AdjustMoveOffset, 2, TraceNum);
			}
			default:
				return false;
			}
		}
		return true;
	}

	public void RotateTakePhotoActor(FRotator RotatorOffset, bool IsLocal)
	{
		if (IsInTakePhotoMode && !TakePhotoActor.IsNullOrDestroyed())
		{
			FHitResult SweepHitResult;
			if (IsLocal)
			{
				TakePhotoActor.AddActorLocalRotation(RotatorOffset, bSweep: true, out SweepHitResult, bTeleport: false);
			}
			else
			{
				TakePhotoActor.AddActorWorldRotation(RotatorOffset, bSweep: true, out SweepHitResult, bTeleport: false);
			}
		}
	}

	public void ResetCamera()
	{
		TakePhotoActor?.SetActorLocationAndRotation(ResetCameraActorTransform.GetLocation(), ResetCameraActorTransform.GetRotation().Rotator(), bSweep: false, out var _, bTeleport: true);
	}

	public UCineCameraComponent GetTargetCamera()
	{
		if (TakePhotoActor.IsNullOrDestroyed())
		{
			return null;
		}
		return TakePhotoActor.FollowCamera;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_TakePhotoSystemMgr");
		TakePhotoSystemConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TakePhotoSystemConfig");
		TakePhotoSystemConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TakePhotoSystemConfig", Classes.FObjectProperty);
	}

	static BGW_TakePhotoSystemMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_TakePhotoSystemMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_TakePhotoSystemMgr));
	}
}
