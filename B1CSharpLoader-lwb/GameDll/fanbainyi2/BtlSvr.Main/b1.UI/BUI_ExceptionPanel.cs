using System;
using System.Text.RegularExpressions;
using b1.Localization;
using B1UI.GSUI;
using BtlB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ExceptionPanel")]
public class BUI_ExceptionPanel : BUI_Widget
{
	private UCanvasPanel SensitiveDetailCon;

	private UCanvasPanel NonSensitiveDetailCon;

	private UCanvasPanel BtnCon;

	private static readonly FName SensitiveDetailConName;

	private static readonly FName NonSensitiveDetailConName;

	private static readonly FName BtnConName;

	private UButton ConfirmButton;

	private UButton CloseButton;

	private UButton CopyButton;

	private UMultiLineEditableText TextArea;

	private UMultiLineEditableText TextUserConfig;

	private UTextBlock InfoTxt;

	private UTextBlock TitleTxt;

	private UTextBlock ExitTxt;

	private UTextBlock TipsTxt;

	private static readonly FName ConfirmButtonName;

	private static readonly FName CloseButtonName;

	private static readonly FName CopyButtonName;

	private static readonly FName InfoTxtName;

	private static readonly FName TitleTxtName;

	private static readonly FName TipsTxtName;

	private static readonly FName ExitTxtName;

	private static bool OnCloseButtonDown_IsValid;

	private static IntPtr OnCloseButtonDown_FunctionAddress;

	private static int OnCloseButtonDown_ParamsSize;

	private bool IsProdEnv => B1Global.GIsGameReleased;

	private bool IsSupportClose => DebugConfig.ExceptionShowBtn;

	protected override void OnUIInitialized()
	{
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SensitiveDetailCon = UGSE_UMGFuncLib.GetWidgetFromName(this, SensitiveDetailConName) as UCanvasPanel;
		NonSensitiveDetailCon = UGSE_UMGFuncLib.GetWidgetFromName(this, NonSensitiveDetailConName) as UCanvasPanel;
		BtnCon = UGSE_UMGFuncLib.GetWidgetFromName(this, BtnConName) as UCanvasPanel;
		ExitTxt = UGSE_UMGFuncLib.GetWidgetFromName(this, ExitTxtName) as UTextBlock;
		SensitiveDetailCon?.SetVisibility(IsProdEnv ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
		NonSensitiveDetailCon?.SetVisibility((!IsProdEnv) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
		BtnCon?.SetVisibility((!DebugConfig.ExceptionShowBtn) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
		ConfirmButton = UGSE_UMGFuncLib.GetWidgetFromName(this, ConfirmButtonName) as UButton;
		CloseButton = UGSE_UMGFuncLib.GetWidgetFromName(this, CloseButtonName) as UButton;
		CopyButton = UGSE_UMGFuncLib.GetWidgetFromName(this, CopyButtonName) as UButton;
		TextArea = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TextArea) as UMultiLineEditableText;
		TextUserConfig = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TextUserConfig) as UMultiLineEditableText;
		InfoTxt = UGSE_UMGFuncLib.GetWidgetFromName(this, InfoTxtName) as UTextBlock;
		TitleTxt = UGSE_UMGFuncLib.GetWidgetFromName(this, TitleTxtName) as UTextBlock;
		TipsTxt = UGSE_UMGFuncLib.GetWidgetFromName(this, TipsTxtName) as UTextBlock;
		ConfirmButton?.OnClicked.Bind(OnCloseButtonDown);
		CloseButton?.OnClicked.Bind(OnCloseButtonDown);
		CopyButton?.SetVisibility(ESlateVisibility.Visible);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_ExceptionPanel:OnCloseButtonDown")]
	public void OnCloseButtonDown()
	{
	}

	private string GetCurrentTimeStr()
	{
		DateTime utcNow = DateTime.UtcNow;
		int year = utcNow.Year;
		int month = utcNow.Month;
		int day = utcNow.Day;
		int hour = utcNow.Hour;
		int minute = utcNow.Minute;
		int second = utcNow.Second;
		string text = UGSE_UMGFuncLib.ConvertToDateText(year, month, day, hour, minute, second);
		string text2 = UGSE_UMGFuncLib.ConvertToTimeText(year, month, day, hour, minute, second);
		return text + " " + text2;
	}

	public void SetExceptionText(string text)
	{
		string text2 = "";
		try
		{
			string text3 = BGU_DeepCopyUtil.Copy(text);
			string value = new Regex("\\w:[\\\\/](\\\\|\\w)*unreal_proj[\\\\/]").Match(text).Value;
			text3 = (string.IsNullOrEmpty(value) ? text3 : text3.Replace(value, ""));
			text = text3;
		}
		catch (Exception arg)
		{
			text2 = $"{arg}字符串处理异常，原本字符串为：{text}！\n";
		}
		if (IsProdEnv)
		{
			string appVersionWithRevision = GSVersionUtil.GetAppVersionWithRevision();
			appVersionWithRevision = appVersionWithRevision + "\n" + GetCurrentTimeStr();
			BGW_GSSdkMgr bGW_GSSdkMgr = BGW_GSSdkMgr.Get(this);
			appVersionWithRevision = ((!(bGW_GSSdkMgr != null)) ? (appVersionWithRevision + $"{UB1Util.GetPrivacyAgreement()}") : (appVersionWithRevision + $"\n{bGW_GSSdkMgr.GameStartSessionUUID}-{(DateTime.Now - DateTime.UtcNow).Hours}-{UB1Util.GetPrivacyAgreement()}"));
			InfoTxt?.SetText(FText.FromString(appVersionWithRevision));
			ExitTxt?.SetText(GetTxtByUIWord(EUIWordID.SETTING_TAB_EXIT));
			TitleTxt?.SetText(GetTxtByUIWord(EUIWordID.EXCEPTION_TITLE));
			TipsTxt?.SetText(GetTxtByUIWord(EUIWordID.EXCEPTION_TIPS));
		}
		else if (TextArea != null)
		{
			TextArea.SetText(FText.FromString(text));
			if (TextUserConfig != null)
			{
				try
				{
					text2 += BGW_DebugMgr.Get(this).GetUserConfig();
					TextUserConfig.SetText(FText.FromString(text2));
				}
				catch (Exception ex)
				{
					text2 = text2 + "获取用户数据异常，请联系 Shepherd 来查询问题！\n" + ex.StackTrace;
					TextUserConfig.SetText(FText.FromString(text2));
				}
			}
		}
		else
		{
			FMessage.OpenDialog(text);
		}
		static FText GetTxtByUIWord(EUIWordID ID)
		{
			FUStUIWordDesc uIWordDesc = BGW_GameDB.GetUIWordDesc((int)ID);
			if (uIWordDesc == null)
			{
				return FText.FromString("");
			}
			return uIWordDesc.Content.ToFText();
		}
	}

	static BUI_ExceptionPanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ExceptionPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ExceptionPanel));
		SensitiveDetailConName = new FName("SensitiveDetailCon");
		NonSensitiveDetailConName = new FName("NonSensitiveDetailCon");
		BtnConName = new FName("BtnCon");
		ConfirmButtonName = new FName("ConfirmBtn");
		CloseButtonName = new FName("CloseButton");
		CopyButtonName = new FName("CopyButton");
		InfoTxtName = new FName("InfoTxt");
		TitleTxtName = new FName("TitleTxt");
		TipsTxtName = new FName("TipsTxt");
		ExitTxtName = new FName("TextBlock_92");
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_ExceptionPanel:OnCloseButtonDown")]
	private static void OnCloseButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_ExceptionPanel bUI_ExceptionPanel = GCHelper.Find<BUI_ExceptionPanel>(obj);
		bUI_ExceptionPanel.OnCloseButtonDown();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_ExceptionPanel");
		OnCloseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCloseButtonDown");
		OnCloseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCloseButtonDown_FunctionAddress);
		OnCloseButtonDown_IsValid = OnCloseButtonDown_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_ExceptionPanel:OnCloseButtonDown", OnCloseButtonDown_IsValid);
	}
}
