using System;
using System.Runtime.InteropServices;

namespace UnrealEngine.Runtime;

public struct TWeakObject<T> : IEquatable<TWeakObject<T>> where T : UObject
{
	internal FWeakObjectPtr weakObjectPtr;

	public static TWeakObject<T> Null => default(TWeakObject<T>);

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

	public bool IsStale => weakObjectPtr.IsStale;

	public TWeakObject(FWeakObjectPtr weakObjectPtr)
	{
		this.weakObjectPtr = new FWeakObjectPtr(weakObjectPtr);
	}

	public TWeakObject(IntPtr native)
		: this(Marshal.PtrToStructure<FWeakObjectPtr>(native))
	{
	}

	public TWeakObject(T obj)
	{
		weakObjectPtr = new FWeakObjectPtr(obj);
	}

	public bool IsValid()
	{
		return weakObjectPtr.IsValid(evenIfPendingKill: false);
	}

	public bool IsValid(bool evenIfPendingKill, bool threadsafeTest = false)
	{
		return weakObjectPtr.IsValid(evenIfPendingKill, threadsafeTest);
	}

	public T Get()
	{
		return weakObjectPtr.Get() as T;
	}

	public T GetEvenIfUnreachable()
	{
		return weakObjectPtr.GetEvenIfUnreachable() as T;
	}

	public void Set(T value)
	{
		weakObjectPtr.Set(value);
	}

	public void Set(FWeakObjectPtr value)
	{
		weakObjectPtr.Set(value);
	}

	public void Reset()
	{
		weakObjectPtr.Reset();
	}

	public static bool operator ==(TWeakObject<T> a, TWeakObject<T> b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(TWeakObject<T> a, TWeakObject<T> b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is TWeakObject<T>)
		{
			return Equals((TWeakObject<T>)obj);
		}
		return false;
	}

	public bool Equals(TWeakObject<T> other)
	{
		return weakObjectPtr == other.weakObjectPtr;
	}

	public override int GetHashCode()
	{
		return weakObjectPtr.GetHashCode();
	}
}
