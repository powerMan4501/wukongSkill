using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_AICastBestSkillByScore_ICB : IFreshAbleGSEvent
{
	private Del_AICastBestSkillByScore _InvokeCallBack;

	private Action<Del_AICastBestSkillByScore> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AICastBestSkillByScore _MultiCastDel;

	public GSDel_AICastBestSkillByScore_ICB(Del_AICastBestSkillByScore InvokeCallBack, Action<Del_AICastBestSkillByScore> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AICastBestSkillByScore)Delegate.Combine(_MultiCastDel, (Del_AICastBestSkillByScore)Del);
		}
		else
		{
			_MultiCastDel = (Del_AICastBestSkillByScore)Delegate.Remove(_MultiCastDel, (Del_AICastBestSkillByScore)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AICastBestSkillByScore_ICB operator +(GSDel_AICastBestSkillByScore_ICB GSEvent, Del_AICastBestSkillByScore Del)
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
		GSEvent._MultiCastDel = (Del_AICastBestSkillByScore)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AICastBestSkillByScore_ICB operator -(GSDel_AICastBestSkillByScore_ICB GSEvent, Del_AICastBestSkillByScore Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AICastBestSkillByScore == Del)
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
		GSEvent._MultiCastDel = (Del_AICastBestSkillByScore)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FOneCBGCastSkillInfoCS> SkillInfoList, bool IsGetTopRandomSkill, int TopRandomSkillPercent, bool NeedTryCastAllSkillUntilSuccess)
	{
		_InvokeCallBack?.Invoke(SkillInfoList, IsGetTopRandomSkill, TopRandomSkillPercent, NeedTryCastAllSkillUntilSuccess);
	}
}
