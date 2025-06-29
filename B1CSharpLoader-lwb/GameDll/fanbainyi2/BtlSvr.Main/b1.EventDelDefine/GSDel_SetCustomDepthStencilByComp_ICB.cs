using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_SetCustomDepthStencilByComp_ICB : IFreshAbleGSEvent
{
	private Del_SetCustomDepthStencilByComp _InvokeCallBack;

	private Action<Del_SetCustomDepthStencilByComp> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetCustomDepthStencilByComp _MultiCastDel;

	public GSDel_SetCustomDepthStencilByComp_ICB(Del_SetCustomDepthStencilByComp InvokeCallBack, Action<Del_SetCustomDepthStencilByComp> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetCustomDepthStencilByComp)Delegate.Combine(_MultiCastDel, (Del_SetCustomDepthStencilByComp)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetCustomDepthStencilByComp)Delegate.Remove(_MultiCastDel, (Del_SetCustomDepthStencilByComp)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetCustomDepthStencilByComp_ICB operator +(GSDel_SetCustomDepthStencilByComp_ICB GSEvent, Del_SetCustomDepthStencilByComp Del)
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
		GSEvent._MultiCastDel = (Del_SetCustomDepthStencilByComp)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetCustomDepthStencilByComp_ICB operator -(GSDel_SetCustomDepthStencilByComp_ICB GSEvent, Del_SetCustomDepthStencilByComp Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetCustomDepthStencilByComp == Del)
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
		GSEvent._MultiCastDel = (Del_SetCustomDepthStencilByComp)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FName CompName, bool bEnable, int Stencil)
	{
		_InvokeCallBack?.Invoke(CompName, bEnable, Stencil);
	}
}
