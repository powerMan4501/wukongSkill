using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptSearchOutcomePins", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptSearchOutcomePins : byte
{
	Found,
	NotFound
}
