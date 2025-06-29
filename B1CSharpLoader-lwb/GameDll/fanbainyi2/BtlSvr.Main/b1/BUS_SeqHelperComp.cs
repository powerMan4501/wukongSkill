using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp")]
public class BUS_SeqHelperComp : UBaseActorComp
{
	private BGUCharacterCS OwnerCharacter;

	private static bool CameraRotation_IsValid;

	private static int CameraRotation_Offset;

	private static bool MoveToTargetTransform_IsValid;

	private static int MoveToTargetTransform_Offset;

	private static bool EnableAI_IsValid;

	private static IntPtr EnableAI_FunctionAddress;

	private static int EnableAI_ParamsSize;

	private static bool DisableAI_IsValid;

	private static IntPtr DisableAI_FunctionAddress;

	private static int DisableAI_ParamsSize;

	private static bool PerformJump_IsValid;

	private static IntPtr PerformJump_FunctionAddress;

	private static int PerformJump_ParamsSize;

	private static bool PerformJump_JumpMontage_IsValid;

	private static int PerformJump_JumpMontage_Offset;

	private static bool PerformJump_JumpForce_IsValid;

	private static int PerformJump_JumpForce_Offset;

	private static bool PerformPatrol_IsValid;

	private static IntPtr PerformPatrol_FunctionAddress;

	private static int PerformPatrol_ParamsSize;

	private static bool NotifyUnitDead_IsValid;

	private static IntPtr NotifyUnitDead_FunctionAddress;

	private static int NotifyUnitDead_ParamsSize;

	private static bool UpdateSimpleStates_IsValid;

	private static IntPtr UpdateSimpleStates_FunctionAddress;

	private static int UpdateSimpleStates_ParamsSize;

	private static bool UpdateSimpleStates_SimpleState_IsValid;

	private static int UpdateSimpleStates_SimpleState_Offset;

	private static FFieldAddress UpdateSimpleStates_SimpleState_PropertyAddress;

	private static bool UpdateSimpleStates_IsRemoving_IsValid;

	private static int UpdateSimpleStates_IsRemoving_Offset;

	private static FFieldAddress UpdateSimpleStates_IsRemoving_PropertyAddress;

	private static bool PerformMoveToPlayer_IsValid;

	private static IntPtr PerformMoveToPlayer_FunctionAddress;

	private static int PerformMoveToPlayer_ParamsSize;

	private static bool PerformMoveToPlayer_SpeedRateType_IsValid;

	private static int PerformMoveToPlayer_SpeedRateType_Offset;

	private static FFieldAddress PerformMoveToPlayer_SpeedRateType_PropertyAddress;

	private static bool PerformMoveToPlayer_AcceptableRadius_IsValid;

	private static int PerformMoveToPlayer_AcceptableRadius_Offset;

	private static bool PerformMoveToPlayer_MoveAIType_IsValid;

	private static int PerformMoveToPlayer_MoveAIType_Offset;

	private static FFieldAddress PerformMoveToPlayer_MoveAIType_PropertyAddress;

	private static bool PerformMoveToPlayer_IncludeSelfRadius_IsValid;

	private static int PerformMoveToPlayer_IncludeSelfRadius_Offset;

	private static FFieldAddress PerformMoveToPlayer_IncludeSelfRadius_PropertyAddress;

	private static bool PerformMoveToPlayer_IncludeTargetRadius_IsValid;

	private static int PerformMoveToPlayer_IncludeTargetRadius_Offset;

	private static FFieldAddress PerformMoveToPlayer_IncludeTargetRadius_PropertyAddress;

	private static bool PerformPerceivePlayer_IsValid;

	private static IntPtr PerformPerceivePlayer_FunctionAddress;

	private static int PerformPerceivePlayer_ParamsSize;

	private static bool PerformMoveToLocation_IsValid;

	private static IntPtr PerformMoveToLocation_FunctionAddress;

	private static int PerformMoveToLocation_ParamsSize;

	private static bool PerformMoveToLocation_Position_IsValid;

	private static int PerformMoveToLocation_Position_Offset;

	private static FFieldAddress PerformMoveToLocation_Position_PropertyAddress;

	private static bool PerformMoveToLocation_SpeedRateType_IsValid;

	private static int PerformMoveToLocation_SpeedRateType_Offset;

	private static FFieldAddress PerformMoveToLocation_SpeedRateType_PropertyAddress;

	private static bool PerformMoveToLocation_AcceptableRadius_IsValid;

	private static int PerformMoveToLocation_AcceptableRadius_Offset;

	private static bool PerformMoveToLocation_MoveAIType_IsValid;

	private static int PerformMoveToLocation_MoveAIType_Offset;

	private static FFieldAddress PerformMoveToLocation_MoveAIType_PropertyAddress;

	private static bool PerformMoveToLocation_IncludeSelfRadius_IsValid;

	private static int PerformMoveToLocation_IncludeSelfRadius_Offset;

	private static FFieldAddress PerformMoveToLocation_IncludeSelfRadius_PropertyAddress;

	private static bool PerformMoveToLocation_IncludeTargetRadius_IsValid;

	private static int PerformMoveToLocation_IncludeTargetRadius_Offset;

	private static FFieldAddress PerformMoveToLocation_IncludeTargetRadius_PropertyAddress;

	private static bool SetMoveToTargetTransform_IsValid;

	private static IntPtr SetMoveToTargetTransform_FunctionAddress;

	private static int SetMoveToTargetTransform_ParamsSize;

	private static bool SetMoveToTargetTransform_Transform_IsValid;

	private static int SetMoveToTargetTransform_Transform_Offset;

	private static FFieldAddress SetMoveToTargetTransform_Transform_PropertyAddress;

	private static bool OverrideAIPerceptionSetting_IsValid;

	private static IntPtr OverrideAIPerceptionSetting_FunctionAddress;

	private static int OverrideAIPerceptionSetting_ParamsSize;

	private static bool OverrideAIPerceptionSetting_InEnableVisualize_IsValid;

	private static int OverrideAIPerceptionSetting_InEnableVisualize_Offset;

	private static FFieldAddress OverrideAIPerceptionSetting_InEnableVisualize_PropertyAddress;

	private static bool OverrideAIPerceptionSetting_InSightRange_IsValid;

	private static int OverrideAIPerceptionSetting_InSightRange_Offset;

	private static bool OverrideAIPerceptionSetting_InVisionAngleDegrees_IsValid;

	private static int OverrideAIPerceptionSetting_InVisionAngleDegrees_Offset;

	private static bool OverrideAIPerceptionSetting_InHearRange_IsValid;

	private static int OverrideAIPerceptionSetting_InHearRange_Offset;

	private static bool OverrideAIPerceptionSetting_InPursuitRange_IsValid;

	private static int OverrideAIPerceptionSetting_InPursuitRange_Offset;

	private static bool SetCharacterCollisionProfile_IsValid;

	private static IntPtr SetCharacterCollisionProfile_FunctionAddress;

	private static int SetCharacterCollisionProfile_ParamsSize;

	private static bool SetCharacterCollisionProfile_CollisionProfileName_IsValid;

	private static int SetCharacterCollisionProfile_CollisionProfileName_Offset;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[EditAnywhere]
	[UProperty(Flags = PropFlags.Interp)]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:CameraRotation")]
	private FTransform CameraRotation
	{
		get
		{
			CheckDestroyed();
			if (!CameraRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqHelperComp:CameraRotation");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, CameraRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqHelperComp:CameraRotation");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, CameraRotation_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty(Flags = PropFlags.Interp)]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:MoveToTargetTransform")]
	private FTransform MoveToTargetTransform
	{
		get
		{
			CheckDestroyed();
			if (!MoveToTargetTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqHelperComp:MoveToTargetTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, MoveToTargetTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveToTargetTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqHelperComp:MoveToTargetTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, MoveToTargetTransform_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		OwnerCharacter = GetOwner() as BGUCharacterCS;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:DisableAI")]
	public void DisableAI()
	{
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_AIPerceptionSetting.Invoke(P1: false);
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_AIPauseBT.Invoke(P1: true);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:EnableAI")]
	public void EnableAI()
	{
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_AIPerceptionSetting.Invoke(P1: true);
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_AIPauseBT.Invoke(P1: false);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:PerformPatrol")]
	public void PerformPatrol()
	{
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_StartPatrolAndLeisure.Invoke();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:OverrideAIPerceptionSetting")]
	public void OverrideAIPerceptionSetting(bool InEnableVisualize, float InSightRange, float InVisionAngleDegrees, float InHearRange, float InPursuitRange)
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:PerformJump")]
	public void PerformJump(UAnimMontage JumpMontage, float JumpForce)
	{
		USkeletalMeshComponent mesh = OwnerCharacter.Mesh;
		if (!(mesh == null) && !(mesh.GetAnimInstance() == null))
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(OwnerCharacter, JumpMontage, FName.None);
			UCharacterMovementComponent uCharacterMovementComponent = OwnerCharacter.GetMovementComponent() as UCharacterMovementComponent;
			uCharacterMovementComponent.AddImpulse(GetOwner().GetActorForwardVector() * JumpForce * uCharacterMovementComponent.Mass, bVelocityChange: true);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:PerformMoveToLocation")]
	public void PerformMoveToLocation(FVector Position, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		BGUFuncLibAICS.BGURequestAIMoveToLocation(OwnerCharacter, Position, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:PerformMoveToPlayer")]
	public void PerformMoveToPlayer(EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius)
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn();
		if (!controlledPawn.IsNullOrDestroyed())
		{
			BGUFuncLibAICS.BGURequestAIMoveToTarget(OwnerCharacter, controlledPawn, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:PerformPerceivePlayer")]
	public void PerformPerceivePlayer()
	{
		EnableAI();
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn();
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_AICatchTarget.Invoke(controlledPawn, ETargetSourceType.Target_SeqAssignTarget, SkipWakeUp: true);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:UpdateSimpleStates")]
	public void UpdateSimpleStates(EBGUSimpleState SimpleState, bool IsRemoving)
	{
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_UnitSetSimpleState.Invoke(SimpleState, IsRemoving);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:NotifyUnitDead")]
	public void NotifyUnitDead()
	{
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_UnitDead.Invoke(null, EDeadReason.None);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:SetCharacterCollisionProfile")]
	public void SetCharacterCollisionProfile(FName CollisionProfileName)
	{
		UCapsuleComponent componentByClass = GetOwner().GetComponentByClass<UCapsuleComponent>();
		if (!componentByClass.IsNullOrDestroyed())
		{
			componentByClass.SetCollisionProfileName(CollisionProfileName);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperComp:SetMoveToTargetTransform")]
	public void SetMoveToTargetTransform(FTransform Transform)
	{
		BGUFuncLibAICS.BGURequestAIMoveToLocation(GetOwner() as ACharacter, Transform.GetLocation(), EAIMoveSpeedType.JOG, 10f, EBGUMoveAIType.None, IncludeSelfRadius: false, IncludeTargetRadius: false);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:EnableAI")]
	private static void EnableAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		bUS_SeqHelperComp.EnableAI();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:DisableAI")]
	private static void DisableAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		bUS_SeqHelperComp.DisableAI();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:PerformJump")]
	private static void PerformJump__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		UAnimMontage jumpMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, PerformJump_JumpMontage_Offset));
		float jumpForce = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, PerformJump_JumpForce_Offset));
		bUS_SeqHelperComp.PerformJump(jumpMontage, jumpForce);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:PerformPatrol")]
	private static void PerformPatrol__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		bUS_SeqHelperComp.PerformPatrol();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:NotifyUnitDead")]
	private static void NotifyUnitDead__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		bUS_SeqHelperComp.NotifyUnitDead();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:UpdateSimpleStates")]
	private static void UpdateSimpleStates__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		EBGUSimpleState simpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(buffer, UpdateSimpleStates_SimpleState_Offset), 0, UpdateSimpleStates_SimpleState_PropertyAddress.Address);
		bool isRemoving = BoolMarshaler.FromNative(IntPtr.Add(buffer, UpdateSimpleStates_IsRemoving_Offset), 0, UpdateSimpleStates_IsRemoving_PropertyAddress.Address);
		bUS_SeqHelperComp.UpdateSimpleStates(simpleState, isRemoving);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:PerformMoveToPlayer")]
	private static void PerformMoveToPlayer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		EAIMoveSpeedType speedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_SpeedRateType_Offset), 0, PerformMoveToPlayer_SpeedRateType_PropertyAddress.Address);
		float acceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_AcceptableRadius_Offset));
		EBGUMoveAIType moveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_MoveAIType_Offset), 0, PerformMoveToPlayer_MoveAIType_PropertyAddress.Address);
		bool includeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_IncludeSelfRadius_Offset), 0, PerformMoveToPlayer_IncludeSelfRadius_PropertyAddress.Address);
		bool includeTargetRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToPlayer_IncludeTargetRadius_Offset), 0, PerformMoveToPlayer_IncludeTargetRadius_PropertyAddress.Address);
		bUS_SeqHelperComp.PerformMoveToPlayer(speedRateType, acceptableRadius, moveAIType, includeSelfRadius, includeTargetRadius);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:PerformPerceivePlayer")]
	private static void PerformPerceivePlayer__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		bUS_SeqHelperComp.PerformPerceivePlayer();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:PerformMoveToLocation")]
	private static void PerformMoveToLocation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		FVector position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_Position_Offset));
		EAIMoveSpeedType speedRateType = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_SpeedRateType_Offset), 0, PerformMoveToLocation_SpeedRateType_PropertyAddress.Address);
		float acceptableRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_AcceptableRadius_Offset));
		EBGUMoveAIType moveAIType = EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_MoveAIType_Offset), 0, PerformMoveToLocation_MoveAIType_PropertyAddress.Address);
		bool includeSelfRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_IncludeSelfRadius_Offset), 0, PerformMoveToLocation_IncludeSelfRadius_PropertyAddress.Address);
		bool includeTargetRadius = BoolMarshaler.FromNative(IntPtr.Add(buffer, PerformMoveToLocation_IncludeTargetRadius_Offset), 0, PerformMoveToLocation_IncludeTargetRadius_PropertyAddress.Address);
		bUS_SeqHelperComp.PerformMoveToLocation(position, speedRateType, acceptableRadius, moveAIType, includeSelfRadius, includeTargetRadius);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:SetMoveToTargetTransform")]
	private static void SetMoveToTargetTransform__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		FTransform moveToTargetTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, SetMoveToTargetTransform_Transform_Offset));
		bUS_SeqHelperComp.SetMoveToTargetTransform(moveToTargetTransform);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:OverrideAIPerceptionSetting")]
	private static void OverrideAIPerceptionSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		bool inEnableVisualize = BoolMarshaler.FromNative(IntPtr.Add(buffer, OverrideAIPerceptionSetting_InEnableVisualize_Offset), 0, OverrideAIPerceptionSetting_InEnableVisualize_PropertyAddress.Address);
		float inSightRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideAIPerceptionSetting_InSightRange_Offset));
		float inVisionAngleDegrees = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideAIPerceptionSetting_InVisionAngleDegrees_Offset));
		float inHearRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideAIPerceptionSetting_InHearRange_Offset));
		float inPursuitRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideAIPerceptionSetting_InPursuitRange_Offset));
		bUS_SeqHelperComp.OverrideAIPerceptionSetting(inEnableVisualize, inSightRange, inVisionAngleDegrees, inHearRange, inPursuitRange);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:SetCharacterCollisionProfile")]
	private static void SetCharacterCollisionProfile__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		FName characterCollisionProfile = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, SetCharacterCollisionProfile_CollisionProfileName_Offset));
		bUS_SeqHelperComp.SetCharacterCollisionProfile(characterCollisionProfile);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SeqHelperComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SeqHelperComp bUS_SeqHelperComp = GCHelper.Find<BUS_SeqHelperComp>(obj);
		bUS_SeqHelperComp.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SeqHelperComp");
		CameraRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraRotation");
		CameraRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraRotation", Classes.FStructProperty);
		MoveToTargetTransform_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveToTargetTransform");
		MoveToTargetTransform_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveToTargetTransform", Classes.FStructProperty);
		EnableAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EnableAI");
		EnableAI_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableAI_FunctionAddress);
		EnableAI_IsValid = EnableAI_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:EnableAI", EnableAI_IsValid);
		DisableAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableAI");
		DisableAI_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableAI_FunctionAddress);
		DisableAI_IsValid = DisableAI_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:DisableAI", DisableAI_IsValid);
		PerformJump_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PerformJump");
		PerformJump_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformJump_FunctionAddress);
		PerformJump_JumpMontage_Offset = NativeReflection.GetPropertyOffset(PerformJump_FunctionAddress, "JumpMontage");
		PerformJump_JumpMontage_IsValid = NativeReflection.ValidatePropertyClass(PerformJump_FunctionAddress, "JumpMontage", Classes.FObjectProperty);
		PerformJump_JumpForce_Offset = NativeReflection.GetPropertyOffset(PerformJump_FunctionAddress, "JumpForce");
		PerformJump_JumpForce_IsValid = NativeReflection.ValidatePropertyClass(PerformJump_FunctionAddress, "JumpForce", Classes.FFloatProperty);
		PerformJump_IsValid = PerformJump_FunctionAddress != IntPtr.Zero && PerformJump_JumpMontage_IsValid && PerformJump_JumpForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:PerformJump", PerformJump_IsValid);
		PerformPatrol_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PerformPatrol");
		PerformPatrol_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformPatrol_FunctionAddress);
		PerformPatrol_IsValid = PerformPatrol_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:PerformPatrol", PerformPatrol_IsValid);
		NotifyUnitDead_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NotifyUnitDead");
		NotifyUnitDead_ParamsSize = NativeReflection.GetFunctionParamsSize(NotifyUnitDead_FunctionAddress);
		NotifyUnitDead_IsValid = NotifyUnitDead_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:NotifyUnitDead", NotifyUnitDead_IsValid);
		UpdateSimpleStates_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSimpleStates");
		UpdateSimpleStates_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSimpleStates_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateSimpleStates_SimpleState_PropertyAddress, UpdateSimpleStates_FunctionAddress, "SimpleState");
		UpdateSimpleStates_SimpleState_Offset = NativeReflection.GetPropertyOffset(UpdateSimpleStates_FunctionAddress, "SimpleState");
		UpdateSimpleStates_SimpleState_IsValid = NativeReflection.ValidatePropertyClass(UpdateSimpleStates_FunctionAddress, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UpdateSimpleStates_IsRemoving_PropertyAddress, UpdateSimpleStates_FunctionAddress, "IsRemoving");
		UpdateSimpleStates_IsRemoving_Offset = NativeReflection.GetPropertyOffset(UpdateSimpleStates_FunctionAddress, "IsRemoving");
		UpdateSimpleStates_IsRemoving_IsValid = NativeReflection.ValidatePropertyClass(UpdateSimpleStates_FunctionAddress, "IsRemoving", Classes.FBoolProperty);
		UpdateSimpleStates_IsValid = UpdateSimpleStates_FunctionAddress != IntPtr.Zero && UpdateSimpleStates_SimpleState_IsValid && UpdateSimpleStates_IsRemoving_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:UpdateSimpleStates", UpdateSimpleStates_IsValid);
		PerformMoveToPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PerformMoveToPlayer");
		PerformMoveToPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformMoveToPlayer_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_SpeedRateType_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "SpeedRateType");
		PerformMoveToPlayer_SpeedRateType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "SpeedRateType");
		PerformMoveToPlayer_SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "SpeedRateType", Classes.FEnumProperty);
		PerformMoveToPlayer_AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "AcceptableRadius");
		PerformMoveToPlayer_AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_MoveAIType_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "MoveAIType");
		PerformMoveToPlayer_MoveAIType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "MoveAIType");
		PerformMoveToPlayer_MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_IncludeSelfRadius_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToPlayer_IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToPlayer_IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToPlayer_IncludeTargetRadius_PropertyAddress, PerformMoveToPlayer_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToPlayer_IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToPlayer_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToPlayer_IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToPlayer_FunctionAddress, "IncludeTargetRadius", Classes.FBoolProperty);
		PerformMoveToPlayer_IsValid = PerformMoveToPlayer_FunctionAddress != IntPtr.Zero && PerformMoveToPlayer_SpeedRateType_IsValid && PerformMoveToPlayer_AcceptableRadius_IsValid && PerformMoveToPlayer_MoveAIType_IsValid && PerformMoveToPlayer_IncludeSelfRadius_IsValid && PerformMoveToPlayer_IncludeTargetRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:PerformMoveToPlayer", PerformMoveToPlayer_IsValid);
		PerformPerceivePlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PerformPerceivePlayer");
		PerformPerceivePlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformPerceivePlayer_FunctionAddress);
		PerformPerceivePlayer_IsValid = PerformPerceivePlayer_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:PerformPerceivePlayer", PerformPerceivePlayer_IsValid);
		PerformMoveToLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PerformMoveToLocation");
		PerformMoveToLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformMoveToLocation_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_Position_PropertyAddress, PerformMoveToLocation_FunctionAddress, "Position");
		PerformMoveToLocation_Position_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "Position");
		PerformMoveToLocation_Position_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_SpeedRateType_PropertyAddress, PerformMoveToLocation_FunctionAddress, "SpeedRateType");
		PerformMoveToLocation_SpeedRateType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "SpeedRateType");
		PerformMoveToLocation_SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "SpeedRateType", Classes.FEnumProperty);
		PerformMoveToLocation_AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "AcceptableRadius");
		PerformMoveToLocation_AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_MoveAIType_PropertyAddress, PerformMoveToLocation_FunctionAddress, "MoveAIType");
		PerformMoveToLocation_MoveAIType_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "MoveAIType");
		PerformMoveToLocation_MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_IncludeSelfRadius_PropertyAddress, PerformMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToLocation_IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "IncludeSelfRadius");
		PerformMoveToLocation_IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PerformMoveToLocation_IncludeTargetRadius_PropertyAddress, PerformMoveToLocation_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToLocation_IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(PerformMoveToLocation_FunctionAddress, "IncludeTargetRadius");
		PerformMoveToLocation_IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(PerformMoveToLocation_FunctionAddress, "IncludeTargetRadius", Classes.FBoolProperty);
		PerformMoveToLocation_IsValid = PerformMoveToLocation_FunctionAddress != IntPtr.Zero && PerformMoveToLocation_Position_IsValid && PerformMoveToLocation_SpeedRateType_IsValid && PerformMoveToLocation_AcceptableRadius_IsValid && PerformMoveToLocation_MoveAIType_IsValid && PerformMoveToLocation_IncludeSelfRadius_IsValid && PerformMoveToLocation_IncludeTargetRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:PerformMoveToLocation", PerformMoveToLocation_IsValid);
		SetMoveToTargetTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMoveToTargetTransform");
		SetMoveToTargetTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMoveToTargetTransform_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetMoveToTargetTransform_Transform_PropertyAddress, SetMoveToTargetTransform_FunctionAddress, "Transform");
		SetMoveToTargetTransform_Transform_Offset = NativeReflection.GetPropertyOffset(SetMoveToTargetTransform_FunctionAddress, "Transform");
		SetMoveToTargetTransform_Transform_IsValid = NativeReflection.ValidatePropertyClass(SetMoveToTargetTransform_FunctionAddress, "Transform", Classes.FStructProperty);
		SetMoveToTargetTransform_IsValid = SetMoveToTargetTransform_FunctionAddress != IntPtr.Zero && SetMoveToTargetTransform_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:SetMoveToTargetTransform", SetMoveToTargetTransform_IsValid);
		OverrideAIPerceptionSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OverrideAIPerceptionSetting");
		OverrideAIPerceptionSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideAIPerceptionSetting_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OverrideAIPerceptionSetting_InEnableVisualize_PropertyAddress, OverrideAIPerceptionSetting_FunctionAddress, "InEnableVisualize");
		OverrideAIPerceptionSetting_InEnableVisualize_Offset = NativeReflection.GetPropertyOffset(OverrideAIPerceptionSetting_FunctionAddress, "InEnableVisualize");
		OverrideAIPerceptionSetting_InEnableVisualize_IsValid = NativeReflection.ValidatePropertyClass(OverrideAIPerceptionSetting_FunctionAddress, "InEnableVisualize", Classes.FBoolProperty);
		OverrideAIPerceptionSetting_InSightRange_Offset = NativeReflection.GetPropertyOffset(OverrideAIPerceptionSetting_FunctionAddress, "InSightRange");
		OverrideAIPerceptionSetting_InSightRange_IsValid = NativeReflection.ValidatePropertyClass(OverrideAIPerceptionSetting_FunctionAddress, "InSightRange", Classes.FFloatProperty);
		OverrideAIPerceptionSetting_InVisionAngleDegrees_Offset = NativeReflection.GetPropertyOffset(OverrideAIPerceptionSetting_FunctionAddress, "InVisionAngleDegrees");
		OverrideAIPerceptionSetting_InVisionAngleDegrees_IsValid = NativeReflection.ValidatePropertyClass(OverrideAIPerceptionSetting_FunctionAddress, "InVisionAngleDegrees", Classes.FFloatProperty);
		OverrideAIPerceptionSetting_InHearRange_Offset = NativeReflection.GetPropertyOffset(OverrideAIPerceptionSetting_FunctionAddress, "InHearRange");
		OverrideAIPerceptionSetting_InHearRange_IsValid = NativeReflection.ValidatePropertyClass(OverrideAIPerceptionSetting_FunctionAddress, "InHearRange", Classes.FFloatProperty);
		OverrideAIPerceptionSetting_InPursuitRange_Offset = NativeReflection.GetPropertyOffset(OverrideAIPerceptionSetting_FunctionAddress, "InPursuitRange");
		OverrideAIPerceptionSetting_InPursuitRange_IsValid = NativeReflection.ValidatePropertyClass(OverrideAIPerceptionSetting_FunctionAddress, "InPursuitRange", Classes.FFloatProperty);
		OverrideAIPerceptionSetting_IsValid = OverrideAIPerceptionSetting_FunctionAddress != IntPtr.Zero && OverrideAIPerceptionSetting_InEnableVisualize_IsValid && OverrideAIPerceptionSetting_InSightRange_IsValid && OverrideAIPerceptionSetting_InVisionAngleDegrees_IsValid && OverrideAIPerceptionSetting_InHearRange_IsValid && OverrideAIPerceptionSetting_InPursuitRange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:OverrideAIPerceptionSetting", OverrideAIPerceptionSetting_IsValid);
		SetCharacterCollisionProfile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCharacterCollisionProfile");
		SetCharacterCollisionProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCharacterCollisionProfile_FunctionAddress);
		SetCharacterCollisionProfile_CollisionProfileName_Offset = NativeReflection.GetPropertyOffset(SetCharacterCollisionProfile_FunctionAddress, "CollisionProfileName");
		SetCharacterCollisionProfile_CollisionProfileName_IsValid = NativeReflection.ValidatePropertyClass(SetCharacterCollisionProfile_FunctionAddress, "CollisionProfileName", Classes.FNameProperty);
		SetCharacterCollisionProfile_IsValid = SetCharacterCollisionProfile_FunctionAddress != IntPtr.Zero && SetCharacterCollisionProfile_CollisionProfileName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:SetCharacterCollisionProfile", SetCharacterCollisionProfile_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SeqHelperComp:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static BUS_SeqHelperComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SeqHelperComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SeqHelperComp));
	}
}
