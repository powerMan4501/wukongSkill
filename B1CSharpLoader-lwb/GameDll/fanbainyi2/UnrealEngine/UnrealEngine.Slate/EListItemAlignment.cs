using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EListItemAlignment", "Slate", UnrealModuleType.Engine)]
public enum EListItemAlignment : byte
{
	EvenlyDistributed,
	EvenlySize,
	EvenlyWide,
	LeftAligned,
	RightAligned,
	CenterAligned,
	Fill
}
