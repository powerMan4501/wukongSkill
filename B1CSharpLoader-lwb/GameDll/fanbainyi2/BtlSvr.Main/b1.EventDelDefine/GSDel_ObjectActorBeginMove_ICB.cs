using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_ObjectActorBeginMove_ICB : IFreshAbleGSEvent
{
	private Del_ObjectActorBeginMove _InvokeCallBack;

	private Action<Del_ObjectActorBeginMove> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ObjectActorBeginMove _MultiCastDel;

	public GSDel_ObjectActorBeginMove_ICB(Del_ObjectActorBeginMove InvokeCallBack, Action<Del_ObjectActorBeginMove> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ObjectActorBeginMove)Delegate.Combine(_MultiCastDel, (Del_ObjectActorBeginMove)Del);
		}
		else
		{
			_MultiCastDel = (Del_ObjectActorBeginMove)Delegate.Remove(_MultiCastDel, (Del_ObjectActorBeginMove)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ObjectActorBeginMove_ICB operator +(GSDel_ObjectActorBeginMove_ICB GSEvent, Del_ObjectActorBeginMove Del)
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
		GSEvent._MultiCastDel = (Del_ObjectActorBeginMove)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ObjectActorBeginMove_ICB operator -(GSDel_ObjectActorBeginMove_ICB GSEvent, Del_ObjectActorBeginMove Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ObjectActorBeginMove == Del)
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
		GSEvent._MultiCastDel = (Del_ObjectActorBeginMove)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EBulletOrMagicFieldMoveModeType BulletOrMagicFieldMoveModeType)
	{
		_InvokeCallBack?.Invoke(BulletOrMagicFieldMoveModeType);
	}
}
