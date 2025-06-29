using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptUMG;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptUMG.JavascriptTextLayout", "JavascriptUMG", UnrealModuleType.GamePlugin)]
public struct FJavascriptTextLayout
{
	private static bool FJavascriptTextLayout_IsValid;

	private static int FJavascriptTextLayout_StructSize;

	public FJavascriptTextLayout Copy()
	{
		return this;
	}

	public static FJavascriptTextLayout FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptTextLayout(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptTextLayout value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptTextLayout FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptTextLayout(nativeBuffer + arrayIndex * FJavascriptTextLayout_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptTextLayout value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptTextLayout_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptTextLayout_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptTextLayout");
		}
	}

	public FJavascriptTextLayout(IntPtr nativeStruct)
	{
		if (!FJavascriptTextLayout_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptUMG.JavascriptTextLayout");
		}
	}

	static FJavascriptTextLayout()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptTextLayout)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptTextLayout));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptUMG.JavascriptTextLayout");
		FJavascriptTextLayout_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptTextLayout_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptUMG.JavascriptTextLayout", FJavascriptTextLayout_IsValid);
	}
}
