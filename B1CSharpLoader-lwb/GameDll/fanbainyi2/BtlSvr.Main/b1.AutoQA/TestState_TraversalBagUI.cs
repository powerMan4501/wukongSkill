using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_TraversalBagUI : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		GetAllEquip,
		OpenBag,
		SwitchToPiGua,
		SelectEquipSlot,
		GetEquipNumInfo,
		TryEveryEquip,
		GoBackToPiGua
	}

	private readonly int WatchTime;

	private int TickCounter;

	private bool IsDebug;

	private bool IsChangeBagState;

	private InnerState CurrentState;

	private List<int>.Enumerator EquipTypes = new List<int> { 0, 1, 2, 3, 4 }.GetEnumerator();

	private int ItemSize;

	private int CurrentItemIndex;

	private GSTileViewPanel CurrentTileView;

	private List<UObject> ObjectList;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_TraversalBagUI(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false, bool InIsChangeBagState = true)
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
				TransferState(InnerState.GetAllEquip);
			}
			break;
		}
		case InnerState.GetAllEquip:
			Description = "获取全物品: AllEquip IgnoreGmNotify";
			BGUFunctionLibraryManaged.RunScriptGM("AllItem IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllAttrItem IgnoreGmNotify", WorldContext);
			TransferState(InnerState.OpenBag);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.OpenBag:
			Description = "打开包裹";
			if (IsChangeBagState)
			{
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: true);
			}
			TransferState(InnerState.SwitchToPiGua);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.SwitchToPiGua:
		{
			if (TickCounter < 5)
			{
				Description = "观看包裹界面中";
				break;
			}
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets3, "行囊");
			if (FoundWidgets3.Count == 1)
			{
				using (List<UWidget>.Enumerator enumerator = FoundWidgets3.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
					}
				}
				Description = "点击进入行囊界面";
				TransferState(InnerState.SelectEquipSlot);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "已经在行囊界面中了";
			TransferState(InnerState.SelectEquipSlot);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.SelectEquipSlot:
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			if (EquipTypes.MoveNext())
			{
				UClass uClass = BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Tab/BI_CommIconTab.BI_CommIconTab_C'", EUIResourceLoadType.NoCache);
				UWidgetLibrary.GetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets2, uClass, TopLevelOnly: false);
				int num = 0;
				foreach (UUserWidget item in FoundWidgets2)
				{
					if (item.GetPathName().Contains("BUI_BagMain") && item.GetName().Contains("BI_CommIconTab_C_"))
					{
						num++;
						if (num == EquipTypes.Current + 1)
						{
							AutoTestHelperLib.ClickButton(item);
							Description = "进入了物品页" + EquipTypes.Current;
							TransferState(InnerState.GetEquipNumInfo);
							return AutoTestNodeLib.NodeState.Running;
						}
					}
				}
				Description = "无法进入物品详情页" + EquipTypes.Current;
				return AutoTestNodeLib.NodeState.Failed;
			}
			Description = "已经查看了全部的物品详情页";
			if (IsChangeBagState)
			{
				AutoTestHelperLib.OpenBag(WorldContext, IsOpen: false);
			}
			return AutoTestNodeLib.NodeState.Succeeded;
		case InnerState.GetEquipNumInfo:
		{
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			CurrentItemIndex = -1;
			UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets, UClass.GetClass<GSTileViewPanel>());
			FoundWidgets.Reverse();
			foreach (GSTileViewPanel item2 in FoundWidgets)
			{
				if (item2.GetPathName().Contains("BUI_BagMain"))
				{
					ObjectList = item2.GetListItems();
					ItemSize = ObjectList.Count;
					if (IsDebug && ItemSize > 5)
					{
						ItemSize = 5;
					}
					CurrentTileView = item2;
					break;
				}
			}
			Description = "物品信息统计完成，继续向下";
			TransferState(InnerState.TryEveryEquip);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.TryEveryEquip:
			if (CurrentItemIndex != -1 && TickCounter < WatchTime)
			{
				Description = "观看物品中：" + ObjectList[CurrentItemIndex].GetName();
				break;
			}
			CurrentItemIndex++;
			if (CurrentItemIndex < ItemSize)
			{
				CurrentTileView.BP_NavigateToItem(ObjectList[CurrentItemIndex]);
				Description = "切换到物品：" + ObjectList[CurrentItemIndex].GetName();
				TransferState(InnerState.TryEveryEquip);
			}
			else
			{
				Description = "已经是最后一个物品了";
				TransferState(InnerState.GoBackToPiGua);
			}
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.GoBackToPiGua:
			Description = "返回包裹主页面";
			TransferState(InnerState.SelectEquipSlot);
			return AutoTestNodeLib.NodeState.Running;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}
}
