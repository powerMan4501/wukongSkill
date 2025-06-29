using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BeAtkPhysAnimSetting : PhysAnimSetting
{
	public UCurveFloat PhysWeightCurve;

	public UCurveFloat MotorStrengthCurve;

	public List<FName> IgnoreBones;

	public float HitImpulse = 1000f;

	public bool bHitOnPelvis;

	public bool bPartPhysics;

	public bool bScaledByTotalMass;

	public bool bCanHitSpine;

	public bool bUseCurveBlend;

	public bool bIsPlayingHit;
}
