using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERenderFocusRule", "Engine", UnrealModuleType.Engine)]
public enum ERenderFocusRule
{
	Always,
	NonPointer,
	NavigationOnly,
	Never
}
