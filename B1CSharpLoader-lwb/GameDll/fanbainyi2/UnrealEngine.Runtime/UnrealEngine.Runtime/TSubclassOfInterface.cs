using System;

namespace UnrealEngine.Runtime;

public struct TSubclassOfInterface<T> : IEquatable<TSubclassOfInterface<T>> where T : class, IInterface
{
	internal FSubclassOf subclassOf;

	private UClass value;

	public static TSubclassOfInterface<T> Null => default(TSubclassOfInterface<T>);

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

	public TSubclassOfInterface(UClass unrealClass)
	{
		subclassOf = default(FSubclassOf);
		value = null;
		SetClass(unrealClass);
	}

	public void SetClass(UClass unrealClass)
	{
		if (unrealClass != null)
		{
			if (!unrealClass.ImplementsInterface<T>())
			{
				throw new Exception("TSubclassOfInterface - the given class doesn't implement the interface: '" + typeof(T)?.ToString() + "' class:" + UClass.GetType(unrealClass.Address));
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

	public static bool operator ==(TSubclassOfInterface<T> a, TSubclassOfInterface<T> b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(TSubclassOfInterface<T> a, TSubclassOfInterface<T> b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is TSubclassOfInterface<T>)
		{
			return Equals((TSubclassOfInterface<T>)obj);
		}
		return false;
	}

	public bool Equals(TSubclassOfInterface<T> other)
	{
		return subclassOf == other.subclassOf;
	}

	public override int GetHashCode()
	{
		return subclassOf.GetHashCode();
	}
}
