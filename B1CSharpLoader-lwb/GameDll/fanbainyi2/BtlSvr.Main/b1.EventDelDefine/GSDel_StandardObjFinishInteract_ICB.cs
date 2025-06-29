using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_StandardObjFinishInteract_ICB : IFreshAbleGSEvent
{
	private Del_StandardObjFinishInteract _InvokeCallBack;

	private Action<Del_StandardObjFinishInteract> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_StandardObjFinishInteract _MultiCastDel;

	public GSDel_StandardObjFinishInteract_ICB(Del_StandardObjFinishInteract InvokeCallBack, Action<Del_StandardObjFinishInteract> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_StandardObjFinishInteract)Delegate.Combine(_MultiCastDel, (Del_StandardObjFinishInteract)Del);
		}
		else
		{
			_MultiCastDel = (Del_StandardObjFinishInteract)Delegate.Remove(_MultiCastDel, (Del_StandardObjFinishInteract)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_StandardObjFinishInteract_ICB operator +(GSDel_StandardObjFinishInteract_ICB GSEvent, Del_StandardObjFinishInteract Del)
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
		GSEvent._MultiCastDel = (Del_StandardObjFinishInteract)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_StandardObjFinishInteract_ICB operator -(GSDel_StandardObjFinishInteract_ICB GSEvent, Del_StandardObjFinishInteract Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_StandardObjFinishInteract == Del)
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
		GSEvent._MultiCastDel = (Del_StandardObjFinishInteract)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor Player, string Guid)
	{
		_InvokeCallBack?.Invoke(Player, Guid);
	}
}
