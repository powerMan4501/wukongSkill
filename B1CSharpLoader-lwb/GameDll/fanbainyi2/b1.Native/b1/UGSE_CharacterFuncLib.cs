using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_CharacterFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ToggleActorTickEnabled_IsValid;

	private static IntPtr ToggleActorTickEnabled_FunctionAddress;

	private static int ToggleActorTickEnabled_ParamsSize;

	private static bool ToggleActorTickEnabled_InActor_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_InActor_PropertyAddress;

	private static int ToggleActorTickEnabled_InActor_Offset;

	private static bool ToggleActorTickEnabled_bEnable_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_bEnable_PropertyAddress;

	private static int ToggleActorTickEnabled_bEnable_Offset;

	private static bool ToggleActorTickEnabled_ToggleActorTick_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_ToggleActorTick_PropertyAddress;

	private static int ToggleActorTickEnabled_ToggleActorTick_Offset;

	private static bool ToggleActorTickEnabled_ToggleMoveComp_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_ToggleMoveComp_PropertyAddress;

	private static int ToggleActorTickEnabled_ToggleMoveComp_Offset;

	private static bool ToggleActorTickEnabled_ToggleAIComp_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_ToggleAIComp_PropertyAddress;

	private static int ToggleActorTickEnabled_ToggleAIComp_Offset;

	private static bool ToggleActorTickEnabled_ToggleSKMeshComp_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_ToggleSKMeshComp_PropertyAddress;

	private static int ToggleActorTickEnabled_ToggleSKMeshComp_Offset;

	private static bool ToggleActorTickEnabled_ToggleAkComp_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_ToggleAkComp_PropertyAddress;

	private static int ToggleActorTickEnabled_ToggleAkComp_Offset;

	private static bool ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_IsValid;

	private static FFieldAddress ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_PropertyAddress;

	private static int ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_Offset;

	private static bool Tick_IsValid;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_Actor_IsValid;

	private static FFieldAddress Tick_Actor_PropertyAddress;

	private static int Tick_Actor_Offset;

	private static bool Tick_DeltaTime_IsValid;

	private static FFieldAddress Tick_DeltaTime_PropertyAddress;

	private static int Tick_DeltaTime_Offset;

	private static bool SetMontagePlayRate_IsValid;

	private static IntPtr SetMontagePlayRate_FunctionAddress;

	private static int SetMontagePlayRate_ParamsSize;

	private static bool SetMontagePlayRate_Character_IsValid;

	private static FFieldAddress SetMontagePlayRate_Character_PropertyAddress;

	private static int SetMontagePlayRate_Character_Offset;

	private static bool SetMontagePlayRate_PlayRate_IsValid;

	private static FFieldAddress SetMontagePlayRate_PlayRate_PropertyAddress;

	private static int SetMontagePlayRate_PlayRate_Offset;

	private static bool SetLocalScreenPercentageIfLocalController_IsValid;

	private static IntPtr SetLocalScreenPercentageIfLocalController_FunctionAddress;

	private static int SetLocalScreenPercentageIfLocalController_ParamsSize;

	private static bool SetLocalScreenPercentageIfLocalController_Actor_IsValid;

	private static FFieldAddress SetLocalScreenPercentageIfLocalController_Actor_PropertyAddress;

	private static int SetLocalScreenPercentageIfLocalController_Actor_Offset;

	private static bool SetLocalScreenPercentageIfLocalController_Controller_IsValid;

	private static FFieldAddress SetLocalScreenPercentageIfLocalController_Controller_PropertyAddress;

	private static int SetLocalScreenPercentageIfLocalController_Controller_Offset;

	private static bool SetLocalScreenPercentageIfLocalController_ScreenPercentage_IsValid;

	private static FFieldAddress SetLocalScreenPercentageIfLocalController_ScreenPercentage_PropertyAddress;

	private static int SetLocalScreenPercentageIfLocalController_ScreenPercentage_Offset;

	private static bool SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_IsValid;

	private static FFieldAddress SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_PropertyAddress;

	private static int SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_Offset;

	private static bool SetAnimRootMotionTranslationScale_IsValid;

	private static IntPtr SetAnimRootMotionTranslationScale_FunctionAddress;

	private static int SetAnimRootMotionTranslationScale_ParamsSize;

	private static bool SetAnimRootMotionTranslationScale_Character_IsValid;

	private static FFieldAddress SetAnimRootMotionTranslationScale_Character_PropertyAddress;

	private static int SetAnimRootMotionTranslationScale_Character_Offset;

	private static bool SetAnimRootMotionTranslationScale_Scale_IsValid;

	private static FFieldAddress SetAnimRootMotionTranslationScale_Scale_PropertyAddress;

	private static int SetAnimRootMotionTranslationScale_Scale_Offset;

	private static bool SetAllPABodiesBelowResponseToChannels_IsValid;

	private static IntPtr SetAllPABodiesBelowResponseToChannels_FunctionAddress;

	private static int SetAllPABodiesBelowResponseToChannels_ParamsSize;

	private static bool SetAllPABodiesBelowResponseToChannels_Mesh_IsValid;

	private static FFieldAddress SetAllPABodiesBelowResponseToChannels_Mesh_PropertyAddress;

	private static int SetAllPABodiesBelowResponseToChannels_Mesh_Offset;

	private static bool SetAllPABodiesBelowResponseToChannels_BoneName_IsValid;

	private static FFieldAddress SetAllPABodiesBelowResponseToChannels_BoneName_PropertyAddress;

	private static int SetAllPABodiesBelowResponseToChannels_BoneName_Offset;

	private static bool SetAllPABodiesBelowResponseToChannels_Channels_IsValid;

	private static FFieldAddress SetAllPABodiesBelowResponseToChannels_Channels_PropertyAddress;

	private static int SetAllPABodiesBelowResponseToChannels_Channels_Offset;

	private static bool SetAllPABodiesBelowResponseToChannels_NewResponse_IsValid;

	private static FFieldAddress SetAllPABodiesBelowResponseToChannels_NewResponse_PropertyAddress;

	private static int SetAllPABodiesBelowResponseToChannels_NewResponse_Offset;

	private static bool SetAllPABodiesBelowResponseToAllChannels_IsValid;

	private static IntPtr SetAllPABodiesBelowResponseToAllChannels_FunctionAddress;

	private static int SetAllPABodiesBelowResponseToAllChannels_ParamsSize;

	private static bool SetAllPABodiesBelowResponseToAllChannels_Mesh_IsValid;

	private static FFieldAddress SetAllPABodiesBelowResponseToAllChannels_Mesh_PropertyAddress;

	private static int SetAllPABodiesBelowResponseToAllChannels_Mesh_Offset;

	private static bool SetAllPABodiesBelowResponseToAllChannels_BoneName_IsValid;

	private static FFieldAddress SetAllPABodiesBelowResponseToAllChannels_BoneName_PropertyAddress;

	private static int SetAllPABodiesBelowResponseToAllChannels_BoneName_Offset;

	private static bool SetAllPABodiesBelowResponseToAllChannels_NewResponse_IsValid;

	private static FFieldAddress SetAllPABodiesBelowResponseToAllChannels_NewResponse_PropertyAddress;

	private static int SetAllPABodiesBelowResponseToAllChannels_NewResponse_Offset;

	private static bool SetActorSKMeshesUpdateRateOptimizations_IsValid;

	private static IntPtr SetActorSKMeshesUpdateRateOptimizations_FunctionAddress;

	private static int SetActorSKMeshesUpdateRateOptimizations_ParamsSize;

	private static bool SetActorSKMeshesUpdateRateOptimizations_Actor_IsValid;

	private static FFieldAddress SetActorSKMeshesUpdateRateOptimizations_Actor_PropertyAddress;

	private static int SetActorSKMeshesUpdateRateOptimizations_Actor_Offset;

	private static bool SetActorSKMeshesUpdateRateOptimizations_bEnable_IsValid;

	private static FFieldAddress SetActorSKMeshesUpdateRateOptimizations_bEnable_PropertyAddress;

	private static int SetActorSKMeshesUpdateRateOptimizations_bEnable_Offset;

	private static bool RecreatePhysicsState_IsValid;

	private static IntPtr RecreatePhysicsState_FunctionAddress;

	private static int RecreatePhysicsState_ParamsSize;

	private static bool RecreatePhysicsState_mesh_IsValid;

	private static FFieldAddress RecreatePhysicsState_mesh_PropertyAddress;

	private static int RecreatePhysicsState_mesh_Offset;

	private static bool MarkDirtyCharacter_IsValid;

	private static IntPtr MarkDirtyCharacter_FunctionAddress;

	private static int MarkDirtyCharacter_ParamsSize;

	private static bool MarkDirtyCharacter_DirtyCharacter_IsValid;

	private static FFieldAddress MarkDirtyCharacter_DirtyCharacter_PropertyAddress;

	private static int MarkDirtyCharacter_DirtyCharacter_Offset;

	private static bool MarkDirtyBPActor_IsValid;

	private static IntPtr MarkDirtyBPActor_FunctionAddress;

	private static int MarkDirtyBPActor_ParamsSize;

	private static bool MarkDirtyBPActor_DirtyBPActor_IsValid;

	private static FFieldAddress MarkDirtyBPActor_DirtyBPActor_PropertyAddress;

	private static int MarkDirtyBPActor_DirtyBPActor_Offset;

	private static bool GetSocketTransform_IsValid;

	private static IntPtr GetSocketTransform_FunctionAddress;

	private static int GetSocketTransform_ParamsSize;

	private static bool GetSocketTransform_Comp_IsValid;

	private static FFieldAddress GetSocketTransform_Comp_PropertyAddress;

	private static int GetSocketTransform_Comp_Offset;

	private static bool GetSocketTransform_SocketName_IsValid;

	private static FFieldAddress GetSocketTransform_SocketName_PropertyAddress;

	private static int GetSocketTransform_SocketName_Offset;

	private static bool GetSocketTransform_TransfromSpace_IsValid;

	private static FFieldAddress GetSocketTransform_TransfromSpace_PropertyAddress;

	private static int GetSocketTransform_TransfromSpace_Offset;

	private static bool GetSocketTransform_ReturnValue_IsValid;

	private static FFieldAddress GetSocketTransform_ReturnValue_PropertyAddress;

	private static int GetSocketTransform_ReturnValue_Offset;

	private static bool GetSocketRotation_IsValid;

	private static IntPtr GetSocketRotation_FunctionAddress;

	private static int GetSocketRotation_ParamsSize;

	private static bool GetSocketRotation_Comp_IsValid;

	private static FFieldAddress GetSocketRotation_Comp_PropertyAddress;

	private static int GetSocketRotation_Comp_Offset;

	private static bool GetSocketRotation_SocketName_IsValid;

	private static FFieldAddress GetSocketRotation_SocketName_PropertyAddress;

	private static int GetSocketRotation_SocketName_Offset;

	private static bool GetSocketRotation_ReturnValue_IsValid;

	private static FFieldAddress GetSocketRotation_ReturnValue_PropertyAddress;

	private static int GetSocketRotation_ReturnValue_Offset;

	private static bool GetSocketLocation_IsValid;

	private static IntPtr GetSocketLocation_FunctionAddress;

	private static int GetSocketLocation_ParamsSize;

	private static bool GetSocketLocation_Comp_IsValid;

	private static FFieldAddress GetSocketLocation_Comp_PropertyAddress;

	private static int GetSocketLocation_Comp_Offset;

	private static bool GetSocketLocation_SocketName_IsValid;

	private static FFieldAddress GetSocketLocation_SocketName_PropertyAddress;

	private static int GetSocketLocation_SocketName_Offset;

	private static bool GetSocketLocation_ReturnValue_IsValid;

	private static FFieldAddress GetSocketLocation_ReturnValue_PropertyAddress;

	private static int GetSocketLocation_ReturnValue_Offset;

	private static bool GetSceneComponentTransformByName_IsValid;

	private static IntPtr GetSceneComponentTransformByName_FunctionAddress;

	private static int GetSceneComponentTransformByName_ParamsSize;

	private static bool GetSceneComponentTransformByName_Actor_IsValid;

	private static FFieldAddress GetSceneComponentTransformByName_Actor_PropertyAddress;

	private static int GetSceneComponentTransformByName_Actor_Offset;

	private static bool GetSceneComponentTransformByName_ComponentName_IsValid;

	private static FFieldAddress GetSceneComponentTransformByName_ComponentName_PropertyAddress;

	private static int GetSceneComponentTransformByName_ComponentName_Offset;

	private static bool GetSceneComponentTransformByName_ReturnValue_IsValid;

	private static FFieldAddress GetSceneComponentTransformByName_ReturnValue_PropertyAddress;

	private static int GetSceneComponentTransformByName_ReturnValue_Offset;

	private static bool GetSceneComponentByName_IsValid;

	private static IntPtr GetSceneComponentByName_FunctionAddress;

	private static int GetSceneComponentByName_ParamsSize;

	private static bool GetSceneComponentByName_Actor_IsValid;

	private static FFieldAddress GetSceneComponentByName_Actor_PropertyAddress;

	private static int GetSceneComponentByName_Actor_Offset;

	private static bool GetSceneComponentByName_ComponentName_IsValid;

	private static FFieldAddress GetSceneComponentByName_ComponentName_PropertyAddress;

	private static int GetSceneComponentByName_ComponentName_Offset;

	private static bool GetSceneComponentByName_ReturnValue_IsValid;

	private static FFieldAddress GetSceneComponentByName_ReturnValue_PropertyAddress;

	private static int GetSceneComponentByName_ReturnValue_Offset;

	private static bool GetPathFollowingBrakingDistance_IsValid;

	private static IntPtr GetPathFollowingBrakingDistance_FunctionAddress;

	private static int GetPathFollowingBrakingDistance_ParamsSize;

	private static bool GetPathFollowingBrakingDistance_CharacterMovement_IsValid;

	private static FFieldAddress GetPathFollowingBrakingDistance_CharacterMovement_PropertyAddress;

	private static int GetPathFollowingBrakingDistance_CharacterMovement_Offset;

	private static bool GetPathFollowingBrakingDistance_ReturnValue_IsValid;

	private static FFieldAddress GetPathFollowingBrakingDistance_ReturnValue_PropertyAddress;

	private static int GetPathFollowingBrakingDistance_ReturnValue_Offset;

	private static bool GetBPObjForMarkDirty_IsValid;

	private static IntPtr GetBPObjForMarkDirty_FunctionAddress;

	private static int GetBPObjForMarkDirty_ParamsSize;

	private static bool GetBPObjForMarkDirty_Obj_IsValid;

	private static FFieldAddress GetBPObjForMarkDirty_Obj_PropertyAddress;

	private static int GetBPObjForMarkDirty_Obj_Offset;

	private static bool GetBPObjForMarkDirty_ReturnValue_IsValid;

	private static FFieldAddress GetBPObjForMarkDirty_ReturnValue_PropertyAddress;

	private static int GetBPObjForMarkDirty_ReturnValue_Offset;

	private static bool GetBoneTransformByMesh_IsValid;

	private static IntPtr GetBoneTransformByMesh_FunctionAddress;

	private static int GetBoneTransformByMesh_ParamsSize;

	private static bool GetBoneTransformByMesh_Mesh_IsValid;

	private static FFieldAddress GetBoneTransformByMesh_Mesh_PropertyAddress;

	private static int GetBoneTransformByMesh_Mesh_Offset;

	private static bool GetBoneTransformByMesh_BoneIndex_IsValid;

	private static FFieldAddress GetBoneTransformByMesh_BoneIndex_PropertyAddress;

	private static int GetBoneTransformByMesh_BoneIndex_Offset;

	private static bool GetBoneTransformByMesh_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTransformByMesh_ReturnValue_PropertyAddress;

	private static int GetBoneTransformByMesh_ReturnValue_Offset;

	private static bool GetBoneTransform_IsValid;

	private static IntPtr GetBoneTransform_FunctionAddress;

	private static int GetBoneTransform_ParamsSize;

	private static bool GetBoneTransform_Character_IsValid;

	private static FFieldAddress GetBoneTransform_Character_PropertyAddress;

	private static int GetBoneTransform_Character_Offset;

	private static bool GetBoneTransform_BoneIndex_IsValid;

	private static FFieldAddress GetBoneTransform_BoneIndex_PropertyAddress;

	private static int GetBoneTransform_BoneIndex_Offset;

	private static bool GetBoneTransform_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTransform_ReturnValue_PropertyAddress;

	private static int GetBoneTransform_ReturnValue_Offset;

	private static bool GetAllCharactersForMarkDirty_IsValid;

	private static IntPtr GetAllCharactersForMarkDirty_FunctionAddress;

	private static int GetAllCharactersForMarkDirty_ParamsSize;

	private static bool GetAllCharactersForMarkDirty_ResourcePath_IsValid;

	private static FFieldAddress GetAllCharactersForMarkDirty_ResourcePath_PropertyAddress;

	private static int GetAllCharactersForMarkDirty_ResourcePath_Offset;

	private static bool GetAllCharactersForMarkDirty_ReturnValue_IsValid;

	private static FFieldAddress GetAllCharactersForMarkDirty_ReturnValue_PropertyAddress;

	private static int GetAllCharactersForMarkDirty_ReturnValue_Offset;

	private static bool GetActorBoundingSphereRadius_IsValid;

	private static IntPtr GetActorBoundingSphereRadius_FunctionAddress;

	private static int GetActorBoundingSphereRadius_ParamsSize;

	private static bool GetActorBoundingSphereRadius_Actor_IsValid;

	private static FFieldAddress GetActorBoundingSphereRadius_Actor_PropertyAddress;

	private static int GetActorBoundingSphereRadius_Actor_Offset;

	private static bool GetActorBoundingSphereRadius_ReturnValue_IsValid;

	private static FFieldAddress GetActorBoundingSphereRadius_ReturnValue_PropertyAddress;

	private static int GetActorBoundingSphereRadius_ReturnValue_Offset;

	private static bool CalculateScreenPercentageFromController_IsValid;

	private static IntPtr CalculateScreenPercentageFromController_FunctionAddress;

	private static int CalculateScreenPercentageFromController_ParamsSize;

	private static bool CalculateScreenPercentageFromController_Actor_IsValid;

	private static FFieldAddress CalculateScreenPercentageFromController_Actor_PropertyAddress;

	private static int CalculateScreenPercentageFromController_Actor_Offset;

	private static bool CalculateScreenPercentageFromController_Controller_IsValid;

	private static FFieldAddress CalculateScreenPercentageFromController_Controller_PropertyAddress;

	private static int CalculateScreenPercentageFromController_Controller_Offset;

	private static bool CalculateScreenPercentageFromController_ReturnValue_IsValid;

	private static FFieldAddress CalculateScreenPercentageFromController_ReturnValue_PropertyAddress;

	private static int CalculateScreenPercentageFromController_ReturnValue_Offset;

	private static bool CalculateMaxDistanceFactor_IsValid;

	private static IntPtr CalculateMaxDistanceFactor_FunctionAddress;

	private static int CalculateMaxDistanceFactor_ParamsSize;

	private static bool CalculateMaxDistanceFactor_Actor_IsValid;

	private static FFieldAddress CalculateMaxDistanceFactor_Actor_PropertyAddress;

	private static int CalculateMaxDistanceFactor_Actor_Offset;

	private static bool CalculateMaxDistanceFactor_ReturnValue_IsValid;

	private static FFieldAddress CalculateMaxDistanceFactor_ReturnValue_PropertyAddress;

	private static int CalculateMaxDistanceFactor_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:ToggleActorTickEnabled")]
	public unsafe static void ToggleActorTickEnabled(AActor InActor, bool bEnable, bool ToggleActorTick, bool ToggleMoveComp, bool ToggleAIComp, bool ToggleSKMeshComp, bool ToggleAkComp, bool ToggleINCLUDE_CHILD_ACTOR)
	{
		if (!ToggleActorTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:ToggleActorTickEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleActorTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleActorTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_InActor_Offset), 0, ToggleActorTickEnabled_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_bEnable_Offset), 0, ToggleActorTickEnabled_bEnable_PropertyAddress.Address, bEnable);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_ToggleActorTick_Offset), 0, ToggleActorTickEnabled_ToggleActorTick_PropertyAddress.Address, ToggleActorTick);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_ToggleMoveComp_Offset), 0, ToggleActorTickEnabled_ToggleMoveComp_PropertyAddress.Address, ToggleMoveComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_ToggleAIComp_Offset), 0, ToggleActorTickEnabled_ToggleAIComp_PropertyAddress.Address, ToggleAIComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_ToggleSKMeshComp_Offset), 0, ToggleActorTickEnabled_ToggleSKMeshComp_PropertyAddress.Address, ToggleSKMeshComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_ToggleAkComp_Offset), 0, ToggleActorTickEnabled_ToggleAkComp_PropertyAddress.Address, ToggleAkComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_Offset), 0, ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_PropertyAddress.Address, ToggleINCLUDE_CHILD_ACTOR);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToggleActorTickEnabled_FunctionAddress, intPtr, ToggleActorTickEnabled_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:Tick")]
	public unsafe static void Tick(AActor Actor, float DeltaTime)
	{
		if (!Tick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:Tick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, Tick_Actor_Offset), 0, Tick_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tick_DeltaTime_Offset), 0, Tick_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Tick_FunctionAddress, intPtr, Tick_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:SetMontagePlayRate")]
	public unsafe static void SetMontagePlayRate(ACharacter Character, float PlayRate)
	{
		if (!SetMontagePlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:SetMontagePlayRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMontagePlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMontagePlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, SetMontagePlayRate_Character_Offset), 0, SetMontagePlayRate_Character_PropertyAddress.Address, Character);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMontagePlayRate_PlayRate_Offset), 0, SetMontagePlayRate_PlayRate_PropertyAddress.Address, PlayRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMontagePlayRate_FunctionAddress, intPtr, SetMontagePlayRate_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:SetLocalScreenPercentageIfLocalController")]
	public unsafe static void SetLocalScreenPercentageIfLocalController(AActor Actor, AController Controller, float ScreenPercentage, out float OutLocalScreenPercentage)
	{
		if (!SetLocalScreenPercentageIfLocalController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:SetLocalScreenPercentageIfLocalController");
			OutLocalScreenPercentage = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalScreenPercentageIfLocalController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalScreenPercentageIfLocalController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetLocalScreenPercentageIfLocalController_Actor_Offset), 0, SetLocalScreenPercentageIfLocalController_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, SetLocalScreenPercentageIfLocalController_Controller_Offset), 0, SetLocalScreenPercentageIfLocalController_Controller_PropertyAddress.Address, Controller);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLocalScreenPercentageIfLocalController_ScreenPercentage_Offset), 0, SetLocalScreenPercentageIfLocalController_ScreenPercentage_PropertyAddress.Address, ScreenPercentage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLocalScreenPercentageIfLocalController_FunctionAddress, intPtr, SetLocalScreenPercentageIfLocalController_ParamsSize);
		OutLocalScreenPercentage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_Offset), 0, SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAnimRootMotionTranslationScale")]
	public unsafe static void SetAnimRootMotionTranslationScale(ACharacter Character, float Scale)
	{
		if (!SetAnimRootMotionTranslationScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAnimRootMotionTranslationScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimRootMotionTranslationScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimRootMotionTranslationScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, SetAnimRootMotionTranslationScale_Character_Offset), 0, SetAnimRootMotionTranslationScale_Character_PropertyAddress.Address, Character);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimRootMotionTranslationScale_Scale_Offset), 0, SetAnimRootMotionTranslationScale_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAnimRootMotionTranslationScale_FunctionAddress, intPtr, SetAnimRootMotionTranslationScale_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAllPABodiesBelowResponseToChannels")]
	public unsafe static void SetAllPABodiesBelowResponseToChannels(USkeletalMeshComponent Mesh, FName BoneName, List<ECollisionChannel> Channels, ECollisionResponseType NewResponse)
	{
		if (!SetAllPABodiesBelowResponseToChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAllPABodiesBelowResponseToChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllPABodiesBelowResponseToChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllPABodiesBelowResponseToChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetAllPABodiesBelowResponseToChannels_Mesh_Offset), 0, SetAllPABodiesBelowResponseToChannels_Mesh_PropertyAddress.Address, Mesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAllPABodiesBelowResponseToChannels_BoneName_Offset), 0, SetAllPABodiesBelowResponseToChannels_BoneName_PropertyAddress.Address, BoneName);
		new TArrayCopyMarshaler<ECollisionChannel>(1, SetAllPABodiesBelowResponseToChannels_Channels_PropertyAddress, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.FromNative, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.ToNative).ToNative(IntPtr.Add(intPtr, SetAllPABodiesBelowResponseToChannels_Channels_Offset), Channels);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetAllPABodiesBelowResponseToChannels_NewResponse_Offset), 0, SetAllPABodiesBelowResponseToChannels_NewResponse_PropertyAddress.Address, NewResponse);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAllPABodiesBelowResponseToChannels_FunctionAddress, intPtr, SetAllPABodiesBelowResponseToChannels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAllPABodiesBelowResponseToChannels_Channels_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAllPABodiesBelowResponseToAllChannels")]
	public unsafe static void SetAllPABodiesBelowResponseToAllChannels(USkeletalMeshComponent Mesh, FName BoneName, ECollisionResponseType NewResponse)
	{
		if (!SetAllPABodiesBelowResponseToAllChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAllPABodiesBelowResponseToAllChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllPABodiesBelowResponseToAllChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllPABodiesBelowResponseToAllChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetAllPABodiesBelowResponseToAllChannels_Mesh_Offset), 0, SetAllPABodiesBelowResponseToAllChannels_Mesh_PropertyAddress.Address, Mesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAllPABodiesBelowResponseToAllChannels_BoneName_Offset), 0, SetAllPABodiesBelowResponseToAllChannels_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<ECollisionResponseType>.ToNative(IntPtr.Add(intPtr, SetAllPABodiesBelowResponseToAllChannels_NewResponse_Offset), 0, SetAllPABodiesBelowResponseToAllChannels_NewResponse_PropertyAddress.Address, NewResponse);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, intPtr, SetAllPABodiesBelowResponseToAllChannels_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:SetActorSKMeshesUpdateRateOptimizations")]
	public unsafe static void SetActorSKMeshesUpdateRateOptimizations(AActor Actor, bool bEnable)
	{
		if (!SetActorSKMeshesUpdateRateOptimizations_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:SetActorSKMeshesUpdateRateOptimizations");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorSKMeshesUpdateRateOptimizations_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorSKMeshesUpdateRateOptimizations_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorSKMeshesUpdateRateOptimizations_Actor_Offset), 0, SetActorSKMeshesUpdateRateOptimizations_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorSKMeshesUpdateRateOptimizations_bEnable_Offset), 0, SetActorSKMeshesUpdateRateOptimizations_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorSKMeshesUpdateRateOptimizations_FunctionAddress, intPtr, SetActorSKMeshesUpdateRateOptimizations_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:RecreatePhysicsState")]
	public unsafe static void RecreatePhysicsState(USkeletalMeshComponent mesh)
	{
		if (!RecreatePhysicsState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:RecreatePhysicsState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecreatePhysicsState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecreatePhysicsState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, RecreatePhysicsState_mesh_Offset), 0, RecreatePhysicsState_mesh_PropertyAddress.Address, mesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecreatePhysicsState_FunctionAddress, intPtr, RecreatePhysicsState_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:MarkDirtyCharacter")]
	public unsafe static void MarkDirtyCharacter(ACharacter DirtyCharacter)
	{
		if (!MarkDirtyCharacter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:MarkDirtyCharacter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkDirtyCharacter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkDirtyCharacter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, MarkDirtyCharacter_DirtyCharacter_Offset), 0, MarkDirtyCharacter_DirtyCharacter_PropertyAddress.Address, DirtyCharacter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkDirtyCharacter_FunctionAddress, intPtr, MarkDirtyCharacter_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:MarkDirtyBPActor")]
	public unsafe static void MarkDirtyBPActor(AActor DirtyBPActor)
	{
		if (!MarkDirtyBPActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:MarkDirtyBPActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkDirtyBPActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkDirtyBPActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, MarkDirtyBPActor_DirtyBPActor_Offset), 0, MarkDirtyBPActor_DirtyBPActor_PropertyAddress.Address, DirtyBPActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkDirtyBPActor_FunctionAddress, intPtr, MarkDirtyBPActor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketTransform")]
	public unsafe static FTransform GetSocketTransform(USceneComponent Comp, FName SocketName, ERelativeTransformSpace TransfromSpace = ERelativeTransformSpace.RTS_World)
	{
		if (!GetSocketTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, GetSocketTransform_Comp_Offset), 0, GetSocketTransform_Comp_PropertyAddress.Address, Comp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSocketTransform_SocketName_Offset), 0, GetSocketTransform_SocketName_PropertyAddress.Address, SocketName);
		EnumMarshaler<ERelativeTransformSpace>.ToNative(IntPtr.Add(intPtr, GetSocketTransform_TransfromSpace_Offset), 0, GetSocketTransform_TransfromSpace_PropertyAddress.Address, TransfromSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSocketTransform_FunctionAddress, intPtr, GetSocketTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetSocketTransform_ReturnValue_Offset), 0, GetSocketTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketRotation")]
	public unsafe static FRotator GetSocketRotation(USceneComponent Comp, FName SocketName)
	{
		if (!GetSocketRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, GetSocketRotation_Comp_Offset), 0, GetSocketRotation_Comp_PropertyAddress.Address, Comp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSocketRotation_SocketName_Offset), 0, GetSocketRotation_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSocketRotation_FunctionAddress, intPtr, GetSocketRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetSocketRotation_ReturnValue_Offset), 0, GetSocketRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketLocation")]
	public unsafe static FVector GetSocketLocation(USceneComponent Comp, FName SocketName)
	{
		if (!GetSocketLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, GetSocketLocation_Comp_Offset), 0, GetSocketLocation_Comp_PropertyAddress.Address, Comp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetSocketLocation_SocketName_Offset), 0, GetSocketLocation_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSocketLocation_FunctionAddress, intPtr, GetSocketLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSocketLocation_ReturnValue_Offset), 0, GetSocketLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSceneComponentTransformByName")]
	public unsafe static FTransform GetSceneComponentTransformByName(AActor Actor, string ComponentName)
	{
		if (!GetSceneComponentTransformByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSceneComponentTransformByName");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneComponentTransformByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneComponentTransformByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetSceneComponentTransformByName_Actor_Offset), 0, GetSceneComponentTransformByName_Actor_PropertyAddress.Address, Actor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSceneComponentTransformByName_ComponentName_Offset), 0, GetSceneComponentTransformByName_ComponentName_PropertyAddress.Address, ComponentName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSceneComponentTransformByName_FunctionAddress, intPtr, GetSceneComponentTransformByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSceneComponentTransformByName_ComponentName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetSceneComponentTransformByName_ReturnValue_Offset), 0, GetSceneComponentTransformByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSceneComponentByName")]
	public unsafe static USceneComponent GetSceneComponentByName(AActor Actor, string ComponentName)
	{
		if (!GetSceneComponentByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSceneComponentByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSceneComponentByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSceneComponentByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetSceneComponentByName_Actor_Offset), 0, GetSceneComponentByName_Actor_PropertyAddress.Address, Actor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSceneComponentByName_ComponentName_Offset), 0, GetSceneComponentByName_ComponentName_PropertyAddress.Address, ComponentName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSceneComponentByName_FunctionAddress, intPtr, GetSceneComponentByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSceneComponentByName_ComponentName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(intPtr, GetSceneComponentByName_ReturnValue_Offset), 0, GetSceneComponentByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetPathFollowingBrakingDistance")]
	public unsafe static float GetPathFollowingBrakingDistance(UCharacterMovementComponent CharacterMovement)
	{
		if (!GetPathFollowingBrakingDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetPathFollowingBrakingDistance");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathFollowingBrakingDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathFollowingBrakingDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCharacterMovementComponent>.ToNative(IntPtr.Add(intPtr, GetPathFollowingBrakingDistance_CharacterMovement_Offset), 0, GetPathFollowingBrakingDistance_CharacterMovement_PropertyAddress.Address, CharacterMovement);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPathFollowingBrakingDistance_FunctionAddress, intPtr, GetPathFollowingBrakingDistance_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPathFollowingBrakingDistance_ReturnValue_Offset), 0, GetPathFollowingBrakingDistance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBPObjForMarkDirty")]
	public unsafe static AActor GetBPObjForMarkDirty(UObject Obj)
	{
		if (!GetBPObjForMarkDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBPObjForMarkDirty");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBPObjForMarkDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBPObjForMarkDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetBPObjForMarkDirty_Obj_Offset), 0, GetBPObjForMarkDirty_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBPObjForMarkDirty_FunctionAddress, intPtr, GetBPObjForMarkDirty_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetBPObjForMarkDirty_ReturnValue_Offset), 0, GetBPObjForMarkDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBoneTransformByMesh")]
	public unsafe static FTransform GetBoneTransformByMesh(USkeletalMeshComponent Mesh, int BoneIndex)
	{
		if (!GetBoneTransformByMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBoneTransformByMesh");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTransformByMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTransformByMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetBoneTransformByMesh_Mesh_Offset), 0, GetBoneTransformByMesh_Mesh_PropertyAddress.Address, Mesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBoneTransformByMesh_BoneIndex_Offset), 0, GetBoneTransformByMesh_BoneIndex_PropertyAddress.Address, BoneIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneTransformByMesh_FunctionAddress, intPtr, GetBoneTransformByMesh_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBoneTransformByMesh_ReturnValue_Offset), 0, GetBoneTransformByMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBoneTransform")]
	public unsafe static FTransform GetBoneTransform(ACharacter Character, int BoneIndex)
	{
		if (!GetBoneTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBoneTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, GetBoneTransform_Character_Offset), 0, GetBoneTransform_Character_PropertyAddress.Address, Character);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBoneTransform_BoneIndex_Offset), 0, GetBoneTransform_BoneIndex_PropertyAddress.Address, BoneIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoneTransform_FunctionAddress, intPtr, GetBoneTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBoneTransform_ReturnValue_Offset), 0, GetBoneTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetAllCharactersForMarkDirty")]
	public unsafe static List<AActor> GetAllCharactersForMarkDirty(string ResourcePath)
	{
		if (!GetAllCharactersForMarkDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetAllCharactersForMarkDirty");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllCharactersForMarkDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllCharactersForMarkDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAllCharactersForMarkDirty_ResourcePath_Offset), 0, GetAllCharactersForMarkDirty_ResourcePath_PropertyAddress.Address, ResourcePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllCharactersForMarkDirty_FunctionAddress, intPtr, GetAllCharactersForMarkDirty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllCharactersForMarkDirty_ResourcePath_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetAllCharactersForMarkDirty_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllCharactersForMarkDirty_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllCharactersForMarkDirty_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:GetActorBoundingSphereRadius")]
	public unsafe static float GetActorBoundingSphereRadius(AActor Actor)
	{
		if (!GetActorBoundingSphereRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:GetActorBoundingSphereRadius");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorBoundingSphereRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorBoundingSphereRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorBoundingSphereRadius_Actor_Offset), 0, GetActorBoundingSphereRadius_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorBoundingSphereRadius_FunctionAddress, intPtr, GetActorBoundingSphereRadius_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetActorBoundingSphereRadius_ReturnValue_Offset), 0, GetActorBoundingSphereRadius_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:CalculateScreenPercentageFromController")]
	public unsafe static float CalculateScreenPercentageFromController(AActor Actor, AController Controller)
	{
		if (!CalculateScreenPercentageFromController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:CalculateScreenPercentageFromController");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateScreenPercentageFromController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateScreenPercentageFromController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CalculateScreenPercentageFromController_Actor_Offset), 0, CalculateScreenPercentageFromController_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, CalculateScreenPercentageFromController_Controller_Offset), 0, CalculateScreenPercentageFromController_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateScreenPercentageFromController_FunctionAddress, intPtr, CalculateScreenPercentageFromController_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalculateScreenPercentageFromController_ReturnValue_Offset), 0, CalculateScreenPercentageFromController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_CharacterFuncLib:CalculateMaxDistanceFactor")]
	public unsafe static float CalculateMaxDistanceFactor(AActor Actor)
	{
		if (!CalculateMaxDistanceFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_CharacterFuncLib:CalculateMaxDistanceFactor");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateMaxDistanceFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateMaxDistanceFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CalculateMaxDistanceFactor_Actor_Offset), 0, CalculateMaxDistanceFactor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateMaxDistanceFactor_FunctionAddress, intPtr, CalculateMaxDistanceFactor_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalculateMaxDistanceFactor_ReturnValue_Offset), 0, CalculateMaxDistanceFactor_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_CharacterFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_CharacterFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_CharacterFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_CharacterFuncLib");
		ToggleActorTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToggleActorTickEnabled");
		ToggleActorTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleActorTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_InActor_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "InActor");
		ToggleActorTickEnabled_InActor_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "InActor");
		ToggleActorTickEnabled_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_bEnable_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "bEnable");
		ToggleActorTickEnabled_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "bEnable");
		ToggleActorTickEnabled_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "bEnable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_ToggleActorTick_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "ToggleActorTick");
		ToggleActorTickEnabled_ToggleActorTick_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "ToggleActorTick");
		ToggleActorTickEnabled_ToggleActorTick_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "ToggleActorTick", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_ToggleMoveComp_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "ToggleMoveComp");
		ToggleActorTickEnabled_ToggleMoveComp_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "ToggleMoveComp");
		ToggleActorTickEnabled_ToggleMoveComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "ToggleMoveComp", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_ToggleAIComp_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "ToggleAIComp");
		ToggleActorTickEnabled_ToggleAIComp_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "ToggleAIComp");
		ToggleActorTickEnabled_ToggleAIComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "ToggleAIComp", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_ToggleSKMeshComp_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "ToggleSKMeshComp");
		ToggleActorTickEnabled_ToggleSKMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "ToggleSKMeshComp");
		ToggleActorTickEnabled_ToggleSKMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "ToggleSKMeshComp", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_ToggleAkComp_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "ToggleAkComp");
		ToggleActorTickEnabled_ToggleAkComp_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "ToggleAkComp");
		ToggleActorTickEnabled_ToggleAkComp_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "ToggleAkComp", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_PropertyAddress, ToggleActorTickEnabled_FunctionAddress, "ToggleINCLUDE_CHILD_ACTOR");
		ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorTickEnabled_FunctionAddress, "ToggleINCLUDE_CHILD_ACTOR");
		ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorTickEnabled_FunctionAddress, "ToggleINCLUDE_CHILD_ACTOR", Classes.FBoolProperty);
		ToggleActorTickEnabled_IsValid = ToggleActorTickEnabled_FunctionAddress != IntPtr.Zero && ToggleActorTickEnabled_InActor_IsValid && ToggleActorTickEnabled_bEnable_IsValid && ToggleActorTickEnabled_ToggleActorTick_IsValid && ToggleActorTickEnabled_ToggleMoveComp_IsValid && ToggleActorTickEnabled_ToggleAIComp_IsValid && ToggleActorTickEnabled_ToggleSKMeshComp_IsValid && ToggleActorTickEnabled_ToggleAkComp_IsValid && ToggleActorTickEnabled_ToggleINCLUDE_CHILD_ACTOR_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:ToggleActorTickEnabled", ToggleActorTickEnabled_IsValid);
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Tick_Actor_PropertyAddress, Tick_FunctionAddress, "Actor");
		Tick_Actor_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "Actor");
		Tick_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Tick_DeltaTime_PropertyAddress, Tick_FunctionAddress, "DeltaTime");
		Tick_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "DeltaTime");
		Tick_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_Actor_IsValid && Tick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:Tick", Tick_IsValid);
		SetMontagePlayRate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMontagePlayRate");
		SetMontagePlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMontagePlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMontagePlayRate_Character_PropertyAddress, SetMontagePlayRate_FunctionAddress, "Character");
		SetMontagePlayRate_Character_Offset = NativeReflectionCached.GetPropertyOffset(SetMontagePlayRate_FunctionAddress, "Character");
		SetMontagePlayRate_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMontagePlayRate_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMontagePlayRate_PlayRate_PropertyAddress, SetMontagePlayRate_FunctionAddress, "PlayRate");
		SetMontagePlayRate_PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(SetMontagePlayRate_FunctionAddress, "PlayRate");
		SetMontagePlayRate_PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMontagePlayRate_FunctionAddress, "PlayRate", Classes.FFloatProperty);
		SetMontagePlayRate_IsValid = SetMontagePlayRate_FunctionAddress != IntPtr.Zero && SetMontagePlayRate_Character_IsValid && SetMontagePlayRate_PlayRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:SetMontagePlayRate", SetMontagePlayRate_IsValid);
		SetLocalScreenPercentageIfLocalController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLocalScreenPercentageIfLocalController");
		SetLocalScreenPercentageIfLocalController_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalScreenPercentageIfLocalController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalScreenPercentageIfLocalController_Actor_PropertyAddress, SetLocalScreenPercentageIfLocalController_FunctionAddress, "Actor");
		SetLocalScreenPercentageIfLocalController_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalScreenPercentageIfLocalController_FunctionAddress, "Actor");
		SetLocalScreenPercentageIfLocalController_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalScreenPercentageIfLocalController_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalScreenPercentageIfLocalController_Controller_PropertyAddress, SetLocalScreenPercentageIfLocalController_FunctionAddress, "Controller");
		SetLocalScreenPercentageIfLocalController_Controller_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalScreenPercentageIfLocalController_FunctionAddress, "Controller");
		SetLocalScreenPercentageIfLocalController_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalScreenPercentageIfLocalController_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalScreenPercentageIfLocalController_ScreenPercentage_PropertyAddress, SetLocalScreenPercentageIfLocalController_FunctionAddress, "ScreenPercentage");
		SetLocalScreenPercentageIfLocalController_ScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalScreenPercentageIfLocalController_FunctionAddress, "ScreenPercentage");
		SetLocalScreenPercentageIfLocalController_ScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalScreenPercentageIfLocalController_FunctionAddress, "ScreenPercentage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_PropertyAddress, SetLocalScreenPercentageIfLocalController_FunctionAddress, "OutLocalScreenPercentage");
		SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalScreenPercentageIfLocalController_FunctionAddress, "OutLocalScreenPercentage");
		SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalScreenPercentageIfLocalController_FunctionAddress, "OutLocalScreenPercentage", Classes.FFloatProperty);
		SetLocalScreenPercentageIfLocalController_IsValid = SetLocalScreenPercentageIfLocalController_FunctionAddress != IntPtr.Zero && SetLocalScreenPercentageIfLocalController_Actor_IsValid && SetLocalScreenPercentageIfLocalController_Controller_IsValid && SetLocalScreenPercentageIfLocalController_ScreenPercentage_IsValid && SetLocalScreenPercentageIfLocalController_OutLocalScreenPercentage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:SetLocalScreenPercentageIfLocalController", SetLocalScreenPercentageIfLocalController_IsValid);
		SetAnimRootMotionTranslationScale_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAnimRootMotionTranslationScale");
		SetAnimRootMotionTranslationScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimRootMotionTranslationScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimRootMotionTranslationScale_Character_PropertyAddress, SetAnimRootMotionTranslationScale_FunctionAddress, "Character");
		SetAnimRootMotionTranslationScale_Character_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimRootMotionTranslationScale_FunctionAddress, "Character");
		SetAnimRootMotionTranslationScale_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimRootMotionTranslationScale_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAnimRootMotionTranslationScale_Scale_PropertyAddress, SetAnimRootMotionTranslationScale_FunctionAddress, "Scale");
		SetAnimRootMotionTranslationScale_Scale_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimRootMotionTranslationScale_FunctionAddress, "Scale");
		SetAnimRootMotionTranslationScale_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimRootMotionTranslationScale_FunctionAddress, "Scale", Classes.FFloatProperty);
		SetAnimRootMotionTranslationScale_IsValid = SetAnimRootMotionTranslationScale_FunctionAddress != IntPtr.Zero && SetAnimRootMotionTranslationScale_Character_IsValid && SetAnimRootMotionTranslationScale_Scale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAnimRootMotionTranslationScale", SetAnimRootMotionTranslationScale_IsValid);
		SetAllPABodiesBelowResponseToChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAllPABodiesBelowResponseToChannels");
		SetAllPABodiesBelowResponseToChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllPABodiesBelowResponseToChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllPABodiesBelowResponseToChannels_Mesh_PropertyAddress, SetAllPABodiesBelowResponseToChannels_FunctionAddress, "Mesh");
		SetAllPABodiesBelowResponseToChannels_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "Mesh");
		SetAllPABodiesBelowResponseToChannels_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPABodiesBelowResponseToChannels_BoneName_PropertyAddress, SetAllPABodiesBelowResponseToChannels_FunctionAddress, "BoneName");
		SetAllPABodiesBelowResponseToChannels_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "BoneName");
		SetAllPABodiesBelowResponseToChannels_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPABodiesBelowResponseToChannels_Channels_PropertyAddress, SetAllPABodiesBelowResponseToChannels_FunctionAddress, "Channels");
		SetAllPABodiesBelowResponseToChannels_Channels_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "Channels");
		SetAllPABodiesBelowResponseToChannels_Channels_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "Channels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPABodiesBelowResponseToChannels_NewResponse_PropertyAddress, SetAllPABodiesBelowResponseToChannels_FunctionAddress, "NewResponse");
		SetAllPABodiesBelowResponseToChannels_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "NewResponse");
		SetAllPABodiesBelowResponseToChannels_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPABodiesBelowResponseToChannels_FunctionAddress, "NewResponse", Classes.FByteProperty);
		SetAllPABodiesBelowResponseToChannels_IsValid = SetAllPABodiesBelowResponseToChannels_FunctionAddress != IntPtr.Zero && SetAllPABodiesBelowResponseToChannels_Mesh_IsValid && SetAllPABodiesBelowResponseToChannels_BoneName_IsValid && SetAllPABodiesBelowResponseToChannels_Channels_IsValid && SetAllPABodiesBelowResponseToChannels_NewResponse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAllPABodiesBelowResponseToChannels", SetAllPABodiesBelowResponseToChannels_IsValid);
		SetAllPABodiesBelowResponseToAllChannels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAllPABodiesBelowResponseToAllChannels");
		SetAllPABodiesBelowResponseToAllChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllPABodiesBelowResponseToAllChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllPABodiesBelowResponseToAllChannels_Mesh_PropertyAddress, SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "Mesh");
		SetAllPABodiesBelowResponseToAllChannels_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "Mesh");
		SetAllPABodiesBelowResponseToAllChannels_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPABodiesBelowResponseToAllChannels_BoneName_PropertyAddress, SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "BoneName");
		SetAllPABodiesBelowResponseToAllChannels_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "BoneName");
		SetAllPABodiesBelowResponseToAllChannels_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPABodiesBelowResponseToAllChannels_NewResponse_PropertyAddress, SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "NewResponse");
		SetAllPABodiesBelowResponseToAllChannels_NewResponse_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "NewResponse");
		SetAllPABodiesBelowResponseToAllChannels_NewResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPABodiesBelowResponseToAllChannels_FunctionAddress, "NewResponse", Classes.FByteProperty);
		SetAllPABodiesBelowResponseToAllChannels_IsValid = SetAllPABodiesBelowResponseToAllChannels_FunctionAddress != IntPtr.Zero && SetAllPABodiesBelowResponseToAllChannels_Mesh_IsValid && SetAllPABodiesBelowResponseToAllChannels_BoneName_IsValid && SetAllPABodiesBelowResponseToAllChannels_NewResponse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:SetAllPABodiesBelowResponseToAllChannels", SetAllPABodiesBelowResponseToAllChannels_IsValid);
		SetActorSKMeshesUpdateRateOptimizations_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorSKMeshesUpdateRateOptimizations");
		SetActorSKMeshesUpdateRateOptimizations_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorSKMeshesUpdateRateOptimizations_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorSKMeshesUpdateRateOptimizations_Actor_PropertyAddress, SetActorSKMeshesUpdateRateOptimizations_FunctionAddress, "Actor");
		SetActorSKMeshesUpdateRateOptimizations_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSKMeshesUpdateRateOptimizations_FunctionAddress, "Actor");
		SetActorSKMeshesUpdateRateOptimizations_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSKMeshesUpdateRateOptimizations_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorSKMeshesUpdateRateOptimizations_bEnable_PropertyAddress, SetActorSKMeshesUpdateRateOptimizations_FunctionAddress, "bEnable");
		SetActorSKMeshesUpdateRateOptimizations_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSKMeshesUpdateRateOptimizations_FunctionAddress, "bEnable");
		SetActorSKMeshesUpdateRateOptimizations_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSKMeshesUpdateRateOptimizations_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetActorSKMeshesUpdateRateOptimizations_IsValid = SetActorSKMeshesUpdateRateOptimizations_FunctionAddress != IntPtr.Zero && SetActorSKMeshesUpdateRateOptimizations_Actor_IsValid && SetActorSKMeshesUpdateRateOptimizations_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:SetActorSKMeshesUpdateRateOptimizations", SetActorSKMeshesUpdateRateOptimizations_IsValid);
		RecreatePhysicsState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecreatePhysicsState");
		RecreatePhysicsState_ParamsSize = NativeReflection.GetFunctionParamsSize(RecreatePhysicsState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecreatePhysicsState_mesh_PropertyAddress, RecreatePhysicsState_FunctionAddress, "mesh");
		RecreatePhysicsState_mesh_Offset = NativeReflectionCached.GetPropertyOffset(RecreatePhysicsState_FunctionAddress, "mesh");
		RecreatePhysicsState_mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(RecreatePhysicsState_FunctionAddress, "mesh", Classes.FObjectProperty);
		RecreatePhysicsState_IsValid = RecreatePhysicsState_FunctionAddress != IntPtr.Zero && RecreatePhysicsState_mesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:RecreatePhysicsState", RecreatePhysicsState_IsValid);
		MarkDirtyCharacter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkDirtyCharacter");
		MarkDirtyCharacter_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirtyCharacter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkDirtyCharacter_DirtyCharacter_PropertyAddress, MarkDirtyCharacter_FunctionAddress, "DirtyCharacter");
		MarkDirtyCharacter_DirtyCharacter_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirtyCharacter_FunctionAddress, "DirtyCharacter");
		MarkDirtyCharacter_DirtyCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirtyCharacter_FunctionAddress, "DirtyCharacter", Classes.FObjectProperty);
		MarkDirtyCharacter_IsValid = MarkDirtyCharacter_FunctionAddress != IntPtr.Zero && MarkDirtyCharacter_DirtyCharacter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:MarkDirtyCharacter", MarkDirtyCharacter_IsValid);
		MarkDirtyBPActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkDirtyBPActor");
		MarkDirtyBPActor_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirtyBPActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkDirtyBPActor_DirtyBPActor_PropertyAddress, MarkDirtyBPActor_FunctionAddress, "DirtyBPActor");
		MarkDirtyBPActor_DirtyBPActor_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirtyBPActor_FunctionAddress, "DirtyBPActor");
		MarkDirtyBPActor_DirtyBPActor_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirtyBPActor_FunctionAddress, "DirtyBPActor", Classes.FObjectProperty);
		MarkDirtyBPActor_IsValid = MarkDirtyBPActor_FunctionAddress != IntPtr.Zero && MarkDirtyBPActor_DirtyBPActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:MarkDirtyBPActor", MarkDirtyBPActor_IsValid);
		GetSocketTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSocketTransform");
		GetSocketTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketTransform_Comp_PropertyAddress, GetSocketTransform_FunctionAddress, "Comp");
		GetSocketTransform_Comp_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketTransform_FunctionAddress, "Comp");
		GetSocketTransform_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketTransform_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketTransform_SocketName_PropertyAddress, GetSocketTransform_FunctionAddress, "SocketName");
		GetSocketTransform_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketTransform_FunctionAddress, "SocketName");
		GetSocketTransform_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketTransform_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketTransform_TransfromSpace_PropertyAddress, GetSocketTransform_FunctionAddress, "TransfromSpace");
		GetSocketTransform_TransfromSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketTransform_FunctionAddress, "TransfromSpace");
		GetSocketTransform_TransfromSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketTransform_FunctionAddress, "TransfromSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketTransform_ReturnValue_PropertyAddress, GetSocketTransform_FunctionAddress, "ReturnValue");
		GetSocketTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketTransform_FunctionAddress, "ReturnValue");
		GetSocketTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSocketTransform_IsValid = GetSocketTransform_FunctionAddress != IntPtr.Zero && GetSocketTransform_Comp_IsValid && GetSocketTransform_SocketName_IsValid && GetSocketTransform_TransfromSpace_IsValid && GetSocketTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketTransform", GetSocketTransform_IsValid);
		GetSocketRotation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSocketRotation");
		GetSocketRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketRotation_Comp_PropertyAddress, GetSocketRotation_FunctionAddress, "Comp");
		GetSocketRotation_Comp_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketRotation_FunctionAddress, "Comp");
		GetSocketRotation_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketRotation_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketRotation_SocketName_PropertyAddress, GetSocketRotation_FunctionAddress, "SocketName");
		GetSocketRotation_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketRotation_FunctionAddress, "SocketName");
		GetSocketRotation_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketRotation_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketRotation_ReturnValue_PropertyAddress, GetSocketRotation_FunctionAddress, "ReturnValue");
		GetSocketRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketRotation_FunctionAddress, "ReturnValue");
		GetSocketRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSocketRotation_IsValid = GetSocketRotation_FunctionAddress != IntPtr.Zero && GetSocketRotation_Comp_IsValid && GetSocketRotation_SocketName_IsValid && GetSocketRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketRotation", GetSocketRotation_IsValid);
		GetSocketLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSocketLocation");
		GetSocketLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketLocation_Comp_PropertyAddress, GetSocketLocation_FunctionAddress, "Comp");
		GetSocketLocation_Comp_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketLocation_FunctionAddress, "Comp");
		GetSocketLocation_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketLocation_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketLocation_SocketName_PropertyAddress, GetSocketLocation_FunctionAddress, "SocketName");
		GetSocketLocation_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketLocation_FunctionAddress, "SocketName");
		GetSocketLocation_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketLocation_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketLocation_ReturnValue_PropertyAddress, GetSocketLocation_FunctionAddress, "ReturnValue");
		GetSocketLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketLocation_FunctionAddress, "ReturnValue");
		GetSocketLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSocketLocation_IsValid = GetSocketLocation_FunctionAddress != IntPtr.Zero && GetSocketLocation_Comp_IsValid && GetSocketLocation_SocketName_IsValid && GetSocketLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSocketLocation", GetSocketLocation_IsValid);
		GetSceneComponentTransformByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSceneComponentTransformByName");
		GetSceneComponentTransformByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneComponentTransformByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneComponentTransformByName_Actor_PropertyAddress, GetSceneComponentTransformByName_FunctionAddress, "Actor");
		GetSceneComponentTransformByName_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneComponentTransformByName_FunctionAddress, "Actor");
		GetSceneComponentTransformByName_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneComponentTransformByName_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSceneComponentTransformByName_ComponentName_PropertyAddress, GetSceneComponentTransformByName_FunctionAddress, "ComponentName");
		GetSceneComponentTransformByName_ComponentName_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneComponentTransformByName_FunctionAddress, "ComponentName");
		GetSceneComponentTransformByName_ComponentName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneComponentTransformByName_FunctionAddress, "ComponentName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSceneComponentTransformByName_ReturnValue_PropertyAddress, GetSceneComponentTransformByName_FunctionAddress, "ReturnValue");
		GetSceneComponentTransformByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneComponentTransformByName_FunctionAddress, "ReturnValue");
		GetSceneComponentTransformByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneComponentTransformByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSceneComponentTransformByName_IsValid = GetSceneComponentTransformByName_FunctionAddress != IntPtr.Zero && GetSceneComponentTransformByName_Actor_IsValid && GetSceneComponentTransformByName_ComponentName_IsValid && GetSceneComponentTransformByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSceneComponentTransformByName", GetSceneComponentTransformByName_IsValid);
		GetSceneComponentByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSceneComponentByName");
		GetSceneComponentByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneComponentByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSceneComponentByName_Actor_PropertyAddress, GetSceneComponentByName_FunctionAddress, "Actor");
		GetSceneComponentByName_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneComponentByName_FunctionAddress, "Actor");
		GetSceneComponentByName_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneComponentByName_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSceneComponentByName_ComponentName_PropertyAddress, GetSceneComponentByName_FunctionAddress, "ComponentName");
		GetSceneComponentByName_ComponentName_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneComponentByName_FunctionAddress, "ComponentName");
		GetSceneComponentByName_ComponentName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneComponentByName_FunctionAddress, "ComponentName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSceneComponentByName_ReturnValue_PropertyAddress, GetSceneComponentByName_FunctionAddress, "ReturnValue");
		GetSceneComponentByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSceneComponentByName_FunctionAddress, "ReturnValue");
		GetSceneComponentByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSceneComponentByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSceneComponentByName_IsValid = GetSceneComponentByName_FunctionAddress != IntPtr.Zero && GetSceneComponentByName_Actor_IsValid && GetSceneComponentByName_ComponentName_IsValid && GetSceneComponentByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetSceneComponentByName", GetSceneComponentByName_IsValid);
		GetPathFollowingBrakingDistance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPathFollowingBrakingDistance");
		GetPathFollowingBrakingDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathFollowingBrakingDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathFollowingBrakingDistance_CharacterMovement_PropertyAddress, GetPathFollowingBrakingDistance_FunctionAddress, "CharacterMovement");
		GetPathFollowingBrakingDistance_CharacterMovement_Offset = NativeReflectionCached.GetPropertyOffset(GetPathFollowingBrakingDistance_FunctionAddress, "CharacterMovement");
		GetPathFollowingBrakingDistance_CharacterMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathFollowingBrakingDistance_FunctionAddress, "CharacterMovement", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathFollowingBrakingDistance_ReturnValue_PropertyAddress, GetPathFollowingBrakingDistance_FunctionAddress, "ReturnValue");
		GetPathFollowingBrakingDistance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathFollowingBrakingDistance_FunctionAddress, "ReturnValue");
		GetPathFollowingBrakingDistance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathFollowingBrakingDistance_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPathFollowingBrakingDistance_IsValid = GetPathFollowingBrakingDistance_FunctionAddress != IntPtr.Zero && GetPathFollowingBrakingDistance_CharacterMovement_IsValid && GetPathFollowingBrakingDistance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetPathFollowingBrakingDistance", GetPathFollowingBrakingDistance_IsValid);
		GetBPObjForMarkDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBPObjForMarkDirty");
		GetBPObjForMarkDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBPObjForMarkDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBPObjForMarkDirty_Obj_PropertyAddress, GetBPObjForMarkDirty_FunctionAddress, "Obj");
		GetBPObjForMarkDirty_Obj_Offset = NativeReflectionCached.GetPropertyOffset(GetBPObjForMarkDirty_FunctionAddress, "Obj");
		GetBPObjForMarkDirty_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBPObjForMarkDirty_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBPObjForMarkDirty_ReturnValue_PropertyAddress, GetBPObjForMarkDirty_FunctionAddress, "ReturnValue");
		GetBPObjForMarkDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBPObjForMarkDirty_FunctionAddress, "ReturnValue");
		GetBPObjForMarkDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBPObjForMarkDirty_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBPObjForMarkDirty_IsValid = GetBPObjForMarkDirty_FunctionAddress != IntPtr.Zero && GetBPObjForMarkDirty_Obj_IsValid && GetBPObjForMarkDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBPObjForMarkDirty", GetBPObjForMarkDirty_IsValid);
		GetBoneTransformByMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneTransformByMesh");
		GetBoneTransformByMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTransformByMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByMesh_Mesh_PropertyAddress, GetBoneTransformByMesh_FunctionAddress, "Mesh");
		GetBoneTransformByMesh_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByMesh_FunctionAddress, "Mesh");
		GetBoneTransformByMesh_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByMesh_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByMesh_BoneIndex_PropertyAddress, GetBoneTransformByMesh_FunctionAddress, "BoneIndex");
		GetBoneTransformByMesh_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByMesh_FunctionAddress, "BoneIndex");
		GetBoneTransformByMesh_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByMesh_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByMesh_ReturnValue_PropertyAddress, GetBoneTransformByMesh_FunctionAddress, "ReturnValue");
		GetBoneTransformByMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByMesh_FunctionAddress, "ReturnValue");
		GetBoneTransformByMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByMesh_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTransformByMesh_IsValid = GetBoneTransformByMesh_FunctionAddress != IntPtr.Zero && GetBoneTransformByMesh_Mesh_IsValid && GetBoneTransformByMesh_BoneIndex_IsValid && GetBoneTransformByMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBoneTransformByMesh", GetBoneTransformByMesh_IsValid);
		GetBoneTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoneTransform");
		GetBoneTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_Character_PropertyAddress, GetBoneTransform_FunctionAddress, "Character");
		GetBoneTransform_Character_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "Character");
		GetBoneTransform_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_BoneIndex_PropertyAddress, GetBoneTransform_FunctionAddress, "BoneIndex");
		GetBoneTransform_BoneIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "BoneIndex");
		GetBoneTransform_BoneIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "BoneIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransform_ReturnValue_PropertyAddress, GetBoneTransform_FunctionAddress, "ReturnValue");
		GetBoneTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransform_FunctionAddress, "ReturnValue");
		GetBoneTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTransform_IsValid = GetBoneTransform_FunctionAddress != IntPtr.Zero && GetBoneTransform_Character_IsValid && GetBoneTransform_BoneIndex_IsValid && GetBoneTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetBoneTransform", GetBoneTransform_IsValid);
		GetAllCharactersForMarkDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllCharactersForMarkDirty");
		GetAllCharactersForMarkDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllCharactersForMarkDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllCharactersForMarkDirty_ResourcePath_PropertyAddress, GetAllCharactersForMarkDirty_FunctionAddress, "ResourcePath");
		GetAllCharactersForMarkDirty_ResourcePath_Offset = NativeReflectionCached.GetPropertyOffset(GetAllCharactersForMarkDirty_FunctionAddress, "ResourcePath");
		GetAllCharactersForMarkDirty_ResourcePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllCharactersForMarkDirty_FunctionAddress, "ResourcePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllCharactersForMarkDirty_ReturnValue_PropertyAddress, GetAllCharactersForMarkDirty_FunctionAddress, "ReturnValue");
		GetAllCharactersForMarkDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllCharactersForMarkDirty_FunctionAddress, "ReturnValue");
		GetAllCharactersForMarkDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllCharactersForMarkDirty_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllCharactersForMarkDirty_IsValid = GetAllCharactersForMarkDirty_FunctionAddress != IntPtr.Zero && GetAllCharactersForMarkDirty_ResourcePath_IsValid && GetAllCharactersForMarkDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetAllCharactersForMarkDirty", GetAllCharactersForMarkDirty_IsValid);
		GetActorBoundingSphereRadius_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorBoundingSphereRadius");
		GetActorBoundingSphereRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorBoundingSphereRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorBoundingSphereRadius_Actor_PropertyAddress, GetActorBoundingSphereRadius_FunctionAddress, "Actor");
		GetActorBoundingSphereRadius_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBoundingSphereRadius_FunctionAddress, "Actor");
		GetActorBoundingSphereRadius_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBoundingSphereRadius_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorBoundingSphereRadius_ReturnValue_PropertyAddress, GetActorBoundingSphereRadius_FunctionAddress, "ReturnValue");
		GetActorBoundingSphereRadius_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBoundingSphereRadius_FunctionAddress, "ReturnValue");
		GetActorBoundingSphereRadius_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBoundingSphereRadius_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetActorBoundingSphereRadius_IsValid = GetActorBoundingSphereRadius_FunctionAddress != IntPtr.Zero && GetActorBoundingSphereRadius_Actor_IsValid && GetActorBoundingSphereRadius_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:GetActorBoundingSphereRadius", GetActorBoundingSphereRadius_IsValid);
		CalculateScreenPercentageFromController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateScreenPercentageFromController");
		CalculateScreenPercentageFromController_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateScreenPercentageFromController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateScreenPercentageFromController_Actor_PropertyAddress, CalculateScreenPercentageFromController_FunctionAddress, "Actor");
		CalculateScreenPercentageFromController_Actor_Offset = NativeReflectionCached.GetPropertyOffset(CalculateScreenPercentageFromController_FunctionAddress, "Actor");
		CalculateScreenPercentageFromController_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateScreenPercentageFromController_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateScreenPercentageFromController_Controller_PropertyAddress, CalculateScreenPercentageFromController_FunctionAddress, "Controller");
		CalculateScreenPercentageFromController_Controller_Offset = NativeReflectionCached.GetPropertyOffset(CalculateScreenPercentageFromController_FunctionAddress, "Controller");
		CalculateScreenPercentageFromController_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateScreenPercentageFromController_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateScreenPercentageFromController_ReturnValue_PropertyAddress, CalculateScreenPercentageFromController_FunctionAddress, "ReturnValue");
		CalculateScreenPercentageFromController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateScreenPercentageFromController_FunctionAddress, "ReturnValue");
		CalculateScreenPercentageFromController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateScreenPercentageFromController_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalculateScreenPercentageFromController_IsValid = CalculateScreenPercentageFromController_FunctionAddress != IntPtr.Zero && CalculateScreenPercentageFromController_Actor_IsValid && CalculateScreenPercentageFromController_Controller_IsValid && CalculateScreenPercentageFromController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:CalculateScreenPercentageFromController", CalculateScreenPercentageFromController_IsValid);
		CalculateMaxDistanceFactor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateMaxDistanceFactor");
		CalculateMaxDistanceFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateMaxDistanceFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateMaxDistanceFactor_Actor_PropertyAddress, CalculateMaxDistanceFactor_FunctionAddress, "Actor");
		CalculateMaxDistanceFactor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(CalculateMaxDistanceFactor_FunctionAddress, "Actor");
		CalculateMaxDistanceFactor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateMaxDistanceFactor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateMaxDistanceFactor_ReturnValue_PropertyAddress, CalculateMaxDistanceFactor_FunctionAddress, "ReturnValue");
		CalculateMaxDistanceFactor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalculateMaxDistanceFactor_FunctionAddress, "ReturnValue");
		CalculateMaxDistanceFactor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateMaxDistanceFactor_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CalculateMaxDistanceFactor_IsValid = CalculateMaxDistanceFactor_FunctionAddress != IntPtr.Zero && CalculateMaxDistanceFactor_Actor_IsValid && CalculateMaxDistanceFactor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_CharacterFuncLib:CalculateMaxDistanceFactor", CalculateMaxDistanceFactor_IsValid);
	}
}
