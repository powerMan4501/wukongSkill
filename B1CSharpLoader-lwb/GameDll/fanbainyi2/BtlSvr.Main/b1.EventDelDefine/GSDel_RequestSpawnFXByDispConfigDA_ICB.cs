using System;
using System.Collections.Generic;
using b1.ECS;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestSpawnFXByDispConfigDA_ICB : IFreshAbleGSEvent
{
	private Del_RequestSpawnFXByDispConfigDA _InvokeCallBack;

	private Action<Del_RequestSpawnFXByDispConfigDA> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSpawnFXByDispConfigDA _MultiCastDel;

	public GSDel_RequestSpawnFXByDispConfigDA_ICB(Del_RequestSpawnFXByDispConfigDA InvokeCallBack, Action<Del_RequestSpawnFXByDispConfigDA> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfigDA)Delegate.Combine(_MultiCastDel, (Del_RequestSpawnFXByDispConfigDA)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfigDA)Delegate.Remove(_MultiCastDel, (Del_RequestSpawnFXByDispConfigDA)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSpawnFXByDispConfigDA_ICB operator +(GSDel_RequestSpawnFXByDispConfigDA_ICB GSEvent, Del_RequestSpawnFXByDispConfigDA Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfigDA)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSpawnFXByDispConfigDA_ICB operator -(GSDel_RequestSpawnFXByDispConfigDA_ICB GSEvent, Del_RequestSpawnFXByDispConfigDA Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSpawnFXByDispConfigDA == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfigDA)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(UBGWDataAsset DispConfig, out int RequestID, USceneComponent EmitterDispOwnerComp = null, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams))
	{
		RequestID = 0;
		_InvokeCallBack?.Invoke(DispConfig, out RequestID, EmitterDispOwnerComp, NeedSetSpawnTransform, SpawnTransform, CallbackParams);
	}
}
