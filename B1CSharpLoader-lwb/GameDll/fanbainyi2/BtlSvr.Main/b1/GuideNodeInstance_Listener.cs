using System;
using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class GuideNodeInstance_Listener : PsmSubMachine_TemplateBase
{
	private class State_Listener : PsmSubMachineState
	{
		public override void OnEnterAction()
		{
			if (GetSubMachine<GuideNodeInstance_Listener>(out var OutSubMachine))
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
				bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Combine(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OutSubMachine.OnSettingValueChanged));
				OutSubMachine.SetObjStateOnBeginning();
			}
		}

		public override void OnExitAction()
		{
			if (GetSubMachine<GuideNodeInstance_Listener>(out var OutSubMachine))
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
				bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Remove(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OutSubMachine.OnSettingValueChanged));
			}
		}

		public override void OnResetAction()
		{
		}

		public override void Shutdown()
		{
			if (GetSubMachine<GuideNodeInstance_Listener>(out var OutSubMachine))
			{
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
				bGW_EventCollection.Evt_SettingValueChanged = (Del_SettingValueChanged)Delegate.Remove(bGW_EventCollection.Evt_SettingValueChanged, new Del_SettingValueChanged(OutSubMachine.OnSettingValueChanged));
			}
		}
	}

	public override string NodeClass => B1CalliopeDef.GuideNode.Listener;

	private GuideCustom_Listener CustomData { get; set; }

	private List<CalliopeCustom_CompositeTransitionCondition_Guide> TransitionConditions { get; set; }

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		CustomData = new GuideCustom_Listener();
		CustomData.MergeFrom(CustomDataBytes);
		TransitionConditions = CustomData.TransitionConditions.ToList();
		RegisterStateWithClass(BGW_FlowUtils.GuideTag.State_Listner, typeof(State_Listener));
		RegisterInitialTransition(BGW_FlowUtils.GuideTag.State_Listner);
		base.ManagedSceneObjs.AddRange(CustomData.ManagedObjs);
		base.ManagedNpcUnits.AddRange(CustomData.ManagedNpcUnits);
		base.ManagedInteractors.AddRange(CustomData.ManagedInteractors);
		base.ManagedStreamingLevelStateConfigs.AddRange(CustomData.ManagedStreamingLevelStateConfigs);
		base.ManagedGroupUnits.AddRange(CustomData.ManagedGroupUnits);
	}

	public override void PreStart()
	{
		base.PreStart();
		ClearTerminateGuards();
		if (BGW_SettingMgrV2.Get(GetOwner()).GetCVBoolByType(UISettingConfigType.PlayerGuide))
		{
			InitTransitionGuards();
		}
	}

	private void InitTransitionGuards()
	{
		if (!TransitionConditions.Any())
		{
			return;
		}
		IBGC_PlayerGuideData PlayerGuideData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_PlayerGuideData, BGC_PlayerGuideData>(UGameplayStatics.GetGameState(GetOwner()));
		if (PlayerGuideData != null)
		{
			TransitionConditions.RemoveAll((CalliopeCustom_CompositeTransitionCondition_Guide condition) => condition.Single.RelatedGuideGroupId.Any() && PlayerGuideData.IsGroupGuideCompleted(condition.Single.RelatedGuideGroupId));
		}
		foreach (CalliopeCustom_CompositeTransitionCondition_Guide transitionCondition in TransitionConditions)
		{
			TransitionGuard guard = new TransitionGuard(transitionCondition, base.ParentNodeInstance);
			RegisterTerminateGuards(guard);
		}
	}

	private void OnSettingValueChanged(int OldValue, int NewValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.PlayerGuide)
		{
			if (NewValue == 1)
			{
				InitTransitionGuards();
				StartTerminateGuards();
			}
			else
			{
				ClearTerminateGuards();
			}
		}
	}
}
