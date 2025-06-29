using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptRemoveHiddenTrianglesMethod", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptRemoveHiddenTrianglesMethod : byte
{
	FastWindingNumber,
	RaycastOcclusionTest
}
