using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptDetailPropertyRow", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptDetailPropertyRow
{
	private static bool FJavascriptDetailPropertyRow_IsValid;

	private static int FJavascriptDetailPropertyRow_StructSize;

	public FJavascriptDetailPropertyRow Copy()
	{
		return this;
	}

	public static FJavascriptDetailPropertyRow FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptDetailPropertyRow(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptDetailPropertyRow value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptDetailPropertyRow FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptDetailPropertyRow(nativeBuffer + arrayIndex * FJavascriptDetailPropertyRow_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptDetailPropertyRow value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptDetailPropertyRow_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailPropertyRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailPropertyRow");
		}
	}

	public FJavascriptDetailPropertyRow(IntPtr nativeStruct)
	{
		if (!FJavascriptDetailPropertyRow_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptDetailPropertyRow");
		}
	}

	static FJavascriptDetailPropertyRow()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptDetailPropertyRow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptDetailPropertyRow));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptDetailPropertyRow");
		FJavascriptDetailPropertyRow_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptDetailPropertyRow_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptDetailPropertyRow", FJavascriptDetailPropertyRow_IsValid);
	}
}
