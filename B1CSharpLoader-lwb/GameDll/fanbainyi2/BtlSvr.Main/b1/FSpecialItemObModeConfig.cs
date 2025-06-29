using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SpecialItemObModeConfig")]
public struct FSpecialItemObModeConfig
{
	[DisplayName("详细配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SpecialItemObModeConfig:SpecialItemConfigMap")]
	public Dictionary<EObModeSource, FObservationModeConfig> SpecialItemConfigMap;

	private static int SpecialItemObModeConfig_StructSize;

	private static int SpecialItemObModeConfig_IsValid;

	private static bool SpecialItemConfigMap_IsValid;

	private static int SpecialItemConfigMap_Offset;

	private static FFieldAddress SpecialItemConfigMap_PropertyAddress;

	public FSpecialItemObModeConfig Copy()
	{
		FSpecialItemObModeConfig result = this;
		if (SpecialItemConfigMap != null)
		{
			result.SpecialItemConfigMap = new Dictionary<EObModeSource, FObservationModeConfig>(SpecialItemConfigMap);
		}
		return result;
	}

	public static FSpecialItemObModeConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSpecialItemObModeConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpecialItemObModeConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpecialItemObModeConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpecialItemObModeConfig(IntPtr.Add(nativeBuffer, arrayIndex * SpecialItemObModeConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpecialItemObModeConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpecialItemObModeConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpecialItemObModeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpecialItemObModeConfig");
		}
		else
		{
			new TMapCopyMarshaler<EObModeSource, FObservationModeConfig>(1, SpecialItemConfigMap_PropertyAddress, CachedMarshalingDelegates<EObModeSource, EnumMarshaler<EObModeSource>>.FromNative, CachedMarshalingDelegates<EObModeSource, EnumMarshaler<EObModeSource>>.ToNative, CachedMarshalingDelegates<FObservationModeConfig, FObservationModeConfig>.FromNative, CachedMarshalingDelegates<FObservationModeConfig, FObservationModeConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpecialItemConfigMap_Offset), SpecialItemConfigMap);
		}
	}

	public FSpecialItemObModeConfig(IntPtr nativeStruct)
	{
		if (SpecialItemObModeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpecialItemObModeConfig");
			SpecialItemConfigMap = null;
		}
		else
		{
			SpecialItemConfigMap = new TMapCopyMarshaler<EObModeSource, FObservationModeConfig>(1, SpecialItemConfigMap_PropertyAddress, CachedMarshalingDelegates<EObModeSource, EnumMarshaler<EObModeSource>>.FromNative, CachedMarshalingDelegates<EObModeSource, EnumMarshaler<EObModeSource>>.ToNative, CachedMarshalingDelegates<FObservationModeConfig, FObservationModeConfig>.FromNative, CachedMarshalingDelegates<FObservationModeConfig, FObservationModeConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpecialItemConfigMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpecialItemObModeConfig");
		SpecialItemObModeConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SpecialItemConfigMap_PropertyAddress, intPtr, "SpecialItemConfigMap");
		SpecialItemConfigMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpecialItemConfigMap");
		SpecialItemConfigMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpecialItemConfigMap", Classes.FMapProperty);
		SpecialItemObModeConfig_IsValid = ((intPtr != IntPtr.Zero && SpecialItemConfigMap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpecialItemObModeConfig", (byte)SpecialItemObModeConfig_IsValid != 0);
	}

	static FSpecialItemObModeConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpecialItemObModeConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpecialItemObModeConfig));
	}
}
