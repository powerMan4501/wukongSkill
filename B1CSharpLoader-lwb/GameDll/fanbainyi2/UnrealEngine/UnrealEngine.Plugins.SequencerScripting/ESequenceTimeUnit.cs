using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.ESequenceTimeUnit", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public enum ESequenceTimeUnit : byte
{
	DisplayRate,
	TickResolution
}
