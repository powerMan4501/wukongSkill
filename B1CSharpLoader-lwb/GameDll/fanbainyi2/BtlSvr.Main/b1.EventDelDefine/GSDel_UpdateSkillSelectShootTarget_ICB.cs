using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_UpdateSkillSelectShootTarget_ICB : IFreshAbleGSEvent
{
	private Del_UpdateSkillSelectShootTarget _InvokeCallBack;

	private Action<Del_UpdateSkillSelectShootTarget> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_UpdateSkillSelectShootTarget _MultiCastDel;

	public GSDel_UpdateSkillSelectShootTarget_ICB(Del_UpdateSkillSelectShootTarget InvokeCallBack, Action<Del_UpdateSkillSelectShootTarget> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_UpdateSkillSelectShootTarget)Delegate.Combine(_MultiCastDel, (Del_UpdateSkillSelectShootTarget)Del);
		}
		else
		{
			_MultiCastDel = (Del_UpdateSkillSelectShootTarget)Delegate.Remove(_MultiCastDel, (Del_UpdateSkillSelectShootTarget)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_UpdateSkillSelectShootTarget_ICB operator +(GSDel_UpdateSkillSelectShootTarget_ICB GSEvent, Del_UpdateSkillSelectShootTarget Del)
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
		GSEvent._MultiCastDel = (Del_UpdateSkillSelectShootTarget)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_UpdateSkillSelectShootTarget_ICB operator -(GSDel_UpdateSkillSelectShootTarget_ICB GSEvent, Del_UpdateSkillSelectShootTarget Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_UpdateSkillSelectShootTarget == Del)
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
		GSEvent._MultiCastDel = (Del_UpdateSkillSelectShootTarget)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(out AActor OutTarget)
	{
		OutTarget = null;
		_InvokeCallBack?.Invoke(out OutTarget);
	}
}
