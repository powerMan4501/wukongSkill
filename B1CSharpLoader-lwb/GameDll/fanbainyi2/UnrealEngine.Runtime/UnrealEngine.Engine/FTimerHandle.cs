using System;

namespace UnrealEngine.Engine;

public struct FTimerHandle : IEquatable<FTimerHandle>
{
	public ulong Handle;

	public bool IsValid => Handle != 0;

	public void Invalidate()
	{
		Handle = 0uL;
	}

	public static bool operator ==(FTimerHandle a, FTimerHandle b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FTimerHandle a, FTimerHandle b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FTimerHandle)
		{
			return Equals((FTimerHandle)obj);
		}
		return false;
	}

	public bool Equals(FTimerHandle other)
	{
		return Handle == other.Handle;
	}

	public override int GetHashCode()
	{
		return Handle.GetHashCode();
	}
}
