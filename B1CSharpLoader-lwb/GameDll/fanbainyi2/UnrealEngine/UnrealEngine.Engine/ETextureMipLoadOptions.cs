using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureMipLoadOptions", "Engine", UnrealModuleType.Engine)]
public enum ETextureMipLoadOptions
{
	Default,
	AllMips,
	OnlyFirstMip
}
