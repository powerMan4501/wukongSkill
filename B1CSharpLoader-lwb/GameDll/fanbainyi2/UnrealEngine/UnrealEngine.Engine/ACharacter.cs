using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.Character", "Engine", UnrealModuleType.Engine)]
public class ACharacter : APawn
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool CharacterMovement_IsValid;

	private static int CharacterMovement_Offset;

	private static bool CapsuleComponent_IsValid;

	private static int CapsuleComponent_Offset;

	private static bool CrouchedEyeHeight_IsValid;

	private static int CrouchedEyeHeight_Offset;

	private static bool IsCrouched_IsValid;

	private static FFieldAddress IsCrouched_PropertyAddress;

	private static int IsCrouched_Offset;

	private static bool PressedJump_IsValid;

	private static FFieldAddress PressedJump_PropertyAddress;

	private static int PressedJump_Offset;

	private static bool WasJumping_IsValid;

	private static FFieldAddress WasJumping_PropertyAddress;

	private static int WasJumping_Offset;

	private static bool JumpKeyHoldTime_IsValid;

	private static int JumpKeyHoldTime_Offset;

	private static bool JumpForceTimeRemaining_IsValid;

	private static int JumpForceTimeRemaining_Offset;

	private static bool ProxyJumpForceStartedTime_IsValid;

	private static int ProxyJumpForceStartedTime_Offset;

	private static bool JumpMaxHoldTime_IsValid;

	private static int JumpMaxHoldTime_Offset;

	private static bool JumpMaxCount_IsValid;

	private static int JumpMaxCount_Offset;

	private static bool JumpCurrentCount_IsValid;

	private static int JumpCurrentCount_Offset;

	private static bool JumpCurrentCountPreJump_IsValid;

	private static int JumpCurrentCountPreJump_Offset;

	private static bool OnReachedJumpApex_IsValid;

	private static int OnReachedJumpApex_Offset;

	private FCharacterReachedApexSignature OnReachedJumpApex_DelegateCached;

	private static bool MovementModeChangedDelegate_IsValid;

	private static int MovementModeChangedDelegate_Offset;

	private FMovementModeChangedSignature MovementModeChangedDelegate_DelegateCached;

	private static bool OnCharacterMovementUpdated_IsValid;

	private static int OnCharacterMovementUpdated_Offset;

	private FCharacterMovementUpdatedSignature OnCharacterMovementUpdated_DelegateCached;

	private static bool UnCrouch_IsValid;

	private static IntPtr UnCrouch_FunctionAddress;

	private static int UnCrouch_ParamsSize;

	private static bool UnCrouch_bClientSimulation_IsValid;

	private static FFieldAddress UnCrouch_bClientSimulation_PropertyAddress;

	private static int UnCrouch_bClientSimulation_Offset;

	private static bool StopJumping_IsValid;

	private static IntPtr StopJumping_FunctionAddress;

	private static int StopJumping_ParamsSize;

	private static bool StopAnimMontage_IsValid;

	private static IntPtr StopAnimMontage_FunctionAddress;

	private static int StopAnimMontage_ParamsSize;

	private static bool StopAnimMontage_AnimMontage_IsValid;

	private static FFieldAddress StopAnimMontage_AnimMontage_PropertyAddress;

	private static int StopAnimMontage_AnimMontage_Offset;

	private static bool PlayAnimMontage_IsValid;

	private static IntPtr PlayAnimMontage_FunctionAddress;

	private static int PlayAnimMontage_ParamsSize;

	private static bool PlayAnimMontage_AnimMontage_IsValid;

	private static FFieldAddress PlayAnimMontage_AnimMontage_PropertyAddress;

	private static int PlayAnimMontage_AnimMontage_Offset;

	private static bool PlayAnimMontage_InPlayRate_IsValid;

	private static FFieldAddress PlayAnimMontage_InPlayRate_PropertyAddress;

	private static int PlayAnimMontage_InPlayRate_Offset;

	private static bool PlayAnimMontage_StartSectionName_IsValid;

	private static FFieldAddress PlayAnimMontage_StartSectionName_PropertyAddress;

	private static int PlayAnimMontage_StartSectionName_Offset;

	private static bool PlayAnimMontage_ReturnValue_IsValid;

	private static FFieldAddress PlayAnimMontage_ReturnValue_PropertyAddress;

	private static int PlayAnimMontage_ReturnValue_Offset;

	private static bool OnWalkingOffLedge_IsValid;

	private IntPtr OnWalkingOffLedge_InstanceFunctionAddress;

	private static IntPtr OnWalkingOffLedge_FunctionAddress;

	private static int OnWalkingOffLedge_ParamsSize;

	private static bool OnWalkingOffLedge_PreviousFloorImpactNormal_IsValid;

	private static FFieldAddress OnWalkingOffLedge_PreviousFloorImpactNormal_PropertyAddress;

	private static int OnWalkingOffLedge_PreviousFloorImpactNormal_Offset;

	private static bool OnWalkingOffLedge_PreviousFloorContactNormal_IsValid;

	private static FFieldAddress OnWalkingOffLedge_PreviousFloorContactNormal_PropertyAddress;

	private static int OnWalkingOffLedge_PreviousFloorContactNormal_Offset;

	private static bool OnWalkingOffLedge_PreviousLocation_IsValid;

	private static FFieldAddress OnWalkingOffLedge_PreviousLocation_PropertyAddress;

	private static int OnWalkingOffLedge_PreviousLocation_Offset;

	private static bool OnWalkingOffLedge_TimeDelta_IsValid;

	private static FFieldAddress OnWalkingOffLedge_TimeDelta_PropertyAddress;

	private static int OnWalkingOffLedge_TimeDelta_Offset;

	private static bool OnLaunched_IsValid;

	private IntPtr OnLaunched_InstanceFunctionAddress;

	private static IntPtr OnLaunched_FunctionAddress;

	private static int OnLaunched_ParamsSize;

	private static bool OnLaunched_LaunchVelocity_IsValid;

	private static FFieldAddress OnLaunched_LaunchVelocity_PropertyAddress;

	private static int OnLaunched_LaunchVelocity_Offset;

	private static bool OnLaunched_bXYOverride_IsValid;

	private static FFieldAddress OnLaunched_bXYOverride_PropertyAddress;

	private static int OnLaunched_bXYOverride_Offset;

	private static bool OnLaunched_bZOverride_IsValid;

	private static FFieldAddress OnLaunched_bZOverride_PropertyAddress;

	private static int OnLaunched_bZOverride_Offset;

	private static bool OnLanded_IsValid;

	private IntPtr OnLanded_InstanceFunctionAddress;

	private static IntPtr OnLanded_FunctionAddress;

	private static int OnLanded_ParamsSize;

	private static bool OnLanded_Hit_IsValid;

	private static FFieldAddress OnLanded_Hit_PropertyAddress;

	private static int OnLanded_Hit_Offset;

	private static bool OnJumped_IsValid;

	private IntPtr OnJumped_InstanceFunctionAddress;

	private static IntPtr OnJumped_FunctionAddress;

	private static int OnJumped_ParamsSize;

	private static bool LaunchCharacter_IsValid;

	private static IntPtr LaunchCharacter_FunctionAddress;

	private static int LaunchCharacter_ParamsSize;

	private static bool LaunchCharacter_LaunchVelocity_IsValid;

	private static FFieldAddress LaunchCharacter_LaunchVelocity_PropertyAddress;

	private static int LaunchCharacter_LaunchVelocity_Offset;

	private static bool LaunchCharacter_bXYOverride_IsValid;

	private static FFieldAddress LaunchCharacter_bXYOverride_PropertyAddress;

	private static int LaunchCharacter_bXYOverride_Offset;

	private static bool LaunchCharacter_bZOverride_IsValid;

	private static FFieldAddress LaunchCharacter_bZOverride_PropertyAddress;

	private static int LaunchCharacter_bZOverride_Offset;

	private static bool UpdateCustomMovement_IsValid;

	private IntPtr UpdateCustomMovement_InstanceFunctionAddress;

	private static IntPtr UpdateCustomMovement_FunctionAddress;

	private static int UpdateCustomMovement_ParamsSize;

	private static bool UpdateCustomMovement_DeltaTime_IsValid;

	private static FFieldAddress UpdateCustomMovement_DeltaTime_PropertyAddress;

	private static int UpdateCustomMovement_DeltaTime_Offset;

	private static bool OnStartCrouch_IsValid;

	private IntPtr OnStartCrouch_InstanceFunctionAddress;

	private static IntPtr OnStartCrouch_FunctionAddress;

	private static int OnStartCrouch_ParamsSize;

	private static bool OnStartCrouch_HalfHeightAdjust_IsValid;

	private static FFieldAddress OnStartCrouch_HalfHeightAdjust_PropertyAddress;

	private static int OnStartCrouch_HalfHeightAdjust_Offset;

	private static bool OnStartCrouch_ScaledHalfHeightAdjust_IsValid;

	private static FFieldAddress OnStartCrouch_ScaledHalfHeightAdjust_PropertyAddress;

	private static int OnStartCrouch_ScaledHalfHeightAdjust_Offset;

	private static bool OnMovementModeChanged_IsValid;

	private IntPtr OnMovementModeChanged_InstanceFunctionAddress;

	private static IntPtr OnMovementModeChanged_FunctionAddress;

	private static int OnMovementModeChanged_ParamsSize;

	private static bool OnMovementModeChanged_PrevMovementMode_IsValid;

	private static FFieldAddress OnMovementModeChanged_PrevMovementMode_PropertyAddress;

	private static int OnMovementModeChanged_PrevMovementMode_Offset;

	private static bool OnMovementModeChanged_NewMovementMode_IsValid;

	private static FFieldAddress OnMovementModeChanged_NewMovementMode_PropertyAddress;

	private static int OnMovementModeChanged_NewMovementMode_Offset;

	private static bool OnMovementModeChanged_PrevCustomMode_IsValid;

	private static FFieldAddress OnMovementModeChanged_PrevCustomMode_PropertyAddress;

	private static int OnMovementModeChanged_PrevCustomMode_Offset;

	private static bool OnMovementModeChanged_NewCustomMode_IsValid;

	private static FFieldAddress OnMovementModeChanged_NewCustomMode_PropertyAddress;

	private static int OnMovementModeChanged_NewCustomMode_Offset;

	private static bool OnEndCrouch_IsValid;

	private IntPtr OnEndCrouch_InstanceFunctionAddress;

	private static IntPtr OnEndCrouch_FunctionAddress;

	private static int OnEndCrouch_ParamsSize;

	private static bool OnEndCrouch_HalfHeightAdjust_IsValid;

	private static FFieldAddress OnEndCrouch_HalfHeightAdjust_PropertyAddress;

	private static int OnEndCrouch_HalfHeightAdjust_Offset;

	private static bool OnEndCrouch_ScaledHalfHeightAdjust_IsValid;

	private static FFieldAddress OnEndCrouch_ScaledHalfHeightAdjust_PropertyAddress;

	private static int OnEndCrouch_ScaledHalfHeightAdjust_Offset;

	private static bool Jump_IsValid;

	private static IntPtr Jump_FunctionAddress;

	private static int Jump_ParamsSize;

	private static bool IsPlayingRootMotion_IsValid;

	private static IntPtr IsPlayingRootMotion_FunctionAddress;

	private static int IsPlayingRootMotion_ParamsSize;

	private static bool IsPlayingRootMotion_ReturnValue_IsValid;

	private static FFieldAddress IsPlayingRootMotion_ReturnValue_PropertyAddress;

	private static int IsPlayingRootMotion_ReturnValue_Offset;

	private static bool IsPlayingNetworkedRootMotionMontage_IsValid;

	private static IntPtr IsPlayingNetworkedRootMotionMontage_FunctionAddress;

	private static int IsPlayingNetworkedRootMotionMontage_ParamsSize;

	private static bool IsPlayingNetworkedRootMotionMontage_ReturnValue_IsValid;

	private static FFieldAddress IsPlayingNetworkedRootMotionMontage_ReturnValue_PropertyAddress;

	private static int IsPlayingNetworkedRootMotionMontage_ReturnValue_Offset;

	private static bool IsJumpProvidingForce_IsValid;

	private static IntPtr IsJumpProvidingForce_FunctionAddress;

	private static int IsJumpProvidingForce_ParamsSize;

	private static bool IsJumpProvidingForce_ReturnValue_IsValid;

	private static FFieldAddress IsJumpProvidingForce_ReturnValue_PropertyAddress;

	private static int IsJumpProvidingForce_ReturnValue_Offset;

	private static bool HasAnyRootMotion_IsValid;

	private static IntPtr HasAnyRootMotion_FunctionAddress;

	private static int HasAnyRootMotion_ParamsSize;

	private static bool HasAnyRootMotion_ReturnValue_IsValid;

	private static FFieldAddress HasAnyRootMotion_ReturnValue_PropertyAddress;

	private static int HasAnyRootMotion_ReturnValue_Offset;

	private static bool GetCurrentMontage_IsValid;

	private static IntPtr GetCurrentMontage_FunctionAddress;

	private static int GetCurrentMontage_ParamsSize;

	private static bool GetCurrentMontage_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentMontage_ReturnValue_PropertyAddress;

	private static int GetCurrentMontage_ReturnValue_Offset;

	private static bool GetBaseTranslationOffset_IsValid;

	private static IntPtr GetBaseTranslationOffset_FunctionAddress;

	private static int GetBaseTranslationOffset_ParamsSize;

	private static bool GetBaseTranslationOffset_ReturnValue_IsValid;

	private static FFieldAddress GetBaseTranslationOffset_ReturnValue_PropertyAddress;

	private static int GetBaseTranslationOffset_ReturnValue_Offset;

	private static bool GetBaseRotationOffset_IsValid;

	private static IntPtr GetBaseRotationOffset_FunctionAddress;

	private static int GetBaseRotationOffset_ParamsSize;

	private static bool GetBaseRotationOffset_ReturnValue_IsValid;

	private static FFieldAddress GetBaseRotationOffset_ReturnValue_PropertyAddress;

	private static int GetBaseRotationOffset_ReturnValue_Offset;

	private static bool GetAnimRootMotionTranslationScale_IsValid;

	private static IntPtr GetAnimRootMotionTranslationScale_FunctionAddress;

	private static int GetAnimRootMotionTranslationScale_ParamsSize;

	private static bool GetAnimRootMotionTranslationScale_ReturnValue_IsValid;

	private static FFieldAddress GetAnimRootMotionTranslationScale_ReturnValue_PropertyAddress;

	private static int GetAnimRootMotionTranslationScale_ReturnValue_Offset;

	private static bool Crouch_IsValid;

	private static IntPtr Crouch_FunctionAddress;

	private static int Crouch_ParamsSize;

	private static bool Crouch_bClientSimulation_IsValid;

	private static FFieldAddress Crouch_bClientSimulation_PropertyAddress;

	private static int Crouch_bClientSimulation_Offset;

	private static bool CanJumpInternal_IsValid;

	private IntPtr CanJumpInternal_InstanceFunctionAddress;

	private static IntPtr CanJumpInternal_FunctionAddress;

	private static int CanJumpInternal_ParamsSize;

	private static bool CanJumpInternal_ReturnValue_IsValid;

	private static FFieldAddress CanJumpInternal_ReturnValue_PropertyAddress;

	private static int CanJumpInternal_ReturnValue_Offset;

	private static bool CanJump_IsValid;

	private static IntPtr CanJump_FunctionAddress;

	private static int CanJump_ParamsSize;

	private static bool CanJump_ReturnValue_IsValid;

	private static FFieldAddress CanJump_ReturnValue_PropertyAddress;

	private static int CanJump_ReturnValue_Offset;

	private static bool CanCrouch_IsValid;

	private static IntPtr CanCrouch_FunctionAddress;

	private static int CanCrouch_ParamsSize;

	private static bool CanCrouch_ReturnValue_IsValid;

	private static FFieldAddress CanCrouch_ReturnValue_PropertyAddress;

	private static int CanCrouch_ReturnValue_Offset;

	private static bool CacheInitialMeshOffset_IsValid;

	private static IntPtr CacheInitialMeshOffset_FunctionAddress;

	private static int CacheInitialMeshOffset_ParamsSize;

	private static bool CacheInitialMeshOffset_MeshRelativeLocation_IsValid;

	private static FFieldAddress CacheInitialMeshOffset_MeshRelativeLocation_PropertyAddress;

	private static int CacheInitialMeshOffset_MeshRelativeLocation_Offset;

	private static bool CacheInitialMeshOffset_MeshRelativeRotation_IsValid;

	private static FFieldAddress CacheInitialMeshOffset_MeshRelativeRotation_PropertyAddress;

	private static int CacheInitialMeshOffset_MeshRelativeRotation_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.Character:Mesh")]
	public USkeletalMeshComponent Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:Mesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:Mesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.Character:CharacterMovement")]
	public UCharacterMovementComponent CharacterMovement
	{
		get
		{
			CheckDestroyed();
			if (!CharacterMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:CharacterMovement");
				return null;
			}
			return UObjectMarshaler<UCharacterMovementComponent>.FromNative(IntPtr.Add(base.Address, CharacterMovement_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:CharacterMovement");
			}
			else
			{
				UObjectMarshaler<UCharacterMovementComponent>.ToNative(IntPtr.Add(base.Address, CharacterMovement_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.Character:CapsuleComponent")]
	public UCapsuleComponent CapsuleComponent
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:CapsuleComponent");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, CapsuleComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:CapsuleComponent");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, CapsuleComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.Character:CrouchedEyeHeight")]
	public float CrouchedEyeHeight
	{
		get
		{
			CheckDestroyed();
			if (!CrouchedEyeHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:CrouchedEyeHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CrouchedEyeHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CrouchedEyeHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:CrouchedEyeHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CrouchedEyeHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755472455499828uL)]
	[UMetaPath("/Script/Engine.Character:bIsCrouched")]
	public bool IsCrouched
	{
		get
		{
			CheckDestroyed();
			if (!IsCrouched_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:bIsCrouched");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCrouched_Offset), 0, IsCrouched_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCrouched_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:bIsCrouched");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCrouched_Offset), 0, IsCrouched_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532500uL)]
	[UMetaPath("/Script/Engine.Character:bPressedJump")]
	public bool PressedJump
	{
		get
		{
			CheckDestroyed();
			if (!PressedJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:bPressedJump");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PressedJump_Offset), 0, PressedJump_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PressedJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:bPressedJump");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PressedJump_Offset), 0, PressedJump_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160673813uL)]
	[UMetaPath("/Script/Engine.Character:bWasJumping")]
	public bool WasJumping
	{
		get
		{
			CheckDestroyed();
			if (!WasJumping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:bWasJumping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WasJumping_Offset), 0, WasJumping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WasJumping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:bWasJumping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WasJumping_Offset), 0, WasJumping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234416149uL)]
	[UMetaPath("/Script/Engine.Character:JumpKeyHoldTime")]
	public float JumpKeyHoldTime
	{
		get
		{
			CheckDestroyed();
			if (!JumpKeyHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpKeyHoldTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpKeyHoldTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpKeyHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpKeyHoldTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpKeyHoldTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234416149uL)]
	[UMetaPath("/Script/Engine.Character:JumpForceTimeRemaining")]
	public float JumpForceTimeRemaining
	{
		get
		{
			CheckDestroyed();
			if (!JumpForceTimeRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpForceTimeRemaining");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpForceTimeRemaining_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpForceTimeRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpForceTimeRemaining");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpForceTimeRemaining_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234416149uL)]
	[UMetaPath("/Script/Engine.Character:ProxyJumpForceStartedTime")]
	public float ProxyJumpForceStartedTime
	{
		get
		{
			CheckDestroyed();
			if (!ProxyJumpForceStartedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:ProxyJumpForceStartedTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProxyJumpForceStartedTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProxyJumpForceStartedTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:ProxyJumpForceStartedTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProxyJumpForceStartedTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274853uL)]
	[UMetaPath("/Script/Engine.Character:JumpMaxHoldTime")]
	public float JumpMaxHoldTime
	{
		get
		{
			CheckDestroyed();
			if (!JumpMaxHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpMaxHoldTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, JumpMaxHoldTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpMaxHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpMaxHoldTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, JumpMaxHoldTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274853uL)]
	[UMetaPath("/Script/Engine.Character:JumpMaxCount")]
	public int JumpMaxCount
	{
		get
		{
			CheckDestroyed();
			if (!JumpMaxCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpMaxCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, JumpMaxCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpMaxCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpMaxCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, JumpMaxCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234407957uL)]
	[UMetaPath("/Script/Engine.Character:JumpCurrentCount")]
	public int JumpCurrentCount
	{
		get
		{
			CheckDestroyed();
			if (!JumpCurrentCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpCurrentCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, JumpCurrentCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpCurrentCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpCurrentCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, JumpCurrentCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234407957uL)]
	[UMetaPath("/Script/Engine.Character:JumpCurrentCountPreJump")]
	public int JumpCurrentCountPreJump
	{
		get
		{
			CheckDestroyed();
			if (!JumpCurrentCountPreJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpCurrentCountPreJump");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, JumpCurrentCountPreJump_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpCurrentCountPreJump_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:JumpCurrentCountPreJump");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, JumpCurrentCountPreJump_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Character:OnReachedJumpApex")]
	public FCharacterReachedApexSignature OnReachedJumpApex
	{
		get
		{
			CheckDestroyed();
			if (!OnReachedJumpApex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:OnReachedJumpApex");
				return new FCharacterReachedApexSignature();
			}
			if (OnReachedJumpApex_DelegateCached == null)
			{
				OnReachedJumpApex_DelegateCached = new FCharacterReachedApexSignature();
				OnReachedJumpApex_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnReachedJumpApex_Offset));
			}
			return OnReachedJumpApex_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Character:MovementModeChangedDelegate")]
	public FMovementModeChangedSignature MovementModeChangedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!MovementModeChangedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:MovementModeChangedDelegate");
				return new FMovementModeChangedSignature();
			}
			if (MovementModeChangedDelegate_DelegateCached == null)
			{
				MovementModeChangedDelegate_DelegateCached = new FMovementModeChangedSignature();
				MovementModeChangedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, MovementModeChangedDelegate_Offset));
			}
			return MovementModeChangedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Character:OnCharacterMovementUpdated")]
	public FCharacterMovementUpdatedSignature OnCharacterMovementUpdated
	{
		get
		{
			CheckDestroyed();
			if (!OnCharacterMovementUpdated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Character:OnCharacterMovementUpdated");
				return new FCharacterMovementUpdatedSignature();
			}
			if (OnCharacterMovementUpdated_DelegateCached == null)
			{
				OnCharacterMovementUpdated_DelegateCached = new FCharacterMovementUpdatedSignature();
				OnCharacterMovementUpdated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCharacterMovementUpdated_Offset));
			}
			return OnCharacterMovementUpdated_DelegateCached;
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Character:UnCrouch")]
	public unsafe void UnCrouch(bool bClientSimulation = false)
	{
		CheckDestroyed();
		if (!UnCrouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:UnCrouch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnCrouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnCrouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, UnCrouch_bClientSimulation_Offset), 0, UnCrouch_bClientSimulation_PropertyAddress.Address, bClientSimulation);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnCrouch_FunctionAddress, intPtr, UnCrouch_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Character:StopJumping")]
	public unsafe void StopJumping()
	{
		CheckDestroyed();
		if (!StopJumping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:StopJumping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopJumping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopJumping_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopJumping_FunctionAddress, argsSize: StopJumping_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Character:StopAnimMontage")]
	public unsafe void StopAnimMontage(UAnimMontage AnimMontage)
	{
		CheckDestroyed();
		if (!StopAnimMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:StopAnimMontage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAnimMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAnimMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, StopAnimMontage_AnimMontage_Offset), 0, StopAnimMontage_AnimMontage_PropertyAddress.Address, AnimMontage);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAnimMontage_FunctionAddress, intPtr, StopAnimMontage_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Character:PlayAnimMontage")]
	public unsafe float PlayAnimMontage(UAnimMontage AnimMontage, float InPlayRate, FName StartSectionName)
	{
		CheckDestroyed();
		if (!PlayAnimMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:PlayAnimMontage");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayAnimMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayAnimMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, PlayAnimMontage_AnimMontage_Offset), 0, PlayAnimMontage_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayAnimMontage_InPlayRate_Offset), 0, PlayAnimMontage_InPlayRate_PropertyAddress.Address, InPlayRate);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PlayAnimMontage_StartSectionName_Offset), 0, PlayAnimMontage_StartSectionName_PropertyAddress.Address, StartSectionName);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayAnimMontage_FunctionAddress, intPtr, PlayAnimMontage_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, PlayAnimMontage_ReturnValue_Offset), 0, PlayAnimMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 146934784u)]
	[UMetaPath("/Script/Engine.Character:OnWalkingOffLedge")]
	public unsafe void OnWalkingOffLedge(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
	{
		CheckDestroyed();
		if (!OnWalkingOffLedge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnWalkingOffLedge");
			return;
		}
		if (OnWalkingOffLedge_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWalkingOffLedge_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWalkingOffLedge");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWalkingOffLedge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWalkingOffLedge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_PreviousFloorImpactNormal_Offset), 0, OnWalkingOffLedge_PreviousFloorImpactNormal_PropertyAddress.Address, PreviousFloorImpactNormal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_PreviousFloorContactNormal_Offset), 0, OnWalkingOffLedge_PreviousFloorContactNormal_PropertyAddress.Address, PreviousFloorContactNormal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_PreviousLocation_Offset), 0, OnWalkingOffLedge_PreviousLocation_PropertyAddress.Address, PreviousLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_TimeDelta_Offset), 0, OnWalkingOffLedge_TimeDelta_PropertyAddress.Address, TimeDelta);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWalkingOffLedge_InstanceFunctionAddress, intPtr, OnWalkingOffLedge_ParamsSize);
	}

	protected unsafe virtual void OnWalkingOffLedge_Implementation(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
	{
		CheckDestroyed();
		if (!OnWalkingOffLedge_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnWalkingOffLedge");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWalkingOffLedge_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWalkingOffLedge_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_PreviousFloorImpactNormal_Offset), 0, OnWalkingOffLedge_PreviousFloorImpactNormal_PropertyAddress.Address, PreviousFloorImpactNormal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_PreviousFloorContactNormal_Offset), 0, OnWalkingOffLedge_PreviousFloorContactNormal_PropertyAddress.Address, PreviousFloorContactNormal);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_PreviousLocation_Offset), 0, OnWalkingOffLedge_PreviousLocation_PropertyAddress.Address, PreviousLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnWalkingOffLedge_TimeDelta_Offset), 0, OnWalkingOffLedge_TimeDelta_PropertyAddress.Address, TimeDelta);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWalkingOffLedge_FunctionAddress, intPtr, OnWalkingOffLedge_ParamsSize);
	}

	[UFunction(Flags = 142739456u)]
	[UMetaPath("/Script/Engine.Character:OnLaunched")]
	public unsafe void OnLaunched(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		CheckDestroyed();
		if (!OnLaunched_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnLaunched");
			return;
		}
		if (OnLaunched_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLaunched_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnLaunched");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLaunched_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLaunched_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnLaunched_LaunchVelocity_Offset), 0, OnLaunched_LaunchVelocity_PropertyAddress.Address, LaunchVelocity);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLaunched_bXYOverride_Offset), 0, OnLaunched_bXYOverride_PropertyAddress.Address, bXYOverride);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLaunched_bZOverride_Offset), 0, OnLaunched_bZOverride_PropertyAddress.Address, bZOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLaunched_InstanceFunctionAddress, intPtr, OnLaunched_ParamsSize);
	}

	protected unsafe virtual void OnLaunched_Implementation(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		CheckDestroyed();
		if (!OnLaunched_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnLaunched");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLaunched_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLaunched_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnLaunched_LaunchVelocity_Offset), 0, OnLaunched_LaunchVelocity_PropertyAddress.Address, LaunchVelocity);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLaunched_bXYOverride_Offset), 0, OnLaunched_bXYOverride_PropertyAddress.Address, bXYOverride);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLaunched_bZOverride_Offset), 0, OnLaunched_bZOverride_PropertyAddress.Address, bZOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLaunched_FunctionAddress, intPtr, OnLaunched_ParamsSize);
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/Engine.Character:OnLanded")]
	public unsafe void OnLanded(FHitResult Hit)
	{
		CheckDestroyed();
		if (!OnLanded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnLanded");
			return;
		}
		if (OnLanded_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLanded_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnLanded");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLanded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLanded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnLanded_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, OnLanded_Hit_Offset), 0, OnLanded_Hit_PropertyAddress.Address, Hit);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLanded_InstanceFunctionAddress, intPtr, OnLanded_ParamsSize);
	}

	protected unsafe virtual void OnLanded_Implementation(FHitResult Hit)
	{
		CheckDestroyed();
		if (!OnLanded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnLanded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLanded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLanded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnLanded_Hit_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, OnLanded_Hit_Offset), 0, OnLanded_Hit_PropertyAddress.Address, Hit);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLanded_FunctionAddress, intPtr, OnLanded_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Engine.Character:OnJumped")]
	public unsafe void OnJumped()
	{
		CheckDestroyed();
		if (!OnJumped_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnJumped");
			return;
		}
		if (OnJumped_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnJumped_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnJumped");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnJumped_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnJumped_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnJumped_InstanceFunctionAddress, argsSize: OnJumped_ParamsSize);
	}

	protected unsafe virtual void OnJumped_Implementation()
	{
		CheckDestroyed();
		if (!OnJumped_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:OnJumped");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnJumped_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnJumped_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnJumped_FunctionAddress, argsSize: OnJumped_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.Character:LaunchCharacter")]
	public unsafe void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
	{
		CheckDestroyed();
		if (!LaunchCharacter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:LaunchCharacter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LaunchCharacter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LaunchCharacter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LaunchCharacter_LaunchVelocity_Offset), 0, LaunchCharacter_LaunchVelocity_PropertyAddress.Address, LaunchVelocity);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LaunchCharacter_bXYOverride_Offset), 0, LaunchCharacter_bXYOverride_PropertyAddress.Address, bXYOverride);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LaunchCharacter_bZOverride_Offset), 0, LaunchCharacter_bZOverride_PropertyAddress.Address, bZOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, LaunchCharacter_FunctionAddress, intPtr, LaunchCharacter_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_UpdateCustomMovement")]
	[UMetaPath("/Script/Engine.Character:K2_UpdateCustomMovement")]
	public unsafe void UpdateCustomMovement(float DeltaTime)
	{
		CheckDestroyed();
		if (!UpdateCustomMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_UpdateCustomMovement");
			return;
		}
		if (UpdateCustomMovement_InstanceFunctionAddress == IntPtr.Zero)
		{
			UpdateCustomMovement_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_UpdateCustomMovement");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateCustomMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateCustomMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateCustomMovement_DeltaTime_Offset), 0, UpdateCustomMovement_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateCustomMovement_InstanceFunctionAddress, intPtr, UpdateCustomMovement_ParamsSize);
	}

	protected unsafe virtual void UpdateCustomMovement_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!UpdateCustomMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_UpdateCustomMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateCustomMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateCustomMovement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, UpdateCustomMovement_DeltaTime_Offset), 0, UpdateCustomMovement_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateCustomMovement_FunctionAddress, intPtr, UpdateCustomMovement_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnStartCrouch")]
	[UMetaPath("/Script/Engine.Character:K2_OnStartCrouch")]
	public unsafe void OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		CheckDestroyed();
		if (!OnStartCrouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_OnStartCrouch");
			return;
		}
		if (OnStartCrouch_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnStartCrouch_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnStartCrouch");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartCrouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartCrouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnStartCrouch_HalfHeightAdjust_Offset), 0, OnStartCrouch_HalfHeightAdjust_PropertyAddress.Address, HalfHeightAdjust);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnStartCrouch_ScaledHalfHeightAdjust_Offset), 0, OnStartCrouch_ScaledHalfHeightAdjust_PropertyAddress.Address, ScaledHalfHeightAdjust);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStartCrouch_InstanceFunctionAddress, intPtr, OnStartCrouch_ParamsSize);
	}

	protected unsafe virtual void OnStartCrouch_Implementation(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		CheckDestroyed();
		if (!OnStartCrouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_OnStartCrouch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnStartCrouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnStartCrouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnStartCrouch_HalfHeightAdjust_Offset), 0, OnStartCrouch_HalfHeightAdjust_PropertyAddress.Address, HalfHeightAdjust);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnStartCrouch_ScaledHalfHeightAdjust_Offset), 0, OnStartCrouch_ScaledHalfHeightAdjust_PropertyAddress.Address, ScaledHalfHeightAdjust);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnStartCrouch_FunctionAddress, intPtr, OnStartCrouch_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnMovementModeChanged")]
	[UMetaPath("/Script/Engine.Character:K2_OnMovementModeChanged")]
	public unsafe void OnMovementModeChanged(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
	{
		CheckDestroyed();
		if (!OnMovementModeChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_OnMovementModeChanged");
			return;
		}
		if (OnMovementModeChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMovementModeChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnMovementModeChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMovementModeChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMovementModeChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_PrevMovementMode_Offset), 0, OnMovementModeChanged_PrevMovementMode_PropertyAddress.Address, PrevMovementMode);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_NewMovementMode_Offset), 0, OnMovementModeChanged_NewMovementMode_PropertyAddress.Address, NewMovementMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_PrevCustomMode_Offset), 0, OnMovementModeChanged_PrevCustomMode_PropertyAddress.Address, PrevCustomMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_NewCustomMode_Offset), 0, OnMovementModeChanged_NewCustomMode_PropertyAddress.Address, NewCustomMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMovementModeChanged_InstanceFunctionAddress, intPtr, OnMovementModeChanged_ParamsSize);
	}

	protected unsafe virtual void OnMovementModeChanged_Implementation(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
	{
		CheckDestroyed();
		if (!OnMovementModeChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_OnMovementModeChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMovementModeChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMovementModeChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_PrevMovementMode_Offset), 0, OnMovementModeChanged_PrevMovementMode_PropertyAddress.Address, PrevMovementMode);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_NewMovementMode_Offset), 0, OnMovementModeChanged_NewMovementMode_PropertyAddress.Address, NewMovementMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_PrevCustomMode_Offset), 0, OnMovementModeChanged_PrevCustomMode_PropertyAddress.Address, PrevCustomMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChanged_NewCustomMode_Offset), 0, OnMovementModeChanged_NewCustomMode_PropertyAddress.Address, NewCustomMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMovementModeChanged_FunctionAddress, intPtr, OnMovementModeChanged_ParamsSize);
	}

	[UFunction(Flags = 134350848u, OriginalName = "K2_OnEndCrouch")]
	[UMetaPath("/Script/Engine.Character:K2_OnEndCrouch")]
	public unsafe void OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		CheckDestroyed();
		if (!OnEndCrouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_OnEndCrouch");
			return;
		}
		if (OnEndCrouch_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnEndCrouch_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_OnEndCrouch");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndCrouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndCrouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEndCrouch_HalfHeightAdjust_Offset), 0, OnEndCrouch_HalfHeightAdjust_PropertyAddress.Address, HalfHeightAdjust);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEndCrouch_ScaledHalfHeightAdjust_Offset), 0, OnEndCrouch_ScaledHalfHeightAdjust_PropertyAddress.Address, ScaledHalfHeightAdjust);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndCrouch_InstanceFunctionAddress, intPtr, OnEndCrouch_ParamsSize);
	}

	protected unsafe virtual void OnEndCrouch_Implementation(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
	{
		CheckDestroyed();
		if (!OnEndCrouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:K2_OnEndCrouch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnEndCrouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEndCrouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEndCrouch_HalfHeightAdjust_Offset), 0, OnEndCrouch_HalfHeightAdjust_PropertyAddress.Address, HalfHeightAdjust);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEndCrouch_ScaledHalfHeightAdjust_Offset), 0, OnEndCrouch_ScaledHalfHeightAdjust_PropertyAddress.Address, ScaledHalfHeightAdjust);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnEndCrouch_FunctionAddress, intPtr, OnEndCrouch_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Character:Jump")]
	public unsafe void Jump()
	{
		CheckDestroyed();
		if (!Jump_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:Jump");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Jump_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Jump_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Jump_FunctionAddress, argsSize: Jump_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Character:IsPlayingRootMotion")]
	public unsafe bool IsPlayingRootMotion()
	{
		CheckDestroyed();
		if (!IsPlayingRootMotion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:IsPlayingRootMotion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayingRootMotion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayingRootMotion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayingRootMotion_FunctionAddress, intPtr, IsPlayingRootMotion_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayingRootMotion_ReturnValue_Offset), 0, IsPlayingRootMotion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Character:IsPlayingNetworkedRootMotionMontage")]
	public unsafe bool IsPlayingNetworkedRootMotionMontage()
	{
		CheckDestroyed();
		if (!IsPlayingNetworkedRootMotionMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:IsPlayingNetworkedRootMotionMontage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayingNetworkedRootMotionMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayingNetworkedRootMotionMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayingNetworkedRootMotionMontage_FunctionAddress, intPtr, IsPlayingNetworkedRootMotionMontage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayingNetworkedRootMotionMontage_ReturnValue_Offset), 0, IsPlayingNetworkedRootMotionMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Character:IsJumpProvidingForce")]
	public unsafe bool IsJumpProvidingForce()
	{
		CheckDestroyed();
		if (!IsJumpProvidingForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:IsJumpProvidingForce");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsJumpProvidingForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsJumpProvidingForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsJumpProvidingForce_FunctionAddress, intPtr, IsJumpProvidingForce_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsJumpProvidingForce_ReturnValue_Offset), 0, IsJumpProvidingForce_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Character:HasAnyRootMotion")]
	public unsafe bool HasAnyRootMotion()
	{
		CheckDestroyed();
		if (!HasAnyRootMotion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:HasAnyRootMotion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAnyRootMotion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAnyRootMotion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAnyRootMotion_FunctionAddress, intPtr, HasAnyRootMotion_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAnyRootMotion_ReturnValue_Offset), 0, HasAnyRootMotion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Character:GetCurrentMontage")]
	public unsafe UAnimMontage GetCurrentMontage()
	{
		CheckDestroyed();
		if (!GetCurrentMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:GetCurrentMontage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentMontage_FunctionAddress, intPtr, GetCurrentMontage_ParamsSize);
		return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(intPtr, GetCurrentMontage_ReturnValue_Offset), 0, GetCurrentMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Character:GetBaseTranslationOffset")]
	public unsafe FVector GetBaseTranslationOffset()
	{
		CheckDestroyed();
		if (!GetBaseTranslationOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:GetBaseTranslationOffset");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBaseTranslationOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBaseTranslationOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBaseTranslationOffset_FunctionAddress, intPtr, GetBaseTranslationOffset_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBaseTranslationOffset_ReturnValue_Offset), 0, GetBaseTranslationOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u, OriginalName = "GetBaseRotationOffsetRotator")]
	[UMetaPath("/Script/Engine.Character:GetBaseRotationOffsetRotator")]
	public unsafe FRotator GetBaseRotationOffset()
	{
		CheckDestroyed();
		if (!GetBaseRotationOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:GetBaseRotationOffsetRotator");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBaseRotationOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBaseRotationOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBaseRotationOffset_FunctionAddress, intPtr, GetBaseRotationOffset_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetBaseRotationOffset_ReturnValue_Offset), 0, GetBaseRotationOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Character:GetAnimRootMotionTranslationScale")]
	public unsafe float GetAnimRootMotionTranslationScale()
	{
		CheckDestroyed();
		if (!GetAnimRootMotionTranslationScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:GetAnimRootMotionTranslationScale");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimRootMotionTranslationScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimRootMotionTranslationScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimRootMotionTranslationScale_FunctionAddress, intPtr, GetAnimRootMotionTranslationScale_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAnimRootMotionTranslationScale_ReturnValue_Offset), 0, GetAnimRootMotionTranslationScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Character:Crouch")]
	public unsafe void Crouch(bool bClientSimulation = false)
	{
		CheckDestroyed();
		if (!Crouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:Crouch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Crouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Crouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Crouch_bClientSimulation_Offset), 0, Crouch_bClientSimulation_PropertyAddress.Address, bClientSimulation);
		NativeReflection.InvokeFunctionOptimized(base.Address, Crouch_FunctionAddress, intPtr, Crouch_ParamsSize);
	}

	[UFunction(Flags = 1208486912u)]
	[UMetaPath("/Script/Engine.Character:CanJumpInternal")]
	protected unsafe bool CanJumpInternal()
	{
		CheckDestroyed();
		if (!CanJumpInternal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:CanJumpInternal");
			return false;
		}
		if (CanJumpInternal_InstanceFunctionAddress == IntPtr.Zero)
		{
			CanJumpInternal_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CanJumpInternal");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanJumpInternal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanJumpInternal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanJumpInternal_InstanceFunctionAddress, intPtr, CanJumpInternal_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanJumpInternal_ReturnValue_Offset), 0, CanJumpInternal_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CanJumpInternal_Implementation()
	{
		CheckDestroyed();
		if (!CanJumpInternal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:CanJumpInternal");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanJumpInternal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanJumpInternal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanJumpInternal_FunctionAddress, intPtr, CanJumpInternal_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanJumpInternal_ReturnValue_Offset), 0, CanJumpInternal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Character:CanJump")]
	public unsafe bool CanJump()
	{
		CheckDestroyed();
		if (!CanJump_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:CanJump");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanJump_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanJump_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanJump_FunctionAddress, intPtr, CanJump_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanJump_ReturnValue_Offset), 0, CanJump_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Character:CanCrouch")]
	public unsafe bool CanCrouch()
	{
		CheckDestroyed();
		if (!CanCrouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:CanCrouch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanCrouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanCrouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanCrouch_FunctionAddress, intPtr, CanCrouch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanCrouch_ReturnValue_Offset), 0, CanCrouch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.Character:CacheInitialMeshOffset")]
	public unsafe void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
	{
		CheckDestroyed();
		if (!CacheInitialMeshOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Character:CacheInitialMeshOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CacheInitialMeshOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CacheInitialMeshOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CacheInitialMeshOffset_MeshRelativeLocation_Offset), 0, CacheInitialMeshOffset_MeshRelativeLocation_PropertyAddress.Address, MeshRelativeLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, CacheInitialMeshOffset_MeshRelativeRotation_Offset), 0, CacheInitialMeshOffset_MeshRelativeRotation_PropertyAddress.Address, MeshRelativeRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, CacheInitialMeshOffset_FunctionAddress, intPtr, CacheInitialMeshOffset_ParamsSize);
	}

	static ACharacter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACharacter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACharacter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Character");
		Mesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		CharacterMovement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CharacterMovement");
		CharacterMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CharacterMovement", Classes.FObjectProperty);
		CapsuleComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleComponent");
		CapsuleComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleComponent", Classes.FObjectProperty);
		CrouchedEyeHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CrouchedEyeHeight");
		CrouchedEyeHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CrouchedEyeHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCrouched_PropertyAddress, intPtr, "bIsCrouched");
		IsCrouched_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCrouched");
		IsCrouched_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCrouched", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PressedJump_PropertyAddress, intPtr, "bPressedJump");
		PressedJump_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPressedJump");
		PressedJump_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPressedJump", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WasJumping_PropertyAddress, intPtr, "bWasJumping");
		WasJumping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWasJumping");
		WasJumping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWasJumping", Classes.FBoolProperty);
		JumpKeyHoldTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpKeyHoldTime");
		JumpKeyHoldTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpKeyHoldTime", Classes.FFloatProperty);
		JumpForceTimeRemaining_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpForceTimeRemaining");
		JumpForceTimeRemaining_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpForceTimeRemaining", Classes.FFloatProperty);
		ProxyJumpForceStartedTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProxyJumpForceStartedTime");
		ProxyJumpForceStartedTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProxyJumpForceStartedTime", Classes.FFloatProperty);
		JumpMaxHoldTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpMaxHoldTime");
		JumpMaxHoldTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpMaxHoldTime", Classes.FFloatProperty);
		JumpMaxCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpMaxCount");
		JumpMaxCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpMaxCount", Classes.FIntProperty);
		JumpCurrentCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpCurrentCount");
		JumpCurrentCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpCurrentCount", Classes.FIntProperty);
		JumpCurrentCountPreJump_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "JumpCurrentCountPreJump");
		JumpCurrentCountPreJump_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "JumpCurrentCountPreJump", Classes.FIntProperty);
		OnReachedJumpApex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnReachedJumpApex");
		OnReachedJumpApex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnReachedJumpApex", Classes.FMulticastDelegateProperty);
		MovementModeChangedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MovementModeChangedDelegate");
		MovementModeChangedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MovementModeChangedDelegate", Classes.FMulticastDelegateProperty);
		OnCharacterMovementUpdated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnCharacterMovementUpdated");
		OnCharacterMovementUpdated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnCharacterMovementUpdated", Classes.FMulticastDelegateProperty);
		UnCrouch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnCrouch");
		UnCrouch_ParamsSize = NativeReflection.GetFunctionParamsSize(UnCrouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnCrouch_bClientSimulation_PropertyAddress, UnCrouch_FunctionAddress, "bClientSimulation");
		UnCrouch_bClientSimulation_Offset = NativeReflectionCached.GetPropertyOffset(UnCrouch_FunctionAddress, "bClientSimulation");
		UnCrouch_bClientSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(UnCrouch_FunctionAddress, "bClientSimulation", Classes.FBoolProperty);
		UnCrouch_IsValid = UnCrouch_FunctionAddress != IntPtr.Zero && UnCrouch_bClientSimulation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:UnCrouch", UnCrouch_IsValid);
		StopJumping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopJumping");
		StopJumping_ParamsSize = NativeReflection.GetFunctionParamsSize(StopJumping_FunctionAddress);
		StopJumping_IsValid = StopJumping_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:StopJumping", StopJumping_IsValid);
		StopAnimMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAnimMontage");
		StopAnimMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAnimMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAnimMontage_AnimMontage_PropertyAddress, StopAnimMontage_FunctionAddress, "AnimMontage");
		StopAnimMontage_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(StopAnimMontage_FunctionAddress, "AnimMontage");
		StopAnimMontage_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAnimMontage_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		StopAnimMontage_IsValid = StopAnimMontage_FunctionAddress != IntPtr.Zero && StopAnimMontage_AnimMontage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:StopAnimMontage", StopAnimMontage_IsValid);
		PlayAnimMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayAnimMontage");
		PlayAnimMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayAnimMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimMontage_AnimMontage_PropertyAddress, PlayAnimMontage_FunctionAddress, "AnimMontage");
		PlayAnimMontage_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimMontage_FunctionAddress, "AnimMontage");
		PlayAnimMontage_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimMontage_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimMontage_InPlayRate_PropertyAddress, PlayAnimMontage_FunctionAddress, "InPlayRate");
		PlayAnimMontage_InPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimMontage_FunctionAddress, "InPlayRate");
		PlayAnimMontage_InPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimMontage_FunctionAddress, "InPlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimMontage_StartSectionName_PropertyAddress, PlayAnimMontage_FunctionAddress, "StartSectionName");
		PlayAnimMontage_StartSectionName_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimMontage_FunctionAddress, "StartSectionName");
		PlayAnimMontage_StartSectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimMontage_FunctionAddress, "StartSectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayAnimMontage_ReturnValue_PropertyAddress, PlayAnimMontage_FunctionAddress, "ReturnValue");
		PlayAnimMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayAnimMontage_FunctionAddress, "ReturnValue");
		PlayAnimMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayAnimMontage_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		PlayAnimMontage_IsValid = PlayAnimMontage_FunctionAddress != IntPtr.Zero && PlayAnimMontage_AnimMontage_IsValid && PlayAnimMontage_InPlayRate_IsValid && PlayAnimMontage_StartSectionName_IsValid && PlayAnimMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:PlayAnimMontage", PlayAnimMontage_IsValid);
		OnWalkingOffLedge_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWalkingOffLedge");
		OnWalkingOffLedge_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWalkingOffLedge_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWalkingOffLedge_PreviousFloorImpactNormal_PropertyAddress, OnWalkingOffLedge_FunctionAddress, "PreviousFloorImpactNormal");
		OnWalkingOffLedge_PreviousFloorImpactNormal_Offset = NativeReflectionCached.GetPropertyOffset(OnWalkingOffLedge_FunctionAddress, "PreviousFloorImpactNormal");
		OnWalkingOffLedge_PreviousFloorImpactNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWalkingOffLedge_FunctionAddress, "PreviousFloorImpactNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWalkingOffLedge_PreviousFloorContactNormal_PropertyAddress, OnWalkingOffLedge_FunctionAddress, "PreviousFloorContactNormal");
		OnWalkingOffLedge_PreviousFloorContactNormal_Offset = NativeReflectionCached.GetPropertyOffset(OnWalkingOffLedge_FunctionAddress, "PreviousFloorContactNormal");
		OnWalkingOffLedge_PreviousFloorContactNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWalkingOffLedge_FunctionAddress, "PreviousFloorContactNormal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWalkingOffLedge_PreviousLocation_PropertyAddress, OnWalkingOffLedge_FunctionAddress, "PreviousLocation");
		OnWalkingOffLedge_PreviousLocation_Offset = NativeReflectionCached.GetPropertyOffset(OnWalkingOffLedge_FunctionAddress, "PreviousLocation");
		OnWalkingOffLedge_PreviousLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWalkingOffLedge_FunctionAddress, "PreviousLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnWalkingOffLedge_TimeDelta_PropertyAddress, OnWalkingOffLedge_FunctionAddress, "TimeDelta");
		OnWalkingOffLedge_TimeDelta_Offset = NativeReflectionCached.GetPropertyOffset(OnWalkingOffLedge_FunctionAddress, "TimeDelta");
		OnWalkingOffLedge_TimeDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWalkingOffLedge_FunctionAddress, "TimeDelta", Classes.FFloatProperty);
		OnWalkingOffLedge_IsValid = OnWalkingOffLedge_FunctionAddress != IntPtr.Zero && OnWalkingOffLedge_PreviousFloorImpactNormal_IsValid && OnWalkingOffLedge_PreviousFloorContactNormal_IsValid && OnWalkingOffLedge_PreviousLocation_IsValid && OnWalkingOffLedge_TimeDelta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:OnWalkingOffLedge", OnWalkingOffLedge_IsValid);
		OnLaunched_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnLaunched");
		OnLaunched_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLaunched_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLaunched_LaunchVelocity_PropertyAddress, OnLaunched_FunctionAddress, "LaunchVelocity");
		OnLaunched_LaunchVelocity_Offset = NativeReflectionCached.GetPropertyOffset(OnLaunched_FunctionAddress, "LaunchVelocity");
		OnLaunched_LaunchVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLaunched_FunctionAddress, "LaunchVelocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnLaunched_bXYOverride_PropertyAddress, OnLaunched_FunctionAddress, "bXYOverride");
		OnLaunched_bXYOverride_Offset = NativeReflectionCached.GetPropertyOffset(OnLaunched_FunctionAddress, "bXYOverride");
		OnLaunched_bXYOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLaunched_FunctionAddress, "bXYOverride", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnLaunched_bZOverride_PropertyAddress, OnLaunched_FunctionAddress, "bZOverride");
		OnLaunched_bZOverride_Offset = NativeReflectionCached.GetPropertyOffset(OnLaunched_FunctionAddress, "bZOverride");
		OnLaunched_bZOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLaunched_FunctionAddress, "bZOverride", Classes.FBoolProperty);
		OnLaunched_IsValid = OnLaunched_FunctionAddress != IntPtr.Zero && OnLaunched_LaunchVelocity_IsValid && OnLaunched_bXYOverride_IsValid && OnLaunched_bZOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:OnLaunched", OnLaunched_IsValid);
		OnLanded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnLanded");
		OnLanded_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLanded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLanded_Hit_PropertyAddress, OnLanded_FunctionAddress, "Hit");
		OnLanded_Hit_Offset = NativeReflectionCached.GetPropertyOffset(OnLanded_FunctionAddress, "Hit");
		OnLanded_Hit_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLanded_FunctionAddress, "Hit", Classes.FStructProperty);
		OnLanded_IsValid = OnLanded_FunctionAddress != IntPtr.Zero && OnLanded_Hit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:OnLanded", OnLanded_IsValid);
		OnJumped_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnJumped");
		OnJumped_ParamsSize = NativeReflection.GetFunctionParamsSize(OnJumped_FunctionAddress);
		OnJumped_IsValid = OnJumped_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:OnJumped", OnJumped_IsValid);
		LaunchCharacter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LaunchCharacter");
		LaunchCharacter_ParamsSize = NativeReflection.GetFunctionParamsSize(LaunchCharacter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LaunchCharacter_LaunchVelocity_PropertyAddress, LaunchCharacter_FunctionAddress, "LaunchVelocity");
		LaunchCharacter_LaunchVelocity_Offset = NativeReflectionCached.GetPropertyOffset(LaunchCharacter_FunctionAddress, "LaunchVelocity");
		LaunchCharacter_LaunchVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchCharacter_FunctionAddress, "LaunchVelocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LaunchCharacter_bXYOverride_PropertyAddress, LaunchCharacter_FunctionAddress, "bXYOverride");
		LaunchCharacter_bXYOverride_Offset = NativeReflectionCached.GetPropertyOffset(LaunchCharacter_FunctionAddress, "bXYOverride");
		LaunchCharacter_bXYOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchCharacter_FunctionAddress, "bXYOverride", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LaunchCharacter_bZOverride_PropertyAddress, LaunchCharacter_FunctionAddress, "bZOverride");
		LaunchCharacter_bZOverride_Offset = NativeReflectionCached.GetPropertyOffset(LaunchCharacter_FunctionAddress, "bZOverride");
		LaunchCharacter_bZOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(LaunchCharacter_FunctionAddress, "bZOverride", Classes.FBoolProperty);
		LaunchCharacter_IsValid = LaunchCharacter_FunctionAddress != IntPtr.Zero && LaunchCharacter_LaunchVelocity_IsValid && LaunchCharacter_bXYOverride_IsValid && LaunchCharacter_bZOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:LaunchCharacter", LaunchCharacter_IsValid);
		UpdateCustomMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_UpdateCustomMovement");
		UpdateCustomMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateCustomMovement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateCustomMovement_DeltaTime_PropertyAddress, UpdateCustomMovement_FunctionAddress, "DeltaTime");
		UpdateCustomMovement_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(UpdateCustomMovement_FunctionAddress, "DeltaTime");
		UpdateCustomMovement_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateCustomMovement_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		UpdateCustomMovement_IsValid = UpdateCustomMovement_FunctionAddress != IntPtr.Zero && UpdateCustomMovement_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:K2_UpdateCustomMovement", UpdateCustomMovement_IsValid);
		OnStartCrouch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnStartCrouch");
		OnStartCrouch_ParamsSize = NativeReflection.GetFunctionParamsSize(OnStartCrouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnStartCrouch_HalfHeightAdjust_PropertyAddress, OnStartCrouch_FunctionAddress, "HalfHeightAdjust");
		OnStartCrouch_HalfHeightAdjust_Offset = NativeReflectionCached.GetPropertyOffset(OnStartCrouch_FunctionAddress, "HalfHeightAdjust");
		OnStartCrouch_HalfHeightAdjust_IsValid = NativeReflectionCached.ValidatePropertyClass(OnStartCrouch_FunctionAddress, "HalfHeightAdjust", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnStartCrouch_ScaledHalfHeightAdjust_PropertyAddress, OnStartCrouch_FunctionAddress, "ScaledHalfHeightAdjust");
		OnStartCrouch_ScaledHalfHeightAdjust_Offset = NativeReflectionCached.GetPropertyOffset(OnStartCrouch_FunctionAddress, "ScaledHalfHeightAdjust");
		OnStartCrouch_ScaledHalfHeightAdjust_IsValid = NativeReflectionCached.ValidatePropertyClass(OnStartCrouch_FunctionAddress, "ScaledHalfHeightAdjust", Classes.FFloatProperty);
		OnStartCrouch_IsValid = OnStartCrouch_FunctionAddress != IntPtr.Zero && OnStartCrouch_HalfHeightAdjust_IsValid && OnStartCrouch_ScaledHalfHeightAdjust_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:K2_OnStartCrouch", OnStartCrouch_IsValid);
		OnMovementModeChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnMovementModeChanged");
		OnMovementModeChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMovementModeChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChanged_PrevMovementMode_PropertyAddress, OnMovementModeChanged_FunctionAddress, "PrevMovementMode");
		OnMovementModeChanged_PrevMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChanged_FunctionAddress, "PrevMovementMode");
		OnMovementModeChanged_PrevMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChanged_FunctionAddress, "PrevMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChanged_NewMovementMode_PropertyAddress, OnMovementModeChanged_FunctionAddress, "NewMovementMode");
		OnMovementModeChanged_NewMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChanged_FunctionAddress, "NewMovementMode");
		OnMovementModeChanged_NewMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChanged_FunctionAddress, "NewMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChanged_PrevCustomMode_PropertyAddress, OnMovementModeChanged_FunctionAddress, "PrevCustomMode");
		OnMovementModeChanged_PrevCustomMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChanged_FunctionAddress, "PrevCustomMode");
		OnMovementModeChanged_PrevCustomMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChanged_FunctionAddress, "PrevCustomMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChanged_NewCustomMode_PropertyAddress, OnMovementModeChanged_FunctionAddress, "NewCustomMode");
		OnMovementModeChanged_NewCustomMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChanged_FunctionAddress, "NewCustomMode");
		OnMovementModeChanged_NewCustomMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChanged_FunctionAddress, "NewCustomMode", Classes.FByteProperty);
		OnMovementModeChanged_IsValid = OnMovementModeChanged_FunctionAddress != IntPtr.Zero && OnMovementModeChanged_PrevMovementMode_IsValid && OnMovementModeChanged_NewMovementMode_IsValid && OnMovementModeChanged_PrevCustomMode_IsValid && OnMovementModeChanged_NewCustomMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:K2_OnMovementModeChanged", OnMovementModeChanged_IsValid);
		OnEndCrouch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_OnEndCrouch");
		OnEndCrouch_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEndCrouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEndCrouch_HalfHeightAdjust_PropertyAddress, OnEndCrouch_FunctionAddress, "HalfHeightAdjust");
		OnEndCrouch_HalfHeightAdjust_Offset = NativeReflectionCached.GetPropertyOffset(OnEndCrouch_FunctionAddress, "HalfHeightAdjust");
		OnEndCrouch_HalfHeightAdjust_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEndCrouch_FunctionAddress, "HalfHeightAdjust", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnEndCrouch_ScaledHalfHeightAdjust_PropertyAddress, OnEndCrouch_FunctionAddress, "ScaledHalfHeightAdjust");
		OnEndCrouch_ScaledHalfHeightAdjust_Offset = NativeReflectionCached.GetPropertyOffset(OnEndCrouch_FunctionAddress, "ScaledHalfHeightAdjust");
		OnEndCrouch_ScaledHalfHeightAdjust_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEndCrouch_FunctionAddress, "ScaledHalfHeightAdjust", Classes.FFloatProperty);
		OnEndCrouch_IsValid = OnEndCrouch_FunctionAddress != IntPtr.Zero && OnEndCrouch_HalfHeightAdjust_IsValid && OnEndCrouch_ScaledHalfHeightAdjust_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:K2_OnEndCrouch", OnEndCrouch_IsValid);
		Jump_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Jump");
		Jump_ParamsSize = NativeReflection.GetFunctionParamsSize(Jump_FunctionAddress);
		Jump_IsValid = Jump_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:Jump", Jump_IsValid);
		IsPlayingRootMotion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayingRootMotion");
		IsPlayingRootMotion_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayingRootMotion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayingRootMotion_ReturnValue_PropertyAddress, IsPlayingRootMotion_FunctionAddress, "ReturnValue");
		IsPlayingRootMotion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayingRootMotion_FunctionAddress, "ReturnValue");
		IsPlayingRootMotion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayingRootMotion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayingRootMotion_IsValid = IsPlayingRootMotion_FunctionAddress != IntPtr.Zero && IsPlayingRootMotion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:IsPlayingRootMotion", IsPlayingRootMotion_IsValid);
		IsPlayingNetworkedRootMotionMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayingNetworkedRootMotionMontage");
		IsPlayingNetworkedRootMotionMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayingNetworkedRootMotionMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayingNetworkedRootMotionMontage_ReturnValue_PropertyAddress, IsPlayingNetworkedRootMotionMontage_FunctionAddress, "ReturnValue");
		IsPlayingNetworkedRootMotionMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayingNetworkedRootMotionMontage_FunctionAddress, "ReturnValue");
		IsPlayingNetworkedRootMotionMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayingNetworkedRootMotionMontage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayingNetworkedRootMotionMontage_IsValid = IsPlayingNetworkedRootMotionMontage_FunctionAddress != IntPtr.Zero && IsPlayingNetworkedRootMotionMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:IsPlayingNetworkedRootMotionMontage", IsPlayingNetworkedRootMotionMontage_IsValid);
		IsJumpProvidingForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsJumpProvidingForce");
		IsJumpProvidingForce_ParamsSize = NativeReflection.GetFunctionParamsSize(IsJumpProvidingForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsJumpProvidingForce_ReturnValue_PropertyAddress, IsJumpProvidingForce_FunctionAddress, "ReturnValue");
		IsJumpProvidingForce_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsJumpProvidingForce_FunctionAddress, "ReturnValue");
		IsJumpProvidingForce_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsJumpProvidingForce_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsJumpProvidingForce_IsValid = IsJumpProvidingForce_FunctionAddress != IntPtr.Zero && IsJumpProvidingForce_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:IsJumpProvidingForce", IsJumpProvidingForce_IsValid);
		HasAnyRootMotion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasAnyRootMotion");
		HasAnyRootMotion_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAnyRootMotion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAnyRootMotion_ReturnValue_PropertyAddress, HasAnyRootMotion_FunctionAddress, "ReturnValue");
		HasAnyRootMotion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyRootMotion_FunctionAddress, "ReturnValue");
		HasAnyRootMotion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyRootMotion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAnyRootMotion_IsValid = HasAnyRootMotion_FunctionAddress != IntPtr.Zero && HasAnyRootMotion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:HasAnyRootMotion", HasAnyRootMotion_IsValid);
		GetCurrentMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentMontage");
		GetCurrentMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentMontage_ReturnValue_PropertyAddress, GetCurrentMontage_FunctionAddress, "ReturnValue");
		GetCurrentMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentMontage_FunctionAddress, "ReturnValue");
		GetCurrentMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentMontage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentMontage_IsValid = GetCurrentMontage_FunctionAddress != IntPtr.Zero && GetCurrentMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:GetCurrentMontage", GetCurrentMontage_IsValid);
		GetBaseTranslationOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBaseTranslationOffset");
		GetBaseTranslationOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBaseTranslationOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBaseTranslationOffset_ReturnValue_PropertyAddress, GetBaseTranslationOffset_FunctionAddress, "ReturnValue");
		GetBaseTranslationOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBaseTranslationOffset_FunctionAddress, "ReturnValue");
		GetBaseTranslationOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBaseTranslationOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBaseTranslationOffset_IsValid = GetBaseTranslationOffset_FunctionAddress != IntPtr.Zero && GetBaseTranslationOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:GetBaseTranslationOffset", GetBaseTranslationOffset_IsValid);
		GetBaseRotationOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBaseRotationOffsetRotator");
		GetBaseRotationOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBaseRotationOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBaseRotationOffset_ReturnValue_PropertyAddress, GetBaseRotationOffset_FunctionAddress, "ReturnValue");
		GetBaseRotationOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBaseRotationOffset_FunctionAddress, "ReturnValue");
		GetBaseRotationOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBaseRotationOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBaseRotationOffset_IsValid = GetBaseRotationOffset_FunctionAddress != IntPtr.Zero && GetBaseRotationOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:GetBaseRotationOffsetRotator", GetBaseRotationOffset_IsValid);
		GetAnimRootMotionTranslationScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimRootMotionTranslationScale");
		GetAnimRootMotionTranslationScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimRootMotionTranslationScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimRootMotionTranslationScale_ReturnValue_PropertyAddress, GetAnimRootMotionTranslationScale_FunctionAddress, "ReturnValue");
		GetAnimRootMotionTranslationScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimRootMotionTranslationScale_FunctionAddress, "ReturnValue");
		GetAnimRootMotionTranslationScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimRootMotionTranslationScale_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAnimRootMotionTranslationScale_IsValid = GetAnimRootMotionTranslationScale_FunctionAddress != IntPtr.Zero && GetAnimRootMotionTranslationScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:GetAnimRootMotionTranslationScale", GetAnimRootMotionTranslationScale_IsValid);
		Crouch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Crouch");
		Crouch_ParamsSize = NativeReflection.GetFunctionParamsSize(Crouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Crouch_bClientSimulation_PropertyAddress, Crouch_FunctionAddress, "bClientSimulation");
		Crouch_bClientSimulation_Offset = NativeReflectionCached.GetPropertyOffset(Crouch_FunctionAddress, "bClientSimulation");
		Crouch_bClientSimulation_IsValid = NativeReflectionCached.ValidatePropertyClass(Crouch_FunctionAddress, "bClientSimulation", Classes.FBoolProperty);
		Crouch_IsValid = Crouch_FunctionAddress != IntPtr.Zero && Crouch_bClientSimulation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:Crouch", Crouch_IsValid);
		CanJumpInternal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanJumpInternal");
		CanJumpInternal_ParamsSize = NativeReflection.GetFunctionParamsSize(CanJumpInternal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanJumpInternal_ReturnValue_PropertyAddress, CanJumpInternal_FunctionAddress, "ReturnValue");
		CanJumpInternal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanJumpInternal_FunctionAddress, "ReturnValue");
		CanJumpInternal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanJumpInternal_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanJumpInternal_IsValid = CanJumpInternal_FunctionAddress != IntPtr.Zero && CanJumpInternal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:CanJumpInternal", CanJumpInternal_IsValid);
		CanJump_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanJump");
		CanJump_ParamsSize = NativeReflection.GetFunctionParamsSize(CanJump_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanJump_ReturnValue_PropertyAddress, CanJump_FunctionAddress, "ReturnValue");
		CanJump_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanJump_FunctionAddress, "ReturnValue");
		CanJump_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanJump_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanJump_IsValid = CanJump_FunctionAddress != IntPtr.Zero && CanJump_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:CanJump", CanJump_IsValid);
		CanCrouch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanCrouch");
		CanCrouch_ParamsSize = NativeReflection.GetFunctionParamsSize(CanCrouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanCrouch_ReturnValue_PropertyAddress, CanCrouch_FunctionAddress, "ReturnValue");
		CanCrouch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanCrouch_FunctionAddress, "ReturnValue");
		CanCrouch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanCrouch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanCrouch_IsValid = CanCrouch_FunctionAddress != IntPtr.Zero && CanCrouch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:CanCrouch", CanCrouch_IsValid);
		CacheInitialMeshOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CacheInitialMeshOffset");
		CacheInitialMeshOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(CacheInitialMeshOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CacheInitialMeshOffset_MeshRelativeLocation_PropertyAddress, CacheInitialMeshOffset_FunctionAddress, "MeshRelativeLocation");
		CacheInitialMeshOffset_MeshRelativeLocation_Offset = NativeReflectionCached.GetPropertyOffset(CacheInitialMeshOffset_FunctionAddress, "MeshRelativeLocation");
		CacheInitialMeshOffset_MeshRelativeLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(CacheInitialMeshOffset_FunctionAddress, "MeshRelativeLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CacheInitialMeshOffset_MeshRelativeRotation_PropertyAddress, CacheInitialMeshOffset_FunctionAddress, "MeshRelativeRotation");
		CacheInitialMeshOffset_MeshRelativeRotation_Offset = NativeReflectionCached.GetPropertyOffset(CacheInitialMeshOffset_FunctionAddress, "MeshRelativeRotation");
		CacheInitialMeshOffset_MeshRelativeRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(CacheInitialMeshOffset_FunctionAddress, "MeshRelativeRotation", Classes.FStructProperty);
		CacheInitialMeshOffset_IsValid = CacheInitialMeshOffset_FunctionAddress != IntPtr.Zero && CacheInitialMeshOffset_MeshRelativeLocation_IsValid && CacheInitialMeshOffset_MeshRelativeRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Character:CacheInitialMeshOffset", CacheInitialMeshOffset_IsValid);
	}
}
