using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptFlareType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptFlareType : byte
{
	SinMode,
	SinSquaredMode,
	TriangleMode
}
