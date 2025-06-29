using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_ConfigInfoData : GSBattleDataDStore
{
	private IBUC_ConfigInfoData ReadData;

	private BUC_ConfigInfoData Data;

	public int ResID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.ResID;
		}
	}

	public int OverrideID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.OverrideID;
		}
	}

	public List<FUnitWeapon> Weapons
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.Weapons;
		}
	}

	public int BeginStealthSkillIDPair
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.BeginStealthSkillIDPair;
		}
	}

	public int EndStealthSkillIDPair
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.EndStealthSkillIDPair;
		}
	}

	public bool bSurfaceTypeTraceFromPelvis
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bSurfaceTypeTraceFromPelvis;
		}
	}

	public float BeAttackedDirForwardRight
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.BeAttackedDirForwardRight;
		}
	}

	public float BeAttackedDirForwardLeft
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.BeAttackedDirForwardLeft;
		}
	}

	public float BeAttackedDirBackwardLeft
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.BeAttackedDirBackwardLeft;
		}
	}

	public float BeAttackedDirBackwardRight
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.BeAttackedDirBackwardRight;
		}
	}

	public bool bOverrideEnableLoSVisualizationInTable
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bOverrideEnableLoSVisualizationInTable;
		}
	}

	public bool bEnableLoSVisualization
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bEnableLoSVisualization;
		}
	}

	public float SightRange
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.SightRange;
		}
	}

	public float VisionAngleDegrees
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.VisionAngleDegrees;
		}
	}

	public float HearRange
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.HearRange;
		}
	}

	public float PursuitRange
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.PursuitRange;
		}
	}

	public float AIWatchTimeMin
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.AIWatchTimeMin;
		}
	}

	public float AIWatchTimeMax
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.AIWatchTimeMax;
		}
	}

	public bool bOverrideUnitAIAttackType
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bOverrideUnitAIAttackType;
		}
	}

	public EUnitAIAttackType UnitAIAttackType
	{
		get
		{
			if (ReadData == null)
			{
				return EUnitAIAttackType.ActiveAttack;
			}
			return ReadData.UnitAIAttackType;
		}
	}

	public Dictionary<int, FStalemateInfo> StalemateInfoMap
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.StalemateInfoMap;
		}
	}

	public float SpotLightRotationLagSpeed
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.SpotLightRotationLagSpeed;
		}
	}

	public string AttachBone
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.AttachBone;
		}
	}

	public ENeutralAnimalType NeutralAnimalType
	{
		get
		{
			if (ReadData == null)
			{
				return ENeutralAnimalType.None;
			}
			return ReadData.NeutralAnimalType;
		}
	}

	public float NeutralAnimalBackToPatrolRange
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.NeutralAnimalBackToPatrolRange;
		}
	}

	public DS_IBUC_ConfigInfoData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ConfigInfoData>(actor);
		}
	}

	public List<FUnitWeapon> GetAllWeaponInfo()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetAllWeaponInfo();
	}

	public List<int> GetBirthBuffs()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetBirthBuffs();
	}

	public List<int> GetDestroyProjectileWhenDead()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetDestroyProjectileWhenDead();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ConfigInfoData>(actor);
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
