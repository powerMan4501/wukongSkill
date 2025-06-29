using UnrealEngine.Runtime;

namespace UnrealEngine.MaterialBaking;

[UEnum]
[UMetaPath("/Script/MaterialBaking.EMaterialBakeMethod", "MaterialBaking", UnrealModuleType.Engine)]
public enum EMaterialBakeMethod
{
	IndividualMaterial,
	AtlasMaterial,
	BinnedMaterial
}
