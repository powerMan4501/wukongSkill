using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EShaderCompressionFormat", "Engine", UnrealModuleType.Engine)]
public enum EShaderCompressionFormat
{
	None,
	LZ4,
	Oodle,
	Zlib
}
