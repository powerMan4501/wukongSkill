using UnrealEngine.Runtime;

namespace UnrealEngine.ViewportInteraction;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ViewportInteraction.EHitResultGizmoFilterMode", "ViewportInteraction", UnrealModuleType.Engine)]
public enum EHitResultGizmoFilterMode : byte
{
	All,
	NoGizmos,
	GizmosOnly
}
