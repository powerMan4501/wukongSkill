using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptNodeCreator", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptNodeCreator
{
	private static bool Node_IsValid;

	private static int Node_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptNodeCreator:Node")]
	public UJavascriptGraphEdNode Node;

	private static bool FJavascriptNodeCreator_IsValid;

	private static int FJavascriptNodeCreator_StructSize;

	public FJavascriptNodeCreator Copy()
	{
		return this;
	}

	public static FJavascriptNodeCreator FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptNodeCreator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptNodeCreator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptNodeCreator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptNodeCreator(nativeBuffer + arrayIndex * FJavascriptNodeCreator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptNodeCreator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptNodeCreator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptNodeCreator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptNodeCreator");
		}
		else
		{
			UObjectMarshaler<UJavascriptGraphEdNode>.ToNative(IntPtr.Add(nativeStruct, Node_Offset), Node);
		}
	}

	public FJavascriptNodeCreator(IntPtr nativeStruct)
	{
		if (!FJavascriptNodeCreator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptNodeCreator");
			Node = null;
		}
		else
		{
			Node = UObjectMarshaler<UJavascriptGraphEdNode>.FromNative(IntPtr.Add(nativeStruct, Node_Offset));
		}
	}

	static FJavascriptNodeCreator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptNodeCreator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptNodeCreator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptNodeCreator");
		FJavascriptNodeCreator_StructSize = NativeReflection.GetStructSize(intPtr);
		Node_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Node");
		Node_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Node", Classes.FObjectProperty);
		FJavascriptNodeCreator_IsValid = intPtr != IntPtr.Zero && Node_IsValid;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptNodeCreator", FJavascriptNodeCreator_IsValid);
	}
}
