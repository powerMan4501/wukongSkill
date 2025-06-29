using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptRef", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptRef
{
	private static bool FJavascriptRef_IsValid;

	private static int FJavascriptRef_StructSize;

	public FJavascriptRef Copy()
	{
		return this;
	}

	public static FJavascriptRef FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptRef(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptRef value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptRef FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptRef(nativeBuffer + arrayIndex * FJavascriptRef_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptRef value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptRef_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptRef_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptRef");
		}
	}

	public FJavascriptRef(IntPtr nativeStruct)
	{
		if (!FJavascriptRef_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptRef");
		}
	}

	static FJavascriptRef()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptRef)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptRef));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptRef");
		FJavascriptRef_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptRef_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptRef", FJavascriptRef_IsValid);
	}
}
