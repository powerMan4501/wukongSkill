using System;

namespace UnrealEngine.Runtime;

public struct CachedUObject<T> where T : UObject
{
	private UObjectRef objRef;

	public T Value;

	public IntPtr Address
	{
		get
		{
			if (!(Value == null))
			{
				return Value.Address;
			}
			return IntPtr.Zero;
		}
	}

	public T Update(IntPtr address)
	{
		if (objRef != null)
		{
			if (address == objRef.Native && Value.objRef == objRef)
			{
				return Value;
			}
			Value = null;
		}
		objRef = GCHelper.FindRef(address);
		if (objRef != null)
		{
			Value = objRef.Managed as T;
			if (Value == null || Value.objRef != objRef)
			{
				objRef = null;
				Value = null;
			}
		}
		return Value;
	}

	public IntPtr Set(T value)
	{
		UObjectRef uObjectRef = ((value == null) ? null : value.objRef);
		if (uObjectRef != objRef || Value.objRef != objRef)
		{
			if (uObjectRef != null)
			{
				objRef = uObjectRef;
				Value = objRef.Managed as T;
				if (Value == null || Value.objRef != objRef)
				{
					objRef = null;
					Value = null;
					return IntPtr.Zero;
				}
				return objRef.Native;
			}
			objRef = null;
			Value = null;
			return IntPtr.Zero;
		}
		if (objRef != null)
		{
			return objRef.Native;
		}
		return IntPtr.Zero;
	}
}
public struct CachedUObject
{
	private UObjectRef objRef;

	public UObject Value;

	public IntPtr Address
	{
		get
		{
			if (!(Value == null))
			{
				return Value.Address;
			}
			return IntPtr.Zero;
		}
	}

	public UObject Update(IntPtr address)
	{
		if (objRef != null)
		{
			if (objRef.Native == address && Value.objRef == objRef)
			{
				return Value;
			}
			Value = null;
		}
		objRef = GCHelper.FindRef(address);
		if (objRef != null)
		{
			Value = objRef.Managed;
			if (Value == null || Value.objRef != objRef)
			{
				objRef = null;
				Value = null;
			}
		}
		return Value;
	}

	public IntPtr Set(UObject value)
	{
		return Set((value == null) ? null : value.objRef);
	}

	public IntPtr Set(UObjectRef value)
	{
		if (value != objRef || Value.objRef != objRef)
		{
			if (value != null)
			{
				objRef = value;
				Value = objRef.Managed;
				if (Value == null || Value.objRef != objRef)
				{
					objRef = null;
					Value = null;
					return IntPtr.Zero;
				}
				return objRef.Native;
			}
			objRef = null;
			Value = null;
			return IntPtr.Zero;
		}
		if (objRef != null)
		{
			return objRef.Native;
		}
		return IntPtr.Zero;
	}
}
