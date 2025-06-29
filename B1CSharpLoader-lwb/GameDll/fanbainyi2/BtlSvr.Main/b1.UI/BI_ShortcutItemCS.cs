using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Plugins.GSInput;
using b1.UI.Comm;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ShortcutItemCS")]
public class BI_ShortcutItemCS : BI_ShortcutCommCS
{
	private List<UCanvasPanel> KeyboardConList = new List<UCanvasPanel>();

	public List<BI_ShortcutItemBaseCS> KeyboardItemList = new List<BI_ShortcutItemBaseCS>();

	public List<BI_ShortcutBaseCS> GamepadItemList = new List<BI_ShortcutBaseCS>();

	public List<BI_ShortcutNumCS> GamepadNumList = new List<BI_ShortcutNumCS>();

	private UImage ImgInputKB;

	private string LastAnimKeyState = "";

	private int LastSelectIdx;

	private int SelectIdx;

	private bool IsNext;

	private float ItemNudge = 92f;

	private bool IsNeedShow;

	private float NrToStDelayTime;

	private float NrToStEasingTime;

	private float StToNrDelayTime;

	private float StToNrEasingTime;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ItemNudge = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ShortcutItemNudge;
		NrToStDelayTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.NrToStDelayTime;
		NrToStEasingTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.NrToStEasingTime;
		StToNrDelayTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.StToNrDelayTime;
		StToNrEasingTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.StToNrEasingTime;
		ImgInputKB = FindChildWidget("InputIcon") as UImage;
		for (int i = 0; (float)i < MaxShortcutNum; i++)
		{
			UCanvasPanel uCanvasPanel = FindChildWidget($"SlotItem{i + 1}_KB") as UCanvasPanel;
			uCanvasPanel.SetRenderOpacity(0f);
			KeyboardConList.Add(uCanvasPanel);
			BI_ShortcutItemBaseCS item = FindChildWidget($"Item{i + 1}_KB") as BI_ShortcutItemBaseCS;
			KeyboardItemList.Add(item);
			BI_ShortcutBaseCS bI_ShortcutBaseCS = FindChildWidget($"Item{i + 1}_GP") as BI_ShortcutBaseCS;
			GamepadItemList.Add(bI_ShortcutBaseCS);
			BI_ShortcutNumCS bI_ShortcutNumCS = FindChildWidget($"Num{i + 1}_GP") as BI_ShortcutNumCS;
			bI_ShortcutBaseCS.Evt_SwitchState = (BUI_StateWidget.Del_SwitchState)Delegate.Combine(bI_ShortcutBaseCS.Evt_SwitchState, new BUI_StateWidget.Del_SwitchState(bI_ShortcutNumCS.SwitchState));
			bI_ShortcutBaseCS.Evt_SwitchDisable = (BUI_StateWidget.Del_SwitchDisable)Delegate.Combine(bI_ShortcutBaseCS.Evt_SwitchDisable, new BUI_StateWidget.Del_SwitchDisable(bI_ShortcutNumCS.SwitchState));
			GamepadNumList.Add(bI_ShortcutNumCS);
			bI_ShortcutBaseCS.SyncImgList.Add(FindChildWidget($"IAIcon{i + 1}_GP") as UImage);
			TxtNameDic.Add(bI_ShortcutBaseCS.CurPosIdx, FindChildWidget($"TxtName{i + 1}_GP") as UTextBlock);
		}
	}

	public void OnShowState(bool IsShow)
	{
		if (IsShow)
		{
			UpdateVisibility();
			return;
		}
		IsNeedShow = false;
		SetVisibility(ESlateVisibility.Collapsed);
	}

	public void UpdateItemDesc()
	{
		foreach (BI_ShortcutItemBaseCS keyboardItem in KeyboardItemList)
		{
			keyboardItem.UpdateContent();
		}
	}

	public void UpdateVisibility()
	{
		IsNeedShow = false;
		foreach (BI_ShortcutItemBaseCS keyboardItem in KeyboardItemList)
		{
			if (keyboardItem.GetShortcutDf().GetBaseID() != 0)
			{
				IsNeedShow = true;
				break;
			}
		}
		SetVisibility((!IsNeedShow) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	public void UpdateGrid(bool IsInit, int OldIdx, int NewIdx)
	{
		int num = CheckKeyboardConIdx(NewIdx - 1);
		int num2 = CheckKeyboardConIdx(NewIdx + 1);
		if (IsInit)
		{
			GSAnimKeyToState("GSAKBSwitchAnimPos", $"PosIdx{num}{NewIdx}", IsForce: true);
			KeyboardItemList[NewIdx].SwitchState(IsSelected: true, IsForce: true);
			KeyboardItemList[NewIdx].AddSyncImage(ImgInputKB);
			KeyboardItemList[NewIdx].UpdateSyncImage();
			return;
		}
		int count = KeyboardConList.Count;
		if (NewIdx == count - 1 && OldIdx == 0)
		{
			IsNext = false;
		}
		else if (NewIdx == 0 && OldIdx == count - 1)
		{
			IsNext = true;
		}
		else if (NewIdx > OldIdx)
		{
			IsNext = true;
		}
		else
		{
			IsNext = false;
		}
		if (IsInBlending("GSAKBSwitchAnimVisable"))
		{
			GSAnimKeyToState("GSAKBSwitchAnimVisable", LastAnimKeyState, IsForce: true);
		}
		if (IsInBlending("GSAKBSwitchAnimPos"))
		{
			GSAnimKeyToState("GSAKBSwitchAnimPos", LastAnimKeyState, IsForce: true);
			KeyboardItemList[LastSelectIdx].SwitchState(IsSelected: false, IsForce: true);
			KeyboardItemList[SelectIdx].SwitchState(IsSelected: true, IsForce: true);
			LastAnimKeyState = "";
		}
		if (NewIdx != OldIdx)
		{
			if (IsNext)
			{
				UGridSlot uGridSlot = KeyboardConList[num2].Slot as UGridSlot;
				if (num2 == 0 || num2 == 1)
				{
					uGridSlot.SetNudge(new FVector2D(ItemNudge * 3f, 0.0));
				}
				else
				{
					uGridSlot.SetNudge(new FVector2D(ItemNudge * 2f, 0.0));
				}
			}
			else
			{
				UGridSlot uGridSlot2 = KeyboardConList[num].Slot as UGridSlot;
				if (num == KeyboardConList.Count - 1 || num == KeyboardConList.Count - 2)
				{
					uGridSlot2.SetNudge(new FVector2D((0f - ItemNudge) * 3f, 0.0));
				}
				else
				{
					uGridSlot2.SetNudge(new FVector2D((0f - ItemNudge) * 2f, 0.0));
				}
			}
		}
		GSAnimKeyToState("GSAKBSwitchAnimVisable", $"PosIdx{OldIdx}{NewIdx}");
		GSAnimKeyToState("GSAKBSwitchAnimPos", $"PosIdx{OldIdx}{NewIdx}");
		KeyboardItemList[OldIdx].SwitchState(IsSelected: false, IsForce: false, StToNrDelayTime, StToNrEasingTime);
		KeyboardItemList[NewIdx].SwitchState(IsSelected: true, IsForce: false, NrToStDelayTime, NrToStEasingTime);
		LastAnimKeyState = $"PosIdx{OldIdx}{NewIdx}";
		LastSelectIdx = OldIdx;
		SelectIdx = NewIdx;
		KeyboardItemList[OldIdx].ClearSyncImage();
		KeyboardItemList[NewIdx].AddSyncImage(ImgInputKB);
		KeyboardItemList[NewIdx].UpdateSyncImage();
	}

	private int CheckKeyboardConIdx(int TargetIdx)
	{
		int count = KeyboardConList.Count;
		if (TargetIdx < 0)
		{
			TargetIdx += count;
		}
		else if (TargetIdx >= count)
		{
			TargetIdx -= count;
		}
		return TargetIdx;
	}

	public BI_ShortcutBaseCS GetShortcutByPosition(int Position, int DefaultPosition)
	{
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
		{
			return GamepadItemList[Position];
		}
		if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
		{
			if (DefaultPosition == Position)
			{
				return KeyboardItemList[Position].GetShortcutSt();
			}
			return KeyboardItemList[Position].GetShortcutDf();
		}
		return null;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_ShortcutItemCS");
	}

	static BI_ShortcutItemCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ShortcutItemCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ShortcutItemCS));
	}
}
