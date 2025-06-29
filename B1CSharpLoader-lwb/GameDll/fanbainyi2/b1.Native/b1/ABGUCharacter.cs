using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUCharacter", "b1", UnrealModuleType.Game)]
public class ABGUCharacter : ACharacter, IBGUActorI, IInterface, IGenericTeamAgentInterface
{
	private static bool ActorCompContainer_IsValid;

	private static int ActorCompContainer_Offset;

	private static bool BGUDataComp_IsValid;

	private static int BGUDataComp_Offset;

	private static bool EventCollection_IsValid;

	private static int EventCollection_Offset;

	private static bool PreferActorRotToControlRot_IsValid;

	private static FFieldAddress PreferActorRotToControlRot_PropertyAddress;

	private static int PreferActorRotToControlRot_Offset;

	private static bool ViewRotationYawOffset_IsValid;

	private static int ViewRotationYawOffset_Offset;

	private static bool GSNetInitFinish_IsValid;

	private static FFieldAddress GSNetInitFinish_PropertyAddress;

	private static int GSNetInitFinish_Offset;

	private static bool AnimCapsule_IsValid;

	private static int AnimCapsule_Offset;

	private static bool AnimMoveComp_IsValid;

	private static int AnimMoveComp_Offset;

	private static bool BeginPlayFromLevelStreaming_IsValid;

	private static FFieldAddress BeginPlayFromLevelStreaming_PropertyAddress;

	private static int BeginPlayFromLevelStreaming_Offset;

	private static bool AIPerceptionStimuliSourceComponent_IsValid;

	private static int AIPerceptionStimuliSourceComponent_Offset;

	private static bool TeamIDDeprecate_IsValid;

	private static int TeamIDDeprecate_Offset;

	private static bool TryGetHostSyncMontage_IsValid;

	private static IntPtr TryGetHostSyncMontage_FunctionAddress;

	private static int TryGetHostSyncMontage_ParamsSize;

	private static bool TryGetHostSyncMontage_ReturnValue_IsValid;

	private static FFieldAddress TryGetHostSyncMontage_ReturnValue_PropertyAddress;

	private static int TryGetHostSyncMontage_ReturnValue_Offset;

	private static bool TryGetComponentByName_IsValid;

	private static IntPtr TryGetComponentByName_FunctionAddress;

	private static int TryGetComponentByName_ParamsSize;

	private static bool TryGetComponentByName_CompName_IsValid;

	private static FFieldAddress TryGetComponentByName_CompName_PropertyAddress;

	private static int TryGetComponentByName_CompName_Offset;

	private static bool TryGetComponentByName_ReturnValue_IsValid;

	private static FFieldAddress TryGetComponentByName_ReturnValue_PropertyAddress;

	private static int TryGetComponentByName_ReturnValue_Offset;

	private static bool SwitchNetRoleOnly_IsValid;

	private static IntPtr SwitchNetRoleOnly_FunctionAddress;

	private static int SwitchNetRoleOnly_ParamsSize;

	private static bool SwitchNetRoleOnly_HasAuthority_IsValid;

	private static FFieldAddress SwitchNetRoleOnly_HasAuthority_PropertyAddress;

	private static int SwitchNetRoleOnly_HasAuthority_Offset;

	private static bool SetViewRotationYawOffset_IsValid;

	private static IntPtr SetViewRotationYawOffset_FunctionAddress;

	private static int SetViewRotationYawOffset_ParamsSize;

	private static bool SetViewRotationYawOffset_NewOffset_IsValid;

	private static FFieldAddress SetViewRotationYawOffset_NewOffset_PropertyAddress;

	private static int SetViewRotationYawOffset_NewOffset_Offset;

	private static bool SetupPlayerInputComponentCS_IsValid;

	private IntPtr SetupPlayerInputComponentCS_InstanceFunctionAddress;

	private static IntPtr SetupPlayerInputComponentCS_FunctionAddress;

	private static int SetupPlayerInputComponentCS_ParamsSize;

	private static bool SetupPlayerInputComponentCS_PlayerInputComponent_IsValid;

	private static FFieldAddress SetupPlayerInputComponentCS_PlayerInputComponent_PropertyAddress;

	private static int SetupPlayerInputComponentCS_PlayerInputComponent_Offset;

	private static bool SetTeamID_IsValid;

	private static IntPtr SetTeamID_FunctionAddress;

	private static int SetTeamID_ParamsSize;

	private static bool SetTeamID_ID_IsValid;

	private static FFieldAddress SetTeamID_ID_PropertyAddress;

	private static int SetTeamID_ID_Offset;

	private static bool SetTamerOwner_IsValid;

	private static IntPtr SetTamerOwner_FunctionAddress;

	private static int SetTamerOwner_ParamsSize;

	private static bool SetTamerOwner_NewOwner_IsValid;

	private static FFieldAddress SetTamerOwner_NewOwner_PropertyAddress;

	private static int SetTamerOwner_NewOwner_Offset;

	private static bool SetPreferActorRotToControlRot_IsValid;

	private static IntPtr SetPreferActorRotToControlRot_FunctionAddress;

	private static int SetPreferActorRotToControlRot_ParamsSize;

	private static bool SetPreferActorRotToControlRot_bValue_IsValid;

	private static FFieldAddress SetPreferActorRotToControlRot_bValue_PropertyAddress;

	private static int SetPreferActorRotToControlRot_bValue_Offset;

	private static bool PreDestroyFromReplicationCS_IsValid;

	private IntPtr PreDestroyFromReplicationCS_InstanceFunctionAddress;

	private static IntPtr PreDestroyFromReplicationCS_FunctionAddress;

	private static int PreDestroyFromReplicationCS_ParamsSize;

	private static bool PostNetReceiveRoleCS_IsValid;

	private IntPtr PostNetReceiveRoleCS_InstanceFunctionAddress;

	private static IntPtr PostNetReceiveRoleCS_FunctionAddress;

	private static int PostNetReceiveRoleCS_ParamsSize;

	private static bool PostInitializeComponentsCS_IsValid;

	private IntPtr PostInitializeComponentsCS_InstanceFunctionAddress;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool OnRep_PlayerStateCS_IsValid;

	private IntPtr OnRep_PlayerStateCS_InstanceFunctionAddress;

	private static IntPtr OnRep_PlayerStateCS_FunctionAddress;

	private static int OnRep_PlayerStateCS_ParamsSize;

	private static bool OnPossessedCS_IsValid;

	private IntPtr OnPossessedCS_InstanceFunctionAddress;

	private static IntPtr OnPossessedCS_FunctionAddress;

	private static int OnPossessedCS_ParamsSize;

	private static bool OnPossessedCS_NewController_IsValid;

	private static FFieldAddress OnPossessedCS_NewController_PropertyAddress;

	private static int OnPossessedCS_NewController_Offset;

	private static bool OnMovementModeChangedCS_IsValid;

	private IntPtr OnMovementModeChangedCS_InstanceFunctionAddress;

	private static IntPtr OnMovementModeChangedCS_FunctionAddress;

	private static int OnMovementModeChangedCS_ParamsSize;

	private static bool OnMovementModeChangedCS_PrevMovementMode_IsValid;

	private static FFieldAddress OnMovementModeChangedCS_PrevMovementMode_PropertyAddress;

	private static int OnMovementModeChangedCS_PrevMovementMode_Offset;

	private static bool OnMovementModeChangedCS_NewMovementMode_IsValid;

	private static FFieldAddress OnMovementModeChangedCS_NewMovementMode_PropertyAddress;

	private static int OnMovementModeChangedCS_NewMovementMode_Offset;

	private static bool OnMovementModeChangedCS_PrevCustomMode_IsValid;

	private static FFieldAddress OnMovementModeChangedCS_PrevCustomMode_PropertyAddress;

	private static int OnMovementModeChangedCS_PrevCustomMode_Offset;

	private static bool OnMovementModeChangedCS_NewCustomMode_IsValid;

	private static FFieldAddress OnMovementModeChangedCS_NewCustomMode_PropertyAddress;

	private static int OnMovementModeChangedCS_NewCustomMode_Offset;

	private static bool OnGuestSyncMontage_IsValid;

	private static IntPtr OnGuestSyncMontage_FunctionAddress;

	private static int OnGuestSyncMontage_ParamsSize;

	private static bool OnGuestSyncMontage__HostSyncMontage_IsValid;

	private static FFieldAddress OnGuestSyncMontage__HostSyncMontage_PropertyAddress;

	private static int OnGuestSyncMontage__HostSyncMontage_Offset;

	private static bool OnGuestSyncMontage__HostSyncMontageStartTime_IsValid;

	private static FFieldAddress OnGuestSyncMontage__HostSyncMontageStartTime_PropertyAddress;

	private static int OnGuestSyncMontage__HostSyncMontageStartTime_Offset;

	private static bool OnConstructionCS_IsValid;

	private IntPtr OnConstructionCS_InstanceFunctionAddress;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	private static int OnConstructionCS_Transform_Offset;

	private static bool OnActorChannelOpen_IsValid;

	private IntPtr OnActorChannelOpen_InstanceFunctionAddress;

	private static IntPtr OnActorChannelOpen_FunctionAddress;

	private static int OnActorChannelOpen_ParamsSize;

	private static bool OnActorChannelOpen_Connection_IsValid;

	private static FFieldAddress OnActorChannelOpen_Connection_PropertyAddress;

	private static int OnActorChannelOpen_Connection_Offset;

	private static bool LeaveGuestSyncMontage_IsValid;

	private static IntPtr LeaveGuestSyncMontage_FunctionAddress;

	private static int LeaveGuestSyncMontage_ParamsSize;

	private static bool IsPlayerCharacterCS_IsValid;

	private IntPtr IsPlayerCharacterCS_InstanceFunctionAddress;

	private static IntPtr IsPlayerCharacterCS_FunctionAddress;

	private static int IsPlayerCharacterCS_ParamsSize;

	private static bool IsPlayerCharacterCS_ReturnValue_IsValid;

	private static FFieldAddress IsPlayerCharacterCS_ReturnValue_PropertyAddress;

	private static int IsPlayerCharacterCS_ReturnValue_Offset;

	private static bool IsInGuestSyncMontage_IsValid;

	private static IntPtr IsInGuestSyncMontage_FunctionAddress;

	private static int IsInGuestSyncMontage_ParamsSize;

	private static bool IsInGuestSyncMontage_ReturnValue_IsValid;

	private static FFieldAddress IsInGuestSyncMontage_ReturnValue_PropertyAddress;

	private static int IsInGuestSyncMontage_ReturnValue_Offset;

	private static bool GSSwapNetRoleCS_IsValid;

	private static IntPtr GSSwapNetRoleCS_FunctionAddress;

	private static int GSSwapNetRoleCS_ParamsSize;

	private static bool GSSwapNetRoleCS_HasAuthority_IsValid;

	private static FFieldAddress GSSwapNetRoleCS_HasAuthority_PropertyAddress;

	private static int GSSwapNetRoleCS_HasAuthority_Offset;

	private static bool GetViewRotationYawOffset_IsValid;

	private static IntPtr GetViewRotationYawOffset_FunctionAddress;

	private static int GetViewRotationYawOffset_ParamsSize;

	private static bool GetViewRotationYawOffset_ReturnValue_IsValid;

	private static FFieldAddress GetViewRotationYawOffset_ReturnValue_PropertyAddress;

	private static int GetViewRotationYawOffset_ReturnValue_Offset;

	private static bool GetTeamID_IsValid;

	private static IntPtr GetTeamID_FunctionAddress;

	private static int GetTeamID_ParamsSize;

	private static bool GetTeamID_ReturnValue_IsValid;

	private static FFieldAddress GetTeamID_ReturnValue_PropertyAddress;

	private static int GetTeamID_ReturnValue_Offset;

	private static bool GetTamerOwner_IsValid;

	private static IntPtr GetTamerOwner_FunctionAddress;

	private static int GetTamerOwner_ParamsSize;

	private static bool GetTamerOwner_ReturnValue_IsValid;

	private static FFieldAddress GetTamerOwner_ReturnValue_PropertyAddress;

	private static int GetTamerOwner_ReturnValue_Offset;

	private static bool GetHostSyncMontageSyncStartTime_IsValid;

	private static IntPtr GetHostSyncMontageSyncStartTime_FunctionAddress;

	private static int GetHostSyncMontageSyncStartTime_ParamsSize;

	private static bool GetHostSyncMontageSyncStartTime_ReturnValue_IsValid;

	private static FFieldAddress GetHostSyncMontageSyncStartTime_ReturnValue_PropertyAddress;

	private static int GetHostSyncMontageSyncStartTime_ReturnValue_Offset;

	private static bool GetGSAuthorityPlayerCS_IsValid;

	private IntPtr GetGSAuthorityPlayerCS_InstanceFunctionAddress;

	private static IntPtr GetGSAuthorityPlayerCS_FunctionAddress;

	private static int GetGSAuthorityPlayerCS_ParamsSize;

	private static bool GetGSAuthorityPlayerCS_ReturnValue_IsValid;

	private static FFieldAddress GetGSAuthorityPlayerCS_ReturnValue_PropertyAddress;

	private static int GetGSAuthorityPlayerCS_ReturnValue_Offset;

	private static bool GetBUSEventCollection_IsValid;

	private static IntPtr GetBUSEventCollection_FunctionAddress;

	private static int GetBUSEventCollection_ParamsSize;

	private static bool GetBUSEventCollection_ReturnValue_IsValid;

	private static FFieldAddress GetBUSEventCollection_ReturnValue_PropertyAddress;

	private static int GetBUSEventCollection_ReturnValue_Offset;

	private static bool GetActorGuidCS_IsValid;

	private IntPtr GetActorGuidCS_InstanceFunctionAddress;

	private static IntPtr GetActorGuidCS_FunctionAddress;

	private static int GetActorGuidCS_ParamsSize;

	private static bool GetActorGuidCS_OutActorGuid_IsValid;

	private static FFieldAddress GetActorGuidCS_OutActorGuid_PropertyAddress;

	private static int GetActorGuidCS_OutActorGuid_Offset;

	private static bool GetActorGuidCS_ReturnValue_IsValid;

	private static FFieldAddress GetActorGuidCS_ReturnValue_PropertyAddress;

	private static int GetActorGuidCS_ReturnValue_Offset;

	private static bool GetActorGuid_IsValid;

	private static IntPtr GetActorGuid_FunctionAddress;

	private static int GetActorGuid_ParamsSize;

	private static bool GetActorGuid_OutActorGuid_IsValid;

	private static FFieldAddress GetActorGuid_OutActorGuid_PropertyAddress;

	private static int GetActorGuid_OutActorGuid_Offset;

	private static bool GetActorGuid_ReturnValue_IsValid;

	private static FFieldAddress GetActorGuid_ReturnValue_PropertyAddress;

	private static int GetActorGuid_ReturnValue_Offset;

	private static bool FullyInit_IsValid;

	private static IntPtr FullyInit_FunctionAddress;

	private static int FullyInit_ParamsSize;

	private static bool ForceSpawnDefaultControllerCS_IsValid;

	private static IntPtr ForceSpawnDefaultControllerCS_FunctionAddress;

	private static int ForceSpawnDefaultControllerCS_ParamsSize;

	private static bool CallPostNetInit_IsValid;

	private static IntPtr CallPostNetInit_FunctionAddress;

	private static int CallPostNetInit_ParamsSize;

	private static bool AttachBaseActorComp_IsValid;

	private static IntPtr AttachBaseActorComp_FunctionAddress;

	private static int AttachBaseActorComp_ParamsSize;

	private static bool AttachBaseActorComp_Comp_IsValid;

	private static FFieldAddress AttachBaseActorComp_Comp_PropertyAddress;

	private static int AttachBaseActorComp_Comp_Offset;

	[UProperty(Flags = (PropFlags)11267864955200012uL)]
	[UMetaPath("/Script/b1.BGUCharacter:ActorCompContainer")]
	protected UActorCompContainer ActorCompContainer
	{
		get
		{
			CheckDestroyed();
			if (!ActorCompContainer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:ActorCompContainer");
				return null;
			}
			return UObjectMarshaler<UActorCompContainer>.FromNative(IntPtr.Add(base.Address, ActorCompContainer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorCompContainer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:ActorCompContainer");
			}
			else
			{
				UObjectMarshaler<UActorCompContainer>.ToNative(IntPtr.Add(base.Address, ActorCompContainer_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864955200012uL)]
	[UMetaPath("/Script/b1.BGUCharacter:BGUDataComp")]
	protected UBGUDataComp BGUDataComp
	{
		get
		{
			CheckDestroyed();
			if (!BGUDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:BGUDataComp");
				return null;
			}
			return UObjectMarshaler<UBGUDataComp>.FromNative(IntPtr.Add(base.Address, BGUDataComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGUDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:BGUDataComp");
			}
			else
			{
				UObjectMarshaler<UBGUDataComp>.ToNative(IntPtr.Add(base.Address, BGUDataComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864955200012uL)]
	[UMetaPath("/Script/b1.BGUCharacter:EventCollection")]
	protected UBUS_EventCollection EventCollection
	{
		get
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:EventCollection");
				return null;
			}
			return UObjectMarshaler<UBUS_EventCollection>.FromNative(IntPtr.Add(base.Address, EventCollection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventCollection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:EventCollection");
			}
			else
			{
				UObjectMarshaler<UBUS_EventCollection>.ToNative(IntPtr.Add(base.Address, EventCollection_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667524uL)]
	[UMetaPath("/Script/b1.BGUCharacter:bPreferActorRotToControlRot")]
	protected bool PreferActorRotToControlRot
	{
		get
		{
			CheckDestroyed();
			if (!PreferActorRotToControlRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:bPreferActorRotToControlRot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PreferActorRotToControlRot_Offset), 0, PreferActorRotToControlRot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PreferActorRotToControlRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:bPreferActorRotToControlRot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PreferActorRotToControlRot_Offset), 0, PreferActorRotToControlRot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954675716uL)]
	[UMetaPath("/Script/b1.BGUCharacter:ViewRotationYawOffset")]
	protected float ViewRotationYawOffset
	{
		get
		{
			CheckDestroyed();
			if (!ViewRotationYawOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:ViewRotationYawOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ViewRotationYawOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewRotationYawOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:ViewRotationYawOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ViewRotationYawOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/b1.BGUCharacter:GSNetInitFinish")]
	public bool GSNetInitFinish
	{
		get
		{
			CheckDestroyed();
			if (!GSNetInitFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:GSNetInitFinish");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, GSNetInitFinish_Offset), 0, GSNetInitFinish_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GSNetInitFinish_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:GSNetInitFinish");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, GSNetInitFinish_Offset), 0, GSNetInitFinish_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234807324uL)]
	[UMetaPath("/Script/b1.BGUCharacter:AnimCapsule")]
	public UCapsuleComponent AnimCapsule
	{
		get
		{
			CheckDestroyed();
			if (!AnimCapsule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:AnimCapsule");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, AnimCapsule_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimCapsule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:AnimCapsule");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, AnimCapsule_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234807324uL)]
	[UMetaPath("/Script/b1.BGUCharacter:AnimMoveComp")]
	public UBGURootMotionFollowMovementComponent AnimMoveComp
	{
		get
		{
			CheckDestroyed();
			if (!AnimMoveComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:AnimMoveComp");
				return null;
			}
			return UObjectMarshaler<UBGURootMotionFollowMovementComponent>.FromNative(IntPtr.Add(base.Address, AnimMoveComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimMoveComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:AnimMoveComp");
			}
			else
			{
				UObjectMarshaler<UBGURootMotionFollowMovementComponent>.ToNative(IntPtr.Add(base.Address, AnimMoveComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/b1.BGUCharacter:bBeginPlayFromLevelStreaming")]
	public bool BeginPlayFromLevelStreaming
	{
		get
		{
			CheckDestroyed();
			if (!BeginPlayFromLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:bBeginPlayFromLevelStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BeginPlayFromLevelStreaming_Offset), 0, BeginPlayFromLevelStreaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BeginPlayFromLevelStreaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:bBeginPlayFromLevelStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BeginPlayFromLevelStreaming_Offset), 0, BeginPlayFromLevelStreaming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799133uL)]
	[UMetaPath("/Script/b1.BGUCharacter:AIPerceptionStimuliSourceComponent")]
	public UAIPerceptionStimuliSourceComponent AIPerceptionStimuliSourceComponent
	{
		get
		{
			CheckDestroyed();
			if (!AIPerceptionStimuliSourceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:AIPerceptionStimuliSourceComponent");
				return null;
			}
			return UObjectMarshaler<UAIPerceptionStimuliSourceComponent>.FromNative(IntPtr.Add(base.Address, AIPerceptionStimuliSourceComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIPerceptionStimuliSourceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:AIPerceptionStimuliSourceComponent");
			}
			else
			{
				UObjectMarshaler<UAIPerceptionStimuliSourceComponent>.ToNative(IntPtr.Add(base.Address, AIPerceptionStimuliSourceComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BGUCharacter:TeamIDDeprecate")]
	public int TeamIDDeprecate
	{
		get
		{
			CheckDestroyed();
			if (!TeamIDDeprecate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:TeamIDDeprecate");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TeamIDDeprecate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeamIDDeprecate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUCharacter:TeamIDDeprecate");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TeamIDDeprecate_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:TryGetHostSyncMontage")]
	public unsafe UAnimMontage TryGetHostSyncMontage()
	{
		CheckDestroyed();
		if (!TryGetHostSyncMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:TryGetHostSyncMontage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetHostSyncMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetHostSyncMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetHostSyncMontage_FunctionAddress, intPtr, TryGetHostSyncMontage_ParamsSize);
		return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(intPtr, TryGetHostSyncMontage_ReturnValue_Offset), 0, TryGetHostSyncMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/b1.BGUCharacter:TryGetComponentByName")]
	public unsafe UActorComponent TryGetComponentByName(FName CompName)
	{
		CheckDestroyed();
		if (!TryGetComponentByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:TryGetComponentByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TryGetComponentByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TryGetComponentByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, TryGetComponentByName_CompName_Offset), 0, TryGetComponentByName_CompName_PropertyAddress.Address, CompName);
		NativeReflection.InvokeFunctionOptimized(base.Address, TryGetComponentByName_FunctionAddress, intPtr, TryGetComponentByName_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, TryGetComponentByName_ReturnValue_Offset), 0, TryGetComponentByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:SwitchNetRoleOnly")]
	public unsafe void SwitchNetRoleOnly(bool HasAuthority)
	{
		CheckDestroyed();
		if (!SwitchNetRoleOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:SwitchNetRoleOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchNetRoleOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchNetRoleOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwitchNetRoleOnly_HasAuthority_Offset), 0, SwitchNetRoleOnly_HasAuthority_PropertyAddress.Address, HasAuthority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwitchNetRoleOnly_FunctionAddress, intPtr, SwitchNetRoleOnly_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:SetViewRotationYawOffset")]
	public unsafe void SetViewRotationYawOffset(float NewOffset)
	{
		CheckDestroyed();
		if (!SetViewRotationYawOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:SetViewRotationYawOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewRotationYawOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewRotationYawOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewRotationYawOffset_NewOffset_Offset), 0, SetViewRotationYawOffset_NewOffset_PropertyAddress.Address, NewOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewRotationYawOffset_FunctionAddress, intPtr, SetViewRotationYawOffset_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUCharacter:SetupPlayerInputComponentCS")]
	protected unsafe void SetupPlayerInputComponentCS(UInputComponent PlayerInputComponent)
	{
		CheckDestroyed();
		if (!SetupPlayerInputComponentCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:SetupPlayerInputComponentCS");
			return;
		}
		if (SetupPlayerInputComponentCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetupPlayerInputComponentCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetupPlayerInputComponentCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetupPlayerInputComponentCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetupPlayerInputComponentCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputComponent>.ToNative(IntPtr.Add(intPtr, SetupPlayerInputComponentCS_PlayerInputComponent_Offset), 0, SetupPlayerInputComponentCS_PlayerInputComponent_PropertyAddress.Address, PlayerInputComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetupPlayerInputComponentCS_InstanceFunctionAddress, intPtr, SetupPlayerInputComponentCS_ParamsSize);
	}

	protected unsafe virtual void SetupPlayerInputComponentCS_Implementation(UInputComponent PlayerInputComponent)
	{
		CheckDestroyed();
		if (!SetupPlayerInputComponentCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:SetupPlayerInputComponentCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetupPlayerInputComponentCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetupPlayerInputComponentCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputComponent>.ToNative(IntPtr.Add(intPtr, SetupPlayerInputComponentCS_PlayerInputComponent_Offset), 0, SetupPlayerInputComponentCS_PlayerInputComponent_PropertyAddress.Address, PlayerInputComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetupPlayerInputComponentCS_FunctionAddress, intPtr, SetupPlayerInputComponentCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:SetTeamID")]
	public unsafe void SetTeamID(int ID)
	{
		CheckDestroyed();
		if (!SetTeamID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:SetTeamID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTeamID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTeamID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTeamID_ID_Offset), 0, SetTeamID_ID_PropertyAddress.Address, ID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTeamID_FunctionAddress, intPtr, SetTeamID_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/b1.BGUCharacter:SetTamerOwner")]
	public unsafe void SetTamerOwner(ABGUTamerBase NewOwner)
	{
		CheckDestroyed();
		if (!SetTamerOwner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:SetTamerOwner");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTamerOwner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTamerOwner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUTamerBase>.ToNative(IntPtr.Add(intPtr, SetTamerOwner_NewOwner_Offset), 0, SetTamerOwner_NewOwner_PropertyAddress.Address, NewOwner);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTamerOwner_FunctionAddress, intPtr, SetTamerOwner_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:SetPreferActorRotToControlRot")]
	public unsafe void SetPreferActorRotToControlRot(bool bValue)
	{
		CheckDestroyed();
		if (!SetPreferActorRotToControlRot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:SetPreferActorRotToControlRot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreferActorRotToControlRot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreferActorRotToControlRot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPreferActorRotToControlRot_bValue_Offset), 0, SetPreferActorRotToControlRot_bValue_PropertyAddress.Address, bValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPreferActorRotToControlRot_FunctionAddress, intPtr, SetPreferActorRotToControlRot_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUCharacter:PreDestroyFromReplicationCS")]
	protected unsafe void PreDestroyFromReplicationCS()
	{
		CheckDestroyed();
		if (!PreDestroyFromReplicationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:PreDestroyFromReplicationCS");
			return;
		}
		if (PreDestroyFromReplicationCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreDestroyFromReplicationCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreDestroyFromReplicationCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreDestroyFromReplicationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreDestroyFromReplicationCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreDestroyFromReplicationCS_InstanceFunctionAddress, argsSize: PreDestroyFromReplicationCS_ParamsSize);
	}

	protected unsafe virtual void PreDestroyFromReplicationCS_Implementation()
	{
		CheckDestroyed();
		if (!PreDestroyFromReplicationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:PreDestroyFromReplicationCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreDestroyFromReplicationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreDestroyFromReplicationCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreDestroyFromReplicationCS_FunctionAddress, argsSize: PreDestroyFromReplicationCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGUCharacter:PostNetReceiveRoleCS")]
	public unsafe void PostNetReceiveRoleCS()
	{
		CheckDestroyed();
		if (!PostNetReceiveRoleCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:PostNetReceiveRoleCS");
			return;
		}
		if (PostNetReceiveRoleCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostNetReceiveRoleCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostNetReceiveRoleCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostNetReceiveRoleCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostNetReceiveRoleCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostNetReceiveRoleCS_InstanceFunctionAddress, argsSize: PostNetReceiveRoleCS_ParamsSize);
	}

	protected unsafe virtual void PostNetReceiveRoleCS_Implementation()
	{
		CheckDestroyed();
		if (!PostNetReceiveRoleCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:PostNetReceiveRoleCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostNetReceiveRoleCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostNetReceiveRoleCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostNetReceiveRoleCS_FunctionAddress, argsSize: PostNetReceiveRoleCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUCharacter:PostInitializeComponentsCS")]
	protected unsafe void PostInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:PostInitializeComponentsCS");
			return;
		}
		if (PostInitializeComponentsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitializeComponentsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitializeComponentsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_InstanceFunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	protected unsafe virtual void PostInitializeComponentsCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:PostInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_FunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGUCharacter:OnRep_PlayerStateCS")]
	public unsafe void OnRep_PlayerStateCS()
	{
		CheckDestroyed();
		if (!OnRep_PlayerStateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnRep_PlayerStateCS");
			return;
		}
		if (OnRep_PlayerStateCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRep_PlayerStateCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRep_PlayerStateCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRep_PlayerStateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRep_PlayerStateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRep_PlayerStateCS_InstanceFunctionAddress, argsSize: OnRep_PlayerStateCS_ParamsSize);
	}

	protected unsafe virtual void OnRep_PlayerStateCS_Implementation()
	{
		CheckDestroyed();
		if (!OnRep_PlayerStateCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnRep_PlayerStateCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRep_PlayerStateCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRep_PlayerStateCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRep_PlayerStateCS_FunctionAddress, argsSize: OnRep_PlayerStateCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGUCharacter:OnPossessedCS")]
	public unsafe void OnPossessedCS(AController NewController)
	{
		CheckDestroyed();
		if (!OnPossessedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnPossessedCS");
			return;
		}
		if (OnPossessedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPossessedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPossessedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPossessedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPossessedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnPossessedCS_NewController_Offset), 0, OnPossessedCS_NewController_PropertyAddress.Address, NewController);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPossessedCS_InstanceFunctionAddress, intPtr, OnPossessedCS_ParamsSize);
	}

	protected unsafe virtual void OnPossessedCS_Implementation(AController NewController)
	{
		CheckDestroyed();
		if (!OnPossessedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnPossessedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPossessedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPossessedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, OnPossessedCS_NewController_Offset), 0, OnPossessedCS_NewController_PropertyAddress.Address, NewController);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPossessedCS_FunctionAddress, intPtr, OnPossessedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUCharacter:OnMovementModeChangedCS")]
	protected unsafe void OnMovementModeChangedCS(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
	{
		CheckDestroyed();
		if (!OnMovementModeChangedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnMovementModeChangedCS");
			return;
		}
		if (OnMovementModeChangedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnMovementModeChangedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnMovementModeChangedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMovementModeChangedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMovementModeChangedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_PrevMovementMode_Offset), 0, OnMovementModeChangedCS_PrevMovementMode_PropertyAddress.Address, PrevMovementMode);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_NewMovementMode_Offset), 0, OnMovementModeChangedCS_NewMovementMode_PropertyAddress.Address, NewMovementMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_PrevCustomMode_Offset), 0, OnMovementModeChangedCS_PrevCustomMode_PropertyAddress.Address, PrevCustomMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_NewCustomMode_Offset), 0, OnMovementModeChangedCS_NewCustomMode_PropertyAddress.Address, NewCustomMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMovementModeChangedCS_InstanceFunctionAddress, intPtr, OnMovementModeChangedCS_ParamsSize);
	}

	protected unsafe virtual void OnMovementModeChangedCS_Implementation(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
	{
		CheckDestroyed();
		if (!OnMovementModeChangedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnMovementModeChangedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnMovementModeChangedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMovementModeChangedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_PrevMovementMode_Offset), 0, OnMovementModeChangedCS_PrevMovementMode_PropertyAddress.Address, PrevMovementMode);
		EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_NewMovementMode_Offset), 0, OnMovementModeChangedCS_NewMovementMode_PropertyAddress.Address, NewMovementMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_PrevCustomMode_Offset), 0, OnMovementModeChangedCS_PrevCustomMode_PropertyAddress.Address, PrevCustomMode);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, OnMovementModeChangedCS_NewCustomMode_Offset), 0, OnMovementModeChangedCS_NewCustomMode_PropertyAddress.Address, NewCustomMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnMovementModeChangedCS_FunctionAddress, intPtr, OnMovementModeChangedCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:OnGuestSyncMontage")]
	public unsafe void OnGuestSyncMontage(UAnimMontage _HostSyncMontage, float _HostSyncMontageStartTime)
	{
		CheckDestroyed();
		if (!OnGuestSyncMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnGuestSyncMontage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnGuestSyncMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGuestSyncMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, OnGuestSyncMontage__HostSyncMontage_Offset), 0, OnGuestSyncMontage__HostSyncMontage_PropertyAddress.Address, _HostSyncMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnGuestSyncMontage__HostSyncMontageStartTime_Offset), 0, OnGuestSyncMontage__HostSyncMontageStartTime_PropertyAddress.Address, _HostSyncMontageStartTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnGuestSyncMontage_FunctionAddress, intPtr, OnGuestSyncMontage_ParamsSize);
	}

	[UFunction(Flags = 147326976u)]
	[UMetaPath("/Script/b1.BGUCharacter:OnConstructionCS")]
	protected unsafe void OnConstructionCS(FTransform Transform)
	{
		CheckDestroyed();
		if (!OnConstructionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnConstructionCS");
			return;
		}
		if (OnConstructionCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnConstructionCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnConstructionCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnConstructionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnConstructionCS_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnConstructionCS_Transform_Offset), 0, OnConstructionCS_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnConstructionCS_InstanceFunctionAddress, intPtr, OnConstructionCS_ParamsSize);
	}

	protected unsafe virtual void OnConstructionCS_Implementation(FTransform Transform)
	{
		CheckDestroyed();
		if (!OnConstructionCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnConstructionCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnConstructionCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnConstructionCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnConstructionCS_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, OnConstructionCS_Transform_Offset), 0, OnConstructionCS_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnConstructionCS_FunctionAddress, intPtr, OnConstructionCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGUCharacter:OnActorChannelOpen")]
	protected unsafe void OnActorChannelOpen(UNetConnection Connection)
	{
		CheckDestroyed();
		if (!OnActorChannelOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnActorChannelOpen");
			return;
		}
		if (OnActorChannelOpen_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnActorChannelOpen_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnActorChannelOpen");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnActorChannelOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnActorChannelOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNetConnection>.ToNative(IntPtr.Add(intPtr, OnActorChannelOpen_Connection_Offset), 0, OnActorChannelOpen_Connection_PropertyAddress.Address, Connection);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnActorChannelOpen_InstanceFunctionAddress, intPtr, OnActorChannelOpen_ParamsSize);
	}

	protected unsafe virtual void OnActorChannelOpen_Implementation(UNetConnection Connection)
	{
		CheckDestroyed();
		if (!OnActorChannelOpen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:OnActorChannelOpen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnActorChannelOpen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnActorChannelOpen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNetConnection>.ToNative(IntPtr.Add(intPtr, OnActorChannelOpen_Connection_Offset), 0, OnActorChannelOpen_Connection_PropertyAddress.Address, Connection);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnActorChannelOpen_FunctionAddress, intPtr, OnActorChannelOpen_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:LeaveGuestSyncMontage")]
	public unsafe void LeaveGuestSyncMontage()
	{
		CheckDestroyed();
		if (!LeaveGuestSyncMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:LeaveGuestSyncMontage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LeaveGuestSyncMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LeaveGuestSyncMontage_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LeaveGuestSyncMontage_FunctionAddress, argsSize: LeaveGuestSyncMontage_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGUCharacter:IsPlayerCharacterCS")]
	public unsafe bool IsPlayerCharacterCS()
	{
		CheckDestroyed();
		if (!IsPlayerCharacterCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:IsPlayerCharacterCS");
			return false;
		}
		if (IsPlayerCharacterCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsPlayerCharacterCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsPlayerCharacterCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayerCharacterCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayerCharacterCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayerCharacterCS_InstanceFunctionAddress, intPtr, IsPlayerCharacterCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayerCharacterCS_ReturnValue_Offset), 0, IsPlayerCharacterCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsPlayerCharacterCS_Implementation()
	{
		CheckDestroyed();
		if (!IsPlayerCharacterCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:IsPlayerCharacterCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayerCharacterCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayerCharacterCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlayerCharacterCS_FunctionAddress, intPtr, IsPlayerCharacterCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayerCharacterCS_ReturnValue_Offset), 0, IsPlayerCharacterCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:IsInGuestSyncMontage")]
	public unsafe bool IsInGuestSyncMontage()
	{
		CheckDestroyed();
		if (!IsInGuestSyncMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:IsInGuestSyncMontage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInGuestSyncMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInGuestSyncMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInGuestSyncMontage_FunctionAddress, intPtr, IsInGuestSyncMontage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInGuestSyncMontage_ReturnValue_Offset), 0, IsInGuestSyncMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:GSSwapNetRoleCS")]
	public unsafe void GSSwapNetRoleCS(bool HasAuthority)
	{
		CheckDestroyed();
		if (!GSSwapNetRoleCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GSSwapNetRoleCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSSwapNetRoleCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSSwapNetRoleCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GSSwapNetRoleCS_HasAuthority_Offset), 0, GSSwapNetRoleCS_HasAuthority_PropertyAddress.Address, HasAuthority);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSSwapNetRoleCS_FunctionAddress, intPtr, GSSwapNetRoleCS_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetViewRotationYawOffset")]
	public unsafe float GetViewRotationYawOffset()
	{
		CheckDestroyed();
		if (!GetViewRotationYawOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetViewRotationYawOffset");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRotationYawOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRotationYawOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewRotationYawOffset_FunctionAddress, intPtr, GetViewRotationYawOffset_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewRotationYawOffset_ReturnValue_Offset), 0, GetViewRotationYawOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetTeamID")]
	public unsafe int GetTeamID()
	{
		CheckDestroyed();
		if (!GetTeamID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetTeamID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTeamID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTeamID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTeamID_FunctionAddress, intPtr, GetTeamID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTeamID_ReturnValue_Offset), 0, GetTeamID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetTamerOwner")]
	public unsafe ABGUTamerBase GetTamerOwner()
	{
		CheckDestroyed();
		if (!GetTamerOwner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetTamerOwner");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTamerOwner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTamerOwner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTamerOwner_FunctionAddress, intPtr, GetTamerOwner_ParamsSize);
		return UObjectMarshaler<ABGUTamerBase>.FromNative(IntPtr.Add(intPtr, GetTamerOwner_ReturnValue_Offset), 0, GetTamerOwner_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetHostSyncMontageSyncStartTime")]
	public unsafe float GetHostSyncMontageSyncStartTime()
	{
		CheckDestroyed();
		if (!GetHostSyncMontageSyncStartTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetHostSyncMontageSyncStartTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHostSyncMontageSyncStartTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHostSyncMontageSyncStartTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHostSyncMontageSyncStartTime_FunctionAddress, intPtr, GetHostSyncMontageSyncStartTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetHostSyncMontageSyncStartTime_ReturnValue_Offset), 0, GetHostSyncMontageSyncStartTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetGSAuthorityPlayerCS")]
	public unsafe APlayerController GetGSAuthorityPlayerCS()
	{
		CheckDestroyed();
		if (!GetGSAuthorityPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetGSAuthorityPlayerCS");
			return null;
		}
		if (GetGSAuthorityPlayerCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetGSAuthorityPlayerCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetGSAuthorityPlayerCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSAuthorityPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSAuthorityPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGSAuthorityPlayerCS_InstanceFunctionAddress, intPtr, GetGSAuthorityPlayerCS_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetGSAuthorityPlayerCS_ReturnValue_Offset), 0, GetGSAuthorityPlayerCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual APlayerController GetGSAuthorityPlayerCS_Implementation()
	{
		CheckDestroyed();
		if (!GetGSAuthorityPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetGSAuthorityPlayerCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSAuthorityPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSAuthorityPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGSAuthorityPlayerCS_FunctionAddress, intPtr, GetGSAuthorityPlayerCS_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetGSAuthorityPlayerCS_ReturnValue_Offset), 0, GetGSAuthorityPlayerCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetBUSEventCollection")]
	public unsafe UBUS_EventCollection GetBUSEventCollection()
	{
		CheckDestroyed();
		if (!GetBUSEventCollection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetBUSEventCollection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBUSEventCollection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBUSEventCollection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBUSEventCollection_FunctionAddress, intPtr, GetBUSEventCollection_ParamsSize);
		return UObjectMarshaler<UBUS_EventCollection>.FromNative(IntPtr.Add(intPtr, GetBUSEventCollection_ReturnValue_Offset), 0, GetBUSEventCollection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212680192u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetActorGuidCS")]
	protected unsafe bool GetActorGuidCS(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuidCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetActorGuidCS");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		if (GetActorGuidCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetActorGuidCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetActorGuidCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuidCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuidCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuidCS_InstanceFunctionAddress, intPtr, GetActorGuidCS_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_OutActorGuid_Offset), 0, GetActorGuidCS_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorGuidCS_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GetActorGuidCS_Implementation(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuidCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetActorGuidCS");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuidCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuidCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuidCS_FunctionAddress, intPtr, GetActorGuidCS_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_OutActorGuid_Offset), 0, GetActorGuidCS_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorGuidCS_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuidCS_ReturnValue_Offset), 0, GetActorGuidCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/b1.BGUCharacter:GetActorGuid")]
	public unsafe bool GetActorGuid(out string OutActorGuid)
	{
		CheckDestroyed();
		if (!GetActorGuid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:GetActorGuid");
			OutActorGuid = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorGuid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorGuid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActorGuid_FunctionAddress, intPtr, GetActorGuid_ParamsSize);
		OutActorGuid = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_OutActorGuid_Offset), 0, GetActorGuid_OutActorGuid_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorGuid_OutActorGuid_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetActorGuid_ReturnValue_Offset), 0, GetActorGuid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:FullyInit")]
	public unsafe void FullyInit()
	{
		CheckDestroyed();
		if (!FullyInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:FullyInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FullyInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FullyInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FullyInit_FunctionAddress, argsSize: FullyInit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:ForceSpawnDefaultControllerCS")]
	public unsafe void ForceSpawnDefaultControllerCS()
	{
		CheckDestroyed();
		if (!ForceSpawnDefaultControllerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:ForceSpawnDefaultControllerCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceSpawnDefaultControllerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceSpawnDefaultControllerCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceSpawnDefaultControllerCS_FunctionAddress, argsSize: ForceSpawnDefaultControllerCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUCharacter:CallPostNetInit")]
	public unsafe void CallPostNetInit()
	{
		CheckDestroyed();
		if (!CallPostNetInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:CallPostNetInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CallPostNetInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CallPostNetInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CallPostNetInit_FunctionAddress, argsSize: CallPostNetInit_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.BGUCharacter:AttachBaseActorComp")]
	protected unsafe void AttachBaseActorComp(UBaseActorComp Comp)
	{
		CheckDestroyed();
		if (!AttachBaseActorComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUCharacter:AttachBaseActorComp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AttachBaseActorComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AttachBaseActorComp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBaseActorComp>.ToNative(IntPtr.Add(intPtr, AttachBaseActorComp_Comp_Offset), 0, AttachBaseActorComp_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeFunctionOptimized(base.Address, AttachBaseActorComp_FunctionAddress, intPtr, AttachBaseActorComp_ParamsSize);
	}

	static ABGUCharacter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUCharacter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUCharacter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGUCharacter");
		ActorCompContainer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorCompContainer");
		ActorCompContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorCompContainer", Classes.FObjectProperty);
		BGUDataComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BGUDataComp");
		BGUDataComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BGUDataComp", Classes.FObjectProperty);
		EventCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EventCollection");
		EventCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EventCollection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PreferActorRotToControlRot_PropertyAddress, intPtr, "bPreferActorRotToControlRot");
		PreferActorRotToControlRot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPreferActorRotToControlRot");
		PreferActorRotToControlRot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPreferActorRotToControlRot", Classes.FBoolProperty);
		ViewRotationYawOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewRotationYawOffset");
		ViewRotationYawOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewRotationYawOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNetInitFinish_PropertyAddress, intPtr, "GSNetInitFinish");
		GSNetInitFinish_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSNetInitFinish");
		GSNetInitFinish_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSNetInitFinish", Classes.FBoolProperty);
		AnimCapsule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimCapsule");
		AnimCapsule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimCapsule", Classes.FObjectProperty);
		AnimMoveComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimMoveComp");
		AnimMoveComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimMoveComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BeginPlayFromLevelStreaming_PropertyAddress, intPtr, "bBeginPlayFromLevelStreaming");
		BeginPlayFromLevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBeginPlayFromLevelStreaming");
		BeginPlayFromLevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBeginPlayFromLevelStreaming", Classes.FBoolProperty);
		AIPerceptionStimuliSourceComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AIPerceptionStimuliSourceComponent");
		AIPerceptionStimuliSourceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AIPerceptionStimuliSourceComponent", Classes.FObjectProperty);
		TeamIDDeprecate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeamIDDeprecate");
		TeamIDDeprecate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeamIDDeprecate", Classes.FIntProperty);
		TryGetHostSyncMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryGetHostSyncMontage");
		TryGetHostSyncMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetHostSyncMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetHostSyncMontage_ReturnValue_PropertyAddress, TryGetHostSyncMontage_FunctionAddress, "ReturnValue");
		TryGetHostSyncMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetHostSyncMontage_FunctionAddress, "ReturnValue");
		TryGetHostSyncMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetHostSyncMontage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TryGetHostSyncMontage_IsValid = TryGetHostSyncMontage_FunctionAddress != IntPtr.Zero && TryGetHostSyncMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:TryGetHostSyncMontage", TryGetHostSyncMontage_IsValid);
		TryGetComponentByName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryGetComponentByName");
		TryGetComponentByName_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetComponentByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TryGetComponentByName_CompName_PropertyAddress, TryGetComponentByName_FunctionAddress, "CompName");
		TryGetComponentByName_CompName_Offset = NativeReflectionCached.GetPropertyOffset(TryGetComponentByName_FunctionAddress, "CompName");
		TryGetComponentByName_CompName_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetComponentByName_FunctionAddress, "CompName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref TryGetComponentByName_ReturnValue_PropertyAddress, TryGetComponentByName_FunctionAddress, "ReturnValue");
		TryGetComponentByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TryGetComponentByName_FunctionAddress, "ReturnValue");
		TryGetComponentByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TryGetComponentByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TryGetComponentByName_IsValid = TryGetComponentByName_FunctionAddress != IntPtr.Zero && TryGetComponentByName_CompName_IsValid && TryGetComponentByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:TryGetComponentByName", TryGetComponentByName_IsValid);
		SwitchNetRoleOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwitchNetRoleOnly");
		SwitchNetRoleOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchNetRoleOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwitchNetRoleOnly_HasAuthority_PropertyAddress, SwitchNetRoleOnly_FunctionAddress, "HasAuthority");
		SwitchNetRoleOnly_HasAuthority_Offset = NativeReflectionCached.GetPropertyOffset(SwitchNetRoleOnly_FunctionAddress, "HasAuthority");
		SwitchNetRoleOnly_HasAuthority_IsValid = NativeReflectionCached.ValidatePropertyClass(SwitchNetRoleOnly_FunctionAddress, "HasAuthority", Classes.FBoolProperty);
		SwitchNetRoleOnly_IsValid = SwitchNetRoleOnly_FunctionAddress != IntPtr.Zero && SwitchNetRoleOnly_HasAuthority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:SwitchNetRoleOnly", SwitchNetRoleOnly_IsValid);
		SetViewRotationYawOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewRotationYawOffset");
		SetViewRotationYawOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewRotationYawOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewRotationYawOffset_NewOffset_PropertyAddress, SetViewRotationYawOffset_FunctionAddress, "NewOffset");
		SetViewRotationYawOffset_NewOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRotationYawOffset_FunctionAddress, "NewOffset");
		SetViewRotationYawOffset_NewOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRotationYawOffset_FunctionAddress, "NewOffset", Classes.FFloatProperty);
		SetViewRotationYawOffset_IsValid = SetViewRotationYawOffset_FunctionAddress != IntPtr.Zero && SetViewRotationYawOffset_NewOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:SetViewRotationYawOffset", SetViewRotationYawOffset_IsValid);
		SetupPlayerInputComponentCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupPlayerInputComponentCS");
		SetupPlayerInputComponentCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupPlayerInputComponentCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetupPlayerInputComponentCS_PlayerInputComponent_PropertyAddress, SetupPlayerInputComponentCS_FunctionAddress, "PlayerInputComponent");
		SetupPlayerInputComponentCS_PlayerInputComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetupPlayerInputComponentCS_FunctionAddress, "PlayerInputComponent");
		SetupPlayerInputComponentCS_PlayerInputComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetupPlayerInputComponentCS_FunctionAddress, "PlayerInputComponent", Classes.FObjectProperty);
		SetupPlayerInputComponentCS_IsValid = SetupPlayerInputComponentCS_FunctionAddress != IntPtr.Zero && SetupPlayerInputComponentCS_PlayerInputComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:SetupPlayerInputComponentCS", SetupPlayerInputComponentCS_IsValid);
		SetTeamID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTeamID");
		SetTeamID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTeamID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTeamID_ID_PropertyAddress, SetTeamID_FunctionAddress, "ID");
		SetTeamID_ID_Offset = NativeReflectionCached.GetPropertyOffset(SetTeamID_FunctionAddress, "ID");
		SetTeamID_ID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTeamID_FunctionAddress, "ID", Classes.FIntProperty);
		SetTeamID_IsValid = SetTeamID_FunctionAddress != IntPtr.Zero && SetTeamID_ID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:SetTeamID", SetTeamID_IsValid);
		SetTamerOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTamerOwner");
		SetTamerOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTamerOwner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTamerOwner_NewOwner_PropertyAddress, SetTamerOwner_FunctionAddress, "NewOwner");
		SetTamerOwner_NewOwner_Offset = NativeReflectionCached.GetPropertyOffset(SetTamerOwner_FunctionAddress, "NewOwner");
		SetTamerOwner_NewOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTamerOwner_FunctionAddress, "NewOwner", Classes.FObjectProperty);
		SetTamerOwner_IsValid = SetTamerOwner_FunctionAddress != IntPtr.Zero && SetTamerOwner_NewOwner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:SetTamerOwner", SetTamerOwner_IsValid);
		SetPreferActorRotToControlRot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPreferActorRotToControlRot");
		SetPreferActorRotToControlRot_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreferActorRotToControlRot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreferActorRotToControlRot_bValue_PropertyAddress, SetPreferActorRotToControlRot_FunctionAddress, "bValue");
		SetPreferActorRotToControlRot_bValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPreferActorRotToControlRot_FunctionAddress, "bValue");
		SetPreferActorRotToControlRot_bValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreferActorRotToControlRot_FunctionAddress, "bValue", Classes.FBoolProperty);
		SetPreferActorRotToControlRot_IsValid = SetPreferActorRotToControlRot_FunctionAddress != IntPtr.Zero && SetPreferActorRotToControlRot_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:SetPreferActorRotToControlRot", SetPreferActorRotToControlRot_IsValid);
		PreDestroyFromReplicationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreDestroyFromReplicationCS");
		PreDestroyFromReplicationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PreDestroyFromReplicationCS_FunctionAddress);
		PreDestroyFromReplicationCS_IsValid = PreDestroyFromReplicationCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:PreDestroyFromReplicationCS", PreDestroyFromReplicationCS_IsValid);
		PostNetReceiveRoleCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostNetReceiveRoleCS");
		PostNetReceiveRoleCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostNetReceiveRoleCS_FunctionAddress);
		PostNetReceiveRoleCS_IsValid = PostNetReceiveRoleCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:PostNetReceiveRoleCS", PostNetReceiveRoleCS_IsValid);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		OnRep_PlayerStateCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRep_PlayerStateCS");
		OnRep_PlayerStateCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRep_PlayerStateCS_FunctionAddress);
		OnRep_PlayerStateCS_IsValid = OnRep_PlayerStateCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:OnRep_PlayerStateCS", OnRep_PlayerStateCS_IsValid);
		OnPossessedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPossessedCS");
		OnPossessedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPossessedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPossessedCS_NewController_PropertyAddress, OnPossessedCS_FunctionAddress, "NewController");
		OnPossessedCS_NewController_Offset = NativeReflectionCached.GetPropertyOffset(OnPossessedCS_FunctionAddress, "NewController");
		OnPossessedCS_NewController_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPossessedCS_FunctionAddress, "NewController", Classes.FObjectProperty);
		OnPossessedCS_IsValid = OnPossessedCS_FunctionAddress != IntPtr.Zero && OnPossessedCS_NewController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:OnPossessedCS", OnPossessedCS_IsValid);
		OnMovementModeChangedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMovementModeChangedCS");
		OnMovementModeChangedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMovementModeChangedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChangedCS_PrevMovementMode_PropertyAddress, OnMovementModeChangedCS_FunctionAddress, "PrevMovementMode");
		OnMovementModeChangedCS_PrevMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "PrevMovementMode");
		OnMovementModeChangedCS_PrevMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "PrevMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChangedCS_NewMovementMode_PropertyAddress, OnMovementModeChangedCS_FunctionAddress, "NewMovementMode");
		OnMovementModeChangedCS_NewMovementMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "NewMovementMode");
		OnMovementModeChangedCS_NewMovementMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "NewMovementMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChangedCS_PrevCustomMode_PropertyAddress, OnMovementModeChangedCS_FunctionAddress, "PrevCustomMode");
		OnMovementModeChangedCS_PrevCustomMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "PrevCustomMode");
		OnMovementModeChangedCS_PrevCustomMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "PrevCustomMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMovementModeChangedCS_NewCustomMode_PropertyAddress, OnMovementModeChangedCS_FunctionAddress, "NewCustomMode");
		OnMovementModeChangedCS_NewCustomMode_Offset = NativeReflectionCached.GetPropertyOffset(OnMovementModeChangedCS_FunctionAddress, "NewCustomMode");
		OnMovementModeChangedCS_NewCustomMode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMovementModeChangedCS_FunctionAddress, "NewCustomMode", Classes.FByteProperty);
		OnMovementModeChangedCS_IsValid = OnMovementModeChangedCS_FunctionAddress != IntPtr.Zero && OnMovementModeChangedCS_PrevMovementMode_IsValid && OnMovementModeChangedCS_NewMovementMode_IsValid && OnMovementModeChangedCS_PrevCustomMode_IsValid && OnMovementModeChangedCS_NewCustomMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:OnMovementModeChangedCS", OnMovementModeChangedCS_IsValid);
		OnGuestSyncMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnGuestSyncMontage");
		OnGuestSyncMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGuestSyncMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnGuestSyncMontage__HostSyncMontage_PropertyAddress, OnGuestSyncMontage_FunctionAddress, "_HostSyncMontage");
		OnGuestSyncMontage__HostSyncMontage_Offset = NativeReflectionCached.GetPropertyOffset(OnGuestSyncMontage_FunctionAddress, "_HostSyncMontage");
		OnGuestSyncMontage__HostSyncMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGuestSyncMontage_FunctionAddress, "_HostSyncMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnGuestSyncMontage__HostSyncMontageStartTime_PropertyAddress, OnGuestSyncMontage_FunctionAddress, "_HostSyncMontageStartTime");
		OnGuestSyncMontage__HostSyncMontageStartTime_Offset = NativeReflectionCached.GetPropertyOffset(OnGuestSyncMontage_FunctionAddress, "_HostSyncMontageStartTime");
		OnGuestSyncMontage__HostSyncMontageStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGuestSyncMontage_FunctionAddress, "_HostSyncMontageStartTime", Classes.FFloatProperty);
		OnGuestSyncMontage_IsValid = OnGuestSyncMontage_FunctionAddress != IntPtr.Zero && OnGuestSyncMontage__HostSyncMontage_IsValid && OnGuestSyncMontage__HostSyncMontageStartTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:OnGuestSyncMontage", OnGuestSyncMontage_IsValid);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflectionCached.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:OnConstructionCS", OnConstructionCS_IsValid);
		OnActorChannelOpen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnActorChannelOpen");
		OnActorChannelOpen_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorChannelOpen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnActorChannelOpen_Connection_PropertyAddress, OnActorChannelOpen_FunctionAddress, "Connection");
		OnActorChannelOpen_Connection_Offset = NativeReflectionCached.GetPropertyOffset(OnActorChannelOpen_FunctionAddress, "Connection");
		OnActorChannelOpen_Connection_IsValid = NativeReflectionCached.ValidatePropertyClass(OnActorChannelOpen_FunctionAddress, "Connection", Classes.FObjectProperty);
		OnActorChannelOpen_IsValid = OnActorChannelOpen_FunctionAddress != IntPtr.Zero && OnActorChannelOpen_Connection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:OnActorChannelOpen", OnActorChannelOpen_IsValid);
		LeaveGuestSyncMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LeaveGuestSyncMontage");
		LeaveGuestSyncMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(LeaveGuestSyncMontage_FunctionAddress);
		LeaveGuestSyncMontage_IsValid = LeaveGuestSyncMontage_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:LeaveGuestSyncMontage", LeaveGuestSyncMontage_IsValid);
		IsPlayerCharacterCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlayerCharacterCS");
		IsPlayerCharacterCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayerCharacterCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayerCharacterCS_ReturnValue_PropertyAddress, IsPlayerCharacterCS_FunctionAddress, "ReturnValue");
		IsPlayerCharacterCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayerCharacterCS_FunctionAddress, "ReturnValue");
		IsPlayerCharacterCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayerCharacterCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayerCharacterCS_IsValid = IsPlayerCharacterCS_FunctionAddress != IntPtr.Zero && IsPlayerCharacterCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:IsPlayerCharacterCS", IsPlayerCharacterCS_IsValid);
		IsInGuestSyncMontage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInGuestSyncMontage");
		IsInGuestSyncMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInGuestSyncMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInGuestSyncMontage_ReturnValue_PropertyAddress, IsInGuestSyncMontage_FunctionAddress, "ReturnValue");
		IsInGuestSyncMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInGuestSyncMontage_FunctionAddress, "ReturnValue");
		IsInGuestSyncMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInGuestSyncMontage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInGuestSyncMontage_IsValid = IsInGuestSyncMontage_FunctionAddress != IntPtr.Zero && IsInGuestSyncMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:IsInGuestSyncMontage", IsInGuestSyncMontage_IsValid);
		GSSwapNetRoleCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSSwapNetRoleCS");
		GSSwapNetRoleCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSSwapNetRoleCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSSwapNetRoleCS_HasAuthority_PropertyAddress, GSSwapNetRoleCS_FunctionAddress, "HasAuthority");
		GSSwapNetRoleCS_HasAuthority_Offset = NativeReflectionCached.GetPropertyOffset(GSSwapNetRoleCS_FunctionAddress, "HasAuthority");
		GSSwapNetRoleCS_HasAuthority_IsValid = NativeReflectionCached.ValidatePropertyClass(GSSwapNetRoleCS_FunctionAddress, "HasAuthority", Classes.FBoolProperty);
		GSSwapNetRoleCS_IsValid = GSSwapNetRoleCS_FunctionAddress != IntPtr.Zero && GSSwapNetRoleCS_HasAuthority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GSSwapNetRoleCS", GSSwapNetRoleCS_IsValid);
		GetViewRotationYawOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewRotationYawOffset");
		GetViewRotationYawOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRotationYawOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRotationYawOffset_ReturnValue_PropertyAddress, GetViewRotationYawOffset_FunctionAddress, "ReturnValue");
		GetViewRotationYawOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRotationYawOffset_FunctionAddress, "ReturnValue");
		GetViewRotationYawOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRotationYawOffset_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewRotationYawOffset_IsValid = GetViewRotationYawOffset_FunctionAddress != IntPtr.Zero && GetViewRotationYawOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetViewRotationYawOffset", GetViewRotationYawOffset_IsValid);
		GetTeamID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTeamID");
		GetTeamID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTeamID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTeamID_ReturnValue_PropertyAddress, GetTeamID_FunctionAddress, "ReturnValue");
		GetTeamID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTeamID_FunctionAddress, "ReturnValue");
		GetTeamID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTeamID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTeamID_IsValid = GetTeamID_FunctionAddress != IntPtr.Zero && GetTeamID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetTeamID", GetTeamID_IsValid);
		GetTamerOwner_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTamerOwner");
		GetTamerOwner_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTamerOwner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTamerOwner_ReturnValue_PropertyAddress, GetTamerOwner_FunctionAddress, "ReturnValue");
		GetTamerOwner_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTamerOwner_FunctionAddress, "ReturnValue");
		GetTamerOwner_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTamerOwner_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTamerOwner_IsValid = GetTamerOwner_FunctionAddress != IntPtr.Zero && GetTamerOwner_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetTamerOwner", GetTamerOwner_IsValid);
		GetHostSyncMontageSyncStartTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetHostSyncMontageSyncStartTime");
		GetHostSyncMontageSyncStartTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHostSyncMontageSyncStartTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHostSyncMontageSyncStartTime_ReturnValue_PropertyAddress, GetHostSyncMontageSyncStartTime_FunctionAddress, "ReturnValue");
		GetHostSyncMontageSyncStartTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHostSyncMontageSyncStartTime_FunctionAddress, "ReturnValue");
		GetHostSyncMontageSyncStartTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHostSyncMontageSyncStartTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetHostSyncMontageSyncStartTime_IsValid = GetHostSyncMontageSyncStartTime_FunctionAddress != IntPtr.Zero && GetHostSyncMontageSyncStartTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetHostSyncMontageSyncStartTime", GetHostSyncMontageSyncStartTime_IsValid);
		GetGSAuthorityPlayerCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGSAuthorityPlayerCS");
		GetGSAuthorityPlayerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSAuthorityPlayerCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGSAuthorityPlayerCS_ReturnValue_PropertyAddress, GetGSAuthorityPlayerCS_FunctionAddress, "ReturnValue");
		GetGSAuthorityPlayerCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGSAuthorityPlayerCS_FunctionAddress, "ReturnValue");
		GetGSAuthorityPlayerCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSAuthorityPlayerCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGSAuthorityPlayerCS_IsValid = GetGSAuthorityPlayerCS_FunctionAddress != IntPtr.Zero && GetGSAuthorityPlayerCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetGSAuthorityPlayerCS", GetGSAuthorityPlayerCS_IsValid);
		GetBUSEventCollection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBUSEventCollection");
		GetBUSEventCollection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBUSEventCollection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBUSEventCollection_ReturnValue_PropertyAddress, GetBUSEventCollection_FunctionAddress, "ReturnValue");
		GetBUSEventCollection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBUSEventCollection_FunctionAddress, "ReturnValue");
		GetBUSEventCollection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBUSEventCollection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBUSEventCollection_IsValid = GetBUSEventCollection_FunctionAddress != IntPtr.Zero && GetBUSEventCollection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetBUSEventCollection", GetBUSEventCollection_IsValid);
		GetActorGuidCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuidCS");
		GetActorGuidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuidCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidCS_OutActorGuid_PropertyAddress, GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "OutActorGuid");
		GetActorGuidCS_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuidCS_ReturnValue_PropertyAddress, GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuidCS_FunctionAddress, "ReturnValue");
		GetActorGuidCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuidCS_IsValid = GetActorGuidCS_FunctionAddress != IntPtr.Zero && GetActorGuidCS_OutActorGuid_IsValid && GetActorGuidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetActorGuidCS", GetActorGuidCS_IsValid);
		GetActorGuid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetActorGuid");
		GetActorGuid_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorGuid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_OutActorGuid_PropertyAddress, GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "OutActorGuid");
		GetActorGuid_OutActorGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "OutActorGuid", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorGuid_ReturnValue_PropertyAddress, GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorGuid_FunctionAddress, "ReturnValue");
		GetActorGuid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorGuid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetActorGuid_IsValid = GetActorGuid_FunctionAddress != IntPtr.Zero && GetActorGuid_OutActorGuid_IsValid && GetActorGuid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:GetActorGuid", GetActorGuid_IsValid);
		FullyInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FullyInit");
		FullyInit_ParamsSize = NativeReflection.GetFunctionParamsSize(FullyInit_FunctionAddress);
		FullyInit_IsValid = FullyInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:FullyInit", FullyInit_IsValid);
		ForceSpawnDefaultControllerCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceSpawnDefaultControllerCS");
		ForceSpawnDefaultControllerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceSpawnDefaultControllerCS_FunctionAddress);
		ForceSpawnDefaultControllerCS_IsValid = ForceSpawnDefaultControllerCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:ForceSpawnDefaultControllerCS", ForceSpawnDefaultControllerCS_IsValid);
		CallPostNetInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CallPostNetInit");
		CallPostNetInit_ParamsSize = NativeReflection.GetFunctionParamsSize(CallPostNetInit_FunctionAddress);
		CallPostNetInit_IsValid = CallPostNetInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:CallPostNetInit", CallPostNetInit_IsValid);
		AttachBaseActorComp_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AttachBaseActorComp");
		AttachBaseActorComp_ParamsSize = NativeReflection.GetFunctionParamsSize(AttachBaseActorComp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AttachBaseActorComp_Comp_PropertyAddress, AttachBaseActorComp_FunctionAddress, "Comp");
		AttachBaseActorComp_Comp_Offset = NativeReflectionCached.GetPropertyOffset(AttachBaseActorComp_FunctionAddress, "Comp");
		AttachBaseActorComp_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(AttachBaseActorComp_FunctionAddress, "Comp", Classes.FObjectProperty);
		AttachBaseActorComp_IsValid = AttachBaseActorComp_FunctionAddress != IntPtr.Zero && AttachBaseActorComp_Comp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUCharacter:AttachBaseActorComp", AttachBaseActorComp_IsValid);
	}
}
