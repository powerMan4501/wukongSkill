using b1.BGW;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIALoopMontage : BUInteractActionTemplate
{
	private UAnimInstance AnimInstance;

	private b1.MontageDialogueSkipHelper SkipHelper;

	public BUIALoopMontage()
	{
		ParamIntNum = 1;
		ParamStringNum = 2;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage == null)
		{
			return false;
		}
		BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(InteractiveActor).AiConversationNeedToPlay = Action.ParamsInt[1];
		BGUFunctionLibraryCS.BGUTriggerUnitState(InteractiveActor, EBUStateTrigger.AttackStateBegin, Action.ParamsInt[0]);
		BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
		AnimInstance = (InteractiveActor as BGUCharacterCS).Mesh.GetAnimInstance();
		SkipHelper = new b1.MontageDialogueSkipHelper();
		SkipHelper.CalculateIsSupportSkip(uAnimMontage, EInteractAction.LoopMontage, Action);
		return true;
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		SkipHelper?.UnbindEvent();
		SkipHelper = null;
		if (!AnimInstance.IsNullOrDestroyed())
		{
			AnimInstance.Montage_Stop(0.2f, null);
		}
	}

	public override void OnFinishInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		SkipHelper?.UnbindEvent();
		SkipHelper = null;
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[1], ELoadResourceType.SyncLoadAndCache);
		if (!(uAnimMontage == null))
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
		}
	}

	public override bool IsSupportSkip(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (SkipHelper != null && SkipHelper.GetIsSupportSkip())
		{
			SkipHelper.BindEvent(InteractiveActor);
			return true;
		}
		return false;
	}

	public override void OnSkipInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		SkipHelper?.ExecSkipAction();
	}

	public override void OnEnd(AActor User)
	{
		base.OnEnd(User);
		SkipHelper?.UnbindEvent();
		SkipHelper = null;
	}
}
