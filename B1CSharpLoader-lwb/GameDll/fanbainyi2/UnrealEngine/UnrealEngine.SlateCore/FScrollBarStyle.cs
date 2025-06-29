using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ScrollBarStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FScrollBarStyle
{
	private static bool HorizontalBackgroundImage_IsValid;

	private static int HorizontalBackgroundImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:HorizontalBackgroundImage")]
	public FSlateBrush HorizontalBackgroundImage;

	private static bool VerticalBackgroundImage_IsValid;

	private static int VerticalBackgroundImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:VerticalBackgroundImage")]
	public FSlateBrush VerticalBackgroundImage;

	private static bool VerticalTopSlotImage_IsValid;

	private static int VerticalTopSlotImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:VerticalTopSlotImage")]
	public FSlateBrush VerticalTopSlotImage;

	private static bool HorizontalTopSlotImage_IsValid;

	private static int HorizontalTopSlotImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:HorizontalTopSlotImage")]
	public FSlateBrush HorizontalTopSlotImage;

	private static bool VerticalBottomSlotImage_IsValid;

	private static int VerticalBottomSlotImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:VerticalBottomSlotImage")]
	public FSlateBrush VerticalBottomSlotImage;

	private static bool HorizontalBottomSlotImage_IsValid;

	private static int HorizontalBottomSlotImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:HorizontalBottomSlotImage")]
	public FSlateBrush HorizontalBottomSlotImage;

	private static bool NormalThumbImage_IsValid;

	private static int NormalThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:NormalThumbImage")]
	public FSlateBrush NormalThumbImage;

	private static bool HoveredThumbImage_IsValid;

	private static int HoveredThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:HoveredThumbImage")]
	public FSlateBrush HoveredThumbImage;

	private static bool DraggedThumbImage_IsValid;

	private static int DraggedThumbImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:DraggedThumbImage")]
	public FSlateBrush DraggedThumbImage;

	private static bool Thickness_IsValid;

	private static int Thickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ScrollBarStyle:Thickness")]
	public float Thickness;

	private static bool FScrollBarStyle_IsValid;

	private static int FScrollBarStyle_StructSize;

	public FScrollBarStyle Copy()
	{
		return this;
	}

	public static FScrollBarStyle FromNative(IntPtr nativeBuffer)
	{
		return new FScrollBarStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScrollBarStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScrollBarStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScrollBarStyle(nativeBuffer + arrayIndex * FScrollBarStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScrollBarStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScrollBarStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScrollBarStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ScrollBarStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HorizontalBackgroundImage_Offset), HorizontalBackgroundImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, VerticalBackgroundImage_Offset), VerticalBackgroundImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, VerticalTopSlotImage_Offset), VerticalTopSlotImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HorizontalTopSlotImage_Offset), HorizontalTopSlotImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, VerticalBottomSlotImage_Offset), VerticalBottomSlotImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HorizontalBottomSlotImage_Offset), HorizontalBottomSlotImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, NormalThumbImage_Offset), NormalThumbImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HoveredThumbImage_Offset), HoveredThumbImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DraggedThumbImage_Offset), DraggedThumbImage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Thickness_Offset), Thickness);
	}

	public FScrollBarStyle(IntPtr nativeStruct)
	{
		if (!FScrollBarStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ScrollBarStyle");
			HorizontalBackgroundImage = default(FSlateBrush);
			VerticalBackgroundImage = default(FSlateBrush);
			VerticalTopSlotImage = default(FSlateBrush);
			HorizontalTopSlotImage = default(FSlateBrush);
			VerticalBottomSlotImage = default(FSlateBrush);
			HorizontalBottomSlotImage = default(FSlateBrush);
			NormalThumbImage = default(FSlateBrush);
			HoveredThumbImage = default(FSlateBrush);
			DraggedThumbImage = default(FSlateBrush);
			Thickness = 0f;
		}
		else
		{
			HorizontalBackgroundImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HorizontalBackgroundImage_Offset));
			VerticalBackgroundImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, VerticalBackgroundImage_Offset));
			VerticalTopSlotImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, VerticalTopSlotImage_Offset));
			HorizontalTopSlotImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HorizontalTopSlotImage_Offset));
			VerticalBottomSlotImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, VerticalBottomSlotImage_Offset));
			HorizontalBottomSlotImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HorizontalBottomSlotImage_Offset));
			NormalThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, NormalThumbImage_Offset));
			HoveredThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HoveredThumbImage_Offset));
			DraggedThumbImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DraggedThumbImage_Offset));
			Thickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Thickness_Offset));
		}
	}

	static FScrollBarStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScrollBarStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScrollBarStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.ScrollBarStyle");
		FScrollBarStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		HorizontalBackgroundImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalBackgroundImage");
		HorizontalBackgroundImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalBackgroundImage", Classes.FStructProperty);
		VerticalBackgroundImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalBackgroundImage");
		VerticalBackgroundImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalBackgroundImage", Classes.FStructProperty);
		VerticalTopSlotImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalTopSlotImage");
		VerticalTopSlotImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalTopSlotImage", Classes.FStructProperty);
		HorizontalTopSlotImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalTopSlotImage");
		HorizontalTopSlotImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalTopSlotImage", Classes.FStructProperty);
		VerticalBottomSlotImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalBottomSlotImage");
		VerticalBottomSlotImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalBottomSlotImage", Classes.FStructProperty);
		HorizontalBottomSlotImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalBottomSlotImage");
		HorizontalBottomSlotImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalBottomSlotImage", Classes.FStructProperty);
		NormalThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalThumbImage");
		NormalThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalThumbImage", Classes.FStructProperty);
		HoveredThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredThumbImage");
		HoveredThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredThumbImage", Classes.FStructProperty);
		DraggedThumbImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DraggedThumbImage");
		DraggedThumbImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DraggedThumbImage", Classes.FStructProperty);
		Thickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Thickness");
		Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Thickness", Classes.FFloatProperty);
		FScrollBarStyle_IsValid = intPtr != IntPtr.Zero && HorizontalBackgroundImage_IsValid && VerticalBackgroundImage_IsValid && VerticalTopSlotImage_IsValid && HorizontalTopSlotImage_IsValid && VerticalBottomSlotImage_IsValid && HorizontalBottomSlotImage_IsValid && NormalThumbImage_IsValid && HoveredThumbImage_IsValid && DraggedThumbImage_IsValid && Thickness_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ScrollBarStyle", FScrollBarStyle_IsValid);
	}
}
