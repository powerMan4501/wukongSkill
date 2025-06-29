using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptUVIslandSource", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptUVIslandSource : byte
{
	PolyGroups,
	UVIslands
}
