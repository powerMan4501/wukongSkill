using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptUICommandList", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptUICommandList
{
	private static bool FJavascriptUICommandList_IsValid;

	private static int FJavascriptUICommandList_StructSize;

	public FJavascriptUICommandList Copy()
	{
		return this;
	}

	public static FJavascriptUICommandList FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptUICommandList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptUICommandList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptUICommandList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptUICommandList(nativeBuffer + arrayIndex * FJavascriptUICommandList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptUICommandList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptUICommandList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptUICommandList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptUICommandList");
		}
	}

	public FJavascriptUICommandList(IntPtr nativeStruct)
	{
		if (!FJavascriptUICommandList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptUICommandList");
		}
	}

	static FJavascriptUICommandList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptUICommandList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptUICommandList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptUICommandList");
		FJavascriptUICommandList_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptUICommandList_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptUICommandList", FJavascriptUICommandList_IsValid);
	}
}
