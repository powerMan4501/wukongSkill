using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_BulletEffectData : IPersistentECSData
{
	public List<DelayTriggerEffect_Bullet> DelayTriggerEffectList;

	public float Age_ForDelayTriggerEffect;

	public BUC_BulletEffectData()
	{
		DelayTriggerEffectList = new List<DelayTriggerEffect_Bullet>();
		Age_ForDelayTriggerEffect = -1f;
	}
}
