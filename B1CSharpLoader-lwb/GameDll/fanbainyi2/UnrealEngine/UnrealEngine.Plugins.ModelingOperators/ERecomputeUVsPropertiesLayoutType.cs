using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ERecomputeUVsPropertiesLayoutType", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ERecomputeUVsPropertiesLayoutType
{
	None,
	Repack,
	NormalizeToBounds,
	NormalizeToWorld
}
