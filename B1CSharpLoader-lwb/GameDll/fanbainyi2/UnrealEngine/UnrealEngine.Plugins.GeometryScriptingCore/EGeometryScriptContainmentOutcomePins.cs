using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptContainmentOutcomePins", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptContainmentOutcomePins : byte
{
	Inside,
	Outside
}
