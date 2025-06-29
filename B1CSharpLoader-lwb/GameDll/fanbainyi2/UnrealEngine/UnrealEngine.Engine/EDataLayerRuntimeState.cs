using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EDataLayerRuntimeState", "Engine", UnrealModuleType.Engine)]
public enum EDataLayerRuntimeState : byte
{
	Unloaded,
	Loaded,
	Activated
}
