using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeSkeletalMeshLodDataNode : UInterchangeBaseNode
{
	private static bool SetCustomSkeletonUid_IsValid;

	private static IntPtr SetCustomSkeletonUid_FunctionAddress;

	private static int SetCustomSkeletonUid_ParamsSize;

	private static bool SetCustomSkeletonUid_AttributeValue_IsValid;

	private static FFieldAddress SetCustomSkeletonUid_AttributeValue_PropertyAddress;

	private static int SetCustomSkeletonUid_AttributeValue_Offset;

	private static bool SetCustomSkeletonUid_ReturnValue_IsValid;

	private static FFieldAddress SetCustomSkeletonUid_ReturnValue_PropertyAddress;

	private static int SetCustomSkeletonUid_ReturnValue_Offset;

	private static bool RemoveMeshUid_IsValid;

	private static IntPtr RemoveMeshUid_FunctionAddress;

	private static int RemoveMeshUid_ParamsSize;

	private static bool RemoveMeshUid_BlendShapeName_IsValid;

	private static FFieldAddress RemoveMeshUid_BlendShapeName_PropertyAddress;

	private static int RemoveMeshUid_BlendShapeName_Offset;

	private static bool RemoveMeshUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveMeshUid_ReturnValue_PropertyAddress;

	private static int RemoveMeshUid_ReturnValue_Offset;

	private static bool RemoveAllMeshes_IsValid;

	private static IntPtr RemoveAllMeshes_FunctionAddress;

	private static int RemoveAllMeshes_ParamsSize;

	private static bool RemoveAllMeshes_ReturnValue_IsValid;

	private static FFieldAddress RemoveAllMeshes_ReturnValue_PropertyAddress;

	private static int RemoveAllMeshes_ReturnValue_Offset;

	private static bool GetMeshUidsCount_IsValid;

	private static IntPtr GetMeshUidsCount_FunctionAddress;

	private static int GetMeshUidsCount_ParamsSize;

	private static bool GetMeshUidsCount_ReturnValue_IsValid;

	private static FFieldAddress GetMeshUidsCount_ReturnValue_PropertyAddress;

	private static int GetMeshUidsCount_ReturnValue_Offset;

	private static bool GetMeshUids_IsValid;

	private static IntPtr GetMeshUids_FunctionAddress;

	private static int GetMeshUids_ParamsSize;

	private static bool GetMeshUids_OutBlendShapeNames_IsValid;

	private static FFieldAddress GetMeshUids_OutBlendShapeNames_PropertyAddress;

	private static int GetMeshUids_OutBlendShapeNames_Offset;

	private static bool GetCustomSkeletonUid_IsValid;

	private static IntPtr GetCustomSkeletonUid_FunctionAddress;

	private static int GetCustomSkeletonUid_ParamsSize;

	private static bool GetCustomSkeletonUid_AttributeValue_IsValid;

	private static FFieldAddress GetCustomSkeletonUid_AttributeValue_PropertyAddress;

	private static int GetCustomSkeletonUid_AttributeValue_Offset;

	private static bool GetCustomSkeletonUid_ReturnValue_IsValid;

	private static FFieldAddress GetCustomSkeletonUid_ReturnValue_PropertyAddress;

	private static int GetCustomSkeletonUid_ReturnValue_Offset;

	private static bool AddMeshUid_IsValid;

	private static IntPtr AddMeshUid_FunctionAddress;

	private static int AddMeshUid_ParamsSize;

	private static bool AddMeshUid_BlendShapeName_IsValid;

	private static FFieldAddress AddMeshUid_BlendShapeName_PropertyAddress;

	private static int AddMeshUid_BlendShapeName_Offset;

	private static bool AddMeshUid_ReturnValue_IsValid;

	private static FFieldAddress AddMeshUid_ReturnValue_PropertyAddress;

	private static int AddMeshUid_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:SetCustomSkeletonUid")]
	public unsafe bool SetCustomSkeletonUid(string AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomSkeletonUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:SetCustomSkeletonUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomSkeletonUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomSkeletonUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomSkeletonUid_AttributeValue_Offset), 0, SetCustomSkeletonUid_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomSkeletonUid_FunctionAddress, intPtr, SetCustomSkeletonUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomSkeletonUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomSkeletonUid_ReturnValue_Offset), 0, SetCustomSkeletonUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:RemoveMeshUid")]
	public unsafe bool RemoveMeshUid(string BlendShapeName)
	{
		CheckDestroyed();
		if (!RemoveMeshUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:RemoveMeshUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMeshUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMeshUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveMeshUid_BlendShapeName_Offset), 0, RemoveMeshUid_BlendShapeName_PropertyAddress.Address, BlendShapeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveMeshUid_FunctionAddress, intPtr, RemoveMeshUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveMeshUid_BlendShapeName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveMeshUid_ReturnValue_Offset), 0, RemoveMeshUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:RemoveAllMeshes")]
	public unsafe bool RemoveAllMeshes()
	{
		CheckDestroyed();
		if (!RemoveAllMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:RemoveAllMeshes");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllMeshes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveAllMeshes_FunctionAddress, intPtr, RemoveAllMeshes_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveAllMeshes_ReturnValue_Offset), 0, RemoveAllMeshes_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetMeshUidsCount")]
	public unsafe int GetMeshUidsCount()
	{
		CheckDestroyed();
		if (!GetMeshUidsCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetMeshUidsCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshUidsCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshUidsCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshUidsCount_FunctionAddress, intPtr, GetMeshUidsCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMeshUidsCount_ReturnValue_Offset), 0, GetMeshUidsCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetMeshUids")]
	public unsafe void GetMeshUids(out List<string> OutBlendShapeNames)
	{
		CheckDestroyed();
		if (!GetMeshUids_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetMeshUids");
			OutBlendShapeNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshUids_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshUids_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMeshUids_FunctionAddress, intPtr, GetMeshUids_ParamsSize);
		OutBlendShapeNames = new TArrayCopyMarshaler<string>(1, GetMeshUids_OutBlendShapeNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetMeshUids_OutBlendShapeNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetMeshUids_OutBlendShapeNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetCustomSkeletonUid")]
	public unsafe bool GetCustomSkeletonUid(out string AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomSkeletonUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetCustomSkeletonUid");
			AttributeValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomSkeletonUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomSkeletonUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomSkeletonUid_FunctionAddress, intPtr, GetCustomSkeletonUid_ParamsSize);
		AttributeValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomSkeletonUid_AttributeValue_Offset), 0, GetCustomSkeletonUid_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomSkeletonUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomSkeletonUid_ReturnValue_Offset), 0, GetCustomSkeletonUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:AddMeshUid")]
	public unsafe bool AddMeshUid(string BlendShapeName)
	{
		CheckDestroyed();
		if (!AddMeshUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:AddMeshUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMeshUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMeshUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddMeshUid_BlendShapeName_Offset), 0, AddMeshUid_BlendShapeName_PropertyAddress.Address, BlendShapeName);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMeshUid_FunctionAddress, intPtr, AddMeshUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMeshUid_BlendShapeName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddMeshUid_ReturnValue_Offset), 0, AddMeshUid_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeSkeletalMeshLodDataNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeSkeletalMeshLodDataNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeSkeletalMeshLodDataNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode");
		SetCustomSkeletonUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomSkeletonUid");
		SetCustomSkeletonUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomSkeletonUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomSkeletonUid_AttributeValue_PropertyAddress, SetCustomSkeletonUid_FunctionAddress, "AttributeValue");
		SetCustomSkeletonUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomSkeletonUid_FunctionAddress, "AttributeValue");
		SetCustomSkeletonUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomSkeletonUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomSkeletonUid_ReturnValue_PropertyAddress, SetCustomSkeletonUid_FunctionAddress, "ReturnValue");
		SetCustomSkeletonUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomSkeletonUid_FunctionAddress, "ReturnValue");
		SetCustomSkeletonUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomSkeletonUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomSkeletonUid_IsValid = SetCustomSkeletonUid_FunctionAddress != IntPtr.Zero && SetCustomSkeletonUid_AttributeValue_IsValid && SetCustomSkeletonUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:SetCustomSkeletonUid", SetCustomSkeletonUid_IsValid);
		RemoveMeshUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveMeshUid");
		RemoveMeshUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMeshUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMeshUid_BlendShapeName_PropertyAddress, RemoveMeshUid_FunctionAddress, "BlendShapeName");
		RemoveMeshUid_BlendShapeName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMeshUid_FunctionAddress, "BlendShapeName");
		RemoveMeshUid_BlendShapeName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMeshUid_FunctionAddress, "BlendShapeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMeshUid_ReturnValue_PropertyAddress, RemoveMeshUid_FunctionAddress, "ReturnValue");
		RemoveMeshUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMeshUid_FunctionAddress, "ReturnValue");
		RemoveMeshUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMeshUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveMeshUid_IsValid = RemoveMeshUid_FunctionAddress != IntPtr.Zero && RemoveMeshUid_BlendShapeName_IsValid && RemoveMeshUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:RemoveMeshUid", RemoveMeshUid_IsValid);
		RemoveAllMeshes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveAllMeshes");
		RemoveAllMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllMeshes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllMeshes_ReturnValue_PropertyAddress, RemoveAllMeshes_FunctionAddress, "ReturnValue");
		RemoveAllMeshes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllMeshes_FunctionAddress, "ReturnValue");
		RemoveAllMeshes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllMeshes_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveAllMeshes_IsValid = RemoveAllMeshes_FunctionAddress != IntPtr.Zero && RemoveAllMeshes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:RemoveAllMeshes", RemoveAllMeshes_IsValid);
		GetMeshUidsCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMeshUidsCount");
		GetMeshUidsCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshUidsCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshUidsCount_ReturnValue_PropertyAddress, GetMeshUidsCount_FunctionAddress, "ReturnValue");
		GetMeshUidsCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshUidsCount_FunctionAddress, "ReturnValue");
		GetMeshUidsCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshUidsCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMeshUidsCount_IsValid = GetMeshUidsCount_FunctionAddress != IntPtr.Zero && GetMeshUidsCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetMeshUidsCount", GetMeshUidsCount_IsValid);
		GetMeshUids_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMeshUids");
		GetMeshUids_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshUids_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshUids_OutBlendShapeNames_PropertyAddress, GetMeshUids_FunctionAddress, "OutBlendShapeNames");
		GetMeshUids_OutBlendShapeNames_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshUids_FunctionAddress, "OutBlendShapeNames");
		GetMeshUids_OutBlendShapeNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshUids_FunctionAddress, "OutBlendShapeNames", Classes.FArrayProperty);
		GetMeshUids_IsValid = GetMeshUids_FunctionAddress != IntPtr.Zero && GetMeshUids_OutBlendShapeNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetMeshUids", GetMeshUids_IsValid);
		GetCustomSkeletonUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomSkeletonUid");
		GetCustomSkeletonUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomSkeletonUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomSkeletonUid_AttributeValue_PropertyAddress, GetCustomSkeletonUid_FunctionAddress, "AttributeValue");
		GetCustomSkeletonUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomSkeletonUid_FunctionAddress, "AttributeValue");
		GetCustomSkeletonUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomSkeletonUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomSkeletonUid_ReturnValue_PropertyAddress, GetCustomSkeletonUid_FunctionAddress, "ReturnValue");
		GetCustomSkeletonUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomSkeletonUid_FunctionAddress, "ReturnValue");
		GetCustomSkeletonUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomSkeletonUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomSkeletonUid_IsValid = GetCustomSkeletonUid_FunctionAddress != IntPtr.Zero && GetCustomSkeletonUid_AttributeValue_IsValid && GetCustomSkeletonUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:GetCustomSkeletonUid", GetCustomSkeletonUid_IsValid);
		AddMeshUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddMeshUid");
		AddMeshUid_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMeshUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMeshUid_BlendShapeName_PropertyAddress, AddMeshUid_FunctionAddress, "BlendShapeName");
		AddMeshUid_BlendShapeName_Offset = NativeReflectionCached.GetPropertyOffset(AddMeshUid_FunctionAddress, "BlendShapeName");
		AddMeshUid_BlendShapeName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMeshUid_FunctionAddress, "BlendShapeName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMeshUid_ReturnValue_PropertyAddress, AddMeshUid_FunctionAddress, "ReturnValue");
		AddMeshUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMeshUid_FunctionAddress, "ReturnValue");
		AddMeshUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMeshUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddMeshUid_IsValid = AddMeshUid_FunctionAddress != IntPtr.Zero && AddMeshUid_BlendShapeName_IsValid && AddMeshUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeSkeletalMeshLodDataNode:AddMeshUid", AddMeshUid_IsValid);
	}
}
