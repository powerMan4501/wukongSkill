using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_RequestSpawnFXByDispConfig_ICB : IFreshAbleGSEvent
{
	private Del_RequestSpawnFXByDispConfig _InvokeCallBack;

	private Action<Del_RequestSpawnFXByDispConfig> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_RequestSpawnFXByDispConfig _MultiCastDel;

	public GSDel_RequestSpawnFXByDispConfig_ICB(Del_RequestSpawnFXByDispConfig InvokeCallBack, Action<Del_RequestSpawnFXByDispConfig> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Combine(_MultiCastDel, (Del_RequestSpawnFXByDispConfig)Del);
		}
		else
		{
			_MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Remove(_MultiCastDel, (Del_RequestSpawnFXByDispConfig)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_RequestSpawnFXByDispConfig_ICB operator +(GSDel_RequestSpawnFXByDispConfig_ICB GSEvent, Del_RequestSpawnFXByDispConfig Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_RequestSpawnFXByDispConfig_ICB operator -(GSDel_RequestSpawnFXByDispConfig_ICB GSEvent, Del_RequestSpawnFXByDispConfig Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_RequestSpawnFXByDispConfig == Del)
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
		GSEvent._MultiCastDel = (Del_RequestSpawnFXByDispConfig)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(string DispConfigDAPath, out int RequestID, USceneComponent EmitterDispOwnerComp = null, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform))
	{
		RequestID = 0;
		_InvokeCallBack?.Invoke(DispConfigDAPath, out RequestID, EmitterDispOwnerComp, NeedSetSpawnTransform, SpawnTransform);
	}
}
