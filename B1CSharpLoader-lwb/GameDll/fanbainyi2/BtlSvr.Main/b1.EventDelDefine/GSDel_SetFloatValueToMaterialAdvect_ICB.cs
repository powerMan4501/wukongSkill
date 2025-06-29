using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetFloatValueToMaterialAdvect_ICB : IFreshAbleGSEvent
{
	private Del_SetFloatValueToMaterialAdvect _InvokeCallBack;

	private Action<Del_SetFloatValueToMaterialAdvect> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetFloatValueToMaterialAdvect _MultiCastDel;

	public GSDel_SetFloatValueToMaterialAdvect_ICB(Del_SetFloatValueToMaterialAdvect InvokeCallBack, Action<Del_SetFloatValueToMaterialAdvect> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

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
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetFloatValueToMaterialAdvect_ICB operator +(GSDel_SetFloatValueToMaterialAdvect_ICB GSEvent, Del_SetFloatValueToMaterialAdvect Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetFloatValueToMaterialAdvect_ICB operator -(GSDel_SetFloatValueToMaterialAdvect_ICB GSEvent, Del_SetFloatValueToMaterialAdvect Del)
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
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FName ParamName, float FloatValue)
	{
		_InvokeCallBack?.Invoke(ParamName, FloatValue);
	}
}
