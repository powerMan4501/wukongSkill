using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptAutomatedTestInstance", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptAutomatedTestInstance
{
	private static bool FJavascriptAutomatedTestInstance_IsValid;

	private static int FJavascriptAutomatedTestInstance_StructSize;

	public FJavascriptAutomatedTestInstance Copy()
	{
		return this;
	}

	public static FJavascriptAutomatedTestInstance FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptAutomatedTestInstance(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptAutomatedTestInstance value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptAutomatedTestInstance FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptAutomatedTestInstance(nativeBuffer + arrayIndex * FJavascriptAutomatedTestInstance_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptAutomatedTestInstance value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptAutomatedTestInstance_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptAutomatedTestInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptAutomatedTestInstance");
		}
	}

	public FJavascriptAutomatedTestInstance(IntPtr nativeStruct)
	{
		if (!FJavascriptAutomatedTestInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptAutomatedTestInstance");
		}
	}

	static FJavascriptAutomatedTestInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptAutomatedTestInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptAutomatedTestInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptAutomatedTestInstance");
		FJavascriptAutomatedTestInstance_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptAutomatedTestInstance_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptAutomatedTestInstance", FJavascriptAutomatedTestInstance_IsValid);
	}
}
