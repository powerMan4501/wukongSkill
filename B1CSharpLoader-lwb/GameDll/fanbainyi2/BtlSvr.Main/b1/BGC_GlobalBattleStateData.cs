using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1;

public class BGC_GlobalBattleStateData : IBGC_GlobalBattleStateData, IPersistentECSData
{
	public UnorderedDict<string, BGUCharacterCS> IntoBattleUnits { get; set; } = new UnorderedDict<string, BGUCharacterCS>();

	public Dictionary<string, BGUCharacterCS> CanForceLeaveBattleUnits { get; set; } = new Dictionary<string, BGUCharacterCS>();

	public MultiMap<EBGUBloodBarType, Entity> InBattleUnitMultiMap { get; } = new MultiMap<EBGUBloodBarType, Entity>();

	public List<FBossRoom> BossRooms { get; } = new List<FBossRoom>();

	public FBossRoom CurrentBossRoom { get; set; }

	public List<Entity> GetInBattleUnitByBloodBarType(EBGUBloodBarType BloodBarType)
	{
		InBattleUnitMultiMap.TryGetValue(BloodBarType, out var value);
		return value;
	}

	public List<Entity> GetAllInBattleUnitByBloodBarType()
	{
		List<Entity> list = new List<Entity>();
		foreach (KeyValuePair<EBGUBloodBarType, List<Entity>> item in InBattleUnitMultiMap)
		{
			list.AddRange(item.Value);
		}
		return list;
	}

	public void AddInBattleUnitInMultiMap(EBGUBloodBarType BloodBarType, Entity Unit)
	{
		if (InBattleUnitMultiMap.TryGetValue(BloodBarType, out var value))
		{
			if (!value.Contains(Unit))
			{
				value.Add(Unit);
				InBattleUnitMultiMap[BloodBarType] = value;
			}
		}
		else
		{
			InBattleUnitMultiMap.Add(BloodBarType, new List<Entity> { Unit });
		}
	}

	public void RemoveInBattleUnitInMultiMap(EBGUBloodBarType BloodBarType, Entity Unit)
	{
		if (InBattleUnitMultiMap.TryGetValue(BloodBarType, out var value) && value.Contains(Unit))
		{
			value.Remove(Unit);
			InBattleUnitMultiMap[BloodBarType] = value;
		}
	}

	public bool IsBossRoomMonster(string UnitGuid)
	{
		foreach (FBossRoom bossRoom in BossRooms)
		{
			if (bossRoom.IsInBossRoom(UnitGuid))
			{
				return true;
			}
		}
		return false;
	}

	public bool IsInBossRoom()
	{
		return CurrentBossRoom != null;
	}
}
