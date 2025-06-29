using System.Collections.Generic;
using CommB1;
using ResB1;

namespace b1;

public static class AwardListUtil
{
	public static void AppendAwardList(AwardList outAwardList, AwardList inAwardList)
	{
		foreach (ItemOne award in inAwardList.Awards)
		{
			bool flag = false;
			for (int i = 0; i < outAwardList.Awards.Count; i++)
			{
				if (outAwardList.Awards[i].Id == award.Id)
				{
					outAwardList.Awards[i].Num = outAwardList.Awards[i].Num + award.Num;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				outAwardList.Awards.Add(award.Clone());
			}
		}
	}

	public static List<ItemOne> MergeDuplicateItemList(List<ItemOne> OriginItemList)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (ItemOne OriginItem in OriginItemList)
		{
			if (OriginItem.Num > 0)
			{
				if (!dictionary.ContainsKey(OriginItem.Id))
				{
					dictionary[OriginItem.Id] = 0;
				}
				dictionary[OriginItem.Id] += OriginItem.Num;
			}
		}
		List<ItemOne> list = new List<ItemOne>();
		foreach (KeyValuePair<int, int> item in dictionary)
		{
			list.Add(new ItemOne
			{
				Id = item.Key,
				Num = item.Value
			});
		}
		return list;
	}

	public static AwardList ItemListToAwardList(List<ItemOne> itemList)
	{
		List<ItemOne> list = MergeDuplicateItemList(itemList);
		AwardList awardList = new AwardList();
		if (list != null)
		{
			awardList.Awards.AddRange(list);
		}
		return awardList;
	}
}
