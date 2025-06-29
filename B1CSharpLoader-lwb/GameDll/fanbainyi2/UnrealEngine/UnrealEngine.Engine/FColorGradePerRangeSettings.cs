using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.ColorGradePerRangeSettings", "Engine", UnrealModuleType.Engine)]
public struct FColorGradePerRangeSettings
{
	private static bool Saturation_IsValid;

	private static int Saturation_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradePerRangeSettings:Saturation")]
	public FVector4 Saturation;

	private static bool Contrast_IsValid;

	private static int Contrast_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradePerRangeSettings:Contrast")]
	public FVector4 Contrast;

	private static bool Gamma_IsValid;

	private static int Gamma_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradePerRangeSettings:Gamma")]
	public FVector4 Gamma;

	private static bool Gain_IsValid;

	private static int Gain_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradePerRangeSettings:Gain")]
	public FVector4 Gain;

	private static bool Offset_IsValid;

	private static int Offset_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.ColorGradePerRangeSettings:Offset")]
	public FVector4 Offset;

	private static bool FColorGradePerRangeSettings_IsValid;

	private static int FColorGradePerRangeSettings_StructSize;

	public FColorGradePerRangeSettings Copy()
	{
		return this;
	}

	public static FColorGradePerRangeSettings FromNative(IntPtr nativeBuffer)
	{
		return new FColorGradePerRangeSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FColorGradePerRangeSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FColorGradePerRangeSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FColorGradePerRangeSettings(nativeBuffer + arrayIndex * FColorGradePerRangeSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FColorGradePerRangeSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FColorGradePerRangeSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FColorGradePerRangeSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ColorGradePerRangeSettings");
			return;
		}
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, Saturation_Offset), Saturation);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, Contrast_Offset), Contrast);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, Gamma_Offset), Gamma);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, Gain_Offset), Gain);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, Offset_Offset), Offset);
	}

	public FColorGradePerRangeSettings(IntPtr nativeStruct)
	{
		if (!FColorGradePerRangeSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.ColorGradePerRangeSettings");
			Saturation = default(FVector4);
			Contrast = default(FVector4);
			Gamma = default(FVector4);
			Gain = default(FVector4);
			Offset = default(FVector4);
		}
		else
		{
			Saturation = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, Saturation_Offset));
			Contrast = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, Contrast_Offset));
			Gamma = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, Gamma_Offset));
			Gain = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, Gain_Offset));
			Offset = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, Offset_Offset));
		}
	}

	static FColorGradePerRangeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FColorGradePerRangeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FColorGradePerRangeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.ColorGradePerRangeSettings");
		FColorGradePerRangeSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Saturation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Saturation");
		Saturation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Saturation", Classes.FStructProperty);
		Contrast_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Contrast");
		Contrast_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Contrast", Classes.FStructProperty);
		Gamma_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Gamma");
		Gamma_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Gamma", Classes.FStructProperty);
		Gain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Gain");
		Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Gain", Classes.FStructProperty);
		Offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Offset");
		Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Offset", Classes.FStructProperty);
		FColorGradePerRangeSettings_IsValid = intPtr != IntPtr.Zero && Saturation_IsValid && Contrast_IsValid && Gamma_IsValid && Gain_IsValid && Offset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.ColorGradePerRangeSettings", FColorGradePerRangeSettings_IsValid);
	}
}
