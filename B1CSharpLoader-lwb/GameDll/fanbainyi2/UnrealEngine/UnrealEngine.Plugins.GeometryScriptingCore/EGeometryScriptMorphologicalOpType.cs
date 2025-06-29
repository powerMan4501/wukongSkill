using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptMorphologicalOpType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptMorphologicalOpType : byte
{
	Dilate,
	Contract,
	Close,
	Open
}
