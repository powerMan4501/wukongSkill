using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GM_OP_Editable")]
internal class BUI_GM_OP_Editable : BUI_Widget
{
	private UTextBlock curValueTxt;

	private UEditableTextBox ediText;

	private UButton Btn;

	private float curValue;

	public string GMCommand_Pre;

	private const string OPTEMP_CURVALUENAME = "CurValueText";

	private const string OPTEMP_EDTTXTNAME = "OPEditableText";

	private const string OPTEMP_BTNNAME = "OPButton";

	private static bool OnClickChangeValue_IsValid;

	private static IntPtr OnClickChangeValue_FunctionAddress;

	private static int OnClickChangeValue_ParamsSize;

	public void Init()
	{
		curValueTxt = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CurValueText")) as UTextBlock;
		ediText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("OPEditableText")) as UEditableTextBox;
		Btn = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("OPButton")) as UButton;
		if (!(curValueTxt == null) && !(ediText == null) && !(Btn == null))
		{
			Btn.OnClicked.Bind(OnClickChangeValue);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_GM_OP_Editable:OnClickChangeValue")]
	public void OnClickChangeValue()
	{
		if (GMCommand_Pre != null)
		{
			if (float.TryParse(ediText.GetText(), out curValue))
			{
				curValueTxt.SetText(FText.FromString(ediText.GetText()));
				UGSE_EngineFuncLib.LogDbg(GMCommand_Pre, bPrintScreen: true);
				USystemLibrary.ExecuteConsoleCommand(this, GMCommand_Pre + " " + curValue, null);
			}
			else
			{
				ediText.SetText(FText.FromString("Error"));
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_GM_OP_Editable:OnClickChangeValue")]
	private static void OnClickChangeValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.BUI_GM_OP_Editable bUI_GM_OP_Editable = GCHelper.Find<b1.UI.BUI_GM_OP_Editable>(obj);
		bUI_GM_OP_Editable.OnClickChangeValue();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_GM_OP_Editable");
		OnClickChangeValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickChangeValue");
		OnClickChangeValue_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickChangeValue_FunctionAddress);
		OnClickChangeValue_IsValid = OnClickChangeValue_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_GM_OP_Editable:OnClickChangeValue", OnClickChangeValue_IsValid);
	}

	static BUI_GM_OP_Editable()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GM_OP_Editable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GM_OP_Editable));
	}
}
