using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECanCreateConnectionResponse", "Engine", UnrealModuleType.Engine)]
public enum ECanCreateConnectionResponse
{
	CONNECT_RESPONSE_MAKE,
	CONNECT_RESPONSE_DISALLOW,
	CONNECT_RESPONSE_BREAK_OTHERS_A,
	CONNECT_RESPONSE_BREAK_OTHERS_B,
	CONNECT_RESPONSE_BREAK_OTHERS_AB,
	CONNECT_RESPONSE_MAKE_WITH_CONVERSION_NODE,
	CONNECT_RESPONSE_MAKE_WITH_PROMOTION
}
