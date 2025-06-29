using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptCpuProfiler", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptCpuProfiler
{
	private static bool FJavascriptCpuProfiler_IsValid;

	private static int FJavascriptCpuProfiler_StructSize;

	public FJavascriptCpuProfiler Copy()
	{
		return this;
	}

	public static FJavascriptCpuProfiler FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptCpuProfiler(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptCpuProfiler value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptCpuProfiler FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptCpuProfiler(nativeBuffer + arrayIndex * FJavascriptCpuProfiler_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptCpuProfiler value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptCpuProfiler_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptCpuProfiler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptCpuProfiler");
		}
	}

	public FJavascriptCpuProfiler(IntPtr nativeStruct)
	{
		if (!FJavascriptCpuProfiler_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptCpuProfiler");
		}
	}

	static FJavascriptCpuProfiler()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptCpuProfiler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptCpuProfiler));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptCpuProfiler");
		FJavascriptCpuProfiler_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptCpuProfiler_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptCpuProfiler", FJavascriptCpuProfiler_IsValid);
	}
}
