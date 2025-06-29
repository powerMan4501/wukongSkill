using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ECollisionGeometryMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ECollisionGeometryMode
{
	Default,
	SimpleAndComplex,
	UseSimpleAsComplex,
	UseComplexAsSimple
}
