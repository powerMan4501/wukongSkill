using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptPrimitiveUVMode", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptPrimitiveUVMode : byte
{
	Uniform,
	ScaleToFill
}
