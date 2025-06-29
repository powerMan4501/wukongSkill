using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckTargetIsInPursuitRange")]
public class BAID_CheckTargetIsInPursuitRange : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor == null)
		{
			return false;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(OwnerActor);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(OwnerActor);
		if (aActor == null)
		{
			return true;
		}
		return unPersistentReadOnlyData.IsInPursuitRange(BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckTargetIsInPursuitRange");
	}

	static BAID_CheckTargetIsInPursuitRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckTargetIsInPursuitRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckTargetIsInPursuitRange));
	}
}
