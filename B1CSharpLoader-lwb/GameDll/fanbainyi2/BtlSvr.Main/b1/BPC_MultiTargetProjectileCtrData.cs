using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_MultiTargetProjectileCtrData : IBPC_MultiTargetProjectileCtrData, IPersistentECSData
{
	public GSBindDictionary<Entity, int> MultiTargetDic { get; } = new GSBindDictionary<Entity, int>();

	[Replicated]
	public EMultiTargetProjectileState ProjectileState { get; set; }

	[Replicated]
	public int HitCount { get; set; }

	public int OriginalTargetCount { get; set; }

	public Entity LastHitUnit { get; set; }

	public BGUProjectileBaseActor Projectile { get; set; }

	public IBUC_ProjectileBasicData ProjectileBasicData { get; set; }

	public IBUC_ObjActorMovementData ObjActorMovementData { get; set; }

	public string CachedSocketName { get; set; }

	public int CacheOriginalProjectileID { get; set; }

	public float SearchTimer { get; set; }

	public float LifeTime { get; set; }

	public void ResetInfo(BGUProjectileBaseActor InProjectile, float InLifeTime, IBUC_ProjectileBasicData InProjectileBasicData, IBUC_ObjActorMovementData InObjActorMovementData)
	{
		Projectile = InProjectile;
		CacheOriginalProjectileID = InProjectileBasicData?.ProjectileID ?? 0;
		CachedSocketName = ((InObjActorMovementData != null) ? InObjActorMovementData.TargetSocketName : string.Empty);
		LifeTime = InLifeTime;
		ProjectileBasicData = InProjectileBasicData;
		ObjActorMovementData = InObjActorMovementData;
		ResetBattleInfo();
	}

	public void ResetBattleInfo()
	{
		MultiTargetDic.Clear();
		ProjectileState = EMultiTargetProjectileState.FollowMaster;
		LastHitUnit = Entity.Null;
		HitCount = 0;
		OriginalTargetCount = 0;
	}
}
