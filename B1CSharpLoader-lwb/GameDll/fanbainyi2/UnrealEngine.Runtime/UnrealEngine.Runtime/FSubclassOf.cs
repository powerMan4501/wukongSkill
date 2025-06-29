using System;

namespace UnrealEngine.Runtime;

public struct FSubclassOf : IEquatable<FSubclassOf>
{
	public IntPtr ClassAddress;

	public UClass Class => GCHelper.Find<UClass>(ClassAddress);

	public static bool operator ==(FSubclassOf a, FSubclassOf b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FSubclassOf a, FSubclassOf b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FSubclassOf)
		{
			return Equals((FSubclassOf)obj);
		}
		return false;
	}

	public bool Equals(FSubclassOf other)
	{
		return ClassAddress == other.ClassAddress;
	}

	public override int GetHashCode()
	{
		return ClassAddress.GetHashCode();
	}
}
