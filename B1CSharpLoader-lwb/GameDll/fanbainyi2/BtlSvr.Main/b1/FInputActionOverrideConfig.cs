using System;
using System.Collections.Generic;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.InputActionOverrideConfig")]
public struct FInputActionOverrideConfig
{
	[UProperty]
	[DisplayName("Override触发事件")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.InputActionOverrideConfig:OverrideTriggerEvents")]
	public Dictionary<ETriggerEvent, ETriggerEvent> OverrideTriggerEvents;

	private static int InputActionOverrideConfig_StructSize;

	private static int InputActionOverrideConfig_IsValid;

	private static bool OverrideTriggerEvents_IsValid;

	private static int OverrideTriggerEvents_Offset;

	private static FFieldAddress OverrideTriggerEvents_PropertyAddress;

	public FInputActionOverrideConfig Copy()
	{
		FInputActionOverrideConfig result = this;
		if (OverrideTriggerEvents != null)
		{
			result.OverrideTriggerEvents = new Dictionary<ETriggerEvent, ETriggerEvent>(OverrideTriggerEvents);
		}
		return result;
	}

	public static FInputActionOverrideConfig FromNative(IntPtr nativeBuffer)
	{
		return new FInputActionOverrideConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputActionOverrideConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputActionOverrideConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputActionOverrideConfig(IntPtr.Add(nativeBuffer, arrayIndex * InputActionOverrideConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputActionOverrideConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * InputActionOverrideConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (InputActionOverrideConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputActionOverrideConfig");
		}
		else
		{
			new TMapCopyMarshaler<ETriggerEvent, ETriggerEvent>(1, OverrideTriggerEvents_PropertyAddress, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.FromNative, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.ToNative, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.FromNative, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverrideTriggerEvents_Offset), OverrideTriggerEvents);
		}
	}

	public FInputActionOverrideConfig(IntPtr nativeStruct)
	{
		if (InputActionOverrideConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.InputActionOverrideConfig");
			OverrideTriggerEvents = null;
		}
		else
		{
			OverrideTriggerEvents = new TMapCopyMarshaler<ETriggerEvent, ETriggerEvent>(1, OverrideTriggerEvents_PropertyAddress, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.FromNative, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.ToNative, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.FromNative, CachedMarshalingDelegates<ETriggerEvent, EnumMarshaler<ETriggerEvent>>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverrideTriggerEvents_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.InputActionOverrideConfig");
		InputActionOverrideConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref OverrideTriggerEvents_PropertyAddress, intPtr, "OverrideTriggerEvents");
		OverrideTriggerEvents_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideTriggerEvents");
		OverrideTriggerEvents_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideTriggerEvents", Classes.FMapProperty);
		InputActionOverrideConfig_IsValid = ((intPtr != IntPtr.Zero && OverrideTriggerEvents_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.InputActionOverrideConfig", (byte)InputActionOverrideConfig_IsValid != 0);
	}

	static FInputActionOverrideConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FInputActionOverrideConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputActionOverrideConfig));
	}
}
