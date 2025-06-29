using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVectorQuantization", "Engine", UnrealModuleType.Engine)]
public enum EVectorQuantization
{
	RoundWholeNumber,
	RoundOneDecimal,
	RoundTwoDecimals
}
