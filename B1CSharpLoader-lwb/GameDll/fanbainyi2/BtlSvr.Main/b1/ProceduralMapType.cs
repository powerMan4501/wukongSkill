using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ProceduralMapType")]
public enum ProceduralMapType : byte
{
	PROCEDURAL_DUNGEON,
	PROCEDURAL_WILDERNESS_LINEAR,
	PROCEDURAL_DEMO_MAP
}
