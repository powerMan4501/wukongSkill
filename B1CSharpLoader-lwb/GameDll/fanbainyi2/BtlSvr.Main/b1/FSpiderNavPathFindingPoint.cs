namespace b1;

public class FSpiderNavPathFindingPoint
{
	public int FatherPointIndex;

	public float Cost_F;

	public float Cost_G;

	public int PointIndex { get; }

	public FSpiderNavPathFindingPoint()
	{
	}

	public FSpiderNavPathFindingPoint(int _PointIndex, int _FatherPointIndex, float _Cost_F, float _Cost_G)
	{
		PointIndex = _PointIndex;
		FatherPointIndex = _FatherPointIndex;
		Cost_F = _Cost_F;
		Cost_G = _Cost_G;
	}
}
