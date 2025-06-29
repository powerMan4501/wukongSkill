using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class AINodeAction_MoveToParamInfo : IAINodeActionInfo
{
	public float MaxMoveTime { get; set; }

	public float AcceptableRadius { get; set; }

	public bool IncludeSelfRadius { get; set; }

	public bool IncludeTargetRadius { get; set; }

	public EBTTargetType BTTargetType { get; set; }

	public FVector TargetLocation { get; set; }

	public EBGUMoveAIType MoveAIType { get; set; }

	public EAIMoveSpeedType SpeedRateType { get; set; }

	public UCurveFloat SpeedRateDistanceCurve { get; set; }

	public bool EnableRangeAcceptableRadius { get; set; }

	public float MinAcceptableRadius { get; set; }

	public float MaxAcceptableRadius { get; set; }

	public bool DynamicChangeMoveTypeAndSpeedType { get; set; }

	public int DCParam_Switch2KFTDistance { get; set; } = 800;

	public int DCParam_Switch2MoveToDistance { get; set; } = 1000;
}
