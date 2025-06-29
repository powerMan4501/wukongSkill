using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_Blend2PlayerCamera_ICB : IFreshAbleGSEvent
{
	private Del_Blend2PlayerCamera _InvokeCallBack;

	private Action<Del_Blend2PlayerCamera> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_Blend2PlayerCamera _MultiCastDel;

	public GSDel_Blend2PlayerCamera_ICB(Del_Blend2PlayerCamera InvokeCallBack, Action<Del_Blend2PlayerCamera> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_Blend2PlayerCamera)Delegate.Combine(_MultiCastDel, (Del_Blend2PlayerCamera)Del);
		}
		else
		{
			_MultiCastDel = (Del_Blend2PlayerCamera)Delegate.Remove(_MultiCastDel, (Del_Blend2PlayerCamera)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_Blend2PlayerCamera_ICB operator +(GSDel_Blend2PlayerCamera_ICB GSEvent, Del_Blend2PlayerCamera Del)
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
		GSEvent._MultiCastDel = (Del_Blend2PlayerCamera)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_Blend2PlayerCamera_ICB operator -(GSDel_Blend2PlayerCamera_ICB GSEvent, Del_Blend2PlayerCamera Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_Blend2PlayerCamera == Del)
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
		GSEvent._MultiCastDel = (Del_Blend2PlayerCamera)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float InCameraBlendOutTime, EViewTargetBlendFunction InCameraBlendOutFunction, float InCameraBlendOutFuncExp)
	{
		_InvokeCallBack?.Invoke(InCameraBlendOutTime, InCameraBlendOutFunction, InCameraBlendOutFuncExp);
	}
}
