using BtlB1;
using BtlShare;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIAXiShuaiSpecial : BUInteractActionTemplate
{
	public BUIAXiShuaiSpecial()
	{
		ParamIntNum = 3;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		bool flag = false;
		ACharacter aCharacter = User as ACharacter;
		if (aCharacter == null)
		{
			BGW_LogUtil.LogError("[BUIAXiShuaiSpecial] DoInteractAction CurPlayer == null");
			return false;
		}
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(aCharacter.GetController());
		if (readOnlyData == null)
		{
			BGW_LogUtil.LogError("[BUIAXiShuaiSpecial] DoInteractAction PlayerRoleData == null");
			return false;
		}
		ReadOnlyRoleEquip wearEquipByPosition = RoleDataHelper.GetWearEquipByPosition(readOnlyData.RoleData.RoleCs, EquipPosition.Arm);
		if (wearEquipByPosition != null && wearEquipByPosition.EquipId == 10503)
		{
			flag = true;
		}
		else
		{
			IBUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(User);
			if (readOnlyData2 == null)
			{
				BGW_LogUtil.LogError("[BUIAXiShuaiSpecial] CalcElemDmgMultiplierV2 AttrContainer == null");
				return false;
			}
			int num = Action.ParamsInt[0];
			float num2 = CalcElemDmgMultiplierV2(EAbnormalStateType.Abnormal_Burn, readOnlyData2);
			float num3 = (float)num * num2;
			float floatValue = readOnlyData2.GetFloatValue(EBGUAttrFloat.Hp);
			if (num3 < floatValue)
			{
				flag = true;
			}
		}
		int num4 = (flag ? Action.ParamsInt[1] : Action.ParamsInt[2]);
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
		BGS_EventCollectionCS.Get(User).Evt_PlayMovieInstance.Invoke(num4, MovieInstance.Create(User, num4, inPlaySettings));
		return true;
	}

	private float CalcElemDmgMultiplierV2(EAbnormalStateType ElemAtkType, IBUC_AttrContainer AttrContainer)
	{
		if (ElemAtkType == EAbnormalStateType.None)
		{
			return 1f;
		}
		float num = 0f;
		switch (ElemAtkType)
		{
		case EAbnormalStateType.Abnormal_Freeze:
			num = AttrContainer.GetFloatValue(EBGUAttrFloat.FreezeDef);
			break;
		case EAbnormalStateType.Abnormal_Burn:
			num = AttrContainer.GetFloatValue(EBGUAttrFloat.BurnDef);
			break;
		case EAbnormalStateType.Abnormal_Poison:
			num = AttrContainer.GetFloatValue(EBGUAttrFloat.PoisonDef);
			break;
		case EAbnormalStateType.Abnormal_Thunder:
			num = AttrContainer.GetFloatValue(EBGUAttrFloat.ThunderDef);
			break;
		}
		return FMath.Clamp(1f - num / 100f, 0.3f, 3f);
	}
}
