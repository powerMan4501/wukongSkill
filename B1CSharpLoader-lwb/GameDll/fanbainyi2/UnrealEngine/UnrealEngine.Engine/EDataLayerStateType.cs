using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EDataLayerState", "Engine", UnrealModuleType.Engine)]
public enum EDataLayerStateType : byte
{
	Unloaded,
	Loaded,
	Activated
}
