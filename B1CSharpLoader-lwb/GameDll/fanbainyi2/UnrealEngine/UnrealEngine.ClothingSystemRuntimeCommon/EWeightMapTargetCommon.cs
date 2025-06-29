using UnrealEngine.Runtime;

namespace UnrealEngine.ClothingSystemRuntimeCommon;

[UEnum]
[UMetaPath("/Script/ClothingSystemRuntimeCommon.EWeightMapTargetCommon", "ClothingSystemRuntimeCommon", UnrealModuleType.Engine)]
public enum EWeightMapTargetCommon
{
	None,
	MaxDistance,
	BackstopDistance,
	BackstopRadius,
	AnimDriveStiffness,
	AnimDriveDamping_DEPRECATED,
	MAX_Target
}
