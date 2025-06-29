using System;
using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.UI;

public abstract class GSBattleDataDStore
{
	protected AActor Owner;

	protected int BindIdx;

	protected Dictionary<int, List<Action>> NeedActionDic = new Dictionary<int, List<Action>>();

	public GSBattleDataDStore(AActor actor)
	{
		Owner = actor;
	}

	public AActor GetOwner()
	{
		return Owner;
	}

	protected void BindAction(Action Action1, Action Action2)
	{
		List<Action> list = new List<Action>();
		list.Add(Action1);
		list.Add(Action2);
		BindIdx++;
		NeedActionDic.Add(BindIdx, list);
	}

	public void RemoveAction(int Index)
	{
		if (NeedActionDic.ContainsKey(Index))
		{
			NeedActionDic.Remove(Index);
		}
	}

	public virtual void ResetActor(AActor actor)
	{
		Owner = actor;
	}

	protected virtual void OnDestructImpl()
	{
	}
}
