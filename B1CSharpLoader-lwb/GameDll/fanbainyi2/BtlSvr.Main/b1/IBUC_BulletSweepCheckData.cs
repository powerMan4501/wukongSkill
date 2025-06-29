using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_BulletSweepCheckData
{
	bool NeedCheckWorldStatic_BP { get; }

	ECollisionChannel SweepCheckChannel { get; }

	FHitCheckConf HitCheckConf { get; }

	float AttackWarningExtendSize { get; }

	bool bEnableDebug { get; }

	List<AActor> BeDamagedEntities { get; }

	bool EnableSweepCheck { get; }

	bool CheckShapeIsValid { get; }

	Dictionary<int, float> HitActorTimer { get; }

	float HitItemTimer { get; }

	BulletSweepCheckMode CheckMode { get; }

	float SweepDelayTimer { get; }

	bool bHitChrAttach { get; }

	float HitChrAttachTime { get; }

	bool bHitItemAttach { get; }

	float HitItemAttachTime { get; }

	float AttachOffset { get; }
}
