using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Plugins.ProceduralMeshComponent;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_StaticMeshFunLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetStaticMeshActorVisibility_IsValid;

	private static IntPtr SetStaticMeshActorVisibility_FunctionAddress;

	private static int SetStaticMeshActorVisibility_ParamsSize;

	private static bool SetStaticMeshActorVisibility_TargetActor_IsValid;

	private static FFieldAddress SetStaticMeshActorVisibility_TargetActor_PropertyAddress;

	private static int SetStaticMeshActorVisibility_TargetActor_Offset;

	private static bool SetStaticMeshActorVisibility_visible_IsValid;

	private static FFieldAddress SetStaticMeshActorVisibility_visible_PropertyAddress;

	private static int SetStaticMeshActorVisibility_visible_Offset;

	private static bool SetStaticMeshActorVisibility_recurseToChildActor_IsValid;

	private static FFieldAddress SetStaticMeshActorVisibility_recurseToChildActor_PropertyAddress;

	private static int SetStaticMeshActorVisibility_recurseToChildActor_Offset;

	private static bool SetLinearColorParameterValueOnMaterials_IsValid;

	private static IntPtr SetLinearColorParameterValueOnMaterials_FunctionAddress;

	private static int SetLinearColorParameterValueOnMaterials_ParamsSize;

	private static bool SetLinearColorParameterValueOnMaterials_MeshComp_IsValid;

	private static FFieldAddress SetLinearColorParameterValueOnMaterials_MeshComp_PropertyAddress;

	private static int SetLinearColorParameterValueOnMaterials_MeshComp_Offset;

	private static bool SetLinearColorParameterValueOnMaterials_ParamName_IsValid;

	private static FFieldAddress SetLinearColorParameterValueOnMaterials_ParamName_PropertyAddress;

	private static int SetLinearColorParameterValueOnMaterials_ParamName_Offset;

	private static bool SetLinearColorParameterValueOnMaterials_ParamValue_IsValid;

	private static FFieldAddress SetLinearColorParameterValueOnMaterials_ParamValue_PropertyAddress;

	private static int SetLinearColorParameterValueOnMaterials_ParamValue_Offset;

	private static bool SetConvexCollisionToStaticMesh_IsValid;

	private static IntPtr SetConvexCollisionToStaticMesh_FunctionAddress;

	private static int SetConvexCollisionToStaticMesh_ParamsSize;

	private static bool SetConvexCollisionToStaticMesh_TargetStaticMesh_IsValid;

	private static FFieldAddress SetConvexCollisionToStaticMesh_TargetStaticMesh_PropertyAddress;

	private static int SetConvexCollisionToStaticMesh_TargetStaticMesh_Offset;

	private static bool SetConvexCollisionToStaticMesh_HullCount_IsValid;

	private static FFieldAddress SetConvexCollisionToStaticMesh_HullCount_PropertyAddress;

	private static int SetConvexCollisionToStaticMesh_HullCount_Offset;

	private static bool SetConvexCollisionToStaticMesh_MaxHullVerts_IsValid;

	private static FFieldAddress SetConvexCollisionToStaticMesh_MaxHullVerts_PropertyAddress;

	private static int SetConvexCollisionToStaticMesh_MaxHullVerts_Offset;

	private static bool SetConvexCollisionToStaticMesh_HullPrecision_IsValid;

	private static FFieldAddress SetConvexCollisionToStaticMesh_HullPrecision_PropertyAddress;

	private static int SetConvexCollisionToStaticMesh_HullPrecision_Offset;

	private static bool SetConvexCollisionToStaticMesh_ReturnValue_IsValid;

	private static FFieldAddress SetConvexCollisionToStaticMesh_ReturnValue_PropertyAddress;

	private static int SetConvexCollisionToStaticMesh_ReturnValue_Offset;

	private static bool SetCollisionPresetForStaticMeshAsset_IsValid;

	private static IntPtr SetCollisionPresetForStaticMeshAsset_FunctionAddress;

	private static int SetCollisionPresetForStaticMeshAsset_ParamsSize;

	private static bool SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_IsValid;

	private static FFieldAddress SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_PropertyAddress;

	private static int SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_Offset;

	private static bool SetCollisionPresetForStaticMeshAsset_CollisionProfileName_IsValid;

	private static FFieldAddress SetCollisionPresetForStaticMeshAsset_CollisionProfileName_PropertyAddress;

	private static int SetCollisionPresetForStaticMeshAsset_CollisionProfileName_Offset;

	private static bool SetCollisionPresetForStaticMeshAsset_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionPresetForStaticMeshAsset_ReturnValue_PropertyAddress;

	private static int SetCollisionPresetForStaticMeshAsset_ReturnValue_Offset;

	private static bool SetCollisionForBodyInstance_IsValid;

	private static IntPtr SetCollisionForBodyInstance_FunctionAddress;

	private static int SetCollisionForBodyInstance_ParamsSize;

	private static bool SetCollisionForBodyInstance_InstancedStaticMesh_IsValid;

	private static FFieldAddress SetCollisionForBodyInstance_InstancedStaticMesh_PropertyAddress;

	private static int SetCollisionForBodyInstance_InstancedStaticMesh_Offset;

	private static bool SetCollisionForBodyInstance_nIndex_IsValid;

	private static FFieldAddress SetCollisionForBodyInstance_nIndex_PropertyAddress;

	private static int SetCollisionForBodyInstance_nIndex_Offset;

	private static bool SetCollisionForBodyInstance_bEnableCollision_IsValid;

	private static FFieldAddress SetCollisionForBodyInstance_bEnableCollision_PropertyAddress;

	private static int SetCollisionForBodyInstance_bEnableCollision_Offset;

	private static bool SetCollisionForBodyInstance_CollisionProfileName_IsValid;

	private static FFieldAddress SetCollisionForBodyInstance_CollisionProfileName_PropertyAddress;

	private static int SetCollisionForBodyInstance_CollisionProfileName_Offset;

	private static bool SetCollisionForBodyInstance_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionForBodyInstance_ReturnValue_PropertyAddress;

	private static int SetCollisionForBodyInstance_ReturnValue_Offset;

	private static bool SetCollisionEnableForStaticMeshAsset_IsValid;

	private static IntPtr SetCollisionEnableForStaticMeshAsset_FunctionAddress;

	private static int SetCollisionEnableForStaticMeshAsset_ParamsSize;

	private static bool SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_IsValid;

	private static FFieldAddress SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_PropertyAddress;

	private static int SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_Offset;

	private static bool SetCollisionEnableForStaticMeshAsset_CollisionEnabled_IsValid;

	private static FFieldAddress SetCollisionEnableForStaticMeshAsset_CollisionEnabled_PropertyAddress;

	private static int SetCollisionEnableForStaticMeshAsset_CollisionEnabled_Offset;

	private static bool SetCollisionEnableForStaticMeshAsset_ReturnValue_IsValid;

	private static FFieldAddress SetCollisionEnableForStaticMeshAsset_ReturnValue_PropertyAddress;

	private static int SetCollisionEnableForStaticMeshAsset_ReturnValue_Offset;

	private static bool SetCollisionComplexity_IsValid;

	private static IntPtr SetCollisionComplexity_FunctionAddress;

	private static int SetCollisionComplexity_ParamsSize;

	private static bool SetCollisionComplexity_TargetStaticMesh_IsValid;

	private static FFieldAddress SetCollisionComplexity_TargetStaticMesh_PropertyAddress;

	private static int SetCollisionComplexity_TargetStaticMesh_Offset;

	private static bool SetCollisionComplexity__CollisionTraceFlag_IsValid;

	private static FFieldAddress SetCollisionComplexity__CollisionTraceFlag_PropertyAddress;

	private static int SetCollisionComplexity__CollisionTraceFlag_Offset;

	private static bool SaveRawMesh_IsValid;

	private static IntPtr SaveRawMesh_FunctionAddress;

	private static int SaveRawMesh_ParamsSize;

	private static bool SaveRawMesh_TargetStaticMesh_IsValid;

	private static FFieldAddress SaveRawMesh_TargetStaticMesh_PropertyAddress;

	private static int SaveRawMesh_TargetStaticMesh_Offset;

	private static bool SaveRawMesh_WedgeIndices_IsValid;

	private static FFieldAddress SaveRawMesh_WedgeIndices_PropertyAddress;

	private static int SaveRawMesh_WedgeIndices_Offset;

	private static bool SaveRawMesh_VertexPositions_IsValid;

	private static FFieldAddress SaveRawMesh_VertexPositions_PropertyAddress;

	private static int SaveRawMesh_VertexPositions_Offset;

	private static bool RunMerge_IsValid;

	private static IntPtr RunMerge_FunctionAddress;

	private static int RunMerge_ParamsSize;

	private static bool RunMerge_PackageName_IsValid;

	private static FFieldAddress RunMerge_PackageName_PropertyAddress;

	private static int RunMerge_PackageName_Offset;

	private static bool RunMerge_SelectedComponents_IsValid;

	private static FFieldAddress RunMerge_SelectedComponents_PropertyAddress;

	private static int RunMerge_SelectedComponents_Offset;

	private static bool RunMerge_Settings_IsValid;

	private static FFieldAddress RunMerge_Settings_PropertyAddress;

	private static int RunMerge_Settings_Offset;

	private static bool RunMerge_bReplaceSourceActors_IsValid;

	private static FFieldAddress RunMerge_bReplaceSourceActors_PropertyAddress;

	private static int RunMerge_bReplaceSourceActors_Offset;

	private static bool RunMerge_ReturnValue_IsValid;

	private static FFieldAddress RunMerge_ReturnValue_PropertyAddress;

	private static int RunMerge_ReturnValue_Offset;

	private static bool IsCPUAccess_IsValid;

	private static IntPtr IsCPUAccess_FunctionAddress;

	private static int IsCPUAccess_ParamsSize;

	private static bool IsCPUAccess_StaticMesh_IsValid;

	private static FFieldAddress IsCPUAccess_StaticMesh_PropertyAddress;

	private static int IsCPUAccess_StaticMesh_Offset;

	private static bool IsCPUAccess_ReturnValue_IsValid;

	private static FFieldAddress IsCPUAccess_ReturnValue_PropertyAddress;

	private static int IsCPUAccess_ReturnValue_Offset;

	private static bool GetStaticMeshMaterialNum_IsValid;

	private static IntPtr GetStaticMeshMaterialNum_FunctionAddress;

	private static int GetStaticMeshMaterialNum_ParamsSize;

	private static bool GetStaticMeshMaterialNum_TargetStaticMesh_IsValid;

	private static FFieldAddress GetStaticMeshMaterialNum_TargetStaticMesh_PropertyAddress;

	private static int GetStaticMeshMaterialNum_TargetStaticMesh_Offset;

	private static bool GetStaticMeshMaterialNum_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshMaterialNum_ReturnValue_PropertyAddress;

	private static int GetStaticMeshMaterialNum_ReturnValue_Offset;

	private static bool GetPreInstanceCustomData_IsValid;

	private static IntPtr GetPreInstanceCustomData_FunctionAddress;

	private static int GetPreInstanceCustomData_ParamsSize;

	private static bool GetPreInstanceCustomData_InstancedStaticMesh_IsValid;

	private static FFieldAddress GetPreInstanceCustomData_InstancedStaticMesh_PropertyAddress;

	private static int GetPreInstanceCustomData_InstancedStaticMesh_Offset;

	private static bool GetPreInstanceCustomData_ReturnValue_IsValid;

	private static FFieldAddress GetPreInstanceCustomData_ReturnValue_PropertyAddress;

	private static int GetPreInstanceCustomData_ReturnValue_Offset;

	private static bool GetMeshVertexMap_IsValid;

	private static IntPtr GetMeshVertexMap_FunctionAddress;

	private static int GetMeshVertexMap_ParamsSize;

	private static bool GetMeshVertexMap_TargetStaticMesh_IsValid;

	private static FFieldAddress GetMeshVertexMap_TargetStaticMesh_PropertyAddress;

	private static int GetMeshVertexMap_TargetStaticMesh_Offset;

	private static bool GetMeshVertexMap_WedgeIndices_IsValid;

	private static FFieldAddress GetMeshVertexMap_WedgeIndices_PropertyAddress;

	private static int GetMeshVertexMap_WedgeIndices_Offset;

	private static bool GetMeshVertexMap_VertexPositions_IsValid;

	private static FFieldAddress GetMeshVertexMap_VertexPositions_PropertyAddress;

	private static int GetMeshVertexMap_VertexPositions_Offset;

	private static bool GetCustomPrimitiveData_IsValid;

	private static IntPtr GetCustomPrimitiveData_FunctionAddress;

	private static int GetCustomPrimitiveData_ParamsSize;

	private static bool GetCustomPrimitiveData_StaticMeshComponent_IsValid;

	private static FFieldAddress GetCustomPrimitiveData_StaticMeshComponent_PropertyAddress;

	private static int GetCustomPrimitiveData_StaticMeshComponent_Offset;

	private static bool GetCustomPrimitiveData_ReturnValue_IsValid;

	private static FFieldAddress GetCustomPrimitiveData_ReturnValue_PropertyAddress;

	private static int GetCustomPrimitiveData_ReturnValue_Offset;

	private static bool GetCollisionPremitiveNumbers_IsValid;

	private static IntPtr GetCollisionPremitiveNumbers_FunctionAddress;

	private static int GetCollisionPremitiveNumbers_ParamsSize;

	private static bool GetCollisionPremitiveNumbers_TargetStaticMesh_IsValid;

	private static FFieldAddress GetCollisionPremitiveNumbers_TargetStaticMesh_PropertyAddress;

	private static int GetCollisionPremitiveNumbers_TargetStaticMesh_Offset;

	private static bool GetCollisionPremitiveNumbers_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionPremitiveNumbers_ReturnValue_PropertyAddress;

	private static int GetCollisionPremitiveNumbers_ReturnValue_Offset;

	private static bool GetCollisionComplexity_IsValid;

	private static IntPtr GetCollisionComplexity_FunctionAddress;

	private static int GetCollisionComplexity_ParamsSize;

	private static bool GetCollisionComplexity_TargetStaticMesh_IsValid;

	private static FFieldAddress GetCollisionComplexity_TargetStaticMesh_PropertyAddress;

	private static int GetCollisionComplexity_TargetStaticMesh_Offset;

	private static bool GetCollisionComplexity_ReturnValue_IsValid;

	private static FFieldAddress GetCollisionComplexity_ReturnValue_PropertyAddress;

	private static int GetCollisionComplexity_ReturnValue_Offset;

	private static bool EnableNanite_IsValid;

	private static IntPtr EnableNanite_FunctionAddress;

	private static int EnableNanite_ParamsSize;

	private static bool EnableNanite_TargetStaticMesh_IsValid;

	private static FFieldAddress EnableNanite_TargetStaticMesh_PropertyAddress;

	private static int EnableNanite_TargetStaticMesh_Offset;

	private static bool EnableNanite_InEnable_IsValid;

	private static FFieldAddress EnableNanite_InEnable_PropertyAddress;

	private static int EnableNanite_InEnable_Offset;

	private static bool ConvertToStaticMesh_IsValid;

	private static IntPtr ConvertToStaticMesh_FunctionAddress;

	private static int ConvertToStaticMesh_ParamsSize;

	private static bool ConvertToStaticMesh_ProceduralMeshComponent_IsValid;

	private static FFieldAddress ConvertToStaticMesh_ProceduralMeshComponent_PropertyAddress;

	private static int ConvertToStaticMesh_ProceduralMeshComponent_Offset;

	private static bool ConvertToStaticMesh_PackageName_IsValid;

	private static FFieldAddress ConvertToStaticMesh_PackageName_PropertyAddress;

	private static int ConvertToStaticMesh_PackageName_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetStaticMeshActorVisibility")]
	public unsafe static void SetStaticMeshActorVisibility(AStaticMeshActor TargetActor, bool visible, bool recurseToChildActor)
	{
		if (!SetStaticMeshActorVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetStaticMeshActorVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStaticMeshActorVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStaticMeshActorVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AStaticMeshActor>.ToNative(IntPtr.Add(intPtr, SetStaticMeshActorVisibility_TargetActor_Offset), 0, SetStaticMeshActorVisibility_TargetActor_PropertyAddress.Address, TargetActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStaticMeshActorVisibility_visible_Offset), 0, SetStaticMeshActorVisibility_visible_PropertyAddress.Address, visible);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStaticMeshActorVisibility_recurseToChildActor_Offset), 0, SetStaticMeshActorVisibility_recurseToChildActor_PropertyAddress.Address, recurseToChildActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStaticMeshActorVisibility_FunctionAddress, intPtr, SetStaticMeshActorVisibility_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetLinearColorParameterValueOnMaterials")]
	public unsafe static void SetLinearColorParameterValueOnMaterials(UMeshComponent MeshComp, FName ParamName, FLinearColor ParamValue)
	{
		if (!SetLinearColorParameterValueOnMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetLinearColorParameterValueOnMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearColorParameterValueOnMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearColorParameterValueOnMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshComponent>.ToNative(IntPtr.Add(intPtr, SetLinearColorParameterValueOnMaterials_MeshComp_Offset), 0, SetLinearColorParameterValueOnMaterials_MeshComp_PropertyAddress.Address, MeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetLinearColorParameterValueOnMaterials_ParamName_Offset), 0, SetLinearColorParameterValueOnMaterials_ParamName_PropertyAddress.Address, ParamName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetLinearColorParameterValueOnMaterials_ParamValue_Offset), 0, SetLinearColorParameterValueOnMaterials_ParamValue_PropertyAddress.Address, ParamValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLinearColorParameterValueOnMaterials_FunctionAddress, intPtr, SetLinearColorParameterValueOnMaterials_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetConvexCollisionToStaticMesh")]
	public unsafe static bool SetConvexCollisionToStaticMesh(UStaticMesh TargetStaticMesh, int HullCount, int MaxHullVerts, int HullPrecision)
	{
		if (!SetConvexCollisionToStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetConvexCollisionToStaticMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConvexCollisionToStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConvexCollisionToStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetConvexCollisionToStaticMesh_TargetStaticMesh_Offset), 0, SetConvexCollisionToStaticMesh_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexCollisionToStaticMesh_HullCount_Offset), 0, SetConvexCollisionToStaticMesh_HullCount_PropertyAddress.Address, HullCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexCollisionToStaticMesh_MaxHullVerts_Offset), 0, SetConvexCollisionToStaticMesh_MaxHullVerts_PropertyAddress.Address, MaxHullVerts);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConvexCollisionToStaticMesh_HullPrecision_Offset), 0, SetConvexCollisionToStaticMesh_HullPrecision_PropertyAddress.Address, HullPrecision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetConvexCollisionToStaticMesh_FunctionAddress, intPtr, SetConvexCollisionToStaticMesh_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetConvexCollisionToStaticMesh_ReturnValue_Offset), 0, SetConvexCollisionToStaticMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionPresetForStaticMeshAsset")]
	public unsafe static bool SetCollisionPresetForStaticMeshAsset(UStaticMesh StaticMeshAsset, FName CollisionProfileName)
	{
		if (!SetCollisionPresetForStaticMeshAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionPresetForStaticMeshAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionPresetForStaticMeshAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionPresetForStaticMeshAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_Offset), 0, SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_PropertyAddress.Address, StaticMeshAsset);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCollisionPresetForStaticMeshAsset_CollisionProfileName_Offset), 0, SetCollisionPresetForStaticMeshAsset_CollisionProfileName_PropertyAddress.Address, CollisionProfileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCollisionPresetForStaticMeshAsset_FunctionAddress, intPtr, SetCollisionPresetForStaticMeshAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionPresetForStaticMeshAsset_ReturnValue_Offset), 0, SetCollisionPresetForStaticMeshAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionForBodyInstance")]
	public unsafe static bool SetCollisionForBodyInstance(UInstancedStaticMeshComponent InstancedStaticMesh, int nIndex, bool bEnableCollision, FName CollisionProfileName)
	{
		if (!SetCollisionForBodyInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionForBodyInstance");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionForBodyInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionForBodyInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInstancedStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, SetCollisionForBodyInstance_InstancedStaticMesh_Offset), 0, SetCollisionForBodyInstance_InstancedStaticMesh_PropertyAddress.Address, InstancedStaticMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCollisionForBodyInstance_nIndex_Offset), 0, SetCollisionForBodyInstance_nIndex_PropertyAddress.Address, nIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionForBodyInstance_bEnableCollision_Offset), 0, SetCollisionForBodyInstance_bEnableCollision_PropertyAddress.Address, bEnableCollision);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetCollisionForBodyInstance_CollisionProfileName_Offset), 0, SetCollisionForBodyInstance_CollisionProfileName_PropertyAddress.Address, CollisionProfileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCollisionForBodyInstance_FunctionAddress, intPtr, SetCollisionForBodyInstance_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionForBodyInstance_ReturnValue_Offset), 0, SetCollisionForBodyInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionEnableForStaticMeshAsset")]
	public unsafe static bool SetCollisionEnableForStaticMeshAsset(UStaticMesh StaticMeshAsset, ECollisionEnabled CollisionEnabled)
	{
		if (!SetCollisionEnableForStaticMeshAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionEnableForStaticMeshAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionEnableForStaticMeshAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionEnableForStaticMeshAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_Offset), 0, SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_PropertyAddress.Address, StaticMeshAsset);
		EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(intPtr, SetCollisionEnableForStaticMeshAsset_CollisionEnabled_Offset), 0, SetCollisionEnableForStaticMeshAsset_CollisionEnabled_PropertyAddress.Address, CollisionEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCollisionEnableForStaticMeshAsset_FunctionAddress, intPtr, SetCollisionEnableForStaticMeshAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCollisionEnableForStaticMeshAsset_ReturnValue_Offset), 0, SetCollisionEnableForStaticMeshAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionComplexity")]
	public unsafe static void SetCollisionComplexity(UStaticMesh TargetStaticMesh, ECollisionTraceFlag _CollisionTraceFlag)
	{
		if (!SetCollisionComplexity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionComplexity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionComplexity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionComplexity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SetCollisionComplexity_TargetStaticMesh_Offset), 0, SetCollisionComplexity_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		EnumMarshaler<ECollisionTraceFlag>.ToNative(IntPtr.Add(intPtr, SetCollisionComplexity__CollisionTraceFlag_Offset), 0, SetCollisionComplexity__CollisionTraceFlag_PropertyAddress.Address, _CollisionTraceFlag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCollisionComplexity_FunctionAddress, intPtr, SetCollisionComplexity_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:SaveRawMesh")]
	public unsafe static void SaveRawMesh(UStaticMesh TargetStaticMesh, List<int> WedgeIndices, List<FVector3f> VertexPositions)
	{
		if (!SaveRawMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:SaveRawMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveRawMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveRawMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, SaveRawMesh_TargetStaticMesh_Offset), 0, SaveRawMesh_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		new TArrayCopyMarshaler<int>(1, SaveRawMesh_WedgeIndices_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(intPtr, SaveRawMesh_WedgeIndices_Offset), WedgeIndices);
		new TArrayCopyMarshaler<FVector3f>(1, SaveRawMesh_VertexPositions_PropertyAddress, CachedMarshalingDelegates<FVector3f, FVector3f>.FromNative, CachedMarshalingDelegates<FVector3f, FVector3f>.ToNative).ToNative(IntPtr.Add(intPtr, SaveRawMesh_VertexPositions_Offset), VertexPositions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveRawMesh_FunctionAddress, intPtr, SaveRawMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveRawMesh_WedgeIndices_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveRawMesh_VertexPositions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:RunMerge")]
	public unsafe static bool RunMerge(string PackageName, List<UPrimitiveComponent> SelectedComponents, FMeshMergingSettings Settings, bool bReplaceSourceActors)
	{
		if (!RunMerge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:RunMerge");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunMerge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunMerge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RunMerge_PackageName_Offset), 0, RunMerge_PackageName_PropertyAddress.Address, PackageName);
		new TArrayCopyMarshaler<UPrimitiveComponent>(1, RunMerge_SelectedComponents_PropertyAddress, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, RunMerge_SelectedComponents_Offset), SelectedComponents);
		NativeReflection.InitializeValue_InContainer(RunMerge_Settings_PropertyAddress.Address, intPtr);
		FMeshMergingSettings.ToNative(IntPtr.Add(intPtr, RunMerge_Settings_Offset), 0, RunMerge_Settings_PropertyAddress.Address, Settings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RunMerge_bReplaceSourceActors_Offset), 0, RunMerge_bReplaceSourceActors_PropertyAddress.Address, bReplaceSourceActors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RunMerge_FunctionAddress, intPtr, RunMerge_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunMerge_PackageName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RunMerge_SelectedComponents_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RunMerge_ReturnValue_Offset), 0, RunMerge_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:IsCPUAccess")]
	public unsafe static bool IsCPUAccess(UStaticMesh StaticMesh)
	{
		if (!IsCPUAccess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:IsCPUAccess");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCPUAccess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCPUAccess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, IsCPUAccess_StaticMesh_Offset), 0, IsCPUAccess_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCPUAccess_FunctionAddress, intPtr, IsCPUAccess_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCPUAccess_ReturnValue_Offset), 0, IsCPUAccess_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetStaticMeshMaterialNum")]
	public unsafe static int GetStaticMeshMaterialNum(UStaticMesh TargetStaticMesh)
	{
		if (!GetStaticMeshMaterialNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetStaticMeshMaterialNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshMaterialNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshMaterialNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetStaticMeshMaterialNum_TargetStaticMesh_Offset), 0, GetStaticMeshMaterialNum_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshMaterialNum_FunctionAddress, intPtr, GetStaticMeshMaterialNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStaticMeshMaterialNum_ReturnValue_Offset), 0, GetStaticMeshMaterialNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetPreInstanceCustomData")]
	public unsafe static List<float> GetPreInstanceCustomData(UInstancedStaticMeshComponent InstancedStaticMesh)
	{
		if (!GetPreInstanceCustomData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetPreInstanceCustomData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreInstanceCustomData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreInstanceCustomData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInstancedStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GetPreInstanceCustomData_InstancedStaticMesh_Offset), 0, GetPreInstanceCustomData_InstancedStaticMesh_PropertyAddress.Address, InstancedStaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPreInstanceCustomData_FunctionAddress, intPtr, GetPreInstanceCustomData_ParamsSize);
		List<float> result = new TArrayCopyMarshaler<float>(1, GetPreInstanceCustomData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPreInstanceCustomData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPreInstanceCustomData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetMeshVertexMap")]
	public unsafe static void GetMeshVertexMap(UStaticMeshComponent TargetStaticMesh, out List<int> WedgeIndices, out List<FVector> VertexPositions)
	{
		if (!GetMeshVertexMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetMeshVertexMap");
			WedgeIndices = null;
			VertexPositions = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMeshVertexMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMeshVertexMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GetMeshVertexMap_TargetStaticMesh_Offset), 0, GetMeshVertexMap_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMeshVertexMap_FunctionAddress, intPtr, GetMeshVertexMap_ParamsSize);
		WedgeIndices = new TArrayCopyMarshaler<int>(1, GetMeshVertexMap_WedgeIndices_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMeshVertexMap_WedgeIndices_Offset));
		NativeReflection.DestroyValue_InContainer(GetMeshVertexMap_WedgeIndices_PropertyAddress.Address, intPtr);
		VertexPositions = new TArrayCopyMarshaler<FVector>(1, GetMeshVertexMap_VertexPositions_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMeshVertexMap_VertexPositions_Offset));
		NativeReflection.DestroyValue_InContainer(GetMeshVertexMap_VertexPositions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCustomPrimitiveData")]
	public unsafe static List<float> GetCustomPrimitiveData(UStaticMeshComponent StaticMeshComponent)
	{
		if (!GetCustomPrimitiveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCustomPrimitiveData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomPrimitiveData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomPrimitiveData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GetCustomPrimitiveData_StaticMeshComponent_Offset), 0, GetCustomPrimitiveData_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCustomPrimitiveData_FunctionAddress, intPtr, GetCustomPrimitiveData_ParamsSize);
		List<float> result = new TArrayCopyMarshaler<float>(1, GetCustomPrimitiveData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCustomPrimitiveData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCustomPrimitiveData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCollisionPremitiveNumbers")]
	public unsafe static int GetCollisionPremitiveNumbers(UStaticMesh TargetStaticMesh)
	{
		if (!GetCollisionPremitiveNumbers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCollisionPremitiveNumbers");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionPremitiveNumbers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionPremitiveNumbers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetCollisionPremitiveNumbers_TargetStaticMesh_Offset), 0, GetCollisionPremitiveNumbers_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCollisionPremitiveNumbers_FunctionAddress, intPtr, GetCollisionPremitiveNumbers_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCollisionPremitiveNumbers_ReturnValue_Offset), 0, GetCollisionPremitiveNumbers_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCollisionComplexity")]
	public unsafe static ECollisionTraceFlag GetCollisionComplexity(UStaticMesh TargetStaticMesh)
	{
		if (!GetCollisionComplexity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCollisionComplexity");
			return ECollisionTraceFlag.CTF_UseDefault;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCollisionComplexity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCollisionComplexity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, GetCollisionComplexity_TargetStaticMesh_Offset), 0, GetCollisionComplexity_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCollisionComplexity_FunctionAddress, intPtr, GetCollisionComplexity_ParamsSize);
		return EnumMarshaler<ECollisionTraceFlag>.FromNative(IntPtr.Add(intPtr, GetCollisionComplexity_ReturnValue_Offset), 0, GetCollisionComplexity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:EnableNanite")]
	public unsafe static void EnableNanite(UStaticMesh TargetStaticMesh, bool InEnable)
	{
		if (!EnableNanite_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:EnableNanite");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableNanite_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableNanite_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, EnableNanite_TargetStaticMesh_Offset), 0, EnableNanite_TargetStaticMesh_PropertyAddress.Address, TargetStaticMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableNanite_InEnable_Offset), 0, EnableNanite_InEnable_PropertyAddress.Address, InEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableNanite_FunctionAddress, intPtr, EnableNanite_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_StaticMeshFunLib:ConvertToStaticMesh")]
	public unsafe static void ConvertToStaticMesh(UProceduralMeshComponent ProceduralMeshComponent, string PackageName)
	{
		if (!ConvertToStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_StaticMeshFunLib:ConvertToStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UProceduralMeshComponent>.ToNative(IntPtr.Add(intPtr, ConvertToStaticMesh_ProceduralMeshComponent_Offset), 0, ConvertToStaticMesh_ProceduralMeshComponent_PropertyAddress.Address, ProceduralMeshComponent);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertToStaticMesh_PackageName_Offset), 0, ConvertToStaticMesh_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToStaticMesh_FunctionAddress, intPtr, ConvertToStaticMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertToStaticMesh_PackageName_PropertyAddress.Address, intPtr);
	}

	static UGSE_StaticMeshFunLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_StaticMeshFunLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_StaticMeshFunLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_StaticMeshFunLib");
		SetStaticMeshActorVisibility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStaticMeshActorVisibility");
		SetStaticMeshActorVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStaticMeshActorVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshActorVisibility_TargetActor_PropertyAddress, SetStaticMeshActorVisibility_FunctionAddress, "TargetActor");
		SetStaticMeshActorVisibility_TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshActorVisibility_FunctionAddress, "TargetActor");
		SetStaticMeshActorVisibility_TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshActorVisibility_FunctionAddress, "TargetActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshActorVisibility_visible_PropertyAddress, SetStaticMeshActorVisibility_FunctionAddress, "visible");
		SetStaticMeshActorVisibility_visible_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshActorVisibility_FunctionAddress, "visible");
		SetStaticMeshActorVisibility_visible_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshActorVisibility_FunctionAddress, "visible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStaticMeshActorVisibility_recurseToChildActor_PropertyAddress, SetStaticMeshActorVisibility_FunctionAddress, "recurseToChildActor");
		SetStaticMeshActorVisibility_recurseToChildActor_Offset = NativeReflectionCached.GetPropertyOffset(SetStaticMeshActorVisibility_FunctionAddress, "recurseToChildActor");
		SetStaticMeshActorVisibility_recurseToChildActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStaticMeshActorVisibility_FunctionAddress, "recurseToChildActor", Classes.FBoolProperty);
		SetStaticMeshActorVisibility_IsValid = SetStaticMeshActorVisibility_FunctionAddress != IntPtr.Zero && SetStaticMeshActorVisibility_TargetActor_IsValid && SetStaticMeshActorVisibility_visible_IsValid && SetStaticMeshActorVisibility_recurseToChildActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetStaticMeshActorVisibility", SetStaticMeshActorVisibility_IsValid);
		SetLinearColorParameterValueOnMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLinearColorParameterValueOnMaterials");
		SetLinearColorParameterValueOnMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearColorParameterValueOnMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearColorParameterValueOnMaterials_MeshComp_PropertyAddress, SetLinearColorParameterValueOnMaterials_FunctionAddress, "MeshComp");
		SetLinearColorParameterValueOnMaterials_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearColorParameterValueOnMaterials_FunctionAddress, "MeshComp");
		SetLinearColorParameterValueOnMaterials_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearColorParameterValueOnMaterials_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearColorParameterValueOnMaterials_ParamName_PropertyAddress, SetLinearColorParameterValueOnMaterials_FunctionAddress, "ParamName");
		SetLinearColorParameterValueOnMaterials_ParamName_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearColorParameterValueOnMaterials_FunctionAddress, "ParamName");
		SetLinearColorParameterValueOnMaterials_ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearColorParameterValueOnMaterials_FunctionAddress, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLinearColorParameterValueOnMaterials_ParamValue_PropertyAddress, SetLinearColorParameterValueOnMaterials_FunctionAddress, "ParamValue");
		SetLinearColorParameterValueOnMaterials_ParamValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearColorParameterValueOnMaterials_FunctionAddress, "ParamValue");
		SetLinearColorParameterValueOnMaterials_ParamValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearColorParameterValueOnMaterials_FunctionAddress, "ParamValue", Classes.FStructProperty);
		SetLinearColorParameterValueOnMaterials_IsValid = SetLinearColorParameterValueOnMaterials_FunctionAddress != IntPtr.Zero && SetLinearColorParameterValueOnMaterials_MeshComp_IsValid && SetLinearColorParameterValueOnMaterials_ParamName_IsValid && SetLinearColorParameterValueOnMaterials_ParamValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetLinearColorParameterValueOnMaterials", SetLinearColorParameterValueOnMaterials_IsValid);
		SetConvexCollisionToStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetConvexCollisionToStaticMesh");
		SetConvexCollisionToStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConvexCollisionToStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConvexCollisionToStaticMesh_TargetStaticMesh_PropertyAddress, SetConvexCollisionToStaticMesh_FunctionAddress, "TargetStaticMesh");
		SetConvexCollisionToStaticMesh_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexCollisionToStaticMesh_FunctionAddress, "TargetStaticMesh");
		SetConvexCollisionToStaticMesh_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexCollisionToStaticMesh_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexCollisionToStaticMesh_HullCount_PropertyAddress, SetConvexCollisionToStaticMesh_FunctionAddress, "HullCount");
		SetConvexCollisionToStaticMesh_HullCount_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexCollisionToStaticMesh_FunctionAddress, "HullCount");
		SetConvexCollisionToStaticMesh_HullCount_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexCollisionToStaticMesh_FunctionAddress, "HullCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexCollisionToStaticMesh_MaxHullVerts_PropertyAddress, SetConvexCollisionToStaticMesh_FunctionAddress, "MaxHullVerts");
		SetConvexCollisionToStaticMesh_MaxHullVerts_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexCollisionToStaticMesh_FunctionAddress, "MaxHullVerts");
		SetConvexCollisionToStaticMesh_MaxHullVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexCollisionToStaticMesh_FunctionAddress, "MaxHullVerts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexCollisionToStaticMesh_HullPrecision_PropertyAddress, SetConvexCollisionToStaticMesh_FunctionAddress, "HullPrecision");
		SetConvexCollisionToStaticMesh_HullPrecision_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexCollisionToStaticMesh_FunctionAddress, "HullPrecision");
		SetConvexCollisionToStaticMesh_HullPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexCollisionToStaticMesh_FunctionAddress, "HullPrecision", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConvexCollisionToStaticMesh_ReturnValue_PropertyAddress, SetConvexCollisionToStaticMesh_FunctionAddress, "ReturnValue");
		SetConvexCollisionToStaticMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConvexCollisionToStaticMesh_FunctionAddress, "ReturnValue");
		SetConvexCollisionToStaticMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConvexCollisionToStaticMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetConvexCollisionToStaticMesh_IsValid = SetConvexCollisionToStaticMesh_FunctionAddress != IntPtr.Zero && SetConvexCollisionToStaticMesh_TargetStaticMesh_IsValid && SetConvexCollisionToStaticMesh_HullCount_IsValid && SetConvexCollisionToStaticMesh_MaxHullVerts_IsValid && SetConvexCollisionToStaticMesh_HullPrecision_IsValid && SetConvexCollisionToStaticMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetConvexCollisionToStaticMesh", SetConvexCollisionToStaticMesh_IsValid);
		SetCollisionPresetForStaticMeshAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCollisionPresetForStaticMeshAsset");
		SetCollisionPresetForStaticMeshAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionPresetForStaticMeshAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_PropertyAddress, SetCollisionPresetForStaticMeshAsset_FunctionAddress, "StaticMeshAsset");
		SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionPresetForStaticMeshAsset_FunctionAddress, "StaticMeshAsset");
		SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionPresetForStaticMeshAsset_FunctionAddress, "StaticMeshAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionPresetForStaticMeshAsset_CollisionProfileName_PropertyAddress, SetCollisionPresetForStaticMeshAsset_FunctionAddress, "CollisionProfileName");
		SetCollisionPresetForStaticMeshAsset_CollisionProfileName_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionPresetForStaticMeshAsset_FunctionAddress, "CollisionProfileName");
		SetCollisionPresetForStaticMeshAsset_CollisionProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionPresetForStaticMeshAsset_FunctionAddress, "CollisionProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionPresetForStaticMeshAsset_ReturnValue_PropertyAddress, SetCollisionPresetForStaticMeshAsset_FunctionAddress, "ReturnValue");
		SetCollisionPresetForStaticMeshAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionPresetForStaticMeshAsset_FunctionAddress, "ReturnValue");
		SetCollisionPresetForStaticMeshAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionPresetForStaticMeshAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionPresetForStaticMeshAsset_IsValid = SetCollisionPresetForStaticMeshAsset_FunctionAddress != IntPtr.Zero && SetCollisionPresetForStaticMeshAsset_StaticMeshAsset_IsValid && SetCollisionPresetForStaticMeshAsset_CollisionProfileName_IsValid && SetCollisionPresetForStaticMeshAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionPresetForStaticMeshAsset", SetCollisionPresetForStaticMeshAsset_IsValid);
		SetCollisionForBodyInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCollisionForBodyInstance");
		SetCollisionForBodyInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionForBodyInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionForBodyInstance_InstancedStaticMesh_PropertyAddress, SetCollisionForBodyInstance_FunctionAddress, "InstancedStaticMesh");
		SetCollisionForBodyInstance_InstancedStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionForBodyInstance_FunctionAddress, "InstancedStaticMesh");
		SetCollisionForBodyInstance_InstancedStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionForBodyInstance_FunctionAddress, "InstancedStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionForBodyInstance_nIndex_PropertyAddress, SetCollisionForBodyInstance_FunctionAddress, "nIndex");
		SetCollisionForBodyInstance_nIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionForBodyInstance_FunctionAddress, "nIndex");
		SetCollisionForBodyInstance_nIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionForBodyInstance_FunctionAddress, "nIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionForBodyInstance_bEnableCollision_PropertyAddress, SetCollisionForBodyInstance_FunctionAddress, "bEnableCollision");
		SetCollisionForBodyInstance_bEnableCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionForBodyInstance_FunctionAddress, "bEnableCollision");
		SetCollisionForBodyInstance_bEnableCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionForBodyInstance_FunctionAddress, "bEnableCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionForBodyInstance_CollisionProfileName_PropertyAddress, SetCollisionForBodyInstance_FunctionAddress, "CollisionProfileName");
		SetCollisionForBodyInstance_CollisionProfileName_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionForBodyInstance_FunctionAddress, "CollisionProfileName");
		SetCollisionForBodyInstance_CollisionProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionForBodyInstance_FunctionAddress, "CollisionProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionForBodyInstance_ReturnValue_PropertyAddress, SetCollisionForBodyInstance_FunctionAddress, "ReturnValue");
		SetCollisionForBodyInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionForBodyInstance_FunctionAddress, "ReturnValue");
		SetCollisionForBodyInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionForBodyInstance_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionForBodyInstance_IsValid = SetCollisionForBodyInstance_FunctionAddress != IntPtr.Zero && SetCollisionForBodyInstance_InstancedStaticMesh_IsValid && SetCollisionForBodyInstance_nIndex_IsValid && SetCollisionForBodyInstance_bEnableCollision_IsValid && SetCollisionForBodyInstance_CollisionProfileName_IsValid && SetCollisionForBodyInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionForBodyInstance", SetCollisionForBodyInstance_IsValid);
		SetCollisionEnableForStaticMeshAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCollisionEnableForStaticMeshAsset");
		SetCollisionEnableForStaticMeshAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionEnableForStaticMeshAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_PropertyAddress, SetCollisionEnableForStaticMeshAsset_FunctionAddress, "StaticMeshAsset");
		SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnableForStaticMeshAsset_FunctionAddress, "StaticMeshAsset");
		SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnableForStaticMeshAsset_FunctionAddress, "StaticMeshAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnableForStaticMeshAsset_CollisionEnabled_PropertyAddress, SetCollisionEnableForStaticMeshAsset_FunctionAddress, "CollisionEnabled");
		SetCollisionEnableForStaticMeshAsset_CollisionEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnableForStaticMeshAsset_FunctionAddress, "CollisionEnabled");
		SetCollisionEnableForStaticMeshAsset_CollisionEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnableForStaticMeshAsset_FunctionAddress, "CollisionEnabled", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionEnableForStaticMeshAsset_ReturnValue_PropertyAddress, SetCollisionEnableForStaticMeshAsset_FunctionAddress, "ReturnValue");
		SetCollisionEnableForStaticMeshAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionEnableForStaticMeshAsset_FunctionAddress, "ReturnValue");
		SetCollisionEnableForStaticMeshAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionEnableForStaticMeshAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCollisionEnableForStaticMeshAsset_IsValid = SetCollisionEnableForStaticMeshAsset_FunctionAddress != IntPtr.Zero && SetCollisionEnableForStaticMeshAsset_StaticMeshAsset_IsValid && SetCollisionEnableForStaticMeshAsset_CollisionEnabled_IsValid && SetCollisionEnableForStaticMeshAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionEnableForStaticMeshAsset", SetCollisionEnableForStaticMeshAsset_IsValid);
		SetCollisionComplexity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCollisionComplexity");
		SetCollisionComplexity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionComplexity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionComplexity_TargetStaticMesh_PropertyAddress, SetCollisionComplexity_FunctionAddress, "TargetStaticMesh");
		SetCollisionComplexity_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionComplexity_FunctionAddress, "TargetStaticMesh");
		SetCollisionComplexity_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionComplexity_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionComplexity__CollisionTraceFlag_PropertyAddress, SetCollisionComplexity_FunctionAddress, "_CollisionTraceFlag");
		SetCollisionComplexity__CollisionTraceFlag_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionComplexity_FunctionAddress, "_CollisionTraceFlag");
		SetCollisionComplexity__CollisionTraceFlag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionComplexity_FunctionAddress, "_CollisionTraceFlag", Classes.FByteProperty);
		SetCollisionComplexity_IsValid = SetCollisionComplexity_FunctionAddress != IntPtr.Zero && SetCollisionComplexity_TargetStaticMesh_IsValid && SetCollisionComplexity__CollisionTraceFlag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SetCollisionComplexity", SetCollisionComplexity_IsValid);
		SaveRawMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveRawMesh");
		SaveRawMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveRawMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveRawMesh_TargetStaticMesh_PropertyAddress, SaveRawMesh_FunctionAddress, "TargetStaticMesh");
		SaveRawMesh_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(SaveRawMesh_FunctionAddress, "TargetStaticMesh");
		SaveRawMesh_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveRawMesh_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveRawMesh_WedgeIndices_PropertyAddress, SaveRawMesh_FunctionAddress, "WedgeIndices");
		SaveRawMesh_WedgeIndices_Offset = NativeReflectionCached.GetPropertyOffset(SaveRawMesh_FunctionAddress, "WedgeIndices");
		SaveRawMesh_WedgeIndices_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveRawMesh_FunctionAddress, "WedgeIndices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveRawMesh_VertexPositions_PropertyAddress, SaveRawMesh_FunctionAddress, "VertexPositions");
		SaveRawMesh_VertexPositions_Offset = NativeReflectionCached.GetPropertyOffset(SaveRawMesh_FunctionAddress, "VertexPositions");
		SaveRawMesh_VertexPositions_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveRawMesh_FunctionAddress, "VertexPositions", Classes.FArrayProperty);
		SaveRawMesh_IsValid = SaveRawMesh_FunctionAddress != IntPtr.Zero && SaveRawMesh_TargetStaticMesh_IsValid && SaveRawMesh_WedgeIndices_IsValid && SaveRawMesh_VertexPositions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:SaveRawMesh", SaveRawMesh_IsValid);
		RunMerge_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunMerge");
		RunMerge_ParamsSize = NativeReflection.GetFunctionParamsSize(RunMerge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunMerge_PackageName_PropertyAddress, RunMerge_FunctionAddress, "PackageName");
		RunMerge_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(RunMerge_FunctionAddress, "PackageName");
		RunMerge_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(RunMerge_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RunMerge_SelectedComponents_PropertyAddress, RunMerge_FunctionAddress, "SelectedComponents");
		RunMerge_SelectedComponents_Offset = NativeReflectionCached.GetPropertyOffset(RunMerge_FunctionAddress, "SelectedComponents");
		RunMerge_SelectedComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(RunMerge_FunctionAddress, "SelectedComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RunMerge_Settings_PropertyAddress, RunMerge_FunctionAddress, "Settings");
		RunMerge_Settings_Offset = NativeReflectionCached.GetPropertyOffset(RunMerge_FunctionAddress, "Settings");
		RunMerge_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(RunMerge_FunctionAddress, "Settings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RunMerge_bReplaceSourceActors_PropertyAddress, RunMerge_FunctionAddress, "bReplaceSourceActors");
		RunMerge_bReplaceSourceActors_Offset = NativeReflectionCached.GetPropertyOffset(RunMerge_FunctionAddress, "bReplaceSourceActors");
		RunMerge_bReplaceSourceActors_IsValid = NativeReflectionCached.ValidatePropertyClass(RunMerge_FunctionAddress, "bReplaceSourceActors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RunMerge_ReturnValue_PropertyAddress, RunMerge_FunctionAddress, "ReturnValue");
		RunMerge_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunMerge_FunctionAddress, "ReturnValue");
		RunMerge_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunMerge_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RunMerge_IsValid = RunMerge_FunctionAddress != IntPtr.Zero && RunMerge_PackageName_IsValid && RunMerge_SelectedComponents_IsValid && RunMerge_Settings_IsValid && RunMerge_bReplaceSourceActors_IsValid && RunMerge_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:RunMerge", RunMerge_IsValid);
		IsCPUAccess_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCPUAccess");
		IsCPUAccess_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCPUAccess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCPUAccess_StaticMesh_PropertyAddress, IsCPUAccess_FunctionAddress, "StaticMesh");
		IsCPUAccess_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(IsCPUAccess_FunctionAddress, "StaticMesh");
		IsCPUAccess_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCPUAccess_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCPUAccess_ReturnValue_PropertyAddress, IsCPUAccess_FunctionAddress, "ReturnValue");
		IsCPUAccess_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCPUAccess_FunctionAddress, "ReturnValue");
		IsCPUAccess_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCPUAccess_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCPUAccess_IsValid = IsCPUAccess_FunctionAddress != IntPtr.Zero && IsCPUAccess_StaticMesh_IsValid && IsCPUAccess_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:IsCPUAccess", IsCPUAccess_IsValid);
		GetStaticMeshMaterialNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshMaterialNum");
		GetStaticMeshMaterialNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshMaterialNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshMaterialNum_TargetStaticMesh_PropertyAddress, GetStaticMeshMaterialNum_FunctionAddress, "TargetStaticMesh");
		GetStaticMeshMaterialNum_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshMaterialNum_FunctionAddress, "TargetStaticMesh");
		GetStaticMeshMaterialNum_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshMaterialNum_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshMaterialNum_ReturnValue_PropertyAddress, GetStaticMeshMaterialNum_FunctionAddress, "ReturnValue");
		GetStaticMeshMaterialNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshMaterialNum_FunctionAddress, "ReturnValue");
		GetStaticMeshMaterialNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshMaterialNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStaticMeshMaterialNum_IsValid = GetStaticMeshMaterialNum_FunctionAddress != IntPtr.Zero && GetStaticMeshMaterialNum_TargetStaticMesh_IsValid && GetStaticMeshMaterialNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetStaticMeshMaterialNum", GetStaticMeshMaterialNum_IsValid);
		GetPreInstanceCustomData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreInstanceCustomData");
		GetPreInstanceCustomData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreInstanceCustomData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreInstanceCustomData_InstancedStaticMesh_PropertyAddress, GetPreInstanceCustomData_FunctionAddress, "InstancedStaticMesh");
		GetPreInstanceCustomData_InstancedStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetPreInstanceCustomData_FunctionAddress, "InstancedStaticMesh");
		GetPreInstanceCustomData_InstancedStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreInstanceCustomData_FunctionAddress, "InstancedStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreInstanceCustomData_ReturnValue_PropertyAddress, GetPreInstanceCustomData_FunctionAddress, "ReturnValue");
		GetPreInstanceCustomData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreInstanceCustomData_FunctionAddress, "ReturnValue");
		GetPreInstanceCustomData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreInstanceCustomData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPreInstanceCustomData_IsValid = GetPreInstanceCustomData_FunctionAddress != IntPtr.Zero && GetPreInstanceCustomData_InstancedStaticMesh_IsValid && GetPreInstanceCustomData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetPreInstanceCustomData", GetPreInstanceCustomData_IsValid);
		GetMeshVertexMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMeshVertexMap");
		GetMeshVertexMap_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMeshVertexMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMeshVertexMap_TargetStaticMesh_PropertyAddress, GetMeshVertexMap_FunctionAddress, "TargetStaticMesh");
		GetMeshVertexMap_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshVertexMap_FunctionAddress, "TargetStaticMesh");
		GetMeshVertexMap_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshVertexMap_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshVertexMap_WedgeIndices_PropertyAddress, GetMeshVertexMap_FunctionAddress, "WedgeIndices");
		GetMeshVertexMap_WedgeIndices_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshVertexMap_FunctionAddress, "WedgeIndices");
		GetMeshVertexMap_WedgeIndices_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshVertexMap_FunctionAddress, "WedgeIndices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMeshVertexMap_VertexPositions_PropertyAddress, GetMeshVertexMap_FunctionAddress, "VertexPositions");
		GetMeshVertexMap_VertexPositions_Offset = NativeReflectionCached.GetPropertyOffset(GetMeshVertexMap_FunctionAddress, "VertexPositions");
		GetMeshVertexMap_VertexPositions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMeshVertexMap_FunctionAddress, "VertexPositions", Classes.FArrayProperty);
		GetMeshVertexMap_IsValid = GetMeshVertexMap_FunctionAddress != IntPtr.Zero && GetMeshVertexMap_TargetStaticMesh_IsValid && GetMeshVertexMap_WedgeIndices_IsValid && GetMeshVertexMap_VertexPositions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetMeshVertexMap", GetMeshVertexMap_IsValid);
		GetCustomPrimitiveData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCustomPrimitiveData");
		GetCustomPrimitiveData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomPrimitiveData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPrimitiveData_StaticMeshComponent_PropertyAddress, GetCustomPrimitiveData_FunctionAddress, "StaticMeshComponent");
		GetCustomPrimitiveData_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPrimitiveData_FunctionAddress, "StaticMeshComponent");
		GetCustomPrimitiveData_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPrimitiveData_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomPrimitiveData_ReturnValue_PropertyAddress, GetCustomPrimitiveData_FunctionAddress, "ReturnValue");
		GetCustomPrimitiveData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomPrimitiveData_FunctionAddress, "ReturnValue");
		GetCustomPrimitiveData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomPrimitiveData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCustomPrimitiveData_IsValid = GetCustomPrimitiveData_FunctionAddress != IntPtr.Zero && GetCustomPrimitiveData_StaticMeshComponent_IsValid && GetCustomPrimitiveData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCustomPrimitiveData", GetCustomPrimitiveData_IsValid);
		GetCollisionPremitiveNumbers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCollisionPremitiveNumbers");
		GetCollisionPremitiveNumbers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionPremitiveNumbers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionPremitiveNumbers_TargetStaticMesh_PropertyAddress, GetCollisionPremitiveNumbers_FunctionAddress, "TargetStaticMesh");
		GetCollisionPremitiveNumbers_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionPremitiveNumbers_FunctionAddress, "TargetStaticMesh");
		GetCollisionPremitiveNumbers_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionPremitiveNumbers_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionPremitiveNumbers_ReturnValue_PropertyAddress, GetCollisionPremitiveNumbers_FunctionAddress, "ReturnValue");
		GetCollisionPremitiveNumbers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionPremitiveNumbers_FunctionAddress, "ReturnValue");
		GetCollisionPremitiveNumbers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionPremitiveNumbers_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCollisionPremitiveNumbers_IsValid = GetCollisionPremitiveNumbers_FunctionAddress != IntPtr.Zero && GetCollisionPremitiveNumbers_TargetStaticMesh_IsValid && GetCollisionPremitiveNumbers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCollisionPremitiveNumbers", GetCollisionPremitiveNumbers_IsValid);
		GetCollisionComplexity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCollisionComplexity");
		GetCollisionComplexity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCollisionComplexity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionComplexity_TargetStaticMesh_PropertyAddress, GetCollisionComplexity_FunctionAddress, "TargetStaticMesh");
		GetCollisionComplexity_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionComplexity_FunctionAddress, "TargetStaticMesh");
		GetCollisionComplexity_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionComplexity_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCollisionComplexity_ReturnValue_PropertyAddress, GetCollisionComplexity_FunctionAddress, "ReturnValue");
		GetCollisionComplexity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCollisionComplexity_FunctionAddress, "ReturnValue");
		GetCollisionComplexity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCollisionComplexity_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetCollisionComplexity_IsValid = GetCollisionComplexity_FunctionAddress != IntPtr.Zero && GetCollisionComplexity_TargetStaticMesh_IsValid && GetCollisionComplexity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:GetCollisionComplexity", GetCollisionComplexity_IsValid);
		EnableNanite_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableNanite");
		EnableNanite_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableNanite_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableNanite_TargetStaticMesh_PropertyAddress, EnableNanite_FunctionAddress, "TargetStaticMesh");
		EnableNanite_TargetStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(EnableNanite_FunctionAddress, "TargetStaticMesh");
		EnableNanite_TargetStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableNanite_FunctionAddress, "TargetStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableNanite_InEnable_PropertyAddress, EnableNanite_FunctionAddress, "InEnable");
		EnableNanite_InEnable_Offset = NativeReflectionCached.GetPropertyOffset(EnableNanite_FunctionAddress, "InEnable");
		EnableNanite_InEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableNanite_FunctionAddress, "InEnable", Classes.FBoolProperty);
		EnableNanite_IsValid = EnableNanite_FunctionAddress != IntPtr.Zero && EnableNanite_TargetStaticMesh_IsValid && EnableNanite_InEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:EnableNanite", EnableNanite_IsValid);
		ConvertToStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToStaticMesh");
		ConvertToStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToStaticMesh_ProceduralMeshComponent_PropertyAddress, ConvertToStaticMesh_FunctionAddress, "ProceduralMeshComponent");
		ConvertToStaticMesh_ProceduralMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToStaticMesh_FunctionAddress, "ProceduralMeshComponent");
		ConvertToStaticMesh_ProceduralMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToStaticMesh_FunctionAddress, "ProceduralMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToStaticMesh_PackageName_PropertyAddress, ConvertToStaticMesh_FunctionAddress, "PackageName");
		ConvertToStaticMesh_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToStaticMesh_FunctionAddress, "PackageName");
		ConvertToStaticMesh_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToStaticMesh_FunctionAddress, "PackageName", Classes.FStrProperty);
		ConvertToStaticMesh_IsValid = ConvertToStaticMesh_FunctionAddress != IntPtr.Zero && ConvertToStaticMesh_ProceduralMeshComponent_IsValid && ConvertToStaticMesh_PackageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_StaticMeshFunLib:ConvertToStaticMesh", ConvertToStaticMesh_IsValid);
	}
}
