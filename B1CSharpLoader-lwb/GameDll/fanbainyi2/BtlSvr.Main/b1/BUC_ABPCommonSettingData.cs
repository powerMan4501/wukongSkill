using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPCommonSettingData : IBUC_ABPCommonSettingData
{
	private float ExitPatrolTimer;

	private bool IsPatrol;

	private IBUC_PatrolData PatrolLogicData;

	private IBUC_NPCAnimData NPCAnimLogicData;

	public EABPMoveMode FinalABPMoveMode { get; set; }

	public UAnimSequence AnimIdle { get; set; }

	public List<UAnimSequence> ExtendAnimIdleList { get; set; }

	public UAnimSequence DefaultAnimIdle { get; set; }

	public List<UAnimSequence> DefaultExtendAnimIdleList { get; set; }

	public UBlendSpace BSStart { get; set; }

	public UBlendSpace BSEnd { get; set; }

	public UBlendSpace BSWalkFwd { get; set; }

	public UBlendSpace BSWalkBwd { get; set; }

	public UBlendSpace BSWalkLeft { get; set; }

	public UBlendSpace BSWalkRight { get; set; }

	public UBlendSpace BSRunFwd { get; set; }

	public UBlendSpace BSRunBwd { get; set; }

	public UBlendSpace BSRunLeft { get; set; }

	public UBlendSpace BSRunRight { get; set; }

	public UBlendSpace BSSprint { get; set; }

	public bool bLockUseFreeMode { get; set; }

	public float AnimTurnMinAngle { get; set; }

	public UAnimSequence AnimTurnInPlaceLeft { get; set; }

	public UAnimSequence AnimTurnInPlaceRight { get; set; }

	public UAnimSequence AnimTurnInPlaceLeft180 { get; set; }

	public UAnimSequence AnimTurnInPlaceRight180 { get; set; }

	public bool bTurnAnimValid { get; set; }

	public float CardinalDirectionBlendTime { get; set; }

	public void Init(BUABPSettingData Setting, IBUC_PatrolData InPatrolLogicData, IBUC_NPCAnimData InNPCAnimLogicData, IBUC_ABPMotionMatchingData MMData)
	{
		PatrolLogicData = InPatrolLogicData;
		NPCAnimLogicData = InNPCAnimLogicData;
		BUABPCommonSettingData commonSetting = Setting.CommonSetting;
		BUABPMotionMatchingSettingData motionMatchingSetting = Setting.MotionMatchingSetting;
		EABPMoveMode eABPMoveMode = commonSetting.ABPMoveMode;
		if (eABPMoveMode == EABPMoveMode.MotionMatching)
		{
			eABPMoveMode = motionMatchingSetting.SpareMoveMode;
		}
		DefaultExtendAnimIdleList = new List<UAnimSequence>();
		DefaultAnimIdle = commonSetting.AnimSeqIdle;
		FinalABPMoveMode = ((commonSetting.ABPMoveMode == EABPMoveMode.MotionMatching && MMData.MotionMatchingState == EState_MM.None) ? motionMatchingSetting.SpareMoveMode : commonSetting.ABPMoveMode);
		AnimIdle = DefaultAnimIdle;
		bLockUseFreeMode = commonSetting.bLockUseFreeMode;
		AnimTurnMinAngle = commonSetting.AnimTurnMinAngle;
		AnimTurnInPlaceLeft = commonSetting.AnimTurnLeft90;
		AnimTurnInPlaceRight = commonSetting.AnimTurnRight90;
		AnimTurnInPlaceLeft180 = commonSetting.AnimTurnLeft180;
		AnimTurnInPlaceRight180 = commonSetting.AnimTurnRight180;
		AnimTurnInPlaceLeft180 = ((AnimTurnInPlaceLeft180 == null) ? AnimTurnInPlaceLeft : AnimTurnInPlaceLeft180);
		AnimTurnInPlaceRight180 = ((AnimTurnInPlaceRight180 == null) ? AnimTurnInPlaceRight : AnimTurnInPlaceRight180);
		bTurnAnimValid = AnimTurnInPlaceLeft != null && AnimTurnInPlaceRight != null && AnimTurnInPlaceLeft180 != null && AnimTurnInPlaceRight180 != null;
		switch (eABPMoveMode)
		{
		case EABPMoveMode.Locomotion_Simple4Dir:
		{
			BUABPSimple4DirSettingData simple4DirSetting = Setting.Simple4DirSetting;
			BSStart = simple4DirSetting.BSStart;
			BSEnd = simple4DirSetting.BSEnd;
			BSWalkFwd = simple4DirSetting.BSWalkFwd;
			BSWalkBwd = simple4DirSetting.BSWalkBwd;
			BSWalkLeft = simple4DirSetting.BSWalkLeft;
			BSWalkRight = simple4DirSetting.BSWalkRight;
			BSRunFwd = simple4DirSetting.BSRunFwd;
			BSRunBwd = simple4DirSetting.BSRunBwd;
			BSRunLeft = simple4DirSetting.BSRunLeft;
			BSRunRight = simple4DirSetting.BSRunRight;
			BSSprint = simple4DirSetting.BSSprint;
			CardinalDirectionBlendTime = simple4DirSetting.CardinalDirectionBlendTime;
			break;
		}
		case EABPMoveMode.PlayerLocomotion:
			DefaultExtendAnimIdleList.AddRange(Setting.PlayerLocomotionSetting.ASIdleList);
			break;
		case EABPMoveMode.AdvancedMonsterLocomotion:
			DefaultExtendAnimIdleList.AddRange(Setting.AdvancedMonsterLocomotionSetting.ASIdleList);
			break;
		case EABPMoveMode.QuadrupedLocomotion:
			DefaultExtendAnimIdleList.AddRange(Setting.QuadrupedLocomotionSetting.AnimIdleList);
			break;
		}
		if (DefaultAnimIdle != null && DefaultExtendAnimIdleList.Count == 0)
		{
			DefaultExtendAnimIdleList.Add(DefaultAnimIdle);
		}
		if (DefaultExtendAnimIdleList.Count > 0 && DefaultAnimIdle == null)
		{
			DefaultAnimIdle = DefaultExtendAnimIdleList[0];
		}
		ExtendAnimIdleList = DefaultExtendAnimIdleList;
	}

	public void Update(AActor Owner, IBUC_ABPHelperData HelperData, IBUC_ABPPatrolData PatrolData, IBUC_ABPNPCAnimData NPCAnimData, IBUC_ABPMotionMatchingData MMData, float DeltaTime)
	{
		BUABPSettingData aBPSettingData = HelperData.ABPSettingData;
		FinalABPMoveMode = ((aBPSettingData.CommonSetting.ABPMoveMode == EABPMoveMode.MotionMatching && MMData.MotionMatchingState == EState_MM.None) ? aBPSettingData.MotionMatchingSetting.SpareMoveMode : aBPSettingData.CommonSetting.ABPMoveMode);
		UAnimSequence ResultAnimIdle = DefaultAnimIdle;
		List<UAnimSequence> ResultExtendAnimIdleList = DefaultExtendAnimIdleList;
		UpdateNPC(NPCAnimData, ref ResultAnimIdle, ref ResultExtendAnimIdleList);
		UpdatePatrol(Owner, PatrolData, ref ResultAnimIdle, ref ResultExtendAnimIdleList, DeltaTime);
		AnimIdle = ResultAnimIdle;
		ExtendAnimIdleList = ResultExtendAnimIdleList;
	}

	private void UpdatePatrol(AActor Owner, IBUC_ABPPatrolData PatrolData, ref UAnimSequence ResultAnimIdle, ref List<UAnimSequence> ResultExtendAnimIdleList, float DeltaTime)
	{
		if (PatrolData.BSRunFwd == null && PatrolData.BSRunBwd == null && PatrolData.BSRunLeft == null && PatrolData.BSRunRight == null && PatrolData.BSWalkFwd == null && PatrolData.BSWalkBwd == null && PatrolData.BSWalkLeft == null && PatrolData.BSWalkRight == null && PatrolData.AnimIdleList.Count == 0)
		{
			return;
		}
		if (ExitPatrolTimer <= 0f)
		{
			bool bIsPatroling = PatrolLogicData.bIsPatroling;
			if (!bIsPatroling && IsPatrol)
			{
				ExitPatrolTimer = 0.5f;
			}
			else if (bIsPatroling)
			{
				ExitPatrolTimer = 0f;
				IsPatrol = true;
			}
		}
		else
		{
			ExitPatrolTimer -= DeltaTime;
			if (ExitPatrolTimer <= 0f)
			{
				ExitPatrolTimer = 0f;
				IsPatrol = false;
			}
		}
		ResultAnimIdle = ((IsPatrol && PatrolData.AnimIdleList.Count > 0) ? PatrolData.AnimIdleList[0] : ResultAnimIdle);
		ResultExtendAnimIdleList = ((IsPatrol && PatrolData.AnimIdleList.Count > 0) ? PatrolData.AnimIdleList : ResultExtendAnimIdleList);
		BSRunFwd = ((IsPatrol && PatrolData.BSRunFwd != null) ? PatrolData.BSRunFwd : PatrolData.DefaultBSRunFwd);
		BSRunBwd = ((IsPatrol && PatrolData.BSRunBwd != null) ? PatrolData.BSRunBwd : PatrolData.DefaultBSRunBwd);
		BSRunLeft = ((IsPatrol && PatrolData.BSRunLeft != null) ? PatrolData.BSRunLeft : PatrolData.DefaultBSRunLeft);
		BSRunRight = ((IsPatrol && PatrolData.BSRunRight != null) ? PatrolData.BSRunRight : PatrolData.DefaultBSRunRight);
		BSWalkFwd = ((IsPatrol && PatrolData.BSWalkFwd != null) ? PatrolData.BSWalkFwd : PatrolData.DefaultBSWalkFwd);
		BSWalkBwd = ((IsPatrol && PatrolData.BSWalkBwd != null) ? PatrolData.BSWalkBwd : PatrolData.DefaultBSWalkBwd);
		BSWalkLeft = ((IsPatrol && PatrolData.BSWalkLeft != null) ? PatrolData.BSWalkLeft : PatrolData.DefaultBSWalkLeft);
		BSWalkRight = ((IsPatrol && PatrolData.BSWalkRight != null) ? PatrolData.BSWalkRight : PatrolData.DefaultBSWalkRight);
	}

	private void UpdateNPC(IBUC_ABPNPCAnimData NPCAnimData, ref UAnimSequence ResultAnimIdle, ref List<UAnimSequence> ResultExtendAnimIdleList)
	{
		if (NPCAnimData != null && NPCAnimData.AnimIdleList != null)
		{
			ResultAnimIdle = ((NPCAnimLogicData.IsTriggerReplaceIdleAnim && NPCAnimData.AnimIdleList.Count > 0) ? NPCAnimData.AnimIdleList[0] : ResultAnimIdle);
			ResultExtendAnimIdleList = ((NPCAnimLogicData.IsTriggerReplaceIdleAnim && NPCAnimData.AnimIdleList.Count > 0) ? NPCAnimData.AnimIdleList : ResultExtendAnimIdleList);
		}
	}
}
