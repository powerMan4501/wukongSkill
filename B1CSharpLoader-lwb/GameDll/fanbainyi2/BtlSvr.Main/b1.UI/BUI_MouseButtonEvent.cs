using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent")]
public class BUI_MouseButtonEvent : UUserWidget
{
	public Action<FGeometry, FPointerEvent> Evt_MouseButtonDown;

	public Action<FGeometry, FPointerEvent> Evt_MouseButtonUp;

	public Action<FGeometry, FPointerEvent> Evt_MouseEnter;

	public Action<FPointerEvent> Evt_MouseLeave;

	public Action<FGeometry, FPointerEvent> Evt_MouseMove;

	public Action<int> Evt_OnUIAnimSequence;

	public Action<float> Evt_UITick;

	private static bool Tick_IsValid;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_MyGeometry_IsValid;

	private static int Tick_MyGeometry_Offset;

	private static FFieldAddress Tick_MyGeometry_PropertyAddress;

	private static bool Tick_InDeltaTime_IsValid;

	private static int Tick_InDeltaTime_Offset;

	private static bool OnMouseMove_IsValid;

	private static IntPtr OnMouseMove_FunctionAddress;

	private static int OnMouseMove_ParamsSize;

	private static bool OnMouseMove_MyGeometry_IsValid;

	private static int OnMouseMove_MyGeometry_Offset;

	private static FFieldAddress OnMouseMove_MyGeometry_PropertyAddress;

	private static bool OnMouseMove_MouseEvent_IsValid;

	private static int OnMouseMove_MouseEvent_Offset;

	private static FFieldAddress OnMouseMove_MouseEvent_PropertyAddress;

	private static bool OnMouseMove_ReturnValue_IsValid;

	private static int OnMouseMove_ReturnValue_Offset;

	private static FFieldAddress OnMouseMove_ReturnValue_PropertyAddress;

	private static bool OnMouseEnter_IsValid;

	private static IntPtr OnMouseEnter_FunctionAddress;

	private static int OnMouseEnter_ParamsSize;

	private static bool OnMouseEnter_MyGeometry_IsValid;

	private static int OnMouseEnter_MyGeometry_Offset;

	private static FFieldAddress OnMouseEnter_MyGeometry_PropertyAddress;

	private static bool OnMouseEnter_MouseEvent_IsValid;

	private static int OnMouseEnter_MouseEvent_Offset;

	private static FFieldAddress OnMouseEnter_MouseEvent_PropertyAddress;

	private static bool OnMouseLeave_IsValid;

	private static IntPtr OnMouseLeave_FunctionAddress;

	private static int OnMouseLeave_ParamsSize;

	private static bool OnMouseLeave_MouseEvent_IsValid;

	private static int OnMouseLeave_MouseEvent_Offset;

	private static FFieldAddress OnMouseLeave_MouseEvent_PropertyAddress;

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

	private static bool OnUserWidgetAnimationSequenceEvent_IsValid;

	private static IntPtr OnUserWidgetAnimationSequenceEvent_FunctionAddress;

	private static int OnUserWidgetAnimationSequenceEvent_ParamsSize;

	private static bool OnUserWidgetAnimationSequenceEvent_Param_IsValid;

	private static int OnUserWidgetAnimationSequenceEvent_Param_Offset;

	[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseButtonDown")]
	protected override FEventReply OnMouseButtonDown_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		Evt_MouseButtonDown?.Invoke(MyGeometry, MouseEvent);
		return UGSE_UMGFuncLib.MakeEventReply(IsHandled: true);
	}

	[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseButtonUp")]
	protected override FEventReply OnMouseButtonUp_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		Evt_MouseButtonUp?.Invoke(MyGeometry, MouseEvent);
		return base.OnMouseButtonUp_Implementation(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseEnter")]
	protected override void OnMouseEnter_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		Evt_MouseEnter?.Invoke(MyGeometry, MouseEvent);
		base.OnMouseEnter_Implementation(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseLeave")]
	protected override void OnMouseLeave_Implementation(FPointerEvent MouseEvent)
	{
		Evt_MouseLeave?.Invoke(MouseEvent);
		base.OnMouseLeave_Implementation(MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseMove")]
	protected override FEventReply OnMouseMove_Implementation(FGeometry MyGeometry, FPointerEvent MouseEvent)
	{
		Evt_MouseMove?.Invoke(MyGeometry, MouseEvent);
		return base.OnMouseMove_Implementation(MyGeometry, MouseEvent);
	}

	[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent:Tick")]
	protected override void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
	{
		Evt_UITick?.Invoke(InDeltaTime);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_MouseButtonEvent:OnUserWidgetAnimationSequenceEvent")]
	public void OnUserWidgetAnimationSequenceEvent(int Param)
	{
		Evt_OnUIAnimSequence?.Invoke(Param);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MouseButtonEvent:Tick")]
	private static void Tick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MouseButtonEvent bUI_MouseButtonEvent = GCHelper.Find<BUI_MouseButtonEvent>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, Tick_MyGeometry_Offset));
		float inDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, Tick_InDeltaTime_Offset));
		bUI_MouseButtonEvent.Tick_Implementation(myGeometry, inDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseMove")]
	private static void OnMouseMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MouseButtonEvent bUI_MouseButtonEvent = GCHelper.Find<BUI_MouseButtonEvent>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseMove_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseMove_MouseEvent_Offset));
		FEventReply value = bUI_MouseButtonEvent.OnMouseMove_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseMove_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseEnter")]
	private static void OnMouseEnter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MouseButtonEvent bUI_MouseButtonEvent = GCHelper.Find<BUI_MouseButtonEvent>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseEnter_MouseEvent_Offset));
		bUI_MouseButtonEvent.OnMouseEnter_Implementation(myGeometry, mouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseLeave")]
	private static void OnMouseLeave__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MouseButtonEvent bUI_MouseButtonEvent = GCHelper.Find<BUI_MouseButtonEvent>(obj);
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseLeave_MouseEvent_Offset));
		bUI_MouseButtonEvent.OnMouseLeave_Implementation(mouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseButtonUp")]
	private static void OnMouseButtonUp__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MouseButtonEvent bUI_MouseButtonEvent = GCHelper.Find<BUI_MouseButtonEvent>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonUp_MouseEvent_Offset));
		FEventReply value = bUI_MouseButtonEvent.OnMouseButtonUp_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonUp_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseButtonDown")]
	private static void OnMouseButtonDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MouseButtonEvent bUI_MouseButtonEvent = GCHelper.Find<BUI_MouseButtonEvent>(obj);
		FGeometry myGeometry = StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MyGeometry_Offset));
		FPointerEvent mouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDown_MouseEvent_Offset));
		FEventReply value = bUI_MouseButtonEvent.OnMouseButtonDown_Implementation(myGeometry, mouseEvent);
		StructAsClassMarshaler<FEventReply>.ToNative(IntPtr.Add(buffer, OnMouseButtonDown_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MouseButtonEvent:OnUserWidgetAnimationSequenceEvent")]
	private static void OnUserWidgetAnimationSequenceEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MouseButtonEvent bUI_MouseButtonEvent = GCHelper.Find<BUI_MouseButtonEvent>(obj);
		int param = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnUserWidgetAnimationSequenceEvent_Param_Offset));
		bUI_MouseButtonEvent.OnUserWidgetAnimationSequenceEvent(param);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUI_MouseButtonEvent");
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflection.GetPropertyRef(ref Tick_MyGeometry_PropertyAddress, Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_Offset = NativeReflection.GetPropertyOffset(Tick_FunctionAddress, "MyGeometry");
		Tick_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(Tick_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		Tick_InDeltaTime_Offset = NativeReflection.GetPropertyOffset(Tick_FunctionAddress, "InDeltaTime");
		Tick_InDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(Tick_FunctionAddress, "InDeltaTime", Classes.FFloatProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_MyGeometry_IsValid && Tick_InDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MouseButtonEvent:Tick", Tick_IsValid);
		OnMouseMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseMove");
		OnMouseMove_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseMove_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseMove_MyGeometry_PropertyAddress, OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "MyGeometry");
		OnMouseMove_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseMove_MouseEvent_PropertyAddress, OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "MouseEvent");
		OnMouseMove_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseMove_ReturnValue_PropertyAddress, OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_Offset = NativeReflection.GetPropertyOffset(OnMouseMove_FunctionAddress, "ReturnValue");
		OnMouseMove_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMove_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OnMouseMove_IsValid = OnMouseMove_FunctionAddress != IntPtr.Zero && OnMouseMove_MyGeometry_IsValid && OnMouseMove_MouseEvent_IsValid && OnMouseMove_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseMove", OnMouseMove_IsValid);
		OnMouseEnter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseEnter");
		OnMouseEnter_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseEnter_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MyGeometry_PropertyAddress, OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MyGeometry");
		OnMouseEnter_MyGeometry_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MyGeometry", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnMouseEnter_MouseEvent_PropertyAddress, OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseEnter_FunctionAddress, "MouseEvent");
		OnMouseEnter_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseEnter_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseEnter_IsValid = OnMouseEnter_FunctionAddress != IntPtr.Zero && OnMouseEnter_MyGeometry_IsValid && OnMouseEnter_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseEnter", OnMouseEnter_IsValid);
		OnMouseLeave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseLeave");
		OnMouseLeave_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseLeave_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseLeave_MouseEvent_PropertyAddress, OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseLeave_FunctionAddress, "MouseEvent");
		OnMouseLeave_MouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseLeave_FunctionAddress, "MouseEvent", Classes.FStructProperty);
		OnMouseLeave_IsValid = OnMouseLeave_FunctionAddress != IntPtr.Zero && OnMouseLeave_MouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseLeave", OnMouseLeave_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseButtonUp", OnMouseButtonUp_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MouseButtonEvent:OnMouseButtonDown", OnMouseButtonDown_IsValid);
		OnUserWidgetAnimationSequenceEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnUserWidgetAnimationSequenceEvent");
		OnUserWidgetAnimationSequenceEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUserWidgetAnimationSequenceEvent_FunctionAddress);
		OnUserWidgetAnimationSequenceEvent_Param_Offset = NativeReflection.GetPropertyOffset(OnUserWidgetAnimationSequenceEvent_FunctionAddress, "Param");
		OnUserWidgetAnimationSequenceEvent_Param_IsValid = NativeReflection.ValidatePropertyClass(OnUserWidgetAnimationSequenceEvent_FunctionAddress, "Param", Classes.FIntProperty);
		OnUserWidgetAnimationSequenceEvent_IsValid = OnUserWidgetAnimationSequenceEvent_FunctionAddress != IntPtr.Zero && OnUserWidgetAnimationSequenceEvent_Param_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MouseButtonEvent:OnUserWidgetAnimationSequenceEvent", OnUserWidgetAnimationSequenceEvent_IsValid);
	}

	static BUI_MouseButtonEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MouseButtonEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MouseButtonEvent));
	}
}
