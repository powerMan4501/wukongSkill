using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UEnum]
[UMetaPath("/Script/Sequencer.EAllowEditsMode", "Sequencer", UnrealModuleType.Engine)]
public enum EAllowEditsMode
{
	AllEdits,
	AllowSequencerEditsOnly,
	AllowLevelEditsOnly
}
