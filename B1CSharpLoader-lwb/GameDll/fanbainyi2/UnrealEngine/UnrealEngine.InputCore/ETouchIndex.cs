using UnrealEngine.Runtime;

namespace UnrealEngine.InputCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InputCore.ETouchIndex", "InputCore", UnrealModuleType.Engine)]
public enum ETouchIndex : byte
{
	Touch1,
	Touch2,
	Touch3,
	Touch4,
	Touch5,
	Touch6,
	Touch7,
	Touch8,
	Touch9,
	Touch10,
	CursorPointerIndex,
	MAX_TOUCHES
}
