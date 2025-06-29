using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.RTAvatarRectLightInfo", "FuncLibEditor", UnrealModuleType.Game)]
public struct FRTAvatarRectLightInfo
{
	private static bool LightTransform_IsValid;

	private static int LightTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/FuncLibEditor.RTAvatarRectLightInfo:LightTransform")]
	public FTransform LightTransform;

	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.RTAvatarRectLightInfo:Intensity")]
	public float Intensity;

	private static bool LightColor_IsValid;

	private static int LightColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.RTAvatarRectLightInfo:LightColor")]
	public FLinearColor LightColor;

	private static bool SourceWidth_IsValid;

	private static int SourceWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.RTAvatarRectLightInfo:SourceWidth")]
	public float SourceWidth;

	private static bool SourceHeight_IsValid;

	private static int SourceHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.RTAvatarRectLightInfo:SourceHeight")]
	public float SourceHeight;

	private static bool FRTAvatarRectLightInfo_IsValid;

	private static int FRTAvatarRectLightInfo_StructSize;

	public FRTAvatarRectLightInfo Copy()
	{
		return this;
	}

	public static FRTAvatarRectLightInfo FromNative(IntPtr nativeBuffer)
	{
		return new FRTAvatarRectLightInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRTAvatarRectLightInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRTAvatarRectLightInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRTAvatarRectLightInfo(nativeBuffer + arrayIndex * FRTAvatarRectLightInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRTAvatarRectLightInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRTAvatarRectLightInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRTAvatarRectLightInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.RTAvatarRectLightInfo");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, LightTransform_Offset), LightTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Intensity_Offset), Intensity);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, LightColor_Offset), LightColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SourceWidth_Offset), SourceWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SourceHeight_Offset), SourceHeight);
	}

	public FRTAvatarRectLightInfo(IntPtr nativeStruct)
	{
		if (!FRTAvatarRectLightInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.RTAvatarRectLightInfo");
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

	static FRTAvatarRectLightInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRTAvatarRectLightInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRTAvatarRectLightInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.RTAvatarRectLightInfo");
		FRTAvatarRectLightInfo_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FRTAvatarRectLightInfo_IsValid = intPtr != IntPtr.Zero && LightTransform_IsValid && Intensity_IsValid && LightColor_IsValid && SourceWidth_IsValid && SourceHeight_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.RTAvatarRectLightInfo", FRTAvatarRectLightInfo_IsValid);
	}
}
