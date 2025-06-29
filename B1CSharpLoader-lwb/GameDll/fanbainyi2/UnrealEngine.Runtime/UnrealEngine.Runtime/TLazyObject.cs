using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public struct TLazyObject<T> : IEquatable<TLazyObject<T>> where T : UObject
{
	internal FLazyObjectPtr lazyObjectPtr;

	public static TLazyObject<T> Null => default(TLazyObject<T>);

	public T Value
	{
		get
		{
			return Get();
		}
		set
		{
			Set(value);
		}
	}

	public FUniqueObjectGuid Guid
	{
		get
		{
			return lazyObjectPtr.Guid;
		}
		set
		{
			lazyObjectPtr.Guid = value;
		}
	}

	public bool IsPending => lazyObjectPtr.IsPending;

	public bool IsValid => lazyObjectPtr.IsValid;

	public bool IsStale => lazyObjectPtr.IsStale;

	public bool IsNull => lazyObjectPtr.IsNull;

	public TLazyObject(FLazyObjectPtr lazyObjectPtr)
	{
		this.lazyObjectPtr = new FLazyObjectPtr(lazyObjectPtr);
	}

	public TLazyObject(IntPtr native)
		: this(Marshal.PtrToStructure<FLazyObjectPtr>(native))
	{
	}

	public TLazyObject(T obj)
	{
		lazyObjectPtr = new FLazyObjectPtr(obj);
	}

	public T Get()
	{
		return lazyObjectPtr.Get() as T;
	}

	public void Set(T value)
	{
		lazyObjectPtr.Set(value);
	}

	public void Set(FLazyObjectPtr value)
	{
		lazyObjectPtr.Set(value);
	}

	public void Reset()
	{
		lazyObjectPtr.Reset();
	}

	public static bool operator ==(TLazyObject<T> a, TLazyObject<T> b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(TLazyObject<T> a, TLazyObject<T> b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is TLazyObject<T>)
		{
			return Equals((TLazyObject<T>)obj);
		}
		return false;
	}

	public bool Equals(TLazyObject<T> other)
	{
		return lazyObjectPtr == other.lazyObjectPtr;
	}

	public override int GetHashCode()
	{
		return lazyObjectPtr.GetHashCode();
	}
}
