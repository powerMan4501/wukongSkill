using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CustomizedInputOverrideConfig")]
public struct FCustomizedInputOverrideConfig
{
	[DisplayName("Override按键映射")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CustomizedInputOverrideConfig:InputMappingContext")]
	public UInputMappingContext InputMappingContext;

	[BlueprintReadWrite]
	[DisplayName("Override InputAction触发事件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CustomizedInputOverrideConfig:OverrideInputActionTriggerEvents")]
	public Dictionary<UInputAction, FInputActionOverrideConfig> OverrideInputActionTriggerEvents;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否override优先级")]
	[Category("基础信息")]
	[USharpPath("/Script/b1-Managed.CustomizedInputOverrideConfig:IsOverridePriority")]
	public bool IsOverridePriority;

	[Category("基础信息")]
	[DisplayName("优先级")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "IsOverridePriority")]
	[USharpPath("/Script/b1-Managed.CustomizedInputOverrideConfig:Priority")]
	public int Priority;

	[UProperty]
	[UMeta(MDProp.EditCondition, "IsOverridePriority")]
	[Category("基础信息")]
	[DisplayName("触发优先级")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CustomizedInputOverrideConfig:TriggerPriority")]
	public int TriggerPriority;

	private static int CustomizedInputOverrideConfig_StructSize;

	private static int CustomizedInputOverrideConfig_IsValid;

	private static bool InputMappingContext_IsValid;

	private static int InputMappingContext_Offset;

	private static bool OverrideInputActionTriggerEvents_IsValid;

	private static int OverrideInputActionTriggerEvents_Offset;

	private static FFieldAddress OverrideInputActionTriggerEvents_PropertyAddress;

	private static bool IsOverridePriority_IsValid;

	private static int IsOverridePriority_Offset;

	private static FFieldAddress IsOverridePriority_PropertyAddress;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool TriggerPriority_IsValid;

	private static int TriggerPriority_Offset;

	public FCustomizedInputOverrideConfig Copy()
	{
		FCustomizedInputOverrideConfig result = this;
		if (OverrideInputActionTriggerEvents != null)
		{
			result.OverrideInputActionTriggerEvents = new Dictionary<UInputAction, FInputActionOverrideConfig>(OverrideInputActionTriggerEvents);
		}
		return result;
	}

	public static FCustomizedInputOverrideConfig FromNative(IntPtr nativeBuffer)
	{
		return new FCustomizedInputOverrideConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCustomizedInputOverrideConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCustomizedInputOverrideConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCustomizedInputOverrideConfig(IntPtr.Add(nativeBuffer, arrayIndex * CustomizedInputOverrideConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCustomizedInputOverrideConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CustomizedInputOverrideConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CustomizedInputOverrideConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CustomizedInputOverrideConfig");
			return;
		}
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(nativeStruct, InputMappingContext_Offset), InputMappingContext);
		new TMapCopyMarshaler<UInputAction, FInputActionOverrideConfig>(1, OverrideInputActionTriggerEvents_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative, CachedMarshalingDelegates<FInputActionOverrideConfig, FInputActionOverrideConfig>.FromNative, CachedMarshalingDelegates<FInputActionOverrideConfig, FInputActionOverrideConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverrideInputActionTriggerEvents_Offset), OverrideInputActionTriggerEvents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsOverridePriority_Offset), 0, IsOverridePriority_PropertyAddress.Address, IsOverridePriority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Priority_Offset), Priority);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TriggerPriority_Offset), TriggerPriority);
	}

	public FCustomizedInputOverrideConfig(IntPtr nativeStruct)
	{
		if (CustomizedInputOverrideConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CustomizedInputOverrideConfig");
			InputMappingContext = null;
			OverrideInputActionTriggerEvents = null;
			IsOverridePriority = false;
			Priority = 0;
			TriggerPriority = 0;
		}
		else
		{
			InputMappingContext = UObjectMarshaler<UInputMappingContext>.FromNative(IntPtr.Add(nativeStruct, InputMappingContext_Offset));
			OverrideInputActionTriggerEvents = new TMapCopyMarshaler<UInputAction, FInputActionOverrideConfig>(1, OverrideInputActionTriggerEvents_PropertyAddress, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.FromNative, CachedMarshalingDelegates<UInputAction, UObjectMarshaler<UInputAction>>.ToNative, CachedMarshalingDelegates<FInputActionOverrideConfig, FInputActionOverrideConfig>.FromNative, CachedMarshalingDelegates<FInputActionOverrideConfig, FInputActionOverrideConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverrideInputActionTriggerEvents_Offset));
			IsOverridePriority = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsOverridePriority_Offset), 0, IsOverridePriority_PropertyAddress.Address);
			Priority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Priority_Offset));
			TriggerPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TriggerPriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CustomizedInputOverrideConfig");
		CustomizedInputOverrideConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		InputMappingContext_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputMappingContext");
		InputMappingContext_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputMappingContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OverrideInputActionTriggerEvents_PropertyAddress, intPtr, "OverrideInputActionTriggerEvents");
		OverrideInputActionTriggerEvents_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideInputActionTriggerEvents");
		OverrideInputActionTriggerEvents_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideInputActionTriggerEvents", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref IsOverridePriority_PropertyAddress, intPtr, "IsOverridePriority");
		IsOverridePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsOverridePriority");
		IsOverridePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsOverridePriority", Classes.FBoolProperty);
		Priority_Offset = NativeReflection.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		TriggerPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerPriority");
		TriggerPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerPriority", Classes.FIntProperty);
		CustomizedInputOverrideConfig_IsValid = ((intPtr != IntPtr.Zero && InputMappingContext_IsValid && OverrideInputActionTriggerEvents_IsValid && IsOverridePriority_IsValid && Priority_IsValid && TriggerPriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CustomizedInputOverrideConfig", (byte)CustomizedInputOverrideConfig_IsValid != 0);
	}

	static FCustomizedInputOverrideConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCustomizedInputOverrideConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCustomizedInputOverrideConfig));
	}
}
