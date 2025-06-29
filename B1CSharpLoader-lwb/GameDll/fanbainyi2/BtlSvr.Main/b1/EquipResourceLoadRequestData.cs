using System.Collections.Generic;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class EquipResourceLoadRequestData
{
	public int RequestID { get; set; }

	public string SkeletalMeshPath { get; set; }

	public string ABPClassPath { get; set; }

	public string AttachSocketName { get; set; }

	public ECharacterModularType ModularType { get; set; }

	public bool bHideTail { get; set; }

	public TStrongObjectPtr<USkeletalMesh> SkeletalMeshObj { get; set; }

	public TStrongObjectPtr<UClass> ABPClassObj { get; set; }

	public Dictionary<string, TStrongObjectPtr<UStaticMesh>> StaticMesh { get; set; }
}
