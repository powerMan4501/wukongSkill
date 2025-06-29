using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestSpawnFXByDispConfigWithEmitterInfo_ICB : IFreshAbleGSEvent
{
	private Del_RequestSpawnFXByDispConfigWithEmitterInfo _InvokeCallBack;

	private Action<Del_RequestSpawnFXByDispConfigWithEmitterInfo> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSpawnFXByDispConfigWithEmitterInfo _MultiCastDel;

	public GSDel_RequestSpawnFXByDispConfigWithEmitterInfo_ICB(Del_RequestSpawnFXByDispConfigWithEmitterInfo InvokeCallBack, Action<Del_RequestSpawnFXByDispConfigWithEmitterInfo> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfigWithEmitterInfo)Delegate.Combine(_MultiCastDel, (Del_RequestSpawnFXByDispConfigWithEmitterInfo)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfigWithEmitterInfo)Delegate.Remove(_MultiCastDel, (Del_RequestSpawnFXByDispConfigWithEmitterInfo)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSpawnFXByDispConfigWithEmitterInfo_ICB operator +(GSDel_RequestSpawnFXByDispConfigWithEmitterInfo_ICB GSEvent, Del_RequestSpawnFXByDispConfigWithEmitterInfo Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfigWithEmitterInfo)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSpawnFXByDispConfigWithEmitterInfo_ICB operator -(GSDel_RequestSpawnFXByDispConfigWithEmitterInfo_ICB GSEvent, Del_RequestSpawnFXByDispConfigWithEmitterInfo Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSpawnFXByDispConfigWithEmitterInfo == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfigWithEmitterInfo)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string DispConfigDAPath, out int RequestID, USceneComponent EmitterDispOwnerComp, FVector EmitterPosWSOnSpawn)
	{
		RequestID = 0;
		_InvokeCallBack?.Invoke(DispConfigDAPath, out RequestID, EmitterDispOwnerComp, EmitterPosWSOnSpawn);
	}
}
