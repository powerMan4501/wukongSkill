using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ToolBarStyle", "SlateCore", UnrealModuleType.Engine)]
public class FToolBarStyle : StructAsClass
{
	private static bool BackgroundBrush_IsValid;

	private static int BackgroundBrush_Offset;

	private static bool ExpandBrush_IsValid;

	private static int ExpandBrush_Offset;

	private static bool SeparatorBrush_IsValid;

	private static int SeparatorBrush_Offset;

	private static bool LabelStyle_IsValid;

	private static int LabelStyle_Offset;

	private static bool EditableTextStyle_IsValid;

	private static int EditableTextStyle_Offset;

	private static bool ToggleButton_IsValid;

	private static int ToggleButton_Offset;

	private static bool ComboButtonStyle_IsValid;

	private static int ComboButtonStyle_Offset;

	private static bool SettingsButtonStyle_IsValid;

	private static int SettingsButtonStyle_Offset;

	private static bool SettingsComboButton_IsValid;

	private static int SettingsComboButton_Offset;

	private static bool SettingsToggleButton_IsValid;

	private static int SettingsToggleButton_Offset;

	private static bool ButtonStyle_IsValid;

	private static int ButtonStyle_Offset;

	private static bool LabelPadding_IsValid;

	private static int LabelPadding_Offset;

	private static bool SeparatorPadding_IsValid;

	private static int SeparatorPadding_Offset;

	private static bool ComboButtonPadding_IsValid;

	private static int ComboButtonPadding_Offset;

	private static bool ButtonPadding_IsValid;

	private static int ButtonPadding_Offset;

	private static bool CheckBoxPadding_IsValid;

	private static int CheckBoxPadding_Offset;

	private static bool BlockPadding_IsValid;

	private static int BlockPadding_Offset;

	private static bool IndentedBlockPadding_IsValid;

	private static int IndentedBlockPadding_Offset;

	private static bool BackgroundPadding_IsValid;

	private static int BackgroundPadding_Offset;

	private static bool IconSize_IsValid;

	private static int IconSize_Offset;

	private static bool ShowLabels_IsValid;

	private static FFieldAddress ShowLabels_PropertyAddress;

	private static int ShowLabels_Offset;

	private static bool FToolBarStyle_IsValid;

	private static IntPtr FToolBarStyle_StructAddress;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:BackgroundBrush")]
	public FSlateBrush BackgroundBrush
	{
		get
		{
			CheckDestroyed();
			if (!BackgroundBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:BackgroundBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, BackgroundBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackgroundBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:BackgroundBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, BackgroundBrush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:ExpandBrush")]
	public FSlateBrush ExpandBrush
	{
		get
		{
			CheckDestroyed();
			if (!ExpandBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ExpandBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, ExpandBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExpandBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ExpandBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, ExpandBrush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:SeparatorBrush")]
	public FSlateBrush SeparatorBrush
	{
		get
		{
			CheckDestroyed();
			if (!SeparatorBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SeparatorBrush");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, SeparatorBrush_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeparatorBrush_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SeparatorBrush");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, SeparatorBrush_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:LabelStyle")]
	public FTextBlockStyle LabelStyle
	{
		get
		{
			CheckDestroyed();
			if (!LabelStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:LabelStyle");
				return default(FTextBlockStyle);
			}
			return FTextBlockStyle.FromNative(IntPtr.Add(base.Address, LabelStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LabelStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:LabelStyle");
			}
			else
			{
				FTextBlockStyle.ToNative(IntPtr.Add(base.Address, LabelStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:EditableTextStyle")]
	public FEditableTextBoxStyle EditableTextStyle
	{
		get
		{
			CheckDestroyed();
			if (!EditableTextStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:EditableTextStyle");
				return default(FEditableTextBoxStyle);
			}
			return FEditableTextBoxStyle.FromNative(IntPtr.Add(base.Address, EditableTextStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EditableTextStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:EditableTextStyle");
			}
			else
			{
				FEditableTextBoxStyle.ToNative(IntPtr.Add(base.Address, EditableTextStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:ToggleButton")]
	public FCheckBoxStyle ToggleButton
	{
		get
		{
			CheckDestroyed();
			if (!ToggleButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ToggleButton");
				return default(FCheckBoxStyle);
			}
			return FCheckBoxStyle.FromNative(IntPtr.Add(base.Address, ToggleButton_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ToggleButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ToggleButton");
			}
			else
			{
				FCheckBoxStyle.ToNative(IntPtr.Add(base.Address, ToggleButton_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:ComboButtonStyle")]
	public FComboButtonStyle ComboButtonStyle
	{
		get
		{
			CheckDestroyed();
			if (!ComboButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ComboButtonStyle");
				return default(FComboButtonStyle);
			}
			return FComboButtonStyle.FromNative(IntPtr.Add(base.Address, ComboButtonStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ComboButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ComboButtonStyle");
			}
			else
			{
				FComboButtonStyle.ToNative(IntPtr.Add(base.Address, ComboButtonStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:SettingsButtonStyle")]
	public FButtonStyle SettingsButtonStyle
	{
		get
		{
			CheckDestroyed();
			if (!SettingsButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SettingsButtonStyle");
				return default(FButtonStyle);
			}
			return FButtonStyle.FromNative(IntPtr.Add(base.Address, SettingsButtonStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SettingsButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SettingsButtonStyle");
			}
			else
			{
				FButtonStyle.ToNative(IntPtr.Add(base.Address, SettingsButtonStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:SettingsComboButton")]
	public FComboButtonStyle SettingsComboButton
	{
		get
		{
			CheckDestroyed();
			if (!SettingsComboButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SettingsComboButton");
				return default(FComboButtonStyle);
			}
			return FComboButtonStyle.FromNative(IntPtr.Add(base.Address, SettingsComboButton_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SettingsComboButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SettingsComboButton");
			}
			else
			{
				FComboButtonStyle.ToNative(IntPtr.Add(base.Address, SettingsComboButton_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:SettingsToggleButton")]
	public FCheckBoxStyle SettingsToggleButton
	{
		get
		{
			CheckDestroyed();
			if (!SettingsToggleButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SettingsToggleButton");
				return default(FCheckBoxStyle);
			}
			return FCheckBoxStyle.FromNative(IntPtr.Add(base.Address, SettingsToggleButton_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SettingsToggleButton_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SettingsToggleButton");
			}
			else
			{
				FCheckBoxStyle.ToNative(IntPtr.Add(base.Address, SettingsToggleButton_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:ButtonStyle")]
	public FButtonStyle ButtonStyle
	{
		get
		{
			CheckDestroyed();
			if (!ButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ButtonStyle");
				return default(FButtonStyle);
			}
			return FButtonStyle.FromNative(IntPtr.Add(base.Address, ButtonStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ButtonStyle");
			}
			else
			{
				FButtonStyle.ToNative(IntPtr.Add(base.Address, ButtonStyle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:LabelPadding")]
	public FMargin LabelPadding
	{
		get
		{
			CheckDestroyed();
			if (!LabelPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:LabelPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, LabelPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LabelPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:LabelPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, LabelPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:SeparatorPadding")]
	public FMargin SeparatorPadding
	{
		get
		{
			CheckDestroyed();
			if (!SeparatorPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SeparatorPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, SeparatorPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeparatorPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:SeparatorPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, SeparatorPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:ComboButtonPadding")]
	public FMargin ComboButtonPadding
	{
		get
		{
			CheckDestroyed();
			if (!ComboButtonPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ComboButtonPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, ComboButtonPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ComboButtonPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ComboButtonPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, ComboButtonPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:ButtonPadding")]
	public FMargin ButtonPadding
	{
		get
		{
			CheckDestroyed();
			if (!ButtonPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ButtonPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, ButtonPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ButtonPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:ButtonPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, ButtonPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:CheckBoxPadding")]
	public FMargin CheckBoxPadding
	{
		get
		{
			CheckDestroyed();
			if (!CheckBoxPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:CheckBoxPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, CheckBoxPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckBoxPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:CheckBoxPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, CheckBoxPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:BlockPadding")]
	public FMargin BlockPadding
	{
		get
		{
			CheckDestroyed();
			if (!BlockPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:BlockPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, BlockPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlockPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:BlockPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, BlockPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:IndentedBlockPadding")]
	public FMargin IndentedBlockPadding
	{
		get
		{
			CheckDestroyed();
			if (!IndentedBlockPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:IndentedBlockPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, IndentedBlockPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IndentedBlockPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:IndentedBlockPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, IndentedBlockPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:BackgroundPadding")]
	public FMargin BackgroundPadding
	{
		get
		{
			CheckDestroyed();
			if (!BackgroundPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:BackgroundPadding");
				return default(FMargin);
			}
			return BlittableTypeMarshaler<FMargin>.FromNative(IntPtr.Add(base.Address, BackgroundPadding_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackgroundPadding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:BackgroundPadding");
			}
			else
			{
				BlittableTypeMarshaler<FMargin>.ToNative(IntPtr.Add(base.Address, BackgroundPadding_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:IconSize")]
	public FVector2D IconSize
	{
		get
		{
			CheckDestroyed();
			if (!IconSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:IconSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, IconSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IconSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:IconSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, IconSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.ToolBarStyle:bShowLabels")]
	public bool ShowLabels
	{
		get
		{
			CheckDestroyed();
			if (!ShowLabels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:bShowLabels");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowLabels_Offset), 0, ShowLabels_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowLabels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SlateCore.ToolBarStyle:bShowLabels");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowLabels_Offset), 0, ShowLabels_PropertyAddress.Address, value);
			}
		}
	}

	protected override IntPtr GetStructAddress()
	{
		return FToolBarStyle_StructAddress;
	}

	static FToolBarStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolBarStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolBarStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = (FToolBarStyle_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.ToolBarStyle"));
		BackgroundBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundBrush");
		BackgroundBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundBrush", Classes.FStructProperty);
		ExpandBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExpandBrush");
		ExpandBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExpandBrush", Classes.FStructProperty);
		SeparatorBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SeparatorBrush");
		SeparatorBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SeparatorBrush", Classes.FStructProperty);
		LabelStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LabelStyle");
		LabelStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LabelStyle", Classes.FStructProperty);
		EditableTextStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EditableTextStyle");
		EditableTextStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EditableTextStyle", Classes.FStructProperty);
		ToggleButton_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ToggleButton");
		ToggleButton_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ToggleButton", Classes.FStructProperty);
		ComboButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComboButtonStyle");
		ComboButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComboButtonStyle", Classes.FStructProperty);
		SettingsButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SettingsButtonStyle");
		SettingsButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SettingsButtonStyle", Classes.FStructProperty);
		SettingsComboButton_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SettingsComboButton");
		SettingsComboButton_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SettingsComboButton", Classes.FStructProperty);
		SettingsToggleButton_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SettingsToggleButton");
		SettingsToggleButton_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SettingsToggleButton", Classes.FStructProperty);
		ButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ButtonStyle");
		ButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ButtonStyle", Classes.FStructProperty);
		LabelPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LabelPadding");
		LabelPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LabelPadding", Classes.FStructProperty);
		SeparatorPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SeparatorPadding");
		SeparatorPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SeparatorPadding", Classes.FStructProperty);
		ComboButtonPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ComboButtonPadding");
		ComboButtonPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ComboButtonPadding", Classes.FStructProperty);
		ButtonPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ButtonPadding");
		ButtonPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ButtonPadding", Classes.FStructProperty);
		CheckBoxPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CheckBoxPadding");
		CheckBoxPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CheckBoxPadding", Classes.FStructProperty);
		BlockPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlockPadding");
		BlockPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlockPadding", Classes.FStructProperty);
		IndentedBlockPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndentedBlockPadding");
		IndentedBlockPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndentedBlockPadding", Classes.FStructProperty);
		BackgroundPadding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackgroundPadding");
		BackgroundPadding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackgroundPadding", Classes.FStructProperty);
		IconSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IconSize");
		IconSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IconSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowLabels_PropertyAddress, intPtr, "bShowLabels");
		ShowLabels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowLabels");
		ShowLabels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowLabels", Classes.FBoolProperty);
		FToolBarStyle_IsValid = intPtr != IntPtr.Zero && BackgroundBrush_IsValid && ExpandBrush_IsValid && SeparatorBrush_IsValid && LabelStyle_IsValid && EditableTextStyle_IsValid && ToggleButton_IsValid && ComboButtonStyle_IsValid && SettingsButtonStyle_IsValid && SettingsComboButton_IsValid && SettingsToggleButton_IsValid && ButtonStyle_IsValid && LabelPadding_IsValid && SeparatorPadding_IsValid && ComboButtonPadding_IsValid && ButtonPadding_IsValid && CheckBoxPadding_IsValid && BlockPadding_IsValid && IndentedBlockPadding_IsValid && BackgroundPadding_IsValid && IconSize_IsValid && ShowLabels_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.ToolBarStyle", FToolBarStyle_IsValid);
	}
}
