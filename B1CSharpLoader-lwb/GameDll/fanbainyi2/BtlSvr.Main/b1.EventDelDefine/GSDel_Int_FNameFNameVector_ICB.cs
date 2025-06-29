using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_Int_FNameFNameVector_ICB : IFreshAbleGSEvent
{
	private Del_Int_FNameFNameVector _InvokeCallBack;

	private Action<Del_Int_FNameFNameVector> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Int_FNameFNameVector _MultiCastDel;

	public GSDel_Int_FNameFNameVector_ICB(Del_Int_FNameFNameVector InvokeCallBack, Action<Del_Int_FNameFNameVector> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Int_FNameFNameVector)Delegate.Combine(_MultiCastDel, (Del_Int_FNameFNameVector)Del);
		}
		else
		{
			_MultiCastDel = (Del_Int_FNameFNameVector)Delegate.Remove(_MultiCastDel, (Del_Int_FNameFNameVector)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Int_FNameFNameVector_ICB operator +(GSDel_Int_FNameFNameVector_ICB GSEvent, Del_Int_FNameFNameVector Del)
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
		GSEvent._MultiCastDel = (Del_Int_FNameFNameVector)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Int_FNameFNameVector_ICB operator -(GSDel_Int_FNameFNameVector_ICB GSEvent, Del_Int_FNameFNameVector Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Int_FNameFNameVector == Del)
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
		GSEvent._MultiCastDel = (Del_Int_FNameFNameVector)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public int Invoke(FName P1, FName P2, FVector P3)
	{
		if (_InvokeCallBack == null)
		{
			return 0;
		}
		return _InvokeCallBack(P1, P2, P3);
	}
}
