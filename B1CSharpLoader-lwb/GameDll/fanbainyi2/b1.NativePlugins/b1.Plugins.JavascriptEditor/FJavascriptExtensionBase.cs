using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptExtensionBase", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptExtensionBase
{
	private static bool FJavascriptExtensionBase_IsValid;

	private static int FJavascriptExtensionBase_StructSize;

	public FJavascriptExtensionBase Copy()
	{
		return this;
	}

	public static FJavascriptExtensionBase FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptExtensionBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptExtensionBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptExtensionBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptExtensionBase(nativeBuffer + arrayIndex * FJavascriptExtensionBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptExtensionBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptExtensionBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptExtensionBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtensionBase");
		}
	}

	public FJavascriptExtensionBase(IntPtr nativeStruct)
	{
		if (!FJavascriptExtensionBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtensionBase");
		}
	}

	static FJavascriptExtensionBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptExtensionBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptExtensionBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptExtensionBase");
		FJavascriptExtensionBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptExtensionBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptExtensionBase", FJavascriptExtensionBase_IsValid);
	}
}
