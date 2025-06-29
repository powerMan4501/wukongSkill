using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDecompressionType", "Engine", UnrealModuleType.Engine)]
public enum EDecompressionType
{
	DTYPE_Setup,
	DTYPE_Invalid,
	DTYPE_Preview,
	DTYPE_Native,
	DTYPE_RealTime,
	DTYPE_Procedural,
	DTYPE_Xenon,
	DTYPE_Streaming
}
