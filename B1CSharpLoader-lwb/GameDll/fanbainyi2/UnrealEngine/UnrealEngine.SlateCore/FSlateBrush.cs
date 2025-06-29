using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.SlateBrush", "SlateCore", UnrealModuleType.Engine)]
public struct FSlateBrush
{
	private static bool ImageSize_IsValid;

	private static int ImageSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:ImageSize")]
	public FVector2D ImageSize;

	private static bool Margin_IsValid;

	private static int Margin_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:Margin")]
	public FMargin Margin;

	private static bool TintColor_IsValid;

	private static int TintColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:TintColor")]
	public FSlateColor TintColor;

	private static bool OutlineSettings_IsValid;

	private static int OutlineSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:OutlineSettings")]
	public FSlateBrushOutlineSettings OutlineSettings;

	private static bool ResourceObject_IsValid;

	private static int ResourceObject_Offset;

	[UProperty(Flags = (PropFlags)21392168023228933uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:ResourceObject")]
	public UObject ResourceObject;

	private static bool DrawAs_IsValid;

	private static FFieldAddress DrawAs_PropertyAddress;

	private static int DrawAs_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:DrawAs")]
	public ESlateBrushDrawType DrawAs;

	private static bool Tiling_IsValid;

	private static FFieldAddress Tiling_PropertyAddress;

	private static int Tiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:Tiling")]
	public ESlateBrushTileType Tiling;

	private static bool Mirroring_IsValid;

	private static FFieldAddress Mirroring_PropertyAddress;

	private static int Mirroring_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.SlateBrush:Mirroring")]
	public ESlateBrushMirrorType Mirroring;

	private static bool FSlateBrush_IsValid;

	private static int FSlateBrush_StructSize;

	public FSlateBrush Copy()
	{
		return this;
	}

	public static FSlateBrush FromNative(IntPtr nativeBuffer)
	{
		return new FSlateBrush(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSlateBrush value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSlateBrush FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSlateBrush(nativeBuffer + arrayIndex * FSlateBrush_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSlateBrush value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSlateBrush_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSlateBrush_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateBrush");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ImageSize_Offset), ImageSize);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, Margin_Offset), Margin);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, TintColor_Offset), TintColor);
		FSlateBrushOutlineSettings.ToNative(IntPtr.Add(nativeStruct, OutlineSettings_Offset), OutlineSettings);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, ResourceObject_Offset), ResourceObject);
		EnumMarshaler<ESlateBrushDrawType>.ToNative(IntPtr.Add(nativeStruct, DrawAs_Offset), 0, DrawAs_PropertyAddress.Address, DrawAs);
		EnumMarshaler<ESlateBrushTileType>.ToNative(IntPtr.Add(nativeStruct, Tiling_Offset), 0, Tiling_PropertyAddress.Address, Tiling);
		EnumMarshaler<ESlateBrushMirrorType>.ToNative(IntPtr.Add(nativeStruct, Mirroring_Offset), 0, Mirroring_PropertyAddress.Address, Mirroring);
	}

	public FSlateBrush(IntPtr nativeStruct)
	{
		if (!FSlateBrush_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.SlateBrush");
			ImageSize = default(FVector2D);
			Margin = default(FMargin);
			TintColor = default(FSlateColor);
			OutlineSettings = default(FSlateBrushOutlineSettings);
			ResourceObject = null;
			DrawAs = ESlateBrushDrawType.NoDrawType;
			Tiling = ESlateBrushTileType.NoTile;
			Mirroring = ESlateBrushMirrorType.NoMirror;
		}
		else
		{
			ImageSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ImageSize_Offset));
			Margin = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, Margin_Offset));
			TintColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, TintColor_Offset));
			OutlineSettings = FSlateBrushOutlineSettings.FromNative(IntPtr.Add(nativeStruct, OutlineSettings_Offset));
			ResourceObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, ResourceObject_Offset));
			DrawAs = EnumMarshaler<ESlateBrushDrawType>.FromNative(IntPtr.Add(nativeStruct, DrawAs_Offset), 0, DrawAs_PropertyAddress.Address);
			Tiling = EnumMarshaler<ESlateBrushTileType>.FromNative(IntPtr.Add(nativeStruct, Tiling_Offset), 0, Tiling_PropertyAddress.Address);
			Mirroring = EnumMarshaler<ESlateBrushMirrorType>.FromNative(IntPtr.Add(nativeStruct, Mirroring_Offset), 0, Mirroring_PropertyAddress.Address);
		}
	}

	static FSlateBrush()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSlateBrush)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSlateBrush));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.SlateBrush");
		FSlateBrush_StructSize = NativeReflection.GetStructSize(intPtr);
		ImageSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImageSize");
		ImageSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImageSize", Classes.FStructProperty);
		Margin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Margin");
		Margin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Margin", Classes.FStructProperty);
		TintColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TintColor");
		TintColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TintColor", Classes.FStructProperty);
		OutlineSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutlineSettings");
		OutlineSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutlineSettings", Classes.FStructProperty);
		ResourceObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ResourceObject");
		ResourceObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ResourceObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawAs_PropertyAddress, intPtr, "DrawAs");
		DrawAs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawAs");
		DrawAs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawAs", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Tiling_PropertyAddress, intPtr, "Tiling");
		Tiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tiling");
		Tiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tiling", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref Mirroring_PropertyAddress, intPtr, "Mirroring");
		Mirroring_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mirroring");
		Mirroring_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mirroring", Classes.FByteProperty);
		FSlateBrush_IsValid = intPtr != IntPtr.Zero && ImageSize_IsValid && Margin_IsValid && TintColor_IsValid && OutlineSettings_IsValid && ResourceObject_IsValid && DrawAs_IsValid && Tiling_IsValid && Mirroring_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SlateBrush", FSlateBrush_IsValid);
	}
}
