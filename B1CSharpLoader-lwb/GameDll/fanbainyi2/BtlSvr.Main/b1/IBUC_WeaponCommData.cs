using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_WeaponCommData
{
	bool bIsActive { get; }

	bool EnableScale { get; }

	float ScaleTimer { get; }

	UCurveVector ScaleCurve { get; }
}
