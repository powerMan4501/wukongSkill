using UnrealEngine.Runtime;

namespace UnrealEngine.Sequencer;

[UEnum]
[UMetaPath("/Script/Sequencer.EKeyGroupMode", "Sequencer", UnrealModuleType.Engine)]
public enum EKeyGroupMode
{
	KeyChanged,
	KeyGroup,
	KeyAll
}
