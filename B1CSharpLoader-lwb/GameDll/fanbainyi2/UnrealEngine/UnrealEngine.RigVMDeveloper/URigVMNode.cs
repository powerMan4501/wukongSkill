using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.RigVM;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMNode", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMNode : UObject
{
	private static bool SetHasBreakpoint_IsValid;

	private static IntPtr SetHasBreakpoint_FunctionAddress;

	private static int SetHasBreakpoint_ParamsSize;

	private static bool SetHasBreakpoint_bValue_IsValid;

	private static FFieldAddress SetHasBreakpoint_bValue_PropertyAddress;

	private static int SetHasBreakpoint_bValue_Offset;

	private static bool SetExecutionIsHaltedAtThisNode_IsValid;

	private static IntPtr SetExecutionIsHaltedAtThisNode_FunctionAddress;

	private static int SetExecutionIsHaltedAtThisNode_ParamsSize;

	private static bool SetExecutionIsHaltedAtThisNode_bValue_IsValid;

	private static FFieldAddress SetExecutionIsHaltedAtThisNode_bValue_PropertyAddress;

	private static int SetExecutionIsHaltedAtThisNode_bValue_Offset;

	private static bool IsVisibleInUI_IsValid;

	private static IntPtr IsVisibleInUI_FunctionAddress;

	private static int IsVisibleInUI_ParamsSize;

	private static bool IsVisibleInUI_ReturnValue_IsValid;

	private static FFieldAddress IsVisibleInUI_ReturnValue_PropertyAddress;

	private static int IsVisibleInUI_ReturnValue_Offset;

	private static bool IsSelected_IsValid;

	private static IntPtr IsSelected_FunctionAddress;

	private static int IsSelected_ParamsSize;

	private static bool IsSelected_ReturnValue_IsValid;

	private static FFieldAddress IsSelected_ReturnValue_PropertyAddress;

	private static int IsSelected_ReturnValue_Offset;

	private static bool IsPure_IsValid;

	private static IntPtr IsPure_FunctionAddress;

	private static int IsPure_ParamsSize;

	private static bool IsPure_ReturnValue_IsValid;

	private static FFieldAddress IsPure_ReturnValue_PropertyAddress;

	private static int IsPure_ReturnValue_Offset;

	private static bool IsMutable_IsValid;

	private static IntPtr IsMutable_FunctionAddress;

	private static int IsMutable_ParamsSize;

	private static bool IsMutable_ReturnValue_IsValid;

	private static FFieldAddress IsMutable_ReturnValue_PropertyAddress;

	private static int IsMutable_ReturnValue_Offset;

	private static bool IsLinkedTo_IsValid;

	private static IntPtr IsLinkedTo_FunctionAddress;

	private static int IsLinkedTo_ParamsSize;

	private static bool IsLinkedTo_InNode_IsValid;

	private static FFieldAddress IsLinkedTo_InNode_PropertyAddress;

	private static int IsLinkedTo_InNode_Offset;

	private static bool IsLinkedTo_ReturnValue_IsValid;

	private static FFieldAddress IsLinkedTo_ReturnValue_PropertyAddress;

	private static int IsLinkedTo_ReturnValue_Offset;

	private static bool IsInjected_IsValid;

	private static IntPtr IsInjected_FunctionAddress;

	private static int IsInjected_ParamsSize;

	private static bool IsInjected_ReturnValue_IsValid;

	private static FFieldAddress IsInjected_ReturnValue_PropertyAddress;

	private static int IsInjected_ReturnValue_Offset;

	private static bool IsEvent_IsValid;

	private static IntPtr IsEvent_FunctionAddress;

	private static int IsEvent_ParamsSize;

	private static bool IsEvent_ReturnValue_IsValid;

	private static FFieldAddress IsEvent_ReturnValue_PropertyAddress;

	private static int IsEvent_ReturnValue_Offset;

	private static bool IsDefinedAsVarying_IsValid;

	private static IntPtr IsDefinedAsVarying_FunctionAddress;

	private static int IsDefinedAsVarying_ParamsSize;

	private static bool IsDefinedAsVarying_ReturnValue_IsValid;

	private static FFieldAddress IsDefinedAsVarying_ReturnValue_PropertyAddress;

	private static int IsDefinedAsVarying_ReturnValue_Offset;

	private static bool IsDefinedAsConstant_IsValid;

	private static IntPtr IsDefinedAsConstant_FunctionAddress;

	private static int IsDefinedAsConstant_ParamsSize;

	private static bool IsDefinedAsConstant_ReturnValue_IsValid;

	private static FFieldAddress IsDefinedAsConstant_ReturnValue_PropertyAddress;

	private static int IsDefinedAsConstant_ReturnValue_Offset;

	private static bool HasPinOfDirection_IsValid;

	private static IntPtr HasPinOfDirection_FunctionAddress;

	private static int HasPinOfDirection_ParamsSize;

	private static bool HasPinOfDirection_InDirection_IsValid;

	private static FFieldAddress HasPinOfDirection_InDirection_PropertyAddress;

	private static int HasPinOfDirection_InDirection_Offset;

	private static bool HasPinOfDirection_ReturnValue_IsValid;

	private static FFieldAddress HasPinOfDirection_ReturnValue_PropertyAddress;

	private static int HasPinOfDirection_ReturnValue_Offset;

	private static bool HasOutputPin_IsValid;

	private static IntPtr HasOutputPin_FunctionAddress;

	private static int HasOutputPin_ParamsSize;

	private static bool HasOutputPin_bIncludeIO_IsValid;

	private static FFieldAddress HasOutputPin_bIncludeIO_PropertyAddress;

	private static int HasOutputPin_bIncludeIO_Offset;

	private static bool HasOutputPin_ReturnValue_IsValid;

	private static FFieldAddress HasOutputPin_ReturnValue_PropertyAddress;

	private static int HasOutputPin_ReturnValue_Offset;

	private static bool HasOrphanedPins_IsValid;

	private static IntPtr HasOrphanedPins_FunctionAddress;

	private static int HasOrphanedPins_ParamsSize;

	private static bool HasOrphanedPins_ReturnValue_IsValid;

	private static FFieldAddress HasOrphanedPins_ReturnValue_PropertyAddress;

	private static int HasOrphanedPins_ReturnValue_Offset;

	private static bool HasIOPin_IsValid;

	private static IntPtr HasIOPin_FunctionAddress;

	private static int HasIOPin_ParamsSize;

	private static bool HasIOPin_ReturnValue_IsValid;

	private static FFieldAddress HasIOPin_ReturnValue_PropertyAddress;

	private static int HasIOPin_ReturnValue_Offset;

	private static bool HasInputPin_IsValid;

	private static IntPtr HasInputPin_FunctionAddress;

	private static int HasInputPin_ParamsSize;

	private static bool HasInputPin_bIncludeIO_IsValid;

	private static FFieldAddress HasInputPin_bIncludeIO_PropertyAddress;

	private static int HasInputPin_bIncludeIO_Offset;

	private static bool HasInputPin_ReturnValue_IsValid;

	private static FFieldAddress HasInputPin_ReturnValue_PropertyAddress;

	private static int HasInputPin_ReturnValue_Offset;

	private static bool HasBreakpoint_IsValid;

	private static IntPtr HasBreakpoint_FunctionAddress;

	private static int HasBreakpoint_ParamsSize;

	private static bool HasBreakpoint_ReturnValue_IsValid;

	private static FFieldAddress HasBreakpoint_ReturnValue_PropertyAddress;

	private static int HasBreakpoint_ReturnValue_Offset;

	private static bool GetToolTipText_IsValid;

	private static IntPtr GetToolTipText_FunctionAddress;

	private static int GetToolTipText_ParamsSize;

	private static bool GetToolTipText_ReturnValue_IsValid;

	private static FFieldAddress GetToolTipText_ReturnValue_PropertyAddress;

	private static int GetToolTipText_ReturnValue_Offset;

	private static bool GetSize_IsValid;

	private static IntPtr GetSize_FunctionAddress;

	private static int GetSize_ParamsSize;

	private static bool GetSize_ReturnValue_IsValid;

	private static FFieldAddress GetSize_ReturnValue_PropertyAddress;

	private static int GetSize_ReturnValue_Offset;

	private static bool GetRootGraph_IsValid;

	private static IntPtr GetRootGraph_FunctionAddress;

	private static int GetRootGraph_ParamsSize;

	private static bool GetRootGraph_ReturnValue_IsValid;

	private static FFieldAddress GetRootGraph_ReturnValue_PropertyAddress;

	private static int GetRootGraph_ReturnValue_Offset;

	private static bool GetPreviousFName_IsValid;

	private static IntPtr GetPreviousFName_FunctionAddress;

	private static int GetPreviousFName_ParamsSize;

	private static bool GetPreviousFName_ReturnValue_IsValid;

	private static FFieldAddress GetPreviousFName_ReturnValue_PropertyAddress;

	private static int GetPreviousFName_ReturnValue_Offset;

	private static bool GetPosition_IsValid;

	private static IntPtr GetPosition_FunctionAddress;

	private static int GetPosition_ParamsSize;

	private static bool GetPosition_ReturnValue_IsValid;

	private static FFieldAddress GetPosition_ReturnValue_PropertyAddress;

	private static int GetPosition_ReturnValue_Offset;

	private static bool GetPins_IsValid;

	private static IntPtr GetPins_FunctionAddress;

	private static int GetPins_ParamsSize;

	private static bool GetPins_ReturnValue_IsValid;

	private static FFieldAddress GetPins_ReturnValue_PropertyAddress;

	private static int GetPins_ReturnValue_Offset;

	private static bool GetOrphanedPins_IsValid;

	private static IntPtr GetOrphanedPins_FunctionAddress;

	private static int GetOrphanedPins_ParamsSize;

	private static bool GetOrphanedPins_ReturnValue_IsValid;

	private static FFieldAddress GetOrphanedPins_ReturnValue_PropertyAddress;

	private static int GetOrphanedPins_ReturnValue_Offset;

	private static bool GetNodeTitle_IsValid;

	private static IntPtr GetNodeTitle_FunctionAddress;

	private static int GetNodeTitle_ParamsSize;

	private static bool GetNodeTitle_ReturnValue_IsValid;

	private static FFieldAddress GetNodeTitle_ReturnValue_PropertyAddress;

	private static int GetNodeTitle_ReturnValue_Offset;

	private static bool GetNodePath_IsValid;

	private static IntPtr GetNodePath_FunctionAddress;

	private static int GetNodePath_ParamsSize;

	private static bool GetNodePath_bRecursive_IsValid;

	private static FFieldAddress GetNodePath_bRecursive_PropertyAddress;

	private static int GetNodePath_bRecursive_Offset;

	private static bool GetNodePath_ReturnValue_IsValid;

	private static FFieldAddress GetNodePath_ReturnValue_PropertyAddress;

	private static int GetNodePath_ReturnValue_Offset;

	private static bool GetNodeIndex_IsValid;

	private static IntPtr GetNodeIndex_FunctionAddress;

	private static int GetNodeIndex_ParamsSize;

	private static bool GetNodeIndex_ReturnValue_IsValid;

	private static FFieldAddress GetNodeIndex_ReturnValue_PropertyAddress;

	private static int GetNodeIndex_ReturnValue_Offset;

	private static bool GetNodeColor_IsValid;

	private static IntPtr GetNodeColor_FunctionAddress;

	private static int GetNodeColor_ParamsSize;

	private static bool GetNodeColor_ReturnValue_IsValid;

	private static FFieldAddress GetNodeColor_ReturnValue_PropertyAddress;

	private static int GetNodeColor_ReturnValue_Offset;

	private static bool GetLinks_IsValid;

	private static IntPtr GetLinks_FunctionAddress;

	private static int GetLinks_ParamsSize;

	private static bool GetLinks_ReturnValue_IsValid;

	private static FFieldAddress GetLinks_ReturnValue_PropertyAddress;

	private static int GetLinks_ReturnValue_Offset;

	private static bool GetLinkedTargetNodes_IsValid;

	private static IntPtr GetLinkedTargetNodes_FunctionAddress;

	private static int GetLinkedTargetNodes_ParamsSize;

	private static bool GetLinkedTargetNodes_ReturnValue_IsValid;

	private static FFieldAddress GetLinkedTargetNodes_ReturnValue_PropertyAddress;

	private static int GetLinkedTargetNodes_ReturnValue_Offset;

	private static bool GetLinkedSourceNodes_IsValid;

	private static IntPtr GetLinkedSourceNodes_FunctionAddress;

	private static int GetLinkedSourceNodes_ParamsSize;

	private static bool GetLinkedSourceNodes_ReturnValue_IsValid;

	private static FFieldAddress GetLinkedSourceNodes_ReturnValue_PropertyAddress;

	private static int GetLinkedSourceNodes_ReturnValue_Offset;

	private static bool GetInjectionInfo_IsValid;

	private static IntPtr GetInjectionInfo_FunctionAddress;

	private static int GetInjectionInfo_ParamsSize;

	private static bool GetInjectionInfo_ReturnValue_IsValid;

	private static FFieldAddress GetInjectionInfo_ReturnValue_PropertyAddress;

	private static int GetInjectionInfo_ReturnValue_Offset;

	private static bool GetGraph_IsValid;

	private static IntPtr GetGraph_FunctionAddress;

	private static int GetGraph_ParamsSize;

	private static bool GetGraph_ReturnValue_IsValid;

	private static FFieldAddress GetGraph_ReturnValue_PropertyAddress;

	private static int GetGraph_ReturnValue_Offset;

	private static bool GetEventName_IsValid;

	private static IntPtr GetEventName_FunctionAddress;

	private static int GetEventName_ParamsSize;

	private static bool GetEventName_ReturnValue_IsValid;

	private static FFieldAddress GetEventName_ReturnValue_PropertyAddress;

	private static int GetEventName_ReturnValue_Offset;

	private static bool GetAllPinsRecursively_IsValid;

	private static IntPtr GetAllPinsRecursively_FunctionAddress;

	private static int GetAllPinsRecursively_ParamsSize;

	private static bool GetAllPinsRecursively_ReturnValue_IsValid;

	private static FFieldAddress GetAllPinsRecursively_ReturnValue_PropertyAddress;

	private static int GetAllPinsRecursively_ReturnValue_Offset;

	private static bool FindPin_IsValid;

	private static IntPtr FindPin_FunctionAddress;

	private static int FindPin_ParamsSize;

	private static bool FindPin_InPinPath_IsValid;

	private static FFieldAddress FindPin_InPinPath_PropertyAddress;

	private static int FindPin_InPinPath_Offset;

	private static bool FindPin_ReturnValue_IsValid;

	private static FFieldAddress FindPin_ReturnValue_PropertyAddress;

	private static int FindPin_ReturnValue_Offset;

	private static bool ExecutionIsHaltedAtThisNode_IsValid;

	private static IntPtr ExecutionIsHaltedAtThisNode_FunctionAddress;

	private static int ExecutionIsHaltedAtThisNode_ParamsSize;

	private static bool ExecutionIsHaltedAtThisNode_ReturnValue_IsValid;

	private static FFieldAddress ExecutionIsHaltedAtThisNode_ReturnValue_PropertyAddress;

	private static int ExecutionIsHaltedAtThisNode_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:SetHasBreakpoint")]
	public unsafe void SetHasBreakpoint(bool bValue)
	{
		CheckDestroyed();
		if (!SetHasBreakpoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:SetHasBreakpoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHasBreakpoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHasBreakpoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetHasBreakpoint_bValue_Offset), 0, SetHasBreakpoint_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHasBreakpoint_FunctionAddress, intPtr, SetHasBreakpoint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:SetExecutionIsHaltedAtThisNode")]
	public unsafe void SetExecutionIsHaltedAtThisNode(bool bValue)
	{
		CheckDestroyed();
		if (!SetExecutionIsHaltedAtThisNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:SetExecutionIsHaltedAtThisNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExecutionIsHaltedAtThisNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExecutionIsHaltedAtThisNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetExecutionIsHaltedAtThisNode_bValue_Offset), 0, SetExecutionIsHaltedAtThisNode_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetExecutionIsHaltedAtThisNode_FunctionAddress, intPtr, SetExecutionIsHaltedAtThisNode_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsVisibleInUI")]
	public unsafe bool IsVisibleInUI()
	{
		CheckDestroyed();
		if (!IsVisibleInUI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsVisibleInUI");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVisibleInUI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVisibleInUI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVisibleInUI_FunctionAddress, intPtr, IsVisibleInUI_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVisibleInUI_ReturnValue_Offset), 0, IsVisibleInUI_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsSelected")]
	public unsafe bool IsSelected()
	{
		CheckDestroyed();
		if (!IsSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsSelected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSelected_FunctionAddress, intPtr, IsSelected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSelected_ReturnValue_Offset), 0, IsSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsPure")]
	public unsafe bool IsPure()
	{
		CheckDestroyed();
		if (!IsPure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsPure");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPure_FunctionAddress, intPtr, IsPure_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPure_ReturnValue_Offset), 0, IsPure_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsMutable")]
	public unsafe bool IsMutable()
	{
		CheckDestroyed();
		if (!IsMutable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsMutable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMutable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMutable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMutable_FunctionAddress, intPtr, IsMutable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMutable_ReturnValue_Offset), 0, IsMutable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsLinkedTo")]
	public unsafe bool IsLinkedTo(URigVMNode InNode)
	{
		CheckDestroyed();
		if (!IsLinkedTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsLinkedTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLinkedTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLinkedTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMNode>.ToNative(IntPtr.Add(intPtr, IsLinkedTo_InNode_Offset), 0, IsLinkedTo_InNode_PropertyAddress.Address, InNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLinkedTo_FunctionAddress, intPtr, IsLinkedTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLinkedTo_ReturnValue_Offset), 0, IsLinkedTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsInjected")]
	public unsafe bool IsInjected()
	{
		CheckDestroyed();
		if (!IsInjected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsInjected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInjected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInjected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInjected_FunctionAddress, intPtr, IsInjected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInjected_ReturnValue_Offset), 0, IsInjected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsEvent")]
	public unsafe bool IsEvent()
	{
		CheckDestroyed();
		if (!IsEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEvent_FunctionAddress, intPtr, IsEvent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEvent_ReturnValue_Offset), 0, IsEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsDefinedAsVarying")]
	public unsafe bool IsDefinedAsVarying()
	{
		CheckDestroyed();
		if (!IsDefinedAsVarying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsDefinedAsVarying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDefinedAsVarying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDefinedAsVarying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDefinedAsVarying_FunctionAddress, intPtr, IsDefinedAsVarying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDefinedAsVarying_ReturnValue_Offset), 0, IsDefinedAsVarying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:IsDefinedAsConstant")]
	public unsafe bool IsDefinedAsConstant()
	{
		CheckDestroyed();
		if (!IsDefinedAsConstant_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:IsDefinedAsConstant");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDefinedAsConstant_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDefinedAsConstant_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDefinedAsConstant_FunctionAddress, intPtr, IsDefinedAsConstant_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDefinedAsConstant_ReturnValue_Offset), 0, IsDefinedAsConstant_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:HasPinOfDirection")]
	public unsafe bool HasPinOfDirection(ERigVMPinDirection InDirection)
	{
		CheckDestroyed();
		if (!HasPinOfDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:HasPinOfDirection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasPinOfDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasPinOfDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERigVMPinDirection>.ToNative(IntPtr.Add(intPtr, HasPinOfDirection_InDirection_Offset), 0, HasPinOfDirection_InDirection_PropertyAddress.Address, InDirection);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasPinOfDirection_FunctionAddress, intPtr, HasPinOfDirection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasPinOfDirection_ReturnValue_Offset), 0, HasPinOfDirection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:HasOutputPin")]
	public unsafe bool HasOutputPin(bool bIncludeIO = true)
	{
		CheckDestroyed();
		if (!HasOutputPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:HasOutputPin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasOutputPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasOutputPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HasOutputPin_bIncludeIO_Offset), 0, HasOutputPin_bIncludeIO_PropertyAddress.Address, bIncludeIO);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasOutputPin_FunctionAddress, intPtr, HasOutputPin_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasOutputPin_ReturnValue_Offset), 0, HasOutputPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:HasOrphanedPins")]
	public unsafe bool HasOrphanedPins()
	{
		CheckDestroyed();
		if (!HasOrphanedPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:HasOrphanedPins");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasOrphanedPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasOrphanedPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasOrphanedPins_FunctionAddress, intPtr, HasOrphanedPins_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasOrphanedPins_ReturnValue_Offset), 0, HasOrphanedPins_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:HasIOPin")]
	public unsafe bool HasIOPin()
	{
		CheckDestroyed();
		if (!HasIOPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:HasIOPin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasIOPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasIOPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasIOPin_FunctionAddress, intPtr, HasIOPin_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasIOPin_ReturnValue_Offset), 0, HasIOPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:HasInputPin")]
	public unsafe bool HasInputPin(bool bIncludeIO = true)
	{
		CheckDestroyed();
		if (!HasInputPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:HasInputPin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasInputPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasInputPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HasInputPin_bIncludeIO_Offset), 0, HasInputPin_bIncludeIO_PropertyAddress.Address, bIncludeIO);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasInputPin_FunctionAddress, intPtr, HasInputPin_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasInputPin_ReturnValue_Offset), 0, HasInputPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:HasBreakpoint")]
	public unsafe bool HasBreakpoint()
	{
		CheckDestroyed();
		if (!HasBreakpoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:HasBreakpoint");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasBreakpoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasBreakpoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasBreakpoint_FunctionAddress, intPtr, HasBreakpoint_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasBreakpoint_ReturnValue_Offset), 0, HasBreakpoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetToolTipText")]
	public unsafe string GetToolTipText()
	{
		CheckDestroyed();
		if (!GetToolTipText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetToolTipText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetToolTipText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetToolTipText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetToolTipText_FunctionAddress, intPtr, GetToolTipText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetToolTipText_ReturnValue_Offset), 0, GetToolTipText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetToolTipText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetSize")]
	public unsafe FVector2D GetSize()
	{
		CheckDestroyed();
		if (!GetSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSize_FunctionAddress, intPtr, GetSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetSize_ReturnValue_Offset), 0, GetSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetRootGraph")]
	public unsafe URigVMGraph GetRootGraph()
	{
		CheckDestroyed();
		if (!GetRootGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetRootGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRootGraph_FunctionAddress, intPtr, GetRootGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetRootGraph_ReturnValue_Offset), 0, GetRootGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetPreviousFName")]
	public unsafe FName GetPreviousFName()
	{
		CheckDestroyed();
		if (!GetPreviousFName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetPreviousFName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviousFName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviousFName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviousFName_FunctionAddress, intPtr, GetPreviousFName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetPreviousFName_ReturnValue_Offset), 0, GetPreviousFName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetPosition")]
	public unsafe FVector2D GetPosition()
	{
		CheckDestroyed();
		if (!GetPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetPosition");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPosition_FunctionAddress, intPtr, GetPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetPosition_ReturnValue_Offset), 0, GetPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetPins")]
	public unsafe List<URigVMPin> GetPins()
	{
		CheckDestroyed();
		if (!GetPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPins_FunctionAddress, intPtr, GetPins_ParamsSize);
		List<URigVMPin> result = new TArrayCopyMarshaler<URigVMPin>(1, GetPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMPin, UObjectMarshaler<URigVMPin>>.FromNative, CachedMarshalingDelegates<URigVMPin, UObjectMarshaler<URigVMPin>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetOrphanedPins")]
	public unsafe List<URigVMPin> GetOrphanedPins()
	{
		CheckDestroyed();
		if (!GetOrphanedPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetOrphanedPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOrphanedPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOrphanedPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOrphanedPins_FunctionAddress, intPtr, GetOrphanedPins_ParamsSize);
		List<URigVMPin> result = new TArrayCopyMarshaler<URigVMPin>(1, GetOrphanedPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMPin, UObjectMarshaler<URigVMPin>>.FromNative, CachedMarshalingDelegates<URigVMPin, UObjectMarshaler<URigVMPin>>.ToNative).FromNative(IntPtr.Add(intPtr, GetOrphanedPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOrphanedPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetNodeTitle")]
	public unsafe string GetNodeTitle()
	{
		CheckDestroyed();
		if (!GetNodeTitle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetNodeTitle");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeTitle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeTitle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeTitle_FunctionAddress, intPtr, GetNodeTitle_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNodeTitle_ReturnValue_Offset), 0, GetNodeTitle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNodeTitle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetNodePath")]
	public unsafe string GetNodePath(bool bRecursive = false)
	{
		CheckDestroyed();
		if (!GetNodePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetNodePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetNodePath_bRecursive_Offset), 0, GetNodePath_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodePath_FunctionAddress, intPtr, GetNodePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNodePath_ReturnValue_Offset), 0, GetNodePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNodePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetNodeIndex")]
	public unsafe int GetNodeIndex()
	{
		CheckDestroyed();
		if (!GetNodeIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetNodeIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeIndex_FunctionAddress, intPtr, GetNodeIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNodeIndex_ReturnValue_Offset), 0, GetNodeIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetNodeColor")]
	public unsafe FLinearColor GetNodeColor()
	{
		CheckDestroyed();
		if (!GetNodeColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetNodeColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeColor_FunctionAddress, intPtr, GetNodeColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetNodeColor_ReturnValue_Offset), 0, GetNodeColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetLinks")]
	public unsafe List<URigVMLink> GetLinks()
	{
		CheckDestroyed();
		if (!GetLinks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetLinks");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLinks_FunctionAddress, intPtr, GetLinks_ParamsSize);
		List<URigVMLink> result = new TArrayCopyMarshaler<URigVMLink>(1, GetLinks_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMLink, UObjectMarshaler<URigVMLink>>.FromNative, CachedMarshalingDelegates<URigVMLink, UObjectMarshaler<URigVMLink>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLinks_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLinks_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetLinkedTargetNodes")]
	public unsafe List<URigVMNode> GetLinkedTargetNodes()
	{
		CheckDestroyed();
		if (!GetLinkedTargetNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetLinkedTargetNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinkedTargetNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinkedTargetNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLinkedTargetNodes_FunctionAddress, intPtr, GetLinkedTargetNodes_ParamsSize);
		List<URigVMNode> result = new TArrayCopyMarshaler<URigVMNode>(1, GetLinkedTargetNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.FromNative, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLinkedTargetNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLinkedTargetNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetLinkedSourceNodes")]
	public unsafe List<URigVMNode> GetLinkedSourceNodes()
	{
		CheckDestroyed();
		if (!GetLinkedSourceNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetLinkedSourceNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinkedSourceNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinkedSourceNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLinkedSourceNodes_FunctionAddress, intPtr, GetLinkedSourceNodes_ParamsSize);
		List<URigVMNode> result = new TArrayCopyMarshaler<URigVMNode>(1, GetLinkedSourceNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.FromNative, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLinkedSourceNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLinkedSourceNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetInjectionInfo")]
	public unsafe URigVMInjectionInfo GetInjectionInfo()
	{
		CheckDestroyed();
		if (!GetInjectionInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetInjectionInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInjectionInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInjectionInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInjectionInfo_FunctionAddress, intPtr, GetInjectionInfo_ParamsSize);
		return UObjectMarshaler<URigVMInjectionInfo>.FromNative(IntPtr.Add(intPtr, GetInjectionInfo_ReturnValue_Offset), 0, GetInjectionInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetGraph")]
	public unsafe URigVMGraph GetGraph()
	{
		CheckDestroyed();
		if (!GetGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraph_FunctionAddress, intPtr, GetGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetGraph_ReturnValue_Offset), 0, GetGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetEventName")]
	public unsafe FName GetEventName()
	{
		CheckDestroyed();
		if (!GetEventName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetEventName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEventName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEventName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEventName_FunctionAddress, intPtr, GetEventName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetEventName_ReturnValue_Offset), 0, GetEventName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:GetAllPinsRecursively")]
	public unsafe List<URigVMPin> GetAllPinsRecursively()
	{
		CheckDestroyed();
		if (!GetAllPinsRecursively_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:GetAllPinsRecursively");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllPinsRecursively_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllPinsRecursively_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllPinsRecursively_FunctionAddress, intPtr, GetAllPinsRecursively_ParamsSize);
		List<URigVMPin> result = new TArrayCopyMarshaler<URigVMPin>(1, GetAllPinsRecursively_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMPin, UObjectMarshaler<URigVMPin>>.FromNative, CachedMarshalingDelegates<URigVMPin, UObjectMarshaler<URigVMPin>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllPinsRecursively_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllPinsRecursively_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:FindPin")]
	public unsafe URigVMPin FindPin(string InPinPath)
	{
		CheckDestroyed();
		if (!FindPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:FindPin");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPin_InPinPath_Offset), 0, FindPin_InPinPath_PropertyAddress.Address, InPinPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindPin_FunctionAddress, intPtr, FindPin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindPin_InPinPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMPin>.FromNative(IntPtr.Add(intPtr, FindPin_ReturnValue_Offset), 0, FindPin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMNode:ExecutionIsHaltedAtThisNode")]
	public unsafe bool ExecutionIsHaltedAtThisNode()
	{
		CheckDestroyed();
		if (!ExecutionIsHaltedAtThisNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMNode:ExecutionIsHaltedAtThisNode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecutionIsHaltedAtThisNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecutionIsHaltedAtThisNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecutionIsHaltedAtThisNode_FunctionAddress, intPtr, ExecutionIsHaltedAtThisNode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExecutionIsHaltedAtThisNode_ReturnValue_Offset), 0, ExecutionIsHaltedAtThisNode_ReturnValue_PropertyAddress.Address);
	}

	static URigVMNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMNode");
		SetHasBreakpoint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetHasBreakpoint");
		SetHasBreakpoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHasBreakpoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHasBreakpoint_bValue_PropertyAddress, SetHasBreakpoint_FunctionAddress, "bValue");
		SetHasBreakpoint_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetHasBreakpoint_FunctionAddress, "bValue");
		SetHasBreakpoint_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHasBreakpoint_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetHasBreakpoint_IsValid = SetHasBreakpoint_FunctionAddress != IntPtr.Zero && SetHasBreakpoint_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:SetHasBreakpoint", SetHasBreakpoint_IsValid);
		SetExecutionIsHaltedAtThisNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetExecutionIsHaltedAtThisNode");
		SetExecutionIsHaltedAtThisNode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExecutionIsHaltedAtThisNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExecutionIsHaltedAtThisNode_bValue_PropertyAddress, SetExecutionIsHaltedAtThisNode_FunctionAddress, "bValue");
		SetExecutionIsHaltedAtThisNode_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetExecutionIsHaltedAtThisNode_FunctionAddress, "bValue");
		SetExecutionIsHaltedAtThisNode_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExecutionIsHaltedAtThisNode_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetExecutionIsHaltedAtThisNode_IsValid = SetExecutionIsHaltedAtThisNode_FunctionAddress != IntPtr.Zero && SetExecutionIsHaltedAtThisNode_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:SetExecutionIsHaltedAtThisNode", SetExecutionIsHaltedAtThisNode_IsValid);
		IsVisibleInUI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsVisibleInUI");
		IsVisibleInUI_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVisibleInUI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVisibleInUI_ReturnValue_PropertyAddress, IsVisibleInUI_FunctionAddress, "ReturnValue");
		IsVisibleInUI_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVisibleInUI_FunctionAddress, "ReturnValue");
		IsVisibleInUI_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVisibleInUI_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVisibleInUI_IsValid = IsVisibleInUI_FunctionAddress != IntPtr.Zero && IsVisibleInUI_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsVisibleInUI", IsVisibleInUI_IsValid);
		IsSelected_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSelected");
		IsSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSelected_ReturnValue_PropertyAddress, IsSelected_FunctionAddress, "ReturnValue");
		IsSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSelected_FunctionAddress, "ReturnValue");
		IsSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSelected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSelected_IsValid = IsSelected_FunctionAddress != IntPtr.Zero && IsSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsSelected", IsSelected_IsValid);
		IsPure_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsPure");
		IsPure_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPure_ReturnValue_PropertyAddress, IsPure_FunctionAddress, "ReturnValue");
		IsPure_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPure_FunctionAddress, "ReturnValue");
		IsPure_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPure_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPure_IsValid = IsPure_FunctionAddress != IntPtr.Zero && IsPure_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsPure", IsPure_IsValid);
		IsMutable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsMutable");
		IsMutable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMutable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMutable_ReturnValue_PropertyAddress, IsMutable_FunctionAddress, "ReturnValue");
		IsMutable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMutable_FunctionAddress, "ReturnValue");
		IsMutable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMutable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMutable_IsValid = IsMutable_FunctionAddress != IntPtr.Zero && IsMutable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsMutable", IsMutable_IsValid);
		IsLinkedTo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLinkedTo");
		IsLinkedTo_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLinkedTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLinkedTo_InNode_PropertyAddress, IsLinkedTo_FunctionAddress, "InNode");
		IsLinkedTo_InNode_Offset = NativeReflectionCached.GetPropertyOffset(IsLinkedTo_FunctionAddress, "InNode");
		IsLinkedTo_InNode_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLinkedTo_FunctionAddress, "InNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLinkedTo_ReturnValue_PropertyAddress, IsLinkedTo_FunctionAddress, "ReturnValue");
		IsLinkedTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLinkedTo_FunctionAddress, "ReturnValue");
		IsLinkedTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLinkedTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLinkedTo_IsValid = IsLinkedTo_FunctionAddress != IntPtr.Zero && IsLinkedTo_InNode_IsValid && IsLinkedTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsLinkedTo", IsLinkedTo_IsValid);
		IsInjected_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsInjected");
		IsInjected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInjected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInjected_ReturnValue_PropertyAddress, IsInjected_FunctionAddress, "ReturnValue");
		IsInjected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInjected_FunctionAddress, "ReturnValue");
		IsInjected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInjected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInjected_IsValid = IsInjected_FunctionAddress != IntPtr.Zero && IsInjected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsInjected", IsInjected_IsValid);
		IsEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEvent");
		IsEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEvent_ReturnValue_PropertyAddress, IsEvent_FunctionAddress, "ReturnValue");
		IsEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEvent_FunctionAddress, "ReturnValue");
		IsEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEvent_IsValid = IsEvent_FunctionAddress != IntPtr.Zero && IsEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsEvent", IsEvent_IsValid);
		IsDefinedAsVarying_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsDefinedAsVarying");
		IsDefinedAsVarying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDefinedAsVarying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDefinedAsVarying_ReturnValue_PropertyAddress, IsDefinedAsVarying_FunctionAddress, "ReturnValue");
		IsDefinedAsVarying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDefinedAsVarying_FunctionAddress, "ReturnValue");
		IsDefinedAsVarying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDefinedAsVarying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDefinedAsVarying_IsValid = IsDefinedAsVarying_FunctionAddress != IntPtr.Zero && IsDefinedAsVarying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsDefinedAsVarying", IsDefinedAsVarying_IsValid);
		IsDefinedAsConstant_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsDefinedAsConstant");
		IsDefinedAsConstant_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDefinedAsConstant_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDefinedAsConstant_ReturnValue_PropertyAddress, IsDefinedAsConstant_FunctionAddress, "ReturnValue");
		IsDefinedAsConstant_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDefinedAsConstant_FunctionAddress, "ReturnValue");
		IsDefinedAsConstant_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDefinedAsConstant_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDefinedAsConstant_IsValid = IsDefinedAsConstant_FunctionAddress != IntPtr.Zero && IsDefinedAsConstant_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:IsDefinedAsConstant", IsDefinedAsConstant_IsValid);
		HasPinOfDirection_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasPinOfDirection");
		HasPinOfDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(HasPinOfDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasPinOfDirection_InDirection_PropertyAddress, HasPinOfDirection_FunctionAddress, "InDirection");
		HasPinOfDirection_InDirection_Offset = NativeReflectionCached.GetPropertyOffset(HasPinOfDirection_FunctionAddress, "InDirection");
		HasPinOfDirection_InDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(HasPinOfDirection_FunctionAddress, "InDirection", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref HasPinOfDirection_ReturnValue_PropertyAddress, HasPinOfDirection_FunctionAddress, "ReturnValue");
		HasPinOfDirection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasPinOfDirection_FunctionAddress, "ReturnValue");
		HasPinOfDirection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasPinOfDirection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasPinOfDirection_IsValid = HasPinOfDirection_FunctionAddress != IntPtr.Zero && HasPinOfDirection_InDirection_IsValid && HasPinOfDirection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:HasPinOfDirection", HasPinOfDirection_IsValid);
		HasOutputPin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasOutputPin");
		HasOutputPin_ParamsSize = NativeReflection.GetFunctionParamsSize(HasOutputPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasOutputPin_bIncludeIO_PropertyAddress, HasOutputPin_FunctionAddress, "bIncludeIO");
		HasOutputPin_bIncludeIO_Offset = NativeReflectionCached.GetPropertyOffset(HasOutputPin_FunctionAddress, "bIncludeIO");
		HasOutputPin_bIncludeIO_IsValid = NativeReflectionCached.ValidatePropertyClass(HasOutputPin_FunctionAddress, "bIncludeIO", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasOutputPin_ReturnValue_PropertyAddress, HasOutputPin_FunctionAddress, "ReturnValue");
		HasOutputPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasOutputPin_FunctionAddress, "ReturnValue");
		HasOutputPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasOutputPin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasOutputPin_IsValid = HasOutputPin_FunctionAddress != IntPtr.Zero && HasOutputPin_bIncludeIO_IsValid && HasOutputPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:HasOutputPin", HasOutputPin_IsValid);
		HasOrphanedPins_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasOrphanedPins");
		HasOrphanedPins_ParamsSize = NativeReflection.GetFunctionParamsSize(HasOrphanedPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasOrphanedPins_ReturnValue_PropertyAddress, HasOrphanedPins_FunctionAddress, "ReturnValue");
		HasOrphanedPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasOrphanedPins_FunctionAddress, "ReturnValue");
		HasOrphanedPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasOrphanedPins_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasOrphanedPins_IsValid = HasOrphanedPins_FunctionAddress != IntPtr.Zero && HasOrphanedPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:HasOrphanedPins", HasOrphanedPins_IsValid);
		HasIOPin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasIOPin");
		HasIOPin_ParamsSize = NativeReflection.GetFunctionParamsSize(HasIOPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasIOPin_ReturnValue_PropertyAddress, HasIOPin_FunctionAddress, "ReturnValue");
		HasIOPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasIOPin_FunctionAddress, "ReturnValue");
		HasIOPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasIOPin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasIOPin_IsValid = HasIOPin_FunctionAddress != IntPtr.Zero && HasIOPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:HasIOPin", HasIOPin_IsValid);
		HasInputPin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasInputPin");
		HasInputPin_ParamsSize = NativeReflection.GetFunctionParamsSize(HasInputPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasInputPin_bIncludeIO_PropertyAddress, HasInputPin_FunctionAddress, "bIncludeIO");
		HasInputPin_bIncludeIO_Offset = NativeReflectionCached.GetPropertyOffset(HasInputPin_FunctionAddress, "bIncludeIO");
		HasInputPin_bIncludeIO_IsValid = NativeReflectionCached.ValidatePropertyClass(HasInputPin_FunctionAddress, "bIncludeIO", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasInputPin_ReturnValue_PropertyAddress, HasInputPin_FunctionAddress, "ReturnValue");
		HasInputPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasInputPin_FunctionAddress, "ReturnValue");
		HasInputPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasInputPin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasInputPin_IsValid = HasInputPin_FunctionAddress != IntPtr.Zero && HasInputPin_bIncludeIO_IsValid && HasInputPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:HasInputPin", HasInputPin_IsValid);
		HasBreakpoint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasBreakpoint");
		HasBreakpoint_ParamsSize = NativeReflection.GetFunctionParamsSize(HasBreakpoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasBreakpoint_ReturnValue_PropertyAddress, HasBreakpoint_FunctionAddress, "ReturnValue");
		HasBreakpoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasBreakpoint_FunctionAddress, "ReturnValue");
		HasBreakpoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasBreakpoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasBreakpoint_IsValid = HasBreakpoint_FunctionAddress != IntPtr.Zero && HasBreakpoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:HasBreakpoint", HasBreakpoint_IsValid);
		GetToolTipText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetToolTipText");
		GetToolTipText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetToolTipText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetToolTipText_ReturnValue_PropertyAddress, GetToolTipText_FunctionAddress, "ReturnValue");
		GetToolTipText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetToolTipText_FunctionAddress, "ReturnValue");
		GetToolTipText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetToolTipText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetToolTipText_IsValid = GetToolTipText_FunctionAddress != IntPtr.Zero && GetToolTipText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetToolTipText", GetToolTipText_IsValid);
		GetSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSize");
		GetSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSize_ReturnValue_PropertyAddress, GetSize_FunctionAddress, "ReturnValue");
		GetSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSize_FunctionAddress, "ReturnValue");
		GetSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSize_IsValid = GetSize_FunctionAddress != IntPtr.Zero && GetSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetSize", GetSize_IsValid);
		GetRootGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRootGraph");
		GetRootGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootGraph_ReturnValue_PropertyAddress, GetRootGraph_FunctionAddress, "ReturnValue");
		GetRootGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootGraph_FunctionAddress, "ReturnValue");
		GetRootGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRootGraph_IsValid = GetRootGraph_FunctionAddress != IntPtr.Zero && GetRootGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetRootGraph", GetRootGraph_IsValid);
		GetPreviousFName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPreviousFName");
		GetPreviousFName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviousFName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviousFName_ReturnValue_PropertyAddress, GetPreviousFName_FunctionAddress, "ReturnValue");
		GetPreviousFName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviousFName_FunctionAddress, "ReturnValue");
		GetPreviousFName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviousFName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetPreviousFName_IsValid = GetPreviousFName_FunctionAddress != IntPtr.Zero && GetPreviousFName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetPreviousFName", GetPreviousFName_IsValid);
		GetPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPosition");
		GetPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPosition_ReturnValue_PropertyAddress, GetPosition_FunctionAddress, "ReturnValue");
		GetPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPosition_FunctionAddress, "ReturnValue");
		GetPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPosition_IsValid = GetPosition_FunctionAddress != IntPtr.Zero && GetPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetPosition", GetPosition_IsValid);
		GetPins_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPins");
		GetPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPins_ReturnValue_PropertyAddress, GetPins_FunctionAddress, "ReturnValue");
		GetPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPins_FunctionAddress, "ReturnValue");
		GetPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPins_IsValid = GetPins_FunctionAddress != IntPtr.Zero && GetPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetPins", GetPins_IsValid);
		GetOrphanedPins_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOrphanedPins");
		GetOrphanedPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOrphanedPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOrphanedPins_ReturnValue_PropertyAddress, GetOrphanedPins_FunctionAddress, "ReturnValue");
		GetOrphanedPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOrphanedPins_FunctionAddress, "ReturnValue");
		GetOrphanedPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrphanedPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOrphanedPins_IsValid = GetOrphanedPins_FunctionAddress != IntPtr.Zero && GetOrphanedPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetOrphanedPins", GetOrphanedPins_IsValid);
		GetNodeTitle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeTitle");
		GetNodeTitle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeTitle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeTitle_ReturnValue_PropertyAddress, GetNodeTitle_FunctionAddress, "ReturnValue");
		GetNodeTitle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeTitle_FunctionAddress, "ReturnValue");
		GetNodeTitle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeTitle_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeTitle_IsValid = GetNodeTitle_FunctionAddress != IntPtr.Zero && GetNodeTitle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetNodeTitle", GetNodeTitle_IsValid);
		GetNodePath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodePath");
		GetNodePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodePath_bRecursive_PropertyAddress, GetNodePath_FunctionAddress, "bRecursive");
		GetNodePath_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetNodePath_FunctionAddress, "bRecursive");
		GetNodePath_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodePath_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodePath_ReturnValue_PropertyAddress, GetNodePath_FunctionAddress, "ReturnValue");
		GetNodePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodePath_FunctionAddress, "ReturnValue");
		GetNodePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodePath_IsValid = GetNodePath_FunctionAddress != IntPtr.Zero && GetNodePath_bRecursive_IsValid && GetNodePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetNodePath", GetNodePath_IsValid);
		GetNodeIndex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeIndex");
		GetNodeIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeIndex_ReturnValue_PropertyAddress, GetNodeIndex_FunctionAddress, "ReturnValue");
		GetNodeIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeIndex_FunctionAddress, "ReturnValue");
		GetNodeIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNodeIndex_IsValid = GetNodeIndex_FunctionAddress != IntPtr.Zero && GetNodeIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetNodeIndex", GetNodeIndex_IsValid);
		GetNodeColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeColor");
		GetNodeColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeColor_ReturnValue_PropertyAddress, GetNodeColor_FunctionAddress, "ReturnValue");
		GetNodeColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeColor_FunctionAddress, "ReturnValue");
		GetNodeColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNodeColor_IsValid = GetNodeColor_FunctionAddress != IntPtr.Zero && GetNodeColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetNodeColor", GetNodeColor_IsValid);
		GetLinks_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLinks");
		GetLinks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinks_ReturnValue_PropertyAddress, GetLinks_FunctionAddress, "ReturnValue");
		GetLinks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinks_FunctionAddress, "ReturnValue");
		GetLinks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinks_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLinks_IsValid = GetLinks_FunctionAddress != IntPtr.Zero && GetLinks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetLinks", GetLinks_IsValid);
		GetLinkedTargetNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLinkedTargetNodes");
		GetLinkedTargetNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinkedTargetNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedTargetNodes_ReturnValue_PropertyAddress, GetLinkedTargetNodes_FunctionAddress, "ReturnValue");
		GetLinkedTargetNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedTargetNodes_FunctionAddress, "ReturnValue");
		GetLinkedTargetNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedTargetNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLinkedTargetNodes_IsValid = GetLinkedTargetNodes_FunctionAddress != IntPtr.Zero && GetLinkedTargetNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetLinkedTargetNodes", GetLinkedTargetNodes_IsValid);
		GetLinkedSourceNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLinkedSourceNodes");
		GetLinkedSourceNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinkedSourceNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedSourceNodes_ReturnValue_PropertyAddress, GetLinkedSourceNodes_FunctionAddress, "ReturnValue");
		GetLinkedSourceNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedSourceNodes_FunctionAddress, "ReturnValue");
		GetLinkedSourceNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedSourceNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLinkedSourceNodes_IsValid = GetLinkedSourceNodes_FunctionAddress != IntPtr.Zero && GetLinkedSourceNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetLinkedSourceNodes", GetLinkedSourceNodes_IsValid);
		GetInjectionInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInjectionInfo");
		GetInjectionInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInjectionInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInjectionInfo_ReturnValue_PropertyAddress, GetInjectionInfo_FunctionAddress, "ReturnValue");
		GetInjectionInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInjectionInfo_FunctionAddress, "ReturnValue");
		GetInjectionInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInjectionInfo_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInjectionInfo_IsValid = GetInjectionInfo_FunctionAddress != IntPtr.Zero && GetInjectionInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetInjectionInfo", GetInjectionInfo_IsValid);
		GetGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGraph");
		GetGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraph_ReturnValue_PropertyAddress, GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraph_FunctionAddress, "ReturnValue");
		GetGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGraph_IsValid = GetGraph_FunctionAddress != IntPtr.Zero && GetGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetGraph", GetGraph_IsValid);
		GetEventName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEventName");
		GetEventName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEventName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEventName_ReturnValue_PropertyAddress, GetEventName_FunctionAddress, "ReturnValue");
		GetEventName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEventName_FunctionAddress, "ReturnValue");
		GetEventName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEventName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetEventName_IsValid = GetEventName_FunctionAddress != IntPtr.Zero && GetEventName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetEventName", GetEventName_IsValid);
		GetAllPinsRecursively_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllPinsRecursively");
		GetAllPinsRecursively_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllPinsRecursively_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllPinsRecursively_ReturnValue_PropertyAddress, GetAllPinsRecursively_FunctionAddress, "ReturnValue");
		GetAllPinsRecursively_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllPinsRecursively_FunctionAddress, "ReturnValue");
		GetAllPinsRecursively_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllPinsRecursively_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllPinsRecursively_IsValid = GetAllPinsRecursively_FunctionAddress != IntPtr.Zero && GetAllPinsRecursively_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:GetAllPinsRecursively", GetAllPinsRecursively_IsValid);
		FindPin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindPin");
		FindPin_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPin_InPinPath_PropertyAddress, FindPin_FunctionAddress, "InPinPath");
		FindPin_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "InPinPath");
		FindPin_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPin_ReturnValue_PropertyAddress, FindPin_FunctionAddress, "ReturnValue");
		FindPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "ReturnValue");
		FindPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindPin_IsValid = FindPin_FunctionAddress != IntPtr.Zero && FindPin_InPinPath_IsValid && FindPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:FindPin", FindPin_IsValid);
		ExecutionIsHaltedAtThisNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExecutionIsHaltedAtThisNode");
		ExecutionIsHaltedAtThisNode_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecutionIsHaltedAtThisNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecutionIsHaltedAtThisNode_ReturnValue_PropertyAddress, ExecutionIsHaltedAtThisNode_FunctionAddress, "ReturnValue");
		ExecutionIsHaltedAtThisNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExecutionIsHaltedAtThisNode_FunctionAddress, "ReturnValue");
		ExecutionIsHaltedAtThisNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecutionIsHaltedAtThisNode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExecutionIsHaltedAtThisNode_IsValid = ExecutionIsHaltedAtThisNode_FunctionAddress != IntPtr.Zero && ExecutionIsHaltedAtThisNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMNode:ExecutionIsHaltedAtThisNode", ExecutionIsHaltedAtThisNode_IsValid);
	}
}
