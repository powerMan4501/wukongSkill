using System;
using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class GameInstanceStaticVar<T> : StaticVar
{
	protected Dictionary<IntPtr, T> values = new Dictionary<IntPtr, T>();

	private IntPtr GetDefaultWorld()
	{
		return Native_UObject.GetWorld(FGlobals.GEngine);
	}

	public virtual bool Clear()
	{
		IntPtr defaultWorld = GetDefaultWorld();
		if (defaultWorld != IntPtr.Zero)
		{
			IntPtr intPtr = Native_UWorld.GetGameInstance(defaultWorld);
			if (intPtr != IntPtr.Zero)
			{
				return values.Remove(intPtr);
			}
		}
		return false;
	}

	public virtual bool HasValue()
	{
		IntPtr defaultWorld = GetDefaultWorld();
		if (defaultWorld != IntPtr.Zero)
		{
			IntPtr intPtr = Native_UWorld.GetGameInstance(defaultWorld);
			if (intPtr != IntPtr.Zero)
			{
				return values.ContainsKey(intPtr);
			}
			return false;
		}
		return false;
	}

	public virtual bool TryGetValue(out T value)
	{
		IntPtr defaultWorld = GetDefaultWorld();
		if (defaultWorld != IntPtr.Zero)
		{
			IntPtr intPtr = Native_UWorld.GetGameInstance(defaultWorld);
			if (intPtr != IntPtr.Zero && values.TryGetValue(intPtr, out value))
			{
				return true;
			}
		}
		value = default(T);
		return false;
	}

	public T Get()
	{
		TryGetValue(out var value);
		return value;
	}

	public T Set(T value)
	{
		IntPtr defaultWorld = GetDefaultWorld();
		if (defaultWorld != IntPtr.Zero)
		{
			IntPtr intPtr = Native_UWorld.GetGameInstance(defaultWorld);
			if (intPtr != IntPtr.Zero)
			{
				values[intPtr] = value;
			}
		}
		return value;
	}

	public virtual bool Clear(UObject worldContextObject)
	{
		IntPtr intPtr = Native_UWorld.GetGameInstance(worldContextObject.Address);
		if (intPtr != IntPtr.Zero)
		{
			return values.Remove(intPtr);
		}
		return false;
	}

	public virtual bool HasValue(UObject worldContextObject)
	{
		IntPtr intPtr = Native_UWorld.GetGameInstance(worldContextObject.Address);
		if (intPtr != IntPtr.Zero)
		{
			return values.ContainsKey(intPtr);
		}
		return false;
	}

	public virtual bool TryGetValue(UObject worldContextObject, out T value)
	{
		IntPtr intPtr = Native_UWorld.GetGameInstance(worldContextObject.Address);
		if (intPtr != IntPtr.Zero && values.TryGetValue(intPtr, out value))
		{
			return true;
		}
		value = default(T);
		return false;
	}

	public T Get(UObject worldContextObject)
	{
		TryGetValue(worldContextObject, out var value);
		return value;
	}

	public T Set(UObject worldContextObject, T value)
	{
		IntPtr intPtr = Native_UWorld.GetGameInstance(worldContextObject.Address);
		if (intPtr != IntPtr.Zero)
		{
			values[intPtr] = value;
		}
		return value;
	}

	public override void OnGameInstanceShutdown(IntPtr gameInstance)
	{
		values.Remove(gameInstance);
	}
}
