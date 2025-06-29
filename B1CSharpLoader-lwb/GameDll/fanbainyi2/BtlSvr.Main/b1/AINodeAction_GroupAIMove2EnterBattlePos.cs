using UnrealEngine.Engine;

namespace b1;

public class AINodeAction_GroupAIMove2EnterBattlePos : IAINodeActionInfo
{
	public float MaxMoveTime { get; set; }

	public float AcceptableRadius { get; set; }

	public bool IncludeSelfRadius { get; set; }

	public bool IncludeTargetRadius { get; set; }

	public EBGUMoveAIType MoveAIType { get; set; }

	public EAIMoveSpeedType SpeedRateType { get; set; }

	public UCurveFloat SpeedRateDistanceCurve { get; set; }

	public bool EnableRangeAcceptableRadius { get; set; }

	public float MinAcceptableRadius { get; set; }

	public float MaxAcceptableRadius { get; set; }

	public bool DynamicChangeMoveTypeAndSpeedType { get; set; }

	public int DCParam_Switch2KFTDistance { get; set; } = 1000;

	public int DCParam_Switch2MoveToDistance { get; set; } = 800;
}
