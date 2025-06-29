using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMirrorToolAction", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMirrorToolAction
{
	NoAction,
	ShiftToCenter,
	Left,
	Right,
	Up,
	Down,
	Forward,
	Backward
}
