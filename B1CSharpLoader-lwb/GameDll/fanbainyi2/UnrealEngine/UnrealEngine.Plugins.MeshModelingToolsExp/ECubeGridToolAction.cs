using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ECubeGridToolAction", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ECubeGridToolAction
{
	NoAction,
	Push,
	Pull,
	Flip,
	SlideForward,
	SlideBack,
	DecreasePowerOfTwo,
	IncreasePowerOfTwo,
	CornerMode,
	Done,
	Cancel
}
