using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EFFTSize", "Engine", UnrealModuleType.Engine)]
public enum EFFTSize : byte
{
	DefaultSize,
	Min,
	Small,
	Medium,
	Large,
	VeryLarge,
	Max
}
