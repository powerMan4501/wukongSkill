using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.TextWidget")]
public struct FTextWidget
{
	[UProperty]
	[DisplayName("Widget名字")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TextWidget:WidgetName")]
	public string WidgetName;

	[DisplayName("Config")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TextWidget:TextConfig")]
	public FTextConfig TextConfig;

	private static int TextWidget_StructSize;

	private static int TextWidget_IsValid;

	private static bool WidgetName_IsValid;

	private static int WidgetName_Offset;

	private static bool TextConfig_IsValid;

	private static int TextConfig_Offset;

	public FTextWidget Copy()
	{
		return this;
	}

	public static FTextWidget FromNative(IntPtr nativeBuffer)
	{
		return new FTextWidget(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTextWidget value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTextWidget FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTextWidget(IntPtr.Add(nativeBuffer, arrayIndex * TextWidget_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTextWidget value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TextWidget_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TextWidget_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TextWidget");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, WidgetName_Offset), WidgetName);
		FTextConfig.ToNative(IntPtr.Add(nativeStruct, TextConfig_Offset), TextConfig);
	}

	public FTextWidget(IntPtr nativeStruct)
	{
		if (TextWidget_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TextWidget");
			WidgetName = null;
			TextConfig = default(FTextConfig);
		}
		else
		{
			WidgetName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, WidgetName_Offset));
			TextConfig = FTextConfig.FromNative(IntPtr.Add(nativeStruct, TextConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TextWidget");
		TextWidget_StructSize = NativeReflection.GetStructSize(intPtr);
		WidgetName_Offset = NativeReflection.GetPropertyOffset(intPtr, "WidgetName");
		WidgetName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WidgetName", Classes.FStrProperty);
		TextConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextConfig");
		TextConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextConfig", Classes.FStructProperty);
		TextWidget_IsValid = ((intPtr != IntPtr.Zero && WidgetName_IsValid && TextConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TextWidget", (byte)TextWidget_IsValid != 0);
	}

	static FTextWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTextWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTextWidget));
	}
}
