using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_Void_StringIntIntIntFloat_ICB : IFreshAbleGSEvent
{
	private Del_Void_StringIntIntIntFloat _InvokeCallBack;

	private Action<Del_Void_StringIntIntIntFloat> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Void_StringIntIntIntFloat _MultiCastDel;

	public GSDel_Void_StringIntIntIntFloat_ICB(Del_Void_StringIntIntIntFloat InvokeCallBack, Action<Del_Void_StringIntIntIntFloat> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Void_StringIntIntIntFloat)Delegate.Combine(_MultiCastDel, (Del_Void_StringIntIntIntFloat)Del);
		}
		else
		{
			_MultiCastDel = (Del_Void_StringIntIntIntFloat)Delegate.Remove(_MultiCastDel, (Del_Void_StringIntIntIntFloat)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Void_StringIntIntIntFloat_ICB operator +(GSDel_Void_StringIntIntIntFloat_ICB GSEvent, Del_Void_StringIntIntIntFloat Del)
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
		GSEvent._MultiCastDel = (Del_Void_StringIntIntIntFloat)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Void_StringIntIntIntFloat_ICB operator -(GSDel_Void_StringIntIntIntFloat_ICB GSEvent, Del_Void_StringIntIntIntFloat Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Void_StringIntIntIntFloat == Del)
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
		GSEvent._MultiCastDel = (Del_Void_StringIntIntIntFloat)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string P1, int P2, int P3, int P4, float P5)
	{
		_InvokeCallBack?.Invoke(P1, P2, P3, P4, P5);
	}
}
