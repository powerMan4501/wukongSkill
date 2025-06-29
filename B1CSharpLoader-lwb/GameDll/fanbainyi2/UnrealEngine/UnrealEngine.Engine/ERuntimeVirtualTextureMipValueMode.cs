using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERuntimeVirtualTextureMipValueMode", "Engine", UnrealModuleType.Engine)]
public enum ERuntimeVirtualTextureMipValueMode
{
	RVTMVM_None,
	RVTMVM_MipLevel,
	RVTMVM_MipBias,
	RVTMVM_RecalculateDerivatives
}
