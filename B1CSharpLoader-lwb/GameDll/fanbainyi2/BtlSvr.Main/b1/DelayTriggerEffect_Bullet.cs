using System.Collections.Generic;

namespace b1;

public struct DelayTriggerEffect_Bullet
{
	public float TriggerTime;

	public List<int> EffectIDs;

	public DelayTriggerEffect_Bullet(float _TriggerTime, List<int> _EffectID)
	{
		TriggerTime = _TriggerTime;
		EffectIDs = _EffectID;
	}
}
