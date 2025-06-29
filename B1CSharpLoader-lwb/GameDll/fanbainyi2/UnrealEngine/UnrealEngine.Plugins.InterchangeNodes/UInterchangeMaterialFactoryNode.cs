using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeMaterialFactoryNode : UInterchangeBaseNode
{
	private static bool SetTextureDependencyUid_IsValid;

	private static IntPtr SetTextureDependencyUid_FunctionAddress;

	private static int SetTextureDependencyUid_ParamsSize;

	private static bool SetTextureDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress SetTextureDependencyUid_DependencyUid_PropertyAddress;

	private static int SetTextureDependencyUid_DependencyUid_Offset;

	private static bool SetTextureDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress SetTextureDependencyUid_ReturnValue_PropertyAddress;

	private static int SetTextureDependencyUid_ReturnValue_Offset;

	private static bool SetCustomTranslatedMaterialNodeUid_IsValid;

	private static IntPtr SetCustomTranslatedMaterialNodeUid_FunctionAddress;

	private static int SetCustomTranslatedMaterialNodeUid_ParamsSize;

	private static bool SetCustomTranslatedMaterialNodeUid_AttributeValue_IsValid;

	private static FFieldAddress SetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress;

	private static int SetCustomTranslatedMaterialNodeUid_AttributeValue_Offset;

	private static bool SetCustomTranslatedMaterialNodeUid_ReturnValue_IsValid;

	private static FFieldAddress SetCustomTranslatedMaterialNodeUid_ReturnValue_PropertyAddress;

	private static int SetCustomTranslatedMaterialNodeUid_ReturnValue_Offset;

	private static bool SetCustomMaterialUsage_IsValid;

	private static IntPtr SetCustomMaterialUsage_FunctionAddress;

	private static int SetCustomMaterialUsage_ParamsSize;

	private static bool SetCustomMaterialUsage_AttributeValue_IsValid;

	private static FFieldAddress SetCustomMaterialUsage_AttributeValue_PropertyAddress;

	private static int SetCustomMaterialUsage_AttributeValue_Offset;

	private static bool SetCustomMaterialUsage_bAddApplyDelegate_IsValid;

	private static FFieldAddress SetCustomMaterialUsage_bAddApplyDelegate_PropertyAddress;

	private static int SetCustomMaterialUsage_bAddApplyDelegate_Offset;

	private static bool SetCustomMaterialUsage_ReturnValue_IsValid;

	private static FFieldAddress SetCustomMaterialUsage_ReturnValue_PropertyAddress;

	private static int SetCustomMaterialUsage_ReturnValue_Offset;

	private static bool SetCustomBlendMode_IsValid;

	private static IntPtr SetCustomBlendMode_FunctionAddress;

	private static int SetCustomBlendMode_ParamsSize;

	private static bool SetCustomBlendMode_AttributeValue_IsValid;

	private static FFieldAddress SetCustomBlendMode_AttributeValue_PropertyAddress;

	private static int SetCustomBlendMode_AttributeValue_Offset;

	private static bool SetCustomBlendMode_bAddApplyDelegate_IsValid;

	private static FFieldAddress SetCustomBlendMode_bAddApplyDelegate_PropertyAddress;

	private static int SetCustomBlendMode_bAddApplyDelegate_Offset;

	private static bool SetCustomBlendMode_ReturnValue_IsValid;

	private static FFieldAddress SetCustomBlendMode_ReturnValue_PropertyAddress;

	private static int SetCustomBlendMode_ReturnValue_Offset;

	private static bool RemoveTextureDependencyUid_IsValid;

	private static IntPtr RemoveTextureDependencyUid_FunctionAddress;

	private static int RemoveTextureDependencyUid_ParamsSize;

	private static bool RemoveTextureDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress RemoveTextureDependencyUid_DependencyUid_PropertyAddress;

	private static int RemoveTextureDependencyUid_DependencyUid_Offset;

	private static bool RemoveTextureDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveTextureDependencyUid_ReturnValue_PropertyAddress;

	private static int RemoveTextureDependencyUid_ReturnValue_Offset;

	private static bool InitializeMaterialNode_IsValid;

	private static IntPtr InitializeMaterialNode_FunctionAddress;

	private static int InitializeMaterialNode_ParamsSize;

	private static bool InitializeMaterialNode_UniqueID_IsValid;

	private static FFieldAddress InitializeMaterialNode_UniqueID_PropertyAddress;

	private static int InitializeMaterialNode_UniqueID_Offset;

	private static bool InitializeMaterialNode_DisplayLabel_IsValid;

	private static FFieldAddress InitializeMaterialNode_DisplayLabel_PropertyAddress;

	private static int InitializeMaterialNode_DisplayLabel_Offset;

	private static bool InitializeMaterialNode_InAssetClass_IsValid;

	private static FFieldAddress InitializeMaterialNode_InAssetClass_PropertyAddress;

	private static int InitializeMaterialNode_InAssetClass_Offset;

	private static bool GetTextureDependency_IsValid;

	private static IntPtr GetTextureDependency_FunctionAddress;

	private static int GetTextureDependency_ParamsSize;

	private static bool GetTextureDependency_Index_IsValid;

	private static FFieldAddress GetTextureDependency_Index_PropertyAddress;

	private static int GetTextureDependency_Index_Offset;

	private static bool GetTextureDependency_OutDependency_IsValid;

	private static FFieldAddress GetTextureDependency_OutDependency_PropertyAddress;

	private static int GetTextureDependency_OutDependency_Offset;

	private static bool GetTextureDependencies_IsValid;

	private static IntPtr GetTextureDependencies_FunctionAddress;

	private static int GetTextureDependencies_ParamsSize;

	private static bool GetTextureDependencies_OutDependencies_IsValid;

	private static FFieldAddress GetTextureDependencies_OutDependencies_PropertyAddress;

	private static int GetTextureDependencies_OutDependencies_Offset;

	private static bool GetTextureDependeciesCount_IsValid;

	private static IntPtr GetTextureDependeciesCount_FunctionAddress;

	private static int GetTextureDependeciesCount_ParamsSize;

	private static bool GetTextureDependeciesCount_ReturnValue_IsValid;

	private static FFieldAddress GetTextureDependeciesCount_ReturnValue_PropertyAddress;

	private static int GetTextureDependeciesCount_ReturnValue_Offset;

	private static bool GetObjectClass_IsValid;

	private static IntPtr GetObjectClass_FunctionAddress;

	private static int GetObjectClass_ParamsSize;

	private static bool GetObjectClass_ReturnValue_IsValid;

	private static FFieldAddress GetObjectClass_ReturnValue_PropertyAddress;

	private static int GetObjectClass_ReturnValue_Offset;

	private static bool GetCustomTranslatedMaterialNodeUid_IsValid;

	private static IntPtr GetCustomTranslatedMaterialNodeUid_FunctionAddress;

	private static int GetCustomTranslatedMaterialNodeUid_ParamsSize;

	private static bool GetCustomTranslatedMaterialNodeUid_AttributeValue_IsValid;

	private static FFieldAddress GetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress;

	private static int GetCustomTranslatedMaterialNodeUid_AttributeValue_Offset;

	private static bool GetCustomTranslatedMaterialNodeUid_ReturnValue_IsValid;

	private static FFieldAddress GetCustomTranslatedMaterialNodeUid_ReturnValue_PropertyAddress;

	private static int GetCustomTranslatedMaterialNodeUid_ReturnValue_Offset;

	private static bool GetCustomMaterialUsage_IsValid;

	private static IntPtr GetCustomMaterialUsage_FunctionAddress;

	private static int GetCustomMaterialUsage_ParamsSize;

	private static bool GetCustomMaterialUsage_AttributeValue_IsValid;

	private static FFieldAddress GetCustomMaterialUsage_AttributeValue_PropertyAddress;

	private static int GetCustomMaterialUsage_AttributeValue_Offset;

	private static bool GetCustomMaterialUsage_ReturnValue_IsValid;

	private static FFieldAddress GetCustomMaterialUsage_ReturnValue_PropertyAddress;

	private static int GetCustomMaterialUsage_ReturnValue_Offset;

	private static bool GetCustomBlendMode_IsValid;

	private static IntPtr GetCustomBlendMode_FunctionAddress;

	private static int GetCustomBlendMode_ParamsSize;

	private static bool GetCustomBlendMode_AttributeValue_IsValid;

	private static FFieldAddress GetCustomBlendMode_AttributeValue_PropertyAddress;

	private static int GetCustomBlendMode_AttributeValue_Offset;

	private static bool GetCustomBlendMode_ReturnValue_IsValid;

	private static FFieldAddress GetCustomBlendMode_ReturnValue_PropertyAddress;

	private static int GetCustomBlendMode_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetTextureDependencyUid")]
	public unsafe bool SetTextureDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!SetTextureDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetTextureDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetTextureDependencyUid_DependencyUid_Offset), 0, SetTextureDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextureDependencyUid_FunctionAddress, intPtr, SetTextureDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTextureDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetTextureDependencyUid_ReturnValue_Offset), 0, SetTextureDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomTranslatedMaterialNodeUid")]
	public unsafe bool SetCustomTranslatedMaterialNodeUid(string AttributeValue)
	{
		CheckDestroyed();
		if (!SetCustomTranslatedMaterialNodeUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomTranslatedMaterialNodeUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomTranslatedMaterialNodeUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomTranslatedMaterialNodeUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomTranslatedMaterialNodeUid_AttributeValue_Offset), 0, SetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress.Address, AttributeValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomTranslatedMaterialNodeUid_FunctionAddress, intPtr, SetCustomTranslatedMaterialNodeUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomTranslatedMaterialNodeUid_ReturnValue_Offset), 0, SetCustomTranslatedMaterialNodeUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomMaterialUsage")]
	public unsafe bool SetCustomMaterialUsage(byte AttributeValue, bool bAddApplyDelegate = true)
	{
		CheckDestroyed();
		if (!SetCustomMaterialUsage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomMaterialUsage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomMaterialUsage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomMaterialUsage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetCustomMaterialUsage_AttributeValue_Offset), 0, SetCustomMaterialUsage_AttributeValue_PropertyAddress.Address, AttributeValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomMaterialUsage_bAddApplyDelegate_Offset), 0, SetCustomMaterialUsage_bAddApplyDelegate_PropertyAddress.Address, bAddApplyDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomMaterialUsage_FunctionAddress, intPtr, SetCustomMaterialUsage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomMaterialUsage_ReturnValue_Offset), 0, SetCustomMaterialUsage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomBlendMode")]
	public unsafe bool SetCustomBlendMode(byte AttributeValue, bool bAddApplyDelegate = true)
	{
		CheckDestroyed();
		if (!SetCustomBlendMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomBlendMode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomBlendMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomBlendMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetCustomBlendMode_AttributeValue_Offset), 0, SetCustomBlendMode_AttributeValue_PropertyAddress.Address, AttributeValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomBlendMode_bAddApplyDelegate_Offset), 0, SetCustomBlendMode_bAddApplyDelegate_PropertyAddress.Address, bAddApplyDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomBlendMode_FunctionAddress, intPtr, SetCustomBlendMode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomBlendMode_ReturnValue_Offset), 0, SetCustomBlendMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:RemoveTextureDependencyUid")]
	public unsafe bool RemoveTextureDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!RemoveTextureDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:RemoveTextureDependencyUid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTextureDependencyUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTextureDependencyUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveTextureDependencyUid_DependencyUid_Offset), 0, RemoveTextureDependencyUid_DependencyUid_PropertyAddress.Address, DependencyUid);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveTextureDependencyUid_FunctionAddress, intPtr, RemoveTextureDependencyUid_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveTextureDependencyUid_DependencyUid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveTextureDependencyUid_ReturnValue_Offset), 0, RemoveTextureDependencyUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:InitializeMaterialNode")]
	public unsafe void InitializeMaterialNode(string UniqueID, string DisplayLabel, string InAssetClass)
	{
		CheckDestroyed();
		if (!InitializeMaterialNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:InitializeMaterialNode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeMaterialNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeMaterialNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeMaterialNode_UniqueID_Offset), 0, InitializeMaterialNode_UniqueID_PropertyAddress.Address, UniqueID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeMaterialNode_DisplayLabel_Offset), 0, InitializeMaterialNode_DisplayLabel_PropertyAddress.Address, DisplayLabel);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, InitializeMaterialNode_InAssetClass_Offset), 0, InitializeMaterialNode_InAssetClass_PropertyAddress.Address, InAssetClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeMaterialNode_FunctionAddress, intPtr, InitializeMaterialNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(InitializeMaterialNode_UniqueID_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeMaterialNode_DisplayLabel_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(InitializeMaterialNode_InAssetClass_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependency")]
	public unsafe void GetTextureDependency(int Index, out string OutDependency)
	{
		CheckDestroyed();
		if (!GetTextureDependency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependency");
			OutDependency = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureDependency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureDependency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTextureDependency_Index_Offset), 0, GetTextureDependency_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureDependency_FunctionAddress, intPtr, GetTextureDependency_ParamsSize);
		OutDependency = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTextureDependency_OutDependency_Offset), 0, GetTextureDependency_OutDependency_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTextureDependency_OutDependency_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependencies")]
	public unsafe void GetTextureDependencies(out List<string> OutDependencies)
	{
		CheckDestroyed();
		if (!GetTextureDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependencies");
			OutDependencies = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureDependencies_FunctionAddress, intPtr, GetTextureDependencies_ParamsSize);
		OutDependencies = new TArrayCopyMarshaler<string>(1, GetTextureDependencies_OutDependencies_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetTextureDependencies_OutDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(GetTextureDependencies_OutDependencies_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependeciesCount")]
	public unsafe int GetTextureDependeciesCount()
	{
		CheckDestroyed();
		if (!GetTextureDependeciesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependeciesCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureDependeciesCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureDependeciesCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureDependeciesCount_FunctionAddress, intPtr, GetTextureDependeciesCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextureDependeciesCount_ReturnValue_Offset), 0, GetTextureDependeciesCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetObjectClass")]
	public unsafe TSubclassOf<UObject> GetObjectClass()
	{
		CheckDestroyed();
		if (!GetObjectClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetObjectClass");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomTranslatedMaterialNodeUid")]
	public unsafe bool GetCustomTranslatedMaterialNodeUid(out string AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomTranslatedMaterialNodeUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomTranslatedMaterialNodeUid");
			AttributeValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomTranslatedMaterialNodeUid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomTranslatedMaterialNodeUid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomTranslatedMaterialNodeUid_FunctionAddress, intPtr, GetCustomTranslatedMaterialNodeUid_ParamsSize);
		AttributeValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomTranslatedMaterialNodeUid_AttributeValue_Offset), 0, GetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomTranslatedMaterialNodeUid_ReturnValue_Offset), 0, GetCustomTranslatedMaterialNodeUid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomMaterialUsage")]
	public unsafe bool GetCustomMaterialUsage(out byte AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomMaterialUsage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomMaterialUsage");
			AttributeValue = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomMaterialUsage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomMaterialUsage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomMaterialUsage_FunctionAddress, intPtr, GetCustomMaterialUsage_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetCustomMaterialUsage_AttributeValue_Offset), 0, GetCustomMaterialUsage_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomMaterialUsage_ReturnValue_Offset), 0, GetCustomMaterialUsage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomBlendMode")]
	public unsafe bool GetCustomBlendMode(out byte AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomBlendMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomBlendMode");
			AttributeValue = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomBlendMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomBlendMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomBlendMode_FunctionAddress, intPtr, GetCustomBlendMode_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetCustomBlendMode_AttributeValue_Offset), 0, GetCustomBlendMode_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomBlendMode_ReturnValue_Offset), 0, GetCustomBlendMode_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeMaterialFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeMaterialFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeMaterialFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeMaterialFactoryNode");
		SetTextureDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTextureDependencyUid");
		SetTextureDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureDependencyUid_DependencyUid_PropertyAddress, SetTextureDependencyUid_FunctionAddress, "DependencyUid");
		SetTextureDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureDependencyUid_FunctionAddress, "DependencyUid");
		SetTextureDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureDependencyUid_ReturnValue_PropertyAddress, SetTextureDependencyUid_FunctionAddress, "ReturnValue");
		SetTextureDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureDependencyUid_FunctionAddress, "ReturnValue");
		SetTextureDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTextureDependencyUid_IsValid = SetTextureDependencyUid_FunctionAddress != IntPtr.Zero && SetTextureDependencyUid_DependencyUid_IsValid && SetTextureDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetTextureDependencyUid", SetTextureDependencyUid_IsValid);
		SetCustomTranslatedMaterialNodeUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomTranslatedMaterialNodeUid");
		SetCustomTranslatedMaterialNodeUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomTranslatedMaterialNodeUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress, SetCustomTranslatedMaterialNodeUid_FunctionAddress, "AttributeValue");
		SetCustomTranslatedMaterialNodeUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomTranslatedMaterialNodeUid_FunctionAddress, "AttributeValue");
		SetCustomTranslatedMaterialNodeUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomTranslatedMaterialNodeUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomTranslatedMaterialNodeUid_ReturnValue_PropertyAddress, SetCustomTranslatedMaterialNodeUid_FunctionAddress, "ReturnValue");
		SetCustomTranslatedMaterialNodeUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomTranslatedMaterialNodeUid_FunctionAddress, "ReturnValue");
		SetCustomTranslatedMaterialNodeUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomTranslatedMaterialNodeUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomTranslatedMaterialNodeUid_IsValid = SetCustomTranslatedMaterialNodeUid_FunctionAddress != IntPtr.Zero && SetCustomTranslatedMaterialNodeUid_AttributeValue_IsValid && SetCustomTranslatedMaterialNodeUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomTranslatedMaterialNodeUid", SetCustomTranslatedMaterialNodeUid_IsValid);
		SetCustomMaterialUsage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomMaterialUsage");
		SetCustomMaterialUsage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomMaterialUsage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomMaterialUsage_AttributeValue_PropertyAddress, SetCustomMaterialUsage_FunctionAddress, "AttributeValue");
		SetCustomMaterialUsage_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomMaterialUsage_FunctionAddress, "AttributeValue");
		SetCustomMaterialUsage_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomMaterialUsage_FunctionAddress, "AttributeValue", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomMaterialUsage_bAddApplyDelegate_PropertyAddress, SetCustomMaterialUsage_FunctionAddress, "bAddApplyDelegate");
		SetCustomMaterialUsage_bAddApplyDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomMaterialUsage_FunctionAddress, "bAddApplyDelegate");
		SetCustomMaterialUsage_bAddApplyDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomMaterialUsage_FunctionAddress, "bAddApplyDelegate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomMaterialUsage_ReturnValue_PropertyAddress, SetCustomMaterialUsage_FunctionAddress, "ReturnValue");
		SetCustomMaterialUsage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomMaterialUsage_FunctionAddress, "ReturnValue");
		SetCustomMaterialUsage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomMaterialUsage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomMaterialUsage_IsValid = SetCustomMaterialUsage_FunctionAddress != IntPtr.Zero && SetCustomMaterialUsage_AttributeValue_IsValid && SetCustomMaterialUsage_bAddApplyDelegate_IsValid && SetCustomMaterialUsage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomMaterialUsage", SetCustomMaterialUsage_IsValid);
		SetCustomBlendMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomBlendMode");
		SetCustomBlendMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomBlendMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBlendMode_AttributeValue_PropertyAddress, SetCustomBlendMode_FunctionAddress, "AttributeValue");
		SetCustomBlendMode_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBlendMode_FunctionAddress, "AttributeValue");
		SetCustomBlendMode_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBlendMode_FunctionAddress, "AttributeValue", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBlendMode_bAddApplyDelegate_PropertyAddress, SetCustomBlendMode_FunctionAddress, "bAddApplyDelegate");
		SetCustomBlendMode_bAddApplyDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBlendMode_FunctionAddress, "bAddApplyDelegate");
		SetCustomBlendMode_bAddApplyDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBlendMode_FunctionAddress, "bAddApplyDelegate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBlendMode_ReturnValue_PropertyAddress, SetCustomBlendMode_FunctionAddress, "ReturnValue");
		SetCustomBlendMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBlendMode_FunctionAddress, "ReturnValue");
		SetCustomBlendMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBlendMode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomBlendMode_IsValid = SetCustomBlendMode_FunctionAddress != IntPtr.Zero && SetCustomBlendMode_AttributeValue_IsValid && SetCustomBlendMode_bAddApplyDelegate_IsValid && SetCustomBlendMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:SetCustomBlendMode", SetCustomBlendMode_IsValid);
		RemoveTextureDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveTextureDependencyUid");
		RemoveTextureDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTextureDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTextureDependencyUid_DependencyUid_PropertyAddress, RemoveTextureDependencyUid_FunctionAddress, "DependencyUid");
		RemoveTextureDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTextureDependencyUid_FunctionAddress, "DependencyUid");
		RemoveTextureDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTextureDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTextureDependencyUid_ReturnValue_PropertyAddress, RemoveTextureDependencyUid_FunctionAddress, "ReturnValue");
		RemoveTextureDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTextureDependencyUid_FunctionAddress, "ReturnValue");
		RemoveTextureDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTextureDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveTextureDependencyUid_IsValid = RemoveTextureDependencyUid_FunctionAddress != IntPtr.Zero && RemoveTextureDependencyUid_DependencyUid_IsValid && RemoveTextureDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:RemoveTextureDependencyUid", RemoveTextureDependencyUid_IsValid);
		InitializeMaterialNode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeMaterialNode");
		InitializeMaterialNode_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeMaterialNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeMaterialNode_UniqueID_PropertyAddress, InitializeMaterialNode_FunctionAddress, "UniqueID");
		InitializeMaterialNode_UniqueID_Offset = NativeReflectionCached.GetPropertyOffset(InitializeMaterialNode_FunctionAddress, "UniqueID");
		InitializeMaterialNode_UniqueID_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeMaterialNode_FunctionAddress, "UniqueID", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeMaterialNode_DisplayLabel_PropertyAddress, InitializeMaterialNode_FunctionAddress, "DisplayLabel");
		InitializeMaterialNode_DisplayLabel_Offset = NativeReflectionCached.GetPropertyOffset(InitializeMaterialNode_FunctionAddress, "DisplayLabel");
		InitializeMaterialNode_DisplayLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeMaterialNode_FunctionAddress, "DisplayLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeMaterialNode_InAssetClass_PropertyAddress, InitializeMaterialNode_FunctionAddress, "InAssetClass");
		InitializeMaterialNode_InAssetClass_Offset = NativeReflectionCached.GetPropertyOffset(InitializeMaterialNode_FunctionAddress, "InAssetClass");
		InitializeMaterialNode_InAssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeMaterialNode_FunctionAddress, "InAssetClass", Classes.FStrProperty);
		InitializeMaterialNode_IsValid = InitializeMaterialNode_FunctionAddress != IntPtr.Zero && InitializeMaterialNode_UniqueID_IsValid && InitializeMaterialNode_DisplayLabel_IsValid && InitializeMaterialNode_InAssetClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:InitializeMaterialNode", InitializeMaterialNode_IsValid);
		GetTextureDependency_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureDependency");
		GetTextureDependency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureDependency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependency_Index_PropertyAddress, GetTextureDependency_FunctionAddress, "Index");
		GetTextureDependency_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependency_FunctionAddress, "Index");
		GetTextureDependency_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependency_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependency_OutDependency_PropertyAddress, GetTextureDependency_FunctionAddress, "OutDependency");
		GetTextureDependency_OutDependency_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependency_FunctionAddress, "OutDependency");
		GetTextureDependency_OutDependency_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependency_FunctionAddress, "OutDependency", Classes.FStrProperty);
		GetTextureDependency_IsValid = GetTextureDependency_FunctionAddress != IntPtr.Zero && GetTextureDependency_Index_IsValid && GetTextureDependency_OutDependency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependency", GetTextureDependency_IsValid);
		GetTextureDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureDependencies");
		GetTextureDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependencies_OutDependencies_PropertyAddress, GetTextureDependencies_FunctionAddress, "OutDependencies");
		GetTextureDependencies_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependencies_FunctionAddress, "OutDependencies");
		GetTextureDependencies_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependencies_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		GetTextureDependencies_IsValid = GetTextureDependencies_FunctionAddress != IntPtr.Zero && GetTextureDependencies_OutDependencies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependencies", GetTextureDependencies_IsValid);
		GetTextureDependeciesCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureDependeciesCount");
		GetTextureDependeciesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureDependeciesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependeciesCount_ReturnValue_PropertyAddress, GetTextureDependeciesCount_FunctionAddress, "ReturnValue");
		GetTextureDependeciesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependeciesCount_FunctionAddress, "ReturnValue");
		GetTextureDependeciesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependeciesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTextureDependeciesCount_IsValid = GetTextureDependeciesCount_FunctionAddress != IntPtr.Zero && GetTextureDependeciesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetTextureDependeciesCount", GetTextureDependeciesCount_IsValid);
		GetObjectClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetObjectClass");
		GetObjectClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectClass_ReturnValue_PropertyAddress, GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectClass_FunctionAddress, "ReturnValue");
		GetObjectClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetObjectClass_IsValid = GetObjectClass_FunctionAddress != IntPtr.Zero && GetObjectClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetObjectClass", GetObjectClass_IsValid);
		GetCustomTranslatedMaterialNodeUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomTranslatedMaterialNodeUid");
		GetCustomTranslatedMaterialNodeUid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomTranslatedMaterialNodeUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomTranslatedMaterialNodeUid_AttributeValue_PropertyAddress, GetCustomTranslatedMaterialNodeUid_FunctionAddress, "AttributeValue");
		GetCustomTranslatedMaterialNodeUid_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomTranslatedMaterialNodeUid_FunctionAddress, "AttributeValue");
		GetCustomTranslatedMaterialNodeUid_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomTranslatedMaterialNodeUid_FunctionAddress, "AttributeValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomTranslatedMaterialNodeUid_ReturnValue_PropertyAddress, GetCustomTranslatedMaterialNodeUid_FunctionAddress, "ReturnValue");
		GetCustomTranslatedMaterialNodeUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomTranslatedMaterialNodeUid_FunctionAddress, "ReturnValue");
		GetCustomTranslatedMaterialNodeUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomTranslatedMaterialNodeUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomTranslatedMaterialNodeUid_IsValid = GetCustomTranslatedMaterialNodeUid_FunctionAddress != IntPtr.Zero && GetCustomTranslatedMaterialNodeUid_AttributeValue_IsValid && GetCustomTranslatedMaterialNodeUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomTranslatedMaterialNodeUid", GetCustomTranslatedMaterialNodeUid_IsValid);
		GetCustomMaterialUsage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomMaterialUsage");
		GetCustomMaterialUsage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomMaterialUsage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomMaterialUsage_AttributeValue_PropertyAddress, GetCustomMaterialUsage_FunctionAddress, "AttributeValue");
		GetCustomMaterialUsage_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomMaterialUsage_FunctionAddress, "AttributeValue");
		GetCustomMaterialUsage_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomMaterialUsage_FunctionAddress, "AttributeValue", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomMaterialUsage_ReturnValue_PropertyAddress, GetCustomMaterialUsage_FunctionAddress, "ReturnValue");
		GetCustomMaterialUsage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomMaterialUsage_FunctionAddress, "ReturnValue");
		GetCustomMaterialUsage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomMaterialUsage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomMaterialUsage_IsValid = GetCustomMaterialUsage_FunctionAddress != IntPtr.Zero && GetCustomMaterialUsage_AttributeValue_IsValid && GetCustomMaterialUsage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomMaterialUsage", GetCustomMaterialUsage_IsValid);
		GetCustomBlendMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomBlendMode");
		GetCustomBlendMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomBlendMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomBlendMode_AttributeValue_PropertyAddress, GetCustomBlendMode_FunctionAddress, "AttributeValue");
		GetCustomBlendMode_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomBlendMode_FunctionAddress, "AttributeValue");
		GetCustomBlendMode_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomBlendMode_FunctionAddress, "AttributeValue", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomBlendMode_ReturnValue_PropertyAddress, GetCustomBlendMode_FunctionAddress, "ReturnValue");
		GetCustomBlendMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomBlendMode_FunctionAddress, "ReturnValue");
		GetCustomBlendMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomBlendMode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomBlendMode_IsValid = GetCustomBlendMode_FunctionAddress != IntPtr.Zero && GetCustomBlendMode_AttributeValue_IsValid && GetCustomBlendMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialFactoryNode:GetCustomBlendMode", GetCustomBlendMode_IsValid);
	}
}
