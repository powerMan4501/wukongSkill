using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GamepadCustomizedInputConfig")]
public struct FGamepadCustomizedInputConfig
{
	[DisplayName("交换按键信息")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GamepadCustomizedInputConfig:DetailConfigs")]
	public List<FGamepadCustomizedInputDetailConfig> DetailConfigs;

	private static int GamepadCustomizedInputConfig_StructSize;

	private static int GamepadCustomizedInputConfig_IsValid;

	private static bool DetailConfigs_IsValid;

	private static int DetailConfigs_Offset;

	private static FFieldAddress DetailConfigs_PropertyAddress;

	public FGamepadCustomizedInputConfig Copy()
	{
		FGamepadCustomizedInputConfig result = this;
		if (DetailConfigs != null)
		{
			result.DetailConfigs = new List<FGamepadCustomizedInputDetailConfig>(DetailConfigs);
		}
		return result;
	}

	public static FGamepadCustomizedInputConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGamepadCustomizedInputConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGamepadCustomizedInputConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGamepadCustomizedInputConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGamepadCustomizedInputConfig(IntPtr.Add(nativeBuffer, arrayIndex * GamepadCustomizedInputConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGamepadCustomizedInputConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GamepadCustomizedInputConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GamepadCustomizedInputConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamepadCustomizedInputConfig");
		}
		else
		{
			new TArrayCopyMarshaler<FGamepadCustomizedInputDetailConfig>(1, DetailConfigs_PropertyAddress, CachedMarshalingDelegates<FGamepadCustomizedInputDetailConfig, FGamepadCustomizedInputDetailConfig>.FromNative, CachedMarshalingDelegates<FGamepadCustomizedInputDetailConfig, FGamepadCustomizedInputDetailConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, DetailConfigs_Offset), DetailConfigs);
		}
	}

	public FGamepadCustomizedInputConfig(IntPtr nativeStruct)
	{
		if (GamepadCustomizedInputConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GamepadCustomizedInputConfig");
			DetailConfigs = null;
		}
		else
		{
			DetailConfigs = new TArrayCopyMarshaler<FGamepadCustomizedInputDetailConfig>(1, DetailConfigs_PropertyAddress, CachedMarshalingDelegates<FGamepadCustomizedInputDetailConfig, FGamepadCustomizedInputDetailConfig>.FromNative, CachedMarshalingDelegates<FGamepadCustomizedInputDetailConfig, FGamepadCustomizedInputDetailConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, DetailConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GamepadCustomizedInputConfig");
		GamepadCustomizedInputConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref DetailConfigs_PropertyAddress, intPtr, "DetailConfigs");
		DetailConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetailConfigs");
		DetailConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetailConfigs", Classes.FArrayProperty);
		GamepadCustomizedInputConfig_IsValid = ((intPtr != IntPtr.Zero && DetailConfigs_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GamepadCustomizedInputConfig", (byte)GamepadCustomizedInputConfig_IsValid != 0);
	}

	static FGamepadCustomizedInputConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGamepadCustomizedInputConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGamepadCustomizedInputConfig));
	}
}
