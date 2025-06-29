using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ERigElementType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigElementType : byte
{
	None = 0,
	Bone = 1,
	Null = 2,
	Space = 2,
	Control = 4,
	Curve = 8,
	RigidBody = 16,
	Reference = 32,
	Last = 64,
	All = 63,
	ToResetAfterSetupEvent = 13
}
