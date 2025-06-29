using System;
using b1.EventDelDefine;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_PlayerCameraSystem")]
public class BUS_PlayerCameraSystem : UActorCompBaseUObj
{
	private static bool PlayerController_IsValid;

	private static int PlayerController_Offset;

	private static bool PlayerCameraManager_IsValid;

	private static int PlayerCameraManager_Offset;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BUS_PlayerCameraSystem:PlayerController")]
	private APlayerController PlayerController
	{
		get
		{
			CheckDestroyed();
			if (!PlayerController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PlayerCameraSystem:PlayerController");
				return null;
			}
			return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(base.Address, PlayerController_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PlayerCameraSystem:PlayerController");
			}
			else
			{
				UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(base.Address, PlayerController_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BUS_PlayerCameraSystem:PlayerCameraManager")]
	private APlayerCameraManager PlayerCameraManager
	{
		get
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PlayerCameraSystem:PlayerCameraManager");
				return null;
			}
			return UObjectMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_PlayerCameraSystem:PlayerCameraManager");
			}
			else
			{
				UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset), value);
			}
		}
	}

	private BUC_SeqCameraData SeqCameraData { get; set; }

	private IBGC_MovieData MovieData { get; set; }

	public override void OnAttach()
	{
		SeqCameraData = RequireWritableData<BUC_SeqCameraData>();
		MovieData = RequireReadOnlyGameStateData<IBGC_MovieData, BGC_MovieData>();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_PrepareCameraSequenceActor += new Del_PrepareCameraSequenceActor(PrepareCameraSequenceActor_i);
		}
	}

	public override void PreBeginPlay()
	{
		if (!UGSE_EngineFuncLib.IsDedicateServer(Owner.World))
		{
			PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
			PlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(this);
			SeqCameraData.CameraNormalModePitchMin = PlayerCameraManager.ViewPitchMin;
			SeqCameraData.CameraNormalModePitchMax = PlayerCameraManager.ViewPitchMax;
		}
	}

	private void PrepareCameraSequenceActor_i(FGSCameraSequenceData CameraSequenceData, ref FTransform StartTransform, bool IsSeqAttachToActor = false)
	{
		SeqCameraData.bUseCinematicCamera = CameraSequenceData.ShouldUseCinematicCamera;
		ULevelSequence cameraSequence = CameraSequenceData.CameraSequence;
		if (BGW_LogUtil.LogIfNull(cameraSequence, "LevelSequence is null"))
		{
			return;
		}
		bool flag = IsCameraSequenceWithCrane(cameraSequence);
		UWorld world = GetOwner().World;
		if (SeqCameraData.LevelSequenceActorForCamera == null)
		{
			SeqCameraData.LevelSequenceActorForCamera = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay<ALevelSequenceActor>(world);
			SeqCameraData.LevelSequenceActorForCamera.SequencePlayer = UObject.NewObject<ULevelSequencePlayer>(SeqCameraData.LevelSequenceActorForCamera, B1GlobalFNames.LevelSequenceActorForCameraInst, EObjectFlags.NoFlags, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
		}
		if (IsSeqAttachToActor)
		{
			BGU_UnrealActorUtil.AttachToActorSimple(SeqCameraData.LevelSequenceActorForCamera, GetOwner(), EAttachmentTransformRules.SnapToTargetNotIncludingScale);
		}
		else
		{
			BGU_UnrealActorUtil.DetachFromActor(SeqCameraData.LevelSequenceActorForCamera, EDetachmentTransformRules.KeepRelativeTransform);
		}
		if (SeqCameraData.LevelSequenceActorForCamera.SequencePlayer.IsPlaying())
		{
			SeqCameraData.LevelSequenceActorForCamera.SequencePlayer.Stop();
		}
		UGSE_SequencerFuncLib.SequenceActorInitPlayerCS(SeqCameraData.LevelSequenceActorForCamera, UGSE_WorldFuncLib.WorldGetPersistentLevel(GetOwner().World), cameraSequence);
		SeqCameraData.LevelSequenceActorForCamera.SetActorTransform(StartTransform, bSweep: false, out var _, bTeleport: false);
		SeqCameraData.LevelSequenceActorForCamera.ResetBindings();
		AActor cameraActor = MovieData.GetCameraActor(this);
		AActor cinematicCameraActor = MovieData.GetCinematicCameraActor(this);
		AActor cameraCraneActor = MovieData.GetCameraCraneActor(this);
		AActor cameraRailActor = MovieData.GetCameraRailActor(this);
		SeqCameraData.CameraActorForSeq = cameraActor;
		if (SeqCameraData.bUseCinematicCamera)
		{
			SeqCameraData.CameraActorForSeq = cinematicCameraActor;
		}
		if (CameraSequenceData.CameraRailClass != null)
		{
			if (!flag)
			{
				BGW_LogUtil.LogError("Camera Sequence with Rail Data, But With No Crane Data Name:%d");
				return;
			}
			BGU_UnrealActorUtil.AttachToActorSimple(SeqCameraData.CameraActorForSeq, cameraCraneActor, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			BGU_UnrealActorUtil.AttachToActorSimple(cameraCraneActor, cameraRailActor, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			BGU_UnrealActorUtil.AttachToActorSimple(cameraRailActor, SeqCameraData.LevelSequenceActorForCamera, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			CameraSequenceActorBindOneObj_i(cameraSequence, B1GlobalFNames.BP_CameraActor_ForSeq, SeqCameraData.CameraActorForSeq);
			CameraSequenceActorBindOneObj_i(cameraSequence, B1GlobalFNames.BP_CameraCrane_ForSeq, cameraCraneActor);
			CameraSequenceActorBindOneObj_i(cameraSequence, B1GlobalFNames.BP_CameraRail_ForSeq, cameraRailActor);
		}
		else if (flag)
		{
			BGU_UnrealActorUtil.AttachToActorSimple(SeqCameraData.CameraActorForSeq, cameraCraneActor, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			BGU_UnrealActorUtil.AttachToActorSimple(cameraCraneActor, SeqCameraData.LevelSequenceActorForCamera, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			CameraSequenceActorBindOneObj_i(cameraSequence, B1GlobalFNames.BP_CameraActor_ForSeq, SeqCameraData.CameraActorForSeq);
			CameraSequenceActorBindOneObj_i(cameraSequence, B1GlobalFNames.BP_CameraCrane_ForSeq, cameraCraneActor);
		}
		else
		{
			BGU_UnrealActorUtil.AttachToActorSimple(SeqCameraData.CameraActorForSeq, SeqCameraData.LevelSequenceActorForCamera, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			CameraSequenceActorBindOneObj_i(cameraSequence, SeqCameraData.bUseCinematicCamera ? B1GlobalFNames.BP_CameraCinematic_ForSeq : B1GlobalFNames.BP_CameraActor_ForSeq, SeqCameraData.CameraActorForSeq);
		}
		SeqCameraData.LevelSequenceActorForCamera.SequencePlayer.SetDisableCameraCuts(bInDisableCameraCuts: true);
		BGUFuncLibSequenceCS.PlayFromStart(SeqCameraData.LevelSequenceActorForCamera);
		SeqCameraData.LevelSequenceActorForCamera.SequencePlayer.Play();
		if (cameraRailActor != null)
		{
			ACameraRig_Rail aCameraRig_Rail = cameraRailActor as ACameraRig_Rail;
			if (aCameraRig_Rail != null)
			{
				UGSE_CharacterFuncLib.Tick(aCameraRig_Rail, 0f);
			}
		}
		if (flag)
		{
			ACameraRig_Crane aCameraRig_Crane = cameraCraneActor as ACameraRig_Crane;
			if (aCameraRig_Crane != null)
			{
				UGSE_CharacterFuncLib.Tick(aCameraRig_Crane, 0f);
			}
		}
	}

	private void CameraSequenceActorBindOneObj_i(ULevelSequence LevelSequence, FName BindingName, AActor BindingObj)
	{
		if (!BGW_LogUtil.LogIfNull(BindingObj, "BindingObj is NULL"))
		{
			FSequenceBindingIDInCS levelSequenceBindingIDByNameCS = UGSE_SequencerFuncLib.GetLevelSequenceBindingIDByNameCS(LevelSequence, BindingName);
			UGSE_SequencerFuncLib.SequenceActorAddBindingCS(SeqCameraData.LevelSequenceActorForCamera, levelSequenceBindingIDByNameCS, BindingObj);
			UGSE_SequencerFuncLib.LevelSequenceUnbindPossessableObjectCS(LevelSequence, levelSequenceBindingIDByNameCS);
			if (UGSE_SequencerFuncLib.IsMovieSceneObjectBindingIDValidCS(levelSequenceBindingIDByNameCS))
			{
				UGSE_SequencerFuncLib.LevelSequenceBindPossessableObjectCS(LevelSequence, levelSequenceBindingIDByNameCS, BindingObj, GetOwner().World);
			}
		}
	}

	private bool IsCameraSequenceWithCrane(ULevelSequence LevelSequence)
	{
		return UGSE_SequencerFuncLib.IsMovieSceneObjectBindingIDValidCS(UGSE_SequencerFuncLib.GetLevelSequenceBindingIDByNameCS(LevelSequence, B1GlobalFNames.BP_CameraCrane_ForSeq));
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (!(PlayerController == null))
		{
			if (BGUFunctionLibraryCS.BGUCanPlayerCtrlCamera(owner))
			{
				PlayerController.ResetIgnoreLookInput();
			}
			else if (!PlayerController.IsLookInputIgnored())
			{
				PlayerController.SetIgnoreLookInput(bNewLookInput: true);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_PlayerCameraSystem");
		PlayerController_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerController");
		PlayerController_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerController", Classes.FObjectProperty);
		PlayerCameraManager_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerCameraManager");
		PlayerCameraManager_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerCameraManager", Classes.FObjectProperty);
	}

	static BUS_PlayerCameraSystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_PlayerCameraSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_PlayerCameraSystem));
	}
}
