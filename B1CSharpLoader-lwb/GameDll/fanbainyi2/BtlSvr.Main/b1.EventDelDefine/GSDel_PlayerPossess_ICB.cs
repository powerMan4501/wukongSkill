using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayerPossess_ICB : IFreshAbleGSEvent
{
	private Del_PlayerPossess _InvokeCallBack;

	private Action<Del_PlayerPossess> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayerPossess _MultiCastDel;

	public GSDel_PlayerPossess_ICB(Del_PlayerPossess InvokeCallBack, Action<Del_PlayerPossess> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayerPossess)Delegate.Combine(_MultiCastDel, (Del_PlayerPossess)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayerPossess)Delegate.Remove(_MultiCastDel, (Del_PlayerPossess)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayerPossess_ICB operator +(GSDel_PlayerPossess_ICB GSEvent, Del_PlayerPossess Del)
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
		GSEvent._MultiCastDel = (Del_PlayerPossess)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayerPossess_ICB operator -(GSDel_PlayerPossess_ICB GSEvent, Del_PlayerPossess Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayerPossess == Del)
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
		GSEvent._MultiCastDel = (Del_PlayerPossess)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UWorld World, ABGPPlayerController PC, UClass ToReplaceUnitInst, FTransform NewTransform, bool NeedBlend, out APawn NewPlayer, float PossessBlendTime = 0f, int PossessBlendFunc = 0, float PossessBlendExp = 0f, bool EnableBlendViewTarget = false)
	{
		NewPlayer = null;
		_InvokeCallBack?.Invoke(World, PC, ToReplaceUnitInst, NewTransform, NeedBlend, out NewPlayer, PossessBlendTime, PossessBlendFunc, PossessBlendExp, EnableBlendViewTarget);
	}
}
