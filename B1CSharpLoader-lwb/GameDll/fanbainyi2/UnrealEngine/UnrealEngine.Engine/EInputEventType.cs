using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EInputEvent", "Engine", UnrealModuleType.Engine)]
public enum EInputEventType : byte
{
	IE_Pressed,
	IE_Released,
	IE_Repeat,
	IE_DoubleClick,
	IE_Axis
}
