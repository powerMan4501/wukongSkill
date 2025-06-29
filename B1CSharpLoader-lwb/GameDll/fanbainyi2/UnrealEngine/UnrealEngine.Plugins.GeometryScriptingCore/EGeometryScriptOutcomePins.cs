using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptOutcomePins", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptOutcomePins : byte
{
	Failure,
	Success
}
