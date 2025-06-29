using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ELatticeDeformerToolAction", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ELatticeDeformerToolAction
{
	NoAction,
	Constrain,
	ClearConstraints
}
