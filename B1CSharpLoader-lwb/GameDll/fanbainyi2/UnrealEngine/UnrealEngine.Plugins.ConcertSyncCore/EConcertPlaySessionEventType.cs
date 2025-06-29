using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConcertSyncCore;

[UEnum]
[UMetaPath("/Script/ConcertSyncCore.EConcertPlaySessionEventType", "ConcertSyncCore", UnrealModuleType.EnginePlugin)]
public enum EConcertPlaySessionEventType
{
	None,
	BeginPlay,
	SwitchPlay,
	EndPlay
}
