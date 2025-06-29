using System;

namespace UnrealEngine.Runtime;

public struct TSubclassOf<T> : IEquatable<TSubclassOf<T>> where T : UObject
{
	internal FSubclassOf subclassOf;

	private UClass value;

	public static TSubclassOf<T> Null => default(TSubclassOf<T>);

	public UClass Value
	{
		get
		{
			if (subclassOf.ClassAddress != IntPtr.Zero && (value == null || value.Address != subclassOf.ClassAddress))
			{
				value = GCHelper.Find<UClass>(subclassOf.ClassAddress);
			}
			return value;
		}
		set
		{
			SetClass(value);
		}
	}

	public TSubclassOf(UClass unrealClass)
	{
		subclassOf = default(FSubclassOf);
		value = null;
		SetClass(unrealClass);
	}

	public void SetClass(UClass unrealClass)
	{
		if (unrealClass != null)
		{
			if (!unrealClass.IsChildOf<T>())
			{
				throw new Exception("TSubclassOf - tried to set class with the wrong target class type. Expected:" + typeof(T)?.ToString() + " Actual:" + UClass.GetType(unrealClass.Address));
			}
			subclassOf.ClassAddress = unrealClass.Address;
		}
		else
		{
			subclassOf.ClassAddress = IntPtr.Zero;
		}
	}

	public void SetClass<TClass>() where TClass : T
	{
		SetClass(UClass.GetClass<TClass>());
	}

	public T GetDefaultObject()
	{
		UClass uClass = Value;
		if (uClass != null)
		{
			return uClass.GetDefaultObject() as T;
		}
		return null;
	}

	public static bool operator ==(TSubclassOf<T> a, TSubclassOf<T> b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(TSubclassOf<T> a, TSubclassOf<T> b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is TSubclassOf<T>)
		{
			return Equals((TSubclassOf<T>)obj);
		}
		return false;
	}

	public bool Equals(TSubclassOf<T> other)
	{
		return subclassOf == other.subclassOf;
	}

	public override int GetHashCode()
	{
		return subclassOf.GetHashCode();
	}

	public static implicit operator TSubclassOf<T>(UClass unrealClass)
	{
		return new TSubclassOf<T>(unrealClass);
	}
}
