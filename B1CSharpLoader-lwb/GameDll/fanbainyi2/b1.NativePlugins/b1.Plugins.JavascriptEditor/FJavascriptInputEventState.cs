using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptInputEventState", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptInputEventState
{
	private static bool FJavascriptInputEventState_IsValid;

	private static int FJavascriptInputEventState_StructSize;

	public FJavascriptInputEventState Copy()
	{
		return this;
	}

	public static FJavascriptInputEventState FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptInputEventState(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptInputEventState value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptInputEventState FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptInputEventState(nativeBuffer + arrayIndex * FJavascriptInputEventState_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptInputEventState value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptInputEventState_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptInputEventState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptInputEventState");
		}
	}

	public FJavascriptInputEventState(IntPtr nativeStruct)
	{
		if (!FJavascriptInputEventState_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptInputEventState");
		}
	}

	static FJavascriptInputEventState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptInputEventState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptInputEventState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptInputEventState");
		FJavascriptInputEventState_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptInputEventState_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptInputEventState", FJavascriptInputEventState_IsValid);
	}
}
