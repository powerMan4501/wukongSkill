using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpenColorIO;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayConfiguration", "OpenColorIO", UnrealModuleType.EnginePlugin)]
public struct FOpenColorIODisplayConfiguration
{
	private static bool IsEnabled_IsValid;

	private static FFieldAddress IsEnabled_PropertyAddress;

	private static int IsEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayConfiguration:bIsEnabled")]
	public bool IsEnabled;

	private static bool ColorConfiguration_IsValid;

	private static int ColorConfiguration_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayConfiguration:ColorConfiguration")]
	public FOpenColorIOColorConversionSettings ColorConfiguration;

	private static bool FOpenColorIODisplayConfiguration_IsValid;

	private static int FOpenColorIODisplayConfiguration_StructSize;

	public FOpenColorIODisplayConfiguration Copy()
	{
		return this;
	}

	public static FOpenColorIODisplayConfiguration FromNative(IntPtr nativeBuffer)
	{
		return new FOpenColorIODisplayConfiguration(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOpenColorIODisplayConfiguration value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOpenColorIODisplayConfiguration FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOpenColorIODisplayConfiguration(nativeBuffer + arrayIndex * FOpenColorIODisplayConfiguration_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOpenColorIODisplayConfiguration value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOpenColorIODisplayConfiguration_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOpenColorIODisplayConfiguration_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OpenColorIO.OpenColorIODisplayConfiguration");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsEnabled_Offset), 0, IsEnabled_PropertyAddress.Address, IsEnabled);
		FOpenColorIOColorConversionSettings.ToNative(IntPtr.Add(nativeStruct, ColorConfiguration_Offset), ColorConfiguration);
	}

	public FOpenColorIODisplayConfiguration(IntPtr nativeStruct)
	{
		if (!FOpenColorIODisplayConfiguration_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OpenColorIO.OpenColorIODisplayConfiguration");
			IsEnabled = false;
			ColorConfiguration = default(FOpenColorIOColorConversionSettings);
		}
		else
		{
			IsEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsEnabled_Offset), 0, IsEnabled_PropertyAddress.Address);
			ColorConfiguration = FOpenColorIOColorConversionSettings.FromNative(IntPtr.Add(nativeStruct, ColorConfiguration_Offset));
		}
	}

	static FOpenColorIODisplayConfiguration()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOpenColorIODisplayConfiguration)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOpenColorIODisplayConfiguration));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OpenColorIO.OpenColorIODisplayConfiguration");
		FOpenColorIODisplayConfiguration_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IsEnabled_PropertyAddress, intPtr, "bIsEnabled");
		IsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsEnabled");
		IsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsEnabled", Classes.FBoolProperty);
		ColorConfiguration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorConfiguration");
		ColorConfiguration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorConfiguration", Classes.FStructProperty);
		FOpenColorIODisplayConfiguration_IsValid = intPtr != IntPtr.Zero && IsEnabled_IsValid && ColorConfiguration_IsValid;
		NativeReflection.LogStructIsValid("/Script/OpenColorIO.OpenColorIODisplayConfiguration", FOpenColorIODisplayConfiguration_IsValid);
	}
}
