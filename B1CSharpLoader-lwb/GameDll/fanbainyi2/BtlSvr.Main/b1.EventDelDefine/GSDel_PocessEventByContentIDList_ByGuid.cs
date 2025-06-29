using System;
using System.Collections.Generic;
using b1.ECS;

namespace b1.EventDelDefine;

public class GSDel_PocessEventByContentIDList_ByGuid : IFreshAbleGSEvent
{
	public int EventId;

	public GSEventCollectionBase _OwnerEventCollectionCS;

	private Del_PocessEventByContentIDList_ByGuid _MultiCastDel;

	public void RefreshEntityComponentEventReg(bool Active, Delegate Del)
	{
		if (Active)
		{
			_MultiCastDel = (Del_PocessEventByContentIDList_ByGuid)Delegate.Combine(_MultiCastDel, (Del_PocessEventByContentIDList_ByGuid)Del);
		}
		else
		{
			_MultiCastDel = (Del_PocessEventByContentIDList_ByGuid)Delegate.Remove(_MultiCastDel, (Del_PocessEventByContentIDList_ByGuid)Del);
		}
	}

	public static GSDel_PocessEventByContentIDList_ByGuid operator +(GSDel_PocessEventByContentIDList_ByGuid GSEvent, Del_PocessEventByContentIDList_ByGuid Del)
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
		GSEvent._MultiCastDel = (Del_PocessEventByContentIDList_ByGuid)Delegate.Combine(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public static GSDel_PocessEventByContentIDList_ByGuid operator -(GSDel_PocessEventByContentIDList_ByGuid GSEvent, Del_PocessEventByContentIDList_ByGuid Del)
	{
		if (Del.Target is IEntityComponent entityComponent)
		{
			List<EventRegCache> orAllocEventRegCache = GSEvent._OwnerEventCollectionCS.GetOrAllocEventRegCache(entityComponent);
			for (int num = orAllocEventRegCache.Count - 1; num >= 0; num--)
			{
				if (orAllocEventRegCache[num].Del as Del_PocessEventByContentIDList_ByGuid == Del)
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
		GSEvent._MultiCastDel = (Del_PocessEventByContentIDList_ByGuid)Delegate.Remove(GSEvent._MultiCastDel, Del);
		return GSEvent;
	}

	public void Invoke(string SourceLog, string UnitGuid, List<int> ConversationContentIDList, uint ConversationChain_RootID = 0u)
	{
		_MultiCastDel?.Invoke(SourceLog, UnitGuid, ConversationContentIDList, ConversationChain_RootID);
	}
}
