using System;
using System.Text;
using b1.Localization;
using BtlB1;
using GSE.GSSdk;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_CommErrorTips")]
public class BUI_CommErrorTips : BUI_Widget
{
	private UTextBlock LogText;

	private UTextBlock UserConfigText;

	private UTextBlock UserTips;

	private UTextBlock ConfirmTxt;

	private UButton ConfimrBtn;

	private UCanvasPanel StackInfoCon;

	private UCanvasPanel LogCon;

	private UTextBlock StackInfoText;

	private static bool OnConfirmButtonDown_IsValid;

	private static IntPtr OnConfirmButtonDown_FunctionAddress;

	private static int OnConfirmButtonDown_ParamsSize;

	private bool IsProdEnv => B1Global.GIsGameReleased;

	protected override void OnUIInitialized()
	{
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		LogText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("LogText")) as UTextBlock;
		UserConfigText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UserConfigText")) as UTextBlock;
		UserTips = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UserTips")) as UTextBlock;
		ConfimrBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("ConfirmBtn")) as UButton;
		StackInfoCon = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("StackInfoCon")) as UCanvasPanel;
		LogCon = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("LogCon")) as UCanvasPanel;
		StackInfoText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("StackInfoText")) as UTextBlock;
		ConfirmTxt = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TextBlock_92")) as UTextBlock;
		FUStUIWordDesc uIWordDesc = BGW_GameDB.GetUIWordDesc(5);
		ConfirmTxt?.SetText((uIWordDesc == null) ? FText.FromString("") : uIWordDesc.Content.ToFText());
		ConfimrBtn?.OnClicked.Bind(OnConfirmButtonDown);
		StackInfoCon?.SetVisibility(ESlateVisibility.Collapsed);
		LogCon?.SetVisibility(IsProdEnv ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	public void SetFocusTick()
	{
		ConfimrBtn?.SetFocus();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_CommErrorTips:OnConfirmButtonDown")]
	public void OnConfirmButtonDown()
	{
		BGW_EventCollection.Get(this).Evt_CloseExceptionUI();
	}

	public void SetErrorTipsText(FSMException Ex)
	{
		if (Ex != null)
		{
			SetErrorTipsText(Ex.ErrorCode, ECommonErrorType.Loading, Ex.ExtraMsg);
		}
	}

	public void SetErrorTipsText(int ErrorCode, ECommonErrorType CommonErrorType, string ExtraMsg)
	{
		CommonErrorUITipsDesc commonErrorUITipsDesc = GameDBRuntime.GetCommonErrorUITipsDesc(CommonErrorType, ErrorCode);
		if (commonErrorUITipsDesc != null)
		{
			FText fText = commonErrorUITipsDesc.ErrorTips.ToFText();
			UserTips.SetText(FText.FromString($"【{ErrorCode}】 ") + fText);
			UserConfigText.SetText(FText.FromString(GetUserConfig()));
		}
		else
		{
			UserTips.SetText(FText.FromString($"【{ErrorCode}】 Can not find the corresponding tips."));
		}
		LogText.SetText(FText.FromString(ExtraMsg));
		UserConfigText.SetText(FText.FromString(GetUserConfig()));
		GSSDKReport.MonitorAdd(MonEvtCatogray.ERROR, "ErrorCode", 1L, $"type={CommonErrorType}, ret={ErrorCode}, git={BuildEnv.GitVersion}, p4={BuildEnv.P4Version}");
	}

	private string GetUserConfig()
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = (UGSE_EngineFuncLib.IsEditor() ? "true" : "false");
		string localP4UserName = BGW_LocalDevEnvUtils.GetLocalP4UserName();
		string platformName = UGameplayStatics.GetPlatformName();
		string buildVersionForDebug = GetBuildVersionForDebug();
		string currentLevelName = UGameplayStatics.GetCurrentLevelName(this);
		stringBuilder.AppendLine("IsEditor: " + text + "    UserName: " + localP4UserName + "    Platform: " + platformName + "    Version: " + buildVersionForDebug);
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController != null)
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (controlledPawn != null)
			{
				UBGWFunctionLibraryCS.GetMapInfoFromPlayer(controlledPawn, out var MapName, out var MapAreaId, out var MapAreaName, out var PlayerPos);
				stringBuilder.AppendLine($"Map: {currentLevelName}-{MapName}    Area: {MapAreaId}-{MapAreaName}    Position: ({(int)PlayerPos.X}, {(int)PlayerPos.Y}, {(int)PlayerPos.Z})");
			}
			else
			{
				stringBuilder.AppendLine("Map: " + currentLevelName + "    NoPlayer");
			}
		}
		return stringBuilder.ToString();
	}

	private string GetBuildVersionForDebug()
	{
		return GSVersionUtil.GetAppVersionWithRevision();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_CommErrorTips:OnConfirmButtonDown")]
	private static void OnConfirmButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_CommErrorTips bUI_CommErrorTips = GCHelper.Find<BUI_CommErrorTips>(obj);
		bUI_CommErrorTips.OnConfirmButtonDown();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_CommErrorTips");
		OnConfirmButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnConfirmButtonDown");
		OnConfirmButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConfirmButtonDown_FunctionAddress);
		OnConfirmButtonDown_IsValid = OnConfirmButtonDown_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_CommErrorTips:OnConfirmButtonDown", OnConfirmButtonDown_IsValid);
	}

	static BUI_CommErrorTips()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_CommErrorTips)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_CommErrorTips));
	}
}
