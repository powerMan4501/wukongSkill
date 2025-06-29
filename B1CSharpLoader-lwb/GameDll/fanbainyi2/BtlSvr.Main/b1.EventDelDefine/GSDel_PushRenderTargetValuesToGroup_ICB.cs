using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PushRenderTargetValuesToGroup_ICB : IFreshAbleGSEvent
{
	private Del_PushRenderTargetValuesToGroup _InvokeCallBack;

	private Action<Del_PushRenderTargetValuesToGroup> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PushRenderTargetValuesToGroup _MultiCastDel;

	public GSDel_PushRenderTargetValuesToGroup_ICB(Del_PushRenderTargetValuesToGroup InvokeCallBack, Action<Del_PushRenderTargetValuesToGroup> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PushRenderTargetValuesToGroup)Delegate.Combine(_MultiCastDel, (Del_PushRenderTargetValuesToGroup)Del);
		}
		else
		{
			_MultiCastDel = (Del_PushRenderTargetValuesToGroup)Delegate.Remove(_MultiCastDel, (Del_PushRenderTargetValuesToGroup)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PushRenderTargetValuesToGroup_ICB operator +(GSDel_PushRenderTargetValuesToGroup_ICB GSEvent, Del_PushRenderTargetValuesToGroup Del)
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
		GSEvent._MultiCastDel = (Del_PushRenderTargetValuesToGroup)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PushRenderTargetValuesToGroup_ICB operator -(GSDel_PushRenderTargetValuesToGroup_ICB GSEvent, Del_PushRenderTargetValuesToGroup Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PushRenderTargetValuesToGroup == Del)
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
		GSEvent._MultiCastDel = (Del_PushRenderTargetValuesToGroup)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(RenderTargetType RTType, int GroupIndex, List<FLinearColor> ColorValues, List<float> FloatValues)
	{
		_InvokeCallBack?.Invoke(RTType, GroupIndex, ColorValues, FloatValues);
	}
}
