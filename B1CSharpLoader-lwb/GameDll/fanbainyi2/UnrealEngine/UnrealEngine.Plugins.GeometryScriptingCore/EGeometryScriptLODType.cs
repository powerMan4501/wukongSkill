using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptLODType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptLODType : byte
{
	MaxAvailable,
	HiResSourceModel,
	SourceModel,
	RenderData
}
