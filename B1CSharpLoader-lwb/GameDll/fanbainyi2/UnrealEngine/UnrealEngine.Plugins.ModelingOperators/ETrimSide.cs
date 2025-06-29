using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ETrimSide", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ETrimSide
{
	RemoveInside,
	RemoveOutside
}
