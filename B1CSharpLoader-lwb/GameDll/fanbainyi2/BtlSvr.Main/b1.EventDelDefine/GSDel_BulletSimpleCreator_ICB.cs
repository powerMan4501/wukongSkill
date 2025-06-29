using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_BulletSimpleCreator_ICB : IFreshAbleGSEvent
{
	private Del_BulletSimpleCreator _InvokeCallBack;

	private Action<Del_BulletSimpleCreator> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BulletSimpleCreator _MultiCastDel;

	public GSDel_BulletSimpleCreator_ICB(Del_BulletSimpleCreator InvokeCallBack, Action<Del_BulletSimpleCreator> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BulletSimpleCreator)Delegate.Combine(_MultiCastDel, (Del_BulletSimpleCreator)Del);
		}
		else
		{
			_MultiCastDel = (Del_BulletSimpleCreator)Delegate.Remove(_MultiCastDel, (Del_BulletSimpleCreator)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BulletSimpleCreator_ICB operator +(GSDel_BulletSimpleCreator_ICB GSEvent, Del_BulletSimpleCreator Del)
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
		GSEvent._MultiCastDel = (Del_BulletSimpleCreator)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BulletSimpleCreator_ICB operator -(GSDel_BulletSimpleCreator_ICB GSEvent, Del_BulletSimpleCreator Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BulletSimpleCreator == Del)
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
		GSEvent._MultiCastDel = (Del_BulletSimpleCreator)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(BulletSimpleCreateType CreateType, FSimpleCreatorInfo CreatorInfo)
	{
		_InvokeCallBack?.Invoke(CreateType, CreatorInfo);
	}
}
