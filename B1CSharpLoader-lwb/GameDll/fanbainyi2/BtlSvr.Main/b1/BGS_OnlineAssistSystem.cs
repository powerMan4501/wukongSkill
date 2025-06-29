using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BGS_OnlineAssistSystem : GameStateSystemBase
{
	private BGC_OnlineAssistData _onlineAssistData;

	private IBIC_GlobalActorData _globalActorData;

	public override void OnAttach()
	{
		_onlineAssistData = RequireWritableData<BGC_OnlineAssistData>();
		_globalActorData = RequireReadonlyGameInstanceData<IBIC_GlobalActorData, BIC_GlobalActorData>();
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(Owner);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_RegisterCrusadeMonsterInfo += new Del_Void_IntString(OnRegisterCrusadeMonsterInfo);
			bGS_GSEventCollection.Evt_EncounterUnit += new Del_Void_String(OnEncounterUnit);
			bGS_GSEventCollection.Evt_TriggerAssistEvent += new Del_Void_EAssistEvent(OnTriggerAssistEvent);
			bGS_GSEventCollection.Evt_EnterCrusadeArea += new Del_Void_Bool(OnEnterCrusadeArea);
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SetActorAliveState = (Del_Void_StringBool)Delegate.Combine(bGW_EventCollection.Evt_SetActorAliveState, new Del_Void_StringBool(OnSetActorAliveState));
		}
	}

	public override void OnBeginPlay()
	{
		_onlineAssistData.IsHomeOwner = true;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_SetActorAliveState = (Del_Void_StringBool)Delegate.Remove(bGW_EventCollection.Evt_SetActorAliveState, new Del_Void_StringBool(OnSetActorAliveState));
		}
	}

	private void OnRegisterCrusadeMonsterInfo(int RebirthPointId, string UnitGuid)
	{
		if (GSEUtil.Ensure(RebirthPointId > 0 && !string.IsNullOrEmpty(UnitGuid), $"Online Assist: fail to register crusade monster info, UnitGuid: {UnitGuid}, RebirthPoint: {RebirthPointId}") && _onlineAssistData.CrusadeMonsterInfos.TryGetValue(UnitGuid, out var OutValue))
		{
			if (OutValue.CrusadeState == ECrusadeState.AliveAndOnceCrusaded || OutValue.CrusadeState == ECrusadeState.Crusaded)
			{
				OutValue.CrusadeState = (_globalActorData.GetActorAliveState(UnitGuid) ? ECrusadeState.AliveAndOnceCrusaded : ECrusadeState.Crusaded);
				return;
			}
			_onlineAssistData.CrusadeMonsterInfos.Add(UnitGuid, new FCrusadeUnitInfo
			{
				RebirthPoint = RebirthPointId,
				CrusadeState = ECrusadeState.NotEverEncountered
			});
		}
	}

	private void OnEncounterUnit(string UnitGuid)
	{
		if (_onlineAssistData.CrusadeMonsterInfos.TryGetValue(UnitGuid, out var OutValue) && OutValue.CrusadeState == ECrusadeState.NotEverEncountered)
		{
			OutValue.CrusadeState = ECrusadeState.EncounteredNotEverCrusaded;
		}
	}

	private void OnSetActorAliveState(string UnitGuid, bool bAlive)
	{
		if (_onlineAssistData.CrusadeMonsterInfos.TryGetValue(UnitGuid, out var OutValue) && GSEUtil.Ensure(OutValue.CrusadeState != ECrusadeState.NotEverEncountered, "Online Assist: fail to update CrusadeState due to the actor have not ever been encountered"))
		{
			switch (OutValue.CrusadeState)
			{
			case ECrusadeState.EncounteredNotEverCrusaded:
				if (!bAlive)
				{
					OutValue.CrusadeState = ECrusadeState.Crusaded;
				}
				break;
			case ECrusadeState.AliveAndOnceCrusaded:
				if (!bAlive)
				{
					OutValue.CrusadeState = ECrusadeState.Crusaded;
				}
				break;
			case ECrusadeState.Crusaded:
				if (bAlive)
				{
					OutValue.CrusadeState = ECrusadeState.AliveAndOnceCrusaded;
				}
				break;
			}
		}
		if (UnitGuid == _onlineAssistData.CurrentCrusadeUnit && !bAlive)
		{
			OnTriggerAssistEvent(EAssistEvent.CrusadeTargetDead);
		}
	}

	private void OnTriggerAssistEvent(EAssistEvent AssistEvent)
	{
		switch (_onlineAssistData.AssistState)
		{
		case EAssistState.NotCallForAssist:
			if (AssistEvent == EAssistEvent.RequestAssist)
			{
				_onlineAssistData.AssistState = EAssistState.WaitingForAssist;
			}
			break;
		case EAssistState.WaitingForAssist:
			switch (AssistEvent)
			{
			case EAssistEvent.ActivelyCancel:
				_onlineAssistData.AssistState = EAssistState.NotCallForAssist;
				break;
			case EAssistEvent.TeleportOutAssistArea:
				_onlineAssistData.AssistState = EAssistState.NotCallForAssist;
				break;
			case EAssistEvent.CrusadeTargetDead:
				_onlineAssistData.AssistState = EAssistState.NotCallForAssist;
				break;
			case EAssistEvent.MoveOutAssistArea:
				_onlineAssistData.AssistState = EAssistState.NotCallForAssist;
				break;
			case EAssistEvent.BackToStandalone:
				_onlineAssistData.AssistState = EAssistState.NotCallForAssist;
				break;
			}
			switch (AssistEvent)
			{
			case EAssistEvent.TeamWipeOut:
				BGS_EventCollectionCS.Get(Owner).Evt_TeamWipeOut.Invoke();
				_onlineAssistData.CurrentCrusadeUnit = string.Empty;
				_onlineAssistData.AssistState = EAssistState.NotCallForAssist;
				break;
			case EAssistEvent.CrusadeSuccess:
				BGS_EventCollectionCS.Get(Owner).Evt_CrusadeSuccess.Invoke();
				_onlineAssistData.CurrentCrusadeUnit = string.Empty;
				_onlineAssistData.AssistState = EAssistState.NotCallForAssist;
				break;
			}
			break;
		}
	}

	private void OnEnterCrusadeArea(bool IsEnter)
	{
	}
}
