namespace b1;

public class GSSuperArmorMappingTargetInfo
{
	public int BuffID;

	public float ValueIntervalMin;

	public float ValueIntervalMax;

	public string TargetLevelName;

	public float ValueBias;

	public GSSuperArmorMappingTargetInfo(int _BuffID, string _TargetLevelName, float _ValueIntervalMin, float _ValueIntervalMax, float _ValueBias)
	{
		BuffID = _BuffID;
		ValueIntervalMin = _ValueIntervalMin;
		ValueIntervalMax = _ValueIntervalMax;
		TargetLevelName = _TargetLevelName;
		ValueBias = _ValueBias;
	}
}
