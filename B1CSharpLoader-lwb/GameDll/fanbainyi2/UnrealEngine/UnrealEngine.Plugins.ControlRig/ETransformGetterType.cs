using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.ETransformGetterType", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum ETransformGetterType
{
	Initial,
	Current,
	Max
}
