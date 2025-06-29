using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.HyperlinkStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FHyperlinkStyle
{
	private static bool UnderlineStyle_IsValid;

	private static int UnderlineStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.HyperlinkStyle:UnderlineStyle")]
	public FButtonStyle UnderlineStyle;

	private static bool TextStyle_IsValid;

	private static int TextStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.HyperlinkStyle:TextStyle")]
	public FTextBlockStyle TextStyle;

	private static bool Padding_IsValid;

	private static int Padding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.HyperlinkStyle:Padding")]
	public FMargin Padding;

	private static bool FHyperlinkStyle_IsValid;

	private static int FHyperlinkStyle_StructSize;

	public FHyperlinkStyle Copy()
	{
		return this;
	}

	public static FHyperlinkStyle FromNative(IntPtr nativeBuffer)
	{
		return new FHyperlinkStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHyperlinkStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHyperlinkStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHyperlinkStyle(nativeBuffer + arrayIndex * FHyperlinkStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHyperlinkStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHyperlinkStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHyperlinkStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.HyperlinkStyle");
			return;
		}
		FButtonStyle.ToNative(IntPtr.Add(nativeStruct, UnderlineStyle_Offset), UnderlineStyle);
		FTextBlockStyle.ToNative(IntPtr.Add(nativeStruct, TextStyle_Offset), TextStyle);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, Padding_Offset), Padding);
	}

	public FHyperlinkStyle(IntPtr nativeStruct)
	{
		if (!FHyperlinkStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.HyperlinkStyle");
			UnderlineStyle = default(FButtonStyle);
			TextStyle = default(FTextBlockStyle);
			Padding = default(FMargin);
		}
		else
		{
			UnderlineStyle = FButtonStyle.FromNative(IntPtr.Add(nativeStruct, UnderlineStyle_Offset));
			TextStyle = FTextBlockStyle.FromNative(IntPtr.Add(nativeStruct, TextStyle_Offset));
			Padding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, Padding_Offset));
		}
	}

	static FHyperlinkStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHyperlinkStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHyperlinkStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.HyperlinkStyle");
		FHyperlinkStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		UnderlineStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnderlineStyle");
		UnderlineStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnderlineStyle", Classes.FStructProperty);
		TextStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextStyle");
		TextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextStyle", Classes.FStructProperty);
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		FHyperlinkStyle_IsValid = intPtr != IntPtr.Zero && UnderlineStyle_IsValid && TextStyle_IsValid && Padding_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.HyperlinkStyle", FHyperlinkStyle_IsValid);
	}
}
