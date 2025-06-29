using System;
using System.Collections.Generic;
using b1.ECS;
using CommB1;

namespace b1.EventDelDefine;

public class GSDel_GMLoadSnapshotAttr_ICB : IFreshAbleGSEvent
{
	private Del_GMLoadSnapshotAttr _InvokeCallBack;

	private Action<Del_GMLoadSnapshotAttr> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_GMLoadSnapshotAttr _MultiCastDel;

	public GSDel_GMLoadSnapshotAttr_ICB(Del_GMLoadSnapshotAttr InvokeCallBack, Action<Del_GMLoadSnapshotAttr> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_GMLoadSnapshotAttr)Delegate.Combine(_MultiCastDel, (Del_GMLoadSnapshotAttr)Del);
		}
		else
		{
			_MultiCastDel = (Del_GMLoadSnapshotAttr)Delegate.Remove(_MultiCastDel, (Del_GMLoadSnapshotAttr)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_GMLoadSnapshotAttr_ICB operator +(GSDel_GMLoadSnapshotAttr_ICB GSEvent, Del_GMLoadSnapshotAttr Del)
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
		GSEvent._MultiCastDel = (Del_GMLoadSnapshotAttr)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_GMLoadSnapshotAttr_ICB operator -(GSDel_GMLoadSnapshotAttr_ICB GSEvent, Del_GMLoadSnapshotAttr Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_GMLoadSnapshotAttr == Del)
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
		GSEvent._MultiCastDel = (Del_GMLoadSnapshotAttr)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EffectAttrList effectAttrList, CustomAttrList customAttrList)
	{
		_InvokeCallBack?.Invoke(effectAttrList, customAttrList);
	}
}
