using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SlateFontInfo", "SlateCore", UnrealModuleType.Engine)]
public struct FSlateFontInfo
{
	private static bool FontObject_IsValid;

	private static int FontObject_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/SlateCore.SlateFontInfo:FontObject")]
	public UObject FontObject;

	private static bool FontMaterial_IsValid;

	private static int FontMaterial_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/SlateCore.SlateFontInfo:FontMaterial")]
	public UObject FontMaterial;

	private static bool GSIsWithFontUVExtend_IsValid;

	private static FFieldAddress GSIsWithFontUVExtend_PropertyAddress;

	private static int GSIsWithFontUVExtend_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateFontInfo:bGSIsWithFontUVExtend")]
	public bool GSIsWithFontUVExtend;

	private static bool OutlineSettings_IsValid;

	private static int OutlineSettings_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/SlateCore.SlateFontInfo:OutlineSettings")]
	public FFontOutlineSettings OutlineSettings;

	private static bool TypefaceFontName_IsValid;

	private static int TypefaceFontName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateFontInfo:TypefaceFontName")]
	public FName TypefaceFontName;

	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateFontInfo:Size")]
	public int Size;

	private static bool LetterSpacing_IsValid;

	private static int LetterSpacing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateFontInfo:LetterSpacing")]
	public int LetterSpacing;

	private static bool FSlateFontInfo_IsValid;

	private static int FSlateFontInfo_StructSize;

	public FSlateFontInfo Copy()
	{
		return this;
	}

	public static FSlateFontInfo FromNative(IntPtr nativeBuffer)
	{
		return new FSlateFontInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSlateFontInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSlateFontInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSlateFontInfo(nativeBuffer + arrayIndex * FSlateFontInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSlateFontInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSlateFontInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSlateFontInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateFontInfo");
			return;
		}
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, FontObject_Offset), FontObject);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, FontMaterial_Offset), FontMaterial);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GSIsWithFontUVExtend_Offset), 0, GSIsWithFontUVExtend_PropertyAddress.Address, GSIsWithFontUVExtend);
		FFontOutlineSettings.ToNative(IntPtr.Add(nativeStruct, OutlineSettings_Offset), OutlineSettings);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TypefaceFontName_Offset), TypefaceFontName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LetterSpacing_Offset), LetterSpacing);
	}

	public FSlateFontInfo(IntPtr nativeStruct)
	{
		if (!FSlateFontInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateFontInfo");
			FontObject = null;
			FontMaterial = null;
			GSIsWithFontUVExtend = false;
			OutlineSettings = default(FFontOutlineSettings);
			TypefaceFontName = default(FName);
			Size = 0;
			LetterSpacing = 0;
		}
		else
		{
			FontObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, FontObject_Offset));
			FontMaterial = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, FontMaterial_Offset));
			GSIsWithFontUVExtend = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GSIsWithFontUVExtend_Offset), 0, GSIsWithFontUVExtend_PropertyAddress.Address);
			OutlineSettings = FFontOutlineSettings.FromNative(IntPtr.Add(nativeStruct, OutlineSettings_Offset));
			TypefaceFontName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TypefaceFontName_Offset));
			Size = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			LetterSpacing = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LetterSpacing_Offset));
		}
	}

	static FSlateFontInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSlateFontInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSlateFontInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SlateFontInfo");
		FSlateFontInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FontObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FontObject");
		FontObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FontObject", Classes.FObjectProperty);
		FontMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FontMaterial");
		FontMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FontMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSIsWithFontUVExtend_PropertyAddress, intPtr, "bGSIsWithFontUVExtend");
		GSIsWithFontUVExtend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGSIsWithFontUVExtend");
		GSIsWithFontUVExtend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGSIsWithFontUVExtend", Classes.FBoolProperty);
		OutlineSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutlineSettings");
		OutlineSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutlineSettings", Classes.FStructProperty);
		TypefaceFontName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TypefaceFontName");
		TypefaceFontName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TypefaceFontName", Classes.FNameProperty);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FIntProperty);
		LetterSpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LetterSpacing");
		LetterSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LetterSpacing", Classes.FIntProperty);
		FSlateFontInfo_IsValid = intPtr != IntPtr.Zero && FontObject_IsValid && FontMaterial_IsValid && GSIsWithFontUVExtend_IsValid && OutlineSettings_IsValid && TypefaceFontName_IsValid && Size_IsValid && LetterSpacing_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SlateFontInfo", FSlateFontInfo_IsValid);
	}
}
