using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.CheckBoxStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FCheckBoxStyle
{
	private static bool CheckBoxType_IsValid;

	private static FFieldAddress CheckBoxType_PropertyAddress;

	private static int CheckBoxType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckBoxType")]
	public ESlateCheckBoxType CheckBoxType;

	private static bool UncheckedImage_IsValid;

	private static int UncheckedImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UncheckedImage")]
	public FSlateBrush UncheckedImage;

	private static bool UncheckedHoveredImage_IsValid;

	private static int UncheckedHoveredImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UncheckedHoveredImage")]
	public FSlateBrush UncheckedHoveredImage;

	private static bool UncheckedPressedImage_IsValid;

	private static int UncheckedPressedImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UncheckedPressedImage")]
	public FSlateBrush UncheckedPressedImage;

	private static bool CheckedImage_IsValid;

	private static int CheckedImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckedImage")]
	public FSlateBrush CheckedImage;

	private static bool CheckedHoveredImage_IsValid;

	private static int CheckedHoveredImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckedHoveredImage")]
	public FSlateBrush CheckedHoveredImage;

	private static bool CheckedPressedImage_IsValid;

	private static int CheckedPressedImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckedPressedImage")]
	public FSlateBrush CheckedPressedImage;

	private static bool UndeterminedImage_IsValid;

	private static int UndeterminedImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UndeterminedImage")]
	public FSlateBrush UndeterminedImage;

	private static bool UndeterminedHoveredImage_IsValid;

	private static int UndeterminedHoveredImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UndeterminedHoveredImage")]
	public FSlateBrush UndeterminedHoveredImage;

	private static bool UndeterminedPressedImage_IsValid;

	private static int UndeterminedPressedImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UndeterminedPressedImage")]
	public FSlateBrush UndeterminedPressedImage;

	private static bool Padding_IsValid;

	private static int Padding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:Padding")]
	public FMargin Padding;

	private static bool BackgroundImage_IsValid;

	private static int BackgroundImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:BackgroundImage")]
	public FSlateBrush BackgroundImage;

	private static bool BackgroundHoveredImage_IsValid;

	private static int BackgroundHoveredImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:BackgroundHoveredImage")]
	public FSlateBrush BackgroundHoveredImage;

	private static bool BackgroundPressedImage_IsValid;

	private static int BackgroundPressedImage_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:BackgroundPressedImage")]
	public FSlateBrush BackgroundPressedImage;

	private static bool ForegroundColor_IsValid;

	private static int ForegroundColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:ForegroundColor")]
	public FSlateColor ForegroundColor;

	private static bool HoveredForeground_IsValid;

	private static int HoveredForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:HoveredForeground")]
	public FSlateColor HoveredForeground;

	private static bool PressedForeground_IsValid;

	private static int PressedForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:PressedForeground")]
	public FSlateColor PressedForeground;

	private static bool CheckedForeground_IsValid;

	private static int CheckedForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckedForeground")]
	public FSlateColor CheckedForeground;

	private static bool CheckedHoveredForeground_IsValid;

	private static int CheckedHoveredForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckedHoveredForeground")]
	public FSlateColor CheckedHoveredForeground;

	private static bool CheckedPressedForeground_IsValid;

	private static int CheckedPressedForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckedPressedForeground")]
	public FSlateColor CheckedPressedForeground;

	private static bool UndeterminedForeground_IsValid;

	private static int UndeterminedForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UndeterminedForeground")]
	public FSlateColor UndeterminedForeground;

	private static bool BorderBackgroundColor_IsValid;

	private static int BorderBackgroundColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:BorderBackgroundColor")]
	public FSlateColor BorderBackgroundColor;

	private static bool CheckedSlateSound_IsValid;

	private static int CheckedSlateSound_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:CheckedSlateSound")]
	public FSlateSound CheckedSlateSound;

	private static bool UncheckedSlateSound_IsValid;

	private static int UncheckedSlateSound_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:UncheckedSlateSound")]
	public FSlateSound UncheckedSlateSound;

	private static bool HoveredSlateSound_IsValid;

	private static int HoveredSlateSound_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SlateCore.CheckBoxStyle:HoveredSlateSound")]
	public FSlateSound HoveredSlateSound;

	private static bool FCheckBoxStyle_IsValid;

	private static int FCheckBoxStyle_StructSize;

	public FCheckBoxStyle Copy()
	{
		return this;
	}

	public static FCheckBoxStyle FromNative(IntPtr nativeBuffer)
	{
		return new FCheckBoxStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCheckBoxStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCheckBoxStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCheckBoxStyle(nativeBuffer + arrayIndex * FCheckBoxStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCheckBoxStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCheckBoxStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCheckBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.CheckBoxStyle");
			return;
		}
		EnumMarshaler<ESlateCheckBoxType>.ToNative(IntPtr.Add(nativeStruct, CheckBoxType_Offset), 0, CheckBoxType_PropertyAddress.Address, CheckBoxType);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, UncheckedImage_Offset), UncheckedImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, UncheckedHoveredImage_Offset), UncheckedHoveredImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, UncheckedPressedImage_Offset), UncheckedPressedImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, CheckedImage_Offset), CheckedImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, CheckedHoveredImage_Offset), CheckedHoveredImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, CheckedPressedImage_Offset), CheckedPressedImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, UndeterminedImage_Offset), UndeterminedImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, UndeterminedHoveredImage_Offset), UndeterminedHoveredImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, UndeterminedPressedImage_Offset), UndeterminedPressedImage);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, Padding_Offset), Padding);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundImage_Offset), BackgroundImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundHoveredImage_Offset), BackgroundHoveredImage);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, BackgroundPressedImage_Offset), BackgroundPressedImage);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, ForegroundColor_Offset), ForegroundColor);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, HoveredForeground_Offset), HoveredForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, PressedForeground_Offset), PressedForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, CheckedForeground_Offset), CheckedForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, CheckedHoveredForeground_Offset), CheckedHoveredForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, CheckedPressedForeground_Offset), CheckedPressedForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, UndeterminedForeground_Offset), UndeterminedForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, BorderBackgroundColor_Offset), BorderBackgroundColor);
		FSlateSound.ToNative(IntPtr.Add(nativeStruct, CheckedSlateSound_Offset), CheckedSlateSound);
		FSlateSound.ToNative(IntPtr.Add(nativeStruct, UncheckedSlateSound_Offset), UncheckedSlateSound);
		FSlateSound.ToNative(IntPtr.Add(nativeStruct, HoveredSlateSound_Offset), HoveredSlateSound);
	}

	public FCheckBoxStyle(IntPtr nativeStruct)
	{
		if (!FCheckBoxStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.CheckBoxStyle");
			CheckBoxType = ESlateCheckBoxType.CheckBox;
			UncheckedImage = default(FSlateBrush);
			UncheckedHoveredImage = default(FSlateBrush);
			UncheckedPressedImage = default(FSlateBrush);
			CheckedImage = default(FSlateBrush);
			CheckedHoveredImage = default(FSlateBrush);
			CheckedPressedImage = default(FSlateBrush);
			UndeterminedImage = default(FSlateBrush);
			UndeterminedHoveredImage = default(FSlateBrush);
			UndeterminedPressedImage = default(FSlateBrush);
			Padding = default(FMargin);
			BackgroundImage = default(FSlateBrush);
			BackgroundHoveredImage = default(FSlateBrush);
			BackgroundPressedImage = default(FSlateBrush);
			ForegroundColor = default(FSlateColor);
			HoveredForeground = default(FSlateColor);
			PressedForeground = default(FSlateColor);
			CheckedForeground = default(FSlateColor);
			CheckedHoveredForeground = default(FSlateColor);
			CheckedPressedForeground = default(FSlateColor);
			UndeterminedForeground = default(FSlateColor);
			BorderBackgroundColor = default(FSlateColor);
			CheckedSlateSound = default(FSlateSound);
			UncheckedSlateSound = default(FSlateSound);
			HoveredSlateSound = default(FSlateSound);
		}
		else
		{
			CheckBoxType = EnumMarshaler<ESlateCheckBoxType>.FromNative(IntPtr.Add(nativeStruct, CheckBoxType_Offset), 0, CheckBoxType_PropertyAddress.Address);
			UncheckedImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, UncheckedImage_Offset));
			UncheckedHoveredImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, UncheckedHoveredImage_Offset));
			UncheckedPressedImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, UncheckedPressedImage_Offset));
			CheckedImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, CheckedImage_Offset));
			CheckedHoveredImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, CheckedHoveredImage_Offset));
			CheckedPressedImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, CheckedPressedImage_Offset));
			UndeterminedImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, UndeterminedImage_Offset));
			UndeterminedHoveredImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, UndeterminedHoveredImage_Offset));
			UndeterminedPressedImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, UndeterminedPressedImage_Offset));
			Padding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, Padding_Offset));
			BackgroundImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundImage_Offset));
			BackgroundHoveredImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundHoveredImage_Offset));
			BackgroundPressedImage = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, BackgroundPressedImage_Offset));
			ForegroundColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, ForegroundColor_Offset));
			HoveredForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, HoveredForeground_Offset));
			PressedForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, PressedForeground_Offset));
			CheckedForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, CheckedForeground_Offset));
			CheckedHoveredForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, CheckedHoveredForeground_Offset));
			CheckedPressedForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, CheckedPressedForeground_Offset));
			UndeterminedForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, UndeterminedForeground_Offset));
			BorderBackgroundColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, BorderBackgroundColor_Offset));
			CheckedSlateSound = FSlateSound.FromNative(IntPtr.Add(nativeStruct, CheckedSlateSound_Offset));
			UncheckedSlateSound = FSlateSound.FromNative(IntPtr.Add(nativeStruct, UncheckedSlateSound_Offset));
			HoveredSlateSound = FSlateSound.FromNative(IntPtr.Add(nativeStruct, HoveredSlateSound_Offset));
		}
	}

	static FCheckBoxStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCheckBoxStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCheckBoxStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.CheckBoxStyle");
		FCheckBoxStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CheckBoxType_PropertyAddress, intPtr, "CheckBoxType");
		CheckBoxType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckBoxType");
		CheckBoxType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckBoxType", Classes.FByteProperty);
		UncheckedImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UncheckedImage");
		UncheckedImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UncheckedImage", Classes.FStructProperty);
		UncheckedHoveredImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UncheckedHoveredImage");
		UncheckedHoveredImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UncheckedHoveredImage", Classes.FStructProperty);
		UncheckedPressedImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UncheckedPressedImage");
		UncheckedPressedImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UncheckedPressedImage", Classes.FStructProperty);
		CheckedImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedImage");
		CheckedImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedImage", Classes.FStructProperty);
		CheckedHoveredImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedHoveredImage");
		CheckedHoveredImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedHoveredImage", Classes.FStructProperty);
		CheckedPressedImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedPressedImage");
		CheckedPressedImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedPressedImage", Classes.FStructProperty);
		UndeterminedImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UndeterminedImage");
		UndeterminedImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UndeterminedImage", Classes.FStructProperty);
		UndeterminedHoveredImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UndeterminedHoveredImage");
		UndeterminedHoveredImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UndeterminedHoveredImage", Classes.FStructProperty);
		UndeterminedPressedImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UndeterminedPressedImage");
		UndeterminedPressedImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UndeterminedPressedImage", Classes.FStructProperty);
		Padding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Padding");
		Padding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Padding", Classes.FStructProperty);
		BackgroundImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundImage");
		BackgroundImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundImage", Classes.FStructProperty);
		BackgroundHoveredImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundHoveredImage");
		BackgroundHoveredImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundHoveredImage", Classes.FStructProperty);
		BackgroundPressedImage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundPressedImage");
		BackgroundPressedImage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundPressedImage", Classes.FStructProperty);
		ForegroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForegroundColor");
		ForegroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForegroundColor", Classes.FStructProperty);
		HoveredForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredForeground");
		HoveredForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredForeground", Classes.FStructProperty);
		PressedForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressedForeground");
		PressedForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressedForeground", Classes.FStructProperty);
		CheckedForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedForeground");
		CheckedForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedForeground", Classes.FStructProperty);
		CheckedHoveredForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedHoveredForeground");
		CheckedHoveredForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedHoveredForeground", Classes.FStructProperty);
		CheckedPressedForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedPressedForeground");
		CheckedPressedForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedPressedForeground", Classes.FStructProperty);
		UndeterminedForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UndeterminedForeground");
		UndeterminedForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UndeterminedForeground", Classes.FStructProperty);
		BorderBackgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BorderBackgroundColor");
		BorderBackgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BorderBackgroundColor", Classes.FStructProperty);
		CheckedSlateSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckedSlateSound");
		CheckedSlateSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckedSlateSound", Classes.FStructProperty);
		UncheckedSlateSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UncheckedSlateSound");
		UncheckedSlateSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UncheckedSlateSound", Classes.FStructProperty);
		HoveredSlateSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredSlateSound");
		HoveredSlateSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredSlateSound", Classes.FStructProperty);
		FCheckBoxStyle_IsValid = intPtr != IntPtr.Zero && CheckBoxType_IsValid && UncheckedImage_IsValid && UncheckedHoveredImage_IsValid && UncheckedPressedImage_IsValid && CheckedImage_IsValid && CheckedHoveredImage_IsValid && CheckedPressedImage_IsValid && UndeterminedImage_IsValid && UndeterminedHoveredImage_IsValid && UndeterminedPressedImage_IsValid && Padding_IsValid && BackgroundImage_IsValid && BackgroundHoveredImage_IsValid && BackgroundPressedImage_IsValid && ForegroundColor_IsValid && HoveredForeground_IsValid && PressedForeground_IsValid && CheckedForeground_IsValid && CheckedHoveredForeground_IsValid && CheckedPressedForeground_IsValid && UndeterminedForeground_IsValid && BorderBackgroundColor_IsValid && CheckedSlateSound_IsValid && UncheckedSlateSound_IsValid && HoveredSlateSound_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.CheckBoxStyle", FCheckBoxStyle_IsValid);
	}
}
