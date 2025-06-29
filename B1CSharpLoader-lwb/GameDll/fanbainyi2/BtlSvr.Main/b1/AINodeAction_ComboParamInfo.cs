using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class AINodeAction_ComboParamInfo : IAINodeActionInfo
{
	public EComboTargetType ComboTargetType { get; set; }

	public EZatoichiSkillSourceType SkillSourceType { get; set; }

	public bool PursuitAnyWhere { get; set; }

	public bool PursuitInAllSkill { get; set; }

	public bool CanUpdateComboTargetWhenPursuit { get; set; }

	public bool ForceCastSkillAfterPursuitFailed { get; set; }

	public float PursuitRangePos { get; set; }

	public EAIMoveSpeedType SpeedRateType { get; set; }

	public EState_MM MotionMatchingMoveMode { get; set; }

	public EBGUMoveAIType MoveAIType { get; set; }

	public EBGUMoveAcceptableRadiusType MoveAcceptableRadiusType { get; set; }

	public float BeginRotateAngle { get; set; }

	public bool IsUseSkillForTurn { get; set; }

	public bool IsUseSkillForMove { get; set; }

	public float BeginMoveDistanceWhenUseSkill { get; set; }

	public bool EnableInterruptReduceCBNum { get; set; }

	public bool CanCheckCastSkillDuringWholeComboWindow { get; set; }

	public bool NeedTraceHitTargetBefore { get; set; }

	public bool EnableForceComboRelation { get; set; }

	public bool EnableComboCondition { get; set; }

	public float TraceDistance { get; set; }

	public ETraceTypeQuery TraceTypeQuery { get; set; }

	public bool IsGetTopRandomSkill { get; set; }

	public int TopRandomSkillPercent { get; set; }

	public List<FComboSkill> SkillArray { get; set; } = new List<FComboSkill>();

	public bool IsGetAdvanceComboLength { get; set; }

	public List<FComboSkillNumInfo> ComboSkillNumInfo { get; set; } = new List<FComboSkillNumInfo>();

	public bool bCanBeForceAbort { get; set; }

	public bool bCanBeInterruptedByHRCounterattack { get; set; }

	public bool UseSocketDirection { get; set; }

	public FName DirectionBaseSocket { get; set; }

	public FName ForwardSocket { get; set; }

	public FName RightSocket { get; set; }

	public EEscapeSkillConfigMode SkillConfigMode { get; set; }

	public List<int> SingleDirectionSkills { get; set; } = new List<int>();

	public int AvoidObstacleSectionNum { get; set; }

	public float SectionsStartAngle { get; set; }

	public float IntervalAngle { get; set; }

	public List<FAvoidObstacleSection> AvoidObstacleSections { get; set; } = new List<FAvoidObstacleSection>();
}
