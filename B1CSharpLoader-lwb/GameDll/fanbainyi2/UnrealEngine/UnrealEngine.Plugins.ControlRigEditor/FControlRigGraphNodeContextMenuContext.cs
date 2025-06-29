using System;
using UnrealEngine.RigVMDeveloper;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext", "ControlRigEditor", UnrealModuleType.EnginePlugin)]
public struct FControlRigGraphNodeContextMenuContext
{
	private static bool Graph_IsValid;

	private static int Graph_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext:Graph")]
	public URigVMGraph Graph;

	private static bool Node_IsValid;

	private static int Node_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext:Node")]
	public URigVMNode Node;

	private static bool Pin_IsValid;

	private static int Pin_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext:Pin")]
	public URigVMPin Pin;

	private static bool FControlRigGraphNodeContextMenuContext_IsValid;

	private static int FControlRigGraphNodeContextMenuContext_StructSize;

	public FControlRigGraphNodeContextMenuContext Copy()
	{
		return this;
	}

	public static FControlRigGraphNodeContextMenuContext FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigGraphNodeContextMenuContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigGraphNodeContextMenuContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigGraphNodeContextMenuContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigGraphNodeContextMenuContext(nativeBuffer + arrayIndex * FControlRigGraphNodeContextMenuContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigGraphNodeContextMenuContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigGraphNodeContextMenuContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigGraphNodeContextMenuContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext");
			return;
		}
		UObjectMarshaler<URigVMGraph>.ToNative(IntPtr.Add(nativeStruct, Graph_Offset), Graph);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(nativeStruct, Node_Offset), Node);
		UObjectMarshaler<URigVMPin>.ToNative(IntPtr.Add(nativeStruct, Pin_Offset), Pin);
	}

	public FControlRigGraphNodeContextMenuContext(IntPtr nativeStruct)
	{
		if (!FControlRigGraphNodeContextMenuContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext");
			Graph = null;
			Node = null;
			Pin = null;
		}
		else
		{
			Graph = UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(nativeStruct, Graph_Offset));
			Node = UObjectMarshaler<URigVMNode>.FromNative(IntPtr.Add(nativeStruct, Node_Offset));
			Pin = UObjectMarshaler<URigVMPin>.FromNative(IntPtr.Add(nativeStruct, Pin_Offset));
		}
	}

	static FControlRigGraphNodeContextMenuContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigGraphNodeContextMenuContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigGraphNodeContextMenuContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext");
		FControlRigGraphNodeContextMenuContext_StructSize = NativeReflection.GetStructSize(intPtr);
		Graph_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Graph");
		Graph_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Graph", Classes.FObjectProperty);
		Node_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Node");
		Node_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Node", Classes.FObjectProperty);
		Pin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pin");
		Pin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pin", Classes.FObjectProperty);
		FControlRigGraphNodeContextMenuContext_IsValid = intPtr != IntPtr.Zero && Graph_IsValid && Node_IsValid && Pin_IsValid;
		NativeReflection.LogStructIsValid("/Script/ControlRigEditor.ControlRigGraphNodeContextMenuContext", FControlRigGraphNodeContextMenuContext_IsValid);
	}
}
