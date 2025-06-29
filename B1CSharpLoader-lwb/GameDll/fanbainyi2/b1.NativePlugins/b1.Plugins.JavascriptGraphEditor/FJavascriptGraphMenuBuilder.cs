using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptGraphMenuBuilder
{
	private static bool Graph_IsValid;

	private static int Graph_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder:Graph")]
	public UEdGraph Graph;

	private static bool GraphNode_IsValid;

	private static int GraphNode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder:GraphNode")]
	public UEdGraphNode GraphNode;

	private static bool GraphPin_IsValid;

	private static int GraphPin_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder:GraphPin")]
	public FJavascriptEdGraphPin GraphPin;

	private static bool IsDebugging_IsValid;

	private static FFieldAddress IsDebugging_PropertyAddress;

	private static int IsDebugging_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder:bIsDebugging")]
	public bool IsDebugging;

	private static bool FJavascriptGraphMenuBuilder_IsValid;

	private static int FJavascriptGraphMenuBuilder_StructSize;

	public FJavascriptGraphMenuBuilder Copy()
	{
		return this;
	}

	public static FJavascriptGraphMenuBuilder FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptGraphMenuBuilder(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptGraphMenuBuilder value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptGraphMenuBuilder FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptGraphMenuBuilder(nativeBuffer + arrayIndex * FJavascriptGraphMenuBuilder_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptGraphMenuBuilder value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptGraphMenuBuilder_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptGraphMenuBuilder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder");
			return;
		}
		UObjectMarshaler<UEdGraph>.ToNative(IntPtr.Add(nativeStruct, Graph_Offset), Graph);
		UObjectMarshaler<UEdGraphNode>.ToNative(IntPtr.Add(nativeStruct, GraphNode_Offset), GraphNode);
		FJavascriptEdGraphPin.ToNative(IntPtr.Add(nativeStruct, GraphPin_Offset), GraphPin);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsDebugging_Offset), 0, IsDebugging_PropertyAddress.Address, IsDebugging);
	}

	public FJavascriptGraphMenuBuilder(IntPtr nativeStruct)
	{
		if (!FJavascriptGraphMenuBuilder_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder");
			Graph = null;
			GraphNode = null;
			GraphPin = default(FJavascriptEdGraphPin);
			IsDebugging = false;
		}
		else
		{
			Graph = UObjectMarshaler<UEdGraph>.FromNative(IntPtr.Add(nativeStruct, Graph_Offset));
			GraphNode = UObjectMarshaler<UEdGraphNode>.FromNative(IntPtr.Add(nativeStruct, GraphNode_Offset));
			GraphPin = FJavascriptEdGraphPin.FromNative(IntPtr.Add(nativeStruct, GraphPin_Offset));
			IsDebugging = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsDebugging_Offset), 0, IsDebugging_PropertyAddress.Address);
		}
	}

	static FJavascriptGraphMenuBuilder()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptGraphMenuBuilder)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptGraphMenuBuilder));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder");
		FJavascriptGraphMenuBuilder_StructSize = NativeReflection.GetStructSize(intPtr);
		Graph_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Graph");
		Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Graph", Classes.FObjectProperty);
		GraphNode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GraphNode");
		GraphNode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GraphNode", Classes.FObjectProperty);
		GraphPin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GraphPin");
		GraphPin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GraphPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDebugging_PropertyAddress, intPtr, "bIsDebugging");
		IsDebugging_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsDebugging");
		IsDebugging_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsDebugging", Classes.FBoolProperty);
		FJavascriptGraphMenuBuilder_IsValid = intPtr != IntPtr.Zero && Graph_IsValid && GraphNode_IsValid && GraphPin_IsValid && IsDebugging_IsValid;
		NativeReflection.LogStructIsValid("/Script/JavascriptGraphEditor.JavascriptGraphMenuBuilder", FJavascriptGraphMenuBuilder_IsValid);
	}
}
