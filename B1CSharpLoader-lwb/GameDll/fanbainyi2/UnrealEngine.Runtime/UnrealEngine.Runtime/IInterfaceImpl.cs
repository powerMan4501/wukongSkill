using System;

namespace UnrealEngine.Runtime;

public abstract class IInterfaceImpl : IInterface
{
	private CachedUObject cachedObj;

	public IntPtr Address => cachedObj.Address;

	public IntPtr GetAddress()
	{
		return cachedObj.Address;
	}

	public UObject GetObject()
	{
		return cachedObj.Value;
	}

	public void CheckDestroyed()
	{
		if (cachedObj.Value == null || cachedObj.Value.IsDestroyed)
		{
			Type type = ((cachedObj.Value != null) ? cachedObj.Value.GetType() : GetType());
			throw new Exception("Attempting to access a destroyed unreal object of type " + type.ToString());
		}
	}

	internal void SetObj(UObjectRef objRef)
	{
		cachedObj.Set(objRef);
	}

	public virtual void ResetInterface()
	{
	}
}
