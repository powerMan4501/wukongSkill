using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETrackToggleAction", "Engine", UnrealModuleType.Engine)]
public enum ETrackToggleAction
{
	ETTA_Off,
	ETTA_On,
	ETTA_Toggle,
	ETTA_Trigger
}
