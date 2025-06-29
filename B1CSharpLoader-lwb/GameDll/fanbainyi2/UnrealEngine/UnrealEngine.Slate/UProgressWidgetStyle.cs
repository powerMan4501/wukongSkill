using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.Slate;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Slate.ProgressWidgetStyle", "Slate", UnrealModuleType.Engine)]
public class UProgressWidgetStyle : USlateWidgetStyleContainerBase
{
	private static bool ProgressBarStyle_IsValid;

	private static int ProgressBarStyle_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Slate.ProgressWidgetStyle:ProgressBarStyle")]
	public FProgressBarStyle ProgressBarStyle
	{
		get
		{
			CheckDestroyed();
			if (!ProgressBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Slate.ProgressWidgetStyle:ProgressBarStyle");
				return default(FProgressBarStyle);
			}
			return FProgressBarStyle.FromNative(IntPtr.Add(base.Address, ProgressBarStyle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgressBarStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Slate.ProgressWidgetStyle:ProgressBarStyle");
			}
			else
			{
				FProgressBarStyle.ToNative(IntPtr.Add(base.Address, ProgressBarStyle_Offset), value);
			}
		}
	}

	static UProgressWidgetStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProgressWidgetStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProgressWidgetStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Slate.ProgressWidgetStyle");
		ProgressBarStyle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ProgressBarStyle");
		ProgressBarStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ProgressBarStyle", Classes.FStructProperty);
	}
}
