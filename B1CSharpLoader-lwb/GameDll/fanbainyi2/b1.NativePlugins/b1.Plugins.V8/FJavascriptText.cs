using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptText", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptText
{
	private static bool FJavascriptText_IsValid;

	private static int FJavascriptText_StructSize;

	public FJavascriptText Copy()
	{
		return this;
	}

	public static FJavascriptText FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptText(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptText value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptText FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptText(nativeBuffer + arrayIndex * FJavascriptText_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptText value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptText_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptText_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptText");
		}
	}

	public FJavascriptText(IntPtr nativeStruct)
	{
		if (!FJavascriptText_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptText");
		}
	}

	static FJavascriptText()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptText)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptText));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptText");
		FJavascriptText_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptText_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptText", FJavascriptText_IsValid);
	}
}
