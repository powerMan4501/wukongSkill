using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureCompressionQuality", "Engine", UnrealModuleType.Engine)]
public enum ETextureCompressionQuality
{
	TCQ_Default,
	TCQ_Lowest,
	TCQ_Low,
	TCQ_Medium,
	TCQ_High,
	TCQ_Highest
}
