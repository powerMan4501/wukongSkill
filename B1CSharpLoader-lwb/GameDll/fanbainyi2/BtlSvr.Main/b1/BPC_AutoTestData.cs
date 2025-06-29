using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_AutoTestData : IBPC_AutoTestData, IPersistentECSData
{
	public EAINodeActionType CurrentActionType { get; set; }

	public EAutoMoveMode CurrentAutoMoveMode { get; set; }

	public FVector CurrentTargetLocation { get; set; } = FVector.ZeroVector;

	public bool IsForced { get; set; }

	public float Timer { get; set; }

	public float MaxActionTime { get; set; }

	public AActor CurEnemy { get; set; }

	public AActor CharacterCS { get; set; }
}
