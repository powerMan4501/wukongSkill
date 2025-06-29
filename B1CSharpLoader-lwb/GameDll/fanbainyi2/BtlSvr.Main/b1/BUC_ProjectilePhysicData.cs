using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ProjectilePhysicData : b1.IBUC_ProjectilePhysicData, IPersistentECSData
{
	public FName Default_ProfileName_MagicField;

	public FName Default_ProfileName_Bullet;

	public float OriGravityScale { get; set; }
}
