using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

[UEnum]
[UMetaPath("/Script/ViewportInteraction.EViewportWorldInteractionType", "ViewportInteraction", UnrealModuleType.Engine)]
public enum EViewportWorldInteractionType
{
	VR,
	Legacy
}
