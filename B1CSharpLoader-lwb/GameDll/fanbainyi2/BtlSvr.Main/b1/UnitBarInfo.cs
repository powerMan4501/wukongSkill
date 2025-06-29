namespace b1;

public class UnitBarInfo
{
	public string UnitGuid { get; set; }

	public float HPValue { get; set; }

	public int Priority { get; set; }

	public UnitBarInfo(string _Guid, float _HPValue, int _Priority)
	{
		UnitGuid = _Guid;
		HPValue = _HPValue;
		Priority = _Priority;
	}
}
