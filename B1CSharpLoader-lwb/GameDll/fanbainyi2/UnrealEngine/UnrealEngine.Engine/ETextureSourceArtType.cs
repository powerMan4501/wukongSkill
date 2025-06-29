using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureSourceArtType", "Engine", UnrealModuleType.Engine)]
public enum ETextureSourceArtType
{
	TSAT_Uncompressed,
	TSAT_PNGCompressed,
	TSAT_DDSFile
}
