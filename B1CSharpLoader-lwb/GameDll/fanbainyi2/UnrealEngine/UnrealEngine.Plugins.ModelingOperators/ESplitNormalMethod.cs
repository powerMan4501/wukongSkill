using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ESplitNormalMethod", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ESplitNormalMethod
{
	UseExistingTopology,
	FaceNormalThreshold,
	FaceGroupID,
	PerTriangle,
	PerVertex
}
