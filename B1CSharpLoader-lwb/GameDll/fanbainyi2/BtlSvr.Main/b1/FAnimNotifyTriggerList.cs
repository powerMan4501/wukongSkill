using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class FAnimNotifyTriggerList
{
	private class FAnimNotifyTriggerItemBase
	{
		public long EntityMontageID { get; private set; }

		public float MontageRemainTime { get; private set; }

		protected bool IsGroupIDValid(int GroupID)
		{
			return GroupID > 0;
		}

		public FAnimNotifyTriggerItemBase(long InEntityMontageID, float InMontageRemainTime)
		{
			EntityMontageID = InEntityMontageID;
			MontageRemainTime = InMontageRemainTime;
		}

		public void Update(float InDeltaTime)
		{
			MontageRemainTime -= InDeltaTime;
			OnUpdate(InDeltaTime);
		}

		protected virtual void OnUpdate(float InDeltaTime)
		{
		}
	}

	private class FAnimNotifyTriggerWhiteListItem : FAnimNotifyTriggerItemBase
	{
		public Dictionary<(int, int), float> WhiteList { get; } = new Dictionary<(int, int), float>();

		public FAnimNotifyTriggerWhiteListItem(long InEntityMontageID, float InMontageRemainTime)
			: base(InEntityMontageID, InMontageRemainTime)
		{
		}

		public void Add(int GroupID, int NotifyID, float TriggerTime)
		{
			WhiteList[(GroupID, NotifyID)] = TriggerTime;
		}

		protected override void OnUpdate(float InDeltaTime)
		{
			foreach (var item in new List<(int, int)>(WhiteList.Keys))
			{
				WhiteList[item] -= InDeltaTime;
				if (WhiteList[item] < 0f)
				{
					WhiteList.Remove(item);
				}
			}
		}
	}

	private class FAnimNotifyTriggerBlackListItem : FAnimNotifyTriggerItemBase
	{
		private HashSet<int> GroupBlackList { get; } = new HashSet<int>();

		private HashSet<int> NotifyBlackList { get; } = new HashSet<int>();

		public FAnimNotifyTriggerBlackListItem(long InEntityMontageID, float InMontageRemainTime)
			: base(InEntityMontageID, InMontageRemainTime)
		{
		}

		public bool IsCannotTrigger(int GroupID, int NotifyID)
		{
			if (IsGroupIDValid(GroupID) && GroupBlackList.Contains(GroupID))
			{
				return true;
			}
			if (NotifyBlackList.Contains(NotifyID))
			{
				return true;
			}
			return false;
		}

		public void Add(int GroupID, int NotifyID)
		{
			if (IsGroupIDValid(GroupID))
			{
				GroupBlackList.Add(GroupID);
			}
			NotifyBlackList.Add(NotifyID);
		}
	}

	private Dictionary<long, FAnimNotifyTriggerBlackListItem> BlackList { get; } = new Dictionary<long, FAnimNotifyTriggerBlackListItem>();

	private Dictionary<long, FAnimNotifyTriggerWhiteListItem> WhiteList { get; } = new Dictionary<long, FAnimNotifyTriggerWhiteListItem>();

	public long GetEntityMontageID(AActor Actor, int MontageID)
	{
		int entityHash = AActorStatics.GetEntityHash(Actor);
		return GetEntityMontageID(entityHash, MontageID);
	}

	public long GetEntityMontageID(int EntityID, int MontageID)
	{
		return (long)EntityID << 32 + MontageID;
	}

	public bool IsCannotTrigger(long EntityMontageID, int GroupID, int NotifyID)
	{
		if (BlackList.TryGetValue(EntityMontageID, out var value))
		{
			return value.IsCannotTrigger(GroupID, NotifyID);
		}
		return false;
	}

	public void MarkStash(long EntityMontageID, int GroupID, int NotifyID, float MontageTime, float TriggerTime)
	{
		if (!WhiteList.ContainsKey(EntityMontageID))
		{
			FAnimNotifyTriggerWhiteListItem value = new FAnimNotifyTriggerWhiteListItem(EntityMontageID, MontageTime);
			WhiteList[EntityMontageID] = value;
		}
		WhiteList[EntityMontageID].Add(GroupID, NotifyID, TriggerTime);
	}

	public void MarkAllStashCannotTrigger()
	{
		foreach (KeyValuePair<long, FAnimNotifyTriggerWhiteListItem> white in WhiteList)
		{
			FAnimNotifyTriggerWhiteListItem value = white.Value;
			foreach (KeyValuePair<(int, int), float> white2 in value.WhiteList)
			{
				MarkCannotTrigger(value.EntityMontageID, white2.Key.Item1, white2.Key.Item2, value.MontageRemainTime);
			}
		}
		WhiteList.Clear();
	}

	public void MarkCannotTrigger(long EntityMontageID, int GroupID, int NotifyID, float MontageTime)
	{
		if (!BlackList.ContainsKey(EntityMontageID))
		{
			FAnimNotifyTriggerBlackListItem fAnimNotifyTriggerBlackListItem = new FAnimNotifyTriggerBlackListItem(EntityMontageID, MontageTime);
			fAnimNotifyTriggerBlackListItem.Add(GroupID, NotifyID);
			BlackList.Add(EntityMontageID, fAnimNotifyTriggerBlackListItem);
		}
		BlackList[EntityMontageID].Add(GroupID, NotifyID);
	}

	public void Update(float InDeltaTime)
	{
		foreach (FAnimNotifyTriggerBlackListItem item in new List<FAnimNotifyTriggerBlackListItem>(BlackList.Values))
		{
			item.Update(InDeltaTime);
			if (item.MontageRemainTime < 0f)
			{
				BlackList.Remove(item.EntityMontageID);
			}
		}
		foreach (FAnimNotifyTriggerWhiteListItem item2 in new List<FAnimNotifyTriggerWhiteListItem>(WhiteList.Values))
		{
			item2.Update(InDeltaTime);
			if (item2.MontageRemainTime < 0f)
			{
				WhiteList.Remove(item2.EntityMontageID);
			}
		}
	}

	public void Clear()
	{
		BlackList.Clear();
		WhiteList.Clear();
	}
}
