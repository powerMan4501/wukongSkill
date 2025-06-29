using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818946208uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialInstanceDynamic", "Engine", UnrealModuleType.Engine)]
public class UMaterialInstanceDynamic : UMaterialInstance
{
	private static bool SetVectorParameterValueByInfo_IsValid;

	private static IntPtr SetVectorParameterValueByInfo_FunctionAddress;

	private static int SetVectorParameterValueByInfo_ParamsSize;

	private static bool SetVectorParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress SetVectorParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int SetVectorParameterValueByInfo_ParameterInfo_Offset;

	private static bool SetVectorParameterValueByInfo_Value_IsValid;

	private static FFieldAddress SetVectorParameterValueByInfo_Value_PropertyAddress;

	private static int SetVectorParameterValueByInfo_Value_Offset;

	private static bool SetVectorParameterValue_IsValid;

	private static IntPtr SetVectorParameterValue_FunctionAddress;

	private static int SetVectorParameterValue_ParamsSize;

	private static bool SetVectorParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetVectorParameterValue_ParameterName_PropertyAddress;

	private static int SetVectorParameterValue_ParameterName_Offset;

	private static bool SetVectorParameterValue_Value_IsValid;

	private static FFieldAddress SetVectorParameterValue_Value_PropertyAddress;

	private static int SetVectorParameterValue_Value_Offset;

	private static bool SetTextureParameterValueByInfo_IsValid;

	private static IntPtr SetTextureParameterValueByInfo_FunctionAddress;

	private static int SetTextureParameterValueByInfo_ParamsSize;

	private static bool SetTextureParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress SetTextureParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int SetTextureParameterValueByInfo_ParameterInfo_Offset;

	private static bool SetTextureParameterValueByInfo_Value_IsValid;

	private static FFieldAddress SetTextureParameterValueByInfo_Value_PropertyAddress;

	private static int SetTextureParameterValueByInfo_Value_Offset;

	private static bool SetTextureParameterValue_IsValid;

	private static IntPtr SetTextureParameterValue_FunctionAddress;

	private static int SetTextureParameterValue_ParamsSize;

	private static bool SetTextureParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetTextureParameterValue_ParameterName_PropertyAddress;

	private static int SetTextureParameterValue_ParameterName_Offset;

	private static bool SetTextureParameterValue_Value_IsValid;

	private static FFieldAddress SetTextureParameterValue_Value_PropertyAddress;

	private static int SetTextureParameterValue_Value_Offset;

	private static bool SetSparseVolumeTextureParameterValue_IsValid;

	private static IntPtr SetSparseVolumeTextureParameterValue_FunctionAddress;

	private static int SetSparseVolumeTextureParameterValue_ParamsSize;

	private static bool SetSparseVolumeTextureParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetSparseVolumeTextureParameterValue_ParameterName_PropertyAddress;

	private static int SetSparseVolumeTextureParameterValue_ParameterName_Offset;

	private static bool SetSparseVolumeTextureParameterValue_Value_IsValid;

	private static FFieldAddress SetSparseVolumeTextureParameterValue_Value_PropertyAddress;

	private static int SetSparseVolumeTextureParameterValue_Value_Offset;

	private static bool SetScalarParameterValueByInfo_IsValid;

	private static IntPtr SetScalarParameterValueByInfo_FunctionAddress;

	private static int SetScalarParameterValueByInfo_ParamsSize;

	private static bool SetScalarParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress SetScalarParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int SetScalarParameterValueByInfo_ParameterInfo_Offset;

	private static bool SetScalarParameterValueByInfo_Value_IsValid;

	private static FFieldAddress SetScalarParameterValueByInfo_Value_PropertyAddress;

	private static int SetScalarParameterValueByInfo_Value_Offset;

	private static bool SetScalarParameterValue_IsValid;

	private static IntPtr SetScalarParameterValue_FunctionAddress;

	private static int SetScalarParameterValue_ParamsSize;

	private static bool SetScalarParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetScalarParameterValue_ParameterName_PropertyAddress;

	private static int SetScalarParameterValue_ParameterName_Offset;

	private static bool SetScalarParameterValue_Value_IsValid;

	private static FFieldAddress SetScalarParameterValue_Value_PropertyAddress;

	private static int SetScalarParameterValue_Value_Offset;

	private static bool SetRuntimeVirtualTextureParameterValueByInfo_IsValid;

	private static IntPtr SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress;

	private static int SetRuntimeVirtualTextureParameterValueByInfo_ParamsSize;

	private static bool SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_Offset;

	private static bool SetRuntimeVirtualTextureParameterValueByInfo_Value_IsValid;

	private static FFieldAddress SetRuntimeVirtualTextureParameterValueByInfo_Value_PropertyAddress;

	private static int SetRuntimeVirtualTextureParameterValueByInfo_Value_Offset;

	private static bool SetRuntimeVirtualTextureParameterValue_IsValid;

	private static IntPtr SetRuntimeVirtualTextureParameterValue_FunctionAddress;

	private static int SetRuntimeVirtualTextureParameterValue_ParamsSize;

	private static bool SetRuntimeVirtualTextureParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetRuntimeVirtualTextureParameterValue_ParameterName_PropertyAddress;

	private static int SetRuntimeVirtualTextureParameterValue_ParameterName_Offset;

	private static bool SetRuntimeVirtualTextureParameterValue_Value_IsValid;

	private static FFieldAddress SetRuntimeVirtualTextureParameterValue_Value_PropertyAddress;

	private static int SetRuntimeVirtualTextureParameterValue_Value_Offset;

	private static bool SetDoubleVectorParameterValue_IsValid;

	private static IntPtr SetDoubleVectorParameterValue_FunctionAddress;

	private static int SetDoubleVectorParameterValue_ParamsSize;

	private static bool SetDoubleVectorParameterValue_ParameterName_IsValid;

	private static FFieldAddress SetDoubleVectorParameterValue_ParameterName_PropertyAddress;

	private static int SetDoubleVectorParameterValue_ParameterName_Offset;

	private static bool SetDoubleVectorParameterValue_Value_IsValid;

	private static FFieldAddress SetDoubleVectorParameterValue_Value_PropertyAddress;

	private static int SetDoubleVectorParameterValue_Value_Offset;

	private static bool InterpolateMaterialInstanceParameters_IsValid;

	private static IntPtr InterpolateMaterialInstanceParameters_FunctionAddress;

	private static int InterpolateMaterialInstanceParameters_ParamsSize;

	private static bool InterpolateMaterialInstanceParameters_SourceA_IsValid;

	private static FFieldAddress InterpolateMaterialInstanceParameters_SourceA_PropertyAddress;

	private static int InterpolateMaterialInstanceParameters_SourceA_Offset;

	private static bool InterpolateMaterialInstanceParameters_SourceB_IsValid;

	private static FFieldAddress InterpolateMaterialInstanceParameters_SourceB_PropertyAddress;

	private static int InterpolateMaterialInstanceParameters_SourceB_Offset;

	private static bool InterpolateMaterialInstanceParameters_Alpha_IsValid;

	private static FFieldAddress InterpolateMaterialInstanceParameters_Alpha_PropertyAddress;

	private static int InterpolateMaterialInstanceParameters_Alpha_Offset;

	private static bool GetVectorParameterValueByInfo_IsValid;

	private static IntPtr GetVectorParameterValueByInfo_FunctionAddress;

	private static int GetVectorParameterValueByInfo_ParamsSize;

	private static bool GetVectorParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress GetVectorParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int GetVectorParameterValueByInfo_ParameterInfo_Offset;

	private static bool GetVectorParameterValueByInfo_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameterValueByInfo_ReturnValue_PropertyAddress;

	private static int GetVectorParameterValueByInfo_ReturnValue_Offset;

	private static bool GetVectorParameterValue_IsValid;

	private static IntPtr GetVectorParameterValue_FunctionAddress;

	private static int GetVectorParameterValue_ParamsSize;

	private static bool GetVectorParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetVectorParameterValue_ParameterName_PropertyAddress;

	private static int GetVectorParameterValue_ParameterName_Offset;

	private static bool GetVectorParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetVectorParameterValue_ReturnValue_PropertyAddress;

	private static int GetVectorParameterValue_ReturnValue_Offset;

	private static bool GetTextureParameterValueByInfo_IsValid;

	private static IntPtr GetTextureParameterValueByInfo_FunctionAddress;

	private static int GetTextureParameterValueByInfo_ParamsSize;

	private static bool GetTextureParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress GetTextureParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int GetTextureParameterValueByInfo_ParameterInfo_Offset;

	private static bool GetTextureParameterValueByInfo_ReturnValue_IsValid;

	private static FFieldAddress GetTextureParameterValueByInfo_ReturnValue_PropertyAddress;

	private static int GetTextureParameterValueByInfo_ReturnValue_Offset;

	private static bool GetTextureParameterValue_IsValid;

	private static IntPtr GetTextureParameterValue_FunctionAddress;

	private static int GetTextureParameterValue_ParamsSize;

	private static bool GetTextureParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetTextureParameterValue_ParameterName_PropertyAddress;

	private static int GetTextureParameterValue_ParameterName_Offset;

	private static bool GetTextureParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetTextureParameterValue_ReturnValue_PropertyAddress;

	private static int GetTextureParameterValue_ReturnValue_Offset;

	private static bool GetScalarParameterValueByInfo_IsValid;

	private static IntPtr GetScalarParameterValueByInfo_FunctionAddress;

	private static int GetScalarParameterValueByInfo_ParamsSize;

	private static bool GetScalarParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int GetScalarParameterValueByInfo_ParameterInfo_Offset;

	private static bool GetScalarParameterValueByInfo_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterValueByInfo_ReturnValue_PropertyAddress;

	private static int GetScalarParameterValueByInfo_ReturnValue_Offset;

	private static bool GetScalarParameterValue_IsValid;

	private static IntPtr GetScalarParameterValue_FunctionAddress;

	private static int GetScalarParameterValue_ParamsSize;

	private static bool GetScalarParameterValue_ParameterName_IsValid;

	private static FFieldAddress GetScalarParameterValue_ParameterName_PropertyAddress;

	private static int GetScalarParameterValue_ParameterName_Offset;

	private static bool GetScalarParameterValue_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterValue_ReturnValue_PropertyAddress;

	private static int GetScalarParameterValue_ReturnValue_Offset;

	private static bool CopyMaterialInstanceParameters_IsValid;

	private static IntPtr CopyMaterialInstanceParameters_FunctionAddress;

	private static int CopyMaterialInstanceParameters_ParamsSize;

	private static bool CopyMaterialInstanceParameters_Source_IsValid;

	private static FFieldAddress CopyMaterialInstanceParameters_Source_PropertyAddress;

	private static int CopyMaterialInstanceParameters_Source_Offset;

	private static bool CopyMaterialInstanceParameters_bQuickParametersOnly_IsValid;

	private static FFieldAddress CopyMaterialInstanceParameters_bQuickParametersOnly_PropertyAddress;

	private static int CopyMaterialInstanceParameters_bQuickParametersOnly_Offset;

	private static bool CopyParameterOverrides_IsValid;

	private static IntPtr CopyParameterOverrides_FunctionAddress;

	private static int CopyParameterOverrides_ParamsSize;

	private static bool CopyParameterOverrides_MaterialInstance_IsValid;

	private static FFieldAddress CopyParameterOverrides_MaterialInstance_PropertyAddress;

	private static int CopyParameterOverrides_MaterialInstance_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetVectorParameterValueByInfo")]
	public unsafe void SetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo, FLinearColor Value)
	{
		CheckDestroyed();
		if (!SetVectorParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetVectorParameterValueByInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetVectorParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, SetVectorParameterValueByInfo_ParameterInfo_Offset), 0, SetVectorParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValueByInfo_Value_Offset), 0, SetVectorParameterValueByInfo_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorParameterValueByInfo_FunctionAddress, intPtr, SetVectorParameterValueByInfo_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetVectorParameterValue")]
	public unsafe void SetVectorParameterValue(FName ParameterName, FLinearColor Value)
	{
		CheckDestroyed();
		if (!SetVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetVectorParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVectorParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVectorParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValue_ParameterName_Offset), 0, SetVectorParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetVectorParameterValue_Value_Offset), 0, SetVectorParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVectorParameterValue_FunctionAddress, intPtr, SetVectorParameterValue_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetTextureParameterValueByInfo")]
	public unsafe void SetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo, UTexture Value)
	{
		CheckDestroyed();
		if (!SetTextureParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetTextureParameterValueByInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetTextureParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueByInfo_ParameterInfo_Offset), 0, SetTextureParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueByInfo_Value_Offset), 0, SetTextureParameterValueByInfo_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextureParameterValueByInfo_FunctionAddress, intPtr, SetTextureParameterValueByInfo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetTextureParameterValue")]
	public unsafe void SetTextureParameterValue(FName ParameterName, UTexture Value)
	{
		CheckDestroyed();
		if (!SetTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetTextureParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValue_ParameterName_Offset), 0, SetTextureParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValue_Value_Offset), 0, SetTextureParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextureParameterValue_FunctionAddress, intPtr, SetTextureParameterValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetSparseVolumeTextureParameterValue")]
	public unsafe void SetSparseVolumeTextureParameterValue(FName ParameterName, USparseVolumeTexture Value)
	{
		CheckDestroyed();
		if (!SetSparseVolumeTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetSparseVolumeTextureParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSparseVolumeTextureParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSparseVolumeTextureParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetSparseVolumeTextureParameterValue_ParameterName_Offset), 0, SetSparseVolumeTextureParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<USparseVolumeTexture>.ToNative(IntPtr.Add(intPtr, SetSparseVolumeTextureParameterValue_Value_Offset), 0, SetSparseVolumeTextureParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSparseVolumeTextureParameterValue_FunctionAddress, intPtr, SetSparseVolumeTextureParameterValue_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetScalarParameterValueByInfo")]
	public unsafe void SetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo, float Value)
	{
		CheckDestroyed();
		if (!SetScalarParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetScalarParameterValueByInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalarParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalarParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetScalarParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, SetScalarParameterValueByInfo_ParameterInfo_Offset), 0, SetScalarParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValueByInfo_Value_Offset), 0, SetScalarParameterValueByInfo_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScalarParameterValueByInfo_FunctionAddress, intPtr, SetScalarParameterValueByInfo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetScalarParameterValue")]
	public unsafe void SetScalarParameterValue(FName ParameterName, float Value)
	{
		CheckDestroyed();
		if (!SetScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetScalarParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScalarParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScalarParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValue_ParameterName_Offset), 0, SetScalarParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScalarParameterValue_Value_Offset), 0, SetScalarParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScalarParameterValue_FunctionAddress, intPtr, SetScalarParameterValue_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetRuntimeVirtualTextureParameterValueByInfo")]
	public unsafe void SetRuntimeVirtualTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo, URuntimeVirtualTexture Value)
	{
		CheckDestroyed();
		if (!SetRuntimeVirtualTextureParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetRuntimeVirtualTextureParameterValueByInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRuntimeVirtualTextureParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRuntimeVirtualTextureParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_Offset), 0, SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		UObjectMarshaler<URuntimeVirtualTexture>.ToNative(IntPtr.Add(intPtr, SetRuntimeVirtualTextureParameterValueByInfo_Value_Offset), 0, SetRuntimeVirtualTextureParameterValueByInfo_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress, intPtr, SetRuntimeVirtualTextureParameterValueByInfo_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetRuntimeVirtualTextureParameterValue")]
	public unsafe void SetRuntimeVirtualTextureParameterValue(FName ParameterName, URuntimeVirtualTexture Value)
	{
		CheckDestroyed();
		if (!SetRuntimeVirtualTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetRuntimeVirtualTextureParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRuntimeVirtualTextureParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRuntimeVirtualTextureParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetRuntimeVirtualTextureParameterValue_ParameterName_Offset), 0, SetRuntimeVirtualTextureParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<URuntimeVirtualTexture>.ToNative(IntPtr.Add(intPtr, SetRuntimeVirtualTextureParameterValue_Value_Offset), 0, SetRuntimeVirtualTextureParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRuntimeVirtualTextureParameterValue_FunctionAddress, intPtr, SetRuntimeVirtualTextureParameterValue_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:SetDoubleVectorParameterValue")]
	public unsafe void SetDoubleVectorParameterValue(FName ParameterName, FVector Value)
	{
		CheckDestroyed();
		if (!SetDoubleVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:SetDoubleVectorParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDoubleVectorParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDoubleVectorParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetDoubleVectorParameterValue_ParameterName_Offset), 0, SetDoubleVectorParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetDoubleVectorParameterValue_Value_Offset), 0, SetDoubleVectorParameterValue_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDoubleVectorParameterValue_FunctionAddress, intPtr, SetDoubleVectorParameterValue_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_InterpolateMaterialInstanceParams")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_InterpolateMaterialInstanceParams")]
	public unsafe void InterpolateMaterialInstanceParameters(UMaterialInstance SourceA, UMaterialInstance SourceB, float Alpha)
	{
		CheckDestroyed();
		if (!InterpolateMaterialInstanceParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_InterpolateMaterialInstanceParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InterpolateMaterialInstanceParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InterpolateMaterialInstanceParameters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(intPtr, InterpolateMaterialInstanceParameters_SourceA_Offset), 0, InterpolateMaterialInstanceParameters_SourceA_PropertyAddress.Address, SourceA);
		UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(intPtr, InterpolateMaterialInstanceParameters_SourceB_Offset), 0, InterpolateMaterialInstanceParameters_SourceB_PropertyAddress.Address, SourceB);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InterpolateMaterialInstanceParameters_Alpha_Offset), 0, InterpolateMaterialInstanceParameters_Alpha_PropertyAddress.Address, Alpha);
		NativeReflection.InvokeFunctionOptimized(base.Address, InterpolateMaterialInstanceParameters_FunctionAddress, intPtr, InterpolateMaterialInstanceParameters_ParamsSize);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_GetVectorParameterValueByInfo")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_GetVectorParameterValueByInfo")]
	public unsafe FLinearColor GetVectorParameterValueByInfo(FMaterialParameterInfo ParameterInfo)
	{
		CheckDestroyed();
		if (!GetVectorParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_GetVectorParameterValueByInfo");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVectorParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, GetVectorParameterValueByInfo_ParameterInfo_Offset), 0, GetVectorParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorParameterValueByInfo_FunctionAddress, intPtr, GetVectorParameterValueByInfo_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetVectorParameterValueByInfo_ReturnValue_Offset), 0, GetVectorParameterValueByInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_GetVectorParameterValue")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_GetVectorParameterValue")]
	public unsafe FLinearColor GetVectorParameterValue(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetVectorParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_GetVectorParameterValue");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetVectorParameterValue_ParameterName_Offset), 0, GetVectorParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorParameterValue_FunctionAddress, intPtr, GetVectorParameterValue_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetVectorParameterValue_ReturnValue_Offset), 0, GetVectorParameterValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u, OriginalName = "K2_GetTextureParameterValueByInfo")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_GetTextureParameterValueByInfo")]
	public unsafe UTexture GetTextureParameterValueByInfo(FMaterialParameterInfo ParameterInfo)
	{
		CheckDestroyed();
		if (!GetTextureParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_GetTextureParameterValueByInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTextureParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, GetTextureParameterValueByInfo_ParameterInfo_Offset), 0, GetTextureParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureParameterValueByInfo_FunctionAddress, intPtr, GetTextureParameterValueByInfo_ParamsSize);
		return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(intPtr, GetTextureParameterValueByInfo_ReturnValue_Offset), 0, GetTextureParameterValueByInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_GetTextureParameterValue")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_GetTextureParameterValue")]
	public unsafe UTexture GetTextureParameterValue(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetTextureParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_GetTextureParameterValue");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextureParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextureParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTextureParameterValue_ParameterName_Offset), 0, GetTextureParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextureParameterValue_FunctionAddress, intPtr, GetTextureParameterValue_ParamsSize);
		return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(intPtr, GetTextureParameterValue_ReturnValue_Offset), 0, GetTextureParameterValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u, OriginalName = "K2_GetScalarParameterValueByInfo")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_GetScalarParameterValueByInfo")]
	public unsafe float GetScalarParameterValueByInfo(FMaterialParameterInfo ParameterInfo)
	{
		CheckDestroyed();
		if (!GetScalarParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_GetScalarParameterValueByInfo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, GetScalarParameterValueByInfo_ParameterInfo_Offset), 0, GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScalarParameterValueByInfo_FunctionAddress, intPtr, GetScalarParameterValueByInfo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScalarParameterValueByInfo_ReturnValue_Offset), 0, GetScalarParameterValueByInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_GetScalarParameterValue")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_GetScalarParameterValue")]
	public unsafe float GetScalarParameterValue(FName ParameterName)
	{
		CheckDestroyed();
		if (!GetScalarParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_GetScalarParameterValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetScalarParameterValue_ParameterName_Offset), 0, GetScalarParameterValue_ParameterName_PropertyAddress.Address, ParameterName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetScalarParameterValue_FunctionAddress, intPtr, GetScalarParameterValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScalarParameterValue_ReturnValue_Offset), 0, GetScalarParameterValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_CopyMaterialInstanceParameters")]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:K2_CopyMaterialInstanceParameters")]
	public unsafe void CopyMaterialInstanceParameters(UMaterialInterface Source, bool bQuickParametersOnly = false)
	{
		CheckDestroyed();
		if (!CopyMaterialInstanceParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:K2_CopyMaterialInstanceParameters");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyMaterialInstanceParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyMaterialInstanceParameters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, CopyMaterialInstanceParameters_Source_Offset), 0, CopyMaterialInstanceParameters_Source_PropertyAddress.Address, Source);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CopyMaterialInstanceParameters_bQuickParametersOnly_Offset), 0, CopyMaterialInstanceParameters_bQuickParametersOnly_PropertyAddress.Address, bQuickParametersOnly);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyMaterialInstanceParameters_FunctionAddress, intPtr, CopyMaterialInstanceParameters_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.MaterialInstanceDynamic:CopyParameterOverrides")]
	public unsafe void CopyParameterOverrides(UMaterialInstance MaterialInstance)
	{
		CheckDestroyed();
		if (!CopyParameterOverrides_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MaterialInstanceDynamic:CopyParameterOverrides");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyParameterOverrides_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyParameterOverrides_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(intPtr, CopyParameterOverrides_MaterialInstance_Offset), 0, CopyParameterOverrides_MaterialInstance_PropertyAddress.Address, MaterialInstance);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyParameterOverrides_FunctionAddress, intPtr, CopyParameterOverrides_ParamsSize);
	}

	static UMaterialInstanceDynamic()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialInstanceDynamic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialInstanceDynamic));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.MaterialInstanceDynamic");
		SetVectorParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVectorParameterValueByInfo");
		SetVectorParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValueByInfo_ParameterInfo_PropertyAddress, SetVectorParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetVectorParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetVectorParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValueByInfo_Value_PropertyAddress, SetVectorParameterValueByInfo_FunctionAddress, "Value");
		SetVectorParameterValueByInfo_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValueByInfo_FunctionAddress, "Value");
		SetVectorParameterValueByInfo_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValueByInfo_FunctionAddress, "Value", Classes.FStructProperty);
		SetVectorParameterValueByInfo_IsValid = SetVectorParameterValueByInfo_FunctionAddress != IntPtr.Zero && SetVectorParameterValueByInfo_ParameterInfo_IsValid && SetVectorParameterValueByInfo_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetVectorParameterValueByInfo", SetVectorParameterValueByInfo_IsValid);
		SetVectorParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVectorParameterValue");
		SetVectorParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVectorParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValue_ParameterName_PropertyAddress, SetVectorParameterValue_FunctionAddress, "ParameterName");
		SetVectorParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValue_FunctionAddress, "ParameterName");
		SetVectorParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVectorParameterValue_Value_PropertyAddress, SetVectorParameterValue_FunctionAddress, "Value");
		SetVectorParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVectorParameterValue_FunctionAddress, "Value");
		SetVectorParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVectorParameterValue_FunctionAddress, "Value", Classes.FStructProperty);
		SetVectorParameterValue_IsValid = SetVectorParameterValue_FunctionAddress != IntPtr.Zero && SetVectorParameterValue_ParameterName_IsValid && SetVectorParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetVectorParameterValue", SetVectorParameterValue_IsValid);
		SetTextureParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTextureParameterValueByInfo");
		SetTextureParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueByInfo_ParameterInfo_PropertyAddress, SetTextureParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetTextureParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetTextureParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueByInfo_Value_PropertyAddress, SetTextureParameterValueByInfo_FunctionAddress, "Value");
		SetTextureParameterValueByInfo_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueByInfo_FunctionAddress, "Value");
		SetTextureParameterValueByInfo_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueByInfo_FunctionAddress, "Value", Classes.FObjectProperty);
		SetTextureParameterValueByInfo_IsValid = SetTextureParameterValueByInfo_FunctionAddress != IntPtr.Zero && SetTextureParameterValueByInfo_ParameterInfo_IsValid && SetTextureParameterValueByInfo_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetTextureParameterValueByInfo", SetTextureParameterValueByInfo_IsValid);
		SetTextureParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTextureParameterValue");
		SetTextureParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValue_ParameterName_PropertyAddress, SetTextureParameterValue_FunctionAddress, "ParameterName");
		SetTextureParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValue_FunctionAddress, "ParameterName");
		SetTextureParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValue_Value_PropertyAddress, SetTextureParameterValue_FunctionAddress, "Value");
		SetTextureParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValue_FunctionAddress, "Value");
		SetTextureParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValue_FunctionAddress, "Value", Classes.FObjectProperty);
		SetTextureParameterValue_IsValid = SetTextureParameterValue_FunctionAddress != IntPtr.Zero && SetTextureParameterValue_ParameterName_IsValid && SetTextureParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetTextureParameterValue", SetTextureParameterValue_IsValid);
		SetSparseVolumeTextureParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSparseVolumeTextureParameterValue");
		SetSparseVolumeTextureParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSparseVolumeTextureParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSparseVolumeTextureParameterValue_ParameterName_PropertyAddress, SetSparseVolumeTextureParameterValue_FunctionAddress, "ParameterName");
		SetSparseVolumeTextureParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetSparseVolumeTextureParameterValue_FunctionAddress, "ParameterName");
		SetSparseVolumeTextureParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSparseVolumeTextureParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSparseVolumeTextureParameterValue_Value_PropertyAddress, SetSparseVolumeTextureParameterValue_FunctionAddress, "Value");
		SetSparseVolumeTextureParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetSparseVolumeTextureParameterValue_FunctionAddress, "Value");
		SetSparseVolumeTextureParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSparseVolumeTextureParameterValue_FunctionAddress, "Value", Classes.FObjectProperty);
		SetSparseVolumeTextureParameterValue_IsValid = SetSparseVolumeTextureParameterValue_FunctionAddress != IntPtr.Zero && SetSparseVolumeTextureParameterValue_ParameterName_IsValid && SetSparseVolumeTextureParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetSparseVolumeTextureParameterValue", SetSparseVolumeTextureParameterValue_IsValid);
		SetScalarParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetScalarParameterValueByInfo");
		SetScalarParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalarParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValueByInfo_ParameterInfo_PropertyAddress, SetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetScalarParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetScalarParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValueByInfo_Value_PropertyAddress, SetScalarParameterValueByInfo_FunctionAddress, "Value");
		SetScalarParameterValueByInfo_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValueByInfo_FunctionAddress, "Value");
		SetScalarParameterValueByInfo_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValueByInfo_FunctionAddress, "Value", Classes.FFloatProperty);
		SetScalarParameterValueByInfo_IsValid = SetScalarParameterValueByInfo_FunctionAddress != IntPtr.Zero && SetScalarParameterValueByInfo_ParameterInfo_IsValid && SetScalarParameterValueByInfo_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetScalarParameterValueByInfo", SetScalarParameterValueByInfo_IsValid);
		SetScalarParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetScalarParameterValue");
		SetScalarParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScalarParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValue_ParameterName_PropertyAddress, SetScalarParameterValue_FunctionAddress, "ParameterName");
		SetScalarParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValue_FunctionAddress, "ParameterName");
		SetScalarParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetScalarParameterValue_Value_PropertyAddress, SetScalarParameterValue_FunctionAddress, "Value");
		SetScalarParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetScalarParameterValue_FunctionAddress, "Value");
		SetScalarParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScalarParameterValue_FunctionAddress, "Value", Classes.FFloatProperty);
		SetScalarParameterValue_IsValid = SetScalarParameterValue_FunctionAddress != IntPtr.Zero && SetScalarParameterValue_ParameterName_IsValid && SetScalarParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetScalarParameterValue", SetScalarParameterValue_IsValid);
		SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRuntimeVirtualTextureParameterValueByInfo");
		SetRuntimeVirtualTextureParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_PropertyAddress, SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress, "ParameterInfo");
		SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRuntimeVirtualTextureParameterValueByInfo_Value_PropertyAddress, SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress, "Value");
		SetRuntimeVirtualTextureParameterValueByInfo_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress, "Value");
		SetRuntimeVirtualTextureParameterValueByInfo_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress, "Value", Classes.FObjectProperty);
		SetRuntimeVirtualTextureParameterValueByInfo_IsValid = SetRuntimeVirtualTextureParameterValueByInfo_FunctionAddress != IntPtr.Zero && SetRuntimeVirtualTextureParameterValueByInfo_ParameterInfo_IsValid && SetRuntimeVirtualTextureParameterValueByInfo_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetRuntimeVirtualTextureParameterValueByInfo", SetRuntimeVirtualTextureParameterValueByInfo_IsValid);
		SetRuntimeVirtualTextureParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRuntimeVirtualTextureParameterValue");
		SetRuntimeVirtualTextureParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRuntimeVirtualTextureParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRuntimeVirtualTextureParameterValue_ParameterName_PropertyAddress, SetRuntimeVirtualTextureParameterValue_FunctionAddress, "ParameterName");
		SetRuntimeVirtualTextureParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetRuntimeVirtualTextureParameterValue_FunctionAddress, "ParameterName");
		SetRuntimeVirtualTextureParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRuntimeVirtualTextureParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRuntimeVirtualTextureParameterValue_Value_PropertyAddress, SetRuntimeVirtualTextureParameterValue_FunctionAddress, "Value");
		SetRuntimeVirtualTextureParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetRuntimeVirtualTextureParameterValue_FunctionAddress, "Value");
		SetRuntimeVirtualTextureParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRuntimeVirtualTextureParameterValue_FunctionAddress, "Value", Classes.FObjectProperty);
		SetRuntimeVirtualTextureParameterValue_IsValid = SetRuntimeVirtualTextureParameterValue_FunctionAddress != IntPtr.Zero && SetRuntimeVirtualTextureParameterValue_ParameterName_IsValid && SetRuntimeVirtualTextureParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetRuntimeVirtualTextureParameterValue", SetRuntimeVirtualTextureParameterValue_IsValid);
		SetDoubleVectorParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDoubleVectorParameterValue");
		SetDoubleVectorParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDoubleVectorParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleVectorParameterValue_ParameterName_PropertyAddress, SetDoubleVectorParameterValue_FunctionAddress, "ParameterName");
		SetDoubleVectorParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleVectorParameterValue_FunctionAddress, "ParameterName");
		SetDoubleVectorParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleVectorParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDoubleVectorParameterValue_Value_PropertyAddress, SetDoubleVectorParameterValue_FunctionAddress, "Value");
		SetDoubleVectorParameterValue_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetDoubleVectorParameterValue_FunctionAddress, "Value");
		SetDoubleVectorParameterValue_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDoubleVectorParameterValue_FunctionAddress, "Value", Classes.FStructProperty);
		SetDoubleVectorParameterValue_IsValid = SetDoubleVectorParameterValue_FunctionAddress != IntPtr.Zero && SetDoubleVectorParameterValue_ParameterName_IsValid && SetDoubleVectorParameterValue_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:SetDoubleVectorParameterValue", SetDoubleVectorParameterValue_IsValid);
		InterpolateMaterialInstanceParameters_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_InterpolateMaterialInstanceParams");
		InterpolateMaterialInstanceParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(InterpolateMaterialInstanceParameters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InterpolateMaterialInstanceParameters_SourceA_PropertyAddress, InterpolateMaterialInstanceParameters_FunctionAddress, "SourceA");
		InterpolateMaterialInstanceParameters_SourceA_Offset = NativeReflectionCached.GetPropertyOffset(InterpolateMaterialInstanceParameters_FunctionAddress, "SourceA");
		InterpolateMaterialInstanceParameters_SourceA_IsValid = NativeReflectionCached.ValidatePropertyClass(InterpolateMaterialInstanceParameters_FunctionAddress, "SourceA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpolateMaterialInstanceParameters_SourceB_PropertyAddress, InterpolateMaterialInstanceParameters_FunctionAddress, "SourceB");
		InterpolateMaterialInstanceParameters_SourceB_Offset = NativeReflectionCached.GetPropertyOffset(InterpolateMaterialInstanceParameters_FunctionAddress, "SourceB");
		InterpolateMaterialInstanceParameters_SourceB_IsValid = NativeReflectionCached.ValidatePropertyClass(InterpolateMaterialInstanceParameters_FunctionAddress, "SourceB", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpolateMaterialInstanceParameters_Alpha_PropertyAddress, InterpolateMaterialInstanceParameters_FunctionAddress, "Alpha");
		InterpolateMaterialInstanceParameters_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(InterpolateMaterialInstanceParameters_FunctionAddress, "Alpha");
		InterpolateMaterialInstanceParameters_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(InterpolateMaterialInstanceParameters_FunctionAddress, "Alpha", Classes.FFloatProperty);
		InterpolateMaterialInstanceParameters_IsValid = InterpolateMaterialInstanceParameters_FunctionAddress != IntPtr.Zero && InterpolateMaterialInstanceParameters_SourceA_IsValid && InterpolateMaterialInstanceParameters_SourceB_IsValid && InterpolateMaterialInstanceParameters_Alpha_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_InterpolateMaterialInstanceParams", InterpolateMaterialInstanceParameters_IsValid);
		GetVectorParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetVectorParameterValueByInfo");
		GetVectorParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValueByInfo_ParameterInfo_PropertyAddress, GetVectorParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetVectorParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetVectorParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValueByInfo_ReturnValue_PropertyAddress, GetVectorParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetVectorParameterValueByInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetVectorParameterValueByInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValueByInfo_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorParameterValueByInfo_IsValid = GetVectorParameterValueByInfo_FunctionAddress != IntPtr.Zero && GetVectorParameterValueByInfo_ParameterInfo_IsValid && GetVectorParameterValueByInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_GetVectorParameterValueByInfo", GetVectorParameterValueByInfo_IsValid);
		GetVectorParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetVectorParameterValue");
		GetVectorParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_ParameterName_PropertyAddress, GetVectorParameterValue_FunctionAddress, "ParameterName");
		GetVectorParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "ParameterName");
		GetVectorParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorParameterValue_ReturnValue_PropertyAddress, GetVectorParameterValue_FunctionAddress, "ReturnValue");
		GetVectorParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorParameterValue_FunctionAddress, "ReturnValue");
		GetVectorParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorParameterValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorParameterValue_IsValid = GetVectorParameterValue_FunctionAddress != IntPtr.Zero && GetVectorParameterValue_ParameterName_IsValid && GetVectorParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_GetVectorParameterValue", GetVectorParameterValue_IsValid);
		GetTextureParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetTextureParameterValueByInfo");
		GetTextureParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterValueByInfo_ParameterInfo_PropertyAddress, GetTextureParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetTextureParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetTextureParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterValueByInfo_ReturnValue_PropertyAddress, GetTextureParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetTextureParameterValueByInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetTextureParameterValueByInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterValueByInfo_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTextureParameterValueByInfo_IsValid = GetTextureParameterValueByInfo_FunctionAddress != IntPtr.Zero && GetTextureParameterValueByInfo_ParameterInfo_IsValid && GetTextureParameterValueByInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_GetTextureParameterValueByInfo", GetTextureParameterValueByInfo_IsValid);
		GetTextureParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetTextureParameterValue");
		GetTextureParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextureParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterValue_ParameterName_PropertyAddress, GetTextureParameterValue_FunctionAddress, "ParameterName");
		GetTextureParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterValue_FunctionAddress, "ParameterName");
		GetTextureParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTextureParameterValue_ReturnValue_PropertyAddress, GetTextureParameterValue_FunctionAddress, "ReturnValue");
		GetTextureParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextureParameterValue_FunctionAddress, "ReturnValue");
		GetTextureParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextureParameterValue_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTextureParameterValue_IsValid = GetTextureParameterValue_FunctionAddress != IntPtr.Zero && GetTextureParameterValue_ParameterName_IsValid && GetTextureParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_GetTextureParameterValue", GetTextureParameterValue_IsValid);
		GetScalarParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetScalarParameterValueByInfo");
		GetScalarParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress, GetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetScalarParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetScalarParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValueByInfo_ReturnValue_PropertyAddress, GetScalarParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetScalarParameterValueByInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetScalarParameterValueByInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValueByInfo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScalarParameterValueByInfo_IsValid = GetScalarParameterValueByInfo_FunctionAddress != IntPtr.Zero && GetScalarParameterValueByInfo_ParameterInfo_IsValid && GetScalarParameterValueByInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_GetScalarParameterValueByInfo", GetScalarParameterValueByInfo_IsValid);
		GetScalarParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetScalarParameterValue");
		GetScalarParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_ParameterName_PropertyAddress, GetScalarParameterValue_FunctionAddress, "ParameterName");
		GetScalarParameterValue_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "ParameterName");
		GetScalarParameterValue_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValue_ReturnValue_PropertyAddress, GetScalarParameterValue_FunctionAddress, "ReturnValue");
		GetScalarParameterValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValue_FunctionAddress, "ReturnValue");
		GetScalarParameterValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScalarParameterValue_IsValid = GetScalarParameterValue_FunctionAddress != IntPtr.Zero && GetScalarParameterValue_ParameterName_IsValid && GetScalarParameterValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_GetScalarParameterValue", GetScalarParameterValue_IsValid);
		CopyMaterialInstanceParameters_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_CopyMaterialInstanceParameters");
		CopyMaterialInstanceParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyMaterialInstanceParameters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyMaterialInstanceParameters_Source_PropertyAddress, CopyMaterialInstanceParameters_FunctionAddress, "Source");
		CopyMaterialInstanceParameters_Source_Offset = NativeReflectionCached.GetPropertyOffset(CopyMaterialInstanceParameters_FunctionAddress, "Source");
		CopyMaterialInstanceParameters_Source_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMaterialInstanceParameters_FunctionAddress, "Source", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyMaterialInstanceParameters_bQuickParametersOnly_PropertyAddress, CopyMaterialInstanceParameters_FunctionAddress, "bQuickParametersOnly");
		CopyMaterialInstanceParameters_bQuickParametersOnly_Offset = NativeReflectionCached.GetPropertyOffset(CopyMaterialInstanceParameters_FunctionAddress, "bQuickParametersOnly");
		CopyMaterialInstanceParameters_bQuickParametersOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyMaterialInstanceParameters_FunctionAddress, "bQuickParametersOnly", Classes.FBoolProperty);
		CopyMaterialInstanceParameters_IsValid = CopyMaterialInstanceParameters_FunctionAddress != IntPtr.Zero && CopyMaterialInstanceParameters_Source_IsValid && CopyMaterialInstanceParameters_bQuickParametersOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:K2_CopyMaterialInstanceParameters", CopyMaterialInstanceParameters_IsValid);
		CopyParameterOverrides_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyParameterOverrides");
		CopyParameterOverrides_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyParameterOverrides_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyParameterOverrides_MaterialInstance_PropertyAddress, CopyParameterOverrides_FunctionAddress, "MaterialInstance");
		CopyParameterOverrides_MaterialInstance_Offset = NativeReflectionCached.GetPropertyOffset(CopyParameterOverrides_FunctionAddress, "MaterialInstance");
		CopyParameterOverrides_MaterialInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyParameterOverrides_FunctionAddress, "MaterialInstance", Classes.FObjectProperty);
		CopyParameterOverrides_IsValid = CopyParameterOverrides_FunctionAddress != IntPtr.Zero && CopyParameterOverrides_MaterialInstance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MaterialInstanceDynamic:CopyParameterOverrides", CopyParameterOverrides_IsValid);
	}
}
