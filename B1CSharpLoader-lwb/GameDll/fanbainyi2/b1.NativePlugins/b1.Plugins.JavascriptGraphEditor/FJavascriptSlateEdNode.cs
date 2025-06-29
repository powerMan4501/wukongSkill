using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptSlateEdNode", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptSlateEdNode
{
	private static bool FJavascriptSlateEdNode_IsValid;

	private static int FJavascriptSlateEdNode_StructSize;

	public FJavascriptSlateEdNode Copy()
	{
		return this;
	}

	public static FJavascriptSlateEdNode FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptSlateEdNode(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptSlateEdNode value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptSlateEdNode FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptSlateEdNode(nativeBuffer + arrayIndex * FJavascriptSlateEdNode_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptSlateEdNode value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptSlateEdNode_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateEdNode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptSlateEdNode");
		}
	}

	public FJavascriptSlateEdNode(IntPtr nativeStruct)
	{
		if (!FJavascriptSlateEdNode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptSlateEdNode");
		}
	}

	static FJavascriptSlateEdNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptSlateEdNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptSlateEdNode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptSlateEdNode");
		FJavascriptSlateEdNode_StructSize = NativeReflection.GetStructSize(intPtr);
		FJavascriptSlateEdNode_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptSlateEdNode", FJavascriptSlateEdNode_IsValid);
	}
}
