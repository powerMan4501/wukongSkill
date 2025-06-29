using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_DragFarCamera_ICB : IFreshAbleGSEvent
{
	private Del_DragFarCamera _InvokeCallBack;

	private Action<Del_DragFarCamera> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DragFarCamera _MultiCastDel;

	public GSDel_DragFarCamera_ICB(Del_DragFarCamera InvokeCallBack, Action<Del_DragFarCamera> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DragFarCamera)Delegate.Combine(_MultiCastDel, (Del_DragFarCamera)Del);
		}
		else
		{
			_MultiCastDel = (Del_DragFarCamera)Delegate.Remove(_MultiCastDel, (Del_DragFarCamera)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_DragFarCamera_ICB operator +(GSDel_DragFarCamera_ICB GSEvent, Del_DragFarCamera Del)
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
		GSEvent._MultiCastDel = (Del_DragFarCamera)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_DragFarCamera_ICB operator -(GSDel_DragFarCamera_ICB GSEvent, Del_DragFarCamera Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DragFarCamera == Del)
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
		GSEvent._MultiCastDel = (Del_DragFarCamera)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(bool IsDragFarest, float NewMinArmLength, float NewMaxArmLength, float NewMinSocketZ, float NewMaxSocketZ)
	{
		_InvokeCallBack?.Invoke(IsDragFarest, NewMinArmLength, NewMaxArmLength, NewMinSocketZ, NewMaxSocketZ);
	}
}
