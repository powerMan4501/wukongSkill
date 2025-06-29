using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptSlateWidget", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public struct FJavascriptSlateWidget
{
	private static bool FJavascriptSlateWidget_IsValid;

	private static int FJavascriptSlateWidget_StructSize;

	public FJavascriptSlateWidget Copy()
	{
		return this;
	}

	public static FJavascriptSlateWidget FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptSlateWidget(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptSlateWidget value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptSlateWidget FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptSlateWidget(nativeBuffer + arrayIndex * FJavascriptSlateWidget_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptSlateWidget value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptSlateWidget_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateWidget_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateWidget");
		}
	}

	public FJavascriptSlateWidget(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateWidget_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateWidget");
		}
	}

	static FJavascriptSlateWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptSlateWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptSlateWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptUMG.JavascriptSlateWidget");
		FJavascriptSlateWidget_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptSlateWidget_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptUMG.JavascriptSlateWidget", FJavascriptSlateWidget_IsValid);
	}
}
