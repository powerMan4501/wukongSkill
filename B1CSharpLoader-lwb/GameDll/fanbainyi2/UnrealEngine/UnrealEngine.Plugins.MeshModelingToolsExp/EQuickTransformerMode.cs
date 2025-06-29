using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EQuickTransformerMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EQuickTransformerMode
{
	AxisTranslation,
	AxisRotation
}
