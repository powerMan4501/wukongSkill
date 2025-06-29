using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.InlineEditableTextBlockStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FInlineEditableTextBlockStyle
{
	private static bool EditableTextBoxStyle_IsValid;

	private static int EditableTextBoxStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.InlineEditableTextBlockStyle:EditableTextBoxStyle")]
	public FEditableTextBoxStyle EditableTextBoxStyle;

	private static bool TextStyle_IsValid;

	private static int TextStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.InlineEditableTextBlockStyle:TextStyle")]
	public FTextBlockStyle TextStyle;

	private static bool FInlineEditableTextBlockStyle_IsValid;

	private static int FInlineEditableTextBlockStyle_StructSize;

	public FInlineEditableTextBlockStyle Copy()
	{
		return this;
	}

	public static FInlineEditableTextBlockStyle FromNative(IntPtr nativeBuffer)
	{
		return new FInlineEditableTextBlockStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInlineEditableTextBlockStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInlineEditableTextBlockStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInlineEditableTextBlockStyle(nativeBuffer + arrayIndex * FInlineEditableTextBlockStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInlineEditableTextBlockStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInlineEditableTextBlockStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInlineEditableTextBlockStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.InlineEditableTextBlockStyle");
			return;
		}
		FEditableTextBoxStyle.ToNative(IntPtr.Add(nativeStruct, EditableTextBoxStyle_Offset), EditableTextBoxStyle);
		FTextBlockStyle.ToNative(IntPtr.Add(nativeStruct, TextStyle_Offset), TextStyle);
	}

	public FInlineEditableTextBlockStyle(IntPtr nativeStruct)
	{
		if (!FInlineEditableTextBlockStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.InlineEditableTextBlockStyle");
			EditableTextBoxStyle = default(FEditableTextBoxStyle);
			TextStyle = default(FTextBlockStyle);
		}
		else
		{
			EditableTextBoxStyle = FEditableTextBoxStyle.FromNative(IntPtr.Add(nativeStruct, EditableTextBoxStyle_Offset));
			TextStyle = FTextBlockStyle.FromNative(IntPtr.Add(nativeStruct, TextStyle_Offset));
		}
	}

	static FInlineEditableTextBlockStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInlineEditableTextBlockStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInlineEditableTextBlockStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.InlineEditableTextBlockStyle");
		FInlineEditableTextBlockStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		EditableTextBoxStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EditableTextBoxStyle");
		EditableTextBoxStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EditableTextBoxStyle", Classes.FStructProperty);
		TextStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextStyle");
		TextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextStyle", Classes.FStructProperty);
		FInlineEditableTextBlockStyle_IsValid = intPtr != IntPtr.Zero && EditableTextBoxStyle_IsValid && TextStyle_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.InlineEditableTextBlockStyle", FInlineEditableTextBlockStyle_IsValid);
	}
}
