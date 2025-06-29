using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ESelectInfo", "SlateCore", UnrealModuleType.Engine)]
public enum ESelectInfo : byte
{
	OnKeyPress,
	OnNavigation,
	OnMouseClick,
	Direct
}
