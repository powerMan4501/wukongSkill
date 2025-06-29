using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EAIRequestType")]
public enum EAIRequestType : byte
{
	MoveToLoc,
	MoveToActor,
	DirDamage,
	MoveSkill
}
