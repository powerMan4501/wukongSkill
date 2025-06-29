using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_ActorTransformInfoData_ICB : IFreshAbleGSEvent
{
	private Del_ActorTransformInfoData _InvokeCallBack;

	private Action<Del_ActorTransformInfoData> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ActorTransformInfoData _MultiCastDel;

	public GSDel_ActorTransformInfoData_ICB(Del_ActorTransformInfoData InvokeCallBack, Action<Del_ActorTransformInfoData> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ActorTransformInfoData)Delegate.Combine(_MultiCastDel, (Del_ActorTransformInfoData)Del);
		}
		else
		{
			_MultiCastDel = (Del_ActorTransformInfoData)Delegate.Remove(_MultiCastDel, (Del_ActorTransformInfoData)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ActorTransformInfoData_ICB operator +(GSDel_ActorTransformInfoData_ICB GSEvent, Del_ActorTransformInfoData Del)
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
		GSEvent._MultiCastDel = (Del_ActorTransformInfoData)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ActorTransformInfoData_ICB operator -(GSDel_ActorTransformInfoData_ICB GSEvent, Del_ActorTransformInfoData Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ActorTransformInfoData == Del)
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
		GSEvent._MultiCastDel = (Del_ActorTransformInfoData)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public bool Invoke(AActor Target, IBUC_ActorTransformInfoData ActorTransformInfoData)
	{
		if (_InvokeCallBack == null)
		{
			return false;
		}
		return _InvokeCallBack(Target, ActorTransformInfoData);
	}
}
