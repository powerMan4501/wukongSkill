using System.Collections.Generic;
using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PatrolData : IBUC_PatrolData
{
	private TStrongObjectPtr<BGWDataAsset_AbpHumanoidSetting> mABPSettingForPatrol = new TStrongObjectPtr<BGWDataAsset_AbpHumanoidSetting>();

	public EGroupPatrolType GroupPatrolType;

	public string GroupSplineActorGuid;

	public USplineComponent GroupSpline;

	public int TargetGroupSplinePoint;

	public string GroupLeaderGuid;

	public FVector GroupRelativeLocation;

	public bool IsGroupOnWaitPoint;

	[GSGameDataSnapShot]
	public EPatrolType PatrolType { get; set; }

	[GSGameDataSnapShot]
	public bool bDisableRestartOnLeaveFight { get; set; }

	[GSGameDataSnapShot]
	public bool bDisableRestartOnReset { get; set; }

	public EState_MM MotionMatchingState { get; set; }

	public EBGUMoveAIType FindPathMoveType { get; set; }

	public EAIMoveSpeedType PatrolMoveSpeedType { get; set; }

	public bool bEnablePatrolOnStart { get; set; }

	public int PatrolBuff { get; set; }

	public BGWDataAsset_AbpHumanoidSetting ABPSettingForPatrol
	{
		get
		{
			return mABPSettingForPatrol.Get();
		}
		set
		{
			mABPSettingForPatrol.Set(value);
		}
	}

	public bool bPatrolStarted { get; set; }

	public bool bPatrolNeedRetry { get; set; }

	public bool bNeedDelayInit { get; set; }

	public float MoveAcceptableRadius { get; set; }

	public GSWaitAMConfig StartWaitAMConfig { get; set; }

	public GSTurnSkillConfig TurnSkillConfig { get; set; }

	public GSRandomPatrolConfig RandomPatrolConfig { get; set; }

	public GSSplinePatrolConfig SplinePatrolConfig { get; set; }

	public GSMultiSplinePatrolConfig MultiSplinePatrolConfig { get; set; }

	public GSLeisureConfig LeisureConfig { get; set; }

	public GSGroupPatrolConfig GroupPatrolConfig { get; set; }

	public string FollowTargetGuid { get; set; } = "";

	public FVector FollowRelativeLocation { get; set; }

	public Dictionary<Entity, FVector> FollowerRelativeLocationMap { get; set; } = new Dictionary<Entity, FVector>();

	public float FindPathDistance { get; set; }

	public bool bGroupMemberPauseFindPath { get; set; }

	public bool bIsPatroling { get; set; }

	public bool bIsInLeisure { get; set; }

	public FVector StartLeisureLocation { get; set; } = FVector.ZeroVector;

	public int LeisureLoopCount { get; set; }

	public Dictionary<int, float> LeisureRandomCDTimer { get; set; } = new Dictionary<int, float>();

	public int LastLeisureRandomIndex { get; set; }

	public List<int> HasCDIndex { get; } = new List<int>();

	public uint CustomTimeDilationHandleID { get; set; }

	public uint GravityScaleHandleID { get; set; }

	public bool bPendingMoveRequest { get; set; }

	public FVector PendingTargetLocation { get; set; }

	public HashSet<int> FinishedMovieSequenceBeforeReset { get; set; } = new HashSet<int>();

	public void CopyBPDataToData(EPatrolType patrolType, bool disableRestartOnLeaveFight, bool disableRestartOnReset, EState_MM motionMatchingState, EBGUMoveAIType moveAIType, EAIMoveSpeedType patrolMoveSpeedType, bool enablePatrolOnStart, int patrolBuff, BGWDataAsset_AbpHumanoidSetting abpSettingForPatrol, float moveAcceptableRadius, float startWaitAMProbability, IList<UAnimMontage> startWaitAM, in FGSTurnSkillConfig turnSkillConfig, in FRandomPatrolConfig randomPatrolConfig, in FGSSplinePatrolConfig splinePatrolConfig, in FGSMultiSplinePatrolConfig multiSplinePatrolConfig, in FGSLeisureConfig leisureConfig, in FFollowPatrolConfig followPatrolConfig, in FGSGroupPatrolConfig groupPatrolConfig)
	{
		PatrolType = patrolType;
		bDisableRestartOnLeaveFight = disableRestartOnLeaveFight;
		bDisableRestartOnReset = disableRestartOnReset;
		MotionMatchingState = motionMatchingState;
		FindPathMoveType = moveAIType;
		PatrolMoveSpeedType = patrolMoveSpeedType;
		bEnablePatrolOnStart = enablePatrolOnStart;
		PatrolBuff = patrolBuff;
		ABPSettingForPatrol = abpSettingForPatrol;
		MoveAcceptableRadius = moveAcceptableRadius;
		StartWaitAMConfig = new GSWaitAMConfig(startWaitAMProbability, startWaitAM);
		TurnSkillConfig = new GSTurnSkillConfig(in turnSkillConfig);
		RandomPatrolConfig = new GSRandomPatrolConfig(in randomPatrolConfig);
		SplinePatrolConfig = new GSSplinePatrolConfig(in splinePatrolConfig);
		MultiSplinePatrolConfig = new GSMultiSplinePatrolConfig(in multiSplinePatrolConfig);
		LeisureConfig = new GSLeisureConfig(in leisureConfig);
		FollowTargetGuid = BGU_DataUtil.GetActorGuid(followPatrolConfig.FollowTarget, bFindFromComponent: true);
		GroupPatrolConfig = new GSGroupPatrolConfig(in groupPatrolConfig);
	}

	public bool HasReplaceLeisureSequenceID()
	{
		if (LeisureConfig.ReplaceLeisureSequenceID <= 0)
		{
			return false;
		}
		return !FinishedMovieSequenceBeforeReset.Contains(LeisureConfig.ReplaceLeisureSequenceID);
	}
}
