using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptFunction", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptFunction
{
	private static bool FJavascriptFunction_IsValid;

	private static int FJavascriptFunction_StructSize;

	public FJavascriptFunction Copy()
	{
		return this;
	}

	public static FJavascriptFunction FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptFunction(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptFunction value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptFunction FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptFunction(nativeBuffer + arrayIndex * FJavascriptFunction_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptFunction value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptFunction_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptFunction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptFunction");
		}
	}

	public FJavascriptFunction(IntPtr nativeStruct)
	{
		if (!FJavascriptFunction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptFunction");
		}
	}

	static FJavascriptFunction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptFunction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptFunction));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptFunction");
		FJavascriptFunction_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptFunction_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptFunction", FJavascriptFunction_IsValid);
	}
}
