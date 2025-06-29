using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptEdGraphPin", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptEdGraphPin
{
	private static bool FJavascriptEdGraphPin_IsValid;

	private static int FJavascriptEdGraphPin_StructSize;

	public FJavascriptEdGraphPin Copy()
	{
		return this;
	}

	public static FJavascriptEdGraphPin FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptEdGraphPin(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptEdGraphPin value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptEdGraphPin FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptEdGraphPin(nativeBuffer + arrayIndex * FJavascriptEdGraphPin_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptEdGraphPin value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptEdGraphPin_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptEdGraphPin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptEdGraphPin");
		}
	}

	public FJavascriptEdGraphPin(IntPtr nativeStruct)
	{
		if (!FJavascriptEdGraphPin_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptEdGraphPin");
		}
	}

	static FJavascriptEdGraphPin()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptEdGraphPin)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptEdGraphPin));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptEdGraphPin");
		FJavascriptEdGraphPin_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptEdGraphPin_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptEdGraphPin", FJavascriptEdGraphPin_IsValid);
	}
}
