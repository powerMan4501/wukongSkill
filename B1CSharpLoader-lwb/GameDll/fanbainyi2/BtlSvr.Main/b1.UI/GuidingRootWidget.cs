using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GuidingRootWidget")]
public class GuidingRootWidget : BUI_Widget
{
	private UWidget maskWidget;

	private List<FVector2D> maskPositionList;

	private List<UWidget> guideWidgetList;

	private int curActivateWidgetIndex;

	private static bool OnInitialized_IsValid;

	private static IntPtr OnInitialized_FunctionAddress;

	private static int OnInitialized_ParamsSize;

	private static bool OnMouseButtonUp_IsValid;

	private static IntPtr OnMouseButtonUp_FunctionAddress;

	private static int OnMouseButtonUp_ParamsSize;

	private static bool OnMouseButtonUp_MyGeometry_IsValid;

	private static int OnMouseButtonUp_MyGeometry_Offset;

	private static FFieldAddress OnMouseButtonUp_MyGeometry_PropertyAddress;

	private static bool OnMouseButtonUp_MouseEvent_IsValid;

	private static int OnMouseButtonUp_MouseEvent_Offset;

	private static FFieldAddress OnMouseButtonUp_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonUp_ReturnValue_IsValid;

	private static int OnMouseButtonUp_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonUp_ReturnValue_PropertyAddress;

	private static bool OnMouseButtonDown_IsValid;

	private static IntPtr OnMouseButtonDown_FunctionAddress;

	private static int OnMouseButtonDown_ParamsSize;

	private static bool OnMouseButtonDown_MyGeometry_IsValid;

	private static int OnMouseButtonDown_MyGeometry_Offset;

	private static FFieldAddress OnMouseButtonDown_MyGeometry_PropertyAddress;

	private static bool OnMouseButtonDown_MouseEvent_IsValid;

	private static int OnMouseButtonDown_MouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDown_MouseEvent_PropertyAddress;

	private static bool OnMouseButtonDown_ReturnValue_IsValid;

	private static int OnMouseButtonDown_ReturnValue_Offset;

	private static FFieldAddress OnMouseButtonDown_ReturnValue_PropertyAddress;

	[USharpPath("/Script/b1-Managed.GuidingRootWidget:OnInitialized")]
	protected override void OnInitialized_Implementation()
	{
		guideWidgetList = new List<UWidget>();
		maskPositionList = new List<FVector2D>();
		UWidget widgetFromName = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.btn_Guiding_First);
		UWidget widgetFromName2 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.btn_Guiding_Second);
		UWidget widgetFromName3 = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.btn_Guiding_Third);
		if (widgetFromName != null)
		{
			guideWidgetList.Add(widgetFromName);
		}
		if (widgetFromName2 != null)
		{
			guideWidgetList.Add(widgetFromName2);
		}
		if (widgetFromName3 != null)
		{
			guideWidgetList.Add(widgetFromName3);
		}
		maskPositionList.Add(new FVector2D(108.0, 392.0));
		maskPositionList.Add(new FVector2D(-204.0, 72.0));
		maskPositionList.Add(new FVector2D(-56.0, 784.0));
		maskWidget = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.MaskWidget);
		MoveMaskToNextPos();
	}

	[USharpPath("/Script/b1-Managed.GuidingRootWidget:OnMouseButtonDown")]
	protected override FEventReply OnMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		if (guideWidgetList.Count <= 0)
		{
			UGSE_EngineFuncLib.LogError("GuideWidgetList is empty");
			return new FEventReply();
		}
		UWidget widget = guideWidgetList[curActivateWidgetIndex];
		InvokeWidgetButtonInputEvent(widget, 0, MyGeometry, MouseEvent);
		return new FEventReply();
	}

	[USharpPath("/Script/b1-Managed.GuidingRootWidget:OnMouseButtonUp")]
	protected override FEventReply OnMouseButtonUp_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		if (guideWidgetList.Count <= 0)
		{
			UGSE_EngineFuncLib.LogError("GuideWidgetList is empty");
			return new FEventReply();
		}
		UWidget widget = guideWidgetList[curActivateWidgetIndex++];
		InvokeWidgetButtonInputEvent(widget, 1, MyGeometry, MouseEvent);
		curActivateWidgetIndex %= guideWidgetList.Count;
		MoveMaskToNextPos();
		return new FEventReply();
	}

	private void InvokeWidgetButtonInputEvent(UWidget widget, int inputType, FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		if (widget != null)
		{
			UGSE_UMGFuncLib.InvokeWidgetInputEvent(widget, inputType, MyGeometry, MouseEvent);
		}
	}

	private void MoveMaskToNextPos()
	{
		if (maskPositionList != null && curActivateWidgetIndex < maskPositionList.Count && maskWidget != null)
		{
			UCanvasPanelSlot uCanvasPanelSlot = maskWidget.Slot.Cast<UCanvasPanelSlot>();
			if (uCanvasPanelSlot != null)
			{
				uCanvasPanelSlot.SetPosition(maskPositionList[curActivateWidgetIndex]);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GuidingRootWidget:OnInitialized")]
	private static void OnInitialized__Invoker(IntPtr buffer, IntPtr obj)
	{
		GuidingRootWidget guidingRootWidget = GCHelper.Find<GuidingRootWidget>(obj);
		guidingRootWidget.OnInitialized_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.GuidingRootWidget:OnMouseButtonUp")]
	private static void OnMouseButtonUp__Invoker(IntPtr buffer, IntPtr obj)
	{
		GuidingRootWidget guidingRootWidget = GCHelper.Find<GuidingRootWidget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MouseEvent_Offset));
		FEventReply value = guidingRootWidget.OnMouseButtonUp_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonUp_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GuidingRootWidget:OnMouseButtonDown")]
	private static void OnMouseButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		GuidingRootWidget guidingRootWidget = GCHelper.Find<GuidingRootWidget>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MouseEvent_Offset));
		FEventReply value = guidingRootWidget.OnMouseButtonDown_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonDown_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GuidingRootWidget");
		OnInitialized_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInitialized");
		OnInitialized_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInitialized_FunctionAddress);
		OnInitialized_IsValid = OnInitialized_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GuidingRootWidget:OnInitialized", OnInitialized_IsValid);
		OnMouseButtonUp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonUp");
		OnMouseButtonUp_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonUp_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_MyGeometry_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MyGeometry");
		OnMouseButtonUp_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_MouseEvent_PropertyAddress, OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "MouseEvent");
		OnMouseButtonUp_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUp_ReturnValue_PropertyAddress, OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUp_FunctionAddress, "ReturnValue");
		OnMouseButtonUp_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUp_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonUp_IsValid = OnMouseButtonUp_FunctionAddress != IntPtr.Zero && OnMouseButtonUp_MyGeometry_IsValid && OnMouseButtonUp_MouseEvent_IsValid && OnMouseButtonUp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GuidingRootWidget:OnMouseButtonUp", OnMouseButtonUp_IsValid);
		OnMouseButtonDown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonDown");
		OnMouseButtonDown_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDown_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_MyGeometry_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MyGeometry");
		OnMouseButtonDown_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_MouseEvent_PropertyAddress, OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "MouseEvent");
		OnMouseButtonDown_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDown_ReturnValue_PropertyAddress, OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDown_FunctionAddress, "ReturnValue");
		OnMouseButtonDown_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDown_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseButtonDown_IsValid = OnMouseButtonDown_FunctionAddress != IntPtr.Zero && OnMouseButtonDown_MyGeometry_IsValid && OnMouseButtonDown_MouseEvent_IsValid && OnMouseButtonDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GuidingRootWidget:OnMouseButtonDown", OnMouseButtonDown_IsValid);
	}

	static GuidingRootWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GuidingRootWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GuidingRootWidget));
	}
}
