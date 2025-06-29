using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeCurvatureColorMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeCurvatureColorMode
{
	Grayscale,
	RedBlue,
	RedGreenBlue
}
