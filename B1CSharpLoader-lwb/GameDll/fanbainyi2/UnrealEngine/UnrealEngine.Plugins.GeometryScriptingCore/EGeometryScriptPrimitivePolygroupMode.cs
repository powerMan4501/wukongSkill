using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptPrimitivePolygroupMode", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptPrimitivePolygroupMode : byte
{
	SingleGroup,
	PerFace,
	PerQuad
}
