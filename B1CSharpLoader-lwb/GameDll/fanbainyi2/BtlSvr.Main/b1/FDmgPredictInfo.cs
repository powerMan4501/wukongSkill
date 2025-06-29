namespace b1;

public struct FDmgPredictInfo
{
	public bool IsCrit;

	public float DmgRandomValue;

	public FDmgPredictInfo(bool _IsCrit, float _DmgRandomValue)
	{
		IsCrit = _IsCrit;
		DmgRandomValue = _DmgRandomValue;
	}
}
