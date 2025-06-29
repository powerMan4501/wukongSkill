using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPWeaponAimData
{
	float WeaponAimAlpha { get; }

	bool bEnableWeaponAim { get; }

	FName WeaponBoneName { get; }

	FVector WeaponAimPos { get; }

	FVector WeaponAimAxis { get; }

	float DegreesConstraint { get; }
}
