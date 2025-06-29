using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ETextOverflowPolicy", "SlateCore", UnrealModuleType.Engine)]
public enum ETextOverflowPolicy : byte
{
	Clip,
	Ellipsis
}
