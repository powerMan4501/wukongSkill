using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_BGS_TriggerTransEffect_ICB : IFreshAbleGSEvent
{
	private Del_BGS_TriggerTransEffect _InvokeCallBack;

	private Action<Del_BGS_TriggerTransEffect> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_BGS_TriggerTransEffect _MultiCastDel;

	public GSDel_BGS_TriggerTransEffect_ICB(Del_BGS_TriggerTransEffect InvokeCallBack, Action<Del_BGS_TriggerTransEffect> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_BGS_TriggerTransEffect)Delegate.Combine(_MultiCastDel, (Del_BGS_TriggerTransEffect)Del);
		}
		else
		{
			_MultiCastDel = (Del_BGS_TriggerTransEffect)Delegate.Remove(_MultiCastDel, (Del_BGS_TriggerTransEffect)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_BGS_TriggerTransEffect_ICB operator +(GSDel_BGS_TriggerTransEffect_ICB GSEvent, Del_BGS_TriggerTransEffect Del)
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
		GSEvent._MultiCastDel = (Del_BGS_TriggerTransEffect)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_BGS_TriggerTransEffect_ICB operator -(GSDel_BGS_TriggerTransEffect_ICB GSEvent, Del_BGS_TriggerTransEffect Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_BGS_TriggerTransEffect == Del)
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
		GSEvent._MultiCastDel = (Del_BGS_TriggerTransEffect)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(ACharacter Unit, string DataAssetPath, FVector EffectOffset)
	{
		_InvokeCallBack?.Invoke(Unit, DataAssetPath, EffectOffset);
	}
}
