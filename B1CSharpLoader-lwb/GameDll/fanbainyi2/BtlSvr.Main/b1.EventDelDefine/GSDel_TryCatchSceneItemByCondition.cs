using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public class GSDel_TryCatchSceneItemByCondition : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_TryCatchSceneItemByCondition _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_TryCatchSceneItemByCondition)Delegate.Combine(_MultiCastDel, (Del_TryCatchSceneItemByCondition)Del);
		}
		else
		{
			_MultiCastDel = (Del_TryCatchSceneItemByCondition)Delegate.Remove(_MultiCastDel, (Del_TryCatchSceneItemByCondition)Del);
		}
	}

	public static GSDel_TryCatchSceneItemByCondition operator +(GSDel_TryCatchSceneItemByCondition GSEvent, Del_TryCatchSceneItemByCondition Del)
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
		GSEvent._MultiCastDel = (Del_TryCatchSceneItemByCondition)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_TryCatchSceneItemByCondition operator -(GSDel_TryCatchSceneItemByCondition GSEvent, Del_TryCatchSceneItemByCondition Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_TryCatchSceneItemByCondition == Del)
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
		GSEvent._MultiCastDel = (Del_TryCatchSceneItemByCondition)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(List<FName> SceneActorTags, QueryBestLocationCondition Condition, bool NeedRemoveCurrentCatch)
	{
		_MultiCastDel?.Invoke(SceneActorTags, Condition, NeedRemoveCurrentCatch);
	}
}
