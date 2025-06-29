using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptSlateTextRun", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public struct FJavascriptSlateTextRun
{
	private static bool FJavascriptSlateTextRun_IsValid;

	private static int FJavascriptSlateTextRun_StructSize;

	public FJavascriptSlateTextRun Copy()
	{
		return this;
	}

	public static FJavascriptSlateTextRun FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptSlateTextRun(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptSlateTextRun value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptSlateTextRun FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptSlateTextRun(nativeBuffer + arrayIndex * FJavascriptSlateTextRun_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptSlateTextRun value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptSlateTextRun_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateTextRun_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateTextRun");
		}
	}

	public FJavascriptSlateTextRun(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateTextRun_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptSlateTextRun");
		}
	}

	static FJavascriptSlateTextRun()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptSlateTextRun)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptSlateTextRun));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptUMG.JavascriptSlateTextRun");
		FJavascriptSlateTextRun_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptSlateTextRun_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptUMG.JavascriptSlateTextRun", FJavascriptSlateTextRun_IsValid);
	}
}
