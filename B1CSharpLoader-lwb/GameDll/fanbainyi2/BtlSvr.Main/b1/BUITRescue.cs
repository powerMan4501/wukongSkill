using b1.BGW;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUITRescue : BUInteractTypeTemplate
{
	public BUITRescue()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[0];
	}

	public override bool TriggerInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((User as APawn).PlayerState);
		if (readOnlyData != null && readOnlyData.InteractActionDesc.InteractAction != EInteractAction.LongPressRescue)
		{
			return false;
		}
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(User).TryGetCachedResourceObj<UAnimMontage>(readOnlyData.InteractActionDesc.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage == null)
		{
			return false;
		}
		BGUFuncLibAnim.BGUActorTryPlayMontage(User, uAnimMontage, FName.None, EMontageBindReason.Interact);
		return true;
	}

	public override bool BreakInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BPC_PlayerInteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((User as APawn).PlayerState);
		if (readOnlyData != null && readOnlyData.InteractActionDesc.InteractAction != EInteractAction.LongPressRescue)
		{
			return false;
		}
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(User).TryGetCachedResourceObj<UAnimMontage>(readOnlyData.InteractActionDesc.ParamsString[1], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage == null)
		{
			return false;
		}
		BGUFunctionLibraryCS.BGUTriggerUnitState(User, EBUStateTrigger.AttackStateBegin, -1f);
		BGUFuncLibAnim.BGUActorTryPlayMontage(User, uAnimMontage, FName.None, EMontageBindReason.Interact);
		return true;
	}

	public override bool FinishInteractInput(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		BUS_EventCollectionCS.Get(User).Evt_FinishRescueInteract.Invoke(InteractiveActor);
		return true;
	}
}
