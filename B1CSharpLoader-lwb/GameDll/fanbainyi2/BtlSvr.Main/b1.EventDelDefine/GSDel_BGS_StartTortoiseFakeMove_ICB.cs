using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_BGS_StartTortoiseFakeMove_ICB : IFreshAbleGSEvent
{
	private Del_BGS_StartTortoiseFakeMove _InvokeCallBack;

	private Action<Del_BGS_StartTortoiseFakeMove> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGS_StartTortoiseFakeMove _MultiCastDel;

	public GSDel_BGS_StartTortoiseFakeMove_ICB(Del_BGS_StartTortoiseFakeMove InvokeCallBack, Action<Del_BGS_StartTortoiseFakeMove> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGS_StartTortoiseFakeMove)Delegate.Combine(_MultiCastDel, (Del_BGS_StartTortoiseFakeMove)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGS_StartTortoiseFakeMove)Delegate.Remove(_MultiCastDel, (Del_BGS_StartTortoiseFakeMove)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BGS_StartTortoiseFakeMove_ICB operator +(GSDel_BGS_StartTortoiseFakeMove_ICB GSEvent, Del_BGS_StartTortoiseFakeMove Del)
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
		GSEvent._MultiCastDel = (Del_BGS_StartTortoiseFakeMove)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BGS_StartTortoiseFakeMove_ICB operator -(GSDel_BGS_StartTortoiseFakeMove_ICB GSEvent, Del_BGS_StartTortoiseFakeMove Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGS_StartTortoiseFakeMove == Del)
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
		GSEvent._MultiCastDel = (Del_BGS_StartTortoiseFakeMove)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UAnimSequence InverseAnim, bool IsLoop)
	{
		_InvokeCallBack?.Invoke(InverseAnim, IsLoop);
	}
}
