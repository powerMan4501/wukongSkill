using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSSweepCheckShapeType", "b1", UnrealModuleType.Game)]
public enum EGSSweepCheckShapeType : byte
{
	Zero,
	BoxShape,
	SphereShape,
	CapsuleShape
}
