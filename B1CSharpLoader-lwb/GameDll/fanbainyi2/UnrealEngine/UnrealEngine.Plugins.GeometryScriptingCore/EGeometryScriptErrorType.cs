using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptErrorType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptErrorType : byte
{
	NoError,
	UnknownError,
	InvalidInputs,
	OperationFailed
}
