using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_SelfBeyondPursuitRange")]
public class BAID_SelfBeyondPursuitRange : BAID_Base
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
		if (unPersistentReadOnlyData.IsInPursuitRange(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor)))
		{
			return false;
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_SelfBeyondPursuitRange");
	}

	static BAID_SelfBeyondPursuitRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_SelfBeyondPursuitRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_SelfBeyondPursuitRange));
	}
}
