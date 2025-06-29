using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EWidgetClipping", "SlateCore", UnrealModuleType.Engine)]
public enum EWidgetClipping : byte
{
	Inherit,
	ClipToBounds,
	ClipToBoundsWithoutIntersecting,
	ClipToBoundsAlways,
	OnDemand
}
