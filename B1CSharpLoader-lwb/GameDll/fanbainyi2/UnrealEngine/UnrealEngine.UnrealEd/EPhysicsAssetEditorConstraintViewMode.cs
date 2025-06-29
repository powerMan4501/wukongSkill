using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPhysicsAssetEditorConstraintViewMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EPhysicsAssetEditorConstraintViewMode
{
	None,
	AllPositions,
	AllLimits
}
