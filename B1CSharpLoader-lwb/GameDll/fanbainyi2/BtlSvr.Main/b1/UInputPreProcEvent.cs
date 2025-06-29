using System;
using b1.Plugins.GSInput;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.InputPreProcEvent")]
public class UInputPreProcEvent : UObject
{
	private static bool OnKeyUpEvent_IsValid;

	private static IntPtr OnKeyUpEvent_FunctionAddress;

	private static int OnKeyUpEvent_ParamsSize;

	private static bool OnKeyUpEvent_InKeyEvent_IsValid;

	private static int OnKeyUpEvent_InKeyEvent_Offset;

	private static FFieldAddress OnKeyUpEvent_InKeyEvent_PropertyAddress;

	private static bool OnInputTrigger_IsValid;

	private static IntPtr OnInputTrigger_FunctionAddress;

	private static int OnInputTrigger_ParamsSize;

	private static bool OnInputTrigger_InputType_IsValid;

	private static int OnInputTrigger_InputType_Offset;

	private static FFieldAddress OnInputTrigger_InputType_PropertyAddress;

	private static bool OnKeyDownEvent_IsValid;

	private static IntPtr OnKeyDownEvent_FunctionAddress;

	private static int OnKeyDownEvent_ParamsSize;

	private static bool OnKeyDownEvent_InKeyEvent_IsValid;

	private static int OnKeyDownEvent_InKeyEvent_Offset;

	private static FFieldAddress OnKeyDownEvent_InKeyEvent_PropertyAddress;

	private static bool OnMouseMoveEvent_IsValid;

	private static IntPtr OnMouseMoveEvent_FunctionAddress;

	private static int OnMouseMoveEvent_ParamsSize;

	private static bool OnMouseMoveEvent_InMouseEvent_IsValid;

	private static int OnMouseMoveEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseMoveEvent_InMouseEvent_PropertyAddress;

	private static bool OnMouseWheelEvent_IsValid;

	private static IntPtr OnMouseWheelEvent_FunctionAddress;

	private static int OnMouseWheelEvent_ParamsSize;

	private static bool OnMouseWheelEvent_InMouseEvent_IsValid;

	private static int OnMouseWheelEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseWheelEvent_InMouseEvent_PropertyAddress;

	private static bool OnAnalogInputEvent_IsValid;

	private static IntPtr OnAnalogInputEvent_FunctionAddress;

	private static int OnAnalogInputEvent_ParamsSize;

	private static bool OnAnalogInputEvent_InAnalogInputEvent_IsValid;

	private static int OnAnalogInputEvent_InAnalogInputEvent_Offset;

	private static FFieldAddress OnAnalogInputEvent_InAnalogInputEvent_PropertyAddress;

	private static bool OnMouseButtonUpEvent_IsValid;

	private static IntPtr OnMouseButtonUpEvent_FunctionAddress;

	private static int OnMouseButtonUpEvent_ParamsSize;

	private static bool OnMouseButtonUpEvent_InMouseEvent_IsValid;

	private static int OnMouseButtonUpEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseButtonUpEvent_InMouseEvent_PropertyAddress;

	private static bool OnAnyKeyTriggerEvent_IsValid;

	private static IntPtr OnAnyKeyTriggerEvent_FunctionAddress;

	private static int OnAnyKeyTriggerEvent_ParamsSize;

	private static bool OnAnyKeyTriggerEvent_Key_IsValid;

	private static int OnAnyKeyTriggerEvent_Key_Offset;

	private static FFieldAddress OnAnyKeyTriggerEvent_Key_PropertyAddress;

	private static bool OnMouseButtonDownEvent_IsValid;

	private static IntPtr OnMouseButtonDownEvent_FunctionAddress;

	private static int OnMouseButtonDownEvent_ParamsSize;

	private static bool OnMouseButtonDownEvent_InMouseEvent_IsValid;

	private static int OnMouseButtonDownEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDownEvent_InMouseEvent_PropertyAddress;

	private static bool OnInputTypeChangeTrigger_IsValid;

	private static IntPtr OnInputTypeChangeTrigger_FunctionAddress;

	private static int OnInputTypeChangeTrigger_ParamsSize;

	private static bool OnInputTypeChangeTrigger_InputType_IsValid;

	private static int OnInputTypeChangeTrigger_InputType_Offset;

	private static FFieldAddress OnInputTypeChangeTrigger_InputType_PropertyAddress;

	private static bool OnMouseButtonDoubleClickEvent_IsValid;

	private static IntPtr OnMouseButtonDoubleClickEvent_FunctionAddress;

	private static int OnMouseButtonDoubleClickEvent_ParamsSize;

	private static bool OnMouseButtonDoubleClickEvent_InMouseEvent_IsValid;

	private static int OnMouseButtonDoubleClickEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDoubleClickEvent_InMouseEvent_PropertyAddress;

	private BGW_EventCollection EventCollection => BGW_EventCollection.Get(this);

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnInputTrigger")]
	public void OnInputTrigger(EGSInputType InputType)
	{
		EventCollection.Evt_OnInputTrigger(InputType);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnInputTypeChangeTrigger")]
	public void OnInputTypeChangeTrigger(EGSInputType InputType)
	{
		EventCollection.Evt_OnInputTypeChangeTrigger(InputType);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnKeyDownEvent")]
	public void OnKeyDownEvent(FKeyEvent InKeyEvent)
	{
		EventCollection.Evt_OnKeyDownEvent(InKeyEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnKeyUpEvent")]
	public void OnKeyUpEvent(FKeyEvent InKeyEvent)
	{
		EventCollection.Evt_OnKeyUpEvent(InKeyEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnAnalogInputEvent")]
	public void OnAnalogInputEvent(FAnalogInputEvent InAnalogInputEvent)
	{
		EventCollection.Evt_OnAnalogInputEvent(InAnalogInputEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnMouseMoveEvent")]
	public void OnMouseMoveEvent(FPointerEvent InMouseEvent)
	{
		EventCollection.Evt_OnMouseMoveEvent(InMouseEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonDownEvent")]
	public void OnMouseButtonDownEvent(FPointerEvent InMouseEvent)
	{
		EventCollection.Evt_OnMouseButtonDownEvent(InMouseEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonUpEvent")]
	public void OnMouseButtonUpEvent(FPointerEvent InMouseEvent)
	{
		EventCollection.Evt_OnMouseButtonUpEvent(InMouseEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonDoubleClickEvent")]
	public void OnMouseButtonDoubleClickEvent(FPointerEvent InMouseEvent)
	{
		EventCollection.Evt_OnMouseButtonDoubleClickEvent(InMouseEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnMouseWheelEvent")]
	public void OnMouseWheelEvent(FPointerEvent InMouseEvent)
	{
		EventCollection.Evt_OnMouseWheelEvent(InMouseEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.InputPreProcEvent:OnAnyKeyTriggerEvent")]
	public void OnAnyKeyTriggerEvent(FKey Key)
	{
		EventCollection.Evt_OnAnyKeyTrigger(Key);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnKeyUpEvent")]
	private static void OnKeyUpEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyUpEvent_InKeyEvent_Offset));
		uInputPreProcEvent.OnKeyUpEvent(inKeyEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnInputTrigger")]
	private static void OnInputTrigger__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		EGSInputType inputType = EnumMarshaler<EGSInputType>.FromNative(IntPtr.Add(buffer, OnInputTrigger_InputType_Offset), 0, OnInputTrigger_InputType_PropertyAddress.Address);
		uInputPreProcEvent.OnInputTrigger(inputType);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnKeyDownEvent")]
	private static void OnKeyDownEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyDownEvent_InKeyEvent_Offset));
		uInputPreProcEvent.OnKeyDownEvent(inKeyEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnMouseMoveEvent")]
	private static void OnMouseMoveEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseMoveEvent_InMouseEvent_Offset));
		uInputPreProcEvent.OnMouseMoveEvent(inMouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnMouseWheelEvent")]
	private static void OnMouseWheelEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseWheelEvent_InMouseEvent_Offset));
		uInputPreProcEvent.OnMouseWheelEvent(inMouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnAnalogInputEvent")]
	private static void OnAnalogInputEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FAnalogInputEvent inAnalogInputEvent = StructAsClassMarshaler<FAnalogInputEvent>.FromNative(IntPtr.Add(buffer, OnAnalogInputEvent_InAnalogInputEvent_Offset));
		uInputPreProcEvent.OnAnalogInputEvent(inAnalogInputEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonUpEvent")]
	private static void OnMouseButtonUpEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonUpEvent_InMouseEvent_Offset));
		uInputPreProcEvent.OnMouseButtonUpEvent(inMouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnAnyKeyTriggerEvent")]
	private static void OnAnyKeyTriggerEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FKey key = FKey.FromNative(IntPtr.Add(buffer, OnAnyKeyTriggerEvent_Key_Offset));
		uInputPreProcEvent.OnAnyKeyTriggerEvent(key);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonDownEvent")]
	private static void OnMouseButtonDownEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDownEvent_InMouseEvent_Offset));
		uInputPreProcEvent.OnMouseButtonDownEvent(inMouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnInputTypeChangeTrigger")]
	private static void OnInputTypeChangeTrigger__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		EGSInputType inputType = EnumMarshaler<EGSInputType>.FromNative(IntPtr.Add(buffer, OnInputTypeChangeTrigger_InputType_Offset), 0, OnInputTypeChangeTrigger_InputType_PropertyAddress.Address);
		uInputPreProcEvent.OnInputTypeChangeTrigger(inputType);
	}

	[UFunctionInvoker("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonDoubleClickEvent")]
	private static void OnMouseButtonDoubleClickEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UInputPreProcEvent uInputPreProcEvent = GCHelper.Find<UInputPreProcEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDoubleClickEvent_InMouseEvent_Offset));
		uInputPreProcEvent.OnMouseButtonDoubleClickEvent(inMouseEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.InputPreProcEvent");
		OnKeyUpEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnKeyUpEvent");
		OnKeyUpEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyUpEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyUpEvent_InKeyEvent_PropertyAddress, OnKeyUpEvent_FunctionAddress, "InKeyEvent");
		OnKeyUpEvent_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyUpEvent_FunctionAddress, "InKeyEvent");
		OnKeyUpEvent_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyUpEvent_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		OnKeyUpEvent_IsValid = OnKeyUpEvent_FunctionAddress != IntPtr.Zero && OnKeyUpEvent_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnKeyUpEvent", OnKeyUpEvent_IsValid);
		OnInputTrigger_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInputTrigger");
		OnInputTrigger_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputTrigger_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnInputTrigger_InputType_PropertyAddress, OnInputTrigger_FunctionAddress, "InputType");
		OnInputTrigger_InputType_Offset = NativeReflection.GetPropertyOffset(OnInputTrigger_FunctionAddress, "InputType");
		OnInputTrigger_InputType_IsValid = NativeReflection.ValidatePropertyClass(OnInputTrigger_FunctionAddress, "InputType", Classes.FEnumProperty);
		OnInputTrigger_IsValid = OnInputTrigger_FunctionAddress != IntPtr.Zero && OnInputTrigger_InputType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnInputTrigger", OnInputTrigger_IsValid);
		OnKeyDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnKeyDownEvent");
		OnKeyDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyDownEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyDownEvent_InKeyEvent_PropertyAddress, OnKeyDownEvent_FunctionAddress, "InKeyEvent");
		OnKeyDownEvent_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyDownEvent_FunctionAddress, "InKeyEvent");
		OnKeyDownEvent_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyDownEvent_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		OnKeyDownEvent_IsValid = OnKeyDownEvent_FunctionAddress != IntPtr.Zero && OnKeyDownEvent_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnKeyDownEvent", OnKeyDownEvent_IsValid);
		OnMouseMoveEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseMoveEvent");
		OnMouseMoveEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseMoveEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseMoveEvent_InMouseEvent_PropertyAddress, OnMouseMoveEvent_FunctionAddress, "InMouseEvent");
		OnMouseMoveEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseMoveEvent_FunctionAddress, "InMouseEvent");
		OnMouseMoveEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseMoveEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseMoveEvent_IsValid = OnMouseMoveEvent_FunctionAddress != IntPtr.Zero && OnMouseMoveEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnMouseMoveEvent", OnMouseMoveEvent_IsValid);
		OnMouseWheelEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseWheelEvent");
		OnMouseWheelEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseWheelEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseWheelEvent_InMouseEvent_PropertyAddress, OnMouseWheelEvent_FunctionAddress, "InMouseEvent");
		OnMouseWheelEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseWheelEvent_FunctionAddress, "InMouseEvent");
		OnMouseWheelEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseWheelEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseWheelEvent_IsValid = OnMouseWheelEvent_FunctionAddress != IntPtr.Zero && OnMouseWheelEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnMouseWheelEvent", OnMouseWheelEvent_IsValid);
		OnAnalogInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAnalogInputEvent");
		OnAnalogInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnalogInputEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAnalogInputEvent_InAnalogInputEvent_PropertyAddress, OnAnalogInputEvent_FunctionAddress, "InAnalogInputEvent");
		OnAnalogInputEvent_InAnalogInputEvent_Offset = NativeReflection.GetPropertyOffset(OnAnalogInputEvent_FunctionAddress, "InAnalogInputEvent");
		OnAnalogInputEvent_InAnalogInputEvent_IsValid = NativeReflection.ValidatePropertyClass(OnAnalogInputEvent_FunctionAddress, "InAnalogInputEvent", Classes.FStructProperty);
		OnAnalogInputEvent_IsValid = OnAnalogInputEvent_FunctionAddress != IntPtr.Zero && OnAnalogInputEvent_InAnalogInputEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnAnalogInputEvent", OnAnalogInputEvent_IsValid);
		OnMouseButtonUpEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonUpEvent");
		OnMouseButtonUpEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonUpEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUpEvent_InMouseEvent_PropertyAddress, OnMouseButtonUpEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonUpEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUpEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonUpEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUpEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseButtonUpEvent_IsValid = OnMouseButtonUpEvent_FunctionAddress != IntPtr.Zero && OnMouseButtonUpEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonUpEvent", OnMouseButtonUpEvent_IsValid);
		OnAnyKeyTriggerEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAnyKeyTriggerEvent");
		OnAnyKeyTriggerEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnyKeyTriggerEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAnyKeyTriggerEvent_Key_PropertyAddress, OnAnyKeyTriggerEvent_FunctionAddress, "Key");
		OnAnyKeyTriggerEvent_Key_Offset = NativeReflection.GetPropertyOffset(OnAnyKeyTriggerEvent_FunctionAddress, "Key");
		OnAnyKeyTriggerEvent_Key_IsValid = NativeReflection.ValidatePropertyClass(OnAnyKeyTriggerEvent_FunctionAddress, "Key", Classes.FStructProperty);
		OnAnyKeyTriggerEvent_IsValid = OnAnyKeyTriggerEvent_FunctionAddress != IntPtr.Zero && OnAnyKeyTriggerEvent_Key_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnAnyKeyTriggerEvent", OnAnyKeyTriggerEvent_IsValid);
		OnMouseButtonDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonDownEvent");
		OnMouseButtonDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDownEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDownEvent_InMouseEvent_PropertyAddress, OnMouseButtonDownEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonDownEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDownEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonDownEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDownEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseButtonDownEvent_IsValid = OnMouseButtonDownEvent_FunctionAddress != IntPtr.Zero && OnMouseButtonDownEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonDownEvent", OnMouseButtonDownEvent_IsValid);
		OnInputTypeChangeTrigger_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnInputTypeChangeTrigger");
		OnInputTypeChangeTrigger_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputTypeChangeTrigger_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnInputTypeChangeTrigger_InputType_PropertyAddress, OnInputTypeChangeTrigger_FunctionAddress, "InputType");
		OnInputTypeChangeTrigger_InputType_Offset = NativeReflection.GetPropertyOffset(OnInputTypeChangeTrigger_FunctionAddress, "InputType");
		OnInputTypeChangeTrigger_InputType_IsValid = NativeReflection.ValidatePropertyClass(OnInputTypeChangeTrigger_FunctionAddress, "InputType", Classes.FEnumProperty);
		OnInputTypeChangeTrigger_IsValid = OnInputTypeChangeTrigger_FunctionAddress != IntPtr.Zero && OnInputTypeChangeTrigger_InputType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnInputTypeChangeTrigger", OnInputTypeChangeTrigger_IsValid);
		OnMouseButtonDoubleClickEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonDoubleClickEvent");
		OnMouseButtonDoubleClickEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDoubleClickEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDoubleClickEvent_InMouseEvent_PropertyAddress, OnMouseButtonDoubleClickEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonDoubleClickEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDoubleClickEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonDoubleClickEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDoubleClickEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseButtonDoubleClickEvent_IsValid = OnMouseButtonDoubleClickEvent_FunctionAddress != IntPtr.Zero && OnMouseButtonDoubleClickEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.InputPreProcEvent:OnMouseButtonDoubleClickEvent", OnMouseButtonDoubleClickEvent_IsValid);
	}

	static UInputPreProcEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UInputPreProcEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputPreProcEvent));
	}
}
