using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.EFlowDirectionPreference", "SlateCore", UnrealModuleType.Engine)]
public enum EFlowDirectionPreference
{
	Inherit,
	Culture,
	LeftToRight,
	RightToLeft
}
