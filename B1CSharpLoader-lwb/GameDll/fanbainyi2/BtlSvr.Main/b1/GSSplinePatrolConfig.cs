using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GSSplinePatrolConfig
{
	public bool SingleDirection;

	public TSoftObject<AActor> SplineActor { get; set; }

	public TSoftObject<ATriggerBase> TriggerBox { get; set; }

	public Dictionary<int, GSSplinePatrolWaitPoint> WaitPointConfig { get; set; } = new Dictionary<int, GSSplinePatrolWaitPoint>();

	public Dictionary<int, GSSplinePatrolJumpPoint> JumpPointConfig { get; set; } = new Dictionary<int, GSSplinePatrolJumpPoint>();

	public GSSplinePatrolConfig(in FGSSplinePatrolConfig InConfig)
	{
		SplineActor = new TSoftObject<AActor>(InConfig.SplineActor);
		SingleDirection = InConfig.SingleDirection;
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

	public GSSplinePatrolConfig(GSSplinePatrolConfig other)
	{
		SplineActor = other.SplineActor;
		SingleDirection = other.SingleDirection;
		TriggerBox = other.TriggerBox;
		foreach (KeyValuePair<int, GSSplinePatrolWaitPoint> item in other.WaitPointConfig)
		{
			WaitPointConfig.Add(item.Key, new GSSplinePatrolWaitPoint(item.Value));
		}
		foreach (KeyValuePair<int, GSSplinePatrolJumpPoint> item2 in other.JumpPointConfig)
		{
			JumpPointConfig.Add(item2.Key, new GSSplinePatrolJumpPoint(item2.Value));
		}
	}
}
