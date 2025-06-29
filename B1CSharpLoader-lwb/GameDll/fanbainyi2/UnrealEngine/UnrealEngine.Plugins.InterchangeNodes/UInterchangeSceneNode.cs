using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeSceneNode : UInterchangeBaseNode
{
	private static bool SetCustomLocalTransform_IsValid;

	private static IntPtr SetCustomLocalTransform_FunctionAddress;

	private static int SetCustomLocalTransform_ParamsSize;

	private static bool SetCustomLocalTransform_AttributeValue_IsValid;

	private static FFieldAddress SetCustomLocalTransform_AttributeValue_PropertyAddress;

	private static int SetCustomLocalTransform_AttributeValue_Offset;

	private static bool SetCustomLocalTransform_ReturnValue_IsValid;

	private static FFieldAddress SetCustomLocalTransform_ReturnValue_PropertyAddress;

	private static int SetCustomLocalTransform_ReturnValue_Offset;

	private static bool SetCustomGlobalTransform_IsValid;

	private static IntPtr SetCustomGlobalTransform_FunctionAddress;

	private static int SetCustomGlobalTransform_ParamsSize;

	private static bool SetCustomGlobalTransform_AttributeValue_IsValid;

	private static FFieldAddress SetCustomGlobalTransform_AttributeValue_PropertyAddress;

	private static int SetCustomGlobalTransform_AttributeValue_Offset;

	private static bool SetCustomGlobalTransform_ReturnValue_IsValid;

	private static FFieldAddress SetCustomGlobalTransform_ReturnValue_PropertyAddress;

	private static int SetCustomGlobalTransform_ReturnValue_Offset;

	private static bool SetCustomAssetInstanceUid_IsValid;

	private static IntPtr SetCustomAssetInstanceUid_FunctionAddress;

	private static int SetCustomAssetInstanceUid_ParamsSize;

	private static bool SetCustomAssetInstanceUid_AttributeValue_IsValid;

	private static FFieldAddress SetCustomAssetInstanceUid_AttributeValue_PropertyAddress;

	private static int SetCustomAssetInstanceUid_AttributeValue_Offset;

	private static bool SetCustomAssetInstanceUid_ReturnValue_IsValid;

	private static FFieldAddress SetCustomAssetInstanceUid_ReturnValue_PropertyAddress;

	private static int SetCustomAssetInstanceUid_ReturnValue_Offset;

	private static bool RemoveSpecializedType_IsValid;

	private static IntPtr RemoveSpecializedType_FunctionAddress;

	private static int RemoveSpecializedType_ParamsSize;

	private static bool RemoveSpecializedType_SpecializedType_IsValid;

	private static FFieldAddress RemoveSpecializedType_SpecializedType_PropertyAddress;

	private static int RemoveSpecializedType_SpecializedType_Offset;

	private static bool RemoveSpecializedType_ReturnValue_IsValid;

	private static FFieldAddress RemoveSpecializedType_ReturnValue_PropertyAddress;

	private static int RemoveSpecializedType_ReturnValue_Offset;

	private static bool RemoveMaterialDependencyUid_IsValid;

	private static IntPtr RemoveMaterialDependencyUid_FunctionAddress;

	private static int RemoveMaterialDependencyUid_ParamsSize;

	private static bool RemoveMaterialDependencyUid_MaterialDependencyUid_IsValid;

	private static FFieldAddress RemoveMaterialDependencyUid_MaterialDependencyUid_PropertyAddress;

	private static int RemoveMaterialDependencyUid_MaterialDependencyUid_Offset;

	private static bool RemoveMaterialDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveMaterialDependencyUid_ReturnValue_PropertyAddress;

	private static int RemoveMaterialDependencyUid_ReturnValue_Offset;

	private static bool IsSpecializedTypeContains_IsValid;

	private static IntPtr IsSpecializedTypeContains_FunctionAddress;

	private static int IsSpecializedTypeContains_ParamsSize;

	private static bool IsSpecializedTypeContains_SpecializedType_IsValid;

	private static FFieldAddress IsSpecializedTypeContains_SpecializedType_PropertyAddress;

	private static int IsSpecializedTypeContains_SpecializedType_Offset;

	private static bool IsSpecializedTypeContains_ReturnValue_IsValid;

	private static FFieldAddress IsSpecializedTypeContains_ReturnValue_PropertyAddress;

	private static int IsSpecializedTypeContains_ReturnValue_Offset;

	private static bool GetSpecializedTypes_IsValid;

	private static IntPtr GetSpecializedTypes_FunctionAddress;

	private static int GetSpecializedTypes_ParamsSize;

	private static bool GetSpecializedTypes_OutSpecializedTypes_IsValid;

	private static FFieldAddress GetSpecializedTypes_OutSpecializedTypes_PropertyAddress;

	private static int GetSpecializedTypes_OutSpecializedTypes_Offset;

	private static bool GetSpecializedTypeCount_IsValid;

	private static IntPtr GetSpecializedTypeCount_FunctionAddress;

	private static int GetSpecializedTypeCount_ParamsSize;

	private static bool GetSpecializedTypeCount_ReturnValue_IsValid;

	private static FFieldAddress GetSpecializedTypeCount_ReturnValue_PropertyAddress;

	private static int GetSpecializedTypeCount_ReturnValue_Offset;

	private static bool GetSpecializedType_IsValid;

	private static IntPtr GetSpecializedType_FunctionAddress;

	private static int GetSpecializedType_ParamsSize;

	private static bool GetSpecializedType_Index_IsValid;

	private static FFieldAddress GetSpecializedType_Index_PropertyAddress;

	private static int GetSpecializedType_Index_Offset;

	private static bool GetSpecializedType_OutSpecializedType_IsValid;

	private static FFieldAddress GetSpecializedType_OutSpecializedType_PropertyAddress;

	private static int GetSpecializedType_OutSpecializedType_Offset;

	private static bool GetMaterialDependencyUidsCount_IsValid;

	private static IntPtr GetMaterialDependencyUidsCount_FunctionAddress;

	private static int GetMaterialDependencyUidsCount_ParamsSize;

	private static bool GetMaterialDependencyUidsCount_ReturnValue_IsValid;

	private static FFieldAddress GetMaterialDependencyUidsCount_ReturnValue_PropertyAddress;

	private static int GetMaterialDependencyUidsCount_ReturnValue_Offset;

	private static bool GetMaterialDependencyUids_IsValid;

	private static IntPtr GetMaterialDependencyUids_FunctionAddress;

	private static int GetMaterialDependencyUids_ParamsSize;

	private static bool GetMaterialDependencyUids_OutMaterialDependencyUids_IsValid;

	private static FFieldAddress GetMaterialDependencyUids_OutMaterialDependencyUids_PropertyAddress;

	private static int GetMaterialDependencyUids_OutMaterialDependencyUids_Offset;

	private static bool GetMaterialDependencyUid_IsValid;

	private static IntPtr GetMaterialDependencyUid_FunctionAddress;

	private static int GetMaterialDependencyUid_ParamsSize;

	private static bool GetMaterialDependencyUid_Index_IsValid;

	private static FFieldAddress GetMaterialDependencyUid_Index_PropertyAddress;

	private static int GetMaterialDependencyUid_Index_Offset;

	private static bool GetMaterialDependencyUid_OutMaterialDependencyUid_IsValid;

	private static FFieldAddress GetMaterialDependencyUid_OutMaterialDependencyUid_PropertyAddress;

	private static int GetMaterialDependencyUid_OutMaterialDependencyUid_Offset;

	private static bool GetCustomLocalTransform_IsValid;

	private static IntPtr GetCustomLocalTransform_FunctionAddress;

	private static int GetCustomLocalTransform_ParamsSize;

	private static bool GetCustomLocalTransform_AttributeValue_IsValid;

	private static FFieldAddress GetCustomLocalTransform_AttributeValue_PropertyAddress;

	private static int GetCustomLocalTransform_AttributeValue_Offset;

	private static bool GetCustomLocalTransform_ReturnValue_IsValid;

	private static FFieldAddress GetCustomLocalTransform_ReturnValue_PropertyAddress;

	private static int GetCustomLocalTransform_ReturnValue_Offset;

	private static bool GetCustomGlobalTransform_IsValid;

	private static IntPtr GetCustomGlobalTransform_FunctionAddress;

	private static int GetCustomGlobalTransform_ParamsSize;

	private static bool GetCustomGlobalTransform_AttributeValue_IsValid;

	private static FFieldAddress GetCustomGlobalTransform_AttributeValue_PropertyAddress;

	private static int GetCustomGlobalTransform_AttributeValue_Offset;

	private static bool GetCustomGlobalTransform_ReturnValue_IsValid;

	private static FFieldAddress GetCustomGlobalTransform_ReturnValue_PropertyAddress;

	private static int GetCustomGlobalTransform_ReturnValue_Offset;

	private static bool GetCustomAssetInstanceUid_IsValid;

	private static IntPtr GetCustomAssetInstanceUid_FunctionAddress;

	private static int GetCustomAssetInstanceUid_ParamsSize;

	private static bool GetCustomAssetInstanceUid_AttributeValue_IsValid;

	private static FFieldAddress GetCustomAssetInstanceUid_AttributeValue_PropertyAddress;

	private static int GetCustomAssetInstanceUid_AttributeValue_Offset;

	private static bool GetCustomAssetInstanceUid_ReturnValue_IsValid;

	private static FFieldAddress GetCustomAssetInstanceUid_ReturnValue_PropertyAddress;

	private static int GetCustomAssetInstanceUid_ReturnValue_Offset;

	private static bool AddSpecializedType_IsValid;

	private static IntPtr AddSpecializedType_FunctionAddress;

	private static int AddSpecializedType_ParamsSize;

	private static bool AddSpecializedType_SpecializedType_IsValid;

	private static FFieldAddress AddSpecializedType_SpecializedType_PropertyAddress;

	private static int AddSpecializedType_SpecializedType_Offset;

	private static bool AddSpecializedType_ReturnValue_IsValid;

	private static FFieldAddress AddSpecializedType_ReturnValue_PropertyAddress;

	private static int AddSpecializedType_ReturnValue_Offset;

	private static bool AddMaterialDependencyUid_IsValid;

	private static IntPtr AddMaterialDependencyUid_FunctionAddress;

	private static int AddMaterialDependencyUid_ParamsSize;

	private static bool AddMaterialDependencyUid_MaterialDependencyUid_IsValid;

	private static FFieldAddress AddMaterialDependencyUid_MaterialDependencyUid_PropertyAddress;

	private static int AddMaterialDependencyUid_MaterialDependencyUid_Offset;

	private static bool AddMaterialDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress AddMaterialDependencyUid_ReturnValue_PropertyAddress;

	private static int AddMaterialDependencyUid_ReturnValue_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomLocalTransform")]
	public unsafe bool SetCustomLocalTransform(FTransform AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomLocalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomLocalTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomLocalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomLocalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCustomLocalTransform_AttributeValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetCustomLocalTransform_AttributeValue_Offset), 0, SetCustomLocalTransform_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomLocalTransform_FunctionAddress, intPtr, SetCustomLocalTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomLocalTransform_ReturnValue_Offset), 0, SetCustomLocalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomGlobalTransform")]
	public unsafe bool SetCustomGlobalTransform(FTransform AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomGlobalTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetCustomGlobalTransform_AttributeValue_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetCustomGlobalTransform_AttributeValue_Offset), 0, SetCustomGlobalTransform_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomGlobalTransform_FunctionAddress, intPtr, SetCustomGlobalTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomGlobalTransform_ReturnValue_Offset), 0, SetCustomGlobalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomAssetInstanceUid")]
	public unsafe bool SetCustomAssetInstanceUid(string AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomAssetInstanceUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomAssetInstanceUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomAssetInstanceUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomAssetInstanceUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomAssetInstanceUid_AttributeValue_Offset), 0, SetCustomAssetInstanceUid_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomAssetInstanceUid_FunctionAddress, intPtr, SetCustomAssetInstanceUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomAssetInstanceUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomAssetInstanceUid_ReturnValue_Offset), 0, SetCustomAssetInstanceUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:RemoveSpecializedType")]
	public unsafe bool RemoveSpecializedType(string SpecializedType)
	{
		CheckDestroyed();
		if (!RemoveSpecializedType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:RemoveSpecializedType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSpecializedType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSpecializedType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveSpecializedType_SpecializedType_Offset), 0, RemoveSpecializedType_SpecializedType_PropertyAddress.Address, SpecializedType);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSpecializedType_FunctionAddress, intPtr, RemoveSpecializedType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveSpecializedType_SpecializedType_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveSpecializedType_ReturnValue_Offset), 0, RemoveSpecializedType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:RemoveMaterialDependencyUid")]
	public unsafe bool RemoveMaterialDependencyUid(string MaterialDependencyUid)
	{
		CheckDestroyed();
		if (!RemoveMaterialDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:RemoveMaterialDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMaterialDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMaterialDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveMaterialDependencyUid_MaterialDependencyUid_Offset), 0, RemoveMaterialDependencyUid_MaterialDependencyUid_PropertyAddress.Address, MaterialDependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveMaterialDependencyUid_FunctionAddress, intPtr, RemoveMaterialDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveMaterialDependencyUid_MaterialDependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveMaterialDependencyUid_ReturnValue_Offset), 0, RemoveMaterialDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:IsSpecializedTypeContains")]
	public unsafe bool IsSpecializedTypeContains(string SpecializedType)
	{
		CheckDestroyed();
		if (!IsSpecializedTypeContains_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:IsSpecializedTypeContains");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSpecializedTypeContains_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSpecializedTypeContains_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsSpecializedTypeContains_SpecializedType_Offset), 0, IsSpecializedTypeContains_SpecializedType_PropertyAddress.Address, SpecializedType);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSpecializedTypeContains_FunctionAddress, intPtr, IsSpecializedTypeContains_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsSpecializedTypeContains_SpecializedType_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSpecializedTypeContains_ReturnValue_Offset), 0, IsSpecializedTypeContains_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedTypes")]
	public unsafe void GetSpecializedTypes(out List<string> OutSpecializedTypes)
	{
		CheckDestroyed();
		if (!GetSpecializedTypes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedTypes");
			OutSpecializedTypes = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpecializedTypes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpecializedTypes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpecializedTypes_FunctionAddress, intPtr, GetSpecializedTypes_ParamsSize);
		OutSpecializedTypes = new TArrayCopyMarshaler<string>(1, GetSpecializedTypes_OutSpecializedTypes_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSpecializedTypes_OutSpecializedTypes_Offset));
		NativeReflection.DestroyValue_InContainer(GetSpecializedTypes_OutSpecializedTypes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedTypeCount")]
	public unsafe int GetSpecializedTypeCount()
	{
		CheckDestroyed();
		if (!GetSpecializedTypeCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedTypeCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpecializedTypeCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpecializedTypeCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpecializedTypeCount_FunctionAddress, intPtr, GetSpecializedTypeCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSpecializedTypeCount_ReturnValue_Offset), 0, GetSpecializedTypeCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedType")]
	public unsafe void GetSpecializedType(int Index, out string OutSpecializedType)
	{
		CheckDestroyed();
		if (!GetSpecializedType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedType");
			OutSpecializedType = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpecializedType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpecializedType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetSpecializedType_Index_Offset), 0, GetSpecializedType_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpecializedType_FunctionAddress, intPtr, GetSpecializedType_ParamsSize);
		OutSpecializedType = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSpecializedType_OutSpecializedType_Offset), 0, GetSpecializedType_OutSpecializedType_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSpecializedType_OutSpecializedType_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUidsCount")]
	public unsafe int GetMaterialDependencyUidsCount()
	{
		CheckDestroyed();
		if (!GetMaterialDependencyUidsCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUidsCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialDependencyUidsCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialDependencyUidsCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialDependencyUidsCount_FunctionAddress, intPtr, GetMaterialDependencyUidsCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaterialDependencyUidsCount_ReturnValue_Offset), 0, GetMaterialDependencyUidsCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUids")]
	public unsafe void GetMaterialDependencyUids(out List<string> OutMaterialDependencyUids)
	{
		CheckDestroyed();
		if (!GetMaterialDependencyUids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUids");
			OutMaterialDependencyUids = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialDependencyUids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialDependencyUids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialDependencyUids_FunctionAddress, intPtr, GetMaterialDependencyUids_ParamsSize);
		OutMaterialDependencyUids = new TArrayCopyMarshaler<string>(1, GetMaterialDependencyUids_OutMaterialDependencyUids_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetMaterialDependencyUids_OutMaterialDependencyUids_Offset));
		NativeReflection.DestroyValue_InContainer(GetMaterialDependencyUids_OutMaterialDependencyUids_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUid")]
	public unsafe void GetMaterialDependencyUid(int Index, out string OutMaterialDependencyUid)
	{
		CheckDestroyed();
		if (!GetMaterialDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUid");
			OutMaterialDependencyUid = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaterialDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaterialDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMaterialDependencyUid_Index_Offset), 0, GetMaterialDependencyUid_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaterialDependencyUid_FunctionAddress, intPtr, GetMaterialDependencyUid_ParamsSize);
		OutMaterialDependencyUid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMaterialDependencyUid_OutMaterialDependencyUid_Offset), 0, GetMaterialDependencyUid_OutMaterialDependencyUid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMaterialDependencyUid_OutMaterialDependencyUid_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomLocalTransform")]
	public unsafe bool GetCustomLocalTransform(out FTransform AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomLocalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomLocalTransform");
			AttributeValue = default(FTransform);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomLocalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomLocalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCustomLocalTransform_AttributeValue_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomLocalTransform_FunctionAddress, intPtr, GetCustomLocalTransform_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetCustomLocalTransform_AttributeValue_Offset), 0, GetCustomLocalTransform_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomLocalTransform_ReturnValue_Offset), 0, GetCustomLocalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomGlobalTransform")]
	public unsafe bool GetCustomGlobalTransform(out FTransform AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomGlobalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomGlobalTransform");
			AttributeValue = default(FTransform);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomGlobalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomGlobalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCustomGlobalTransform_AttributeValue_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomGlobalTransform_FunctionAddress, intPtr, GetCustomGlobalTransform_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetCustomGlobalTransform_AttributeValue_Offset), 0, GetCustomGlobalTransform_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomGlobalTransform_ReturnValue_Offset), 0, GetCustomGlobalTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomAssetInstanceUid")]
	public unsafe bool GetCustomAssetInstanceUid(out string AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomAssetInstanceUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomAssetInstanceUid");
			AttributeValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomAssetInstanceUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomAssetInstanceUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomAssetInstanceUid_FunctionAddress, intPtr, GetCustomAssetInstanceUid_ParamsSize);
		AttributeValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomAssetInstanceUid_AttributeValue_Offset), 0, GetCustomAssetInstanceUid_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomAssetInstanceUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomAssetInstanceUid_ReturnValue_Offset), 0, GetCustomAssetInstanceUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:AddSpecializedType")]
	public unsafe bool AddSpecializedType(string SpecializedType)
	{
		CheckDestroyed();
		if (!AddSpecializedType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:AddSpecializedType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSpecializedType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSpecializedType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddSpecializedType_SpecializedType_Offset), 0, AddSpecializedType_SpecializedType_PropertyAddress.Address, SpecializedType);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSpecializedType_FunctionAddress, intPtr, AddSpecializedType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSpecializedType_SpecializedType_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddSpecializedType_ReturnValue_Offset), 0, AddSpecializedType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSceneNode:AddMaterialDependencyUid")]
	public unsafe bool AddMaterialDependencyUid(string MaterialDependencyUid)
	{
		CheckDestroyed();
		if (!AddMaterialDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSceneNode:AddMaterialDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMaterialDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMaterialDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddMaterialDependencyUid_MaterialDependencyUid_Offset), 0, AddMaterialDependencyUid_MaterialDependencyUid_PropertyAddress.Address, MaterialDependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMaterialDependencyUid_FunctionAddress, intPtr, AddMaterialDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMaterialDependencyUid_MaterialDependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddMaterialDependencyUid_ReturnValue_Offset), 0, AddMaterialDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeSceneNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeSceneNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeSceneNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeSceneNode");
		SetCustomLocalTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomLocalTransform");
		SetCustomLocalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomLocalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomLocalTransform_AttributeValue_PropertyAddress, SetCustomLocalTransform_FunctionAddress, "AttributeValue");
		SetCustomLocalTransform_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomLocalTransform_FunctionAddress, "AttributeValue");
		SetCustomLocalTransform_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomLocalTransform_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomLocalTransform_ReturnValue_PropertyAddress, SetCustomLocalTransform_FunctionAddress, "ReturnValue");
		SetCustomLocalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomLocalTransform_FunctionAddress, "ReturnValue");
		SetCustomLocalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomLocalTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomLocalTransform_IsValid = SetCustomLocalTransform_FunctionAddress != IntPtr.Zero && SetCustomLocalTransform_AttributeValue_IsValid && SetCustomLocalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomLocalTransform", SetCustomLocalTransform_IsValid);
		SetCustomGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomGlobalTransform");
		SetCustomGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomGlobalTransform_AttributeValue_PropertyAddress, SetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		SetCustomGlobalTransform_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		SetCustomGlobalTransform_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomGlobalTransform_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomGlobalTransform_ReturnValue_PropertyAddress, SetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		SetCustomGlobalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		SetCustomGlobalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomGlobalTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomGlobalTransform_IsValid = SetCustomGlobalTransform_FunctionAddress != IntPtr.Zero && SetCustomGlobalTransform_AttributeValue_IsValid && SetCustomGlobalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomGlobalTransform", SetCustomGlobalTransform_IsValid);
		SetCustomAssetInstanceUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomAssetInstanceUid");
		SetCustomAssetInstanceUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomAssetInstanceUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomAssetInstanceUid_AttributeValue_PropertyAddress, SetCustomAssetInstanceUid_FunctionAddress, "AttributeValue");
		SetCustomAssetInstanceUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomAssetInstanceUid_FunctionAddress, "AttributeValue");
		SetCustomAssetInstanceUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomAssetInstanceUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomAssetInstanceUid_ReturnValue_PropertyAddress, SetCustomAssetInstanceUid_FunctionAddress, "ReturnValue");
		SetCustomAssetInstanceUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomAssetInstanceUid_FunctionAddress, "ReturnValue");
		SetCustomAssetInstanceUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomAssetInstanceUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomAssetInstanceUid_IsValid = SetCustomAssetInstanceUid_FunctionAddress != IntPtr.Zero && SetCustomAssetInstanceUid_AttributeValue_IsValid && SetCustomAssetInstanceUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:SetCustomAssetInstanceUid", SetCustomAssetInstanceUid_IsValid);
		RemoveSpecializedType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveSpecializedType");
		RemoveSpecializedType_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSpecializedType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSpecializedType_SpecializedType_PropertyAddress, RemoveSpecializedType_FunctionAddress, "SpecializedType");
		RemoveSpecializedType_SpecializedType_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSpecializedType_FunctionAddress, "SpecializedType");
		RemoveSpecializedType_SpecializedType_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSpecializedType_FunctionAddress, "SpecializedType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSpecializedType_ReturnValue_PropertyAddress, RemoveSpecializedType_FunctionAddress, "ReturnValue");
		RemoveSpecializedType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSpecializedType_FunctionAddress, "ReturnValue");
		RemoveSpecializedType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSpecializedType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveSpecializedType_IsValid = RemoveSpecializedType_FunctionAddress != IntPtr.Zero && RemoveSpecializedType_SpecializedType_IsValid && RemoveSpecializedType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:RemoveSpecializedType", RemoveSpecializedType_IsValid);
		RemoveMaterialDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveMaterialDependencyUid");
		RemoveMaterialDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMaterialDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMaterialDependencyUid_MaterialDependencyUid_PropertyAddress, RemoveMaterialDependencyUid_FunctionAddress, "MaterialDependencyUid");
		RemoveMaterialDependencyUid_MaterialDependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMaterialDependencyUid_FunctionAddress, "MaterialDependencyUid");
		RemoveMaterialDependencyUid_MaterialDependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMaterialDependencyUid_FunctionAddress, "MaterialDependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMaterialDependencyUid_ReturnValue_PropertyAddress, RemoveMaterialDependencyUid_FunctionAddress, "ReturnValue");
		RemoveMaterialDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMaterialDependencyUid_FunctionAddress, "ReturnValue");
		RemoveMaterialDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMaterialDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveMaterialDependencyUid_IsValid = RemoveMaterialDependencyUid_FunctionAddress != IntPtr.Zero && RemoveMaterialDependencyUid_MaterialDependencyUid_IsValid && RemoveMaterialDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:RemoveMaterialDependencyUid", RemoveMaterialDependencyUid_IsValid);
		IsSpecializedTypeContains_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSpecializedTypeContains");
		IsSpecializedTypeContains_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSpecializedTypeContains_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSpecializedTypeContains_SpecializedType_PropertyAddress, IsSpecializedTypeContains_FunctionAddress, "SpecializedType");
		IsSpecializedTypeContains_SpecializedType_Offset = NativeReflectionCached.GetPropertyOffset(IsSpecializedTypeContains_FunctionAddress, "SpecializedType");
		IsSpecializedTypeContains_SpecializedType_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSpecializedTypeContains_FunctionAddress, "SpecializedType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSpecializedTypeContains_ReturnValue_PropertyAddress, IsSpecializedTypeContains_FunctionAddress, "ReturnValue");
		IsSpecializedTypeContains_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSpecializedTypeContains_FunctionAddress, "ReturnValue");
		IsSpecializedTypeContains_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSpecializedTypeContains_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSpecializedTypeContains_IsValid = IsSpecializedTypeContains_FunctionAddress != IntPtr.Zero && IsSpecializedTypeContains_SpecializedType_IsValid && IsSpecializedTypeContains_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:IsSpecializedTypeContains", IsSpecializedTypeContains_IsValid);
		GetSpecializedTypes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSpecializedTypes");
		GetSpecializedTypes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpecializedTypes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpecializedTypes_OutSpecializedTypes_PropertyAddress, GetSpecializedTypes_FunctionAddress, "OutSpecializedTypes");
		GetSpecializedTypes_OutSpecializedTypes_Offset = NativeReflectionCached.GetPropertyOffset(GetSpecializedTypes_FunctionAddress, "OutSpecializedTypes");
		GetSpecializedTypes_OutSpecializedTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpecializedTypes_FunctionAddress, "OutSpecializedTypes", Classes.FArrayProperty);
		GetSpecializedTypes_IsValid = GetSpecializedTypes_FunctionAddress != IntPtr.Zero && GetSpecializedTypes_OutSpecializedTypes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedTypes", GetSpecializedTypes_IsValid);
		GetSpecializedTypeCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSpecializedTypeCount");
		GetSpecializedTypeCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpecializedTypeCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpecializedTypeCount_ReturnValue_PropertyAddress, GetSpecializedTypeCount_FunctionAddress, "ReturnValue");
		GetSpecializedTypeCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpecializedTypeCount_FunctionAddress, "ReturnValue");
		GetSpecializedTypeCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpecializedTypeCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSpecializedTypeCount_IsValid = GetSpecializedTypeCount_FunctionAddress != IntPtr.Zero && GetSpecializedTypeCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedTypeCount", GetSpecializedTypeCount_IsValid);
		GetSpecializedType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSpecializedType");
		GetSpecializedType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpecializedType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpecializedType_Index_PropertyAddress, GetSpecializedType_FunctionAddress, "Index");
		GetSpecializedType_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetSpecializedType_FunctionAddress, "Index");
		GetSpecializedType_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpecializedType_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSpecializedType_OutSpecializedType_PropertyAddress, GetSpecializedType_FunctionAddress, "OutSpecializedType");
		GetSpecializedType_OutSpecializedType_Offset = NativeReflectionCached.GetPropertyOffset(GetSpecializedType_FunctionAddress, "OutSpecializedType");
		GetSpecializedType_OutSpecializedType_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpecializedType_FunctionAddress, "OutSpecializedType", Classes.FStrProperty);
		GetSpecializedType_IsValid = GetSpecializedType_FunctionAddress != IntPtr.Zero && GetSpecializedType_Index_IsValid && GetSpecializedType_OutSpecializedType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetSpecializedType", GetSpecializedType_IsValid);
		GetMaterialDependencyUidsCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMaterialDependencyUidsCount");
		GetMaterialDependencyUidsCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialDependencyUidsCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependencyUidsCount_ReturnValue_PropertyAddress, GetMaterialDependencyUidsCount_FunctionAddress, "ReturnValue");
		GetMaterialDependencyUidsCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependencyUidsCount_FunctionAddress, "ReturnValue");
		GetMaterialDependencyUidsCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependencyUidsCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaterialDependencyUidsCount_IsValid = GetMaterialDependencyUidsCount_FunctionAddress != IntPtr.Zero && GetMaterialDependencyUidsCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUidsCount", GetMaterialDependencyUidsCount_IsValid);
		GetMaterialDependencyUids_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMaterialDependencyUids");
		GetMaterialDependencyUids_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialDependencyUids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependencyUids_OutMaterialDependencyUids_PropertyAddress, GetMaterialDependencyUids_FunctionAddress, "OutMaterialDependencyUids");
		GetMaterialDependencyUids_OutMaterialDependencyUids_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependencyUids_FunctionAddress, "OutMaterialDependencyUids");
		GetMaterialDependencyUids_OutMaterialDependencyUids_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependencyUids_FunctionAddress, "OutMaterialDependencyUids", Classes.FArrayProperty);
		GetMaterialDependencyUids_IsValid = GetMaterialDependencyUids_FunctionAddress != IntPtr.Zero && GetMaterialDependencyUids_OutMaterialDependencyUids_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUids", GetMaterialDependencyUids_IsValid);
		GetMaterialDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMaterialDependencyUid");
		GetMaterialDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaterialDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependencyUid_Index_PropertyAddress, GetMaterialDependencyUid_FunctionAddress, "Index");
		GetMaterialDependencyUid_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependencyUid_FunctionAddress, "Index");
		GetMaterialDependencyUid_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependencyUid_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMaterialDependencyUid_OutMaterialDependencyUid_PropertyAddress, GetMaterialDependencyUid_FunctionAddress, "OutMaterialDependencyUid");
		GetMaterialDependencyUid_OutMaterialDependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(GetMaterialDependencyUid_FunctionAddress, "OutMaterialDependencyUid");
		GetMaterialDependencyUid_OutMaterialDependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaterialDependencyUid_FunctionAddress, "OutMaterialDependencyUid", Classes.FStrProperty);
		GetMaterialDependencyUid_IsValid = GetMaterialDependencyUid_FunctionAddress != IntPtr.Zero && GetMaterialDependencyUid_Index_IsValid && GetMaterialDependencyUid_OutMaterialDependencyUid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetMaterialDependencyUid", GetMaterialDependencyUid_IsValid);
		GetCustomLocalTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomLocalTransform");
		GetCustomLocalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomLocalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomLocalTransform_AttributeValue_PropertyAddress, GetCustomLocalTransform_FunctionAddress, "AttributeValue");
		GetCustomLocalTransform_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomLocalTransform_FunctionAddress, "AttributeValue");
		GetCustomLocalTransform_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomLocalTransform_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomLocalTransform_ReturnValue_PropertyAddress, GetCustomLocalTransform_FunctionAddress, "ReturnValue");
		GetCustomLocalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomLocalTransform_FunctionAddress, "ReturnValue");
		GetCustomLocalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomLocalTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomLocalTransform_IsValid = GetCustomLocalTransform_FunctionAddress != IntPtr.Zero && GetCustomLocalTransform_AttributeValue_IsValid && GetCustomLocalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomLocalTransform", GetCustomLocalTransform_IsValid);
		GetCustomGlobalTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomGlobalTransform");
		GetCustomGlobalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomGlobalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomGlobalTransform_AttributeValue_PropertyAddress, GetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		GetCustomGlobalTransform_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomGlobalTransform_FunctionAddress, "AttributeValue");
		GetCustomGlobalTransform_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomGlobalTransform_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomGlobalTransform_ReturnValue_PropertyAddress, GetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		GetCustomGlobalTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomGlobalTransform_FunctionAddress, "ReturnValue");
		GetCustomGlobalTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomGlobalTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomGlobalTransform_IsValid = GetCustomGlobalTransform_FunctionAddress != IntPtr.Zero && GetCustomGlobalTransform_AttributeValue_IsValid && GetCustomGlobalTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomGlobalTransform", GetCustomGlobalTransform_IsValid);
		GetCustomAssetInstanceUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomAssetInstanceUid");
		GetCustomAssetInstanceUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomAssetInstanceUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomAssetInstanceUid_AttributeValue_PropertyAddress, GetCustomAssetInstanceUid_FunctionAddress, "AttributeValue");
		GetCustomAssetInstanceUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomAssetInstanceUid_FunctionAddress, "AttributeValue");
		GetCustomAssetInstanceUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomAssetInstanceUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomAssetInstanceUid_ReturnValue_PropertyAddress, GetCustomAssetInstanceUid_FunctionAddress, "ReturnValue");
		GetCustomAssetInstanceUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomAssetInstanceUid_FunctionAddress, "ReturnValue");
		GetCustomAssetInstanceUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomAssetInstanceUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomAssetInstanceUid_IsValid = GetCustomAssetInstanceUid_FunctionAddress != IntPtr.Zero && GetCustomAssetInstanceUid_AttributeValue_IsValid && GetCustomAssetInstanceUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:GetCustomAssetInstanceUid", GetCustomAssetInstanceUid_IsValid);
		AddSpecializedType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddSpecializedType");
		AddSpecializedType_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSpecializedType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSpecializedType_SpecializedType_PropertyAddress, AddSpecializedType_FunctionAddress, "SpecializedType");
		AddSpecializedType_SpecializedType_Offset = NativeReflectionCached.GetPropertyOffset(AddSpecializedType_FunctionAddress, "SpecializedType");
		AddSpecializedType_SpecializedType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpecializedType_FunctionAddress, "SpecializedType", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpecializedType_ReturnValue_PropertyAddress, AddSpecializedType_FunctionAddress, "ReturnValue");
		AddSpecializedType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSpecializedType_FunctionAddress, "ReturnValue");
		AddSpecializedType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpecializedType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddSpecializedType_IsValid = AddSpecializedType_FunctionAddress != IntPtr.Zero && AddSpecializedType_SpecializedType_IsValid && AddSpecializedType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:AddSpecializedType", AddSpecializedType_IsValid);
		AddMaterialDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddMaterialDependencyUid");
		AddMaterialDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMaterialDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMaterialDependencyUid_MaterialDependencyUid_PropertyAddress, AddMaterialDependencyUid_FunctionAddress, "MaterialDependencyUid");
		AddMaterialDependencyUid_MaterialDependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(AddMaterialDependencyUid_FunctionAddress, "MaterialDependencyUid");
		AddMaterialDependencyUid_MaterialDependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMaterialDependencyUid_FunctionAddress, "MaterialDependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMaterialDependencyUid_ReturnValue_PropertyAddress, AddMaterialDependencyUid_FunctionAddress, "ReturnValue");
		AddMaterialDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMaterialDependencyUid_FunctionAddress, "ReturnValue");
		AddMaterialDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMaterialDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddMaterialDependencyUid_IsValid = AddMaterialDependencyUid_FunctionAddress != IntPtr.Zero && AddMaterialDependencyUid_MaterialDependencyUid_IsValid && AddMaterialDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSceneNode:AddMaterialDependencyUid", AddMaterialDependencyUid_IsValid);
	}
}
