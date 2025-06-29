using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.Pawn", "Engine", UnrealModuleType.Engine)]
public class APawn : AActor, INavAgentInterface, IInterface
{
	private static IntPtr classAddress;

	private static bool UseControllerRotationPitch_IsValid;

	private static FFieldAddress UseControllerRotationPitch_PropertyAddress;

	private static int UseControllerRotationPitch_Offset;

	private static bool UseControllerRotationYaw_IsValid;

	private static FFieldAddress UseControllerRotationYaw_PropertyAddress;

	private static int UseControllerRotationYaw_Offset;

	private static bool UseControllerRotationRoll_IsValid;

	private static FFieldAddress UseControllerRotationRoll_PropertyAddress;

	private static int UseControllerRotationRoll_Offset;

	private static bool CanAffectNavigationGeneration_IsValid;

	private static FFieldAddress CanAffectNavigationGeneration_PropertyAddress;

	private static int CanAffectNavigationGeneration_Offset;

	private static bool BaseEyeHeight_IsValid;

	private static int BaseEyeHeight_Offset;

	private static bool AIControllerClass_IsValid;

	private static int AIControllerClass_Offset;

	private static bool PlayerState_IsValid;

	private static int PlayerState_Offset;

	private static bool LastHitBy_IsValid;

	private static int LastHitBy_Offset;

	private static bool ReceiveControllerChangedDelegate_IsValid;

	private static int ReceiveControllerChangedDelegate_Offset;

	private FPawnControllerChangedSignature ReceiveControllerChangedDelegate_DelegateCached;

	private static bool ReceiveRestartedDelegate_IsValid;

	private static int ReceiveRestartedDelegate_Offset;

	private FPawnRestartedSignature ReceiveRestartedDelegate_DelegateCached;

	private static bool SpawnDefaultController_IsValid;

	private static IntPtr SpawnDefaultController_FunctionAddress;

	private static int SpawnDefaultController_ParamsSize;

	private static bool SetCanAffectNavigationGeneration_IsValid;

	private static IntPtr SetCanAffectNavigationGeneration_FunctionAddress;

	private static int SetCanAffectNavigationGeneration_ParamsSize;

	private static bool SetCanAffectNavigationGeneration_bNewValue_IsValid;

	private static FFieldAddress SetCanAffectNavigationGeneration_bNewValue_PropertyAddress;

	private static int SetCanAffectNavigationGeneration_bNewValue_Offset;

	private static bool SetCanAffectNavigationGeneration_bForceUpdate_IsValid;

	private static FFieldAddress SetCanAffectNavigationGeneration_bForceUpdate_PropertyAddress;

	private static int SetCanAffectNavigationGeneration_bForceUpdate_Offset;

	private static bool ReceiveUnpossessed_IsValid;

	private IntPtr ReceiveUnpossessed_InstanceFunctionAddress;

	private static IntPtr ReceiveUnpossessed_FunctionAddress;

	private static int ReceiveUnpossessed_ParamsSize;

	private static bool ReceiveUnpossessed_OldController_IsValid;

	private static FFieldAddress ReceiveUnpossessed_OldController_PropertyAddress;

	private static int ReceiveUnpossessed_OldController_Offset;

	private static bool ReceiveRestarted_IsValid;

	private IntPtr ReceiveRestarted_InstanceFunctionAddress;

	private static IntPtr ReceiveRestarted_FunctionAddress;

	private static int ReceiveRestarted_ParamsSize;

	private static bool ReceivePossessed_IsValid;

	private IntPtr ReceivePossessed_InstanceFunctionAddress;

	private static IntPtr ReceivePossessed_FunctionAddress;

	private static int ReceivePossessed_ParamsSize;

	private static bool ReceivePossessed_NewController_IsValid;

	private static FFieldAddress ReceivePossessed_NewController_PropertyAddress;

	private static int ReceivePossessed_NewController_Offset;

	private static bool ReceiveControllerChanged_IsValid;

	private IntPtr ReceiveControllerChanged_InstanceFunctionAddress;

	private static IntPtr ReceiveControllerChanged_FunctionAddress;

	private static int ReceiveControllerChanged_ParamsSize;

	private static bool ReceiveControllerChanged_OldController_IsValid;

	private static FFieldAddress ReceiveControllerChanged_OldController_PropertyAddress;

	private static int ReceiveControllerChanged_OldController_Offset;

	private static bool ReceiveControllerChanged_NewController_IsValid;

	private static FFieldAddress ReceiveControllerChanged_NewController_PropertyAddress;

	private static int ReceiveControllerChanged_NewController_Offset;

	private static bool PawnMakeNoise_IsValid;

	private static IntPtr PawnMakeNoise_FunctionAddress;

	private static int PawnMakeNoise_ParamsSize;

	private static bool PawnMakeNoise_Loudness_IsValid;

	private static FFieldAddress PawnMakeNoise_Loudness_PropertyAddress;

	private static int PawnMakeNoise_Loudness_Offset;

	private static bool PawnMakeNoise_NoiseLocation_IsValid;

	private static FFieldAddress PawnMakeNoise_NoiseLocation_PropertyAddress;

	private static int PawnMakeNoise_NoiseLocation_Offset;

	private static bool PawnMakeNoise_bUseNoiseMakerLocation_IsValid;

	private static FFieldAddress PawnMakeNoise_bUseNoiseMakerLocation_PropertyAddress;

	private static int PawnMakeNoise_bUseNoiseMakerLocation_Offset;

	private static bool PawnMakeNoise_NoiseMaker_IsValid;

	private static FFieldAddress PawnMakeNoise_NoiseMaker_PropertyAddress;

	private static int PawnMakeNoise_NoiseMaker_Offset;

	private static bool IsPlayerControlled_IsValid;

	private static IntPtr IsPlayerControlled_FunctionAddress;

	private static int IsPlayerControlled_ParamsSize;

	private static bool IsPlayerControlled_ReturnValue_IsValid;

	private static FFieldAddress IsPlayerControlled_ReturnValue_PropertyAddress;

	private static int IsPlayerControlled_ReturnValue_Offset;

	private static bool IsPawnControlled_IsValid;

	private static IntPtr IsPawnControlled_FunctionAddress;

	private static int IsPawnControlled_ParamsSize;

	private static bool IsPawnControlled_ReturnValue_IsValid;

	private static FFieldAddress IsPawnControlled_ReturnValue_PropertyAddress;

	private static int IsPawnControlled_ReturnValue_Offset;

	private static bool IsMoveInputIgnored_IsValid;

	private static IntPtr IsMoveInputIgnored_FunctionAddress;

	private static int IsMoveInputIgnored_ParamsSize;

	private static bool IsMoveInputIgnored_ReturnValue_IsValid;

	private static FFieldAddress IsMoveInputIgnored_ReturnValue_PropertyAddress;

	private static int IsMoveInputIgnored_ReturnValue_Offset;

	private static bool IsLocallyViewed_IsValid;

	private static IntPtr IsLocallyViewed_FunctionAddress;

	private static int IsLocallyViewed_ParamsSize;

	private static bool IsLocallyViewed_ReturnValue_IsValid;

	private static FFieldAddress IsLocallyViewed_ReturnValue_PropertyAddress;

	private static int IsLocallyViewed_ReturnValue_Offset;

	private static bool IsLocallyControlled_IsValid;

	private static IntPtr IsLocallyControlled_FunctionAddress;

	private static int IsLocallyControlled_ParamsSize;

	private static bool IsLocallyControlled_ReturnValue_IsValid;

	private static FFieldAddress IsLocallyControlled_ReturnValue_PropertyAddress;

	private static int IsLocallyControlled_ReturnValue_Offset;

	private static bool IsControlled_IsValid;

	private static IntPtr IsControlled_FunctionAddress;

	private static int IsControlled_ParamsSize;

	private static bool IsControlled_ReturnValue_IsValid;

	private static FFieldAddress IsControlled_ReturnValue_PropertyAddress;

	private static int IsControlled_ReturnValue_Offset;

	private static bool IsBotControlled_IsValid;

	private static IntPtr IsBotControlled_FunctionAddress;

	private static int IsBotControlled_ParamsSize;

	private static bool IsBotControlled_ReturnValue_IsValid;

	private static FFieldAddress IsBotControlled_ReturnValue_PropertyAddress;

	private static int IsBotControlled_ReturnValue_Offset;

	private static bool GetPendingMovementInputVector_IsValid;

	private static IntPtr GetPendingMovementInputVector_FunctionAddress;

	private static int GetPendingMovementInputVector_ParamsSize;

	private static bool GetPendingMovementInputVector_ReturnValue_IsValid;

	private static FFieldAddress GetPendingMovementInputVector_ReturnValue_PropertyAddress;

	private static int GetPendingMovementInputVector_ReturnValue_Offset;

	private static bool GetNavAgentLocation_IsValid;

	private static IntPtr GetNavAgentLocation_FunctionAddress;

	private static int GetNavAgentLocation_ParamsSize;

	private static bool GetNavAgentLocation_ReturnValue_IsValid;

	private static FFieldAddress GetNavAgentLocation_ReturnValue_PropertyAddress;

	private static int GetNavAgentLocation_ReturnValue_Offset;

	private static bool GetMovementComponent_IsValid;

	private static IntPtr GetMovementComponent_FunctionAddress;

	private static int GetMovementComponent_ParamsSize;

	private static bool GetMovementComponent_ReturnValue_IsValid;

	private static FFieldAddress GetMovementComponent_ReturnValue_PropertyAddress;

	private static int GetMovementComponent_ReturnValue_Offset;

	private static bool GetMovementBaseActor_IsValid;

	private static IntPtr GetMovementBaseActor_FunctionAddress;

	private static int GetMovementBaseActor_ParamsSize;

	private static bool GetMovementBaseActor_Pawn_IsValid;

	private static FFieldAddress GetMovementBaseActor_Pawn_PropertyAddress;

	private static int GetMovementBaseActor_Pawn_Offset;

	private static bool GetMovementBaseActor_ReturnValue_IsValid;

	private static FFieldAddress GetMovementBaseActor_ReturnValue_PropertyAddress;

	private static int GetMovementBaseActor_ReturnValue_Offset;

	private static bool GetLocalViewingPlayerController_IsValid;

	private static IntPtr GetLocalViewingPlayerController_FunctionAddress;

	private static int GetLocalViewingPlayerController_ParamsSize;

	private static bool GetLocalViewingPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetLocalViewingPlayerController_ReturnValue_PropertyAddress;

	private static int GetLocalViewingPlayerController_ReturnValue_Offset;

	private static bool GetLastMovementInputVector_IsValid;

	private static IntPtr GetLastMovementInputVector_FunctionAddress;

	private static int GetLastMovementInputVector_ParamsSize;

	private static bool GetLastMovementInputVector_ReturnValue_IsValid;

	private static FFieldAddress GetLastMovementInputVector_ReturnValue_PropertyAddress;

	private static int GetLastMovementInputVector_ReturnValue_Offset;

	private static bool GetControlRotation_IsValid;

	private static IntPtr GetControlRotation_FunctionAddress;

	private static int GetControlRotation_ParamsSize;

	private static bool GetControlRotation_ReturnValue_IsValid;

	private static FFieldAddress GetControlRotation_ReturnValue_PropertyAddress;

	private static int GetControlRotation_ReturnValue_Offset;

	private static bool GetController_IsValid;

	private static IntPtr GetController_FunctionAddress;

	private static int GetController_ParamsSize;

	private static bool GetController_ReturnValue_IsValid;

	private static FFieldAddress GetController_ReturnValue_PropertyAddress;

	private static int GetController_ReturnValue_Offset;

	private static bool GetBaseAimRotation_IsValid;

	private static IntPtr GetBaseAimRotation_FunctionAddress;

	private static int GetBaseAimRotation_ParamsSize;

	private static bool GetBaseAimRotation_ReturnValue_IsValid;

	private static FFieldAddress GetBaseAimRotation_ReturnValue_PropertyAddress;

	private static int GetBaseAimRotation_ReturnValue_Offset;

	private static bool DetachFromControllerPendingDestroy_IsValid;

	private static IntPtr DetachFromControllerPendingDestroy_FunctionAddress;

	private static int DetachFromControllerPendingDestroy_ParamsSize;

	private static bool ConsumeMovementInputVector_IsValid;

	private static IntPtr ConsumeMovementInputVector_FunctionAddress;

	private static int ConsumeMovementInputVector_ParamsSize;

	private static bool ConsumeMovementInputVector_ReturnValue_IsValid;

	private static FFieldAddress ConsumeMovementInputVector_ReturnValue_PropertyAddress;

	private static int ConsumeMovementInputVector_ReturnValue_Offset;

	private static bool AddMovementInput_IsValid;

	private static IntPtr AddMovementInput_FunctionAddress;

	private static int AddMovementInput_ParamsSize;

	private static bool AddMovementInput_WorldDirection_IsValid;

	private static FFieldAddress AddMovementInput_WorldDirection_PropertyAddress;

	private static int AddMovementInput_WorldDirection_Offset;

	private static bool AddMovementInput_ScaleValue_IsValid;

	private static FFieldAddress AddMovementInput_ScaleValue_PropertyAddress;

	private static int AddMovementInput_ScaleValue_Offset;

	private static bool AddMovementInput_bForce_IsValid;

	private static FFieldAddress AddMovementInput_bForce_PropertyAddress;

	private static int AddMovementInput_bForce_Offset;

	private static bool AddControllerYawInput_IsValid;

	private static IntPtr AddControllerYawInput_FunctionAddress;

	private static int AddControllerYawInput_ParamsSize;

	private static bool AddControllerYawInput_Val_IsValid;

	private static FFieldAddress AddControllerYawInput_Val_PropertyAddress;

	private static int AddControllerYawInput_Val_Offset;

	private static bool AddControllerRollInput_IsValid;

	private static IntPtr AddControllerRollInput_FunctionAddress;

	private static int AddControllerRollInput_ParamsSize;

	private static bool AddControllerRollInput_Val_IsValid;

	private static FFieldAddress AddControllerRollInput_Val_PropertyAddress;

	private static int AddControllerRollInput_Val_Offset;

	private static bool AddControllerPitchInput_IsValid;

	private static IntPtr AddControllerPitchInput_FunctionAddress;

	private static int AddControllerPitchInput_ParamsSize;

	private static bool AddControllerPitchInput_Val_IsValid;

	private static FFieldAddress AddControllerPitchInput_Val_PropertyAddress;

	private static int AddControllerPitchInput_Val_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Pawn:bUseControllerRotationPitch")]
	public bool UseControllerRotationPitch
	{
		get
		{
			CheckDestroyed();
			if (!UseControllerRotationPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bUseControllerRotationPitch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseControllerRotationPitch_Offset), 0, UseControllerRotationPitch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseControllerRotationPitch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bUseControllerRotationPitch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseControllerRotationPitch_Offset), 0, UseControllerRotationPitch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Pawn:bUseControllerRotationYaw")]
	public bool UseControllerRotationYaw
	{
		get
		{
			CheckDestroyed();
			if (!UseControllerRotationYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bUseControllerRotationYaw");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseControllerRotationYaw_Offset), 0, UseControllerRotationYaw_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseControllerRotationYaw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bUseControllerRotationYaw");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseControllerRotationYaw_Offset), 0, UseControllerRotationYaw_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Pawn:bUseControllerRotationRoll")]
	public bool UseControllerRotationRoll
	{
		get
		{
			CheckDestroyed();
			if (!UseControllerRotationRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bUseControllerRotationRoll");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseControllerRotationRoll_Offset), 0, UseControllerRotationRoll_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseControllerRotationRoll_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bUseControllerRotationRoll");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseControllerRotationRoll_Offset), 0, UseControllerRotationRoll_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.Pawn:bCanAffectNavigationGeneration")]
	public bool CanAffectNavigationGeneration
	{
		get
		{
			CheckDestroyed();
			if (!CanAffectNavigationGeneration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bCanAffectNavigationGeneration");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanAffectNavigationGeneration_Offset), 0, CanAffectNavigationGeneration_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanAffectNavigationGeneration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:bCanAffectNavigationGeneration");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanAffectNavigationGeneration_Offset), 0, CanAffectNavigationGeneration_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.Pawn:BaseEyeHeight")]
	public float BaseEyeHeight
	{
		get
		{
			CheckDestroyed();
			if (!BaseEyeHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:BaseEyeHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BaseEyeHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseEyeHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:BaseEyeHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BaseEyeHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.Pawn:AIControllerClass")]
	public TSubclassOf<AController> AIControllerClass
	{
		get
		{
			CheckDestroyed();
			if (!AIControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:AIControllerClass");
				return default(TSubclassOf<AController>);
			}
			return TSubclassOfMarshaler<AController>.FromNative(IntPtr.Add(base.Address, AIControllerClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIControllerClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:AIControllerClass");
			}
			else
			{
				TSubclassOfMarshaler<AController>.ToNative(IntPtr.Add(base.Address, AIControllerClass_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392172318196276uL)]
	[UMetaPath("/Script/Engine.Pawn:PlayerState")]
	public APlayerState PlayerState
	{
		get
		{
			CheckDestroyed();
			if (!PlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:PlayerState");
				return null;
			}
			return UObjectMarshaler<APlayerState>.FromNative(IntPtr.Add(base.Address, PlayerState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:PlayerState");
			}
			else
			{
				UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(base.Address, PlayerState_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141125652uL)]
	[UMetaPath("/Script/Engine.Pawn:LastHitBy")]
	public AController LastHitBy
	{
		get
		{
			CheckDestroyed();
			if (!LastHitBy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:LastHitBy");
				return null;
			}
			return UObjectMarshaler<AController>.FromNative(IntPtr.Add(base.Address, LastHitBy_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastHitBy_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:LastHitBy");
			}
			else
			{
				UObjectMarshaler<AController>.ToNative(IntPtr.Add(base.Address, LastHitBy_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Pawn:ReceiveControllerChangedDelegate")]
	public FPawnControllerChangedSignature ReceiveControllerChangedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ReceiveControllerChangedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:ReceiveControllerChangedDelegate");
				return new FPawnControllerChangedSignature();
			}
			if (ReceiveControllerChangedDelegate_DelegateCached == null)
			{
				ReceiveControllerChangedDelegate_DelegateCached = new FPawnControllerChangedSignature();
				ReceiveControllerChangedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ReceiveControllerChangedDelegate_Offset));
			}
			return ReceiveControllerChangedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668615806976uL)]
	[UMetaPath("/Script/Engine.Pawn:ReceiveRestartedDelegate")]
	public FPawnRestartedSignature ReceiveRestartedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ReceiveRestartedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Pawn:ReceiveRestartedDelegate");
				return new FPawnRestartedSignature();
			}
			if (ReceiveRestartedDelegate_DelegateCached == null)
			{
				ReceiveRestartedDelegate_DelegateCached = new FPawnRestartedSignature();
				ReceiveRestartedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ReceiveRestartedDelegate_Offset));
			}
			return ReceiveRestartedDelegate_DelegateCached;
		}
	}

	internal override void SetupPlayerInputComponent(IntPtr playerInputComponentAddress)
	{
		UInputComponent playerInputComponent = GCHelper.Find<UInputComponent>(playerInputComponentAddress);
		SetupPlayerInputComponent(playerInputComponent);
	}

	protected virtual void SetupPlayerInputComponent(UInputComponent playerInputComponent)
	{
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Pawn:SpawnDefaultController")]
	public unsafe void SpawnDefaultController()
	{
		CheckDestroyed();
		if (!SpawnDefaultController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:SpawnDefaultController");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnDefaultController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnDefaultController_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SpawnDefaultController_FunctionAddress, argsSize: SpawnDefaultController_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Pawn:SetCanAffectNavigationGeneration")]
	public unsafe void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate = false)
	{
		CheckDestroyed();
		if (!SetCanAffectNavigationGeneration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:SetCanAffectNavigationGeneration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCanAffectNavigationGeneration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCanAffectNavigationGeneration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCanAffectNavigationGeneration_bNewValue_Offset), 0, SetCanAffectNavigationGeneration_bNewValue_PropertyAddress.Address, bNewValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCanAffectNavigationGeneration_bForceUpdate_Offset), 0, SetCanAffectNavigationGeneration_bForceUpdate_PropertyAddress.Address, bForceUpdate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCanAffectNavigationGeneration_FunctionAddress, intPtr, SetCanAffectNavigationGeneration_ParamsSize);
	}

	[UFunction(Flags = 134350852u)]
	[UMetaPath("/Script/Engine.Pawn:ReceiveUnpossessed")]
	public unsafe void ReceiveUnpossessed(AController OldController)
	{
		CheckDestroyed();
		if (!ReceiveUnpossessed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceiveUnpossessed");
			return;
		}
		if (ReceiveUnpossessed_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveUnpossessed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveUnpossessed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveUnpossessed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveUnpossessed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveUnpossessed_OldController_Offset), 0, ReceiveUnpossessed_OldController_PropertyAddress.Address, OldController);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveUnpossessed_InstanceFunctionAddress, intPtr, ReceiveUnpossessed_ParamsSize);
	}

	protected unsafe virtual void ReceiveUnpossessed_Implementation(AController OldController)
	{
		CheckDestroyed();
		if (!ReceiveUnpossessed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceiveUnpossessed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveUnpossessed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveUnpossessed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveUnpossessed_OldController_Offset), 0, ReceiveUnpossessed_OldController_PropertyAddress.Address, OldController);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveUnpossessed_FunctionAddress, intPtr, ReceiveUnpossessed_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Pawn:ReceiveRestarted")]
	public unsafe void ReceiveRestarted()
	{
		CheckDestroyed();
		if (!ReceiveRestarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceiveRestarted");
			return;
		}
		if (ReceiveRestarted_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveRestarted_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveRestarted");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveRestarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveRestarted_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveRestarted_InstanceFunctionAddress, argsSize: ReceiveRestarted_ParamsSize);
	}

	protected unsafe virtual void ReceiveRestarted_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveRestarted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceiveRestarted");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveRestarted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveRestarted_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveRestarted_FunctionAddress, argsSize: ReceiveRestarted_ParamsSize);
	}

	[UFunction(Flags = 134350852u)]
	[UMetaPath("/Script/Engine.Pawn:ReceivePossessed")]
	public unsafe void ReceivePossessed(AController NewController)
	{
		CheckDestroyed();
		if (!ReceivePossessed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceivePossessed");
			return;
		}
		if (ReceivePossessed_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceivePossessed_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceivePossessed");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePossessed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePossessed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceivePossessed_NewController_Offset), 0, ReceivePossessed_NewController_PropertyAddress.Address, NewController);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePossessed_InstanceFunctionAddress, intPtr, ReceivePossessed_ParamsSize);
	}

	protected unsafe virtual void ReceivePossessed_Implementation(AController NewController)
	{
		CheckDestroyed();
		if (!ReceivePossessed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceivePossessed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePossessed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePossessed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceivePossessed_NewController_Offset), 0, ReceivePossessed_NewController_PropertyAddress.Address, NewController);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePossessed_FunctionAddress, intPtr, ReceivePossessed_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.Pawn:ReceiveControllerChanged")]
	public unsafe void ReceiveControllerChanged(AController OldController, AController NewController)
	{
		CheckDestroyed();
		if (!ReceiveControllerChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceiveControllerChanged");
			return;
		}
		if (ReceiveControllerChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveControllerChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveControllerChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveControllerChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveControllerChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveControllerChanged_OldController_Offset), 0, ReceiveControllerChanged_OldController_PropertyAddress.Address, OldController);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveControllerChanged_NewController_Offset), 0, ReceiveControllerChanged_NewController_PropertyAddress.Address, NewController);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveControllerChanged_InstanceFunctionAddress, intPtr, ReceiveControllerChanged_ParamsSize);
	}

	protected unsafe virtual void ReceiveControllerChanged_Implementation(AController OldController, AController NewController)
	{
		CheckDestroyed();
		if (!ReceiveControllerChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ReceiveControllerChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveControllerChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveControllerChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveControllerChanged_OldController_Offset), 0, ReceiveControllerChanged_OldController_PropertyAddress.Address, OldController);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, ReceiveControllerChanged_NewController_Offset), 0, ReceiveControllerChanged_NewController_PropertyAddress.Address, NewController);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveControllerChanged_FunctionAddress, intPtr, ReceiveControllerChanged_ParamsSize);
	}

	[UFunction(Flags = 75629573u)]
	[UMetaPath("/Script/Engine.Pawn:PawnMakeNoise")]
	public unsafe void PawnMakeNoise(float Loudness, FVector NoiseLocation, bool bUseNoiseMakerLocation, AActor NoiseMaker)
	{
		CheckDestroyed();
		if (!PawnMakeNoise_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:PawnMakeNoise");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PawnMakeNoise_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PawnMakeNoise_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PawnMakeNoise_Loudness_Offset), 0, PawnMakeNoise_Loudness_PropertyAddress.Address, Loudness);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, PawnMakeNoise_NoiseLocation_Offset), 0, PawnMakeNoise_NoiseLocation_PropertyAddress.Address, NoiseLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PawnMakeNoise_bUseNoiseMakerLocation_Offset), 0, PawnMakeNoise_bUseNoiseMakerLocation_PropertyAddress.Address, bUseNoiseMakerLocation);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PawnMakeNoise_NoiseMaker_Offset), 0, PawnMakeNoise_NoiseMaker_PropertyAddress.Address, NoiseMaker);
		NativeReflection.InvokeFunctionOptimized(base.Address, PawnMakeNoise_FunctionAddress, intPtr, PawnMakeNoise_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Pawn:IsPlayerControlled")]
	public unsafe bool IsPlayerControlled()
	{
		CheckDestroyed();
		if (!IsPlayerControlled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:IsPlayerControlled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayerControlled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayerControlled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayerControlled_FunctionAddress, intPtr, IsPlayerControlled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayerControlled_ReturnValue_Offset), 0, IsPlayerControlled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Pawn:IsPawnControlled")]
	public unsafe bool IsPawnControlled()
	{
		CheckDestroyed();
		if (!IsPawnControlled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:IsPawnControlled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPawnControlled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPawnControlled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPawnControlled_FunctionAddress, intPtr, IsPawnControlled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPawnControlled_ReturnValue_Offset), 0, IsPawnControlled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Pawn:IsMoveInputIgnored")]
	public unsafe bool IsMoveInputIgnored()
	{
		CheckDestroyed();
		if (!IsMoveInputIgnored_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:IsMoveInputIgnored");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMoveInputIgnored_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMoveInputIgnored_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMoveInputIgnored_FunctionAddress, intPtr, IsMoveInputIgnored_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMoveInputIgnored_ReturnValue_Offset), 0, IsMoveInputIgnored_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Pawn:IsLocallyViewed")]
	public unsafe bool IsLocallyViewed()
	{
		CheckDestroyed();
		if (!IsLocallyViewed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:IsLocallyViewed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocallyViewed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocallyViewed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocallyViewed_FunctionAddress, intPtr, IsLocallyViewed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocallyViewed_ReturnValue_Offset), 0, IsLocallyViewed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Pawn:IsLocallyControlled")]
	public unsafe bool IsLocallyControlled()
	{
		CheckDestroyed();
		if (!IsLocallyControlled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:IsLocallyControlled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocallyControlled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocallyControlled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocallyControlled_FunctionAddress, intPtr, IsLocallyControlled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocallyControlled_ReturnValue_Offset), 0, IsLocallyControlled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Pawn:IsControlled")]
	public unsafe bool IsControlled()
	{
		CheckDestroyed();
		if (!IsControlled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:IsControlled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsControlled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsControlled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsControlled_FunctionAddress, intPtr, IsControlled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsControlled_ReturnValue_Offset), 0, IsControlled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Pawn:IsBotControlled")]
	public unsafe bool IsBotControlled()
	{
		CheckDestroyed();
		if (!IsBotControlled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:IsBotControlled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsBotControlled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsBotControlled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsBotControlled_FunctionAddress, intPtr, IsBotControlled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsBotControlled_ReturnValue_Offset), 0, IsBotControlled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Pawn:GetPendingMovementInputVector")]
	public unsafe FVector GetPendingMovementInputVector()
	{
		CheckDestroyed();
		if (!GetPendingMovementInputVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetPendingMovementInputVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPendingMovementInputVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPendingMovementInputVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPendingMovementInputVector_FunctionAddress, intPtr, GetPendingMovementInputVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPendingMovementInputVector_ReturnValue_Offset), 0, GetPendingMovementInputVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.Pawn:GetNavAgentLocation")]
	public unsafe FVector GetNavAgentLocation()
	{
		CheckDestroyed();
		if (!GetNavAgentLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetNavAgentLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNavAgentLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNavAgentLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNavAgentLocation_FunctionAddress, intPtr, GetNavAgentLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetNavAgentLocation_ReturnValue_Offset), 0, GetNavAgentLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Pawn:GetMovementComponent")]
	public unsafe UPawnMovementComponent GetMovementComponent()
	{
		CheckDestroyed();
		if (!GetMovementComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetMovementComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMovementComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMovementComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMovementComponent_FunctionAddress, intPtr, GetMovementComponent_ParamsSize);
		return UObjectMarshaler<UPawnMovementComponent>.FromNative(IntPtr.Add(intPtr, GetMovementComponent_ReturnValue_Offset), 0, GetMovementComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Engine.Pawn:GetMovementBaseActor")]
	public unsafe static AActor GetMovementBaseActor(APawn Pawn)
	{
		if (!GetMovementBaseActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetMovementBaseActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMovementBaseActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMovementBaseActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, GetMovementBaseActor_Pawn_Offset), 0, GetMovementBaseActor_Pawn_PropertyAddress.Address, Pawn);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMovementBaseActor_FunctionAddress, intPtr, GetMovementBaseActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetMovementBaseActor_ReturnValue_Offset), 0, GetMovementBaseActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Pawn:GetLocalViewingPlayerController")]
	public unsafe APlayerController GetLocalViewingPlayerController()
	{
		CheckDestroyed();
		if (!GetLocalViewingPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetLocalViewingPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalViewingPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalViewingPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLocalViewingPlayerController_FunctionAddress, intPtr, GetLocalViewingPlayerController_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetLocalViewingPlayerController_ReturnValue_Offset), 0, GetLocalViewingPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Pawn:GetLastMovementInputVector")]
	public unsafe FVector GetLastMovementInputVector()
	{
		CheckDestroyed();
		if (!GetLastMovementInputVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetLastMovementInputVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLastMovementInputVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLastMovementInputVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLastMovementInputVector_FunctionAddress, intPtr, GetLastMovementInputVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLastMovementInputVector_ReturnValue_Offset), 0, GetLastMovementInputVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.Pawn:GetControlRotation")]
	public unsafe FRotator GetControlRotation()
	{
		CheckDestroyed();
		if (!GetControlRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetControlRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlRotation_FunctionAddress, intPtr, GetControlRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetControlRotation_ReturnValue_Offset), 0, GetControlRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Pawn:GetController")]
	public unsafe AController GetController()
	{
		CheckDestroyed();
		if (!GetController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetController_FunctionAddress, intPtr, GetController_ParamsSize);
		return UObjectMarshaler<AController>.FromNative(IntPtr.Add(intPtr, GetController_ReturnValue_Offset), 0, GetController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.Pawn:GetBaseAimRotation")]
	public unsafe FRotator GetBaseAimRotation()
	{
		CheckDestroyed();
		if (!GetBaseAimRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:GetBaseAimRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBaseAimRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBaseAimRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBaseAimRotation_FunctionAddress, intPtr, GetBaseAimRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetBaseAimRotation_ReturnValue_Offset), 0, GetBaseAimRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Pawn:DetachFromControllerPendingDestroy")]
	public unsafe void DetachFromControllerPendingDestroy()
	{
		CheckDestroyed();
		if (!DetachFromControllerPendingDestroy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:DetachFromControllerPendingDestroy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DetachFromControllerPendingDestroy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DetachFromControllerPendingDestroy_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DetachFromControllerPendingDestroy_FunctionAddress, argsSize: DetachFromControllerPendingDestroy_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.Pawn:ConsumeMovementInputVector")]
	public unsafe FVector ConsumeMovementInputVector()
	{
		CheckDestroyed();
		if (!ConsumeMovementInputVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:ConsumeMovementInputVector");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsumeMovementInputVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsumeMovementInputVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConsumeMovementInputVector_FunctionAddress, intPtr, ConsumeMovementInputVector_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ConsumeMovementInputVector_ReturnValue_Offset), 0, ConsumeMovementInputVector_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.Pawn:AddMovementInput")]
	public unsafe void AddMovementInput(FVector WorldDirection, float ScaleValue = 1f, bool bForce = false)
	{
		CheckDestroyed();
		if (!AddMovementInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:AddMovementInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMovementInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMovementInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddMovementInput_WorldDirection_Offset), 0, AddMovementInput_WorldDirection_PropertyAddress.Address, WorldDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddMovementInput_ScaleValue_Offset), 0, AddMovementInput_ScaleValue_PropertyAddress.Address, ScaleValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddMovementInput_bForce_Offset), 0, AddMovementInput_bForce_PropertyAddress.Address, bForce);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMovementInput_FunctionAddress, intPtr, AddMovementInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Pawn:AddControllerYawInput")]
	public unsafe void AddControllerYawInput(float Val)
	{
		CheckDestroyed();
		if (!AddControllerYawInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:AddControllerYawInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddControllerYawInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddControllerYawInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddControllerYawInput_Val_Offset), 0, AddControllerYawInput_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddControllerYawInput_FunctionAddress, intPtr, AddControllerYawInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Pawn:AddControllerRollInput")]
	public unsafe void AddControllerRollInput(float Val)
	{
		CheckDestroyed();
		if (!AddControllerRollInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:AddControllerRollInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddControllerRollInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddControllerRollInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddControllerRollInput_Val_Offset), 0, AddControllerRollInput_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddControllerRollInput_FunctionAddress, intPtr, AddControllerRollInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Pawn:AddControllerPitchInput")]
	public unsafe void AddControllerPitchInput(float Val)
	{
		CheckDestroyed();
		if (!AddControllerPitchInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Pawn:AddControllerPitchInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddControllerPitchInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddControllerPitchInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddControllerPitchInput_Val_Offset), 0, AddControllerPitchInput_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddControllerPitchInput_FunctionAddress, intPtr, AddControllerPitchInput_ParamsSize);
	}

	static APawn()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APawn)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APawn));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.Pawn");
		NativeReflectionCached.GetPropertyRef(ref UseControllerRotationPitch_PropertyAddress, classAddress, "bUseControllerRotationPitch");
		UseControllerRotationPitch_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bUseControllerRotationPitch");
		UseControllerRotationPitch_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bUseControllerRotationPitch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseControllerRotationYaw_PropertyAddress, classAddress, "bUseControllerRotationYaw");
		UseControllerRotationYaw_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bUseControllerRotationYaw");
		UseControllerRotationYaw_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bUseControllerRotationYaw", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseControllerRotationRoll_PropertyAddress, classAddress, "bUseControllerRotationRoll");
		UseControllerRotationRoll_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bUseControllerRotationRoll");
		UseControllerRotationRoll_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bUseControllerRotationRoll", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanAffectNavigationGeneration_PropertyAddress, classAddress, "bCanAffectNavigationGeneration");
		CanAffectNavigationGeneration_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "bCanAffectNavigationGeneration");
		CanAffectNavigationGeneration_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "bCanAffectNavigationGeneration", Classes.FBoolProperty);
		BaseEyeHeight_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "BaseEyeHeight");
		BaseEyeHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "BaseEyeHeight", Classes.FFloatProperty);
		AIControllerClass_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "AIControllerClass");
		AIControllerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "AIControllerClass", Classes.FClassProperty);
		PlayerState_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "PlayerState");
		PlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "PlayerState", Classes.FObjectProperty);
		LastHitBy_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "LastHitBy");
		LastHitBy_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "LastHitBy", Classes.FObjectProperty);
		ReceiveControllerChangedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ReceiveControllerChangedDelegate");
		ReceiveControllerChangedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ReceiveControllerChangedDelegate", Classes.FMulticastDelegateProperty);
		ReceiveRestartedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "ReceiveRestartedDelegate");
		ReceiveRestartedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "ReceiveRestartedDelegate", Classes.FMulticastDelegateProperty);
		SpawnDefaultController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnDefaultController");
		SpawnDefaultController_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnDefaultController_FunctionAddress);
		SpawnDefaultController_IsValid = SpawnDefaultController_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:SpawnDefaultController", SpawnDefaultController_IsValid);
		SetCanAffectNavigationGeneration_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCanAffectNavigationGeneration");
		SetCanAffectNavigationGeneration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCanAffectNavigationGeneration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCanAffectNavigationGeneration_bNewValue_PropertyAddress, SetCanAffectNavigationGeneration_FunctionAddress, "bNewValue");
		SetCanAffectNavigationGeneration_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCanAffectNavigationGeneration_FunctionAddress, "bNewValue");
		SetCanAffectNavigationGeneration_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanAffectNavigationGeneration_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCanAffectNavigationGeneration_bForceUpdate_PropertyAddress, SetCanAffectNavigationGeneration_FunctionAddress, "bForceUpdate");
		SetCanAffectNavigationGeneration_bForceUpdate_Offset = NativeReflectionCached.GetPropertyOffset(SetCanAffectNavigationGeneration_FunctionAddress, "bForceUpdate");
		SetCanAffectNavigationGeneration_bForceUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanAffectNavigationGeneration_FunctionAddress, "bForceUpdate", Classes.FBoolProperty);
		SetCanAffectNavigationGeneration_IsValid = SetCanAffectNavigationGeneration_FunctionAddress != IntPtr.Zero && SetCanAffectNavigationGeneration_bNewValue_IsValid && SetCanAffectNavigationGeneration_bForceUpdate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:SetCanAffectNavigationGeneration", SetCanAffectNavigationGeneration_IsValid);
		ReceiveUnpossessed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceiveUnpossessed");
		ReceiveUnpossessed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveUnpossessed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveUnpossessed_OldController_PropertyAddress, ReceiveUnpossessed_FunctionAddress, "OldController");
		ReceiveUnpossessed_OldController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveUnpossessed_FunctionAddress, "OldController");
		ReceiveUnpossessed_OldController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveUnpossessed_FunctionAddress, "OldController", Classes.FObjectProperty);
		ReceiveUnpossessed_IsValid = ReceiveUnpossessed_FunctionAddress != IntPtr.Zero && ReceiveUnpossessed_OldController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:ReceiveUnpossessed", ReceiveUnpossessed_IsValid);
		ReceiveRestarted_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceiveRestarted");
		ReceiveRestarted_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveRestarted_FunctionAddress);
		ReceiveRestarted_IsValid = ReceiveRestarted_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:ReceiveRestarted", ReceiveRestarted_IsValid);
		ReceivePossessed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceivePossessed");
		ReceivePossessed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceivePossessed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceivePossessed_NewController_PropertyAddress, ReceivePossessed_FunctionAddress, "NewController");
		ReceivePossessed_NewController_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePossessed_FunctionAddress, "NewController");
		ReceivePossessed_NewController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePossessed_FunctionAddress, "NewController", Classes.FObjectProperty);
		ReceivePossessed_IsValid = ReceivePossessed_FunctionAddress != IntPtr.Zero && ReceivePossessed_NewController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:ReceivePossessed", ReceivePossessed_IsValid);
		ReceiveControllerChanged_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReceiveControllerChanged");
		ReceiveControllerChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveControllerChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveControllerChanged_OldController_PropertyAddress, ReceiveControllerChanged_FunctionAddress, "OldController");
		ReceiveControllerChanged_OldController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveControllerChanged_FunctionAddress, "OldController");
		ReceiveControllerChanged_OldController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveControllerChanged_FunctionAddress, "OldController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveControllerChanged_NewController_PropertyAddress, ReceiveControllerChanged_FunctionAddress, "NewController");
		ReceiveControllerChanged_NewController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveControllerChanged_FunctionAddress, "NewController");
		ReceiveControllerChanged_NewController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveControllerChanged_FunctionAddress, "NewController", Classes.FObjectProperty);
		ReceiveControllerChanged_IsValid = ReceiveControllerChanged_FunctionAddress != IntPtr.Zero && ReceiveControllerChanged_OldController_IsValid && ReceiveControllerChanged_NewController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:ReceiveControllerChanged", ReceiveControllerChanged_IsValid);
		PawnMakeNoise_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PawnMakeNoise");
		PawnMakeNoise_ParamsSize = NativeReflection.GetFunctionParamsSize(PawnMakeNoise_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PawnMakeNoise_Loudness_PropertyAddress, PawnMakeNoise_FunctionAddress, "Loudness");
		PawnMakeNoise_Loudness_Offset = NativeReflectionCached.GetPropertyOffset(PawnMakeNoise_FunctionAddress, "Loudness");
		PawnMakeNoise_Loudness_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnMakeNoise_FunctionAddress, "Loudness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PawnMakeNoise_NoiseLocation_PropertyAddress, PawnMakeNoise_FunctionAddress, "NoiseLocation");
		PawnMakeNoise_NoiseLocation_Offset = NativeReflectionCached.GetPropertyOffset(PawnMakeNoise_FunctionAddress, "NoiseLocation");
		PawnMakeNoise_NoiseLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnMakeNoise_FunctionAddress, "NoiseLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PawnMakeNoise_bUseNoiseMakerLocation_PropertyAddress, PawnMakeNoise_FunctionAddress, "bUseNoiseMakerLocation");
		PawnMakeNoise_bUseNoiseMakerLocation_Offset = NativeReflectionCached.GetPropertyOffset(PawnMakeNoise_FunctionAddress, "bUseNoiseMakerLocation");
		PawnMakeNoise_bUseNoiseMakerLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnMakeNoise_FunctionAddress, "bUseNoiseMakerLocation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PawnMakeNoise_NoiseMaker_PropertyAddress, PawnMakeNoise_FunctionAddress, "NoiseMaker");
		PawnMakeNoise_NoiseMaker_Offset = NativeReflectionCached.GetPropertyOffset(PawnMakeNoise_FunctionAddress, "NoiseMaker");
		PawnMakeNoise_NoiseMaker_IsValid = NativeReflectionCached.ValidatePropertyClass(PawnMakeNoise_FunctionAddress, "NoiseMaker", Classes.FObjectProperty);
		PawnMakeNoise_IsValid = PawnMakeNoise_FunctionAddress != IntPtr.Zero && PawnMakeNoise_Loudness_IsValid && PawnMakeNoise_NoiseLocation_IsValid && PawnMakeNoise_bUseNoiseMakerLocation_IsValid && PawnMakeNoise_NoiseMaker_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:PawnMakeNoise", PawnMakeNoise_IsValid);
		IsPlayerControlled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPlayerControlled");
		IsPlayerControlled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayerControlled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayerControlled_ReturnValue_PropertyAddress, IsPlayerControlled_FunctionAddress, "ReturnValue");
		IsPlayerControlled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayerControlled_FunctionAddress, "ReturnValue");
		IsPlayerControlled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayerControlled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayerControlled_IsValid = IsPlayerControlled_FunctionAddress != IntPtr.Zero && IsPlayerControlled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:IsPlayerControlled", IsPlayerControlled_IsValid);
		IsPawnControlled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPawnControlled");
		IsPawnControlled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPawnControlled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPawnControlled_ReturnValue_PropertyAddress, IsPawnControlled_FunctionAddress, "ReturnValue");
		IsPawnControlled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPawnControlled_FunctionAddress, "ReturnValue");
		IsPawnControlled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPawnControlled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPawnControlled_IsValid = IsPawnControlled_FunctionAddress != IntPtr.Zero && IsPawnControlled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:IsPawnControlled", IsPawnControlled_IsValid);
		IsMoveInputIgnored_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsMoveInputIgnored");
		IsMoveInputIgnored_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMoveInputIgnored_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMoveInputIgnored_ReturnValue_PropertyAddress, IsMoveInputIgnored_FunctionAddress, "ReturnValue");
		IsMoveInputIgnored_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMoveInputIgnored_FunctionAddress, "ReturnValue");
		IsMoveInputIgnored_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMoveInputIgnored_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMoveInputIgnored_IsValid = IsMoveInputIgnored_FunctionAddress != IntPtr.Zero && IsMoveInputIgnored_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:IsMoveInputIgnored", IsMoveInputIgnored_IsValid);
		IsLocallyViewed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLocallyViewed");
		IsLocallyViewed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocallyViewed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocallyViewed_ReturnValue_PropertyAddress, IsLocallyViewed_FunctionAddress, "ReturnValue");
		IsLocallyViewed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocallyViewed_FunctionAddress, "ReturnValue");
		IsLocallyViewed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocallyViewed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocallyViewed_IsValid = IsLocallyViewed_FunctionAddress != IntPtr.Zero && IsLocallyViewed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:IsLocallyViewed", IsLocallyViewed_IsValid);
		IsLocallyControlled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLocallyControlled");
		IsLocallyControlled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocallyControlled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocallyControlled_ReturnValue_PropertyAddress, IsLocallyControlled_FunctionAddress, "ReturnValue");
		IsLocallyControlled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocallyControlled_FunctionAddress, "ReturnValue");
		IsLocallyControlled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocallyControlled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocallyControlled_IsValid = IsLocallyControlled_FunctionAddress != IntPtr.Zero && IsLocallyControlled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:IsLocallyControlled", IsLocallyControlled_IsValid);
		IsControlled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsControlled");
		IsControlled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsControlled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsControlled_ReturnValue_PropertyAddress, IsControlled_FunctionAddress, "ReturnValue");
		IsControlled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsControlled_FunctionAddress, "ReturnValue");
		IsControlled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsControlled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsControlled_IsValid = IsControlled_FunctionAddress != IntPtr.Zero && IsControlled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:IsControlled", IsControlled_IsValid);
		IsBotControlled_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsBotControlled");
		IsBotControlled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsBotControlled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsBotControlled_ReturnValue_PropertyAddress, IsBotControlled_FunctionAddress, "ReturnValue");
		IsBotControlled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsBotControlled_FunctionAddress, "ReturnValue");
		IsBotControlled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsBotControlled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsBotControlled_IsValid = IsBotControlled_FunctionAddress != IntPtr.Zero && IsBotControlled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:IsBotControlled", IsBotControlled_IsValid);
		GetPendingMovementInputVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPendingMovementInputVector");
		GetPendingMovementInputVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPendingMovementInputVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPendingMovementInputVector_ReturnValue_PropertyAddress, GetPendingMovementInputVector_FunctionAddress, "ReturnValue");
		GetPendingMovementInputVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPendingMovementInputVector_FunctionAddress, "ReturnValue");
		GetPendingMovementInputVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPendingMovementInputVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPendingMovementInputVector_IsValid = GetPendingMovementInputVector_FunctionAddress != IntPtr.Zero && GetPendingMovementInputVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetPendingMovementInputVector", GetPendingMovementInputVector_IsValid);
		GetNavAgentLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNavAgentLocation");
		GetNavAgentLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNavAgentLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNavAgentLocation_ReturnValue_PropertyAddress, GetNavAgentLocation_FunctionAddress, "ReturnValue");
		GetNavAgentLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNavAgentLocation_FunctionAddress, "ReturnValue");
		GetNavAgentLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNavAgentLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNavAgentLocation_IsValid = GetNavAgentLocation_FunctionAddress != IntPtr.Zero && GetNavAgentLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetNavAgentLocation", GetNavAgentLocation_IsValid);
		GetMovementComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMovementComponent");
		GetMovementComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMovementComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMovementComponent_ReturnValue_PropertyAddress, GetMovementComponent_FunctionAddress, "ReturnValue");
		GetMovementComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMovementComponent_FunctionAddress, "ReturnValue");
		GetMovementComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMovementComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMovementComponent_IsValid = GetMovementComponent_FunctionAddress != IntPtr.Zero && GetMovementComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetMovementComponent", GetMovementComponent_IsValid);
		GetMovementBaseActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMovementBaseActor");
		GetMovementBaseActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMovementBaseActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMovementBaseActor_Pawn_PropertyAddress, GetMovementBaseActor_FunctionAddress, "Pawn");
		GetMovementBaseActor_Pawn_Offset = NativeReflectionCached.GetPropertyOffset(GetMovementBaseActor_FunctionAddress, "Pawn");
		GetMovementBaseActor_Pawn_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMovementBaseActor_FunctionAddress, "Pawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMovementBaseActor_ReturnValue_PropertyAddress, GetMovementBaseActor_FunctionAddress, "ReturnValue");
		GetMovementBaseActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMovementBaseActor_FunctionAddress, "ReturnValue");
		GetMovementBaseActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMovementBaseActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMovementBaseActor_IsValid = GetMovementBaseActor_FunctionAddress != IntPtr.Zero && GetMovementBaseActor_Pawn_IsValid && GetMovementBaseActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetMovementBaseActor", GetMovementBaseActor_IsValid);
		GetLocalViewingPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalViewingPlayerController");
		GetLocalViewingPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalViewingPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalViewingPlayerController_ReturnValue_PropertyAddress, GetLocalViewingPlayerController_FunctionAddress, "ReturnValue");
		GetLocalViewingPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalViewingPlayerController_FunctionAddress, "ReturnValue");
		GetLocalViewingPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalViewingPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLocalViewingPlayerController_IsValid = GetLocalViewingPlayerController_FunctionAddress != IntPtr.Zero && GetLocalViewingPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetLocalViewingPlayerController", GetLocalViewingPlayerController_IsValid);
		GetLastMovementInputVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLastMovementInputVector");
		GetLastMovementInputVector_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLastMovementInputVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLastMovementInputVector_ReturnValue_PropertyAddress, GetLastMovementInputVector_FunctionAddress, "ReturnValue");
		GetLastMovementInputVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLastMovementInputVector_FunctionAddress, "ReturnValue");
		GetLastMovementInputVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLastMovementInputVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLastMovementInputVector_IsValid = GetLastMovementInputVector_FunctionAddress != IntPtr.Zero && GetLastMovementInputVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetLastMovementInputVector", GetLastMovementInputVector_IsValid);
		GetControlRotation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetControlRotation");
		GetControlRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlRotation_ReturnValue_PropertyAddress, GetControlRotation_FunctionAddress, "ReturnValue");
		GetControlRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRotation_FunctionAddress, "ReturnValue");
		GetControlRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlRotation_IsValid = GetControlRotation_FunctionAddress != IntPtr.Zero && GetControlRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetControlRotation", GetControlRotation_IsValid);
		GetController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetController");
		GetController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetController_ReturnValue_PropertyAddress, GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetController_FunctionAddress, "ReturnValue");
		GetController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetController_IsValid = GetController_FunctionAddress != IntPtr.Zero && GetController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetController", GetController_IsValid);
		GetBaseAimRotation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBaseAimRotation");
		GetBaseAimRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBaseAimRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBaseAimRotation_ReturnValue_PropertyAddress, GetBaseAimRotation_FunctionAddress, "ReturnValue");
		GetBaseAimRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBaseAimRotation_FunctionAddress, "ReturnValue");
		GetBaseAimRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBaseAimRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBaseAimRotation_IsValid = GetBaseAimRotation_FunctionAddress != IntPtr.Zero && GetBaseAimRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:GetBaseAimRotation", GetBaseAimRotation_IsValid);
		DetachFromControllerPendingDestroy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DetachFromControllerPendingDestroy");
		DetachFromControllerPendingDestroy_ParamsSize = NativeReflection.GetFunctionParamsSize(DetachFromControllerPendingDestroy_FunctionAddress);
		DetachFromControllerPendingDestroy_IsValid = DetachFromControllerPendingDestroy_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:DetachFromControllerPendingDestroy", DetachFromControllerPendingDestroy_IsValid);
		ConsumeMovementInputVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConsumeMovementInputVector");
		ConsumeMovementInputVector_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsumeMovementInputVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConsumeMovementInputVector_ReturnValue_PropertyAddress, ConsumeMovementInputVector_FunctionAddress, "ReturnValue");
		ConsumeMovementInputVector_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConsumeMovementInputVector_FunctionAddress, "ReturnValue");
		ConsumeMovementInputVector_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsumeMovementInputVector_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConsumeMovementInputVector_IsValid = ConsumeMovementInputVector_FunctionAddress != IntPtr.Zero && ConsumeMovementInputVector_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:ConsumeMovementInputVector", ConsumeMovementInputVector_IsValid);
		AddMovementInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMovementInput");
		AddMovementInput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMovementInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInput_WorldDirection_PropertyAddress, AddMovementInput_FunctionAddress, "WorldDirection");
		AddMovementInput_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInput_FunctionAddress, "WorldDirection");
		AddMovementInput_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInput_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInput_ScaleValue_PropertyAddress, AddMovementInput_FunctionAddress, "ScaleValue");
		AddMovementInput_ScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInput_FunctionAddress, "ScaleValue");
		AddMovementInput_ScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInput_FunctionAddress, "ScaleValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInput_bForce_PropertyAddress, AddMovementInput_FunctionAddress, "bForce");
		AddMovementInput_bForce_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInput_FunctionAddress, "bForce");
		AddMovementInput_bForce_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInput_FunctionAddress, "bForce", Classes.FBoolProperty);
		AddMovementInput_IsValid = AddMovementInput_FunctionAddress != IntPtr.Zero && AddMovementInput_WorldDirection_IsValid && AddMovementInput_ScaleValue_IsValid && AddMovementInput_bForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:AddMovementInput", AddMovementInput_IsValid);
		AddControllerYawInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddControllerYawInput");
		AddControllerYawInput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddControllerYawInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddControllerYawInput_Val_PropertyAddress, AddControllerYawInput_FunctionAddress, "Val");
		AddControllerYawInput_Val_Offset = NativeReflectionCached.GetPropertyOffset(AddControllerYawInput_FunctionAddress, "Val");
		AddControllerYawInput_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControllerYawInput_FunctionAddress, "Val", Classes.FFloatProperty);
		AddControllerYawInput_IsValid = AddControllerYawInput_FunctionAddress != IntPtr.Zero && AddControllerYawInput_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:AddControllerYawInput", AddControllerYawInput_IsValid);
		AddControllerRollInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddControllerRollInput");
		AddControllerRollInput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddControllerRollInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddControllerRollInput_Val_PropertyAddress, AddControllerRollInput_FunctionAddress, "Val");
		AddControllerRollInput_Val_Offset = NativeReflectionCached.GetPropertyOffset(AddControllerRollInput_FunctionAddress, "Val");
		AddControllerRollInput_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControllerRollInput_FunctionAddress, "Val", Classes.FFloatProperty);
		AddControllerRollInput_IsValid = AddControllerRollInput_FunctionAddress != IntPtr.Zero && AddControllerRollInput_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:AddControllerRollInput", AddControllerRollInput_IsValid);
		AddControllerPitchInput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddControllerPitchInput");
		AddControllerPitchInput_ParamsSize = NativeReflection.GetFunctionParamsSize(AddControllerPitchInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddControllerPitchInput_Val_PropertyAddress, AddControllerPitchInput_FunctionAddress, "Val");
		AddControllerPitchInput_Val_Offset = NativeReflectionCached.GetPropertyOffset(AddControllerPitchInput_FunctionAddress, "Val");
		AddControllerPitchInput_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(AddControllerPitchInput_FunctionAddress, "Val", Classes.FFloatProperty);
		AddControllerPitchInput_IsValid = AddControllerPitchInput_FunctionAddress != IntPtr.Zero && AddControllerPitchInput_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Pawn:AddControllerPitchInput", AddControllerPitchInput_IsValid);
	}
}
