using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptMenuBuilder", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptMenuBuilder
{
	private static bool FJavascriptMenuBuilder_IsValid;

	private static int FJavascriptMenuBuilder_StructSize;

	public FJavascriptMenuBuilder Copy()
	{
		return this;
	}

	public static FJavascriptMenuBuilder FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptMenuBuilder(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptMenuBuilder value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptMenuBuilder FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptMenuBuilder(nativeBuffer + arrayIndex * FJavascriptMenuBuilder_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptMenuBuilder value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptMenuBuilder_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptMenuBuilder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptMenuBuilder");
		}
	}

	public FJavascriptMenuBuilder(IntPtr nativeStruct)
	{
		if (!FJavascriptMenuBuilder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptMenuBuilder");
		}
	}

	static FJavascriptMenuBuilder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptMenuBuilder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptMenuBuilder));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptMenuBuilder");
		FJavascriptMenuBuilder_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptMenuBuilder_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptMenuBuilder", FJavascriptMenuBuilder_IsValid);
	}
}
