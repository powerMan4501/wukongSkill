using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AIReqMoveToLoc")]
public class AIReqMoveToLoc : AIRequestBase
{
	public float LeftDis;

	public override void Initialize(FObjectInitializer initializer)
	{
		IsNeedSelectPoint = true;
		base.AIRequestType = EAIRequestType.MoveToLoc;
		LeftDis = 100f;
	}

	public override bool IsFinish()
	{
		if (LeftDis <= 50f)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.AIReqMoveToLoc");
	}

	static AIReqMoveToLoc()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AIReqMoveToLoc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIReqMoveToLoc));
	}
}
