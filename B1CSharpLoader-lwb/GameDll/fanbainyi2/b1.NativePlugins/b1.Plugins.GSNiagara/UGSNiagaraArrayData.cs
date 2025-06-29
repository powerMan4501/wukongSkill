using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSNiagara;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData", "GSNiagara", UnrealModuleType.GamePlugin)]
public class UGSNiagaraArrayData : UPrimaryDataAsset
{
	private static bool ParticleInfoArray_IsValid;

	private static FFieldAddress ParticleInfoArray_PropertyAddress;

	private static int ParticleInfoArray_Offset;

	private TArrayReadWriteMarshaler<FGSNiagaraParticleInfo> ParticleInfoArray_MarshalerCached;

	private static bool UpdateParticle_IsValid;

	private static IntPtr UpdateParticle_FunctionAddress;

	private static int UpdateParticle_ParamsSize;

	private static bool UpdateParticle_InParticleInfoArray_IsValid;

	private static FFieldAddress UpdateParticle_InParticleInfoArray_PropertyAddress;

	private static int UpdateParticle_InParticleInfoArray_Offset;

	private static bool RemoveParticle_IsValid;

	private static IntPtr RemoveParticle_FunctionAddress;

	private static int RemoveParticle_ParamsSize;

	private static bool RemoveParticle_Info_IsValid;

	private static FFieldAddress RemoveParticle_Info_PropertyAddress;

	private static int RemoveParticle_Info_Offset;

	private static bool RemoveParticle_ReturnValue_IsValid;

	private static FFieldAddress RemoveParticle_ReturnValue_PropertyAddress;

	private static int RemoveParticle_ReturnValue_Offset;

	private static bool ForceSetParticleSize_IsValid;

	private static IntPtr ForceSetParticleSize_FunctionAddress;

	private static int ForceSetParticleSize_ParamsSize;

	private static bool ForceSetParticleSize_TargetSizeArray_IsValid;

	private static FFieldAddress ForceSetParticleSize_TargetSizeArray_PropertyAddress;

	private static int ForceSetParticleSize_TargetSizeArray_Offset;

	private static bool ForceSetParticlePos_IsValid;

	private static IntPtr ForceSetParticlePos_FunctionAddress;

	private static int ForceSetParticlePos_ParamsSize;

	private static bool ForceSetParticlePos_TargetPosArray_IsValid;

	private static FFieldAddress ForceSetParticlePos_TargetPosArray_PropertyAddress;

	private static int ForceSetParticlePos_TargetPosArray_Offset;

	private static bool ClearParticleArrayData_IsValid;

	private static IntPtr ClearParticleArrayData_FunctionAddress;

	private static int ClearParticleArrayData_ParamsSize;

	private static bool AddParticle_IsValid;

	private static IntPtr AddParticle_FunctionAddress;

	private static int AddParticle_ParamsSize;

	private static bool AddParticle_Info_IsValid;

	private static FFieldAddress AddParticle_Info_PropertyAddress;

	private static int AddParticle_Info_Offset;

	private static bool AddParticle_ReturnValue_IsValid;

	private static FFieldAddress AddParticle_ReturnValue_PropertyAddress;

	private static int AddParticle_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData:ParticleInfoArray")]
	public TArrayReadWrite<FGSNiagaraParticleInfo> ParticleInfoArray
	{
		get
		{
			CheckDestroyed();
			if (!ParticleInfoArray_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSNiagara.GSNiagaraArrayData:ParticleInfoArray");
				return null;
			}
			if (ParticleInfoArray_MarshalerCached == null)
			{
				ParticleInfoArray_MarshalerCached = new TArrayReadWriteMarshaler<FGSNiagaraParticleInfo>(1, ParticleInfoArray_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraParticleInfo, FGSNiagaraParticleInfo>.FromNative, CachedMarshalingDelegates<FGSNiagaraParticleInfo, FGSNiagaraParticleInfo>.ToNative);
			}
			return ParticleInfoArray_MarshalerCached.FromNative(IntPtr.Add(base.Address, ParticleInfoArray_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData:UpdateParticle")]
	public unsafe void UpdateParticle(List<FGSNiagaraParticleInfo> InParticleInfoArray)
	{
		CheckDestroyed();
		if (!UpdateParticle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraArrayData:UpdateParticle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateParticle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateParticle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FGSNiagaraParticleInfo>(1, UpdateParticle_InParticleInfoArray_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraParticleInfo, FGSNiagaraParticleInfo>.FromNative, CachedMarshalingDelegates<FGSNiagaraParticleInfo, FGSNiagaraParticleInfo>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateParticle_InParticleInfoArray_Offset), InParticleInfoArray);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateParticle_FunctionAddress, intPtr, UpdateParticle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateParticle_InParticleInfoArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData:RemoveParticle")]
	public unsafe bool RemoveParticle(FGSNiagaraParticleInfo Info)
	{
		CheckDestroyed();
		if (!RemoveParticle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraArrayData:RemoveParticle");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveParticle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveParticle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveParticle_Info_PropertyAddress.Address, intPtr);
		FGSNiagaraParticleInfo.ToNative(IntPtr.Add(intPtr, RemoveParticle_Info_Offset), 0, RemoveParticle_Info_PropertyAddress.Address, Info);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveParticle_FunctionAddress, intPtr, RemoveParticle_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveParticle_ReturnValue_Offset), 0, RemoveParticle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData:ForceSetParticleSize")]
	public unsafe void ForceSetParticleSize(List<float> TargetSizeArray)
	{
		CheckDestroyed();
		if (!ForceSetParticleSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraArrayData:ForceSetParticleSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceSetParticleSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceSetParticleSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, ForceSetParticleSize_TargetSizeArray_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, ForceSetParticleSize_TargetSizeArray_Offset), TargetSizeArray);
		NativeReflection.InvokeFunctionOptimized(base.Address, ForceSetParticleSize_FunctionAddress, intPtr, ForceSetParticleSize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ForceSetParticleSize_TargetSizeArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData:ForceSetParticlePos")]
	public unsafe void ForceSetParticlePos(List<FVector> TargetPosArray)
	{
		CheckDestroyed();
		if (!ForceSetParticlePos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraArrayData:ForceSetParticlePos");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceSetParticlePos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceSetParticlePos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, ForceSetParticlePos_TargetPosArray_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, ForceSetParticlePos_TargetPosArray_Offset), TargetPosArray);
		NativeReflection.InvokeFunctionOptimized(base.Address, ForceSetParticlePos_FunctionAddress, intPtr, ForceSetParticlePos_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ForceSetParticlePos_TargetPosArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData:ClearParticleArrayData")]
	public unsafe void ClearParticleArrayData()
	{
		CheckDestroyed();
		if (!ClearParticleArrayData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraArrayData:ClearParticleArrayData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearParticleArrayData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearParticleArrayData_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearParticleArrayData_FunctionAddress, argsSize: ClearParticleArrayData_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSNiagara.GSNiagaraArrayData:AddParticle")]
	public unsafe bool AddParticle(FGSNiagaraParticleInfo Info)
	{
		CheckDestroyed();
		if (!AddParticle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSNiagara.GSNiagaraArrayData:AddParticle");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddParticle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddParticle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddParticle_Info_PropertyAddress.Address, intPtr);
		FGSNiagaraParticleInfo.ToNative(IntPtr.Add(intPtr, AddParticle_Info_Offset), 0, AddParticle_Info_PropertyAddress.Address, Info);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddParticle_FunctionAddress, intPtr, AddParticle_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddParticle_ReturnValue_Offset), 0, AddParticle_ReturnValue_PropertyAddress.Address);
	}

	static UGSNiagaraArrayData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSNiagaraArrayData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSNiagaraArrayData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSNiagara.GSNiagaraArrayData");
		NativeReflectionCached.GetPropertyRef(ref ParticleInfoArray_PropertyAddress, intPtr, "ParticleInfoArray");
		ParticleInfoArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParticleInfoArray");
		ParticleInfoArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParticleInfoArray", Classes.FArrayProperty);
		UpdateParticle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateParticle");
		UpdateParticle_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateParticle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateParticle_InParticleInfoArray_PropertyAddress, UpdateParticle_FunctionAddress, "InParticleInfoArray");
		UpdateParticle_InParticleInfoArray_Offset = NativeReflectionCached.GetPropertyOffset(UpdateParticle_FunctionAddress, "InParticleInfoArray");
		UpdateParticle_InParticleInfoArray_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateParticle_FunctionAddress, "InParticleInfoArray", Classes.FArrayProperty);
		UpdateParticle_IsValid = UpdateParticle_FunctionAddress != IntPtr.Zero && UpdateParticle_InParticleInfoArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraArrayData:UpdateParticle", UpdateParticle_IsValid);
		RemoveParticle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveParticle");
		RemoveParticle_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveParticle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveParticle_Info_PropertyAddress, RemoveParticle_FunctionAddress, "Info");
		RemoveParticle_Info_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParticle_FunctionAddress, "Info");
		RemoveParticle_Info_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParticle_FunctionAddress, "Info", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveParticle_ReturnValue_PropertyAddress, RemoveParticle_FunctionAddress, "ReturnValue");
		RemoveParticle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveParticle_FunctionAddress, "ReturnValue");
		RemoveParticle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveParticle_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveParticle_IsValid = RemoveParticle_FunctionAddress != IntPtr.Zero && RemoveParticle_Info_IsValid && RemoveParticle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraArrayData:RemoveParticle", RemoveParticle_IsValid);
		ForceSetParticleSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceSetParticleSize");
		ForceSetParticleSize_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceSetParticleSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceSetParticleSize_TargetSizeArray_PropertyAddress, ForceSetParticleSize_FunctionAddress, "TargetSizeArray");
		ForceSetParticleSize_TargetSizeArray_Offset = NativeReflectionCached.GetPropertyOffset(ForceSetParticleSize_FunctionAddress, "TargetSizeArray");
		ForceSetParticleSize_TargetSizeArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceSetParticleSize_FunctionAddress, "TargetSizeArray", Classes.FArrayProperty);
		ForceSetParticleSize_IsValid = ForceSetParticleSize_FunctionAddress != IntPtr.Zero && ForceSetParticleSize_TargetSizeArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraArrayData:ForceSetParticleSize", ForceSetParticleSize_IsValid);
		ForceSetParticlePos_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceSetParticlePos");
		ForceSetParticlePos_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceSetParticlePos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceSetParticlePos_TargetPosArray_PropertyAddress, ForceSetParticlePos_FunctionAddress, "TargetPosArray");
		ForceSetParticlePos_TargetPosArray_Offset = NativeReflectionCached.GetPropertyOffset(ForceSetParticlePos_FunctionAddress, "TargetPosArray");
		ForceSetParticlePos_TargetPosArray_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceSetParticlePos_FunctionAddress, "TargetPosArray", Classes.FArrayProperty);
		ForceSetParticlePos_IsValid = ForceSetParticlePos_FunctionAddress != IntPtr.Zero && ForceSetParticlePos_TargetPosArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraArrayData:ForceSetParticlePos", ForceSetParticlePos_IsValid);
		ClearParticleArrayData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearParticleArrayData");
		ClearParticleArrayData_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearParticleArrayData_FunctionAddress);
		ClearParticleArrayData_IsValid = ClearParticleArrayData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraArrayData:ClearParticleArrayData", ClearParticleArrayData_IsValid);
		AddParticle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddParticle");
		AddParticle_ParamsSize = NativeReflection.GetFunctionParamsSize(AddParticle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddParticle_Info_PropertyAddress, AddParticle_FunctionAddress, "Info");
		AddParticle_Info_Offset = NativeReflectionCached.GetPropertyOffset(AddParticle_FunctionAddress, "Info");
		AddParticle_Info_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParticle_FunctionAddress, "Info", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddParticle_ReturnValue_PropertyAddress, AddParticle_FunctionAddress, "ReturnValue");
		AddParticle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddParticle_FunctionAddress, "ReturnValue");
		AddParticle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddParticle_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddParticle_IsValid = AddParticle_FunctionAddress != IntPtr.Zero && AddParticle_Info_IsValid && AddParticle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSNiagara.GSNiagaraArrayData:AddParticle", AddParticle_IsValid);
	}
}
