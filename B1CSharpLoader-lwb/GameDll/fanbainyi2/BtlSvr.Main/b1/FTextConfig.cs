using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TextConfig")]
public struct FTextConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TextConfig:Anchors")]
	public FAnchors Anchors;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TextConfig:Alignment")]
	public FVector2D Alignment;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TextConfig:Pos")]
	public FVector2D Pos;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TextConfig:Color")]
	public FSlateColor Color;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用字体大小配置")]
	[USharpPath("/Script/b1-Managed.TextConfig:UseFontSize")]
	public bool UseFontSize;

	[UProperty]
	[EditAnywhere]
	[DisplayName("字体大小")]
	[UMeta(MDProp.EditCondition, "UseFontSize")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TextConfig:FontSize")]
	public int FontSize;

	[UProperty]
	[DisplayName("使用字符间距配置")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TextConfig:UseLetterSpacing")]
	public bool UseLetterSpacing;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("字符间距")]
	[UMeta(MDProp.EditCondition, "UseLetterSpacing")]
	[USharpPath("/Script/b1-Managed.TextConfig:LetterSpacing")]
	public int LetterSpacing;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TextConfig:ShadowOffset")]
	public FVector2D ShadowOffset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TextConfig:ShadowColor")]
	public FLinearColor ShadowColor;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.TextConfig:Justification")]
	public ETextJustify Justification;

	[Tooltip("已废弃")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TextConfig:FontInfo")]
	public FSlateFontInfo FontInfo;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("已废弃")]
	[USharpPath("/Script/b1-Managed.TextConfig:ColorMap")]
	public Dictionary<ETextColorType, FSlateColor> ColorMap;

	private static int TextConfig_StructSize;

	private static int TextConfig_IsValid;

	private static bool Anchors_IsValid;

	private static int Anchors_Offset;

	private static bool Alignment_IsValid;

	private static int Alignment_Offset;

	private static bool Pos_IsValid;

	private static int Pos_Offset;

	private static bool Color_IsValid;

	private static int Color_Offset;

	private static bool UseFontSize_IsValid;

	private static int UseFontSize_Offset;

	private static FFieldAddress UseFontSize_PropertyAddress;

	private static bool FontSize_IsValid;

	private static int FontSize_Offset;

	private static bool UseLetterSpacing_IsValid;

	private static int UseLetterSpacing_Offset;

	private static FFieldAddress UseLetterSpacing_PropertyAddress;

	private static bool LetterSpacing_IsValid;

	private static int LetterSpacing_Offset;

	private static bool ShadowOffset_IsValid;

	private static int ShadowOffset_Offset;

	private static bool ShadowColor_IsValid;

	private static int ShadowColor_Offset;

	private static bool Justification_IsValid;

	private static int Justification_Offset;

	private static FFieldAddress Justification_PropertyAddress;

	private static bool FontInfo_IsValid;

	private static int FontInfo_Offset;

	private static bool ColorMap_IsValid;

	private static int ColorMap_Offset;

	private static FFieldAddress ColorMap_PropertyAddress;

	public FTextConfig Copy()
	{
		FTextConfig result = this;
		if (ColorMap != null)
		{
			result.ColorMap = new Dictionary<ETextColorType, FSlateColor>(ColorMap);
		}
		return result;
	}

	public static FTextConfig FromNative(IntPtr nativeBuffer)
	{
		return new FTextConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTextConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTextConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTextConfig(IntPtr.Add(nativeBuffer, arrayIndex * TextConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTextConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TextConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TextConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TextConfig");
			return;
		}
		FAnchors.ToNative(IntPtr.Add(nativeStruct, Anchors_Offset), Anchors);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Alignment_Offset), Alignment);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Pos_Offset), Pos);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseFontSize_Offset), 0, UseFontSize_PropertyAddress.Address, UseFontSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, FontSize_Offset), FontSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseLetterSpacing_Offset), 0, UseLetterSpacing_PropertyAddress.Address, UseLetterSpacing);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LetterSpacing_Offset), LetterSpacing);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ShadowOffset_Offset), ShadowOffset);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, ShadowColor_Offset), ShadowColor);
		EnumMarshaler<ETextJustify>.ToNative(IntPtr.Add(nativeStruct, Justification_Offset), 0, Justification_PropertyAddress.Address, Justification);
		FSlateFontInfo.ToNative(IntPtr.Add(nativeStruct, FontInfo_Offset), FontInfo);
		new TMapCopyMarshaler<ETextColorType, FSlateColor>(1, ColorMap_PropertyAddress, CachedMarshalingDelegates<ETextColorType, EnumMarshaler<ETextColorType>>.FromNative, CachedMarshalingDelegates<ETextColorType, EnumMarshaler<ETextColorType>>.ToNative, CachedMarshalingDelegates<FSlateColor, FSlateColor>.FromNative, CachedMarshalingDelegates<FSlateColor, FSlateColor>.ToNative).ToNative(IntPtr.Add(nativeStruct, ColorMap_Offset), ColorMap);
	}

	public FTextConfig(IntPtr nativeStruct)
	{
		if (TextConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TextConfig");
			Anchors = default(FAnchors);
			Alignment = default(FVector2D);
			Pos = default(FVector2D);
			Color = default(FSlateColor);
			UseFontSize = false;
			FontSize = 0;
			UseLetterSpacing = false;
			LetterSpacing = 0;
			ShadowOffset = default(FVector2D);
			ShadowColor = default(FLinearColor);
			Justification = ETextJustify.Left;
			FontInfo = default(FSlateFontInfo);
			ColorMap = null;
		}
		else
		{
			Anchors = FAnchors.FromNative(IntPtr.Add(nativeStruct, Anchors_Offset));
			Alignment = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Alignment_Offset));
			Pos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Pos_Offset));
			Color = FSlateColor.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			UseFontSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseFontSize_Offset), 0, UseFontSize_PropertyAddress.Address);
			FontSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, FontSize_Offset));
			UseLetterSpacing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseLetterSpacing_Offset), 0, UseLetterSpacing_PropertyAddress.Address);
			LetterSpacing = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LetterSpacing_Offset));
			ShadowOffset = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ShadowOffset_Offset));
			ShadowColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, ShadowColor_Offset));
			Justification = EnumMarshaler<ETextJustify>.FromNative(IntPtr.Add(nativeStruct, Justification_Offset), 0, Justification_PropertyAddress.Address);
			FontInfo = FSlateFontInfo.FromNative(IntPtr.Add(nativeStruct, FontInfo_Offset));
			ColorMap = new TMapCopyMarshaler<ETextColorType, FSlateColor>(1, ColorMap_PropertyAddress, CachedMarshalingDelegates<ETextColorType, EnumMarshaler<ETextColorType>>.FromNative, CachedMarshalingDelegates<ETextColorType, EnumMarshaler<ETextColorType>>.ToNative, CachedMarshalingDelegates<FSlateColor, FSlateColor>.FromNative, CachedMarshalingDelegates<FSlateColor, FSlateColor>.ToNative).FromNative(IntPtr.Add(nativeStruct, ColorMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TextConfig");
		TextConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		Anchors_Offset = NativeReflection.GetPropertyOffset(intPtr, "Anchors");
		Anchors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Anchors", Classes.FStructProperty);
		Alignment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Alignment");
		Alignment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Alignment", Classes.FStructProperty);
		Pos_Offset = NativeReflection.GetPropertyOffset(intPtr, "Pos");
		Pos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Pos", Classes.FStructProperty);
		Color_Offset = NativeReflection.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UseFontSize_PropertyAddress, intPtr, "UseFontSize");
		UseFontSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseFontSize");
		UseFontSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseFontSize", Classes.FBoolProperty);
		FontSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "FontSize");
		FontSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FontSize", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UseLetterSpacing_PropertyAddress, intPtr, "UseLetterSpacing");
		UseLetterSpacing_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseLetterSpacing");
		UseLetterSpacing_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseLetterSpacing", Classes.FBoolProperty);
		LetterSpacing_Offset = NativeReflection.GetPropertyOffset(intPtr, "LetterSpacing");
		LetterSpacing_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LetterSpacing", Classes.FIntProperty);
		ShadowOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowOffset");
		ShadowOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowOffset", Classes.FStructProperty);
		ShadowColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadowColor");
		ShadowColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadowColor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Justification_PropertyAddress, intPtr, "Justification");
		Justification_Offset = NativeReflection.GetPropertyOffset(intPtr, "Justification");
		Justification_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Justification", Classes.FEnumProperty);
		FontInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "FontInfo");
		FontInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FontInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ColorMap_PropertyAddress, intPtr, "ColorMap");
		ColorMap_Offset = NativeReflection.GetPropertyOffset(intPtr, "ColorMap");
		ColorMap_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ColorMap", Classes.FMapProperty);
		TextConfig_IsValid = ((intPtr != IntPtr.Zero && Anchors_IsValid && Alignment_IsValid && Pos_IsValid && Color_IsValid && UseFontSize_IsValid && FontSize_IsValid && UseLetterSpacing_IsValid && LetterSpacing_IsValid && ShadowOffset_IsValid && ShadowColor_IsValid && Justification_IsValid && FontInfo_IsValid && ColorMap_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TextConfig", (byte)TextConfig_IsValid != 0);
	}

	static FTextConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTextConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTextConfig));
	}
}
