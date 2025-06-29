using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SkeletalMeshFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateUROParams_IsValid;

	private static IntPtr UpdateUROParams_FunctionAddress;

	private static int UpdateUROParams_ParamsSize;

	private static bool UpdateUROParams_OwnerActor_IsValid;

	private static FFieldAddress UpdateUROParams_OwnerActor_PropertyAddress;

	private static int UpdateUROParams_OwnerActor_Offset;

	private static bool UpdateUROParams_BaseVisibleDistanceFactorThesholds_IsValid;

	private static FFieldAddress UpdateUROParams_BaseVisibleDistanceFactorThesholds_PropertyAddress;

	private static int UpdateUROParams_BaseVisibleDistanceFactorThesholds_Offset;

	private static bool UpdateUROParams_BaseNonRenderedUpdateRate_IsValid;

	private static FFieldAddress UpdateUROParams_BaseNonRenderedUpdateRate_PropertyAddress;

	private static int UpdateUROParams_BaseNonRenderedUpdateRate_Offset;

	private static bool SetUpdateOverlapsOnAnimationFinalize_IsValid;

	private static IntPtr SetUpdateOverlapsOnAnimationFinalize_FunctionAddress;

	private static int SetUpdateOverlapsOnAnimationFinalize_ParamsSize;

	private static bool SetUpdateOverlapsOnAnimationFinalize_SKComp_IsValid;

	private static FFieldAddress SetUpdateOverlapsOnAnimationFinalize_SKComp_PropertyAddress;

	private static int SetUpdateOverlapsOnAnimationFinalize_SKComp_Offset;

	private static bool SetUpdateOverlapsOnAnimationFinalize_bVal_IsValid;

	private static FFieldAddress SetUpdateOverlapsOnAnimationFinalize_bVal_PropertyAddress;

	private static int SetUpdateOverlapsOnAnimationFinalize_bVal_Offset;

	private static bool SetTextureParameterValueOnMaterials_IsValid;

	private static IntPtr SetTextureParameterValueOnMaterials_FunctionAddress;

	private static int SetTextureParameterValueOnMaterials_ParamsSize;

	private static bool SetTextureParameterValueOnMaterials_MeshComp_IsValid;

	private static FFieldAddress SetTextureParameterValueOnMaterials_MeshComp_PropertyAddress;

	private static int SetTextureParameterValueOnMaterials_MeshComp_Offset;

	private static bool SetTextureParameterValueOnMaterials_ParameterName_IsValid;

	private static FFieldAddress SetTextureParameterValueOnMaterials_ParameterName_PropertyAddress;

	private static int SetTextureParameterValueOnMaterials_ParameterName_Offset;

	private static bool SetTextureParameterValueOnMaterials_ParameterValue_IsValid;

	private static FFieldAddress SetTextureParameterValueOnMaterials_ParameterValue_PropertyAddress;

	private static int SetTextureParameterValueOnMaterials_ParameterValue_Offset;

	private static bool SetBodyInstanceShapeCollisionEnable_IsValid;

	private static IntPtr SetBodyInstanceShapeCollisionEnable_FunctionAddress;

	private static int SetBodyInstanceShapeCollisionEnable_ParamsSize;

	private static bool SetBodyInstanceShapeCollisionEnable_SKMeshComp_IsValid;

	private static FFieldAddress SetBodyInstanceShapeCollisionEnable_SKMeshComp_PropertyAddress;

	private static int SetBodyInstanceShapeCollisionEnable_SKMeshComp_Offset;

	private static bool SetBodyInstanceShapeCollisionEnable_BoneName_IsValid;

	private static FFieldAddress SetBodyInstanceShapeCollisionEnable_BoneName_PropertyAddress;

	private static int SetBodyInstanceShapeCollisionEnable_BoneName_Offset;

	private static bool SetBodyInstanceShapeCollisionEnable_ShapeIndex_IsValid;

	private static FFieldAddress SetBodyInstanceShapeCollisionEnable_ShapeIndex_PropertyAddress;

	private static int SetBodyInstanceShapeCollisionEnable_ShapeIndex_Offset;

	private static bool SetBodyInstanceShapeCollisionEnable_NewType_IsValid;

	private static FFieldAddress SetBodyInstanceShapeCollisionEnable_NewType_PropertyAddress;

	private static int SetBodyInstanceShapeCollisionEnable_NewType_Offset;

	private static bool SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_IsValid;

	private static FFieldAddress SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_PropertyAddress;

	private static int SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_Offset;

	private static bool SetBodyInstanceShapeCollisionEnable_bGetWelded_IsValid;

	private static FFieldAddress SetBodyInstanceShapeCollisionEnable_bGetWelded_PropertyAddress;

	private static int SetBodyInstanceShapeCollisionEnable_bGetWelded_Offset;

	private static bool SetBodyInstanceCollisionProfileName_IsValid;

	private static IntPtr SetBodyInstanceCollisionProfileName_FunctionAddress;

	private static int SetBodyInstanceCollisionProfileName_ParamsSize;

	private static bool SetBodyInstanceCollisionProfileName_SKMeshComp_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionProfileName_SKMeshComp_PropertyAddress;

	private static int SetBodyInstanceCollisionProfileName_SKMeshComp_Offset;

	private static bool SetBodyInstanceCollisionProfileName_BoneName_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionProfileName_BoneName_PropertyAddress;

	private static int SetBodyInstanceCollisionProfileName_BoneName_Offset;

	private static bool SetBodyInstanceCollisionProfileName_InCollisionProfileName_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionProfileName_InCollisionProfileName_PropertyAddress;

	private static int SetBodyInstanceCollisionProfileName_InCollisionProfileName_Offset;

	private static bool SetBodyInstanceCollisionProfileName_bGetWelded_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionProfileName_bGetWelded_PropertyAddress;

	private static int SetBodyInstanceCollisionProfileName_bGetWelded_Offset;

	private static bool SetBodyInstanceCollisionEnable_IsValid;

	private static IntPtr SetBodyInstanceCollisionEnable_FunctionAddress;

	private static int SetBodyInstanceCollisionEnable_ParamsSize;

	private static bool SetBodyInstanceCollisionEnable_SKMeshComp_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionEnable_SKMeshComp_PropertyAddress;

	private static int SetBodyInstanceCollisionEnable_SKMeshComp_Offset;

	private static bool SetBodyInstanceCollisionEnable_BoneName_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionEnable_BoneName_PropertyAddress;

	private static int SetBodyInstanceCollisionEnable_BoneName_Offset;

	private static bool SetBodyInstanceCollisionEnable_NewType_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionEnable_NewType_PropertyAddress;

	private static int SetBodyInstanceCollisionEnable_NewType_Offset;

	private static bool SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_PropertyAddress;

	private static int SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_Offset;

	private static bool SetBodyInstanceCollisionEnable_bGetWelded_IsValid;

	private static FFieldAddress SetBodyInstanceCollisionEnable_bGetWelded_PropertyAddress;

	private static int SetBodyInstanceCollisionEnable_bGetWelded_Offset;

	private static bool SetBodyInstanceAutoWeld_IsValid;

	private static IntPtr SetBodyInstanceAutoWeld_FunctionAddress;

	private static int SetBodyInstanceAutoWeld_ParamsSize;

	private static bool SetBodyInstanceAutoWeld_SKMeshComp_IsValid;

	private static FFieldAddress SetBodyInstanceAutoWeld_SKMeshComp_PropertyAddress;

	private static int SetBodyInstanceAutoWeld_SKMeshComp_Offset;

	private static bool SetBodyInstanceAutoWeld_BoneName_IsValid;

	private static FFieldAddress SetBodyInstanceAutoWeld_BoneName_PropertyAddress;

	private static int SetBodyInstanceAutoWeld_BoneName_Offset;

	private static bool SetBodyInstanceAutoWeld_bAutoWeld_IsValid;

	private static FFieldAddress SetBodyInstanceAutoWeld_bAutoWeld_PropertyAddress;

	private static int SetBodyInstanceAutoWeld_bAutoWeld_Offset;

	private static bool SetBodyInstanceAutoWeld_bGetWelded_IsValid;

	private static FFieldAddress SetBodyInstanceAutoWeld_bGetWelded_PropertyAddress;

	private static int SetBodyInstanceAutoWeld_bGetWelded_Offset;

	private static bool SetAllBodiesShapeCollisionEnabled_IsValid;

	private static IntPtr SetAllBodiesShapeCollisionEnabled_FunctionAddress;

	private static int SetAllBodiesShapeCollisionEnabled_ParamsSize;

	private static bool SetAllBodiesShapeCollisionEnabled_SKComp_IsValid;

	private static FFieldAddress SetAllBodiesShapeCollisionEnabled_SKComp_PropertyAddress;

	private static int SetAllBodiesShapeCollisionEnabled_SKComp_Offset;

	private static bool SetAllBodiesShapeCollisionEnabled_Type_IsValid;

	private static FFieldAddress SetAllBodiesShapeCollisionEnabled_Type_PropertyAddress;

	private static int SetAllBodiesShapeCollisionEnabled_Type_Offset;

	private static bool SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_IsValid;

	private static FFieldAddress SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_PropertyAddress;

	private static int SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_Offset;

	private static bool RemoveLoDs_IsValid;

	private static IntPtr RemoveLoDs_FunctionAddress;

	private static int RemoveLoDs_ParamsSize;

	private static bool RemoveLoDs_SkeletalMesh_IsValid;

	private static FFieldAddress RemoveLoDs_SkeletalMesh_PropertyAddress;

	private static int RemoveLoDs_SkeletalMesh_Offset;

	private static bool RemoveLoDs_ToRemoveLODs_IsValid;

	private static FFieldAddress RemoveLoDs_ToRemoveLODs_PropertyAddress;

	private static int RemoveLoDs_ToRemoveLODs_Offset;

	private static bool RemoveLoDs_ReturnValue_IsValid;

	private static FFieldAddress RemoveLoDs_ReturnValue_PropertyAddress;

	private static int RemoveLoDs_ReturnValue_Offset;

	private static bool IsCPUAccess_IsValid;

	private static IntPtr IsCPUAccess_FunctionAddress;

	private static int IsCPUAccess_ParamsSize;

	private static bool IsCPUAccess_SKMesh_IsValid;

	private static FFieldAddress IsCPUAccess_SKMesh_PropertyAddress;

	private static int IsCPUAccess_SKMesh_Offset;

	private static bool IsCPUAccess_ReturnValue_IsValid;

	private static FFieldAddress IsCPUAccess_ReturnValue_PropertyAddress;

	private static int IsCPUAccess_ReturnValue_Offset;

	private static bool GS_SetEndPhysicsTickEnabled_IsValid;

	private static IntPtr GS_SetEndPhysicsTickEnabled_FunctionAddress;

	private static int GS_SetEndPhysicsTickEnabled_ParamsSize;

	private static bool GS_SetEndPhysicsTickEnabled_SKComp_IsValid;

	private static FFieldAddress GS_SetEndPhysicsTickEnabled_SKComp_PropertyAddress;

	private static int GS_SetEndPhysicsTickEnabled_SKComp_Offset;

	private static bool GS_SetEndPhysicsTickEnabled_bVal_IsValid;

	private static FFieldAddress GS_SetEndPhysicsTickEnabled_bVal_PropertyAddress;

	private static int GS_SetEndPhysicsTickEnabled_bVal_Offset;

	private static bool GetUROResult_IsValid;

	private static IntPtr GetUROResult_FunctionAddress;

	private static int GetUROResult_ParamsSize;

	private static bool GetUROResult_OwnerActor_IsValid;

	private static FFieldAddress GetUROResult_OwnerActor_PropertyAddress;

	private static int GetUROResult_OwnerActor_Offset;

	private static bool GetUROResult_OutAccumulatedDeltaTime_IsValid;

	private static FFieldAddress GetUROResult_OutAccumulatedDeltaTime_PropertyAddress;

	private static int GetUROResult_OutAccumulatedDeltaTime_Offset;

	private static bool GetUROResult_ReturnValue_IsValid;

	private static FFieldAddress GetUROResult_ReturnValue_PropertyAddress;

	private static int GetUROResult_ReturnValue_Offset;

	private static bool GetRefPoseTransform_IsValid;

	private static IntPtr GetRefPoseTransform_FunctionAddress;

	private static int GetRefPoseTransform_ParamsSize;

	private static bool GetRefPoseTransform_MeshComp_IsValid;

	private static FFieldAddress GetRefPoseTransform_MeshComp_PropertyAddress;

	private static int GetRefPoseTransform_MeshComp_Offset;

	private static bool GetRefPoseTransform_BoneIndex_IsValid;

	private static FFieldAddress GetRefPoseTransform_BoneIndex_PropertyAddress;

	private static int GetRefPoseTransform_BoneIndex_Offset;

	private static bool GetRefPoseTransform_bIsLocal_IsValid;

	private static FFieldAddress GetRefPoseTransform_bIsLocal_PropertyAddress;

	private static int GetRefPoseTransform_bIsLocal_Offset;

	private static bool GetRefPoseTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRefPoseTransform_ReturnValue_PropertyAddress;

	private static int GetRefPoseTransform_ReturnValue_Offset;

	private static bool GetNumOverrideMaterials_IsValid;

	private static IntPtr GetNumOverrideMaterials_FunctionAddress;

	private static int GetNumOverrideMaterials_ParamsSize;

	private static bool GetNumOverrideMaterials_SKComp_IsValid;

	private static FFieldAddress GetNumOverrideMaterials_SKComp_PropertyAddress;

	private static int GetNumOverrideMaterials_SKComp_Offset;

	private static bool GetNumOverrideMaterials_ReturnValue_IsValid;

	private static FFieldAddress GetNumOverrideMaterials_ReturnValue_PropertyAddress;

	private static int GetNumOverrideMaterials_ReturnValue_Offset;

	private static bool GetLODSettingsGroupNum_IsValid;

	private static IntPtr GetLODSettingsGroupNum_FunctionAddress;

	private static int GetLODSettingsGroupNum_ParamsSize;

	private static bool GetLODSettingsGroupNum_LodSettings_IsValid;

	private static FFieldAddress GetLODSettingsGroupNum_LodSettings_PropertyAddress;

	private static int GetLODSettingsGroupNum_LodSettings_Offset;

	private static bool GetLODSettingsGroupNum_ReturnValue_IsValid;

	private static FFieldAddress GetLODSettingsGroupNum_ReturnValue_PropertyAddress;

	private static int GetLODSettingsGroupNum_ReturnValue_Offset;

	private static bool GetBodyInstanceShapeCollisionEnable_IsValid;

	private static IntPtr GetBodyInstanceShapeCollisionEnable_FunctionAddress;

	private static int GetBodyInstanceShapeCollisionEnable_ParamsSize;

	private static bool GetBodyInstanceShapeCollisionEnable_SKMeshComp_IsValid;

	private static FFieldAddress GetBodyInstanceShapeCollisionEnable_SKMeshComp_PropertyAddress;

	private static int GetBodyInstanceShapeCollisionEnable_SKMeshComp_Offset;

	private static bool GetBodyInstanceShapeCollisionEnable_BoneName_IsValid;

	private static FFieldAddress GetBodyInstanceShapeCollisionEnable_BoneName_PropertyAddress;

	private static int GetBodyInstanceShapeCollisionEnable_BoneName_Offset;

	private static bool GetBodyInstanceShapeCollisionEnable_ShapeIndex_IsValid;

	private static FFieldAddress GetBodyInstanceShapeCollisionEnable_ShapeIndex_PropertyAddress;

	private static int GetBodyInstanceShapeCollisionEnable_ShapeIndex_Offset;

	private static bool GetBodyInstanceShapeCollisionEnable_bGetWelded_IsValid;

	private static FFieldAddress GetBodyInstanceShapeCollisionEnable_bGetWelded_PropertyAddress;

	private static int GetBodyInstanceShapeCollisionEnable_bGetWelded_Offset;

	private static bool GetBodyInstanceShapeCollisionEnable_ReturnValue_IsValid;

	private static FFieldAddress GetBodyInstanceShapeCollisionEnable_ReturnValue_PropertyAddress;

	private static int GetBodyInstanceShapeCollisionEnable_ReturnValue_Offset;

	private static bool GetBodyInstanceCollisionProfileName_IsValid;

	private static IntPtr GetBodyInstanceCollisionProfileName_FunctionAddress;

	private static int GetBodyInstanceCollisionProfileName_ParamsSize;

	private static bool GetBodyInstanceCollisionProfileName_SKMeshComp_IsValid;

	private static FFieldAddress GetBodyInstanceCollisionProfileName_SKMeshComp_PropertyAddress;

	private static int GetBodyInstanceCollisionProfileName_SKMeshComp_Offset;

	private static bool GetBodyInstanceCollisionProfileName_BoneName_IsValid;

	private static FFieldAddress GetBodyInstanceCollisionProfileName_BoneName_PropertyAddress;

	private static int GetBodyInstanceCollisionProfileName_BoneName_Offset;

	private static bool GetBodyInstanceCollisionProfileName_bGetWelded_IsValid;

	private static FFieldAddress GetBodyInstanceCollisionProfileName_bGetWelded_PropertyAddress;

	private static int GetBodyInstanceCollisionProfileName_bGetWelded_Offset;

	private static bool GetBodyInstanceCollisionProfileName_ReturnValue_IsValid;

	private static FFieldAddress GetBodyInstanceCollisionProfileName_ReturnValue_PropertyAddress;

	private static int GetBodyInstanceCollisionProfileName_ReturnValue_Offset;

	private static bool BakeSkinInfoToUVs_IsValid;

	private static IntPtr BakeSkinInfoToUVs_FunctionAddress;

	private static int BakeSkinInfoToUVs_ParamsSize;

	private static bool BakeSkinInfoToUVs_TargetSkeletalMesh_IsValid;

	private static FFieldAddress BakeSkinInfoToUVs_TargetSkeletalMesh_PropertyAddress;

	private static int BakeSkinInfoToUVs_TargetSkeletalMesh_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:UpdateUROParams")]
	public unsafe static void UpdateUROParams(AActor OwnerActor, List<float> BaseVisibleDistanceFactorThesholds, int BaseNonRenderedUpdateRate)
	{
		if (!UpdateUROParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:UpdateUROParams");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateUROParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateUROParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, UpdateUROParams_OwnerActor_Offset), 0, UpdateUROParams_OwnerActor_PropertyAddress.Address, OwnerActor);
		new TArrayCopyMarshaler<float>(1, UpdateUROParams_BaseVisibleDistanceFactorThesholds_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, UpdateUROParams_BaseVisibleDistanceFactorThesholds_Offset), BaseVisibleDistanceFactorThesholds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, UpdateUROParams_BaseNonRenderedUpdateRate_Offset), 0, UpdateUROParams_BaseNonRenderedUpdateRate_PropertyAddress.Address, BaseNonRenderedUpdateRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateUROParams_FunctionAddress, intPtr, UpdateUROParams_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateUROParams_BaseVisibleDistanceFactorThesholds_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetUpdateOverlapsOnAnimationFinalize")]
	public unsafe static void SetUpdateOverlapsOnAnimationFinalize(USkeletalMeshComponent SKComp, bool bVal)
	{
		if (!SetUpdateOverlapsOnAnimationFinalize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetUpdateOverlapsOnAnimationFinalize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUpdateOverlapsOnAnimationFinalize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUpdateOverlapsOnAnimationFinalize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetUpdateOverlapsOnAnimationFinalize_SKComp_Offset), 0, SetUpdateOverlapsOnAnimationFinalize_SKComp_PropertyAddress.Address, SKComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUpdateOverlapsOnAnimationFinalize_bVal_Offset), 0, SetUpdateOverlapsOnAnimationFinalize_bVal_PropertyAddress.Address, bVal);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUpdateOverlapsOnAnimationFinalize_FunctionAddress, intPtr, SetUpdateOverlapsOnAnimationFinalize_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetTextureParameterValueOnMaterials")]
	public unsafe static void SetTextureParameterValueOnMaterials(UMeshComponent MeshComp, FName ParameterName, UTexture ParameterValue)
	{
		if (!SetTextureParameterValueOnMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetTextureParameterValueOnMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureParameterValueOnMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureParameterValueOnMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshComponent>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueOnMaterials_MeshComp_Offset), 0, SetTextureParameterValueOnMaterials_MeshComp_PropertyAddress.Address, MeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueOnMaterials_ParameterName_Offset), 0, SetTextureParameterValueOnMaterials_ParameterName_PropertyAddress.Address, ParameterName);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetTextureParameterValueOnMaterials_ParameterValue_Offset), 0, SetTextureParameterValueOnMaterials_ParameterValue_PropertyAddress.Address, ParameterValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTextureParameterValueOnMaterials_FunctionAddress, intPtr, SetTextureParameterValueOnMaterials_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceShapeCollisionEnable")]
	public unsafe static void SetBodyInstanceShapeCollisionEnable(USkeletalMeshComponent SKMeshComp, FName BoneName, int ShapeIndex, ECollisionEnabled NewType, bool bUpdatePhysicsFilterData = true, bool bGetWelded = true)
	{
		if (!SetBodyInstanceShapeCollisionEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceShapeCollisionEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBodyInstanceShapeCollisionEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBodyInstanceShapeCollisionEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceShapeCollisionEnable_SKMeshComp_Offset), 0, SetBodyInstanceShapeCollisionEnable_SKMeshComp_PropertyAddress.Address, SKMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceShapeCollisionEnable_BoneName_Offset), 0, SetBodyInstanceShapeCollisionEnable_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceShapeCollisionEnable_ShapeIndex_Offset), 0, SetBodyInstanceShapeCollisionEnable_ShapeIndex_PropertyAddress.Address, ShapeIndex);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceShapeCollisionEnable_NewType_Offset), 0, SetBodyInstanceShapeCollisionEnable_NewType_PropertyAddress.Address, NewType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_Offset), 0, SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_PropertyAddress.Address, bUpdatePhysicsFilterData);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyInstanceShapeCollisionEnable_bGetWelded_Offset), 0, SetBodyInstanceShapeCollisionEnable_bGetWelded_PropertyAddress.Address, bGetWelded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBodyInstanceShapeCollisionEnable_FunctionAddress, intPtr, SetBodyInstanceShapeCollisionEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceCollisionProfileName")]
	public unsafe static void SetBodyInstanceCollisionProfileName(USkeletalMeshComponent SKMeshComp, FName BoneName, FName InCollisionProfileName, bool bGetWelded = true)
	{
		if (!SetBodyInstanceCollisionProfileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceCollisionProfileName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBodyInstanceCollisionProfileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBodyInstanceCollisionProfileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionProfileName_SKMeshComp_Offset), 0, SetBodyInstanceCollisionProfileName_SKMeshComp_PropertyAddress.Address, SKMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionProfileName_BoneName_Offset), 0, SetBodyInstanceCollisionProfileName_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionProfileName_InCollisionProfileName_Offset), 0, SetBodyInstanceCollisionProfileName_InCollisionProfileName_PropertyAddress.Address, InCollisionProfileName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionProfileName_bGetWelded_Offset), 0, SetBodyInstanceCollisionProfileName_bGetWelded_PropertyAddress.Address, bGetWelded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBodyInstanceCollisionProfileName_FunctionAddress, intPtr, SetBodyInstanceCollisionProfileName_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceCollisionEnable")]
	public unsafe static void SetBodyInstanceCollisionEnable(USkeletalMeshComponent SKMeshComp, FName BoneName, ECollisionEnabled NewType, bool bUpdatePhysicsFilterData = true, bool bGetWelded = true)
	{
		if (!SetBodyInstanceCollisionEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceCollisionEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBodyInstanceCollisionEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBodyInstanceCollisionEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionEnable_SKMeshComp_Offset), 0, SetBodyInstanceCollisionEnable_SKMeshComp_PropertyAddress.Address, SKMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionEnable_BoneName_Offset), 0, SetBodyInstanceCollisionEnable_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionEnable_NewType_Offset), 0, SetBodyInstanceCollisionEnable_NewType_PropertyAddress.Address, NewType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_Offset), 0, SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_PropertyAddress.Address, bUpdatePhysicsFilterData);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyInstanceCollisionEnable_bGetWelded_Offset), 0, SetBodyInstanceCollisionEnable_bGetWelded_PropertyAddress.Address, bGetWelded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBodyInstanceCollisionEnable_FunctionAddress, intPtr, SetBodyInstanceCollisionEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceAutoWeld")]
	public unsafe static void SetBodyInstanceAutoWeld(USkeletalMeshComponent SKMeshComp, FName BoneName, bool bAutoWeld, bool bGetWelded = true)
	{
		if (!SetBodyInstanceAutoWeld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceAutoWeld");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBodyInstanceAutoWeld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBodyInstanceAutoWeld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceAutoWeld_SKMeshComp_Offset), 0, SetBodyInstanceAutoWeld_SKMeshComp_PropertyAddress.Address, SKMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBodyInstanceAutoWeld_BoneName_Offset), 0, SetBodyInstanceAutoWeld_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyInstanceAutoWeld_bAutoWeld_Offset), 0, SetBodyInstanceAutoWeld_bAutoWeld_PropertyAddress.Address, bAutoWeld);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyInstanceAutoWeld_bGetWelded_Offset), 0, SetBodyInstanceAutoWeld_bGetWelded_PropertyAddress.Address, bGetWelded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBodyInstanceAutoWeld_FunctionAddress, intPtr, SetBodyInstanceAutoWeld_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetAllBodiesShapeCollisionEnabled")]
	public unsafe static void SetAllBodiesShapeCollisionEnabled(USkeletalMeshComponent SKComp, ECollisionEnabled Type, bool bUpdateFilterData = true)
	{
		if (!SetAllBodiesShapeCollisionEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetAllBodiesShapeCollisionEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllBodiesShapeCollisionEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllBodiesShapeCollisionEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetAllBodiesShapeCollisionEnabled_SKComp_Offset), 0, SetAllBodiesShapeCollisionEnabled_SKComp_PropertyAddress.Address, SKComp);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetAllBodiesShapeCollisionEnabled_Type_Offset), 0, SetAllBodiesShapeCollisionEnabled_Type_PropertyAddress.Address, Type);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_Offset), 0, SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_PropertyAddress.Address, bUpdateFilterData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAllBodiesShapeCollisionEnabled_FunctionAddress, intPtr, SetAllBodiesShapeCollisionEnabled_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:RemoveLoDs")]
	public unsafe static bool RemoveLoDs(USkeletalMesh SkeletalMesh, List<int> ToRemoveLODs)
	{
		if (!RemoveLoDs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:RemoveLoDs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveLoDs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveLoDs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, RemoveLoDs_SkeletalMesh_Offset), 0, RemoveLoDs_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		new TArrayCopyMarshaler<int>(1, RemoveLoDs_ToRemoveLODs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, RemoveLoDs_ToRemoveLODs_Offset), ToRemoveLODs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveLoDs_FunctionAddress, intPtr, RemoveLoDs_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveLoDs_ToRemoveLODs_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveLoDs_ReturnValue_Offset), 0, RemoveLoDs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:IsCPUAccess")]
	public unsafe static bool IsCPUAccess(USkeletalMesh SKMesh)
	{
		if (!IsCPUAccess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:IsCPUAccess");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCPUAccess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCPUAccess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, IsCPUAccess_SKMesh_Offset), 0, IsCPUAccess_SKMesh_PropertyAddress.Address, SKMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCPUAccess_FunctionAddress, intPtr, IsCPUAccess_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCPUAccess_ReturnValue_Offset), 0, IsCPUAccess_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GS_SetEndPhysicsTickEnabled")]
	public unsafe static void GS_SetEndPhysicsTickEnabled(USkeletalMeshComponent SKComp, bool bVal)
	{
		if (!GS_SetEndPhysicsTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GS_SetEndPhysicsTickEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GS_SetEndPhysicsTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GS_SetEndPhysicsTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GS_SetEndPhysicsTickEnabled_SKComp_Offset), 0, GS_SetEndPhysicsTickEnabled_SKComp_PropertyAddress.Address, SKComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GS_SetEndPhysicsTickEnabled_bVal_Offset), 0, GS_SetEndPhysicsTickEnabled_bVal_PropertyAddress.Address, bVal);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GS_SetEndPhysicsTickEnabled_FunctionAddress, intPtr, GS_SetEndPhysicsTickEnabled_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetUROResult")]
	public unsafe static bool GetUROResult(AActor OwnerActor, out float OutAccumulatedDeltaTime)
	{
		if (!GetUROResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetUROResult");
			OutAccumulatedDeltaTime = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUROResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUROResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetUROResult_OwnerActor_Offset), 0, GetUROResult_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUROResult_FunctionAddress, intPtr, GetUROResult_ParamsSize);
		OutAccumulatedDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetUROResult_OutAccumulatedDeltaTime_Offset), 0, GetUROResult_OutAccumulatedDeltaTime_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetUROResult_ReturnValue_Offset), 0, GetUROResult_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetRefPoseTransform")]
	public unsafe static FTransform GetRefPoseTransform(USkinnedMeshComponent MeshComp, int BoneIndex, bool bIsLocal = true)
	{
		if (!GetRefPoseTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetRefPoseTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRefPoseTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRefPoseTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkinnedMeshComponent>.ToNative(IntPtr.Add(intPtr, GetRefPoseTransform_MeshComp_Offset), 0, GetRefPoseTransform_MeshComp_PropertyAddress.Address, MeshComp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRefPoseTransform_BoneIndex_Offset), 0, GetRefPoseTransform_BoneIndex_PropertyAddress.Address, BoneIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetRefPoseTransform_bIsLocal_Offset), 0, GetRefPoseTransform_bIsLocal_PropertyAddress.Address, bIsLocal);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRefPoseTransform_FunctionAddress, intPtr, GetRefPoseTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRefPoseTransform_ReturnValue_Offset), 0, GetRefPoseTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetNumOverrideMaterials")]
	public unsafe static int GetNumOverrideMaterials(USkeletalMeshComponent SKComp)
	{
		if (!GetNumOverrideMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetNumOverrideMaterials");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumOverrideMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumOverrideMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetNumOverrideMaterials_SKComp_Offset), 0, GetNumOverrideMaterials_SKComp_PropertyAddress.Address, SKComp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumOverrideMaterials_FunctionAddress, intPtr, GetNumOverrideMaterials_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumOverrideMaterials_ReturnValue_Offset), 0, GetNumOverrideMaterials_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetLODSettingsGroupNum")]
	public unsafe static int GetLODSettingsGroupNum(USkeletalMeshLODSettings LodSettings)
	{
		if (!GetLODSettingsGroupNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetLODSettingsGroupNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLODSettingsGroupNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLODSettingsGroupNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshLODSettings>.ToNative(IntPtr.Add(intPtr, GetLODSettingsGroupNum_LodSettings_Offset), 0, GetLODSettingsGroupNum_LodSettings_PropertyAddress.Address, LodSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLODSettingsGroupNum_FunctionAddress, intPtr, GetLODSettingsGroupNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLODSettingsGroupNum_ReturnValue_Offset), 0, GetLODSettingsGroupNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetBodyInstanceShapeCollisionEnable")]
	public unsafe static ECollisionEnabled GetBodyInstanceShapeCollisionEnable(USkeletalMeshComponent SKMeshComp, FName BoneName, int ShapeIndex, bool bGetWelded = true)
	{
		if (!GetBodyInstanceShapeCollisionEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetBodyInstanceShapeCollisionEnable");
			return ECollisionEnabled.NoCollision;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBodyInstanceShapeCollisionEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBodyInstanceShapeCollisionEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetBodyInstanceShapeCollisionEnable_SKMeshComp_Offset), 0, GetBodyInstanceShapeCollisionEnable_SKMeshComp_PropertyAddress.Address, SKMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBodyInstanceShapeCollisionEnable_BoneName_Offset), 0, GetBodyInstanceShapeCollisionEnable_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBodyInstanceShapeCollisionEnable_ShapeIndex_Offset), 0, GetBodyInstanceShapeCollisionEnable_ShapeIndex_PropertyAddress.Address, ShapeIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBodyInstanceShapeCollisionEnable_bGetWelded_Offset), 0, GetBodyInstanceShapeCollisionEnable_bGetWelded_PropertyAddress.Address, bGetWelded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBodyInstanceShapeCollisionEnable_FunctionAddress, intPtr, GetBodyInstanceShapeCollisionEnable_ParamsSize);
		return EnumMarshaler<ECollisionEnabled>.FromNative(IntPtr.Add(intPtr, GetBodyInstanceShapeCollisionEnable_ReturnValue_Offset), 0, GetBodyInstanceShapeCollisionEnable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetBodyInstanceCollisionProfileName")]
	public unsafe static FName GetBodyInstanceCollisionProfileName(USkeletalMeshComponent SKMeshComp, FName BoneName, bool bGetWelded)
	{
		if (!GetBodyInstanceCollisionProfileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetBodyInstanceCollisionProfileName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBodyInstanceCollisionProfileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBodyInstanceCollisionProfileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetBodyInstanceCollisionProfileName_SKMeshComp_Offset), 0, GetBodyInstanceCollisionProfileName_SKMeshComp_PropertyAddress.Address, SKMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBodyInstanceCollisionProfileName_BoneName_Offset), 0, GetBodyInstanceCollisionProfileName_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetBodyInstanceCollisionProfileName_bGetWelded_Offset), 0, GetBodyInstanceCollisionProfileName_bGetWelded_PropertyAddress.Address, bGetWelded);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBodyInstanceCollisionProfileName_FunctionAddress, intPtr, GetBodyInstanceCollisionProfileName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetBodyInstanceCollisionProfileName_ReturnValue_Offset), 0, GetBodyInstanceCollisionProfileName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:BakeSkinInfoToUVs")]
	public unsafe static void BakeSkinInfoToUVs(USkeletalMesh TargetSkeletalMesh)
	{
		if (!BakeSkinInfoToUVs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:BakeSkinInfoToUVs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BakeSkinInfoToUVs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BakeSkinInfoToUVs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, BakeSkinInfoToUVs_TargetSkeletalMesh_Offset), 0, BakeSkinInfoToUVs_TargetSkeletalMesh_PropertyAddress.Address, TargetSkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BakeSkinInfoToUVs_FunctionAddress, intPtr, BakeSkinInfoToUVs_ParamsSize);
	}

	static UGSE_SkeletalMeshFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SkeletalMeshFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SkeletalMeshFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib");
		UpdateUROParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateUROParams");
		UpdateUROParams_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateUROParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateUROParams_OwnerActor_PropertyAddress, UpdateUROParams_FunctionAddress, "OwnerActor");
		UpdateUROParams_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(UpdateUROParams_FunctionAddress, "OwnerActor");
		UpdateUROParams_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateUROParams_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateUROParams_BaseVisibleDistanceFactorThesholds_PropertyAddress, UpdateUROParams_FunctionAddress, "BaseVisibleDistanceFactorThesholds");
		UpdateUROParams_BaseVisibleDistanceFactorThesholds_Offset = NativeReflectionCached.GetPropertyOffset(UpdateUROParams_FunctionAddress, "BaseVisibleDistanceFactorThesholds");
		UpdateUROParams_BaseVisibleDistanceFactorThesholds_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateUROParams_FunctionAddress, "BaseVisibleDistanceFactorThesholds", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateUROParams_BaseNonRenderedUpdateRate_PropertyAddress, UpdateUROParams_FunctionAddress, "BaseNonRenderedUpdateRate");
		UpdateUROParams_BaseNonRenderedUpdateRate_Offset = NativeReflectionCached.GetPropertyOffset(UpdateUROParams_FunctionAddress, "BaseNonRenderedUpdateRate");
		UpdateUROParams_BaseNonRenderedUpdateRate_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateUROParams_FunctionAddress, "BaseNonRenderedUpdateRate", Classes.FIntProperty);
		UpdateUROParams_IsValid = UpdateUROParams_FunctionAddress != IntPtr.Zero && UpdateUROParams_OwnerActor_IsValid && UpdateUROParams_BaseVisibleDistanceFactorThesholds_IsValid && UpdateUROParams_BaseNonRenderedUpdateRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:UpdateUROParams", UpdateUROParams_IsValid);
		SetUpdateOverlapsOnAnimationFinalize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUpdateOverlapsOnAnimationFinalize");
		SetUpdateOverlapsOnAnimationFinalize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUpdateOverlapsOnAnimationFinalize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUpdateOverlapsOnAnimationFinalize_SKComp_PropertyAddress, SetUpdateOverlapsOnAnimationFinalize_FunctionAddress, "SKComp");
		SetUpdateOverlapsOnAnimationFinalize_SKComp_Offset = NativeReflectionCached.GetPropertyOffset(SetUpdateOverlapsOnAnimationFinalize_FunctionAddress, "SKComp");
		SetUpdateOverlapsOnAnimationFinalize_SKComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUpdateOverlapsOnAnimationFinalize_FunctionAddress, "SKComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetUpdateOverlapsOnAnimationFinalize_bVal_PropertyAddress, SetUpdateOverlapsOnAnimationFinalize_FunctionAddress, "bVal");
		SetUpdateOverlapsOnAnimationFinalize_bVal_Offset = NativeReflectionCached.GetPropertyOffset(SetUpdateOverlapsOnAnimationFinalize_FunctionAddress, "bVal");
		SetUpdateOverlapsOnAnimationFinalize_bVal_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUpdateOverlapsOnAnimationFinalize_FunctionAddress, "bVal", Classes.FBoolProperty);
		SetUpdateOverlapsOnAnimationFinalize_IsValid = SetUpdateOverlapsOnAnimationFinalize_FunctionAddress != IntPtr.Zero && SetUpdateOverlapsOnAnimationFinalize_SKComp_IsValid && SetUpdateOverlapsOnAnimationFinalize_bVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetUpdateOverlapsOnAnimationFinalize", SetUpdateOverlapsOnAnimationFinalize_IsValid);
		SetTextureParameterValueOnMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTextureParameterValueOnMaterials");
		SetTextureParameterValueOnMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureParameterValueOnMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueOnMaterials_MeshComp_PropertyAddress, SetTextureParameterValueOnMaterials_FunctionAddress, "MeshComp");
		SetTextureParameterValueOnMaterials_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueOnMaterials_FunctionAddress, "MeshComp");
		SetTextureParameterValueOnMaterials_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueOnMaterials_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueOnMaterials_ParameterName_PropertyAddress, SetTextureParameterValueOnMaterials_FunctionAddress, "ParameterName");
		SetTextureParameterValueOnMaterials_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueOnMaterials_FunctionAddress, "ParameterName");
		SetTextureParameterValueOnMaterials_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueOnMaterials_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureParameterValueOnMaterials_ParameterValue_PropertyAddress, SetTextureParameterValueOnMaterials_FunctionAddress, "ParameterValue");
		SetTextureParameterValueOnMaterials_ParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureParameterValueOnMaterials_FunctionAddress, "ParameterValue");
		SetTextureParameterValueOnMaterials_ParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureParameterValueOnMaterials_FunctionAddress, "ParameterValue", Classes.FObjectProperty);
		SetTextureParameterValueOnMaterials_IsValid = SetTextureParameterValueOnMaterials_FunctionAddress != IntPtr.Zero && SetTextureParameterValueOnMaterials_MeshComp_IsValid && SetTextureParameterValueOnMaterials_ParameterName_IsValid && SetTextureParameterValueOnMaterials_ParameterValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetTextureParameterValueOnMaterials", SetTextureParameterValueOnMaterials_IsValid);
		SetBodyInstanceShapeCollisionEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBodyInstanceShapeCollisionEnable");
		SetBodyInstanceShapeCollisionEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBodyInstanceShapeCollisionEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceShapeCollisionEnable_SKMeshComp_PropertyAddress, SetBodyInstanceShapeCollisionEnable_FunctionAddress, "SKMeshComp");
		SetBodyInstanceShapeCollisionEnable_SKMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "SKMeshComp");
		SetBodyInstanceShapeCollisionEnable_SKMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "SKMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceShapeCollisionEnable_BoneName_PropertyAddress, SetBodyInstanceShapeCollisionEnable_FunctionAddress, "BoneName");
		SetBodyInstanceShapeCollisionEnable_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "BoneName");
		SetBodyInstanceShapeCollisionEnable_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceShapeCollisionEnable_ShapeIndex_PropertyAddress, SetBodyInstanceShapeCollisionEnable_FunctionAddress, "ShapeIndex");
		SetBodyInstanceShapeCollisionEnable_ShapeIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "ShapeIndex");
		SetBodyInstanceShapeCollisionEnable_ShapeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "ShapeIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceShapeCollisionEnable_NewType_PropertyAddress, SetBodyInstanceShapeCollisionEnable_FunctionAddress, "NewType");
		SetBodyInstanceShapeCollisionEnable_NewType_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "NewType");
		SetBodyInstanceShapeCollisionEnable_NewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "NewType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_PropertyAddress, SetBodyInstanceShapeCollisionEnable_FunctionAddress, "bUpdatePhysicsFilterData");
		SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "bUpdatePhysicsFilterData");
		SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "bUpdatePhysicsFilterData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceShapeCollisionEnable_bGetWelded_PropertyAddress, SetBodyInstanceShapeCollisionEnable_FunctionAddress, "bGetWelded");
		SetBodyInstanceShapeCollisionEnable_bGetWelded_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "bGetWelded");
		SetBodyInstanceShapeCollisionEnable_bGetWelded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceShapeCollisionEnable_FunctionAddress, "bGetWelded", Classes.FBoolProperty);
		SetBodyInstanceShapeCollisionEnable_IsValid = SetBodyInstanceShapeCollisionEnable_FunctionAddress != IntPtr.Zero && SetBodyInstanceShapeCollisionEnable_SKMeshComp_IsValid && SetBodyInstanceShapeCollisionEnable_BoneName_IsValid && SetBodyInstanceShapeCollisionEnable_ShapeIndex_IsValid && SetBodyInstanceShapeCollisionEnable_NewType_IsValid && SetBodyInstanceShapeCollisionEnable_bUpdatePhysicsFilterData_IsValid && SetBodyInstanceShapeCollisionEnable_bGetWelded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceShapeCollisionEnable", SetBodyInstanceShapeCollisionEnable_IsValid);
		SetBodyInstanceCollisionProfileName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBodyInstanceCollisionProfileName");
		SetBodyInstanceCollisionProfileName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBodyInstanceCollisionProfileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionProfileName_SKMeshComp_PropertyAddress, SetBodyInstanceCollisionProfileName_FunctionAddress, "SKMeshComp");
		SetBodyInstanceCollisionProfileName_SKMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionProfileName_FunctionAddress, "SKMeshComp");
		SetBodyInstanceCollisionProfileName_SKMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionProfileName_FunctionAddress, "SKMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionProfileName_BoneName_PropertyAddress, SetBodyInstanceCollisionProfileName_FunctionAddress, "BoneName");
		SetBodyInstanceCollisionProfileName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionProfileName_FunctionAddress, "BoneName");
		SetBodyInstanceCollisionProfileName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionProfileName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionProfileName_InCollisionProfileName_PropertyAddress, SetBodyInstanceCollisionProfileName_FunctionAddress, "InCollisionProfileName");
		SetBodyInstanceCollisionProfileName_InCollisionProfileName_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionProfileName_FunctionAddress, "InCollisionProfileName");
		SetBodyInstanceCollisionProfileName_InCollisionProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionProfileName_FunctionAddress, "InCollisionProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionProfileName_bGetWelded_PropertyAddress, SetBodyInstanceCollisionProfileName_FunctionAddress, "bGetWelded");
		SetBodyInstanceCollisionProfileName_bGetWelded_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionProfileName_FunctionAddress, "bGetWelded");
		SetBodyInstanceCollisionProfileName_bGetWelded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionProfileName_FunctionAddress, "bGetWelded", Classes.FBoolProperty);
		SetBodyInstanceCollisionProfileName_IsValid = SetBodyInstanceCollisionProfileName_FunctionAddress != IntPtr.Zero && SetBodyInstanceCollisionProfileName_SKMeshComp_IsValid && SetBodyInstanceCollisionProfileName_BoneName_IsValid && SetBodyInstanceCollisionProfileName_InCollisionProfileName_IsValid && SetBodyInstanceCollisionProfileName_bGetWelded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceCollisionProfileName", SetBodyInstanceCollisionProfileName_IsValid);
		SetBodyInstanceCollisionEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBodyInstanceCollisionEnable");
		SetBodyInstanceCollisionEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBodyInstanceCollisionEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionEnable_SKMeshComp_PropertyAddress, SetBodyInstanceCollisionEnable_FunctionAddress, "SKMeshComp");
		SetBodyInstanceCollisionEnable_SKMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionEnable_FunctionAddress, "SKMeshComp");
		SetBodyInstanceCollisionEnable_SKMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionEnable_FunctionAddress, "SKMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionEnable_BoneName_PropertyAddress, SetBodyInstanceCollisionEnable_FunctionAddress, "BoneName");
		SetBodyInstanceCollisionEnable_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionEnable_FunctionAddress, "BoneName");
		SetBodyInstanceCollisionEnable_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionEnable_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionEnable_NewType_PropertyAddress, SetBodyInstanceCollisionEnable_FunctionAddress, "NewType");
		SetBodyInstanceCollisionEnable_NewType_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionEnable_FunctionAddress, "NewType");
		SetBodyInstanceCollisionEnable_NewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionEnable_FunctionAddress, "NewType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_PropertyAddress, SetBodyInstanceCollisionEnable_FunctionAddress, "bUpdatePhysicsFilterData");
		SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionEnable_FunctionAddress, "bUpdatePhysicsFilterData");
		SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionEnable_FunctionAddress, "bUpdatePhysicsFilterData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceCollisionEnable_bGetWelded_PropertyAddress, SetBodyInstanceCollisionEnable_FunctionAddress, "bGetWelded");
		SetBodyInstanceCollisionEnable_bGetWelded_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceCollisionEnable_FunctionAddress, "bGetWelded");
		SetBodyInstanceCollisionEnable_bGetWelded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceCollisionEnable_FunctionAddress, "bGetWelded", Classes.FBoolProperty);
		SetBodyInstanceCollisionEnable_IsValid = SetBodyInstanceCollisionEnable_FunctionAddress != IntPtr.Zero && SetBodyInstanceCollisionEnable_SKMeshComp_IsValid && SetBodyInstanceCollisionEnable_BoneName_IsValid && SetBodyInstanceCollisionEnable_NewType_IsValid && SetBodyInstanceCollisionEnable_bUpdatePhysicsFilterData_IsValid && SetBodyInstanceCollisionEnable_bGetWelded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceCollisionEnable", SetBodyInstanceCollisionEnable_IsValid);
		SetBodyInstanceAutoWeld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBodyInstanceAutoWeld");
		SetBodyInstanceAutoWeld_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBodyInstanceAutoWeld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceAutoWeld_SKMeshComp_PropertyAddress, SetBodyInstanceAutoWeld_FunctionAddress, "SKMeshComp");
		SetBodyInstanceAutoWeld_SKMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceAutoWeld_FunctionAddress, "SKMeshComp");
		SetBodyInstanceAutoWeld_SKMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceAutoWeld_FunctionAddress, "SKMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceAutoWeld_BoneName_PropertyAddress, SetBodyInstanceAutoWeld_FunctionAddress, "BoneName");
		SetBodyInstanceAutoWeld_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceAutoWeld_FunctionAddress, "BoneName");
		SetBodyInstanceAutoWeld_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceAutoWeld_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceAutoWeld_bAutoWeld_PropertyAddress, SetBodyInstanceAutoWeld_FunctionAddress, "bAutoWeld");
		SetBodyInstanceAutoWeld_bAutoWeld_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceAutoWeld_FunctionAddress, "bAutoWeld");
		SetBodyInstanceAutoWeld_bAutoWeld_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceAutoWeld_FunctionAddress, "bAutoWeld", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyInstanceAutoWeld_bGetWelded_PropertyAddress, SetBodyInstanceAutoWeld_FunctionAddress, "bGetWelded");
		SetBodyInstanceAutoWeld_bGetWelded_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyInstanceAutoWeld_FunctionAddress, "bGetWelded");
		SetBodyInstanceAutoWeld_bGetWelded_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyInstanceAutoWeld_FunctionAddress, "bGetWelded", Classes.FBoolProperty);
		SetBodyInstanceAutoWeld_IsValid = SetBodyInstanceAutoWeld_FunctionAddress != IntPtr.Zero && SetBodyInstanceAutoWeld_SKMeshComp_IsValid && SetBodyInstanceAutoWeld_BoneName_IsValid && SetBodyInstanceAutoWeld_bAutoWeld_IsValid && SetBodyInstanceAutoWeld_bGetWelded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetBodyInstanceAutoWeld", SetBodyInstanceAutoWeld_IsValid);
		SetAllBodiesShapeCollisionEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAllBodiesShapeCollisionEnabled");
		SetAllBodiesShapeCollisionEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllBodiesShapeCollisionEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesShapeCollisionEnabled_SKComp_PropertyAddress, SetAllBodiesShapeCollisionEnabled_FunctionAddress, "SKComp");
		SetAllBodiesShapeCollisionEnabled_SKComp_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesShapeCollisionEnabled_FunctionAddress, "SKComp");
		SetAllBodiesShapeCollisionEnabled_SKComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesShapeCollisionEnabled_FunctionAddress, "SKComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesShapeCollisionEnabled_Type_PropertyAddress, SetAllBodiesShapeCollisionEnabled_FunctionAddress, "Type");
		SetAllBodiesShapeCollisionEnabled_Type_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesShapeCollisionEnabled_FunctionAddress, "Type");
		SetAllBodiesShapeCollisionEnabled_Type_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesShapeCollisionEnabled_FunctionAddress, "Type", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_PropertyAddress, SetAllBodiesShapeCollisionEnabled_FunctionAddress, "bUpdateFilterData");
		SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesShapeCollisionEnabled_FunctionAddress, "bUpdateFilterData");
		SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesShapeCollisionEnabled_FunctionAddress, "bUpdateFilterData", Classes.FBoolProperty);
		SetAllBodiesShapeCollisionEnabled_IsValid = SetAllBodiesShapeCollisionEnabled_FunctionAddress != IntPtr.Zero && SetAllBodiesShapeCollisionEnabled_SKComp_IsValid && SetAllBodiesShapeCollisionEnabled_Type_IsValid && SetAllBodiesShapeCollisionEnabled_bUpdateFilterData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:SetAllBodiesShapeCollisionEnabled", SetAllBodiesShapeCollisionEnabled_IsValid);
		RemoveLoDs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveLoDs");
		RemoveLoDs_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveLoDs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveLoDs_SkeletalMesh_PropertyAddress, RemoveLoDs_FunctionAddress, "SkeletalMesh");
		RemoveLoDs_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLoDs_FunctionAddress, "SkeletalMesh");
		RemoveLoDs_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLoDs_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLoDs_ToRemoveLODs_PropertyAddress, RemoveLoDs_FunctionAddress, "ToRemoveLODs");
		RemoveLoDs_ToRemoveLODs_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLoDs_FunctionAddress, "ToRemoveLODs");
		RemoveLoDs_ToRemoveLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLoDs_FunctionAddress, "ToRemoveLODs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLoDs_ReturnValue_PropertyAddress, RemoveLoDs_FunctionAddress, "ReturnValue");
		RemoveLoDs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLoDs_FunctionAddress, "ReturnValue");
		RemoveLoDs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLoDs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveLoDs_IsValid = RemoveLoDs_FunctionAddress != IntPtr.Zero && RemoveLoDs_SkeletalMesh_IsValid && RemoveLoDs_ToRemoveLODs_IsValid && RemoveLoDs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:RemoveLoDs", RemoveLoDs_IsValid);
		IsCPUAccess_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCPUAccess");
		IsCPUAccess_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCPUAccess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCPUAccess_SKMesh_PropertyAddress, IsCPUAccess_FunctionAddress, "SKMesh");
		IsCPUAccess_SKMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsCPUAccess_FunctionAddress, "SKMesh");
		IsCPUAccess_SKMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCPUAccess_FunctionAddress, "SKMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCPUAccess_ReturnValue_PropertyAddress, IsCPUAccess_FunctionAddress, "ReturnValue");
		IsCPUAccess_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCPUAccess_FunctionAddress, "ReturnValue");
		IsCPUAccess_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCPUAccess_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCPUAccess_IsValid = IsCPUAccess_FunctionAddress != IntPtr.Zero && IsCPUAccess_SKMesh_IsValid && IsCPUAccess_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:IsCPUAccess", IsCPUAccess_IsValid);
		GS_SetEndPhysicsTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GS_SetEndPhysicsTickEnabled");
		GS_SetEndPhysicsTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GS_SetEndPhysicsTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GS_SetEndPhysicsTickEnabled_SKComp_PropertyAddress, GS_SetEndPhysicsTickEnabled_FunctionAddress, "SKComp");
		GS_SetEndPhysicsTickEnabled_SKComp_Offset = NativeReflectionCached.GetPropertyOffset(GS_SetEndPhysicsTickEnabled_FunctionAddress, "SKComp");
		GS_SetEndPhysicsTickEnabled_SKComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GS_SetEndPhysicsTickEnabled_FunctionAddress, "SKComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GS_SetEndPhysicsTickEnabled_bVal_PropertyAddress, GS_SetEndPhysicsTickEnabled_FunctionAddress, "bVal");
		GS_SetEndPhysicsTickEnabled_bVal_Offset = NativeReflectionCached.GetPropertyOffset(GS_SetEndPhysicsTickEnabled_FunctionAddress, "bVal");
		GS_SetEndPhysicsTickEnabled_bVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GS_SetEndPhysicsTickEnabled_FunctionAddress, "bVal", Classes.FBoolProperty);
		GS_SetEndPhysicsTickEnabled_IsValid = GS_SetEndPhysicsTickEnabled_FunctionAddress != IntPtr.Zero && GS_SetEndPhysicsTickEnabled_SKComp_IsValid && GS_SetEndPhysicsTickEnabled_bVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GS_SetEndPhysicsTickEnabled", GS_SetEndPhysicsTickEnabled_IsValid);
		GetUROResult_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUROResult");
		GetUROResult_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUROResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUROResult_OwnerActor_PropertyAddress, GetUROResult_FunctionAddress, "OwnerActor");
		GetUROResult_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(GetUROResult_FunctionAddress, "OwnerActor");
		GetUROResult_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUROResult_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUROResult_OutAccumulatedDeltaTime_PropertyAddress, GetUROResult_FunctionAddress, "OutAccumulatedDeltaTime");
		GetUROResult_OutAccumulatedDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(GetUROResult_FunctionAddress, "OutAccumulatedDeltaTime");
		GetUROResult_OutAccumulatedDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUROResult_FunctionAddress, "OutAccumulatedDeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUROResult_ReturnValue_PropertyAddress, GetUROResult_FunctionAddress, "ReturnValue");
		GetUROResult_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUROResult_FunctionAddress, "ReturnValue");
		GetUROResult_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUROResult_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetUROResult_IsValid = GetUROResult_FunctionAddress != IntPtr.Zero && GetUROResult_OwnerActor_IsValid && GetUROResult_OutAccumulatedDeltaTime_IsValid && GetUROResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetUROResult", GetUROResult_IsValid);
		GetRefPoseTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRefPoseTransform");
		GetRefPoseTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRefPoseTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseTransform_MeshComp_PropertyAddress, GetRefPoseTransform_FunctionAddress, "MeshComp");
		GetRefPoseTransform_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseTransform_FunctionAddress, "MeshComp");
		GetRefPoseTransform_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseTransform_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseTransform_BoneIndex_PropertyAddress, GetRefPoseTransform_FunctionAddress, "BoneIndex");
		GetRefPoseTransform_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseTransform_FunctionAddress, "BoneIndex");
		GetRefPoseTransform_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseTransform_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseTransform_bIsLocal_PropertyAddress, GetRefPoseTransform_FunctionAddress, "bIsLocal");
		GetRefPoseTransform_bIsLocal_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseTransform_FunctionAddress, "bIsLocal");
		GetRefPoseTransform_bIsLocal_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseTransform_FunctionAddress, "bIsLocal", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRefPoseTransform_ReturnValue_PropertyAddress, GetRefPoseTransform_FunctionAddress, "ReturnValue");
		GetRefPoseTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRefPoseTransform_FunctionAddress, "ReturnValue");
		GetRefPoseTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRefPoseTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRefPoseTransform_IsValid = GetRefPoseTransform_FunctionAddress != IntPtr.Zero && GetRefPoseTransform_MeshComp_IsValid && GetRefPoseTransform_BoneIndex_IsValid && GetRefPoseTransform_bIsLocal_IsValid && GetRefPoseTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetRefPoseTransform", GetRefPoseTransform_IsValid);
		GetNumOverrideMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumOverrideMaterials");
		GetNumOverrideMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumOverrideMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumOverrideMaterials_SKComp_PropertyAddress, GetNumOverrideMaterials_FunctionAddress, "SKComp");
		GetNumOverrideMaterials_SKComp_Offset = NativeReflectionCached.GetPropertyOffset(GetNumOverrideMaterials_FunctionAddress, "SKComp");
		GetNumOverrideMaterials_SKComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumOverrideMaterials_FunctionAddress, "SKComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumOverrideMaterials_ReturnValue_PropertyAddress, GetNumOverrideMaterials_FunctionAddress, "ReturnValue");
		GetNumOverrideMaterials_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumOverrideMaterials_FunctionAddress, "ReturnValue");
		GetNumOverrideMaterials_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumOverrideMaterials_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumOverrideMaterials_IsValid = GetNumOverrideMaterials_FunctionAddress != IntPtr.Zero && GetNumOverrideMaterials_SKComp_IsValid && GetNumOverrideMaterials_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetNumOverrideMaterials", GetNumOverrideMaterials_IsValid);
		GetLODSettingsGroupNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLODSettingsGroupNum");
		GetLODSettingsGroupNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLODSettingsGroupNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLODSettingsGroupNum_LodSettings_PropertyAddress, GetLODSettingsGroupNum_FunctionAddress, "LodSettings");
		GetLODSettingsGroupNum_LodSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetLODSettingsGroupNum_FunctionAddress, "LodSettings");
		GetLODSettingsGroupNum_LodSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODSettingsGroupNum_FunctionAddress, "LodSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLODSettingsGroupNum_ReturnValue_PropertyAddress, GetLODSettingsGroupNum_FunctionAddress, "ReturnValue");
		GetLODSettingsGroupNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLODSettingsGroupNum_FunctionAddress, "ReturnValue");
		GetLODSettingsGroupNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLODSettingsGroupNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLODSettingsGroupNum_IsValid = GetLODSettingsGroupNum_FunctionAddress != IntPtr.Zero && GetLODSettingsGroupNum_LodSettings_IsValid && GetLODSettingsGroupNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetLODSettingsGroupNum", GetLODSettingsGroupNum_IsValid);
		GetBodyInstanceShapeCollisionEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBodyInstanceShapeCollisionEnable");
		GetBodyInstanceShapeCollisionEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBodyInstanceShapeCollisionEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceShapeCollisionEnable_SKMeshComp_PropertyAddress, GetBodyInstanceShapeCollisionEnable_FunctionAddress, "SKMeshComp");
		GetBodyInstanceShapeCollisionEnable_SKMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "SKMeshComp");
		GetBodyInstanceShapeCollisionEnable_SKMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "SKMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceShapeCollisionEnable_BoneName_PropertyAddress, GetBodyInstanceShapeCollisionEnable_FunctionAddress, "BoneName");
		GetBodyInstanceShapeCollisionEnable_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "BoneName");
		GetBodyInstanceShapeCollisionEnable_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceShapeCollisionEnable_ShapeIndex_PropertyAddress, GetBodyInstanceShapeCollisionEnable_FunctionAddress, "ShapeIndex");
		GetBodyInstanceShapeCollisionEnable_ShapeIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "ShapeIndex");
		GetBodyInstanceShapeCollisionEnable_ShapeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "ShapeIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceShapeCollisionEnable_bGetWelded_PropertyAddress, GetBodyInstanceShapeCollisionEnable_FunctionAddress, "bGetWelded");
		GetBodyInstanceShapeCollisionEnable_bGetWelded_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "bGetWelded");
		GetBodyInstanceShapeCollisionEnable_bGetWelded_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "bGetWelded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceShapeCollisionEnable_ReturnValue_PropertyAddress, GetBodyInstanceShapeCollisionEnable_FunctionAddress, "ReturnValue");
		GetBodyInstanceShapeCollisionEnable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "ReturnValue");
		GetBodyInstanceShapeCollisionEnable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceShapeCollisionEnable_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetBodyInstanceShapeCollisionEnable_IsValid = GetBodyInstanceShapeCollisionEnable_FunctionAddress != IntPtr.Zero && GetBodyInstanceShapeCollisionEnable_SKMeshComp_IsValid && GetBodyInstanceShapeCollisionEnable_BoneName_IsValid && GetBodyInstanceShapeCollisionEnable_ShapeIndex_IsValid && GetBodyInstanceShapeCollisionEnable_bGetWelded_IsValid && GetBodyInstanceShapeCollisionEnable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetBodyInstanceShapeCollisionEnable", GetBodyInstanceShapeCollisionEnable_IsValid);
		GetBodyInstanceCollisionProfileName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBodyInstanceCollisionProfileName");
		GetBodyInstanceCollisionProfileName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBodyInstanceCollisionProfileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceCollisionProfileName_SKMeshComp_PropertyAddress, GetBodyInstanceCollisionProfileName_FunctionAddress, "SKMeshComp");
		GetBodyInstanceCollisionProfileName_SKMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceCollisionProfileName_FunctionAddress, "SKMeshComp");
		GetBodyInstanceCollisionProfileName_SKMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceCollisionProfileName_FunctionAddress, "SKMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceCollisionProfileName_BoneName_PropertyAddress, GetBodyInstanceCollisionProfileName_FunctionAddress, "BoneName");
		GetBodyInstanceCollisionProfileName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceCollisionProfileName_FunctionAddress, "BoneName");
		GetBodyInstanceCollisionProfileName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceCollisionProfileName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceCollisionProfileName_bGetWelded_PropertyAddress, GetBodyInstanceCollisionProfileName_FunctionAddress, "bGetWelded");
		GetBodyInstanceCollisionProfileName_bGetWelded_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceCollisionProfileName_FunctionAddress, "bGetWelded");
		GetBodyInstanceCollisionProfileName_bGetWelded_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceCollisionProfileName_FunctionAddress, "bGetWelded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBodyInstanceCollisionProfileName_ReturnValue_PropertyAddress, GetBodyInstanceCollisionProfileName_FunctionAddress, "ReturnValue");
		GetBodyInstanceCollisionProfileName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBodyInstanceCollisionProfileName_FunctionAddress, "ReturnValue");
		GetBodyInstanceCollisionProfileName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBodyInstanceCollisionProfileName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetBodyInstanceCollisionProfileName_IsValid = GetBodyInstanceCollisionProfileName_FunctionAddress != IntPtr.Zero && GetBodyInstanceCollisionProfileName_SKMeshComp_IsValid && GetBodyInstanceCollisionProfileName_BoneName_IsValid && GetBodyInstanceCollisionProfileName_bGetWelded_IsValid && GetBodyInstanceCollisionProfileName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:GetBodyInstanceCollisionProfileName", GetBodyInstanceCollisionProfileName_IsValid);
		BakeSkinInfoToUVs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BakeSkinInfoToUVs");
		BakeSkinInfoToUVs_ParamsSize = NativeReflection.GetFunctionParamsSize(BakeSkinInfoToUVs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BakeSkinInfoToUVs_TargetSkeletalMesh_PropertyAddress, BakeSkinInfoToUVs_FunctionAddress, "TargetSkeletalMesh");
		BakeSkinInfoToUVs_TargetSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(BakeSkinInfoToUVs_FunctionAddress, "TargetSkeletalMesh");
		BakeSkinInfoToUVs_TargetSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BakeSkinInfoToUVs_FunctionAddress, "TargetSkeletalMesh", Classes.FObjectProperty);
		BakeSkinInfoToUVs_IsValid = BakeSkinInfoToUVs_FunctionAddress != IntPtr.Zero && BakeSkinInfoToUVs_TargetSkeletalMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SkeletalMeshFuncLib:BakeSkinInfoToUVs", BakeSkinInfoToUVs_IsValid);
	}
}
