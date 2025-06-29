using System;

namespace UnrealEngine.Runtime;

public struct TSoftObject<T> : IEquatable<TSoftObject<T>> where T : UObject
{
	private FSoftObjectPtr softObject;

	public static TSoftObject<T> Null => default(TSoftObject<T>);

	public FSoftObjectPath ObjectPath => softObject.ObjectPath;

	public string Path => softObject.Path;

	public string AssetPathName => softObject.AssetPathName;

	public string SubPathString => softObject.SubPathString;

	public string LongPackageName => softObject.LongPackageName;

	public string AssetName => softObject.AssetName;

	public T Value
	{
		get
		{
			return softObject.Value as T;
		}
		set
		{
			softObject.Value = value;
		}
	}

	public bool IsPending => softObject.IsPending;

	public bool IsValid => softObject.IsValid;

	public bool IsStale => softObject.IsStale;

	public bool IsNull => softObject.IsNull;

	public TSoftObject(T obj)
	{
		softObject = default(FSoftObjectPtr);
		Value = obj;
	}

	public TSoftObject(FSoftObjectPath softObject)
	{
		this.softObject = new FSoftObjectPtr(softObject);
	}

	public void Reset()
	{
		softObject.Reset();
	}

	public T LoadSynchronous()
	{
		UObject uObject = softObject.Value;
		if (uObject == null && IsPending)
		{
			uObject = softObject.LoadSynchronous();
		}
		return uObject as T;
	}

	public static bool operator ==(TSoftObject<T> a, TSoftObject<T> b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(TSoftObject<T> a, TSoftObject<T> b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is TSoftObject<T>)
		{
			return Equals((TSoftObject<T>)obj);
		}
		return false;
	}

	public bool Equals(TSoftObject<T> other)
	{
		return softObject == other.softObject;
	}

	public override int GetHashCode()
	{
		return softObject.GetHashCode();
	}
}
