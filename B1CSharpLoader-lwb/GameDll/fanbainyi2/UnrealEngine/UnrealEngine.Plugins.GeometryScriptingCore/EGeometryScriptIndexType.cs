using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptIndexType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptIndexType : byte
{
	Any,
	Triangle,
	Vertex,
	MaterialID,
	PolygroupID
}
