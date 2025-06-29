using UnrealEngine.Runtime;

namespace UnrealEngine.Foliage;

[UEnum]
[UMetaPath("/Script/Foliage.EFoliageScaling", "Foliage", UnrealModuleType.Engine)]
public enum EFoliageScaling
{
	Uniform,
	Free,
	LockXY,
	LockXZ,
	LockYZ
}
