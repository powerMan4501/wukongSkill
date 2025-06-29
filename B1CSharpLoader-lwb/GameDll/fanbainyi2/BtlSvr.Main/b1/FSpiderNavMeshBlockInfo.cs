using System.Collections.Generic;

namespace b1;

public class FSpiderNavMeshBlockInfo
{
	public List<FSpiderNavPointInfo> NavPoints = new List<FSpiderNavPointInfo>();

	public FSpiderNavMeshBlockInfo(List<FGsSpiderNavPointInfo> InNavPoints)
	{
		for (int i = 0; i < InNavPoints.Count; i++)
		{
			NavPoints.Add(new FSpiderNavPointInfo(InNavPoints[i]));
		}
	}
}
