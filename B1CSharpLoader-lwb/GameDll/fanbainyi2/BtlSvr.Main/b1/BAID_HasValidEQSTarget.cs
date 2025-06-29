using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_HasValidEQSTarget")]
public class BAID_HasValidEQSTarget : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor.IsNullOrDestroyed())
		{
			return false;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(OwnerActor);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		if (unPersistentReadOnlyData.GetCurEQSTarget(OwnerActor).IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_HasValidEQSTarget");
	}

	static BAID_HasValidEQSTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_HasValidEQSTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_HasValidEQSTarget));
	}
}
