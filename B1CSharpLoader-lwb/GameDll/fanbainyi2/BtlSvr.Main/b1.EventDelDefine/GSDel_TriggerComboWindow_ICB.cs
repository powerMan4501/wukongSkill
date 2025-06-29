using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_TriggerComboWindow_ICB : IFreshAbleGSEvent
{
	private Del_TriggerComboWindow _InvokeCallBack;

	private Action<Del_TriggerComboWindow> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TriggerComboWindow _MultiCastDel;

	public GSDel_TriggerComboWindow_ICB(Del_TriggerComboWindow InvokeCallBack, Action<Del_TriggerComboWindow> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TriggerComboWindow)Delegate.Combine(_MultiCastDel, (Del_TriggerComboWindow)Del);
		}
		else
		{
			_MultiCastDel = (Del_TriggerComboWindow)Delegate.Remove(_MultiCastDel, (Del_TriggerComboWindow)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_TriggerComboWindow_ICB operator +(GSDel_TriggerComboWindow_ICB GSEvent, Del_TriggerComboWindow Del)
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
		GSEvent._MultiCastDel = (Del_TriggerComboWindow)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_TriggerComboWindow_ICB operator -(GSDel_TriggerComboWindow_ICB GSEvent, Del_TriggerComboWindow Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TriggerComboWindow == Del)
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
		GSEvent._MultiCastDel = (Del_TriggerComboWindow)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int MontageInstanceID, uint NotifyUniqueID, int GroupID, List<int> BlackListComboSkillID, List<int> WhiteListComboSkillID, float TotalDuration)
	{
		_InvokeCallBack?.Invoke(MontageInstanceID, NotifyUniqueID, GroupID, BlackListComboSkillID, WhiteListComboSkillID, TotalDuration);
	}
}
