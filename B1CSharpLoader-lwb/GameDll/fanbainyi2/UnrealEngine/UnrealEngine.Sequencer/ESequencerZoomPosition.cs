using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UEnum]
[UMetaPath("/Script/Sequencer.ESequencerZoomPosition", "Sequencer", UnrealModuleType.Engine)]
public enum ESequencerZoomPosition
{
	SZP_CurrentTime,
	SZP_MousePosition
}
