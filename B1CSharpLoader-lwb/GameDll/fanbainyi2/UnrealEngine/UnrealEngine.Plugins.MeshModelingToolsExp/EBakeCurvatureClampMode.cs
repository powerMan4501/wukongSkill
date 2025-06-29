using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeCurvatureClampMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeCurvatureClampMode
{
	None,
	OnlyPositive,
	OnlyNegative
}
