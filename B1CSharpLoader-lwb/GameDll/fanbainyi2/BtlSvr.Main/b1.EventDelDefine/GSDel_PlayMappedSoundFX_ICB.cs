using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayMappedSoundFX_ICB : IFreshAbleGSEvent
{
	private Del_PlayMappedSoundFX _InvokeCallBack;

	private Action<Del_PlayMappedSoundFX> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayMappedSoundFX _MultiCastDel;

	public GSDel_PlayMappedSoundFX_ICB(Del_PlayMappedSoundFX InvokeCallBack, Action<Del_PlayMappedSoundFX> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayMappedSoundFX)Delegate.Combine(_MultiCastDel, (Del_PlayMappedSoundFX)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayMappedSoundFX)Delegate.Remove(_MultiCastDel, (Del_PlayMappedSoundFX)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayMappedSoundFX_ICB operator +(GSDel_PlayMappedSoundFX_ICB GSEvent, Del_PlayMappedSoundFX Del)
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
		GSEvent._MultiCastDel = (Del_PlayMappedSoundFX)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayMappedSoundFX_ICB operator -(GSDel_PlayMappedSoundFX_ICB GSEvent, Del_PlayMappedSoundFX Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayMappedSoundFX == Del)
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
		GSEvent._MultiCastDel = (Del_PlayMappedSoundFX)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EquipPosition EquipPosition, int ActionTypeID, bool bIsFollow, FName SocketName)
	{
		_InvokeCallBack?.Invoke(EquipPosition, ActionTypeID, bIsFollow, SocketName);
	}
}
