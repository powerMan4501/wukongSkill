using System.Collections.Generic;
using b1.BGW;
using b1.UI.Comm;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_TraversalLegacyUI : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		GetAllLegacy,
		OpenBag,
		SwitchToLegacyUI,
		SelectLegacyItem,
		End
	}

	private readonly int WatchTime;

	private int TickCounter;

	private bool IsDebug;

	private bool IsChangeBagState;

	private InnerState CurrentState;

	private List<int>.Enumerator LegacyIndex = new List<int> { 1, 2, 3, 4, 5, 6 }.GetEnumerator();

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_TraversalLegacyUI(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false, bool InIsChangeBagState = true)
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
				TransferState(InnerState.GetAllLegacy);
			}
			break;
		}
		case InnerState.GetAllLegacy:
			Description = "获取全根器: AllLegacy";
			BGUFunctionLibraryManaged.RunScriptGM("AllLegacy", WorldContext);
			TransferState(InnerState.OpenBag);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.OpenBag:
			Description = "打开包裹";
			if (IsChangeBagState)
			{
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
			}
			TransferState(InnerState.SwitchToLegacyUI);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.SwitchToLegacyUI:
		{
			if (TickCounter < 5)
			{
				Description = "观看包裹界面中";
				break;
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets, "根器");
			if (FoundWidgets.Count == 1)
			{
				using (List<UWidget>.Enumerator enumerator = FoundWidgets.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
					}
				}
				Description = "点击进入根器界面";
				TransferState(InnerState.SelectLegacyItem);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "已经在根器界面中了";
			TransferState(InnerState.SelectLegacyItem);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.SelectLegacyItem:
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			if (LegacyIndex.MoveNext())
			{
				UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Genqi/BI_GenqiBtnV2.BI_GenqiBtnV2_C'", EUIResourceLoadType.NoCache);
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets2, uClass, TopLevelOnly: false);
				foreach (UUserWidget item in FoundWidgets2)
				{
					if (item.GetName() == "BI_GenqiBtn_" + LegacyIndex.Current)
					{
						(item as BUI_Button)?.SetFocusOn();
						Description = "Focus根器" + LegacyIndex.Current;
						TransferState(InnerState.SelectLegacyItem);
						return AutoTestNodeLib.NodeState.Running;
					}
				}
			}
			else
			{
				Description = "已经查看了全部的根器";
				UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets3, "披挂");
				if (FoundWidgets3.Count == 1)
				{
					using (List<UWidget>.Enumerator enumerator = FoundWidgets3.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
						}
					}
					Description += " 点击进入披挂界面";
					TransferState(InnerState.End);
					return AutoTestNodeLib.NodeState.Running;
				}
			}
			Description = "无法进入物品详情页" + LegacyIndex.Current;
			return AutoTestNodeLib.NodeState.Failed;
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
