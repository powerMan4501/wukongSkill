using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EGBufferFormat", "Engine", UnrealModuleType.Engine)]
public enum EGBufferFormat
{
	Force8BitsPerChannel = 0,
	Default = 1,
	HighPrecisionNormals = 3,
	Force16BitsPerChannel = 5
}
