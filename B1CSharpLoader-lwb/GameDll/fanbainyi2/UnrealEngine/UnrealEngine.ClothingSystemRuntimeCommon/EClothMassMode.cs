using UnrealEngine.Runtime;

namespace UnrealEngine.ClothingSystemRuntimeCommon;

[UEnum]
[UMetaPath("/Script/ClothingSystemRuntimeCommon.EClothMassMode", "ClothingSystemRuntimeCommon", UnrealModuleType.Engine)]
public enum EClothMassMode
{
	UniformMass,
	TotalMass,
	Density,
	MaxClothMassMode
}
