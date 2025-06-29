using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.GameplayTasks;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.AIController", "AIModule", UnrealModuleType.Engine)]
public class AIController : AController, IAIPerceptionListenerInterface, IInterface, IGameplayTaskOwnerInterface, IGenericTeamAgentInterface, IVisualLoggerDebugSnapshotInterface
{
	private static bool StartAILogicOnPossess_IsValid;

	private static FFieldAddress StartAILogicOnPossess_PropertyAddress;

	private static int StartAILogicOnPossess_Offset;

	private static bool StopAILogicOnUnposses_IsValid;

	private static FFieldAddress StopAILogicOnUnposses_PropertyAddress;

	private static int StopAILogicOnUnposses_Offset;

	private static bool SkipExtraLOSChecks_IsValid;

	private static FFieldAddress SkipExtraLOSChecks_PropertyAddress;

	private static int SkipExtraLOSChecks_Offset;

	private static bool AllowStrafe_IsValid;

	private static FFieldAddress AllowStrafe_PropertyAddress;

	private static int AllowStrafe_Offset;

	private static bool WantsPlayerState_IsValid;

	private static FFieldAddress WantsPlayerState_PropertyAddress;

	private static int WantsPlayerState_Offset;

	private static bool SetControlRotationFromPawnOrientation_IsValid;

	private static FFieldAddress SetControlRotationFromPawnOrientation_PropertyAddress;

	private static int SetControlRotationFromPawnOrientation_Offset;

	private static bool BrainComponent_IsValid;

	private static int BrainComponent_Offset;

	private static bool ActionsComp_IsValid;

	private static int ActionsComp_Offset;

	private static bool Blackboard_IsValid;

	private static int Blackboard_Offset;

	private static bool DefaultNavigationFilterClass_IsValid;

	private static int DefaultNavigationFilterClass_Offset;

	private static bool ReceiveMoveCompleted_IsValid;

	private static int ReceiveMoveCompleted_Offset;

	private FAIMoveCompletedSignature ReceiveMoveCompleted_DelegateCached;

	private static bool UseBlackboard_IsValid;

	private static IntPtr UseBlackboard_FunctionAddress;

	private static int UseBlackboard_ParamsSize;

	private static bool UseBlackboard_BlackboardAsset_IsValid;

	private static FFieldAddress UseBlackboard_BlackboardAsset_PropertyAddress;

	private static int UseBlackboard_BlackboardAsset_Offset;

	private static bool UseBlackboard_BlackboardComponent_IsValid;

	private static FFieldAddress UseBlackboard_BlackboardComponent_PropertyAddress;

	private static int UseBlackboard_BlackboardComponent_Offset;

	private static bool UseBlackboard_ReturnValue_IsValid;

	private static FFieldAddress UseBlackboard_ReturnValue_PropertyAddress;

	private static int UseBlackboard_ReturnValue_Offset;

	private static bool UnclaimTaskResource_IsValid;

	private static IntPtr UnclaimTaskResource_FunctionAddress;

	private static int UnclaimTaskResource_ParamsSize;

	private static bool UnclaimTaskResource_ResourceClass_IsValid;

	private static FFieldAddress UnclaimTaskResource_ResourceClass_PropertyAddress;

	private static int UnclaimTaskResource_ResourceClass_Offset;

	private static bool SetPathFollowingComponent_IsValid;

	private static IntPtr SetPathFollowingComponent_FunctionAddress;

	private static int SetPathFollowingComponent_ParamsSize;

	private static bool SetPathFollowingComponent_NewPFComponent_IsValid;

	private static FFieldAddress SetPathFollowingComponent_NewPFComponent_PropertyAddress;

	private static int SetPathFollowingComponent_NewPFComponent_Offset;

	private static bool SetMoveBlockDetection_IsValid;

	private static IntPtr SetMoveBlockDetection_FunctionAddress;

	private static int SetMoveBlockDetection_ParamsSize;

	private static bool SetMoveBlockDetection_bEnable_IsValid;

	private static FFieldAddress SetMoveBlockDetection_bEnable_PropertyAddress;

	private static int SetMoveBlockDetection_bEnable_Offset;

	private static bool RunBehaviorTree_IsValid;

	private static IntPtr RunBehaviorTree_FunctionAddress;

	private static int RunBehaviorTree_ParamsSize;

	private static bool RunBehaviorTree_BTAsset_IsValid;

	private static FFieldAddress RunBehaviorTree_BTAsset_PropertyAddress;

	private static int RunBehaviorTree_BTAsset_Offset;

	private static bool RunBehaviorTree_ReturnValue_IsValid;

	private static FFieldAddress RunBehaviorTree_ReturnValue_PropertyAddress;

	private static int RunBehaviorTree_ReturnValue_Offset;

	private static bool OnUsingBlackBoard_IsValid;

	private IntPtr OnUsingBlackBoard_InstanceFunctionAddress;

	private static IntPtr OnUsingBlackBoard_FunctionAddress;

	private static int OnUsingBlackBoard_ParamsSize;

	private static bool OnUsingBlackBoard_BlackboardComp_IsValid;

	private static FFieldAddress OnUsingBlackBoard_BlackboardComp_PropertyAddress;

	private static int OnUsingBlackBoard_BlackboardComp_Offset;

	private static bool OnUsingBlackBoard_BlackboardAsset_IsValid;

	private static FFieldAddress OnUsingBlackBoard_BlackboardAsset_PropertyAddress;

	private static int OnUsingBlackBoard_BlackboardAsset_Offset;

	private static bool MoveToLocation_IsValid;

	private static IntPtr MoveToLocation_FunctionAddress;

	private static int MoveToLocation_ParamsSize;

	private static bool MoveToLocation_Dest_IsValid;

	private static FFieldAddress MoveToLocation_Dest_PropertyAddress;

	private static int MoveToLocation_Dest_Offset;

	private static bool MoveToLocation_AcceptanceRadius_IsValid;

	private static FFieldAddress MoveToLocation_AcceptanceRadius_PropertyAddress;

	private static int MoveToLocation_AcceptanceRadius_Offset;

	private static bool MoveToLocation_bStopOnOverlap_IsValid;

	private static FFieldAddress MoveToLocation_bStopOnOverlap_PropertyAddress;

	private static int MoveToLocation_bStopOnOverlap_Offset;

	private static bool MoveToLocation_bUsePathfinding_IsValid;

	private static FFieldAddress MoveToLocation_bUsePathfinding_PropertyAddress;

	private static int MoveToLocation_bUsePathfinding_Offset;

	private static bool MoveToLocation_bProjectDestinationToNavigation_IsValid;

	private static FFieldAddress MoveToLocation_bProjectDestinationToNavigation_PropertyAddress;

	private static int MoveToLocation_bProjectDestinationToNavigation_Offset;

	private static bool MoveToLocation_bCanStrafe_IsValid;

	private static FFieldAddress MoveToLocation_bCanStrafe_PropertyAddress;

	private static int MoveToLocation_bCanStrafe_Offset;

	private static bool MoveToLocation_FilterClass_IsValid;

	private static FFieldAddress MoveToLocation_FilterClass_PropertyAddress;

	private static int MoveToLocation_FilterClass_Offset;

	private static bool MoveToLocation_bAllowPartialPath_IsValid;

	private static FFieldAddress MoveToLocation_bAllowPartialPath_PropertyAddress;

	private static int MoveToLocation_bAllowPartialPath_Offset;

	private static bool MoveToLocation_ReturnValue_IsValid;

	private static FFieldAddress MoveToLocation_ReturnValue_PropertyAddress;

	private static int MoveToLocation_ReturnValue_Offset;

	private static bool MoveToActor_IsValid;

	private static IntPtr MoveToActor_FunctionAddress;

	private static int MoveToActor_ParamsSize;

	private static bool MoveToActor_Goal_IsValid;

	private static FFieldAddress MoveToActor_Goal_PropertyAddress;

	private static int MoveToActor_Goal_Offset;

	private static bool MoveToActor_AcceptanceRadius_IsValid;

	private static FFieldAddress MoveToActor_AcceptanceRadius_PropertyAddress;

	private static int MoveToActor_AcceptanceRadius_Offset;

	private static bool MoveToActor_bStopOnOverlap_IsValid;

	private static FFieldAddress MoveToActor_bStopOnOverlap_PropertyAddress;

	private static int MoveToActor_bStopOnOverlap_Offset;

	private static bool MoveToActor_bUsePathfinding_IsValid;

	private static FFieldAddress MoveToActor_bUsePathfinding_PropertyAddress;

	private static int MoveToActor_bUsePathfinding_Offset;

	private static bool MoveToActor_bCanStrafe_IsValid;

	private static FFieldAddress MoveToActor_bCanStrafe_PropertyAddress;

	private static int MoveToActor_bCanStrafe_Offset;

	private static bool MoveToActor_FilterClass_IsValid;

	private static FFieldAddress MoveToActor_FilterClass_PropertyAddress;

	private static int MoveToActor_FilterClass_Offset;

	private static bool MoveToActor_bAllowPartialPath_IsValid;

	private static FFieldAddress MoveToActor_bAllowPartialPath_PropertyAddress;

	private static int MoveToActor_bAllowPartialPath_Offset;

	private static bool MoveToActor_ReturnValue_IsValid;

	private static FFieldAddress MoveToActor_ReturnValue_PropertyAddress;

	private static int MoveToActor_ReturnValue_Offset;

	private static bool SetFocus_IsValid;

	private static IntPtr SetFocus_FunctionAddress;

	private static int SetFocus_ParamsSize;

	private static bool SetFocus_NewFocus_IsValid;

	private static FFieldAddress SetFocus_NewFocus_PropertyAddress;

	private static int SetFocus_NewFocus_Offset;

	private static bool SetFocalPoint_IsValid;

	private static IntPtr SetFocalPoint_FunctionAddress;

	private static int SetFocalPoint_ParamsSize;

	private static bool SetFocalPoint_FP_IsValid;

	private static FFieldAddress SetFocalPoint_FP_PropertyAddress;

	private static int SetFocalPoint_FP_Offset;

	private static bool ClearFocus_IsValid;

	private static IntPtr ClearFocus_FunctionAddress;

	private static int ClearFocus_ParamsSize;

	private static bool HasPartialPath_IsValid;

	private static IntPtr HasPartialPath_FunctionAddress;

	private static int HasPartialPath_ParamsSize;

	private static bool HasPartialPath_ReturnValue_IsValid;

	private static FFieldAddress HasPartialPath_ReturnValue_PropertyAddress;

	private static int HasPartialPath_ReturnValue_Offset;

	private static bool GetPathFollowingComponent_IsValid;

	private static IntPtr GetPathFollowingComponent_FunctionAddress;

	private static int GetPathFollowingComponent_ParamsSize;

	private static bool GetPathFollowingComponent_ReturnValue_IsValid;

	private static FFieldAddress GetPathFollowingComponent_ReturnValue_PropertyAddress;

	private static int GetPathFollowingComponent_ReturnValue_Offset;

	private static bool GetMoveStatus_IsValid;

	private static IntPtr GetMoveStatus_FunctionAddress;

	private static int GetMoveStatus_ParamsSize;

	private static bool GetMoveStatus_ReturnValue_IsValid;

	private static FFieldAddress GetMoveStatus_ReturnValue_PropertyAddress;

	private static int GetMoveStatus_ReturnValue_Offset;

	private static bool GetImmediateMoveDestination_IsValid;

	private static IntPtr GetImmediateMoveDestination_FunctionAddress;

	private static int GetImmediateMoveDestination_ParamsSize;

	private static bool GetImmediateMoveDestination_ReturnValue_IsValid;

	private static FFieldAddress GetImmediateMoveDestination_ReturnValue_PropertyAddress;

	private static int GetImmediateMoveDestination_ReturnValue_Offset;

	private static bool GetFocusActor_IsValid;

	private static IntPtr GetFocusActor_FunctionAddress;

	private static int GetFocusActor_ParamsSize;

	private static bool GetFocusActor_ReturnValue_IsValid;

	private static FFieldAddress GetFocusActor_ReturnValue_PropertyAddress;

	private static int GetFocusActor_ReturnValue_Offset;

	private static bool GetFocalPointOnActor_IsValid;

	private static IntPtr GetFocalPointOnActor_FunctionAddress;

	private static int GetFocalPointOnActor_ParamsSize;

	private static bool GetFocalPointOnActor_Actor_IsValid;

	private static FFieldAddress GetFocalPointOnActor_Actor_PropertyAddress;

	private static int GetFocalPointOnActor_Actor_Offset;

	private static bool GetFocalPointOnActor_ReturnValue_IsValid;

	private static FFieldAddress GetFocalPointOnActor_ReturnValue_PropertyAddress;

	private static int GetFocalPointOnActor_ReturnValue_Offset;

	private static bool GetFocalPoint_IsValid;

	private static IntPtr GetFocalPoint_FunctionAddress;

	private static int GetFocalPoint_ParamsSize;

	private static bool GetFocalPoint_ReturnValue_IsValid;

	private static FFieldAddress GetFocalPoint_ReturnValue_PropertyAddress;

	private static int GetFocalPoint_ReturnValue_Offset;

	private static bool GetAIPerceptionComponent_IsValid;

	private static IntPtr GetAIPerceptionComponent_FunctionAddress;

	private static int GetAIPerceptionComponent_ParamsSize;

	private static bool GetAIPerceptionComponent_ReturnValue_IsValid;

	private static FFieldAddress GetAIPerceptionComponent_ReturnValue_PropertyAddress;

	private static int GetAIPerceptionComponent_ReturnValue_Offset;

	private static bool ClaimTaskResource_IsValid;

	private static IntPtr ClaimTaskResource_FunctionAddress;

	private static int ClaimTaskResource_ParamsSize;

	private static bool ClaimTaskResource_ResourceClass_IsValid;

	private static FFieldAddress ClaimTaskResource_ResourceClass_PropertyAddress;

	private static int ClaimTaskResource_ResourceClass_Offset;

	[UProperty(Flags = (PropFlags)11267863880925189uL)]
	[UMetaPath("/Script/AIModule.AIController:bStartAILogicOnPossess")]
	protected bool StartAILogicOnPossess
	{
		get
		{
			CheckDestroyed();
			if (!StartAILogicOnPossess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bStartAILogicOnPossess");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StartAILogicOnPossess_Offset), 0, StartAILogicOnPossess_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StartAILogicOnPossess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bStartAILogicOnPossess");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StartAILogicOnPossess_Offset), 0, StartAILogicOnPossess_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925189uL)]
	[UMetaPath("/Script/AIModule.AIController:bStopAILogicOnUnposses")]
	protected bool StopAILogicOnUnposses
	{
		get
		{
			CheckDestroyed();
			if (!StopAILogicOnUnposses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bStopAILogicOnUnposses");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StopAILogicOnUnposses_Offset), 0, StopAILogicOnUnposses_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StopAILogicOnUnposses_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bStopAILogicOnUnposses");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StopAILogicOnUnposses_Offset), 0, StopAILogicOnUnposses_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AIModule.AIController:bSkipExtraLOSChecks")]
	public bool SkipExtraLOSChecks
	{
		get
		{
			CheckDestroyed();
			if (!SkipExtraLOSChecks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bSkipExtraLOSChecks");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SkipExtraLOSChecks_Offset), 0, SkipExtraLOSChecks_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkipExtraLOSChecks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bSkipExtraLOSChecks");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SkipExtraLOSChecks_Offset), 0, SkipExtraLOSChecks_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AIModule.AIController:bAllowStrafe")]
	public bool AllowStrafe
	{
		get
		{
			CheckDestroyed();
			if (!AllowStrafe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bAllowStrafe");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowStrafe_Offset), 0, AllowStrafe_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowStrafe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bAllowStrafe");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowStrafe_Offset), 0, AllowStrafe_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AIModule.AIController:bWantsPlayerState")]
	public bool WantsPlayerState
	{
		get
		{
			CheckDestroyed();
			if (!WantsPlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bWantsPlayerState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WantsPlayerState_Offset), 0, WantsPlayerState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WantsPlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bWantsPlayerState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WantsPlayerState_Offset), 0, WantsPlayerState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AIModule.AIController:bSetControlRotationFromPawnOrientation")]
	public bool SetControlRotationFromPawnOrientation
	{
		get
		{
			CheckDestroyed();
			if (!SetControlRotationFromPawnOrientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bSetControlRotationFromPawnOrientation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SetControlRotationFromPawnOrientation_Offset), 0, SetControlRotationFromPawnOrientation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetControlRotationFromPawnOrientation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:bSetControlRotationFromPawnOrientation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SetControlRotationFromPawnOrientation_Offset), 0, SetControlRotationFromPawnOrientation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141641740uL)]
	[UMetaPath("/Script/AIModule.AIController:BrainComponent")]
	public UBrainComponent BrainComponent
	{
		get
		{
			CheckDestroyed();
			if (!BrainComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:BrainComponent");
				return null;
			}
			return UObjectMarshaler<UBrainComponent>.FromNative(IntPtr.Add(base.Address, BrainComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrainComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:BrainComponent");
			}
			else
			{
				UObjectMarshaler<UBrainComponent>.ToNative(IntPtr.Add(base.Address, BrainComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023753244uL)]
	[UMetaPath("/Script/AIModule.AIController:ActionsComp")]
	public UPawnActionsComponent ActionsComp
	{
		get
		{
			CheckDestroyed();
			if (!ActionsComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:ActionsComp");
				return null;
			}
			return UObjectMarshaler<UPawnActionsComponent>.FromNative(IntPtr.Add(base.Address, ActionsComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActionsComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:ActionsComp");
			}
			else
			{
				UObjectMarshaler<UPawnActionsComponent>.ToNative(IntPtr.Add(base.Address, ActionsComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862034460uL)]
	[UMetaPath("/Script/AIModule.AIController:Blackboard")]
	protected UBlackboardComponent Blackboard
	{
		get
		{
			CheckDestroyed();
			if (!Blackboard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:Blackboard");
				return null;
			}
			return UObjectMarshaler<UBlackboardComponent>.FromNative(IntPtr.Add(base.Address, Blackboard_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Blackboard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:Blackboard");
			}
			else
			{
				UObjectMarshaler<UBlackboardComponent>.ToNative(IntPtr.Add(base.Address, Blackboard_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510149uL)]
	[UMetaPath("/Script/AIModule.AIController:DefaultNavigationFilterClass")]
	protected TSubclassOf<UNavigationQueryFilter> DefaultNavigationFilterClass
	{
		get
		{
			CheckDestroyed();
			if (!DefaultNavigationFilterClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:DefaultNavigationFilterClass");
				return default(TSubclassOf<UNavigationQueryFilter>);
			}
			return TSubclassOfMarshaler<UNavigationQueryFilter>.FromNative(IntPtr.Add(base.Address, DefaultNavigationFilterClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultNavigationFilterClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:DefaultNavigationFilterClass");
			}
			else
			{
				TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(base.Address, DefaultNavigationFilterClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AIModule.AIController:ReceiveMoveCompleted")]
	public FAIMoveCompletedSignature ReceiveMoveCompleted
	{
		get
		{
			CheckDestroyed();
			if (!ReceiveMoveCompleted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AIController:ReceiveMoveCompleted");
				return new FAIMoveCompletedSignature();
			}
			if (ReceiveMoveCompleted_DelegateCached == null)
			{
				ReceiveMoveCompleted_DelegateCached = new FAIMoveCompletedSignature();
				ReceiveMoveCompleted_DelegateCached.SetAddress(IntPtr.Add(base.Address, ReceiveMoveCompleted_Offset));
			}
			return ReceiveMoveCompleted_DelegateCached;
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AIModule.AIController:UseBlackboard")]
	public unsafe bool UseBlackboard(UBlackboardData BlackboardAsset, out UBlackboardComponent BlackboardComponent)
	{
		CheckDestroyed();
		if (!UseBlackboard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:UseBlackboard");
			BlackboardComponent = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UseBlackboard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UseBlackboard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlackboardData>.ToNative(IntPtr.Add(intPtr, UseBlackboard_BlackboardAsset_Offset), 0, UseBlackboard_BlackboardAsset_PropertyAddress.Address, BlackboardAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, UseBlackboard_FunctionAddress, intPtr, UseBlackboard_ParamsSize);
		BlackboardComponent = UObjectMarshaler<UBlackboardComponent>.FromNative(IntPtr.Add(intPtr, UseBlackboard_BlackboardComponent_Offset), 0, UseBlackboard_BlackboardComponent_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, UseBlackboard_ReturnValue_Offset), 0, UseBlackboard_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIController:UnclaimTaskResource")]
	public unsafe void UnclaimTaskResource(TSubclassOf<UGameplayTaskResource> ResourceClass)
	{
		CheckDestroyed();
		if (!UnclaimTaskResource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:UnclaimTaskResource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnclaimTaskResource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnclaimTaskResource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UGameplayTaskResource>.ToNative(IntPtr.Add(intPtr, UnclaimTaskResource_ResourceClass_Offset), 0, UnclaimTaskResource_ResourceClass_PropertyAddress.Address, ResourceClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnclaimTaskResource_FunctionAddress, intPtr, UnclaimTaskResource_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIController:SetPathFollowingComponent")]
	public unsafe void SetPathFollowingComponent(UPathFollowingComponent NewPFComponent)
	{
		CheckDestroyed();
		if (!SetPathFollowingComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:SetPathFollowingComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPathFollowingComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPathFollowingComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPathFollowingComponent>.ToNative(IntPtr.Add(intPtr, SetPathFollowingComponent_NewPFComponent_Offset), 0, SetPathFollowingComponent_NewPFComponent_PropertyAddress.Address, NewPFComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPathFollowingComponent_FunctionAddress, intPtr, SetPathFollowingComponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIController:SetMoveBlockDetection")]
	public unsafe void SetMoveBlockDetection(bool bEnable)
	{
		CheckDestroyed();
		if (!SetMoveBlockDetection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:SetMoveBlockDetection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMoveBlockDetection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMoveBlockDetection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMoveBlockDetection_bEnable_Offset), 0, SetMoveBlockDetection_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMoveBlockDetection_FunctionAddress, intPtr, SetMoveBlockDetection_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AIModule.AIController:RunBehaviorTree")]
	public unsafe bool RunBehaviorTree(UBehaviorTree BTAsset)
	{
		CheckDestroyed();
		if (!RunBehaviorTree_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:RunBehaviorTree");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunBehaviorTree_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunBehaviorTree_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(intPtr, RunBehaviorTree_BTAsset_Offset), 0, RunBehaviorTree_BTAsset_PropertyAddress.Address, BTAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, RunBehaviorTree_FunctionAddress, intPtr, RunBehaviorTree_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RunBehaviorTree_ReturnValue_Offset), 0, RunBehaviorTree_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.AIController:OnUsingBlackBoard")]
	protected unsafe void OnUsingBlackBoard(UBlackboardComponent BlackboardComp, UBlackboardData BlackboardAsset)
	{
		CheckDestroyed();
		if (!OnUsingBlackBoard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:OnUsingBlackBoard");
			return;
		}
		if (OnUsingBlackBoard_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnUsingBlackBoard_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnUsingBlackBoard");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUsingBlackBoard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUsingBlackBoard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlackboardComponent>.ToNative(IntPtr.Add(intPtr, OnUsingBlackBoard_BlackboardComp_Offset), 0, OnUsingBlackBoard_BlackboardComp_PropertyAddress.Address, BlackboardComp);
		UObjectMarshaler<UBlackboardData>.ToNative(IntPtr.Add(intPtr, OnUsingBlackBoard_BlackboardAsset_Offset), 0, OnUsingBlackBoard_BlackboardAsset_PropertyAddress.Address, BlackboardAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUsingBlackBoard_InstanceFunctionAddress, intPtr, OnUsingBlackBoard_ParamsSize);
	}

	protected unsafe virtual void OnUsingBlackBoard_Implementation(UBlackboardComponent BlackboardComp, UBlackboardData BlackboardAsset)
	{
		CheckDestroyed();
		if (!OnUsingBlackBoard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:OnUsingBlackBoard");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUsingBlackBoard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUsingBlackBoard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlackboardComponent>.ToNative(IntPtr.Add(intPtr, OnUsingBlackBoard_BlackboardComp_Offset), 0, OnUsingBlackBoard_BlackboardComp_PropertyAddress.Address, BlackboardComp);
		UObjectMarshaler<UBlackboardData>.ToNative(IntPtr.Add(intPtr, OnUsingBlackBoard_BlackboardAsset_Offset), 0, OnUsingBlackBoard_BlackboardAsset_PropertyAddress.Address, BlackboardAsset);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnUsingBlackBoard_FunctionAddress, intPtr, OnUsingBlackBoard_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/AIModule.AIController:MoveToLocation")]
	public unsafe EPathFollowingRequestResult MoveToLocation(FVector Dest, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bProjectDestinationToNavigation, bool bCanStrafe, TSubclassOf<UNavigationQueryFilter> FilterClass, bool bAllowPartialPath)
	{
		CheckDestroyed();
		if (!MoveToLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:MoveToLocation");
			return EPathFollowingRequestResult.Failed;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveToLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveToLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MoveToLocation_Dest_Offset), 0, MoveToLocation_Dest_PropertyAddress.Address, Dest);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MoveToLocation_AcceptanceRadius_Offset), 0, MoveToLocation_AcceptanceRadius_PropertyAddress.Address, AcceptanceRadius);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToLocation_bStopOnOverlap_Offset), 0, MoveToLocation_bStopOnOverlap_PropertyAddress.Address, bStopOnOverlap);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToLocation_bUsePathfinding_Offset), 0, MoveToLocation_bUsePathfinding_PropertyAddress.Address, bUsePathfinding);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToLocation_bProjectDestinationToNavigation_Offset), 0, MoveToLocation_bProjectDestinationToNavigation_PropertyAddress.Address, bProjectDestinationToNavigation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToLocation_bCanStrafe_Offset), 0, MoveToLocation_bCanStrafe_PropertyAddress.Address, bCanStrafe);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, MoveToLocation_FilterClass_Offset), 0, MoveToLocation_FilterClass_PropertyAddress.Address, FilterClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToLocation_bAllowPartialPath_Offset), 0, MoveToLocation_bAllowPartialPath_PropertyAddress.Address, bAllowPartialPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveToLocation_FunctionAddress, intPtr, MoveToLocation_ParamsSize);
		return EnumMarshaler<EPathFollowingRequestResult>.FromNative(IntPtr.Add(intPtr, MoveToLocation_ReturnValue_Offset), 0, MoveToLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIController:MoveToActor")]
	public unsafe EPathFollowingRequestResult MoveToActor(AActor Goal, float AcceptanceRadius, bool bStopOnOverlap, bool bUsePathfinding, bool bCanStrafe, TSubclassOf<UNavigationQueryFilter> FilterClass, bool bAllowPartialPath)
	{
		CheckDestroyed();
		if (!MoveToActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:MoveToActor");
			return EPathFollowingRequestResult.Failed;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveToActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveToActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, MoveToActor_Goal_Offset), 0, MoveToActor_Goal_PropertyAddress.Address, Goal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MoveToActor_AcceptanceRadius_Offset), 0, MoveToActor_AcceptanceRadius_PropertyAddress.Address, AcceptanceRadius);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToActor_bStopOnOverlap_Offset), 0, MoveToActor_bStopOnOverlap_PropertyAddress.Address, bStopOnOverlap);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToActor_bUsePathfinding_Offset), 0, MoveToActor_bUsePathfinding_PropertyAddress.Address, bUsePathfinding);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToActor_bCanStrafe_Offset), 0, MoveToActor_bCanStrafe_PropertyAddress.Address, bCanStrafe);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, MoveToActor_FilterClass_Offset), 0, MoveToActor_FilterClass_PropertyAddress.Address, FilterClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveToActor_bAllowPartialPath_Offset), 0, MoveToActor_bAllowPartialPath_PropertyAddress.Address, bAllowPartialPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveToActor_FunctionAddress, intPtr, MoveToActor_ParamsSize);
		return EnumMarshaler<EPathFollowingRequestResult>.FromNative(IntPtr.Add(intPtr, MoveToActor_ReturnValue_Offset), 0, MoveToActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_SetFocus")]
	[UMetaPath("/Script/AIModule.AIController:K2_SetFocus")]
	public unsafe void SetFocus(AActor NewFocus)
	{
		CheckDestroyed();
		if (!SetFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:K2_SetFocus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetFocus_NewFocus_Offset), 0, SetFocus_NewFocus_PropertyAddress.Address, NewFocus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFocus_FunctionAddress, intPtr, SetFocus_ParamsSize);
	}

	[UFunction(Flags = 75629569u, OriginalName = "K2_SetFocalPoint")]
	[UMetaPath("/Script/AIModule.AIController:K2_SetFocalPoint")]
	public unsafe void SetFocalPoint(FVector FP)
	{
		CheckDestroyed();
		if (!SetFocalPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:K2_SetFocalPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFocalPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFocalPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetFocalPoint_FP_Offset), 0, SetFocalPoint_FP_PropertyAddress.Address, FP);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFocalPoint_FunctionAddress, intPtr, SetFocalPoint_ParamsSize);
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_ClearFocus")]
	[UMetaPath("/Script/AIModule.AIController:K2_ClearFocus")]
	public unsafe void ClearFocus()
	{
		CheckDestroyed();
		if (!ClearFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:K2_ClearFocus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearFocus_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearFocus_FunctionAddress, argsSize: ClearFocus_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.AIController:HasPartialPath")]
	public unsafe bool HasPartialPath()
	{
		CheckDestroyed();
		if (!HasPartialPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:HasPartialPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasPartialPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasPartialPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasPartialPath_FunctionAddress, intPtr, HasPartialPath_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasPartialPath_ReturnValue_Offset), 0, HasPartialPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.AIController:GetPathFollowingComponent")]
	public unsafe UPathFollowingComponent GetPathFollowingComponent()
	{
		CheckDestroyed();
		if (!GetPathFollowingComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:GetPathFollowingComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathFollowingComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathFollowingComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPathFollowingComponent_FunctionAddress, intPtr, GetPathFollowingComponent_ParamsSize);
		return UObjectMarshaler<UPathFollowingComponent>.FromNative(IntPtr.Add(intPtr, GetPathFollowingComponent_ReturnValue_Offset), 0, GetPathFollowingComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.AIController:GetMoveStatus")]
	public unsafe EPathFollowingStatus GetMoveStatus()
	{
		CheckDestroyed();
		if (!GetMoveStatus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:GetMoveStatus");
			return EPathFollowingStatus.Idle;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMoveStatus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMoveStatus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMoveStatus_FunctionAddress, intPtr, GetMoveStatus_ParamsSize);
		return EnumMarshaler<EPathFollowingStatus>.FromNative(IntPtr.Add(intPtr, GetMoveStatus_ReturnValue_Offset), 0, GetMoveStatus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/AIModule.AIController:GetImmediateMoveDestination")]
	public unsafe FVector GetImmediateMoveDestination()
	{
		CheckDestroyed();
		if (!GetImmediateMoveDestination_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:GetImmediateMoveDestination");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetImmediateMoveDestination_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetImmediateMoveDestination_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetImmediateMoveDestination_FunctionAddress, intPtr, GetImmediateMoveDestination_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetImmediateMoveDestination_ReturnValue_Offset), 0, GetImmediateMoveDestination_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AIModule.AIController:GetFocusActor")]
	public unsafe AActor GetFocusActor()
	{
		CheckDestroyed();
		if (!GetFocusActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:GetFocusActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFocusActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFocusActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFocusActor_FunctionAddress, intPtr, GetFocusActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetFocusActor_ReturnValue_Offset), 0, GetFocusActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/AIModule.AIController:GetFocalPointOnActor")]
	public unsafe FVector GetFocalPointOnActor(AActor Actor)
	{
		CheckDestroyed();
		if (!GetFocalPointOnActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:GetFocalPointOnActor");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFocalPointOnActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFocalPointOnActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetFocalPointOnActor_Actor_Offset), 0, GetFocalPointOnActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFocalPointOnActor_FunctionAddress, intPtr, GetFocalPointOnActor_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetFocalPointOnActor_ReturnValue_Offset), 0, GetFocalPointOnActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/AIModule.AIController:GetFocalPoint")]
	public unsafe FVector GetFocalPoint()
	{
		CheckDestroyed();
		if (!GetFocalPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:GetFocalPoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFocalPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFocalPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFocalPoint_FunctionAddress, intPtr, GetFocalPoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetFocalPoint_ReturnValue_Offset), 0, GetFocalPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/AIModule.AIController:GetAIPerceptionComponent")]
	public unsafe UAIPerceptionComponent GetAIPerceptionComponent()
	{
		CheckDestroyed();
		if (!GetAIPerceptionComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:GetAIPerceptionComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAIPerceptionComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAIPerceptionComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAIPerceptionComponent_FunctionAddress, intPtr, GetAIPerceptionComponent_ParamsSize);
		return UObjectMarshaler<UAIPerceptionComponent>.FromNative(IntPtr.Add(intPtr, GetAIPerceptionComponent_ReturnValue_Offset), 0, GetAIPerceptionComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AIModule.AIController:ClaimTaskResource")]
	public unsafe void ClaimTaskResource(TSubclassOf<UGameplayTaskResource> ResourceClass)
	{
		CheckDestroyed();
		if (!ClaimTaskResource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.AIController:ClaimTaskResource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClaimTaskResource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClaimTaskResource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UGameplayTaskResource>.ToNative(IntPtr.Add(intPtr, ClaimTaskResource_ResourceClass_Offset), 0, ClaimTaskResource_ResourceClass_PropertyAddress.Address, ResourceClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClaimTaskResource_FunctionAddress, intPtr, ClaimTaskResource_ParamsSize);
	}

	static AIController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AIController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AIController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.AIController");
		NativeReflectionCached.GetPropertyRef(ref StartAILogicOnPossess_PropertyAddress, intPtr, "bStartAILogicOnPossess");
		StartAILogicOnPossess_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStartAILogicOnPossess");
		StartAILogicOnPossess_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStartAILogicOnPossess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAILogicOnUnposses_PropertyAddress, intPtr, "bStopAILogicOnUnposses");
		StopAILogicOnUnposses_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStopAILogicOnUnposses");
		StopAILogicOnUnposses_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStopAILogicOnUnposses", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipExtraLOSChecks_PropertyAddress, intPtr, "bSkipExtraLOSChecks");
		SkipExtraLOSChecks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipExtraLOSChecks");
		SkipExtraLOSChecks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipExtraLOSChecks", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowStrafe_PropertyAddress, intPtr, "bAllowStrafe");
		AllowStrafe_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowStrafe");
		AllowStrafe_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowStrafe", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WantsPlayerState_PropertyAddress, intPtr, "bWantsPlayerState");
		WantsPlayerState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWantsPlayerState");
		WantsPlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWantsPlayerState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetControlRotationFromPawnOrientation_PropertyAddress, intPtr, "bSetControlRotationFromPawnOrientation");
		SetControlRotationFromPawnOrientation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSetControlRotationFromPawnOrientation");
		SetControlRotationFromPawnOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSetControlRotationFromPawnOrientation", Classes.FBoolProperty);
		BrainComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BrainComponent");
		BrainComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BrainComponent", Classes.FObjectProperty);
		ActionsComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActionsComp");
		ActionsComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActionsComp", Classes.FObjectProperty);
		Blackboard_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Blackboard");
		Blackboard_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Blackboard", Classes.FObjectProperty);
		DefaultNavigationFilterClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultNavigationFilterClass");
		DefaultNavigationFilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultNavigationFilterClass", Classes.FClassProperty);
		ReceiveMoveCompleted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReceiveMoveCompleted");
		ReceiveMoveCompleted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReceiveMoveCompleted", Classes.FMulticastDelegateProperty);
		UseBlackboard_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UseBlackboard");
		UseBlackboard_ParamsSize = NativeReflection.GetFunctionParamsSize(UseBlackboard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UseBlackboard_BlackboardAsset_PropertyAddress, UseBlackboard_FunctionAddress, "BlackboardAsset");
		UseBlackboard_BlackboardAsset_Offset = NativeReflectionCached.GetPropertyOffset(UseBlackboard_FunctionAddress, "BlackboardAsset");
		UseBlackboard_BlackboardAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(UseBlackboard_FunctionAddress, "BlackboardAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBlackboard_BlackboardComponent_PropertyAddress, UseBlackboard_FunctionAddress, "BlackboardComponent");
		UseBlackboard_BlackboardComponent_Offset = NativeReflectionCached.GetPropertyOffset(UseBlackboard_FunctionAddress, "BlackboardComponent");
		UseBlackboard_BlackboardComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(UseBlackboard_FunctionAddress, "BlackboardComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseBlackboard_ReturnValue_PropertyAddress, UseBlackboard_FunctionAddress, "ReturnValue");
		UseBlackboard_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UseBlackboard_FunctionAddress, "ReturnValue");
		UseBlackboard_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UseBlackboard_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		UseBlackboard_IsValid = UseBlackboard_FunctionAddress != IntPtr.Zero && UseBlackboard_BlackboardAsset_IsValid && UseBlackboard_BlackboardComponent_IsValid && UseBlackboard_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:UseBlackboard", UseBlackboard_IsValid);
		UnclaimTaskResource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnclaimTaskResource");
		UnclaimTaskResource_ParamsSize = NativeReflection.GetFunctionParamsSize(UnclaimTaskResource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnclaimTaskResource_ResourceClass_PropertyAddress, UnclaimTaskResource_FunctionAddress, "ResourceClass");
		UnclaimTaskResource_ResourceClass_Offset = NativeReflectionCached.GetPropertyOffset(UnclaimTaskResource_FunctionAddress, "ResourceClass");
		UnclaimTaskResource_ResourceClass_IsValid = NativeReflectionCached.ValidatePropertyClass(UnclaimTaskResource_FunctionAddress, "ResourceClass", Classes.FClassProperty);
		UnclaimTaskResource_IsValid = UnclaimTaskResource_FunctionAddress != IntPtr.Zero && UnclaimTaskResource_ResourceClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:UnclaimTaskResource", UnclaimTaskResource_IsValid);
		SetPathFollowingComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPathFollowingComponent");
		SetPathFollowingComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPathFollowingComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPathFollowingComponent_NewPFComponent_PropertyAddress, SetPathFollowingComponent_FunctionAddress, "NewPFComponent");
		SetPathFollowingComponent_NewPFComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetPathFollowingComponent_FunctionAddress, "NewPFComponent");
		SetPathFollowingComponent_NewPFComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPathFollowingComponent_FunctionAddress, "NewPFComponent", Classes.FObjectProperty);
		SetPathFollowingComponent_IsValid = SetPathFollowingComponent_FunctionAddress != IntPtr.Zero && SetPathFollowingComponent_NewPFComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:SetPathFollowingComponent", SetPathFollowingComponent_IsValid);
		SetMoveBlockDetection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMoveBlockDetection");
		SetMoveBlockDetection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMoveBlockDetection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMoveBlockDetection_bEnable_PropertyAddress, SetMoveBlockDetection_FunctionAddress, "bEnable");
		SetMoveBlockDetection_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetMoveBlockDetection_FunctionAddress, "bEnable");
		SetMoveBlockDetection_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMoveBlockDetection_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetMoveBlockDetection_IsValid = SetMoveBlockDetection_FunctionAddress != IntPtr.Zero && SetMoveBlockDetection_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:SetMoveBlockDetection", SetMoveBlockDetection_IsValid);
		RunBehaviorTree_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RunBehaviorTree");
		RunBehaviorTree_ParamsSize = NativeReflection.GetFunctionParamsSize(RunBehaviorTree_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunBehaviorTree_BTAsset_PropertyAddress, RunBehaviorTree_FunctionAddress, "BTAsset");
		RunBehaviorTree_BTAsset_Offset = NativeReflectionCached.GetPropertyOffset(RunBehaviorTree_FunctionAddress, "BTAsset");
		RunBehaviorTree_BTAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(RunBehaviorTree_FunctionAddress, "BTAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RunBehaviorTree_ReturnValue_PropertyAddress, RunBehaviorTree_FunctionAddress, "ReturnValue");
		RunBehaviorTree_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunBehaviorTree_FunctionAddress, "ReturnValue");
		RunBehaviorTree_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunBehaviorTree_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RunBehaviorTree_IsValid = RunBehaviorTree_FunctionAddress != IntPtr.Zero && RunBehaviorTree_BTAsset_IsValid && RunBehaviorTree_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:RunBehaviorTree", RunBehaviorTree_IsValid);
		OnUsingBlackBoard_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnUsingBlackBoard");
		OnUsingBlackBoard_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUsingBlackBoard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnUsingBlackBoard_BlackboardComp_PropertyAddress, OnUsingBlackBoard_FunctionAddress, "BlackboardComp");
		OnUsingBlackBoard_BlackboardComp_Offset = NativeReflectionCached.GetPropertyOffset(OnUsingBlackBoard_FunctionAddress, "BlackboardComp");
		OnUsingBlackBoard_BlackboardComp_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUsingBlackBoard_FunctionAddress, "BlackboardComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnUsingBlackBoard_BlackboardAsset_PropertyAddress, OnUsingBlackBoard_FunctionAddress, "BlackboardAsset");
		OnUsingBlackBoard_BlackboardAsset_Offset = NativeReflectionCached.GetPropertyOffset(OnUsingBlackBoard_FunctionAddress, "BlackboardAsset");
		OnUsingBlackBoard_BlackboardAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUsingBlackBoard_FunctionAddress, "BlackboardAsset", Classes.FObjectProperty);
		OnUsingBlackBoard_IsValid = OnUsingBlackBoard_FunctionAddress != IntPtr.Zero && OnUsingBlackBoard_BlackboardComp_IsValid && OnUsingBlackBoard_BlackboardAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:OnUsingBlackBoard", OnUsingBlackBoard_IsValid);
		MoveToLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveToLocation");
		MoveToLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveToLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_Dest_PropertyAddress, MoveToLocation_FunctionAddress, "Dest");
		MoveToLocation_Dest_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "Dest");
		MoveToLocation_Dest_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "Dest", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_AcceptanceRadius_PropertyAddress, MoveToLocation_FunctionAddress, "AcceptanceRadius");
		MoveToLocation_AcceptanceRadius_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "AcceptanceRadius");
		MoveToLocation_AcceptanceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "AcceptanceRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_bStopOnOverlap_PropertyAddress, MoveToLocation_FunctionAddress, "bStopOnOverlap");
		MoveToLocation_bStopOnOverlap_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "bStopOnOverlap");
		MoveToLocation_bStopOnOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "bStopOnOverlap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_bUsePathfinding_PropertyAddress, MoveToLocation_FunctionAddress, "bUsePathfinding");
		MoveToLocation_bUsePathfinding_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "bUsePathfinding");
		MoveToLocation_bUsePathfinding_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "bUsePathfinding", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_bProjectDestinationToNavigation_PropertyAddress, MoveToLocation_FunctionAddress, "bProjectDestinationToNavigation");
		MoveToLocation_bProjectDestinationToNavigation_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "bProjectDestinationToNavigation");
		MoveToLocation_bProjectDestinationToNavigation_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "bProjectDestinationToNavigation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_bCanStrafe_PropertyAddress, MoveToLocation_FunctionAddress, "bCanStrafe");
		MoveToLocation_bCanStrafe_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "bCanStrafe");
		MoveToLocation_bCanStrafe_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "bCanStrafe", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_FilterClass_PropertyAddress, MoveToLocation_FunctionAddress, "FilterClass");
		MoveToLocation_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "FilterClass");
		MoveToLocation_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_bAllowPartialPath_PropertyAddress, MoveToLocation_FunctionAddress, "bAllowPartialPath");
		MoveToLocation_bAllowPartialPath_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "bAllowPartialPath");
		MoveToLocation_bAllowPartialPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "bAllowPartialPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToLocation_ReturnValue_PropertyAddress, MoveToLocation_FunctionAddress, "ReturnValue");
		MoveToLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MoveToLocation_FunctionAddress, "ReturnValue");
		MoveToLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToLocation_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		MoveToLocation_IsValid = MoveToLocation_FunctionAddress != IntPtr.Zero && MoveToLocation_Dest_IsValid && MoveToLocation_AcceptanceRadius_IsValid && MoveToLocation_bStopOnOverlap_IsValid && MoveToLocation_bUsePathfinding_IsValid && MoveToLocation_bProjectDestinationToNavigation_IsValid && MoveToLocation_bCanStrafe_IsValid && MoveToLocation_FilterClass_IsValid && MoveToLocation_bAllowPartialPath_IsValid && MoveToLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:MoveToLocation", MoveToLocation_IsValid);
		MoveToActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveToActor");
		MoveToActor_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveToActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_Goal_PropertyAddress, MoveToActor_FunctionAddress, "Goal");
		MoveToActor_Goal_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "Goal");
		MoveToActor_Goal_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "Goal", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_AcceptanceRadius_PropertyAddress, MoveToActor_FunctionAddress, "AcceptanceRadius");
		MoveToActor_AcceptanceRadius_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "AcceptanceRadius");
		MoveToActor_AcceptanceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "AcceptanceRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_bStopOnOverlap_PropertyAddress, MoveToActor_FunctionAddress, "bStopOnOverlap");
		MoveToActor_bStopOnOverlap_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "bStopOnOverlap");
		MoveToActor_bStopOnOverlap_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "bStopOnOverlap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_bUsePathfinding_PropertyAddress, MoveToActor_FunctionAddress, "bUsePathfinding");
		MoveToActor_bUsePathfinding_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "bUsePathfinding");
		MoveToActor_bUsePathfinding_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "bUsePathfinding", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_bCanStrafe_PropertyAddress, MoveToActor_FunctionAddress, "bCanStrafe");
		MoveToActor_bCanStrafe_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "bCanStrafe");
		MoveToActor_bCanStrafe_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "bCanStrafe", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_FilterClass_PropertyAddress, MoveToActor_FunctionAddress, "FilterClass");
		MoveToActor_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "FilterClass");
		MoveToActor_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_bAllowPartialPath_PropertyAddress, MoveToActor_FunctionAddress, "bAllowPartialPath");
		MoveToActor_bAllowPartialPath_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "bAllowPartialPath");
		MoveToActor_bAllowPartialPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "bAllowPartialPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveToActor_ReturnValue_PropertyAddress, MoveToActor_FunctionAddress, "ReturnValue");
		MoveToActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MoveToActor_FunctionAddress, "ReturnValue");
		MoveToActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveToActor_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		MoveToActor_IsValid = MoveToActor_FunctionAddress != IntPtr.Zero && MoveToActor_Goal_IsValid && MoveToActor_AcceptanceRadius_IsValid && MoveToActor_bStopOnOverlap_IsValid && MoveToActor_bUsePathfinding_IsValid && MoveToActor_bCanStrafe_IsValid && MoveToActor_FilterClass_IsValid && MoveToActor_bAllowPartialPath_IsValid && MoveToActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:MoveToActor", MoveToActor_IsValid);
		SetFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetFocus");
		SetFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFocus_NewFocus_PropertyAddress, SetFocus_FunctionAddress, "NewFocus");
		SetFocus_NewFocus_Offset = NativeReflectionCached.GetPropertyOffset(SetFocus_FunctionAddress, "NewFocus");
		SetFocus_NewFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFocus_FunctionAddress, "NewFocus", Classes.FObjectProperty);
		SetFocus_IsValid = SetFocus_FunctionAddress != IntPtr.Zero && SetFocus_NewFocus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:K2_SetFocus", SetFocus_IsValid);
		SetFocalPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetFocalPoint");
		SetFocalPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFocalPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFocalPoint_FP_PropertyAddress, SetFocalPoint_FunctionAddress, "FP");
		SetFocalPoint_FP_Offset = NativeReflectionCached.GetPropertyOffset(SetFocalPoint_FunctionAddress, "FP");
		SetFocalPoint_FP_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFocalPoint_FunctionAddress, "FP", Classes.FStructProperty);
		SetFocalPoint_IsValid = SetFocalPoint_FunctionAddress != IntPtr.Zero && SetFocalPoint_FP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:K2_SetFocalPoint", SetFocalPoint_IsValid);
		ClearFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_ClearFocus");
		ClearFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearFocus_FunctionAddress);
		ClearFocus_IsValid = ClearFocus_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:K2_ClearFocus", ClearFocus_IsValid);
		HasPartialPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasPartialPath");
		HasPartialPath_ParamsSize = NativeReflection.GetFunctionParamsSize(HasPartialPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasPartialPath_ReturnValue_PropertyAddress, HasPartialPath_FunctionAddress, "ReturnValue");
		HasPartialPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasPartialPath_FunctionAddress, "ReturnValue");
		HasPartialPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasPartialPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasPartialPath_IsValid = HasPartialPath_FunctionAddress != IntPtr.Zero && HasPartialPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:HasPartialPath", HasPartialPath_IsValid);
		GetPathFollowingComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPathFollowingComponent");
		GetPathFollowingComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathFollowingComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathFollowingComponent_ReturnValue_PropertyAddress, GetPathFollowingComponent_FunctionAddress, "ReturnValue");
		GetPathFollowingComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathFollowingComponent_FunctionAddress, "ReturnValue");
		GetPathFollowingComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathFollowingComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPathFollowingComponent_IsValid = GetPathFollowingComponent_FunctionAddress != IntPtr.Zero && GetPathFollowingComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:GetPathFollowingComponent", GetPathFollowingComponent_IsValid);
		GetMoveStatus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMoveStatus");
		GetMoveStatus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMoveStatus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMoveStatus_ReturnValue_PropertyAddress, GetMoveStatus_FunctionAddress, "ReturnValue");
		GetMoveStatus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMoveStatus_FunctionAddress, "ReturnValue");
		GetMoveStatus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMoveStatus_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetMoveStatus_IsValid = GetMoveStatus_FunctionAddress != IntPtr.Zero && GetMoveStatus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:GetMoveStatus", GetMoveStatus_IsValid);
		GetImmediateMoveDestination_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetImmediateMoveDestination");
		GetImmediateMoveDestination_ParamsSize = NativeReflection.GetFunctionParamsSize(GetImmediateMoveDestination_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetImmediateMoveDestination_ReturnValue_PropertyAddress, GetImmediateMoveDestination_FunctionAddress, "ReturnValue");
		GetImmediateMoveDestination_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetImmediateMoveDestination_FunctionAddress, "ReturnValue");
		GetImmediateMoveDestination_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetImmediateMoveDestination_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetImmediateMoveDestination_IsValid = GetImmediateMoveDestination_FunctionAddress != IntPtr.Zero && GetImmediateMoveDestination_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:GetImmediateMoveDestination", GetImmediateMoveDestination_IsValid);
		GetFocusActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFocusActor");
		GetFocusActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFocusActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFocusActor_ReturnValue_PropertyAddress, GetFocusActor_FunctionAddress, "ReturnValue");
		GetFocusActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFocusActor_FunctionAddress, "ReturnValue");
		GetFocusActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocusActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFocusActor_IsValid = GetFocusActor_FunctionAddress != IntPtr.Zero && GetFocusActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:GetFocusActor", GetFocusActor_IsValid);
		GetFocalPointOnActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFocalPointOnActor");
		GetFocalPointOnActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFocalPointOnActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFocalPointOnActor_Actor_PropertyAddress, GetFocalPointOnActor_FunctionAddress, "Actor");
		GetFocalPointOnActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetFocalPointOnActor_FunctionAddress, "Actor");
		GetFocalPointOnActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocalPointOnActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFocalPointOnActor_ReturnValue_PropertyAddress, GetFocalPointOnActor_FunctionAddress, "ReturnValue");
		GetFocalPointOnActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFocalPointOnActor_FunctionAddress, "ReturnValue");
		GetFocalPointOnActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocalPointOnActor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFocalPointOnActor_IsValid = GetFocalPointOnActor_FunctionAddress != IntPtr.Zero && GetFocalPointOnActor_Actor_IsValid && GetFocalPointOnActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:GetFocalPointOnActor", GetFocalPointOnActor_IsValid);
		GetFocalPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFocalPoint");
		GetFocalPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFocalPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFocalPoint_ReturnValue_PropertyAddress, GetFocalPoint_FunctionAddress, "ReturnValue");
		GetFocalPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFocalPoint_FunctionAddress, "ReturnValue");
		GetFocalPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFocalPoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFocalPoint_IsValid = GetFocalPoint_FunctionAddress != IntPtr.Zero && GetFocalPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:GetFocalPoint", GetFocalPoint_IsValid);
		GetAIPerceptionComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAIPerceptionComponent");
		GetAIPerceptionComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAIPerceptionComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAIPerceptionComponent_ReturnValue_PropertyAddress, GetAIPerceptionComponent_FunctionAddress, "ReturnValue");
		GetAIPerceptionComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAIPerceptionComponent_FunctionAddress, "ReturnValue");
		GetAIPerceptionComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAIPerceptionComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAIPerceptionComponent_IsValid = GetAIPerceptionComponent_FunctionAddress != IntPtr.Zero && GetAIPerceptionComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:GetAIPerceptionComponent", GetAIPerceptionComponent_IsValid);
		ClaimTaskResource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClaimTaskResource");
		ClaimTaskResource_ParamsSize = NativeReflection.GetFunctionParamsSize(ClaimTaskResource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClaimTaskResource_ResourceClass_PropertyAddress, ClaimTaskResource_FunctionAddress, "ResourceClass");
		ClaimTaskResource_ResourceClass_Offset = NativeReflectionCached.GetPropertyOffset(ClaimTaskResource_FunctionAddress, "ResourceClass");
		ClaimTaskResource_ResourceClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ClaimTaskResource_FunctionAddress, "ResourceClass", Classes.FClassProperty);
		ClaimTaskResource_IsValid = ClaimTaskResource_FunctionAddress != IntPtr.Zero && ClaimTaskResource_ResourceClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.AIController:ClaimTaskResource", ClaimTaskResource_IsValid);
	}
}
