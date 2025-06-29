using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class WorldStaticVar<T> : StaticVar
{
	protected Dictionary<IntPtr, T> values = new Dictionary<IntPtr, T>();

	protected int worldTypeFlags;

	public WorldStaticVar()
	{
	}

	public WorldStaticVar(params EWorldType[] worldTypes)
	{
		foreach (EWorldType eWorldType in worldTypes)
		{
			worldTypeFlags |= 1 << (int)eWorldType;
		}
	}

	public virtual bool HasValue(UObject worldContextObject)
	{
		IntPtr intPtr = Native_UObject.GetWorld(worldContextObject.Address);
		if (worldTypeFlags == 0)
		{
			return values.ContainsKey(intPtr);
		}
		if (intPtr != IntPtr.Zero)
		{
			int num = 1 << (int)Native_UWorld.Get_WorldType(intPtr);
			if ((worldTypeFlags & num) == num)
			{
				return values.ContainsKey(intPtr);
			}
		}
		return false;
	}

	public virtual bool TryGetValue(UObject worldContextObject, out T value)
	{
		IntPtr intPtr = Native_UObject.GetWorld(worldContextObject.Address);
		if (worldTypeFlags == 0)
		{
			if (values.TryGetValue(intPtr, out value))
			{
				return true;
			}
		}
		else if (intPtr != IntPtr.Zero)
		{
			int num = 1 << (int)Native_UWorld.Get_WorldType(intPtr);
			if ((worldTypeFlags & num) == num && values.TryGetValue(intPtr, out value))
			{
				return true;
			}
		}
		value = default(T);
		return false;
	}

	public T Get(UObject worldContextObject)
	{
		TryGetValue(worldContextObject, out var value);
		return value;
	}

	public virtual bool Set(UObject worldContextObject, T value)
	{
		IntPtr intPtr = Native_UObject.GetWorld(worldContextObject.Address);
		if (worldTypeFlags == 0)
		{
			values[intPtr] = value;
			return true;
		}
		if (intPtr != IntPtr.Zero)
		{
			int num = 1 << (int)Native_UWorld.Get_WorldType(intPtr);
			if ((worldTypeFlags & num) == num)
			{
				values[intPtr] = value;
				return true;
			}
		}
		return false;
	}

	public override void OnWorldDestroyed(IntPtr world)
	{
		values.Remove(world);
	}
}
