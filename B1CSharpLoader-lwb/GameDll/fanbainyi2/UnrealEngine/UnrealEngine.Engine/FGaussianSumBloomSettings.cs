using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.GaussianSumBloomSettings", "Engine", UnrealModuleType.Engine)]
public struct FGaussianSumBloomSettings
{
	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Intensity")]
	public float Intensity;

	private static bool Threshold_IsValid;

	private static int Threshold_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Threshold")]
	public float Threshold;

	private static bool SizeScale_IsValid;

	private static int SizeScale_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:SizeScale")]
	public float SizeScale;

	private static bool Filter1Size_IsValid;

	private static int Filter1Size_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter1Size")]
	public float Filter1Size;

	private static bool Filter2Size_IsValid;

	private static int Filter2Size_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter2Size")]
	public float Filter2Size;

	private static bool Filter3Size_IsValid;

	private static int Filter3Size_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter3Size")]
	public float Filter3Size;

	private static bool Filter4Size_IsValid;

	private static int Filter4Size_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter4Size")]
	public float Filter4Size;

	private static bool Filter5Size_IsValid;

	private static int Filter5Size_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter5Size")]
	public float Filter5Size;

	private static bool Filter6Size_IsValid;

	private static int Filter6Size_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter6Size")]
	public float Filter6Size;

	private static bool Filter1Tint_IsValid;

	private static int Filter1Tint_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter1Tint")]
	public FLinearColor Filter1Tint;

	private static bool Filter2Tint_IsValid;

	private static int Filter2Tint_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter2Tint")]
	public FLinearColor Filter2Tint;

	private static bool Filter3Tint_IsValid;

	private static int Filter3Tint_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter3Tint")]
	public FLinearColor Filter3Tint;

	private static bool Filter4Tint_IsValid;

	private static int Filter4Tint_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter4Tint")]
	public FLinearColor Filter4Tint;

	private static bool Filter5Tint_IsValid;

	private static int Filter5Tint_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter5Tint")]
	public FLinearColor Filter5Tint;

	private static bool Filter6Tint_IsValid;

	private static int Filter6Tint_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/Engine.GaussianSumBloomSettings:Filter6Tint")]
	public FLinearColor Filter6Tint;

	private static bool FGaussianSumBloomSettings_IsValid;

	private static int FGaussianSumBloomSettings_StructSize;

	public FGaussianSumBloomSettings Copy()
	{
		return this;
	}

	public static FGaussianSumBloomSettings FromNative(IntPtr nativeBuffer)
	{
		return new FGaussianSumBloomSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGaussianSumBloomSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGaussianSumBloomSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGaussianSumBloomSettings(nativeBuffer + arrayIndex * FGaussianSumBloomSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGaussianSumBloomSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGaussianSumBloomSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGaussianSumBloomSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.GaussianSumBloomSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Intensity_Offset), Intensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Threshold_Offset), Threshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SizeScale_Offset), SizeScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Filter1Size_Offset), Filter1Size);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Filter2Size_Offset), Filter2Size);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Filter3Size_Offset), Filter3Size);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Filter4Size_Offset), Filter4Size);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Filter5Size_Offset), Filter5Size);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Filter6Size_Offset), Filter6Size);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Filter1Tint_Offset), Filter1Tint);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Filter2Tint_Offset), Filter2Tint);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Filter3Tint_Offset), Filter3Tint);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Filter4Tint_Offset), Filter4Tint);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Filter5Tint_Offset), Filter5Tint);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Filter6Tint_Offset), Filter6Tint);
	}

	public FGaussianSumBloomSettings(IntPtr nativeStruct)
	{
		if (!FGaussianSumBloomSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.GaussianSumBloomSettings");
			Intensity = 0f;
			Threshold = 0f;
			SizeScale = 0f;
			Filter1Size = 0f;
			Filter2Size = 0f;
			Filter3Size = 0f;
			Filter4Size = 0f;
			Filter5Size = 0f;
			Filter6Size = 0f;
			Filter1Tint = default(FLinearColor);
			Filter2Tint = default(FLinearColor);
			Filter3Tint = default(FLinearColor);
			Filter4Tint = default(FLinearColor);
			Filter5Tint = default(FLinearColor);
			Filter6Tint = default(FLinearColor);
		}
		else
		{
			Intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Intensity_Offset));
			Threshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Threshold_Offset));
			SizeScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SizeScale_Offset));
			Filter1Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Filter1Size_Offset));
			Filter2Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Filter2Size_Offset));
			Filter3Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Filter3Size_Offset));
			Filter4Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Filter4Size_Offset));
			Filter5Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Filter5Size_Offset));
			Filter6Size = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Filter6Size_Offset));
			Filter1Tint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Filter1Tint_Offset));
			Filter2Tint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Filter2Tint_Offset));
			Filter3Tint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Filter3Tint_Offset));
			Filter4Tint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Filter4Tint_Offset));
			Filter5Tint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Filter5Tint_Offset));
			Filter6Tint = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Filter6Tint_Offset));
		}
	}

	static FGaussianSumBloomSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGaussianSumBloomSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGaussianSumBloomSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.GaussianSumBloomSettings");
		FGaussianSumBloomSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		Threshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Threshold");
		Threshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Threshold", Classes.FFloatProperty);
		SizeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SizeScale");
		SizeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SizeScale", Classes.FFloatProperty);
		Filter1Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter1Size");
		Filter1Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter1Size", Classes.FFloatProperty);
		Filter2Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter2Size");
		Filter2Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter2Size", Classes.FFloatProperty);
		Filter3Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter3Size");
		Filter3Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter3Size", Classes.FFloatProperty);
		Filter4Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter4Size");
		Filter4Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter4Size", Classes.FFloatProperty);
		Filter5Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter5Size");
		Filter5Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter5Size", Classes.FFloatProperty);
		Filter6Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter6Size");
		Filter6Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter6Size", Classes.FFloatProperty);
		Filter1Tint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter1Tint");
		Filter1Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter1Tint", Classes.FStructProperty);
		Filter2Tint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter2Tint");
		Filter2Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter2Tint", Classes.FStructProperty);
		Filter3Tint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter3Tint");
		Filter3Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter3Tint", Classes.FStructProperty);
		Filter4Tint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter4Tint");
		Filter4Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter4Tint", Classes.FStructProperty);
		Filter5Tint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter5Tint");
		Filter5Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter5Tint", Classes.FStructProperty);
		Filter6Tint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Filter6Tint");
		Filter6Tint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Filter6Tint", Classes.FStructProperty);
		FGaussianSumBloomSettings_IsValid = intPtr != IntPtr.Zero && Intensity_IsValid && Threshold_IsValid && SizeScale_IsValid && Filter1Size_IsValid && Filter2Size_IsValid && Filter3Size_IsValid && Filter4Size_IsValid && Filter5Size_IsValid && Filter6Size_IsValid && Filter1Tint_IsValid && Filter2Tint_IsValid && Filter3Tint_IsValid && Filter4Tint_IsValid && Filter5Tint_IsValid && Filter6Tint_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.GaussianSumBloomSettings", FGaussianSumBloomSettings_IsValid);
	}
}
