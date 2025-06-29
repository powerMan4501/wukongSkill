using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_RandomEventData : IPersistentECSData
{
	private Dictionary<int, AwardRandomEventInfo> RandomProbabilityDict = new Dictionary<int, AwardRandomEventInfo>();

	public AwardRandomEventInfo GetRandomProbabilityDict(int EventId)
	{
		if (RandomProbabilityDict != null && RandomProbabilityDict.TryGetValue(EventId, out var value))
		{
			return value;
		}
		return default(AwardRandomEventInfo);
	}

	public void RasieRandomProbabilityById(int EventId, EAwardProbabilityRaiseType RaiseType, int NewRandomProbability, bool CanReduce)
	{
		if (RandomProbabilityDict != null && RandomProbabilityDict.TryGetValue(EventId, out var value))
		{
			int num = value.CurProbability;
			switch (RaiseType)
			{
			case EAwardProbabilityRaiseType.RaiseToFirst:
				num = value.FirstProbability;
				break;
			case EAwardProbabilityRaiseType.RaiseToSecond:
				num = value.SecondProbability;
				break;
			case EAwardProbabilityRaiseType.RaiseToTarget:
				num = NewRandomProbability;
				break;
			}
			if (CanReduce || num > value.CurProbability)
			{
				value.CurProbability = num;
				RandomProbabilityDict[EventId] = value;
			}
		}
	}

	public void RandomProbabilityDictAdd(int EventId, AwardRandomEventInfo NewRandomProbability)
	{
		if (RandomProbabilityDict != null && !RandomProbabilityDict.TryGetValue(EventId, out var _))
		{
			RandomProbabilityDict.Add(EventId, NewRandomProbability);
		}
	}

	public void SetCanAwardState(int EventId, bool NewState)
	{
		if (RandomProbabilityDict != null && RandomProbabilityDict.TryGetValue(EventId, out var value))
		{
			value.CanAward = NewState;
			RandomProbabilityDict[EventId] = value;
		}
	}

	public bool GetCanAwardState(int EventId)
	{
		if (RandomProbabilityDict != null && RandomProbabilityDict.TryGetValue(EventId, out var value))
		{
			return value.CanAward;
		}
		return false;
	}

	public void SetAwardRandomCount(int EventId)
	{
		if (RandomProbabilityDict != null && RandomProbabilityDict.TryGetValue(EventId, out var value))
		{
			value.AwardRandomCount++;
			RandomProbabilityDict[EventId] = value;
		}
	}

	public int GetAwardRandomCount(int EventId)
	{
		if (RandomProbabilityDict != null && RandomProbabilityDict.TryGetValue(EventId, out var value))
		{
			return value.AwardRandomCount;
		}
		return 0;
	}
}
