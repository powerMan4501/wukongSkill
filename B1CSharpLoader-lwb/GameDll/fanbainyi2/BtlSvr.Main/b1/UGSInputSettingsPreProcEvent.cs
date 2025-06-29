using System;
using b1.Plugins.GSInput;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UGSInputSettingsPreProcEvent")]
public class UGSInputSettingsPreProcEvent : UObject
{
	private Action<FName> _pressFunc;

	private Action<FName> _releaseFunc;

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

	private static bool OnMouseButtonUpEvent_IsValid;

	private static IntPtr OnMouseButtonUpEvent_FunctionAddress;

	private static int OnMouseButtonUpEvent_ParamsSize;

	private static bool OnMouseButtonUpEvent_InMouseEvent_IsValid;

	private static int OnMouseButtonUpEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseButtonUpEvent_InMouseEvent_PropertyAddress;

	private static bool OnMouseButtonDownEvent_IsValid;

	private static IntPtr OnMouseButtonDownEvent_FunctionAddress;

	private static int OnMouseButtonDownEvent_ParamsSize;

	private static bool OnMouseButtonDownEvent_InMouseEvent_IsValid;

	private static int OnMouseButtonDownEvent_InMouseEvent_Offset;

	private static FFieldAddress OnMouseButtonDownEvent_InMouseEvent_PropertyAddress;

	private APlayerController LocalPlayerController => UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);

	private UGSInputSettingPreProc InputPreProc => UGSE_InputFuncLib.GetInputSettingPreProc(this);

	public void BindAction(Action<FName> PressFunc, Action<FName> ReleaseFunc)
	{
		UGSE_InputFuncLib.RegisterGSInputProc(this, EGSInputProcOrder.Setting);
		if (!InputPreProc.IsNullOrDestroyed())
		{
			InputPreProc?.OnKeyDownEvent.Bind(OnKeyDownEvent);
			InputPreProc?.OnKeyUpEvent.Bind(OnKeyUpEvent);
			InputPreProc?.OnMouseButtonDownEvent.Bind(OnMouseButtonDownEvent);
			InputPreProc?.OnMouseButtonUpEvent.Bind(OnMouseButtonUpEvent);
			_pressFunc = PressFunc;
			_releaseFunc = ReleaseFunc;
		}
	}

	public void UnbindAction()
	{
		if (!InputPreProc.IsNullOrDestroyed())
		{
			_pressFunc = null;
			_releaseFunc = null;
			InputPreProc?.OnKeyDownEvent.Unbind(OnKeyDownEvent);
			InputPreProc?.OnKeyUpEvent.Unbind(OnKeyUpEvent);
			InputPreProc?.OnMouseButtonDownEvent.Unbind(OnMouseButtonDownEvent);
			InputPreProc?.OnMouseButtonUpEvent.Unbind(OnMouseButtonUpEvent);
			UGSE_InputFuncLib.FlushPressedInput(LocalPlayerController);
		}
		UGSE_InputFuncLib.UnRegisterGSInputProc(this, EGSInputProcOrder.Setting);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnKeyUpEvent")]
	private void OnKeyUpEvent(FKeyEvent InKeyEvent)
	{
		_releaseFunc?.Invoke(UGSE_InputFuncLib.GetKeyByKeyEvent(InKeyEvent));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnKeyDownEvent")]
	private void OnKeyDownEvent(FKeyEvent InKeyEvent)
	{
		_pressFunc?.Invoke(UGSE_InputFuncLib.GetKeyByKeyEvent(InKeyEvent));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnMouseButtonUpEvent")]
	private void OnMouseButtonUpEvent(FPointerEvent InMouseEvent)
	{
		_releaseFunc?.Invoke(UGSE_InputFuncLib.GetKeyByPointerEvent(InMouseEvent));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnMouseButtonDownEvent")]
	private void OnMouseButtonDownEvent(FPointerEvent InMouseEvent)
	{
		_pressFunc?.Invoke(UGSE_InputFuncLib.GetKeyByPointerEvent(InMouseEvent));
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnKeyUpEvent")]
	private static void OnKeyUpEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSInputSettingsPreProcEvent uGSInputSettingsPreProcEvent = GCHelper.Find<UGSInputSettingsPreProcEvent>(obj);
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyUpEvent_InKeyEvent_Offset));
		uGSInputSettingsPreProcEvent.OnKeyUpEvent(inKeyEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnKeyDownEvent")]
	private static void OnKeyDownEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSInputSettingsPreProcEvent uGSInputSettingsPreProcEvent = GCHelper.Find<UGSInputSettingsPreProcEvent>(obj);
		FKeyEvent inKeyEvent = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, OnKeyDownEvent_InKeyEvent_Offset));
		uGSInputSettingsPreProcEvent.OnKeyDownEvent(inKeyEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnMouseButtonUpEvent")]
	private static void OnMouseButtonUpEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSInputSettingsPreProcEvent uGSInputSettingsPreProcEvent = GCHelper.Find<UGSInputSettingsPreProcEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonUpEvent_InMouseEvent_Offset));
		uGSInputSettingsPreProcEvent.OnMouseButtonUpEvent(inMouseEvent);
	}

	[UFunctionInvoker("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnMouseButtonDownEvent")]
	private static void OnMouseButtonDownEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UGSInputSettingsPreProcEvent uGSInputSettingsPreProcEvent = GCHelper.Find<UGSInputSettingsPreProcEvent>(obj);
		FPointerEvent inMouseEvent = StructAsClassMarshaler<FPointerEvent>.FromNative(IntPtr.Add(buffer, OnMouseButtonDownEvent_InMouseEvent_Offset));
		uGSInputSettingsPreProcEvent.OnMouseButtonDownEvent(inMouseEvent);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UGSInputSettingsPreProcEvent");
		OnKeyUpEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnKeyUpEvent");
		OnKeyUpEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyUpEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyUpEvent_InKeyEvent_PropertyAddress, OnKeyUpEvent_FunctionAddress, "InKeyEvent");
		OnKeyUpEvent_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyUpEvent_FunctionAddress, "InKeyEvent");
		OnKeyUpEvent_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyUpEvent_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		OnKeyUpEvent_IsValid = OnKeyUpEvent_FunctionAddress != IntPtr.Zero && OnKeyUpEvent_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnKeyUpEvent", OnKeyUpEvent_IsValid);
		OnKeyDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnKeyDownEvent");
		OnKeyDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnKeyDownEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnKeyDownEvent_InKeyEvent_PropertyAddress, OnKeyDownEvent_FunctionAddress, "InKeyEvent");
		OnKeyDownEvent_InKeyEvent_Offset = NativeReflection.GetPropertyOffset(OnKeyDownEvent_FunctionAddress, "InKeyEvent");
		OnKeyDownEvent_InKeyEvent_IsValid = NativeReflection.ValidatePropertyClass(OnKeyDownEvent_FunctionAddress, "InKeyEvent", Classes.FStructProperty);
		OnKeyDownEvent_IsValid = OnKeyDownEvent_FunctionAddress != IntPtr.Zero && OnKeyDownEvent_InKeyEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnKeyDownEvent", OnKeyDownEvent_IsValid);
		OnMouseButtonUpEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonUpEvent");
		OnMouseButtonUpEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonUpEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonUpEvent_InMouseEvent_PropertyAddress, OnMouseButtonUpEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonUpEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonUpEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonUpEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonUpEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseButtonUpEvent_IsValid = OnMouseButtonUpEvent_FunctionAddress != IntPtr.Zero && OnMouseButtonUpEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnMouseButtonUpEvent", OnMouseButtonUpEvent_IsValid);
		OnMouseButtonDownEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMouseButtonDownEvent");
		OnMouseButtonDownEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseButtonDownEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnMouseButtonDownEvent_InMouseEvent_PropertyAddress, OnMouseButtonDownEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonDownEvent_InMouseEvent_Offset = NativeReflection.GetPropertyOffset(OnMouseButtonDownEvent_FunctionAddress, "InMouseEvent");
		OnMouseButtonDownEvent_InMouseEvent_IsValid = NativeReflection.ValidatePropertyClass(OnMouseButtonDownEvent_FunctionAddress, "InMouseEvent", Classes.FStructProperty);
		OnMouseButtonDownEvent_IsValid = OnMouseButtonDownEvent_FunctionAddress != IntPtr.Zero && OnMouseButtonDownEvent_InMouseEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UGSInputSettingsPreProcEvent:OnMouseButtonDownEvent", OnMouseButtonDownEvent_IsValid);
	}

	static UGSInputSettingsPreProcEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UGSInputSettingsPreProcEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputSettingsPreProcEvent));
	}
}
