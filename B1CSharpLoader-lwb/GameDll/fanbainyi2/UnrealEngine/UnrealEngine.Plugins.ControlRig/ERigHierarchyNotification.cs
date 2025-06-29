using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigHierarchyNotification", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigHierarchyNotification
{
	ElementAdded,
	ElementRemoved,
	ElementRenamed,
	ElementSelected,
	ElementDeselected,
	ParentChanged,
	HierarchyReset,
	ControlSettingChanged,
	ControlVisibilityChanged,
	ControlShapeTransformChanged,
	ParentWeightsChanged,
	Max
}
