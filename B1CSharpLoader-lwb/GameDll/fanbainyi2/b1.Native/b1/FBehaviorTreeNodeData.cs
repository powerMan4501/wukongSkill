using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.BehaviorTreeNodeData", "UnrealExtent", UnrealModuleType.Game)]
public struct FBehaviorTreeNodeData
{
	private static bool TaskNodeList_IsValid;

	private static FFieldAddress TaskNodeList_PropertyAddress;

	private static int TaskNodeList_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/UnrealExtent.BehaviorTreeNodeData:TaskNodeList")]
	public List<UBTTaskNode> TaskNodeList;

	private static bool FBehaviorTreeNodeData_IsValid;

	private static int FBehaviorTreeNodeData_StructSize;

	public FBehaviorTreeNodeData Copy()
	{
		FBehaviorTreeNodeData result = this;
		if (TaskNodeList != null)
		{
			result.TaskNodeList = new List<UBTTaskNode>(TaskNodeList);
		}
		return result;
	}

	public static FBehaviorTreeNodeData FromNative(IntPtr nativeBuffer)
	{
		return new FBehaviorTreeNodeData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBehaviorTreeNodeData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBehaviorTreeNodeData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBehaviorTreeNodeData(nativeBuffer + arrayIndex * FBehaviorTreeNodeData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBehaviorTreeNodeData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBehaviorTreeNodeData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBehaviorTreeNodeData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.BehaviorTreeNodeData");
		}
		else
		{
			new TArrayCopyMarshaler<UBTTaskNode>(1, TaskNodeList_PropertyAddress, CachedMarshalingDelegates<UBTTaskNode, UObjectMarshaler<UBTTaskNode>>.FromNative, CachedMarshalingDelegates<UBTTaskNode, UObjectMarshaler<UBTTaskNode>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TaskNodeList_Offset), TaskNodeList);
		}
	}

	public FBehaviorTreeNodeData(IntPtr nativeStruct)
	{
		if (!FBehaviorTreeNodeData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.BehaviorTreeNodeData");
			TaskNodeList = null;
		}
		else
		{
			TaskNodeList = new TArrayCopyMarshaler<UBTTaskNode>(1, TaskNodeList_PropertyAddress, CachedMarshalingDelegates<UBTTaskNode, UObjectMarshaler<UBTTaskNode>>.FromNative, CachedMarshalingDelegates<UBTTaskNode, UObjectMarshaler<UBTTaskNode>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TaskNodeList_Offset));
		}
	}

	static FBehaviorTreeNodeData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBehaviorTreeNodeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBehaviorTreeNodeData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.BehaviorTreeNodeData");
		FBehaviorTreeNodeData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TaskNodeList_PropertyAddress, intPtr, "TaskNodeList");
		TaskNodeList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaskNodeList");
		TaskNodeList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaskNodeList", Classes.FArrayProperty);
		FBehaviorTreeNodeData_IsValid = intPtr != IntPtr.Zero && TaskNodeList_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.BehaviorTreeNodeData", FBehaviorTreeNodeData_IsValid);
	}
}
