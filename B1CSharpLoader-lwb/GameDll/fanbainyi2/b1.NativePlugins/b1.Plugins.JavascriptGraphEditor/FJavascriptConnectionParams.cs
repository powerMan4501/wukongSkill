using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptConnectionParams", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptConnectionParams
{
	private static bool FJavascriptConnectionParams_IsValid;

	private static int FJavascriptConnectionParams_StructSize;

	public FJavascriptConnectionParams Copy()
	{
		return this;
	}

	public static FJavascriptConnectionParams FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptConnectionParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptConnectionParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptConnectionParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptConnectionParams(nativeBuffer + arrayIndex * FJavascriptConnectionParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptConnectionParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptConnectionParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptConnectionParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptConnectionParams");
		}
	}

	public FJavascriptConnectionParams(IntPtr nativeStruct)
	{
		if (!FJavascriptConnectionParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptConnectionParams");
		}
	}

	static FJavascriptConnectionParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptConnectionParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptConnectionParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptConnectionParams");
		FJavascriptConnectionParams_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptConnectionParams_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptConnectionParams", FJavascriptConnectionParams_IsValid);
	}
}
