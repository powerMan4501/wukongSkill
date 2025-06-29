using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_ResetEQSTarget")]
internal class BAIT_ResetEQSTarget : BAIT_Base
{
	public override void ReceiveExecute(AActor OwnerActor)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			BUS_EventCollectionCS.Get(aBGUCharacter).Evt_SetEQSTarget.Invoke(null);
			UBTFunctionLibrary.SetBlackboardValueAsObject(this, new FBlackboardKeySelector
			{
				SelectedKeyName = B1GlobalFNames.EQS_Target
			}, null);
			FinishExecute(bSuccess: true);
		}
		else
		{
			FinishExecute(bSuccess: false);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ResetEQSTarget");
	}

	static BAIT_ResetEQSTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ResetEQSTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ResetEQSTarget));
	}
}
