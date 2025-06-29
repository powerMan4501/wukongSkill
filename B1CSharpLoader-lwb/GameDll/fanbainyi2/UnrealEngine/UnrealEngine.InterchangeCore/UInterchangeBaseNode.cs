using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode", "InterchangeCore", UnrealModuleType.Engine)]
public class UInterchangeBaseNode : UObject
{
	private static bool SetParentUid_IsValid;

	private static IntPtr SetParentUid_FunctionAddress;

	private static int SetParentUid_ParamsSize;

	private static bool SetParentUid_ParentUid_IsValid;

	private static FFieldAddress SetParentUid_ParentUid_PropertyAddress;

	private static int SetParentUid_ParentUid_Offset;

	private static bool SetParentUid_ReturnValue_IsValid;

	private static FFieldAddress SetParentUid_ReturnValue_PropertyAddress;

	private static int SetParentUid_ReturnValue_Offset;

	private static bool SetEnabled_IsValid;

	private static IntPtr SetEnabled_FunctionAddress;

	private static int SetEnabled_ParamsSize;

	private static bool SetEnabled_bIsEnabled_IsValid;

	private static FFieldAddress SetEnabled_bIsEnabled_PropertyAddress;

	private static int SetEnabled_bIsEnabled_Offset;

	private static bool SetEnabled_ReturnValue_IsValid;

	private static FFieldAddress SetEnabled_ReturnValue_PropertyAddress;

	private static int SetEnabled_ReturnValue_Offset;

	private static bool SetDisplayLabel_IsValid;

	private static IntPtr SetDisplayLabel_FunctionAddress;

	private static int SetDisplayLabel_ParamsSize;

	private static bool SetDisplayLabel_DisplayName_IsValid;

	private static FFieldAddress SetDisplayLabel_DisplayName_PropertyAddress;

	private static int SetDisplayLabel_DisplayName_Offset;

	private static bool SetDisplayLabel_ReturnValue_IsValid;

	private static FFieldAddress SetDisplayLabel_ReturnValue_PropertyAddress;

	private static int SetDisplayLabel_ReturnValue_Offset;

	private static bool SetAssetName_IsValid;

	private static IntPtr SetAssetName_FunctionAddress;

	private static int SetAssetName_ParamsSize;

	private static bool SetAssetName_AssetName_IsValid;

	private static FFieldAddress SetAssetName_AssetName_PropertyAddress;

	private static int SetAssetName_AssetName_Offset;

	private static bool SetAssetName_ReturnValue_IsValid;

	private static FFieldAddress SetAssetName_ReturnValue_PropertyAddress;

	private static int SetAssetName_ReturnValue_Offset;

	private static bool RemoveTargetNodeUid_IsValid;

	private static IntPtr RemoveTargetNodeUid_FunctionAddress;

	private static int RemoveTargetNodeUid_ParamsSize;

	private static bool RemoveTargetNodeUid_AssetUid_IsValid;

	private static FFieldAddress RemoveTargetNodeUid_AssetUid_PropertyAddress;

	private static int RemoveTargetNodeUid_AssetUid_Offset;

	private static bool RemoveTargetNodeUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveTargetNodeUid_ReturnValue_PropertyAddress;

	private static int RemoveTargetNodeUid_ReturnValue_Offset;

	private static bool RemoveFactoryDependencyUid_IsValid;

	private static IntPtr RemoveFactoryDependencyUid_FunctionAddress;

	private static int RemoveFactoryDependencyUid_ParamsSize;

	private static bool RemoveFactoryDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress RemoveFactoryDependencyUid_DependencyUid_PropertyAddress;

	private static int RemoveFactoryDependencyUid_DependencyUid_Offset;

	private static bool RemoveFactoryDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveFactoryDependencyUid_ReturnValue_PropertyAddress;

	private static int RemoveFactoryDependencyUid_ReturnValue_Offset;

	private static bool RemoveAttribute_IsValid;

	private static IntPtr RemoveAttribute_FunctionAddress;

	private static int RemoveAttribute_ParamsSize;

	private static bool RemoveAttribute_NodeAttributeKey_IsValid;

	private static FFieldAddress RemoveAttribute_NodeAttributeKey_PropertyAddress;

	private static int RemoveAttribute_NodeAttributeKey_Offset;

	private static bool RemoveAttribute_ReturnValue_IsValid;

	private static FFieldAddress RemoveAttribute_ReturnValue_PropertyAddress;

	private static int RemoveAttribute_ReturnValue_Offset;

	private static bool IsEnabled_IsValid;

	private static IntPtr IsEnabled_FunctionAddress;

	private static int IsEnabled_ParamsSize;

	private static bool IsEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsEnabled_ReturnValue_PropertyAddress;

	private static int IsEnabled_ReturnValue_Offset;

	private static bool InitializeNode_IsValid;

	private static IntPtr InitializeNode_FunctionAddress;

	private static int InitializeNode_ParamsSize;

	private static bool InitializeNode_UniqueID_IsValid;

	private static FFieldAddress InitializeNode_UniqueID_PropertyAddress;

	private static int InitializeNode_UniqueID_Offset;

	private static bool InitializeNode_DisplayLabel_IsValid;

	private static FFieldAddress InitializeNode_DisplayLabel_PropertyAddress;

	private static int InitializeNode_DisplayLabel_Offset;

	private static bool InitializeNode_NodeContainerType_IsValid;

	private static FFieldAddress InitializeNode_NodeContainerType_PropertyAddress;

	private static int InitializeNode_NodeContainerType_Offset;

	private static bool GetUniqueID_IsValid;

	private static IntPtr GetUniqueID_FunctionAddress;

	private static int GetUniqueID_ParamsSize;

	private static bool GetUniqueID_ReturnValue_IsValid;

	private static FFieldAddress GetUniqueID_ReturnValue_PropertyAddress;

	private static int GetUniqueID_ReturnValue_Offset;

	private static bool GetTargetNodeUids_IsValid;

	private static IntPtr GetTargetNodeUids_FunctionAddress;

	private static int GetTargetNodeUids_ParamsSize;

	private static bool GetTargetNodeUids_OutTargetAssets_IsValid;

	private static FFieldAddress GetTargetNodeUids_OutTargetAssets_PropertyAddress;

	private static int GetTargetNodeUids_OutTargetAssets_Offset;

	private static bool GetTargetNodeCount_IsValid;

	private static IntPtr GetTargetNodeCount_FunctionAddress;

	private static int GetTargetNodeCount_ParamsSize;

	private static bool GetTargetNodeCount_ReturnValue_IsValid;

	private static FFieldAddress GetTargetNodeCount_ReturnValue_PropertyAddress;

	private static int GetTargetNodeCount_ReturnValue_Offset;

	private static bool GetStringAttribute_IsValid;

	private static IntPtr GetStringAttribute_FunctionAddress;

	private static int GetStringAttribute_ParamsSize;

	private static bool GetStringAttribute_NodeAttributeKey_IsValid;

	private static FFieldAddress GetStringAttribute_NodeAttributeKey_PropertyAddress;

	private static int GetStringAttribute_NodeAttributeKey_Offset;

	private static bool GetStringAttribute_OutValue_IsValid;

	private static FFieldAddress GetStringAttribute_OutValue_PropertyAddress;

	private static int GetStringAttribute_OutValue_Offset;

	private static bool GetStringAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetStringAttribute_ReturnValue_PropertyAddress;

	private static int GetStringAttribute_ReturnValue_Offset;

	private static bool GetParentUid_IsValid;

	private static IntPtr GetParentUid_FunctionAddress;

	private static int GetParentUid_ParamsSize;

	private static bool GetParentUid_ReturnValue_IsValid;

	private static FFieldAddress GetParentUid_ReturnValue_PropertyAddress;

	private static int GetParentUid_ReturnValue_Offset;

	private static bool GetNodeContainerType_IsValid;

	private static IntPtr GetNodeContainerType_FunctionAddress;

	private static int GetNodeContainerType_ParamsSize;

	private static bool GetNodeContainerType_ReturnValue_IsValid;

	private static FFieldAddress GetNodeContainerType_ReturnValue_PropertyAddress;

	private static int GetNodeContainerType_ReturnValue_Offset;

	private static bool GetInt32Attribute_IsValid;

	private static IntPtr GetInt32Attribute_FunctionAddress;

	private static int GetInt32Attribute_ParamsSize;

	private static bool GetInt32Attribute_NodeAttributeKey_IsValid;

	private static FFieldAddress GetInt32Attribute_NodeAttributeKey_PropertyAddress;

	private static int GetInt32Attribute_NodeAttributeKey_Offset;

	private static bool GetInt32Attribute_OutValue_IsValid;

	private static FFieldAddress GetInt32Attribute_OutValue_PropertyAddress;

	private static int GetInt32Attribute_OutValue_Offset;

	private static bool GetInt32Attribute_ReturnValue_IsValid;

	private static FFieldAddress GetInt32Attribute_ReturnValue_PropertyAddress;

	private static int GetInt32Attribute_ReturnValue_Offset;

	private static bool GetFloatAttribute_IsValid;

	private static IntPtr GetFloatAttribute_FunctionAddress;

	private static int GetFloatAttribute_ParamsSize;

	private static bool GetFloatAttribute_NodeAttributeKey_IsValid;

	private static FFieldAddress GetFloatAttribute_NodeAttributeKey_PropertyAddress;

	private static int GetFloatAttribute_NodeAttributeKey_Offset;

	private static bool GetFloatAttribute_OutValue_IsValid;

	private static FFieldAddress GetFloatAttribute_OutValue_PropertyAddress;

	private static int GetFloatAttribute_OutValue_Offset;

	private static bool GetFloatAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetFloatAttribute_ReturnValue_PropertyAddress;

	private static int GetFloatAttribute_ReturnValue_Offset;

	private static bool GetFactoryDependency_IsValid;

	private static IntPtr GetFactoryDependency_FunctionAddress;

	private static int GetFactoryDependency_ParamsSize;

	private static bool GetFactoryDependency_Index_IsValid;

	private static FFieldAddress GetFactoryDependency_Index_PropertyAddress;

	private static int GetFactoryDependency_Index_Offset;

	private static bool GetFactoryDependency_OutDependency_IsValid;

	private static FFieldAddress GetFactoryDependency_OutDependency_PropertyAddress;

	private static int GetFactoryDependency_OutDependency_Offset;

	private static bool GetFactoryDependenciesCount_IsValid;

	private static IntPtr GetFactoryDependenciesCount_FunctionAddress;

	private static int GetFactoryDependenciesCount_ParamsSize;

	private static bool GetFactoryDependenciesCount_ReturnValue_IsValid;

	private static FFieldAddress GetFactoryDependenciesCount_ReturnValue_PropertyAddress;

	private static int GetFactoryDependenciesCount_ReturnValue_Offset;

	private static bool GetFactoryDependencies_IsValid;

	private static IntPtr GetFactoryDependencies_FunctionAddress;

	private static int GetFactoryDependencies_ParamsSize;

	private static bool GetFactoryDependencies_OutDependencies_IsValid;

	private static FFieldAddress GetFactoryDependencies_OutDependencies_PropertyAddress;

	private static int GetFactoryDependencies_OutDependencies_Offset;

	private static bool GetDisplayLabel_IsValid;

	private static IntPtr GetDisplayLabel_FunctionAddress;

	private static int GetDisplayLabel_ParamsSize;

	private static bool GetDisplayLabel_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayLabel_ReturnValue_PropertyAddress;

	private static int GetDisplayLabel_ReturnValue_Offset;

	private static bool GetBooleanAttribute_IsValid;

	private static IntPtr GetBooleanAttribute_FunctionAddress;

	private static int GetBooleanAttribute_ParamsSize;

	private static bool GetBooleanAttribute_NodeAttributeKey_IsValid;

	private static FFieldAddress GetBooleanAttribute_NodeAttributeKey_PropertyAddress;

	private static int GetBooleanAttribute_NodeAttributeKey_Offset;

	private static bool GetBooleanAttribute_OutValue_IsValid;

	private static FFieldAddress GetBooleanAttribute_OutValue_PropertyAddress;

	private static int GetBooleanAttribute_OutValue_Offset;

	private static bool GetBooleanAttribute_ReturnValue_IsValid;

	private static FFieldAddress GetBooleanAttribute_ReturnValue_PropertyAddress;

	private static int GetBooleanAttribute_ReturnValue_Offset;

	private static bool GetAssetName_IsValid;

	private static IntPtr GetAssetName_FunctionAddress;

	private static int GetAssetName_ParamsSize;

	private static bool GetAssetName_ReturnValue_IsValid;

	private static FFieldAddress GetAssetName_ReturnValue_PropertyAddress;

	private static int GetAssetName_ReturnValue_Offset;

	private static bool AddTargetNodeUid_IsValid;

	private static IntPtr AddTargetNodeUid_FunctionAddress;

	private static int AddTargetNodeUid_ParamsSize;

	private static bool AddTargetNodeUid_AssetUid_IsValid;

	private static FFieldAddress AddTargetNodeUid_AssetUid_PropertyAddress;

	private static int AddTargetNodeUid_AssetUid_Offset;

	private static bool AddTargetNodeUid_ReturnValue_IsValid;

	private static FFieldAddress AddTargetNodeUid_ReturnValue_PropertyAddress;

	private static int AddTargetNodeUid_ReturnValue_Offset;

	private static bool AddStringAttribute_IsValid;

	private static IntPtr AddStringAttribute_FunctionAddress;

	private static int AddStringAttribute_ParamsSize;

	private static bool AddStringAttribute_NodeAttributeKey_IsValid;

	private static FFieldAddress AddStringAttribute_NodeAttributeKey_PropertyAddress;

	private static int AddStringAttribute_NodeAttributeKey_Offset;

	private static bool AddStringAttribute_Value_IsValid;

	private static FFieldAddress AddStringAttribute_Value_PropertyAddress;

	private static int AddStringAttribute_Value_Offset;

	private static bool AddStringAttribute_ReturnValue_IsValid;

	private static FFieldAddress AddStringAttribute_ReturnValue_PropertyAddress;

	private static int AddStringAttribute_ReturnValue_Offset;

	private static bool AddInt32Attribute_IsValid;

	private static IntPtr AddInt32Attribute_FunctionAddress;

	private static int AddInt32Attribute_ParamsSize;

	private static bool AddInt32Attribute_NodeAttributeKey_IsValid;

	private static FFieldAddress AddInt32Attribute_NodeAttributeKey_PropertyAddress;

	private static int AddInt32Attribute_NodeAttributeKey_Offset;

	private static bool AddInt32Attribute_Value_IsValid;

	private static FFieldAddress AddInt32Attribute_Value_PropertyAddress;

	private static int AddInt32Attribute_Value_Offset;

	private static bool AddInt32Attribute_ReturnValue_IsValid;

	private static FFieldAddress AddInt32Attribute_ReturnValue_PropertyAddress;

	private static int AddInt32Attribute_ReturnValue_Offset;

	private static bool AddFloatAttribute_IsValid;

	private static IntPtr AddFloatAttribute_FunctionAddress;

	private static int AddFloatAttribute_ParamsSize;

	private static bool AddFloatAttribute_NodeAttributeKey_IsValid;

	private static FFieldAddress AddFloatAttribute_NodeAttributeKey_PropertyAddress;

	private static int AddFloatAttribute_NodeAttributeKey_Offset;

	private static bool AddFloatAttribute_Value_IsValid;

	private static FFieldAddress AddFloatAttribute_Value_PropertyAddress;

	private static int AddFloatAttribute_Value_Offset;

	private static bool AddFloatAttribute_ReturnValue_IsValid;

	private static FFieldAddress AddFloatAttribute_ReturnValue_PropertyAddress;

	private static int AddFloatAttribute_ReturnValue_Offset;

	private static bool AddFactoryDependencyUid_IsValid;

	private static IntPtr AddFactoryDependencyUid_FunctionAddress;

	private static int AddFactoryDependencyUid_ParamsSize;

	private static bool AddFactoryDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress AddFactoryDependencyUid_DependencyUid_PropertyAddress;

	private static int AddFactoryDependencyUid_DependencyUid_Offset;

	private static bool AddFactoryDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress AddFactoryDependencyUid_ReturnValue_PropertyAddress;

	private static int AddFactoryDependencyUid_ReturnValue_Offset;

	private static bool AddBooleanAttribute_IsValid;

	private static IntPtr AddBooleanAttribute_FunctionAddress;

	private static int AddBooleanAttribute_ParamsSize;

	private static bool AddBooleanAttribute_NodeAttributeKey_IsValid;

	private static FFieldAddress AddBooleanAttribute_NodeAttributeKey_PropertyAddress;

	private static int AddBooleanAttribute_NodeAttributeKey_Offset;

	private static bool AddBooleanAttribute_Value_IsValid;

	private static FFieldAddress AddBooleanAttribute_Value_PropertyAddress;

	private static int AddBooleanAttribute_Value_Offset;

	private static bool AddBooleanAttribute_ReturnValue_IsValid;

	private static FFieldAddress AddBooleanAttribute_ReturnValue_PropertyAddress;

	private static int AddBooleanAttribute_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:SetParentUid")]
	public unsafe bool SetParentUid(string ParentUid)
	{
		CheckDestroyed();
		if (!SetParentUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:SetParentUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParentUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParentUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetParentUid_ParentUid_Offset), 0, SetParentUid_ParentUid_PropertyAddress.Address, ParentUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetParentUid_FunctionAddress, intPtr, SetParentUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetParentUid_ParentUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetParentUid_ReturnValue_Offset), 0, SetParentUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:SetEnabled")]
	public unsafe bool SetEnabled(bool bIsEnabled)
	{
		CheckDestroyed();
		if (!SetEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:SetEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnabled_bIsEnabled_Offset), 0, SetEnabled_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnabled_FunctionAddress, intPtr, SetEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetEnabled_ReturnValue_Offset), 0, SetEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:SetDisplayLabel")]
	public unsafe bool SetDisplayLabel(string DisplayName)
	{
		CheckDestroyed();
		if (!SetDisplayLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:SetDisplayLabel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisplayLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisplayLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetDisplayLabel_DisplayName_Offset), 0, SetDisplayLabel_DisplayName_PropertyAddress.Address, DisplayName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDisplayLabel_FunctionAddress, intPtr, SetDisplayLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDisplayLabel_DisplayName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetDisplayLabel_ReturnValue_Offset), 0, SetDisplayLabel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:SetAssetName")]
	public unsafe bool SetAssetName(string AssetName)
	{
		CheckDestroyed();
		if (!SetAssetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:SetAssetName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAssetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAssetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetAssetName_AssetName_Offset), 0, SetAssetName_AssetName_PropertyAddress.Address, AssetName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAssetName_FunctionAddress, intPtr, SetAssetName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAssetName_AssetName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetAssetName_ReturnValue_Offset), 0, SetAssetName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:RemoveTargetNodeUid")]
	public unsafe bool RemoveTargetNodeUid(string AssetUid)
	{
		CheckDestroyed();
		if (!RemoveTargetNodeUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:RemoveTargetNodeUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTargetNodeUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTargetNodeUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveTargetNodeUid_AssetUid_Offset), 0, RemoveTargetNodeUid_AssetUid_PropertyAddress.Address, AssetUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTargetNodeUid_FunctionAddress, intPtr, RemoveTargetNodeUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveTargetNodeUid_AssetUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveTargetNodeUid_ReturnValue_Offset), 0, RemoveTargetNodeUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:RemoveFactoryDependencyUid")]
	public unsafe bool RemoveFactoryDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!RemoveFactoryDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:RemoveFactoryDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveFactoryDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveFactoryDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveFactoryDependencyUid_DependencyUid_Offset), 0, RemoveFactoryDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveFactoryDependencyUid_FunctionAddress, intPtr, RemoveFactoryDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveFactoryDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveFactoryDependencyUid_ReturnValue_Offset), 0, RemoveFactoryDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:RemoveAttribute")]
	public unsafe bool RemoveAttribute(string NodeAttributeKey)
	{
		CheckDestroyed();
		if (!RemoveAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:RemoveAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveAttribute_NodeAttributeKey_Offset), 0, RemoveAttribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAttribute_FunctionAddress, intPtr, RemoveAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveAttribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAttribute_ReturnValue_Offset), 0, RemoveAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:IsEnabled")]
	public unsafe bool IsEnabled()
	{
		CheckDestroyed();
		if (!IsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:IsEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsEnabled_FunctionAddress, intPtr, IsEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEnabled_ReturnValue_Offset), 0, IsEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:InitializeNode")]
	public unsafe void InitializeNode(string UniqueID, string DisplayLabel, EInterchangeNodeContainerType NodeContainerType)
	{
		CheckDestroyed();
		if (!InitializeNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:InitializeNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeNode_UniqueID_Offset), 0, InitializeNode_UniqueID_PropertyAddress.Address, UniqueID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeNode_DisplayLabel_Offset), 0, InitializeNode_DisplayLabel_PropertyAddress.Address, DisplayLabel);
		EnumMarshaler<EInterchangeNodeContainerType>.ToNative(IntPtr.Add(intPtr, InitializeNode_NodeContainerType_Offset), 0, InitializeNode_NodeContainerType_PropertyAddress.Address, NodeContainerType);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeNode_FunctionAddress, intPtr, InitializeNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializeNode_UniqueID_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeNode_DisplayLabel_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetUniqueID")]
	public new unsafe string GetUniqueID()
	{
		CheckDestroyed();
		if (!GetUniqueID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetUniqueID");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniqueID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniqueID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUniqueID_FunctionAddress, intPtr, GetUniqueID_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUniqueID_ReturnValue_Offset), 0, GetUniqueID_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUniqueID_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetTargetNodeUids")]
	public unsafe void GetTargetNodeUids(out List<string> OutTargetAssets)
	{
		CheckDestroyed();
		if (!GetTargetNodeUids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetTargetNodeUids");
			OutTargetAssets = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTargetNodeUids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTargetNodeUids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTargetNodeUids_FunctionAddress, intPtr, GetTargetNodeUids_ParamsSize);
		OutTargetAssets = new TArrayCopyMarshaler<string>(1, GetTargetNodeUids_OutTargetAssets_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetTargetNodeUids_OutTargetAssets_Offset));
		NativeReflection.DestroyValue_InContainer(GetTargetNodeUids_OutTargetAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetTargetNodeCount")]
	public unsafe int GetTargetNodeCount()
	{
		CheckDestroyed();
		if (!GetTargetNodeCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetTargetNodeCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTargetNodeCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTargetNodeCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTargetNodeCount_FunctionAddress, intPtr, GetTargetNodeCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTargetNodeCount_ReturnValue_Offset), 0, GetTargetNodeCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetStringAttribute")]
	public unsafe bool GetStringAttribute(string NodeAttributeKey, out string OutValue)
	{
		CheckDestroyed();
		if (!GetStringAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetStringAttribute");
			OutValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStringAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStringAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetStringAttribute_NodeAttributeKey_Offset), 0, GetStringAttribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStringAttribute_FunctionAddress, intPtr, GetStringAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetStringAttribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		OutValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStringAttribute_OutValue_Offset), 0, GetStringAttribute_OutValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStringAttribute_OutValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetStringAttribute_ReturnValue_Offset), 0, GetStringAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetParentUid")]
	public unsafe string GetParentUid()
	{
		CheckDestroyed();
		if (!GetParentUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetParentUid");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParentUid_FunctionAddress, intPtr, GetParentUid_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetParentUid_ReturnValue_Offset), 0, GetParentUid_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetParentUid_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetNodeContainerType")]
	public unsafe EInterchangeNodeContainerType GetNodeContainerType()
	{
		CheckDestroyed();
		if (!GetNodeContainerType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetNodeContainerType");
			return EInterchangeNodeContainerType.NodeContainerType_None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNodeContainerType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNodeContainerType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNodeContainerType_FunctionAddress, intPtr, GetNodeContainerType_ParamsSize);
		return EnumMarshaler<EInterchangeNodeContainerType>.FromNative(IntPtr.Add(intPtr, GetNodeContainerType_ReturnValue_Offset), 0, GetNodeContainerType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetInt32Attribute")]
	public unsafe bool GetInt32Attribute(string NodeAttributeKey, out int OutValue)
	{
		CheckDestroyed();
		if (!GetInt32Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetInt32Attribute");
			OutValue = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInt32Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInt32Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetInt32Attribute_NodeAttributeKey_Offset), 0, GetInt32Attribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInt32Attribute_FunctionAddress, intPtr, GetInt32Attribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInt32Attribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		OutValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInt32Attribute_OutValue_Offset), 0, GetInt32Attribute_OutValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetInt32Attribute_ReturnValue_Offset), 0, GetInt32Attribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetFloatAttribute")]
	public unsafe bool GetFloatAttribute(string NodeAttributeKey, out float OutValue)
	{
		CheckDestroyed();
		if (!GetFloatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetFloatAttribute");
			OutValue = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFloatAttribute_NodeAttributeKey_Offset), 0, GetFloatAttribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFloatAttribute_FunctionAddress, intPtr, GetFloatAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFloatAttribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		OutValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatAttribute_OutValue_Offset), 0, GetFloatAttribute_OutValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetFloatAttribute_ReturnValue_Offset), 0, GetFloatAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependency")]
	public unsafe void GetFactoryDependency(int Index, out string OutDependency)
	{
		CheckDestroyed();
		if (!GetFactoryDependency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependency");
			OutDependency = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFactoryDependency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFactoryDependency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetFactoryDependency_Index_Offset), 0, GetFactoryDependency_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFactoryDependency_FunctionAddress, intPtr, GetFactoryDependency_ParamsSize);
		OutDependency = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFactoryDependency_OutDependency_Offset), 0, GetFactoryDependency_OutDependency_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFactoryDependency_OutDependency_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependenciesCount")]
	public unsafe int GetFactoryDependenciesCount()
	{
		CheckDestroyed();
		if (!GetFactoryDependenciesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependenciesCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFactoryDependenciesCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFactoryDependenciesCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFactoryDependenciesCount_FunctionAddress, intPtr, GetFactoryDependenciesCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFactoryDependenciesCount_ReturnValue_Offset), 0, GetFactoryDependenciesCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependencies")]
	public unsafe void GetFactoryDependencies(out List<string> OutDependencies)
	{
		CheckDestroyed();
		if (!GetFactoryDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependencies");
			OutDependencies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFactoryDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFactoryDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFactoryDependencies_FunctionAddress, intPtr, GetFactoryDependencies_ParamsSize);
		OutDependencies = new TArrayCopyMarshaler<string>(1, GetFactoryDependencies_OutDependencies_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetFactoryDependencies_OutDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(GetFactoryDependencies_OutDependencies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetDisplayLabel")]
	public unsafe string GetDisplayLabel()
	{
		CheckDestroyed();
		if (!GetDisplayLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetDisplayLabel");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayLabel_FunctionAddress, intPtr, GetDisplayLabel_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayLabel_ReturnValue_Offset), 0, GetDisplayLabel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDisplayLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetBooleanAttribute")]
	public unsafe bool GetBooleanAttribute(string NodeAttributeKey, out bool OutValue)
	{
		CheckDestroyed();
		if (!GetBooleanAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetBooleanAttribute");
			OutValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBooleanAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBooleanAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetBooleanAttribute_NodeAttributeKey_Offset), 0, GetBooleanAttribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBooleanAttribute_FunctionAddress, intPtr, GetBooleanAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBooleanAttribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		OutValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBooleanAttribute_OutValue_Offset), 0, GetBooleanAttribute_OutValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBooleanAttribute_ReturnValue_Offset), 0, GetBooleanAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:GetAssetName")]
	public unsafe string GetAssetName()
	{
		CheckDestroyed();
		if (!GetAssetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:GetAssetName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetName_FunctionAddress, intPtr, GetAssetName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetName_ReturnValue_Offset), 0, GetAssetName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAssetName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:AddTargetNodeUid")]
	public unsafe bool AddTargetNodeUid(string AssetUid)
	{
		CheckDestroyed();
		if (!AddTargetNodeUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:AddTargetNodeUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTargetNodeUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTargetNodeUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddTargetNodeUid_AssetUid_Offset), 0, AddTargetNodeUid_AssetUid_PropertyAddress.Address, AssetUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTargetNodeUid_FunctionAddress, intPtr, AddTargetNodeUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTargetNodeUid_AssetUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddTargetNodeUid_ReturnValue_Offset), 0, AddTargetNodeUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:AddStringAttribute")]
	public unsafe bool AddStringAttribute(string NodeAttributeKey, string Value)
	{
		CheckDestroyed();
		if (!AddStringAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:AddStringAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddStringAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddStringAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddStringAttribute_NodeAttributeKey_Offset), 0, AddStringAttribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddStringAttribute_Value_Offset), 0, AddStringAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddStringAttribute_FunctionAddress, intPtr, AddStringAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddStringAttribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddStringAttribute_Value_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddStringAttribute_ReturnValue_Offset), 0, AddStringAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:AddInt32Attribute")]
	public unsafe bool AddInt32Attribute(string NodeAttributeKey, int Value)
	{
		CheckDestroyed();
		if (!AddInt32Attribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:AddInt32Attribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInt32Attribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInt32Attribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddInt32Attribute_NodeAttributeKey_Offset), 0, AddInt32Attribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddInt32Attribute_Value_Offset), 0, AddInt32Attribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInt32Attribute_FunctionAddress, intPtr, AddInt32Attribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddInt32Attribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddInt32Attribute_ReturnValue_Offset), 0, AddInt32Attribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:AddFloatAttribute")]
	public unsafe bool AddFloatAttribute(string NodeAttributeKey, float Value)
	{
		CheckDestroyed();
		if (!AddFloatAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:AddFloatAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFloatAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFloatAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFloatAttribute_NodeAttributeKey_Offset), 0, AddFloatAttribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddFloatAttribute_Value_Offset), 0, AddFloatAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddFloatAttribute_FunctionAddress, intPtr, AddFloatAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFloatAttribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddFloatAttribute_ReturnValue_Offset), 0, AddFloatAttribute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:AddFactoryDependencyUid")]
	public unsafe bool AddFactoryDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!AddFactoryDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:AddFactoryDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFactoryDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFactoryDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFactoryDependencyUid_DependencyUid_Offset), 0, AddFactoryDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddFactoryDependencyUid_FunctionAddress, intPtr, AddFactoryDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFactoryDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddFactoryDependencyUid_ReturnValue_Offset), 0, AddFactoryDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeBaseNode:AddBooleanAttribute")]
	public unsafe bool AddBooleanAttribute(string NodeAttributeKey, bool Value)
	{
		CheckDestroyed();
		if (!AddBooleanAttribute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeBaseNode:AddBooleanAttribute");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBooleanAttribute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBooleanAttribute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddBooleanAttribute_NodeAttributeKey_Offset), 0, AddBooleanAttribute_NodeAttributeKey_PropertyAddress.Address, NodeAttributeKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBooleanAttribute_Value_Offset), 0, AddBooleanAttribute_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddBooleanAttribute_FunctionAddress, intPtr, AddBooleanAttribute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBooleanAttribute_NodeAttributeKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddBooleanAttribute_ReturnValue_Offset), 0, AddBooleanAttribute_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeBaseNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeBaseNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeBaseNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeCore.InterchangeBaseNode");
		SetParentUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetParentUid");
		SetParentUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParentUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParentUid_ParentUid_PropertyAddress, SetParentUid_FunctionAddress, "ParentUid");
		SetParentUid_ParentUid_Offset = NativeReflectionCached.GetPropertyOffset(SetParentUid_FunctionAddress, "ParentUid");
		SetParentUid_ParentUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentUid_FunctionAddress, "ParentUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParentUid_ReturnValue_PropertyAddress, SetParentUid_FunctionAddress, "ReturnValue");
		SetParentUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetParentUid_FunctionAddress, "ReturnValue");
		SetParentUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParentUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetParentUid_IsValid = SetParentUid_FunctionAddress != IntPtr.Zero && SetParentUid_ParentUid_IsValid && SetParentUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:SetParentUid", SetParentUid_IsValid);
		SetEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEnabled");
		SetEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnabled_bIsEnabled_PropertyAddress, SetEnabled_FunctionAddress, "bIsEnabled");
		SetEnabled_bIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnabled_FunctionAddress, "bIsEnabled");
		SetEnabled_bIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnabled_FunctionAddress, "bIsEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnabled_ReturnValue_PropertyAddress, SetEnabled_FunctionAddress, "ReturnValue");
		SetEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEnabled_FunctionAddress, "ReturnValue");
		SetEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetEnabled_IsValid = SetEnabled_FunctionAddress != IntPtr.Zero && SetEnabled_bIsEnabled_IsValid && SetEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:SetEnabled", SetEnabled_IsValid);
		SetDisplayLabel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDisplayLabel");
		SetDisplayLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayLabel_DisplayName_PropertyAddress, SetDisplayLabel_FunctionAddress, "DisplayName");
		SetDisplayLabel_DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayLabel_FunctionAddress, "DisplayName");
		SetDisplayLabel_DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayLabel_FunctionAddress, "DisplayName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayLabel_ReturnValue_PropertyAddress, SetDisplayLabel_FunctionAddress, "ReturnValue");
		SetDisplayLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayLabel_FunctionAddress, "ReturnValue");
		SetDisplayLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayLabel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetDisplayLabel_IsValid = SetDisplayLabel_FunctionAddress != IntPtr.Zero && SetDisplayLabel_DisplayName_IsValid && SetDisplayLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:SetDisplayLabel", SetDisplayLabel_IsValid);
		SetAssetName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAssetName");
		SetAssetName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAssetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAssetName_AssetName_PropertyAddress, SetAssetName_FunctionAddress, "AssetName");
		SetAssetName_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(SetAssetName_FunctionAddress, "AssetName");
		SetAssetName_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAssetName_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAssetName_ReturnValue_PropertyAddress, SetAssetName_FunctionAddress, "ReturnValue");
		SetAssetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAssetName_FunctionAddress, "ReturnValue");
		SetAssetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAssetName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetAssetName_IsValid = SetAssetName_FunctionAddress != IntPtr.Zero && SetAssetName_AssetName_IsValid && SetAssetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:SetAssetName", SetAssetName_IsValid);
		RemoveTargetNodeUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveTargetNodeUid");
		RemoveTargetNodeUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTargetNodeUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTargetNodeUid_AssetUid_PropertyAddress, RemoveTargetNodeUid_FunctionAddress, "AssetUid");
		RemoveTargetNodeUid_AssetUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTargetNodeUid_FunctionAddress, "AssetUid");
		RemoveTargetNodeUid_AssetUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTargetNodeUid_FunctionAddress, "AssetUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTargetNodeUid_ReturnValue_PropertyAddress, RemoveTargetNodeUid_FunctionAddress, "ReturnValue");
		RemoveTargetNodeUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTargetNodeUid_FunctionAddress, "ReturnValue");
		RemoveTargetNodeUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTargetNodeUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveTargetNodeUid_IsValid = RemoveTargetNodeUid_FunctionAddress != IntPtr.Zero && RemoveTargetNodeUid_AssetUid_IsValid && RemoveTargetNodeUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:RemoveTargetNodeUid", RemoveTargetNodeUid_IsValid);
		RemoveFactoryDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveFactoryDependencyUid");
		RemoveFactoryDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveFactoryDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveFactoryDependencyUid_DependencyUid_PropertyAddress, RemoveFactoryDependencyUid_FunctionAddress, "DependencyUid");
		RemoveFactoryDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFactoryDependencyUid_FunctionAddress, "DependencyUid");
		RemoveFactoryDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFactoryDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFactoryDependencyUid_ReturnValue_PropertyAddress, RemoveFactoryDependencyUid_FunctionAddress, "ReturnValue");
		RemoveFactoryDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFactoryDependencyUid_FunctionAddress, "ReturnValue");
		RemoveFactoryDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFactoryDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveFactoryDependencyUid_IsValid = RemoveFactoryDependencyUid_FunctionAddress != IntPtr.Zero && RemoveFactoryDependencyUid_DependencyUid_IsValid && RemoveFactoryDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:RemoveFactoryDependencyUid", RemoveFactoryDependencyUid_IsValid);
		RemoveAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAttribute");
		RemoveAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttribute_NodeAttributeKey_PropertyAddress, RemoveAttribute_FunctionAddress, "NodeAttributeKey");
		RemoveAttribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttribute_FunctionAddress, "NodeAttributeKey");
		RemoveAttribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAttribute_ReturnValue_PropertyAddress, RemoveAttribute_FunctionAddress, "ReturnValue");
		RemoveAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAttribute_FunctionAddress, "ReturnValue");
		RemoveAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAttribute_IsValid = RemoveAttribute_FunctionAddress != IntPtr.Zero && RemoveAttribute_NodeAttributeKey_IsValid && RemoveAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:RemoveAttribute", RemoveAttribute_IsValid);
		IsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsEnabled");
		IsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEnabled_ReturnValue_PropertyAddress, IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEnabled_FunctionAddress, "ReturnValue");
		IsEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEnabled_IsValid = IsEnabled_FunctionAddress != IntPtr.Zero && IsEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:IsEnabled", IsEnabled_IsValid);
		InitializeNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeNode");
		InitializeNode_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeNode_UniqueID_PropertyAddress, InitializeNode_FunctionAddress, "UniqueID");
		InitializeNode_UniqueID_Offset = NativeReflectionCached.GetPropertyOffset(InitializeNode_FunctionAddress, "UniqueID");
		InitializeNode_UniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeNode_FunctionAddress, "UniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeNode_DisplayLabel_PropertyAddress, InitializeNode_FunctionAddress, "DisplayLabel");
		InitializeNode_DisplayLabel_Offset = NativeReflectionCached.GetPropertyOffset(InitializeNode_FunctionAddress, "DisplayLabel");
		InitializeNode_DisplayLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeNode_FunctionAddress, "DisplayLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeNode_NodeContainerType_PropertyAddress, InitializeNode_FunctionAddress, "NodeContainerType");
		InitializeNode_NodeContainerType_Offset = NativeReflectionCached.GetPropertyOffset(InitializeNode_FunctionAddress, "NodeContainerType");
		InitializeNode_NodeContainerType_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeNode_FunctionAddress, "NodeContainerType", Classes.FEnumProperty);
		InitializeNode_IsValid = InitializeNode_FunctionAddress != IntPtr.Zero && InitializeNode_UniqueID_IsValid && InitializeNode_DisplayLabel_IsValid && InitializeNode_NodeContainerType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:InitializeNode", InitializeNode_IsValid);
		GetUniqueID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUniqueID");
		GetUniqueID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniqueID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueID_ReturnValue_PropertyAddress, GetUniqueID_FunctionAddress, "ReturnValue");
		GetUniqueID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueID_FunctionAddress, "ReturnValue");
		GetUniqueID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueID_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUniqueID_IsValid = GetUniqueID_FunctionAddress != IntPtr.Zero && GetUniqueID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetUniqueID", GetUniqueID_IsValid);
		GetTargetNodeUids_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTargetNodeUids");
		GetTargetNodeUids_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTargetNodeUids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTargetNodeUids_OutTargetAssets_PropertyAddress, GetTargetNodeUids_FunctionAddress, "OutTargetAssets");
		GetTargetNodeUids_OutTargetAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetNodeUids_FunctionAddress, "OutTargetAssets");
		GetTargetNodeUids_OutTargetAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetNodeUids_FunctionAddress, "OutTargetAssets", Classes.FArrayProperty);
		GetTargetNodeUids_IsValid = GetTargetNodeUids_FunctionAddress != IntPtr.Zero && GetTargetNodeUids_OutTargetAssets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetTargetNodeUids", GetTargetNodeUids_IsValid);
		GetTargetNodeCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTargetNodeCount");
		GetTargetNodeCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTargetNodeCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTargetNodeCount_ReturnValue_PropertyAddress, GetTargetNodeCount_FunctionAddress, "ReturnValue");
		GetTargetNodeCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetNodeCount_FunctionAddress, "ReturnValue");
		GetTargetNodeCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetNodeCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTargetNodeCount_IsValid = GetTargetNodeCount_FunctionAddress != IntPtr.Zero && GetTargetNodeCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetTargetNodeCount", GetTargetNodeCount_IsValid);
		GetStringAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStringAttribute");
		GetStringAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStringAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttribute_NodeAttributeKey_PropertyAddress, GetStringAttribute_FunctionAddress, "NodeAttributeKey");
		GetStringAttribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttribute_FunctionAddress, "NodeAttributeKey");
		GetStringAttribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttribute_OutValue_PropertyAddress, GetStringAttribute_FunctionAddress, "OutValue");
		GetStringAttribute_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttribute_FunctionAddress, "OutValue");
		GetStringAttribute_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttribute_FunctionAddress, "OutValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStringAttribute_ReturnValue_PropertyAddress, GetStringAttribute_FunctionAddress, "ReturnValue");
		GetStringAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStringAttribute_FunctionAddress, "ReturnValue");
		GetStringAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStringAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetStringAttribute_IsValid = GetStringAttribute_FunctionAddress != IntPtr.Zero && GetStringAttribute_NodeAttributeKey_IsValid && GetStringAttribute_OutValue_IsValid && GetStringAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetStringAttribute", GetStringAttribute_IsValid);
		GetParentUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParentUid");
		GetParentUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentUid_ReturnValue_PropertyAddress, GetParentUid_FunctionAddress, "ReturnValue");
		GetParentUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentUid_FunctionAddress, "ReturnValue");
		GetParentUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentUid_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetParentUid_IsValid = GetParentUid_FunctionAddress != IntPtr.Zero && GetParentUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetParentUid", GetParentUid_IsValid);
		GetNodeContainerType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNodeContainerType");
		GetNodeContainerType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeContainerType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNodeContainerType_ReturnValue_PropertyAddress, GetNodeContainerType_FunctionAddress, "ReturnValue");
		GetNodeContainerType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNodeContainerType_FunctionAddress, "ReturnValue");
		GetNodeContainerType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNodeContainerType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetNodeContainerType_IsValid = GetNodeContainerType_FunctionAddress != IntPtr.Zero && GetNodeContainerType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetNodeContainerType", GetNodeContainerType_IsValid);
		GetInt32Attribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInt32Attribute");
		GetInt32Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInt32Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInt32Attribute_NodeAttributeKey_PropertyAddress, GetInt32Attribute_FunctionAddress, "NodeAttributeKey");
		GetInt32Attribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32Attribute_FunctionAddress, "NodeAttributeKey");
		GetInt32Attribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32Attribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt32Attribute_OutValue_PropertyAddress, GetInt32Attribute_FunctionAddress, "OutValue");
		GetInt32Attribute_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32Attribute_FunctionAddress, "OutValue");
		GetInt32Attribute_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32Attribute_FunctionAddress, "OutValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt32Attribute_ReturnValue_PropertyAddress, GetInt32Attribute_FunctionAddress, "ReturnValue");
		GetInt32Attribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32Attribute_FunctionAddress, "ReturnValue");
		GetInt32Attribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32Attribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetInt32Attribute_IsValid = GetInt32Attribute_FunctionAddress != IntPtr.Zero && GetInt32Attribute_NodeAttributeKey_IsValid && GetInt32Attribute_OutValue_IsValid && GetInt32Attribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetInt32Attribute", GetInt32Attribute_IsValid);
		GetFloatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFloatAttribute");
		GetFloatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttribute_NodeAttributeKey_PropertyAddress, GetFloatAttribute_FunctionAddress, "NodeAttributeKey");
		GetFloatAttribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttribute_FunctionAddress, "NodeAttributeKey");
		GetFloatAttribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttribute_OutValue_PropertyAddress, GetFloatAttribute_FunctionAddress, "OutValue");
		GetFloatAttribute_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttribute_FunctionAddress, "OutValue");
		GetFloatAttribute_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttribute_FunctionAddress, "OutValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatAttribute_ReturnValue_PropertyAddress, GetFloatAttribute_FunctionAddress, "ReturnValue");
		GetFloatAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatAttribute_FunctionAddress, "ReturnValue");
		GetFloatAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetFloatAttribute_IsValid = GetFloatAttribute_FunctionAddress != IntPtr.Zero && GetFloatAttribute_NodeAttributeKey_IsValid && GetFloatAttribute_OutValue_IsValid && GetFloatAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetFloatAttribute", GetFloatAttribute_IsValid);
		GetFactoryDependency_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFactoryDependency");
		GetFactoryDependency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFactoryDependency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFactoryDependency_Index_PropertyAddress, GetFactoryDependency_FunctionAddress, "Index");
		GetFactoryDependency_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetFactoryDependency_FunctionAddress, "Index");
		GetFactoryDependency_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFactoryDependency_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFactoryDependency_OutDependency_PropertyAddress, GetFactoryDependency_FunctionAddress, "OutDependency");
		GetFactoryDependency_OutDependency_Offset = NativeReflectionCached.GetPropertyOffset(GetFactoryDependency_FunctionAddress, "OutDependency");
		GetFactoryDependency_OutDependency_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFactoryDependency_FunctionAddress, "OutDependency", Classes.FStrProperty);
		GetFactoryDependency_IsValid = GetFactoryDependency_FunctionAddress != IntPtr.Zero && GetFactoryDependency_Index_IsValid && GetFactoryDependency_OutDependency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependency", GetFactoryDependency_IsValid);
		GetFactoryDependenciesCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFactoryDependenciesCount");
		GetFactoryDependenciesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFactoryDependenciesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFactoryDependenciesCount_ReturnValue_PropertyAddress, GetFactoryDependenciesCount_FunctionAddress, "ReturnValue");
		GetFactoryDependenciesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFactoryDependenciesCount_FunctionAddress, "ReturnValue");
		GetFactoryDependenciesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFactoryDependenciesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFactoryDependenciesCount_IsValid = GetFactoryDependenciesCount_FunctionAddress != IntPtr.Zero && GetFactoryDependenciesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependenciesCount", GetFactoryDependenciesCount_IsValid);
		GetFactoryDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFactoryDependencies");
		GetFactoryDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFactoryDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFactoryDependencies_OutDependencies_PropertyAddress, GetFactoryDependencies_FunctionAddress, "OutDependencies");
		GetFactoryDependencies_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetFactoryDependencies_FunctionAddress, "OutDependencies");
		GetFactoryDependencies_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFactoryDependencies_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		GetFactoryDependencies_IsValid = GetFactoryDependencies_FunctionAddress != IntPtr.Zero && GetFactoryDependencies_OutDependencies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetFactoryDependencies", GetFactoryDependencies_IsValid);
		GetDisplayLabel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayLabel");
		GetDisplayLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayLabel_ReturnValue_PropertyAddress, GetDisplayLabel_FunctionAddress, "ReturnValue");
		GetDisplayLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayLabel_FunctionAddress, "ReturnValue");
		GetDisplayLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayLabel_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayLabel_IsValid = GetDisplayLabel_FunctionAddress != IntPtr.Zero && GetDisplayLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetDisplayLabel", GetDisplayLabel_IsValid);
		GetBooleanAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBooleanAttribute");
		GetBooleanAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBooleanAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBooleanAttribute_NodeAttributeKey_PropertyAddress, GetBooleanAttribute_FunctionAddress, "NodeAttributeKey");
		GetBooleanAttribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(GetBooleanAttribute_FunctionAddress, "NodeAttributeKey");
		GetBooleanAttribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBooleanAttribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBooleanAttribute_OutValue_PropertyAddress, GetBooleanAttribute_FunctionAddress, "OutValue");
		GetBooleanAttribute_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBooleanAttribute_FunctionAddress, "OutValue");
		GetBooleanAttribute_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBooleanAttribute_FunctionAddress, "OutValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBooleanAttribute_ReturnValue_PropertyAddress, GetBooleanAttribute_FunctionAddress, "ReturnValue");
		GetBooleanAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBooleanAttribute_FunctionAddress, "ReturnValue");
		GetBooleanAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBooleanAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBooleanAttribute_IsValid = GetBooleanAttribute_FunctionAddress != IntPtr.Zero && GetBooleanAttribute_NodeAttributeKey_IsValid && GetBooleanAttribute_OutValue_IsValid && GetBooleanAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetBooleanAttribute", GetBooleanAttribute_IsValid);
		GetAssetName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssetName");
		GetAssetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetName_ReturnValue_PropertyAddress, GetAssetName_FunctionAddress, "ReturnValue");
		GetAssetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetName_FunctionAddress, "ReturnValue");
		GetAssetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAssetName_IsValid = GetAssetName_FunctionAddress != IntPtr.Zero && GetAssetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:GetAssetName", GetAssetName_IsValid);
		AddTargetNodeUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddTargetNodeUid");
		AddTargetNodeUid_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTargetNodeUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTargetNodeUid_AssetUid_PropertyAddress, AddTargetNodeUid_FunctionAddress, "AssetUid");
		AddTargetNodeUid_AssetUid_Offset = NativeReflectionCached.GetPropertyOffset(AddTargetNodeUid_FunctionAddress, "AssetUid");
		AddTargetNodeUid_AssetUid_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTargetNodeUid_FunctionAddress, "AssetUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTargetNodeUid_ReturnValue_PropertyAddress, AddTargetNodeUid_FunctionAddress, "ReturnValue");
		AddTargetNodeUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddTargetNodeUid_FunctionAddress, "ReturnValue");
		AddTargetNodeUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTargetNodeUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddTargetNodeUid_IsValid = AddTargetNodeUid_FunctionAddress != IntPtr.Zero && AddTargetNodeUid_AssetUid_IsValid && AddTargetNodeUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:AddTargetNodeUid", AddTargetNodeUid_IsValid);
		AddStringAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddStringAttribute");
		AddStringAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddStringAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddStringAttribute_NodeAttributeKey_PropertyAddress, AddStringAttribute_FunctionAddress, "NodeAttributeKey");
		AddStringAttribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(AddStringAttribute_FunctionAddress, "NodeAttributeKey");
		AddStringAttribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStringAttribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStringAttribute_Value_PropertyAddress, AddStringAttribute_FunctionAddress, "Value");
		AddStringAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddStringAttribute_FunctionAddress, "Value");
		AddStringAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStringAttribute_FunctionAddress, "Value", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStringAttribute_ReturnValue_PropertyAddress, AddStringAttribute_FunctionAddress, "ReturnValue");
		AddStringAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddStringAttribute_FunctionAddress, "ReturnValue");
		AddStringAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStringAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddStringAttribute_IsValid = AddStringAttribute_FunctionAddress != IntPtr.Zero && AddStringAttribute_NodeAttributeKey_IsValid && AddStringAttribute_Value_IsValid && AddStringAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:AddStringAttribute", AddStringAttribute_IsValid);
		AddInt32Attribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddInt32Attribute");
		AddInt32Attribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInt32Attribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInt32Attribute_NodeAttributeKey_PropertyAddress, AddInt32Attribute_FunctionAddress, "NodeAttributeKey");
		AddInt32Attribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(AddInt32Attribute_FunctionAddress, "NodeAttributeKey");
		AddInt32Attribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt32Attribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInt32Attribute_Value_PropertyAddress, AddInt32Attribute_FunctionAddress, "Value");
		AddInt32Attribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddInt32Attribute_FunctionAddress, "Value");
		AddInt32Attribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt32Attribute_FunctionAddress, "Value", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInt32Attribute_ReturnValue_PropertyAddress, AddInt32Attribute_FunctionAddress, "ReturnValue");
		AddInt32Attribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInt32Attribute_FunctionAddress, "ReturnValue");
		AddInt32Attribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt32Attribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddInt32Attribute_IsValid = AddInt32Attribute_FunctionAddress != IntPtr.Zero && AddInt32Attribute_NodeAttributeKey_IsValid && AddInt32Attribute_Value_IsValid && AddInt32Attribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:AddInt32Attribute", AddInt32Attribute_IsValid);
		AddFloatAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddFloatAttribute");
		AddFloatAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFloatAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFloatAttribute_NodeAttributeKey_PropertyAddress, AddFloatAttribute_FunctionAddress, "NodeAttributeKey");
		AddFloatAttribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatAttribute_FunctionAddress, "NodeAttributeKey");
		AddFloatAttribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatAttribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatAttribute_Value_PropertyAddress, AddFloatAttribute_FunctionAddress, "Value");
		AddFloatAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatAttribute_FunctionAddress, "Value");
		AddFloatAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatAttribute_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloatAttribute_ReturnValue_PropertyAddress, AddFloatAttribute_FunctionAddress, "ReturnValue");
		AddFloatAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFloatAttribute_FunctionAddress, "ReturnValue");
		AddFloatAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloatAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddFloatAttribute_IsValid = AddFloatAttribute_FunctionAddress != IntPtr.Zero && AddFloatAttribute_NodeAttributeKey_IsValid && AddFloatAttribute_Value_IsValid && AddFloatAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:AddFloatAttribute", AddFloatAttribute_IsValid);
		AddFactoryDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddFactoryDependencyUid");
		AddFactoryDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFactoryDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFactoryDependencyUid_DependencyUid_PropertyAddress, AddFactoryDependencyUid_FunctionAddress, "DependencyUid");
		AddFactoryDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(AddFactoryDependencyUid_FunctionAddress, "DependencyUid");
		AddFactoryDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFactoryDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFactoryDependencyUid_ReturnValue_PropertyAddress, AddFactoryDependencyUid_FunctionAddress, "ReturnValue");
		AddFactoryDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFactoryDependencyUid_FunctionAddress, "ReturnValue");
		AddFactoryDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFactoryDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddFactoryDependencyUid_IsValid = AddFactoryDependencyUid_FunctionAddress != IntPtr.Zero && AddFactoryDependencyUid_DependencyUid_IsValid && AddFactoryDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:AddFactoryDependencyUid", AddFactoryDependencyUid_IsValid);
		AddBooleanAttribute_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddBooleanAttribute");
		AddBooleanAttribute_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBooleanAttribute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBooleanAttribute_NodeAttributeKey_PropertyAddress, AddBooleanAttribute_FunctionAddress, "NodeAttributeKey");
		AddBooleanAttribute_NodeAttributeKey_Offset = NativeReflectionCached.GetPropertyOffset(AddBooleanAttribute_FunctionAddress, "NodeAttributeKey");
		AddBooleanAttribute_NodeAttributeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBooleanAttribute_FunctionAddress, "NodeAttributeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBooleanAttribute_Value_PropertyAddress, AddBooleanAttribute_FunctionAddress, "Value");
		AddBooleanAttribute_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddBooleanAttribute_FunctionAddress, "Value");
		AddBooleanAttribute_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBooleanAttribute_FunctionAddress, "Value", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBooleanAttribute_ReturnValue_PropertyAddress, AddBooleanAttribute_FunctionAddress, "ReturnValue");
		AddBooleanAttribute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBooleanAttribute_FunctionAddress, "ReturnValue");
		AddBooleanAttribute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBooleanAttribute_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddBooleanAttribute_IsValid = AddBooleanAttribute_FunctionAddress != IntPtr.Zero && AddBooleanAttribute_NodeAttributeKey_IsValid && AddBooleanAttribute_Value_IsValid && AddBooleanAttribute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeBaseNode:AddBooleanAttribute", AddBooleanAttribute_IsValid);
	}
}
