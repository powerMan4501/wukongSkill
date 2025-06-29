using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public class GSDel_AddPostProcessMat_ICB : IFreshAbleGSEvent
{
	private Del_AddPostProcessMat _InvokeCallBack;

	private Action<Del_AddPostProcessMat> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_AddPostProcessMat _MultiCastDel;

	public GSDel_AddPostProcessMat_ICB(Del_AddPostProcessMat InvokeCallBack, Action<Del_AddPostProcessMat> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_AddPostProcessMat)Delegate.Combine(_MultiCastDel, (Del_AddPostProcessMat)Del);
		}
		else
		{
			_MultiCastDel = (Del_AddPostProcessMat)Delegate.Remove(_MultiCastDel, (Del_AddPostProcessMat)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_AddPostProcessMat_ICB operator +(GSDel_AddPostProcessMat_ICB GSEvent, Del_AddPostProcessMat Del)
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
		GSEvent._MultiCastDel = (Del_AddPostProcessMat)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_AddPostProcessMat_ICB operator -(GSDel_AddPostProcessMat_ICB GSEvent, Del_AddPostProcessMat Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_AddPostProcessMat == Del)
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
		GSEvent._MultiCastDel = (Del_AddPostProcessMat)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(EPostProcessSource Source, int NotifyId, AActor Owner, BGWDataAsset_PostProcessMatSetting Template)
	{
		_InvokeCallBack?.Invoke(Source, NotifyId, Owner, Template);
	}
}
