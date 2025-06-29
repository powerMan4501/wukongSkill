using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SwitchDispInteractConfig : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SwitchDispInteractConfig _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SwitchDispInteractConfig)Delegate.Combine(_MultiCastDel, (Del_SwitchDispInteractConfig)Del);
		}
		else
		{
			_MultiCastDel = (Del_SwitchDispInteractConfig)Delegate.Remove(_MultiCastDel, (Del_SwitchDispInteractConfig)Del);
		}
	}

	public static GSDel_SwitchDispInteractConfig operator +(GSDel_SwitchDispInteractConfig GSEvent, Del_SwitchDispInteractConfig Del)
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
		GSEvent._MultiCastDel = (Del_SwitchDispInteractConfig)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SwitchDispInteractConfig operator -(GSDel_SwitchDispInteractConfig GSEvent, Del_SwitchDispInteractConfig Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SwitchDispInteractConfig == Del)
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
		GSEvent._MultiCastDel = (Del_SwitchDispInteractConfig)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<FBoneUseForDispMap> DispInteractBoneList_New)
	{
		_MultiCastDel?.Invoke(DispInteractBoneList_New);
	}
}
