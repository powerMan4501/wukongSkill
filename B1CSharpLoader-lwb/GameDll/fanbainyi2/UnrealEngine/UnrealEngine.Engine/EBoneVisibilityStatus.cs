using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBoneVisibilityStatus", "Engine", UnrealModuleType.Engine)]
public enum EBoneVisibilityStatus
{
	BVS_HiddenByParent,
	BVS_Visible,
	BVS_ExplicitlyHidden
}
