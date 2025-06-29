using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_NameBar")]
internal class BUI_NameBar : BUI_Widget
{
	private AActor Owner;

	private bool bResized;

	private static bool ItemNameText_IsValid;

	private static int ItemNameText_Offset;

	private static bool BackImage_IsValid;

	private static int BackImage_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_NameBar:ItemNameText")]
	private UTextBlock ItemNameText
	{
		get
		{
			CheckDestroyed();
			if (!ItemNameText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_NameBar:ItemNameText");
				return null;
			}
			return UObjectMarshaler<UTextBlock>.FromNative(IntPtr.Add(base.Address, ItemNameText_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemNameText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_NameBar:ItemNameText");
			}
			else
			{
				UObjectMarshaler<UTextBlock>.ToNative(IntPtr.Add(base.Address, ItemNameText_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_NameBar:BackImage")]
	private UImage BackImage
	{
		get
		{
			CheckDestroyed();
			if (!BackImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_NameBar:BackImage");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, BackImage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackImage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_NameBar:BackImage");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, BackImage_Offset), value);
			}
		}
	}

	protected override void OnUIInitialized()
	{
		ItemNameText = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.TextBlock_ItemName) as UTextBlock;
		BackImage = UGSE_UMGFuncLib.GetWidgetFromName(this, B1GlobalFNames.BackImage) as UImage;
		UWidgetAnimation widgetAnimationByName = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "FadeIn");
		if (widgetAnimationByName != null)
		{
			PlayAnimation(widgetAnimationByName);
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		if (!bResized)
		{
			FVector2D desiredSize = ItemNameText.GetDesiredSize();
			desiredSize.X += 100f;
			UCanvasPanelSlot uCanvasPanelSlot = BackImage.Slot as UCanvasPanelSlot;
			if (uCanvasPanelSlot != null)
			{
				uCanvasPanelSlot.SetSize(desiredSize);
			}
			bResized = true;
		}
	}

	public void SetName(string Name)
	{
		ItemNameText.SetText(FText.FromString(Name));
	}

	public void SetOwner(AActor owner)
	{
		Owner = owner;
	}

	public void SetTextColor(FLinearColor Color)
	{
		FSlateColor colorAndOpacity = new FSlateColor
		{
			SpecifiedColor = Color
		};
		ItemNameText.SetColorAndOpacity(colorAndOpacity);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_NameBar");
		ItemNameText_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ItemNameText");
		ItemNameText_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ItemNameText", Classes.FObjectProperty);
		BackImage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BackImage");
		BackImage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BackImage", Classes.FObjectProperty);
	}

	static BUI_NameBar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_NameBar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_NameBar));
	}
}
