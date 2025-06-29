using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorMode", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptEditorMode
{
	private static bool FJavascriptEditorMode_IsValid;

	private static int FJavascriptEditorMode_StructSize;

	public FJavascriptEditorMode Copy()
	{
		return this;
	}

	public static FJavascriptEditorMode FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptEditorMode(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptEditorMode value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptEditorMode FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptEditorMode(nativeBuffer + arrayIndex * FJavascriptEditorMode_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptEditorMode value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptEditorMode_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptEditorMode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptEditorMode");
		}
	}

	public FJavascriptEditorMode(IntPtr nativeStruct)
	{
		if (!FJavascriptEditorMode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptEditorMode");
		}
	}

	static FJavascriptEditorMode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptEditorMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptEditorMode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptEditorMode");
		FJavascriptEditorMode_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptEditorMode_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptEditorMode", FJavascriptEditorMode_IsValid);
	}
}
