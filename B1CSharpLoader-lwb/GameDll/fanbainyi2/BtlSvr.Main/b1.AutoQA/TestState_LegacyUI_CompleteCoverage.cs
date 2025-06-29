using System;
using System.Collections.Generic;
using b1.BGW;
using b1.UI.Comm;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_LegacyUI_CompleteCoverage : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		GetAllLegacy,
		Memreport1,
		OpenShrineUI,
		OpenSecondMenu,
		OpenResetUI,
		OpenLegacyUI,
		SelectLegacyItem,
		EnterRight,
		LeaveRight,
		FocusTalent,
		LearnTalent,
		ResetTalent,
		End,
		Memreport2
	}

	private readonly int WatchTime;

	private bool IsDebug;

	private int TickCounter;

	private BUI_Button CurrentSelectLegacy;

	private InnerState CurrentState;

	private List<int>.Enumerator LegacyIndex = new List<int> { 1, 2, 3, 4, 5, 6 }.GetEnumerator();

	private bool IsLearn = true;

	private List<int>.Enumerator LegacyTalentIndex = new List<int> { 1, 2, 3 }.GetEnumerator();

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_LegacyUI_CompleteCoverage(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false)
	{
		base.WorldContext = WorldContext;
		WatchTime = InWatchTime;
		IsDebug = InIsDebug;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = CurrentState.ToString() + " " + TickCounter;
		switch (CurrentState)
		{
		case InnerState.WaitForPreload:
		{
			Description = "等待Preload完成中";
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
			if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.PreloadCountLeft() < 10)
			{
				Description = "预加载已经完成，可以开始测试";
				TransferState(InnerState.GetAllLegacy);
			}
			break;
		}
		case InnerState.GetAllLegacy:
			Description = "获取全根器: AllLegacy";
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "UISetting.PlayerGuide 0", null);
			BGUFunctionLibraryManaged.RunScriptGM("AllLegacy", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllLegacy", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllLegacy", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("additem 4097 3", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("DebugConfig.EnableShrineAllFunc 1", WorldContext);
			TransferState(InnerState.Memreport1);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.Memreport1:
			if (TickCounter == 5)
			{
				Description = "GC两次";
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
			}
			else if (TickCounter == 10)
			{
				Description = "导出PreMemreport";
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreLegacyCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
			{
				TransferState(InnerState.OpenShrineUI);
				return AutoTestNodeLib.NodeState.Running;
			}
			break;
		case InnerState.OpenShrineUI:
			if (TickCounter == 2)
			{
				BGUFunctionLibraryManaged.RunScriptGM("ActiveShrineUI", WorldContext);
			}
			else if (TickCounter >= 5)
			{
				TransferState(InnerState.OpenSecondMenu);
			}
			break;
		case InnerState.OpenSecondMenu:
			if (TickCounter == 2 || TickCounter == 3)
			{
				BUI_Menu bUI_Menu3 = null;
				UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets4, UClass.GetClass<BUI_Menu>());
				foreach (BUI_Menu item in FoundWidgets4)
				{
					if (item.GetPathName().Contains("BI_ShrineFirMenu"))
					{
						bUI_Menu3 = item;
						break;
					}
				}
				if (bUI_Menu3 == null)
				{
					Description = "无法找到BI_ShrineFirMenu";
					return AutoTestNodeLib.NodeState.Failed;
				}
				BUI_Button bUI_Button2 = bUI_Menu3.TryGetChild(1);
				if (TickCounter == 2)
				{
					bUI_Button2?.SetFocusOn();
				}
				else if (TickCounter == 3)
				{
					bUI_Button2?.TriggerGSClicked();
				}
			}
			else if (TickCounter >= 5)
			{
				TransferState(InnerState.OpenResetUI);
			}
			break;
		case InnerState.OpenResetUI:
			if (TickCounter == 2 || TickCounter == 3)
			{
				BUI_Menu bUI_Menu = null;
				UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets2, UClass.GetClass<BUI_Menu>());
				foreach (BUI_Menu item2 in FoundWidgets2)
				{
					if (item2.GetPathName().Contains("BI_ShrineSecMenu"))
					{
						bUI_Menu = item2;
						break;
					}
				}
				if (bUI_Menu == null)
				{
					Description = "无法找到BI_ShrineSecMenu";
					return AutoTestNodeLib.NodeState.Failed;
				}
				BUI_Button bUI_Button = bUI_Menu.TryGetChild(1);
				if (TickCounter == 2)
				{
					bUI_Button?.SetFocusOn();
				}
				else if (TickCounter == 3)
				{
					bUI_Button?.TriggerGSClicked();
				}
			}
			else if (TickCounter >= 5)
			{
				TransferState(InnerState.OpenLegacyUI);
			}
			break;
		case InnerState.OpenLegacyUI:
			if (TickCounter == 2)
			{
				UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets5, "根器");
				if (FoundWidgets5.Count <= 0)
				{
					Description = "无法找到根器按钮!";
					return AutoTestNodeLib.NodeState.Failed;
				}
				AutoTestHelperLib.ClickButton(FoundWidgets5[0]);
			}
			else if (TickCounter >= 5)
			{
				TransferState(InnerState.SelectLegacyItem);
			}
			break;
		case InnerState.SelectLegacyItem:
			if (TickCounter < WatchTime)
			{
				Description = "等待页面刷新中";
				break;
			}
			if (LegacyIndex.MoveNext())
			{
				UClass uClass2 = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Genqi/BI_GenqiBtnV2.BI_GenqiBtnV2_C'", EUIResourceLoadType.NoCache);
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets3, uClass2, TopLevelOnly: false);
				foreach (UUserWidget item3 in FoundWidgets3)
				{
					if (item3.GetName() == "BI_GenqiBtn_" + LegacyIndex.Current)
					{
						CurrentSelectLegacy = item3 as BUI_Button;
						if (CurrentSelectLegacy.IsNullOrDestroyed())
						{
							return AutoTestNodeLib.NodeState.Failed;
						}
						CurrentSelectLegacy?.SetFocusOn();
						Description = "Focus根器" + LegacyIndex.Current;
						TransferState(InnerState.EnterRight);
						return AutoTestNodeLib.NodeState.Running;
					}
				}
				return AutoTestNodeLib.NodeState.Failed;
			}
			if (IsLearn)
			{
				IsLearn = false;
				LegacyIndex = new List<int> { 1, 2, 3, 4, 5, 6 }.GetEnumerator();
				TransferState(InnerState.SelectLegacyItem);
				return AutoTestNodeLib.NodeState.Running;
			}
			TransferState(InnerState.End);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.EnterRight:
			if (TickCounter == 1)
			{
				CurrentSelectLegacy?.TriggerGSClicked();
			}
			else if (TickCounter > 2)
			{
				LegacyTalentIndex = new List<int> { 0, 1, 2 }.GetEnumerator();
				TransferState(InnerState.FocusTalent);
			}
			break;
		case InnerState.LeaveRight:
			if (TickCounter == 1)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIBack", ETriggerEvent.Started);
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIBack", ETriggerEvent.Completed);
			}
			else if (TickCounter > 2)
			{
				TransferState(InnerState.SelectLegacyItem);
			}
			break;
		case InnerState.FocusTalent:
			if (LegacyTalentIndex.MoveNext())
			{
				UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Genqi/BI_GenqiDecs.BI_GenqiDecs_C'", EUIResourceLoadType.NoCache);
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, uClass, TopLevelOnly: false);
				(FoundWidgets[LegacyTalentIndex.Current] as BUI_Button)?.SetFocusOn();
				if (IsLearn)
				{
					TransferState(InnerState.LearnTalent);
				}
				else
				{
					TransferState(InnerState.ResetTalent);
				}
				break;
			}
			TransferState(InnerState.LeaveRight);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.LearnTalent:
			if (TickCounter == 1)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIButton_Press", ETriggerEvent.Triggered);
			}
			else if (TickCounter == 10)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIButton_Release", ETriggerEvent.Triggered);
				TransferState(InnerState.FocusTalent);
			}
			break;
		case InnerState.ResetTalent:
			AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIReset", ETriggerEvent.Started);
			AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIReset", ETriggerEvent.Completed);
			TransferState(InnerState.FocusTalent);
			break;
		case InnerState.End:
			if (TickCounter == 2)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIBack", ETriggerEvent.Started);
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIBack", ETriggerEvent.Completed);
			}
			else if (TickCounter == 4)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIBack", ETriggerEvent.Started);
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIBack", ETriggerEvent.Completed);
			}
			else if (TickCounter > 5)
			{
				TransferState(InnerState.Memreport2);
			}
			break;
		case InnerState.Memreport2:
			if (TickCounter == 5)
			{
				Description = "GC两次";
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
			}
			else if (TickCounter == 10)
			{
				Description = "导出PostMemreport";
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PostLegacyCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
			{
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			break;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
