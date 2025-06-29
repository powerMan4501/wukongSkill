using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureMipCount", "Engine", UnrealModuleType.Engine)]
public enum ETextureMipCount
{
	TMC_ResidentMips,
	TMC_AllMips,
	TMC_AllMipsBiased
}
