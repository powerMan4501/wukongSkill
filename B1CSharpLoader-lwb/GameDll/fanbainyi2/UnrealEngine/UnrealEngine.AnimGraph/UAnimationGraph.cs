using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AnimGraph.AnimationGraph", "AnimGraph", UnrealModuleType.Engine)]
public class UAnimationGraph : UEdGraph
{
	private static bool GetGraphNodesOfClass_IsValid;

	private static IntPtr GetGraphNodesOfClass_FunctionAddress;

	private static int GetGraphNodesOfClass_ParamsSize;

	private static bool GetGraphNodesOfClass_NodeClass_IsValid;

	private static FFieldAddress GetGraphNodesOfClass_NodeClass_PropertyAddress;

	private static int GetGraphNodesOfClass_NodeClass_Offset;

	private static bool GetGraphNodesOfClass_GraphNodes_IsValid;

	private static FFieldAddress GetGraphNodesOfClass_GraphNodes_PropertyAddress;

	private static int GetGraphNodesOfClass_GraphNodes_Offset;

	private static bool GetGraphNodesOfClass_bIncludeChildClasses_IsValid;

	private static FFieldAddress GetGraphNodesOfClass_bIncludeChildClasses_PropertyAddress;

	private static int GetGraphNodesOfClass_bIncludeChildClasses_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AnimGraph.AnimationGraph:GetGraphNodesOfClass")]
	public unsafe void GetGraphNodesOfClass(TSubclassOf<UAnimGraphNode_Base> NodeClass, out List<UAnimGraphNode_Base> GraphNodes, bool bIncludeChildClasses = true)
	{
		CheckDestroyed();
		if (!GetGraphNodesOfClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimationGraph:GetGraphNodesOfClass");
			GraphNodes = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraphNodesOfClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraphNodesOfClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UAnimGraphNode_Base>.ToNative(IntPtr.Add(intPtr, GetGraphNodesOfClass_NodeClass_Offset), 0, GetGraphNodesOfClass_NodeClass_PropertyAddress.Address, NodeClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetGraphNodesOfClass_bIncludeChildClasses_Offset), 0, GetGraphNodesOfClass_bIncludeChildClasses_PropertyAddress.Address, bIncludeChildClasses);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraphNodesOfClass_FunctionAddress, intPtr, GetGraphNodesOfClass_ParamsSize);
		GraphNodes = new TArrayCopyMarshaler<UAnimGraphNode_Base>(1, GetGraphNodesOfClass_GraphNodes_PropertyAddress, CachedMarshalingDelegates<UAnimGraphNode_Base, UObjectMarshaler<UAnimGraphNode_Base>>.FromNative, CachedMarshalingDelegates<UAnimGraphNode_Base, UObjectMarshaler<UAnimGraphNode_Base>>.ToNative).FromNative(IntPtr.Add(intPtr, GetGraphNodesOfClass_GraphNodes_Offset));
		NativeReflection.DestroyValue_InContainer(GetGraphNodesOfClass_GraphNodes_PropertyAddress.Address, intPtr);
	}

	static UAnimationGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AnimGraph.AnimationGraph");
		GetGraphNodesOfClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGraphNodesOfClass");
		GetGraphNodesOfClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraphNodesOfClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraphNodesOfClass_NodeClass_PropertyAddress, GetGraphNodesOfClass_FunctionAddress, "NodeClass");
		GetGraphNodesOfClass_NodeClass_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphNodesOfClass_FunctionAddress, "NodeClass");
		GetGraphNodesOfClass_NodeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphNodesOfClass_FunctionAddress, "NodeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGraphNodesOfClass_GraphNodes_PropertyAddress, GetGraphNodesOfClass_FunctionAddress, "GraphNodes");
		GetGraphNodesOfClass_GraphNodes_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphNodesOfClass_FunctionAddress, "GraphNodes");
		GetGraphNodesOfClass_GraphNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphNodesOfClass_FunctionAddress, "GraphNodes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGraphNodesOfClass_bIncludeChildClasses_PropertyAddress, GetGraphNodesOfClass_FunctionAddress, "bIncludeChildClasses");
		GetGraphNodesOfClass_bIncludeChildClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphNodesOfClass_FunctionAddress, "bIncludeChildClasses");
		GetGraphNodesOfClass_bIncludeChildClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphNodesOfClass_FunctionAddress, "bIncludeChildClasses", Classes.FBoolProperty);
		GetGraphNodesOfClass_IsValid = GetGraphNodesOfClass_FunctionAddress != IntPtr.Zero && GetGraphNodesOfClass_NodeClass_IsValid && GetGraphNodesOfClass_GraphNodes_IsValid && GetGraphNodesOfClass_bIncludeChildClasses_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimationGraph:GetGraphNodesOfClass", GetGraphNodesOfClass_IsValid);
	}
}
