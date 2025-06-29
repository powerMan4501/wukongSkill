using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_SetAttackIKBoneScaleAlpha_ICB : IFreshAbleGSEvent
{
	private Del_SetAttackIKBoneScaleAlpha _InvokeCallBack;

	private Action<Del_SetAttackIKBoneScaleAlpha> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_SetAttackIKBoneScaleAlpha _MultiCastDel;

	public GSDel_SetAttackIKBoneScaleAlpha_ICB(Del_SetAttackIKBoneScaleAlpha InvokeCallBack, Action<Del_SetAttackIKBoneScaleAlpha> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_SetAttackIKBoneScaleAlpha)Delegate.Combine(_MultiCastDel, (Del_SetAttackIKBoneScaleAlpha)Del);
		}
		else
		{
			_MultiCastDel = (Del_SetAttackIKBoneScaleAlpha)Delegate.Remove(_MultiCastDel, (Del_SetAttackIKBoneScaleAlpha)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_SetAttackIKBoneScaleAlpha_ICB operator +(GSDel_SetAttackIKBoneScaleAlpha_ICB GSEvent, Del_SetAttackIKBoneScaleAlpha Del)
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
		GSEvent._MultiCastDel = (Del_SetAttackIKBoneScaleAlpha)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_SetAttackIKBoneScaleAlpha_ICB operator -(GSDel_SetAttackIKBoneScaleAlpha_ICB GSEvent, Del_SetAttackIKBoneScaleAlpha Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_SetAttackIKBoneScaleAlpha == Del)
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
		GSEvent._MultiCastDel = (Del_SetAttackIKBoneScaleAlpha)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(float alpha)
	{
		_InvokeCallBack?.Invoke(alpha);
	}
}
