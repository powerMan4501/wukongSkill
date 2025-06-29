using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESlateGesture", "Engine", UnrealModuleType.Engine)]
public enum ESlateGesture : byte
{
	None,
	Scroll,
	Magnify,
	Swipe,
	Rotate,
	LongPress
}
