using BtlB1;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FAiConversationProxy
{
	private bool bSpeakerIsTamer;

	public BAC_Event CurEvent;

	public BUS_GSEventCollection BE_Speaker;

	public TWeakObject<AActor> SpeakerPtr { get; private set; }

	public TWeakObject<BGUDialogueProxyActor> DialogueProxyActor { get; private set; }

	public FAiConversationProxy(AActor _Speaker, BGUDialogueProxyActor _DialogueProxyActor = null)
	{
		SpeakerPtr = new TWeakObject<AActor>(_Speaker);
		BE_Speaker = BUS_EventCollectionCS.Get(_Speaker);
		bSpeakerIsTamer = _Speaker is ABGUTamerBase;
		if (bSpeakerIsTamer)
		{
			DialogueProxyActor = new TWeakObject<BGUDialogueProxyActor>(_DialogueProxyActor);
		}
	}

	public void Update(float DeltaTime)
	{
		CurEvent?.Update(DeltaTime);
		DrawDebug(DeltaTime);
	}

	public uint GetReqID_CurPlayingEvent()
	{
		if (CurEvent == null)
		{
			return 0u;
		}
		return CurEvent.GetEventReqID();
	}

	public bool IsFinished()
	{
		return CurEvent == null;
	}

	public void HandleConversation(AActor Unit, BAC_Event AiConversationEvent)
	{
		if (AiConversationEvent != null)
		{
			if (bSpeakerIsTamer && Unit is BGUActorBaseCS)
			{
				SpeakerPtr = new TWeakObject<AActor>(Unit);
				DialogueProxyActor.Set(null);
				bSpeakerIsTamer = false;
			}
			HandleNewEvent(AiConversationEvent);
		}
	}

	public void StopAiConversation(EACInterruptType InterruptType, EACInterruptReason InterruptReason)
	{
		switch (InterruptType)
		{
		case EACInterruptType.Complete:
			CompleteCurEvent(InterruptReason);
			break;
		case EACInterruptType.Interrupt:
			InterruptCurEvent(InterruptReason);
			break;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string arg = "warning:Speaker丢失 ";
			if (!SpeakerPtr.Get().IsNullOrDestroyed())
			{
				arg = SpeakerPtr.Get().GetName();
			}
			BGUFunctionLibraryCS.LogBattleInfo(SpeakerPtr.Get(), EBattleInfoType.AiConversation, $"<character>{arg}</><action>的对话被打断, 打断类型:</><effect>{InterruptType}</><action> ,打断原因:</><effect>{InterruptReason}</>");
			BGUFunctionLibraryCS.LogBattleInfo(SpeakerPtr.Get(), EBattleInfoType.AiConversation, "<action>-----------------------------------------------------------------------</>");
		}
	}

	public void JumpToNextSubtitleMarkerPos()
	{
		if (CurEvent != null)
		{
			CurEvent.JumpToNextSubtitleMarkerPos();
		}
	}

	private bool HandleNewEvent(BAC_Event NewEvent)
	{
		if (NewEvent == null)
		{
			return false;
		}
		if (CurEvent != null)
		{
			int contentPriority = CurEvent.GetContentPriority();
			if (NewEvent.GetContentPriority() <= contentPriority)
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					string arg = "warning:Speaker丢失 ";
					if (!CurEvent.GetSpeaker().IsNullOrDestroyed())
					{
						arg = CurEvent.GetSpeaker().GetName();
					}
					BGUFunctionLibraryCS.LogBattleInfo(SpeakerPtr.Get(), EBattleInfoType.AiConversation, $"<character>{arg}</><action>当前正在执行的对话：</><effect>{CurEvent.GetAiConversationContentDescID()}</><action>优先级为</>" + $"<effect>{CurEvent.GetContentPriority()}</><action>, 而想要插入的对话：</><effect>{NewEvent.GetAiConversationContentDescID()}</>" + $"<action>优先级为</><effect>{NewEvent.GetContentPriority()}</><action>,无法打断插入</>");
				}
				return false;
			}
		}
		InterruptCurEvent(EACInterruptReason.High_Priority_Event_Insert);
		PlayNewEvent(NewEvent);
		return true;
	}

	private void InterruptCurEvent(EACInterruptReason Reason)
	{
		if (CurEvent != null)
		{
			CurEvent.InterruptEvent(Reason);
		}
	}

	private void CompleteCurEvent(EACInterruptReason Reason)
	{
		if (CurEvent != null)
		{
			CurEvent.CompleteEvent_WithoutTriggerNextAiConversation(Reason);
		}
	}

	private void PlayNewEvent(BAC_Event _Event)
	{
		CurEvent = _Event;
		CurEvent.PendingHandleConversation(this);
	}

	public void OnEventEnded()
	{
		CurEvent = null;
		BE_Speaker?.Evt_ActiveAiConversationDistanceInterruptCheck.Invoke(P1: false, P2: false, 0f);
		BE_Speaker?.Evt_ActiveAiConversationListenerStateInterruptCheck.Invoke(P1: false, "", 0f);
	}

	public void DrawDebug(float DeltaTime)
	{
		if (CurEvent != null && GSGameplayCVar.CVar_EnableAiConversationDebug.GetValueInGameThread() != 0)
		{
			BGUCharacterCS bGUCharacterCS = CurEvent.GetSpeaker() as BGUCharacterCS;
			if (!bGUCharacterCS.IsNullOrDestroyed())
			{
				FLinearColor lineColor = (CurEvent.InWaiting() ? FLinearColor.Red : FLinearColor.Green);
				USystemLibrary.DrawDebugCapsule(bGUCharacterCS, bGUCharacterCS.GetActorLocation(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius(), bGUCharacterCS.GetActorRotation(), lineColor, 0f, 4f);
			}
		}
	}
}
