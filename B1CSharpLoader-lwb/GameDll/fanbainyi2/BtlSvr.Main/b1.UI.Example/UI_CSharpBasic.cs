using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Example;

[UClass]
[USharpPath("/Script/b1-Managed.UI_CSharpBasic")]
internal class UI_CSharpBasic : BUI_Widget
{
	private UButton BtnDoSth;

	private UButton BtnClose;

	private float Timer = 3f;

	private static bool OnClickClose_IsValid;

	private static IntPtr OnClickClose_FunctionAddress;

	private static int OnClickClose_ParamsSize;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		BtnDoSth = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.Btn_DoSomething) as UButton;
		BtnClose = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.Btn_Close) as UButton;
		(UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.Txt_DoSomething) as UTextBlock).SetText(FText.FromString("haha"));
		BtnClose.OnClicked.Bind(OnClickClose);
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		Timer -= InDeltaTime;
		if (Timer <= 0f)
		{
			Timer = 3f;
			UGSE_EngineFuncLib.LogError("my god");
		}
	}

	private void OnClickDoSth()
	{
		PlayAnimation(UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "TestAnim"));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UI_CSharpBasic:OnClickClose")]
	private void OnClickClose()
	{
		RemoveFromParent();
	}

	public override void OnTestEvent(int Param1, int Param2, string ParamStr1)
	{
		UGSE_EngineFuncLib.LogError("test event" + ParamStr1);
	}

	[UFunctionInvoker("/Script/b1-Managed.UI_CSharpBasic:OnClickClose")]
	private static void OnClickClose__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.UI.Example.UI_CSharpBasic uI_CSharpBasic = GCHelper.Find<b1.UI.Example.UI_CSharpBasic>(obj);
		uI_CSharpBasic.OnClickClose();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UI_CSharpBasic");
		OnClickClose_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnClickClose");
		OnClickClose_ParamsSize = NativeReflection.GetFunctionParamsSize(OnClickClose_FunctionAddress);
		OnClickClose_IsValid = OnClickClose_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UI_CSharpBasic:OnClickClose", OnClickClose_IsValid);
	}

	static UI_CSharpBasic()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.Example.UI_CSharpBasic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.Example.UI_CSharpBasic));
	}
}
