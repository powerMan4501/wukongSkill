using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[UMetaPath("/Script/SlateCore.SlateWidgetStyle", "SlateCore", UnrealModuleType.Engine)]
public class FSlateWidgetStyle : StructAsClass
{
	private static bool FSlateWidgetStyle_IsValid;

	private static IntPtr FSlateWidgetStyle_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FSlateWidgetStyle_StructAddress;
	}

	static FSlateWidgetStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSlateWidgetStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSlateWidgetStyle));
	}

	private static void LoadNativeType()
	{
		FSlateWidgetStyle_IsValid = (FSlateWidgetStyle_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.SlateWidgetStyle")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.SlateWidgetStyle", FSlateWidgetStyle_IsValid);
	}
}
