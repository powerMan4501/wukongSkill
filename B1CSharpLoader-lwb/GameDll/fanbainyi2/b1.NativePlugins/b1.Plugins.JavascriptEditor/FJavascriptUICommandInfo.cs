using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptUICommandInfo", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptUICommandInfo
{
	private static bool FJavascriptUICommandInfo_IsValid;

	private static int FJavascriptUICommandInfo_StructSize;

	public FJavascriptUICommandInfo Copy()
	{
		return this;
	}

	public static FJavascriptUICommandInfo FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptUICommandInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptUICommandInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptUICommandInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptUICommandInfo(nativeBuffer + arrayIndex * FJavascriptUICommandInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptUICommandInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptUICommandInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptUICommandInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptUICommandInfo");
		}
	}

	public FJavascriptUICommandInfo(IntPtr nativeStruct)
	{
		if (!FJavascriptUICommandInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptUICommandInfo");
		}
	}

	static FJavascriptUICommandInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptUICommandInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptUICommandInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptUICommandInfo");
		FJavascriptUICommandInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptUICommandInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptUICommandInfo", FJavascriptUICommandInfo_IsValid);
	}
}
