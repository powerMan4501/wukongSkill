using System.Collections.Generic;
using b1.BGW;
using b1.UI.Comm;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_TraversalTravelNotesUI : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		GetAllTravelNotes,
		OpenBag,
		SwitchToNotes,
		SelectNotesType,
		ClickSubTab_Monster,
		WaitRefresh_Monster,
		FocusItem_Monster,
		ClickSubTab_Medition,
		WaitRefresh_Medition,
		FocusItem_Medition,
		ClickSubTab_Echo,
		WaitRefresh_Echo,
		FocusItem_Echo,
		PlayEcho,
		End
	}

	private readonly int WatchTime;

	private int TickCounter;

	private bool IsDebug;

	private bool IsChangeBagState;

	private int CurrentListBarIndex;

	private int ChildBtnSize;

	private int CurrentChildBtnIndex = -1;

	private List<UUserWidget> AccordionChildBtnList;

	private InnerState CurrentState;

	private List<int>.Enumerator NotesType = new List<int> { 0, 1 }.GetEnumerator();

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_TraversalTravelNotesUI(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false, bool InIsChangeBagState = true)
	{
		base.WorldContext = WorldContext;
		WatchTime = InWatchTime;
		IsDebug = InIsDebug;
		IsChangeBagState = InIsChangeBagState;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "";
		switch (CurrentState)
		{
		case InnerState.WaitForPreload:
		{
			Description = "等待Preload完成中";
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
			if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.PreloadCountLeft() < 10)
			{
				Description = "预加载已经完成，可以开始测试";
				TransferState(InnerState.GetAllTravelNotes);
			}
			break;
		}
		case InnerState.GetAllTravelNotes:
			Description = "获取全游记";
			BGUFunctionLibraryManaged.RunScriptGM("AllCard 1 IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("UnlockMeditation IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllEcho IgnoreGmNotify", WorldContext);
			TransferState(InnerState.OpenBag);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.OpenBag:
			Description = "打开包裹";
			if (IsChangeBagState)
			{
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
			}
			TransferState(InnerState.SwitchToNotes);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.SwitchToNotes:
		{
			if (TickCounter < 5)
			{
				Description = "观看包裹界面中";
				break;
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets6, "游记");
			if (FoundWidgets6.Count == 1)
			{
				using (List<UWidget>.Enumerator enumerator2 = FoundWidgets6.GetEnumerator())
				{
					if (enumerator2.MoveNext())
					{
						AutoTestHelperLib.ClickButton((UTextBlock)enumerator2.Current);
					}
				}
				Description = "点击进入游记界面";
				TransferState(InnerState.SelectNotesType);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "已经在游记界面中了";
			TransferState(InnerState.SelectNotesType);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.SelectNotesType:
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			if (NotesType.MoveNext())
			{
				UClass uClass5 = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/TravelNotes/BI_TravelNotesMain_Tab.BI_TravelNotesMain_Tab_C'", EUIResourceLoadType.NoCache);
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets4, uClass5, TopLevelOnly: false);
				foreach (UUserWidget item in FoundWidgets4)
				{
					if (item.GetName() == "BI_TravelNotesMain_Tab_" + NotesType.Current)
					{
						AutoTestHelperLib.ClickButton(item);
						Description = "进入了游记类型" + NotesType.Current;
						CurrentListBarIndex = -1;
						if (NotesType.Current == 0)
						{
							TransferState(InnerState.ClickSubTab_Monster);
						}
						else if (NotesType.Current == 1)
						{
							TransferState(InnerState.ClickSubTab_Medition);
						}
						else if (NotesType.Current == 2)
						{
							TransferState(InnerState.ClickSubTab_Echo);
						}
						return AutoTestNodeLib.NodeState.Running;
					}
				}
			}
			else
			{
				Description = "已经查看了全部的游记";
				UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets5, "披挂");
				if (FoundWidgets5.Count == 1)
				{
					using (List<UWidget>.Enumerator enumerator2 = FoundWidgets5.GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							AutoTestHelperLib.ClickButton((UTextBlock)enumerator2.Current);
						}
					}
					Description += " 点击进入披挂界面";
					TransferState(InnerState.End);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			Description = "无法进入游记详情页" + NotesType.Current;
			return AutoTestNodeLib.NodeState.Failed;
		case InnerState.ClickSubTab_Monster:
		{
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			CurrentListBarIndex++;
			UClass uClass4 = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/TravelNotes/BI_TravelNotesMain_ListBar.BI_TravelNotesMain_ListBar_C'", EUIResourceLoadType.NoCache);
			UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets3, uClass4, TopLevelOnly: false);
			foreach (UUserWidget item2 in FoundWidgets3)
			{
				if (item2.GetName() == "BI_TravelNotesMain_ListBar_" + CurrentListBarIndex)
				{
					if (item2.GetVisibility() == ESlateVisibility.Collapsed)
					{
						Description = "怪物图鉴查看完毕";
						TransferState(InnerState.SelectNotesType);
						return AutoTestNodeLib.NodeState.Running;
					}
					AutoTestHelperLib.ClickButton(item2);
					Description = "进入了怪物图鉴" + CurrentListBarIndex;
					TransferState(InnerState.WaitRefresh_Monster);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			break;
		}
		case InnerState.WaitRefresh_Monster:
		{
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			Description = "进入了怪物图鉴" + CurrentListBarIndex;
			UClass uClass2 = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/AccordionView/BI_AccordionChildBtn_A.BI_AccordionChildBtn_A_C'", EUIResourceLoadType.NoCache);
			CurrentChildBtnIndex = -1;
			AccordionChildBtnList = null;
			UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out AccordionChildBtnList, uClass2, TopLevelOnly: false);
			if (AccordionChildBtnList != null && AccordionChildBtnList.Count > 0)
			{
				AccordionChildBtnList.RemoveAt(0);
			}
			List<UUserWidget> list = new List<UUserWidget>();
			foreach (UUserWidget accordionChildBtn in AccordionChildBtnList)
			{
				if (accordionChildBtn.GetVisibility() != ESlateVisibility.Collapsed && accordionChildBtn.GetVisibility() != ESlateVisibility.Hidden)
				{
					list.Add(accordionChildBtn);
				}
			}
			AccordionChildBtnList = list;
			ChildBtnSize = AccordionChildBtnList?.Count ?? (-1);
			if (IsDebug && ChildBtnSize > 5)
			{
				ChildBtnSize = 5;
			}
			TransferState(InnerState.FocusItem_Monster);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.FocusItem_Monster:
			if (CurrentChildBtnIndex != -1 && TickCounter < WatchTime)
			{
				Description = "观看图鉴中：" + CurrentChildBtnIndex;
				break;
			}
			CurrentChildBtnIndex++;
			if (CurrentChildBtnIndex < ChildBtnSize)
			{
				(AccordionChildBtnList[CurrentChildBtnIndex] as BUI_Button)?.SetFocusOn();
				Description = "观看图鉴:" + AccordionChildBtnList[CurrentChildBtnIndex].GetName();
				TransferState(InnerState.FocusItem_Monster);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "当前图鉴已看完" + CurrentListBarIndex;
			AutoTestHelperLib.MouseGoBack(WorldContext);
			TransferState(InnerState.ClickSubTab_Monster);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.ClickSubTab_Medition:
		{
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			CurrentListBarIndex++;
			UClass uClass3 = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/TravelNotes/BI_TravelNotesMain_ListBar.BI_TravelNotesMain_ListBar_C'", EUIResourceLoadType.NoCache);
			UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets2, uClass3, TopLevelOnly: false);
			foreach (UUserWidget item3 in FoundWidgets2)
			{
				if (item3.GetName() == "BI_TravelNotesMain_ListBar_" + CurrentListBarIndex)
				{
					if (item3.GetVisibility() == ESlateVisibility.Collapsed)
					{
						Description = "打坐点查看完毕";
						TransferState(InnerState.SelectNotesType);
						return AutoTestNodeLib.NodeState.Running;
					}
					AutoTestHelperLib.ClickButton(item3);
					Description = "进入了打坐点" + CurrentListBarIndex;
					TransferState(InnerState.WaitRefresh_Medition);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			break;
		}
		case InnerState.WaitRefresh_Medition:
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			Description = "进入了打坐点" + CurrentListBarIndex;
			TransferState(InnerState.FocusItem_Medition);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.FocusItem_Medition:
			Description = "FocusItem_Medition " + CurrentListBarIndex;
			AutoTestHelperLib.MouseGoBack(WorldContext);
			TransferState(InnerState.ClickSubTab_Medition);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.ClickSubTab_Echo:
		{
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			CurrentListBarIndex++;
			UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/TravelNotes/BI_TravelNotesMain_ListBar.BI_TravelNotesMain_ListBar_C'", EUIResourceLoadType.NoCache);
			UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, uClass, TopLevelOnly: false);
			foreach (UUserWidget item4 in FoundWidgets)
			{
				if (item4.GetName() == "BI_TravelNotesMain_ListBar_" + CurrentListBarIndex)
				{
					if (item4.GetVisibility() == ESlateVisibility.Collapsed)
					{
						Description = "回声查看完毕";
						TransferState(InnerState.SelectNotesType);
						return AutoTestNodeLib.NodeState.Running;
					}
					AutoTestHelperLib.ClickButton(item4);
					Description = "进入了回声" + CurrentListBarIndex;
					TransferState(InnerState.WaitRefresh_Echo);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			break;
		}
		case InnerState.WaitRefresh_Echo:
		{
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			Description = "进入了回声" + CurrentListBarIndex;
			UClass uClass6 = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/AccordionView/BI_AccordionChildBtn_Echo.BI_AccordionChildBtn_Echo_C'", EUIResourceLoadType.NoCache);
			CurrentChildBtnIndex = -1;
			AccordionChildBtnList = null;
			UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out AccordionChildBtnList, uClass6, TopLevelOnly: false);
			if (AccordionChildBtnList != null && AccordionChildBtnList.Count > 0)
			{
				AccordionChildBtnList.RemoveAt(0);
			}
			List<UUserWidget> list2 = new List<UUserWidget>();
			foreach (UUserWidget accordionChildBtn2 in AccordionChildBtnList)
			{
				if (accordionChildBtn2.GetVisibility() != ESlateVisibility.Collapsed && accordionChildBtn2.GetVisibility() != ESlateVisibility.Hidden)
				{
					list2.Add(accordionChildBtn2);
				}
			}
			AccordionChildBtnList = list2;
			ChildBtnSize = AccordionChildBtnList?.Count ?? (-1);
			if (IsDebug && ChildBtnSize > 5)
			{
				ChildBtnSize = 5;
			}
			TransferState(InnerState.FocusItem_Echo);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.FocusItem_Echo:
			CurrentChildBtnIndex++;
			if (CurrentChildBtnIndex < ChildBtnSize)
			{
				(AccordionChildBtnList[CurrentChildBtnIndex] as BUI_Button)?.SetFocusOn();
				Description = "观看回声:" + AccordionChildBtnList[CurrentChildBtnIndex].GetName();
				TransferState(InnerState.PlayEcho);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "当前回声已看完" + CurrentListBarIndex;
			AutoTestHelperLib.MouseGoBack(WorldContext);
			TransferState(InnerState.ClickSubTab_Echo);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.PlayEcho:
			if (TickCounter == 0)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_T);
				Description = "播放回声：" + CurrentChildBtnIndex;
				break;
			}
			if (TickCounter < WatchTime)
			{
				Description = "正在播放回声：" + CurrentChildBtnIndex;
				break;
			}
			Description = "当前回声播放结束" + CurrentChildBtnIndex;
			TransferState(InnerState.FocusItem_Echo);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.End:
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			if (IsChangeBagState)
			{
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: false);
			}
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
