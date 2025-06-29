using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptExtensibilityManager", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptExtensibilityManager
{
	private static bool FJavascriptExtensibilityManager_IsValid;

	private static int FJavascriptExtensibilityManager_StructSize;

	public FJavascriptExtensibilityManager Copy()
	{
		return this;
	}

	public static FJavascriptExtensibilityManager FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptExtensibilityManager(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptExtensibilityManager value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptExtensibilityManager FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptExtensibilityManager(nativeBuffer + arrayIndex * FJavascriptExtensibilityManager_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptExtensibilityManager value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptExtensibilityManager_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptExtensibilityManager_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtensibilityManager");
		}
	}

	public FJavascriptExtensibilityManager(IntPtr nativeStruct)
	{
		if (!FJavascriptExtensibilityManager_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtensibilityManager");
		}
	}

	static FJavascriptExtensibilityManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptExtensibilityManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptExtensibilityManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptExtensibilityManager");
		FJavascriptExtensibilityManager_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptExtensibilityManager_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptExtensibilityManager", FJavascriptExtensibilityManager_IsValid);
	}
}
