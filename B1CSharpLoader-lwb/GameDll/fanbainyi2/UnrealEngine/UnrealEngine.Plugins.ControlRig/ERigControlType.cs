using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ERigControlType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigControlType : byte
{
	Bool,
	Float,
	Integer,
	Vector2D,
	Position,
	Scale,
	Rotator,
	Transform,
	TransformNoScale,
	EulerTransform
}
