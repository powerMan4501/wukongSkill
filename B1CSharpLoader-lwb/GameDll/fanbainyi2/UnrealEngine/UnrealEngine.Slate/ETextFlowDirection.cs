using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.ETextFlowDirection", "Slate", UnrealModuleType.Engine)]
public enum ETextFlowDirection : byte
{
	Auto,
	LeftToRight,
	RightToLeft
}
