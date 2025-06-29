using System;
using b1.Localization;
using b1.Plugins.GSInput;
using b1.UI.Comm;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ShortcutItemBaseCS")]
public class BI_ShortcutItemBaseCS : BUI_Widget
{
	private BI_ShortcutBaseCS ShortcutDf;

	private BI_ShortcutBaseCS ShortcutSt;

	private BI_ShortcutNumCS Num;

	private UCanvasPanel NameCon;

	private UTextBlock TxtName;

	private UCanvasPanel BriefDescCon;

	private UTextBlock TxtBriefDesc;

	private UWidget StCon;

	private UWidget DfCon;

	private int ItemID;

	public static readonly string GSAKBSwitchState_Normal;

	public static readonly string GSAKBSwitchState_Select;

	public static readonly string GSAKBSwitchState_Out;

	public static readonly FName GSAKBSwitchState_Name_Normal;

	public static readonly FName GSAKBSwitchState_Name_Select;

	public static readonly FName GSAKBSwitchState_Name_Out;

	private static bool CurPosIdx_IsValid;

	private static int CurPosIdx_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty")]
	[Tooltip("PosIdx")]
	[USharpPath("/Script/b1-Managed.BI_ShortcutItemBaseCS:CurPosIdx")]
	public int CurPosIdx
	{
		get
		{
			CheckDestroyed();
			if (!CurPosIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutItemBaseCS:CurPosIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurPosIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurPosIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_ShortcutItemBaseCS:CurPosIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurPosIdx_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ShortcutDf = FindChildWidget("ItemDf") as BI_ShortcutBaseCS;
		ShortcutDf.OnInit(EGSInputType.KeyboardMouse, EnShortcutType.ITEM, CurPosIdx);
		ShortcutDf.IsSelectItem = false;
		ShortcutSt = FindChildWidget("ItemSt") as BI_ShortcutBaseCS;
		ShortcutSt.OnInit(EGSInputType.KeyboardMouse, EnShortcutType.ITEM, CurPosIdx);
		ShortcutSt.IsSelectItem = true;
		Num = FindChildWidget("QuanSt") as BI_ShortcutNumCS;
		Num.CurPosIdx = CurPosIdx;
		StCon = FindChildWidget("StCon");
		DfCon = FindChildWidget("DfCon");
		BI_ShortcutBaseCS shortcutDf = ShortcutDf;
		shortcutDf.Evt_SwitchState = (BUI_StateWidget.Del_SwitchState)Delegate.Combine(shortcutDf.Evt_SwitchState, new BUI_StateWidget.Del_SwitchState(Num.SwitchState));
		BI_ShortcutBaseCS shortcutDf2 = ShortcutDf;
		shortcutDf2.Evt_SwitchDisable = (BUI_StateWidget.Del_SwitchDisable)Delegate.Combine(shortcutDf2.Evt_SwitchDisable, new BUI_StateWidget.Del_SwitchDisable(Num.SwitchState));
		NameCon = FindChildWidget("NameCon") as UCanvasPanel;
		TxtName = FindChildWidget("TxtName") as UTextBlock;
		BriefDescCon = FindChildWidget("DescCon") as UCanvasPanel;
		TxtBriefDesc = FindChildWidget("TxtDesc") as UTextBlock;
		GSBindDelegateToOnAKBStateBegin("GSAKBSwitchState", OnAKBStateBeginFunc);
		GSBindDelegateToOnAKBStateEnd("GSAKBSwitchState", OnAKBStateEndFunc);
	}

	private void OnAKBStateBeginFunc(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		StCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		DfCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
	}

	private void OnAKBStateEndFunc(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		if (EndStateName == GSAKBSwitchState_Name_Normal)
		{
			StCon.SetVisibility(ESlateVisibility.Collapsed);
		}
		else
		{
			StCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		if (EndStateName == GSAKBSwitchState_Name_Out)
		{
			DfCon.SetVisibility(ESlateVisibility.Collapsed);
		}
		else
		{
			DfCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
	}

	public void UpdateContent(int TargetID)
	{
		ItemID = TargetID;
		NameCon.SetVisibility(ESlateVisibility.Collapsed);
		BriefDescCon.SetVisibility(ESlateVisibility.Collapsed);
		ItemDesc itemDesc = GameDBRuntime.GetItemDesc(TargetID);
		if (itemDesc != null)
		{
			TxtName.SetText(itemDesc.Name.ToFTextRemoveRich());
			NameCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			if (BGW_SettingMgrV2.Get(this).GetCVBoolByType(UISettingConfigType.KeybaordEffectDesc))
			{
				TxtBriefDesc.SetText(itemDesc.HudEffectDesc.ToFTextRemoveRich());
				BriefDescCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
		}
	}

	public void UpdateContent()
	{
		UpdateContent(ItemID);
	}

	public BI_ShortcutBaseCS GetShortcutDf()
	{
		return ShortcutDf;
	}

	public BI_ShortcutBaseCS GetShortcutSt()
	{
		return ShortcutSt;
	}

	public void SwitchState(bool IsSelected, bool IsForce = false, float InStateDelayEasingTime = 0f, float InStateOverideEasingTime = -1f)
	{
		if (IsSelected)
		{
			GSAnimKeyToState("GSAKBSwitchState", GSAKBSwitchState_Select, IsForce, InStateDelayEasingTime, InStateOverideEasingTime);
		}
		else
		{
			GSAnimKeyToState("GSAKBSwitchState", GSAKBSwitchState_Normal, IsForce, InStateDelayEasingTime, InStateOverideEasingTime);
		}
	}

	public void AddSyncImage(UImage Img)
	{
		ShortcutDf.SyncImgList.Add(Img);
	}

	public void ClearSyncImage()
	{
		ShortcutDf.SyncImgList.Clear();
	}

	public void UpdateSyncImage()
	{
		ShortcutDf.UpdateSyncImage();
	}

	static BI_ShortcutItemBaseCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ShortcutItemBaseCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ShortcutItemBaseCS));
		GSAKBSwitchState_Normal = "Normal";
		GSAKBSwitchState_Select = "Select";
		GSAKBSwitchState_Out = "Out";
		GSAKBSwitchState_Name_Normal = new FName(GSAKBSwitchState_Normal);
		GSAKBSwitchState_Name_Select = new FName(GSAKBSwitchState_Select);
		GSAKBSwitchState_Name_Out = new FName(GSAKBSwitchState_Out);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_ShortcutItemBaseCS");
		CurPosIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurPosIdx");
		CurPosIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurPosIdx", Classes.FIntProperty);
	}
}
