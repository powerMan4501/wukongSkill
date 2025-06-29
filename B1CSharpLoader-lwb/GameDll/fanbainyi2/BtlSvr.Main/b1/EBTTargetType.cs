using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EBTTargetType")]
public enum EBTTargetType : byte
{
	Target,
	Player,
	SceneItem,
	Location,
	AlignToCamFwd,
	None
}
