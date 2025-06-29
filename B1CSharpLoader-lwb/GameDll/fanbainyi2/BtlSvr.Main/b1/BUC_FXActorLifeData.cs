using b1.ECS;

namespace b1;

public class BUC_FXActorLifeData : b1.IBUC_FXActorLifeData, IPersistentECSData
{
	public float LifeTime;

	public float DelayDestroyTimer;

	public bool FXActorIsDead;

	public float FXActorAge { get; set; }

	public BUC_FXActorLifeData()
	{
		LifeTime = -1f;
		DelayDestroyTimer = -1f;
		FXActorIsDead = false;
	}
}
