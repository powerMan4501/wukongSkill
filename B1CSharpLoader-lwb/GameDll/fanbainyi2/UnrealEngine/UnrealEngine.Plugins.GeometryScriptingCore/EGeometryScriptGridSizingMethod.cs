using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptGridSizingMethod", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptGridSizingMethod : byte
{
	GridCellSize,
	GridResolution
}
