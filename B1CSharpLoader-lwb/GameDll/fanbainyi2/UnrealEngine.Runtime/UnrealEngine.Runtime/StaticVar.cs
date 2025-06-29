using System;

namespace UnrealEngine.Runtime;

public abstract class StaticVar
{
	public bool IsRegistered { get; private set; }

	public StaticVar()
	{
		Register();
	}

	public virtual void Register()
	{
		if (!IsRegistered)
		{
			StaticVarManager.Vars.Add(this);
			IsRegistered = true;
		}
	}

	public virtual void Unregister()
	{
		if (IsRegistered)
		{
			StaticVarManager.Vars.Remove(this);
			IsRegistered = false;
		}
	}

	public virtual void OnUnload()
	{
	}

	public virtual void OnPIEBegin(bool simulating)
	{
	}

	public virtual void OnPIEEnd(bool simulating)
	{
	}

	public virtual void OnWorldAdded(IntPtr world)
	{
	}

	public virtual void OnWorldDestroyed(IntPtr world)
	{
	}

	public virtual void OnGameInstanceShutdown(IntPtr gameInstance)
	{
	}
}
