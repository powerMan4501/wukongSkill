using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PushRenderTargetValuesToGroup : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PushRenderTargetValuesToGroup _MultiCastDel;

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
	}

	public static GSDel_PushRenderTargetValuesToGroup operator +(GSDel_PushRenderTargetValuesToGroup GSEvent, Del_PushRenderTargetValuesToGroup Del)
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
		return GSEvent;
	}

	public static GSDel_PushRenderTargetValuesToGroup operator -(GSDel_PushRenderTargetValuesToGroup GSEvent, Del_PushRenderTargetValuesToGroup Del)
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
		return GSEvent;
	}

	public void Invoke(RenderTargetType RTType, int GroupIndex, List<FLinearColor> ColorValues, List<float> FloatValues)
	{
		_MultiCastDel?.Invoke(RTType, GroupIndex, ColorValues, FloatValues);
	}
}
