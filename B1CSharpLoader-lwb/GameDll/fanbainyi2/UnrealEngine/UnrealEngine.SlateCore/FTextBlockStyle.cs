using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.TextBlockStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FTextBlockStyle
{
	private static bool Font_IsValid;

	private static int Font_Offset;

	[UProperty(Flags = (PropFlags)6755399441055749uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:Font")]
	public FSlateFontInfo Font;

	private static bool ColorAndOpacity_IsValid;

	private static int ColorAndOpacity_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:ColorAndOpacity")]
	public FSlateColor ColorAndOpacity;

	private static bool ShadowOffset_IsValid;

	private static int ShadowOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:ShadowOffset")]
	public FVector2D ShadowOffset;

	private static bool ShadowColorAndOpacity_IsValid;

	private static int ShadowColorAndOpacity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:ShadowColorAndOpacity")]
	public FLinearColor ShadowColorAndOpacity;

	private static bool HighlightColor_IsValid;

	private static int HighlightColor_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:HighlightColor")]
	public FSlateColor HighlightColor;

	private static bool HighlightShape_IsValid;

	private static int HighlightShape_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:HighlightShape")]
	public FSlateBrush HighlightShape;

	private static bool StrikeBrush_IsValid;

	private static int StrikeBrush_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:StrikeBrush")]
	public FSlateBrush StrikeBrush;

	private static bool UnderlineBrush_IsValid;

	private static int UnderlineBrush_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:UnderlineBrush")]
	public FSlateBrush UnderlineBrush;

	private static bool TransformPolicy_IsValid;

	private static FFieldAddress TransformPolicy_PropertyAddress;

	private static int TransformPolicy_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:TransformPolicy")]
	public ETextTransformPolicy TransformPolicy;

	private static bool OverflowPolicy_IsValid;

	private static FFieldAddress OverflowPolicy_PropertyAddress;

	private static int OverflowPolicy_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/SlateCore.TextBlockStyle:OverflowPolicy")]
	public ETextOverflowPolicy OverflowPolicy;

	private static bool FTextBlockStyle_IsValid;

	private static int FTextBlockStyle_StructSize;

	public FTextBlockStyle Copy()
	{
		return this;
	}

	public static FTextBlockStyle FromNative(IntPtr nativeBuffer)
	{
		return new FTextBlockStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTextBlockStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTextBlockStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTextBlockStyle(nativeBuffer + arrayIndex * FTextBlockStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTextBlockStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTextBlockStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTextBlockStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.TextBlockStyle");
			return;
		}
		FSlateFontInfo.ToNative(IntPtr.Add(nativeStruct, Font_Offset), Font);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, ColorAndOpacity_Offset), ColorAndOpacity);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ShadowOffset_Offset), ShadowOffset);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, ShadowColorAndOpacity_Offset), ShadowColorAndOpacity);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, HighlightColor_Offset), HighlightColor);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, HighlightShape_Offset), HighlightShape);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, StrikeBrush_Offset), StrikeBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, UnderlineBrush_Offset), UnderlineBrush);
		EnumMarshaler<ETextTransformPolicy>.ToNative(IntPtr.Add(nativeStruct, TransformPolicy_Offset), 0, TransformPolicy_PropertyAddress.Address, TransformPolicy);
		EnumMarshaler<ETextOverflowPolicy>.ToNative(IntPtr.Add(nativeStruct, OverflowPolicy_Offset), 0, OverflowPolicy_PropertyAddress.Address, OverflowPolicy);
	}

	public FTextBlockStyle(IntPtr nativeStruct)
	{
		if (!FTextBlockStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.TextBlockStyle");
			Font = default(FSlateFontInfo);
			ColorAndOpacity = default(FSlateColor);
			ShadowOffset = default(FVector2D);
			ShadowColorAndOpacity = default(FLinearColor);
			HighlightColor = default(FSlateColor);
			HighlightShape = default(FSlateBrush);
			StrikeBrush = default(FSlateBrush);
			UnderlineBrush = default(FSlateBrush);
			TransformPolicy = ETextTransformPolicy.None;
			OverflowPolicy = ETextOverflowPolicy.Clip;
		}
		else
		{
			Font = FSlateFontInfo.FromNative(IntPtr.Add(nativeStruct, Font_Offset));
			ColorAndOpacity = FSlateColor.FromNative(IntPtr.Add(nativeStruct, ColorAndOpacity_Offset));
			ShadowOffset = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ShadowOffset_Offset));
			ShadowColorAndOpacity = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, ShadowColorAndOpacity_Offset));
			HighlightColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, HighlightColor_Offset));
			HighlightShape = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, HighlightShape_Offset));
			StrikeBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, StrikeBrush_Offset));
			UnderlineBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, UnderlineBrush_Offset));
			TransformPolicy = EnumMarshaler<ETextTransformPolicy>.FromNative(IntPtr.Add(nativeStruct, TransformPolicy_Offset), 0, TransformPolicy_PropertyAddress.Address);
			OverflowPolicy = EnumMarshaler<ETextOverflowPolicy>.FromNative(IntPtr.Add(nativeStruct, OverflowPolicy_Offset), 0, OverflowPolicy_PropertyAddress.Address);
		}
	}

	static FTextBlockStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTextBlockStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTextBlockStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.TextBlockStyle");
		FTextBlockStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FStructProperty);
		ColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorAndOpacity");
		ColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorAndOpacity", Classes.FStructProperty);
		ShadowOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowOffset");
		ShadowOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowOffset", Classes.FStructProperty);
		ShadowColorAndOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowColorAndOpacity");
		ShadowColorAndOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowColorAndOpacity", Classes.FStructProperty);
		HighlightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighlightColor");
		HighlightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighlightColor", Classes.FStructProperty);
		HighlightShape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighlightShape");
		HighlightShape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighlightShape", Classes.FStructProperty);
		StrikeBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrikeBrush");
		StrikeBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrikeBrush", Classes.FStructProperty);
		UnderlineBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnderlineBrush");
		UnderlineBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnderlineBrush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransformPolicy_PropertyAddress, intPtr, "TransformPolicy");
		TransformPolicy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformPolicy");
		TransformPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformPolicy", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OverflowPolicy_PropertyAddress, intPtr, "OverflowPolicy");
		OverflowPolicy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverflowPolicy");
		OverflowPolicy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverflowPolicy", Classes.FEnumProperty);
		FTextBlockStyle_IsValid = intPtr != IntPtr.Zero && Font_IsValid && ColorAndOpacity_IsValid && ShadowOffset_IsValid && ShadowColorAndOpacity_IsValid && HighlightColor_IsValid && HighlightShape_IsValid && StrikeBrush_IsValid && UnderlineBrush_IsValid && TransformPolicy_IsValid && OverflowPolicy_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.TextBlockStyle", FTextBlockStyle_IsValid);
	}
}
