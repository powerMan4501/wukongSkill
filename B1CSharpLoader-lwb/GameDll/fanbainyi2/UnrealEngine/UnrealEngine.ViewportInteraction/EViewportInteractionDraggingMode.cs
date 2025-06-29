using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

[UEnum]
[UMetaPath("/Script/ViewportInteraction.EViewportInteractionDraggingMode", "ViewportInteraction", UnrealModuleType.Engine)]
public enum EViewportInteractionDraggingMode
{
	Nothing,
	TransformablesWithGizmo,
	TransformablesAtLaserImpact,
	AssistingDrag,
	TransformablesFreely,
	World,
	Interactable,
	Material
}
