using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeStaticMeshFactoryNode : UInterchangeBaseNode
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

	private static bool RemoveLodDataUniqueId_IsValid;

	private static IntPtr RemoveLodDataUniqueId_FunctionAddress;

	private static int RemoveLodDataUniqueId_ParamsSize;

	private static bool RemoveLodDataUniqueId_LodDataUniqueId_IsValid;

	private static FFieldAddress RemoveLodDataUniqueId_LodDataUniqueId_PropertyAddress;

	private static int RemoveLodDataUniqueId_LodDataUniqueId_Offset;

	private static bool RemoveLodDataUniqueId_ReturnValue_IsValid;

	private static FFieldAddress RemoveLodDataUniqueId_ReturnValue_PropertyAddress;

	private static int RemoveLodDataUniqueId_ReturnValue_Offset;

	private static bool InitializeStaticMeshNode_IsValid;

	private static IntPtr InitializeStaticMeshNode_FunctionAddress;

	private static int InitializeStaticMeshNode_ParamsSize;

	private static bool InitializeStaticMeshNode_UniqueID_IsValid;

	private static FFieldAddress InitializeStaticMeshNode_UniqueID_PropertyAddress;

	private static int InitializeStaticMeshNode_UniqueID_Offset;

	private static bool InitializeStaticMeshNode_DisplayLabel_IsValid;

	private static FFieldAddress InitializeStaticMeshNode_DisplayLabel_PropertyAddress;

	private static int InitializeStaticMeshNode_DisplayLabel_Offset;

	private static bool InitializeStaticMeshNode_InAssetClass_IsValid;

	private static FFieldAddress InitializeStaticMeshNode_InAssetClass_PropertyAddress;

	private static int InitializeStaticMeshNode_InAssetClass_Offset;

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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorReplace")]
	public unsafe bool SetCustomVertexColorReplace(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomVertexColorReplace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorReplace");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorOverride")]
	public unsafe bool SetCustomVertexColorOverride(FColor AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomVertexColorOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorOverride");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorIgnore")]
	public unsafe bool SetCustomVertexColorIgnore(bool AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomVertexColorIgnore_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorIgnore");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:RemoveLodDataUniqueId")]
	public unsafe bool RemoveLodDataUniqueId(string LodDataUniqueId)
	{
		CheckDestroyed();
		if (!RemoveLodDataUniqueId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:RemoveLodDataUniqueId");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:InitializeStaticMeshNode")]
	public unsafe void InitializeStaticMeshNode(string UniqueID, string DisplayLabel, string InAssetClass)
	{
		CheckDestroyed();
		if (!InitializeStaticMeshNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:InitializeStaticMeshNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeStaticMeshNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeStaticMeshNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeStaticMeshNode_UniqueID_Offset), 0, InitializeStaticMeshNode_UniqueID_PropertyAddress.Address, UniqueID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeStaticMeshNode_DisplayLabel_Offset), 0, InitializeStaticMeshNode_DisplayLabel_PropertyAddress.Address, DisplayLabel);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeStaticMeshNode_InAssetClass_Offset), 0, InitializeStaticMeshNode_InAssetClass_PropertyAddress.Address, InAssetClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeStaticMeshNode_FunctionAddress, intPtr, InitializeStaticMeshNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializeStaticMeshNode_UniqueID_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeStaticMeshNode_DisplayLabel_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeStaticMeshNode_InAssetClass_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetObjectClass")]
	public unsafe TSubclassOf<UObject> GetObjectClass()
	{
		CheckDestroyed();
		if (!GetObjectClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetObjectClass");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetLodDataUniqueIds")]
	public unsafe void GetLodDataUniqueIds(out List<string> OutLodDataUniqueIds)
	{
		CheckDestroyed();
		if (!GetLodDataUniqueIds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetLodDataUniqueIds");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetLodDataCount")]
	public unsafe int GetLodDataCount()
	{
		CheckDestroyed();
		if (!GetLodDataCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetLodDataCount");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorReplace")]
	public unsafe bool GetCustomVertexColorReplace(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomVertexColorReplace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorReplace");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorOverride")]
	public unsafe bool GetCustomVertexColorOverride(out FColor AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomVertexColorOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorOverride");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorIgnore")]
	public unsafe bool GetCustomVertexColorIgnore(out bool AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomVertexColorIgnore_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorIgnore");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:AddLodDataUniqueId")]
	public unsafe bool AddLodDataUniqueId(string LodDataUniqueId)
	{
		CheckDestroyed();
		if (!AddLodDataUniqueId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:AddLodDataUniqueId");
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

	static UInterchangeStaticMeshFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeStaticMeshFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeStaticMeshFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode");
		SetCustomVertexColorReplace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomVertexColorReplace");
		SetCustomVertexColorReplace_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomVertexColorReplace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorReplace_AttributeValue_PropertyAddress, SetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		SetCustomVertexColorReplace_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		SetCustomVertexColorReplace_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorReplace_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorReplace_ReturnValue_PropertyAddress, SetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		SetCustomVertexColorReplace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		SetCustomVertexColorReplace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorReplace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomVertexColorReplace_IsValid = SetCustomVertexColorReplace_FunctionAddress != IntPtr.Zero && SetCustomVertexColorReplace_AttributeValue_IsValid && SetCustomVertexColorReplace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorReplace", SetCustomVertexColorReplace_IsValid);
		SetCustomVertexColorOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomVertexColorOverride");
		SetCustomVertexColorOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomVertexColorOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorOverride_AttributeValue_PropertyAddress, SetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		SetCustomVertexColorOverride_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		SetCustomVertexColorOverride_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorOverride_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorOverride_ReturnValue_PropertyAddress, SetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		SetCustomVertexColorOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		SetCustomVertexColorOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorOverride_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomVertexColorOverride_IsValid = SetCustomVertexColorOverride_FunctionAddress != IntPtr.Zero && SetCustomVertexColorOverride_AttributeValue_IsValid && SetCustomVertexColorOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorOverride", SetCustomVertexColorOverride_IsValid);
		SetCustomVertexColorIgnore_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomVertexColorIgnore");
		SetCustomVertexColorIgnore_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomVertexColorIgnore_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorIgnore_AttributeValue_PropertyAddress, SetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		SetCustomVertexColorIgnore_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		SetCustomVertexColorIgnore_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorIgnore_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomVertexColorIgnore_ReturnValue_PropertyAddress, SetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		SetCustomVertexColorIgnore_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		SetCustomVertexColorIgnore_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomVertexColorIgnore_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomVertexColorIgnore_IsValid = SetCustomVertexColorIgnore_FunctionAddress != IntPtr.Zero && SetCustomVertexColorIgnore_AttributeValue_IsValid && SetCustomVertexColorIgnore_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:SetCustomVertexColorIgnore", SetCustomVertexColorIgnore_IsValid);
		RemoveLodDataUniqueId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveLodDataUniqueId");
		RemoveLodDataUniqueId_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveLodDataUniqueId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveLodDataUniqueId_LodDataUniqueId_PropertyAddress, RemoveLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		RemoveLodDataUniqueId_LodDataUniqueId_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		RemoveLodDataUniqueId_LodDataUniqueId_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLodDataUniqueId_FunctionAddress, "LodDataUniqueId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLodDataUniqueId_ReturnValue_PropertyAddress, RemoveLodDataUniqueId_FunctionAddress, "ReturnValue");
		RemoveLodDataUniqueId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLodDataUniqueId_FunctionAddress, "ReturnValue");
		RemoveLodDataUniqueId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLodDataUniqueId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveLodDataUniqueId_IsValid = RemoveLodDataUniqueId_FunctionAddress != IntPtr.Zero && RemoveLodDataUniqueId_LodDataUniqueId_IsValid && RemoveLodDataUniqueId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:RemoveLodDataUniqueId", RemoveLodDataUniqueId_IsValid);
		InitializeStaticMeshNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeStaticMeshNode");
		InitializeStaticMeshNode_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeStaticMeshNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeStaticMeshNode_UniqueID_PropertyAddress, InitializeStaticMeshNode_FunctionAddress, "UniqueID");
		InitializeStaticMeshNode_UniqueID_Offset = NativeReflectionCached.GetPropertyOffset(InitializeStaticMeshNode_FunctionAddress, "UniqueID");
		InitializeStaticMeshNode_UniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeStaticMeshNode_FunctionAddress, "UniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeStaticMeshNode_DisplayLabel_PropertyAddress, InitializeStaticMeshNode_FunctionAddress, "DisplayLabel");
		InitializeStaticMeshNode_DisplayLabel_Offset = NativeReflectionCached.GetPropertyOffset(InitializeStaticMeshNode_FunctionAddress, "DisplayLabel");
		InitializeStaticMeshNode_DisplayLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeStaticMeshNode_FunctionAddress, "DisplayLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeStaticMeshNode_InAssetClass_PropertyAddress, InitializeStaticMeshNode_FunctionAddress, "InAssetClass");
		InitializeStaticMeshNode_InAssetClass_Offset = NativeReflectionCached.GetPropertyOffset(InitializeStaticMeshNode_FunctionAddress, "InAssetClass");
		InitializeStaticMeshNode_InAssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeStaticMeshNode_FunctionAddress, "InAssetClass", Classes.FStrProperty);
		InitializeStaticMeshNode_IsValid = InitializeStaticMeshNode_FunctionAddress != IntPtr.Zero && InitializeStaticMeshNode_UniqueID_IsValid && InitializeStaticMeshNode_DisplayLabel_IsValid && InitializeStaticMeshNode_InAssetClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:InitializeStaticMeshNode", InitializeStaticMeshNode_IsValid);
		GetObjectClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObjectClass");
		GetObjectClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectClass_ReturnValue_PropertyAddress, GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetObjectClass_IsValid = GetObjectClass_FunctionAddress != IntPtr.Zero && GetObjectClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetObjectClass", GetObjectClass_IsValid);
		GetLodDataUniqueIds_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodDataUniqueIds");
		GetLodDataUniqueIds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodDataUniqueIds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodDataUniqueIds_OutLodDataUniqueIds_PropertyAddress, GetLodDataUniqueIds_FunctionAddress, "OutLodDataUniqueIds");
		GetLodDataUniqueIds_OutLodDataUniqueIds_Offset = NativeReflectionCached.GetPropertyOffset(GetLodDataUniqueIds_FunctionAddress, "OutLodDataUniqueIds");
		GetLodDataUniqueIds_OutLodDataUniqueIds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodDataUniqueIds_FunctionAddress, "OutLodDataUniqueIds", Classes.FArrayProperty);
		GetLodDataUniqueIds_IsValid = GetLodDataUniqueIds_FunctionAddress != IntPtr.Zero && GetLodDataUniqueIds_OutLodDataUniqueIds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetLodDataUniqueIds", GetLodDataUniqueIds_IsValid);
		GetLodDataCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLodDataCount");
		GetLodDataCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLodDataCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLodDataCount_ReturnValue_PropertyAddress, GetLodDataCount_FunctionAddress, "ReturnValue");
		GetLodDataCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLodDataCount_FunctionAddress, "ReturnValue");
		GetLodDataCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLodDataCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLodDataCount_IsValid = GetLodDataCount_FunctionAddress != IntPtr.Zero && GetLodDataCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetLodDataCount", GetLodDataCount_IsValid);
		GetCustomVertexColorReplace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomVertexColorReplace");
		GetCustomVertexColorReplace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomVertexColorReplace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorReplace_AttributeValue_PropertyAddress, GetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		GetCustomVertexColorReplace_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorReplace_FunctionAddress, "AttributeValue");
		GetCustomVertexColorReplace_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorReplace_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorReplace_ReturnValue_PropertyAddress, GetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		GetCustomVertexColorReplace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorReplace_FunctionAddress, "ReturnValue");
		GetCustomVertexColorReplace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorReplace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomVertexColorReplace_IsValid = GetCustomVertexColorReplace_FunctionAddress != IntPtr.Zero && GetCustomVertexColorReplace_AttributeValue_IsValid && GetCustomVertexColorReplace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorReplace", GetCustomVertexColorReplace_IsValid);
		GetCustomVertexColorOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomVertexColorOverride");
		GetCustomVertexColorOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomVertexColorOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorOverride_AttributeValue_PropertyAddress, GetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		GetCustomVertexColorOverride_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorOverride_FunctionAddress, "AttributeValue");
		GetCustomVertexColorOverride_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorOverride_FunctionAddress, "AttributeValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorOverride_ReturnValue_PropertyAddress, GetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		GetCustomVertexColorOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorOverride_FunctionAddress, "ReturnValue");
		GetCustomVertexColorOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorOverride_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomVertexColorOverride_IsValid = GetCustomVertexColorOverride_FunctionAddress != IntPtr.Zero && GetCustomVertexColorOverride_AttributeValue_IsValid && GetCustomVertexColorOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorOverride", GetCustomVertexColorOverride_IsValid);
		GetCustomVertexColorIgnore_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomVertexColorIgnore");
		GetCustomVertexColorIgnore_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomVertexColorIgnore_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorIgnore_AttributeValue_PropertyAddress, GetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		GetCustomVertexColorIgnore_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorIgnore_FunctionAddress, "AttributeValue");
		GetCustomVertexColorIgnore_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorIgnore_FunctionAddress, "AttributeValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomVertexColorIgnore_ReturnValue_PropertyAddress, GetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		GetCustomVertexColorIgnore_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomVertexColorIgnore_FunctionAddress, "ReturnValue");
		GetCustomVertexColorIgnore_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomVertexColorIgnore_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomVertexColorIgnore_IsValid = GetCustomVertexColorIgnore_FunctionAddress != IntPtr.Zero && GetCustomVertexColorIgnore_AttributeValue_IsValid && GetCustomVertexColorIgnore_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:GetCustomVertexColorIgnore", GetCustomVertexColorIgnore_IsValid);
		AddLodDataUniqueId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddLodDataUniqueId");
		AddLodDataUniqueId_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLodDataUniqueId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLodDataUniqueId_LodDataUniqueId_PropertyAddress, AddLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		AddLodDataUniqueId_LodDataUniqueId_Offset = NativeReflectionCached.GetPropertyOffset(AddLodDataUniqueId_FunctionAddress, "LodDataUniqueId");
		AddLodDataUniqueId_LodDataUniqueId_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLodDataUniqueId_FunctionAddress, "LodDataUniqueId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLodDataUniqueId_ReturnValue_PropertyAddress, AddLodDataUniqueId_FunctionAddress, "ReturnValue");
		AddLodDataUniqueId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLodDataUniqueId_FunctionAddress, "ReturnValue");
		AddLodDataUniqueId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLodDataUniqueId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddLodDataUniqueId_IsValid = AddLodDataUniqueId_FunctionAddress != IntPtr.Zero && AddLodDataUniqueId_LodDataUniqueId_IsValid && AddLodDataUniqueId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeStaticMeshFactoryNode:AddLodDataUniqueId", AddLodDataUniqueId_IsValid);
	}
}
