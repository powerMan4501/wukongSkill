using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptExtender", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptExtender
{
	private static bool FJavascriptExtender_IsValid;

	private static int FJavascriptExtender_StructSize;

	public FJavascriptExtender Copy()
	{
		return this;
	}

	public static FJavascriptExtender FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptExtender(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptExtender value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptExtender FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptExtender(nativeBuffer + arrayIndex * FJavascriptExtender_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptExtender value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptExtender_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptExtender_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtender");
		}
	}

	public FJavascriptExtender(IntPtr nativeStruct)
	{
		if (!FJavascriptExtender_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptExtender");
		}
	}

	static FJavascriptExtender()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptExtender)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptExtender));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptExtender");
		FJavascriptExtender_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptExtender_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptExtender", FJavascriptExtender_IsValid);
	}
}
