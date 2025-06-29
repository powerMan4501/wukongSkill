using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestSetDBCNiagaraVectorParam_ICB : IFreshAbleGSEvent
{
	private Del_RequestSetDBCNiagaraVectorParam _InvokeCallBack;

	private Action<Del_RequestSetDBCNiagaraVectorParam> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSetDBCNiagaraVectorParam _MultiCastDel;

	public GSDel_RequestSetDBCNiagaraVectorParam_ICB(Del_RequestSetDBCNiagaraVectorParam InvokeCallBack, Action<Del_RequestSetDBCNiagaraVectorParam> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSetDBCNiagaraVectorParam)Delegate.Combine(_MultiCastDel, (Del_RequestSetDBCNiagaraVectorParam)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSetDBCNiagaraVectorParam)Delegate.Remove(_MultiCastDel, (Del_RequestSetDBCNiagaraVectorParam)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSetDBCNiagaraVectorParam_ICB operator +(GSDel_RequestSetDBCNiagaraVectorParam_ICB GSEvent, Del_RequestSetDBCNiagaraVectorParam Del)
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
		GSEvent._MultiCastDel = (Del_RequestSetDBCNiagaraVectorParam)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSetDBCNiagaraVectorParam_ICB operator -(GSDel_RequestSetDBCNiagaraVectorParam_ICB GSEvent, Del_RequestSetDBCNiagaraVectorParam Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSetDBCNiagaraVectorParam == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSetDBCNiagaraVectorParam)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(uint IdentityID, FName ParamName, FVector Value)
	{
		_InvokeCallBack?.Invoke(IdentityID, ParamName, Value);
	}
}
