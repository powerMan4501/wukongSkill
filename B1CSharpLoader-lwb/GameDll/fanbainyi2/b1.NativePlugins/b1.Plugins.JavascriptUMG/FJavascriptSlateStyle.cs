using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptSlateStyle", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public struct FJavascriptSlateStyle
{
	private static bool FJavascriptSlateStyle_IsValid;

	private static int FJavascriptSlateStyle_StructSize;

	public FJavascriptSlateStyle Copy()
	{
		return this;
	}

	public static FJavascriptSlateStyle FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptSlateStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptSlateStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptSlateStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptSlateStyle(nativeBuffer + arrayIndex * FJavascriptSlateStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptSlateStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptSlateStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateStyle");
		}
	}

	public FJavascriptSlateStyle(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateStyle");
		}
	}

	static FJavascriptSlateStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptSlateStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptSlateStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptUMG.JavascriptSlateStyle");
		FJavascriptSlateStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptSlateStyle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptUMG.JavascriptSlateStyle", FJavascriptSlateStyle_IsValid);
	}
}
