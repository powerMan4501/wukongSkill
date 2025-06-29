using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_BarFloat")]
public class BUI_BarFloat : BUI_Widget
{
	public UWidgetAnimation Flash;

	public UImage FloatImage;

	public UNamedSlot FloatSlot;

	private static bool WAE_ShowInFinished_IsValid;

	private static int WAE_ShowInFinished_Offset;

	private FWidgetAnimationDynamicEvent WAE_ShowInFinished_DelegateCached;

	private static bool OnAnimationFinished_IsValid;

	private static IntPtr OnAnimationFinished_FunctionAddress;

	private static int OnAnimationFinished_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_BarFloat:WAE_ShowInFinished")]
	private FWidgetAnimationDynamicEvent WAE_ShowInFinished
	{
		get
		{
			CheckDestroyed();
			if (!WAE_ShowInFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_BarFloat:WAE_ShowInFinished");
				return null;
			}
			if (WAE_ShowInFinished_DelegateCached == null)
			{
				WAE_ShowInFinished_DelegateCached = new FWidgetAnimationDynamicEvent();
				WAE_ShowInFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, WAE_ShowInFinished_Offset));
			}
			return WAE_ShowInFinished_DelegateCached;
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		Flash = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "Flash");
		FloatImage = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FloatImage) as UImage;
		FloatSlot = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FloatSlot) as UNamedSlot;
		WAE_ShowInFinished.Bind(OnAnimationFinished);
	}

	protected override void OnUIInitialized()
	{
		Flash = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "Flash");
		FloatImage = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FloatImage) as UImage;
		FloatSlot = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.FloatSlot) as UNamedSlot;
		WAE_ShowInFinished.Bind(OnAnimationFinished);
	}

	public void InitSetFloatImage(FSlateBrush InBrush, FWidgetTransform InTransForm)
	{
		FloatImage.SetBrush(InBrush);
		FloatImage.SetRenderTransform(InTransForm);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_BarFloat:OnAnimationFinished")]
	private void OnAnimationFinished()
	{
		RemoveFromParent();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_BarFloat:OnAnimationFinished")]
	private static void OnAnimationFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_BarFloat bUI_BarFloat = GCHelper.Find<BUI_BarFloat>(obj);
		bUI_BarFloat.OnAnimationFinished();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_BarFloat");
		WAE_ShowInFinished_Offset = NativeReflection.GetPropertyOffset(intPtr, "WAE_ShowInFinished");
		WAE_ShowInFinished_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WAE_ShowInFinished", Classes.FDelegateProperty);
		OnAnimationFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAnimationFinished");
		OnAnimationFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnimationFinished_FunctionAddress);
		OnAnimationFinished_IsValid = OnAnimationFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_BarFloat:OnAnimationFinished", OnAnimationFinished_IsValid);
	}

	static BUI_BarFloat()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_BarFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_BarFloat));
	}
}
