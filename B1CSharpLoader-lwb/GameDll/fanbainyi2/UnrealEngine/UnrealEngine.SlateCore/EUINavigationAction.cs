using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EUINavigationAction", "SlateCore", UnrealModuleType.Engine)]
public enum EUINavigationAction : byte
{
	Accept,
	Back,
	Num,
	Invalid
}
