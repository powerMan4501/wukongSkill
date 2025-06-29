using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptSocket", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptSocket
{
	private static bool FJavascriptSocket_IsValid;

	private static int FJavascriptSocket_StructSize;

	public FJavascriptSocket Copy()
	{
		return this;
	}

	public static FJavascriptSocket FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptSocket(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptSocket value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptSocket FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptSocket(nativeBuffer + arrayIndex * FJavascriptSocket_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptSocket value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptSocket_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptSocket_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptSocket");
		}
	}

	public FJavascriptSocket(IntPtr nativeStruct)
	{
		if (!FJavascriptSocket_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptSocket");
		}
	}

	static FJavascriptSocket()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptSocket)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptSocket));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptSocket");
		FJavascriptSocket_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptSocket_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptSocket", FJavascriptSocket_IsValid);
	}
}
