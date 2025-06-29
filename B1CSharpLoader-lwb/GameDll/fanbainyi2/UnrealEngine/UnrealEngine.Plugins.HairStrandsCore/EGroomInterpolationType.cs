using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EGroomInterpolationType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomInterpolationType : byte
{
	None = 0,
	RigidTransform = 2,
	OffsetTransform = 4,
	SmoothTransform = 8
}
