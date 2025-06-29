using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.Slate;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Slate.ButtonWidgetStyle", "Slate", UnrealModuleType.Engine)]
public class UButtonWidgetStyle : USlateWidgetStyleContainerBase
{
	private static bool ButtonStyle_IsValid;

	private static int ButtonStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Slate.ButtonWidgetStyle:ButtonStyle")]
	public FButtonStyle ButtonStyle
	{
		get
		{
			CheckDestroyed();
			if (!ButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Slate.ButtonWidgetStyle:ButtonStyle");
				return default(FButtonStyle);
			}
			return FButtonStyle.FromNative(IntPtr.Add(base.Address, ButtonStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ButtonStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Slate.ButtonWidgetStyle:ButtonStyle");
			}
			else
			{
				FButtonStyle.ToNative(IntPtr.Add(base.Address, ButtonStyle_Offset), value);
			}
		}
	}

	static UButtonWidgetStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UButtonWidgetStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UButtonWidgetStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Slate.ButtonWidgetStyle");
		ButtonStyle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ButtonStyle");
		ButtonStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ButtonStyle", Classes.FStructProperty);
	}
}
