using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class TStrongObjectPtr<T> : TStrongObjectPtrBase, IDisposable, IEquatable<TStrongObjectPtr<T>> where T : UObject
{
	private string CacheName;

	private T RealCachedObj;

	private T CachedObj
	{
		get
		{
			return RealCachedObj;
		}
		set
		{
			RealCachedObj = value;
		}
	}

	public override UObject GetUObject()
	{
		return CachedObj;
	}

	public override string GetCacheName()
	{
		return CacheName;
	}

	public TStrongObjectPtr()
	{
		StrongPtrGCCollector.AddNewPtr_GameThread(this);
		ThisAddr = Native_TStrongObjectPtr.New();
		StrongPtrLeakDetection.JoinDetection(this);
	}

	public TStrongObjectPtr(T Obj)
	{
		StrongPtrGCCollector.AddNewPtr_GameThread(this);
		ThisAddr = Native_TStrongObjectPtr.New();
		Set(Obj);
		StrongPtrLeakDetection.JoinDetection(this);
	}

	~TStrongObjectPtr()
	{
		Dispose();
	}

	public void Dispose()
	{
		Destroy();
	}

	public override void GCClear()
	{
		Destroy();
	}

	private void Destroy()
	{
		if ((object)CachedObj != null && ThisAddr != IntPtr.Zero)
		{
			Native_TStrongObjectPtr.Reset(ThisAddr, IntPtr.Zero);
			if ((bool)Native_FThreading.IsInGameThread())
			{
				Native_TStrongObjectPtr.Delete(ThisAddr);
			}
			else
			{
				StrongPtrGCCollector.AddDeferDeletePtr_AnyThread(ThisAddr);
			}
			ThisAddr = IntPtr.Zero;
		}
		CachedObj = null;
	}

	public override void SetNull()
	{
		Set(null);
	}

	public void Delete()
	{
		Set(null);
	}

	public T Get()
	{
		if (!IsValid())
		{
			return null;
		}
		return CachedObj;
	}

	public override bool IsValid()
	{
		if (ThisAddr == IntPtr.Zero)
		{
			return false;
		}
		if (CachedObj.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}

	public void Set(T NewValue)
	{
		if (!(ThisAddr == IntPtr.Zero))
		{
			Native_TStrongObjectPtr.Reset(ThisAddr, (NewValue == null) ? IntPtr.Zero : NewValue.Address);
			CachedObj = NewValue;
		}
	}

	public override bool Equals(object obj)
	{
		if (obj is UObject || obj == null)
		{
			return obj == CachedObj;
		}
		return false;
	}

	public bool Equals(TStrongObjectPtr<T> other)
	{
		return CachedObj == other.CachedObj;
	}

	public static bool operator ==(TStrongObjectPtr<T> Objself, object Other)
	{
		return Objself.CachedObj == Other;
	}

	public static bool operator !=(TStrongObjectPtr<T> Objself, object Other)
	{
		return Objself.CachedObj != Other;
	}

	public static bool operator ==(TStrongObjectPtr<T> Objself, TStrongObjectPtr<T> Other)
	{
		if ((object)Other == null)
		{
			return (object)Objself == null;
		}
		if ((object)Objself == null)
		{
			return (object)Other == null;
		}
		return Objself.CachedObj == Other.CachedObj;
	}

	public static bool operator !=(TStrongObjectPtr<T> Objself, TStrongObjectPtr<T> Other)
	{
		return !(Objself == Other);
	}

	public override int GetHashCode()
	{
		if (CachedObj != null)
		{
			return CachedObj.GetHashCode();
		}
		return base.GetHashCode();
	}
}
