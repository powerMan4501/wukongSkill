using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SpawnSystemAttachedWithParams_IsValid;

	private static IntPtr SpawnSystemAttachedWithParams_FunctionAddress;

	private static int SpawnSystemAttachedWithParams_ParamsSize;

	private static bool SpawnSystemAttachedWithParams_SpawnParams_IsValid;

	private static FFieldAddress SpawnSystemAttachedWithParams_SpawnParams_PropertyAddress;

	private static int SpawnSystemAttachedWithParams_SpawnParams_Offset;

	private static bool SpawnSystemAttachedWithParams_ReturnValue_IsValid;

	private static FFieldAddress SpawnSystemAttachedWithParams_ReturnValue_PropertyAddress;

	private static int SpawnSystemAttachedWithParams_ReturnValue_Offset;

	private static bool SpawnSystemAttached_IsValid;

	private static IntPtr SpawnSystemAttached_FunctionAddress;

	private static int SpawnSystemAttached_ParamsSize;

	private static bool SpawnSystemAttached_SystemTemplate_IsValid;

	private static FFieldAddress SpawnSystemAttached_SystemTemplate_PropertyAddress;

	private static int SpawnSystemAttached_SystemTemplate_Offset;

	private static bool SpawnSystemAttached_AttachToComponent_IsValid;

	private static FFieldAddress SpawnSystemAttached_AttachToComponent_PropertyAddress;

	private static int SpawnSystemAttached_AttachToComponent_Offset;

	private static bool SpawnSystemAttached_AttachPointName_IsValid;

	private static FFieldAddress SpawnSystemAttached_AttachPointName_PropertyAddress;

	private static int SpawnSystemAttached_AttachPointName_Offset;

	private static bool SpawnSystemAttached_Location_IsValid;

	private static FFieldAddress SpawnSystemAttached_Location_PropertyAddress;

	private static int SpawnSystemAttached_Location_Offset;

	private static bool SpawnSystemAttached_Rotation_IsValid;

	private static FFieldAddress SpawnSystemAttached_Rotation_PropertyAddress;

	private static int SpawnSystemAttached_Rotation_Offset;

	private static bool SpawnSystemAttached_LocationType_IsValid;

	private static FFieldAddress SpawnSystemAttached_LocationType_PropertyAddress;

	private static int SpawnSystemAttached_LocationType_Offset;

	private static bool SpawnSystemAttached_bAutoDestroy_IsValid;

	private static FFieldAddress SpawnSystemAttached_bAutoDestroy_PropertyAddress;

	private static int SpawnSystemAttached_bAutoDestroy_Offset;

	private static bool SpawnSystemAttached_bAutoActivate_IsValid;

	private static FFieldAddress SpawnSystemAttached_bAutoActivate_PropertyAddress;

	private static int SpawnSystemAttached_bAutoActivate_Offset;

	private static bool SpawnSystemAttached_PoolingMethod_IsValid;

	private static FFieldAddress SpawnSystemAttached_PoolingMethod_PropertyAddress;

	private static int SpawnSystemAttached_PoolingMethod_Offset;

	private static bool SpawnSystemAttached_bPreCullCheck_IsValid;

	private static FFieldAddress SpawnSystemAttached_bPreCullCheck_PropertyAddress;

	private static int SpawnSystemAttached_bPreCullCheck_Offset;

	private static bool SpawnSystemAttached_ReturnValue_IsValid;

	private static FFieldAddress SpawnSystemAttached_ReturnValue_PropertyAddress;

	private static int SpawnSystemAttached_ReturnValue_Offset;

	private static bool SpawnSystemAtLocationWithParams_IsValid;

	private static IntPtr SpawnSystemAtLocationWithParams_FunctionAddress;

	private static int SpawnSystemAtLocationWithParams_ParamsSize;

	private static bool SpawnSystemAtLocationWithParams_SpawnParams_IsValid;

	private static FFieldAddress SpawnSystemAtLocationWithParams_SpawnParams_PropertyAddress;

	private static int SpawnSystemAtLocationWithParams_SpawnParams_Offset;

	private static bool SpawnSystemAtLocationWithParams_ReturnValue_IsValid;

	private static FFieldAddress SpawnSystemAtLocationWithParams_ReturnValue_PropertyAddress;

	private static int SpawnSystemAtLocationWithParams_ReturnValue_Offset;

	private static bool SpawnSystemAtLocation_IsValid;

	private static IntPtr SpawnSystemAtLocation_FunctionAddress;

	private static int SpawnSystemAtLocation_ParamsSize;

	private static bool SpawnSystemAtLocation_WorldContextObject_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_WorldContextObject_PropertyAddress;

	private static int SpawnSystemAtLocation_WorldContextObject_Offset;

	private static bool SpawnSystemAtLocation_SystemTemplate_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_SystemTemplate_PropertyAddress;

	private static int SpawnSystemAtLocation_SystemTemplate_Offset;

	private static bool SpawnSystemAtLocation_Location_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_Location_PropertyAddress;

	private static int SpawnSystemAtLocation_Location_Offset;

	private static bool SpawnSystemAtLocation_Rotation_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_Rotation_PropertyAddress;

	private static int SpawnSystemAtLocation_Rotation_Offset;

	private static bool SpawnSystemAtLocation_Scale_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_Scale_PropertyAddress;

	private static int SpawnSystemAtLocation_Scale_Offset;

	private static bool SpawnSystemAtLocation_bAutoDestroy_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_bAutoDestroy_PropertyAddress;

	private static int SpawnSystemAtLocation_bAutoDestroy_Offset;

	private static bool SpawnSystemAtLocation_bAutoActivate_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_bAutoActivate_PropertyAddress;

	private static int SpawnSystemAtLocation_bAutoActivate_Offset;

	private static bool SpawnSystemAtLocation_PoolingMethod_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_PoolingMethod_PropertyAddress;

	private static int SpawnSystemAtLocation_PoolingMethod_Offset;

	private static bool SpawnSystemAtLocation_bPreCullCheck_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_bPreCullCheck_PropertyAddress;

	private static int SpawnSystemAtLocation_bPreCullCheck_Offset;

	private static bool SpawnSystemAtLocation_ReturnValue_IsValid;

	private static FFieldAddress SpawnSystemAtLocation_ReturnValue_PropertyAddress;

	private static int SpawnSystemAtLocation_ReturnValue_Offset;

	private static bool SetVolumeTextureObject_IsValid;

	private static IntPtr SetVolumeTextureObject_FunctionAddress;

	private static int SetVolumeTextureObject_ParamsSize;

	private static bool SetVolumeTextureObject_NiagaraSystem_IsValid;

	private static FFieldAddress SetVolumeTextureObject_NiagaraSystem_PropertyAddress;

	private static int SetVolumeTextureObject_NiagaraSystem_Offset;

	private static bool SetVolumeTextureObject_OverrideName_IsValid;

	private static FFieldAddress SetVolumeTextureObject_OverrideName_PropertyAddress;

	private static int SetVolumeTextureObject_OverrideName_Offset;

	private static bool SetVolumeTextureObject_Texture_IsValid;

	private static FFieldAddress SetVolumeTextureObject_Texture_PropertyAddress;

	private static int SetVolumeTextureObject_Texture_Offset;

	private static bool SetTextureObject_IsValid;

	private static IntPtr SetTextureObject_FunctionAddress;

	private static int SetTextureObject_ParamsSize;

	private static bool SetTextureObject_NiagaraSystem_IsValid;

	private static FFieldAddress SetTextureObject_NiagaraSystem_PropertyAddress;

	private static int SetTextureObject_NiagaraSystem_Offset;

	private static bool SetTextureObject_OverrideName_IsValid;

	private static FFieldAddress SetTextureObject_OverrideName_PropertyAddress;

	private static int SetTextureObject_OverrideName_Offset;

	private static bool SetTextureObject_Texture_IsValid;

	private static FFieldAddress SetTextureObject_Texture_PropertyAddress;

	private static int SetTextureObject_Texture_Offset;

	private static bool SetTexture2DArrayObject_IsValid;

	private static IntPtr SetTexture2DArrayObject_FunctionAddress;

	private static int SetTexture2DArrayObject_ParamsSize;

	private static bool SetTexture2DArrayObject_NiagaraSystem_IsValid;

	private static FFieldAddress SetTexture2DArrayObject_NiagaraSystem_PropertyAddress;

	private static int SetTexture2DArrayObject_NiagaraSystem_Offset;

	private static bool SetTexture2DArrayObject_OverrideName_IsValid;

	private static FFieldAddress SetTexture2DArrayObject_OverrideName_PropertyAddress;

	private static int SetTexture2DArrayObject_OverrideName_Offset;

	private static bool SetTexture2DArrayObject_Texture_IsValid;

	private static FFieldAddress SetTexture2DArrayObject_Texture_PropertyAddress;

	private static int SetTexture2DArrayObject_Texture_Offset;

	private static bool SetSkeletalMeshDataInterfaceSamplingRegions_IsValid;

	private static IntPtr SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress;

	private static int SetSkeletalMeshDataInterfaceSamplingRegions_ParamsSize;

	private static bool SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_IsValid;

	private static FFieldAddress SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_PropertyAddress;

	private static int SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_Offset;

	private static bool SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_IsValid;

	private static FFieldAddress SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_PropertyAddress;

	private static int SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_Offset;

	private static bool SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_IsValid;

	private static FFieldAddress SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_PropertyAddress;

	private static int SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_Offset;

	private static bool SetComponentNiagaraGPURayTracedCollisionGroup_IsValid;

	private static IntPtr SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress;

	private static int SetComponentNiagaraGPURayTracedCollisionGroup_ParamsSize;

	private static bool SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid;

	private static FFieldAddress SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress;

	private static int SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset;

	private static bool SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_IsValid;

	private static FFieldAddress SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_PropertyAddress;

	private static int SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_Offset;

	private static bool SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid;

	private static FFieldAddress SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress;

	private static int SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset;

	private static bool SetActorNiagaraGPURayTracedCollisionGroup_IsValid;

	private static IntPtr SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress;

	private static int SetActorNiagaraGPURayTracedCollisionGroup_ParamsSize;

	private static bool SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid;

	private static FFieldAddress SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress;

	private static int SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset;

	private static bool SetActorNiagaraGPURayTracedCollisionGroup_Actor_IsValid;

	private static FFieldAddress SetActorNiagaraGPURayTracedCollisionGroup_Actor_PropertyAddress;

	private static int SetActorNiagaraGPURayTracedCollisionGroup_Actor_Offset;

	private static bool SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid;

	private static FFieldAddress SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress;

	private static int SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset;

	private static bool ReleaseNiagaraGPURayTracedCollisionGroup_IsValid;

	private static IntPtr ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress;

	private static int ReleaseNiagaraGPURayTracedCollisionGroup_ParamsSize;

	private static bool ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid;

	private static FFieldAddress ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress;

	private static int ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset;

	private static bool ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid;

	private static FFieldAddress ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress;

	private static int ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset;

	private static bool OverrideSystemUserVariableStaticMeshComponent_IsValid;

	private static IntPtr OverrideSystemUserVariableStaticMeshComponent_FunctionAddress;

	private static int OverrideSystemUserVariableStaticMeshComponent_ParamsSize;

	private static bool OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_IsValid;

	private static FFieldAddress OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_PropertyAddress;

	private static int OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_Offset;

	private static bool OverrideSystemUserVariableStaticMeshComponent_OverrideName_IsValid;

	private static FFieldAddress OverrideSystemUserVariableStaticMeshComponent_OverrideName_PropertyAddress;

	private static int OverrideSystemUserVariableStaticMeshComponent_OverrideName_Offset;

	private static bool OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_IsValid;

	private static FFieldAddress OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_PropertyAddress;

	private static int OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_Offset;

	private static bool OverrideSystemUserVariableStaticMesh_IsValid;

	private static IntPtr OverrideSystemUserVariableStaticMesh_FunctionAddress;

	private static int OverrideSystemUserVariableStaticMesh_ParamsSize;

	private static bool OverrideSystemUserVariableStaticMesh_NiagaraSystem_IsValid;

	private static FFieldAddress OverrideSystemUserVariableStaticMesh_NiagaraSystem_PropertyAddress;

	private static int OverrideSystemUserVariableStaticMesh_NiagaraSystem_Offset;

	private static bool OverrideSystemUserVariableStaticMesh_OverrideName_IsValid;

	private static FFieldAddress OverrideSystemUserVariableStaticMesh_OverrideName_PropertyAddress;

	private static int OverrideSystemUserVariableStaticMesh_OverrideName_Offset;

	private static bool OverrideSystemUserVariableStaticMesh_StaticMesh_IsValid;

	private static FFieldAddress OverrideSystemUserVariableStaticMesh_StaticMesh_PropertyAddress;

	private static int OverrideSystemUserVariableStaticMesh_StaticMesh_Offset;

	private static bool OverrideSystemUserVariableSkeletalMeshComponent_IsValid;

	private static IntPtr OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress;

	private static int OverrideSystemUserVariableSkeletalMeshComponent_ParamsSize;

	private static bool OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_PropertyAddress;

	private static int OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_Offset;

	private static bool OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_PropertyAddress;

	private static int OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_Offset;

	private static bool OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_IsValid;

	private static FFieldAddress OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_PropertyAddress;

	private static int OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_Offset;

	private static bool GetNiagaraParameterCollection_IsValid;

	private static IntPtr GetNiagaraParameterCollection_FunctionAddress;

	private static int GetNiagaraParameterCollection_ParamsSize;

	private static bool GetNiagaraParameterCollection_WorldContextObject_IsValid;

	private static FFieldAddress GetNiagaraParameterCollection_WorldContextObject_PropertyAddress;

	private static int GetNiagaraParameterCollection_WorldContextObject_Offset;

	private static bool GetNiagaraParameterCollection_Collection_IsValid;

	private static FFieldAddress GetNiagaraParameterCollection_Collection_PropertyAddress;

	private static int GetNiagaraParameterCollection_Collection_Offset;

	private static bool GetNiagaraParameterCollection_ReturnValue_IsValid;

	private static FFieldAddress GetNiagaraParameterCollection_ReturnValue_PropertyAddress;

	private static int GetNiagaraParameterCollection_ReturnValue_Offset;

	private static bool AcquireNiagaraGPURayTracedCollisionGroup_IsValid;

	private static IntPtr AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress;

	private static int AcquireNiagaraGPURayTracedCollisionGroup_ParamsSize;

	private static bool AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid;

	private static FFieldAddress AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress;

	private static int AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset;

	private static bool AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_IsValid;

	private static FFieldAddress AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_PropertyAddress;

	private static int AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAttachedWithParams")]
	public unsafe static UNiagaraComponent SpawnSystemAttachedWithParams(out FXSystemSpawnParameters SpawnParams)
	{
		if (!SpawnSystemAttachedWithParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAttachedWithParams");
			SpawnParams = default(FXSystemSpawnParameters);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnSystemAttachedWithParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnSystemAttachedWithParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SpawnSystemAttachedWithParams_SpawnParams_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnSystemAttachedWithParams_FunctionAddress, intPtr, SpawnSystemAttachedWithParams_ParamsSize);
		SpawnParams = FXSystemSpawnParameters.FromNative(IntPtr.Add(intPtr, SpawnSystemAttachedWithParams_SpawnParams_Offset), 0, SpawnSystemAttachedWithParams_SpawnParams_PropertyAddress.Address);
		return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(intPtr, SpawnSystemAttachedWithParams_ReturnValue_Offset), 0, SpawnSystemAttachedWithParams_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAttached")]
	public unsafe static UNiagaraComponent SpawnSystemAttached(UNiagaraSystem SystemTemplate, USceneComponent AttachToComponent, FName AttachPointName, FVector Location, FRotator Rotation, EAttachLocation LocationType, bool bAutoDestroy, bool bAutoActivate = true, ENCPoolMethod PoolingMethod = ENCPoolMethod.None, bool bPreCullCheck = true)
	{
		if (!SpawnSystemAttached_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAttached");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnSystemAttached_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnSystemAttached_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_SystemTemplate_Offset), 0, SpawnSystemAttached_SystemTemplate_PropertyAddress.Address, SystemTemplate);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_AttachToComponent_Offset), 0, SpawnSystemAttached_AttachToComponent_PropertyAddress.Address, AttachToComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_AttachPointName_Offset), 0, SpawnSystemAttached_AttachPointName_PropertyAddress.Address, AttachPointName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_Location_Offset), 0, SpawnSystemAttached_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_Rotation_Offset), 0, SpawnSystemAttached_Rotation_PropertyAddress.Address, Rotation);
		EnumMarshaler<EAttachLocation>.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_LocationType_Offset), 0, SpawnSystemAttached_LocationType_PropertyAddress.Address, LocationType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_bAutoDestroy_Offset), 0, SpawnSystemAttached_bAutoDestroy_PropertyAddress.Address, bAutoDestroy);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_bAutoActivate_Offset), 0, SpawnSystemAttached_bAutoActivate_PropertyAddress.Address, bAutoActivate);
		EnumMarshaler<ENCPoolMethod>.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_PoolingMethod_Offset), 0, SpawnSystemAttached_PoolingMethod_PropertyAddress.Address, PoolingMethod);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnSystemAttached_bPreCullCheck_Offset), 0, SpawnSystemAttached_bPreCullCheck_PropertyAddress.Address, bPreCullCheck);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnSystemAttached_FunctionAddress, intPtr, SpawnSystemAttached_ParamsSize);
		return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(intPtr, SpawnSystemAttached_ReturnValue_Offset), 0, SpawnSystemAttached_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAtLocationWithParams")]
	public unsafe static UNiagaraComponent SpawnSystemAtLocationWithParams(out FXSystemSpawnParameters SpawnParams)
	{
		if (!SpawnSystemAtLocationWithParams_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAtLocationWithParams");
			SpawnParams = default(FXSystemSpawnParameters);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnSystemAtLocationWithParams_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnSystemAtLocationWithParams_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SpawnSystemAtLocationWithParams_SpawnParams_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnSystemAtLocationWithParams_FunctionAddress, intPtr, SpawnSystemAtLocationWithParams_ParamsSize);
		SpawnParams = FXSystemSpawnParameters.FromNative(IntPtr.Add(intPtr, SpawnSystemAtLocationWithParams_SpawnParams_Offset), 0, SpawnSystemAtLocationWithParams_SpawnParams_PropertyAddress.Address);
		return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(intPtr, SpawnSystemAtLocationWithParams_ReturnValue_Offset), 0, SpawnSystemAtLocationWithParams_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAtLocation")]
	public unsafe static UNiagaraComponent SpawnSystemAtLocation(UObject WorldContextObject, UNiagaraSystem SystemTemplate, FVector Location, FRotator Rotation, FVector Scale, bool bAutoDestroy, bool bAutoActivate, ENCPoolMethod PoolingMethod, bool bPreCullCheck)
	{
		if (!SpawnSystemAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAtLocation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnSystemAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnSystemAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_WorldContextObject_Offset), 0, SpawnSystemAtLocation_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_SystemTemplate_Offset), 0, SpawnSystemAtLocation_SystemTemplate_PropertyAddress.Address, SystemTemplate);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_Location_Offset), 0, SpawnSystemAtLocation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_Rotation_Offset), 0, SpawnSystemAtLocation_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_Scale_Offset), 0, SpawnSystemAtLocation_Scale_PropertyAddress.Address, Scale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_bAutoDestroy_Offset), 0, SpawnSystemAtLocation_bAutoDestroy_PropertyAddress.Address, bAutoDestroy);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_bAutoActivate_Offset), 0, SpawnSystemAtLocation_bAutoActivate_PropertyAddress.Address, bAutoActivate);
		EnumMarshaler<ENCPoolMethod>.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_PoolingMethod_Offset), 0, SpawnSystemAtLocation_PoolingMethod_PropertyAddress.Address, PoolingMethod);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_bPreCullCheck_Offset), 0, SpawnSystemAtLocation_bPreCullCheck_PropertyAddress.Address, bPreCullCheck);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnSystemAtLocation_FunctionAddress, intPtr, SpawnSystemAtLocation_ParamsSize);
		return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(intPtr, SpawnSystemAtLocation_ReturnValue_Offset), 0, SpawnSystemAtLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SetVolumeTextureObject")]
	public unsafe static void SetVolumeTextureObject(UNiagaraComponent NiagaraSystem, string OverrideName, UVolumeTexture Texture)
	{
		if (!SetVolumeTextureObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SetVolumeTextureObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumeTextureObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumeTextureObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetVolumeTextureObject_NiagaraSystem_Offset), 0, SetVolumeTextureObject_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetVolumeTextureObject_OverrideName_Offset), 0, SetVolumeTextureObject_OverrideName_PropertyAddress.Address, OverrideName);
		UObjectMarshaler<UVolumeTexture>.ToNative(IntPtr.Add(intPtr, SetVolumeTextureObject_Texture_Offset), 0, SetVolumeTextureObject_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetVolumeTextureObject_FunctionAddress, intPtr, SetVolumeTextureObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetVolumeTextureObject_OverrideName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SetTextureObject")]
	public unsafe static void SetTextureObject(UNiagaraComponent NiagaraSystem, string OverrideName, UTexture Texture)
	{
		if (!SetTextureObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SetTextureObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextureObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextureObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetTextureObject_NiagaraSystem_Offset), 0, SetTextureObject_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetTextureObject_OverrideName_Offset), 0, SetTextureObject_OverrideName_PropertyAddress.Address, OverrideName);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetTextureObject_Texture_Offset), 0, SetTextureObject_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTextureObject_FunctionAddress, intPtr, SetTextureObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTextureObject_OverrideName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SetTexture2DArrayObject")]
	public unsafe static void SetTexture2DArrayObject(UNiagaraComponent NiagaraSystem, string OverrideName, UTexture2DArray Texture)
	{
		if (!SetTexture2DArrayObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SetTexture2DArrayObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTexture2DArrayObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTexture2DArrayObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetTexture2DArrayObject_NiagaraSystem_Offset), 0, SetTexture2DArrayObject_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetTexture2DArrayObject_OverrideName_Offset), 0, SetTexture2DArrayObject_OverrideName_PropertyAddress.Address, OverrideName);
		UObjectMarshaler<UTexture2DArray>.ToNative(IntPtr.Add(intPtr, SetTexture2DArrayObject_Texture_Offset), 0, SetTexture2DArrayObject_Texture_PropertyAddress.Address, Texture);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTexture2DArrayObject_FunctionAddress, intPtr, SetTexture2DArrayObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTexture2DArrayObject_OverrideName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SetSkeletalMeshDataInterfaceSamplingRegions")]
	public unsafe static void SetSkeletalMeshDataInterfaceSamplingRegions(UNiagaraComponent NiagaraSystem, string OverrideName, List<FName> SamplingRegions)
	{
		if (!SetSkeletalMeshDataInterfaceSamplingRegions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SetSkeletalMeshDataInterfaceSamplingRegions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkeletalMeshDataInterfaceSamplingRegions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkeletalMeshDataInterfaceSamplingRegions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_Offset), 0, SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_Offset), 0, SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_PropertyAddress.Address, OverrideName);
		new TArrayCopyMarshaler<FName>(1, SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_Offset), SamplingRegions);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, intPtr, SetSkeletalMeshDataInterfaceSamplingRegions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SetComponentNiagaraGPURayTracedCollisionGroup")]
	public unsafe static void SetComponentNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject, UPrimitiveComponent Primitive, int CollisionGroup)
	{
		if (!SetComponentNiagaraGPURayTracedCollisionGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SetComponentNiagaraGPURayTracedCollisionGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetComponentNiagaraGPURayTracedCollisionGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetComponentNiagaraGPURayTracedCollisionGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset), 0, SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_Offset), 0, SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_PropertyAddress.Address, Primitive);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset), 0, SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress.Address, CollisionGroup);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, intPtr, SetComponentNiagaraGPURayTracedCollisionGroup_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:SetActorNiagaraGPURayTracedCollisionGroup")]
	public unsafe static void SetActorNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject, AActor Actor, int CollisionGroup)
	{
		if (!SetActorNiagaraGPURayTracedCollisionGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:SetActorNiagaraGPURayTracedCollisionGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorNiagaraGPURayTracedCollisionGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorNiagaraGPURayTracedCollisionGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset), 0, SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorNiagaraGPURayTracedCollisionGroup_Actor_Offset), 0, SetActorNiagaraGPURayTracedCollisionGroup_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset), 0, SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress.Address, CollisionGroup);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, intPtr, SetActorNiagaraGPURayTracedCollisionGroup_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:ReleaseNiagaraGPURayTracedCollisionGroup")]
	public unsafe static void ReleaseNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject, int CollisionGroup)
	{
		if (!ReleaseNiagaraGPURayTracedCollisionGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:ReleaseNiagaraGPURayTracedCollisionGroup");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseNiagaraGPURayTracedCollisionGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseNiagaraGPURayTracedCollisionGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset), 0, ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset), 0, ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress.Address, CollisionGroup);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress, intPtr, ReleaseNiagaraGPURayTracedCollisionGroup_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableStaticMeshComponent")]
	public unsafe static void OverrideSystemUserVariableStaticMeshComponent(UNiagaraComponent NiagaraSystem, string OverrideName, UStaticMeshComponent StaticMeshComponent)
	{
		if (!OverrideSystemUserVariableStaticMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableStaticMeshComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideSystemUserVariableStaticMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideSystemUserVariableStaticMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_Offset), 0, OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableStaticMeshComponent_OverrideName_Offset), 0, OverrideSystemUserVariableStaticMeshComponent_OverrideName_PropertyAddress.Address, OverrideName);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_Offset), 0, OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_PropertyAddress.Address, StaticMeshComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, intPtr, OverrideSystemUserVariableStaticMeshComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OverrideSystemUserVariableStaticMeshComponent_OverrideName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableStaticMesh")]
	public unsafe static void OverrideSystemUserVariableStaticMesh(UNiagaraComponent NiagaraSystem, string OverrideName, UStaticMesh StaticMesh)
	{
		if (!OverrideSystemUserVariableStaticMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableStaticMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideSystemUserVariableStaticMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideSystemUserVariableStaticMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableStaticMesh_NiagaraSystem_Offset), 0, OverrideSystemUserVariableStaticMesh_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableStaticMesh_OverrideName_Offset), 0, OverrideSystemUserVariableStaticMesh_OverrideName_PropertyAddress.Address, OverrideName);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableStaticMesh_StaticMesh_Offset), 0, OverrideSystemUserVariableStaticMesh_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OverrideSystemUserVariableStaticMesh_FunctionAddress, intPtr, OverrideSystemUserVariableStaticMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OverrideSystemUserVariableStaticMesh_OverrideName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableSkeletalMeshComponent")]
	public unsafe static void OverrideSystemUserVariableSkeletalMeshComponent(UNiagaraComponent NiagaraSystem, string OverrideName, USkeletalMeshComponent SkeletalMeshComponent)
	{
		if (!OverrideSystemUserVariableSkeletalMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableSkeletalMeshComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideSystemUserVariableSkeletalMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideSystemUserVariableSkeletalMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_Offset), 0, OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_Offset), 0, OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_PropertyAddress.Address, OverrideName);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_Offset), 0, OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_PropertyAddress.Address, SkeletalMeshComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, intPtr, OverrideSystemUserVariableSkeletalMeshComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:GetNiagaraParameterCollection")]
	public unsafe static UNiagaraParameterCollectionInstance GetNiagaraParameterCollection(UObject WorldContextObject, UNiagaraParameterCollection Collection)
	{
		if (!GetNiagaraParameterCollection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:GetNiagaraParameterCollection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNiagaraParameterCollection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNiagaraParameterCollection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetNiagaraParameterCollection_WorldContextObject_Offset), 0, GetNiagaraParameterCollection_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UNiagaraParameterCollection>.ToNative(IntPtr.Add(intPtr, GetNiagaraParameterCollection_Collection_Offset), 0, GetNiagaraParameterCollection_Collection_PropertyAddress.Address, Collection);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNiagaraParameterCollection_FunctionAddress, intPtr, GetNiagaraParameterCollection_ParamsSize);
		return UObjectMarshaler<UNiagaraParameterCollectionInstance>.FromNative(IntPtr.Add(intPtr, GetNiagaraParameterCollection_ReturnValue_Offset), 0, GetNiagaraParameterCollection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Niagara.NiagaraFunctionLibrary:AcquireNiagaraGPURayTracedCollisionGroup")]
	public unsafe static int AcquireNiagaraGPURayTracedCollisionGroup(UObject WorldContextObject)
	{
		if (!AcquireNiagaraGPURayTracedCollisionGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraFunctionLibrary:AcquireNiagaraGPURayTracedCollisionGroup");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AcquireNiagaraGPURayTracedCollisionGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AcquireNiagaraGPURayTracedCollisionGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset), 0, AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress, intPtr, AcquireNiagaraGPURayTracedCollisionGroup_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_Offset), 0, AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_PropertyAddress.Address);
	}

	static UNiagaraFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Niagara.NiagaraFunctionLibrary");
		SpawnSystemAttachedWithParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnSystemAttachedWithParams");
		SpawnSystemAttachedWithParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnSystemAttachedWithParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttachedWithParams_SpawnParams_PropertyAddress, SpawnSystemAttachedWithParams_FunctionAddress, "SpawnParams");
		SpawnSystemAttachedWithParams_SpawnParams_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttachedWithParams_FunctionAddress, "SpawnParams");
		SpawnSystemAttachedWithParams_SpawnParams_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttachedWithParams_FunctionAddress, "SpawnParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttachedWithParams_ReturnValue_PropertyAddress, SpawnSystemAttachedWithParams_FunctionAddress, "ReturnValue");
		SpawnSystemAttachedWithParams_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttachedWithParams_FunctionAddress, "ReturnValue");
		SpawnSystemAttachedWithParams_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttachedWithParams_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnSystemAttachedWithParams_IsValid = SpawnSystemAttachedWithParams_FunctionAddress != IntPtr.Zero && SpawnSystemAttachedWithParams_SpawnParams_IsValid && SpawnSystemAttachedWithParams_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAttachedWithParams", SpawnSystemAttachedWithParams_IsValid);
		SpawnSystemAttached_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnSystemAttached");
		SpawnSystemAttached_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnSystemAttached_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_SystemTemplate_PropertyAddress, SpawnSystemAttached_FunctionAddress, "SystemTemplate");
		SpawnSystemAttached_SystemTemplate_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "SystemTemplate");
		SpawnSystemAttached_SystemTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "SystemTemplate", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_AttachToComponent_PropertyAddress, SpawnSystemAttached_FunctionAddress, "AttachToComponent");
		SpawnSystemAttached_AttachToComponent_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "AttachToComponent");
		SpawnSystemAttached_AttachToComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "AttachToComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_AttachPointName_PropertyAddress, SpawnSystemAttached_FunctionAddress, "AttachPointName");
		SpawnSystemAttached_AttachPointName_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "AttachPointName");
		SpawnSystemAttached_AttachPointName_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "AttachPointName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_Location_PropertyAddress, SpawnSystemAttached_FunctionAddress, "Location");
		SpawnSystemAttached_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "Location");
		SpawnSystemAttached_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_Rotation_PropertyAddress, SpawnSystemAttached_FunctionAddress, "Rotation");
		SpawnSystemAttached_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "Rotation");
		SpawnSystemAttached_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_LocationType_PropertyAddress, SpawnSystemAttached_FunctionAddress, "LocationType");
		SpawnSystemAttached_LocationType_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "LocationType");
		SpawnSystemAttached_LocationType_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "LocationType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_bAutoDestroy_PropertyAddress, SpawnSystemAttached_FunctionAddress, "bAutoDestroy");
		SpawnSystemAttached_bAutoDestroy_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "bAutoDestroy");
		SpawnSystemAttached_bAutoDestroy_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "bAutoDestroy", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_bAutoActivate_PropertyAddress, SpawnSystemAttached_FunctionAddress, "bAutoActivate");
		SpawnSystemAttached_bAutoActivate_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "bAutoActivate");
		SpawnSystemAttached_bAutoActivate_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "bAutoActivate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_PoolingMethod_PropertyAddress, SpawnSystemAttached_FunctionAddress, "PoolingMethod");
		SpawnSystemAttached_PoolingMethod_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "PoolingMethod");
		SpawnSystemAttached_PoolingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "PoolingMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_bPreCullCheck_PropertyAddress, SpawnSystemAttached_FunctionAddress, "bPreCullCheck");
		SpawnSystemAttached_bPreCullCheck_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "bPreCullCheck");
		SpawnSystemAttached_bPreCullCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "bPreCullCheck", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAttached_ReturnValue_PropertyAddress, SpawnSystemAttached_FunctionAddress, "ReturnValue");
		SpawnSystemAttached_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAttached_FunctionAddress, "ReturnValue");
		SpawnSystemAttached_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAttached_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnSystemAttached_IsValid = SpawnSystemAttached_FunctionAddress != IntPtr.Zero && SpawnSystemAttached_SystemTemplate_IsValid && SpawnSystemAttached_AttachToComponent_IsValid && SpawnSystemAttached_AttachPointName_IsValid && SpawnSystemAttached_Location_IsValid && SpawnSystemAttached_Rotation_IsValid && SpawnSystemAttached_LocationType_IsValid && SpawnSystemAttached_bAutoDestroy_IsValid && SpawnSystemAttached_bAutoActivate_IsValid && SpawnSystemAttached_PoolingMethod_IsValid && SpawnSystemAttached_bPreCullCheck_IsValid && SpawnSystemAttached_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAttached", SpawnSystemAttached_IsValid);
		SpawnSystemAtLocationWithParams_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnSystemAtLocationWithParams");
		SpawnSystemAtLocationWithParams_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnSystemAtLocationWithParams_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocationWithParams_SpawnParams_PropertyAddress, SpawnSystemAtLocationWithParams_FunctionAddress, "SpawnParams");
		SpawnSystemAtLocationWithParams_SpawnParams_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocationWithParams_FunctionAddress, "SpawnParams");
		SpawnSystemAtLocationWithParams_SpawnParams_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocationWithParams_FunctionAddress, "SpawnParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocationWithParams_ReturnValue_PropertyAddress, SpawnSystemAtLocationWithParams_FunctionAddress, "ReturnValue");
		SpawnSystemAtLocationWithParams_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocationWithParams_FunctionAddress, "ReturnValue");
		SpawnSystemAtLocationWithParams_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocationWithParams_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnSystemAtLocationWithParams_IsValid = SpawnSystemAtLocationWithParams_FunctionAddress != IntPtr.Zero && SpawnSystemAtLocationWithParams_SpawnParams_IsValid && SpawnSystemAtLocationWithParams_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAtLocationWithParams", SpawnSystemAtLocationWithParams_IsValid);
		SpawnSystemAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnSystemAtLocation");
		SpawnSystemAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnSystemAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_WorldContextObject_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "WorldContextObject");
		SpawnSystemAtLocation_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "WorldContextObject");
		SpawnSystemAtLocation_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_SystemTemplate_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "SystemTemplate");
		SpawnSystemAtLocation_SystemTemplate_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "SystemTemplate");
		SpawnSystemAtLocation_SystemTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "SystemTemplate", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_Location_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "Location");
		SpawnSystemAtLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "Location");
		SpawnSystemAtLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_Rotation_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "Rotation");
		SpawnSystemAtLocation_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "Rotation");
		SpawnSystemAtLocation_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_Scale_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "Scale");
		SpawnSystemAtLocation_Scale_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "Scale");
		SpawnSystemAtLocation_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "Scale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_bAutoDestroy_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "bAutoDestroy");
		SpawnSystemAtLocation_bAutoDestroy_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "bAutoDestroy");
		SpawnSystemAtLocation_bAutoDestroy_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "bAutoDestroy", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_bAutoActivate_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "bAutoActivate");
		SpawnSystemAtLocation_bAutoActivate_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "bAutoActivate");
		SpawnSystemAtLocation_bAutoActivate_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "bAutoActivate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_PoolingMethod_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "PoolingMethod");
		SpawnSystemAtLocation_PoolingMethod_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "PoolingMethod");
		SpawnSystemAtLocation_PoolingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "PoolingMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_bPreCullCheck_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "bPreCullCheck");
		SpawnSystemAtLocation_bPreCullCheck_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "bPreCullCheck");
		SpawnSystemAtLocation_bPreCullCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "bPreCullCheck", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnSystemAtLocation_ReturnValue_PropertyAddress, SpawnSystemAtLocation_FunctionAddress, "ReturnValue");
		SpawnSystemAtLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnSystemAtLocation_FunctionAddress, "ReturnValue");
		SpawnSystemAtLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnSystemAtLocation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnSystemAtLocation_IsValid = SpawnSystemAtLocation_FunctionAddress != IntPtr.Zero && SpawnSystemAtLocation_WorldContextObject_IsValid && SpawnSystemAtLocation_SystemTemplate_IsValid && SpawnSystemAtLocation_Location_IsValid && SpawnSystemAtLocation_Rotation_IsValid && SpawnSystemAtLocation_Scale_IsValid && SpawnSystemAtLocation_bAutoDestroy_IsValid && SpawnSystemAtLocation_bAutoActivate_IsValid && SpawnSystemAtLocation_PoolingMethod_IsValid && SpawnSystemAtLocation_bPreCullCheck_IsValid && SpawnSystemAtLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SpawnSystemAtLocation", SpawnSystemAtLocation_IsValid);
		SetVolumeTextureObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetVolumeTextureObject");
		SetVolumeTextureObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumeTextureObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumeTextureObject_NiagaraSystem_PropertyAddress, SetVolumeTextureObject_FunctionAddress, "NiagaraSystem");
		SetVolumeTextureObject_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumeTextureObject_FunctionAddress, "NiagaraSystem");
		SetVolumeTextureObject_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumeTextureObject_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVolumeTextureObject_OverrideName_PropertyAddress, SetVolumeTextureObject_FunctionAddress, "OverrideName");
		SetVolumeTextureObject_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumeTextureObject_FunctionAddress, "OverrideName");
		SetVolumeTextureObject_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumeTextureObject_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetVolumeTextureObject_Texture_PropertyAddress, SetVolumeTextureObject_FunctionAddress, "Texture");
		SetVolumeTextureObject_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumeTextureObject_FunctionAddress, "Texture");
		SetVolumeTextureObject_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumeTextureObject_FunctionAddress, "Texture", Classes.FObjectProperty);
		SetVolumeTextureObject_IsValid = SetVolumeTextureObject_FunctionAddress != IntPtr.Zero && SetVolumeTextureObject_NiagaraSystem_IsValid && SetVolumeTextureObject_OverrideName_IsValid && SetVolumeTextureObject_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SetVolumeTextureObject", SetVolumeTextureObject_IsValid);
		SetTextureObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTextureObject");
		SetTextureObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextureObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextureObject_NiagaraSystem_PropertyAddress, SetTextureObject_FunctionAddress, "NiagaraSystem");
		SetTextureObject_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureObject_FunctionAddress, "NiagaraSystem");
		SetTextureObject_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureObject_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureObject_OverrideName_PropertyAddress, SetTextureObject_FunctionAddress, "OverrideName");
		SetTextureObject_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureObject_FunctionAddress, "OverrideName");
		SetTextureObject_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureObject_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTextureObject_Texture_PropertyAddress, SetTextureObject_FunctionAddress, "Texture");
		SetTextureObject_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetTextureObject_FunctionAddress, "Texture");
		SetTextureObject_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextureObject_FunctionAddress, "Texture", Classes.FObjectProperty);
		SetTextureObject_IsValid = SetTextureObject_FunctionAddress != IntPtr.Zero && SetTextureObject_NiagaraSystem_IsValid && SetTextureObject_OverrideName_IsValid && SetTextureObject_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SetTextureObject", SetTextureObject_IsValid);
		SetTexture2DArrayObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTexture2DArrayObject");
		SetTexture2DArrayObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTexture2DArrayObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTexture2DArrayObject_NiagaraSystem_PropertyAddress, SetTexture2DArrayObject_FunctionAddress, "NiagaraSystem");
		SetTexture2DArrayObject_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetTexture2DArrayObject_FunctionAddress, "NiagaraSystem");
		SetTexture2DArrayObject_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTexture2DArrayObject_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTexture2DArrayObject_OverrideName_PropertyAddress, SetTexture2DArrayObject_FunctionAddress, "OverrideName");
		SetTexture2DArrayObject_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetTexture2DArrayObject_FunctionAddress, "OverrideName");
		SetTexture2DArrayObject_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTexture2DArrayObject_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTexture2DArrayObject_Texture_PropertyAddress, SetTexture2DArrayObject_FunctionAddress, "Texture");
		SetTexture2DArrayObject_Texture_Offset = NativeReflectionCached.GetPropertyOffset(SetTexture2DArrayObject_FunctionAddress, "Texture");
		SetTexture2DArrayObject_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTexture2DArrayObject_FunctionAddress, "Texture", Classes.FObjectProperty);
		SetTexture2DArrayObject_IsValid = SetTexture2DArrayObject_FunctionAddress != IntPtr.Zero && SetTexture2DArrayObject_NiagaraSystem_IsValid && SetTexture2DArrayObject_OverrideName_IsValid && SetTexture2DArrayObject_Texture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SetTexture2DArrayObject", SetTexture2DArrayObject_IsValid);
		SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSkeletalMeshDataInterfaceSamplingRegions");
		SetSkeletalMeshDataInterfaceSamplingRegions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_PropertyAddress, SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "NiagaraSystem");
		SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "NiagaraSystem");
		SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_PropertyAddress, SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "OverrideName");
		SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "OverrideName");
		SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_PropertyAddress, SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "SamplingRegions");
		SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_Offset = NativeReflectionCached.GetPropertyOffset(SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "SamplingRegions");
		SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress, "SamplingRegions", Classes.FArrayProperty);
		SetSkeletalMeshDataInterfaceSamplingRegions_IsValid = SetSkeletalMeshDataInterfaceSamplingRegions_FunctionAddress != IntPtr.Zero && SetSkeletalMeshDataInterfaceSamplingRegions_NiagaraSystem_IsValid && SetSkeletalMeshDataInterfaceSamplingRegions_OverrideName_IsValid && SetSkeletalMeshDataInterfaceSamplingRegions_SamplingRegions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SetSkeletalMeshDataInterfaceSamplingRegions", SetSkeletalMeshDataInterfaceSamplingRegions_IsValid);
		SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetComponentNiagaraGPURayTracedCollisionGroup");
		SetComponentNiagaraGPURayTracedCollisionGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress, SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_PropertyAddress, SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "Primitive");
		SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "Primitive");
		SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "Primitive", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress, SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup");
		SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup");
		SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup", Classes.FIntProperty);
		SetComponentNiagaraGPURayTracedCollisionGroup_IsValid = SetComponentNiagaraGPURayTracedCollisionGroup_FunctionAddress != IntPtr.Zero && SetComponentNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid && SetComponentNiagaraGPURayTracedCollisionGroup_Primitive_IsValid && SetComponentNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SetComponentNiagaraGPURayTracedCollisionGroup", SetComponentNiagaraGPURayTracedCollisionGroup_IsValid);
		SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorNiagaraGPURayTracedCollisionGroup");
		SetActorNiagaraGPURayTracedCollisionGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress, SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorNiagaraGPURayTracedCollisionGroup_Actor_PropertyAddress, SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "Actor");
		SetActorNiagaraGPURayTracedCollisionGroup_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "Actor");
		SetActorNiagaraGPURayTracedCollisionGroup_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress, SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup");
		SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset = NativeReflectionCached.GetPropertyOffset(SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup");
		SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup", Classes.FIntProperty);
		SetActorNiagaraGPURayTracedCollisionGroup_IsValid = SetActorNiagaraGPURayTracedCollisionGroup_FunctionAddress != IntPtr.Zero && SetActorNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid && SetActorNiagaraGPURayTracedCollisionGroup_Actor_IsValid && SetActorNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:SetActorNiagaraGPURayTracedCollisionGroup", SetActorNiagaraGPURayTracedCollisionGroup_IsValid);
		ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReleaseNiagaraGPURayTracedCollisionGroup");
		ReleaseNiagaraGPURayTracedCollisionGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress, ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_PropertyAddress, ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup");
		ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup");
		ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress, "CollisionGroup", Classes.FIntProperty);
		ReleaseNiagaraGPURayTracedCollisionGroup_IsValid = ReleaseNiagaraGPURayTracedCollisionGroup_FunctionAddress != IntPtr.Zero && ReleaseNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid && ReleaseNiagaraGPURayTracedCollisionGroup_CollisionGroup_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:ReleaseNiagaraGPURayTracedCollisionGroup", ReleaseNiagaraGPURayTracedCollisionGroup_IsValid);
		OverrideSystemUserVariableStaticMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OverrideSystemUserVariableStaticMeshComponent");
		OverrideSystemUserVariableStaticMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideSystemUserVariableStaticMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_PropertyAddress, OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableStaticMeshComponent_OverrideName_PropertyAddress, OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableStaticMeshComponent_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableStaticMeshComponent_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_PropertyAddress, OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "StaticMeshComponent");
		OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "StaticMeshComponent");
		OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableStaticMeshComponent_FunctionAddress, "StaticMeshComponent", Classes.FObjectProperty);
		OverrideSystemUserVariableStaticMeshComponent_IsValid = OverrideSystemUserVariableStaticMeshComponent_FunctionAddress != IntPtr.Zero && OverrideSystemUserVariableStaticMeshComponent_NiagaraSystem_IsValid && OverrideSystemUserVariableStaticMeshComponent_OverrideName_IsValid && OverrideSystemUserVariableStaticMeshComponent_StaticMeshComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableStaticMeshComponent", OverrideSystemUserVariableStaticMeshComponent_IsValid);
		OverrideSystemUserVariableStaticMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OverrideSystemUserVariableStaticMesh");
		OverrideSystemUserVariableStaticMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideSystemUserVariableStaticMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableStaticMesh_NiagaraSystem_PropertyAddress, OverrideSystemUserVariableStaticMesh_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableStaticMesh_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableStaticMesh_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableStaticMesh_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableStaticMesh_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableStaticMesh_OverrideName_PropertyAddress, OverrideSystemUserVariableStaticMesh_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableStaticMesh_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableStaticMesh_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableStaticMesh_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableStaticMesh_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableStaticMesh_StaticMesh_PropertyAddress, OverrideSystemUserVariableStaticMesh_FunctionAddress, "StaticMesh");
		OverrideSystemUserVariableStaticMesh_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableStaticMesh_FunctionAddress, "StaticMesh");
		OverrideSystemUserVariableStaticMesh_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableStaticMesh_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		OverrideSystemUserVariableStaticMesh_IsValid = OverrideSystemUserVariableStaticMesh_FunctionAddress != IntPtr.Zero && OverrideSystemUserVariableStaticMesh_NiagaraSystem_IsValid && OverrideSystemUserVariableStaticMesh_OverrideName_IsValid && OverrideSystemUserVariableStaticMesh_StaticMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableStaticMesh", OverrideSystemUserVariableStaticMesh_IsValid);
		OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OverrideSystemUserVariableSkeletalMeshComponent");
		OverrideSystemUserVariableSkeletalMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_PropertyAddress, OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "NiagaraSystem");
		OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_PropertyAddress, OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "OverrideName");
		OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_PropertyAddress, OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "SkeletalMeshComponent");
		OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "SkeletalMeshComponent");
		OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress, "SkeletalMeshComponent", Classes.FObjectProperty);
		OverrideSystemUserVariableSkeletalMeshComponent_IsValid = OverrideSystemUserVariableSkeletalMeshComponent_FunctionAddress != IntPtr.Zero && OverrideSystemUserVariableSkeletalMeshComponent_NiagaraSystem_IsValid && OverrideSystemUserVariableSkeletalMeshComponent_OverrideName_IsValid && OverrideSystemUserVariableSkeletalMeshComponent_SkeletalMeshComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:OverrideSystemUserVariableSkeletalMeshComponent", OverrideSystemUserVariableSkeletalMeshComponent_IsValid);
		GetNiagaraParameterCollection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNiagaraParameterCollection");
		GetNiagaraParameterCollection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNiagaraParameterCollection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraParameterCollection_WorldContextObject_PropertyAddress, GetNiagaraParameterCollection_FunctionAddress, "WorldContextObject");
		GetNiagaraParameterCollection_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraParameterCollection_FunctionAddress, "WorldContextObject");
		GetNiagaraParameterCollection_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraParameterCollection_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraParameterCollection_Collection_PropertyAddress, GetNiagaraParameterCollection_FunctionAddress, "Collection");
		GetNiagaraParameterCollection_Collection_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraParameterCollection_FunctionAddress, "Collection");
		GetNiagaraParameterCollection_Collection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraParameterCollection_FunctionAddress, "Collection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNiagaraParameterCollection_ReturnValue_PropertyAddress, GetNiagaraParameterCollection_FunctionAddress, "ReturnValue");
		GetNiagaraParameterCollection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNiagaraParameterCollection_FunctionAddress, "ReturnValue");
		GetNiagaraParameterCollection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNiagaraParameterCollection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetNiagaraParameterCollection_IsValid = GetNiagaraParameterCollection_FunctionAddress != IntPtr.Zero && GetNiagaraParameterCollection_WorldContextObject_IsValid && GetNiagaraParameterCollection_Collection_IsValid && GetNiagaraParameterCollection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:GetNiagaraParameterCollection", GetNiagaraParameterCollection_IsValid);
		AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AcquireNiagaraGPURayTracedCollisionGroup");
		AcquireNiagaraGPURayTracedCollisionGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_PropertyAddress, AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject");
		AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_PropertyAddress, AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress, "ReturnValue");
		AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress, "ReturnValue");
		AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AcquireNiagaraGPURayTracedCollisionGroup_IsValid = AcquireNiagaraGPURayTracedCollisionGroup_FunctionAddress != IntPtr.Zero && AcquireNiagaraGPURayTracedCollisionGroup_WorldContextObject_IsValid && AcquireNiagaraGPURayTracedCollisionGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraFunctionLibrary:AcquireNiagaraGPURayTracedCollisionGroup", AcquireNiagaraGPURayTracedCollisionGroup_IsValid);
	}
}
