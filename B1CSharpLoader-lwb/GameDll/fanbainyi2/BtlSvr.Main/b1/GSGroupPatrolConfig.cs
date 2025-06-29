using System.Collections.Generic;

namespace b1;

public class GSGroupPatrolConfig
{
	public GSGroupFollowConfig GroupFollowConfig;

	public Dictionary<int, GSSplinePatrolWaitPoint> WaitPointConfig { get; set; } = new Dictionary<int, GSSplinePatrolWaitPoint>();

	public GSGroupPatrolConfig(in FGSGroupPatrolConfig InConfig)
	{
		foreach (KeyValuePair<int, FGSSplinePatrolWaitPoint> item in InConfig.SplineWaitPointConfig)
		{
			WaitPointConfig.Add(item.Key, new GSSplinePatrolWaitPoint(item.Value));
		}
		GroupFollowConfig = new GSGroupFollowConfig(in InConfig.GroupFollowConfig);
	}
}
