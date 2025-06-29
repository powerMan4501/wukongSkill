using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptAutomatedTestParameters", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptAutomatedTestParameters
{
	private static bool FJavascriptAutomatedTestParameters_IsValid;

	private static int FJavascriptAutomatedTestParameters_StructSize;

	public FJavascriptAutomatedTestParameters Copy()
	{
		return this;
	}

	public static FJavascriptAutomatedTestParameters FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptAutomatedTestParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptAutomatedTestParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptAutomatedTestParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptAutomatedTestParameters(nativeBuffer + arrayIndex * FJavascriptAutomatedTestParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptAutomatedTestParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptAutomatedTestParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptAutomatedTestParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptAutomatedTestParameters");
		}
	}

	public FJavascriptAutomatedTestParameters(IntPtr nativeStruct)
	{
		if (!FJavascriptAutomatedTestParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptAutomatedTestParameters");
		}
	}

	static FJavascriptAutomatedTestParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptAutomatedTestParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptAutomatedTestParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptAutomatedTestParameters");
		FJavascriptAutomatedTestParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptAutomatedTestParameters_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptAutomatedTestParameters", FJavascriptAutomatedTestParameters_IsValid);
	}
}
