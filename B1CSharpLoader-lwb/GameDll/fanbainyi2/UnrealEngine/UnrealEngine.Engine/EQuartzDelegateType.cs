using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EQuartzDelegateType", "Engine", UnrealModuleType.Engine)]
public enum EQuartzDelegateType : byte
{
	MetronomeTick,
	CommandEvent,
	Count
}
