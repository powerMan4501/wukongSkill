using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckWatchTimeNotEnd")]
internal class BAID_CheckWatchTimeNotEnd : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(bGUCharacterCS);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		if (unPersistentReadOnlyData.GetWatchTime() > 0f)
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckWatchTimeNotEnd");
	}

	static BAID_CheckWatchTimeNotEnd()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckWatchTimeNotEnd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckWatchTimeNotEnd));
	}
}
