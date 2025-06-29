using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.TextureAddress", "Engine", UnrealModuleType.Engine)]
public enum ETextureAddress
{
	TA_Wrap,
	TA_Clamp,
	TA_Mirror
}
