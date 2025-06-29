using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EPhysicalMaterialMaskColor", "Engine", UnrealModuleType.Engine)]
public enum EPhysicalMaterialMaskColor : byte
{
	Red,
	Green,
	Blue,
	Cyan,
	Magenta,
	Yellow,
	White,
	Black
}
