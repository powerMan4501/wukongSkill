using UnrealEngine.Runtime;

namespace b1;

public class AINodeAction_SpiderMoveToParamInfo : IAINodeActionInfo
{
	public float MaxMoveTime { get; set; }

	public float AcceptableRadius { get; set; }

	public bool IncludeSelfRadius { get; set; }

	public bool IncludeTargetRadius { get; set; }

	public EBTTargetType BTTargetType { get; set; }

	public ESpiderNavPositionType TargetPositionType { get; set; }

	public FVector TargetLocation { get; set; }

	public FVector TargetNormal { get; set; }

	public EAIMoveSpeedType SpeedRateType { get; set; }
}
