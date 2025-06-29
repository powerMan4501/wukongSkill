using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_ClearHasCastComboInfo")]
internal class BAIT_ClearHasCastComboInfo : BAIT_Base
{
	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor).Evt_ClearHasCastComboInfo.Invoke();
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ClearHasCastComboInfo");
	}

	static BAIT_ClearHasCastComboInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ClearHasCastComboInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ClearHasCastComboInfo));
	}
}
