using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptDetailWidgetRow", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptDetailWidgetRow
{
	private static bool FJavascriptDetailWidgetRow_IsValid;

	private static int FJavascriptDetailWidgetRow_StructSize;

	public FJavascriptDetailWidgetRow Copy()
	{
		return this;
	}

	public static FJavascriptDetailWidgetRow FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptDetailWidgetRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptDetailWidgetRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptDetailWidgetRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptDetailWidgetRow(nativeBuffer + arrayIndex * FJavascriptDetailWidgetRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptDetailWidgetRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptDetailWidgetRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailWidgetRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailWidgetRow");
		}
	}

	public FJavascriptDetailWidgetRow(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailWidgetRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailWidgetRow");
		}
	}

	static FJavascriptDetailWidgetRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptDetailWidgetRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptDetailWidgetRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptDetailWidgetRow");
		FJavascriptDetailWidgetRow_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptDetailWidgetRow_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptDetailWidgetRow", FJavascriptDetailWidgetRow_IsValid);
	}
}
