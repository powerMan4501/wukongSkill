using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptPropertyHandle", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptPropertyHandle
{
	private static bool FJavascriptPropertyHandle_IsValid;

	private static int FJavascriptPropertyHandle_StructSize;

	public FJavascriptPropertyHandle Copy()
	{
		return this;
	}

	public static FJavascriptPropertyHandle FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptPropertyHandle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptPropertyHandle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptPropertyHandle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptPropertyHandle(nativeBuffer + arrayIndex * FJavascriptPropertyHandle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptPropertyHandle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptPropertyHandle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptPropertyHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptPropertyHandle");
		}
	}

	public FJavascriptPropertyHandle(IntPtr nativeStruct)
	{
		if (!FJavascriptPropertyHandle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptPropertyHandle");
		}
	}

	static FJavascriptPropertyHandle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptPropertyHandle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptPropertyHandle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptPropertyHandle");
		FJavascriptPropertyHandle_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptPropertyHandle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptPropertyHandle", FJavascriptPropertyHandle_IsValid);
	}
}
