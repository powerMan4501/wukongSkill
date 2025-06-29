using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using BtlShare;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIADaShengEquipOpen : BUInteractActionTemplate
{
	private bool IsPassCondition = true;

	public BUIADaShengEquipOpen()
	{
		ParamIntNum = 3;
		ParamStringNum = 3;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		ACharacter aCharacter = User as ACharacter;
		if (aCharacter == null)
		{
			BGW_LogUtil.LogError("[BUIDaShengEquipOpen] DoInteractAction CurPlayer == null");
			return false;
		}
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(aCharacter.GetController());
		if (readOnlyData == null)
		{
			BGW_LogUtil.LogError("[BUIDaShengEquipOpen] DoInteractAction PlayerRoleData == null");
			return false;
		}
		Dictionary<EquipPosition, int> obj = new Dictionary<EquipPosition, int>
		{
			{
				EquipPosition.Head,
				12001
			},
			{
				EquipPosition.Upwear,
				12002
			},
			{
				EquipPosition.Arm,
				12003
			},
			{
				EquipPosition.Foot,
				12004
			}
		};
		IsPassCondition = true;
		foreach (KeyValuePair<EquipPosition, int> item in obj)
		{
			ReadOnlyRoleEquip wearEquipByPosition = RoleDataHelper.GetWearEquipByPosition(readOnlyData.RoleData.RoleCs, item.Key);
			if (wearEquipByPosition == null || wearEquipByPosition.EquipId != item.Value)
			{
				IsPassCondition = false;
				break;
			}
		}
		if (IsPassCondition)
		{
			Action.ResetAction = EGSYesNo.No;
			int num = Action.ParamsInt[2];
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
				DisableCameraCuts = (Action.ParamsBool == EGSYesNo.Yes),
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
			BGS_EventCollectionCS.Get(User).Evt_PlayMovieInstance.Invoke(num, MovieInstance.Create(User, num, inPlaySettings));
		}
		else
		{
			Action.ResetAction = EGSYesNo.Yes;
			if (Action.ParamsInt.Count > 0)
			{
				BUS_EventCollectionCS.Get(User).Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(Action.ParamsInt[0], ECastSkillSourceType.Interact));
			}
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
				InteractiveActor.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
			}
			BUC_InteractData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(InteractiveActor);
			float num2 = 0f;
			if (!string.IsNullOrEmpty(Action.CameraBlendTime))
			{
				num2 = StringParseHelper.SafeFloatParse(Action.CameraBlendTime.Split(',')[1]);
			}
			if (Action.ParamsBool == EGSYesNo.No && Action.ParamsString.Count > 2 && Action.ParamsString[2].Length > 0)
			{
				UAnimationAsset uAnimationAsset = BGW_PreloadAssetMgr.Get(User).TryGetCachedResourceObj<UAnimationAsset>(Action.ParamsString[2], ELoadResourceType.SyncLoadAndCache);
				readOnlyData2.BlendOutTimer = uAnimationAsset.GetPlayLength() - num2;
				BGS_EventCollectionCS.Get(User).Evt_BGS_BeginInteractSyncAnimation.Invoke(User, InteractiveActor, in FName.None, new FName(Action.ParamsString[1]), uAnimationAsset);
			}
			if (Action.ParamsBool == EGSYesNo.Yes && Action.ParamsString.Count > 2 && Action.ParamsString[2].Length > 0)
			{
				UAnimationAsset uAnimationAsset2 = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimationAsset>(Action.ParamsString[2], ELoadResourceType.SyncLoadAndCache);
				readOnlyData2.BlendOutTimer = uAnimationAsset2.GetPlayLength() - num2;
				BGS_EventCollectionCS.Get(InteractiveActor).Evt_BGS_BeginInteractSyncAnimation.Invoke(InteractiveActor, User, in FName.None, new FName(Action.ParamsString[1]), uAnimationAsset2);
			}
			if (Action.ParamsInt.Count > 1 && Action.ParamsInt[1] > 0)
			{
				FMovieSceneSequencePlaybackSettings playbackSettings2 = new FMovieSceneSequencePlaybackSettings
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
				FLevelSequenceCameraSettings cameraSettings2 = new FLevelSequenceCameraSettings
				{
					AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
					OverrideAspectRatioAxisConstraint = false
				};
				FMovieGraphPlaySettings inPlaySettings2 = new FMovieGraphPlaySettings
				{
					PlaybackSettings = playbackSettings2,
					CameraSettings = cameraSettings2,
					bUsePlayerCamera = false
				};
				BGS_EventCollectionCS.Get(User).Evt_PlayMovieInstance.Invoke(Action.ParamsInt[1], MovieInstance.Create(User, Action.ParamsInt[1], inPlaySettings2));
			}
		}
		return true;
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (IsPassCondition)
		{
			return;
		}
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
		if (!IsPassCondition)
		{
			bool p = Action.ParamsBool == EGSYesNo.Yes;
			BGS_EventCollectionCS.Get(InteractiveActor).Evt_BGS_EndInteractSyncAnimation.Invoke(InteractiveActor, p);
		}
	}

	public override void UpdateIdle(AActor InteractiveActor, FUStInteractionMappingDesc Action, EBGUInteractUnitState State)
	{
		if (!IsPassCondition)
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				float playLength = uAnimMontage.GetPlayLength();
				BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact, 1f, 0f, (State == EBGUInteractUnitState.AfterInactive) ? playLength : 0f);
			}
		}
	}
}
