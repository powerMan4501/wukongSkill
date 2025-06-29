using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent")]
public struct BUC_DispLibDBC_CustomEvent
{
	[DisplayName("触发时机")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent:TriggerMode")]
	public DispLibDBCCustomEventTriggerMode TriggerMode;

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "TriggerMode == DispLibDBCCustomEventTriggerMode::Standard")]
	[DisplayName("延迟时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent:DelayTime")]
	public float DelayTime;

	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "")]
	[DisplayName("结束模式")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent:EndMode")]
	public DispLibDBCEndMode EndMode;

	[UMeta(MD.ToolTip, "只有结束模式是【固定持续时间】这个参数才有效, 当自定义事件触发后经过此时间后，通知自定义事件进入【结束表现阶段】")]
	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent:Duration")]
	public float Duration;

	[UProperty]
	[UMeta(MD.ToolTip, "")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MDProp.EditCondition, "EndMode != DispLibDBCEndMode::AutoRelease")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent:DelayTimeAfterStop")]
	public float DelayTimeAfterStop;

	[DisplayName("参数DA")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent:ParametersDataAssets")]
	public DispLibDBCCustomEventDataAssetBase ParametersDataAssets;

	private static int BUC_DispLibDBC_CustomEvent_StructSize;

	private static int BUC_DispLibDBC_CustomEvent_IsValid;

	private static bool TriggerMode_IsValid;

	private static int TriggerMode_Offset;

	private static FFieldAddress TriggerMode_PropertyAddress;

	private static bool DelayTime_IsValid;

	private static int DelayTime_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool ParametersDataAssets_IsValid;

	private static int ParametersDataAssets_Offset;

	public BUC_DispLibDBC_CustomEvent Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_CustomEvent FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_CustomEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_CustomEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_CustomEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_CustomEvent(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_CustomEvent_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_CustomEvent value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_CustomEvent_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_CustomEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent");
			return;
		}
		EnumMarshaler<DispLibDBCCustomEventTriggerMode>.ToNative(IntPtr.Add(nativeStruct, TriggerMode_Offset), 0, TriggerMode_PropertyAddress.Address, TriggerMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTime_Offset), DelayTime);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset), DelayTimeAfterStop);
		UObjectMarshaler<DispLibDBCCustomEventDataAssetBase>.ToNative(IntPtr.Add(nativeStruct, ParametersDataAssets_Offset), ParametersDataAssets);
	}

	public BUC_DispLibDBC_CustomEvent(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_CustomEvent_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent");
			TriggerMode = DispLibDBCCustomEventTriggerMode.Standard;
			DelayTime = 0f;
			EndMode = DispLibDBCEndMode.AutoRelease;
			Duration = 0f;
			DelayTimeAfterStop = 0f;
			ParametersDataAssets = null;
		}
		else
		{
			TriggerMode = EnumMarshaler<DispLibDBCCustomEventTriggerMode>.FromNative(IntPtr.Add(nativeStruct, TriggerMode_Offset), 0, TriggerMode_PropertyAddress.Address);
			DelayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTime_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			DelayTimeAfterStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTimeAfterStop_Offset));
			ParametersDataAssets = UObjectMarshaler<DispLibDBCCustomEventDataAssetBase>.FromNative(IntPtr.Add(nativeStruct, ParametersDataAssets_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent");
		BUC_DispLibDBC_CustomEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref TriggerMode_PropertyAddress, intPtr, "TriggerMode");
		TriggerMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerMode");
		TriggerMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerMode", Classes.FEnumProperty);
		DelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTime");
		DelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		ParametersDataAssets_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParametersDataAssets");
		ParametersDataAssets_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParametersDataAssets", Classes.FObjectProperty);
		BUC_DispLibDBC_CustomEvent_IsValid = ((intPtr != IntPtr.Zero && TriggerMode_IsValid && DelayTime_IsValid && EndMode_IsValid && Duration_IsValid && DelayTimeAfterStop_IsValid && ParametersDataAssets_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_CustomEvent", (byte)BUC_DispLibDBC_CustomEvent_IsValid != 0);
	}

	static BUC_DispLibDBC_CustomEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_CustomEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_CustomEvent));
	}
}
