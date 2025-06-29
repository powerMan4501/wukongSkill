using System.Collections.Generic;
using BtlShare;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_ConfigInfoData
{
	int ResID { get; }

	int OverrideID { get; }

	List<FUnitWeapon> Weapons { get; }

	int BeginStealthSkillIDPair { get; }

	int EndStealthSkillIDPair { get; }

	bool bSurfaceTypeTraceFromPelvis { get; }

	float BeAttackedDirForwardRight { get; }

	float BeAttackedDirForwardLeft { get; }

	float BeAttackedDirBackwardLeft { get; }

	float BeAttackedDirBackwardRight { get; }

	bool bOverrideEnableLoSVisualizationInTable { get; }

	bool bEnableLoSVisualization { get; }

	float SightRange { get; }

	float VisionAngleDegrees { get; }

	float HearRange { get; }

	float PursuitRange { get; }

	float AIWatchTimeMin { get; }

	float AIWatchTimeMax { get; }

	bool bOverrideUnitAIAttackType { get; }

	EUnitAIAttackType UnitAIAttackType { get; }

	Dictionary<int, FStalemateInfo> StalemateInfoMap { get; }

	float SpotLightRotationLagSpeed { get; }

	string AttachBone { get; }

	ENeutralAnimalType NeutralAnimalType { get; }

	float NeutralAnimalBackToPatrolRange { get; }

	List<FUnitWeapon> GetAllWeaponInfo();

	List<int> GetBirthBuffs();

	List<int> GetDestroyProjectileWhenDead();
}
