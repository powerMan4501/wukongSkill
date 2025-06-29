using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_MarkBeAttackedWarnningProtectTime_ICB : IFreshAbleGSEvent
{
	private Del_MarkBeAttackedWarnningProtectTime _InvokeCallBack;

	private Action<Del_MarkBeAttackedWarnningProtectTime> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_MarkBeAttackedWarnningProtectTime _MultiCastDel;

	public GSDel_MarkBeAttackedWarnningProtectTime_ICB(Del_MarkBeAttackedWarnningProtectTime InvokeCallBack, Action<Del_MarkBeAttackedWarnningProtectTime> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_MarkBeAttackedWarnningProtectTime)Delegate.Combine(_MultiCastDel, (Del_MarkBeAttackedWarnningProtectTime)Del);
		}
		else
		{
			_MultiCastDel = (Del_MarkBeAttackedWarnningProtectTime)Delegate.Remove(_MultiCastDel, (Del_MarkBeAttackedWarnningProtectTime)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_MarkBeAttackedWarnningProtectTime_ICB operator +(GSDel_MarkBeAttackedWarnningProtectTime_ICB GSEvent, Del_MarkBeAttackedWarnningProtectTime Del)
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
		GSEvent._MultiCastDel = (Del_MarkBeAttackedWarnningProtectTime)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_MarkBeAttackedWarnningProtectTime_ICB operator -(GSDel_MarkBeAttackedWarnningProtectTime_ICB GSEvent, Del_MarkBeAttackedWarnningProtectTime Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_MarkBeAttackedWarnningProtectTime == Del)
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
		GSEvent._MultiCastDel = (Del_MarkBeAttackedWarnningProtectTime)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string SkillTaskUniqID, float ResetTime, float GroupResetTime, int GroupID, int FromInstanceID = -1)
	{
		_InvokeCallBack?.Invoke(SkillTaskUniqID, ResetTime, GroupResetTime, GroupID, FromInstanceID);
	}
}
