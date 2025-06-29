using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AIReqMoveSkill")]
public class AIReqMoveSkill : AIRequestBase
{
	public float LeftDamage;

	public override void Initialize(FObjectInitializer initializer)
	{
		IsNeedSelectPoint = true;
		base.AIRequestType = EAIRequestType.MoveSkill;
		LeftDamage = 10f;
	}

	public override bool IsFinish()
	{
		if (LeftDamage <= 0f)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AIReqMoveSkill");
	}

	static AIReqMoveSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AIReqMoveSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIReqMoveSkill));
	}
}
