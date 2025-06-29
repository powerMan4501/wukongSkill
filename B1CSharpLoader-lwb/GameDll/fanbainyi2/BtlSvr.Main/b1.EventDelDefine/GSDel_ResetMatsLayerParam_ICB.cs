using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_ResetMatsLayerParam_ICB : IFreshAbleGSEvent
{
	private Del_ResetMatsLayerParam _InvokeCallBack;

	private Action<Del_ResetMatsLayerParam> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ResetMatsLayerParam _MultiCastDel;

	public GSDel_ResetMatsLayerParam_ICB(Del_ResetMatsLayerParam InvokeCallBack, Action<Del_ResetMatsLayerParam> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ResetMatsLayerParam)Delegate.Combine(_MultiCastDel, (Del_ResetMatsLayerParam)Del);
		}
		else
		{
			_MultiCastDel = (Del_ResetMatsLayerParam)Delegate.Remove(_MultiCastDel, (Del_ResetMatsLayerParam)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ResetMatsLayerParam_ICB operator +(GSDel_ResetMatsLayerParam_ICB GSEvent, Del_ResetMatsLayerParam Del)
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
		GSEvent._MultiCastDel = (Del_ResetMatsLayerParam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ResetMatsLayerParam_ICB operator -(GSDel_ResetMatsLayerParam_ICB GSEvent, Del_ResetMatsLayerParam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ResetMatsLayerParam == Del)
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
		GSEvent._MultiCastDel = (Del_ResetMatsLayerParam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int LayerMappingIdx, FName LayerMappingName, FName ParamName)
	{
		_InvokeCallBack?.Invoke(LayerMappingIdx, LayerMappingName, ParamName);
	}
}
