using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_UnitDebugData
{
	int AIState { get; }

	int LastSkillBlockReason { get; }

	int UserHandle { get; }

	bool bLogVerbose { get; }

	bool bEnablePerceptionPreview { get; }

	bool bEnablePerceptionPreviewOutlineOnly { get; }

	bool bEnableWakeUpLinkRangeDebug { get; }

	bool DrawSweepCheckSphere { get; }

	bool DrawSkillEffectArea { get; }

	bool DrawBuffArea { get; }

	bool DrawBulletCollision { get; }

	bool DrawBulletDestroyPos { get; }

	AActor ZBBOwner { get; }

	BGU_DebugActor DebugActor { get; }
}
