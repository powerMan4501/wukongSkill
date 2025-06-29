using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ETextTransformPolicy", "SlateCore", UnrealModuleType.Engine)]
public enum ETextTransformPolicy : byte
{
	None,
	ToLower,
	ToUpper
}
