using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptPrimitiveOriginMode", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptPrimitiveOriginMode : byte
{
	Center,
	Base_
}
