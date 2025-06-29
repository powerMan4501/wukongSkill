using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EDescendantScrollDestination", "Slate", UnrealModuleType.Engine)]
public enum EDescendantScrollDestination : byte
{
	IntoView,
	TopOrLeft,
	Center,
	BottomOrRight
}
