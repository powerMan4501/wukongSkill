using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetFloatValueToMaterialAdvect : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetFloatValueToMaterialAdvect _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetFloatValueToMaterialAdvect)Delegate.Combine(_MultiCastDel, (Del_SetFloatValueToMaterialAdvect)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetFloatValueToMaterialAdvect)Delegate.Remove(_MultiCastDel, (Del_SetFloatValueToMaterialAdvect)Del);
		}
	}

	public static GSDel_SetFloatValueToMaterialAdvect operator +(GSDel_SetFloatValueToMaterialAdvect GSEvent, Del_SetFloatValueToMaterialAdvect Del)
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
		GSEvent._MultiCastDel = (Del_SetFloatValueToMaterialAdvect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_SetFloatValueToMaterialAdvect operator -(GSDel_SetFloatValueToMaterialAdvect GSEvent, Del_SetFloatValueToMaterialAdvect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetFloatValueToMaterialAdvect == Del)
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
		GSEvent._MultiCastDel = (Del_SetFloatValueToMaterialAdvect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(FName ParamName, float FloatValue)
	{
		_MultiCastDel?.Invoke(ParamName, FloatValue);
	}
}
