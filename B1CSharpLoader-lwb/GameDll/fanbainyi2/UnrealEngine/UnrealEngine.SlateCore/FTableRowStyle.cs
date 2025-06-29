using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.TableRowStyle", "SlateCore", UnrealModuleType.Engine)]
public struct FTableRowStyle
{
	private static bool SelectorFocusedBrush_IsValid;

	private static int SelectorFocusedBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:SelectorFocusedBrush")]
	public FSlateBrush SelectorFocusedBrush;

	private static bool ActiveHoveredBrush_IsValid;

	private static int ActiveHoveredBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:ActiveHoveredBrush")]
	public FSlateBrush ActiveHoveredBrush;

	private static bool ActiveBrush_IsValid;

	private static int ActiveBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:ActiveBrush")]
	public FSlateBrush ActiveBrush;

	private static bool InactiveHoveredBrush_IsValid;

	private static int InactiveHoveredBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:InactiveHoveredBrush")]
	public FSlateBrush InactiveHoveredBrush;

	private static bool InactiveBrush_IsValid;

	private static int InactiveBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:InactiveBrush")]
	public FSlateBrush InactiveBrush;

	private static bool UseParentRowBrush_IsValid;

	private static FFieldAddress UseParentRowBrush_PropertyAddress;

	private static int UseParentRowBrush_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:bUseParentRowBrush")]
	public bool UseParentRowBrush;

	private static bool ParentRowBackgroundBrush_IsValid;

	private static int ParentRowBackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:ParentRowBackgroundBrush")]
	public FSlateBrush ParentRowBackgroundBrush;

	private static bool ParentRowBackgroundHoveredBrush_IsValid;

	private static int ParentRowBackgroundHoveredBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:ParentRowBackgroundHoveredBrush")]
	public FSlateBrush ParentRowBackgroundHoveredBrush;

	private static bool EvenRowBackgroundHoveredBrush_IsValid;

	private static int EvenRowBackgroundHoveredBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:EvenRowBackgroundHoveredBrush")]
	public FSlateBrush EvenRowBackgroundHoveredBrush;

	private static bool EvenRowBackgroundBrush_IsValid;

	private static int EvenRowBackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:EvenRowBackgroundBrush")]
	public FSlateBrush EvenRowBackgroundBrush;

	private static bool OddRowBackgroundHoveredBrush_IsValid;

	private static int OddRowBackgroundHoveredBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:OddRowBackgroundHoveredBrush")]
	public FSlateBrush OddRowBackgroundHoveredBrush;

	private static bool OddRowBackgroundBrush_IsValid;

	private static int OddRowBackgroundBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:OddRowBackgroundBrush")]
	public FSlateBrush OddRowBackgroundBrush;

	private static bool TextColor_IsValid;

	private static int TextColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:TextColor")]
	public FSlateColor TextColor;

	private static bool SelectedTextColor_IsValid;

	private static int SelectedTextColor_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:SelectedTextColor")]
	public FSlateColor SelectedTextColor;

	private static bool DropIndicator_Above_IsValid;

	private static int DropIndicator_Above_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:DropIndicator_Above")]
	public FSlateBrush DropIndicator_Above;

	private static bool DropIndicator_Onto_IsValid;

	private static int DropIndicator_Onto_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:DropIndicator_Onto")]
	public FSlateBrush DropIndicator_Onto;

	private static bool DropIndicator_Below_IsValid;

	private static int DropIndicator_Below_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:DropIndicator_Below")]
	public FSlateBrush DropIndicator_Below;

	private static bool ActiveHighlightedBrush_IsValid;

	private static int ActiveHighlightedBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:ActiveHighlightedBrush")]
	public FSlateBrush ActiveHighlightedBrush;

	private static bool InactiveHighlightedBrush_IsValid;

	private static int InactiveHighlightedBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.TableRowStyle:InactiveHighlightedBrush")]
	public FSlateBrush InactiveHighlightedBrush;

	private static bool FTableRowStyle_IsValid;

	private static int FTableRowStyle_StructSize;

	public FTableRowStyle Copy()
	{
		return this;
	}

	public static FTableRowStyle FromNative(IntPtr nativeBuffer)
	{
		return new FTableRowStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTableRowStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTableRowStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTableRowStyle(nativeBuffer + arrayIndex * FTableRowStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTableRowStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTableRowStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTableRowStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.TableRowStyle");
			return;
		}
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, SelectorFocusedBrush_Offset), SelectorFocusedBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ActiveHoveredBrush_Offset), ActiveHoveredBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ActiveBrush_Offset), ActiveBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, InactiveHoveredBrush_Offset), InactiveHoveredBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, InactiveBrush_Offset), InactiveBrush);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseParentRowBrush_Offset), 0, UseParentRowBrush_PropertyAddress.Address, UseParentRowBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ParentRowBackgroundBrush_Offset), ParentRowBackgroundBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ParentRowBackgroundHoveredBrush_Offset), ParentRowBackgroundHoveredBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, EvenRowBackgroundHoveredBrush_Offset), EvenRowBackgroundHoveredBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, EvenRowBackgroundBrush_Offset), EvenRowBackgroundBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, OddRowBackgroundHoveredBrush_Offset), OddRowBackgroundHoveredBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, OddRowBackgroundBrush_Offset), OddRowBackgroundBrush);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, TextColor_Offset), TextColor);
		FSlateColor.ToNative(IntPtr.Add(nativeStruct, SelectedTextColor_Offset), SelectedTextColor);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DropIndicator_Above_Offset), DropIndicator_Above);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DropIndicator_Onto_Offset), DropIndicator_Onto);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, DropIndicator_Below_Offset), DropIndicator_Below);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, ActiveHighlightedBrush_Offset), ActiveHighlightedBrush);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, InactiveHighlightedBrush_Offset), InactiveHighlightedBrush);
	}

	public FTableRowStyle(IntPtr nativeStruct)
	{
		if (!FTableRowStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.TableRowStyle");
			SelectorFocusedBrush = default(FSlateBrush);
			ActiveHoveredBrush = default(FSlateBrush);
			ActiveBrush = default(FSlateBrush);
			InactiveHoveredBrush = default(FSlateBrush);
			InactiveBrush = default(FSlateBrush);
			UseParentRowBrush = false;
			ParentRowBackgroundBrush = default(FSlateBrush);
			ParentRowBackgroundHoveredBrush = default(FSlateBrush);
			EvenRowBackgroundHoveredBrush = default(FSlateBrush);
			EvenRowBackgroundBrush = default(FSlateBrush);
			OddRowBackgroundHoveredBrush = default(FSlateBrush);
			OddRowBackgroundBrush = default(FSlateBrush);
			TextColor = default(FSlateColor);
			SelectedTextColor = default(FSlateColor);
			DropIndicator_Above = default(FSlateBrush);
			DropIndicator_Onto = default(FSlateBrush);
			DropIndicator_Below = default(FSlateBrush);
			ActiveHighlightedBrush = default(FSlateBrush);
			InactiveHighlightedBrush = default(FSlateBrush);
		}
		else
		{
			SelectorFocusedBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, SelectorFocusedBrush_Offset));
			ActiveHoveredBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ActiveHoveredBrush_Offset));
			ActiveBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ActiveBrush_Offset));
			InactiveHoveredBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, InactiveHoveredBrush_Offset));
			InactiveBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, InactiveBrush_Offset));
			UseParentRowBrush = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseParentRowBrush_Offset), 0, UseParentRowBrush_PropertyAddress.Address);
			ParentRowBackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ParentRowBackgroundBrush_Offset));
			ParentRowBackgroundHoveredBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ParentRowBackgroundHoveredBrush_Offset));
			EvenRowBackgroundHoveredBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, EvenRowBackgroundHoveredBrush_Offset));
			EvenRowBackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, EvenRowBackgroundBrush_Offset));
			OddRowBackgroundHoveredBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, OddRowBackgroundHoveredBrush_Offset));
			OddRowBackgroundBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, OddRowBackgroundBrush_Offset));
			TextColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, TextColor_Offset));
			SelectedTextColor = FSlateColor.FromNative(IntPtr.Add(nativeStruct, SelectedTextColor_Offset));
			DropIndicator_Above = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DropIndicator_Above_Offset));
			DropIndicator_Onto = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DropIndicator_Onto_Offset));
			DropIndicator_Below = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, DropIndicator_Below_Offset));
			ActiveHighlightedBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, ActiveHighlightedBrush_Offset));
			InactiveHighlightedBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, InactiveHighlightedBrush_Offset));
		}
	}

	static FTableRowStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTableRowStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTableRowStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.TableRowStyle");
		FTableRowStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		SelectorFocusedBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectorFocusedBrush");
		SelectorFocusedBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectorFocusedBrush", Classes.FStructProperty);
		ActiveHoveredBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveHoveredBrush");
		ActiveHoveredBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveHoveredBrush", Classes.FStructProperty);
		ActiveBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveBrush");
		ActiveBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveBrush", Classes.FStructProperty);
		InactiveHoveredBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InactiveHoveredBrush");
		InactiveHoveredBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InactiveHoveredBrush", Classes.FStructProperty);
		InactiveBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InactiveBrush");
		InactiveBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InactiveBrush", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseParentRowBrush_PropertyAddress, intPtr, "bUseParentRowBrush");
		UseParentRowBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseParentRowBrush");
		UseParentRowBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseParentRowBrush", Classes.FBoolProperty);
		ParentRowBackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentRowBackgroundBrush");
		ParentRowBackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentRowBackgroundBrush", Classes.FStructProperty);
		ParentRowBackgroundHoveredBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParentRowBackgroundHoveredBrush");
		ParentRowBackgroundHoveredBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParentRowBackgroundHoveredBrush", Classes.FStructProperty);
		EvenRowBackgroundHoveredBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EvenRowBackgroundHoveredBrush");
		EvenRowBackgroundHoveredBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EvenRowBackgroundHoveredBrush", Classes.FStructProperty);
		EvenRowBackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EvenRowBackgroundBrush");
		EvenRowBackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EvenRowBackgroundBrush", Classes.FStructProperty);
		OddRowBackgroundHoveredBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OddRowBackgroundHoveredBrush");
		OddRowBackgroundHoveredBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OddRowBackgroundHoveredBrush", Classes.FStructProperty);
		OddRowBackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OddRowBackgroundBrush");
		OddRowBackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OddRowBackgroundBrush", Classes.FStructProperty);
		TextColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextColor");
		TextColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextColor", Classes.FStructProperty);
		SelectedTextColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SelectedTextColor");
		SelectedTextColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SelectedTextColor", Classes.FStructProperty);
		DropIndicator_Above_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DropIndicator_Above");
		DropIndicator_Above_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DropIndicator_Above", Classes.FStructProperty);
		DropIndicator_Onto_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DropIndicator_Onto");
		DropIndicator_Onto_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DropIndicator_Onto", Classes.FStructProperty);
		DropIndicator_Below_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DropIndicator_Below");
		DropIndicator_Below_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DropIndicator_Below", Classes.FStructProperty);
		ActiveHighlightedBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveHighlightedBrush");
		ActiveHighlightedBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveHighlightedBrush", Classes.FStructProperty);
		InactiveHighlightedBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InactiveHighlightedBrush");
		InactiveHighlightedBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InactiveHighlightedBrush", Classes.FStructProperty);
		FTableRowStyle_IsValid = intPtr != IntPtr.Zero && SelectorFocusedBrush_IsValid && ActiveHoveredBrush_IsValid && ActiveBrush_IsValid && InactiveHoveredBrush_IsValid && InactiveBrush_IsValid && UseParentRowBrush_IsValid && ParentRowBackgroundBrush_IsValid && ParentRowBackgroundHoveredBrush_IsValid && EvenRowBackgroundHoveredBrush_IsValid && EvenRowBackgroundBrush_IsValid && OddRowBackgroundHoveredBrush_IsValid && OddRowBackgroundBrush_IsValid && TextColor_IsValid && SelectedTextColor_IsValid && DropIndicator_Above_IsValid && DropIndicator_Onto_IsValid && DropIndicator_Below_IsValid && ActiveHighlightedBrush_IsValid && InactiveHighlightedBrush_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.TableRowStyle", FTableRowStyle_IsValid);
	}
}
