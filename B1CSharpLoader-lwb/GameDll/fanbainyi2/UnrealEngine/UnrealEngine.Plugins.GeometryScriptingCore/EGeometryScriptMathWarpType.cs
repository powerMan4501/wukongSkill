using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptMathWarpType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptMathWarpType : byte
{
	SinWave1D,
	SinWave2D,
	SinWave3D
}
