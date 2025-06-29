using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpenColorIO;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/OpenColorIO.OpenColorIOColorConversionSettings", "OpenColorIO", UnrealModuleType.EnginePlugin)]
public struct FOpenColorIOColorConversionSettings
{
	private static bool ConfigurationSource_IsValid;

	private static int ConfigurationSource_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIOColorConversionSettings:ConfigurationSource")]
	public UOpenColorIOConfiguration ConfigurationSource;

	private static bool SourceColorSpace_IsValid;

	private static int SourceColorSpace_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIOColorConversionSettings:SourceColorSpace")]
	public FOpenColorIOColorSpace SourceColorSpace;

	private static bool DestinationColorSpace_IsValid;

	private static int DestinationColorSpace_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIOColorConversionSettings:DestinationColorSpace")]
	public FOpenColorIOColorSpace DestinationColorSpace;

	private static bool FOpenColorIOColorConversionSettings_IsValid;

	private static int FOpenColorIOColorConversionSettings_StructSize;

	public FOpenColorIOColorConversionSettings Copy()
	{
		return this;
	}

	public static FOpenColorIOColorConversionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FOpenColorIOColorConversionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOpenColorIOColorConversionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOpenColorIOColorConversionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOpenColorIOColorConversionSettings(nativeBuffer + arrayIndex * FOpenColorIOColorConversionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOpenColorIOColorConversionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOpenColorIOColorConversionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOpenColorIOColorConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OpenColorIO.OpenColorIOColorConversionSettings");
			return;
		}
		UObjectMarshaler<UOpenColorIOConfiguration>.ToNative(IntPtr.Add(nativeStruct, ConfigurationSource_Offset), ConfigurationSource);
		FOpenColorIOColorSpace.ToNative(IntPtr.Add(nativeStruct, SourceColorSpace_Offset), SourceColorSpace);
		FOpenColorIOColorSpace.ToNative(IntPtr.Add(nativeStruct, DestinationColorSpace_Offset), DestinationColorSpace);
	}

	public FOpenColorIOColorConversionSettings(IntPtr nativeStruct)
	{
		if (!FOpenColorIOColorConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/OpenColorIO.OpenColorIOColorConversionSettings");
			ConfigurationSource = null;
			SourceColorSpace = default(FOpenColorIOColorSpace);
			DestinationColorSpace = default(FOpenColorIOColorSpace);
		}
		else
		{
			ConfigurationSource = UObjectMarshaler<UOpenColorIOConfiguration>.FromNative(IntPtr.Add(nativeStruct, ConfigurationSource_Offset));
			SourceColorSpace = FOpenColorIOColorSpace.FromNative(IntPtr.Add(nativeStruct, SourceColorSpace_Offset));
			DestinationColorSpace = FOpenColorIOColorSpace.FromNative(IntPtr.Add(nativeStruct, DestinationColorSpace_Offset));
		}
	}

	static FOpenColorIOColorConversionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOpenColorIOColorConversionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOpenColorIOColorConversionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/OpenColorIO.OpenColorIOColorConversionSettings");
		FOpenColorIOColorConversionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigurationSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigurationSource");
		ConfigurationSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigurationSource", Classes.FObjectProperty);
		SourceColorSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceColorSpace");
		SourceColorSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceColorSpace", Classes.FStructProperty);
		DestinationColorSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DestinationColorSpace");
		DestinationColorSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DestinationColorSpace", Classes.FStructProperty);
		FOpenColorIOColorConversionSettings_IsValid = intPtr != IntPtr.Zero && ConfigurationSource_IsValid && SourceColorSpace_IsValid && DestinationColorSpace_IsValid;
		NativeReflection.LogStructIsValid("/Script/OpenColorIO.OpenColorIOColorConversionSettings", FOpenColorIOColorConversionSettings_IsValid);
	}
}
