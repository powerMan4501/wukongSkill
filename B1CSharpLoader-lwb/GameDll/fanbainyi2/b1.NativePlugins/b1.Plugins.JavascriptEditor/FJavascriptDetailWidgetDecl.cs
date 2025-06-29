using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptDetailWidgetDecl", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptDetailWidgetDecl
{
	private static bool FJavascriptDetailWidgetDecl_IsValid;

	private static int FJavascriptDetailWidgetDecl_StructSize;

	public FJavascriptDetailWidgetDecl Copy()
	{
		return this;
	}

	public static FJavascriptDetailWidgetDecl FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptDetailWidgetDecl(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptDetailWidgetDecl value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptDetailWidgetDecl FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptDetailWidgetDecl(nativeBuffer + arrayIndex * FJavascriptDetailWidgetDecl_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptDetailWidgetDecl value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptDetailWidgetDecl_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailWidgetDecl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailWidgetDecl");
		}
	}

	public FJavascriptDetailWidgetDecl(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailWidgetDecl_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailWidgetDecl");
		}
	}

	static FJavascriptDetailWidgetDecl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptDetailWidgetDecl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptDetailWidgetDecl));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptDetailWidgetDecl");
		FJavascriptDetailWidgetDecl_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptDetailWidgetDecl_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptDetailWidgetDecl", FJavascriptDetailWidgetDecl_IsValid);
	}
}
