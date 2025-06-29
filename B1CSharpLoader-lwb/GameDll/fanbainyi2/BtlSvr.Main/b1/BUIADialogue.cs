using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIADialogue : BUInteractActionTemplate
{
	private AActor DialoguePlayer;

	private AActor InteractiveActor;

	private float MontageTime = -1f;

	private bool IsAiConversationHasAM;

	private bool IsNeedRemoveAttackStateAtEnd;

	private int SkipCount;

	public BUIADialogue()
	{
		ParamIntNum = 1;
		ParamStringNum = 1;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		this.InteractiveActor = InteractiveActor;
		AActor aActor = ((Action.ParamsBool == EGSYesNo.Yes) ? User : InteractiveActor);
		Player = User;
		DialoguePlayer = aActor;
		List<int> list = new List<int>();
		list.AddRange(Action.ParamsInt.ToList());
		BUS_EventCollectionCS.Get(aActor).Evt_HandleConversationByContentIDList.Invoke("交互", list);
		IBGC_AiConversationMgrData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_AiConversationMgrData>(aActor);
		if (gameStateReadonlyData == null)
		{
			BGW_LogUtil.LogError("[interactcomp] BUIADialogue DoInteractAction AiConversationMgrData == null");
			return false;
		}
		if (!gameStateReadonlyData.GetLast_bPocessSuccess())
		{
			BGW_LogUtil.LogError("[interactcomp] BUIADialogue DoInteractAction HandleConversation Failed");
			return false;
		}
		FUStAiConversationContentDesc aiConversationContentDesc = BGW_GameDB.GetAiConversationContentDesc(gameStateReadonlyData.GetLast_AiConversationDescID());
		if (aiConversationContentDesc == null)
		{
			BGW_LogUtil.LogError("[interactcomp] BUIADialogue DoInteractAction AiConversationContentDesc == null");
			return false;
		}
		if (aiConversationContentDesc.SpeakerType == EAiConversationTargetType.Self)
		{
			BUS_EventCollectionCS.Get(InteractiveActor).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting);
			BUS_EventCollectionCS.Get(aActor).Evt_OnAiConversationListEnded += new Del_Void(OnAiConversationEnded);
			BUS_EventCollectionCS.Get(aActor).Evt_OnAiConversationListInteraputed += new Del_Void(OnAiConversationInterrupted);
		}
		IsAiConversationHasAM = !string.IsNullOrWhiteSpace(aiConversationContentDesc.AMPath);
		IsNeedRemoveAttackStateAtEnd = Action.ParamsBool == EGSYesNo.No && IsAiConversationHasAM;
		SkipCount = 0;
		if (Action.ParamsString.Count > 0)
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(User).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				BGUFunctionLibraryCS.BGUTriggerUnitState(User, EBUStateTrigger.AttackStateBegin, -1f);
				MontageTime = BGUFuncLibAnim.BGUActorTryPlayMontage(User, uAnimMontage, FName.None, EMontageBindReason.Interact);
			}
		}
		return true;
	}

	private void OnAiConversationEnded()
	{
		BUS_EventCollectionCS.Get(InteractiveActor)?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting, IsRemove: true);
		BUS_EventCollectionCS.Get(DialoguePlayer).Evt_OnAiConversationListEnded -= new Del_Void(OnAiConversationEnded);
		BUS_EventCollectionCS.Get(DialoguePlayer).Evt_OnAiConversationListInteraputed -= new Del_Void(OnAiConversationInterrupted);
		if (SkipCount > 0 && IsNeedRemoveAttackStateAtEnd)
		{
			BUS_EventCollectionCS.Get(InteractiveActor)?.Evt_UnitStateTrigger?.Invoke(EBUStateTrigger.AttackStateBegin, 0.2f, NeedForceUpdate: true);
		}
	}

	private void OnAiConversationInterrupted()
	{
		BUS_EventCollectionCS.Get(InteractiveActor)?.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting, IsRemove: true);
		BUS_EventCollectionCS.Get(DialoguePlayer).Evt_OnAiConversationListEnded -= new Del_Void(OnAiConversationEnded);
		BUS_EventCollectionCS.Get(DialoguePlayer).Evt_OnAiConversationListInteraputed -= new Del_Void(OnAiConversationInterrupted);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(DialoguePlayer);
		if (!firstLocalPlayerController.IsNullOrDestroyed())
		{
			BPS_EventCollectionCS.Get(firstLocalPlayerController)?.Evt_BPS_BreakInteract?.Invoke();
		}
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BUS_EventCollectionCS.Get(DialoguePlayer).Evt_OnAiConversationListEnded -= new Del_Void(OnAiConversationEnded);
		BUS_EventCollectionCS.Get(DialoguePlayer).Evt_OnAiConversationListInteraputed -= new Del_Void(OnAiConversationInterrupted);
		BGS_EventCollectionCS.Get(DialoguePlayer).Evt_BGS_StopAiConversation.Invoke(DialoguePlayer, EACInterruptType.Interrupt, EACInterruptReason.InteractActionBreak);
		BUS_EventCollectionCS.Get(InteractiveActor).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting, IsRemove: true);
		if (MontageTime > 0f)
		{
			MontageTime = 0f;
			ACharacter aCharacter = User as ACharacter;
			if (!aCharacter.IsNullOrDestroyed() && !(aCharacter.Mesh == null))
			{
				aCharacter.Mesh.GetAnimInstance()?.Montage_Stop(0.2f, null);
			}
		}
	}

	public override bool IsSupportSkip(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (Action == null || Action.ParamsInt.Count <= 0)
		{
			return false;
		}
		if (Action.ParamsString.Count > 0)
		{
			return false;
		}
		if (DebugConfig.DisableSkipMontageInteractFunc && IsAiConversationHasAM)
		{
			return false;
		}
		return true;
	}

	public override void OnSkipInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BGS_EventCollectionCS.Get(DialoguePlayer)?.Evt_BGS_JumpToNextSubtitleMarkerPos?.Invoke(DialoguePlayer);
		SkipCount++;
	}
}
