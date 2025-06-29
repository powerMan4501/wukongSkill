using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorModeTools", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptEditorModeTools
{
	private static bool FJavascriptEditorModeTools_IsValid;

	private static int FJavascriptEditorModeTools_StructSize;

	public FJavascriptEditorModeTools Copy()
	{
		return this;
	}

	public static FJavascriptEditorModeTools FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptEditorModeTools(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptEditorModeTools value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptEditorModeTools FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptEditorModeTools(nativeBuffer + arrayIndex * FJavascriptEditorModeTools_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptEditorModeTools value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptEditorModeTools_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptEditorModeTools_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptEditorModeTools");
		}
	}

	public FJavascriptEditorModeTools(IntPtr nativeStruct)
	{
		if (!FJavascriptEditorModeTools_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptEditorModeTools");
		}
	}

	static FJavascriptEditorModeTools()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptEditorModeTools)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptEditorModeTools));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptEditorModeTools");
		FJavascriptEditorModeTools_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptEditorModeTools_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptEditorModeTools", FJavascriptEditorModeTools_IsValid);
	}
}
