using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptFillHolesMethod", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptFillHolesMethod : byte
{
	Automatic,
	MinimalFill,
	PolygonTriangulation,
	TriangleFan,
	PlanarProjection
}
