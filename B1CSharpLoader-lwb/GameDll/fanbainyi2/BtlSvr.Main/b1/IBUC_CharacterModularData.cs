using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_CharacterModularData
{
	Dictionary<string, USkeletalMesh> EquipMeshesIndexByAttachSocket { get; }

	Dictionary<FName, string> EquipTagAndAttachSocketMapping { get; }

	Dictionary<EquipPosition, TStrongObjectPtr<USkeletalMeshComponent>> MapEquipSMC { get; }

	USkeletalMeshComponent TailMesh { get; }
}
