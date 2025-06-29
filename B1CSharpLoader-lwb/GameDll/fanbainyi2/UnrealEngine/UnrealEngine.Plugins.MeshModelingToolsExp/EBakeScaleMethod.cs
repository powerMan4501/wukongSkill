using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeScaleMethod", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeScaleMethod
{
	BakeFullScale,
	BakeNonuniformScale,
	DoNotBakeScale
}
