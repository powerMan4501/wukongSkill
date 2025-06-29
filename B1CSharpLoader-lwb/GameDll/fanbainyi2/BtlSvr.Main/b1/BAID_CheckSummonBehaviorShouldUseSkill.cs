using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckSummonBehaviorShouldUseSkill")]
internal class BAID_CheckSummonBehaviorShouldUseSkill : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		b1.IBUC_SummonBehaviorData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_SummonBehaviorData, b1.BUC_SummonBehaviorData>(OwnerActor);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		return unPersistentReadOnlyData.QueueSkillID.Count > 0;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckSummonBehaviorShouldUseSkill");
	}

	static BAID_CheckSummonBehaviorShouldUseSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckSummonBehaviorShouldUseSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckSummonBehaviorShouldUseSkill));
	}
}
