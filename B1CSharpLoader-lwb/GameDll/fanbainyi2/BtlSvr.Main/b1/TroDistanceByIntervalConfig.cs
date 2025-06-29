using System.Collections.Generic;

namespace b1;

public struct TroDistanceByIntervalConfig
{
	public Dictionary<int, int> DistanceToIntervalDic;

	public int ElseInterval;

	public TroDistanceByIntervalConfig(Dictionary<int, int> InDistanceToIntervalDic, int InElseInterval = 0)
	{
		DistanceToIntervalDic = InDistanceToIntervalDic;
		ElseInterval = InElseInterval;
	}
}
