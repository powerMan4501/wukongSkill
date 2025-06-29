using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public struct FSoftObjectPtrUnsafe : IDisposable, IEquatable<FSoftObjectPtrUnsafe>
{
	private TPersistentObjectPtr_FSoftObjectPathUnsafe objectPath;

	public FSoftObjectPath ObjectPath
	{
		get
		{
			return objectPath.ObjectID.ToSafe();
		}
		set
		{
			objectPath.ObjectID.AssetPathName = value.AssetPathName;
			objectPath.ObjectID.SubPathString = value.SubPathString;
		}
	}

	public bool IsPending => Native_FSoftObjectPtr.IsPending(ref this);

	public bool IsValid => Native_FSoftObjectPtr.IsValid(ref this);

	public bool IsStale => Native_FSoftObjectPtr.IsStale(ref this);

	public bool IsNull => Native_FSoftObjectPtr.IsNull(ref this);

	public FSoftObjectPtrUnsafe(FName assetPathName, string subPathString)
	{
		objectPath = default(TPersistentObjectPtr_FSoftObjectPathUnsafe);
		objectPath.WeakPtr.Reset();
		objectPath.TagAtLastTest = 0;
		objectPath.ObjectID.AssetPathName = assetPathName;
		objectPath.ObjectID.SubPathString = subPathString;
	}

	public FSoftObjectPtrUnsafe(FSoftObjectPath assetRef)
	{
		objectPath = default(TPersistentObjectPtr_FSoftObjectPathUnsafe);
		objectPath.WeakPtr.Reset();
		objectPath.TagAtLastTest = 0;
		ObjectPath = assetRef;
	}

	public FSoftObjectPtrUnsafe(FSoftObjectPathUnsafe assetRefUnsafe)
		: this(assetRefUnsafe.ToSafe())
	{
	}

	public FSoftObjectPtrUnsafe(FSoftObjectPtrUnsafe other)
	{
		objectPath = default(TPersistentObjectPtr_FSoftObjectPathUnsafe);
		objectPath.WeakPtr.Reset();
		objectPath.TagAtLastTest = 0;
		ObjectPath = other.objectPath.ObjectID.ToSafe();
	}

	public FSoftObjectPtrUnsafe(UObject obj)
	{
		objectPath = default(TPersistentObjectPtr_FSoftObjectPathUnsafe);
		objectPath.WeakPtr.Reset();
		objectPath.TagAtLastTest = 0;
		Set(obj);
	}

	public void Copy(FSoftObjectPtrUnsafe other)
	{
		ObjectPath = other.ObjectPath;
	}

	public FSoftObjectPath GetObjectPath()
	{
		return objectPath.ObjectID.ToSafe();
	}

	public TPersistentObjectPtr_FSoftObjectPathUnsafe GetObjectPathUnsafe()
	{
		return objectPath;
	}

	public UObject Get()
	{
		return GCHelper.Find<UObject>(Native_FSoftObjectPtr.Get(ref this));
	}

	public void Set(UObject value)
	{
		Native_FSoftObjectPtr.SetUObject(ref this, (value == null) ? IntPtr.Zero : value.Address);
	}

	public void Set(FWeakObjectPtr value)
	{
		Native_FSoftObjectPtr.SetFWeakObjectPtr(ref this, ref value);
	}

	public void Reset()
	{
		Native_FSoftObjectPtr.Reset(ref this);
	}

	public UObject LoadSynchronous()
	{
		return GCHelper.Find<UObject>(Native_FSoftObjectPtr.LoadSynchronous(ref this));
	}

	public static bool operator ==(FSoftObjectPtrUnsafe a, FSoftObjectPtrUnsafe b)
	{
		return Native_FSoftObjectPtr.Equals(ref a, ref b);
	}

	public static bool operator !=(FSoftObjectPtrUnsafe a, FSoftObjectPtrUnsafe b)
	{
		return !Native_FSoftObjectPtr.Equals(ref a, ref b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FSoftObjectPtrUnsafe)
		{
			return Equals((FSoftObjectPtrUnsafe)obj);
		}
		return false;
	}

	public bool Equals(FSoftObjectPtrUnsafe other)
	{
		return Native_FSoftObjectPtr.Equals(ref this, ref other);
	}

	public override int GetHashCode()
	{
		return (int)Native_FSoftObjectPtr.GetTypeHash(ref this);
	}

	public void Dispose()
	{
		objectPath.ObjectID.Dispose();
	}
}
