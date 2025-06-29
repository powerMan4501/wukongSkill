using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAnimInterpolationType", "Engine", UnrealModuleType.Engine)]
public enum EAnimInterpolationType : byte
{
	Linear,
	Step
}
