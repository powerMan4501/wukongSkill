using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EInterpTrackMoveRotMode", "Engine", UnrealModuleType.Engine)]
public enum EInterpTrackMoveRotMode
{
	IMR_Keyframed,
	IMR_LookAtGroup,
	IMR_Ignore
}
