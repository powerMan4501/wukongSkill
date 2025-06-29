using System;
using System.Diagnostics;
using System.IO;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_DataValidatePanel")]
internal class BUI_DataValidatePanel : BUI_Widget
{
	private UButton CloseBtn;

	private const string CLOSEBTN_NAME = "CloseBtn";

	private UButton OpenLogBtn;

	private const string OPENLOGBTN_NAME = "OpenLogBtn";

	private UMultiLineEditableText TextArea;

	private const string TEXTAREA_NAME = "TextArea";

	private UMultiLineEditableText TextAreaFull;

	private const string TEXTAREAFULL_NAME = "TextAreaFull";

	private UCheckBox DisplayFullCheckBox;

	private const string CHECKBOX_NAME = "DisplayFullCheckBox";

	private string[] UserNameBlackList = new string[14]
	{
		"hasa", "songjiajun", "feiluo", "rongda", "ziheng", "yanzhenlong", "pat", "woody", "weiyi", "sybil",
		"guansi", "cd9", "anna", "charlie"
	};

	private float CanCloseTimer = 5f;

	private bool ShowCloseBtn;

	private static bool OnClickClose_IsValid;

	private static IntPtr OnClickClose_FunctionAddress;

	private static int OnClickClose_ParamsSize;

	private static bool OnClickOpenLog_IsValid;

	private static IntPtr OnClickOpenLog_FunctionAddress;

	private static int OnClickOpenLog_ParamsSize;

	private static bool OnCheckDisplayFull_IsValid;

	private static IntPtr OnCheckDisplayFull_FunctionAddress;

	private static int OnCheckDisplayFull_ParamsSize;

	private static bool OnCheckDisplayFull_bIsChecked_IsValid;

	private static int OnCheckDisplayFull_bIsChecked_Offset;

	private static FFieldAddress OnCheckDisplayFull_bIsChecked_PropertyAddress;

	protected override void OnUIInitialized()
	{
		TextArea = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TextArea")) as UMultiLineEditableText;
		if (TextArea == null)
		{
			return;
		}
		TextAreaFull = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TextAreaFull")) as UMultiLineEditableText;
		if (TextAreaFull == null)
		{
			return;
		}
		CloseBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CloseBtn")) as UButton;
		if (CloseBtn == null)
		{
			return;
		}
		CloseBtn.SetVisibility(ESlateVisibility.Hidden);
		CloseBtn.OnClicked.Bind(OnClickClose);
		OpenLogBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("OpenLogBtn")) as UButton;
		if (OpenLogBtn == null)
		{
			return;
		}
		OpenLogBtn.OnClicked.Bind(OnClickOpenLog);
		DisplayFullCheckBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("DisplayFullCheckBox")) as UCheckBox;
		if (DisplayFullCheckBox == null)
		{
			return;
		}
		DisplayFullCheckBox.OnCheckStateChanged.Bind(OnCheckDisplayFull);
		string userNameFromP4Settings = BGW_DebugMgr.Get(this).GetUserNameFromP4Settings();
		bool flag = false;
		string[] userNameBlackList = UserNameBlackList;
		foreach (string text in userNameBlackList)
		{
			if (userNameFromP4Settings == text)
			{
				flag = true;
				break;
			}
		}
		CanCloseTimer = (flag ? 5f : 0f);
		BGW_EventCollection.Get(this).Evt_SetSuperUserInputMode(IsRequest: true, EGSInputModeChangeReason.DataValidate);
	}

	protected override void OnUIDestruct()
	{
		BGW_EventCollection.Get(this).Evt_SetSuperUserInputMode(IsRequest: false, EGSInputModeChangeReason.DataValidate);
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		if (ShowCloseBtn)
		{
			return;
		}
		if (CanCloseTimer > 0f)
		{
			CanCloseTimer -= InDeltaTime;
			return;
		}
		if (CloseBtn != null)
		{
			CloseBtn.SetVisibility(ESlateVisibility.Visible);
		}
		ShowCloseBtn = true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUI_DataValidatePanel:OnClickClose")]
	private void OnClickClose()
	{
		UGSE_EngineFuncLib.LogDbg("Close", bPrintScreen: true);
		RemoveFromParent();
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_DataValidatePanel:OnClickOpenLog")]
	private void OnClickOpenLog()
	{
		UGSE_EngineFuncLib.LogDbg("OpenLog", bPrintScreen: true);
		BGW_ValiDateMgr bGW_ValiDateMgr = BGW_ValiDateMgr.Get(this);
		if (bGW_ValiDateMgr.bDelayWriteLogToFile)
		{
			try
			{
				File.WriteAllText("D:\\DataValidation.txt", bGW_ValiDateMgr.FullLog);
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("Failed to open the log file! " + ex.ToString());
				return;
			}
		}
		Process.Start("D:\\DataValidation.txt");
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_DataValidatePanel:OnCheckDisplayFull")]
	private void OnCheckDisplayFull(bool bIsChecked)
	{
		if (TextArea != null)
		{
			TextArea.SetVisibility(bIsChecked ? ESlateVisibility.Hidden : ESlateVisibility.Visible);
		}
		if (TextAreaFull != null)
		{
			TextAreaFull.SetVisibility((!bIsChecked) ? ESlateVisibility.Hidden : ESlateVisibility.Visible);
		}
	}

	public void SetValidateInfoToUI(string text, string textFull = "")
	{
		if (TextArea != null)
		{
			TextArea.SetText(FText.FromString(text));
		}
		if (textFull != "" && TextAreaFull != null)
		{
			TextAreaFull.SetText(FText.FromString(textFull));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DataValidatePanel:OnClickClose")]
	private static void OnClickClose__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_DataValidatePanel bUI_DataValidatePanel = GCHelper.Find<b1.UI.BUI_DataValidatePanel>(obj);
		bUI_DataValidatePanel.OnClickClose();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DataValidatePanel:OnClickOpenLog")]
	private static void OnClickOpenLog__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_DataValidatePanel bUI_DataValidatePanel = GCHelper.Find<b1.UI.BUI_DataValidatePanel>(obj);
		bUI_DataValidatePanel.OnClickOpenLog();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_DataValidatePanel:OnCheckDisplayFull")]
	private static void OnCheckDisplayFull__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_DataValidatePanel bUI_DataValidatePanel = GCHelper.Find<b1.UI.BUI_DataValidatePanel>(obj);
		bool bIsChecked = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnCheckDisplayFull_bIsChecked_Offset), 0, OnCheckDisplayFull_bIsChecked_PropertyAddress.Address);
		bUI_DataValidatePanel.OnCheckDisplayFull(bIsChecked);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_DataValidatePanel");
		OnClickClose_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickClose");
		OnClickClose_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickClose_FunctionAddress);
		OnClickClose_IsValid = OnClickClose_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DataValidatePanel:OnClickClose", OnClickClose_IsValid);
		OnClickOpenLog_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickOpenLog");
		OnClickOpenLog_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickOpenLog_FunctionAddress);
		OnClickOpenLog_IsValid = OnClickOpenLog_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DataValidatePanel:OnClickOpenLog", OnClickOpenLog_IsValid);
		OnCheckDisplayFull_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCheckDisplayFull");
		OnCheckDisplayFull_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCheckDisplayFull_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnCheckDisplayFull_bIsChecked_PropertyAddress, OnCheckDisplayFull_FunctionAddress, "bIsChecked");
		OnCheckDisplayFull_bIsChecked_Offset = NativeReflection.GetPropertyOffset(OnCheckDisplayFull_FunctionAddress, "bIsChecked");
		OnCheckDisplayFull_bIsChecked_IsValid = NativeReflection.ValidatePropertyClass(OnCheckDisplayFull_FunctionAddress, "bIsChecked", Classes.FBoolProperty);
		OnCheckDisplayFull_IsValid = OnCheckDisplayFull_FunctionAddress != IntPtr.Zero && OnCheckDisplayFull_bIsChecked_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_DataValidatePanel:OnCheckDisplayFull", OnCheckDisplayFull_IsValid);
	}

	static BUI_DataValidatePanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_DataValidatePanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_DataValidatePanel));
	}
}
