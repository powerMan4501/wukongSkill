using System;
using System.Collections.Generic;
using b1.ECS;
using BtlB1;

namespace b1.EventDelDefine;

public class GSDel_ModifyAiConvBlackboardData_ICB : IFreshAbleGSEvent
{
	private Del_ModifyAiConvBlackboardData _InvokeCallBack;

	private Action<Del_ModifyAiConvBlackboardData> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_ModifyAiConvBlackboardData _MultiCastDel;

	public GSDel_ModifyAiConvBlackboardData_ICB(Del_ModifyAiConvBlackboardData InvokeCallBack, Action<Del_ModifyAiConvBlackboardData> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_ModifyAiConvBlackboardData)Delegate.Combine(_MultiCastDel, (Del_ModifyAiConvBlackboardData)Del);
		}
		else
		{
			_MultiCastDel = (Del_ModifyAiConvBlackboardData)Delegate.Remove(_MultiCastDel, (Del_ModifyAiConvBlackboardData)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_ModifyAiConvBlackboardData_ICB operator +(GSDel_ModifyAiConvBlackboardData_ICB GSEvent, Del_ModifyAiConvBlackboardData Del)
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
		GSEvent._MultiCastDel = (Del_ModifyAiConvBlackboardData)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_ModifyAiConvBlackboardData_ICB operator -(GSDel_ModifyAiConvBlackboardData_ICB GSEvent, Del_ModifyAiConvBlackboardData Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_ModifyAiConvBlackboardData == Del)
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
		GSEvent._MultiCastDel = (Del_ModifyAiConvBlackboardData)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string KeyName, EACFactDataOperateType OperateType, string ModifyContent)
	{
		_InvokeCallBack?.Invoke(KeyName, OperateType, ModifyContent);
	}
}
