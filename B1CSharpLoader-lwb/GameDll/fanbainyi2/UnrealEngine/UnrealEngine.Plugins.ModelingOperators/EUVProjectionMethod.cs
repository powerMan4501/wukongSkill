using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.EUVProjectionMethod", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum EUVProjectionMethod
{
	Box,
	Cylinder,
	Plane,
	ExpMap
}
