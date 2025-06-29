using System;
using System.Collections.Generic;
using b1.Plugins.GSInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UGSKeyEvent")]
public class UGSKeyEvent : UObject
{
	private FInputDelegate.AnalogEvent _analogEvent = delegate
	{
	};

	private FInputDelegate.KeyDown _keyDownEvent = delegate
	{
	};

	private FInputDelegate.KeyUp _keyUpEvent = delegate
	{
	};

	private FInputDelegate.MouseButtonDown _mouseDownEvent = delegate
	{
	};

	private FInputDelegate.MouseButtonUp _mouseUpEvent = delegate
	{
	};

	private FInputDelegate.MouseWheelEvent _mouseWheelEvent = delegate
	{
	};

	private UGSInputPreProc _inputPreProc;

	private Dictionary<IntPtr, List<Delegate>> _widgetBindEventsDic;

	private static bool OnKeyUpEvent_IsValid;

	private static IntPtr OnKeyUpEvent_FunctionAddress;

	private static int OnKeyUpEvent_ParamsSize;

	private static bool OnKeyUpEvent_InKeyEvent_IsValid;

	private static int OnKeyUpEvent_InKeyEvent_Offset;

	private static FFieldAddress OnKeyUpEvent_InKeyEvent_PropertyAddress;

	private static bool OnKeyDownEvent_IsValid;

	private static IntPtr OnKeyDownEvent_FunctionAddress;

	private static int OnKeyDownEvent_ParamsSize;

	private static bool OnKeyDownEvent_InKeyEvent_IsValid;

	private static int OnKeyDownEvent_InKeyEvent_Offset;

	private static FFieldAddress OnKeyDownEvent_InKeyEvent_PropertyAddress;

	private static bool OnMouseUpEvent_IsValid;

	private static IntPtr OnMouseUpEvent_FunctionAddress;

	private static int OnMouseUpEvent_ParamsSize;

	private static bool OnMouseUpEvent_InMouseEvent_IsValid;

	private static int OnMouseUpEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseUpEvent_InMouseEvent_PropertyAddress;

	private static bool OnMouseDownEvent_IsValid;

	private static IntPtr OnMouseDownEvent_FunctionAddress;

	private static int OnMouseDownEvent_ParamsSize;

	private static bool OnMouseDownEvent_InMouseEvent_IsValid;

	private static int OnMouseDownEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseDownEvent_InMouseEvent_PropertyAddress;

	private static bool OnMouseWheelEvent_IsValid;

	private static IntPtr OnMouseWheelEvent_FunctionAddress;

	private static int OnMouseWheelEvent_ParamsSize;

	private static bool OnMouseWheelEvent_InWheelEvent_IsValid;

	private static int OnMouseWheelEvent_InWheelEvent_Offset;

	private static FFieldAddress OnMouseWheelEvent_InWheelEvent_PropertyAddress;

	private static bool OnAnalogInputEvent_IsValid;

	private static IntPtr OnAnalogInputEvent_FunctionAddress;

	private static int OnAnalogInputEvent_ParamsSize;

	private static bool OnAnalogInputEvent_AnalogInputEvent_IsValid;

	private static int OnAnalogInputEvent_AnalogInputEvent_Offset;

	private static FFieldAddress OnAnalogInputEvent_AnalogInputEvent_PropertyAddress;

	public void BindEvent<T>(T Event, UGSInputWidgetCS InputWidget) where T : Delegate
	{
		if (Event is FInputDelegate.AnalogEvent b)
		{
			_analogEvent = (FInputDelegate.AnalogEvent)Delegate.Combine(_analogEvent, b);
		}
		else if (Event is FInputDelegate.KeyDown b2)
		{
			_keyDownEvent = (FInputDelegate.KeyDown)Delegate.Combine(_keyDownEvent, b2);
		}
		else if (Event is FInputDelegate.KeyUp b3)
		{
			_keyUpEvent = (FInputDelegate.KeyUp)Delegate.Combine(_keyUpEvent, b3);
		}
		else if (Event is FInputDelegate.MouseButtonDown b4)
		{
			_mouseDownEvent = (FInputDelegate.MouseButtonDown)Delegate.Combine(_mouseDownEvent, b4);
		}
		else if (Event is FInputDelegate.MouseButtonUp b5)
		{
			_mouseUpEvent = (FInputDelegate.MouseButtonUp)Delegate.Combine(_mouseUpEvent, b5);
		}
		else
		{
			if (!(Event is FInputDelegate.MouseWheelEvent b6))
			{
				throw new Exception($"Bind event fail because the type of {Event} is not support!");
			}
			_mouseWheelEvent = (FInputDelegate.MouseWheelEvent)Delegate.Combine(_mouseWheelEvent, b6);
		}
		IntPtr address = InputWidget.Address;
		if (_widgetBindEventsDic.ContainsKey(address))
		{
			if (!_widgetBindEventsDic[address].Contains(Event))
			{
				_widgetBindEventsDic[address].Add(Event);
			}
		}
		else
		{
			_widgetBindEventsDic.Add(address, new List<Delegate> { Event });
		}
	}

	public void UnbindEvent(UGSInputWidgetCS InputWidget)
	{
		IntPtr address = InputWidget.Address;
		if (!_widgetBindEventsDic.TryGetValue(address, out var value))
		{
			return;
		}
		foreach (Delegate item in value)
		{
			if (item is FInputDelegate.AnalogEvent value2)
			{
				_analogEvent = (FInputDelegate.AnalogEvent)Delegate.Remove(_analogEvent, value2);
			}
			else if (item is FInputDelegate.KeyDown value3)
			{
				_keyDownEvent = (FInputDelegate.KeyDown)Delegate.Remove(_keyDownEvent, value3);
			}
			else if (item is FInputDelegate.KeyUp value4)
			{
				_keyUpEvent = (FInputDelegate.KeyUp)Delegate.Remove(_keyUpEvent, value4);
			}
			else if (item is FInputDelegate.MouseButtonDown value5)
			{
				_mouseDownEvent = (FInputDelegate.MouseButtonDown)Delegate.Remove(_mouseDownEvent, value5);
			}
			else if (item is FInputDelegate.MouseButtonUp value6)
			{
				_mouseUpEvent = (FInputDelegate.MouseButtonUp)Delegate.Remove(_mouseUpEvent, value6);
			}
		}
	}

	public void BindEventOnInputPreProc(FInputPreProcTracker InputPreProcTracker)
	{
		_inputPreProc = InputPreProcTracker.InputPreProc;
		_widgetBindEventsDic = new Dictionary<IntPtr, List<Delegate>>();
		_inputPreProc?.OnAnalogInputEvent.Bind(OnAnalogInputEvent);
		_inputPreProc?.OnKeyDownEvent.Bind(OnKeyDownEvent);
		_inputPreProc?.OnKeyUpEvent.Bind(OnKeyUpEvent);
		_inputPreProc?.OnMouseButtonDownEvent.Bind(OnMouseDownEvent);
		_inputPreProc?.OnMouseButtonUpEvent.Bind(OnMouseUpEvent);
		_inputPreProc?.OnMouseWheelEvent.Bind(OnMouseWheelEvent);
	}

	public void UnbindEventOnInputPreProc(bool IsShutdown)
	{
		if (IsShutdown)
		{
			_inputPreProc?.OnAnalogInputEvent.Unbind(OnAnalogInputEvent);
			_inputPreProc?.OnKeyDownEvent.Unbind(OnKeyDownEvent);
			_inputPreProc?.OnKeyUpEvent.Unbind(OnKeyUpEvent);
			_inputPreProc?.OnMouseButtonDownEvent.Unbind(OnMouseDownEvent);
			_inputPreProc?.OnMouseButtonUpEvent.Unbind(OnMouseUpEvent);
			_inputPreProc?.OnMouseWheelEvent.Unbind(OnMouseWheelEvent);
		}
		_widgetBindEventsDic.Clear();
		_analogEvent = null;
		_keyDownEvent = null;
		_keyUpEvent = null;
		_mouseDownEvent = null;
		_mouseUpEvent = null;
		_mouseWheelEvent = null;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSKeyEvent:OnAnalogInputEvent")]
	private void OnAnalogInputEvent(FAnalogInputEvent AnalogInputEvent)
	{
		_analogEvent?.Invoke(AnalogInputEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSKeyEvent:OnKeyUpEvent")]
	private void OnKeyUpEvent(FKeyEvent InKeyEvent)
	{
		_keyUpEvent?.Invoke(InKeyEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSKeyEvent:OnKeyDownEvent")]
	private void OnKeyDownEvent(FKeyEvent InKeyEvent)
	{
		if (!UGSE_UINavigationFuncLib.IsRepeatAction(InKeyEvent))
		{
			_keyDownEvent?.Invoke(InKeyEvent);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSKeyEvent:OnMouseDownEvent")]
	private void OnMouseDownEvent(FPointerEvent InMouseEvent)
	{
		_mouseDownEvent?.Invoke(InMouseEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSKeyEvent:OnMouseUpEvent")]
	private void OnMouseUpEvent(FPointerEvent InMouseEvent)
	{
		_mouseUpEvent?.Invoke(InMouseEvent);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSKeyEvent:OnMouseWheelEvent")]
	private void OnMouseWheelEvent(FPointerEvent InWheelEvent)
	{
		_mouseWheelEvent?.Invoke(InWheelEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSKeyEvent:OnKeyUpEvent")]
	private static void OnKeyUpEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSKeyEvent uGSKeyEvent = GCHelper.Find<UGSKeyEvent>(obj);
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyUpEvent_InKeyEvent_Offset));
		uGSKeyEvent.OnKeyUpEvent(inKeyEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSKeyEvent:OnKeyDownEvent")]
	private static void OnKeyDownEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSKeyEvent uGSKeyEvent = GCHelper.Find<UGSKeyEvent>(obj);
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyDownEvent_InKeyEvent_Offset));
		uGSKeyEvent.OnKeyDownEvent(inKeyEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSKeyEvent:OnMouseUpEvent")]
	private static void OnMouseUpEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSKeyEvent uGSKeyEvent = GCHelper.Find<UGSKeyEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseUpEvent_InMouseEvent_Offset));
		uGSKeyEvent.OnMouseUpEvent(inMouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSKeyEvent:OnMouseDownEvent")]
	private static void OnMouseDownEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSKeyEvent uGSKeyEvent = GCHelper.Find<UGSKeyEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseDownEvent_InMouseEvent_Offset));
		uGSKeyEvent.OnMouseDownEvent(inMouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSKeyEvent:OnMouseWheelEvent")]
	private static void OnMouseWheelEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSKeyEvent uGSKeyEvent = GCHelper.Find<UGSKeyEvent>(obj);
		FPointerEvent inWheelEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseWheelEvent_InWheelEvent_Offset));
		uGSKeyEvent.OnMouseWheelEvent(inWheelEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSKeyEvent:OnAnalogInputEvent")]
	private static void OnAnalogInputEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSKeyEvent uGSKeyEvent = GCHelper.Find<UGSKeyEvent>(obj);
		FAnalogInputEvent analogInputEvent = StructAsClassMarshaler<FAnalogInputEvent>.FromNative(IntPtr.Add(buffer, OnAnalogInputEvent_AnalogInputEvent_Offset));
		uGSKeyEvent.OnAnalogInputEvent(analogInputEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UGSKeyEvent");
		OnKeyUpEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnKeyUpEvent");
		OnKeyUpEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyUpEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyUpEvent_InKeyEvent_PropertyAddress, OnKeyUpEvent_FunctionAddress, "InKeyEvent");
		OnKeyUpEvent_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyUpEvent_FunctionAddress, "InKeyEvent");
		OnKeyUpEvent_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyUpEvent_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		OnKeyUpEvent_IsValid = OnKeyUpEvent_FunctionAddress != IntPtr.Zero && OnKeyUpEvent_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSKeyEvent:OnKeyUpEvent", OnKeyUpEvent_IsValid);
		OnKeyDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnKeyDownEvent");
		OnKeyDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyDownEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyDownEvent_InKeyEvent_PropertyAddress, OnKeyDownEvent_FunctionAddress, "InKeyEvent");
		OnKeyDownEvent_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyDownEvent_FunctionAddress, "InKeyEvent");
		OnKeyDownEvent_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyDownEvent_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		OnKeyDownEvent_IsValid = OnKeyDownEvent_FunctionAddress != IntPtr.Zero && OnKeyDownEvent_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSKeyEvent:OnKeyDownEvent", OnKeyDownEvent_IsValid);
		OnMouseUpEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseUpEvent");
		OnMouseUpEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseUpEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseUpEvent_InMouseEvent_PropertyAddress, OnMouseUpEvent_FunctionAddress, "InMouseEvent");
		OnMouseUpEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseUpEvent_FunctionAddress, "InMouseEvent");
		OnMouseUpEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseUpEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseUpEvent_IsValid = OnMouseUpEvent_FunctionAddress != IntPtr.Zero && OnMouseUpEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSKeyEvent:OnMouseUpEvent", OnMouseUpEvent_IsValid);
		OnMouseDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseDownEvent");
		OnMouseDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseDownEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseDownEvent_InMouseEvent_PropertyAddress, OnMouseDownEvent_FunctionAddress, "InMouseEvent");
		OnMouseDownEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseDownEvent_FunctionAddress, "InMouseEvent");
		OnMouseDownEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseDownEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseDownEvent_IsValid = OnMouseDownEvent_FunctionAddress != IntPtr.Zero && OnMouseDownEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSKeyEvent:OnMouseDownEvent", OnMouseDownEvent_IsValid);
		OnMouseWheelEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseWheelEvent");
		OnMouseWheelEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseWheelEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseWheelEvent_InWheelEvent_PropertyAddress, OnMouseWheelEvent_FunctionAddress, "InWheelEvent");
		OnMouseWheelEvent_InWheelEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseWheelEvent_FunctionAddress, "InWheelEvent");
		OnMouseWheelEvent_InWheelEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseWheelEvent_FunctionAddress, "InWheelEvent", Classes.FStructProperty);
		OnMouseWheelEvent_IsValid = OnMouseWheelEvent_FunctionAddress != IntPtr.Zero && OnMouseWheelEvent_InWheelEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSKeyEvent:OnMouseWheelEvent", OnMouseWheelEvent_IsValid);
		OnAnalogInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAnalogInputEvent");
		OnAnalogInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAnalogInputEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnAnalogInputEvent_AnalogInputEvent_PropertyAddress, OnAnalogInputEvent_FunctionAddress, "AnalogInputEvent");
		OnAnalogInputEvent_AnalogInputEvent_Offset = NativeReflection.GetPropertyOffset(OnAnalogInputEvent_FunctionAddress, "AnalogInputEvent");
		OnAnalogInputEvent_AnalogInputEvent_IsValid = NativeReflection.ValidatePropertyClass(OnAnalogInputEvent_FunctionAddress, "AnalogInputEvent", Classes.FStructProperty);
		OnAnalogInputEvent_IsValid = OnAnalogInputEvent_FunctionAddress != IntPtr.Zero && OnAnalogInputEvent_AnalogInputEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSKeyEvent:OnAnalogInputEvent", OnAnalogInputEvent_IsValid);
	}

	static UGSKeyEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UGSKeyEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSKeyEvent));
	}
}
