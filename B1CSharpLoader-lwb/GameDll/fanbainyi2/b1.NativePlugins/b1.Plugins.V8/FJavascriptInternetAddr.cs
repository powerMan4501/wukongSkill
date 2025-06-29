using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptInternetAddr", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptInternetAddr
{
	private static bool FJavascriptInternetAddr_IsValid;

	private static int FJavascriptInternetAddr_StructSize;

	public FJavascriptInternetAddr Copy()
	{
		return this;
	}

	public static FJavascriptInternetAddr FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptInternetAddr(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptInternetAddr value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptInternetAddr FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptInternetAddr(nativeBuffer + arrayIndex * FJavascriptInternetAddr_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptInternetAddr value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptInternetAddr_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptInternetAddr_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptInternetAddr");
		}
	}

	public FJavascriptInternetAddr(IntPtr nativeStruct)
	{
		if (!FJavascriptInternetAddr_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptInternetAddr");
		}
	}

	static FJavascriptInternetAddr()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptInternetAddr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptInternetAddr));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptInternetAddr");
		FJavascriptInternetAddr_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptInternetAddr_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptInternetAddr", FJavascriptInternetAddr_IsValid);
	}
}
