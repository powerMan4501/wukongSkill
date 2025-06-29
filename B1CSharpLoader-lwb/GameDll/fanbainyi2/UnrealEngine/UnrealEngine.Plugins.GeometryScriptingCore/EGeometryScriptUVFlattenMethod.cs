using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptUVFlattenMethod", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptUVFlattenMethod : byte
{
	ExpMap,
	Conformal
}
