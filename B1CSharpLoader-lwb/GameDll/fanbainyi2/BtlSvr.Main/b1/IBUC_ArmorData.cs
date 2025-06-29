using System.Collections.Generic;

namespace b1;

public interface IBUC_ArmorData
{
	bool CanTriggerCounterFightBack();

	bool CanTriggerAddCounterAttackTimes(EFightBackCountType BeAttackedCntType);

	bool IsInPreHRCounterattacking();

	bool IsInPreHRCounterattackingSuperArmor();

	List<int> GetArmorSkillIDs();

	void GetHitRecoverCounterInfo(out int CurCount, out int TotalTimes);

	void GetBlockCounterInfo(out int CurCount, out int PerfectBlockTime, out int TotalTimes, out float BlockCD, out float BlockResetTime);

	bool GetCurrentBlockInfoByHitLevel(int HitLevel, out FBlockInfoByHitLevel CurrentBlockInfo);

	void GetCurrentBlockInfoConfig(out BGWDataAsset_BlockInfoConfig _NowUseBlockInfoConfig);

	bool CheckIsInPerfectBlock();

	bool CheckIsTriggerPerfectBlock();
}
