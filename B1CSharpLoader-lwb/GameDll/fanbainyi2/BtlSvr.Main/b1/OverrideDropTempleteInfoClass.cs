using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class OverrideDropTempleteInfoClass
{
	private Dictionary<int, UBGWDropItemTemplete> OverrideDropTempleteDict;

	private Dictionary<int, FTransform> OverrideSpawnPosDict;

	public OverrideDropTempleteInfoClass()
	{
		OverrideDropTempleteDict = null;
		OverrideSpawnPosDict = null;
	}

	public void AddOverrideDropTemplete(int ItemID, UBGWDropItemTemplete DropItemTemplete)
	{
		if (ItemID > 0 && !(DropItemTemplete == null))
		{
			if (OverrideDropTempleteDict == null)
			{
				OverrideDropTempleteDict = new Dictionary<int, UBGWDropItemTemplete> { { ItemID, DropItemTemplete } };
			}
			else if (OverrideDropTempleteDict.ContainsKey(ItemID))
			{
				OverrideDropTempleteDict[ItemID] = DropItemTemplete;
			}
			else
			{
				OverrideDropTempleteDict.Add(ItemID, DropItemTemplete);
			}
		}
	}

	public void AddOverrideSpawnPos(int ItemID, FTransform SpawnPos)
	{
		if (ItemID > 0)
		{
			if (OverrideSpawnPosDict == null)
			{
				OverrideSpawnPosDict = new Dictionary<int, FTransform> { { ItemID, SpawnPos } };
			}
			else if (OverrideSpawnPosDict.ContainsKey(ItemID))
			{
				OverrideSpawnPosDict[ItemID] = SpawnPos;
			}
			else
			{
				OverrideSpawnPosDict.Add(ItemID, SpawnPos);
			}
		}
	}

	public UBGWDropItemTemplete GetDropItemTempleteByItemID(int ItemID)
	{
		if (OverrideDropTempleteDict == null)
		{
			return null;
		}
		if (OverrideDropTempleteDict.ContainsKey(ItemID))
		{
			return OverrideDropTempleteDict[ItemID];
		}
		return null;
	}

	public FTransform GetSpawnPosByItemID(int ItemID)
	{
		if (OverrideSpawnPosDict == null)
		{
			return FTransform.Default;
		}
		if (OverrideSpawnPosDict.ContainsKey(ItemID))
		{
			return OverrideSpawnPosDict[ItemID];
		}
		return FTransform.Default;
	}
}
