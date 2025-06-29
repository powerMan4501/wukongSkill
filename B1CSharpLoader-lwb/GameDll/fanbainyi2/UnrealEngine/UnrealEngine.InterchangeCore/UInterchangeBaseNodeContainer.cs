using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer", "InterchangeCore", UnrealModuleType.Engine)]
public class UInterchangeBaseNodeContainer : UObject
{
	private static bool SetNodeParentUid_IsValid;

	private static IntPtr SetNodeParentUid_FunctionAddress;

	private static int SetNodeParentUid_ParamsSize;

	private static bool SetNodeParentUid_NodeUniqueID_IsValid;

	private static FFieldAddress SetNodeParentUid_NodeUniqueID_PropertyAddress;

	private static int SetNodeParentUid_NodeUniqueID_Offset;

	private static bool SetNodeParentUid_NewParentNodeUid_IsValid;

	private static FFieldAddress SetNodeParentUid_NewParentNodeUid_PropertyAddress;

	private static int SetNodeParentUid_NewParentNodeUid_Offset;

	private static bool SetNodeParentUid_ReturnValue_IsValid;

	private static FFieldAddress SetNodeParentUid_ReturnValue_PropertyAddress;

	private static int SetNodeParentUid_ReturnValue_Offset;

	private static bool SaveToFile_IsValid;

	private static IntPtr SaveToFile_FunctionAddress;

	private static int SaveToFile_ParamsSize;

	private static bool SaveToFile_Filename_IsValid;

	private static FFieldAddress SaveToFile_Filename_PropertyAddress;

	private static int SaveToFile_Filename_Offset;

	private static bool LoadFromFile_IsValid;

	private static IntPtr LoadFromFile_FunctionAddress;

	private static int LoadFromFile_ParamsSize;

	private static bool LoadFromFile_Filename_IsValid;

	private static FFieldAddress LoadFromFile_Filename_PropertyAddress;

	private static int LoadFromFile_Filename_Offset;

	private static bool IsNodeUidValid_IsValid;

	private static IntPtr IsNodeUidValid_FunctionAddress;

	private static int IsNodeUidValid_ParamsSize;

	private static bool IsNodeUidValid_NodeUniqueID_IsValid;

	private static FFieldAddress IsNodeUidValid_NodeUniqueID_PropertyAddress;

	private static int IsNodeUidValid_NodeUniqueID_Offset;

	private static bool IsNodeUidValid_ReturnValue_IsValid;

	private static FFieldAddress IsNodeUidValid_ReturnValue_PropertyAddress;

	private static int IsNodeUidValid_ReturnValue_Offset;

	private static bool GetRoots_IsValid;

	private static IntPtr GetRoots_FunctionAddress;

	private static int GetRoots_ParamsSize;

	private static bool GetRoots_RootNodes_IsValid;

	private static FFieldAddress GetRoots_RootNodes_PropertyAddress;

	private static int GetRoots_RootNodes_Offset;

	private static bool GetNodes_IsValid;

	private static IntPtr GetNodes_FunctionAddress;

	private static int GetNodes_ParamsSize;

	private static bool GetNodes_ClassNode_IsValid;

	private static FFieldAddress GetNodes_ClassNode_PropertyAddress;

	private static int GetNodes_ClassNode_Offset;

	private static bool GetNodes_OutNodes_IsValid;

	private static FFieldAddress GetNodes_OutNodes_PropertyAddress;

	private static int GetNodes_OutNodes_Offset;

	private static bool GetNodeChildrenUids_IsValid;

	private static IntPtr GetNodeChildrenUids_FunctionAddress;

	private static int GetNodeChildrenUids_ParamsSize;

	private static bool GetNodeChildrenUids_NodeUniqueID_IsValid;

	private static FFieldAddress GetNodeChildrenUids_NodeUniqueID_PropertyAddress;

	private static int GetNodeChildrenUids_NodeUniqueID_Offset;

	private static bool GetNodeChildrenUids_ReturnValue_IsValid;

	private static FFieldAddress GetNodeChildrenUids_ReturnValue_PropertyAddress;

	private static int GetNodeChildrenUids_ReturnValue_Offset;

	private static bool GetNodeChildrenCount_IsValid;

	private static IntPtr GetNodeChildrenCount_FunctionAddress;

	private static int GetNodeChildrenCount_ParamsSize;

	private static bool GetNodeChildrenCount_NodeUniqueID_IsValid;

	private static FFieldAddress GetNodeChildrenCount_NodeUniqueID_PropertyAddress;

	private static int GetNodeChildrenCount_NodeUniqueID_Offset;

	private static bool GetNodeChildrenCount_ReturnValue_IsValid;

	private static FFieldAddress GetNodeChildrenCount_ReturnValue_PropertyAddress;

	private static int GetNodeChildrenCount_ReturnValue_Offset;

	private static bool GetNodeChildren_IsValid;

	private static IntPtr GetNodeChildren_FunctionAddress;

	private static int GetNodeChildren_ParamsSize;

	private static bool GetNodeChildren_NodeUniqueID_IsValid;

	private static FFieldAddress GetNodeChildren_NodeUniqueID_PropertyAddress;

	private static int GetNodeChildren_NodeUniqueID_Offset;

	private static bool GetNodeChildren_ChildIndex_IsValid;

	private static FFieldAddress GetNodeChildren_ChildIndex_PropertyAddress;

	private static int GetNodeChildren_ChildIndex_Offset;

	private static bool GetNodeChildren_ReturnValue_IsValid;

	private static FFieldAddress GetNodeChildren_ReturnValue_PropertyAddress;

	private static int GetNodeChildren_ReturnValue_Offset;

	private static bool GetNode_IsValid;

	private static IntPtr GetNode_FunctionAddress;

	private static int GetNode_ParamsSize;

	private static bool GetNode_NodeUniqueID_IsValid;

	private static FFieldAddress GetNode_NodeUniqueID_PropertyAddress;

	private static int GetNode_NodeUniqueID_Offset;

	private static bool GetNode_ReturnValue_IsValid;

	private static FFieldAddress GetNode_ReturnValue_PropertyAddress;

	private static int GetNode_ReturnValue_Offset;

	private static bool AddNode_IsValid;

	private static IntPtr AddNode_FunctionAddress;

	private static int AddNode_ParamsSize;

	private static bool AddNode_Node_IsValid;

	private static FFieldAddress AddNode_Node_PropertyAddress;

	private static int AddNode_Node_Offset;

	private static bool AddNode_ReturnValue_IsValid;

	private static FFieldAddress AddNode_ReturnValue_PropertyAddress;

	private static int AddNode_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:SetNodeParentUid")]
	public unsafe bool SetNodeParentUid(string NodeUniqueID, string NewParentNodeUid)
	{
		CheckDestroyed();
		if (!SetNodeParentUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:SetNodeParentUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNodeParentUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNodeParentUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeParentUid_NodeUniqueID_Offset), 0, SetNodeParentUid_NodeUniqueID_PropertyAddress.Address, NodeUniqueID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNodeParentUid_NewParentNodeUid_Offset), 0, SetNodeParentUid_NewParentNodeUid_PropertyAddress.Address, NewParentNodeUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNodeParentUid_FunctionAddress, intPtr, SetNodeParentUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNodeParentUid_NodeUniqueID_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetNodeParentUid_NewParentNodeUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetNodeParentUid_ReturnValue_Offset), 0, SetNodeParentUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:SaveToFile")]
	public unsafe void SaveToFile(string Filename)
	{
		CheckDestroyed();
		if (!SaveToFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:SaveToFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveToFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveToFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveToFile_Filename_Offset), 0, SaveToFile_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeFunctionOptimized(base.Address, SaveToFile_FunctionAddress, intPtr, SaveToFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveToFile_Filename_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:LoadFromFile")]
	public unsafe void LoadFromFile(string Filename)
	{
		CheckDestroyed();
		if (!LoadFromFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:LoadFromFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadFromFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadFromFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadFromFile_Filename_Offset), 0, LoadFromFile_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadFromFile_FunctionAddress, intPtr, LoadFromFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadFromFile_Filename_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:IsNodeUidValid")]
	public unsafe bool IsNodeUidValid(string NodeUniqueID)
	{
		CheckDestroyed();
		if (!IsNodeUidValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:IsNodeUidValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNodeUidValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNodeUidValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsNodeUidValid_NodeUniqueID_Offset), 0, IsNodeUidValid_NodeUniqueID_PropertyAddress.Address, NodeUniqueID);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsNodeUidValid_FunctionAddress, intPtr, IsNodeUidValid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsNodeUidValid_NodeUniqueID_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNodeUidValid_ReturnValue_Offset), 0, IsNodeUidValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetRoots")]
	public unsafe void GetRoots(out List<string> RootNodes)
	{
		CheckDestroyed();
		if (!GetRoots_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetRoots");
			RootNodes = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRoots_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRoots_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRoots_FunctionAddress, intPtr, GetRoots_ParamsSize);
		RootNodes = new TArrayCopyMarshaler<string>(1, GetRoots_RootNodes_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetRoots_RootNodes_Offset));
		NativeReflection.DestroyValue_InContainer(GetRoots_RootNodes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodes")]
	public unsafe void GetNodes(TSubclassOf<UObject> ClassNode, out List<string> OutNodes)
	{
		CheckDestroyed();
		if (!GetNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodes");
			OutNodes = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetNodes_ClassNode_Offset), 0, GetNodes_ClassNode_PropertyAddress.Address, ClassNode);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodes_FunctionAddress, intPtr, GetNodes_ParamsSize);
		OutNodes = new TArrayCopyMarshaler<string>(1, GetNodes_OutNodes_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetNodes_OutNodes_Offset));
		NativeReflection.DestroyValue_InContainer(GetNodes_OutNodes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildrenUids")]
	public unsafe List<string> GetNodeChildrenUids(string NodeUniqueID)
	{
		CheckDestroyed();
		if (!GetNodeChildrenUids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildrenUids");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeChildrenUids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeChildrenUids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetNodeChildrenUids_NodeUniqueID_Offset), 0, GetNodeChildrenUids_NodeUniqueID_PropertyAddress.Address, NodeUniqueID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeChildrenUids_FunctionAddress, intPtr, GetNodeChildrenUids_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNodeChildrenUids_NodeUniqueID_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetNodeChildrenUids_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetNodeChildrenUids_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNodeChildrenUids_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildrenCount")]
	public unsafe int GetNodeChildrenCount(string NodeUniqueID)
	{
		CheckDestroyed();
		if (!GetNodeChildrenCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildrenCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeChildrenCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeChildrenCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetNodeChildrenCount_NodeUniqueID_Offset), 0, GetNodeChildrenCount_NodeUniqueID_PropertyAddress.Address, NodeUniqueID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeChildrenCount_FunctionAddress, intPtr, GetNodeChildrenCount_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNodeChildrenCount_NodeUniqueID_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNodeChildrenCount_ReturnValue_Offset), 0, GetNodeChildrenCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildren")]
	public unsafe UInterchangeBaseNode GetNodeChildren(string NodeUniqueID, int ChildIndex)
	{
		CheckDestroyed();
		if (!GetNodeChildren_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildren");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeChildren_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeChildren_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetNodeChildren_NodeUniqueID_Offset), 0, GetNodeChildren_NodeUniqueID_PropertyAddress.Address, NodeUniqueID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNodeChildren_ChildIndex_Offset), 0, GetNodeChildren_ChildIndex_PropertyAddress.Address, ChildIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeChildren_FunctionAddress, intPtr, GetNodeChildren_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNodeChildren_NodeUniqueID_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UInterchangeBaseNode>.FromNative(IntPtr.Add(intPtr, GetNodeChildren_ReturnValue_Offset), 0, GetNodeChildren_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNode")]
	public unsafe UInterchangeBaseNode GetNode(string NodeUniqueID)
	{
		CheckDestroyed();
		if (!GetNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetNode_NodeUniqueID_Offset), 0, GetNode_NodeUniqueID_PropertyAddress.Address, NodeUniqueID);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNode_FunctionAddress, intPtr, GetNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNode_NodeUniqueID_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UInterchangeBaseNode>.FromNative(IntPtr.Add(intPtr, GetNode_ReturnValue_Offset), 0, GetNode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNodeContainer:AddNode")]
	public unsafe string AddNode(UInterchangeBaseNode Node)
	{
		CheckDestroyed();
		if (!AddNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNodeContainer:AddNode");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNode>.ToNative(IntPtr.Add(intPtr, AddNode_Node_Offset), 0, AddNode_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddNode_FunctionAddress, intPtr, AddNode_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, AddNode_ReturnValue_Offset), 0, AddNode_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddNode_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UInterchangeBaseNodeContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeBaseNodeContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeBaseNodeContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeCore.InterchangeBaseNodeContainer");
		SetNodeParentUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNodeParentUid");
		SetNodeParentUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNodeParentUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNodeParentUid_NodeUniqueID_PropertyAddress, SetNodeParentUid_FunctionAddress, "NodeUniqueID");
		SetNodeParentUid_NodeUniqueID_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeParentUid_FunctionAddress, "NodeUniqueID");
		SetNodeParentUid_NodeUniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeParentUid_FunctionAddress, "NodeUniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeParentUid_NewParentNodeUid_PropertyAddress, SetNodeParentUid_FunctionAddress, "NewParentNodeUid");
		SetNodeParentUid_NewParentNodeUid_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeParentUid_FunctionAddress, "NewParentNodeUid");
		SetNodeParentUid_NewParentNodeUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeParentUid_FunctionAddress, "NewParentNodeUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNodeParentUid_ReturnValue_PropertyAddress, SetNodeParentUid_FunctionAddress, "ReturnValue");
		SetNodeParentUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNodeParentUid_FunctionAddress, "ReturnValue");
		SetNodeParentUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNodeParentUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetNodeParentUid_IsValid = SetNodeParentUid_FunctionAddress != IntPtr.Zero && SetNodeParentUid_NodeUniqueID_IsValid && SetNodeParentUid_NewParentNodeUid_IsValid && SetNodeParentUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:SetNodeParentUid", SetNodeParentUid_IsValid);
		SaveToFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SaveToFile");
		SaveToFile_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveToFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveToFile_Filename_PropertyAddress, SaveToFile_FunctionAddress, "Filename");
		SaveToFile_Filename_Offset = NativeReflectionCached.GetPropertyOffset(SaveToFile_FunctionAddress, "Filename");
		SaveToFile_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveToFile_FunctionAddress, "Filename", Classes.FStrProperty);
		SaveToFile_IsValid = SaveToFile_FunctionAddress != IntPtr.Zero && SaveToFile_Filename_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:SaveToFile", SaveToFile_IsValid);
		LoadFromFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LoadFromFile");
		LoadFromFile_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadFromFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadFromFile_Filename_PropertyAddress, LoadFromFile_FunctionAddress, "Filename");
		LoadFromFile_Filename_Offset = NativeReflectionCached.GetPropertyOffset(LoadFromFile_FunctionAddress, "Filename");
		LoadFromFile_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFromFile_FunctionAddress, "Filename", Classes.FStrProperty);
		LoadFromFile_IsValid = LoadFromFile_FunctionAddress != IntPtr.Zero && LoadFromFile_Filename_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:LoadFromFile", LoadFromFile_IsValid);
		IsNodeUidValid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsNodeUidValid");
		IsNodeUidValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNodeUidValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNodeUidValid_NodeUniqueID_PropertyAddress, IsNodeUidValid_FunctionAddress, "NodeUniqueID");
		IsNodeUidValid_NodeUniqueID_Offset = NativeReflectionCached.GetPropertyOffset(IsNodeUidValid_FunctionAddress, "NodeUniqueID");
		IsNodeUidValid_NodeUniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNodeUidValid_FunctionAddress, "NodeUniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNodeUidValid_ReturnValue_PropertyAddress, IsNodeUidValid_FunctionAddress, "ReturnValue");
		IsNodeUidValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNodeUidValid_FunctionAddress, "ReturnValue");
		IsNodeUidValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNodeUidValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNodeUidValid_IsValid = IsNodeUidValid_FunctionAddress != IntPtr.Zero && IsNodeUidValid_NodeUniqueID_IsValid && IsNodeUidValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:IsNodeUidValid", IsNodeUidValid_IsValid);
		GetRoots_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRoots");
		GetRoots_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRoots_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRoots_RootNodes_PropertyAddress, GetRoots_FunctionAddress, "RootNodes");
		GetRoots_RootNodes_Offset = NativeReflectionCached.GetPropertyOffset(GetRoots_FunctionAddress, "RootNodes");
		GetRoots_RootNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRoots_FunctionAddress, "RootNodes", Classes.FArrayProperty);
		GetRoots_IsValid = GetRoots_FunctionAddress != IntPtr.Zero && GetRoots_RootNodes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetRoots", GetRoots_IsValid);
		GetNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodes");
		GetNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodes_ClassNode_PropertyAddress, GetNodes_FunctionAddress, "ClassNode");
		GetNodes_ClassNode_Offset = NativeReflectionCached.GetPropertyOffset(GetNodes_FunctionAddress, "ClassNode");
		GetNodes_ClassNode_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodes_FunctionAddress, "ClassNode", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodes_OutNodes_PropertyAddress, GetNodes_FunctionAddress, "OutNodes");
		GetNodes_OutNodes_Offset = NativeReflectionCached.GetPropertyOffset(GetNodes_FunctionAddress, "OutNodes");
		GetNodes_OutNodes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodes_FunctionAddress, "OutNodes", Classes.FArrayProperty);
		GetNodes_IsValid = GetNodes_FunctionAddress != IntPtr.Zero && GetNodes_ClassNode_IsValid && GetNodes_OutNodes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodes", GetNodes_IsValid);
		GetNodeChildrenUids_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeChildrenUids");
		GetNodeChildrenUids_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeChildrenUids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeChildrenUids_NodeUniqueID_PropertyAddress, GetNodeChildrenUids_FunctionAddress, "NodeUniqueID");
		GetNodeChildrenUids_NodeUniqueID_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeChildrenUids_FunctionAddress, "NodeUniqueID");
		GetNodeChildrenUids_NodeUniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeChildrenUids_FunctionAddress, "NodeUniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodeChildrenUids_ReturnValue_PropertyAddress, GetNodeChildrenUids_FunctionAddress, "ReturnValue");
		GetNodeChildrenUids_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeChildrenUids_FunctionAddress, "ReturnValue");
		GetNodeChildrenUids_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeChildrenUids_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNodeChildrenUids_IsValid = GetNodeChildrenUids_FunctionAddress != IntPtr.Zero && GetNodeChildrenUids_NodeUniqueID_IsValid && GetNodeChildrenUids_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildrenUids", GetNodeChildrenUids_IsValid);
		GetNodeChildrenCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeChildrenCount");
		GetNodeChildrenCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeChildrenCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeChildrenCount_NodeUniqueID_PropertyAddress, GetNodeChildrenCount_FunctionAddress, "NodeUniqueID");
		GetNodeChildrenCount_NodeUniqueID_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeChildrenCount_FunctionAddress, "NodeUniqueID");
		GetNodeChildrenCount_NodeUniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeChildrenCount_FunctionAddress, "NodeUniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodeChildrenCount_ReturnValue_PropertyAddress, GetNodeChildrenCount_FunctionAddress, "ReturnValue");
		GetNodeChildrenCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeChildrenCount_FunctionAddress, "ReturnValue");
		GetNodeChildrenCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeChildrenCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNodeChildrenCount_IsValid = GetNodeChildrenCount_FunctionAddress != IntPtr.Zero && GetNodeChildrenCount_NodeUniqueID_IsValid && GetNodeChildrenCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildrenCount", GetNodeChildrenCount_IsValid);
		GetNodeChildren_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeChildren");
		GetNodeChildren_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeChildren_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeChildren_NodeUniqueID_PropertyAddress, GetNodeChildren_FunctionAddress, "NodeUniqueID");
		GetNodeChildren_NodeUniqueID_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeChildren_FunctionAddress, "NodeUniqueID");
		GetNodeChildren_NodeUniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeChildren_FunctionAddress, "NodeUniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodeChildren_ChildIndex_PropertyAddress, GetNodeChildren_FunctionAddress, "ChildIndex");
		GetNodeChildren_ChildIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeChildren_FunctionAddress, "ChildIndex");
		GetNodeChildren_ChildIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeChildren_FunctionAddress, "ChildIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNodeChildren_ReturnValue_PropertyAddress, GetNodeChildren_FunctionAddress, "ReturnValue");
		GetNodeChildren_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeChildren_FunctionAddress, "ReturnValue");
		GetNodeChildren_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeChildren_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNodeChildren_IsValid = GetNodeChildren_FunctionAddress != IntPtr.Zero && GetNodeChildren_NodeUniqueID_IsValid && GetNodeChildren_ChildIndex_IsValid && GetNodeChildren_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNodeChildren", GetNodeChildren_IsValid);
		GetNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNode");
		GetNode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNode_NodeUniqueID_PropertyAddress, GetNode_FunctionAddress, "NodeUniqueID");
		GetNode_NodeUniqueID_Offset = NativeReflectionCached.GetPropertyOffset(GetNode_FunctionAddress, "NodeUniqueID");
		GetNode_NodeUniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNode_FunctionAddress, "NodeUniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNode_ReturnValue_PropertyAddress, GetNode_FunctionAddress, "ReturnValue");
		GetNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNode_FunctionAddress, "ReturnValue");
		GetNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNode_IsValid = GetNode_FunctionAddress != IntPtr.Zero && GetNode_NodeUniqueID_IsValid && GetNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:GetNode", GetNode_IsValid);
		AddNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddNode");
		AddNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNode_Node_PropertyAddress, AddNode_FunctionAddress, "Node");
		AddNode_Node_Offset = NativeReflectionCached.GetPropertyOffset(AddNode_FunctionAddress, "Node");
		AddNode_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNode_FunctionAddress, "Node", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNode_ReturnValue_PropertyAddress, AddNode_FunctionAddress, "ReturnValue");
		AddNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNode_FunctionAddress, "ReturnValue");
		AddNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNode_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		AddNode_IsValid = AddNode_FunctionAddress != IntPtr.Zero && AddNode_Node_IsValid && AddNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNodeContainer:AddNode", AddNode_IsValid);
	}
}
