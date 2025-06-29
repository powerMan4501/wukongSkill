using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeSkeletalMeshFactoryNode : UInterchangeBaseNode
{
	private static bool SetCustomVertexColorReplace_IsValid;

	private static IntPtr SetCustomVertexColorReplace_FunctionAddress;

	private static int SetCustomVertexColorReplace_ParamsSize;

	private static bool SetCustomVertexColorReplace_AttributeValue_IsValid;

	private static FFieldAddress SetCustomVertexColorReplace_AttributeValue_PropertyAddress;

	private static int SetCustomVertexColorReplace_AttributeValue_Offset;

	private static bool SetCustomVertexColorReplace_ReturnValue_IsValid;

	private static FFieldAddress SetCustomVertexColorReplace_ReturnValue_PropertyAddress;

	private static int SetCustomVertexColorReplace_ReturnValue_Offset;

	private static bool SetCustomVertexColorOverride_IsValid;

	private static IntPtr SetCustomVertexColorOverride_FunctionAddress;

	private static int SetCustomVertexColorOverride_ParamsSize;

	private static bool SetCustomVertexColorOverride_AttributeValue_IsValid;

	private static FFieldAddress SetCustomVertexColorOverride_AttributeValue_PropertyAddress;

	private static int SetCustomVertexColorOverride_AttributeValue_Offset;

	private static bool SetCustomVertexColorOverride_ReturnValue_IsValid;

	private static FFieldAddress SetCustomVertexColorOverride_ReturnValue_PropertyAddress;

	private static int SetCustomVertexColorOverride_ReturnValue_Offset;

	private static bool SetCustomVertexColorIgnore_IsValid;

	private static IntPtr SetCustomVertexColorIgnore_FunctionAddress;

	private static int SetCustomVertexColorIgnore_ParamsSize;

	private static bool SetCustomVertexColorIgnore_AttributeValue_IsValid;

	private static FFieldAddress SetCustomVertexColorIgnore_AttributeValue_PropertyAddress;

	private static int SetCustomVertexColorIgnore_AttributeValue_Offset;

	private static bool SetCustomVertexColorIgnore_ReturnValue_IsValid;

	private static FFieldAddress SetCustomVertexColorIgnore_ReturnValue_PropertyAddress;

	private static int SetCustomVertexColorIgnore_ReturnValue_Offset;

	private static bool SetCustomSkeletonSoftObjectPath_IsValid;

	private static IntPtr SetCustomSkeletonSoftObjectPath_FunctionAddress;

	private static int SetCustomSkeletonSoftObjectPath_ParamsSize;

	private static bool SetCustomSkeletonSoftObjectPath_AttributeValue_IsValid;

	private static FFieldAddress SetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress;

	private static int SetCustomSkeletonSoftObjectPath_AttributeValue_Offset;

	private static bool SetCustomSkeletonSoftObjectPath_ReturnValue_IsValid;

	private static FFieldAddress SetCustomSkeletonSoftObjectPath_ReturnValue_PropertyAddress;

	private static int SetCustomSkeletonSoftObjectPath_ReturnValue_Offset;

	private static bool SetCustomPhysicAssetSoftObjectPath_IsValid;

	private static IntPtr SetCustomPhysicAssetSoftObjectPath_FunctionAddress;

	private static int SetCustomPhysicAssetSoftObjectPath_ParamsSize;

	private static bool SetCustomPhysicAssetSoftObjectPath_AttributeValue_IsValid;

	private static FFieldAddress SetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress;

	private static int SetCustomPhysicAssetSoftObjectPath_AttributeValue_Offset;

	private static bool SetCustomPhysicAssetSoftObjectPath_ReturnValue_IsValid;

	private static FFieldAddress SetCustomPhysicAssetSoftObjectPath_ReturnValue_PropertyAddress;

	private static int SetCustomPhysicAssetSoftObjectPath_ReturnValue_Offset;

	private static bool SetCustomImportMorphTarget_IsValid;

	private static IntPtr SetCustomImportMorphTarget_FunctionAddress;

	private static int SetCustomImportMorphTarget_ParamsSize;

	private static bool SetCustomImportMorphTarget_AttributeValue_IsValid;

	private static FFieldAddress SetCustomImportMorphTarget_AttributeValue_PropertyAddress;

	private static int SetCustomImportMorphTarget_AttributeValue_Offset;

	private static bool SetCustomImportMorphTarget_ReturnValue_IsValid;

	private static FFieldAddress SetCustomImportMorphTarget_ReturnValue_PropertyAddress;

	private static int SetCustomImportMorphTarget_ReturnValue_Offset;

	private static bool SetCustomCreatePhysicsAsset_IsValid;

	private static IntPtr SetCustomCreatePhysicsAsset_FunctionAddress;

	private static int SetCustomCreatePhysicsAsset_ParamsSize;

	private static bool SetCustomCreatePhysicsAsset_AttributeValue_IsValid;

	private static FFieldAddress SetCustomCreatePhysicsAsset_AttributeValue_PropertyAddress;

	private static int SetCustomCreatePhysicsAsset_AttributeValue_Offset;

	private static bool SetCustomCreatePhysicsAsset_ReturnValue_IsValid;

	private static FFieldAddress SetCustomCreatePhysicsAsset_ReturnValue_PropertyAddress;

	private static int SetCustomCreatePhysicsAsset_ReturnValue_Offset;

	private static bool RemoveLodDataUniqueId_IsValid;

	private static IntPtr RemoveLodDataUniqueId_FunctionAddress;

	private static int RemoveLodDataUniqueId_ParamsSize;

	private static bool RemoveLodDataUniqueId_LodDataUniqueId_IsValid;

	private static FFieldAddress RemoveLodDataUniqueId_LodDataUniqueId_PropertyAddress;

	private static int RemoveLodDataUniqueId_LodDataUniqueId_Offset;

	private static bool RemoveLodDataUniqueId_ReturnValue_IsValid;

	private static FFieldAddress RemoveLodDataUniqueId_ReturnValue_PropertyAddress;

	private static int RemoveLodDataUniqueId_ReturnValue_Offset;

	private static bool InitializeSkeletalMeshNode_IsValid;

	private static IntPtr InitializeSkeletalMeshNode_FunctionAddress;

	private static int InitializeSkeletalMeshNode_ParamsSize;

	private static bool InitializeSkeletalMeshNode_UniqueID_IsValid;

	private static FFieldAddress InitializeSkeletalMeshNode_UniqueID_PropertyAddress;

	private static int InitializeSkeletalMeshNode_UniqueID_Offset;

	private static bool InitializeSkeletalMeshNode_DisplayLabel_IsValid;

	private static FFieldAddress InitializeSkeletalMeshNode_DisplayLabel_PropertyAddress;

	private static int InitializeSkeletalMeshNode_DisplayLabel_Offset;

	private static bool InitializeSkeletalMeshNode_InAssetClass_IsValid;

	private static FFieldAddress InitializeSkeletalMeshNode_InAssetClass_PropertyAddress;

	private static int InitializeSkeletalMeshNode_InAssetClass_Offset;

	private static bool GetObjectClass_IsValid;

	private static IntPtr GetObjectClass_FunctionAddress;

	private static int GetObjectClass_ParamsSize;

	private static bool GetObjectClass_ReturnValue_IsValid;

	private static FFieldAddress GetObjectClass_ReturnValue_PropertyAddress;

	private static int GetObjectClass_ReturnValue_Offset;

	private static bool GetLodDataUniqueIds_IsValid;

	private static IntPtr GetLodDataUniqueIds_FunctionAddress;

	private static int GetLodDataUniqueIds_ParamsSize;

	private static bool GetLodDataUniqueIds_OutLodDataUniqueIds_IsValid;

	private static FFieldAddress GetLodDataUniqueIds_OutLodDataUniqueIds_PropertyAddress;

	private static int GetLodDataUniqueIds_OutLodDataUniqueIds_Offset;

	private static bool GetLodDataCount_IsValid;

	private static IntPtr GetLodDataCount_FunctionAddress;

	private static int GetLodDataCount_ParamsSize;

	private static bool GetLodDataCount_ReturnValue_IsValid;

	private static FFieldAddress GetLodDataCount_ReturnValue_PropertyAddress;

	private static int GetLodDataCount_ReturnValue_Offset;

	private static bool GetCustomVertexColorReplace_IsValid;

	private static IntPtr GetCustomVertexColorReplace_FunctionAddress;

	private static int GetCustomVertexColorReplace_ParamsSize;

	private static bool GetCustomVertexColorReplace_AttributeValue_IsValid;

	private static FFieldAddress GetCustomVertexColorReplace_AttributeValue_PropertyAddress;

	private static int GetCustomVertexColorReplace_AttributeValue_Offset;

	private static bool GetCustomVertexColorReplace_ReturnValue_IsValid;

	private static FFieldAddress GetCustomVertexColorReplace_ReturnValue_PropertyAddress;

	private static int GetCustomVertexColorReplace_ReturnValue_Offset;

	private static bool GetCustomVertexColorOverride_IsValid;

	private static IntPtr GetCustomVertexColorOverride_FunctionAddress;

	private static int GetCustomVertexColorOverride_ParamsSize;

	private static bool GetCustomVertexColorOverride_AttributeValue_IsValid;

	private static FFieldAddress GetCustomVertexColorOverride_AttributeValue_PropertyAddress;

	private static int GetCustomVertexColorOverride_AttributeValue_Offset;

	private static bool GetCustomVertexColorOverride_ReturnValue_IsValid;

	private static FFieldAddress GetCustomVertexColorOverride_ReturnValue_PropertyAddress;

	private static int GetCustomVertexColorOverride_ReturnValue_Offset;

	private static bool GetCustomVertexColorIgnore_IsValid;

	private static IntPtr GetCustomVertexColorIgnore_FunctionAddress;

	private static int GetCustomVertexColorIgnore_ParamsSize;

	private static bool GetCustomVertexColorIgnore_AttributeValue_IsValid;

	private static FFieldAddress GetCustomVertexColorIgnore_AttributeValue_PropertyAddress;

	private static int GetCustomVertexColorIgnore_AttributeValue_Offset;

	private static bool GetCustomVertexColorIgnore_ReturnValue_IsValid;

	private static FFieldAddress GetCustomVertexColorIgnore_ReturnValue_PropertyAddress;

	private static int GetCustomVertexColorIgnore_ReturnValue_Offset;

	private static bool GetCustomSkeletonSoftObjectPath_IsValid;

	private static IntPtr GetCustomSkeletonSoftObjectPath_FunctionAddress;

	private static int GetCustomSkeletonSoftObjectPath_ParamsSize;

	private static bool GetCustomSkeletonSoftObjectPath_AttributeValue_IsValid;

	private static FFieldAddress GetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress;

	private static int GetCustomSkeletonSoftObjectPath_AttributeValue_Offset;

	private static bool GetCustomSkeletonSoftObjectPath_ReturnValue_IsValid;

	private static FFieldAddress GetCustomSkeletonSoftObjectPath_ReturnValue_PropertyAddress;

	private static int GetCustomSkeletonSoftObjectPath_ReturnValue_Offset;

	private static bool GetCustomPhysicAssetSoftObjectPath_IsValid;

	private static IntPtr GetCustomPhysicAssetSoftObjectPath_FunctionAddress;

	private static int GetCustomPhysicAssetSoftObjectPath_ParamsSize;

	private static bool GetCustomPhysicAssetSoftObjectPath_AttributeValue_IsValid;

	private static FFieldAddress GetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress;

	private static int GetCustomPhysicAssetSoftObjectPath_AttributeValue_Offset;

	private static bool GetCustomPhysicAssetSoftObjectPath_ReturnValue_IsValid;

	private static FFieldAddress GetCustomPhysicAssetSoftObjectPath_ReturnValue_PropertyAddress;

	private static int GetCustomPhysicAssetSoftObjectPath_ReturnValue_Offset;

	private static bool GetCustomImportMorphTarget_IsValid;

	private static IntPtr GetCustomImportMorphTarget_FunctionAddress;

	private static int GetCustomImportMorphTarget_ParamsSize;

	private static bool GetCustomImportMorphTarget_AttributeValue_IsValid;

	private static FFieldAddress GetCustomImportMorphTarget_AttributeValue_PropertyAddress;

	private static int GetCustomImportMorphTarget_AttributeValue_Offset;

	private static bool GetCustomImportMorphTarget_ReturnValue_IsValid;

	private static FFieldAddress GetCustomImportMorphTarget_ReturnValue_PropertyAddress;

	private static int GetCustomImportMorphTarget_ReturnValue_Offset;

	private static bool GetCustomCreatePhysicsAsset_IsValid;

	private static IntPtr GetCustomCreatePhysicsAsset_FunctionAddress;

	private static int GetCustomCreatePhysicsAsset_ParamsSize;

	private static bool GetCustomCreatePhysicsAsset_AttributeValue_IsValid;

	private static FFieldAddress GetCustomCreatePhysicsAsset_AttributeValue_PropertyAddress;

	private static int GetCustomCreatePhysicsAsset_AttributeValue_Offset;

	private static bool GetCustomCreatePhysicsAsset_ReturnValue_IsValid;

	private static FFieldAddress GetCustomCreatePhysicsAsset_ReturnValue_PropertyAddress;

	private static int GetCustomCreatePhysicsAsset_ReturnValue_Offset;

	private static bool AddLodDataUniqueId_IsValid;

	private static IntPtr AddLodDataUniqueId_FunctionAddress;

	private static int AddLodDataUniqueId_ParamsSize;

	private static bool AddLodDataUniqueId_LodDataUniqueId_IsValid;

	private static FFieldAddress AddLodDataUniqueId_LodDataUniqueId_PropertyAddress;

	private static int AddLodDataUniqueId_LodDataUniqueId_Offset;

	private static bool AddLodDataUniqueId_ReturnValue_IsValid;

	private static FFieldAddress AddLodDataUniqueId_ReturnValue_PropertyAddress;

	private static int AddLodDataUniqueId_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorReplace")]
	public unsafe bool SetCustomVertexColorReplace(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomVertexColorReplace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorReplace");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomVertexColorReplace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomVertexColorReplace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomVertexColorReplace_AttributeValue_Offset), 0, SetCustomVertexColorReplace_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomVertexColorReplace_FunctionAddress, intPtr, SetCustomVertexColorReplace_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomVertexColorReplace_ReturnValue_Offset), 0, SetCustomVertexColorReplace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorOverride")]
	public unsafe bool SetCustomVertexColorOverride(FColor AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomVertexColorOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorOverride");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomVertexColorOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomVertexColorOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetCustomVertexColorOverride_AttributeValue_Offset), 0, SetCustomVertexColorOverride_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomVertexColorOverride_FunctionAddress, intPtr, SetCustomVertexColorOverride_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomVertexColorOverride_ReturnValue_Offset), 0, SetCustomVertexColorOverride_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorIgnore")]
	public unsafe bool SetCustomVertexColorIgnore(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomVertexColorIgnore_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorIgnore");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomVertexColorIgnore_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomVertexColorIgnore_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomVertexColorIgnore_AttributeValue_Offset), 0, SetCustomVertexColorIgnore_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomVertexColorIgnore_FunctionAddress, intPtr, SetCustomVertexColorIgnore_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomVertexColorIgnore_ReturnValue_Offset), 0, SetCustomVertexColorIgnore_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomSkeletonSoftObjectPath")]
	public unsafe bool SetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomSkeletonSoftObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomSkeletonSoftObjectPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomSkeletonSoftObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomSkeletonSoftObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftObjectPath.ToNative(IntPtr.Add(intPtr, SetCustomSkeletonSoftObjectPath_AttributeValue_Offset), 0, SetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomSkeletonSoftObjectPath_FunctionAddress, intPtr, SetCustomSkeletonSoftObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomSkeletonSoftObjectPath_ReturnValue_Offset), 0, SetCustomSkeletonSoftObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomPhysicAssetSoftObjectPath")]
	public unsafe bool SetCustomPhysicAssetSoftObjectPath(FSoftObjectPath AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomPhysicAssetSoftObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomPhysicAssetSoftObjectPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomPhysicAssetSoftObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomPhysicAssetSoftObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftObjectPath.ToNative(IntPtr.Add(intPtr, SetCustomPhysicAssetSoftObjectPath_AttributeValue_Offset), 0, SetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomPhysicAssetSoftObjectPath_FunctionAddress, intPtr, SetCustomPhysicAssetSoftObjectPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomPhysicAssetSoftObjectPath_ReturnValue_Offset), 0, SetCustomPhysicAssetSoftObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomImportMorphTarget")]
	public unsafe bool SetCustomImportMorphTarget(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomImportMorphTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomImportMorphTarget");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomImportMorphTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomImportMorphTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomImportMorphTarget_AttributeValue_Offset), 0, SetCustomImportMorphTarget_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomImportMorphTarget_FunctionAddress, intPtr, SetCustomImportMorphTarget_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomImportMorphTarget_ReturnValue_Offset), 0, SetCustomImportMorphTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomCreatePhysicsAsset")]
	public unsafe bool SetCustomCreatePhysicsAsset(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomCreatePhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomCreatePhysicsAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomCreatePhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomCreatePhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomCreatePhysicsAsset_AttributeValue_Offset), 0, SetCustomCreatePhysicsAsset_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomCreatePhysicsAsset_FunctionAddress, intPtr, SetCustomCreatePhysicsAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomCreatePhysicsAsset_ReturnValue_Offset), 0, SetCustomCreatePhysicsAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:RemoveLodDataUniqueId")]
	public unsafe bool RemoveLodDataUniqueId(string LodDataUniqueId)
	{
		CheckDestroyed();
		if (!RemoveLodDataUniqueId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:RemoveLodDataUniqueId");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveLodDataUniqueId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveLodDataUniqueId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveLodDataUniqueId_LodDataUniqueId_Offset), 0, RemoveLodDataUniqueId_LodDataUniqueId_PropertyAddress.Address, LodDataUniqueId);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveLodDataUniqueId_FunctionAddress, intPtr, RemoveLodDataUniqueId_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveLodDataUniqueId_LodDataUniqueId_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveLodDataUniqueId_ReturnValue_Offset), 0, RemoveLodDataUniqueId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:InitializeSkeletalMeshNode")]
	public unsafe void InitializeSkeletalMeshNode(string UniqueID, string DisplayLabel, string InAssetClass)
	{
		CheckDestroyed();
		if (!InitializeSkeletalMeshNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:InitializeSkeletalMeshNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeSkeletalMeshNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeSkeletalMeshNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeSkeletalMeshNode_UniqueID_Offset), 0, InitializeSkeletalMeshNode_UniqueID_PropertyAddress.Address, UniqueID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeSkeletalMeshNode_DisplayLabel_Offset), 0, InitializeSkeletalMeshNode_DisplayLabel_PropertyAddress.Address, DisplayLabel);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeSkeletalMeshNode_InAssetClass_Offset), 0, InitializeSkeletalMeshNode_InAssetClass_PropertyAddress.Address, InAssetClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeSkeletalMeshNode_FunctionAddress, intPtr, InitializeSkeletalMeshNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializeSkeletalMeshNode_UniqueID_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeSkeletalMeshNode_DisplayLabel_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeSkeletalMeshNode_InAssetClass_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetObjectClass")]
	public unsafe TSubclassOf<UObject> GetObjectClass()
	{
		CheckDestroyed();
		if (!GetObjectClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetObjectClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObjectClass_FunctionAddress, intPtr, GetObjectClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObjectClass_ReturnValue_Offset), 0, GetObjectClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetLodDataUniqueIds")]
	public unsafe void GetLodDataUniqueIds(out List<string> OutLodDataUniqueIds)
	{
		CheckDestroyed();
		if (!GetLodDataUniqueIds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetLodDataUniqueIds");
			OutLodDataUniqueIds = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLodDataUniqueIds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLodDataUniqueIds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLodDataUniqueIds_FunctionAddress, intPtr, GetLodDataUniqueIds_ParamsSize);
		OutLodDataUniqueIds = new TArrayCopyMarshaler<string>(1, GetLodDataUniqueIds_OutLodDataUniqueIds_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetLodDataUniqueIds_OutLodDataUniqueIds_Offset));
		NativeReflection.DestroyValue_InContainer(GetLodDataUniqueIds_OutLodDataUniqueIds_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetLodDataCount")]
	public unsafe int GetLodDataCount()
	{
		CheckDestroyed();
		if (!GetLodDataCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetLodDataCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLodDataCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLodDataCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLodDataCount_FunctionAddress, intPtr, GetLodDataCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLodDataCount_ReturnValue_Offset), 0, GetLodDataCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorReplace")]
	public unsafe bool GetCustomVertexColorReplace(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomVertexColorReplace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorReplace");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomVertexColorReplace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomVertexColorReplace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomVertexColorReplace_FunctionAddress, intPtr, GetCustomVertexColorReplace_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomVertexColorReplace_AttributeValue_Offset), 0, GetCustomVertexColorReplace_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomVertexColorReplace_ReturnValue_Offset), 0, GetCustomVertexColorReplace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorOverride")]
	public unsafe bool GetCustomVertexColorOverride(out FColor AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomVertexColorOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorOverride");
			AttributeValue = default(FColor);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomVertexColorOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomVertexColorOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomVertexColorOverride_FunctionAddress, intPtr, GetCustomVertexColorOverride_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, GetCustomVertexColorOverride_AttributeValue_Offset), 0, GetCustomVertexColorOverride_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomVertexColorOverride_ReturnValue_Offset), 0, GetCustomVertexColorOverride_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorIgnore")]
	public unsafe bool GetCustomVertexColorIgnore(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomVertexColorIgnore_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorIgnore");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomVertexColorIgnore_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomVertexColorIgnore_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomVertexColorIgnore_FunctionAddress, intPtr, GetCustomVertexColorIgnore_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomVertexColorIgnore_AttributeValue_Offset), 0, GetCustomVertexColorIgnore_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomVertexColorIgnore_ReturnValue_Offset), 0, GetCustomVertexColorIgnore_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomSkeletonSoftObjectPath")]
	public unsafe bool GetCustomSkeletonSoftObjectPath(out FSoftObjectPath AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomSkeletonSoftObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomSkeletonSoftObjectPath");
			AttributeValue = default(FSoftObjectPath);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomSkeletonSoftObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomSkeletonSoftObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomSkeletonSoftObjectPath_FunctionAddress, intPtr, GetCustomSkeletonSoftObjectPath_ParamsSize);
		AttributeValue = FSoftObjectPath.FromNative(IntPtr.Add(intPtr, GetCustomSkeletonSoftObjectPath_AttributeValue_Offset), 0, GetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomSkeletonSoftObjectPath_ReturnValue_Offset), 0, GetCustomSkeletonSoftObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomPhysicAssetSoftObjectPath")]
	public unsafe bool GetCustomPhysicAssetSoftObjectPath(out FSoftObjectPath AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomPhysicAssetSoftObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomPhysicAssetSoftObjectPath");
			AttributeValue = default(FSoftObjectPath);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomPhysicAssetSoftObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomPhysicAssetSoftObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomPhysicAssetSoftObjectPath_FunctionAddress, intPtr, GetCustomPhysicAssetSoftObjectPath_ParamsSize);
		AttributeValue = FSoftObjectPath.FromNative(IntPtr.Add(intPtr, GetCustomPhysicAssetSoftObjectPath_AttributeValue_Offset), 0, GetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomPhysicAssetSoftObjectPath_ReturnValue_Offset), 0, GetCustomPhysicAssetSoftObjectPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomImportMorphTarget")]
	public unsafe bool GetCustomImportMorphTarget(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomImportMorphTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomImportMorphTarget");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomImportMorphTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomImportMorphTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomImportMorphTarget_FunctionAddress, intPtr, GetCustomImportMorphTarget_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomImportMorphTarget_AttributeValue_Offset), 0, GetCustomImportMorphTarget_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomImportMorphTarget_ReturnValue_Offset), 0, GetCustomImportMorphTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomCreatePhysicsAsset")]
	public unsafe bool GetCustomCreatePhysicsAsset(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomCreatePhysicsAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomCreatePhysicsAsset");
			AttributeValue = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomCreatePhysicsAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomCreatePhysicsAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomCreatePhysicsAsset_FunctionAddress, intPtr, GetCustomCreatePhysicsAsset_ParamsSize);
		AttributeValue = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomCreatePhysicsAsset_AttributeValue_Offset), 0, GetCustomCreatePhysicsAsset_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomCreatePhysicsAsset_ReturnValue_Offset), 0, GetCustomCreatePhysicsAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:AddLodDataUniqueId")]
	public unsafe bool AddLodDataUniqueId(string LodDataUniqueId)
	{
		CheckDestroyed();
		if (!AddLodDataUniqueId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:AddLodDataUniqueId");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLodDataUniqueId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLodDataUniqueId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLodDataUniqueId_LodDataUniqueId_Offset), 0, AddLodDataUniqueId_LodDataUniqueId_PropertyAddress.Address, LodDataUniqueId);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddLodDataUniqueId_FunctionAddress, intPtr, AddLodDataUniqueId_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLodDataUniqueId_LodDataUniqueId_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddLodDataUniqueId_ReturnValue_Offset), 0, AddLodDataUniqueId_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeSkeletalMeshFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeSkeletalMeshFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeSkeletalMeshFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode");
		SetCustomVertexColorReplace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomVertexColorReplace");
		SetCustomVertexColorReplace_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomVertexColorReplace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorReplace_AttributeValue_PropertyAddress, SetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		SetCustomVertexColorReplace_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		SetCustomVertexColorReplace_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorReplace_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorReplace_ReturnValue_PropertyAddress, SetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		SetCustomVertexColorReplace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		SetCustomVertexColorReplace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorReplace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomVertexColorReplace_IsValid = SetCustomVertexColorReplace_FunctionAddress != IntPtr.Zero && SetCustomVertexColorReplace_AttributeValue_IsValid && SetCustomVertexColorReplace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorReplace", SetCustomVertexColorReplace_IsValid);
		SetCustomVertexColorOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomVertexColorOverride");
		SetCustomVertexColorOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomVertexColorOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorOverride_AttributeValue_PropertyAddress, SetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		SetCustomVertexColorOverride_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		SetCustomVertexColorOverride_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorOverride_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorOverride_ReturnValue_PropertyAddress, SetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		SetCustomVertexColorOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		SetCustomVertexColorOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorOverride_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomVertexColorOverride_IsValid = SetCustomVertexColorOverride_FunctionAddress != IntPtr.Zero && SetCustomVertexColorOverride_AttributeValue_IsValid && SetCustomVertexColorOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorOverride", SetCustomVertexColorOverride_IsValid);
		SetCustomVertexColorIgnore_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomVertexColorIgnore");
		SetCustomVertexColorIgnore_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomVertexColorIgnore_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorIgnore_AttributeValue_PropertyAddress, SetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		SetCustomVertexColorIgnore_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		SetCustomVertexColorIgnore_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorIgnore_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorIgnore_ReturnValue_PropertyAddress, SetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		SetCustomVertexColorIgnore_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		SetCustomVertexColorIgnore_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorIgnore_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomVertexColorIgnore_IsValid = SetCustomVertexColorIgnore_FunctionAddress != IntPtr.Zero && SetCustomVertexColorIgnore_AttributeValue_IsValid && SetCustomVertexColorIgnore_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomVertexColorIgnore", SetCustomVertexColorIgnore_IsValid);
		SetCustomSkeletonSoftObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomSkeletonSoftObjectPath");
		SetCustomSkeletonSoftObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomSkeletonSoftObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress, SetCustomSkeletonSoftObjectPath_FunctionAddress, "AttributeValue");
		SetCustomSkeletonSoftObjectPath_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomSkeletonSoftObjectPath_FunctionAddress, "AttributeValue");
		SetCustomSkeletonSoftObjectPath_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomSkeletonSoftObjectPath_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomSkeletonSoftObjectPath_ReturnValue_PropertyAddress, SetCustomSkeletonSoftObjectPath_FunctionAddress, "ReturnValue");
		SetCustomSkeletonSoftObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomSkeletonSoftObjectPath_FunctionAddress, "ReturnValue");
		SetCustomSkeletonSoftObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomSkeletonSoftObjectPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomSkeletonSoftObjectPath_IsValid = SetCustomSkeletonSoftObjectPath_FunctionAddress != IntPtr.Zero && SetCustomSkeletonSoftObjectPath_AttributeValue_IsValid && SetCustomSkeletonSoftObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomSkeletonSoftObjectPath", SetCustomSkeletonSoftObjectPath_IsValid);
		SetCustomPhysicAssetSoftObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomPhysicAssetSoftObjectPath");
		SetCustomPhysicAssetSoftObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomPhysicAssetSoftObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress, SetCustomPhysicAssetSoftObjectPath_FunctionAddress, "AttributeValue");
		SetCustomPhysicAssetSoftObjectPath_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPhysicAssetSoftObjectPath_FunctionAddress, "AttributeValue");
		SetCustomPhysicAssetSoftObjectPath_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPhysicAssetSoftObjectPath_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomPhysicAssetSoftObjectPath_ReturnValue_PropertyAddress, SetCustomPhysicAssetSoftObjectPath_FunctionAddress, "ReturnValue");
		SetCustomPhysicAssetSoftObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomPhysicAssetSoftObjectPath_FunctionAddress, "ReturnValue");
		SetCustomPhysicAssetSoftObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomPhysicAssetSoftObjectPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomPhysicAssetSoftObjectPath_IsValid = SetCustomPhysicAssetSoftObjectPath_FunctionAddress != IntPtr.Zero && SetCustomPhysicAssetSoftObjectPath_AttributeValue_IsValid && SetCustomPhysicAssetSoftObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomPhysicAssetSoftObjectPath", SetCustomPhysicAssetSoftObjectPath_IsValid);
		SetCustomImportMorphTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomImportMorphTarget");
		SetCustomImportMorphTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomImportMorphTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomImportMorphTarget_AttributeValue_PropertyAddress, SetCustomImportMorphTarget_FunctionAddress, "AttributeValue");
		SetCustomImportMorphTarget_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomImportMorphTarget_FunctionAddress, "AttributeValue");
		SetCustomImportMorphTarget_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomImportMorphTarget_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomImportMorphTarget_ReturnValue_PropertyAddress, SetCustomImportMorphTarget_FunctionAddress, "ReturnValue");
		SetCustomImportMorphTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomImportMorphTarget_FunctionAddress, "ReturnValue");
		SetCustomImportMorphTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomImportMorphTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomImportMorphTarget_IsValid = SetCustomImportMorphTarget_FunctionAddress != IntPtr.Zero && SetCustomImportMorphTarget_AttributeValue_IsValid && SetCustomImportMorphTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomImportMorphTarget", SetCustomImportMorphTarget_IsValid);
		SetCustomCreatePhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomCreatePhysicsAsset");
		SetCustomCreatePhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomCreatePhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomCreatePhysicsAsset_AttributeValue_PropertyAddress, SetCustomCreatePhysicsAsset_FunctionAddress, "AttributeValue");
		SetCustomCreatePhysicsAsset_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomCreatePhysicsAsset_FunctionAddress, "AttributeValue");
		SetCustomCreatePhysicsAsset_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomCreatePhysicsAsset_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomCreatePhysicsAsset_ReturnValue_PropertyAddress, SetCustomCreatePhysicsAsset_FunctionAddress, "ReturnValue");
		SetCustomCreatePhysicsAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomCreatePhysicsAsset_FunctionAddress, "ReturnValue");
		SetCustomCreatePhysicsAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomCreatePhysicsAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomCreatePhysicsAsset_IsValid = SetCustomCreatePhysicsAsset_FunctionAddress != IntPtr.Zero && SetCustomCreatePhysicsAsset_AttributeValue_IsValid && SetCustomCreatePhysicsAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:SetCustomCreatePhysicsAsset", SetCustomCreatePhysicsAsset_IsValid);
		RemoveLodDataUniqueId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveLodDataUniqueId");
		RemoveLodDataUniqueId_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveLodDataUniqueId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveLodDataUniqueId_LodDataUniqueId_PropertyAddress, RemoveLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		RemoveLodDataUniqueId_LodDataUniqueId_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		RemoveLodDataUniqueId_LodDataUniqueId_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLodDataUniqueId_FunctionAddress, "LodDataUniqueId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLodDataUniqueId_ReturnValue_PropertyAddress, RemoveLodDataUniqueId_FunctionAddress, "ReturnValue");
		RemoveLodDataUniqueId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLodDataUniqueId_FunctionAddress, "ReturnValue");
		RemoveLodDataUniqueId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLodDataUniqueId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveLodDataUniqueId_IsValid = RemoveLodDataUniqueId_FunctionAddress != IntPtr.Zero && RemoveLodDataUniqueId_LodDataUniqueId_IsValid && RemoveLodDataUniqueId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:RemoveLodDataUniqueId", RemoveLodDataUniqueId_IsValid);
		InitializeSkeletalMeshNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeSkeletalMeshNode");
		InitializeSkeletalMeshNode_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeSkeletalMeshNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeSkeletalMeshNode_UniqueID_PropertyAddress, InitializeSkeletalMeshNode_FunctionAddress, "UniqueID");
		InitializeSkeletalMeshNode_UniqueID_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSkeletalMeshNode_FunctionAddress, "UniqueID");
		InitializeSkeletalMeshNode_UniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSkeletalMeshNode_FunctionAddress, "UniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeSkeletalMeshNode_DisplayLabel_PropertyAddress, InitializeSkeletalMeshNode_FunctionAddress, "DisplayLabel");
		InitializeSkeletalMeshNode_DisplayLabel_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSkeletalMeshNode_FunctionAddress, "DisplayLabel");
		InitializeSkeletalMeshNode_DisplayLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSkeletalMeshNode_FunctionAddress, "DisplayLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeSkeletalMeshNode_InAssetClass_PropertyAddress, InitializeSkeletalMeshNode_FunctionAddress, "InAssetClass");
		InitializeSkeletalMeshNode_InAssetClass_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSkeletalMeshNode_FunctionAddress, "InAssetClass");
		InitializeSkeletalMeshNode_InAssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSkeletalMeshNode_FunctionAddress, "InAssetClass", Classes.FStrProperty);
		InitializeSkeletalMeshNode_IsValid = InitializeSkeletalMeshNode_FunctionAddress != IntPtr.Zero && InitializeSkeletalMeshNode_UniqueID_IsValid && InitializeSkeletalMeshNode_DisplayLabel_IsValid && InitializeSkeletalMeshNode_InAssetClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:InitializeSkeletalMeshNode", InitializeSkeletalMeshNode_IsValid);
		GetObjectClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObjectClass");
		GetObjectClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectClass_ReturnValue_PropertyAddress, GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetObjectClass_IsValid = GetObjectClass_FunctionAddress != IntPtr.Zero && GetObjectClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetObjectClass", GetObjectClass_IsValid);
		GetLodDataUniqueIds_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodDataUniqueIds");
		GetLodDataUniqueIds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodDataUniqueIds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodDataUniqueIds_OutLodDataUniqueIds_PropertyAddress, GetLodDataUniqueIds_FunctionAddress, "OutLodDataUniqueIds");
		GetLodDataUniqueIds_OutLodDataUniqueIds_Offset = NativeReflectionCached.GetPropertyOffset(GetLodDataUniqueIds_FunctionAddress, "OutLodDataUniqueIds");
		GetLodDataUniqueIds_OutLodDataUniqueIds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodDataUniqueIds_FunctionAddress, "OutLodDataUniqueIds", Classes.FArrayProperty);
		GetLodDataUniqueIds_IsValid = GetLodDataUniqueIds_FunctionAddress != IntPtr.Zero && GetLodDataUniqueIds_OutLodDataUniqueIds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetLodDataUniqueIds", GetLodDataUniqueIds_IsValid);
		GetLodDataCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodDataCount");
		GetLodDataCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodDataCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodDataCount_ReturnValue_PropertyAddress, GetLodDataCount_FunctionAddress, "ReturnValue");
		GetLodDataCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLodDataCount_FunctionAddress, "ReturnValue");
		GetLodDataCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodDataCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLodDataCount_IsValid = GetLodDataCount_FunctionAddress != IntPtr.Zero && GetLodDataCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetLodDataCount", GetLodDataCount_IsValid);
		GetCustomVertexColorReplace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomVertexColorReplace");
		GetCustomVertexColorReplace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomVertexColorReplace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorReplace_AttributeValue_PropertyAddress, GetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		GetCustomVertexColorReplace_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		GetCustomVertexColorReplace_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorReplace_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorReplace_ReturnValue_PropertyAddress, GetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		GetCustomVertexColorReplace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		GetCustomVertexColorReplace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorReplace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomVertexColorReplace_IsValid = GetCustomVertexColorReplace_FunctionAddress != IntPtr.Zero && GetCustomVertexColorReplace_AttributeValue_IsValid && GetCustomVertexColorReplace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorReplace", GetCustomVertexColorReplace_IsValid);
		GetCustomVertexColorOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomVertexColorOverride");
		GetCustomVertexColorOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomVertexColorOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorOverride_AttributeValue_PropertyAddress, GetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		GetCustomVertexColorOverride_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		GetCustomVertexColorOverride_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorOverride_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorOverride_ReturnValue_PropertyAddress, GetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		GetCustomVertexColorOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		GetCustomVertexColorOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorOverride_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomVertexColorOverride_IsValid = GetCustomVertexColorOverride_FunctionAddress != IntPtr.Zero && GetCustomVertexColorOverride_AttributeValue_IsValid && GetCustomVertexColorOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorOverride", GetCustomVertexColorOverride_IsValid);
		GetCustomVertexColorIgnore_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomVertexColorIgnore");
		GetCustomVertexColorIgnore_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomVertexColorIgnore_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorIgnore_AttributeValue_PropertyAddress, GetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		GetCustomVertexColorIgnore_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		GetCustomVertexColorIgnore_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorIgnore_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorIgnore_ReturnValue_PropertyAddress, GetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		GetCustomVertexColorIgnore_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		GetCustomVertexColorIgnore_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorIgnore_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomVertexColorIgnore_IsValid = GetCustomVertexColorIgnore_FunctionAddress != IntPtr.Zero && GetCustomVertexColorIgnore_AttributeValue_IsValid && GetCustomVertexColorIgnore_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomVertexColorIgnore", GetCustomVertexColorIgnore_IsValid);
		GetCustomSkeletonSoftObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomSkeletonSoftObjectPath");
		GetCustomSkeletonSoftObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomSkeletonSoftObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomSkeletonSoftObjectPath_AttributeValue_PropertyAddress, GetCustomSkeletonSoftObjectPath_FunctionAddress, "AttributeValue");
		GetCustomSkeletonSoftObjectPath_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomSkeletonSoftObjectPath_FunctionAddress, "AttributeValue");
		GetCustomSkeletonSoftObjectPath_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomSkeletonSoftObjectPath_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomSkeletonSoftObjectPath_ReturnValue_PropertyAddress, GetCustomSkeletonSoftObjectPath_FunctionAddress, "ReturnValue");
		GetCustomSkeletonSoftObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomSkeletonSoftObjectPath_FunctionAddress, "ReturnValue");
		GetCustomSkeletonSoftObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomSkeletonSoftObjectPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomSkeletonSoftObjectPath_IsValid = GetCustomSkeletonSoftObjectPath_FunctionAddress != IntPtr.Zero && GetCustomSkeletonSoftObjectPath_AttributeValue_IsValid && GetCustomSkeletonSoftObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomSkeletonSoftObjectPath", GetCustomSkeletonSoftObjectPath_IsValid);
		GetCustomPhysicAssetSoftObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomPhysicAssetSoftObjectPath");
		GetCustomPhysicAssetSoftObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomPhysicAssetSoftObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPhysicAssetSoftObjectPath_AttributeValue_PropertyAddress, GetCustomPhysicAssetSoftObjectPath_FunctionAddress, "AttributeValue");
		GetCustomPhysicAssetSoftObjectPath_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPhysicAssetSoftObjectPath_FunctionAddress, "AttributeValue");
		GetCustomPhysicAssetSoftObjectPath_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPhysicAssetSoftObjectPath_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPhysicAssetSoftObjectPath_ReturnValue_PropertyAddress, GetCustomPhysicAssetSoftObjectPath_FunctionAddress, "ReturnValue");
		GetCustomPhysicAssetSoftObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPhysicAssetSoftObjectPath_FunctionAddress, "ReturnValue");
		GetCustomPhysicAssetSoftObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPhysicAssetSoftObjectPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomPhysicAssetSoftObjectPath_IsValid = GetCustomPhysicAssetSoftObjectPath_FunctionAddress != IntPtr.Zero && GetCustomPhysicAssetSoftObjectPath_AttributeValue_IsValid && GetCustomPhysicAssetSoftObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomPhysicAssetSoftObjectPath", GetCustomPhysicAssetSoftObjectPath_IsValid);
		GetCustomImportMorphTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomImportMorphTarget");
		GetCustomImportMorphTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomImportMorphTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomImportMorphTarget_AttributeValue_PropertyAddress, GetCustomImportMorphTarget_FunctionAddress, "AttributeValue");
		GetCustomImportMorphTarget_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomImportMorphTarget_FunctionAddress, "AttributeValue");
		GetCustomImportMorphTarget_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomImportMorphTarget_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomImportMorphTarget_ReturnValue_PropertyAddress, GetCustomImportMorphTarget_FunctionAddress, "ReturnValue");
		GetCustomImportMorphTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomImportMorphTarget_FunctionAddress, "ReturnValue");
		GetCustomImportMorphTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomImportMorphTarget_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomImportMorphTarget_IsValid = GetCustomImportMorphTarget_FunctionAddress != IntPtr.Zero && GetCustomImportMorphTarget_AttributeValue_IsValid && GetCustomImportMorphTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomImportMorphTarget", GetCustomImportMorphTarget_IsValid);
		GetCustomCreatePhysicsAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomCreatePhysicsAsset");
		GetCustomCreatePhysicsAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomCreatePhysicsAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomCreatePhysicsAsset_AttributeValue_PropertyAddress, GetCustomCreatePhysicsAsset_FunctionAddress, "AttributeValue");
		GetCustomCreatePhysicsAsset_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomCreatePhysicsAsset_FunctionAddress, "AttributeValue");
		GetCustomCreatePhysicsAsset_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomCreatePhysicsAsset_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomCreatePhysicsAsset_ReturnValue_PropertyAddress, GetCustomCreatePhysicsAsset_FunctionAddress, "ReturnValue");
		GetCustomCreatePhysicsAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomCreatePhysicsAsset_FunctionAddress, "ReturnValue");
		GetCustomCreatePhysicsAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomCreatePhysicsAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomCreatePhysicsAsset_IsValid = GetCustomCreatePhysicsAsset_FunctionAddress != IntPtr.Zero && GetCustomCreatePhysicsAsset_AttributeValue_IsValid && GetCustomCreatePhysicsAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:GetCustomCreatePhysicsAsset", GetCustomCreatePhysicsAsset_IsValid);
		AddLodDataUniqueId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddLodDataUniqueId");
		AddLodDataUniqueId_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLodDataUniqueId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLodDataUniqueId_LodDataUniqueId_PropertyAddress, AddLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		AddLodDataUniqueId_LodDataUniqueId_Offset = NativeReflectionCached.GetPropertyOffset(AddLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		AddLodDataUniqueId_LodDataUniqueId_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLodDataUniqueId_FunctionAddress, "LodDataUniqueId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLodDataUniqueId_ReturnValue_PropertyAddress, AddLodDataUniqueId_FunctionAddress, "ReturnValue");
		AddLodDataUniqueId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLodDataUniqueId_FunctionAddress, "ReturnValue");
		AddLodDataUniqueId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLodDataUniqueId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddLodDataUniqueId_IsValid = AddLodDataUniqueId_FunctionAddress != IntPtr.Zero && AddLodDataUniqueId_LodDataUniqueId_IsValid && AddLodDataUniqueId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshFactoryNode:AddLodDataUniqueId", AddLodDataUniqueId_IsValid);
	}
}
