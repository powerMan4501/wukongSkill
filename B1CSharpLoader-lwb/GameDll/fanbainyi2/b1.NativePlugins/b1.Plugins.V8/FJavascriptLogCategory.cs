using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptLogCategory", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptLogCategory
{
	private static bool FJavascriptLogCategory_IsValid;

	private static int FJavascriptLogCategory_StructSize;

	public FJavascriptLogCategory Copy()
	{
		return this;
	}

	public static FJavascriptLogCategory FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptLogCategory(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptLogCategory value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptLogCategory FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptLogCategory(nativeBuffer + arrayIndex * FJavascriptLogCategory_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptLogCategory value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptLogCategory_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptLogCategory_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptLogCategory");
		}
	}

	public FJavascriptLogCategory(IntPtr nativeStruct)
	{
		if (!FJavascriptLogCategory_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptLogCategory");
		}
	}

	static FJavascriptLogCategory()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptLogCategory)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptLogCategory));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptLogCategory");
		FJavascriptLogCategory_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptLogCategory_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptLogCategory", FJavascriptLogCategory_IsValid);
	}
}
