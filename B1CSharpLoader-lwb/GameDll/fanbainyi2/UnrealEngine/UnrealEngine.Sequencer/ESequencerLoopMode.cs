using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UEnum]
[UMetaPath("/Script/Sequencer.ESequencerLoopMode", "Sequencer", UnrealModuleType.Engine)]
public enum ESequencerLoopMode
{
	SLM_NoLoop,
	SLM_Loop,
	SLM_LoopSelectionRange
}
