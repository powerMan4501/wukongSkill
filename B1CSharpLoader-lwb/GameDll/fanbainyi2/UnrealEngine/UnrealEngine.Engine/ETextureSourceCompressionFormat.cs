using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureSourceCompressionFormat", "Engine", UnrealModuleType.Engine)]
public enum ETextureSourceCompressionFormat
{
	TSCF_None,
	TSCF_PNG,
	TSCF_JPEG
}
