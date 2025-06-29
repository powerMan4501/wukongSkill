using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestSetDBCNiagaraFloatParam_ICB : IFreshAbleGSEvent
{
	private Del_RequestSetDBCNiagaraFloatParam _InvokeCallBack;

	private Action<Del_RequestSetDBCNiagaraFloatParam> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSetDBCNiagaraFloatParam _MultiCastDel;

	public GSDel_RequestSetDBCNiagaraFloatParam_ICB(Del_RequestSetDBCNiagaraFloatParam InvokeCallBack, Action<Del_RequestSetDBCNiagaraFloatParam> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSetDBCNiagaraFloatParam)Delegate.Combine(_MultiCastDel, (Del_RequestSetDBCNiagaraFloatParam)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSetDBCNiagaraFloatParam)Delegate.Remove(_MultiCastDel, (Del_RequestSetDBCNiagaraFloatParam)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSetDBCNiagaraFloatParam_ICB operator +(GSDel_RequestSetDBCNiagaraFloatParam_ICB GSEvent, Del_RequestSetDBCNiagaraFloatParam Del)
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
		GSEvent._MultiCastDel = (Del_RequestSetDBCNiagaraFloatParam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSetDBCNiagaraFloatParam_ICB operator -(GSDel_RequestSetDBCNiagaraFloatParam_ICB GSEvent, Del_RequestSetDBCNiagaraFloatParam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSetDBCNiagaraFloatParam == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSetDBCNiagaraFloatParam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(uint IdentityID, FName ParamName, float Value)
	{
		_InvokeCallBack?.Invoke(IdentityID, ParamName, Value);
	}
}
