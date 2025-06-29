using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ReleaseBlockInSPState_ICB : IFreshAbleGSEvent
{
	private Del_ReleaseBlockInSPState _InvokeCallBack;

	private Action<Del_ReleaseBlockInSPState> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ReleaseBlockInSPState _MultiCastDel;

	public GSDel_ReleaseBlockInSPState_ICB(Del_ReleaseBlockInSPState InvokeCallBack, Action<Del_ReleaseBlockInSPState> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ReleaseBlockInSPState)Delegate.Combine(_MultiCastDel, (Del_ReleaseBlockInSPState)Del);
		}
		else
		{
			_MultiCastDel = (Del_ReleaseBlockInSPState)Delegate.Remove(_MultiCastDel, (Del_ReleaseBlockInSPState)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ReleaseBlockInSPState_ICB operator +(GSDel_ReleaseBlockInSPState_ICB GSEvent, Del_ReleaseBlockInSPState Del)
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
		GSEvent._MultiCastDel = (Del_ReleaseBlockInSPState)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ReleaseBlockInSPState_ICB operator -(GSDel_ReleaseBlockInSPState_ICB GSEvent, Del_ReleaseBlockInSPState Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ReleaseBlockInSPState == Del)
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
		GSEvent._MultiCastDel = (Del_ReleaseBlockInSPState)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int MontageInstanceID, int NotifyUniqueID)
	{
		_InvokeCallBack?.Invoke(MontageInstanceID, NotifyUniqueID);
	}
}
