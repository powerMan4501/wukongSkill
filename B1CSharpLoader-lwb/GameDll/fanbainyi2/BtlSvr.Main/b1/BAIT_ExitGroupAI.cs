using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAIT_ExitGroupAI")]
[USharpPath("/Script/b1-Managed.BAIT_ExitGroupAI")]
internal class BAIT_ExitGroupAI : BAIT_Base
{
	public override void ReceiveExecute(AActor OwnerActor)
	{
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ExitGroupAI");
	}

	static BAIT_ExitGroupAI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ExitGroupAI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ExitGroupAI));
	}
}
