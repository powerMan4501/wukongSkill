using System;

namespace UnrealEngine.Runtime;

public struct TSoftClass<T> : IEquatable<TSoftClass<T>> where T : UObject
{
	private FSoftObjectPtr softObject;

	public static TSoftClass<T> Null => default(TSoftClass<T>);

	public FSoftObjectPath ObjectPath => softObject.ObjectPath;

	public string Path => softObject.Path;

	public UClass Value
	{
		get
		{
			UClass uClass = softObject.Value as UClass;
			if (uClass == null || !uClass.IsChildOf<T>())
			{
				return null;
			}
			return uClass;
		}
		set
		{
			SetClass(value);
		}
	}

	public bool IsPending => softObject.IsPending;

	public bool IsValid => softObject.IsValid;

	public bool IsStale => softObject.IsStale;

	public bool IsNull => softObject.IsNull;

	public TSoftClass(UClass unrealClass)
	{
		softObject = default(FSoftObjectPtr);
		Value = unrealClass;
	}

	public TSoftClass(FSoftObjectPath objectPath)
	{
		softObject = new FSoftObjectPtr(objectPath);
	}

	public TSoftClass(string objectPath)
	{
		softObject = new FSoftObjectPtr(new FSoftObjectPath(new FName(objectPath), null));
	}

	public void SetClass(UClass unrealClass)
	{
		if (unrealClass != null && !unrealClass.IsA<T>())
		{
			throw new Exception("TAssetClass - tried to set class with the wrong target class type. Expected:" + typeof(T)?.ToString() + " Actual:" + UClass.GetType(unrealClass.Address));
		}
		softObject.Value = unrealClass;
	}

	public void SetClass<TClass>() where TClass : T
	{
		SetClass(UClass.GetClass<TClass>());
	}

	public void Reset()
	{
		softObject.Reset();
	}

	public UClass LoadSynchronous()
	{
		UObject uObject = softObject.Value;
		if (uObject == null || IsPending)
		{
			uObject = softObject.LoadSynchronous();
		}
		UClass uClass = uObject as UClass;
		if (uClass == null || !uClass.IsChildOf<T>())
		{
			return null;
		}
		return uClass;
	}

	public static bool operator ==(TSoftClass<T> a, TSoftClass<T> b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(TSoftClass<T> a, TSoftClass<T> b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is TSoftClass<T>)
		{
			return Equals((TSoftClass<T>)obj);
		}
		return false;
	}

	public bool Equals(TSoftClass<T> other)
	{
		return softObject == other.softObject;
	}

	public override int GetHashCode()
	{
		return softObject.GetHashCode();
	}
}
