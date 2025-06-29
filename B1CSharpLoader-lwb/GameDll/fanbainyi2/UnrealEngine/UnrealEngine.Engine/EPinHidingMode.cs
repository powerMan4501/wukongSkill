using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPinHidingMode", "Engine", UnrealModuleType.Engine)]
public enum EPinHidingMode
{
	NeverAsPin,
	PinHiddenByDefault,
	PinShownByDefault,
	AlwaysAsPin
}
