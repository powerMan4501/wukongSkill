using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EQuartzCommandType", "Engine", UnrealModuleType.Engine)]
public enum EQuartzCommandType : byte
{
	PlaySound,
	QueueSoundToPlay,
	RetriggerSound,
	TickRateChange,
	TransportReset,
	StartOtherClock
}
