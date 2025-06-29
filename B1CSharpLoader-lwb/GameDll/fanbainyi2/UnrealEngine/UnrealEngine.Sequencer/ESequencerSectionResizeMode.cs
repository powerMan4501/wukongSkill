using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UEnum]
[UMetaPath("/Script/Sequencer.ESequencerSectionResizeMode", "Sequencer", UnrealModuleType.Engine)]
public enum ESequencerSectionResizeMode
{
	SSRM_LeadingEdge,
	SSRM_TrailingEdge
}
