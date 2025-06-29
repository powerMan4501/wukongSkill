using b1.ECS;

namespace b1;

internal class BUC_FXActorBaseData : b1.IBUC_FXActorBaseData, IPersistentECSData
{
	public float LifeTime { get; set; }

	public float DelayDestroyTime { get; set; }

	public EFXActorType FXActorType { get; set; }
}
