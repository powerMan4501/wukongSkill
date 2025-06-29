using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_OnGenerateSkillFeature_ICB : IFreshAbleGSEvent
{
	private Del_OnGenerateSkillFeature _InvokeCallBack;

	private Action<Del_OnGenerateSkillFeature> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_OnGenerateSkillFeature _MultiCastDel;

	public GSDel_OnGenerateSkillFeature_ICB(Del_OnGenerateSkillFeature InvokeCallBack, Action<Del_OnGenerateSkillFeature> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_OnGenerateSkillFeature)Delegate.Combine(_MultiCastDel, (Del_OnGenerateSkillFeature)Del);
		}
		else
		{
			_MultiCastDel = (Del_OnGenerateSkillFeature)Delegate.Remove(_MultiCastDel, (Del_OnGenerateSkillFeature)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_OnGenerateSkillFeature_ICB operator +(GSDel_OnGenerateSkillFeature_ICB GSEvent, Del_OnGenerateSkillFeature Del)
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
		GSEvent._MultiCastDel = (Del_OnGenerateSkillFeature)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_OnGenerateSkillFeature_ICB operator -(GSDel_OnGenerateSkillFeature_ICB GSEvent, Del_OnGenerateSkillFeature Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_OnGenerateSkillFeature == Del)
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
		GSEvent._MultiCastDel = (Del_OnGenerateSkillFeature)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AFSkillArea SkillRangeFeature)
	{
		_InvokeCallBack?.Invoke(SkillRangeFeature);
	}
}
