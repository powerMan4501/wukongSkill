using b1.BGW;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIADummyMeshAnim : BUInteractActionTemplate
{
	public BUIADummyMeshAnim()
	{
		ParamIntNum = 2;
		ParamStringNum = 3;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (Action.ParamsInt.Count > 0)
		{
			BUS_EventCollectionCS.Get(User).Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(Action.ParamsInt[0], ECastSkillSourceType.Interact));
		}
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage != null)
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
		}
		BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(InteractiveActor);
		float num = 0f;
		if (!string.IsNullOrEmpty(Action.CameraBlendTime))
		{
			num = StringParseHelper.SafeFloatParse(Action.CameraBlendTime.Split(',')[1]);
		}
		if (Action.ParamsString.Count > 2 && Action.ParamsString[2].Length > 0)
		{
			UAnimationAsset uAnimationAsset = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimationAsset>(Action.ParamsString[2], ELoadResourceType.SyncLoadAndCache);
			readOnlyData.BlendOutTimer = uAnimationAsset.GetPlayLength() - num;
			BGS_EventCollectionCS.Get(InteractiveActor).Evt_BGS_BeginInteractSyncAnimation.Invoke(InteractiveActor, User, in FName.None, new FName(Action.ParamsString[1]), uAnimationAsset);
		}
		if (Action.ParamsInt.Count > 1 && Action.ParamsInt[1] > 0)
		{
			FMovieSceneSequencePlaybackSettings playbackSettings = new FMovieSceneSequencePlaybackSettings
			{
				AutoPlay = false,
				PlayRate = 1f,
				StartTime = 0f,
				RandomStartTime = false,
				RestoreState = false,
				DisableMovementInput = true,
				DisableLookAtInput = true,
				HidePlayer = false,
				HideHud = true,
				DisableCameraCuts = false,
				PauseAtEnd = false
			};
			FLevelSequenceCameraSettings cameraSettings = new FLevelSequenceCameraSettings
			{
				AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
				OverrideAspectRatioAxisConstraint = false
			};
			FMovieGraphPlaySettings inPlaySettings = new FMovieGraphPlaySettings
			{
				PlaybackSettings = playbackSettings,
				CameraSettings = cameraSettings,
				bUsePlayerCamera = false
			};
			BGS_EventCollectionCS.Get(User).Evt_PlayMovieInstance.Invoke(Action.ParamsInt[1], MovieInstance.Create(User, Action.ParamsInt[1], inPlaySettings));
		}
		return true;
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		USkeletalMeshComponent uSkeletalMeshComponent = null;
		foreach (UActorComponent item in InteractiveActor.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			if (item.IsA<USkeletalMeshComponent>() && item.ComponentHasTag(B1GlobalFNames.master))
			{
				uSkeletalMeshComponent = item as USkeletalMeshComponent;
			}
		}
		if (Action == null || !(uSkeletalMeshComponent != null))
		{
			return;
		}
		if (Action.ParamsString[0].Length > 0)
		{
			UAnimInstance animInstance = uSkeletalMeshComponent.GetAnimInstance();
			if (animInstance == null)
			{
				return;
			}
			animInstance.Montage_Stop(0f, null);
		}
		bool p = Action.ParamsBool == EGSYesNo.Yes;
		BGS_EventCollectionCS.Get(InteractiveActor).Evt_BGS_EndInteractSyncAnimation.Invoke(InteractiveActor, p);
	}

	public override void OnFinishInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		bool p = Action.ParamsBool == EGSYesNo.Yes;
		BGS_EventCollectionCS.Get(InteractiveActor)?.Evt_BGS_EndInteractSyncAnimation.Invoke(InteractiveActor, p);
	}

	public override void UpdateIdle(AActor InteractiveActor, FUStInteractionMappingDesc Action, EBGUInteractUnitState State)
	{
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage != null)
		{
			float playLength = uAnimMontage.GetPlayLength();
			BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact, 1f, 0f, (State == EBGUInteractUnitState.AfterInactive) ? playLength : 0f);
		}
	}
}
