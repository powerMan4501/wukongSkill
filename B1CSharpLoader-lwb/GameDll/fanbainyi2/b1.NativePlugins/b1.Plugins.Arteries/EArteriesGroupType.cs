using UnrealEngine.Runtime;

namespace b1.Plugins.Arteries;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Arteries.EArteriesGroupType", "Arteries", UnrealModuleType.GamePlugin)]
public enum EArteriesGroupType : byte
{
	Point,
	Primitive,
	Object
}
