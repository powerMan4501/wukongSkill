using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.AutoQA;

public class TestState_TraversalEquipmentUI : AutoTestNodeLib.TestState_Node
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
		ResetWearEquip,
		GetEquipNumInfo_Weapon,
		TryEveryEquip_Weapon,
		ResetWearWeapon,
		GoBackToPiGua
	}

	private readonly int WatchTime;

	private int TickCounter;

	private bool IsDebug;

	private bool IsChangeBagState;

	private InnerState CurrentState;

	private List<int>.Enumerator EquipTypes = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.GetEnumerator();

	private int EquipSize;

	private int CurrentEquipIndex;

	private GSTileViewPanel CurrentTileView;

	private List<UObject> ObjectList;

	private GSAutoSizeScrollBox WeaponScrollBox;

	private bool Roll;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_TraversalEquipmentUI(UObject WorldContext, int InWatchTime = 5, bool InIsDebug = false, bool InIsChangeBagState = true)
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
			Description = "获取全装备: AllEquip IgnoreGmNotify";
			BGUFunctionLibraryManaged.RunScriptGM("AllEquip IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllHulu IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllWeapon IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AddItem 1997 IgnoreGmNotify", WorldContext);
			BGUFunctionLibraryManaged.RunScriptGM("AllSoulSkill IgnoreGmNotify", WorldContext);
			USystemLibrary.ExecuteConsoleCommand(WorldContext, "UISetting.PlayerGuide 0", null);
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
			UGSE_UMGFuncLib.QAGetWidgetWithText(WorldContext, out var FoundWidgets, "披挂");
			if (FoundWidgets.Count == 1)
			{
				using (List<UWidget>.Enumerator enumerator = FoundWidgets.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						AutoTestHelperLib.ClickButton((UTextBlock)enumerator.Current);
					}
				}
				Description = "点击进入披挂界面";
				TransferState(InnerState.SelectEquipSlot);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "已经在披挂界面中了";
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
				UClass uClass = null;
				UWidgetLibrary.GetAllWidgetsOfClass(WidgetClass: (EquipTypes.Current == 7) ? BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Remake_CE04/Remake_Item/BI_EquipItem_RZDSlot.BI_EquipItem_RZDSlot_C'", EUIResourceLoadType.NoCache) : ((EquipTypes.Current >= 7) ? BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Remake_CE04/Remake_Item/BI_GearItem_Slot.BI_GearItem_Slot_C'", EUIResourceLoadType.NoCache) : BGW_PreloadAssetMgr.Get(WorldContext).RequestSyncLoadForUIResource<UClass>("WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Remake_CE04/Remake_Item/BI_EquipItem_Slot.BI_EquipItem_Slot_C'", EUIResourceLoadType.NoCache)), WorldContextObject: UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), FoundWidgets: out var FoundWidgets4, TopLevelOnly: false);
				foreach (UUserWidget item in FoundWidgets4)
				{
					if (item.GetName() == "BI_EquipSlotItem_" + EquipTypes.Current)
					{
						AutoTestHelperLib.ClickButton(item);
						Description = "进入了装备详情页" + EquipTypes.Current;
						if (EquipTypes.Current == 5)
						{
							TransferState(InnerState.GetEquipNumInfo_Weapon);
						}
						else
						{
							TransferState(InnerState.GetEquipNumInfo);
						}
						return AutoTestNodeLib.NodeState.Running;
					}
				}
				Description = "无法进入装备详情页" + EquipTypes.Current;
				return AutoTestNodeLib.NodeState.Failed;
			}
			Description = "已经查看了全部的装备详情页";
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
			CurrentEquipIndex = -1;
			Roll = false;
			UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets2, UClass.GetClass<GSTileViewPanel>());
			FoundWidgets2.Reverse();
			foreach (GSTileViewPanel item2 in FoundWidgets2)
			{
				if (item2.GetPathName().Contains("BUI_EquipMain"))
				{
					ObjectList = item2.GetListItems();
					EquipSize = ObjectList.Count;
					if (IsDebug && EquipSize > 5)
					{
						EquipSize = 5;
					}
					CurrentTileView = item2;
					break;
				}
			}
			Description = "装备信息统计完成，继续向下";
			TransferState(InnerState.TryEveryEquip);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.TryEveryEquip:
			if (CurrentEquipIndex != -1 && TickCounter < WatchTime)
			{
				Description = "观看装备中：" + ObjectList[CurrentEquipIndex].GetName();
				break;
			}
			if (!Roll)
			{
				CurrentEquipIndex++;
			}
			if (CurrentEquipIndex < EquipSize)
			{
				if (Roll)
				{
					QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_E);
					Description = "穿戴装备：" + ObjectList[CurrentEquipIndex].GetName();
					Roll = false;
					TransferState(InnerState.TryEveryEquip);
				}
				else
				{
					CurrentTileView.BP_NavigateToItem(ObjectList[CurrentEquipIndex]);
					Description = "切换到装备：" + ObjectList[CurrentEquipIndex].GetName();
					Roll = true;
					TransferState(InnerState.TryEveryEquip);
				}
			}
			else
			{
				Description = "已经是最后一件装备了";
				TransferState(InnerState.ResetWearEquip);
			}
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.ResetWearEquip:
		{
			Description = "重置穿戴装备中";
			int index = 0;
			if (EquipTypes.Current == 6)
			{
				index = 1;
			}
			else if (EquipTypes.Current == 7)
			{
				index = ObjectList.Count - 1;
			}
			else if (EquipTypes.Current == 8)
			{
				index = 4;
			}
			else if (EquipTypes.Current == 9)
			{
				index = ObjectList.Count - 8;
			}
			if (TickCounter == 2)
			{
				CurrentTileView.BP_NavigateToItem(ObjectList[index]);
				Description = "切换到装备1：" + ObjectList[index].GetName();
			}
			else if (TickCounter == 3)
			{
				CurrentTileView.BP_NavigateToItem(ObjectList[index]);
				Description = "切换到装备2：" + ObjectList[index].GetName();
			}
			else if (TickCounter == 5)
			{
				CurrentTileView.BP_NavigateToItem(ObjectList[index]);
				Description = "切换到装备3：" + ObjectList[index].GetName();
			}
			else if (TickCounter == 7)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_E);
				Description = "穿戴重置装备1";
			}
			else if (TickCounter == 9)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_E);
				Description = "穿戴重置装备2";
			}
			else if (TickCounter == 120)
			{
				Description = "重置完毕";
				TransferState(InnerState.GoBackToPiGua);
			}
			break;
		}
		case InnerState.GetEquipNumInfo_Weapon:
		{
			if (TickCounter < 5)
			{
				Description = "等待页面刷新中";
				break;
			}
			CurrentEquipIndex = -1;
			Roll = false;
			UGSE_UMGFuncLib.QAGetAllWidgetsOfClass(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), out var FoundWidgets3, UClass.GetClass<GSAutoSizeScrollBox>());
			foreach (GSAutoSizeScrollBox item3 in FoundWidgets3)
			{
				if (item3.GetPathName().Contains("BUI_WeaponBuild") && item3.GetPathName().Contains("WeaponScroll"))
				{
					WeaponScrollBox = item3;
					break;
				}
			}
			Description = "武器信息统计完成，继续向下";
			TransferState(InnerState.TryEveryEquip_Weapon);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.TryEveryEquip_Weapon:
			if (CurrentEquipIndex != -1 && TickCounter < WatchTime)
			{
				Description = "观看武器中：" + CurrentEquipIndex;
				break;
			}
			if (WeaponScrollBox.GetSelectedIdx() >= CurrentEquipIndex)
			{
				if (Roll)
				{
					QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_E);
					Description = "穿戴武器：" + CurrentEquipIndex;
					Roll = false;
					TransferState(InnerState.TryEveryEquip_Weapon);
				}
				else
				{
					CurrentEquipIndex++;
					WeaponScrollBox.ScrollToIdx(CurrentEquipIndex, Force: true);
					Description = "切换到武器：" + CurrentEquipIndex;
					Roll = true;
					TransferState(InnerState.TryEveryEquip_Weapon);
				}
			}
			else
			{
				Description = "已经是最后一件装备了";
				TransferState(InnerState.ResetWearWeapon);
			}
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.ResetWearWeapon:
			Description = "重置穿戴武器中";
			if (TickCounter == 2)
			{
				WeaponScrollBox.ScrollToIdx(0, Force: true);
				Description = "切换到武器：0";
			}
			else if (TickCounter == 7)
			{
				QASimulateWindowsOperations.KeyPress(QASimulateWindowsOperations.KeyCode.KEY_E);
				Description = "穿戴武器：0";
			}
			else if (TickCounter == 12)
			{
				Description = "重置完毕";
				TransferState(InnerState.GoBackToPiGua);
			}
			break;
		case InnerState.GoBackToPiGua:
			Description = "返回包裹主页面";
			AutoTestHelperLib.MouseGoBack(WorldContext);
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
