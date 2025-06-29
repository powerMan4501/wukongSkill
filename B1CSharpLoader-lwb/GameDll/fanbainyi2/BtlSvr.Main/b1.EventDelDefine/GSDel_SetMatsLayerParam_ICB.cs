using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetMatsLayerParam_ICB : IFreshAbleGSEvent
{
	private Del_SetMatsLayerParam _InvokeCallBack;

	private Action<Del_SetMatsLayerParam> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetMatsLayerParam _MultiCastDel;

	public GSDel_SetMatsLayerParam_ICB(Del_SetMatsLayerParam InvokeCallBack, Action<Del_SetMatsLayerParam> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetMatsLayerParam)Delegate.Combine(_MultiCastDel, (Del_SetMatsLayerParam)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetMatsLayerParam)Delegate.Remove(_MultiCastDel, (Del_SetMatsLayerParam)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetMatsLayerParam_ICB operator +(GSDel_SetMatsLayerParam_ICB GSEvent, Del_SetMatsLayerParam Del)
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
		GSEvent._MultiCastDel = (Del_SetMatsLayerParam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetMatsLayerParam_ICB operator -(GSDel_SetMatsLayerParam_ICB GSEvent, Del_SetMatsLayerParam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetMatsLayerParam == Del)
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
		GSEvent._MultiCastDel = (Del_SetMatsLayerParam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int LayerMappingIdx, FName LayerMappingName, FName ParamName, in MaterialParamInfo NewMPI, bool ForceUpdateDefaultValue)
	{
		_InvokeCallBack?.Invoke(LayerMappingIdx, LayerMappingName, ParamName, in NewMPI, ForceUpdateDefaultValue);
	}
}
