using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptPropertyTypeCustomizationUtils", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptPropertyTypeCustomizationUtils
{
	private static bool FJavascriptPropertyTypeCustomizationUtils_IsValid;

	private static int FJavascriptPropertyTypeCustomizationUtils_StructSize;

	public FJavascriptPropertyTypeCustomizationUtils Copy()
	{
		return this;
	}

	public static FJavascriptPropertyTypeCustomizationUtils FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptPropertyTypeCustomizationUtils(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptPropertyTypeCustomizationUtils value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptPropertyTypeCustomizationUtils FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptPropertyTypeCustomizationUtils(nativeBuffer + arrayIndex * FJavascriptPropertyTypeCustomizationUtils_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptPropertyTypeCustomizationUtils value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptPropertyTypeCustomizationUtils_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptPropertyTypeCustomizationUtils_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptPropertyTypeCustomizationUtils");
		}
	}

	public FJavascriptPropertyTypeCustomizationUtils(IntPtr nativeStruct)
	{
		if (!FJavascriptPropertyTypeCustomizationUtils_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptPropertyTypeCustomizationUtils");
		}
	}

	static FJavascriptPropertyTypeCustomizationUtils()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptPropertyTypeCustomizationUtils)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptPropertyTypeCustomizationUtils));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptPropertyTypeCustomizationUtils");
		FJavascriptPropertyTypeCustomizationUtils_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptPropertyTypeCustomizationUtils_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptPropertyTypeCustomizationUtils", FJavascriptPropertyTypeCustomizationUtils_IsValid);
	}
}
