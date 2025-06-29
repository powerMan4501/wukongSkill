using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.EConsumeMouseWheel", "SlateCore", UnrealModuleType.Engine)]
public enum EConsumeMouseWheel
{
	WhenScrollingPossible,
	Always,
	Never
}
