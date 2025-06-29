using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RegistExtraInteractBones_ICB : IFreshAbleGSEvent
{
	private Del_RegistExtraInteractBones _InvokeCallBack;

	private Action<Del_RegistExtraInteractBones> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RegistExtraInteractBones _MultiCastDel;

	public GSDel_RegistExtraInteractBones_ICB(Del_RegistExtraInteractBones InvokeCallBack, Action<Del_RegistExtraInteractBones> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RegistExtraInteractBones)Delegate.Combine(_MultiCastDel, (Del_RegistExtraInteractBones)Del);
		}
		else
		{
			_MultiCastDel = (Del_RegistExtraInteractBones)Delegate.Remove(_MultiCastDel, (Del_RegistExtraInteractBones)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RegistExtraInteractBones_ICB operator +(GSDel_RegistExtraInteractBones_ICB GSEvent, Del_RegistExtraInteractBones Del)
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
		GSEvent._MultiCastDel = (Del_RegistExtraInteractBones)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RegistExtraInteractBones_ICB operator -(GSDel_RegistExtraInteractBones_ICB GSEvent, Del_RegistExtraInteractBones Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RegistExtraInteractBones == Del)
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
		GSEvent._MultiCastDel = (Del_RegistExtraInteractBones)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(int NotifyID, TArrayReadWrite<FBoneUseForDispMap> InteractBones)
	{
		_InvokeCallBack?.Invoke(NotifyID, InteractBones);
	}
}
