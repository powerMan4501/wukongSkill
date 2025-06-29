using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

public class BGW_Watermark
{
	private List<UTextBlock> WatermarkTxtList = new List<UTextBlock>();

	private List<UTextBlock> WatermarkUserIdTxtList = new List<UTextBlock>();

	private UTextBlock FixedWatermarkTxt;

	private UTextBlock FixedWatermarkTxtBin;

	private string ListWatermarkText = "GameScience";

	private string FixedWatermarkText = "GameScience";

	private string FixedWatermarkTextBin = "oo=o=o=o=o=o=o=o=o=o=ooo";

	private FSlateColor TxtColor;

	private float TxtWatermarkScale = 0.5f;

	private float WatermarkOpacity = 0.1f;

	private float FixedWatermarkOpacity = 0.5f;

	private UUserWidget Widget;

	private UWidget FixedMatrixWidget;

	private bool bEnable = true;

	private UImage Ref01;

	private UImage Ref02;

	private UImage Ref03;

	private UImage Ref04;

	private BGW_WatchDog.UserDynamicKeyInfo DynamicKeyInfo;

	public bool Inited
	{
		get
		{
			if (Widget != null)
			{
				return !Widget.IsNullOrDestroyed();
			}
			return false;
		}
	}

	private static bool NeedShowFixedMatrixWaterMark => DebugConfig.LQALanguage;

	public void RandomWaterMarkTmpHide()
	{
		if (Widget != null)
		{
			UWidgetAnimation widgetAnimationByName = UGSE_UMGFuncLib.GetWidgetAnimationByName(Widget, "ShowOut");
			if (widgetAnimationByName != null)
			{
				Widget.PlayAnimation(widgetAnimationByName);
			}
		}
	}

	public void SetWatermark(string StrWatermark, bool bRandomAngle, string FixedTxt = null, string BiuVersion = "", string UserDyanmicKey = "", string LoginUserName = "")
	{
		ListWatermarkText = StrWatermark;
		if (BGW_WatchDog.ParseUserDynamicKey(UserDyanmicKey, ref DynamicKeyInfo))
		{
			ListWatermarkText = ListWatermarkText + "." + StrWatermark + "\n" + DynamicKeyInfo.BinString;
			UpdateRefImageInMatVal(DynamicKeyInfo.PureNumber);
			FixedWatermarkTextBin = DynamicKeyInfo.BinString;
		}
		if (FixedTxt != null)
		{
			FixedWatermarkText = FixedTxt;
			if (BiuVersion != "")
			{
				FixedWatermarkText = FixedWatermarkText + " v" + BiuVersion;
			}
		}
		ResetWatermark(bRandomAngle);
		if (NeedShowFixedMatrixWaterMark && !string.IsNullOrEmpty(LoginUserName))
		{
			for (int i = 0; i < WatermarkUserIdTxtList.Count; i++)
			{
				WatermarkUserIdTxtList[i].SetText(FText.FromString(LoginUserName));
			}
		}
	}

	private void ResetWatermark(bool bRandomAngle)
	{
		if (!bEnable || WatermarkTxtList.Count == 0)
		{
			return;
		}
		int num = 0;
		if (bRandomAngle)
		{
			num = FMath.RandRange(-80, 10);
		}
		for (int i = 0; i < WatermarkTxtList.Count; i++)
		{
			WatermarkTxtList[i].SetText(FText.FromString(ListWatermarkText));
			WatermarkTxtList[i].SetVisibility(ESlateVisibility.Hidden);
			if (num != 0)
			{
				WatermarkTxtList[i].SetRenderTransformAngle(num);
			}
		}
		FVector2D renderTranslation = new FVector2D
		{
			X = FMath.RandRange(0, 100),
			Y = FMath.RandRange(0, 200)
		};
		int index = FMath.Rand() % WatermarkTxtList.Count;
		WatermarkTxtList[index].SetVisibility(ESlateVisibility.HitTestInvisible);
		WatermarkTxtList[index].SetRenderTranslation(renderTranslation);
		if (FixedWatermarkText != null)
		{
			FixedWatermarkTxt.SetText(FText.FromString(FixedWatermarkText));
		}
		if (FixedWatermarkTextBin != null)
		{
			FixedWatermarkTxtBin.SetText(FText.FromString(FixedWatermarkTextBin));
		}
		if (!Widget.IsInViewport())
		{
			Widget.AddToViewport(10000);
		}
		if (!Widget.IsVisible())
		{
			Widget.SetVisibility(ESlateVisibility.HitTestInvisible);
		}
	}

	public void HideWatermark()
	{
		if (Widget != null && !Widget.IsNullOrDestroyed() && bEnable)
		{
			Widget.SetVisibility(ESlateVisibility.Hidden);
			if (FixedMatrixWidget != null)
			{
				FixedMatrixWidget.SetVisibility(ESlateVisibility.Hidden);
			}
			bEnable = false;
		}
	}

	public void ShowWatermark()
	{
		Widget.SetVisibility(ESlateVisibility.HitTestInvisible);
		if (FixedMatrixWidget != null && NeedShowFixedMatrixWaterMark)
		{
			FixedMatrixWidget.SetVisibility(ESlateVisibility.HitTestInvisible);
		}
		bEnable = true;
	}

	public void Destroy()
	{
		bEnable = false;
		if (Widget != null)
		{
			if (!Widget.IsNullOrDestroyed() && Widget.IsInViewport())
			{
				Widget.RemoveFromParent();
			}
			Widget.RemoveFromRoot();
			Widget = null;
		}
	}

	private void UpdateRefImageInMatVal(int Val)
	{
		Ref01.GetDynamicMaterial().SetScalarParameterValue(B1GlobalFNames.ImgWatermarkMatPName, Val);
		Ref02.GetDynamicMaterial().SetScalarParameterValue(B1GlobalFNames.ImgWatermarkMatPName, Val);
		Ref03.GetDynamicMaterial().SetScalarParameterValue(B1GlobalFNames.ImgWatermarkMatPName, Val);
		Ref04.GetDynamicMaterial().SetScalarParameterValue(B1GlobalFNames.ImgWatermarkMatPName, Val);
	}

	public void Init(UObject WorldContext)
	{
		if (Widget == null)
		{
			string resPath = "/Game/00Main/UI/BluePrintsV3/Other/BUI_P_Watermark.BUI_P_Watermark_C";
			Widget = UGSE_UMGFuncLib.CreateUserWidget(WorldContext, resPath);
			HotReload.UnloadBegin += delegate
			{
				if (!Widget.IsNullOrDestroyed())
				{
					Widget.RemoveFromRoot();
				}
			};
			Widget.AddToRoot();
		}
		bEnable = true;
		Widget.AddToViewport(10000);
		Widget.SetVisibility(ESlateVisibility.Hidden);
		WatermarkTxtList.Clear();
		for (int num = 0; num < 9; num++)
		{
			UTextBlock uTextBlock = UGSE_UMGFuncLib.GetWidgetFromName(Widget, new FName(B1GlobalFNames.WatermarkTxt_.ToString() + num)) as UTextBlock;
			uTextBlock.SetText(FText.FromString(ListWatermarkText));
			WatermarkTxtList.Add(uTextBlock);
		}
		FixedWatermarkTxtBin = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.TxtFixedWatermarkBin) as UTextBlock;
		FixedWatermarkTxtBin.SetText(FText.FromString(FixedWatermarkTextBin));
		FixedWatermarkTxt = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.TxtFixedWatermark) as UTextBlock;
		FixedWatermarkTxt.SetText(FText.FromString(ListWatermarkText));
		Ref01 = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.Ref01Watermark) as UImage;
		Ref02 = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.Ref02Watermark) as UImage;
		Ref03 = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.Ref03Watermark) as UImage;
		Ref04 = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.Ref04Watermark) as UImage;
		UpdateRefImageInMatVal(0);
		FixedMatrixWidget = UGSE_UMGFuncLib.GetWidgetFromName(Widget, B1GlobalFNames.WatermarkFixedMatrixCont);
		if (!(FixedMatrixWidget != null))
		{
			return;
		}
		if (NeedShowFixedMatrixWaterMark)
		{
			FixedMatrixWidget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			WatermarkUserIdTxtList.Clear();
			for (int num2 = 0; num2 < 12; num2++)
			{
				UTextBlock uTextBlock2 = UGSE_UMGFuncLib.GetWidgetFromName(Widget, new FName("TextBlock_wm_name_" + num2)) as UTextBlock;
				if (uTextBlock2 != null)
				{
					WatermarkUserIdTxtList.Add(uTextBlock2);
				}
			}
		}
		else
		{
			FixedMatrixWidget.SetVisibility(ESlateVisibility.Collapsed);
		}
	}
}
