using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_DoReplicateData : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_DoReplicateData _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_DoReplicateData)Delegate.Combine(_MultiCastDel, (Del_DoReplicateData)Del);
		}
		else
		{
			_MultiCastDel = (Del_DoReplicateData)Delegate.Remove(_MultiCastDel, (Del_DoReplicateData)Del);
		}
	}

	public static GSDel_DoReplicateData operator +(GSDel_DoReplicateData GSEvent, Del_DoReplicateData Del)
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
		GSEvent._MultiCastDel = (Del_DoReplicateData)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_DoReplicateData operator -(GSDel_DoReplicateData GSEvent, Del_DoReplicateData Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_DoReplicateData == Del)
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
		GSEvent._MultiCastDel = (Del_DoReplicateData)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public int Invoke(IntPtr ConnectionPtr, byte[] bytes)
	{
		if (_MultiCastDel == null)
		{
			return 0;
		}
		return _MultiCastDel(ConnectionPtr, bytes);
	}
}
