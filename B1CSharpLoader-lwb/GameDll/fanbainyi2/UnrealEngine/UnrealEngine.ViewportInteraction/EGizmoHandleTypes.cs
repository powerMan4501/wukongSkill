using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

[UEnum]
[UMetaPath("/Script/ViewportInteraction.EGizmoHandleTypes", "ViewportInteraction", UnrealModuleType.Engine)]
public enum EGizmoHandleTypes
{
	All,
	Translate,
	Rotate,
	Scale
}
