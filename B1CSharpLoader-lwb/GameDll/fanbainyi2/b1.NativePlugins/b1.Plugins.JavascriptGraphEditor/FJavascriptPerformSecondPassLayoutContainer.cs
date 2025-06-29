using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptPerformSecondPassLayoutContainer", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptPerformSecondPassLayoutContainer
{
	private static bool FJavascriptPerformSecondPassLayoutContainer_IsValid;

	private static int FJavascriptPerformSecondPassLayoutContainer_StructSize;

	public FJavascriptPerformSecondPassLayoutContainer Copy()
	{
		return this;
	}

	public static FJavascriptPerformSecondPassLayoutContainer FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptPerformSecondPassLayoutContainer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptPerformSecondPassLayoutContainer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptPerformSecondPassLayoutContainer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptPerformSecondPassLayoutContainer(nativeBuffer + arrayIndex * FJavascriptPerformSecondPassLayoutContainer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptPerformSecondPassLayoutContainer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptPerformSecondPassLayoutContainer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptPerformSecondPassLayoutContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptPerformSecondPassLayoutContainer");
		}
	}

	public FJavascriptPerformSecondPassLayoutContainer(IntPtr nativeStruct)
	{
		if (!FJavascriptPerformSecondPassLayoutContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptPerformSecondPassLayoutContainer");
		}
	}

	static FJavascriptPerformSecondPassLayoutContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptPerformSecondPassLayoutContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptPerformSecondPassLayoutContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptPerformSecondPassLayoutContainer");
		FJavascriptPerformSecondPassLayoutContainer_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptPerformSecondPassLayoutContainer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptPerformSecondPassLayoutContainer", FJavascriptPerformSecondPassLayoutContainer_IsValid);
	}
}
