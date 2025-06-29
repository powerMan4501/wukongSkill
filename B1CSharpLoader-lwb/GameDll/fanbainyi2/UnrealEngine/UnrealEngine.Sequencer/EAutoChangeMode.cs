using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UEnum]
[UMetaPath("/Script/Sequencer.EAutoChangeMode", "Sequencer", UnrealModuleType.Engine)]
public enum EAutoChangeMode
{
	AutoKey,
	AutoTrack,
	All,
	None
}
