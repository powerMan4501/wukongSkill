using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMirrorCtrlClickBehavior", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMirrorCtrlClickBehavior
{
	Reposition,
	RepositionAndReorient
}
