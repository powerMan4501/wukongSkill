using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FDelegateHandle : IEquatable<FDelegateHandle>
{
	public ulong ID;

	public bool IsValid => ID != 0;

	public void Reset()
	{
		ID = 0uL;
	}

	public static FDelegateHandle New()
	{
		FDelegateHandle result = default(FDelegateHandle);
		Native_FDelegateHandle.GenerateNewHandle(ref result);
		return result;
	}

	public static bool operator ==(FDelegateHandle a, FDelegateHandle b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FDelegateHandle a, FDelegateHandle b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FDelegateHandle)
		{
			return Equals((FDelegateHandle)obj);
		}
		return false;
	}

	public bool Equals(FDelegateHandle other)
	{
		return ID == other.ID;
	}

	public override int GetHashCode()
	{
		return ID.GetHashCode();
	}
}
