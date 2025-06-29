using System;
using b1.BGW;
using b1.Localization;
using B1UI.GSUI;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropItemCS")]
public class BI_DropItemCS : BUI_Widget
{
	private BGW_UIMgr UIMgr;

	private UCanvasPanel SizeCon;

	private UImage ImgBar;

	private UMaterialInstanceDynamic MIBar;

	private UTextBlock TxtName;

	private UTextBlock TxtNum;

	private UTextBlock TxtIncNum;

	private UImage ImgWareHouseTag;

	private UWidgetAnimation AnimIncrease;

	private EnShowState ShowState;

	private bool IsHideAfterAnim;

	private bool IsShow;

	private float ShowTime;

	private float MinShowTime;

	private float ShowTimeCheck;

	private float AllIncreaseNum;

	private bool IsAnimHideComplete;

	private int CurItemID;

	private bool IsInFunc;

	private Action<int, GainPerformanceType> DropItemFill;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		if (IsInFunc)
		{
			ShowTime = uIConfigDataAsset.DropInFuncShowTime;
		}
		else
		{
			ShowTime = uIConfigDataAsset.DropShowTime;
		}
		MinShowTime = uIConfigDataAsset.DropMinShowTime;
		SizeCon = FindChildWidget("ResizeCon") as UCanvasPanel;
		ImgBar = FindChildWidget("ImgBar") as UImage;
		MIBar = ImgBar.GetDynamicMaterial();
		TxtName = FindChildWidget("TxtName") as UTextBlock;
		TxtNum = FindChildWidget("TxtNum") as UTextBlock;
		TxtIncNum = FindChildWidget("TxtIncre") as UTextBlock;
		ImgWareHouseTag = FindChildWidget("ImgMarkerSave") as UImage;
		AnimIncrease = FindWidgetAnimation("AnimIncrease");
		ShowState = EnShowState.Min;
	}

	public void SetHideAfterAnim(bool IsHide)
	{
		IsHideAfterAnim = IsHide;
	}

	public void BindDropItemFill(Action<int, GainPerformanceType> CallEvent)
	{
		DropItemFill = CallEvent;
	}

	public void DoShowIn()
	{
		StopAnimationByInfo("AnimHide");
		SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		PlayWidgetAnimationByInfoName("AnimShow");
	}

	public void DoShowOut()
	{
		ShowState = EnShowState.Hide;
		AllIncreaseNum = 0f;
		StopAnimationByInfo("AnimShow");
		PlayWidgetAnimationByInfoName("AnimHide", 0f, 1f, 1, delegate
		{
			if (ShowState == EnShowState.Hide && IsHideAfterAnim)
			{
				SetVisibility(ESlateVisibility.Collapsed);
			}
			ShowState = EnShowState.HideComplete;
		});
		CurItemID = 0;
	}

	public void SetIsInFunc(bool IsIn)
	{
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		IsInFunc = IsIn;
		if (IsIn)
		{
			ShowTime = uIConfigDataAsset.DropInFuncShowTime;
		}
		else
		{
			ShowTime = uIConfigDataAsset.DropShowTime;
		}
	}

	public void Reset()
	{
		AllIncreaseNum = 0f;
		ShowState = EnShowState.HideComplete;
		SetVisibility(ESlateVisibility.Collapsed);
		CurItemID = 0;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (ShowState == EnShowState.Show)
		{
			ShowTimeCheck -= InDeltaTime;
			if (ShowTimeCheck <= 0f)
			{
				DoShowOut();
			}
		}
	}

	public void UpdateContent(FItemWithTag ItemTagData, bool IsNextWait = false)
	{
		UpdateContent(ItemTagData.ItemData, ItemTagData.ItemTag);
	}

	public void UpdateContent(ItemOne ItemData, EItemTag ItemTag = EItemTag.BAG)
	{
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemData.Id);
		if (itemDesc != null)
		{
			switch (ItemTag)
			{
			case EItemTag.BAG:
				GSAnimKeyToState("AKBInfoState", "Default");
				break;
			case EItemTag.WAREHOUSE:
				GSAnimKeyToState("AKBInfoState", "Warehouse");
				break;
			case EItemTag.OVERFLOW:
				StopAnimation("AnimOverflow");
				PlayAnimation("AnimOverflow");
				GSAnimKeyToState("AKBInfoState", "Overflow");
				break;
			}
			AllIncreaseNum += ItemData.Num;
			CurItemID = ItemData.Id;
			if (itemDesc.ItemType != ItemType.Spirit)
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_itemsmall_drop");
				MIBar.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Tier, (float)itemDesc.Quality);
				UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgBar, GSUIResPathUtil.GetItemIconTPath(ItemData.Id));
				TxtNum.SetText(FText.FromString($"×{ItemData.Num}"));
			}
			else
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_lingyun_drop");
				TxtNum.SetText(FText.FromString($"×{AllIncreaseNum}"));
				TxtIncNum.SetText(FText.FromString($"+{ItemData.Num}"));
			}
			TxtName.SetText(itemDesc.Name.ToFTextRemoveRich());
			if (ShowState != EnShowState.Show)
			{
				DoShowIn();
			}
			else
			{
				PlayWidgetAnimation(AnimIncrease);
			}
			ShowTimeCheck = ShowTime;
			ShowState = EnShowState.Show;
			DropItemFill?.Invoke(CurItemID, GainPerformanceType.Min);
		}
	}

	public bool GetIsShow()
	{
		if (ShowState != EnShowState.Show)
		{
			return ShowState == EnShowState.Hide;
		}
		return true;
	}

	public void SetMinShowTime()
	{
		if (ShowTimeCheck > MinShowTime)
		{
			ShowTimeCheck = MinShowTime;
		}
	}

	public float GetItemHeight()
	{
		return (SizeCon.Slot as UCanvasPanelSlot).GetSize().Y;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropItemCS");
	}

	static BI_DropItemCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropItemCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropItemCS));
	}
}
