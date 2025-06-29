using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_RegisterFamilyTree_ICB : IFreshAbleGSEvent
{
	private Del_RegisterFamilyTree _InvokeCallBack;

	private Action<Del_RegisterFamilyTree> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RegisterFamilyTree _MultiCastDel;

	public GSDel_RegisterFamilyTree_ICB(Del_RegisterFamilyTree InvokeCallBack, Action<Del_RegisterFamilyTree> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RegisterFamilyTree)Delegate.Combine(_MultiCastDel, (Del_RegisterFamilyTree)Del);
		}
		else
		{
			_MultiCastDel = (Del_RegisterFamilyTree)Delegate.Remove(_MultiCastDel, (Del_RegisterFamilyTree)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RegisterFamilyTree_ICB operator +(GSDel_RegisterFamilyTree_ICB GSEvent, Del_RegisterFamilyTree Del)
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
		GSEvent._MultiCastDel = (Del_RegisterFamilyTree)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RegisterFamilyTree_ICB operator -(GSDel_RegisterFamilyTree_ICB GSEvent, Del_RegisterFamilyTree Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RegisterFamilyTree == Del)
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
		GSEvent._MultiCastDel = (Del_RegisterFamilyTree)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BUCircusBase Actor, bool Register)
	{
		_InvokeCallBack?.Invoke(Actor, Register);
	}
}
