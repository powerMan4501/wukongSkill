using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_OnSyncPlayGroupLeisureMontage_ICB : IFreshAbleGSEvent
{
	private Del_OnSyncPlayGroupLeisureMontage _InvokeCallBack;

	private Action<Del_OnSyncPlayGroupLeisureMontage> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnSyncPlayGroupLeisureMontage _MultiCastDel;

	public GSDel_OnSyncPlayGroupLeisureMontage_ICB(Del_OnSyncPlayGroupLeisureMontage InvokeCallBack, Action<Del_OnSyncPlayGroupLeisureMontage> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnSyncPlayGroupLeisureMontage)Delegate.Combine(_MultiCastDel, (Del_OnSyncPlayGroupLeisureMontage)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnSyncPlayGroupLeisureMontage)Delegate.Remove(_MultiCastDel, (Del_OnSyncPlayGroupLeisureMontage)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnSyncPlayGroupLeisureMontage_ICB operator +(GSDel_OnSyncPlayGroupLeisureMontage_ICB GSEvent, Del_OnSyncPlayGroupLeisureMontage Del)
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
		GSEvent._MultiCastDel = (Del_OnSyncPlayGroupLeisureMontage)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnSyncPlayGroupLeisureMontage_ICB operator -(GSDel_OnSyncPlayGroupLeisureMontage_ICB GSEvent, Del_OnSyncPlayGroupLeisureMontage Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnSyncPlayGroupLeisureMontage == Del)
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
		GSEvent._MultiCastDel = (Del_OnSyncPlayGroupLeisureMontage)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public float Invoke(AActor Actor, UAnimMontage Montage)
	{
		if (_InvokeCallBack == null)
		{
			return 0f;
		}
		return _InvokeCallBack(Actor, Montage);
	}
}
