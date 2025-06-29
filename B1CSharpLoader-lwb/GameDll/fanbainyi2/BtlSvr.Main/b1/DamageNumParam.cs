using UnrealEngine.Runtime;

namespace b1;

public struct DamageNumParam
{
	public EDamageNumberType DamageType;

	public int DamageNum;

	public FVector RealHitLocation;

	public FVector RealHitDir;

	public float Amplitude;

	public EDmgNumUITeamType AttackerTeamType;

	public DamageNumParam(EDamageNumberType InDamageType, int InDamageNum, float InAmplitude, FVector InRealHitLocation, FVector InRealHitDir = default(FVector), EDmgNumUITeamType _AttackerTeamType = EDmgNumUITeamType.Hero)
	{
		DamageType = InDamageType;
		DamageNum = InDamageNum;
		Amplitude = InAmplitude;
		RealHitLocation = InRealHitLocation;
		RealHitDir = InRealHitDir;
		AttackerTeamType = _AttackerTeamType;
	}
}
