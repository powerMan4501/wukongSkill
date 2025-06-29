using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBUHandFootType", "b1", UnrealModuleType.Game)]
public enum EBUHandFootType : byte
{
	None,
	LeftHand,
	RightHand,
	LeftFoot,
	RightFoot
}
