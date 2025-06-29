using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureMipValueMode", "Engine", UnrealModuleType.Engine)]
public enum ETextureMipValueMode
{
	TMVM_None,
	TMVM_MipLevel,
	TMVM_MipBias,
	TMVM_Derivative
}
