using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetBeHitSkillTempData_ICB : IFreshAbleGSEvent
{
	private Del_SetBeHitSkillTempData _InvokeCallBack;

	private Action<Del_SetBeHitSkillTempData> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetBeHitSkillTempData _MultiCastDel;

	public GSDel_SetBeHitSkillTempData_ICB(Del_SetBeHitSkillTempData InvokeCallBack, Action<Del_SetBeHitSkillTempData> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetBeHitSkillTempData)Delegate.Combine(_MultiCastDel, (Del_SetBeHitSkillTempData)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetBeHitSkillTempData)Delegate.Remove(_MultiCastDel, (Del_SetBeHitSkillTempData)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetBeHitSkillTempData_ICB operator +(GSDel_SetBeHitSkillTempData_ICB GSEvent, Del_SetBeHitSkillTempData Del)
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
		GSEvent._MultiCastDel = (Del_SetBeHitSkillTempData)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetBeHitSkillTempData_ICB operator -(GSDel_SetBeHitSkillTempData_ICB GSEvent, Del_SetBeHitSkillTempData Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetBeHitSkillTempData == Del)
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
		GSEvent._MultiCastDel = (Del_SetBeHitSkillTempData)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FSkillDamageConfig Data)
	{
		_InvokeCallBack?.Invoke(Data);
	}
}
