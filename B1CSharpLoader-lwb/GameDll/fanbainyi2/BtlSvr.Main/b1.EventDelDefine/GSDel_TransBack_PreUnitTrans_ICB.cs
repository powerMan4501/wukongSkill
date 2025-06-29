using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TransBack_PreUnitTrans_ICB : IFreshAbleGSEvent
{
	private Del_TransBack_PreUnitTrans _InvokeCallBack;

	private Action<Del_TransBack_PreUnitTrans> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TransBack_PreUnitTrans _MultiCastDel;

	public GSDel_TransBack_PreUnitTrans_ICB(Del_TransBack_PreUnitTrans InvokeCallBack, Action<Del_TransBack_PreUnitTrans> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TransBack_PreUnitTrans)Delegate.Combine(_MultiCastDel, (Del_TransBack_PreUnitTrans)Del);
		}
		else
		{
			_MultiCastDel = (Del_TransBack_PreUnitTrans)Delegate.Remove(_MultiCastDel, (Del_TransBack_PreUnitTrans)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TransBack_PreUnitTrans_ICB operator +(GSDel_TransBack_PreUnitTrans_ICB GSEvent, Del_TransBack_PreUnitTrans Del)
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
		GSEvent._MultiCastDel = (Del_TransBack_PreUnitTrans)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TransBack_PreUnitTrans_ICB operator -(GSDel_TransBack_PreUnitTrans_ICB GSEvent, Del_TransBack_PreUnitTrans Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TransBack_PreUnitTrans == Del)
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
		GSEvent._MultiCastDel = (Del_TransBack_PreUnitTrans)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EPlayerTransEndType UnitTransType)
	{
		_InvokeCallBack?.Invoke(UnitTransType);
	}
}
