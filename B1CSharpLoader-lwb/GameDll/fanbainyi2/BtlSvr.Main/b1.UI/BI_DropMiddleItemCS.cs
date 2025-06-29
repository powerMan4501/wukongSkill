using System;
using System.Collections.Generic;
using b1.BGW;
using b1.GSMUI.Core;
using b1.Localization;
using B1UI.GSUI;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropMiddleItemCS")]
public class BI_DropMiddleItemCS : BI_DropAdvanceCS
{
	private BGW_UIMgr UIMgr;

	private BI_DropManualCS DropManualItem;

	private UImage ImgBar;

	private UMaterialInstanceDynamic MIBar;

	private UMaterialInstanceDynamic MISweep;

	private UTextBlock TxtName;

	private UOverlay NumResizeRoot;

	private UTextBlock TxtNum;

	private UTextBlock TxtDesc;

	private UTextBlock TxtOverflow;

	private UWidget ActionCon;

	private List<FItemWithTag> ItemDataList = new List<FItemWithTag>();

	private ItemOne CurItemData;

	private Action<int, GainPerformanceType> Evt_DropItemFill;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ShowType = DropAdvanceType.MiddleItem;
		UIMgr = BGW_UIMgr.Get(this);
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		ShowTime = uIConfigDataAsset.DropAdvanceShowTime;
		MinShowTime = uIConfigDataAsset.DropAdvanceMinShowTime;
		ShowTimeCheck = ShowTime;
		FindChildWidget("RootCon")?.SetRenderOpacity(0f);
		ImgBar = FindChildWidget("ImgBar") as UImage;
		MIBar = ImgBar.GetDynamicMaterial();
		MISweep = (FindChildWidget("UIFX_Sweep") as UImage).GetDynamicMaterial();
		TxtName = FindChildWidget("TxtName") as UTextBlock;
		NumResizeRoot = FindChildWidget("NumResizeRoot") as UOverlay;
		TxtNum = FindChildWidget("TxtNum") as UTextBlock;
		TxtDesc = FindChildWidget("TxtDesc") as UTextBlock;
		TxtOverflow = FindChildWidget("TxtOverflow") as UTextBlock;
		ActionCon = FindChildWidget("ActionCon");
	}

	protected override bool OnManualJumpPress(FInputActionValue Value)
	{
		if (SettingMgr.GetCVBoolByType(UISettingConfigType.AdvanceDropManualClose) && ShowState == EnShowState.Show && !IsInFunc)
		{
			OnNext();
		}
		return true;
	}

	protected override bool OnManualJumpRelease(FInputActionValue Value)
	{
		return true;
	}

	public void BindDropItemFillEvt(Action<int, GainPerformanceType> CallEvent)
	{
		Evt_DropItemFill = CallEvent;
	}

	public void SetManualItem(BI_DropManualCS Item)
	{
		DropManualItem = Item;
	}

	public override void CheckData()
	{
		_ = ItemDataList.Count;
	}

	public override int GetDataCount()
	{
		return ItemDataList.Count;
	}

	public void AddItem(FItemWithTag ItemData)
	{
		if (ItemDataList.Count == 0 && ShowState != EnShowState.Show)
		{
			ShowTimeCheck = FirstShowDelayTime;
		}
		ItemDataList.Add(ItemData);
		ItemDataList.Sort(delegate(FItemWithTag X, FItemWithTag Y)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(X.ItemData.Id);
			ItemDesc itemDesc2 = GameDBRuntime.GetItemDesc(Y.ItemData.Id);
			if (itemDesc == null || itemDesc2 == null)
			{
				return X.ItemData.Id - Y.ItemData.Id;
			}
			return (itemDesc2.Quality == itemDesc.Quality) ? ((X.ItemData.Id == Y.ItemData.Id) ? (X.ItemTag - Y.ItemTag) : (X.ItemData.Id - Y.ItemData.Id)) : (itemDesc2.Quality - itemDesc.Quality);
		});
		if (IsInFunc && ShowState == EnShowState.Show)
		{
			UpdateDropFill();
			UpdateContent();
		}
	}

	protected override void UpdateContent()
	{
		if (ItemDataList.Count == 0)
		{
			return;
		}
		ItemOne itemData = ItemDataList[0].ItemData;
		if (itemData == null)
		{
			return;
		}
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(itemData.Id);
		if (itemDesc != null)
		{
			if (itemDesc.Quality >= ItemQuality.Red)
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_itemmedium_drop_level03");
			}
			else if (itemDesc.Quality >= ItemQuality.Purple)
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_itemmedium_drop_level02");
			}
			else
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_itemmedium_drop_level01");
			}
			if (itemDesc.PackageType == ItemPackageType.QuestItem)
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_itemmedium_drop_quest");
			}
			CurItemData = itemData;
			UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgBar, GSUIResPathUtil.GetItemIconTPath(itemData.Id));
			MIBar.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Tier, (float)itemDesc.Quality);
			MISweep.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Tier, (float)itemDesc.Quality);
			TxtName.SetText(itemDesc.Name.ToFTextRemoveRich());
			TxtName.SetRenderOpacity(1f);
			if (itemDesc.ItemType == ItemType.Equip || itemDesc.ItemType == ItemType.Seed || CurItemData.Num == 1)
			{
				NumResizeRoot.SetVisibility(ESlateVisibility.Collapsed);
				TxtNum.SetText(FText.GetEmpty());
			}
			else
			{
				TxtNum.SetText(FText.FromString($"× {CurItemData.Num}"));
				NumResizeRoot.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			TxtDesc.SetText(GSMUIUtil.GetUIWordDescFText((EUIWordID)(1350 + itemDesc.PackageType)));
			switch (ItemDataList[0].ItemTag)
			{
			case EItemTag.BAG:
				GSAnimKeyToState("AKBInfoState", "Default");
				break;
			case EItemTag.WAREHOUSE:
				GSAnimKeyToState("AKBInfoState", "Warehouse");
				break;
			case EItemTag.OVERFLOW:
				GSAnimKeyToState("AKBInfoState", "Overflow");
				StopAnimation("AnimOverflow");
				PlayAnimation("AnimOverflow");
				TxtOverflow.SetText(GSMUIUtil.GetUIWordDescFText(EUIWordID.DROP_OVERFLOW_TIPS));
				break;
			}
			ItemDataList.RemoveAt(0);
			ShowTimeCheck = ShowTime;
		}
	}

	protected override void UpdateDropFill()
	{
		Evt_DropItemFill?.Invoke(CurItemData.Id, GainPerformanceType.Small);
	}

	protected override bool CanShow()
	{
		if (!base.CanShow())
		{
			return false;
		}
		if (DropManualItem != null)
		{
			return !DropManualItem.GetIsShow();
		}
		return false;
	}

	protected override void UpdateFuncInfo()
	{
		base.UpdateFuncInfo();
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		if (IsInFunc)
		{
			ShowTime = uIConfigDataAsset.DropInFuncAdvanceShowTime;
			ActionCon.SetVisibility(ESlateVisibility.Collapsed);
			return;
		}
		ShowTime = uIConfigDataAsset.DropAdvanceShowTime;
		if (SettingMgr.GetCVBoolByType(UISettingConfigType.AdvanceDropManualClose))
		{
			ActionCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		else
		{
			ActionCon.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	public override void Reset()
	{
		base.Reset();
		foreach (FItemWithTag itemData in ItemDataList)
		{
			Evt_DropItemFill?.Invoke(itemData.ItemData.Id, GainPerformanceType.Small);
		}
		ItemDataList.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropMiddleItemCS");
	}

	static BI_DropMiddleItemCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropMiddleItemCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropMiddleItemCS));
	}
}
