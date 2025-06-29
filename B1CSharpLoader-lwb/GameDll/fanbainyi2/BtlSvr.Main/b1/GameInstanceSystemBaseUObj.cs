using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.ConsoleVariableManager;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GameInstanceSystemBaseUObj")]
public class GameInstanceSystemBaseUObj : UObject, IGameInstObjCS, IGameInstObj, ICallbackValidator
{
	public int _TickStatId = -1;

	private Dictionary<string, GISCvar> ManagedCvar = new Dictionary<string, GISCvar>();

	private static List<string> sResetCvarCache;

	public virtual bool bTickEnabled => false;

	public UObject Owner { get; set; }

	public int StatId
	{
		get
		{
			if (_TickStatId < 0)
			{
				_TickStatId = ProfilerFuncLib.CreateStatID(GetType().FullName + ":Tick");
			}
			return _TickStatId;
		}
	}

	public bool IsValidAcceptCallback()
	{
		return !Owner.IsNullOrDestroyed();
	}

	private GISCvar GetOrCreateManagedCvar(string Name, int ResetFlag)
	{
		if (!ManagedCvar.TryGetValue(Name, out var value))
		{
			value = new GISCvar();
			value.Name = Name;
			value.Handle = CVarFuncLib.CreateHandle(Name);
			value.Resetflag = ResetFlag;
			value.RelatedGameInstObj = this;
			ManagedCvar[Name] = value;
		}
		GSEUtil.Ensure(value.Resetflag == ResetFlag, $"CvarName: {Name} Cvar.Resetflag:{value.Resetflag} ResetFlag:{ResetFlag}");
		return value;
	}

	protected void HandleResetCvarFrameCounter(GISCvar Cvar, int ResetFrameCounter)
	{
		Cvar.ResetFrameCounter = ResetFrameCounter;
		if (ResetFrameCounter > 0)
		{
			BGW_EventCollection.Get(this).Evt_RegisterAutoResetGISCVar(Cvar);
		}
	}

	protected void SetCvar(string Name, int Value, int ResetFlag = 1, int ResetFrameCounter = -1, EConsoleVariablePriority Priority = EConsoleVariablePriority.Default, int ExtendPriority = 0)
	{
		GISCvar orCreateManagedCvar = GetOrCreateManagedCvar(Name, ResetFlag);
		CVarFuncLib.SetByHandleWithPriority(orCreateManagedCvar.Handle, Value, Priority, ExtendPriority);
		HandleResetCvarFrameCounter(orCreateManagedCvar, ResetFrameCounter);
	}

	protected void SetCvar(string Name, float Value, int ResetFlag = 1, int ResetFrameCounter = -1, EConsoleVariablePriority Priority = EConsoleVariablePriority.Default, int ExtendPriority = 0)
	{
		GISCvar orCreateManagedCvar = GetOrCreateManagedCvar(Name, ResetFlag);
		CVarFuncLib.SetByHandleWithPriority(orCreateManagedCvar.Handle, Value, Priority, ExtendPriority);
		HandleResetCvarFrameCounter(orCreateManagedCvar, ResetFrameCounter);
	}

	public void ResetCvar(string Name)
	{
		if (ManagedCvar.TryGetValue(Name, out var value))
		{
			CVarFuncLib.DestroyHandle(value.Handle);
			value.Handle = -1;
			ManagedCvar.Remove(Name);
		}
	}

	protected void ResetAllManagedCvar()
	{
		foreach (GISCvar value in ManagedCvar.Values)
		{
			CVarFuncLib.DestroyHandle(value.Handle);
			value.Handle = -1;
		}
		ManagedCvar.Clear();
	}

	protected void ResetAllManagedCvarByType(int ResetFilter, int DontResetFilter = 0)
	{
		sResetCvarCache.Clear();
		foreach (KeyValuePair<string, GISCvar> item in ManagedCvar)
		{
			if ((item.Value.Resetflag & ResetFilter) != 0 && (item.Value.Resetflag & DontResetFilter) == 0)
			{
				sResetCvarCache.Add(item.Key);
			}
		}
		foreach (string item2 in sResetCvarCache)
		{
			ResetCvar(item2);
		}
	}

	public virtual void OnAttach()
	{
	}

	public virtual void OnInit()
	{
	}

	public virtual void OnAfterInit()
	{
	}

	public virtual bool CanTick()
	{
		return true;
	}

	public virtual int GetTickGroupMask()
	{
		return 0;
	}

	public virtual void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	public virtual void OnShutdown()
	{
		ResetAllManagedCvar();
	}

	public virtual void OnPostLoadMap()
	{
		ResetAllManagedCvarByType(1);
	}

	protected T RequireWritableGameInstanceData<T>() where T : class
	{
		return BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(Owner).GetGameInstanceWritableData<T>();
	}

	protected IT RequireReadonlyGameInstanceData<IT, T>() where IT : class where T : class, IT
	{
		return BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(Owner).GetGameInstanceReadonlyData<IT, T>();
	}

	static GameInstanceSystemBaseUObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GameInstanceSystemBaseUObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GameInstanceSystemBaseUObj));
		sResetCvarCache = new List<string>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GameInstanceSystemBaseUObj");
	}
}
