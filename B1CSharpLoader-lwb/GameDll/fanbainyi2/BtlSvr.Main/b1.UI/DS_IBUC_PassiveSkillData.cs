using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_PassiveSkillData : GSBattleDataDStore
{
	private IBUC_PassiveSkillData ReadData;

	private BUC_PassiveSkillData Data;

	public Dictionary<int, FUStSkillSDesc> CachedSkillSDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedSkillSDescs;
		}
	}

	public Dictionary<int, FUStSkillEffectDesc> CachedSkillEffectDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedSkillEffectDescs;
		}
	}

	public Dictionary<int, FUStPlayerSkillCtrlDesc> CachedPlayerSkillCtrlDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedPlayerSkillCtrlDescs;
		}
	}

	public Dictionary<int, FUStChargeSkillSDesc> CachedChargeSkillSDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedChargeSkillSDescs;
		}
	}

	public Dictionary<int, Dictionary<string, float>> CachedBuffModifyData
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedBuffModifyData;
		}
	}

	public Dictionary<int, FUStRollSkillDesc> CachedRollDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedRollDescs;
		}
	}

	public Dictionary<int, FUStSummonCommDesc> CachedSummonCommDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedSummonCommDescs;
		}
	}

	public Dictionary<int, FUStPlayerInputSkillMappingDesc> CachedPlayerCommSkillDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedPlayerCommSkillDescs;
		}
	}

	public Dictionary<int, FUStIronBodyConfigDesc> CachedIronBodyConfigDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedIronBodyConfigDescs;
		}
	}

	public Dictionary<int, int> ChachedPotentialEnergyConfigID
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.ChachedPotentialEnergyConfigID;
		}
	}

	public Dictionary<int, Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>>> CachedPotentialEnergyConfigDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedPotentialEnergyConfigDescs;
		}
	}

	public Dictionary<int, FUStSkillDamageExpandDesc> CachedSkillDamageExpandDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedSkillDamageExpandDescs;
		}
	}

	public Dictionary<int, FUStPartRuleInfoDesc> CachedPartRuleInfoDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedPartRuleInfoDescs;
		}
	}

	public Dictionary<int, FUStProjectileCommDesc> CachedProjectileCommDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedProjectileCommDescs;
		}
	}

	public Dictionary<int, FUStAttrCopyConfigDesc> CacheAttrCopyConfigDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CacheAttrCopyConfigDescs;
		}
	}

	public Dictionary<int, FUStLifeSavingHairConfigDesc> CachedLifeSavingHairConfigDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedLifeSavingHairConfigDescs;
		}
	}

	public Dictionary<int, FUStSuperArmorLevelDesc> CachedFUStSuperArmorLevelDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedFUStSuperArmorLevelDescs;
		}
	}

	public Dictionary<int, FUStPlayerCommDesc> CachedFUStPlayerCommDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedFUStPlayerCommDescs;
		}
	}

	public Dictionary<int, FUStPhantomRushSkillConfigDesc> CachedFUStPhantomRushSkillConfigDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedFUStPhantomRushSkillConfigDescs;
		}
	}

	public Dictionary<int, FUStEffectiveHitProjectileEffectDesc> CachedEffectiveHitProjectileEffectDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedEffectiveHitProjectileEffectDescs;
		}
	}

	public Dictionary<int, FUStSealingSpellSkillConfigDesc> CachedSealingSpellSkillConfigDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedSealingSpellSkillConfigDescs;
		}
	}

	public Dictionary<int, FUStTransQiTianDaShengConfigDesc> CachedTransQiTianDaShengConfigDescs
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CachedTransQiTianDaShengConfigDescs;
		}
	}

	public DS_IBUC_PassiveSkillData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PassiveSkillData>(actor);
		}
	}

	public override void ResetActor(AActor actor)
	{
		base.ResetActor(actor);
		if (ReadData != null && Data != null)
		{
			foreach (List<Action> value in NeedActionDic.Values)
			{
				value[1]?.Invoke();
			}
		}
		if (actor.IsNullOrDestroyed())
		{
			ReadData = null;
			Data = null;
			return;
		}
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PassiveSkillData>(actor);
		if (ReadData == null || Data == null)
		{
			return;
		}
		foreach (List<Action> value2 in NeedActionDic.Values)
		{
			value2[0]?.Invoke();
		}
	}
}
