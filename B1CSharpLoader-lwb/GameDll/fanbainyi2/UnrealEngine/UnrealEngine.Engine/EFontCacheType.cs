using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EFontCacheType", "Engine", UnrealModuleType.Engine)]
public enum EFontCacheType
{
	Offline,
	Runtime,
	Bitmap
}
