using System;
using System.Collections.Generic;
using b1.CppExport;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch)Delegate.Combine(_MultiCastDel, (Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch)Delegate.Remove(_MultiCastDel, (Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch)Del);
		}
	}

	public static GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch operator +(GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch GSEvent, Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch Del)
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
		GSEvent._MultiCastDel = (Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch operator -(GSDel_RequestAsyncLineTrace_ByObjectTypeSingle_Batch GSEvent, Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch == Del)
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
		GSEvent._MultiCastDel = (Del_RequestAsyncLineTrace_ByObjectTypeSingle_Batch)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(in AsyncLineTraceReqRef ReqRef, List<EObjectTypeQuery> ObjectTypes, List<AActor> Ingnores, bool bTraceComplex, Del_OnAsyncLineTraceFinish _OnLineTraceFinishCallBack, bool bDebug = false)
	{
		_MultiCastDel?.Invoke(in ReqRef, ObjectTypes, Ingnores, bTraceComplex, _OnLineTraceFinishCallBack, bDebug);
	}
}
