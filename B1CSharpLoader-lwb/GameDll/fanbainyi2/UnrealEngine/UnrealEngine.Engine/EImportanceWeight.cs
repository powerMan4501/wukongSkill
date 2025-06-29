using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EImportanceWeight", "Engine", UnrealModuleType.Engine)]
public enum EImportanceWeight : byte
{
	Luminance,
	Red,
	Green,
	Blue,
	Alpha
}
