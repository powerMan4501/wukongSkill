using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FWeakObjectPtr : IEquatable<FWeakObjectPtr>
{
	public int ObjectIndex;

	public int ObjectSerialNumber;

	public bool IsStale => Native_FWeakObjectPtr.IsStale(ref this);

	public static FWeakObjectPtr Default
	{
		get
		{
			FWeakObjectPtr result = default(FWeakObjectPtr);
			result.Reset();
			return result;
		}
	}

	public FWeakObjectPtr(UObject obj)
	{
		ObjectIndex = -1;
		ObjectSerialNumber = 0;
		Set(obj);
	}

	public FWeakObjectPtr(IntPtr objAddress)
	{
		ObjectIndex = -1;
		ObjectSerialNumber = 0;
		Set(objAddress);
	}

	public FWeakObjectPtr(FWeakObjectPtr obj)
	{
		ObjectIndex = -1;
		ObjectSerialNumber = 0;
		Set(obj);
	}

	public bool IsValid()
	{
		return IsValid(evenIfPendingKill: false);
	}

	public bool IsValid(bool evenIfPendingKill, bool threadsafeTest = false)
	{
		return Native_FWeakObjectPtr.IsValid(ref this, evenIfPendingKill, threadsafeTest);
	}

	public UObject Get()
	{
		return GCHelper.Find<UObject>(Native_FWeakObjectPtr.Get(ref this));
	}

	public UObject GetEvenIfUnreachable()
	{
		return GCHelper.Find<UObject>(Native_FWeakObjectPtr.GetEvenIfUnreachable(ref this));
	}

	public IntPtr GetPtr()
	{
		return Native_FWeakObjectPtr.Get(ref this);
	}

	public IntPtr GetPtrEvenIfUnreachable()
	{
		return Native_FWeakObjectPtr.GetEvenIfUnreachable(ref this);
	}

	public void Set(IntPtr value)
	{
		Native_FWeakObjectPtr.SetUObject(ref this, value);
	}

	public void Set(UObject value)
	{
		Native_FWeakObjectPtr.SetUObject(ref this, (value == null) ? IntPtr.Zero : value.Address);
	}

	public void Set(FWeakObjectPtr value)
	{
		Native_FWeakObjectPtr.SetFWeakObjectPtr(ref this, ref value);
	}

	public void Reset()
	{
		Native_FWeakObjectPtr.Reset(ref this);
	}

	public static bool operator ==(FWeakObjectPtr a, FWeakObjectPtr b)
	{
		return Native_FWeakObjectPtr.Equals(ref a, ref b);
	}

	public static bool operator !=(FWeakObjectPtr a, FWeakObjectPtr b)
	{
		return !Native_FWeakObjectPtr.Equals(ref a, ref b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FWeakObjectPtr)
		{
			return Equals((FWeakObjectPtr)obj);
		}
		return false;
	}

	public bool Equals(FWeakObjectPtr other)
	{
		return Native_FWeakObjectPtr.Equals(ref this, ref other);
	}

	public override int GetHashCode()
	{
		return (int)Native_FWeakObjectPtr.GetTypeHash(ref this);
	}
}
