using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SkillSequenceComp")]
public class BUS_SkillSequenceComp : UActorCompBaseUObj
{
	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_AnimationSyncHostData AnimationSyncHostData;

	private float CameraBlendForIBMTimer;

	private FName DefaultCameraFOVTag = FName.None;

	private readonly string RefCameraFOVTagPrefix = "GSRefFOV_";

	private static bool OnFinished_IsValid;

	private static IntPtr OnFinished_FunctionAddress;

	private static int OnFinished_ParamsSize;

	private APlayerCameraManager PlayerCameraManager { get; set; }

	private APlayerController PlayerController { get; set; }

	private AActor ViewTargetCache { get; set; }

	private ULevelSequencePlayer SequencePlayer { get; set; }

	private FSkillSequencePlaySettings PlaySettings { get; set; }

	private ACalliopeLevelSequenceActor SequenceActor { get; set; }

	private TWeakObject<ACameraActor> CameraActorCache { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_PlaySkillSequence += new Del_PlaySkillSequence(OnPlaySkillSequence);
			bUS_GSEventCollection.Evt_StopSkillSequence += new Del_Void(OnStopSkillSequence);
			bUS_GSEventCollection.Evt_StopSkillSequenceWithBlendOutTime += new Del_Void_Float(OnStopSkillSequenceWithBlendOutTime);
			bUS_GSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		}
		PlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(Owner);
		PlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		AnimationSyncHostData = RequireReadOnlyData<IBUC_AnimationSyncHostData, BUC_AnimationSyncHostData>();
		base.BGSEventCollection.Evt_DetachCameraInSkillSeq += new Del_Void(OnDetachCameraInSkillSeq);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_DetachCameraInSkillSeq -= new Del_Void(OnDetachCameraInSkillSeq);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (CameraBlendForIBMTimer > 0f)
		{
			CameraBlendForIBMTimer -= DeltaTime;
			if (CameraBlendForIBMTimer <= 0f)
			{
				OnFinished();
			}
		}
	}

	private void OnPlaySkillSequence(FSkillSequencePlaySettings InPlaySettings)
	{
		APawn controlledPawn = PlayerController.GetControlledPawn();
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(controlledPawn, EBGUSimpleState.PhantomRush) || (AnimationSyncHostData.Guest != null && AnimationSyncHostData.Guest != controlledPawn) || (AnimationSyncHostData.Guest == null && Owner != controlledPawn))
		{
			return;
		}
		if (!UGSE_EngineFuncLib.IsStandAlone(Owner.World) && TargetInfoData != null)
		{
			BGUCharacterCS bGUCharacterCS = TargetInfoData.GetTargetInfo().LockTargetActor as BGUCharacterCS;
			if (bGUCharacterCS != null && bGUCharacterCS.IsPlayerControlled())
			{
				if (!(bGUCharacterCS.GetController() as APlayerController != null))
				{
					return;
				}
				PlayerController = bGUCharacterCS.GetController() as APlayerController;
				PlayerCameraManager = PlayerController.PlayerCameraManager;
			}
		}
		PlaySettings = InPlaySettings;
		List<FTransform> list = new List<FTransform>();
		FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner);
		for (int i = 0; i < PlaySettings.SequenceCameraTransforms.Count; i++)
		{
			list.Add(FTransform.Multiply(PlaySettings.SequenceCameraTransforms[i], fTransform));
		}
		float num = -1f;
		int num2 = -1;
		float num3 = 0f;
		FVector cameraLocation = PlayerCameraManager.GetCameraLocation();
		FRotator cameraRotation = PlayerCameraManager.GetCameraRotation();
		for (int j = 0; j < list.Count; j++)
		{
			FTransform fTransform2 = list[j];
			float num4 = MathLib.DistSquared(fTransform2.GetLocation(), cameraLocation);
			float num5 = MathLib.ClampAxis(MathLib.ClampAxis(fTransform2.Rotation.Rotator().Yaw) - MathLib.ClampAxis(cameraRotation.Yaw));
			if (num5 > 180f)
			{
				num5 = 360f - num5;
			}
			if (num < 0f || num4 < num || (MathLib.Abs(num4 - num) < 1E-08f && num3 > num5))
			{
				num = num4;
				num2 = j;
				num3 = num5;
			}
		}
		FHitResult SweepHitResult;
		if (num2 >= 0 && num2 < PlaySettings.SequenceList.Count)
		{
			ULevelSequence uLevelSequence = PlaySettings.SequenceList[num2];
			if (uLevelSequence != null)
			{
				if (SequenceActor == null)
				{
					FMovieSceneSequencePlaybackSettings fMovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings
					{
						AutoPlay = false,
						PlayRate = 1f,
						StartTime = 0f,
						RandomStartTime = false,
						RestoreState = false,
						DisableMovementInput = true,
						DisableLookAtInput = true,
						HidePlayer = false,
						HideHud = false,
						DisableCameraCuts = true,
						PauseAtEnd = true
					};
					FLevelSequenceCameraSettings cameraSettings = new FLevelSequenceCameraSettings
					{
						AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
						OverrideAspectRatioAxisConstraint = false
					};
					SequenceActor = UGameplayStatics.GetActorOfClass(this, UClass.GetClass<ACalliopeLevelSequenceActor>()) as ACalliopeLevelSequenceActor;
					if (SequenceActor == null)
					{
						SequencePlayer = UCalliopeLevelSequencePlayer.CreateCalliopeLevelSequencePlayer(Owner, uLevelSequence, fMovieSceneSequencePlaybackSettings, cameraSettings, out var OutActor);
						SequenceActor = OutActor;
					}
					else
					{
						SequenceActor.PlaybackSettings = fMovieSceneSequencePlaybackSettings;
						SequenceActor.CameraSettings = cameraSettings;
						SequencePlayer = SequenceActor.GetSequencePlayer();
						SequenceActor.SetSequence(uLevelSequence);
					}
				}
				base.BGSEventCollection.Evt_PauseCurrentMovie += new Del_Void(OnPauseSkillSequence);
				base.BGSEventCollection.Evt_ResumeCurrentMovie += new Del_Void(OnResumeSkillSequence);
				FTransform newTransform = FTransform.Identity;
				if (PlaySettings.RotationType == ESkillCameraRotationType.UseUnitRotation)
				{
					newTransform = fTransform;
				}
				else
				{
					newTransform.SetRotation(PlayerController.GetControlRotation().Quaternion());
					newTransform.SetLocation(PlayerController.GetActorLocation());
				}
				FRotator fRotator = newTransform.Rotation.Rotator();
				fRotator.Pitch = 0f;
				fRotator.Pitch = 0f;
				newTransform.SetRotation(fRotator.Quaternion());
				SequenceActor.SetActorTransform(newTransform, bSweep: false, out SweepHitResult, bTeleport: false);
			}
		}
		ACameraActor aCameraActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(Owner, B1GlobalFNames.CameraActorForSeq) as ACameraActor;
		if (aCameraActor == null)
		{
			aCameraActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Owner.World, BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UClass>("/Game/00Main/Design/CameraSeq/BP_CameraActor_ForSeq.BP_CameraActor_ForSeq_C", ELoadResourceType.SyncLoadAndCache)) as ACameraActor;
		}
		aCameraActor.DetachFromActor();
		aCameraActor.SetActorLocationAndRotation(PlayerCameraManager.GetCameraLocation(), PlayerCameraManager.GetCameraRotation(), bSweep: false, out SweepHitResult, bTeleport: false);
		AActor aActor = null;
		if (PlaySettings.bAttachToUnit)
		{
			if (PlaySettings.DummyMeshAttachSocketName != FName.None)
			{
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(controlledPawn);
				BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, GetOwner(), PlaySettings.DummyMeshAttachSocketName, out var SocketOwnerComp);
				bUS_GSEventCollection?.Evt_SetSyncCamera.Invoke(SocketOwnerComp, aCameraActor, PlaySettings.DummyMeshAttachSocketName);
				if (SequencePlayer == null)
				{
					if (GetOwner() as ACharacter != null)
					{
						float totalDuration = PlaySettings.TotalDuration;
						CameraBlendForIBMTimer = totalDuration - PlaySettings.OutCameraBlendTime;
					}
				}
				else
				{
					aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Owner.World, BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UClass>("/Game/00Main/Design/CameraSeq/BP_CameraActor_ForSeq.BP_CameraActor_ForSeq_C", ELoadResourceType.SyncLoadAndCache));
					if (aActor != null)
					{
						BGU_UnrealActorUtil.AttachToActorSimple(aActor, aCameraActor, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
					}
				}
			}
			else
			{
				BGU_UnrealActorUtil.AttachToActorSimple(aCameraActor, Owner, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
			}
			CameraActorCache = new TWeakObject<ACameraActor>(aCameraActor);
			if (PlaySettings.AttachedCameraFOV > 0f)
			{
				int num6 = -1;
				for (int k = 0; k < aCameraActor.CameraComponent.ComponentTags.Count; k++)
				{
					FName defaultCameraFOVTag = aCameraActor.CameraComponent.ComponentTags[k];
					if (defaultCameraFOVTag.ToString().StartsWith(RefCameraFOVTagPrefix))
					{
						num6 = k;
						DefaultCameraFOVTag = defaultCameraFOVTag;
						break;
					}
				}
				if (num6 > -1)
				{
					aCameraActor.CameraComponent.ComponentTags.RemoveAt(num6);
					aCameraActor.CameraComponent.ComponentTags.Add(new FName(RefCameraFOVTagPrefix + PlaySettings.AttachedCameraFOV));
				}
			}
		}
		else
		{
			BGU_UnrealActorUtil.AttachToActorSimple(aCameraActor, SequenceActor, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
		}
		if (PlayerController.GetViewTarget() as ACameraActor == null)
		{
			ViewTargetCache = PlayerController.GetViewTarget();
		}
		PlayerController.SetViewTargetWithBlend((aActor == null) ? aCameraActor : aActor, PlaySettings.InCameraBlendTime, EViewTargetBlendFunction.VTBlend_EaseInOut, PlaySettings.InCameraBlendFactor);
		if (SequenceActor != null)
		{
			SequenceActor.BindActorByName(B1GlobalFNames.BP_CameraActor_ForSeq, aCameraActor);
			if (aActor != null)
			{
				Dictionary<FName, AActor> dictionary = new Dictionary<FName, AActor>();
				dictionary.Add(PlaySettings.ExtraCameraForSeqBindTag, aActor);
				SequenceActor.BindActorsByTag(dictionary);
			}
			SequencePlayer.Play();
			SequencePlayer.OnFinished.Bind(this, B1GlobalFNames.OnFinished);
			SequencePlayer.OnStop.Bind(this, B1GlobalFNames.OnFinished);
		}
	}

	private void OnDetachCameraInSkillSeq()
	{
		if (PlaySettings.bAttachToUnit && !(SequenceActor == null) && CameraActorCache.IsValid())
		{
			FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner);
			FTransform newTransform = FTransform.Identity;
			if (PlaySettings.RotationType == ESkillCameraRotationType.UseUnitRotation)
			{
				newTransform = fTransform;
			}
			else
			{
				newTransform.SetRotation(PlayerController.GetControlRotation().Quaternion());
				newTransform.SetLocation(PlayerController.GetActorLocation());
			}
			FRotator fRotator = newTransform.Rotation.Rotator();
			fRotator.Pitch = 0f;
			fRotator.Pitch = 0f;
			newTransform.SetRotation(fRotator.Quaternion());
			SequenceActor.SetActorTransform(newTransform, bSweep: false, out var _, bTeleport: false);
			BGU_UnrealActorUtil.AttachToActorSimple(CameraActorCache.Get(), SequenceActor, EAttachmentTransformRules.SnapToTargetNotIncludingScale);
		}
	}

	private void OnPauseSkillSequence()
	{
		if (SequencePlayer != null)
		{
			SequencePlayer.Pause();
		}
	}

	private void OnResumeSkillSequence()
	{
		if (SequencePlayer != null)
		{
			SequencePlayer.Play();
		}
	}

	private void OnStopSkillSequence()
	{
		if (SequencePlayer != null)
		{
			SequencePlayer.Stop();
			return;
		}
		OnFinished();
		CameraBlendForIBMTimer = 0f;
	}

	private void OnStopSkillSequenceWithBlendOutTime(float BlendOutTime)
	{
		FSkillSequencePlaySettings playSettings = PlaySettings;
		playSettings.OutCameraBlendTime = BlendOutTime;
		PlaySettings = playSettings;
		OnStopSkillSequence();
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (State == EMontageCallbackState.OnInterrupted && PlaySettings.bStopWhenMontageInterrupted)
		{
			OnStopSkillSequence();
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SkillSequenceComp:OnFinished")]
	private void OnFinished()
	{
		if (SequencePlayer != null)
		{
			SequencePlayer.OnFinished.Unbind(this, B1GlobalFNames.OnFinished);
			SequencePlayer.OnStop.Unbind(this, B1GlobalFNames.OnFinished);
			base.BGSEventCollection.Evt_PauseCurrentMovie -= new Del_Void(OnPauseSkillSequence);
			base.BGSEventCollection.Evt_ResumeCurrentMovie -= new Del_Void(OnResumeSkillSequence);
		}
		if (ViewTargetCache != null && PlaySettings.bEnableCameraAutoBlendOut)
		{
			BUS_EventCollectionCS.Get(ViewTargetCache)?.Evt_MoveCameraSpringArmRot2Nearest.Invoke();
			PlayerController.SetViewTargetWithBlend(ViewTargetCache, PlaySettings.OutCameraBlendTime, EViewTargetBlendFunction.VTBlend_EaseInOut, PlaySettings.OutCameraBlendFactor);
		}
		if (PlaySettings.bAttachToUnit && PlaySettings.AttachedCameraFOV > 0f && CameraActorCache.IsValid())
		{
			ACameraActor aCameraActor = CameraActorCache.Get();
			int num = -1;
			for (int i = 0; i < aCameraActor.CameraComponent.ComponentTags.Count; i++)
			{
				if (aCameraActor.CameraComponent.ComponentTags[i].ToString().StartsWith(RefCameraFOVTagPrefix))
				{
					num = i;
					break;
				}
			}
			if (num > -1)
			{
				aCameraActor.CameraComponent.ComponentTags.RemoveAt(num);
				aCameraActor.CameraComponent.ComponentTags.Add(DefaultCameraFOVTag);
			}
		}
		ViewTargetCache = null;
		CameraActorCache.Reset();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SkillSequenceComp:OnFinished")]
	private static void OnFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SkillSequenceComp bUS_SkillSequenceComp = GCHelper.Find<BUS_SkillSequenceComp>(obj);
		bUS_SkillSequenceComp.OnFinished();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_SkillSequenceComp");
		OnFinished_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnFinished");
		OnFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnFinished_FunctionAddress);
		OnFinished_IsValid = OnFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SkillSequenceComp:OnFinished", OnFinished_IsValid);
	}

	static BUS_SkillSequenceComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SkillSequenceComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SkillSequenceComp));
	}
}
