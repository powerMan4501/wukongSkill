namespace b1;

public class PatrolUnitInfo
{
	public int GroupIndex;

	public int UnitIndex;

	public int Priority;

	public PatrolUnitInfo(int GroupIndex, int UnitIndex)
	{
		this.GroupIndex = GroupIndex;
		this.UnitIndex = UnitIndex;
		Priority = GroupIndex * 100 + UnitIndex;
	}
}
