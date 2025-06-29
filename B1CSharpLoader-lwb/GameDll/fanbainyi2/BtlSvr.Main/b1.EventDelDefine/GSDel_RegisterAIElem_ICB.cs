using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_RegisterAIElem_ICB : IFreshAbleGSEvent
{
	private Del_RegisterAIElem _InvokeCallBack;

	private Action<Del_RegisterAIElem> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RegisterAIElem _MultiCastDel;

	public GSDel_RegisterAIElem_ICB(Del_RegisterAIElem InvokeCallBack, Action<Del_RegisterAIElem> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RegisterAIElem)Delegate.Combine(_MultiCastDel, (Del_RegisterAIElem)Del);
		}
		else
		{
			_MultiCastDel = (Del_RegisterAIElem)Delegate.Remove(_MultiCastDel, (Del_RegisterAIElem)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RegisterAIElem_ICB operator +(GSDel_RegisterAIElem_ICB GSEvent, Del_RegisterAIElem Del)
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
		GSEvent._MultiCastDel = (Del_RegisterAIElem)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RegisterAIElem_ICB operator -(GSDel_RegisterAIElem_ICB GSEvent, Del_RegisterAIElem Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RegisterAIElem == Del)
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
		GSEvent._MultiCastDel = (Del_RegisterAIElem)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int ElemID, EAIElemType ElemType, float Score)
	{
		_InvokeCallBack?.Invoke(ElemID, ElemType, Score);
	}
}
