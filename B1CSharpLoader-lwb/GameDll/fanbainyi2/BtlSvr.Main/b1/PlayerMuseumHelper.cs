using ArchiveB1;
using CommB1;
using Google.Protobuf.Collections;

namespace b1;

public static class PlayerMuseumHelper
{
	public static RepeatedField<int> GetRedPointData(RoleMuseum museumData, MuseumRedPointType redPointType)
	{
		if (redPointType == MuseumRedPointType.Mv)
		{
			return museumData.RedPoint.MvRedpoint;
		}
		return null;
	}

	public static void RemoveRedPoint(RoleMuseum museumData, MuseumRedPointType redPointType, int RedPointId)
	{
		RepeatedField<int> redPointData = GetRedPointData(museumData, redPointType);
		for (int i = 0; i < redPointData.Count; i++)
		{
			if (redPointData[i] == RedPointId)
			{
				redPointData.RemoveAt(i);
				break;
			}
		}
	}
}
