using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetSkillPreviewConfig_ICB : IFreshAbleGSEvent
{
	private Del_SetSkillPreviewConfig _InvokeCallBack;

	private Action<Del_SetSkillPreviewConfig> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetSkillPreviewConfig _MultiCastDel;

	public GSDel_SetSkillPreviewConfig_ICB(Del_SetSkillPreviewConfig InvokeCallBack, Action<Del_SetSkillPreviewConfig> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetSkillPreviewConfig)Delegate.Combine(_MultiCastDel, (Del_SetSkillPreviewConfig)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetSkillPreviewConfig)Delegate.Remove(_MultiCastDel, (Del_SetSkillPreviewConfig)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetSkillPreviewConfig_ICB operator +(GSDel_SetSkillPreviewConfig_ICB GSEvent, Del_SetSkillPreviewConfig Del)
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
		GSEvent._MultiCastDel = (Del_SetSkillPreviewConfig)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetSkillPreviewConfig_ICB operator -(GSDel_SetSkillPreviewConfig_ICB GSEvent, Del_SetSkillPreviewConfig Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetSkillPreviewConfig == Del)
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
		GSEvent._MultiCastDel = (Del_SetSkillPreviewConfig)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(FSkillPreviewConfig SkillPreviewConfig)
	{
		_InvokeCallBack?.Invoke(SkillPreviewConfig);
	}
}
