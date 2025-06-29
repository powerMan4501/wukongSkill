using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptTangentTypes", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptTangentTypes : byte
{
	FastMikkT,
	PerTriangle
}
