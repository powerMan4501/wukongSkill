using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptTagAndValue", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptTagAndValue
{
	private static bool FJavascriptTagAndValue_IsValid;

	private static int FJavascriptTagAndValue_StructSize;

	public FJavascriptTagAndValue Copy()
	{
		return this;
	}

	public static FJavascriptTagAndValue FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptTagAndValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptTagAndValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptTagAndValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptTagAndValue(nativeBuffer + arrayIndex * FJavascriptTagAndValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptTagAndValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptTagAndValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptTagAndValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptTagAndValue");
		}
	}

	public FJavascriptTagAndValue(IntPtr nativeStruct)
	{
		if (!FJavascriptTagAndValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptTagAndValue");
		}
	}

	static FJavascriptTagAndValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptTagAndValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptTagAndValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptTagAndValue");
		FJavascriptTagAndValue_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptTagAndValue_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptTagAndValue", FJavascriptTagAndValue_IsValid);
	}
}
