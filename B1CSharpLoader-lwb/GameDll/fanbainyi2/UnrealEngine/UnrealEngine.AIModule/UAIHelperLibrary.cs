using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary", "AIModule", UnrealModuleType.Engine)]
public class UAIHelperLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UnlockAIResourcesWithAnimation_IsValid;

	private static IntPtr UnlockAIResourcesWithAnimation_FunctionAddress;

	private static int UnlockAIResourcesWithAnimation_ParamsSize;

	private static bool UnlockAIResourcesWithAnimation_AnimInstance_IsValid;

	private static FFieldAddress UnlockAIResourcesWithAnimation_AnimInstance_PropertyAddress;

	private static int UnlockAIResourcesWithAnimation_AnimInstance_Offset;

	private static bool UnlockAIResourcesWithAnimation_bUnlockMovement_IsValid;

	private static FFieldAddress UnlockAIResourcesWithAnimation_bUnlockMovement_PropertyAddress;

	private static int UnlockAIResourcesWithAnimation_bUnlockMovement_Offset;

	private static bool UnlockAIResourcesWithAnimation_UnlockAILogic_IsValid;

	private static FFieldAddress UnlockAIResourcesWithAnimation_UnlockAILogic_PropertyAddress;

	private static int UnlockAIResourcesWithAnimation_UnlockAILogic_Offset;

	private static bool SpawnAIFromClass_IsValid;

	private static IntPtr SpawnAIFromClass_FunctionAddress;

	private static int SpawnAIFromClass_ParamsSize;

	private static bool SpawnAIFromClass_WorldContextObject_IsValid;

	private static FFieldAddress SpawnAIFromClass_WorldContextObject_PropertyAddress;

	private static int SpawnAIFromClass_WorldContextObject_Offset;

	private static bool SpawnAIFromClass_PawnClass_IsValid;

	private static FFieldAddress SpawnAIFromClass_PawnClass_PropertyAddress;

	private static int SpawnAIFromClass_PawnClass_Offset;

	private static bool SpawnAIFromClass_BehaviorTree_IsValid;

	private static FFieldAddress SpawnAIFromClass_BehaviorTree_PropertyAddress;

	private static int SpawnAIFromClass_BehaviorTree_Offset;

	private static bool SpawnAIFromClass_Location_IsValid;

	private static FFieldAddress SpawnAIFromClass_Location_PropertyAddress;

	private static int SpawnAIFromClass_Location_Offset;

	private static bool SpawnAIFromClass_Rotation_IsValid;

	private static FFieldAddress SpawnAIFromClass_Rotation_PropertyAddress;

	private static int SpawnAIFromClass_Rotation_Offset;

	private static bool SpawnAIFromClass_bNoCollisionFail_IsValid;

	private static FFieldAddress SpawnAIFromClass_bNoCollisionFail_PropertyAddress;

	private static int SpawnAIFromClass_bNoCollisionFail_Offset;

	private static bool SpawnAIFromClass_Owner_IsValid;

	private static FFieldAddress SpawnAIFromClass_Owner_PropertyAddress;

	private static int SpawnAIFromClass_Owner_Offset;

	private static bool SpawnAIFromClass_ReturnValue_IsValid;

	private static FFieldAddress SpawnAIFromClass_ReturnValue_PropertyAddress;

	private static int SpawnAIFromClass_ReturnValue_Offset;

	private static bool SimpleMoveToLocation_IsValid;

	private static IntPtr SimpleMoveToLocation_FunctionAddress;

	private static int SimpleMoveToLocation_ParamsSize;

	private static bool SimpleMoveToLocation_Controller_IsValid;

	private static FFieldAddress SimpleMoveToLocation_Controller_PropertyAddress;

	private static int SimpleMoveToLocation_Controller_Offset;

	private static bool SimpleMoveToLocation_Goal_IsValid;

	private static FFieldAddress SimpleMoveToLocation_Goal_PropertyAddress;

	private static int SimpleMoveToLocation_Goal_Offset;

	private static bool SimpleMoveToActor_IsValid;

	private static IntPtr SimpleMoveToActor_FunctionAddress;

	private static int SimpleMoveToActor_ParamsSize;

	private static bool SimpleMoveToActor_Controller_IsValid;

	private static FFieldAddress SimpleMoveToActor_Controller_PropertyAddress;

	private static int SimpleMoveToActor_Controller_Offset;

	private static bool SimpleMoveToActor_Goal_IsValid;

	private static FFieldAddress SimpleMoveToActor_Goal_PropertyAddress;

	private static int SimpleMoveToActor_Goal_Offset;

	private static bool SendAIMessage_IsValid;

	private static IntPtr SendAIMessage_FunctionAddress;

	private static int SendAIMessage_ParamsSize;

	private static bool SendAIMessage_Target_IsValid;

	private static FFieldAddress SendAIMessage_Target_PropertyAddress;

	private static int SendAIMessage_Target_Offset;

	private static bool SendAIMessage_Message_IsValid;

	private static FFieldAddress SendAIMessage_Message_PropertyAddress;

	private static int SendAIMessage_Message_Offset;

	private static bool SendAIMessage_MessageSource_IsValid;

	private static FFieldAddress SendAIMessage_MessageSource_PropertyAddress;

	private static int SendAIMessage_MessageSource_Offset;

	private static bool SendAIMessage_bSuccess_IsValid;

	private static FFieldAddress SendAIMessage_bSuccess_PropertyAddress;

	private static int SendAIMessage_bSuccess_Offset;

	private static bool LockAIResourcesWithAnimation_IsValid;

	private static IntPtr LockAIResourcesWithAnimation_FunctionAddress;

	private static int LockAIResourcesWithAnimation_ParamsSize;

	private static bool LockAIResourcesWithAnimation_AnimInstance_IsValid;

	private static FFieldAddress LockAIResourcesWithAnimation_AnimInstance_PropertyAddress;

	private static int LockAIResourcesWithAnimation_AnimInstance_Offset;

	private static bool LockAIResourcesWithAnimation_bLockMovement_IsValid;

	private static FFieldAddress LockAIResourcesWithAnimation_bLockMovement_PropertyAddress;

	private static int LockAIResourcesWithAnimation_bLockMovement_Offset;

	private static bool LockAIResourcesWithAnimation_LockAILogic_IsValid;

	private static FFieldAddress LockAIResourcesWithAnimation_LockAILogic_PropertyAddress;

	private static int LockAIResourcesWithAnimation_LockAILogic_Offset;

	private static bool IsValidAIRotation_IsValid;

	private static IntPtr IsValidAIRotation_FunctionAddress;

	private static int IsValidAIRotation_ParamsSize;

	private static bool IsValidAIRotation_Rotation_IsValid;

	private static FFieldAddress IsValidAIRotation_Rotation_PropertyAddress;

	private static int IsValidAIRotation_Rotation_Offset;

	private static bool IsValidAIRotation_ReturnValue_IsValid;

	private static FFieldAddress IsValidAIRotation_ReturnValue_PropertyAddress;

	private static int IsValidAIRotation_ReturnValue_Offset;

	private static bool IsValidAILocation_IsValid;

	private static IntPtr IsValidAILocation_FunctionAddress;

	private static int IsValidAILocation_ParamsSize;

	private static bool IsValidAILocation_Location_IsValid;

	private static FFieldAddress IsValidAILocation_Location_PropertyAddress;

	private static int IsValidAILocation_Location_Offset;

	private static bool IsValidAILocation_ReturnValue_IsValid;

	private static FFieldAddress IsValidAILocation_ReturnValue_PropertyAddress;

	private static int IsValidAILocation_ReturnValue_Offset;

	private static bool IsValidAIDirection_IsValid;

	private static IntPtr IsValidAIDirection_FunctionAddress;

	private static int IsValidAIDirection_ParamsSize;

	private static bool IsValidAIDirection_DirectionVector_IsValid;

	private static FFieldAddress IsValidAIDirection_DirectionVector_PropertyAddress;

	private static int IsValidAIDirection_DirectionVector_Offset;

	private static bool IsValidAIDirection_ReturnValue_IsValid;

	private static FFieldAddress IsValidAIDirection_ReturnValue_PropertyAddress;

	private static int IsValidAIDirection_ReturnValue_Offset;

	private static bool GetNextNavLinkIndex_IsValid;

	private static IntPtr GetNextNavLinkIndex_FunctionAddress;

	private static int GetNextNavLinkIndex_ParamsSize;

	private static bool GetNextNavLinkIndex_Controller_IsValid;

	private static FFieldAddress GetNextNavLinkIndex_Controller_PropertyAddress;

	private static int GetNextNavLinkIndex_Controller_Offset;

	private static bool GetNextNavLinkIndex_ReturnValue_IsValid;

	private static FFieldAddress GetNextNavLinkIndex_ReturnValue_PropertyAddress;

	private static int GetNextNavLinkIndex_ReturnValue_Offset;

	private static bool GetCurrentPathPoints_IsValid;

	private static IntPtr GetCurrentPathPoints_FunctionAddress;

	private static int GetCurrentPathPoints_ParamsSize;

	private static bool GetCurrentPathPoints_Controller_IsValid;

	private static FFieldAddress GetCurrentPathPoints_Controller_PropertyAddress;

	private static int GetCurrentPathPoints_Controller_Offset;

	private static bool GetCurrentPathPoints_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPathPoints_ReturnValue_PropertyAddress;

	private static int GetCurrentPathPoints_ReturnValue_Offset;

	private static bool GetCurrentPathIndex_IsValid;

	private static IntPtr GetCurrentPathIndex_FunctionAddress;

	private static int GetCurrentPathIndex_ParamsSize;

	private static bool GetCurrentPathIndex_Controller_IsValid;

	private static FFieldAddress GetCurrentPathIndex_Controller_PropertyAddress;

	private static int GetCurrentPathIndex_Controller_Offset;

	private static bool GetCurrentPathIndex_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPathIndex_ReturnValue_PropertyAddress;

	private static int GetCurrentPathIndex_ReturnValue_Offset;

	private static bool GetCurrentPath_IsValid;

	private static IntPtr GetCurrentPath_FunctionAddress;

	private static int GetCurrentPath_ParamsSize;

	private static bool GetCurrentPath_Controller_IsValid;

	private static FFieldAddress GetCurrentPath_Controller_PropertyAddress;

	private static int GetCurrentPath_Controller_Offset;

	private static bool GetCurrentPath_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPath_ReturnValue_PropertyAddress;

	private static int GetCurrentPath_ReturnValue_Offset;

	private static bool GetBlackboard_IsValid;

	private static IntPtr GetBlackboard_FunctionAddress;

	private static int GetBlackboard_ParamsSize;

	private static bool GetBlackboard_Target_IsValid;

	private static FFieldAddress GetBlackboard_Target_PropertyAddress;

	private static int GetBlackboard_Target_Offset;

	private static bool GetBlackboard_ReturnValue_IsValid;

	private static FFieldAddress GetBlackboard_ReturnValue_PropertyAddress;

	private static int GetBlackboard_ReturnValue_Offset;

	private static bool GetAIController_IsValid;

	private static IntPtr GetAIController_FunctionAddress;

	private static int GetAIController_ParamsSize;

	private static bool GetAIController_ControlledActor_IsValid;

	private static FFieldAddress GetAIController_ControlledActor_PropertyAddress;

	private static int GetAIController_ControlledActor_Offset;

	private static bool GetAIController_ReturnValue_IsValid;

	private static FFieldAddress GetAIController_ReturnValue_PropertyAddress;

	private static int GetAIController_ReturnValue_Offset;

	[UFunction(Flags = 67249157u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:UnlockAIResourcesWithAnimation")]
	public unsafe static void UnlockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic)
	{
		if (!UnlockAIResourcesWithAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:UnlockAIResourcesWithAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnlockAIResourcesWithAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnlockAIResourcesWithAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, UnlockAIResourcesWithAnimation_AnimInstance_Offset), 0, UnlockAIResourcesWithAnimation_AnimInstance_PropertyAddress.Address, AnimInstance);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UnlockAIResourcesWithAnimation_bUnlockMovement_Offset), 0, UnlockAIResourcesWithAnimation_bUnlockMovement_PropertyAddress.Address, bUnlockMovement);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UnlockAIResourcesWithAnimation_UnlockAILogic_Offset), 0, UnlockAIResourcesWithAnimation_UnlockAILogic_PropertyAddress.Address, UnlockAILogic);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnlockAIResourcesWithAnimation_FunctionAddress, intPtr, UnlockAIResourcesWithAnimation_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:SpawnAIFromClass")]
	public unsafe static APawn SpawnAIFromClass(UObject WorldContextObject, TSubclassOf<APawn> PawnClass, UBehaviorTree BehaviorTree, FVector Location, FRotator Rotation, bool bNoCollisionFail, AActor Owner)
	{
		if (!SpawnAIFromClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:SpawnAIFromClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnAIFromClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnAIFromClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnAIFromClass_WorldContextObject_Offset), 0, SpawnAIFromClass_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, SpawnAIFromClass_PawnClass_Offset), 0, SpawnAIFromClass_PawnClass_PropertyAddress.Address, PawnClass);
		UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(intPtr, SpawnAIFromClass_BehaviorTree_Offset), 0, SpawnAIFromClass_BehaviorTree_PropertyAddress.Address, BehaviorTree);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SpawnAIFromClass_Location_Offset), 0, SpawnAIFromClass_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SpawnAIFromClass_Rotation_Offset), 0, SpawnAIFromClass_Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SpawnAIFromClass_bNoCollisionFail_Offset), 0, SpawnAIFromClass_bNoCollisionFail_PropertyAddress.Address, bNoCollisionFail);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SpawnAIFromClass_Owner_Offset), 0, SpawnAIFromClass_Owner_PropertyAddress.Address, Owner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnAIFromClass_FunctionAddress, intPtr, SpawnAIFromClass_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, SpawnAIFromClass_ReturnValue_Offset), 0, SpawnAIFromClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:SimpleMoveToLocation")]
	public unsafe static void SimpleMoveToLocation(AController Controller, FVector Goal)
	{
		if (!SimpleMoveToLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:SimpleMoveToLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SimpleMoveToLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SimpleMoveToLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, SimpleMoveToLocation_Controller_Offset), 0, SimpleMoveToLocation_Controller_PropertyAddress.Address, Controller);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SimpleMoveToLocation_Goal_Offset), 0, SimpleMoveToLocation_Goal_PropertyAddress.Address, Goal);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SimpleMoveToLocation_FunctionAddress, intPtr, SimpleMoveToLocation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:SimpleMoveToActor")]
	public unsafe static void SimpleMoveToActor(AController Controller, AActor Goal)
	{
		if (!SimpleMoveToActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:SimpleMoveToActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SimpleMoveToActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SimpleMoveToActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, SimpleMoveToActor_Controller_Offset), 0, SimpleMoveToActor_Controller_PropertyAddress.Address, Controller);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SimpleMoveToActor_Goal_Offset), 0, SimpleMoveToActor_Goal_PropertyAddress.Address, Goal);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SimpleMoveToActor_FunctionAddress, intPtr, SimpleMoveToActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:SendAIMessage")]
	public unsafe static void SendAIMessage(APawn Target, FName Message, UObject MessageSource, bool bSuccess = true)
	{
		if (!SendAIMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:SendAIMessage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SendAIMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SendAIMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, SendAIMessage_Target_Offset), 0, SendAIMessage_Target_PropertyAddress.Address, Target);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SendAIMessage_Message_Offset), 0, SendAIMessage_Message_PropertyAddress.Address, Message);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SendAIMessage_MessageSource_Offset), 0, SendAIMessage_MessageSource_PropertyAddress.Address, MessageSource);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SendAIMessage_bSuccess_Offset), 0, SendAIMessage_bSuccess_PropertyAddress.Address, bSuccess);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SendAIMessage_FunctionAddress, intPtr, SendAIMessage_ParamsSize);
	}

	[UFunction(Flags = 67249157u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:LockAIResourcesWithAnimation")]
	public unsafe static void LockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bLockMovement, bool LockAILogic)
	{
		if (!LockAIResourcesWithAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:LockAIResourcesWithAnimation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LockAIResourcesWithAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LockAIResourcesWithAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, LockAIResourcesWithAnimation_AnimInstance_Offset), 0, LockAIResourcesWithAnimation_AnimInstance_PropertyAddress.Address, AnimInstance);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LockAIResourcesWithAnimation_bLockMovement_Offset), 0, LockAIResourcesWithAnimation_bLockMovement_PropertyAddress.Address, bLockMovement);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LockAIResourcesWithAnimation_LockAILogic_Offset), 0, LockAIResourcesWithAnimation_LockAILogic_PropertyAddress.Address, LockAILogic);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LockAIResourcesWithAnimation_FunctionAddress, intPtr, LockAIResourcesWithAnimation_ParamsSize);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAIRotation")]
	public unsafe static bool IsValidAIRotation(FRotator Rotation)
	{
		if (!IsValidAIRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAIRotation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidAIRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidAIRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, IsValidAIRotation_Rotation_Offset), 0, IsValidAIRotation_Rotation_PropertyAddress.Address, Rotation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidAIRotation_FunctionAddress, intPtr, IsValidAIRotation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidAIRotation_ReturnValue_Offset), 0, IsValidAIRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAILocation")]
	public unsafe static bool IsValidAILocation(FVector Location)
	{
		if (!IsValidAILocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAILocation");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidAILocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidAILocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsValidAILocation_Location_Offset), 0, IsValidAILocation_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidAILocation_FunctionAddress, intPtr, IsValidAILocation_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidAILocation_ReturnValue_Offset), 0, IsValidAILocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAIDirection")]
	public unsafe static bool IsValidAIDirection(FVector DirectionVector)
	{
		if (!IsValidAIDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAIDirection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValidAIDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValidAIDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsValidAIDirection_DirectionVector_Offset), 0, IsValidAIDirection_DirectionVector_PropertyAddress.Address, DirectionVector);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValidAIDirection_FunctionAddress, intPtr, IsValidAIDirection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValidAIDirection_ReturnValue_Offset), 0, IsValidAIDirection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:GetNextNavLinkIndex")]
	public unsafe static int GetNextNavLinkIndex(AController Controller)
	{
		if (!GetNextNavLinkIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:GetNextNavLinkIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNextNavLinkIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNextNavLinkIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetNextNavLinkIndex_Controller_Offset), 0, GetNextNavLinkIndex_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNextNavLinkIndex_FunctionAddress, intPtr, GetNextNavLinkIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNextNavLinkIndex_ReturnValue_Offset), 0, GetNextNavLinkIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPathPoints")]
	public unsafe static List<FVector> GetCurrentPathPoints(AController Controller)
	{
		if (!GetCurrentPathPoints_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPathPoints");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPathPoints_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPathPoints_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetCurrentPathPoints_Controller_Offset), 0, GetCurrentPathPoints_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentPathPoints_FunctionAddress, intPtr, GetCurrentPathPoints_ParamsSize);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, GetCurrentPathPoints_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurrentPathPoints_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurrentPathPoints_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPathIndex")]
	public unsafe static int GetCurrentPathIndex(AController Controller)
	{
		if (!GetCurrentPathIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPathIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPathIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPathIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetCurrentPathIndex_Controller_Offset), 0, GetCurrentPathIndex_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentPathIndex_FunctionAddress, intPtr, GetCurrentPathIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentPathIndex_ReturnValue_Offset), 0, GetCurrentPathIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPath")]
	public unsafe static UNavigationPath GetCurrentPath(AController Controller)
	{
		if (!GetCurrentPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, GetCurrentPath_Controller_Offset), 0, GetCurrentPath_Controller_PropertyAddress.Address, Controller);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentPath_FunctionAddress, intPtr, GetCurrentPath_ParamsSize);
		return UObjectMarshaler<UNavigationPath>.FromNative(IntPtr.Add(intPtr, GetCurrentPath_ReturnValue_Offset), 0, GetCurrentPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:GetBlackboard")]
	public unsafe static UBlackboardComponent GetBlackboard(AActor Target)
	{
		if (!GetBlackboard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:GetBlackboard");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlackboard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlackboard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetBlackboard_Target_Offset), 0, GetBlackboard_Target_PropertyAddress.Address, Target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlackboard_FunctionAddress, intPtr, GetBlackboard_ParamsSize);
		return UObjectMarshaler<UBlackboardComponent>.FromNative(IntPtr.Add(intPtr, GetBlackboard_ReturnValue_Offset), 0, GetBlackboard_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AIModule.AIBlueprintHelperLibrary:GetAIController")]
	public unsafe static AIController GetAIController(AActor ControlledActor)
	{
		if (!GetAIController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIBlueprintHelperLibrary:GetAIController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAIController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAIController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetAIController_ControlledActor_Offset), 0, GetAIController_ControlledActor_PropertyAddress.Address, ControlledActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAIController_FunctionAddress, intPtr, GetAIController_ParamsSize);
		return UObjectMarshaler<AIController>.FromNative(IntPtr.Add(intPtr, GetAIController_ReturnValue_Offset), 0, GetAIController_ReturnValue_PropertyAddress.Address);
	}

	static UAIHelperLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAIHelperLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAIHelperLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AIModule.AIBlueprintHelperLibrary");
		UnlockAIResourcesWithAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnlockAIResourcesWithAnimation");
		UnlockAIResourcesWithAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(UnlockAIResourcesWithAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnlockAIResourcesWithAnimation_AnimInstance_PropertyAddress, UnlockAIResourcesWithAnimation_FunctionAddress, "AnimInstance");
		UnlockAIResourcesWithAnimation_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(UnlockAIResourcesWithAnimation_FunctionAddress, "AnimInstance");
		UnlockAIResourcesWithAnimation_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(UnlockAIResourcesWithAnimation_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnlockAIResourcesWithAnimation_bUnlockMovement_PropertyAddress, UnlockAIResourcesWithAnimation_FunctionAddress, "bUnlockMovement");
		UnlockAIResourcesWithAnimation_bUnlockMovement_Offset = NativeReflectionCached.GetPropertyOffset(UnlockAIResourcesWithAnimation_FunctionAddress, "bUnlockMovement");
		UnlockAIResourcesWithAnimation_bUnlockMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(UnlockAIResourcesWithAnimation_FunctionAddress, "bUnlockMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UnlockAIResourcesWithAnimation_UnlockAILogic_PropertyAddress, UnlockAIResourcesWithAnimation_FunctionAddress, "UnlockAILogic");
		UnlockAIResourcesWithAnimation_UnlockAILogic_Offset = NativeReflectionCached.GetPropertyOffset(UnlockAIResourcesWithAnimation_FunctionAddress, "UnlockAILogic");
		UnlockAIResourcesWithAnimation_UnlockAILogic_IsValid = NativeReflectionCached.ValidatePropertyClass(UnlockAIResourcesWithAnimation_FunctionAddress, "UnlockAILogic", Classes.FBoolProperty);
		UnlockAIResourcesWithAnimation_IsValid = UnlockAIResourcesWithAnimation_FunctionAddress != IntPtr.Zero && UnlockAIResourcesWithAnimation_AnimInstance_IsValid && UnlockAIResourcesWithAnimation_bUnlockMovement_IsValid && UnlockAIResourcesWithAnimation_UnlockAILogic_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:UnlockAIResourcesWithAnimation", UnlockAIResourcesWithAnimation_IsValid);
		SpawnAIFromClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnAIFromClass");
		SpawnAIFromClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnAIFromClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_WorldContextObject_PropertyAddress, SpawnAIFromClass_FunctionAddress, "WorldContextObject");
		SpawnAIFromClass_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "WorldContextObject");
		SpawnAIFromClass_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_PawnClass_PropertyAddress, SpawnAIFromClass_FunctionAddress, "PawnClass");
		SpawnAIFromClass_PawnClass_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "PawnClass");
		SpawnAIFromClass_PawnClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "PawnClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_BehaviorTree_PropertyAddress, SpawnAIFromClass_FunctionAddress, "BehaviorTree");
		SpawnAIFromClass_BehaviorTree_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "BehaviorTree");
		SpawnAIFromClass_BehaviorTree_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "BehaviorTree", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_Location_PropertyAddress, SpawnAIFromClass_FunctionAddress, "Location");
		SpawnAIFromClass_Location_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "Location");
		SpawnAIFromClass_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_Rotation_PropertyAddress, SpawnAIFromClass_FunctionAddress, "Rotation");
		SpawnAIFromClass_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "Rotation");
		SpawnAIFromClass_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_bNoCollisionFail_PropertyAddress, SpawnAIFromClass_FunctionAddress, "bNoCollisionFail");
		SpawnAIFromClass_bNoCollisionFail_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "bNoCollisionFail");
		SpawnAIFromClass_bNoCollisionFail_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "bNoCollisionFail", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_Owner_PropertyAddress, SpawnAIFromClass_FunctionAddress, "Owner");
		SpawnAIFromClass_Owner_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "Owner");
		SpawnAIFromClass_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnAIFromClass_ReturnValue_PropertyAddress, SpawnAIFromClass_FunctionAddress, "ReturnValue");
		SpawnAIFromClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnAIFromClass_FunctionAddress, "ReturnValue");
		SpawnAIFromClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnAIFromClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnAIFromClass_IsValid = SpawnAIFromClass_FunctionAddress != IntPtr.Zero && SpawnAIFromClass_WorldContextObject_IsValid && SpawnAIFromClass_PawnClass_IsValid && SpawnAIFromClass_BehaviorTree_IsValid && SpawnAIFromClass_Location_IsValid && SpawnAIFromClass_Rotation_IsValid && SpawnAIFromClass_bNoCollisionFail_IsValid && SpawnAIFromClass_Owner_IsValid && SpawnAIFromClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:SpawnAIFromClass", SpawnAIFromClass_IsValid);
		SimpleMoveToLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SimpleMoveToLocation");
		SimpleMoveToLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SimpleMoveToLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SimpleMoveToLocation_Controller_PropertyAddress, SimpleMoveToLocation_FunctionAddress, "Controller");
		SimpleMoveToLocation_Controller_Offset = NativeReflectionCached.GetPropertyOffset(SimpleMoveToLocation_FunctionAddress, "Controller");
		SimpleMoveToLocation_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(SimpleMoveToLocation_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SimpleMoveToLocation_Goal_PropertyAddress, SimpleMoveToLocation_FunctionAddress, "Goal");
		SimpleMoveToLocation_Goal_Offset = NativeReflectionCached.GetPropertyOffset(SimpleMoveToLocation_FunctionAddress, "Goal");
		SimpleMoveToLocation_Goal_IsValid = NativeReflectionCached.ValidatePropertyClass(SimpleMoveToLocation_FunctionAddress, "Goal", Classes.FStructProperty);
		SimpleMoveToLocation_IsValid = SimpleMoveToLocation_FunctionAddress != IntPtr.Zero && SimpleMoveToLocation_Controller_IsValid && SimpleMoveToLocation_Goal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:SimpleMoveToLocation", SimpleMoveToLocation_IsValid);
		SimpleMoveToActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SimpleMoveToActor");
		SimpleMoveToActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SimpleMoveToActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SimpleMoveToActor_Controller_PropertyAddress, SimpleMoveToActor_FunctionAddress, "Controller");
		SimpleMoveToActor_Controller_Offset = NativeReflectionCached.GetPropertyOffset(SimpleMoveToActor_FunctionAddress, "Controller");
		SimpleMoveToActor_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(SimpleMoveToActor_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SimpleMoveToActor_Goal_PropertyAddress, SimpleMoveToActor_FunctionAddress, "Goal");
		SimpleMoveToActor_Goal_Offset = NativeReflectionCached.GetPropertyOffset(SimpleMoveToActor_FunctionAddress, "Goal");
		SimpleMoveToActor_Goal_IsValid = NativeReflectionCached.ValidatePropertyClass(SimpleMoveToActor_FunctionAddress, "Goal", Classes.FObjectProperty);
		SimpleMoveToActor_IsValid = SimpleMoveToActor_FunctionAddress != IntPtr.Zero && SimpleMoveToActor_Controller_IsValid && SimpleMoveToActor_Goal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:SimpleMoveToActor", SimpleMoveToActor_IsValid);
		SendAIMessage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SendAIMessage");
		SendAIMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(SendAIMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SendAIMessage_Target_PropertyAddress, SendAIMessage_FunctionAddress, "Target");
		SendAIMessage_Target_Offset = NativeReflectionCached.GetPropertyOffset(SendAIMessage_FunctionAddress, "Target");
		SendAIMessage_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(SendAIMessage_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SendAIMessage_Message_PropertyAddress, SendAIMessage_FunctionAddress, "Message");
		SendAIMessage_Message_Offset = NativeReflectionCached.GetPropertyOffset(SendAIMessage_FunctionAddress, "Message");
		SendAIMessage_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(SendAIMessage_FunctionAddress, "Message", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SendAIMessage_MessageSource_PropertyAddress, SendAIMessage_FunctionAddress, "MessageSource");
		SendAIMessage_MessageSource_Offset = NativeReflectionCached.GetPropertyOffset(SendAIMessage_FunctionAddress, "MessageSource");
		SendAIMessage_MessageSource_IsValid = NativeReflectionCached.ValidatePropertyClass(SendAIMessage_FunctionAddress, "MessageSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SendAIMessage_bSuccess_PropertyAddress, SendAIMessage_FunctionAddress, "bSuccess");
		SendAIMessage_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(SendAIMessage_FunctionAddress, "bSuccess");
		SendAIMessage_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(SendAIMessage_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		SendAIMessage_IsValid = SendAIMessage_FunctionAddress != IntPtr.Zero && SendAIMessage_Target_IsValid && SendAIMessage_Message_IsValid && SendAIMessage_MessageSource_IsValid && SendAIMessage_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:SendAIMessage", SendAIMessage_IsValid);
		LockAIResourcesWithAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LockAIResourcesWithAnimation");
		LockAIResourcesWithAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(LockAIResourcesWithAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LockAIResourcesWithAnimation_AnimInstance_PropertyAddress, LockAIResourcesWithAnimation_FunctionAddress, "AnimInstance");
		LockAIResourcesWithAnimation_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(LockAIResourcesWithAnimation_FunctionAddress, "AnimInstance");
		LockAIResourcesWithAnimation_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(LockAIResourcesWithAnimation_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LockAIResourcesWithAnimation_bLockMovement_PropertyAddress, LockAIResourcesWithAnimation_FunctionAddress, "bLockMovement");
		LockAIResourcesWithAnimation_bLockMovement_Offset = NativeReflectionCached.GetPropertyOffset(LockAIResourcesWithAnimation_FunctionAddress, "bLockMovement");
		LockAIResourcesWithAnimation_bLockMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(LockAIResourcesWithAnimation_FunctionAddress, "bLockMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LockAIResourcesWithAnimation_LockAILogic_PropertyAddress, LockAIResourcesWithAnimation_FunctionAddress, "LockAILogic");
		LockAIResourcesWithAnimation_LockAILogic_Offset = NativeReflectionCached.GetPropertyOffset(LockAIResourcesWithAnimation_FunctionAddress, "LockAILogic");
		LockAIResourcesWithAnimation_LockAILogic_IsValid = NativeReflectionCached.ValidatePropertyClass(LockAIResourcesWithAnimation_FunctionAddress, "LockAILogic", Classes.FBoolProperty);
		LockAIResourcesWithAnimation_IsValid = LockAIResourcesWithAnimation_FunctionAddress != IntPtr.Zero && LockAIResourcesWithAnimation_AnimInstance_IsValid && LockAIResourcesWithAnimation_bLockMovement_IsValid && LockAIResourcesWithAnimation_LockAILogic_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:LockAIResourcesWithAnimation", LockAIResourcesWithAnimation_IsValid);
		IsValidAIRotation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidAIRotation");
		IsValidAIRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidAIRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidAIRotation_Rotation_PropertyAddress, IsValidAIRotation_FunctionAddress, "Rotation");
		IsValidAIRotation_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAIRotation_FunctionAddress, "Rotation");
		IsValidAIRotation_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAIRotation_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAIRotation_ReturnValue_PropertyAddress, IsValidAIRotation_FunctionAddress, "ReturnValue");
		IsValidAIRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAIRotation_FunctionAddress, "ReturnValue");
		IsValidAIRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAIRotation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidAIRotation_IsValid = IsValidAIRotation_FunctionAddress != IntPtr.Zero && IsValidAIRotation_Rotation_IsValid && IsValidAIRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAIRotation", IsValidAIRotation_IsValid);
		IsValidAILocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidAILocation");
		IsValidAILocation_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidAILocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidAILocation_Location_PropertyAddress, IsValidAILocation_FunctionAddress, "Location");
		IsValidAILocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAILocation_FunctionAddress, "Location");
		IsValidAILocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAILocation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAILocation_ReturnValue_PropertyAddress, IsValidAILocation_FunctionAddress, "ReturnValue");
		IsValidAILocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAILocation_FunctionAddress, "ReturnValue");
		IsValidAILocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAILocation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidAILocation_IsValid = IsValidAILocation_FunctionAddress != IntPtr.Zero && IsValidAILocation_Location_IsValid && IsValidAILocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAILocation", IsValidAILocation_IsValid);
		IsValidAIDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValidAIDirection");
		IsValidAIDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValidAIDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValidAIDirection_DirectionVector_PropertyAddress, IsValidAIDirection_FunctionAddress, "DirectionVector");
		IsValidAIDirection_DirectionVector_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAIDirection_FunctionAddress, "DirectionVector");
		IsValidAIDirection_DirectionVector_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAIDirection_FunctionAddress, "DirectionVector", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValidAIDirection_ReturnValue_PropertyAddress, IsValidAIDirection_FunctionAddress, "ReturnValue");
		IsValidAIDirection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValidAIDirection_FunctionAddress, "ReturnValue");
		IsValidAIDirection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValidAIDirection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValidAIDirection_IsValid = IsValidAIDirection_FunctionAddress != IntPtr.Zero && IsValidAIDirection_DirectionVector_IsValid && IsValidAIDirection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:IsValidAIDirection", IsValidAIDirection_IsValid);
		GetNextNavLinkIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNextNavLinkIndex");
		GetNextNavLinkIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNextNavLinkIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNextNavLinkIndex_Controller_PropertyAddress, GetNextNavLinkIndex_FunctionAddress, "Controller");
		GetNextNavLinkIndex_Controller_Offset = NativeReflectionCached.GetPropertyOffset(GetNextNavLinkIndex_FunctionAddress, "Controller");
		GetNextNavLinkIndex_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNextNavLinkIndex_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNextNavLinkIndex_ReturnValue_PropertyAddress, GetNextNavLinkIndex_FunctionAddress, "ReturnValue");
		GetNextNavLinkIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNextNavLinkIndex_FunctionAddress, "ReturnValue");
		GetNextNavLinkIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNextNavLinkIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNextNavLinkIndex_IsValid = GetNextNavLinkIndex_FunctionAddress != IntPtr.Zero && GetNextNavLinkIndex_Controller_IsValid && GetNextNavLinkIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:GetNextNavLinkIndex", GetNextNavLinkIndex_IsValid);
		GetCurrentPathPoints_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentPathPoints");
		GetCurrentPathPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPathPoints_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPathPoints_Controller_PropertyAddress, GetCurrentPathPoints_FunctionAddress, "Controller");
		GetCurrentPathPoints_Controller_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPathPoints_FunctionAddress, "Controller");
		GetCurrentPathPoints_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPathPoints_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPathPoints_ReturnValue_PropertyAddress, GetCurrentPathPoints_FunctionAddress, "ReturnValue");
		GetCurrentPathPoints_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPathPoints_FunctionAddress, "ReturnValue");
		GetCurrentPathPoints_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPathPoints_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCurrentPathPoints_IsValid = GetCurrentPathPoints_FunctionAddress != IntPtr.Zero && GetCurrentPathPoints_Controller_IsValid && GetCurrentPathPoints_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPathPoints", GetCurrentPathPoints_IsValid);
		GetCurrentPathIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentPathIndex");
		GetCurrentPathIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPathIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPathIndex_Controller_PropertyAddress, GetCurrentPathIndex_FunctionAddress, "Controller");
		GetCurrentPathIndex_Controller_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPathIndex_FunctionAddress, "Controller");
		GetCurrentPathIndex_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPathIndex_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPathIndex_ReturnValue_PropertyAddress, GetCurrentPathIndex_FunctionAddress, "ReturnValue");
		GetCurrentPathIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPathIndex_FunctionAddress, "ReturnValue");
		GetCurrentPathIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPathIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentPathIndex_IsValid = GetCurrentPathIndex_FunctionAddress != IntPtr.Zero && GetCurrentPathIndex_Controller_IsValid && GetCurrentPathIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPathIndex", GetCurrentPathIndex_IsValid);
		GetCurrentPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentPath");
		GetCurrentPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPath_Controller_PropertyAddress, GetCurrentPath_FunctionAddress, "Controller");
		GetCurrentPath_Controller_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPath_FunctionAddress, "Controller");
		GetCurrentPath_Controller_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPath_FunctionAddress, "Controller", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPath_ReturnValue_PropertyAddress, GetCurrentPath_FunctionAddress, "ReturnValue");
		GetCurrentPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPath_FunctionAddress, "ReturnValue");
		GetCurrentPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentPath_IsValid = GetCurrentPath_FunctionAddress != IntPtr.Zero && GetCurrentPath_Controller_IsValid && GetCurrentPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:GetCurrentPath", GetCurrentPath_IsValid);
		GetBlackboard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlackboard");
		GetBlackboard_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlackboard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboard_Target_PropertyAddress, GetBlackboard_FunctionAddress, "Target");
		GetBlackboard_Target_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboard_FunctionAddress, "Target");
		GetBlackboard_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboard_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlackboard_ReturnValue_PropertyAddress, GetBlackboard_FunctionAddress, "ReturnValue");
		GetBlackboard_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlackboard_FunctionAddress, "ReturnValue");
		GetBlackboard_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlackboard_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlackboard_IsValid = GetBlackboard_FunctionAddress != IntPtr.Zero && GetBlackboard_Target_IsValid && GetBlackboard_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:GetBlackboard", GetBlackboard_IsValid);
		GetAIController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAIController");
		GetAIController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAIController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAIController_ControlledActor_PropertyAddress, GetAIController_FunctionAddress, "ControlledActor");
		GetAIController_ControlledActor_Offset = NativeReflectionCached.GetPropertyOffset(GetAIController_FunctionAddress, "ControlledActor");
		GetAIController_ControlledActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAIController_FunctionAddress, "ControlledActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAIController_ReturnValue_PropertyAddress, GetAIController_FunctionAddress, "ReturnValue");
		GetAIController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAIController_FunctionAddress, "ReturnValue");
		GetAIController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAIController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAIController_IsValid = GetAIController_FunctionAddress != IntPtr.Zero && GetAIController_ControlledActor_IsValid && GetAIController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIBlueprintHelperLibrary:GetAIController", GetAIController_IsValid);
	}
}
