using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UEnum]
[UMetaPath("/Script/ControlRig.EControlRigDrawSettings", "ControlRig", UnrealModuleType.EnginePlugin)]
public enum EControlRigDrawSettings
{
	Points,
	Lines,
	LineStrip,
	DynamicMesh
}
