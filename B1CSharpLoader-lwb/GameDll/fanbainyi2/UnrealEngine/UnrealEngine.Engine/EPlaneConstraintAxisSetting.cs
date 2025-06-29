using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EPlaneConstraintAxisSetting", "Engine", UnrealModuleType.Engine)]
public enum EPlaneConstraintAxisSetting : byte
{
	Custom,
	X,
	Y,
	Z,
	UseGlobalPhysicsSetting
}
