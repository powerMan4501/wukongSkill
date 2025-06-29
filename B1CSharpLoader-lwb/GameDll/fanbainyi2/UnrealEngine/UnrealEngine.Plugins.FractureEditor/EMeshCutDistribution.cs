using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EMeshCutDistribution", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EMeshCutDistribution
{
	SingleCut,
	UniformRandom,
	Grid
}
