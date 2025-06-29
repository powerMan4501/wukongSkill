using System;

namespace UnrealEngine.Runtime;

public struct FLifetimeProperty : IEquatable<FLifetimeProperty>
{
	public ushort RepIndex;

	public ELifetimeCondition Condition;

	private ELifetimeRepNotifyCondition RepNotifyCondition;

	public bool IsPushBased;

	public FLifetimeProperty(ushort repIndex)
		: this(repIndex, ELifetimeCondition.None, ELifetimeRepNotifyCondition.OnChanged, isPushBased: false)
	{
	}

	public FLifetimeProperty(ushort repIndex, ELifetimeCondition condition, ELifetimeRepNotifyCondition repNotifyCondition, bool isPushBased)
	{
		RepIndex = repIndex;
		Condition = condition;
		RepNotifyCondition = repNotifyCondition;
		IsPushBased = isPushBased;
	}

	public static bool operator ==(FLifetimeProperty a, FLifetimeProperty b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FLifetimeProperty a, FLifetimeProperty b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FLifetimeProperty)
		{
			return Equals((FLifetimeProperty)obj);
		}
		return false;
	}

	public bool Equals(FLifetimeProperty other)
	{
		if (RepIndex == other.RepIndex)
		{
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((RepIndex.GetHashCode() * 397) ^ Condition.GetHashCode()) * 397) ^ RepNotifyCondition.GetHashCode();
	}
}
