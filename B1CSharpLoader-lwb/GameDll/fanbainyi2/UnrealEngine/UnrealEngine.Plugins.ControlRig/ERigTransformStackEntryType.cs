using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigTransformStackEntryType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigTransformStackEntryType
{
	TransformPose,
	ControlOffset,
	ControlShape,
	CurveValue
}
