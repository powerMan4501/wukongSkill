using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AiConversationFactType")]
public enum EAiConversationFactType : byte
{
	[DisplayName("整型")]
	FactType_Int,
	[DisplayName("布尔类型")]
	FactType_Bool,
	[DisplayName("字符串")]
	FactType_String
}
