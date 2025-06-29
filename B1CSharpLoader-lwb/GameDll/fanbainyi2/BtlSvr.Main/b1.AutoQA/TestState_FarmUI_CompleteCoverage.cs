using System;
using System.Collections.Generic;
using b1.BGW;
using b1.UI.Comm;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_FarmUI_CompleteCoverage : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		ExecGM,
		Memreport1,
		OpenUI,
		GetUIInfo,
		RandomSelect,
		Click,
		FocusLongPressBtn,
		GetAll,
		SeedInfo,
		End,
		Memreport2
	}

	private readonly int WatchTime;

	private bool IsDebug;

	private int TickCounter;

	private GSTileViewPanel CurrentTileView;

	private List<UObject> ObjectList;

	private int RandomCount;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_FarmUI_CompleteCoverage(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false)
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
				TransferState(InnerState.ExecGM);
			}
			break;
		}
		case InnerState.ExecGM:
			if (TickCounter == 1)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "UISetting.PlayerGuide 0", null);
				BGUFunctionLibraryManaged.RunScriptGM("AllSeeds IgnoreGmNotify", WorldContext);
			}
			else if (TickCounter == 2)
			{
				BGUFunctionLibraryManaged.RunScriptGM("PlantAllSeeds", WorldContext);
			}
			else if (TickCounter == 3)
			{
				BGUFunctionLibraryManaged.RunScriptGM("AddPlayerTime 9999", WorldContext);
			}
			else if (TickCounter > 5)
			{
				TransferState(InnerState.Memreport1);
			}
			break;
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PreFarmCompleteCoverage", null);
			}
			else if (TickCounter >= 15)
			{
				TransferState(InnerState.OpenUI);
			}
			break;
		case InnerState.OpenUI:
			if (TickCounter == 1)
			{
				BGUFunctionLibraryManaged.RunScriptGM("ActiveFarmUI", WorldContext);
			}
			else if (TickCounter == 3)
			{
				TransferState(InnerState.GetUIInfo);
			}
			break;
		case InnerState.GetUIInfo:
		{
			UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, UClass.GetClass<GSTileViewPanel>());
			FoundWidgets.Reverse();
			foreach (GSTileViewPanel item in FoundWidgets)
			{
				if (item.GetPathName().Contains("BUI_Farm"))
				{
					ObjectList = item.GetListItems();
					CurrentTileView = item;
					break;
				}
			}
			if (ObjectList == null || ObjectList.Count <= 0)
			{
				Description = "ObjectList == null || ObjectList.Count <= 0";
				return AutoTestNodeLib.NodeState.Failed;
			}
			TransferState(InnerState.RandomSelect);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.RandomSelect:
		{
			RandomCount++;
			if (RandomCount >= 10)
			{
				TransferState(InnerState.FocusLongPressBtn);
				break;
			}
			int randomNumberInt = UB1Util.GetRandomNumberInt(0, ObjectList.Count - 1);
			CurrentTileView.BP_NavigateToItem(ObjectList[randomNumberInt]);
			TransferState(InnerState.Click);
			break;
		}
		case InnerState.Click:
			if (TickCounter == 1)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIButton_Press", ETriggerEvent.Triggered);
			}
			else if (TickCounter == 2)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIButton_Release", ETriggerEvent.Triggered);
				TransferState(InnerState.RandomSelect);
			}
			break;
		case InnerState.FocusLongPressBtn:
		{
			UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Btn/BI_FarmLongPress.BI_FarmLongPress_C'", EUIResourceLoadType.NoCache);
			UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets2, uClass, TopLevelOnly: false);
			if (FoundWidgets2 == null || FoundWidgets2.Count <= 0)
			{
				Description = "BI_FarmLongPress == null || BI_FarmLongPress.Count <= 0";
				return AutoTestNodeLib.NodeState.Failed;
			}
			(FoundWidgets2[0] as BUI_Button)?.SetFocusOn();
			TransferState(InnerState.GetAll);
			break;
		}
		case InnerState.GetAll:
			if (TickCounter == 1)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIButton_Press", ETriggerEvent.Triggered);
			}
			else if (TickCounter == 10)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUIButton_Release", ETriggerEvent.Triggered);
				TransferState(InnerState.SeedInfo);
			}
			break;
		case InnerState.SeedInfo:
			if (TickCounter == 1)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUICompare", ETriggerEvent.Started);
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUICompare", ETriggerEvent.Completed);
			}
			else if (TickCounter == 10)
			{
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUICompare", ETriggerEvent.Started);
				AutoTestHelperLib.AutoTestInjectInputEvent(WorldContext, "IA_GSUICompare", ETriggerEvent.Completed);
				TransferState(InnerState.End);
			}
			break;
		case InnerState.End:
			if (TickCounter == 2)
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
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=PostFarmCompleteCoverage", null);
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
