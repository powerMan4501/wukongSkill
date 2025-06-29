using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_PerformerEquipData
{
	public bool bUseMergeMesh { get; set; }

	public TWeakObject<USkeletalMeshComponent> MasterMeshComponent { get; set; }

	public Dictionary<FName, TWeakObject<USkeletalMeshComponent>> TaggedMeshComponents { get; } = new Dictionary<FName, TWeakObject<USkeletalMeshComponent>>();
}
