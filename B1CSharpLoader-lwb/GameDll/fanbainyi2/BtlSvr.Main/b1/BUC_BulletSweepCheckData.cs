using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BulletSweepCheckData : b1.IBUC_BulletSweepCheckData, IPersistentECSData
{
	public FTransform PreTransform;

	public FTransform CurTransform;

	public FGSSweepCheckShapeInfo SweepCheckShapeInfo;

	public FQuat SweepCheckShapeRot;

	public bool NeedCheckWorldStatic_BP { get; set; }

	public ECollisionChannel SweepCheckChannel { get; set; }

	public FHitCheckConf HitCheckConf { get; set; }

	public bool bEnableAttackWarning { get; set; }

	public bool bHasDmgEffect { get; set; }

	public float AttackWarningExtendSize { get; set; }

	public FVector AttackWarningOffset { get; set; }

	public bool bEnableDebug { get; set; }

	public List<AActor> BeDamagedEntities { get; } = new List<AActor>();

	public bool EnableSweepCheck { get; set; }

	public bool CheckShapeIsValid { get; set; }

	public Dictionary<int, float> HitActorTimer { get; set; }

	public float HitItemTimer { get; set; }

	public float BulletSweepCheckGap { get; set; }

	public EBGUBulletType ProjectileType { get; set; }

	public BulletSweepCheckMode CheckMode { get; set; }

	public float SweepDelayTimer { get; set; }

	public bool bHitItemAttach { get; set; }

	public float HitItemAttachTime { get; set; }

	public bool bHitChrAttach { get; set; }

	public float HitChrAttachTime { get; set; }

	public float AttachOffset { get; set; }

	public BUC_BulletSweepCheckData()
	{
		PreTransform = FTransform.Identity;
		HitCheckConf = default(FHitCheckConf);
		EnableSweepCheck = true;
		CheckShapeIsValid = true;
		bHasDmgEffect = false;
		HitActorTimer = new Dictionary<int, float>();
		HitItemTimer = -1f;
		BulletSweepCheckGap = 0f;
		ProjectileType = EBGUBulletType.NormalSpawn;
		CheckMode = BulletSweepCheckMode.Normal;
		SweepDelayTimer = 0f;
	}
}
