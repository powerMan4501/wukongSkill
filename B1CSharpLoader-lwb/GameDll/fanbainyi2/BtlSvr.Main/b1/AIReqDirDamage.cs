using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AIReqDirDamage")]
public class AIReqDirDamage : AIRequestBase
{
	public float LeftDamage;

	public override void Initialize(FObjectInitializer initializer)
	{
		IsNeedSelectPoint = false;
		base.AIRequestType = EAIRequestType.DirDamage;
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
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AIReqDirDamage");
	}

	static AIReqDirDamage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AIReqDirDamage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIReqDirDamage));
	}
}
