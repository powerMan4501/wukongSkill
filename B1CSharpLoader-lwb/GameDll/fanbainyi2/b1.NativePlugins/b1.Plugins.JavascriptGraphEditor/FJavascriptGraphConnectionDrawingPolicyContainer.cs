using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphConnectionDrawingPolicyContainer", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptGraphConnectionDrawingPolicyContainer
{
	private static bool FJavascriptGraphConnectionDrawingPolicyContainer_IsValid;

	private static int FJavascriptGraphConnectionDrawingPolicyContainer_StructSize;

	public FJavascriptGraphConnectionDrawingPolicyContainer Copy()
	{
		return this;
	}

	public static FJavascriptGraphConnectionDrawingPolicyContainer FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptGraphConnectionDrawingPolicyContainer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptGraphConnectionDrawingPolicyContainer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptGraphConnectionDrawingPolicyContainer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptGraphConnectionDrawingPolicyContainer(nativeBuffer + arrayIndex * FJavascriptGraphConnectionDrawingPolicyContainer_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptGraphConnectionDrawingPolicyContainer value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptGraphConnectionDrawingPolicyContainer_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptGraphConnectionDrawingPolicyContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptGraphConnectionDrawingPolicyContainer");
		}
	}

	public FJavascriptGraphConnectionDrawingPolicyContainer(IntPtr nativeStruct)
	{
		if (!FJavascriptGraphConnectionDrawingPolicyContainer_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptGraphConnectionDrawingPolicyContainer");
		}
	}

	static FJavascriptGraphConnectionDrawingPolicyContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptGraphConnectionDrawingPolicyContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptGraphConnectionDrawingPolicyContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptGraphConnectionDrawingPolicyContainer");
		FJavascriptGraphConnectionDrawingPolicyContainer_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptGraphConnectionDrawingPolicyContainer_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptGraphConnectionDrawingPolicyContainer", FJavascriptGraphConnectionDrawingPolicyContainer_IsValid);
	}
}
