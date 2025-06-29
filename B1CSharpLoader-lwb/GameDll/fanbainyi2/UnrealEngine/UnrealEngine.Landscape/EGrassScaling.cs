using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.EGrassScaling", "Landscape", UnrealModuleType.Engine)]
public enum EGrassScaling
{
	Uniform,
	Free,
	LockXY
}
