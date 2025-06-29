using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EHorizontalAlignment", "SlateCore", UnrealModuleType.Engine)]
public enum EHorizontalAlignment : byte
{
	HAlign_Fill,
	HAlign_Left,
	HAlign_Center,
	HAlign_Right
}
