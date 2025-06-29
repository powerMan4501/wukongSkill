using System;
using b1.Plugins.GSInput;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_InputActionIcon")]
public class BUI_InputActionIcon : BUI_Button
{
	private const string IconName = "InputIcon";

	protected UGSInputActionIcon InputActionIcon;

	private const string DescriptionName = "TxtName";

	protected UTextBlock DescriptionTextBlock;

	private UWidget ResizeCon;

	private static bool InputAction_IsValid;

	private static int InputAction_Offset;

	private static bool Description_IsValid;

	private static int Description_Offset;

	private FText Description_TextCached;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[DisplayName("Input Action")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_InputActionIcon:InputAction")]
	public UInputAction InputAction
	{
		get
		{
			CheckDestroyed();
			if (!InputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputActionIcon:InputAction");
				return null;
			}
			return UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(base.Address, InputAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputActionIcon:InputAction");
			}
			else
			{
				UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(base.Address, InputAction_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("Description")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_InputActionIcon:Description")]
	public FText Description
	{
		get
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputActionIcon:Description");
				return null;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			return Description_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputActionIcon:Description");
				return;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			Description_TextCached.CopyFrom(value);
		}
	}

	[DisplayName("Color")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_InputActionIcon:Color")]
	public FColor Color
	{
		get
		{
			CheckDestroyed();
			if (!Color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputActionIcon:Color");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, Color_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_InputActionIcon:Color");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, Color_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ResizeCon = FindChildWidget("ResizeCon");
		InputActionIcon = FindChildWidget("InputIcon") as UGSInputActionIcon;
		DescriptionTextBlock = FindChildWidget("TxtName") as UTextBlock;
		InputActionIcon?.SetInputAction(InputAction);
		DescriptionTextBlock?.SetText(Description);
		DescriptionTextBlock?.SetColorAndOpacity(new FSlateColor
		{
			SpecifiedColor = new FLinearColor(Color)
		});
	}

	public void ActiveInputIcon(bool IsActive)
	{
		ResizeCon.SetVisibility((!IsActive) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_InputActionIcon");
		InputAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InputAction");
		InputAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InputAction", Classes.FObjectProperty);
		Description_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Description");
		Description_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Description", Classes.FTextProperty);
		Color_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Color");
		Color_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Color", Classes.FStructProperty);
	}

	static BUI_InputActionIcon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_InputActionIcon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_InputActionIcon));
	}
}
