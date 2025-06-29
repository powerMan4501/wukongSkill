using b1.BGW;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIALongPressRescue : BUInteractActionTemplate
{
	private UAnimInstance AnimInstance;

	public BUIALongPressRescue()
	{
		ParamIntNum = 0;
		ParamStringNum = 2;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(User).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[1], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage == null)
		{
			return false;
		}
		BGUFunctionLibraryCS.BGUTriggerUnitState(User, EBUStateTrigger.AttackStateBegin, -1f);
		AnimInstance = (User as BGUCharacterCS).Mesh.GetAnimInstance();
		BGUFuncLibAnim.BGUActorTryPlayMontage(User, uAnimMontage, FName.None, EMontageBindReason.Interact);
		return true;
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (!AnimInstance.IsNullOrDestroyed())
		{
			AnimInstance.Montage_Stop(0.2f, null);
		}
	}
}
