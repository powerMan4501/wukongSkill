using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.UDSSettingFunctionBinder")]
public class UDSSettingFunctionBinder : UObject
{
	private static bool OnCultureChangedEvent_IsValid;

	private static IntPtr OnCultureChangedEvent_FunctionAddress;

	private static int OnCultureChangedEvent_ParamsSize;

	private static bool OnViewportResizedEvent_IsValid;

	private static IntPtr OnViewportResizedEvent_FunctionAddress;

	private static int OnViewportResizedEvent_ParamsSize;

	private static bool OnViewportResizedEvent_NewSize_IsValid;

	private static int OnViewportResizedEvent_NewSize_Offset;

	private static FFieldAddress OnViewportResizedEvent_NewSize_PropertyAddress;

	private static bool OnMonitorAsPrimaryChange_IsValid;

	private static IntPtr OnMonitorAsPrimaryChange_FunctionAddress;

	private static int OnMonitorAsPrimaryChange_ParamsSize;

	private static bool OnMonitorAsPrimaryChange_MonitorIdx_IsValid;

	private static int OnMonitorAsPrimaryChange_MonitorIdx_Offset;

	public void BindOnMonitorAsPrimaryChange()
	{
		UGSE_SystemSettingsFuncLib.BGUBindOnMonitorAsPrimaryChange(this, new FName("OnMonitorAsPrimaryChange"));
	}

	public void UnBindOnMonitorAsPrimaryChange()
	{
		UGSE_SystemSettingsFuncLib.BGUUnBindOnMonitorAsPrimaryChange(this, new FName("OnMonitorAsPrimaryChange"));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UDSSettingFunctionBinder:OnMonitorAsPrimaryChange")]
	internal void OnMonitorAsPrimaryChange(int MonitorIdx)
	{
		BGW_EventCollection.Get(this).Evt_TriggerMonitorAsPrimaryChange(MonitorIdx);
	}

	public void BindOnViewportResizedEvent()
	{
		UGSE_SystemSettingsFuncLib.BGUBindOnViewportResizedEvent(this, new FName("OnViewportResizedEvent"));
	}

	public void UnBindOnViewportResizedEvent()
	{
		UGSE_SystemSettingsFuncLib.BGUUnBindOnViewportResizedEvent(this, new FName("OnViewportResizedEvent"));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UDSSettingFunctionBinder:OnViewportResizedEvent")]
	internal void OnViewportResizedEvent(FIntPoint NewSize)
	{
		BGW_EventCollection.Get(this).Evt_TriggerViewportResized(NewSize);
	}

	public void BindOnCultureChangedEvent()
	{
		UGSE_SystemSettingsFuncLib.BGUBindOnCultureChangedEvent(this, new FName("OnCultureChangedEvent"));
	}

	public void UnBindOnCultureChangedEvent()
	{
		UGSE_SystemSettingsFuncLib.BGUUnBindOnCultureChangedEvent(this, new FName("OnCultureChangedEvent"));
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.UDSSettingFunctionBinder:OnCultureChangedEvent")]
	internal void OnCultureChangedEvent()
	{
		BGW_EventCollection.Get(this).Evt_TriggerCultureChanged();
	}

	[UFunctionInvoker("/Script/b1-Managed.UDSSettingFunctionBinder:OnCultureChangedEvent")]
	private static void OnCultureChangedEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UDSSettingFunctionBinder uDSSettingFunctionBinder = GCHelper.Find<UDSSettingFunctionBinder>(obj);
		uDSSettingFunctionBinder.OnCultureChangedEvent();
	}

	[UFunctionInvoker("/Script/b1-Managed.UDSSettingFunctionBinder:OnViewportResizedEvent")]
	private static void OnViewportResizedEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		UDSSettingFunctionBinder uDSSettingFunctionBinder = GCHelper.Find<UDSSettingFunctionBinder>(obj);
		FIntPoint newSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(buffer, OnViewportResizedEvent_NewSize_Offset));
		uDSSettingFunctionBinder.OnViewportResizedEvent(newSize);
	}

	[UFunctionInvoker("/Script/b1-Managed.UDSSettingFunctionBinder:OnMonitorAsPrimaryChange")]
	private static void OnMonitorAsPrimaryChange__Invoker(IntPtr buffer, IntPtr obj)
	{
		UDSSettingFunctionBinder uDSSettingFunctionBinder = GCHelper.Find<UDSSettingFunctionBinder>(obj);
		int monitorIdx = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnMonitorAsPrimaryChange_MonitorIdx_Offset));
		uDSSettingFunctionBinder.OnMonitorAsPrimaryChange(monitorIdx);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.UDSSettingFunctionBinder");
		OnCultureChangedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnCultureChangedEvent");
		OnCultureChangedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCultureChangedEvent_FunctionAddress);
		OnCultureChangedEvent_IsValid = OnCultureChangedEvent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UDSSettingFunctionBinder:OnCultureChangedEvent", OnCultureChangedEvent_IsValid);
		OnViewportResizedEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnViewportResizedEvent");
		OnViewportResizedEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewportResizedEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnViewportResizedEvent_NewSize_PropertyAddress, OnViewportResizedEvent_FunctionAddress, "NewSize");
		OnViewportResizedEvent_NewSize_Offset = NativeReflection.GetPropertyOffset(OnViewportResizedEvent_FunctionAddress, "NewSize");
		OnViewportResizedEvent_NewSize_IsValid = NativeReflection.ValidatePropertyClass(OnViewportResizedEvent_FunctionAddress, "NewSize", Classes.FStructProperty);
		OnViewportResizedEvent_IsValid = OnViewportResizedEvent_FunctionAddress != IntPtr.Zero && OnViewportResizedEvent_NewSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UDSSettingFunctionBinder:OnViewportResizedEvent", OnViewportResizedEvent_IsValid);
		OnMonitorAsPrimaryChange_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnMonitorAsPrimaryChange");
		OnMonitorAsPrimaryChange_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMonitorAsPrimaryChange_FunctionAddress);
		OnMonitorAsPrimaryChange_MonitorIdx_Offset = NativeReflection.GetPropertyOffset(OnMonitorAsPrimaryChange_FunctionAddress, "MonitorIdx");
		OnMonitorAsPrimaryChange_MonitorIdx_IsValid = NativeReflection.ValidatePropertyClass(OnMonitorAsPrimaryChange_FunctionAddress, "MonitorIdx", Classes.FIntProperty);
		OnMonitorAsPrimaryChange_IsValid = OnMonitorAsPrimaryChange_FunctionAddress != IntPtr.Zero && OnMonitorAsPrimaryChange_MonitorIdx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.UDSSettingFunctionBinder:OnMonitorAsPrimaryChange", OnMonitorAsPrimaryChange_IsValid);
	}

	static UDSSettingFunctionBinder()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UDSSettingFunctionBinder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDSSettingFunctionBinder));
	}
}
