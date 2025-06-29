using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AIReqMoveToActor")]
public class AIReqMoveToActor : AIRequestBase
{
	public float LeftDis;

	public override void Initialize(FObjectInitializer initializer)
	{
		IsNeedSelectPoint = false;
		base.AIRequestType = EAIRequestType.MoveToActor;
		LeftDis = 10000f;
	}

	public override bool IsFinish()
	{
		if (LeftDis <= 100f)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AIReqMoveToActor");
	}

	static AIReqMoveToActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AIReqMoveToActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIReqMoveToActor));
	}
}
