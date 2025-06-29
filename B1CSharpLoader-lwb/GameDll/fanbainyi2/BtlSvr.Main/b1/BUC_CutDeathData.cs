using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUC_CutDeathData")]
internal class BUC_CutDeathData : UObject
{
	public float DelayClearArmorTime;

	public float DelayDestroyActorTime;

	public float StiffLevelCauseDead;

	public FVector KillerLocation;

	public bool PoseHasCopyToAnimBP;

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUC_CutDeathData");
	}

	static BUC_CutDeathData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUC_CutDeathData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUC_CutDeathData));
	}
}
