using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SlateBrushOutlineSettings", "SlateCore", UnrealModuleType.Engine)]
public struct FSlateBrushOutlineSettings
{
	private static bool CornerRadii_IsValid;

	private static int CornerRadii_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrushOutlineSettings:CornerRadii")]
	public FVector4 CornerRadii;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SlateBrushOutlineSettings:Color")]
	public FSlateColor Color;

	private static bool Width_IsValid;

	private static int Width_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrushOutlineSettings:Width")]
	public float Width;

	private static bool RoundingType_IsValid;

	private static FFieldAddress RoundingType_PropertyAddress;

	private static int RoundingType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrushOutlineSettings:RoundingType")]
	public ESlateBrushRoundingType RoundingType;

	private static bool UseBrushTransparency_IsValid;

	private static FFieldAddress UseBrushTransparency_PropertyAddress;

	private static int UseBrushTransparency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrushOutlineSettings:bUseBrushTransparency")]
	public bool UseBrushTransparency;

	private static bool FSlateBrushOutlineSettings_IsValid;

	private static int FSlateBrushOutlineSettings_StructSize;

	public FSlateBrushOutlineSettings Copy()
	{
		return this;
	}

	public static FSlateBrushOutlineSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSlateBrushOutlineSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSlateBrushOutlineSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSlateBrushOutlineSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSlateBrushOutlineSettings(nativeBuffer + arrayIndex * FSlateBrushOutlineSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSlateBrushOutlineSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSlateBrushOutlineSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSlateBrushOutlineSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateBrushOutlineSettings");
			return;
		}
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, CornerRadii_Offset), CornerRadii);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Width_Offset), Width);
		EnumMarshaler<ESlateBrushRoundingType>.ToNative(IntPtr.Add(nativeStruct, RoundingType_Offset), 0, RoundingType_PropertyAddress.Address, RoundingType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseBrushTransparency_Offset), 0, UseBrushTransparency_PropertyAddress.Address, UseBrushTransparency);
	}

	public FSlateBrushOutlineSettings(IntPtr nativeStruct)
	{
		if (!FSlateBrushOutlineSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateBrushOutlineSettings");
			CornerRadii = default(FVector4);
			Color = default(FSlateColor);
			Width = 0f;
			RoundingType = ESlateBrushRoundingType.FixedRadius;
			UseBrushTransparency = false;
		}
		else
		{
			CornerRadii = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, CornerRadii_Offset));
			Color = FSlateColor.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			Width = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Width_Offset));
			RoundingType = EnumMarshaler<ESlateBrushRoundingType>.FromNative(IntPtr.Add(nativeStruct, RoundingType_Offset), 0, RoundingType_PropertyAddress.Address);
			UseBrushTransparency = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseBrushTransparency_Offset), 0, UseBrushTransparency_PropertyAddress.Address);
		}
	}

	static FSlateBrushOutlineSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSlateBrushOutlineSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSlateBrushOutlineSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SlateBrushOutlineSettings");
		FSlateBrushOutlineSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		CornerRadii_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CornerRadii");
		CornerRadii_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CornerRadii", Classes.FStructProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		Width_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Width");
		Width_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Width", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RoundingType_PropertyAddress, intPtr, "RoundingType");
		RoundingType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoundingType");
		RoundingType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoundingType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBrushTransparency_PropertyAddress, intPtr, "bUseBrushTransparency");
		UseBrushTransparency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseBrushTransparency");
		UseBrushTransparency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseBrushTransparency", Classes.FBoolProperty);
		FSlateBrushOutlineSettings_IsValid = intPtr != IntPtr.Zero && CornerRadii_IsValid && Color_IsValid && Width_IsValid && RoundingType_IsValid && UseBrushTransparency_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SlateBrushOutlineSettings", FSlateBrushOutlineSettings_IsValid);
	}
}
