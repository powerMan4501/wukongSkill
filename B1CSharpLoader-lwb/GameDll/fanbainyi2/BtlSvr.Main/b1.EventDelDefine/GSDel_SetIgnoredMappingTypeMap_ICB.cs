using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1.EventDelDefine;

public class GSDel_SetIgnoredMappingTypeMap_ICB : IFreshAbleGSEvent
{
	private Del_SetIgnoredMappingTypeMap _InvokeCallBack;

	private Action<Del_SetIgnoredMappingTypeMap> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetIgnoredMappingTypeMap _MultiCastDel;

	public GSDel_SetIgnoredMappingTypeMap_ICB(Del_SetIgnoredMappingTypeMap InvokeCallBack, Action<Del_SetIgnoredMappingTypeMap> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetIgnoredMappingTypeMap)Delegate.Combine(_MultiCastDel, (Del_SetIgnoredMappingTypeMap)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetIgnoredMappingTypeMap)Delegate.Remove(_MultiCastDel, (Del_SetIgnoredMappingTypeMap)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetIgnoredMappingTypeMap_ICB operator +(GSDel_SetIgnoredMappingTypeMap_ICB GSEvent, Del_SetIgnoredMappingTypeMap Del)
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
		GSEvent._MultiCastDel = (Del_SetIgnoredMappingTypeMap)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetIgnoredMappingTypeMap_ICB operator -(GSDel_SetIgnoredMappingTypeMap_ICB GSEvent, Del_SetIgnoredMappingTypeMap Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetIgnoredMappingTypeMap == Del)
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
		GSEvent._MultiCastDel = (Del_SetIgnoredMappingTypeMap)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(in Dictionary<ESkillMappingConditionType, bool> IgnorESkillMappingConditionTypeMap)
	{
		_InvokeCallBack?.Invoke(in IgnorESkillMappingConditionTypeMap);
	}
}
