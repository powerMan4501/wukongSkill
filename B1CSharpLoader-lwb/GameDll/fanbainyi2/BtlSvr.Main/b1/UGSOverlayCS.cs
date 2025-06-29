using System;
using b1.Plugins.GSInput;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UGSOverlayCS")]
public class UGSOverlayCS : UGSOverlay
{
	private static bool OnChildAddToGSOverlayCS_IsValid;

	private static IntPtr OnChildAddToGSOverlayCS_FunctionAddress;

	private static int OnChildAddToGSOverlayCS_ParamsSize;

	private static bool OnChildAddToGSOverlayCS_Widget_IsValid;

	private static int OnChildAddToGSOverlayCS_Widget_Offset;

	[USharpPath("/Script/b1-Managed.UGSOverlayCS:OnChildAddToGSOverlayCS")]
	protected override void OnChildAddToGSOverlayCS_Implementation(UWidget Widget)
	{
		if (Widget is UGSInputWidgetCS inputWidget)
		{
			BGW_EventCollection.Get(this).Evt_RegisterInputWidget(inputWidget);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSOverlayCS:OnChildAddToGSOverlayCS")]
	private static void OnChildAddToGSOverlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSOverlayCS uGSOverlayCS = GCHelper.Find<UGSOverlayCS>(obj);
		UWidget widget = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(buffer, OnChildAddToGSOverlayCS_Widget_Offset));
		uGSOverlayCS.OnChildAddToGSOverlayCS_Implementation(widget);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UGSOverlayCS");
		OnChildAddToGSOverlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnChildAddToGSOverlayCS");
		OnChildAddToGSOverlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnChildAddToGSOverlayCS_FunctionAddress);
		OnChildAddToGSOverlayCS_Widget_Offset = NativeReflection.GetPropertyOffset(OnChildAddToGSOverlayCS_FunctionAddress, "Widget");
		OnChildAddToGSOverlayCS_Widget_IsValid = NativeReflection.ValidatePropertyClass(OnChildAddToGSOverlayCS_FunctionAddress, "Widget", Classes.FObjectProperty);
		OnChildAddToGSOverlayCS_IsValid = OnChildAddToGSOverlayCS_FunctionAddress != IntPtr.Zero && OnChildAddToGSOverlayCS_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSOverlayCS:OnChildAddToGSOverlayCS", OnChildAddToGSOverlayCS_IsValid);
	}

	static UGSOverlayCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UGSOverlayCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSOverlayCS));
	}
}
