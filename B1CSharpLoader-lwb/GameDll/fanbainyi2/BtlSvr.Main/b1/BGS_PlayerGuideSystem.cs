using System;
using b1.EventDelDefine;
using BtlShare;
using OssB1;
using UnrealEngine.Engine;

namespace b1;

public class BGS_PlayerGuideSystem : GameModeSystemBase
{
	private BGC_PlayerGuideData _playerGuideData;

	private IBPC_RoleBaseData _roleBaseData;

	public override void OnBeginPlay()
	{
		_playerGuideData = RequireWritableGameStateData<BGC_PlayerGuideData>();
		_roleBaseData = RequireReadOnlyLocalPlayerStateData<IBPC_RoleBaseData, BPC_RoleBaseData>();
		if (DebugConfig.DebugPlayerGuide)
		{
			_playerGuideData.ProceedGroupGuideList.OnAdd += delegate(int Id)
			{
				SendMessage($"玩家触发教学组{Id}");
			};
			_playerGuideData.ProceedGroupGuideList.OnRemove += delegate(int _, int Id)
			{
				SendMessage($"玩家完成教学组{Id}");
			};
			_playerGuideData.CheckListNodeGuideList.OnAdd += delegate(int Id)
			{
				SendMessage($"玩家触发清单教学点{Id}");
			};
			_playerGuideData.CheckListNodeGuideList.OnRemove += delegate(int _, int Id)
			{
				SendMessage($"玩家完成清单教学点{Id}");
			};
		}
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_BGW_UnitCastSkillSuccess = (BGW_EventCollection.Del_BGW_UnitCastSkillSuccess)Delegate.Combine(bGWEventCollection.Evt_BGW_UnitCastSkillSuccess, new BGW_EventCollection.Del_BGW_UnitCastSkillSuccess(OnUnitCastSkillSuccess));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_PostLoadingScreenOpen = (Del_Void)Delegate.Combine(bGWEventCollection2.Evt_PostLoadingScreenOpen, new Del_Void(OnPostLoadingScreenOpen));
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		foreach (int proceedGroupGuide in _playerGuideData.ProceedGroupGuideList)
		{
			GetGameEventCollection().Evt_PlayerFinishGuideGroup.Invoke(proceedGroupGuide);
		}
		_playerGuideData.RevertCurrentProceedGuide();
		if (base.BGWEventCollection != null)
		{
			BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
			bGWEventCollection.Evt_BGW_UnitCastSkillSuccess = (BGW_EventCollection.Del_BGW_UnitCastSkillSuccess)Delegate.Remove(bGWEventCollection.Evt_BGW_UnitCastSkillSuccess, new BGW_EventCollection.Del_BGW_UnitCastSkillSuccess(OnUnitCastSkillSuccess));
			BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
			bGWEventCollection2.Evt_PostLoadingScreenOpen = (Del_Void)Delegate.Remove(bGWEventCollection2.Evt_PostLoadingScreenOpen, new Del_Void(OnPostLoadingScreenOpen));
		}
	}

	public override void OnAttach()
	{
		BGS_GSEventCollection gameEventCollection = GetGameEventCollection();
		if (gameEventCollection != null)
		{
			gameEventCollection.Evt_PlayerTriggerGuideGroup += new Del_Void_Int(OnPlayerTriggerGuideGroup);
			gameEventCollection.Evt_TriggerGuideNodeFinishEvent += new Del_TriggerGuideNodeFinishEvent(OnTriggerGuideNodeFinishEvent);
			gameEventCollection.Evt_TriggerGuideNodeFinishEvent_WithIntParam += new Del_TriggerGuideNodeFinishEvent_WithIntParam(OnTriggerGuideNodeFinishEvent_WithIntParam);
			gameEventCollection.Evt_TriggerConfirmGuideGroupEvent += new Del_Void_Int(OnTriggerConfirmGuideGroupEvent);
		}
	}

	private void OnPlayerTriggerGuideGroup(int GuideGroupId)
	{
		FUStGuideGroupDesc guideGroupDesc = GameDBRuntime.GetGuideGroupDesc(GuideGroupId);
		if (guideGroupDesc != null)
		{
			LogInfo(string.Format("触发了教学组：{0}，类型：{1}，完成类型为：{2}，显示 HUD：{3}，存在游记里：{4}，教学点 Id：{5}", GuideGroupId, guideGroupDesc.GuideGroupType, guideGroupDesc.FinishType, guideGroupDesc.IsShowHud, guideGroupDesc.IsCollected, string.Join(", ", guideGroupDesc.GuideId)));
			_playerGuideData.RemoveTracker(guideGroupDesc, out var OutFinishedGuideGroupIdList);
			OutFinishedGuideGroupIdList.ForEach(TriggerPlayerFinishGuideGroup);
			if (GSEUtil.Ensure(!_playerGuideData.ProceedGroupGuideList.Contains(GuideGroupId)))
			{
				_playerGuideData.ProceedGroupGuideList.Add(GuideGroupId);
			}
			_playerGuideData.AddTracker(guideGroupDesc);
			_playerGuideData.PrintData("OnPlayerTriggerGuideGroup");
		}
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		_playerGuideData.OnTick(DeltaTime, out var OutFinishedGuideGroupIdList);
		OutFinishedGuideGroupIdList.ForEach(TriggerPlayerFinishGuideGroup);
	}

	private void OnTriggerGuideNodeFinishEvent(EGuideNodeFinishType FinishType)
	{
		_playerGuideData.TriggerGuideNodeFinishType(FinishType, out var OutFinishedGuideGroupIdList);
		OutFinishedGuideGroupIdList.ForEach(TriggerPlayerFinishGuideGroup);
	}

	private void OnTriggerGuideNodeFinishEvent_WithIntParam(EGuideNodeFinishType FinishType, int IntParam)
	{
		_playerGuideData.TriggerGuideNodeFinishType_WithIntParam(FinishType, IntParam, out var OutFinishedGuideGroupIdList);
		OutFinishedGuideGroupIdList.ForEach(TriggerPlayerFinishGuideGroup);
	}

	private void OnTriggerConfirmGuideGroupEvent(int Id)
	{
		TriggerPlayerFinishGuideGroup(Id);
	}

	private void OnPostLoadingScreenOpen()
	{
		_playerGuideData.RevertCurrentProceedGuide();
	}

	private void OnFinishGuideGroup(int Id)
	{
		_playerGuideData.FinishedGroupGuideList.Add(Id);
	}

	private void TriggerPlayerFinishGuideGroup(int Id)
	{
		if (_playerGuideData.ProceedGroupGuideList.Remove(Id))
		{
			if (GSEUtil.Ensure(!_playerGuideData.FinishedGroupGuideList.Contains(Id)))
			{
				LogInfo($"完成了教学组：{Id}");
				_playerGuideData.FinishedGroupGuideList.Add(Id);
				EventReporter.GetInstance(Owner).Guide(new ReportEventGuide
				{
					GuideGroupId = (uint)Id,
					RoleId = _roleBaseData.RoleId
				});
				GetGameEventCollection().Evt_PlayerFinishGuideGroup.Invoke(Id);
			}
			_playerGuideData.PrintData("TriggerPlayerFinishGuideGroup");
		}
	}

	private void OnUnitCastSkillSuccess(AActor Owner, int SkillID)
	{
		OnTriggerGuideNodeFinishEvent_WithIntParam(EGuideNodeFinishType.CastSkill, SkillID);
	}

	private void SendMessage(string Message)
	{
		BGW_UIEventCollection.Get(Owner).Evt_UI_ShowTeamInfoMessage(Message, 3f);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private void LogInfo(string Info)
	{
	}
}
