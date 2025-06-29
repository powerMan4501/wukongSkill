using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.TextureSourceColorSettings", "Engine", UnrealModuleType.Engine)]
public struct FTextureSourceColorSettings
{
	private static bool EncodingOverride_IsValid;

	private static FFieldAddress EncodingOverride_PropertyAddress;

	private static int EncodingOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureSourceColorSettings:EncodingOverride")]
	public ETextureSourceEncoding EncodingOverride;

	private static bool ColorSpace_IsValid;

	private static FFieldAddress ColorSpace_PropertyAddress;

	private static int ColorSpace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureSourceColorSettings:ColorSpace")]
	public ETextureColorSpace ColorSpace;

	private static bool RedChromaticityCoordinate_IsValid;

	private static int RedChromaticityCoordinate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureSourceColorSettings:RedChromaticityCoordinate")]
	public FVector2D RedChromaticityCoordinate;

	private static bool GreenChromaticityCoordinate_IsValid;

	private static int GreenChromaticityCoordinate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureSourceColorSettings:GreenChromaticityCoordinate")]
	public FVector2D GreenChromaticityCoordinate;

	private static bool BlueChromaticityCoordinate_IsValid;

	private static int BlueChromaticityCoordinate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureSourceColorSettings:BlueChromaticityCoordinate")]
	public FVector2D BlueChromaticityCoordinate;

	private static bool WhiteChromaticityCoordinate_IsValid;

	private static int WhiteChromaticityCoordinate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureSourceColorSettings:WhiteChromaticityCoordinate")]
	public FVector2D WhiteChromaticityCoordinate;

	private static bool ChromaticAdaptationMethod_IsValid;

	private static FFieldAddress ChromaticAdaptationMethod_PropertyAddress;

	private static int ChromaticAdaptationMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.TextureSourceColorSettings:ChromaticAdaptationMethod")]
	public ETextureChromaticAdaptationMethod ChromaticAdaptationMethod;

	private static bool FTextureSourceColorSettings_IsValid;

	private static int FTextureSourceColorSettings_StructSize;

	public FTextureSourceColorSettings Copy()
	{
		return this;
	}

	public static FTextureSourceColorSettings FromNative(IntPtr nativeBuffer)
	{
		return new FTextureSourceColorSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTextureSourceColorSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTextureSourceColorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTextureSourceColorSettings(nativeBuffer + arrayIndex * FTextureSourceColorSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTextureSourceColorSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTextureSourceColorSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTextureSourceColorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TextureSourceColorSettings");
			return;
		}
		EnumMarshaler<ETextureSourceEncoding>.ToNative(IntPtr.Add(nativeStruct, EncodingOverride_Offset), 0, EncodingOverride_PropertyAddress.Address, EncodingOverride);
		EnumMarshaler<ETextureColorSpace>.ToNative(IntPtr.Add(nativeStruct, ColorSpace_Offset), 0, ColorSpace_PropertyAddress.Address, ColorSpace);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, RedChromaticityCoordinate_Offset), RedChromaticityCoordinate);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, GreenChromaticityCoordinate_Offset), GreenChromaticityCoordinate);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, BlueChromaticityCoordinate_Offset), BlueChromaticityCoordinate);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, WhiteChromaticityCoordinate_Offset), WhiteChromaticityCoordinate);
		EnumMarshaler<ETextureChromaticAdaptationMethod>.ToNative(IntPtr.Add(nativeStruct, ChromaticAdaptationMethod_Offset), 0, ChromaticAdaptationMethod_PropertyAddress.Address, ChromaticAdaptationMethod);
	}

	public FTextureSourceColorSettings(IntPtr nativeStruct)
	{
		if (!FTextureSourceColorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.TextureSourceColorSettings");
			EncodingOverride = ETextureSourceEncoding.TSE_None;
			ColorSpace = ETextureColorSpace.TCS_None;
			RedChromaticityCoordinate = default(FVector2D);
			GreenChromaticityCoordinate = default(FVector2D);
			BlueChromaticityCoordinate = default(FVector2D);
			WhiteChromaticityCoordinate = default(FVector2D);
			ChromaticAdaptationMethod = ETextureChromaticAdaptationMethod.TCAM_None;
		}
		else
		{
			EncodingOverride = EnumMarshaler<ETextureSourceEncoding>.FromNative(IntPtr.Add(nativeStruct, EncodingOverride_Offset), 0, EncodingOverride_PropertyAddress.Address);
			ColorSpace = EnumMarshaler<ETextureColorSpace>.FromNative(IntPtr.Add(nativeStruct, ColorSpace_Offset), 0, ColorSpace_PropertyAddress.Address);
			RedChromaticityCoordinate = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, RedChromaticityCoordinate_Offset));
			GreenChromaticityCoordinate = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, GreenChromaticityCoordinate_Offset));
			BlueChromaticityCoordinate = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, BlueChromaticityCoordinate_Offset));
			WhiteChromaticityCoordinate = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, WhiteChromaticityCoordinate_Offset));
			ChromaticAdaptationMethod = EnumMarshaler<ETextureChromaticAdaptationMethod>.FromNative(IntPtr.Add(nativeStruct, ChromaticAdaptationMethod_Offset), 0, ChromaticAdaptationMethod_PropertyAddress.Address);
		}
	}

	static FTextureSourceColorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTextureSourceColorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTextureSourceColorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.TextureSourceColorSettings");
		FTextureSourceColorSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EncodingOverride_PropertyAddress, intPtr, "EncodingOverride");
		EncodingOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EncodingOverride");
		EncodingOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EncodingOverride", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ColorSpace_PropertyAddress, intPtr, "ColorSpace");
		ColorSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorSpace");
		ColorSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorSpace", Classes.FEnumProperty);
		RedChromaticityCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RedChromaticityCoordinate");
		RedChromaticityCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RedChromaticityCoordinate", Classes.FStructProperty);
		GreenChromaticityCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GreenChromaticityCoordinate");
		GreenChromaticityCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GreenChromaticityCoordinate", Classes.FStructProperty);
		BlueChromaticityCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlueChromaticityCoordinate");
		BlueChromaticityCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlueChromaticityCoordinate", Classes.FStructProperty);
		WhiteChromaticityCoordinate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WhiteChromaticityCoordinate");
		WhiteChromaticityCoordinate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WhiteChromaticityCoordinate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ChromaticAdaptationMethod_PropertyAddress, intPtr, "ChromaticAdaptationMethod");
		ChromaticAdaptationMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChromaticAdaptationMethod");
		ChromaticAdaptationMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChromaticAdaptationMethod", Classes.FEnumProperty);
		FTextureSourceColorSettings_IsValid = intPtr != IntPtr.Zero && EncodingOverride_IsValid && ColorSpace_IsValid && RedChromaticityCoordinate_IsValid && GreenChromaticityCoordinate_IsValid && BlueChromaticityCoordinate_IsValid && WhiteChromaticityCoordinate_IsValid && ChromaticAdaptationMethod_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.TextureSourceColorSettings", FTextureSourceColorSettings_IsValid);
	}
}
