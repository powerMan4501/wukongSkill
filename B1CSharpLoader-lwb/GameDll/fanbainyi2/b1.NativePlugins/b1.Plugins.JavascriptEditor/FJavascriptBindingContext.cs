using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptBindingContext", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptBindingContext
{
	private static bool FJavascriptBindingContext_IsValid;

	private static int FJavascriptBindingContext_StructSize;

	public FJavascriptBindingContext Copy()
	{
		return this;
	}

	public static FJavascriptBindingContext FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptBindingContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptBindingContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptBindingContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptBindingContext(nativeBuffer + arrayIndex * FJavascriptBindingContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptBindingContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptBindingContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptBindingContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptBindingContext");
		}
	}

	public FJavascriptBindingContext(IntPtr nativeStruct)
	{
		if (!FJavascriptBindingContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptBindingContext");
		}
	}

	static FJavascriptBindingContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptBindingContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptBindingContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptBindingContext");
		FJavascriptBindingContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptBindingContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptBindingContext", FJavascriptBindingContext_IsValid);
	}
}
