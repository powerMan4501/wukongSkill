using System.Collections.Generic;
using BtlB1;
using BtlShare;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_PassiveSkillData
{
	Dictionary<int, FUStSkillSDesc> CachedSkillSDescs { get; }

	Dictionary<int, FUStSkillEffectDesc> CachedSkillEffectDescs { get; }

	Dictionary<int, FUStPlayerSkillCtrlDesc> CachedPlayerSkillCtrlDescs { get; }

	Dictionary<int, FUStChargeSkillSDesc> CachedChargeSkillSDescs { get; }

	Dictionary<int, Dictionary<string, float>> CachedBuffModifyData { get; }

	Dictionary<int, FUStRollSkillDesc> CachedRollDescs { get; }

	Dictionary<int, FUStSummonCommDesc> CachedSummonCommDescs { get; }

	Dictionary<int, FUStPlayerInputSkillMappingDesc> CachedPlayerCommSkillDescs { get; }

	Dictionary<int, FUStIronBodyConfigDesc> CachedIronBodyConfigDescs { get; }

	Dictionary<int, int> ChachedPotentialEnergyConfigID { get; }

	Dictionary<int, Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>>> CachedPotentialEnergyConfigDescs { get; }

	Dictionary<int, FUStSkillDamageExpandDesc> CachedSkillDamageExpandDescs { get; }

	Dictionary<int, FUStPartRuleInfoDesc> CachedPartRuleInfoDescs { get; }

	Dictionary<int, FUStProjectileCommDesc> CachedProjectileCommDescs { get; }

	Dictionary<int, FUStAttrCopyConfigDesc> CacheAttrCopyConfigDescs { get; }

	Dictionary<int, FUStLifeSavingHairConfigDesc> CachedLifeSavingHairConfigDescs { get; }

	Dictionary<int, FUStSuperArmorLevelDesc> CachedFUStSuperArmorLevelDescs { get; }

	Dictionary<int, FUStPlayerCommDesc> CachedFUStPlayerCommDescs { get; }

	Dictionary<int, FUStPhantomRushSkillConfigDesc> CachedFUStPhantomRushSkillConfigDescs { get; }

	Dictionary<int, FUStEffectiveHitProjectileEffectDesc> CachedEffectiveHitProjectileEffectDescs { get; }

	Dictionary<int, FUStSealingSpellSkillConfigDesc> CachedSealingSpellSkillConfigDescs { get; }

	Dictionary<int, FUStTransQiTianDaShengConfigDesc> CachedTransQiTianDaShengConfigDescs { get; }
}
