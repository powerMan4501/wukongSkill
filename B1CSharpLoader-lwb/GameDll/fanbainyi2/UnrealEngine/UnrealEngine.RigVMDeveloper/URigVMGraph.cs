using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMGraph", "RigVMDeveloper", UnrealModuleType.Engine)]
public class URigVMGraph : UObject
{
	private static bool SetDefaultFunctionLibrary_IsValid;

	private static IntPtr SetDefaultFunctionLibrary_FunctionAddress;

	private static int SetDefaultFunctionLibrary_ParamsSize;

	private static bool SetDefaultFunctionLibrary_InFunctionLibrary_IsValid;

	private static FFieldAddress SetDefaultFunctionLibrary_InFunctionLibrary_PropertyAddress;

	private static int SetDefaultFunctionLibrary_InFunctionLibrary_Offset;

	private static bool IsTopLevelGraph_IsValid;

	private static IntPtr IsTopLevelGraph_FunctionAddress;

	private static int IsTopLevelGraph_ParamsSize;

	private static bool IsTopLevelGraph_ReturnValue_IsValid;

	private static FFieldAddress IsTopLevelGraph_ReturnValue_PropertyAddress;

	private static int IsTopLevelGraph_ReturnValue_Offset;

	private static bool IsRootGraph_IsValid;

	private static IntPtr IsRootGraph_FunctionAddress;

	private static int IsRootGraph_ParamsSize;

	private static bool IsRootGraph_ReturnValue_IsValid;

	private static FFieldAddress IsRootGraph_ReturnValue_PropertyAddress;

	private static int IsRootGraph_ReturnValue_Offset;

	private static bool IsNodeSelected_IsValid;

	private static IntPtr IsNodeSelected_FunctionAddress;

	private static int IsNodeSelected_ParamsSize;

	private static bool IsNodeSelected_InNodeName_IsValid;

	private static FFieldAddress IsNodeSelected_InNodeName_PropertyAddress;

	private static int IsNodeSelected_InNodeName_Offset;

	private static bool IsNodeSelected_ReturnValue_IsValid;

	private static FFieldAddress IsNodeSelected_ReturnValue_PropertyAddress;

	private static int IsNodeSelected_ReturnValue_Offset;

	private static bool GetVariableDescriptions_IsValid;

	private static IntPtr GetVariableDescriptions_FunctionAddress;

	private static int GetVariableDescriptions_ParamsSize;

	private static bool GetVariableDescriptions_ReturnValue_IsValid;

	private static FFieldAddress GetVariableDescriptions_ReturnValue_PropertyAddress;

	private static int GetVariableDescriptions_ReturnValue_Offset;

	private static bool GetSelectNodes_IsValid;

	private static IntPtr GetSelectNodes_FunctionAddress;

	private static int GetSelectNodes_ParamsSize;

	private static bool GetSelectNodes_ReturnValue_IsValid;

	private static FFieldAddress GetSelectNodes_ReturnValue_PropertyAddress;

	private static int GetSelectNodes_ReturnValue_Offset;

	private static bool GetRootGraph_IsValid;

	private static IntPtr GetRootGraph_FunctionAddress;

	private static int GetRootGraph_ParamsSize;

	private static bool GetRootGraph_ReturnValue_IsValid;

	private static FFieldAddress GetRootGraph_ReturnValue_PropertyAddress;

	private static int GetRootGraph_ReturnValue_Offset;

	private static bool GetReturnNode_IsValid;

	private static IntPtr GetReturnNode_FunctionAddress;

	private static int GetReturnNode_ParamsSize;

	private static bool GetReturnNode_ReturnValue_IsValid;

	private static FFieldAddress GetReturnNode_ReturnValue_PropertyAddress;

	private static int GetReturnNode_ReturnValue_Offset;

	private static bool GetParentGraph_IsValid;

	private static IntPtr GetParentGraph_FunctionAddress;

	private static int GetParentGraph_ParamsSize;

	private static bool GetParentGraph_ReturnValue_IsValid;

	private static FFieldAddress GetParentGraph_ReturnValue_PropertyAddress;

	private static int GetParentGraph_ReturnValue_Offset;

	private static bool GetParameterDescriptions_IsValid;

	private static IntPtr GetParameterDescriptions_FunctionAddress;

	private static int GetParameterDescriptions_ParamsSize;

	private static bool GetParameterDescriptions_ReturnValue_IsValid;

	private static FFieldAddress GetParameterDescriptions_ReturnValue_PropertyAddress;

	private static int GetParameterDescriptions_ReturnValue_Offset;

	private static bool GetOutputArguments_IsValid;

	private static IntPtr GetOutputArguments_FunctionAddress;

	private static int GetOutputArguments_ParamsSize;

	private static bool GetOutputArguments_ReturnValue_IsValid;

	private static FFieldAddress GetOutputArguments_ReturnValue_PropertyAddress;

	private static int GetOutputArguments_ReturnValue_Offset;

	private static bool GetNodes_IsValid;

	private static IntPtr GetNodes_FunctionAddress;

	private static int GetNodes_ParamsSize;

	private static bool GetNodes_ReturnValue_IsValid;

	private static FFieldAddress GetNodes_ReturnValue_PropertyAddress;

	private static int GetNodes_ReturnValue_Offset;

	private static bool GetNodePath_IsValid;

	private static IntPtr GetNodePath_FunctionAddress;

	private static int GetNodePath_ParamsSize;

	private static bool GetNodePath_ReturnValue_IsValid;

	private static FFieldAddress GetNodePath_ReturnValue_PropertyAddress;

	private static int GetNodePath_ReturnValue_Offset;

	private static bool GetLocalVariables_IsValid;

	private static IntPtr GetLocalVariables_FunctionAddress;

	private static int GetLocalVariables_ParamsSize;

	private static bool GetLocalVariables_bIncludeInputArguments_IsValid;

	private static FFieldAddress GetLocalVariables_bIncludeInputArguments_PropertyAddress;

	private static int GetLocalVariables_bIncludeInputArguments_Offset;

	private static bool GetLocalVariables_ReturnValue_IsValid;

	private static FFieldAddress GetLocalVariables_ReturnValue_PropertyAddress;

	private static int GetLocalVariables_ReturnValue_Offset;

	private static bool GetLinks_IsValid;

	private static IntPtr GetLinks_FunctionAddress;

	private static int GetLinks_ParamsSize;

	private static bool GetLinks_ReturnValue_IsValid;

	private static FFieldAddress GetLinks_ReturnValue_PropertyAddress;

	private static int GetLinks_ReturnValue_Offset;

	private static bool GetInputArguments_IsValid;

	private static IntPtr GetInputArguments_FunctionAddress;

	private static int GetInputArguments_ParamsSize;

	private static bool GetInputArguments_ReturnValue_IsValid;

	private static FFieldAddress GetInputArguments_ReturnValue_PropertyAddress;

	private static int GetInputArguments_ReturnValue_Offset;

	private static bool GetGraphName_IsValid;

	private static IntPtr GetGraphName_FunctionAddress;

	private static int GetGraphName_ParamsSize;

	private static bool GetGraphName_ReturnValue_IsValid;

	private static FFieldAddress GetGraphName_ReturnValue_PropertyAddress;

	private static int GetGraphName_ReturnValue_Offset;

	private static bool GetEntryNode_IsValid;

	private static IntPtr GetEntryNode_FunctionAddress;

	private static int GetEntryNode_ParamsSize;

	private static bool GetEntryNode_ReturnValue_IsValid;

	private static FFieldAddress GetEntryNode_ReturnValue_PropertyAddress;

	private static int GetEntryNode_ReturnValue_Offset;

	private static bool GetDefaultFunctionLibrary_IsValid;

	private static IntPtr GetDefaultFunctionLibrary_FunctionAddress;

	private static int GetDefaultFunctionLibrary_ParamsSize;

	private static bool GetDefaultFunctionLibrary_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultFunctionLibrary_ReturnValue_PropertyAddress;

	private static int GetDefaultFunctionLibrary_ReturnValue_Offset;

	private static bool GetContainedGraphs_IsValid;

	private static IntPtr GetContainedGraphs_FunctionAddress;

	private static int GetContainedGraphs_ParamsSize;

	private static bool GetContainedGraphs_bRecursive_IsValid;

	private static FFieldAddress GetContainedGraphs_bRecursive_PropertyAddress;

	private static int GetContainedGraphs_bRecursive_Offset;

	private static bool GetContainedGraphs_ReturnValue_IsValid;

	private static FFieldAddress GetContainedGraphs_ReturnValue_PropertyAddress;

	private static int GetContainedGraphs_ReturnValue_Offset;

	private static bool FindPin_IsValid;

	private static IntPtr FindPin_FunctionAddress;

	private static int FindPin_ParamsSize;

	private static bool FindPin_InPinPath_IsValid;

	private static FFieldAddress FindPin_InPinPath_PropertyAddress;

	private static int FindPin_InPinPath_Offset;

	private static bool FindPin_ReturnValue_IsValid;

	private static FFieldAddress FindPin_ReturnValue_PropertyAddress;

	private static int FindPin_ReturnValue_Offset;

	private static bool FindNodeByName_IsValid;

	private static IntPtr FindNodeByName_FunctionAddress;

	private static int FindNodeByName_ParamsSize;

	private static bool FindNodeByName_InNodeName_IsValid;

	private static FFieldAddress FindNodeByName_InNodeName_PropertyAddress;

	private static int FindNodeByName_InNodeName_Offset;

	private static bool FindNodeByName_ReturnValue_IsValid;

	private static FFieldAddress FindNodeByName_ReturnValue_PropertyAddress;

	private static int FindNodeByName_ReturnValue_Offset;

	private static bool FindNode_IsValid;

	private static IntPtr FindNode_FunctionAddress;

	private static int FindNode_ParamsSize;

	private static bool FindNode_InNodePath_IsValid;

	private static FFieldAddress FindNode_InNodePath_PropertyAddress;

	private static int FindNode_InNodePath_Offset;

	private static bool FindNode_ReturnValue_IsValid;

	private static FFieldAddress FindNode_ReturnValue_PropertyAddress;

	private static int FindNode_ReturnValue_Offset;

	private static bool FindLink_IsValid;

	private static IntPtr FindLink_FunctionAddress;

	private static int FindLink_ParamsSize;

	private static bool FindLink_InLinkPinPathRepresentation_IsValid;

	private static FFieldAddress FindLink_InLinkPinPathRepresentation_PropertyAddress;

	private static int FindLink_InLinkPinPathRepresentation_Offset;

	private static bool FindLink_ReturnValue_IsValid;

	private static FFieldAddress FindLink_ReturnValue_PropertyAddress;

	private static int FindLink_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:SetDefaultFunctionLibrary")]
	public unsafe void SetDefaultFunctionLibrary(URigVMFunctionLibrary InFunctionLibrary)
	{
		CheckDestroyed();
		if (!SetDefaultFunctionLibrary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:SetDefaultFunctionLibrary");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultFunctionLibrary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultFunctionLibrary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<URigVMFunctionLibrary>.ToNative(IntPtr.Add(intPtr, SetDefaultFunctionLibrary_InFunctionLibrary_Offset), 0, SetDefaultFunctionLibrary_InFunctionLibrary_PropertyAddress.Address, InFunctionLibrary);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultFunctionLibrary_FunctionAddress, intPtr, SetDefaultFunctionLibrary_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:IsTopLevelGraph")]
	public unsafe bool IsTopLevelGraph()
	{
		CheckDestroyed();
		if (!IsTopLevelGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:IsTopLevelGraph");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTopLevelGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTopLevelGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTopLevelGraph_FunctionAddress, intPtr, IsTopLevelGraph_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTopLevelGraph_ReturnValue_Offset), 0, IsTopLevelGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:IsRootGraph")]
	public unsafe bool IsRootGraph()
	{
		CheckDestroyed();
		if (!IsRootGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:IsRootGraph");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRootGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRootGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRootGraph_FunctionAddress, intPtr, IsRootGraph_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRootGraph_ReturnValue_Offset), 0, IsRootGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:IsNodeSelected")]
	public unsafe bool IsNodeSelected(FName InNodeName)
	{
		CheckDestroyed();
		if (!IsNodeSelected_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:IsNodeSelected");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNodeSelected_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNodeSelected_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, IsNodeSelected_InNodeName_Offset), 0, IsNodeSelected_InNodeName_PropertyAddress.Address, InNodeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsNodeSelected_FunctionAddress, intPtr, IsNodeSelected_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNodeSelected_ReturnValue_Offset), 0, IsNodeSelected_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetVariableDescriptions")]
	public unsafe List<FRigVMGraphVariableDescription> GetVariableDescriptions()
	{
		CheckDestroyed();
		if (!GetVariableDescriptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetVariableDescriptions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariableDescriptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariableDescriptions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariableDescriptions_FunctionAddress, intPtr, GetVariableDescriptions_ParamsSize);
		List<FRigVMGraphVariableDescription> result = new TArrayCopyMarshaler<FRigVMGraphVariableDescription>(1, GetVariableDescriptions_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.FromNative, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.ToNative).FromNative(IntPtr.Add(intPtr, GetVariableDescriptions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetVariableDescriptions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetSelectNodes")]
	public unsafe List<FName> GetSelectNodes()
	{
		CheckDestroyed();
		if (!GetSelectNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetSelectNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectNodes_FunctionAddress, intPtr, GetSelectNodes_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetSelectNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetRootGraph")]
	public unsafe URigVMGraph GetRootGraph()
	{
		CheckDestroyed();
		if (!GetRootGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetRootGraph");
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
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetReturnNode")]
	public unsafe URigVMFunctionReturnNode GetReturnNode()
	{
		CheckDestroyed();
		if (!GetReturnNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetReturnNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReturnNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReturnNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReturnNode_FunctionAddress, intPtr, GetReturnNode_ParamsSize);
		return UObjectMarshaler<URigVMFunctionReturnNode>.FromNative(IntPtr.Add(intPtr, GetReturnNode_ReturnValue_Offset), 0, GetReturnNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetParentGraph")]
	public unsafe URigVMGraph GetParentGraph()
	{
		CheckDestroyed();
		if (!GetParentGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetParentGraph");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentGraph_FunctionAddress, intPtr, GetParentGraph_ParamsSize);
		return UObjectMarshaler<URigVMGraph>.FromNative(IntPtr.Add(intPtr, GetParentGraph_ReturnValue_Offset), 0, GetParentGraph_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetParameterDescriptions")]
	public unsafe List<FRigVMGraphParameterDescription> GetParameterDescriptions()
	{
		CheckDestroyed();
		if (!GetParameterDescriptions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetParameterDescriptions");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParameterDescriptions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParameterDescriptions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParameterDescriptions_FunctionAddress, intPtr, GetParameterDescriptions_ParamsSize);
		List<FRigVMGraphParameterDescription> result = new TArrayCopyMarshaler<FRigVMGraphParameterDescription>(1, GetParameterDescriptions_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigVMGraphParameterDescription, FRigVMGraphParameterDescription>.FromNative, CachedMarshalingDelegates<FRigVMGraphParameterDescription, FRigVMGraphParameterDescription>.ToNative).FromNative(IntPtr.Add(intPtr, GetParameterDescriptions_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetParameterDescriptions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetOutputArguments")]
	public unsafe List<FRigVMGraphVariableDescription> GetOutputArguments()
	{
		CheckDestroyed();
		if (!GetOutputArguments_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetOutputArguments");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOutputArguments_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOutputArguments_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOutputArguments_FunctionAddress, intPtr, GetOutputArguments_ParamsSize);
		List<FRigVMGraphVariableDescription> result = new TArrayCopyMarshaler<FRigVMGraphVariableDescription>(1, GetOutputArguments_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.FromNative, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.ToNative).FromNative(IntPtr.Add(intPtr, GetOutputArguments_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOutputArguments_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetNodes")]
	public unsafe List<URigVMNode> GetNodes()
	{
		CheckDestroyed();
		if (!GetNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetNodes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodes_FunctionAddress, intPtr, GetNodes_ParamsSize);
		List<URigVMNode> result = new TArrayCopyMarshaler<URigVMNode>(1, GetNodes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.FromNative, CachedMarshalingDelegates<URigVMNode, UObjectMarshaler<URigVMNode>>.ToNative).FromNative(IntPtr.Add(intPtr, GetNodes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNodes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetNodePath")]
	public unsafe string GetNodePath()
	{
		CheckDestroyed();
		if (!GetNodePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetNodePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodePath_FunctionAddress, intPtr, GetNodePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNodePath_ReturnValue_Offset), 0, GetNodePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNodePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetLocalVariables")]
	public unsafe List<FRigVMGraphVariableDescription> GetLocalVariables(bool bIncludeInputArguments = false)
	{
		CheckDestroyed();
		if (!GetLocalVariables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetLocalVariables");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalVariables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalVariables_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLocalVariables_bIncludeInputArguments_Offset), 0, GetLocalVariables_bIncludeInputArguments_PropertyAddress.Address, bIncludeInputArguments);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalVariables_FunctionAddress, intPtr, GetLocalVariables_ParamsSize);
		List<FRigVMGraphVariableDescription> result = new TArrayCopyMarshaler<FRigVMGraphVariableDescription>(1, GetLocalVariables_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.FromNative, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.ToNative).FromNative(IntPtr.Add(intPtr, GetLocalVariables_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLocalVariables_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetLinks")]
	public unsafe List<URigVMLink> GetLinks()
	{
		CheckDestroyed();
		if (!GetLinks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetLinks");
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
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetInputArguments")]
	public unsafe List<FRigVMGraphVariableDescription> GetInputArguments()
	{
		CheckDestroyed();
		if (!GetInputArguments_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetInputArguments");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputArguments_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputArguments_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputArguments_FunctionAddress, intPtr, GetInputArguments_ParamsSize);
		List<FRigVMGraphVariableDescription> result = new TArrayCopyMarshaler<FRigVMGraphVariableDescription>(1, GetInputArguments_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.FromNative, CachedMarshalingDelegates<FRigVMGraphVariableDescription, FRigVMGraphVariableDescription>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputArguments_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputArguments_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetGraphName")]
	public unsafe string GetGraphName()
	{
		CheckDestroyed();
		if (!GetGraphName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetGraphName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGraphName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGraphName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGraphName_FunctionAddress, intPtr, GetGraphName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGraphName_ReturnValue_Offset), 0, GetGraphName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGraphName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetEntryNode")]
	public unsafe URigVMFunctionEntryNode GetEntryNode()
	{
		CheckDestroyed();
		if (!GetEntryNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetEntryNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEntryNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEntryNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEntryNode_FunctionAddress, intPtr, GetEntryNode_ParamsSize);
		return UObjectMarshaler<URigVMFunctionEntryNode>.FromNative(IntPtr.Add(intPtr, GetEntryNode_ReturnValue_Offset), 0, GetEntryNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetDefaultFunctionLibrary")]
	public unsafe URigVMFunctionLibrary GetDefaultFunctionLibrary()
	{
		CheckDestroyed();
		if (!GetDefaultFunctionLibrary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetDefaultFunctionLibrary");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultFunctionLibrary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultFunctionLibrary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultFunctionLibrary_FunctionAddress, intPtr, GetDefaultFunctionLibrary_ParamsSize);
		return UObjectMarshaler<URigVMFunctionLibrary>.FromNative(IntPtr.Add(intPtr, GetDefaultFunctionLibrary_ReturnValue_Offset), 0, GetDefaultFunctionLibrary_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:GetContainedGraphs")]
	public unsafe List<URigVMGraph> GetContainedGraphs(bool bRecursive = false)
	{
		CheckDestroyed();
		if (!GetContainedGraphs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:GetContainedGraphs");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContainedGraphs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContainedGraphs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetContainedGraphs_bRecursive_Offset), 0, GetContainedGraphs_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContainedGraphs_FunctionAddress, intPtr, GetContainedGraphs_ParamsSize);
		List<URigVMGraph> result = new TArrayCopyMarshaler<URigVMGraph>(1, GetContainedGraphs_ReturnValue_PropertyAddress, CachedMarshalingDelegates<URigVMGraph, UObjectMarshaler<URigVMGraph>>.FromNative, CachedMarshalingDelegates<URigVMGraph, UObjectMarshaler<URigVMGraph>>.ToNative).FromNative(IntPtr.Add(intPtr, GetContainedGraphs_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetContainedGraphs_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:FindPin")]
	public unsafe URigVMPin FindPin(string InPinPath)
	{
		CheckDestroyed();
		if (!FindPin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:FindPin");
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

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:FindNodeByName")]
	public unsafe URigVMNode FindNodeByName(FName InNodeName)
	{
		CheckDestroyed();
		if (!FindNodeByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:FindNodeByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNodeByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNodeByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindNodeByName_InNodeName_Offset), 0, FindNodeByName_InNodeName_PropertyAddress.Address, InNodeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindNodeByName_FunctionAddress, intPtr, FindNodeByName_ParamsSize);
		return UObjectMarshaler<URigVMNode>.FromNative(IntPtr.Add(intPtr, FindNodeByName_ReturnValue_Offset), 0, FindNodeByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:FindNode")]
	public unsafe URigVMNode FindNode(string InNodePath)
	{
		CheckDestroyed();
		if (!FindNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:FindNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindNode_InNodePath_Offset), 0, FindNode_InNodePath_PropertyAddress.Address, InNodePath);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindNode_FunctionAddress, intPtr, FindNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindNode_InNodePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMNode>.FromNative(IntPtr.Add(intPtr, FindNode_ReturnValue_Offset), 0, FindNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/RigVMDeveloper.RigVMGraph:FindLink")]
	public unsafe URigVMLink FindLink(string InLinkPinPathRepresentation)
	{
		CheckDestroyed();
		if (!FindLink_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/RigVMDeveloper.RigVMGraph:FindLink");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindLink_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindLink_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindLink_InLinkPinPathRepresentation_Offset), 0, FindLink_InLinkPinPathRepresentation_PropertyAddress.Address, InLinkPinPathRepresentation);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindLink_FunctionAddress, intPtr, FindLink_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindLink_InLinkPinPathRepresentation_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<URigVMLink>.FromNative(IntPtr.Add(intPtr, FindLink_ReturnValue_Offset), 0, FindLink_ReturnValue_PropertyAddress.Address);
	}

	static URigVMGraph()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URigVMGraph)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URigVMGraph));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/RigVMDeveloper.RigVMGraph");
		SetDefaultFunctionLibrary_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDefaultFunctionLibrary");
		SetDefaultFunctionLibrary_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultFunctionLibrary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultFunctionLibrary_InFunctionLibrary_PropertyAddress, SetDefaultFunctionLibrary_FunctionAddress, "InFunctionLibrary");
		SetDefaultFunctionLibrary_InFunctionLibrary_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultFunctionLibrary_FunctionAddress, "InFunctionLibrary");
		SetDefaultFunctionLibrary_InFunctionLibrary_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultFunctionLibrary_FunctionAddress, "InFunctionLibrary", Classes.FObjectProperty);
		SetDefaultFunctionLibrary_IsValid = SetDefaultFunctionLibrary_FunctionAddress != IntPtr.Zero && SetDefaultFunctionLibrary_InFunctionLibrary_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:SetDefaultFunctionLibrary", SetDefaultFunctionLibrary_IsValid);
		IsTopLevelGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsTopLevelGraph");
		IsTopLevelGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTopLevelGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTopLevelGraph_ReturnValue_PropertyAddress, IsTopLevelGraph_FunctionAddress, "ReturnValue");
		IsTopLevelGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTopLevelGraph_FunctionAddress, "ReturnValue");
		IsTopLevelGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTopLevelGraph_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTopLevelGraph_IsValid = IsTopLevelGraph_FunctionAddress != IntPtr.Zero && IsTopLevelGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:IsTopLevelGraph", IsTopLevelGraph_IsValid);
		IsRootGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsRootGraph");
		IsRootGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRootGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRootGraph_ReturnValue_PropertyAddress, IsRootGraph_FunctionAddress, "ReturnValue");
		IsRootGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRootGraph_FunctionAddress, "ReturnValue");
		IsRootGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRootGraph_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRootGraph_IsValid = IsRootGraph_FunctionAddress != IntPtr.Zero && IsRootGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:IsRootGraph", IsRootGraph_IsValid);
		IsNodeSelected_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsNodeSelected");
		IsNodeSelected_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNodeSelected_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNodeSelected_InNodeName_PropertyAddress, IsNodeSelected_FunctionAddress, "InNodeName");
		IsNodeSelected_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(IsNodeSelected_FunctionAddress, "InNodeName");
		IsNodeSelected_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNodeSelected_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNodeSelected_ReturnValue_PropertyAddress, IsNodeSelected_FunctionAddress, "ReturnValue");
		IsNodeSelected_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNodeSelected_FunctionAddress, "ReturnValue");
		IsNodeSelected_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNodeSelected_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNodeSelected_IsValid = IsNodeSelected_FunctionAddress != IntPtr.Zero && IsNodeSelected_InNodeName_IsValid && IsNodeSelected_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:IsNodeSelected", IsNodeSelected_IsValid);
		GetVariableDescriptions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariableDescriptions");
		GetVariableDescriptions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariableDescriptions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariableDescriptions_ReturnValue_PropertyAddress, GetVariableDescriptions_FunctionAddress, "ReturnValue");
		GetVariableDescriptions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariableDescriptions_FunctionAddress, "ReturnValue");
		GetVariableDescriptions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariableDescriptions_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetVariableDescriptions_IsValid = GetVariableDescriptions_FunctionAddress != IntPtr.Zero && GetVariableDescriptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetVariableDescriptions", GetVariableDescriptions_IsValid);
		GetSelectNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSelectNodes");
		GetSelectNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectNodes_ReturnValue_PropertyAddress, GetSelectNodes_FunctionAddress, "ReturnValue");
		GetSelectNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectNodes_FunctionAddress, "ReturnValue");
		GetSelectNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectNodes_IsValid = GetSelectNodes_FunctionAddress != IntPtr.Zero && GetSelectNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetSelectNodes", GetSelectNodes_IsValid);
		GetRootGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRootGraph");
		GetRootGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootGraph_ReturnValue_PropertyAddress, GetRootGraph_FunctionAddress, "ReturnValue");
		GetRootGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootGraph_FunctionAddress, "ReturnValue");
		GetRootGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRootGraph_IsValid = GetRootGraph_FunctionAddress != IntPtr.Zero && GetRootGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetRootGraph", GetRootGraph_IsValid);
		GetReturnNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetReturnNode");
		GetReturnNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReturnNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReturnNode_ReturnValue_PropertyAddress, GetReturnNode_FunctionAddress, "ReturnValue");
		GetReturnNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReturnNode_FunctionAddress, "ReturnValue");
		GetReturnNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReturnNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetReturnNode_IsValid = GetReturnNode_FunctionAddress != IntPtr.Zero && GetReturnNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetReturnNode", GetReturnNode_IsValid);
		GetParentGraph_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParentGraph");
		GetParentGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentGraph_ReturnValue_PropertyAddress, GetParentGraph_FunctionAddress, "ReturnValue");
		GetParentGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentGraph_FunctionAddress, "ReturnValue");
		GetParentGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentGraph_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetParentGraph_IsValid = GetParentGraph_FunctionAddress != IntPtr.Zero && GetParentGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetParentGraph", GetParentGraph_IsValid);
		GetParameterDescriptions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParameterDescriptions");
		GetParameterDescriptions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParameterDescriptions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParameterDescriptions_ReturnValue_PropertyAddress, GetParameterDescriptions_FunctionAddress, "ReturnValue");
		GetParameterDescriptions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParameterDescriptions_FunctionAddress, "ReturnValue");
		GetParameterDescriptions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParameterDescriptions_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetParameterDescriptions_IsValid = GetParameterDescriptions_FunctionAddress != IntPtr.Zero && GetParameterDescriptions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetParameterDescriptions", GetParameterDescriptions_IsValid);
		GetOutputArguments_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOutputArguments");
		GetOutputArguments_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOutputArguments_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOutputArguments_ReturnValue_PropertyAddress, GetOutputArguments_FunctionAddress, "ReturnValue");
		GetOutputArguments_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputArguments_FunctionAddress, "ReturnValue");
		GetOutputArguments_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputArguments_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOutputArguments_IsValid = GetOutputArguments_FunctionAddress != IntPtr.Zero && GetOutputArguments_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetOutputArguments", GetOutputArguments_IsValid);
		GetNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodes");
		GetNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodes_ReturnValue_PropertyAddress, GetNodes_FunctionAddress, "ReturnValue");
		GetNodes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodes_FunctionAddress, "ReturnValue");
		GetNodes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNodes_IsValid = GetNodes_FunctionAddress != IntPtr.Zero && GetNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetNodes", GetNodes_IsValid);
		GetNodePath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodePath");
		GetNodePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodePath_ReturnValue_PropertyAddress, GetNodePath_FunctionAddress, "ReturnValue");
		GetNodePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodePath_FunctionAddress, "ReturnValue");
		GetNodePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodePath_IsValid = GetNodePath_FunctionAddress != IntPtr.Zero && GetNodePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetNodePath", GetNodePath_IsValid);
		GetLocalVariables_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLocalVariables");
		GetLocalVariables_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalVariables_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalVariables_bIncludeInputArguments_PropertyAddress, GetLocalVariables_FunctionAddress, "bIncludeInputArguments");
		GetLocalVariables_bIncludeInputArguments_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalVariables_FunctionAddress, "bIncludeInputArguments");
		GetLocalVariables_bIncludeInputArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalVariables_FunctionAddress, "bIncludeInputArguments", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalVariables_ReturnValue_PropertyAddress, GetLocalVariables_FunctionAddress, "ReturnValue");
		GetLocalVariables_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalVariables_FunctionAddress, "ReturnValue");
		GetLocalVariables_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalVariables_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLocalVariables_IsValid = GetLocalVariables_FunctionAddress != IntPtr.Zero && GetLocalVariables_bIncludeInputArguments_IsValid && GetLocalVariables_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetLocalVariables", GetLocalVariables_IsValid);
		GetLinks_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLinks");
		GetLinks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinks_ReturnValue_PropertyAddress, GetLinks_FunctionAddress, "ReturnValue");
		GetLinks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinks_FunctionAddress, "ReturnValue");
		GetLinks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinks_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLinks_IsValid = GetLinks_FunctionAddress != IntPtr.Zero && GetLinks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetLinks", GetLinks_IsValid);
		GetInputArguments_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInputArguments");
		GetInputArguments_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputArguments_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputArguments_ReturnValue_PropertyAddress, GetInputArguments_FunctionAddress, "ReturnValue");
		GetInputArguments_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputArguments_FunctionAddress, "ReturnValue");
		GetInputArguments_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputArguments_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputArguments_IsValid = GetInputArguments_FunctionAddress != IntPtr.Zero && GetInputArguments_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetInputArguments", GetInputArguments_IsValid);
		GetGraphName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGraphName");
		GetGraphName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGraphName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGraphName_ReturnValue_PropertyAddress, GetGraphName_FunctionAddress, "ReturnValue");
		GetGraphName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGraphName_FunctionAddress, "ReturnValue");
		GetGraphName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGraphName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGraphName_IsValid = GetGraphName_FunctionAddress != IntPtr.Zero && GetGraphName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetGraphName", GetGraphName_IsValid);
		GetEntryNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEntryNode");
		GetEntryNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEntryNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEntryNode_ReturnValue_PropertyAddress, GetEntryNode_FunctionAddress, "ReturnValue");
		GetEntryNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEntryNode_FunctionAddress, "ReturnValue");
		GetEntryNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEntryNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEntryNode_IsValid = GetEntryNode_FunctionAddress != IntPtr.Zero && GetEntryNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetEntryNode", GetEntryNode_IsValid);
		GetDefaultFunctionLibrary_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDefaultFunctionLibrary");
		GetDefaultFunctionLibrary_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultFunctionLibrary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultFunctionLibrary_ReturnValue_PropertyAddress, GetDefaultFunctionLibrary_FunctionAddress, "ReturnValue");
		GetDefaultFunctionLibrary_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultFunctionLibrary_FunctionAddress, "ReturnValue");
		GetDefaultFunctionLibrary_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultFunctionLibrary_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultFunctionLibrary_IsValid = GetDefaultFunctionLibrary_FunctionAddress != IntPtr.Zero && GetDefaultFunctionLibrary_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetDefaultFunctionLibrary", GetDefaultFunctionLibrary_IsValid);
		GetContainedGraphs_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetContainedGraphs");
		GetContainedGraphs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContainedGraphs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContainedGraphs_bRecursive_PropertyAddress, GetContainedGraphs_FunctionAddress, "bRecursive");
		GetContainedGraphs_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetContainedGraphs_FunctionAddress, "bRecursive");
		GetContainedGraphs_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContainedGraphs_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetContainedGraphs_ReturnValue_PropertyAddress, GetContainedGraphs_FunctionAddress, "ReturnValue");
		GetContainedGraphs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContainedGraphs_FunctionAddress, "ReturnValue");
		GetContainedGraphs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContainedGraphs_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetContainedGraphs_IsValid = GetContainedGraphs_FunctionAddress != IntPtr.Zero && GetContainedGraphs_bRecursive_IsValid && GetContainedGraphs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:GetContainedGraphs", GetContainedGraphs_IsValid);
		FindPin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindPin");
		FindPin_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPin_InPinPath_PropertyAddress, FindPin_FunctionAddress, "InPinPath");
		FindPin_InPinPath_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "InPinPath");
		FindPin_InPinPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "InPinPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPin_ReturnValue_PropertyAddress, FindPin_FunctionAddress, "ReturnValue");
		FindPin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPin_FunctionAddress, "ReturnValue");
		FindPin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPin_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindPin_IsValid = FindPin_FunctionAddress != IntPtr.Zero && FindPin_InPinPath_IsValid && FindPin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:FindPin", FindPin_IsValid);
		FindNodeByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindNodeByName");
		FindNodeByName_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNodeByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNodeByName_InNodeName_PropertyAddress, FindNodeByName_FunctionAddress, "InNodeName");
		FindNodeByName_InNodeName_Offset = NativeReflectionCached.GetPropertyOffset(FindNodeByName_FunctionAddress, "InNodeName");
		FindNodeByName_InNodeName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNodeByName_FunctionAddress, "InNodeName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNodeByName_ReturnValue_PropertyAddress, FindNodeByName_FunctionAddress, "ReturnValue");
		FindNodeByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNodeByName_FunctionAddress, "ReturnValue");
		FindNodeByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNodeByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindNodeByName_IsValid = FindNodeByName_FunctionAddress != IntPtr.Zero && FindNodeByName_InNodeName_IsValid && FindNodeByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:FindNodeByName", FindNodeByName_IsValid);
		FindNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindNode");
		FindNode_ParamsSize = NativeReflection.GetFunctionParamsSize(FindNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindNode_InNodePath_PropertyAddress, FindNode_FunctionAddress, "InNodePath");
		FindNode_InNodePath_Offset = NativeReflectionCached.GetPropertyOffset(FindNode_FunctionAddress, "InNodePath");
		FindNode_InNodePath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNode_FunctionAddress, "InNodePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindNode_ReturnValue_PropertyAddress, FindNode_FunctionAddress, "ReturnValue");
		FindNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindNode_FunctionAddress, "ReturnValue");
		FindNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindNode_IsValid = FindNode_FunctionAddress != IntPtr.Zero && FindNode_InNodePath_IsValid && FindNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:FindNode", FindNode_IsValid);
		FindLink_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindLink");
		FindLink_ParamsSize = NativeReflection.GetFunctionParamsSize(FindLink_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindLink_InLinkPinPathRepresentation_PropertyAddress, FindLink_FunctionAddress, "InLinkPinPathRepresentation");
		FindLink_InLinkPinPathRepresentation_Offset = NativeReflectionCached.GetPropertyOffset(FindLink_FunctionAddress, "InLinkPinPathRepresentation");
		FindLink_InLinkPinPathRepresentation_IsValid = NativeReflectionCached.ValidatePropertyClass(FindLink_FunctionAddress, "InLinkPinPathRepresentation", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindLink_ReturnValue_PropertyAddress, FindLink_FunctionAddress, "ReturnValue");
		FindLink_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindLink_FunctionAddress, "ReturnValue");
		FindLink_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindLink_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindLink_IsValid = FindLink_FunctionAddress != IntPtr.Zero && FindLink_InLinkPinPathRepresentation_IsValid && FindLink_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/RigVMDeveloper.RigVMGraph:FindLink", FindLink_IsValid);
	}
}
