using System;
using b1.EventDelDefine;
using b1.Plugins.AsyncLoadingScreen;
using CommB1;
using Google.Protobuf;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class GuideNodeInstance_Mark : PsmSubMachine_TemplateBase
{
	private class State_Mark : PsmSubMachineState
	{
		private IBGC_PlayerGuideData _playerGuideData;

		private bool IsECSWorldBeginPlay => BGW_ECSWorld.Get(GetOwner()).HasECSWorldBeginPlay;

		private bool IsPlayerGuideDataValid => _playerGuideData != null;

		private bool IsLoadingScreenNotOpen => BGWGameInstanceCS.Get(GetOwner()).GetCurLoadingScreenState() == EGSLoadingScreenState.Idle;

		private bool IsSupportMark
		{
			get
			{
				if (IsECSWorldBeginPlay && IsPlayerGuideDataValid)
				{
					return IsLoadingScreenNotOpen;
				}
				return false;
			}
		}

		public override void OnEnterAction()
		{
			_playerGuideData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_PlayerGuideData, BGC_PlayerGuideData>(GetOwner());
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
			bGW_EventCollection.Evt_PostGameStateEndPlay = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PostGameStateEndPlay, new Del_Void(OnPostGameStateEndPlay));
			if (!IsSupportMark)
			{
				NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
			}
			else if (!BGW_SettingMgrV2.Get(GetOwner()).GetCVBoolByType(UISettingConfigType.PlayerGuide))
			{
				NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
			}
			else
			{
				if (!GetSubMachine<GuideNodeInstance_Mark>(out var OutSubMachine))
				{
					return;
				}
				OutSubMachine.SetObjStateOnBeginning();
				if (_playerGuideData.FinishedGroupGuideList.Contains(OutSubMachine.GuideGroupId))
				{
					NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
					return;
				}
				BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(GetOwner());
				if (bGS_GSEventCollection != null)
				{
					bGS_GSEventCollection.Evt_PlayerTriggerGuideGroup.Invoke(OutSubMachine.GuideGroupId);
					if (OutSubMachine.IsWaitUntilGuideFinish)
					{
						bGS_GSEventCollection.Evt_PlayerFinishGuideGroup += new Del_Void_Int(OnFinishGuideGroupId);
					}
					else
					{
						NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
					}
				}
			}
		}

		public override void OnResetAction()
		{
		}

		private void OnPostGameStateEndPlay()
		{
			BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(GetOwner());
			bGW_EventCollection.Evt_PostGameStateEndPlay = (Del_Void)Delegate.Remove(bGW_EventCollection.Evt_PostGameStateEndPlay, new Del_Void(OnPostGameStateEndPlay));
			NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
		}

		private void OnFinishGuideGroupId(int FinishedGuideGroupId)
		{
			if (GetSubMachine<GuideNodeInstance_Mark>(out var OutSubMachine) && OutSubMachine.GuideGroupId == FinishedGuideGroupId)
			{
				NotifySelf(BGW_FlowUtils.SceneObjCommonEventTag.Next);
			}
		}

		public override void OnExitAction()
		{
			if (IsSupportMark && GetSubMachine<GuideNodeInstance_Mark>(out var OutSubMachine) && !_playerGuideData.FinishedGroupGuideList.Contains(OutSubMachine.GuideGroupId))
			{
				BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(GetOwner());
				if (bGS_GSEventCollection != null && OutSubMachine.IsWaitUntilGuideFinish)
				{
					bGS_GSEventCollection.Evt_PlayerFinishGuideGroup -= new Del_Void_Int(OnFinishGuideGroupId);
				}
			}
		}
	}

	public override string NodeClass => B1CalliopeDef.GuideNode.Mark;

	private GuideCustom_Mark CustomData { get; set; }

	private int GuideGroupId { get; set; }

	private bool IsWaitUntilGuideFinish => true;

	protected override string DefaultTerminatePinName => BGW_FlowUtils.PinName.Out.PlainName;

	protected override void InitialData(byte[] CustomDataBytes)
	{
		base.InitialData(CustomDataBytes);
		CustomData = new GuideCustom_Mark();
		CustomData.MergeFrom(CustomDataBytes);
		GuideGroupId = CustomData.GuideGroupId;
		FGameplayTag state_Mark = BGW_FlowUtils.GuideTag.State_Mark;
		RegisterStateWithClass(state_Mark, typeof(State_Mark));
		RegisterInitialTransition(state_Mark);
		RegisterFinalTransition(state_Mark, BGW_FlowUtils.SceneObjCommonEventTag.Next);
	}
}
