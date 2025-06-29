using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptDebugMessageType", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptDebugMessageType : byte
{
	ErrorMessage,
	WarningMessage
}
