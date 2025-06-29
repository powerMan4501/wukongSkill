using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorNiagaraLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetNiagaraSystemMeshRenderStaticmeshArray_IsValid;

	private static IntPtr SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress;

	private static int SetNiagaraSystemMeshRenderStaticmeshArray_ParamsSize;

	private static bool SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_Offset;

	private static bool SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_IsValid;

	private static FFieldAddress SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_PropertyAddress;

	private static int SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_Offset;

	private static bool SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_IsValid;

	private static FFieldAddress SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_PropertyAddress;

	private static int SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_Offset;

	private static bool SetNiagaraActorVectorArrayMaxElement_IsValid;

	private static IntPtr SetNiagaraActorVectorArrayMaxElement_FunctionAddress;

	private static int SetNiagaraActorVectorArrayMaxElement_ParamsSize;

	private static bool SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_Offset;

	private static bool SetNiagaraActorVectorArrayMaxElement_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraActorVectorArrayMaxElement_OverrideName_PropertyAddress;

	private static int SetNiagaraActorVectorArrayMaxElement_OverrideName_Offset;

	private static bool SetNiagaraActorVectorArrayMaxElement_Number_IsValid;

	private static FFieldAddress SetNiagaraActorVectorArrayMaxElement_Number_PropertyAddress;

	private static int SetNiagaraActorVectorArrayMaxElement_Number_Offset;

	private static bool SetNiagaraActorArrayParameterMaxElement_IsValid;

	private static IntPtr SetNiagaraActorArrayParameterMaxElement_FunctionAddress;

	private static int SetNiagaraActorArrayParameterMaxElement_ParamsSize;

	private static bool SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_IsValid;

	private static FFieldAddress SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_PropertyAddress;

	private static int SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_Offset;

	private static bool SetNiagaraActorArrayParameterMaxElement_OverrideName_IsValid;

	private static FFieldAddress SetNiagaraActorArrayParameterMaxElement_OverrideName_PropertyAddress;

	private static int SetNiagaraActorArrayParameterMaxElement_OverrideName_Offset;

	private static bool SetNiagaraActorArrayParameterMaxElement_Number_IsValid;

	private static FFieldAddress SetNiagaraActorArrayParameterMaxElement_Number_PropertyAddress;

	private static int SetNiagaraActorArrayParameterMaxElement_Number_Offset;

	private static bool SerializeUObjectFieldsDataToJson_IsValid;

	private static IntPtr SerializeUObjectFieldsDataToJson_FunctionAddress;

	private static int SerializeUObjectFieldsDataToJson_ParamsSize;

	private static bool SerializeUObjectFieldsDataToJson_InObject_IsValid;

	private static FFieldAddress SerializeUObjectFieldsDataToJson_InObject_PropertyAddress;

	private static int SerializeUObjectFieldsDataToJson_InObject_Offset;

	private static bool SerializeUObjectFieldsDataToJson_FilePath_IsValid;

	private static FFieldAddress SerializeUObjectFieldsDataToJson_FilePath_PropertyAddress;

	private static int SerializeUObjectFieldsDataToJson_FilePath_Offset;

	private static bool RequestSelectedNiagaraAssetForceCompile_IsValid;

	private static IntPtr RequestSelectedNiagaraAssetForceCompile_FunctionAddress;

	private static int RequestSelectedNiagaraAssetForceCompile_ParamsSize;

	private static bool NiagaraUseUniqueID_IsValid;

	private static IntPtr NiagaraUseUniqueID_FunctionAddress;

	private static int NiagaraUseUniqueID_ParamsSize;

	private static bool NiagaraUseUniqueID_NiagaraSystem_IsValid;

	private static FFieldAddress NiagaraUseUniqueID_NiagaraSystem_PropertyAddress;

	private static int NiagaraUseUniqueID_NiagaraSystem_Offset;

	private static bool NiagaraUseUniqueID_ReturnValue_IsValid;

	private static FFieldAddress NiagaraUseUniqueID_ReturnValue_PropertyAddress;

	private static int NiagaraUseUniqueID_ReturnValue_Offset;

	private static bool GetNiagaraSystemInterpolatedSpawningEmitters_IsValid;

	private static IntPtr GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress;

	private static int GetNiagaraSystemInterpolatedSpawningEmitters_ParamsSize;

	private static bool GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_Offset;

	private static bool GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_PropertyAddress;

	private static int GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_Offset;

	private static bool GetNiagaraFieldsData_IsValid;

	private static IntPtr GetNiagaraFieldsData_FunctionAddress;

	private static int GetNiagaraFieldsData_ParamsSize;

	private static bool GetNiagaraFieldsData_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraFieldsData_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraFieldsData_NiagaraSystem_Offset;

	private static bool GetNiagaraFieldsData_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraFieldsData_ReturnValue_PropertyAddress;

	private static int GetNiagaraFieldsData_ReturnValue_Offset;

	private static bool GetNiagaraEmitterSimInstructionNum_IsValid;

	private static IntPtr GetNiagaraEmitterSimInstructionNum_FunctionAddress;

	private static int GetNiagaraEmitterSimInstructionNum_ParamsSize;

	private static bool GetNiagaraEmitterSimInstructionNum_EmitterObj_IsValid;

	private static FFieldAddress GetNiagaraEmitterSimInstructionNum_EmitterObj_PropertyAddress;

	private static int GetNiagaraEmitterSimInstructionNum_EmitterObj_Offset;

	private static bool GetNiagaraEmitterSimInstructionNum_ShaderPlatform_IsValid;

	private static FFieldAddress GetNiagaraEmitterSimInstructionNum_ShaderPlatform_PropertyAddress;

	private static int GetNiagaraEmitterSimInstructionNum_ShaderPlatform_Offset;

	private static bool GetNiagaraEmitterSimInstructionNum_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraEmitterSimInstructionNum_ReturnValue_PropertyAddress;

	private static int GetNiagaraEmitterSimInstructionNum_ReturnValue_Offset;

	private static bool GetNiagaraEmitterCount_IsValid;

	private static IntPtr GetNiagaraEmitterCount_FunctionAddress;

	private static int GetNiagaraEmitterCount_ParamsSize;

	private static bool GetNiagaraEmitterCount_NiagaraSystem_IsValid;

	private static FFieldAddress GetNiagaraEmitterCount_NiagaraSystem_PropertyAddress;

	private static int GetNiagaraEmitterCount_NiagaraSystem_Offset;

	private static bool GetNiagaraEmitterCount_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraEmitterCount_ReturnValue_PropertyAddress;

	private static int GetNiagaraEmitterCount_ReturnValue_Offset;

	private static bool ForceRequestNiagaraSystemCompile_IsValid;

	private static IntPtr ForceRequestNiagaraSystemCompile_FunctionAddress;

	private static int ForceRequestNiagaraSystemCompile_ParamsSize;

	private static bool ForceRequestNiagaraSystemCompile_NiagaraSystem_IsValid;

	private static FFieldAddress ForceRequestNiagaraSystemCompile_NiagaraSystem_PropertyAddress;

	private static int ForceRequestNiagaraSystemCompile_NiagaraSystem_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraSystemMeshRenderStaticmeshArray")]
	public unsafe static void SetNiagaraSystemMeshRenderStaticmeshArray(UNiagaraSystem NiagaraSystem, string EmitterName, List<UStaticMesh> StaticmeshArray)
	{
		if (!SetNiagaraSystemMeshRenderStaticmeshArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraSystemMeshRenderStaticmeshArray");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraSystemMeshRenderStaticmeshArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraSystemMeshRenderStaticmeshArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_Offset), 0, SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_Offset), 0, SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_PropertyAddress.Address, EmitterName);
		new TArrayCopyMarshaler<UStaticMesh>(1, SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_PropertyAddress, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.FromNative, CachedMarshalingDelegates<UStaticMesh, UObjectMarshaler<UStaticMesh>>.ToNative).ToNative(IntPtr.Add(intPtr, SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_Offset), StaticmeshArray);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, intPtr, SetNiagaraSystemMeshRenderStaticmeshArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraActorVectorArrayMaxElement")]
	public unsafe static void SetNiagaraActorVectorArrayMaxElement(UNiagaraComponent NiagaraSystem, FName OverrideName, int Number)
	{
		if (!SetNiagaraActorVectorArrayMaxElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraActorVectorArrayMaxElement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraActorVectorArrayMaxElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraActorVectorArrayMaxElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_Offset), 0, SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraActorVectorArrayMaxElement_OverrideName_Offset), 0, SetNiagaraActorVectorArrayMaxElement_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraActorVectorArrayMaxElement_Number_Offset), 0, SetNiagaraActorVectorArrayMaxElement_Number_PropertyAddress.Address, Number);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraActorVectorArrayMaxElement_FunctionAddress, intPtr, SetNiagaraActorVectorArrayMaxElement_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraActorArrayParameterMaxElement")]
	public unsafe static void SetNiagaraActorArrayParameterMaxElement(UNiagaraComponent NiagaraSystem, FName OverrideName, int Number)
	{
		if (!SetNiagaraActorArrayParameterMaxElement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraActorArrayParameterMaxElement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraActorArrayParameterMaxElement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraActorArrayParameterMaxElement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_Offset), 0, SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNiagaraActorArrayParameterMaxElement_OverrideName_Offset), 0, SetNiagaraActorArrayParameterMaxElement_OverrideName_PropertyAddress.Address, OverrideName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNiagaraActorArrayParameterMaxElement_Number_Offset), 0, SetNiagaraActorArrayParameterMaxElement_Number_PropertyAddress.Address, Number);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraActorArrayParameterMaxElement_FunctionAddress, intPtr, SetNiagaraActorArrayParameterMaxElement_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SerializeUObjectFieldsDataToJson")]
	public unsafe static void SerializeUObjectFieldsDataToJson(UObject InObject, string FilePath)
	{
		if (!SerializeUObjectFieldsDataToJson_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SerializeUObjectFieldsDataToJson");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SerializeUObjectFieldsDataToJson_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SerializeUObjectFieldsDataToJson_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SerializeUObjectFieldsDataToJson_InObject_Offset), 0, SerializeUObjectFieldsDataToJson_InObject_PropertyAddress.Address, InObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SerializeUObjectFieldsDataToJson_FilePath_Offset), 0, SerializeUObjectFieldsDataToJson_FilePath_PropertyAddress.Address, FilePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SerializeUObjectFieldsDataToJson_FunctionAddress, intPtr, SerializeUObjectFieldsDataToJson_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SerializeUObjectFieldsDataToJson_FilePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:RequestSelectedNiagaraAssetForceCompile")]
	public unsafe static void RequestSelectedNiagaraAssetForceCompile()
	{
		if (!RequestSelectedNiagaraAssetForceCompile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:RequestSelectedNiagaraAssetForceCompile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestSelectedNiagaraAssetForceCompile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestSelectedNiagaraAssetForceCompile_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RequestSelectedNiagaraAssetForceCompile_FunctionAddress, argsSize: RequestSelectedNiagaraAssetForceCompile_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:NiagaraUseUniqueID")]
	public unsafe static bool NiagaraUseUniqueID(UNiagaraSystem NiagaraSystem)
	{
		if (!NiagaraUseUniqueID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:NiagaraUseUniqueID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NiagaraUseUniqueID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NiagaraUseUniqueID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, NiagaraUseUniqueID_NiagaraSystem_Offset), 0, NiagaraUseUniqueID_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NiagaraUseUniqueID_FunctionAddress, intPtr, NiagaraUseUniqueID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NiagaraUseUniqueID_ReturnValue_Offset), 0, NiagaraUseUniqueID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraSystemInterpolatedSpawningEmitters")]
	public unsafe static List<string> GetNiagaraSystemInterpolatedSpawningEmitters(UNiagaraSystem NiagaraSystem)
	{
		if (!GetNiagaraSystemInterpolatedSpawningEmitters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraSystemInterpolatedSpawningEmitters");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraSystemInterpolatedSpawningEmitters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraSystemInterpolatedSpawningEmitters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_Offset), 0, GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress, intPtr, GetNiagaraSystemInterpolatedSpawningEmitters_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraFieldsData")]
	public unsafe static FNiagaraSerializedDatas GetNiagaraFieldsData(UNiagaraSystem NiagaraSystem)
	{
		if (!GetNiagaraFieldsData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraFieldsData");
			return default(FNiagaraSerializedDatas);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraFieldsData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraFieldsData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, GetNiagaraFieldsData_NiagaraSystem_Offset), 0, GetNiagaraFieldsData_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraFieldsData_FunctionAddress, intPtr, GetNiagaraFieldsData_ParamsSize);
		FNiagaraSerializedDatas result = FNiagaraSerializedDatas.FromNative(IntPtr.Add(intPtr, GetNiagaraFieldsData_ReturnValue_Offset), 0, GetNiagaraFieldsData_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNiagaraFieldsData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraEmitterSimInstructionNum")]
	public unsafe static int GetNiagaraEmitterSimInstructionNum(UObject EmitterObj, int ShaderPlatform)
	{
		if (!GetNiagaraEmitterSimInstructionNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraEmitterSimInstructionNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraEmitterSimInstructionNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraEmitterSimInstructionNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetNiagaraEmitterSimInstructionNum_EmitterObj_Offset), 0, GetNiagaraEmitterSimInstructionNum_EmitterObj_PropertyAddress.Address, EmitterObj);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetNiagaraEmitterSimInstructionNum_ShaderPlatform_Offset), 0, GetNiagaraEmitterSimInstructionNum_ShaderPlatform_PropertyAddress.Address, ShaderPlatform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraEmitterSimInstructionNum_FunctionAddress, intPtr, GetNiagaraEmitterSimInstructionNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNiagaraEmitterSimInstructionNum_ReturnValue_Offset), 0, GetNiagaraEmitterSimInstructionNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraEmitterCount")]
	public unsafe static int GetNiagaraEmitterCount(UNiagaraSystem NiagaraSystem)
	{
		if (!GetNiagaraEmitterCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraEmitterCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraEmitterCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraEmitterCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, GetNiagaraEmitterCount_NiagaraSystem_Offset), 0, GetNiagaraEmitterCount_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraEmitterCount_FunctionAddress, intPtr, GetNiagaraEmitterCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNiagaraEmitterCount_ReturnValue_Offset), 0, GetNiagaraEmitterCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorNiagaraLibrary:ForceRequestNiagaraSystemCompile")]
	public unsafe static void ForceRequestNiagaraSystemCompile(UNiagaraSystem NiagaraSystem)
	{
		if (!ForceRequestNiagaraSystemCompile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorNiagaraLibrary:ForceRequestNiagaraSystemCompile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceRequestNiagaraSystemCompile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceRequestNiagaraSystemCompile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, ForceRequestNiagaraSystemCompile_NiagaraSystem_Offset), 0, ForceRequestNiagaraSystemCompile_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ForceRequestNiagaraSystemCompile_FunctionAddress, intPtr, ForceRequestNiagaraSystemCompile_ParamsSize);
	}

	static UGSEditorNiagaraLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorNiagaraLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorNiagaraLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorNiagaraLibrary");
		SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraSystemMeshRenderStaticmeshArray");
		SetNiagaraSystemMeshRenderStaticmeshArray_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_PropertyAddress, SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "NiagaraSystem");
		SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "NiagaraSystem");
		SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_PropertyAddress, SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "EmitterName");
		SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "EmitterName");
		SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "EmitterName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_PropertyAddress, SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "StaticmeshArray");
		SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "StaticmeshArray");
		SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress, "StaticmeshArray", Classes.FArrayProperty);
		SetNiagaraSystemMeshRenderStaticmeshArray_IsValid = SetNiagaraSystemMeshRenderStaticmeshArray_FunctionAddress != IntPtr.Zero && SetNiagaraSystemMeshRenderStaticmeshArray_NiagaraSystem_IsValid && SetNiagaraSystemMeshRenderStaticmeshArray_EmitterName_IsValid && SetNiagaraSystemMeshRenderStaticmeshArray_StaticmeshArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraSystemMeshRenderStaticmeshArray", SetNiagaraSystemMeshRenderStaticmeshArray_IsValid);
		SetNiagaraActorVectorArrayMaxElement_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraActorVectorArrayMaxElement");
		SetNiagaraActorVectorArrayMaxElement_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraActorVectorArrayMaxElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_PropertyAddress, SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "NiagaraSystem");
		SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "NiagaraSystem");
		SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraActorVectorArrayMaxElement_OverrideName_PropertyAddress, SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "OverrideName");
		SetNiagaraActorVectorArrayMaxElement_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "OverrideName");
		SetNiagaraActorVectorArrayMaxElement_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraActorVectorArrayMaxElement_Number_PropertyAddress, SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "Number");
		SetNiagaraActorVectorArrayMaxElement_Number_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "Number");
		SetNiagaraActorVectorArrayMaxElement_Number_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraActorVectorArrayMaxElement_FunctionAddress, "Number", Classes.FIntProperty);
		SetNiagaraActorVectorArrayMaxElement_IsValid = SetNiagaraActorVectorArrayMaxElement_FunctionAddress != IntPtr.Zero && SetNiagaraActorVectorArrayMaxElement_NiagaraSystem_IsValid && SetNiagaraActorVectorArrayMaxElement_OverrideName_IsValid && SetNiagaraActorVectorArrayMaxElement_Number_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraActorVectorArrayMaxElement", SetNiagaraActorVectorArrayMaxElement_IsValid);
		SetNiagaraActorArrayParameterMaxElement_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraActorArrayParameterMaxElement");
		SetNiagaraActorArrayParameterMaxElement_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraActorArrayParameterMaxElement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_PropertyAddress, SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "NiagaraSystem");
		SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "NiagaraSystem");
		SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraActorArrayParameterMaxElement_OverrideName_PropertyAddress, SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "OverrideName");
		SetNiagaraActorArrayParameterMaxElement_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "OverrideName");
		SetNiagaraActorArrayParameterMaxElement_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "OverrideName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraActorArrayParameterMaxElement_Number_PropertyAddress, SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "Number");
		SetNiagaraActorArrayParameterMaxElement_Number_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "Number");
		SetNiagaraActorArrayParameterMaxElement_Number_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraActorArrayParameterMaxElement_FunctionAddress, "Number", Classes.FIntProperty);
		SetNiagaraActorArrayParameterMaxElement_IsValid = SetNiagaraActorArrayParameterMaxElement_FunctionAddress != IntPtr.Zero && SetNiagaraActorArrayParameterMaxElement_NiagaraSystem_IsValid && SetNiagaraActorArrayParameterMaxElement_OverrideName_IsValid && SetNiagaraActorArrayParameterMaxElement_Number_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SetNiagaraActorArrayParameterMaxElement", SetNiagaraActorArrayParameterMaxElement_IsValid);
		SerializeUObjectFieldsDataToJson_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SerializeUObjectFieldsDataToJson");
		SerializeUObjectFieldsDataToJson_ParamsSize = NativeReflection.GetFunctionParamsSize(SerializeUObjectFieldsDataToJson_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SerializeUObjectFieldsDataToJson_InObject_PropertyAddress, SerializeUObjectFieldsDataToJson_FunctionAddress, "InObject");
		SerializeUObjectFieldsDataToJson_InObject_Offset = NativeReflectionCached.GetPropertyOffset(SerializeUObjectFieldsDataToJson_FunctionAddress, "InObject");
		SerializeUObjectFieldsDataToJson_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SerializeUObjectFieldsDataToJson_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SerializeUObjectFieldsDataToJson_FilePath_PropertyAddress, SerializeUObjectFieldsDataToJson_FunctionAddress, "FilePath");
		SerializeUObjectFieldsDataToJson_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(SerializeUObjectFieldsDataToJson_FunctionAddress, "FilePath");
		SerializeUObjectFieldsDataToJson_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SerializeUObjectFieldsDataToJson_FunctionAddress, "FilePath", Classes.FStrProperty);
		SerializeUObjectFieldsDataToJson_IsValid = SerializeUObjectFieldsDataToJson_FunctionAddress != IntPtr.Zero && SerializeUObjectFieldsDataToJson_InObject_IsValid && SerializeUObjectFieldsDataToJson_FilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:SerializeUObjectFieldsDataToJson", SerializeUObjectFieldsDataToJson_IsValid);
		RequestSelectedNiagaraAssetForceCompile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestSelectedNiagaraAssetForceCompile");
		RequestSelectedNiagaraAssetForceCompile_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestSelectedNiagaraAssetForceCompile_FunctionAddress);
		RequestSelectedNiagaraAssetForceCompile_IsValid = RequestSelectedNiagaraAssetForceCompile_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:RequestSelectedNiagaraAssetForceCompile", RequestSelectedNiagaraAssetForceCompile_IsValid);
		NiagaraUseUniqueID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NiagaraUseUniqueID");
		NiagaraUseUniqueID_ParamsSize = NativeReflection.GetFunctionParamsSize(NiagaraUseUniqueID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NiagaraUseUniqueID_NiagaraSystem_PropertyAddress, NiagaraUseUniqueID_FunctionAddress, "NiagaraSystem");
		NiagaraUseUniqueID_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(NiagaraUseUniqueID_FunctionAddress, "NiagaraSystem");
		NiagaraUseUniqueID_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(NiagaraUseUniqueID_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NiagaraUseUniqueID_ReturnValue_PropertyAddress, NiagaraUseUniqueID_FunctionAddress, "ReturnValue");
		NiagaraUseUniqueID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NiagaraUseUniqueID_FunctionAddress, "ReturnValue");
		NiagaraUseUniqueID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NiagaraUseUniqueID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NiagaraUseUniqueID_IsValid = NiagaraUseUniqueID_FunctionAddress != IntPtr.Zero && NiagaraUseUniqueID_NiagaraSystem_IsValid && NiagaraUseUniqueID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:NiagaraUseUniqueID", NiagaraUseUniqueID_IsValid);
		GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraSystemInterpolatedSpawningEmitters");
		GetNiagaraSystemInterpolatedSpawningEmitters_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_PropertyAddress, GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress, "NiagaraSystem");
		GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress, "NiagaraSystem");
		GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_PropertyAddress, GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress, "ReturnValue");
		GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress, "ReturnValue");
		GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetNiagaraSystemInterpolatedSpawningEmitters_IsValid = GetNiagaraSystemInterpolatedSpawningEmitters_FunctionAddress != IntPtr.Zero && GetNiagaraSystemInterpolatedSpawningEmitters_NiagaraSystem_IsValid && GetNiagaraSystemInterpolatedSpawningEmitters_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraSystemInterpolatedSpawningEmitters", GetNiagaraSystemInterpolatedSpawningEmitters_IsValid);
		GetNiagaraFieldsData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraFieldsData");
		GetNiagaraFieldsData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraFieldsData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraFieldsData_NiagaraSystem_PropertyAddress, GetNiagaraFieldsData_FunctionAddress, "NiagaraSystem");
		GetNiagaraFieldsData_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraFieldsData_FunctionAddress, "NiagaraSystem");
		GetNiagaraFieldsData_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraFieldsData_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraFieldsData_ReturnValue_PropertyAddress, GetNiagaraFieldsData_FunctionAddress, "ReturnValue");
		GetNiagaraFieldsData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraFieldsData_FunctionAddress, "ReturnValue");
		GetNiagaraFieldsData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraFieldsData_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNiagaraFieldsData_IsValid = GetNiagaraFieldsData_FunctionAddress != IntPtr.Zero && GetNiagaraFieldsData_NiagaraSystem_IsValid && GetNiagaraFieldsData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraFieldsData", GetNiagaraFieldsData_IsValid);
		GetNiagaraEmitterSimInstructionNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraEmitterSimInstructionNum");
		GetNiagaraEmitterSimInstructionNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraEmitterSimInstructionNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraEmitterSimInstructionNum_EmitterObj_PropertyAddress, GetNiagaraEmitterSimInstructionNum_FunctionAddress, "EmitterObj");
		GetNiagaraEmitterSimInstructionNum_EmitterObj_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraEmitterSimInstructionNum_FunctionAddress, "EmitterObj");
		GetNiagaraEmitterSimInstructionNum_EmitterObj_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraEmitterSimInstructionNum_FunctionAddress, "EmitterObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraEmitterSimInstructionNum_ShaderPlatform_PropertyAddress, GetNiagaraEmitterSimInstructionNum_FunctionAddress, "ShaderPlatform");
		GetNiagaraEmitterSimInstructionNum_ShaderPlatform_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraEmitterSimInstructionNum_FunctionAddress, "ShaderPlatform");
		GetNiagaraEmitterSimInstructionNum_ShaderPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraEmitterSimInstructionNum_FunctionAddress, "ShaderPlatform", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraEmitterSimInstructionNum_ReturnValue_PropertyAddress, GetNiagaraEmitterSimInstructionNum_FunctionAddress, "ReturnValue");
		GetNiagaraEmitterSimInstructionNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraEmitterSimInstructionNum_FunctionAddress, "ReturnValue");
		GetNiagaraEmitterSimInstructionNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraEmitterSimInstructionNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNiagaraEmitterSimInstructionNum_IsValid = GetNiagaraEmitterSimInstructionNum_FunctionAddress != IntPtr.Zero && GetNiagaraEmitterSimInstructionNum_EmitterObj_IsValid && GetNiagaraEmitterSimInstructionNum_ShaderPlatform_IsValid && GetNiagaraEmitterSimInstructionNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraEmitterSimInstructionNum", GetNiagaraEmitterSimInstructionNum_IsValid);
		GetNiagaraEmitterCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraEmitterCount");
		GetNiagaraEmitterCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraEmitterCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraEmitterCount_NiagaraSystem_PropertyAddress, GetNiagaraEmitterCount_FunctionAddress, "NiagaraSystem");
		GetNiagaraEmitterCount_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraEmitterCount_FunctionAddress, "NiagaraSystem");
		GetNiagaraEmitterCount_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraEmitterCount_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraEmitterCount_ReturnValue_PropertyAddress, GetNiagaraEmitterCount_FunctionAddress, "ReturnValue");
		GetNiagaraEmitterCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraEmitterCount_FunctionAddress, "ReturnValue");
		GetNiagaraEmitterCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraEmitterCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNiagaraEmitterCount_IsValid = GetNiagaraEmitterCount_FunctionAddress != IntPtr.Zero && GetNiagaraEmitterCount_NiagaraSystem_IsValid && GetNiagaraEmitterCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:GetNiagaraEmitterCount", GetNiagaraEmitterCount_IsValid);
		ForceRequestNiagaraSystemCompile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ForceRequestNiagaraSystemCompile");
		ForceRequestNiagaraSystemCompile_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceRequestNiagaraSystemCompile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceRequestNiagaraSystemCompile_NiagaraSystem_PropertyAddress, ForceRequestNiagaraSystemCompile_FunctionAddress, "NiagaraSystem");
		ForceRequestNiagaraSystemCompile_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(ForceRequestNiagaraSystemCompile_FunctionAddress, "NiagaraSystem");
		ForceRequestNiagaraSystemCompile_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceRequestNiagaraSystemCompile_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		ForceRequestNiagaraSystemCompile_IsValid = ForceRequestNiagaraSystemCompile_FunctionAddress != IntPtr.Zero && ForceRequestNiagaraSystemCompile_NiagaraSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorNiagaraLibrary:ForceRequestNiagaraSystemCompile", ForceRequestNiagaraSystemCompile_IsValid);
	}
}
