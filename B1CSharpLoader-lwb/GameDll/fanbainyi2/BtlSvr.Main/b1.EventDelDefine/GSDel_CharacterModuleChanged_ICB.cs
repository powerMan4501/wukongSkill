using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_CharacterModuleChanged_ICB : IFreshAbleGSEvent
{
	private Del_CharacterModuleChanged _InvokeCallBack;

	private Action<Del_CharacterModuleChanged> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_CharacterModuleChanged _MultiCastDel;

	public GSDel_CharacterModuleChanged_ICB(Del_CharacterModuleChanged InvokeCallBack, Action<Del_CharacterModuleChanged> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_CharacterModuleChanged)Delegate.Combine(_MultiCastDel, (Del_CharacterModuleChanged)Del);
		}
		else
		{
			_MultiCastDel = (Del_CharacterModuleChanged)Delegate.Remove(_MultiCastDel, (Del_CharacterModuleChanged)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_CharacterModuleChanged_ICB operator +(GSDel_CharacterModuleChanged_ICB GSEvent, Del_CharacterModuleChanged Del)
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
		GSEvent._MultiCastDel = (Del_CharacterModuleChanged)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_CharacterModuleChanged_ICB operator -(GSDel_CharacterModuleChanged_ICB GSEvent, Del_CharacterModuleChanged Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_CharacterModuleChanged == Del)
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
		GSEvent._MultiCastDel = (Del_CharacterModuleChanged)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EquipPosition EquipPosition, int RequestID, in FCharacterModuleResourceData ResourceData)
	{
		_InvokeCallBack?.Invoke(EquipPosition, RequestID, in ResourceData);
	}
}
