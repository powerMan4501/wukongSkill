using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GSMultiSplinePatrolConfig
{
	public List<TSoftObject<AActor>> SplineList { get; set; }

	public TSoftObject<ATriggerBase> TriggerBox { get; set; }

	public Dictionary<int, GSSplinePatrolWaitPoint> WaitPointConfig { get; set; } = new Dictionary<int, GSSplinePatrolWaitPoint>();

	public Dictionary<int, GSSplinePatrolJumpPoint> JumpPointConfig { get; set; } = new Dictionary<int, GSSplinePatrolJumpPoint>();

	public GSMultiSplinePatrolConfig(in FGSMultiSplinePatrolConfig InConfig)
	{
		SplineList = new List<TSoftObject<AActor>>(InConfig.SplineList);
		TriggerBox = new TSoftObject<ATriggerBase>(InConfig.TriggerBox);
		foreach (KeyValuePair<int, FGSSplinePatrolWaitPoint> item in InConfig.WaitPointConfig)
		{
			WaitPointConfig.Add(item.Key, new GSSplinePatrolWaitPoint(item.Value));
		}
		foreach (KeyValuePair<int, FGSSplinePatrolJumpPoint> item2 in InConfig.JumpPointConfig)
		{
			JumpPointConfig.Add(item2.Key, new GSSplinePatrolJumpPoint(item2.Value));
		}
	}
}
