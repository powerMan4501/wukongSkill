using b1.ECS;

namespace b1;

public class BUC_BeImmobilizedData : IBUC_BeImmobilizedData, IPersistentECSData
{
	public BGWDataAsset_BeImmobilizedConfig BeImmobilizedConfig { get; set; }

	public float ImmobilizedBaseDefense { get; set; }

	public int CurrentAttackStiffLevel { get; set; } = -1;

	public ImmobilizeConfigInstance ConfigInstance { get; set; }

	public float ImmobilizedRemainTime { get; set; }

	public float AlmostFXPlayTime { get; set; }

	public float RemoveBreakImmobilizedStateTimer { get; set; }

	public float MaxImmobilizeHP { get; set; }

	public float CurrentImmobilizeHP { get; set; }

	public int BeImmobilizedRepeatedCount { get; set; }

	public int ResId { get; set; }

	public int BeginFXRequestID { get; set; }

	public int AlmostEndFXRequestID { get; set; }

	public int BreakingFXRequestID { get; set; } = -1;
}
