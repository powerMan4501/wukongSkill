using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_UnitDebugData : b1.IBUC_UnitDebugData, IPersistentECSData
{
	public int AIState { get; set; }

	public int LastSkillBlockReason { get; set; }

	public int UserHandle { get; set; }

	public bool bLogVerbose { get; set; }

	public bool bEnablePerceptionPreview { get; set; }

	public bool bEnablePerceptionPreviewOutlineOnly { get; set; }

	public bool bEnableWakeUpLinkRangeDebug { get; set; }

	public bool DrawSweepCheckSphere { get; set; }

	public bool DrawSkillEffectArea { get; set; }

	public bool DrawBuffArea { get; set; }

	public bool DrawBulletCollision { get; set; }

	public bool DrawBulletDestroyPos { get; set; }

	public AActor ZBBOwner { get; set; }

	public BGU_DebugActor DebugActor { get; set; }

	public bool IsPlayerDelayBeginPlayFinished { get; set; }
}
