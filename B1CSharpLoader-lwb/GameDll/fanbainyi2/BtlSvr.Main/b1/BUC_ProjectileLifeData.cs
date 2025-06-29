using b1.ECS;

namespace b1;

public class BUC_ProjectileLifeData : IPersistentECSData
{
	public bool ProjectileisFresh;

	public float ProjectileLifeTimer;

	public float ProjectileLifeLowestSpeed;

	public bool ProjectileIsDead;

	public float ProjectileDestroyTimer;

	public bool bIsInDeadAttach;

	public float DeadAttachTimer;

	public BUC_ProjectileLifeData()
	{
		ProjectileisFresh = true;
		ProjectileLifeTimer = 0f;
		ProjectileLifeLowestSpeed = 0f;
		ProjectileDestroyTimer = -1f;
		ProjectileIsDead = false;
		DeadAttachTimer = -1f;
	}

	public bool bInDeadAttach()
	{
		return DeadAttachTimer >= 0f;
	}

	public bool bIsAttached()
	{
		return false;
	}

	public void DeadAttachTimerTick(float DeltaTime)
	{
		if (!(DeadAttachTimer < 0f))
		{
			DeadAttachTimer -= DeltaTime;
		}
	}
}
