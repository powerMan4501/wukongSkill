using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UEnum]
[UMetaPath("/Script/Sequencer.ESequencerSpawnPosition", "Sequencer", UnrealModuleType.Engine)]
public enum ESequencerSpawnPosition
{
	SSP_Origin,
	SSP_PlaceInFrontOfCamera
}
