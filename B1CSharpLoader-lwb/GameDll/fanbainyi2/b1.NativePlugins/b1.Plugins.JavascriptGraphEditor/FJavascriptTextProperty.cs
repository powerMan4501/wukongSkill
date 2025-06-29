using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptTextProperty", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptTextProperty
{
	private static bool FJavascriptTextProperty_IsValid;

	private static int FJavascriptTextProperty_StructSize;

	public FJavascriptTextProperty Copy()
	{
		return this;
	}

	public static FJavascriptTextProperty FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptTextProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptTextProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptTextProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptTextProperty(nativeBuffer + arrayIndex * FJavascriptTextProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptTextProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptTextProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptTextProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptTextProperty");
		}
	}

	public FJavascriptTextProperty(IntPtr nativeStruct)
	{
		if (!FJavascriptTextProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptTextProperty");
		}
	}

	static FJavascriptTextProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptTextProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptTextProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptTextProperty");
		FJavascriptTextProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptTextProperty_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptTextProperty", FJavascriptTextProperty_IsValid);
	}
}
