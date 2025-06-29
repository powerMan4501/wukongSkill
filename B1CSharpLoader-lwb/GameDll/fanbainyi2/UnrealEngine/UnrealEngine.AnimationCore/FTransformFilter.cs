using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AnimationCore.TransformFilter", "AnimationCore", UnrealModuleType.Engine)]
public struct FTransformFilter
{
	private static bool TranslationFilter_IsValid;

	private static int TranslationFilter_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationCore.TransformFilter:TranslationFilter")]
	public FFilterOptionPerAxis TranslationFilter;

	private static bool RotationFilter_IsValid;

	private static int RotationFilter_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationCore.TransformFilter:RotationFilter")]
	public FFilterOptionPerAxis RotationFilter;

	private static bool ScaleFilter_IsValid;

	private static int ScaleFilter_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AnimationCore.TransformFilter:ScaleFilter")]
	public FFilterOptionPerAxis ScaleFilter;

	private static bool FTransformFilter_IsValid;

	private static int FTransformFilter_StructSize;

	public FTransformFilter Copy()
	{
		return this;
	}

	public static FTransformFilter FromNative(IntPtr nativeBuffer)
	{
		return new FTransformFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTransformFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTransformFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTransformFilter(nativeBuffer + arrayIndex * FTransformFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTransformFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTransformFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTransformFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.TransformFilter");
			return;
		}
		FFilterOptionPerAxis.ToNative(IntPtr.Add(nativeStruct, TranslationFilter_Offset), TranslationFilter);
		FFilterOptionPerAxis.ToNative(IntPtr.Add(nativeStruct, RotationFilter_Offset), RotationFilter);
		FFilterOptionPerAxis.ToNative(IntPtr.Add(nativeStruct, ScaleFilter_Offset), ScaleFilter);
	}

	public FTransformFilter(IntPtr nativeStruct)
	{
		if (!FTransformFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AnimationCore.TransformFilter");
			TranslationFilter = default(FFilterOptionPerAxis);
			RotationFilter = default(FFilterOptionPerAxis);
			ScaleFilter = default(FFilterOptionPerAxis);
		}
		else
		{
			TranslationFilter = FFilterOptionPerAxis.FromNative(IntPtr.Add(nativeStruct, TranslationFilter_Offset));
			RotationFilter = FFilterOptionPerAxis.FromNative(IntPtr.Add(nativeStruct, RotationFilter_Offset));
			ScaleFilter = FFilterOptionPerAxis.FromNative(IntPtr.Add(nativeStruct, ScaleFilter_Offset));
		}
	}

	static FTransformFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTransformFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTransformFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AnimationCore.TransformFilter");
		FTransformFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		TranslationFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TranslationFilter");
		TranslationFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TranslationFilter", Classes.FStructProperty);
		RotationFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RotationFilter");
		RotationFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RotationFilter", Classes.FStructProperty);
		ScaleFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScaleFilter");
		ScaleFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScaleFilter", Classes.FStructProperty);
		FTransformFilter_IsValid = intPtr != IntPtr.Zero && TranslationFilter_IsValid && RotationFilter_IsValid && ScaleFilter_IsValid;
		NativeReflection.LogStructIsValid("/Script/AnimationCore.TransformFilter", FTransformFilter_IsValid);
	}
}
