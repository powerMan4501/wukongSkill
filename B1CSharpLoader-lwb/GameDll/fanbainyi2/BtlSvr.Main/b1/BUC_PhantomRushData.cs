using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_PhantomRushData : IBUC_PhantomRushData, IPersistentECSData
{
	public bool bSummonDispearWhenMasterAttack { get; set; }

	public float PhantomRushTimer { get; set; }

	public float PhantomRushNoMagicProtectTimer { get; set; }

	public int NowConfigID { get; set; }

	public int CacheConfigID { get; set; }

	public bool Imperceptible { get; set; }

	public FPoseSnapshot PoseSnapshot { get; set; }
}
