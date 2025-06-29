using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosCloth;

[UEnum]
[UMetaPath("/Script/ChaosCloth.EChaosWeightMapTarget", "ChaosCloth", UnrealModuleType.EnginePlugin)]
public enum EChaosWeightMapTarget
{
	None,
	MaxDistance,
	BackstopDistance,
	BackstopRadius,
	AnimDriveStiffness,
	AnimDriveDamping,
	TetherStiffness,
	TetherScale,
	Drag,
	Lift,
	EdgeStiffness,
	BendingStiffness,
	AreaStiffness,
	CollisionThicknessScale
}
