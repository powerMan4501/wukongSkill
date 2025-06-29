using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.RTAvatarRectLightConfig", "UnrealExtent", UnrealModuleType.Game)]
public struct FRTAvatarRectLightConfig
{
	private static bool LightTransform_IsValid;

	private static int LightTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/UnrealExtent.RTAvatarRectLightConfig:LightTransform")]
	public FTransform LightTransform;

	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.RTAvatarRectLightConfig:Intensity")]
	public float Intensity;

	private static bool LightColor_IsValid;

	private static int LightColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.RTAvatarRectLightConfig:LightColor")]
	public FLinearColor LightColor;

	private static bool SourceWidth_IsValid;

	private static int SourceWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.RTAvatarRectLightConfig:SourceWidth")]
	public float SourceWidth;

	private static bool SourceHeight_IsValid;

	private static int SourceHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.RTAvatarRectLightConfig:SourceHeight")]
	public float SourceHeight;

	private static bool FRTAvatarRectLightConfig_IsValid;

	private static int FRTAvatarRectLightConfig_StructSize;

	public FRTAvatarRectLightConfig Copy()
	{
		return this;
	}

	public static FRTAvatarRectLightConfig FromNative(IntPtr nativeBuffer)
	{
		return new FRTAvatarRectLightConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRTAvatarRectLightConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRTAvatarRectLightConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRTAvatarRectLightConfig(nativeBuffer + arrayIndex * FRTAvatarRectLightConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRTAvatarRectLightConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRTAvatarRectLightConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRTAvatarRectLightConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.RTAvatarRectLightConfig");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, LightTransform_Offset), LightTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Intensity_Offset), Intensity);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, LightColor_Offset), LightColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SourceWidth_Offset), SourceWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SourceHeight_Offset), SourceHeight);
	}

	public FRTAvatarRectLightConfig(IntPtr nativeStruct)
	{
		if (!FRTAvatarRectLightConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.RTAvatarRectLightConfig");
			LightTransform = default(FTransform);
			Intensity = 0f;
			LightColor = default(FLinearColor);
			SourceWidth = 0f;
			SourceHeight = 0f;
		}
		else
		{
			LightTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, LightTransform_Offset));
			Intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Intensity_Offset));
			LightColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, LightColor_Offset));
			SourceWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SourceWidth_Offset));
			SourceHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SourceHeight_Offset));
		}
	}

	static FRTAvatarRectLightConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRTAvatarRectLightConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRTAvatarRectLightConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.RTAvatarRectLightConfig");
		FRTAvatarRectLightConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		LightTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightTransform");
		LightTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightTransform", Classes.FStructProperty);
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		LightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightColor");
		LightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightColor", Classes.FStructProperty);
		SourceWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceWidth");
		SourceWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceWidth", Classes.FFloatProperty);
		SourceHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceHeight");
		SourceHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceHeight", Classes.FFloatProperty);
		FRTAvatarRectLightConfig_IsValid = intPtr != IntPtr.Zero && LightTransform_IsValid && Intensity_IsValid && LightColor_IsValid && SourceWidth_IsValid && SourceHeight_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.RTAvatarRectLightConfig", FRTAvatarRectLightConfig_IsValid);
	}
}
