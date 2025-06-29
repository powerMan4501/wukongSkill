using b1.BGW;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIAMontage : BUInteractActionTemplate
{
	private UAnimInstance AnimInstance;

	private b1.MontageDialogueSkipHelper SkipHelper;

	public BUIAMontage()
	{
		ParamIntNum = 0;
		ParamStringNum = 1;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		AActor aActor = ((Action.ParamsBool == EGSYesNo.Yes) ? User : InteractiveActor);
		UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(aActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
		if (uAnimMontage == null)
		{
			return false;
		}
		BGUFunctionLibraryCS.BGUTriggerUnitState(aActor, EBUStateTrigger.AttackStateBegin, -1f);
		AnimInstance = (aActor as BGUCharacterCS).Mesh.GetAnimInstance();
		BGUFuncLibAnim.BGUActorTryPlayMontage(aActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
		SkipHelper = new b1.MontageDialogueSkipHelper();
		SkipHelper.CalculateIsSupportSkip(uAnimMontage, EInteractAction.Montage, Action);
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

	public override void UpdateIdle(AActor InteractiveActor, FUStInteractionMappingDesc Action, EBGUInteractUnitState State)
	{
		if (Action.ParamsBool != EGSYesNo.Yes && !(InteractiveActor is BGUCharacterCS))
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
			float playLength = uAnimMontage.GetPlayLength();
			if (uAnimMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact, 1f, 0f, (State == EBGUInteractUnitState.AfterInactive) ? playLength : 0f);
			}
		}
	}

	public override void OnEnd(AActor User)
	{
		base.OnEnd(User);
		SkipHelper?.UnbindEvent();
		SkipHelper = null;
	}
}
