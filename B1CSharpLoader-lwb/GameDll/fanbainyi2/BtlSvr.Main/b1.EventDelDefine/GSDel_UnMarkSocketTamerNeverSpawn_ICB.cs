using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_UnMarkSocketTamerNeverSpawn_ICB : IFreshAbleGSEvent
{
	private Del_UnMarkSocketTamerNeverSpawn _InvokeCallBack;

	private Action<Del_UnMarkSocketTamerNeverSpawn> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UnMarkSocketTamerNeverSpawn _MultiCastDel;

	public GSDel_UnMarkSocketTamerNeverSpawn_ICB(Del_UnMarkSocketTamerNeverSpawn InvokeCallBack, Action<Del_UnMarkSocketTamerNeverSpawn> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UnMarkSocketTamerNeverSpawn)Delegate.Combine(_MultiCastDel, (Del_UnMarkSocketTamerNeverSpawn)Del);
		}
		else
		{
			_MultiCastDel = (Del_UnMarkSocketTamerNeverSpawn)Delegate.Remove(_MultiCastDel, (Del_UnMarkSocketTamerNeverSpawn)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UnMarkSocketTamerNeverSpawn_ICB operator +(GSDel_UnMarkSocketTamerNeverSpawn_ICB GSEvent, Del_UnMarkSocketTamerNeverSpawn Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			bool flag = entityComponent.IsNetActive();
			orAllocEventRegCache.Add(EventRegCache.AllocEventRegCache(GSEvent.EventId, Del, flag));
			if (!flag)
			{
				return GSEvent;
			}
		}
		GSEvent._MultiCastDel = (Del_UnMarkSocketTamerNeverSpawn)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UnMarkSocketTamerNeverSpawn_ICB operator -(GSDel_UnMarkSocketTamerNeverSpawn_ICB GSEvent, Del_UnMarkSocketTamerNeverSpawn Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UnMarkSocketTamerNeverSpawn == Del)
				{
					EventRegCache.DeAllocEventRegCache(orAllocEventRegCache[num]);
					orAllocEventRegCache.RemoveAt(num);
				}
			}
			if (orAllocEventRegCache.Count == 0)
			{
				GSEvent._OwnerEventCollectionCS.DeAllocEventRegCache(entityComponent);
			}
			if (!entityComponent.IsNetActive())
			{
				return GSEvent;
			}
		}
		GSEvent._MultiCastDel = (Del_UnMarkSocketTamerNeverSpawn)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor RootActor, FTamerFamilyMatchChildInfo MatchInfo)
	{
		_InvokeCallBack?.Invoke(RootActor, MatchInfo);
	}
}
