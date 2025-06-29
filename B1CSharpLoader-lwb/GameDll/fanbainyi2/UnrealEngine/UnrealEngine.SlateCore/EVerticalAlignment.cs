using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EVerticalAlignment", "SlateCore", UnrealModuleType.Engine)]
public enum EVerticalAlignment : byte
{
	VAlign_Fill,
	VAlign_Top,
	VAlign_Center,
	VAlign_Bottom
}
