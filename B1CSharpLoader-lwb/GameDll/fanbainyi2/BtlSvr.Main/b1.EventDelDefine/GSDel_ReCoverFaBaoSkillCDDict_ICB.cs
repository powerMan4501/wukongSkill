using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ReCoverFaBaoSkillCDDict_ICB : IFreshAbleGSEvent
{
	private Del_ReCoverFaBaoSkillCDDict _InvokeCallBack;

	private Action<Del_ReCoverFaBaoSkillCDDict> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ReCoverFaBaoSkillCDDict _MultiCastDel;

	public GSDel_ReCoverFaBaoSkillCDDict_ICB(Del_ReCoverFaBaoSkillCDDict InvokeCallBack, Action<Del_ReCoverFaBaoSkillCDDict> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ReCoverFaBaoSkillCDDict)Delegate.Combine(_MultiCastDel, (Del_ReCoverFaBaoSkillCDDict)Del);
		}
		else
		{
			_MultiCastDel = (Del_ReCoverFaBaoSkillCDDict)Delegate.Remove(_MultiCastDel, (Del_ReCoverFaBaoSkillCDDict)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ReCoverFaBaoSkillCDDict_ICB operator +(GSDel_ReCoverFaBaoSkillCDDict_ICB GSEvent, Del_ReCoverFaBaoSkillCDDict Del)
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
		GSEvent._MultiCastDel = (Del_ReCoverFaBaoSkillCDDict)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ReCoverFaBaoSkillCDDict_ICB operator -(GSDel_ReCoverFaBaoSkillCDDict_ICB GSEvent, Del_ReCoverFaBaoSkillCDDict Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ReCoverFaBaoSkillCDDict == Del)
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
		GSEvent._MultiCastDel = (Del_ReCoverFaBaoSkillCDDict)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(Dictionary<int, float> Dict)
	{
		_InvokeCallBack?.Invoke(Dict);
	}
}
