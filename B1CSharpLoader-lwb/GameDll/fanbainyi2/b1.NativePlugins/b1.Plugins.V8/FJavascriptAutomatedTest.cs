using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptAutomatedTest", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptAutomatedTest
{
	private static bool FJavascriptAutomatedTest_IsValid;

	private static int FJavascriptAutomatedTest_StructSize;

	public FJavascriptAutomatedTest Copy()
	{
		return this;
	}

	public static FJavascriptAutomatedTest FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptAutomatedTest(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptAutomatedTest value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptAutomatedTest FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptAutomatedTest(nativeBuffer + arrayIndex * FJavascriptAutomatedTest_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptAutomatedTest value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptAutomatedTest_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptAutomatedTest_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptAutomatedTest");
		}
	}

	public FJavascriptAutomatedTest(IntPtr nativeStruct)
	{
		if (!FJavascriptAutomatedTest_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptAutomatedTest");
		}
	}

	static FJavascriptAutomatedTest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptAutomatedTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptAutomatedTest));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptAutomatedTest");
		FJavascriptAutomatedTest_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptAutomatedTest_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptAutomatedTest", FJavascriptAutomatedTest_IsValid);
	}
}
