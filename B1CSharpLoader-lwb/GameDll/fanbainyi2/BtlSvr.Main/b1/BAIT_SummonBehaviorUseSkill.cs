using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SummonBehaviorUseSkill")]
internal class BAIT_SummonBehaviorUseSkill : BAIT_Base
{
	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor).Evt_SummonBehaviorUseSkill.Invoke();
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		if (BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_SummonBehaviorData, b1.BUC_SummonBehaviorData>(OwnerActor).QueueSkillID.Count <= 0 && !BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(OwnerActor).HasState(EBGUUnitState.Attacking))
		{
			FinishExecute(bSuccess: true);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SummonBehaviorUseSkill");
	}

	static BAIT_SummonBehaviorUseSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SummonBehaviorUseSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SummonBehaviorUseSkill));
	}
}
