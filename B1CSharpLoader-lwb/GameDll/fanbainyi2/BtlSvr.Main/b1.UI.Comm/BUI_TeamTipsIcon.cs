using System;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_TeamTipsIcon")]
public class BUI_TeamTipsIcon : BUI_Widget
{
	private UCanvasPanel SaveCon;

	private UImage ImgProg;

	private UMaterialInstanceDynamic ImgProgMat;

	private UHorizontalBox WaitCon;

	private UTextBlock TxtWaitTime;

	public static readonly FName MatParamPercent;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SaveCon = FindChildWidget("SaveCon") as UCanvasPanel;
		SaveCon.SetVisibility(ESlateVisibility.Collapsed);
		ImgProg = FindChildWidget("ImgProg") as UImage;
		ImgProgMat = ImgProg.GetDynamicMaterial();
		WaitCon = FindChildWidget("WaitCon") as UHorizontalBox;
		WaitCon.SetVisibility(ESlateVisibility.Collapsed);
		TxtWaitTime = FindChildWidget("TxtWaitTime") as UTextBlock;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
	}

	public void HandleChangeBeSaveWaitTime(float NewValue)
	{
		if (SaveCon.GetVisibility() != ESlateVisibility.Collapsed)
		{
			SaveCon.SetVisibility(ESlateVisibility.Collapsed);
		}
		if (WaitCon.GetVisibility() != ESlateVisibility.SelfHitTestInvisible)
		{
			WaitCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		int num = (int)Math.Ceiling((float)BGW_PreloadAssetMgr.Get(this).FallDyingConfigDataAsset.SaveTeammateWaitTime - NewValue);
		string text = num.ToString();
		if (num < 10)
		{
			text = "0" + num;
		}
		TxtWaitTime.SetText(FText.FromString("0:" + text));
	}

	public void HandleChangeSaveSelfWaitTimePercent(float NewValue)
	{
		if (SaveCon.GetVisibility() != ESlateVisibility.SelfHitTestInvisible)
		{
			SaveCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		if (WaitCon.GetVisibility() != ESlateVisibility.Collapsed)
		{
			WaitCon.SetVisibility(ESlateVisibility.Collapsed);
		}
		ImgProgMat.SetScalarParameterValue(MatParamPercent, NewValue);
	}

	public void SwitchUIInRound(bool IsInRound)
	{
		TxtWaitTime.SetRenderOpacity((!IsInRound) ? 1 : 0);
	}

	static BUI_TeamTipsIcon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_TeamTipsIcon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_TeamTipsIcon));
		MatParamPercent = new FName("Percent");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_TeamTipsIcon");
	}
}
