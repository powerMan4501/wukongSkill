using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_SwitchMagicConfInfo_ICB : IFreshAbleGSEvent
{
	private Del_SwitchMagicConfInfo _InvokeCallBack;

	private Action<Del_SwitchMagicConfInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SwitchMagicConfInfo _MultiCastDel;

	public GSDel_SwitchMagicConfInfo_ICB(Del_SwitchMagicConfInfo InvokeCallBack, Action<Del_SwitchMagicConfInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SwitchMagicConfInfo)Delegate.Combine(_MultiCastDel, (Del_SwitchMagicConfInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_SwitchMagicConfInfo)Delegate.Remove(_MultiCastDel, (Del_SwitchMagicConfInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SwitchMagicConfInfo_ICB operator +(GSDel_SwitchMagicConfInfo_ICB GSEvent, Del_SwitchMagicConfInfo Del)
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
		GSEvent._MultiCastDel = (Del_SwitchMagicConfInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SwitchMagicConfInfo_ICB operator -(GSDel_SwitchMagicConfInfo_ICB GSEvent, Del_SwitchMagicConfInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SwitchMagicConfInfo == Del)
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
		GSEvent._MultiCastDel = (Del_SwitchMagicConfInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(SpellType SpellType, int NewSpellId, int OldSpellId)
	{
		_InvokeCallBack?.Invoke(SpellType, NewSpellId, OldSpellId);
	}
}
