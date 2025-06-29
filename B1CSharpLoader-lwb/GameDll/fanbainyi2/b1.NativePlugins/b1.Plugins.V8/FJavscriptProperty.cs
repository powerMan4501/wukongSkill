using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavscriptProperty", "V8", UnrealModuleType.GamePlugin)]
public struct FJavscriptProperty
{
	private static bool FJavscriptProperty_IsValid;

	private static int FJavscriptProperty_StructSize;

	public FJavscriptProperty Copy()
	{
		return this;
	}

	public static FJavscriptProperty FromNative(IntPtr nativeBuffer)
	{
		return new FJavscriptProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavscriptProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavscriptProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavscriptProperty(nativeBuffer + arrayIndex * FJavscriptProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavscriptProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavscriptProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavscriptProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavscriptProperty");
		}
	}

	public FJavscriptProperty(IntPtr nativeStruct)
	{
		if (!FJavscriptProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavscriptProperty");
		}
	}

	static FJavscriptProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavscriptProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavscriptProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavscriptProperty");
		FJavscriptProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavscriptProperty_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavscriptProperty", FJavscriptProperty_IsValid);
	}
}
