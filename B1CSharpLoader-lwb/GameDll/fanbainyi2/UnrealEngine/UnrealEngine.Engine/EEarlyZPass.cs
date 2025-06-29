using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EEarlyZPass", "Engine", UnrealModuleType.Engine)]
public enum EEarlyZPass
{
	None,
	OpaqueOnly,
	OpaqueAndMasked,
	Auto
}
