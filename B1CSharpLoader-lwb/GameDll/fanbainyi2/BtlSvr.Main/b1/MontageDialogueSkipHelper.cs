using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class MontageDialogueSkipHelper
{
	private bool IsSupportSkip;

	private EInteractAction InteractActionType;

	private int SkipCount;

	private AActor InteractiveActor;

	private bool IsBindEvent;

	public void CalculateIsSupportSkip(UAnimMontage TargetMontage, EInteractAction InInteractActionType, FUStInteractionMappingDesc Action)
	{
		InteractActionType = InInteractActionType;
		if (DebugConfig.DisableSkipMontageInteractFunc)
		{
			IsSupportSkip = false;
			return;
		}
		switch (InteractActionType)
		{
		case EInteractAction.Montage:
			if (Action.ParamsBool == EGSYesNo.Yes)
			{
				IsSupportSkip = false;
				return;
			}
			break;
		}
		if (TargetMontage.IsNullOrDestroyed())
		{
			IsSupportSkip = false;
			return;
		}
		int num = 0;
		UGSE_AnimFuncLib.GetAllNotifyEvent(TargetMontage, out var AnimNotifyEventList);
		foreach (FAnimNotifyEvent item in AnimNotifyEventList)
		{
			if (!(item.Notify as b1.BAN_HandleAiConversation).IsNullOrDestroyed())
			{
				num++;
			}
		}
		if (num == 1)
		{
			IsSupportSkip = true;
		}
		else
		{
			IsSupportSkip = false;
		}
	}

	public bool GetIsSupportSkip()
	{
		return IsSupportSkip;
	}

	public void BindEvent(AActor InInteractiveActor)
	{
		InteractiveActor = InInteractiveActor;
		if (IsSupportSkip && !InteractiveActor.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InteractiveActor);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.Evt_OnAiConversationListEnded != null)
			{
				bUS_GSEventCollection.Evt_OnAiConversationListEnded += new Del_Void(OnAiConversationEnded);
				IsBindEvent = true;
			}
			SkipCount = 0;
		}
	}

	public void UnbindEvent()
	{
		if (!IsBindEvent)
		{
			return;
		}
		IsBindEvent = false;
		if (!InteractiveActor.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(InteractiveActor);
			if (bUS_GSEventCollection != null && bUS_GSEventCollection.Evt_OnAiConversationListEnded != null)
			{
				bUS_GSEventCollection.Evt_OnAiConversationListEnded -= new Del_Void(OnAiConversationEnded);
			}
		}
	}

	private void OnAiConversationEnded()
	{
		UnbindEvent();
		if (SkipCount <= 0)
		{
			return;
		}
		switch (InteractActionType)
		{
		case EInteractAction.LoopMontage:
			BUS_EventCollectionCS.Get(InteractiveActor)?.Evt_UnitStateTrigger?.Invoke(EBUStateTrigger.AttackStateBegin, 0.2f, NeedForceUpdate: true);
			break;
		case EInteractAction.Montage:
		{
			BGUCharacterCS bGUCharacterCS = InteractiveActor as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed() && bGUCharacterCS.Mesh != null)
			{
				UAnimInstance animInstance = bGUCharacterCS.Mesh.GetAnimInstance();
				if (!animInstance.IsNullOrDestroyed())
				{
					animInstance.Montage_Stop(0.2f, null);
				}
				BUS_EventCollectionCS.Get(InteractiveActor)?.Evt_UnitStateTrigger?.Invoke(EBUStateTrigger.AttackStateBegin, 0.2f, NeedForceUpdate: true);
			}
			break;
		}
		}
	}

	public void ExecSkipAction()
	{
		if (IsSupportSkip && IsBindEvent && !InteractiveActor.IsNullOrDestroyed())
		{
			BGS_EventCollectionCS.Get(InteractiveActor)?.Evt_BGS_JumpToNextSubtitleMarkerPos?.Invoke(InteractiveActor);
			SkipCount++;
		}
	}
}
