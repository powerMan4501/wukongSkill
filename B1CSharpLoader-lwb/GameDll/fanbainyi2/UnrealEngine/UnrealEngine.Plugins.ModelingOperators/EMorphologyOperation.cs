using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.EMorphologyOperation", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum EMorphologyOperation
{
	Dilate,
	Contract,
	Close,
	Open
}
