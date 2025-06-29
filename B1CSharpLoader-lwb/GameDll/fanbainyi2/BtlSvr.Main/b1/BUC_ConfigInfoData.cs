using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ConfigInfoData : IBUC_ConfigInfoData, IPersistentECSData
{
	public BGWDataAsset_TROConfig TROConfigOverride;

	public int ResID { get; set; }

	public int OverrideID { get; set; }

	public List<FUnitWeapon> Weapons { get; set; }

	public List<int> BirthBuffs { get; set; }

	public int BeginStealthSkillIDPair { get; set; }

	public int EndStealthSkillIDPair { get; set; }

	public bool bSurfaceTypeTraceFromPelvis { get; set; }

	public float BeAttackedDirForwardRight { get; set; }

	public float BeAttackedDirForwardLeft { get; set; }

	public float BeAttackedDirBackwardLeft { get; set; }

	public float BeAttackedDirBackwardRight { get; set; }

	public bool bOverrideEnableLoSVisualizationInTable { get; set; }

	public bool bEnableLoSVisualization { get; set; }

	public float SightRange { get; set; }

	public float VisionAngleDegrees { get; set; }

	public float HearRange { get; set; }

	public float PursuitRange { get; set; }

	public float AIWatchTimeMin { get; set; }

	public float AIWatchTimeMax { get; set; }

	public bool bOverrideUnitAIAttackType { get; set; }

	public EUnitAIAttackType UnitAIAttackType { get; set; }

	public Dictionary<int, FStalemateInfo> StalemateInfoMap { get; set; }

	public List<FPhysicBlendInfo> PhysicBlendInfos { get; set; }

	public float PhysicBlendWeight { get; set; }

	public List<int> DestroyProjectileWhenDead { get; set; }

	public float SpotLightRotationLagSpeed { get; set; }

	public string AttachBone { get; set; }

	public ENeutralAnimalType NeutralAnimalType { get; set; }

	public float NeutralAnimalBackToPatrolRange { get; set; }

	public BUC_ConfigInfoData()
	{
		BeAttackedDirForwardRight = 45f;
		BeAttackedDirForwardLeft = -45f;
		BeAttackedDirBackwardLeft = -135f;
		BeAttackedDirBackwardRight = 135f;
	}

	public void CopyBPDataToData(FUnitCDesc UnitCDesc, FUnitAIDesc UnitAIDesc, BGWDataAsset_TROConfig _TROConfigOverride, TArrayReadWrite<int> _DestroyProjectileWhenDead, float InSpotLightRotationLag, FActorAttachConfig AttachConfig, FNeutralAnimalConfig NeutralAnimalConfig)
	{
		ResID = UnitCDesc.ResID;
		OverrideID = UnitCDesc.OverrideID;
		Weapons = UnitCDesc.Weapons;
		BirthBuffs = UnitCDesc.BirthBuffs;
		BeginStealthSkillIDPair = UnitCDesc.StealthSkillIDPair.BeginStealthSkillID;
		EndStealthSkillIDPair = UnitCDesc.StealthSkillIDPair.EndStealthSkillID;
		bSurfaceTypeTraceFromPelvis = UnitCDesc.bSurfaceTypeTraceFromPelvis;
		BeAttackedDirForwardRight = UnitCDesc.BeAttackedDirForwardRight;
		BeAttackedDirForwardLeft = UnitCDesc.BeAttackedDirForwardLeft;
		BeAttackedDirBackwardLeft = UnitCDesc.BeAttackedDirBackwardLeft;
		BeAttackedDirBackwardRight = UnitCDesc.BeAttackedDirBackwardRight;
		bOverrideEnableLoSVisualizationInTable = UnitAIDesc.bOverrideEnableLoSVisualizationInTable;
		bEnableLoSVisualization = UnitAIDesc.bEnableLoSVisualization;
		SightRange = UnitAIDesc.SightRange;
		VisionAngleDegrees = UnitAIDesc.VisionAngleDegrees;
		HearRange = UnitAIDesc.HearRange;
		PursuitRange = UnitAIDesc.PursuitRange;
		AIWatchTimeMin = UnitAIDesc.AIWatchTimeMin;
		AIWatchTimeMax = UnitAIDesc.AIWatchTimeMax;
		bOverrideUnitAIAttackType = UnitAIDesc.bOverrideUnitAIAttackType;
		UnitAIAttackType = UnitAIDesc.UnitAIAttackType;
		StalemateInfoMap = UnitAIDesc.StalemateInfoMap;
		TROConfigOverride = _TROConfigOverride;
		DestroyProjectileWhenDead = new List<int>();
		foreach (int item in _DestroyProjectileWhenDead)
		{
			DestroyProjectileWhenDead.Add(item);
		}
		SpotLightRotationLagSpeed = InSpotLightRotationLag;
		AttachBone = AttachConfig.AttachBone;
		NeutralAnimalType = NeutralAnimalConfig.NeutralAnimalType;
		NeutralAnimalBackToPatrolRange = NeutralAnimalConfig.BackToPatrolRange;
	}

	public List<FUnitWeapon> GetAllWeaponInfo()
	{
		return Weapons;
	}

	public List<int> GetBirthBuffs()
	{
		return BirthBuffs;
	}

	public List<int> GetDestroyProjectileWhenDead()
	{
		return DestroyProjectileWhenDead;
	}
}
