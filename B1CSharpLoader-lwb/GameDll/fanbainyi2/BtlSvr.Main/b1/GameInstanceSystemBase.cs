using b1.BGW;
using UnrealEngine.Runtime;

namespace b1;

public class GameInstanceSystemBase : IGameInstObjCS, IGameInstObj, ICallbackValidator
{
	public int _TickStatId = -1;

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

	public virtual bool bTickEnabled => false;

	public UObject Owner { get; set; }

	public bool IsValidAcceptCallback()
	{
		return !Owner.IsNullOrDestroyed();
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
	}

	public virtual void OnPostLoadMap()
	{
	}

	protected T RequireWritableGameInstanceData<T>() where T : class
	{
		return BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(Owner).GetGameInstanceWritableData<T>();
	}

	protected IT RequireReadonlyGameInstanceData<IT, T>() where IT : class where T : class, IT
	{
		return BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(Owner).GetGameInstanceReadonlyData<IT, T>();
	}
}
