using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_FacialAnimData : IPersistentECSData
{
	public float AnimRemainTimer;

	public float AnimDelayTimer;

	public UAnimSequence Anim_Cache;

	public float AutoBlendOutTime_Cache;

	public UAnimMontage CurAnimMontage;
}
