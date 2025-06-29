using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_Base")]
public class BAIT_Base : UBTTask_USharpBase
{
	protected void EndThisNode(bool bSuccess = true)
	{
		if (IsTaskAborting())
		{
			FinishAbort();
		}
		else
		{
			FinishExecute(bSuccess);
		}
	}

	protected bool ShouldAbort(ACharacter Unit)
	{
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Unit);
		if (readOnlyData != null)
		{
			if (readOnlyData.HasState(EBGUUnitState.Beatback) && !readOnlyData.HasState(EBGUUnitState.InComboWindow))
			{
				return true;
			}
			if (readOnlyData.HasState(EBGUUnitState.HRCounterattacking) || readOnlyData.HasState(EBGUUnitState.BlockBeatBack) || readOnlyData.HasState(EBGUUnitState.PerfectBlockBeatBack) || readOnlyData.HasState(EBGUUnitState.BlockBounced))
			{
				return true;
			}
			return false;
		}
		return true;
	}

	public virtual void ReceiveExecute(AActor OwnerActor)
	{
		FinishExecute(bSuccess: true);
	}

	public virtual void ReceiveAbort(AActor OwnerActor)
	{
		bool flag = true;
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			if (bUS_GSEventCollection != null)
			{
				flag = false;
				bUS_GSEventCollection.Evt_SetAIBTAborted.Invoke();
			}
		}
		if (flag)
		{
			FinishAbort();
		}
	}

	public virtual void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		AINodeFinishState aINodeFinishState = AINodeFinishState.Success;
		if (OwnerActor is BGUCharacterCS actor)
		{
			IBUC_AINodeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AINodeData, BUC_AINodeData>(actor);
			if (unPersistentReadOnlyData != null)
			{
				aINodeFinishState = unPersistentReadOnlyData.CanFinishAINode;
			}
		}
		if (aINodeFinishState != AINodeFinishState.Process)
		{
			EndThisNode(aINodeFinishState == AINodeFinishState.Success);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_Base");
	}

	static BAIT_Base()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIT_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIT_Base));
	}
}
