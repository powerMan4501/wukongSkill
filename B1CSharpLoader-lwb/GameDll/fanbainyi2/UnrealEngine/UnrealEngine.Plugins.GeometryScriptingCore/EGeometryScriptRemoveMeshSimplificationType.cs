using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptRemoveMeshSimplificationType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptRemoveMeshSimplificationType : byte
{
	StandardQEM,
	VolumePreserving,
	AttributeAware
}
