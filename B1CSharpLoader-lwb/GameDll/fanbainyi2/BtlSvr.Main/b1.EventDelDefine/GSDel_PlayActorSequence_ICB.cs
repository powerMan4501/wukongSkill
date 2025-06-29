using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_PlayActorSequence_ICB : IFreshAbleGSEvent
{
	private Del_PlayActorSequence _InvokeCallBack;

	private Action<Del_PlayActorSequence> _MultiCastDelChgCallBack;

	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PlayActorSequence _MultiCastDel;

	public GSDel_PlayActorSequence_ICB(Del_PlayActorSequence InvokeCallBack, Action<Del_PlayActorSequence> MultiCastDelChgCallBack)
	{
		_InvokeCallBack = InvokeCallBack;
		_MultiCastDelChgCallBack = MultiCastDelChgCallBack;
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PlayActorSequence)Delegate.Combine(_MultiCastDel, (Del_PlayActorSequence)Del);
		}
		else
		{
			_MultiCastDel = (Del_PlayActorSequence)Delegate.Remove(_MultiCastDel, (Del_PlayActorSequence)Del);
		}
		_MultiCastDelChgCallBack(_MultiCastDel);
	}

	public static GSDel_PlayActorSequence_ICB operator +(GSDel_PlayActorSequence_ICB GSEvent, Del_PlayActorSequence Del)
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
		GSEvent._MultiCastDel = (Del_PlayActorSequence)Delegate.Combine(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public static GSDel_PlayActorSequence_ICB operator -(GSDel_PlayActorSequence_ICB GSEvent, Del_PlayActorSequence Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PlayActorSequence == Del)
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
		GSEvent._MultiCastDel = (Del_PlayActorSequence)Delegate.Remove(GSEvent._MultiCastDel, Del);
		GSEvent._MultiCastDelChgCallBack(GSEvent._MultiCastDel);
		return GSEvent;
	}

	public void Invoke(AActor MasterActor, ULevelSequence LevelSeq, FName Socket, bool AttachToSocket, bool bAttachToCapsuleRoot, bool bDontRotateWithMaster)
	{
		_InvokeCallBack?.Invoke(MasterActor, LevelSeq, Socket, AttachToSocket, bAttachToCapsuleRoot, bDontRotateWithMaster);
	}
}
