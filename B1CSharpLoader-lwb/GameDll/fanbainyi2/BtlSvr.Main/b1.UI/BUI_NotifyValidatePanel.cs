using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_NotifyValidatePanel")]
internal class BUI_NotifyValidatePanel : BUI_Widget
{
	private UButton CloseBtn;

	private const string CLOSEBTN_NAME = "CloseBtn";

	private UMultiLineEditableText TextArea;

	private const string TEXTAREA_NAME = "TextArea";

	private float CanCloseTimer = 3f;

	private bool ShowCloseBtn;

	private static bool OnClickClose_IsValid;

	private static IntPtr OnClickClose_FunctionAddress;

	private static int OnClickClose_ParamsSize;

	protected override void OnUIInitialized()
	{
		TextArea = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TextArea")) as UMultiLineEditableText;
		if (!(TextArea == null))
		{
			CloseBtn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CloseBtn")) as UButton;
			if (!(CloseBtn == null))
			{
				CloseBtn.SetVisibility(ESlateVisibility.Hidden);
				CloseBtn.OnClicked.Bind(OnClickClose);
			}
		}
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
	[USharpPath("/Script/b1-Managed.BUI_NotifyValidatePanel:OnClickClose")]
	private void OnClickClose()
	{
		UGSE_EngineFuncLib.LogDbg("Close", bPrintScreen: true);
		RemoveFromParent();
	}

	public void SetValidateInfoToUI(string text)
	{
		if (TextArea != null)
		{
			TextArea.SetText(FText.FromString(text));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_NotifyValidatePanel:OnClickClose")]
	private static void OnClickClose__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_NotifyValidatePanel bUI_NotifyValidatePanel = GCHelper.Find<b1.UI.BUI_NotifyValidatePanel>(obj);
		bUI_NotifyValidatePanel.OnClickClose();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_NotifyValidatePanel");
		OnClickClose_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickClose");
		OnClickClose_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickClose_FunctionAddress);
		OnClickClose_IsValid = OnClickClose_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_NotifyValidatePanel:OnClickClose", OnClickClose_IsValid);
	}

	static BUI_NotifyValidatePanel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_NotifyValidatePanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_NotifyValidatePanel));
	}
}
