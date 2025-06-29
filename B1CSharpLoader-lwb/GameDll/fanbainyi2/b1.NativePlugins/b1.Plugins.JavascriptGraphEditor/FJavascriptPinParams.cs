using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptPinParams", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptPinParams
{
	private static bool FJavascriptPinParams_IsValid;

	private static int FJavascriptPinParams_StructSize;

	public FJavascriptPinParams Copy()
	{
		return this;
	}

	public static FJavascriptPinParams FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptPinParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptPinParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptPinParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptPinParams(nativeBuffer + arrayIndex * FJavascriptPinParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptPinParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptPinParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptPinParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptPinParams");
		}
	}

	public FJavascriptPinParams(IntPtr nativeStruct)
	{
		if (!FJavascriptPinParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptPinParams");
		}
	}

	static FJavascriptPinParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptPinParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptPinParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptPinParams");
		FJavascriptPinParams_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptPinParams_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptPinParams", FJavascriptPinParams_IsValid);
	}
}
