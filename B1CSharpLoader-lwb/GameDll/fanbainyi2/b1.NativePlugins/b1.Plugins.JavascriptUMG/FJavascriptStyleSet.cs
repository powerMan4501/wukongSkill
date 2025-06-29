using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptStyleSet", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public struct FJavascriptStyleSet
{
	private static bool FJavascriptStyleSet_IsValid;

	private static int FJavascriptStyleSet_StructSize;

	public FJavascriptStyleSet Copy()
	{
		return this;
	}

	public static FJavascriptStyleSet FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptStyleSet(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptStyleSet value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptStyleSet FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptStyleSet(nativeBuffer + arrayIndex * FJavascriptStyleSet_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptStyleSet value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptStyleSet_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptStyleSet_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptStyleSet");
		}
	}

	public FJavascriptStyleSet(IntPtr nativeStruct)
	{
		if (!FJavascriptStyleSet_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptStyleSet");
		}
	}

	static FJavascriptStyleSet()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptStyleSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptStyleSet));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptUMG.JavascriptStyleSet");
		FJavascriptStyleSet_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptStyleSet_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptUMG.JavascriptStyleSet", FJavascriptStyleSet_IsValid);
	}
}
