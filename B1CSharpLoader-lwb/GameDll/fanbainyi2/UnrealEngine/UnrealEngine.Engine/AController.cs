using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818938533uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.Controller", "Engine", UnrealModuleType.Engine)]
public class AController : AActor, INavAgentInterface, IInterface
{
	private static bool PlayerState_IsValid;

	private static int PlayerState_Offset;

	private static bool OnInstigatedAnyDamage_IsValid;

	private static int OnInstigatedAnyDamage_Offset;

	private FInstigatedAnyDamageSignature OnInstigatedAnyDamage_DelegateCached;

	private static bool OnPossessedPawnChanged_IsValid;

	private static int OnPossessedPawnChanged_Offset;

	private FOnPossessedPawnChanged OnPossessedPawnChanged_DelegateCached;

	private static bool UnPossess_IsValid;

	private static IntPtr UnPossess_FunctionAddress;

	private static int UnPossess_ParamsSize;

	private static bool StopMovement_IsValid;

	private static IntPtr StopMovement_FunctionAddress;

	private static int StopMovement_ParamsSize;

	private static bool SetInitialLocationAndRotation_IsValid;

	private static IntPtr SetInitialLocationAndRotation_FunctionAddress;

	private static int SetInitialLocationAndRotation_ParamsSize;

	private static bool SetInitialLocationAndRotation_NewLocation_IsValid;

	private static FFieldAddress SetInitialLocationAndRotation_NewLocation_PropertyAddress;

	private static int SetInitialLocationAndRotation_NewLocation_Offset;

	private static bool SetInitialLocationAndRotation_NewRotation_IsValid;

	private static FFieldAddress SetInitialLocationAndRotation_NewRotation_PropertyAddress;

	private static int SetInitialLocationAndRotation_NewRotation_Offset;

	private static bool SetIgnoreMoveInput_IsValid;

	private static IntPtr SetIgnoreMoveInput_FunctionAddress;

	private static int SetIgnoreMoveInput_ParamsSize;

	private static bool SetIgnoreMoveInput_bNewMoveInput_IsValid;

	private static FFieldAddress SetIgnoreMoveInput_bNewMoveInput_PropertyAddress;

	private static int SetIgnoreMoveInput_bNewMoveInput_Offset;

	private static bool SetIgnoreLookInput_IsValid;

	private static IntPtr SetIgnoreLookInput_FunctionAddress;

	private static int SetIgnoreLookInput_ParamsSize;

	private static bool SetIgnoreLookInput_bNewLookInput_IsValid;

	private static FFieldAddress SetIgnoreLookInput_bNewLookInput_PropertyAddress;

	private static int SetIgnoreLookInput_bNewLookInput_Offset;

	private static bool SetControlRotation_IsValid;

	private static IntPtr SetControlRotation_FunctionAddress;

	private static int SetControlRotation_ParamsSize;

	private static bool SetControlRotation_NewRotation_IsValid;

	private static FFieldAddress SetControlRotation_NewRotation_PropertyAddress;

	private static int SetControlRotation_NewRotation_Offset;

	private static bool ResetIgnoreMoveInput_IsValid;

	private static IntPtr ResetIgnoreMoveInput_FunctionAddress;

	private static int ResetIgnoreMoveInput_ParamsSize;

	private static bool ResetIgnoreLookInput_IsValid;

	private static IntPtr ResetIgnoreLookInput_FunctionAddress;

	private static int ResetIgnoreLookInput_ParamsSize;

	private static bool ResetIgnoreInputFlags_IsValid;

	private static IntPtr ResetIgnoreInputFlags_FunctionAddress;

	private static int ResetIgnoreInputFlags_ParamsSize;

	private static bool ReceiveUnPossess_IsValid;

	private IntPtr ReceiveUnPossess_InstanceFunctionAddress;

	private static IntPtr ReceiveUnPossess_FunctionAddress;

	private static int ReceiveUnPossess_ParamsSize;

	private static bool ReceiveUnPossess_UnpossessedPawn_IsValid;

	private static FFieldAddress ReceiveUnPossess_UnpossessedPawn_PropertyAddress;

	private static int ReceiveUnPossess_UnpossessedPawn_Offset;

	private static bool ReceivePossess_IsValid;

	private IntPtr ReceivePossess_InstanceFunctionAddress;

	private static IntPtr ReceivePossess_FunctionAddress;

	private static int ReceivePossess_ParamsSize;

	private static bool ReceivePossess_PossessedPawn_IsValid;

	private static FFieldAddress ReceivePossess_PossessedPawn_PropertyAddress;

	private static int ReceivePossess_PossessedPawn_Offset;

	private static bool ReceiveInstigatedAnyDamage_IsValid;

	private IntPtr ReceiveInstigatedAnyDamage_InstanceFunctionAddress;

	private static IntPtr ReceiveInstigatedAnyDamage_FunctionAddress;

	private static int ReceiveInstigatedAnyDamage_ParamsSize;

	private static bool ReceiveInstigatedAnyDamage_Damage_IsValid;

	private static FFieldAddress ReceiveInstigatedAnyDamage_Damage_PropertyAddress;

	private static int ReceiveInstigatedAnyDamage_Damage_Offset;

	private static bool ReceiveInstigatedAnyDamage_DamageType_IsValid;

	private static FFieldAddress ReceiveInstigatedAnyDamage_DamageType_PropertyAddress;

	private static int ReceiveInstigatedAnyDamage_DamageType_Offset;

	private static bool ReceiveInstigatedAnyDamage_DamagedActor_IsValid;

	private static FFieldAddress ReceiveInstigatedAnyDamage_DamagedActor_PropertyAddress;

	private static int ReceiveInstigatedAnyDamage_DamagedActor_Offset;

	private static bool ReceiveInstigatedAnyDamage_DamageCauser_IsValid;

	private static FFieldAddress ReceiveInstigatedAnyDamage_DamageCauser_PropertyAddress;

	private static int ReceiveInstigatedAnyDamage_DamageCauser_Offset;

	private static bool Possess_IsValid;

	private static IntPtr Possess_FunctionAddress;

	private static int Possess_ParamsSize;

	private static bool Possess_InPawn_IsValid;

	private static FFieldAddress Possess_InPawn_PropertyAddress;

	private static int Possess_InPawn_Offset;

	private static bool LineOfSightTo_IsValid;

	private static IntPtr LineOfSightTo_FunctionAddress;

	private static int LineOfSightTo_ParamsSize;

	private static bool LineOfSightTo_Other_IsValid;

	private static FFieldAddress LineOfSightTo_Other_PropertyAddress;

	private static int LineOfSightTo_Other_Offset;

	private static bool LineOfSightTo_ViewPoint_IsValid;

	private static FFieldAddress LineOfSightTo_ViewPoint_PropertyAddress;

	private static int LineOfSightTo_ViewPoint_Offset;

	private static bool LineOfSightTo_bAlternateChecks_IsValid;

	private static FFieldAddress LineOfSightTo_bAlternateChecks_PropertyAddress;

	private static int LineOfSightTo_bAlternateChecks_Offset;

	private static bool LineOfSightTo_ReturnValue_IsValid;

	private static FFieldAddress LineOfSightTo_ReturnValue_PropertyAddress;

	private static int LineOfSightTo_ReturnValue_Offset;

	private static bool GetControlledPawn_IsValid;

	private static IntPtr GetControlledPawn_FunctionAddress;

	private static int GetControlledPawn_ParamsSize;

	private static bool GetControlledPawn_ReturnValue_IsValid;

	private static FFieldAddress GetControlledPawn_ReturnValue_PropertyAddress;

	private static int GetControlledPawn_ReturnValue_Offset;

	private static bool IsPlayerController_IsValid;

	private static IntPtr IsPlayerController_FunctionAddress;

	private static int IsPlayerController_ParamsSize;

	private static bool IsPlayerController_ReturnValue_IsValid;

	private static FFieldAddress IsPlayerController_ReturnValue_PropertyAddress;

	private static int IsPlayerController_ReturnValue_Offset;

	private static bool IsMoveInputIgnored_IsValid;

	private static IntPtr IsMoveInputIgnored_FunctionAddress;

	private static int IsMoveInputIgnored_ParamsSize;

	private static bool IsMoveInputIgnored_ReturnValue_IsValid;

	private static FFieldAddress IsMoveInputIgnored_ReturnValue_PropertyAddress;

	private static int IsMoveInputIgnored_ReturnValue_Offset;

	private static bool IsLookInputIgnored_IsValid;

	private static IntPtr IsLookInputIgnored_FunctionAddress;

	private static int IsLookInputIgnored_ParamsSize;

	private static bool IsLookInputIgnored_ReturnValue_IsValid;

	private static FFieldAddress IsLookInputIgnored_ReturnValue_PropertyAddress;

	private static int IsLookInputIgnored_ReturnValue_Offset;

	private static bool IsLocalPlayerController_IsValid;

	private static IntPtr IsLocalPlayerController_FunctionAddress;

	private static int IsLocalPlayerController_ParamsSize;

	private static bool IsLocalPlayerController_ReturnValue_IsValid;

	private static FFieldAddress IsLocalPlayerController_ReturnValue_PropertyAddress;

	private static int IsLocalPlayerController_ReturnValue_Offset;

	private static bool IsLocalController_IsValid;

	private static IntPtr IsLocalController_FunctionAddress;

	private static int IsLocalController_ParamsSize;

	private static bool IsLocalController_ReturnValue_IsValid;

	private static FFieldAddress IsLocalController_ReturnValue_PropertyAddress;

	private static int IsLocalController_ReturnValue_Offset;

	private static bool GetViewTarget_IsValid;

	private static IntPtr GetViewTarget_FunctionAddress;

	private static int GetViewTarget_ParamsSize;

	private static bool GetViewTarget_ReturnValue_IsValid;

	private static FFieldAddress GetViewTarget_ReturnValue_PropertyAddress;

	private static int GetViewTarget_ReturnValue_Offset;

	private static bool GetPlayerViewPoint_IsValid;

	private static IntPtr GetPlayerViewPoint_FunctionAddress;

	private static int GetPlayerViewPoint_ParamsSize;

	private static bool GetPlayerViewPoint_Location_IsValid;

	private static FFieldAddress GetPlayerViewPoint_Location_PropertyAddress;

	private static int GetPlayerViewPoint_Location_Offset;

	private static bool GetPlayerViewPoint_Rotation_IsValid;

	private static FFieldAddress GetPlayerViewPoint_Rotation_PropertyAddress;

	private static int GetPlayerViewPoint_Rotation_Offset;

	private static bool GetDesiredRotation_IsValid;

	private static IntPtr GetDesiredRotation_FunctionAddress;

	private static int GetDesiredRotation_ParamsSize;

	private static bool GetDesiredRotation_ReturnValue_IsValid;

	private static FFieldAddress GetDesiredRotation_ReturnValue_PropertyAddress;

	private static int GetDesiredRotation_ReturnValue_Offset;

	private static bool GetControlRotation_IsValid;

	private static IntPtr GetControlRotation_FunctionAddress;

	private static int GetControlRotation_ParamsSize;

	private static bool GetControlRotation_ReturnValue_IsValid;

	private static FFieldAddress GetControlRotation_ReturnValue_PropertyAddress;

	private static int GetControlRotation_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881373436084788uL)]
	[UMetaPath("/Script/Engine.Controller:PlayerState")]
	public APlayerState PlayerState
	{
		get
		{
			CheckDestroyed();
			if (!PlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Controller:PlayerState");
				return null;
			}
			return UObjectMarshaler<APlayerState>.FromNative(IntPtr.Add(base.Address, PlayerState_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Controller:PlayerState");
			}
			else
			{
				UObjectMarshaler<APlayerState>.ToNative(IntPtr.Add(base.Address, PlayerState_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Controller:OnInstigatedAnyDamage")]
	public FInstigatedAnyDamageSignature OnInstigatedAnyDamage
	{
		get
		{
			CheckDestroyed();
			if (!OnInstigatedAnyDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Controller:OnInstigatedAnyDamage");
				return new FInstigatedAnyDamageSignature();
			}
			if (OnInstigatedAnyDamage_DelegateCached == null)
			{
				OnInstigatedAnyDamage_DelegateCached = new FInstigatedAnyDamageSignature();
				OnInstigatedAnyDamage_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInstigatedAnyDamage_Offset));
			}
			return OnInstigatedAnyDamage_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Controller:OnPossessedPawnChanged")]
	public FOnPossessedPawnChanged OnPossessedPawnChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnPossessedPawnChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Controller:OnPossessedPawnChanged");
				return new FOnPossessedPawnChanged();
			}
			if (OnPossessedPawnChanged_DelegateCached == null)
			{
				OnPossessedPawnChanged_DelegateCached = new FOnPossessedPawnChanged();
				OnPossessedPawnChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPossessedPawnChanged_Offset));
			}
			return OnPossessedPawnChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.Controller:UnPossess")]
	public unsafe void UnPossess()
	{
		CheckDestroyed();
		if (!UnPossess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:UnPossess");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnPossess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnPossess_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UnPossess_FunctionAddress, argsSize: UnPossess_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Controller:StopMovement")]
	public unsafe void StopMovement()
	{
		CheckDestroyed();
		if (!StopMovement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:StopMovement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopMovement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopMovement_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopMovement_FunctionAddress, argsSize: StopMovement_ParamsSize);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.Controller:SetInitialLocationAndRotation")]
	public unsafe void SetInitialLocationAndRotation(FVector NewLocation, FRotator NewRotation)
	{
		CheckDestroyed();
		if (!SetInitialLocationAndRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:SetInitialLocationAndRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInitialLocationAndRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInitialLocationAndRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetInitialLocationAndRotation_NewLocation_Offset), 0, SetInitialLocationAndRotation_NewLocation_PropertyAddress.Address, NewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetInitialLocationAndRotation_NewRotation_Offset), 0, SetInitialLocationAndRotation_NewRotation_PropertyAddress.Address, NewRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInitialLocationAndRotation_FunctionAddress, intPtr, SetInitialLocationAndRotation_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Controller:SetIgnoreMoveInput")]
	public unsafe void SetIgnoreMoveInput(bool bNewMoveInput)
	{
		CheckDestroyed();
		if (!SetIgnoreMoveInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:SetIgnoreMoveInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIgnoreMoveInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIgnoreMoveInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIgnoreMoveInput_bNewMoveInput_Offset), 0, SetIgnoreMoveInput_bNewMoveInput_PropertyAddress.Address, bNewMoveInput);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIgnoreMoveInput_FunctionAddress, intPtr, SetIgnoreMoveInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Controller:SetIgnoreLookInput")]
	public unsafe void SetIgnoreLookInput(bool bNewLookInput)
	{
		CheckDestroyed();
		if (!SetIgnoreLookInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:SetIgnoreLookInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIgnoreLookInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIgnoreLookInput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIgnoreLookInput_bNewLookInput_Offset), 0, SetIgnoreLookInput_bNewLookInput_PropertyAddress.Address, bNewLookInput);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIgnoreLookInput_FunctionAddress, intPtr, SetIgnoreLookInput_ParamsSize);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.Controller:SetControlRotation")]
	public unsafe void SetControlRotation(FRotator NewRotation)
	{
		CheckDestroyed();
		if (!SetControlRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:SetControlRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetControlRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetControlRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetControlRotation_NewRotation_Offset), 0, SetControlRotation_NewRotation_PropertyAddress.Address, NewRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetControlRotation_FunctionAddress, intPtr, SetControlRotation_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Controller:ResetIgnoreMoveInput")]
	public unsafe void ResetIgnoreMoveInput()
	{
		CheckDestroyed();
		if (!ResetIgnoreMoveInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ResetIgnoreMoveInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetIgnoreMoveInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetIgnoreMoveInput_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetIgnoreMoveInput_FunctionAddress, argsSize: ResetIgnoreMoveInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Controller:ResetIgnoreLookInput")]
	public unsafe void ResetIgnoreLookInput()
	{
		CheckDestroyed();
		if (!ResetIgnoreLookInput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ResetIgnoreLookInput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetIgnoreLookInput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetIgnoreLookInput_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetIgnoreLookInput_FunctionAddress, argsSize: ResetIgnoreLookInput_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.Controller:ResetIgnoreInputFlags")]
	public unsafe void ResetIgnoreInputFlags()
	{
		CheckDestroyed();
		if (!ResetIgnoreInputFlags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ResetIgnoreInputFlags");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetIgnoreInputFlags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetIgnoreInputFlags_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetIgnoreInputFlags_FunctionAddress, argsSize: ResetIgnoreInputFlags_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Engine.Controller:ReceiveUnPossess")]
	protected unsafe void ReceiveUnPossess(APawn UnpossessedPawn)
	{
		CheckDestroyed();
		if (!ReceiveUnPossess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ReceiveUnPossess");
			return;
		}
		if (ReceiveUnPossess_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveUnPossess_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveUnPossess");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveUnPossess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveUnPossess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveUnPossess_UnpossessedPawn_Offset), 0, ReceiveUnPossess_UnpossessedPawn_PropertyAddress.Address, UnpossessedPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveUnPossess_InstanceFunctionAddress, intPtr, ReceiveUnPossess_ParamsSize);
	}

	protected unsafe virtual void ReceiveUnPossess_Implementation(APawn UnpossessedPawn)
	{
		CheckDestroyed();
		if (!ReceiveUnPossess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ReceiveUnPossess");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveUnPossess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveUnPossess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveUnPossess_UnpossessedPawn_Offset), 0, ReceiveUnPossess_UnpossessedPawn_PropertyAddress.Address, UnpossessedPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveUnPossess_FunctionAddress, intPtr, ReceiveUnPossess_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/Engine.Controller:ReceivePossess")]
	protected unsafe void ReceivePossess(APawn PossessedPawn)
	{
		CheckDestroyed();
		if (!ReceivePossess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ReceivePossess");
			return;
		}
		if (ReceivePossess_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceivePossess_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceivePossess");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePossess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePossess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceivePossess_PossessedPawn_Offset), 0, ReceivePossess_PossessedPawn_PropertyAddress.Address, PossessedPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePossess_InstanceFunctionAddress, intPtr, ReceivePossess_ParamsSize);
	}

	protected unsafe virtual void ReceivePossess_Implementation(APawn PossessedPawn)
	{
		CheckDestroyed();
		if (!ReceivePossess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ReceivePossess");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceivePossess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceivePossess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceivePossess_PossessedPawn_Offset), 0, ReceivePossess_PossessedPawn_PropertyAddress.Address, PossessedPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceivePossess_FunctionAddress, intPtr, ReceivePossess_ParamsSize);
	}

	[UFunction(Flags = 134744068u)]
	[UMetaPath("/Script/Engine.Controller:ReceiveInstigatedAnyDamage")]
	protected unsafe void ReceiveInstigatedAnyDamage(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser)
	{
		CheckDestroyed();
		if (!ReceiveInstigatedAnyDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ReceiveInstigatedAnyDamage");
			return;
		}
		if (ReceiveInstigatedAnyDamage_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveInstigatedAnyDamage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveInstigatedAnyDamage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveInstigatedAnyDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveInstigatedAnyDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_Damage_Offset), 0, ReceiveInstigatedAnyDamage_Damage_PropertyAddress.Address, Damage);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_DamageType_Offset), 0, ReceiveInstigatedAnyDamage_DamageType_PropertyAddress.Address, DamageType);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_DamagedActor_Offset), 0, ReceiveInstigatedAnyDamage_DamagedActor_PropertyAddress.Address, DamagedActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_DamageCauser_Offset), 0, ReceiveInstigatedAnyDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveInstigatedAnyDamage_InstanceFunctionAddress, intPtr, ReceiveInstigatedAnyDamage_ParamsSize);
	}

	protected unsafe virtual void ReceiveInstigatedAnyDamage_Implementation(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser)
	{
		CheckDestroyed();
		if (!ReceiveInstigatedAnyDamage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:ReceiveInstigatedAnyDamage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveInstigatedAnyDamage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveInstigatedAnyDamage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_Damage_Offset), 0, ReceiveInstigatedAnyDamage_Damage_PropertyAddress.Address, Damage);
		UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_DamageType_Offset), 0, ReceiveInstigatedAnyDamage_DamageType_PropertyAddress.Address, DamageType);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_DamagedActor_Offset), 0, ReceiveInstigatedAnyDamage_DamagedActor_PropertyAddress.Address, DamagedActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveInstigatedAnyDamage_DamageCauser_Offset), 0, ReceiveInstigatedAnyDamage_DamageCauser_PropertyAddress.Address, DamageCauser);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveInstigatedAnyDamage_FunctionAddress, intPtr, ReceiveInstigatedAnyDamage_ParamsSize);
	}

	[UFunction(Flags = 67240965u)]
	[UMetaPath("/Script/Engine.Controller:Possess")]
	public unsafe void Possess(APawn InPawn)
	{
		CheckDestroyed();
		if (!Possess_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:Possess");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Possess_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Possess_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, Possess_InPawn_Offset), 0, Possess_InPawn_PropertyAddress.Address, InPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, Possess_FunctionAddress, intPtr, Possess_ParamsSize);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.Controller:LineOfSightTo")]
	public unsafe bool LineOfSightTo(AActor Other, FVector ViewPoint, bool bAlternateChecks = false)
	{
		CheckDestroyed();
		if (!LineOfSightTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:LineOfSightTo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LineOfSightTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LineOfSightTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, LineOfSightTo_Other_Offset), 0, LineOfSightTo_Other_PropertyAddress.Address, Other);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LineOfSightTo_ViewPoint_Offset), 0, LineOfSightTo_ViewPoint_PropertyAddress.Address, ViewPoint);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LineOfSightTo_bAlternateChecks_Offset), 0, LineOfSightTo_bAlternateChecks_PropertyAddress.Address, bAlternateChecks);
		NativeReflection.InvokeFunctionOptimized(base.Address, LineOfSightTo_FunctionAddress, intPtr, LineOfSightTo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LineOfSightTo_ReturnValue_Offset), 0, LineOfSightTo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u, OriginalName = "K2_GetPawn")]
	[UMetaPath("/Script/Engine.Controller:K2_GetPawn")]
	public unsafe APawn GetControlledPawn()
	{
		CheckDestroyed();
		if (!GetControlledPawn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:K2_GetPawn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlledPawn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlledPawn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlledPawn_FunctionAddress, intPtr, GetControlledPawn_ParamsSize);
		return UObjectMarshaler<APawn>.FromNative(IntPtr.Add(intPtr, GetControlledPawn_ReturnValue_Offset), 0, GetControlledPawn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Controller:IsPlayerController")]
	public unsafe bool IsPlayerController()
	{
		CheckDestroyed();
		if (!IsPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:IsPlayerController");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayerController_FunctionAddress, intPtr, IsPlayerController_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayerController_ReturnValue_Offset), 0, IsPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Controller:IsMoveInputIgnored")]
	public unsafe bool IsMoveInputIgnored()
	{
		CheckDestroyed();
		if (!IsMoveInputIgnored_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:IsMoveInputIgnored");
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

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Controller:IsLookInputIgnored")]
	public unsafe bool IsLookInputIgnored()
	{
		CheckDestroyed();
		if (!IsLookInputIgnored_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:IsLookInputIgnored");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLookInputIgnored_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLookInputIgnored_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLookInputIgnored_FunctionAddress, intPtr, IsLookInputIgnored_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLookInputIgnored_ReturnValue_Offset), 0, IsLookInputIgnored_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.Controller:IsLocalPlayerController")]
	public unsafe bool IsLocalPlayerController()
	{
		CheckDestroyed();
		if (!IsLocalPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:IsLocalPlayerController");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocalPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocalPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocalPlayerController_FunctionAddress, intPtr, IsLocalPlayerController_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocalPlayerController_ReturnValue_Offset), 0, IsLocalPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Controller:IsLocalController")]
	public unsafe bool IsLocalController()
	{
		CheckDestroyed();
		if (!IsLocalController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:IsLocalController");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocalController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocalController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocalController_FunctionAddress, intPtr, IsLocalController_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocalController_ReturnValue_Offset), 0, IsLocalController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.Controller:GetViewTarget")]
	public unsafe AActor GetViewTarget()
	{
		CheckDestroyed();
		if (!GetViewTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:GetViewTarget");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewTarget_FunctionAddress, intPtr, GetViewTarget_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetViewTarget_ReturnValue_Offset), 0, GetViewTarget_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/Engine.Controller:GetPlayerViewPoint")]
	public unsafe void GetPlayerViewPoint(out FVector Location, out FRotator Rotation)
	{
		CheckDestroyed();
		if (!GetPlayerViewPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:GetPlayerViewPoint");
			Location = default(FVector);
			Rotation = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerViewPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerViewPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerViewPoint_FunctionAddress, intPtr, GetPlayerViewPoint_ParamsSize);
		Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPlayerViewPoint_Location_Offset), 0, GetPlayerViewPoint_Location_PropertyAddress.Address);
		Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetPlayerViewPoint_Rotation_Offset), 0, GetPlayerViewPoint_Rotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.Controller:GetDesiredRotation")]
	public unsafe FRotator GetDesiredRotation()
	{
		CheckDestroyed();
		if (!GetDesiredRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:GetDesiredRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesiredRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesiredRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesiredRotation_FunctionAddress, intPtr, GetDesiredRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetDesiredRotation_ReturnValue_Offset), 0, GetDesiredRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.Controller:GetControlRotation")]
	public unsafe FRotator GetControlRotation()
	{
		CheckDestroyed();
		if (!GetControlRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.Controller:GetControlRotation");
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

	static AController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AController));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.Controller");
		PlayerState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayerState");
		PlayerState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayerState", Classes.FObjectProperty);
		OnInstigatedAnyDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInstigatedAnyDamage");
		OnInstigatedAnyDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInstigatedAnyDamage", Classes.FMulticastDelegateProperty);
		OnPossessedPawnChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPossessedPawnChanged");
		OnPossessedPawnChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPossessedPawnChanged", Classes.FMulticastDelegateProperty);
		UnPossess_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnPossess");
		UnPossess_ParamsSize = NativeReflection.GetFunctionParamsSize(UnPossess_FunctionAddress);
		UnPossess_IsValid = UnPossess_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:UnPossess", UnPossess_IsValid);
		StopMovement_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopMovement");
		StopMovement_ParamsSize = NativeReflection.GetFunctionParamsSize(StopMovement_FunctionAddress);
		StopMovement_IsValid = StopMovement_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:StopMovement", StopMovement_IsValid);
		SetInitialLocationAndRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInitialLocationAndRotation");
		SetInitialLocationAndRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInitialLocationAndRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInitialLocationAndRotation_NewLocation_PropertyAddress, SetInitialLocationAndRotation_FunctionAddress, "NewLocation");
		SetInitialLocationAndRotation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialLocationAndRotation_FunctionAddress, "NewLocation");
		SetInitialLocationAndRotation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialLocationAndRotation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInitialLocationAndRotation_NewRotation_PropertyAddress, SetInitialLocationAndRotation_FunctionAddress, "NewRotation");
		SetInitialLocationAndRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetInitialLocationAndRotation_FunctionAddress, "NewRotation");
		SetInitialLocationAndRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInitialLocationAndRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		SetInitialLocationAndRotation_IsValid = SetInitialLocationAndRotation_FunctionAddress != IntPtr.Zero && SetInitialLocationAndRotation_NewLocation_IsValid && SetInitialLocationAndRotation_NewRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:SetInitialLocationAndRotation", SetInitialLocationAndRotation_IsValid);
		SetIgnoreMoveInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIgnoreMoveInput");
		SetIgnoreMoveInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIgnoreMoveInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIgnoreMoveInput_bNewMoveInput_PropertyAddress, SetIgnoreMoveInput_FunctionAddress, "bNewMoveInput");
		SetIgnoreMoveInput_bNewMoveInput_Offset = NativeReflectionCached.GetPropertyOffset(SetIgnoreMoveInput_FunctionAddress, "bNewMoveInput");
		SetIgnoreMoveInput_bNewMoveInput_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIgnoreMoveInput_FunctionAddress, "bNewMoveInput", Classes.FBoolProperty);
		SetIgnoreMoveInput_IsValid = SetIgnoreMoveInput_FunctionAddress != IntPtr.Zero && SetIgnoreMoveInput_bNewMoveInput_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:SetIgnoreMoveInput", SetIgnoreMoveInput_IsValid);
		SetIgnoreLookInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIgnoreLookInput");
		SetIgnoreLookInput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIgnoreLookInput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIgnoreLookInput_bNewLookInput_PropertyAddress, SetIgnoreLookInput_FunctionAddress, "bNewLookInput");
		SetIgnoreLookInput_bNewLookInput_Offset = NativeReflectionCached.GetPropertyOffset(SetIgnoreLookInput_FunctionAddress, "bNewLookInput");
		SetIgnoreLookInput_bNewLookInput_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIgnoreLookInput_FunctionAddress, "bNewLookInput", Classes.FBoolProperty);
		SetIgnoreLookInput_IsValid = SetIgnoreLookInput_FunctionAddress != IntPtr.Zero && SetIgnoreLookInput_bNewLookInput_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:SetIgnoreLookInput", SetIgnoreLookInput_IsValid);
		SetControlRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetControlRotation");
		SetControlRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetControlRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetControlRotation_NewRotation_PropertyAddress, SetControlRotation_FunctionAddress, "NewRotation");
		SetControlRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetControlRotation_FunctionAddress, "NewRotation");
		SetControlRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetControlRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		SetControlRotation_IsValid = SetControlRotation_FunctionAddress != IntPtr.Zero && SetControlRotation_NewRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:SetControlRotation", SetControlRotation_IsValid);
		ResetIgnoreMoveInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetIgnoreMoveInput");
		ResetIgnoreMoveInput_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetIgnoreMoveInput_FunctionAddress);
		ResetIgnoreMoveInput_IsValid = ResetIgnoreMoveInput_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:ResetIgnoreMoveInput", ResetIgnoreMoveInput_IsValid);
		ResetIgnoreLookInput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetIgnoreLookInput");
		ResetIgnoreLookInput_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetIgnoreLookInput_FunctionAddress);
		ResetIgnoreLookInput_IsValid = ResetIgnoreLookInput_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:ResetIgnoreLookInput", ResetIgnoreLookInput_IsValid);
		ResetIgnoreInputFlags_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetIgnoreInputFlags");
		ResetIgnoreInputFlags_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetIgnoreInputFlags_FunctionAddress);
		ResetIgnoreInputFlags_IsValid = ResetIgnoreInputFlags_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:ResetIgnoreInputFlags", ResetIgnoreInputFlags_IsValid);
		ReceiveUnPossess_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveUnPossess");
		ReceiveUnPossess_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveUnPossess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveUnPossess_UnpossessedPawn_PropertyAddress, ReceiveUnPossess_FunctionAddress, "UnpossessedPawn");
		ReceiveUnPossess_UnpossessedPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveUnPossess_FunctionAddress, "UnpossessedPawn");
		ReceiveUnPossess_UnpossessedPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveUnPossess_FunctionAddress, "UnpossessedPawn", Classes.FObjectProperty);
		ReceiveUnPossess_IsValid = ReceiveUnPossess_FunctionAddress != IntPtr.Zero && ReceiveUnPossess_UnpossessedPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:ReceiveUnPossess", ReceiveUnPossess_IsValid);
		ReceivePossess_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceivePossess");
		ReceivePossess_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceivePossess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceivePossess_PossessedPawn_PropertyAddress, ReceivePossess_FunctionAddress, "PossessedPawn");
		ReceivePossess_PossessedPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceivePossess_FunctionAddress, "PossessedPawn");
		ReceivePossess_PossessedPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceivePossess_FunctionAddress, "PossessedPawn", Classes.FObjectProperty);
		ReceivePossess_IsValid = ReceivePossess_FunctionAddress != IntPtr.Zero && ReceivePossess_PossessedPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:ReceivePossess", ReceivePossess_IsValid);
		ReceiveInstigatedAnyDamage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveInstigatedAnyDamage");
		ReceiveInstigatedAnyDamage_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveInstigatedAnyDamage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveInstigatedAnyDamage_Damage_PropertyAddress, ReceiveInstigatedAnyDamage_FunctionAddress, "Damage");
		ReceiveInstigatedAnyDamage_Damage_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveInstigatedAnyDamage_FunctionAddress, "Damage");
		ReceiveInstigatedAnyDamage_Damage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveInstigatedAnyDamage_FunctionAddress, "Damage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveInstigatedAnyDamage_DamageType_PropertyAddress, ReceiveInstigatedAnyDamage_FunctionAddress, "DamageType");
		ReceiveInstigatedAnyDamage_DamageType_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveInstigatedAnyDamage_FunctionAddress, "DamageType");
		ReceiveInstigatedAnyDamage_DamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveInstigatedAnyDamage_FunctionAddress, "DamageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveInstigatedAnyDamage_DamagedActor_PropertyAddress, ReceiveInstigatedAnyDamage_FunctionAddress, "DamagedActor");
		ReceiveInstigatedAnyDamage_DamagedActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveInstigatedAnyDamage_FunctionAddress, "DamagedActor");
		ReceiveInstigatedAnyDamage_DamagedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveInstigatedAnyDamage_FunctionAddress, "DamagedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveInstigatedAnyDamage_DamageCauser_PropertyAddress, ReceiveInstigatedAnyDamage_FunctionAddress, "DamageCauser");
		ReceiveInstigatedAnyDamage_DamageCauser_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveInstigatedAnyDamage_FunctionAddress, "DamageCauser");
		ReceiveInstigatedAnyDamage_DamageCauser_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveInstigatedAnyDamage_FunctionAddress, "DamageCauser", Classes.FObjectProperty);
		ReceiveInstigatedAnyDamage_IsValid = ReceiveInstigatedAnyDamage_FunctionAddress != IntPtr.Zero && ReceiveInstigatedAnyDamage_Damage_IsValid && ReceiveInstigatedAnyDamage_DamageType_IsValid && ReceiveInstigatedAnyDamage_DamagedActor_IsValid && ReceiveInstigatedAnyDamage_DamageCauser_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:ReceiveInstigatedAnyDamage", ReceiveInstigatedAnyDamage_IsValid);
		Possess_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Possess");
		Possess_ParamsSize = NativeReflection.GetFunctionParamsSize(Possess_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Possess_InPawn_PropertyAddress, Possess_FunctionAddress, "InPawn");
		Possess_InPawn_Offset = NativeReflectionCached.GetPropertyOffset(Possess_FunctionAddress, "InPawn");
		Possess_InPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(Possess_FunctionAddress, "InPawn", Classes.FObjectProperty);
		Possess_IsValid = Possess_FunctionAddress != IntPtr.Zero && Possess_InPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:Possess", Possess_IsValid);
		LineOfSightTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LineOfSightTo");
		LineOfSightTo_ParamsSize = NativeReflection.GetFunctionParamsSize(LineOfSightTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LineOfSightTo_Other_PropertyAddress, LineOfSightTo_FunctionAddress, "Other");
		LineOfSightTo_Other_Offset = NativeReflectionCached.GetPropertyOffset(LineOfSightTo_FunctionAddress, "Other");
		LineOfSightTo_Other_IsValid = NativeReflectionCached.ValidatePropertyClass(LineOfSightTo_FunctionAddress, "Other", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LineOfSightTo_ViewPoint_PropertyAddress, LineOfSightTo_FunctionAddress, "ViewPoint");
		LineOfSightTo_ViewPoint_Offset = NativeReflectionCached.GetPropertyOffset(LineOfSightTo_FunctionAddress, "ViewPoint");
		LineOfSightTo_ViewPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(LineOfSightTo_FunctionAddress, "ViewPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LineOfSightTo_bAlternateChecks_PropertyAddress, LineOfSightTo_FunctionAddress, "bAlternateChecks");
		LineOfSightTo_bAlternateChecks_Offset = NativeReflectionCached.GetPropertyOffset(LineOfSightTo_FunctionAddress, "bAlternateChecks");
		LineOfSightTo_bAlternateChecks_IsValid = NativeReflectionCached.ValidatePropertyClass(LineOfSightTo_FunctionAddress, "bAlternateChecks", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LineOfSightTo_ReturnValue_PropertyAddress, LineOfSightTo_FunctionAddress, "ReturnValue");
		LineOfSightTo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LineOfSightTo_FunctionAddress, "ReturnValue");
		LineOfSightTo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LineOfSightTo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LineOfSightTo_IsValid = LineOfSightTo_FunctionAddress != IntPtr.Zero && LineOfSightTo_Other_IsValid && LineOfSightTo_ViewPoint_IsValid && LineOfSightTo_bAlternateChecks_IsValid && LineOfSightTo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:LineOfSightTo", LineOfSightTo_IsValid);
		GetControlledPawn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_GetPawn");
		GetControlledPawn_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlledPawn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlledPawn_ReturnValue_PropertyAddress, GetControlledPawn_FunctionAddress, "ReturnValue");
		GetControlledPawn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlledPawn_FunctionAddress, "ReturnValue");
		GetControlledPawn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlledPawn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetControlledPawn_IsValid = GetControlledPawn_FunctionAddress != IntPtr.Zero && GetControlledPawn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:K2_GetPawn", GetControlledPawn_IsValid);
		IsPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayerController");
		IsPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayerController_ReturnValue_PropertyAddress, IsPlayerController_FunctionAddress, "ReturnValue");
		IsPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayerController_FunctionAddress, "ReturnValue");
		IsPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayerController_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayerController_IsValid = IsPlayerController_FunctionAddress != IntPtr.Zero && IsPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:IsPlayerController", IsPlayerController_IsValid);
		IsMoveInputIgnored_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsMoveInputIgnored");
		IsMoveInputIgnored_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMoveInputIgnored_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMoveInputIgnored_ReturnValue_PropertyAddress, IsMoveInputIgnored_FunctionAddress, "ReturnValue");
		IsMoveInputIgnored_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMoveInputIgnored_FunctionAddress, "ReturnValue");
		IsMoveInputIgnored_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMoveInputIgnored_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMoveInputIgnored_IsValid = IsMoveInputIgnored_FunctionAddress != IntPtr.Zero && IsMoveInputIgnored_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:IsMoveInputIgnored", IsMoveInputIgnored_IsValid);
		IsLookInputIgnored_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLookInputIgnored");
		IsLookInputIgnored_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLookInputIgnored_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLookInputIgnored_ReturnValue_PropertyAddress, IsLookInputIgnored_FunctionAddress, "ReturnValue");
		IsLookInputIgnored_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLookInputIgnored_FunctionAddress, "ReturnValue");
		IsLookInputIgnored_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLookInputIgnored_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLookInputIgnored_IsValid = IsLookInputIgnored_FunctionAddress != IntPtr.Zero && IsLookInputIgnored_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:IsLookInputIgnored", IsLookInputIgnored_IsValid);
		IsLocalPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLocalPlayerController");
		IsLocalPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocalPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocalPlayerController_ReturnValue_PropertyAddress, IsLocalPlayerController_FunctionAddress, "ReturnValue");
		IsLocalPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocalPlayerController_FunctionAddress, "ReturnValue");
		IsLocalPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocalPlayerController_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocalPlayerController_IsValid = IsLocalPlayerController_FunctionAddress != IntPtr.Zero && IsLocalPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:IsLocalPlayerController", IsLocalPlayerController_IsValid);
		IsLocalController_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLocalController");
		IsLocalController_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocalController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocalController_ReturnValue_PropertyAddress, IsLocalController_FunctionAddress, "ReturnValue");
		IsLocalController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocalController_FunctionAddress, "ReturnValue");
		IsLocalController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocalController_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocalController_IsValid = IsLocalController_FunctionAddress != IntPtr.Zero && IsLocalController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:IsLocalController", IsLocalController_IsValid);
		GetViewTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewTarget");
		GetViewTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewTarget_ReturnValue_PropertyAddress, GetViewTarget_FunctionAddress, "ReturnValue");
		GetViewTarget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewTarget_FunctionAddress, "ReturnValue");
		GetViewTarget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewTarget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetViewTarget_IsValid = GetViewTarget_FunctionAddress != IntPtr.Zero && GetViewTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:GetViewTarget", GetViewTarget_IsValid);
		GetPlayerViewPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayerViewPoint");
		GetPlayerViewPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerViewPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewPoint_Location_PropertyAddress, GetPlayerViewPoint_FunctionAddress, "Location");
		GetPlayerViewPoint_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewPoint_FunctionAddress, "Location");
		GetPlayerViewPoint_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewPoint_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerViewPoint_Rotation_PropertyAddress, GetPlayerViewPoint_FunctionAddress, "Rotation");
		GetPlayerViewPoint_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerViewPoint_FunctionAddress, "Rotation");
		GetPlayerViewPoint_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerViewPoint_FunctionAddress, "Rotation", Classes.FStructProperty);
		GetPlayerViewPoint_IsValid = GetPlayerViewPoint_FunctionAddress != IntPtr.Zero && GetPlayerViewPoint_Location_IsValid && GetPlayerViewPoint_Rotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:GetPlayerViewPoint", GetPlayerViewPoint_IsValid);
		GetDesiredRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDesiredRotation");
		GetDesiredRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesiredRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesiredRotation_ReturnValue_PropertyAddress, GetDesiredRotation_FunctionAddress, "ReturnValue");
		GetDesiredRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesiredRotation_FunctionAddress, "ReturnValue");
		GetDesiredRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesiredRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDesiredRotation_IsValid = GetDesiredRotation_FunctionAddress != IntPtr.Zero && GetDesiredRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:GetDesiredRotation", GetDesiredRotation_IsValid);
		GetControlRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlRotation");
		GetControlRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlRotation_ReturnValue_PropertyAddress, GetControlRotation_FunctionAddress, "ReturnValue");
		GetControlRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlRotation_FunctionAddress, "ReturnValue");
		GetControlRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetControlRotation_IsValid = GetControlRotation_FunctionAddress != IntPtr.Zero && GetControlRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.Controller:GetControlRotation", GetControlRotation_IsValid);
	}
}
