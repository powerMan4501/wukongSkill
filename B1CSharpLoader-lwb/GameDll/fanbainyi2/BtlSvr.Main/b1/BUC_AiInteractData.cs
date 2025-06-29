using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AiInteractData : IBUC_AiInteractData, IPersistentECSDataWithDestroyCB, IPersistentECSData
{
	public EntitySharedRef BestInteractEntityRef { get; set; }

	public Entity CurrentInteractingEntityRef { get; set; }

	public USkeletalMeshComponent MatchingPointDummyMesh { get; set; }

	public FName MatchingPointDummyMeshSocket { get; set; }

	public FTransform MatchingPosTargetTransform { get; set; }

	public UCurveFloat SpeedRateDistanceCurve { get; set; }

	public bool bUsingInteractSkill { get; set; }

	public FUStInteractiveUnitCommDesc InteractiveUnitCommDesc { get; set; }

	public FUStInteractionMappingDesc InteractActionDesc { get; set; }

	public FUStAiInteractionMappingDesc AiInteractionMappingDesc { get; set; }

	public float StartInteractTime { get; set; }

	public bool IsTriggerBreak { get; set; }

	public void OnUnPersistentDestroy()
	{
		BestInteractEntityRef = null;
		CurrentInteractingEntityRef = Entity.Null;
	}
}
