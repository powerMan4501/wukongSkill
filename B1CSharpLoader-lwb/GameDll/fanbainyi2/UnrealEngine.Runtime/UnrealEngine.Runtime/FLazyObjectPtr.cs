using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FLazyObjectPtr : IEquatable<FLazyObjectPtr>
{
	private TPersistentObjectPtr_FUniqueObjectGuid uniqueObjectGuid;

	public FUniqueObjectGuid Guid
	{
		get
		{
			return uniqueObjectGuid.ObjectID;
		}
		set
		{
			uniqueObjectGuid.ObjectID.Guid = value.Guid;
		}
	}

	public bool IsPending => Native_FLazyObjectPtr.IsPending(ref this);

	public bool IsValid => Native_FLazyObjectPtr.IsValid(ref this);

	public bool IsStale => Native_FLazyObjectPtr.IsStale(ref this);

	public bool IsNull => Native_FLazyObjectPtr.IsNull(ref this);

	public FLazyObjectPtr(FUniqueObjectGuid guid)
	{
		uniqueObjectGuid = default(TPersistentObjectPtr_FUniqueObjectGuid);
		uniqueObjectGuid.WeakPtr.Reset();
		uniqueObjectGuid.TagAtLastTest = 0;
		Guid = guid;
	}

	public FLazyObjectPtr(FLazyObjectPtr other)
	{
		uniqueObjectGuid = default(TPersistentObjectPtr_FUniqueObjectGuid);
		uniqueObjectGuid.WeakPtr.Reset();
		uniqueObjectGuid.TagAtLastTest = 0;
		Guid = other.uniqueObjectGuid.ObjectID;
	}

	public FLazyObjectPtr(UObject obj)
	{
		uniqueObjectGuid = default(TPersistentObjectPtr_FUniqueObjectGuid);
		uniqueObjectGuid.WeakPtr.Reset();
		uniqueObjectGuid.TagAtLastTest = 0;
		Set(obj);
	}

	public void Copy(FLazyObjectPtr other)
	{
		Guid = other.Guid;
	}

	public TPersistentObjectPtr_FUniqueObjectGuid GetUniqueObjectGuid()
	{
		return uniqueObjectGuid;
	}

	public UObject Get()
	{
		return GCHelper.Find<UObject>(Native_FLazyObjectPtr.Get(ref this));
	}

	public void Set(UObject value)
	{
		Native_FLazyObjectPtr.SetUObject(ref this, (value == null) ? IntPtr.Zero : value.Address);
	}

	public void Set(FLazyObjectPtr value)
	{
		Native_FLazyObjectPtr.SetFLazyObjectPtr(ref this, ref value);
	}

	public void Reset()
	{
		Native_FLazyObjectPtr.Reset(ref this);
	}

	public static bool operator ==(FLazyObjectPtr a, FLazyObjectPtr b)
	{
		return Native_FLazyObjectPtr.Equals(ref a, ref b);
	}

	public static bool operator !=(FLazyObjectPtr a, FLazyObjectPtr b)
	{
		return !Native_FLazyObjectPtr.Equals(ref a, ref b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FLazyObjectPtr)
		{
			return Equals((FLazyObjectPtr)obj);
		}
		return false;
	}

	public bool Equals(FLazyObjectPtr other)
	{
		return Native_FLazyObjectPtr.Equals(ref this, ref other);
	}

	public override int GetHashCode()
	{
		return (int)Native_FLazyObjectPtr.GetTypeHash(ref this);
	}
}
