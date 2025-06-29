using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ERigSwitchParentMode", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ERigSwitchParentMode
{
	World,
	DefaultParent,
	ParentItem
}
