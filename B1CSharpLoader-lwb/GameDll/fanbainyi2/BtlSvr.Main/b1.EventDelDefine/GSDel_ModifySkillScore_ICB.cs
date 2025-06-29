using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_ModifySkillScore_ICB : IFreshAbleGSEvent
{
	private Del_ModifySkillScore _InvokeCallBack;

	private Action<Del_ModifySkillScore> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ModifySkillScore _MultiCastDel;

	public GSDel_ModifySkillScore_ICB(Del_ModifySkillScore InvokeCallBack, Action<Del_ModifySkillScore> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ModifySkillScore)Delegate.Combine(_MultiCastDel, (Del_ModifySkillScore)Del);
		}
		else
		{
			_MultiCastDel = (Del_ModifySkillScore)Delegate.Remove(_MultiCastDel, (Del_ModifySkillScore)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ModifySkillScore_ICB operator +(GSDel_ModifySkillScore_ICB GSEvent, Del_ModifySkillScore Del)
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
		GSEvent._MultiCastDel = (Del_ModifySkillScore)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ModifySkillScore_ICB operator -(GSDel_ModifySkillScore_ICB GSEvent, Del_ModifySkillScore Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ModifySkillScore == Del)
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
		GSEvent._MultiCastDel = (Del_ModifySkillScore)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(List<FHitModifySkillScoreInfo> SuccessInfoList, List<FHitModifySkillScoreInfo> FailedInfoList)
	{
		_InvokeCallBack?.Invoke(SuccessInfoList, FailedInfoList);
	}
}
