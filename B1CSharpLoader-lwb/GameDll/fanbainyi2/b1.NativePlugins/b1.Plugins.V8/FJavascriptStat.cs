using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptStat", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptStat
{
	private static bool FJavascriptStat_IsValid;

	private static int FJavascriptStat_StructSize;

	public FJavascriptStat Copy()
	{
		return this;
	}

	public static FJavascriptStat FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptStat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptStat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptStat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptStat(nativeBuffer + arrayIndex * FJavascriptStat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptStat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptStat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptStat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptStat");
		}
	}

	public FJavascriptStat(IntPtr nativeStruct)
	{
		if (!FJavascriptStat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptStat");
		}
	}

	static FJavascriptStat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptStat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptStat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptStat");
		FJavascriptStat_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptStat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptStat", FJavascriptStat_IsValid);
	}
}
