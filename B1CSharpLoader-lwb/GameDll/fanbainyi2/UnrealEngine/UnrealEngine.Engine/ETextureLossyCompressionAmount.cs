using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureLossyCompressionAmount", "Engine", UnrealModuleType.Engine)]
public enum ETextureLossyCompressionAmount
{
	TLCA_Default,
	TLCA_None,
	TLCA_Lowest,
	TLCA_Low,
	TLCA_Medium,
	TLCA_High,
	TLCA_Highest
}
