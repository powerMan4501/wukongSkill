using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[UMetaPath("/Script/JavascriptUMG.JavascriptSlateIcon", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public struct FJavascriptSlateIcon
{
	private static bool FJavascriptSlateIcon_IsValid;

	private static int FJavascriptSlateIcon_StructSize;

	public FJavascriptSlateIcon Copy()
	{
		return this;
	}

	public static FJavascriptSlateIcon FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptSlateIcon(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptSlateIcon value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptSlateIcon FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptSlateIcon(nativeBuffer + arrayIndex * FJavascriptSlateIcon_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptSlateIcon value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptSlateIcon_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateIcon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateIcon");
		}
	}

	public FJavascriptSlateIcon(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateIcon_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateIcon");
		}
	}

	static FJavascriptSlateIcon()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptSlateIcon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptSlateIcon));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptUMG.JavascriptSlateIcon");
		FJavascriptSlateIcon_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptSlateIcon_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptUMG.JavascriptSlateIcon", FJavascriptSlateIcon_IsValid);
	}
}
