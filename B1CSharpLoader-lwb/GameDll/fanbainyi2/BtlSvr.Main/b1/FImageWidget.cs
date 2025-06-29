using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ImageWidget")]
public struct FImageWidget
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Widget名字")]
	[USharpPath("/Script/b1-Managed.ImageWidget:WidgetName")]
	public string WidgetName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Config")]
	[USharpPath("/Script/b1-Managed.ImageWidget:ImgConfig")]
	public FImageConfig ImgConfig;

	private static int ImageWidget_StructSize;

	private static int ImageWidget_IsValid;

	private static bool WidgetName_IsValid;

	private static int WidgetName_Offset;

	private static bool ImgConfig_IsValid;

	private static int ImgConfig_Offset;

	public FImageWidget Copy()
	{
		return this;
	}

	public static FImageWidget FromNative(IntPtr nativeBuffer)
	{
		return new FImageWidget(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FImageWidget value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FImageWidget FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FImageWidget(IntPtr.Add(nativeBuffer, arrayIndex * ImageWidget_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FImageWidget value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ImageWidget_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ImageWidget_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ImageWidget");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, WidgetName_Offset), WidgetName);
		FImageConfig.ToNative(IntPtr.Add(nativeStruct, ImgConfig_Offset), ImgConfig);
	}

	public FImageWidget(IntPtr nativeStruct)
	{
		if (ImageWidget_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ImageWidget");
			WidgetName = null;
			ImgConfig = default(FImageConfig);
		}
		else
		{
			WidgetName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, WidgetName_Offset));
			ImgConfig = FImageConfig.FromNative(IntPtr.Add(nativeStruct, ImgConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ImageWidget");
		ImageWidget_StructSize = NativeReflection.GetStructSize(intPtr);
		WidgetName_Offset = NativeReflection.GetPropertyOffset(intPtr, "WidgetName");
		WidgetName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WidgetName", Classes.FStrProperty);
		ImgConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImgConfig");
		ImgConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImgConfig", Classes.FStructProperty);
		ImageWidget_IsValid = ((intPtr != IntPtr.Zero && WidgetName_IsValid && ImgConfig_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ImageWidget", (byte)ImageWidget_IsValid != 0);
	}

	static FImageWidget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FImageWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FImageWidget));
	}
}
