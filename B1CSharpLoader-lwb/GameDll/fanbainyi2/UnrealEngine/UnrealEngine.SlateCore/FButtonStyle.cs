using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ButtonStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FButtonStyle
{
	private static bool Normal_IsValid;

	private static int Normal_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:Normal")]
	public FSlateBrush Normal;

	private static bool Hovered_IsValid;

	private static int Hovered_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:Hovered")]
	public FSlateBrush Hovered;

	private static bool Pressed_IsValid;

	private static int Pressed_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:Pressed")]
	public FSlateBrush Pressed;

	private static bool Disabled_IsValid;

	private static int Disabled_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:Disabled")]
	public FSlateBrush Disabled;

	private static bool NormalForeground_IsValid;

	private static int NormalForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:NormalForeground")]
	public FSlateColor NormalForeground;

	private static bool HoveredForeground_IsValid;

	private static int HoveredForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:HoveredForeground")]
	public FSlateColor HoveredForeground;

	private static bool PressedForeground_IsValid;

	private static int PressedForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:PressedForeground")]
	public FSlateColor PressedForeground;

	private static bool DisabledForeground_IsValid;

	private static int DisabledForeground_Offset;

	[UProperty(Flags = (PropFlags)4507997673881605uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:DisabledForeground")]
	public FSlateColor DisabledForeground;

	private static bool NormalPadding_IsValid;

	private static int NormalPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:NormalPadding")]
	public FMargin NormalPadding;

	private static bool PressedPadding_IsValid;

	private static int PressedPadding_Offset;

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:PressedPadding")]
	public FMargin PressedPadding;

	private static bool PressedSlateSound_IsValid;

	private static int PressedSlateSound_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:PressedSlateSound")]
	public FSlateSound PressedSlateSound;

	private static bool HoveredSlateSound_IsValid;

	private static int HoveredSlateSound_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SlateCore.ButtonStyle:HoveredSlateSound")]
	public FSlateSound HoveredSlateSound;

	private static bool FButtonStyle_IsValid;

	private static int FButtonStyle_StructSize;

	public FButtonStyle Copy()
	{
		return this;
	}

	public static FButtonStyle FromNative(IntPtr nativeBuffer)
	{
		return new FButtonStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FButtonStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FButtonStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FButtonStyle(nativeBuffer + arrayIndex * FButtonStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FButtonStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FButtonStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FButtonStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ButtonStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, Hovered_Offset), Hovered);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, Pressed_Offset), Pressed);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, Disabled_Offset), Disabled);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, NormalForeground_Offset), NormalForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, HoveredForeground_Offset), HoveredForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, PressedForeground_Offset), PressedForeground);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, DisabledForeground_Offset), DisabledForeground);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, NormalPadding_Offset), NormalPadding);
		BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(nativeStruct, PressedPadding_Offset), PressedPadding);
		FSlateSound.ToNative(IntPtr.Add(nativeStruct, PressedSlateSound_Offset), PressedSlateSound);
		FSlateSound.ToNative(IntPtr.Add(nativeStruct, HoveredSlateSound_Offset), HoveredSlateSound);
	}

	public FButtonStyle(IntPtr nativeStruct)
	{
		if (!FButtonStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.ButtonStyle");
			Normal = default(FSlateBrush);
			Hovered = default(FSlateBrush);
			Pressed = default(FSlateBrush);
			Disabled = default(FSlateBrush);
			NormalForeground = default(FSlateColor);
			HoveredForeground = default(FSlateColor);
			PressedForeground = default(FSlateColor);
			DisabledForeground = default(FSlateColor);
			NormalPadding = default(FMargin);
			PressedPadding = default(FMargin);
			PressedSlateSound = default(FSlateSound);
			HoveredSlateSound = default(FSlateSound);
		}
		else
		{
			Normal = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			Hovered = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, Hovered_Offset));
			Pressed = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, Pressed_Offset));
			Disabled = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, Disabled_Offset));
			NormalForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, NormalForeground_Offset));
			HoveredForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, HoveredForeground_Offset));
			PressedForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, PressedForeground_Offset));
			DisabledForeground = FSlateColor.FromNative(IntPtr.Add(nativeStruct, DisabledForeground_Offset));
			NormalPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, NormalPadding_Offset));
			PressedPadding = BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(nativeStruct, PressedPadding_Offset));
			PressedSlateSound = FSlateSound.FromNative(IntPtr.Add(nativeStruct, PressedSlateSound_Offset));
			HoveredSlateSound = FSlateSound.FromNative(IntPtr.Add(nativeStruct, HoveredSlateSound_Offset));
		}
	}

	static FButtonStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FButtonStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FButtonStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.ButtonStyle");
		FButtonStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		Hovered_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Hovered");
		Hovered_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Hovered", Classes.FStructProperty);
		Pressed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pressed");
		Pressed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pressed", Classes.FStructProperty);
		Disabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Disabled");
		Disabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Disabled", Classes.FStructProperty);
		NormalForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalForeground");
		NormalForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalForeground", Classes.FStructProperty);
		HoveredForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredForeground");
		HoveredForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredForeground", Classes.FStructProperty);
		PressedForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressedForeground");
		PressedForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressedForeground", Classes.FStructProperty);
		DisabledForeground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisabledForeground");
		DisabledForeground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisabledForeground", Classes.FStructProperty);
		NormalPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalPadding");
		NormalPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalPadding", Classes.FStructProperty);
		PressedPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressedPadding");
		PressedPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressedPadding", Classes.FStructProperty);
		PressedSlateSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PressedSlateSound");
		PressedSlateSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PressedSlateSound", Classes.FStructProperty);
		HoveredSlateSound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HoveredSlateSound");
		HoveredSlateSound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HoveredSlateSound", Classes.FStructProperty);
		FButtonStyle_IsValid = intPtr != IntPtr.Zero && Normal_IsValid && Hovered_IsValid && Pressed_IsValid && Disabled_IsValid && NormalForeground_IsValid && HoveredForeground_IsValid && PressedForeground_IsValid && DisabledForeground_IsValid && NormalPadding_IsValid && PressedPadding_IsValid && PressedSlateSound_IsValid && HoveredSlateSound_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ButtonStyle", FButtonStyle_IsValid);
	}
}
