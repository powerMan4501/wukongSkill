using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_EnableCheckBuffGroup : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_EnableCheckBuffGroup _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_EnableCheckBuffGroup)Delegate.Combine(_MultiCastDel, (Del_EnableCheckBuffGroup)Del);
		}
		else
		{
			_MultiCastDel = (Del_EnableCheckBuffGroup)Delegate.Remove(_MultiCastDel, (Del_EnableCheckBuffGroup)Del);
		}
	}

	public static GSDel_EnableCheckBuffGroup operator +(GSDel_EnableCheckBuffGroup GSEvent, Del_EnableCheckBuffGroup Del)
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
		GSEvent._MultiCastDel = (Del_EnableCheckBuffGroup)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_EnableCheckBuffGroup operator -(GSDel_EnableCheckBuffGroup GSEvent, Del_EnableCheckBuffGroup Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_EnableCheckBuffGroup == Del)
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
		GSEvent._MultiCastDel = (Del_EnableCheckBuffGroup)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(int BuffGroupID, int TotalLayerCount, int RequiredActiveBuffCount, int AddBuffID)
	{
		_MultiCastDel?.Invoke(BuffGroupID, TotalLayerCount, RequiredActiveBuffCount, AddBuffID);
	}
}
