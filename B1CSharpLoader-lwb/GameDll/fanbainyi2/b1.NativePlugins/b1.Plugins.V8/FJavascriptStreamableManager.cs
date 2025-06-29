using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptStreamableManager", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptStreamableManager
{
	private static bool FJavascriptStreamableManager_IsValid;

	private static int FJavascriptStreamableManager_StructSize;

	public FJavascriptStreamableManager Copy()
	{
		return this;
	}

	public static FJavascriptStreamableManager FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptStreamableManager(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptStreamableManager value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptStreamableManager FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptStreamableManager(nativeBuffer + arrayIndex * FJavascriptStreamableManager_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptStreamableManager value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptStreamableManager_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptStreamableManager_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptStreamableManager");
		}
	}

	public FJavascriptStreamableManager(IntPtr nativeStruct)
	{
		if (!FJavascriptStreamableManager_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptStreamableManager");
		}
	}

	static FJavascriptStreamableManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptStreamableManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptStreamableManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptStreamableManager");
		FJavascriptStreamableManager_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptStreamableManager_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptStreamableManager", FJavascriptStreamableManager_IsValid);
	}
}
