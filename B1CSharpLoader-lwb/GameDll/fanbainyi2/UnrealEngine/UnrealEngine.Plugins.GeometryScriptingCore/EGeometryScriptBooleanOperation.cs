using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptBooleanOperation", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptBooleanOperation : byte
{
	Union,
	Intersection,
	Subtract
}
