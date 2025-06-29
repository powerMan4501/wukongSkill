using System.Collections.Generic;
using ArchiveB1;
using BtlB1;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BossRushBattleStyleInfo_PerRand
{
	public List<BossRushCastCount> SpellList;

	public BossRushCastCount FabaoSkillInfo;

	public BossRushCastCount SoulSkillInfo;

	public int ItemCount;

	public int WineCount;

	public int RollCount;

	public int DefuseCount;

	public int FourPECount;

	public void Clear()
	{
		SpellList = new List<BossRushCastCount>();
		FabaoSkillInfo = new BossRushCastCount();
		SoulSkillInfo = new BossRushCastCount();
		ItemCount = 0;
		WineCount = 0;
		RollCount = 0;
		DefuseCount = 0;
		FourPECount = 0;
	}

	public void InitBattleStyleInfo(UObject WorldContext)
	{
		Clear();
		APlayerController playerController = UGameplayStatics.GetPlayerController(WorldContext, 0);
		if (playerController == null)
		{
			return;
		}
		IBPC_RoleBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(playerController.PlayerState);
		if (readOnlyData != null)
		{
			int soulSkillID = readOnlyData.SoulSkillID;
			SoulSkillInfo.CastId = soulSkillID;
			if (readOnlyData.EquipList.TryGetValue(EquipPosition.Fabao, out var OutValue))
			{
				FabaoSkillInfo.CastId = OutValue;
			}
		}
		IBPC_PlayerRoleData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(playerController);
		if (readOnlyData2 == null)
		{
			return;
		}
		foreach (ReadOnlySpellItem spell in readOnlyData2.RoleData.RoleCs.Actor.Wear.SpellList)
		{
			if (spell.SpellId > 0 && (spell.Type == SpellType.QiShu || spell.Type == SpellType.ShenFa || spell.Type == SpellType.HaoMao || spell.Type == SpellType.BianShen))
			{
				BossRushCastCount bossRushCastCount = new BossRushCastCount();
				bossRushCastCount.CastId = spell.SpellId;
				SpellList.Add(bossRushCastCount);
			}
		}
	}
}
