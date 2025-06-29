using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPanningMethod", "Engine", UnrealModuleType.Engine)]
public enum EPanningMethod
{
	Linear,
	EqualPower
}
