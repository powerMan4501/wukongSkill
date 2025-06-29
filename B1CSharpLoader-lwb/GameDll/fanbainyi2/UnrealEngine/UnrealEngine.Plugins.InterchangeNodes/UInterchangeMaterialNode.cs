using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeMaterialNode : UInterchangeBaseNode
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

	private static bool SetPayLoadKey_IsValid;

	private static IntPtr SetPayLoadKey_FunctionAddress;

	private static int SetPayLoadKey_ParamsSize;

	private static bool SetPayLoadKey_PayloadKey_IsValid;

	private static FFieldAddress SetPayLoadKey_PayloadKey_PropertyAddress;

	private static int SetPayLoadKey_PayloadKey_Offset;

	private static bool RemoveTextureDependencyUid_IsValid;

	private static IntPtr RemoveTextureDependencyUid_FunctionAddress;

	private static int RemoveTextureDependencyUid_ParamsSize;

	private static bool RemoveTextureDependencyUid_DependencyUid_IsValid;

	private static FFieldAddress RemoveTextureDependencyUid_DependencyUid_PropertyAddress;

	private static int RemoveTextureDependencyUid_DependencyUid_Offset;

	private static bool RemoveTextureDependencyUid_ReturnValue_IsValid;

	private static FFieldAddress RemoveTextureDependencyUid_ReturnValue_PropertyAddress;

	private static int RemoveTextureDependencyUid_ReturnValue_Offset;

	private static bool GetVectorParameterData_IsValid;

	private static IntPtr GetVectorParameterData_FunctionAddress;

	private static int GetVectorParameterData_ParamsSize;

	private static bool GetVectorParameterData_ParameterName_IsValid;

	private static FFieldAddress GetVectorParameterData_ParameterName_PropertyAddress;

	private static int GetVectorParameterData_ParameterName_Offset;

	private static bool GetVectorParameterData_OutVectorData_IsValid;

	private static FFieldAddress GetVectorParameterData_OutVectorData_PropertyAddress;

	private static int GetVectorParameterData_OutVectorData_Offset;

	private static bool GetVectorParameterData_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameterData_ReturnValue_PropertyAddress;

	private static int GetVectorParameterData_ReturnValue_Offset;

	private static bool GetTextureParameterData_IsValid;

	private static IntPtr GetTextureParameterData_FunctionAddress;

	private static int GetTextureParameterData_ParamsSize;

	private static bool GetTextureParameterData_ParameterName_IsValid;

	private static FFieldAddress GetTextureParameterData_ParameterName_PropertyAddress;

	private static int GetTextureParameterData_ParameterName_Offset;

	private static bool GetTextureParameterData_OutTextureUid_IsValid;

	private static FFieldAddress GetTextureParameterData_OutTextureUid_PropertyAddress;

	private static int GetTextureParameterData_OutTextureUid_Offset;

	private static bool GetTextureParameterData_OutUVSetIndex_IsValid;

	private static FFieldAddress GetTextureParameterData_OutUVSetIndex_PropertyAddress;

	private static int GetTextureParameterData_OutUVSetIndex_Offset;

	private static bool GetTextureParameterData_OutScaleU_IsValid;

	private static FFieldAddress GetTextureParameterData_OutScaleU_PropertyAddress;

	private static int GetTextureParameterData_OutScaleU_Offset;

	private static bool GetTextureParameterData_OutScaleV_IsValid;

	private static FFieldAddress GetTextureParameterData_OutScaleV_PropertyAddress;

	private static int GetTextureParameterData_OutScaleV_Offset;

	private static bool GetTextureParameterData_ReturnValue_IsValid;

	private static FFieldAddress GetTextureParameterData_ReturnValue_PropertyAddress;

	private static int GetTextureParameterData_ReturnValue_Offset;

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

	private static bool GetScalarParameterData_IsValid;

	private static IntPtr GetScalarParameterData_FunctionAddress;

	private static int GetScalarParameterData_ParamsSize;

	private static bool GetScalarParameterData_ParameterName_IsValid;

	private static FFieldAddress GetScalarParameterData_ParameterName_PropertyAddress;

	private static int GetScalarParameterData_ParameterName_Offset;

	private static bool GetScalarParameterData_OutScalarData_IsValid;

	private static FFieldAddress GetScalarParameterData_OutScalarData_PropertyAddress;

	private static int GetScalarParameterData_OutScalarData_Offset;

	private static bool GetScalarParameterData_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterData_ReturnValue_PropertyAddress;

	private static int GetScalarParameterData_ReturnValue_Offset;

	private static bool AddVectorParameterData_IsValid;

	private static IntPtr AddVectorParameterData_FunctionAddress;

	private static int AddVectorParameterData_ParamsSize;

	private static bool AddVectorParameterData_ParameterName_IsValid;

	private static FFieldAddress AddVectorParameterData_ParameterName_PropertyAddress;

	private static int AddVectorParameterData_ParameterName_Offset;

	private static bool AddVectorParameterData_VectorData_IsValid;

	private static FFieldAddress AddVectorParameterData_VectorData_PropertyAddress;

	private static int AddVectorParameterData_VectorData_Offset;

	private static bool AddTextureParameterData_IsValid;

	private static IntPtr AddTextureParameterData_FunctionAddress;

	private static int AddTextureParameterData_ParamsSize;

	private static bool AddTextureParameterData_ParameterName_IsValid;

	private static FFieldAddress AddTextureParameterData_ParameterName_PropertyAddress;

	private static int AddTextureParameterData_ParameterName_Offset;

	private static bool AddTextureParameterData_TextureUid_IsValid;

	private static FFieldAddress AddTextureParameterData_TextureUid_PropertyAddress;

	private static int AddTextureParameterData_TextureUid_Offset;

	private static bool AddTextureParameterData_UVSetIndex_IsValid;

	private static FFieldAddress AddTextureParameterData_UVSetIndex_PropertyAddress;

	private static int AddTextureParameterData_UVSetIndex_Offset;

	private static bool AddTextureParameterData_ScaleU_IsValid;

	private static FFieldAddress AddTextureParameterData_ScaleU_PropertyAddress;

	private static int AddTextureParameterData_ScaleU_Offset;

	private static bool AddTextureParameterData_ScaleV_IsValid;

	private static FFieldAddress AddTextureParameterData_ScaleV_PropertyAddress;

	private static int AddTextureParameterData_ScaleV_Offset;

	private static bool AddScalarParameterData_IsValid;

	private static IntPtr AddScalarParameterData_FunctionAddress;

	private static int AddScalarParameterData_ParamsSize;

	private static bool AddScalarParameterData_ParameterName_IsValid;

	private static FFieldAddress AddScalarParameterData_ParameterName_PropertyAddress;

	private static int AddScalarParameterData_ParameterName_Offset;

	private static bool AddScalarParameterData_ScalarData_IsValid;

	private static FFieldAddress AddScalarParameterData_ScalarData_PropertyAddress;

	private static int AddScalarParameterData_ScalarData_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:SetTextureDependencyUid")]
	public unsafe bool SetTextureDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!SetTextureDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:SetTextureDependencyUid");
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

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:SetPayLoadKey")]
	public unsafe void SetPayLoadKey(string PayloadKey)
	{
		CheckDestroyed();
		if (!SetPayLoadKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:SetPayLoadKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPayLoadKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPayLoadKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPayLoadKey_PayloadKey_Offset), 0, SetPayLoadKey_PayloadKey_PropertyAddress.Address, PayloadKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPayLoadKey_FunctionAddress, intPtr, SetPayLoadKey_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPayLoadKey_PayloadKey_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:RemoveTextureDependencyUid")]
	public unsafe bool RemoveTextureDependencyUid(string DependencyUid)
	{
		CheckDestroyed();
		if (!RemoveTextureDependencyUid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:RemoveTextureDependencyUid");
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

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:GetVectorParameterData")]
	public unsafe bool GetVectorParameterData(EInterchangeMaterialNodeParameterName ParameterName, out FVector OutVectorData)
	{
		CheckDestroyed();
		if (!GetVectorParameterData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:GetVectorParameterData");
			OutVectorData = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameterData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameterData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangeMaterialNodeParameterName>.ToNative(IntPtr.Add(intPtr, GetVectorParameterData_ParameterName_Offset), 0, GetVectorParameterData_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorParameterData_FunctionAddress, intPtr, GetVectorParameterData_ParamsSize);
		OutVectorData = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorParameterData_OutVectorData_Offset), 0, GetVectorParameterData_OutVectorData_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetVectorParameterData_ReturnValue_Offset), 0, GetVectorParameterData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureParameterData")]
	public unsafe bool GetTextureParameterData(EInterchangeMaterialNodeParameterName ParameterName, out string OutTextureUid, out int OutUVSetIndex, out float OutScaleU, out float OutScaleV)
	{
		CheckDestroyed();
		if (!GetTextureParameterData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureParameterData");
			OutTextureUid = FStringMarshaler.DefaultString;
			OutUVSetIndex = 0;
			OutScaleU = 0f;
			OutScaleV = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureParameterData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureParameterData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangeMaterialNodeParameterName>.ToNative(IntPtr.Add(intPtr, GetTextureParameterData_ParameterName_Offset), 0, GetTextureParameterData_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureParameterData_FunctionAddress, intPtr, GetTextureParameterData_ParamsSize);
		OutTextureUid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTextureParameterData_OutTextureUid_Offset), 0, GetTextureParameterData_OutTextureUid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTextureParameterData_OutTextureUid_PropertyAddress.Address, intPtr);
		OutUVSetIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTextureParameterData_OutUVSetIndex_Offset), 0, GetTextureParameterData_OutUVSetIndex_PropertyAddress.Address);
		OutScaleU = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTextureParameterData_OutScaleU_Offset), 0, GetTextureParameterData_OutScaleU_PropertyAddress.Address);
		OutScaleV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTextureParameterData_OutScaleV_Offset), 0, GetTextureParameterData_OutScaleV_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTextureParameterData_ReturnValue_Offset), 0, GetTextureParameterData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependency")]
	public unsafe void GetTextureDependency(int Index, out string OutDependency)
	{
		CheckDestroyed();
		if (!GetTextureDependency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependency");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependencies")]
	public unsafe void GetTextureDependencies(out List<string> OutDependencies)
	{
		CheckDestroyed();
		if (!GetTextureDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependencies");
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
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependeciesCount")]
	public unsafe int GetTextureDependeciesCount()
	{
		CheckDestroyed();
		if (!GetTextureDependeciesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependeciesCount");
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

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:GetScalarParameterData")]
	public unsafe bool GetScalarParameterData(EInterchangeMaterialNodeParameterName ParameterName, out float OutScalarData)
	{
		CheckDestroyed();
		if (!GetScalarParameterData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:GetScalarParameterData");
			OutScalarData = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangeMaterialNodeParameterName>.ToNative(IntPtr.Add(intPtr, GetScalarParameterData_ParameterName_Offset), 0, GetScalarParameterData_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScalarParameterData_FunctionAddress, intPtr, GetScalarParameterData_ParamsSize);
		OutScalarData = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScalarParameterData_OutScalarData_Offset), 0, GetScalarParameterData_OutScalarData_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetScalarParameterData_ReturnValue_Offset), 0, GetScalarParameterData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:AddVectorParameterData")]
	public unsafe void AddVectorParameterData(EInterchangeMaterialNodeParameterName ParameterName, FVector VectorData)
	{
		CheckDestroyed();
		if (!AddVectorParameterData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:AddVectorParameterData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddVectorParameterData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddVectorParameterData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangeMaterialNodeParameterName>.ToNative(IntPtr.Add(intPtr, AddVectorParameterData_ParameterName_Offset), 0, AddVectorParameterData_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddVectorParameterData_VectorData_Offset), 0, AddVectorParameterData_VectorData_PropertyAddress.Address, VectorData);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddVectorParameterData_FunctionAddress, intPtr, AddVectorParameterData_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:AddTextureParameterData")]
	public unsafe void AddTextureParameterData(EInterchangeMaterialNodeParameterName ParameterName, string TextureUid, int UVSetIndex, float ScaleU, float ScaleV)
	{
		CheckDestroyed();
		if (!AddTextureParameterData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:AddTextureParameterData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTextureParameterData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTextureParameterData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangeMaterialNodeParameterName>.ToNative(IntPtr.Add(intPtr, AddTextureParameterData_ParameterName_Offset), 0, AddTextureParameterData_ParameterName_PropertyAddress.Address, ParameterName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddTextureParameterData_TextureUid_Offset), 0, AddTextureParameterData_TextureUid_PropertyAddress.Address, TextureUid);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddTextureParameterData_UVSetIndex_Offset), 0, AddTextureParameterData_UVSetIndex_PropertyAddress.Address, UVSetIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddTextureParameterData_ScaleU_Offset), 0, AddTextureParameterData_ScaleU_PropertyAddress.Address, ScaleU);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddTextureParameterData_ScaleV_Offset), 0, AddTextureParameterData_ScaleV_PropertyAddress.Address, ScaleV);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddTextureParameterData_FunctionAddress, intPtr, AddTextureParameterData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddTextureParameterData_TextureUid_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeMaterialNode:AddScalarParameterData")]
	public unsafe void AddScalarParameterData(EInterchangeMaterialNodeParameterName ParameterName, float ScalarData)
	{
		CheckDestroyed();
		if (!AddScalarParameterData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeMaterialNode:AddScalarParameterData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddScalarParameterData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddScalarParameterData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangeMaterialNodeParameterName>.ToNative(IntPtr.Add(intPtr, AddScalarParameterData_ParameterName_Offset), 0, AddScalarParameterData_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddScalarParameterData_ScalarData_Offset), 0, AddScalarParameterData_ScalarData_PropertyAddress.Address, ScalarData);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddScalarParameterData_FunctionAddress, intPtr, AddScalarParameterData_ParamsSize);
	}

	static UInterchangeMaterialNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeMaterialNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeMaterialNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeMaterialNode");
		SetTextureDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTextureDependencyUid");
		SetTextureDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureDependencyUid_DependencyUid_PropertyAddress, SetTextureDependencyUid_FunctionAddress, "DependencyUid");
		SetTextureDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureDependencyUid_FunctionAddress, "DependencyUid");
		SetTextureDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureDependencyUid_ReturnValue_PropertyAddress, SetTextureDependencyUid_FunctionAddress, "ReturnValue");
		SetTextureDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureDependencyUid_FunctionAddress, "ReturnValue");
		SetTextureDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTextureDependencyUid_IsValid = SetTextureDependencyUid_FunctionAddress != IntPtr.Zero && SetTextureDependencyUid_DependencyUid_IsValid && SetTextureDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:SetTextureDependencyUid", SetTextureDependencyUid_IsValid);
		SetPayLoadKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPayLoadKey");
		SetPayLoadKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPayLoadKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPayLoadKey_PayloadKey_PropertyAddress, SetPayLoadKey_FunctionAddress, "PayloadKey");
		SetPayLoadKey_PayloadKey_Offset = NativeReflectionCached.GetPropertyOffset(SetPayLoadKey_FunctionAddress, "PayloadKey");
		SetPayLoadKey_PayloadKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPayLoadKey_FunctionAddress, "PayloadKey", Classes.FStrProperty);
		SetPayLoadKey_IsValid = SetPayLoadKey_FunctionAddress != IntPtr.Zero && SetPayLoadKey_PayloadKey_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:SetPayLoadKey", SetPayLoadKey_IsValid);
		RemoveTextureDependencyUid_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveTextureDependencyUid");
		RemoveTextureDependencyUid_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTextureDependencyUid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTextureDependencyUid_DependencyUid_PropertyAddress, RemoveTextureDependencyUid_FunctionAddress, "DependencyUid");
		RemoveTextureDependencyUid_DependencyUid_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTextureDependencyUid_FunctionAddress, "DependencyUid");
		RemoveTextureDependencyUid_DependencyUid_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTextureDependencyUid_FunctionAddress, "DependencyUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTextureDependencyUid_ReturnValue_PropertyAddress, RemoveTextureDependencyUid_FunctionAddress, "ReturnValue");
		RemoveTextureDependencyUid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTextureDependencyUid_FunctionAddress, "ReturnValue");
		RemoveTextureDependencyUid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTextureDependencyUid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveTextureDependencyUid_IsValid = RemoveTextureDependencyUid_FunctionAddress != IntPtr.Zero && RemoveTextureDependencyUid_DependencyUid_IsValid && RemoveTextureDependencyUid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:RemoveTextureDependencyUid", RemoveTextureDependencyUid_IsValid);
		GetVectorParameterData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVectorParameterData");
		GetVectorParameterData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameterData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterData_ParameterName_PropertyAddress, GetVectorParameterData_FunctionAddress, "ParameterName");
		GetVectorParameterData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterData_FunctionAddress, "ParameterName");
		GetVectorParameterData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterData_FunctionAddress, "ParameterName", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterData_OutVectorData_PropertyAddress, GetVectorParameterData_FunctionAddress, "OutVectorData");
		GetVectorParameterData_OutVectorData_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterData_FunctionAddress, "OutVectorData");
		GetVectorParameterData_OutVectorData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterData_FunctionAddress, "OutVectorData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterData_ReturnValue_PropertyAddress, GetVectorParameterData_FunctionAddress, "ReturnValue");
		GetVectorParameterData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterData_FunctionAddress, "ReturnValue");
		GetVectorParameterData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetVectorParameterData_IsValid = GetVectorParameterData_FunctionAddress != IntPtr.Zero && GetVectorParameterData_ParameterName_IsValid && GetVectorParameterData_OutVectorData_IsValid && GetVectorParameterData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:GetVectorParameterData", GetVectorParameterData_IsValid);
		GetTextureParameterData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureParameterData");
		GetTextureParameterData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureParameterData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterData_ParameterName_PropertyAddress, GetTextureParameterData_FunctionAddress, "ParameterName");
		GetTextureParameterData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterData_FunctionAddress, "ParameterName");
		GetTextureParameterData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterData_FunctionAddress, "ParameterName", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterData_OutTextureUid_PropertyAddress, GetTextureParameterData_FunctionAddress, "OutTextureUid");
		GetTextureParameterData_OutTextureUid_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterData_FunctionAddress, "OutTextureUid");
		GetTextureParameterData_OutTextureUid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterData_FunctionAddress, "OutTextureUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterData_OutUVSetIndex_PropertyAddress, GetTextureParameterData_FunctionAddress, "OutUVSetIndex");
		GetTextureParameterData_OutUVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterData_FunctionAddress, "OutUVSetIndex");
		GetTextureParameterData_OutUVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterData_FunctionAddress, "OutUVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterData_OutScaleU_PropertyAddress, GetTextureParameterData_FunctionAddress, "OutScaleU");
		GetTextureParameterData_OutScaleU_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterData_FunctionAddress, "OutScaleU");
		GetTextureParameterData_OutScaleU_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterData_FunctionAddress, "OutScaleU", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterData_OutScaleV_PropertyAddress, GetTextureParameterData_FunctionAddress, "OutScaleV");
		GetTextureParameterData_OutScaleV_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterData_FunctionAddress, "OutScaleV");
		GetTextureParameterData_OutScaleV_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterData_FunctionAddress, "OutScaleV", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterData_ReturnValue_PropertyAddress, GetTextureParameterData_FunctionAddress, "ReturnValue");
		GetTextureParameterData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterData_FunctionAddress, "ReturnValue");
		GetTextureParameterData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTextureParameterData_IsValid = GetTextureParameterData_FunctionAddress != IntPtr.Zero && GetTextureParameterData_ParameterName_IsValid && GetTextureParameterData_OutTextureUid_IsValid && GetTextureParameterData_OutUVSetIndex_IsValid && GetTextureParameterData_OutScaleU_IsValid && GetTextureParameterData_OutScaleV_IsValid && GetTextureParameterData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureParameterData", GetTextureParameterData_IsValid);
		GetTextureDependency_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureDependency");
		GetTextureDependency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureDependency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependency_Index_PropertyAddress, GetTextureDependency_FunctionAddress, "Index");
		GetTextureDependency_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependency_FunctionAddress, "Index");
		GetTextureDependency_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependency_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependency_OutDependency_PropertyAddress, GetTextureDependency_FunctionAddress, "OutDependency");
		GetTextureDependency_OutDependency_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependency_FunctionAddress, "OutDependency");
		GetTextureDependency_OutDependency_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependency_FunctionAddress, "OutDependency", Classes.FStrProperty);
		GetTextureDependency_IsValid = GetTextureDependency_FunctionAddress != IntPtr.Zero && GetTextureDependency_Index_IsValid && GetTextureDependency_OutDependency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependency", GetTextureDependency_IsValid);
		GetTextureDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureDependencies");
		GetTextureDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependencies_OutDependencies_PropertyAddress, GetTextureDependencies_FunctionAddress, "OutDependencies");
		GetTextureDependencies_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependencies_FunctionAddress, "OutDependencies");
		GetTextureDependencies_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependencies_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		GetTextureDependencies_IsValid = GetTextureDependencies_FunctionAddress != IntPtr.Zero && GetTextureDependencies_OutDependencies_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependencies", GetTextureDependencies_IsValid);
		GetTextureDependeciesCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTextureDependeciesCount");
		GetTextureDependeciesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureDependeciesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureDependeciesCount_ReturnValue_PropertyAddress, GetTextureDependeciesCount_FunctionAddress, "ReturnValue");
		GetTextureDependeciesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureDependeciesCount_FunctionAddress, "ReturnValue");
		GetTextureDependeciesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureDependeciesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTextureDependeciesCount_IsValid = GetTextureDependeciesCount_FunctionAddress != IntPtr.Zero && GetTextureDependeciesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:GetTextureDependeciesCount", GetTextureDependeciesCount_IsValid);
		GetScalarParameterData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetScalarParameterData");
		GetScalarParameterData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterData_ParameterName_PropertyAddress, GetScalarParameterData_FunctionAddress, "ParameterName");
		GetScalarParameterData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterData_FunctionAddress, "ParameterName");
		GetScalarParameterData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterData_FunctionAddress, "ParameterName", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterData_OutScalarData_PropertyAddress, GetScalarParameterData_FunctionAddress, "OutScalarData");
		GetScalarParameterData_OutScalarData_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterData_FunctionAddress, "OutScalarData");
		GetScalarParameterData_OutScalarData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterData_FunctionAddress, "OutScalarData", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterData_ReturnValue_PropertyAddress, GetScalarParameterData_FunctionAddress, "ReturnValue");
		GetScalarParameterData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterData_FunctionAddress, "ReturnValue");
		GetScalarParameterData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetScalarParameterData_IsValid = GetScalarParameterData_FunctionAddress != IntPtr.Zero && GetScalarParameterData_ParameterName_IsValid && GetScalarParameterData_OutScalarData_IsValid && GetScalarParameterData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:GetScalarParameterData", GetScalarParameterData_IsValid);
		AddVectorParameterData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddVectorParameterData");
		AddVectorParameterData_ParamsSize = NativeReflection.GetFunctionParamsSize(AddVectorParameterData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterData_ParameterName_PropertyAddress, AddVectorParameterData_FunctionAddress, "ParameterName");
		AddVectorParameterData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterData_FunctionAddress, "ParameterName");
		AddVectorParameterData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterData_FunctionAddress, "ParameterName", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddVectorParameterData_VectorData_PropertyAddress, AddVectorParameterData_FunctionAddress, "VectorData");
		AddVectorParameterData_VectorData_Offset = NativeReflectionCached.GetPropertyOffset(AddVectorParameterData_FunctionAddress, "VectorData");
		AddVectorParameterData_VectorData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddVectorParameterData_FunctionAddress, "VectorData", Classes.FStructProperty);
		AddVectorParameterData_IsValid = AddVectorParameterData_FunctionAddress != IntPtr.Zero && AddVectorParameterData_ParameterName_IsValid && AddVectorParameterData_VectorData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:AddVectorParameterData", AddVectorParameterData_IsValid);
		AddTextureParameterData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddTextureParameterData");
		AddTextureParameterData_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTextureParameterData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTextureParameterData_ParameterName_PropertyAddress, AddTextureParameterData_FunctionAddress, "ParameterName");
		AddTextureParameterData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddTextureParameterData_FunctionAddress, "ParameterName");
		AddTextureParameterData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTextureParameterData_FunctionAddress, "ParameterName", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTextureParameterData_TextureUid_PropertyAddress, AddTextureParameterData_FunctionAddress, "TextureUid");
		AddTextureParameterData_TextureUid_Offset = NativeReflectionCached.GetPropertyOffset(AddTextureParameterData_FunctionAddress, "TextureUid");
		AddTextureParameterData_TextureUid_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTextureParameterData_FunctionAddress, "TextureUid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTextureParameterData_UVSetIndex_PropertyAddress, AddTextureParameterData_FunctionAddress, "UVSetIndex");
		AddTextureParameterData_UVSetIndex_Offset = NativeReflectionCached.GetPropertyOffset(AddTextureParameterData_FunctionAddress, "UVSetIndex");
		AddTextureParameterData_UVSetIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTextureParameterData_FunctionAddress, "UVSetIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTextureParameterData_ScaleU_PropertyAddress, AddTextureParameterData_FunctionAddress, "ScaleU");
		AddTextureParameterData_ScaleU_Offset = NativeReflectionCached.GetPropertyOffset(AddTextureParameterData_FunctionAddress, "ScaleU");
		AddTextureParameterData_ScaleU_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTextureParameterData_FunctionAddress, "ScaleU", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTextureParameterData_ScaleV_PropertyAddress, AddTextureParameterData_FunctionAddress, "ScaleV");
		AddTextureParameterData_ScaleV_Offset = NativeReflectionCached.GetPropertyOffset(AddTextureParameterData_FunctionAddress, "ScaleV");
		AddTextureParameterData_ScaleV_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTextureParameterData_FunctionAddress, "ScaleV", Classes.FFloatProperty);
		AddTextureParameterData_IsValid = AddTextureParameterData_FunctionAddress != IntPtr.Zero && AddTextureParameterData_ParameterName_IsValid && AddTextureParameterData_TextureUid_IsValid && AddTextureParameterData_UVSetIndex_IsValid && AddTextureParameterData_ScaleU_IsValid && AddTextureParameterData_ScaleV_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:AddTextureParameterData", AddTextureParameterData_IsValid);
		AddScalarParameterData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddScalarParameterData");
		AddScalarParameterData_ParamsSize = NativeReflection.GetFunctionParamsSize(AddScalarParameterData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterData_ParameterName_PropertyAddress, AddScalarParameterData_FunctionAddress, "ParameterName");
		AddScalarParameterData_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterData_FunctionAddress, "ParameterName");
		AddScalarParameterData_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterData_FunctionAddress, "ParameterName", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AddScalarParameterData_ScalarData_PropertyAddress, AddScalarParameterData_FunctionAddress, "ScalarData");
		AddScalarParameterData_ScalarData_Offset = NativeReflectionCached.GetPropertyOffset(AddScalarParameterData_FunctionAddress, "ScalarData");
		AddScalarParameterData_ScalarData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddScalarParameterData_FunctionAddress, "ScalarData", Classes.FFloatProperty);
		AddScalarParameterData_IsValid = AddScalarParameterData_FunctionAddress != IntPtr.Zero && AddScalarParameterData_ParameterName_IsValid && AddScalarParameterData_ScalarData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeMaterialNode:AddScalarParameterData", AddScalarParameterData_IsValid);
	}
}
