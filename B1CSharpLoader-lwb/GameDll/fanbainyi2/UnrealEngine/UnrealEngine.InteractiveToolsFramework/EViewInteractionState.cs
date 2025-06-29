using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.EViewInteractionState", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum EViewInteractionState
{
	None,
	Hovered,
	Focused
}
