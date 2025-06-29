using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809578656uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotifyState_GSBase", "b1", UnrealModuleType.Game)]
public class UAnimNotifyState_GSBase : UAnimNotifyState
{
	private static bool AnimNSType_IsValid;

	private static FFieldAddress AnimNSType_PropertyAddress;

	private static int AnimNSType_Offset;

	private static bool CanTriggerEndByCrossMontageBegin_IsValid;

	private static FFieldAddress CanTriggerEndByCrossMontageBegin_PropertyAddress;

	private static int CanTriggerEndByCrossMontageBegin_Offset;

	private static bool IsCheckAnimInstance_IsValid;

	private static FFieldAddress IsCheckAnimInstance_PropertyAddress;

	private static int IsCheckAnimInstance_Offset;

	private static bool CanBePlacedInASCS_IsValid;

	private static FFieldAddress CanBePlacedInASCS_PropertyAddress;

	private static int CanBePlacedInASCS_Offset;

	private static bool CanUseQueuedType_IsValid;

	private static FFieldAddress CanUseQueuedType_PropertyAddress;

	private static int CanUseQueuedType_Offset;

	private static bool isPreload_IsValid;

	private static FFieldAddress isPreload_PropertyAddress;

	private static int isPreload_Offset;

	private static bool NotifyStateNameForShow_IsValid;

	private static int NotifyStateNameForShow_Offset;

	private static bool UpdateDataOnNotifyStateReplace_IsValid;

	private IntPtr UpdateDataOnNotifyStateReplace_InstanceFunctionAddress;

	private static IntPtr UpdateDataOnNotifyStateReplace_FunctionAddress;

	private static int UpdateDataOnNotifyStateReplace_ParamsSize;

	private static bool UpdateDataOnNotifyStateReplace_NewNotifyState_IsValid;

	private static FFieldAddress UpdateDataOnNotifyStateReplace_NewNotifyState_PropertyAddress;

	private static int UpdateDataOnNotifyStateReplace_NewNotifyState_Offset;

	private static bool GSValidateInputCS_IsValid;

	private IntPtr GSValidateInputCS_InstanceFunctionAddress;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static FFieldAddress GSValidateInputCS_actor_PropertyAddress;

	private static int GSValidateInputCS_actor_Offset;

	private static bool GSOnSectionManuallyChanged_IsValid;

	private IntPtr GSOnSectionManuallyChanged_InstanceFunctionAddress;

	private static IntPtr GSOnSectionManuallyChanged_FunctionAddress;

	private static int GSOnSectionManuallyChanged_ParamsSize;

	private static bool GSOnSectionManuallyChanged_OwnerChar_IsValid;

	private static FFieldAddress GSOnSectionManuallyChanged_OwnerChar_PropertyAddress;

	private static int GSOnSectionManuallyChanged_OwnerChar_Offset;

	private static bool GSOnSectionManuallyChanged_RemainingDuration_IsValid;

	private static FFieldAddress GSOnSectionManuallyChanged_RemainingDuration_PropertyAddress;

	private static int GSOnSectionManuallyChanged_RemainingDuration_Offset;

	private static bool GSNotifyTickCS_IsValid;

	private IntPtr GSNotifyTickCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static FFieldAddress GSNotifyTickCS_FrameDeltaTime_PropertyAddress;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private IntPtr GSNotifyEndCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static bool GSNotifyDebugPreTickCS_IsValid;

	private IntPtr GSNotifyDebugPreTickCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyDebugPreTickCS_FunctionAddress;

	private static int GSNotifyDebugPreTickCS_ParamsSize;

	private static bool GSNotifyDebugPreTickCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyDebugPreTickCS_NotifyParam_PropertyAddress;

	private static int GSNotifyDebugPreTickCS_NotifyParam_Offset;

	private static bool GSNotifyDebugPreTickCS_ReturnValue_IsValid;

	private static FFieldAddress GSNotifyDebugPreTickCS_ReturnValue_PropertyAddress;

	private static int GSNotifyDebugPreTickCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPreEndCS_IsValid;

	private IntPtr GSNotifyDebugPreEndCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyDebugPreEndCS_FunctionAddress;

	private static int GSNotifyDebugPreEndCS_ParamsSize;

	private static bool GSNotifyDebugPreEndCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyDebugPreEndCS_NotifyParam_PropertyAddress;

	private static int GSNotifyDebugPreEndCS_NotifyParam_Offset;

	private static bool GSNotifyDebugPreEndCS_ReturnValue_IsValid;

	private static FFieldAddress GSNotifyDebugPreEndCS_ReturnValue_PropertyAddress;

	private static int GSNotifyDebugPreEndCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPreBeginCS_IsValid;

	private IntPtr GSNotifyDebugPreBeginCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyDebugPreBeginCS_FunctionAddress;

	private static int GSNotifyDebugPreBeginCS_ParamsSize;

	private static bool GSNotifyDebugPreBeginCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyDebugPreBeginCS_NotifyParam_PropertyAddress;

	private static int GSNotifyDebugPreBeginCS_NotifyParam_Offset;

	private static bool GSNotifyDebugPreBeginCS_ReturnValue_IsValid;

	private static FFieldAddress GSNotifyDebugPreBeginCS_ReturnValue_PropertyAddress;

	private static int GSNotifyDebugPreBeginCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPostTickCS_IsValid;

	private IntPtr GSNotifyDebugPostTickCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyDebugPostTickCS_FunctionAddress;

	private static int GSNotifyDebugPostTickCS_ParamsSize;

	private static bool GSNotifyDebugPostTickCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyDebugPostTickCS_NotifyParam_PropertyAddress;

	private static int GSNotifyDebugPostTickCS_NotifyParam_Offset;

	private static bool GSNotifyDebugPostTickCS_ReturnValue_IsValid;

	private static FFieldAddress GSNotifyDebugPostTickCS_ReturnValue_PropertyAddress;

	private static int GSNotifyDebugPostTickCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPostEndCS_IsValid;

	private IntPtr GSNotifyDebugPostEndCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyDebugPostEndCS_FunctionAddress;

	private static int GSNotifyDebugPostEndCS_ParamsSize;

	private static bool GSNotifyDebugPostEndCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyDebugPostEndCS_NotifyParam_PropertyAddress;

	private static int GSNotifyDebugPostEndCS_NotifyParam_Offset;

	private static bool GSNotifyDebugPostEndCS_ReturnValue_IsValid;

	private static FFieldAddress GSNotifyDebugPostEndCS_ReturnValue_PropertyAddress;

	private static int GSNotifyDebugPostEndCS_ReturnValue_Offset;

	private static bool GSNotifyDebugPostBeginCS_IsValid;

	private IntPtr GSNotifyDebugPostBeginCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyDebugPostBeginCS_FunctionAddress;

	private static int GSNotifyDebugPostBeginCS_ParamsSize;

	private static bool GSNotifyDebugPostBeginCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyDebugPostBeginCS_NotifyParam_PropertyAddress;

	private static int GSNotifyDebugPostBeginCS_NotifyParam_Offset;

	private static bool GSNotifyDebugPostBeginCS_ReturnValue_IsValid;

	private static FFieldAddress GSNotifyDebugPostBeginCS_ReturnValue_PropertyAddress;

	private static int GSNotifyDebugPostBeginCS_ReturnValue_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private IntPtr GSNotifyBeginCS_InstanceFunctionAddress;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static FFieldAddress GSNotifyBeginCS_TotalDuration_PropertyAddress;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSAllowCrossSection_IsValid;

	private IntPtr GSAllowCrossSection_InstanceFunctionAddress;

	private static IntPtr GSAllowCrossSection_FunctionAddress;

	private static int GSAllowCrossSection_ParamsSize;

	private static bool GSAllowCrossSection_ReturnValue_IsValid;

	private static FFieldAddress GSAllowCrossSection_ReturnValue_PropertyAddress;

	private static int GSAllowCrossSection_ReturnValue_Offset;

	private static bool GetSoftReferences_IsValid;

	private IntPtr GetSoftReferences_InstanceFunctionAddress;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static bool GetPreloadedAssets_IsValid;

	private static IntPtr GetPreloadedAssets_FunctionAddress;

	private static int GetPreloadedAssets_ParamsSize;

	private static bool GetPreloadedAssets_ReturnValue_IsValid;

	private static FFieldAddress GetPreloadedAssets_ReturnValue_PropertyAddress;

	private static int GetPreloadedAssets_ReturnValue_Offset;

	private static bool GetModifySpeedRate_IsValid;

	private IntPtr GetModifySpeedRate_InstanceFunctionAddress;

	private static IntPtr GetModifySpeedRate_FunctionAddress;

	private static int GetModifySpeedRate_ParamsSize;

	private static bool GetModifySpeedRate_ReturnValue_IsValid;

	private static FFieldAddress GetModifySpeedRate_ReturnValue_PropertyAddress;

	private static int GetModifySpeedRate_ReturnValue_Offset;

	private static bool GetJumpableSectionPrefix_IsValid;

	private IntPtr GetJumpableSectionPrefix_InstanceFunctionAddress;

	private static IntPtr GetJumpableSectionPrefix_FunctionAddress;

	private static int GetJumpableSectionPrefix_ParamsSize;

	private static bool GetJumpableSectionPrefix_ReturnValue_IsValid;

	private static FFieldAddress GetJumpableSectionPrefix_ReturnValue_PropertyAddress;

	private static int GetJumpableSectionPrefix_ReturnValue_Offset;

	private static bool GetAnimNSType_IsValid;

	private IntPtr GetAnimNSType_InstanceFunctionAddress;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static bool AddPreloadedAsset_IsValid;

	private static IntPtr AddPreloadedAsset_FunctionAddress;

	private static int AddPreloadedAsset_ParamsSize;

	private static bool AddPreloadedAsset_Obj_IsValid;

	private static FFieldAddress AddPreloadedAsset_Obj_PropertyAddress;

	private static int AddPreloadedAsset_Obj_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:AnimNSType")]
	protected EGsEnAnimNS AnimNSType
	{
		get
		{
			CheckDestroyed();
			if (!AnimNSType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:AnimNSType");
				return EGsEnAnimNS.None;
			}
			return EnumMarshaler<EGsEnAnimNS>.FromNative(IntPtr.Add(base.Address, AnimNSType_Offset), 0, AnimNSType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AnimNSType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:AnimNSType");
			}
			else
			{
				EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(base.Address, AnimNSType_Offset), 0, AnimNSType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954733077uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:bCanTriggerEndByCrossMontageBegin")]
	protected bool CanTriggerEndByCrossMontageBegin
	{
		get
		{
			CheckDestroyed();
			if (!CanTriggerEndByCrossMontageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:bCanTriggerEndByCrossMontageBegin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanTriggerEndByCrossMontageBegin_Offset), 0, CanTriggerEndByCrossMontageBegin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanTriggerEndByCrossMontageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:bCanTriggerEndByCrossMontageBegin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanTriggerEndByCrossMontageBegin_Offset), 0, CanTriggerEndByCrossMontageBegin_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:IsCheckAnimInstance")]
	protected bool IsCheckAnimInstance
	{
		get
		{
			CheckDestroyed();
			if (!IsCheckAnimInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:IsCheckAnimInstance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCheckAnimInstance_Offset), 0, IsCheckAnimInstance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCheckAnimInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:IsCheckAnimInstance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCheckAnimInstance_Offset), 0, IsCheckAnimInstance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:CanBePlacedInASCS")]
	protected bool CanBePlacedInASCS
	{
		get
		{
			CheckDestroyed();
			if (!CanBePlacedInASCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:CanBePlacedInASCS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanBePlacedInASCS_Offset), 0, CanBePlacedInASCS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanBePlacedInASCS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:CanBePlacedInASCS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanBePlacedInASCS_Offset), 0, CanBePlacedInASCS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:CanUseQueuedType")]
	protected bool CanUseQueuedType
	{
		get
		{
			CheckDestroyed();
			if (!CanUseQueuedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:CanUseQueuedType");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanUseQueuedType_Offset), 0, CanUseQueuedType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanUseQueuedType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:CanUseQueuedType");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanUseQueuedType_Offset), 0, CanUseQueuedType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:isPreload")]
	public bool isPreload
	{
		get
		{
			CheckDestroyed();
			if (!isPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:isPreload");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, isPreload_Offset), 0, isPreload_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!isPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:isPreload");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, isPreload_Offset), 0, isPreload_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013205uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:NotifyStateNameForShow")]
	public FName NotifyStateNameForShow
	{
		get
		{
			CheckDestroyed();
			if (!NotifyStateNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:NotifyStateNameForShow");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyStateNameForShow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyStateNameForShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSBase:NotifyStateNameForShow");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyStateNameForShow_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:UpdateDataOnNotifyStateReplace")]
	public unsafe void UpdateDataOnNotifyStateReplace(UAnimNotifyState NewNotifyState)
	{
		CheckDestroyed();
		if (!UpdateDataOnNotifyStateReplace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:UpdateDataOnNotifyStateReplace");
			return;
		}
		if (UpdateDataOnNotifyStateReplace_InstanceFunctionAddress == IntPtr.Zero)
		{
			UpdateDataOnNotifyStateReplace_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "UpdateDataOnNotifyStateReplace");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateDataOnNotifyStateReplace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateDataOnNotifyStateReplace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, UpdateDataOnNotifyStateReplace_NewNotifyState_Offset), 0, UpdateDataOnNotifyStateReplace_NewNotifyState_PropertyAddress.Address, NewNotifyState);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateDataOnNotifyStateReplace_InstanceFunctionAddress, intPtr, UpdateDataOnNotifyStateReplace_ParamsSize);
	}

	protected unsafe virtual void UpdateDataOnNotifyStateReplace_Implementation(UAnimNotifyState NewNotifyState)
	{
		CheckDestroyed();
		if (!UpdateDataOnNotifyStateReplace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:UpdateDataOnNotifyStateReplace");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateDataOnNotifyStateReplace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateDataOnNotifyStateReplace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, UpdateDataOnNotifyStateReplace_NewNotifyState_Offset), 0, UpdateDataOnNotifyStateReplace_NewNotifyState_PropertyAddress.Address, NewNotifyState);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateDataOnNotifyStateReplace_FunctionAddress, intPtr, UpdateDataOnNotifyStateReplace_ParamsSize);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSValidateInputCS")]
	public unsafe void GSValidateInputCS(AActor actor)
	{
		CheckDestroyed();
		if (!GSValidateInputCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSValidateInputCS");
			return;
		}
		if (GSValidateInputCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSValidateInputCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSValidateInputCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSValidateInputCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSValidateInputCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GSValidateInputCS_actor_Offset), 0, GSValidateInputCS_actor_PropertyAddress.Address, actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSValidateInputCS_InstanceFunctionAddress, intPtr, GSValidateInputCS_ParamsSize);
	}

	protected unsafe virtual void GSValidateInputCS_Implementation(AActor actor)
	{
		CheckDestroyed();
		if (!GSValidateInputCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSValidateInputCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSValidateInputCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSValidateInputCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GSValidateInputCS_actor_Offset), 0, GSValidateInputCS_actor_PropertyAddress.Address, actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSValidateInputCS_FunctionAddress, intPtr, GSValidateInputCS_ParamsSize);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSOnSectionManuallyChanged")]
	public unsafe void GSOnSectionManuallyChanged(ABGUCharacter OwnerChar, float RemainingDuration)
	{
		CheckDestroyed();
		if (!GSOnSectionManuallyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSOnSectionManuallyChanged");
			return;
		}
		if (GSOnSectionManuallyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSOnSectionManuallyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSOnSectionManuallyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSOnSectionManuallyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnSectionManuallyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, GSOnSectionManuallyChanged_OwnerChar_Offset), 0, GSOnSectionManuallyChanged_OwnerChar_PropertyAddress.Address, OwnerChar);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSOnSectionManuallyChanged_RemainingDuration_Offset), 0, GSOnSectionManuallyChanged_RemainingDuration_PropertyAddress.Address, RemainingDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSOnSectionManuallyChanged_InstanceFunctionAddress, intPtr, GSOnSectionManuallyChanged_ParamsSize);
	}

	protected unsafe virtual void GSOnSectionManuallyChanged_Implementation(ABGUCharacter OwnerChar, float RemainingDuration)
	{
		CheckDestroyed();
		if (!GSOnSectionManuallyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSOnSectionManuallyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSOnSectionManuallyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSOnSectionManuallyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, GSOnSectionManuallyChanged_OwnerChar_Offset), 0, GSOnSectionManuallyChanged_OwnerChar_PropertyAddress.Address, OwnerChar);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSOnSectionManuallyChanged_RemainingDuration_Offset), 0, GSOnSectionManuallyChanged_RemainingDuration_PropertyAddress.Address, RemainingDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSOnSectionManuallyChanged_FunctionAddress, intPtr, GSOnSectionManuallyChanged_ParamsSize);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyTickCS")]
	protected unsafe void GSNotifyTickCS(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		CheckDestroyed();
		if (!GSNotifyTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyTickCS");
			return;
		}
		if (GSNotifyTickCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyTickCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyTickCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyTickCS_NotifyParam_Offset), 0, GSNotifyTickCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSNotifyTickCS_FrameDeltaTime_Offset), 0, GSNotifyTickCS_FrameDeltaTime_PropertyAddress.Address, FrameDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyTickCS_InstanceFunctionAddress, intPtr, GSNotifyTickCS_ParamsSize);
	}

	protected unsafe virtual void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		CheckDestroyed();
		if (!GSNotifyTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyTickCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyTickCS_NotifyParam_Offset), 0, GSNotifyTickCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSNotifyTickCS_FrameDeltaTime_Offset), 0, GSNotifyTickCS_FrameDeltaTime_PropertyAddress.Address, FrameDeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyTickCS_FunctionAddress, intPtr, GSNotifyTickCS_ParamsSize);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyEndCS")]
	protected unsafe void GSNotifyEndCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyEndCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyEndCS");
			return;
		}
		if (GSNotifyEndCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyEndCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyEndCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyEndCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyEndCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyEndCS_NotifyParam_Offset), 0, GSNotifyEndCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyEndCS_InstanceFunctionAddress, intPtr, GSNotifyEndCS_ParamsSize);
	}

	protected unsafe virtual void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyEndCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyEndCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyEndCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyEndCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyEndCS_NotifyParam_Offset), 0, GSNotifyEndCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyEndCS_FunctionAddress, intPtr, GSNotifyEndCS_ParamsSize);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreTickCS")]
	protected unsafe int GSNotifyDebugPreTickCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPreTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreTickCS");
			return 0;
		}
		if (GSNotifyDebugPreTickCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyDebugPreTickCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyDebugPreTickCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPreTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPreTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPreTickCS_NotifyParam_Offset), 0, GSNotifyDebugPreTickCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPreTickCS_InstanceFunctionAddress, intPtr, GSNotifyDebugPreTickCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPreTickCS_ReturnValue_Offset), 0, GSNotifyDebugPreTickCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSNotifyDebugPreTickCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPreTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreTickCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPreTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPreTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPreTickCS_NotifyParam_Offset), 0, GSNotifyDebugPreTickCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPreTickCS_FunctionAddress, intPtr, GSNotifyDebugPreTickCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPreTickCS_ReturnValue_Offset), 0, GSNotifyDebugPreTickCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreEndCS")]
	protected unsafe int GSNotifyDebugPreEndCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPreEndCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreEndCS");
			return 0;
		}
		if (GSNotifyDebugPreEndCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyDebugPreEndCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyDebugPreEndCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPreEndCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPreEndCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPreEndCS_NotifyParam_Offset), 0, GSNotifyDebugPreEndCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPreEndCS_InstanceFunctionAddress, intPtr, GSNotifyDebugPreEndCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPreEndCS_ReturnValue_Offset), 0, GSNotifyDebugPreEndCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSNotifyDebugPreEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPreEndCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreEndCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPreEndCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPreEndCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPreEndCS_NotifyParam_Offset), 0, GSNotifyDebugPreEndCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPreEndCS_FunctionAddress, intPtr, GSNotifyDebugPreEndCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPreEndCS_ReturnValue_Offset), 0, GSNotifyDebugPreEndCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreBeginCS")]
	protected unsafe int GSNotifyDebugPreBeginCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPreBeginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreBeginCS");
			return 0;
		}
		if (GSNotifyDebugPreBeginCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyDebugPreBeginCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyDebugPreBeginCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPreBeginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPreBeginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPreBeginCS_NotifyParam_Offset), 0, GSNotifyDebugPreBeginCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPreBeginCS_InstanceFunctionAddress, intPtr, GSNotifyDebugPreBeginCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPreBeginCS_ReturnValue_Offset), 0, GSNotifyDebugPreBeginCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSNotifyDebugPreBeginCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPreBeginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreBeginCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPreBeginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPreBeginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPreBeginCS_NotifyParam_Offset), 0, GSNotifyDebugPreBeginCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPreBeginCS_FunctionAddress, intPtr, GSNotifyDebugPreBeginCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPreBeginCS_ReturnValue_Offset), 0, GSNotifyDebugPreBeginCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostTickCS")]
	protected unsafe int GSNotifyDebugPostTickCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPostTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostTickCS");
			return 0;
		}
		if (GSNotifyDebugPostTickCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyDebugPostTickCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyDebugPostTickCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPostTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPostTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPostTickCS_NotifyParam_Offset), 0, GSNotifyDebugPostTickCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPostTickCS_InstanceFunctionAddress, intPtr, GSNotifyDebugPostTickCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPostTickCS_ReturnValue_Offset), 0, GSNotifyDebugPostTickCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSNotifyDebugPostTickCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPostTickCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostTickCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPostTickCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPostTickCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPostTickCS_NotifyParam_Offset), 0, GSNotifyDebugPostTickCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPostTickCS_FunctionAddress, intPtr, GSNotifyDebugPostTickCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPostTickCS_ReturnValue_Offset), 0, GSNotifyDebugPostTickCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostEndCS")]
	protected unsafe int GSNotifyDebugPostEndCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPostEndCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostEndCS");
			return 0;
		}
		if (GSNotifyDebugPostEndCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyDebugPostEndCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyDebugPostEndCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPostEndCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPostEndCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPostEndCS_NotifyParam_Offset), 0, GSNotifyDebugPostEndCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPostEndCS_InstanceFunctionAddress, intPtr, GSNotifyDebugPostEndCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPostEndCS_ReturnValue_Offset), 0, GSNotifyDebugPostEndCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSNotifyDebugPostEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPostEndCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostEndCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPostEndCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPostEndCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPostEndCS_NotifyParam_Offset), 0, GSNotifyDebugPostEndCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPostEndCS_FunctionAddress, intPtr, GSNotifyDebugPostEndCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPostEndCS_ReturnValue_Offset), 0, GSNotifyDebugPostEndCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostBeginCS")]
	protected unsafe int GSNotifyDebugPostBeginCS(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPostBeginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostBeginCS");
			return 0;
		}
		if (GSNotifyDebugPostBeginCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyDebugPostBeginCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyDebugPostBeginCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPostBeginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPostBeginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPostBeginCS_NotifyParam_Offset), 0, GSNotifyDebugPostBeginCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPostBeginCS_InstanceFunctionAddress, intPtr, GSNotifyDebugPostBeginCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPostBeginCS_ReturnValue_Offset), 0, GSNotifyDebugPostBeginCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int GSNotifyDebugPostBeginCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		CheckDestroyed();
		if (!GSNotifyDebugPostBeginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostBeginCS");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyDebugPostBeginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyDebugPostBeginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyDebugPostBeginCS_NotifyParam_Offset), 0, GSNotifyDebugPostBeginCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyDebugPostBeginCS_FunctionAddress, intPtr, GSNotifyDebugPostBeginCS_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GSNotifyDebugPostBeginCS_ReturnValue_Offset), 0, GSNotifyDebugPostBeginCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSNotifyBeginCS")]
	protected unsafe void GSNotifyBeginCS(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		CheckDestroyed();
		if (!GSNotifyBeginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyBeginCS");
			return;
		}
		if (GSNotifyBeginCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSNotifyBeginCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSNotifyBeginCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyBeginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyBeginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyBeginCS_NotifyParam_Offset), 0, GSNotifyBeginCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSNotifyBeginCS_TotalDuration_Offset), 0, GSNotifyBeginCS_TotalDuration_PropertyAddress.Address, TotalDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyBeginCS_InstanceFunctionAddress, intPtr, GSNotifyBeginCS_ParamsSize);
	}

	protected unsafe virtual void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		CheckDestroyed();
		if (!GSNotifyBeginCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSNotifyBeginCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSNotifyBeginCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSNotifyBeginCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FUStGSNotifyParam.ToNative(IntPtr.Add(intPtr, GSNotifyBeginCS_NotifyParam_Offset), 0, GSNotifyBeginCS_NotifyParam_PropertyAddress.Address, NotifyParam);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GSNotifyBeginCS_TotalDuration_Offset), 0, GSNotifyBeginCS_TotalDuration_PropertyAddress.Address, TotalDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSNotifyBeginCS_FunctionAddress, intPtr, GSNotifyBeginCS_ParamsSize);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GSAllowCrossSection")]
	public unsafe bool GSAllowCrossSection()
	{
		CheckDestroyed();
		if (!GSAllowCrossSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSAllowCrossSection");
			return false;
		}
		if (GSAllowCrossSection_InstanceFunctionAddress == IntPtr.Zero)
		{
			GSAllowCrossSection_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GSAllowCrossSection");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSAllowCrossSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSAllowCrossSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSAllowCrossSection_InstanceFunctionAddress, intPtr, GSAllowCrossSection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool GSAllowCrossSection_Implementation()
	{
		CheckDestroyed();
		if (!GSAllowCrossSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GSAllowCrossSection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSAllowCrossSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSAllowCrossSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GSAllowCrossSection_FunctionAddress, intPtr, GSAllowCrossSection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GetSoftReferences")]
	public unsafe List<FSoftObjectPath> GetSoftReferences()
	{
		CheckDestroyed();
		if (!GetSoftReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetSoftReferences");
			return null;
		}
		if (GetSoftReferences_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSoftReferences_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSoftReferences");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoftReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoftReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSoftReferences_InstanceFunctionAddress, intPtr, GetSoftReferences_ParamsSize);
		List<FSoftObjectPath> result = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(intPtr, GetSoftReferences_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSoftReferences_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		CheckDestroyed();
		if (!GetSoftReferences_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetSoftReferences");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSoftReferences_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSoftReferences_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSoftReferences_FunctionAddress, intPtr, GetSoftReferences_ParamsSize);
		List<FSoftObjectPath> result = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(intPtr, GetSoftReferences_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSoftReferences_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GetPreloadedAssets")]
	public unsafe List<UObject> GetPreloadedAssets()
	{
		CheckDestroyed();
		if (!GetPreloadedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetPreloadedAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreloadedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreloadedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreloadedAssets_FunctionAddress, intPtr, GetPreloadedAssets_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetPreloadedAssets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPreloadedAssets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetPreloadedAssets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GetModifySpeedRate")]
	public unsafe float GetModifySpeedRate()
	{
		CheckDestroyed();
		if (!GetModifySpeedRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetModifySpeedRate");
			return 0f;
		}
		if (GetModifySpeedRate_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetModifySpeedRate_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetModifySpeedRate");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetModifySpeedRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetModifySpeedRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetModifySpeedRate_InstanceFunctionAddress, intPtr, GetModifySpeedRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetModifySpeedRate_ReturnValue_Offset), 0, GetModifySpeedRate_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual float GetModifySpeedRate_Implementation()
	{
		CheckDestroyed();
		if (!GetModifySpeedRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetModifySpeedRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetModifySpeedRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetModifySpeedRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetModifySpeedRate_FunctionAddress, intPtr, GetModifySpeedRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetModifySpeedRate_ReturnValue_Offset), 0, GetModifySpeedRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GetJumpableSectionPrefix")]
	public unsafe string GetJumpableSectionPrefix()
	{
		CheckDestroyed();
		if (!GetJumpableSectionPrefix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetJumpableSectionPrefix");
			return FStringMarshaler.DefaultString;
		}
		if (GetJumpableSectionPrefix_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetJumpableSectionPrefix_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetJumpableSectionPrefix");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJumpableSectionPrefix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJumpableSectionPrefix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetJumpableSectionPrefix_InstanceFunctionAddress, intPtr, GetJumpableSectionPrefix_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetJumpableSectionPrefix_ReturnValue_Offset), 0, GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetJumpableSectionPrefix_Implementation()
	{
		CheckDestroyed();
		if (!GetJumpableSectionPrefix_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetJumpableSectionPrefix");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetJumpableSectionPrefix_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetJumpableSectionPrefix_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetJumpableSectionPrefix_FunctionAddress, intPtr, GetJumpableSectionPrefix_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetJumpableSectionPrefix_ReturnValue_Offset), 0, GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetJumpableSectionPrefix_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:GetAnimNSType")]
	public unsafe EGsEnAnimNS GetAnimNSType()
	{
		CheckDestroyed();
		if (!GetAnimNSType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetAnimNSType");
			return EGsEnAnimNS.None;
		}
		if (GetAnimNSType_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAnimNSType_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAnimNSType");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimNSType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimNSType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimNSType_InstanceFunctionAddress, intPtr, GetAnimNSType_ParamsSize);
		return EnumMarshaler<EGsEnAnimNS>.FromNative(IntPtr.Add(intPtr, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual EGsEnAnimNS GetAnimNSType_Implementation()
	{
		CheckDestroyed();
		if (!GetAnimNSType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:GetAnimNSType");
			return EGsEnAnimNS.None;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimNSType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimNSType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimNSType_FunctionAddress, intPtr, GetAnimNSType_ParamsSize);
		return EnumMarshaler<EGsEnAnimNS>.FromNative(IntPtr.Add(intPtr, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSBase:AddPreloadedAsset")]
	public unsafe void AddPreloadedAsset(UObject Obj)
	{
		CheckDestroyed();
		if (!AddPreloadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.AnimNotifyState_GSBase:AddPreloadedAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPreloadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPreloadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddPreloadedAsset_Obj_Offset), 0, AddPreloadedAsset_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddPreloadedAsset_FunctionAddress, intPtr, AddPreloadedAsset_ParamsSize);
	}

	static UAnimNotifyState_GSBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_GSBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_GSBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.AnimNotifyState_GSBase");
		NativeReflectionCached.GetPropertyRef(ref AnimNSType_PropertyAddress, intPtr, "AnimNSType");
		AnimNSType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimNSType");
		AnimNSType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimNSType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CanTriggerEndByCrossMontageBegin_PropertyAddress, intPtr, "bCanTriggerEndByCrossMontageBegin");
		CanTriggerEndByCrossMontageBegin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanTriggerEndByCrossMontageBegin");
		CanTriggerEndByCrossMontageBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanTriggerEndByCrossMontageBegin", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCheckAnimInstance_PropertyAddress, intPtr, "IsCheckAnimInstance");
		IsCheckAnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsCheckAnimInstance");
		IsCheckAnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsCheckAnimInstance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanBePlacedInASCS_PropertyAddress, intPtr, "CanBePlacedInASCS");
		CanBePlacedInASCS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanBePlacedInASCS");
		CanBePlacedInASCS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanBePlacedInASCS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanUseQueuedType_PropertyAddress, intPtr, "CanUseQueuedType");
		CanUseQueuedType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CanUseQueuedType");
		CanUseQueuedType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CanUseQueuedType", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref isPreload_PropertyAddress, intPtr, "isPreload");
		isPreload_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "isPreload");
		isPreload_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "isPreload", Classes.FBoolProperty);
		NotifyStateNameForShow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyStateNameForShow");
		NotifyStateNameForShow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyStateNameForShow", Classes.FNameProperty);
		UpdateDataOnNotifyStateReplace_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateDataOnNotifyStateReplace");
		UpdateDataOnNotifyStateReplace_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateDataOnNotifyStateReplace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateDataOnNotifyStateReplace_NewNotifyState_PropertyAddress, UpdateDataOnNotifyStateReplace_FunctionAddress, "NewNotifyState");
		UpdateDataOnNotifyStateReplace_NewNotifyState_Offset = NativeReflectionCached.GetPropertyOffset(UpdateDataOnNotifyStateReplace_FunctionAddress, "NewNotifyState");
		UpdateDataOnNotifyStateReplace_NewNotifyState_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateDataOnNotifyStateReplace_FunctionAddress, "NewNotifyState", Classes.FObjectProperty);
		UpdateDataOnNotifyStateReplace_IsValid = UpdateDataOnNotifyStateReplace_FunctionAddress != IntPtr.Zero && UpdateDataOnNotifyStateReplace_NewNotifyState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:UpdateDataOnNotifyStateReplace", UpdateDataOnNotifyStateReplace_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSValidateInputCS_actor_PropertyAddress, GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_Offset = NativeReflectionCached.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSValidateInputCS", GSValidateInputCS_IsValid);
		GSOnSectionManuallyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnSectionManuallyChanged");
		GSOnSectionManuallyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnSectionManuallyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSOnSectionManuallyChanged_OwnerChar_PropertyAddress, GSOnSectionManuallyChanged_FunctionAddress, "OwnerChar");
		GSOnSectionManuallyChanged_OwnerChar_Offset = NativeReflectionCached.GetPropertyOffset(GSOnSectionManuallyChanged_FunctionAddress, "OwnerChar");
		GSOnSectionManuallyChanged_OwnerChar_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnSectionManuallyChanged_FunctionAddress, "OwnerChar", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GSOnSectionManuallyChanged_RemainingDuration_PropertyAddress, GSOnSectionManuallyChanged_FunctionAddress, "RemainingDuration");
		GSOnSectionManuallyChanged_RemainingDuration_Offset = NativeReflectionCached.GetPropertyOffset(GSOnSectionManuallyChanged_FunctionAddress, "RemainingDuration");
		GSOnSectionManuallyChanged_RemainingDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(GSOnSectionManuallyChanged_FunctionAddress, "RemainingDuration", Classes.FFloatProperty);
		GSOnSectionManuallyChanged_IsValid = GSOnSectionManuallyChanged_FunctionAddress != IntPtr.Zero && GSOnSectionManuallyChanged_OwnerChar_IsValid && GSOnSectionManuallyChanged_RemainingDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSOnSectionManuallyChanged", GSOnSectionManuallyChanged_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyTickCS_FrameDeltaTime_PropertyAddress, GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyDebugPreTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyDebugPreTickCS");
		GSNotifyDebugPreTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPreTickCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPreTickCS_NotifyParam_PropertyAddress, GSNotifyDebugPreTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreTickCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPreTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreTickCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPreTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPreTickCS_ReturnValue_PropertyAddress, GSNotifyDebugPreTickCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreTickCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPreTickCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreTickCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPreTickCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPreTickCS_IsValid = GSNotifyDebugPreTickCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPreTickCS_NotifyParam_IsValid && GSNotifyDebugPreTickCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreTickCS", GSNotifyDebugPreTickCS_IsValid);
		GSNotifyDebugPreEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyDebugPreEndCS");
		GSNotifyDebugPreEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPreEndCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPreEndCS_NotifyParam_PropertyAddress, GSNotifyDebugPreEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreEndCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPreEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreEndCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPreEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPreEndCS_ReturnValue_PropertyAddress, GSNotifyDebugPreEndCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreEndCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPreEndCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreEndCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPreEndCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPreEndCS_IsValid = GSNotifyDebugPreEndCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPreEndCS_NotifyParam_IsValid && GSNotifyDebugPreEndCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreEndCS", GSNotifyDebugPreEndCS_IsValid);
		GSNotifyDebugPreBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyDebugPreBeginCS");
		GSNotifyDebugPreBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPreBeginCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPreBeginCS_NotifyParam_PropertyAddress, GSNotifyDebugPreBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreBeginCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPreBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPreBeginCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPreBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPreBeginCS_ReturnValue_PropertyAddress, GSNotifyDebugPreBeginCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreBeginCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPreBeginCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPreBeginCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPreBeginCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPreBeginCS_IsValid = GSNotifyDebugPreBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPreBeginCS_NotifyParam_IsValid && GSNotifyDebugPreBeginCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPreBeginCS", GSNotifyDebugPreBeginCS_IsValid);
		GSNotifyDebugPostTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyDebugPostTickCS");
		GSNotifyDebugPostTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPostTickCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPostTickCS_NotifyParam_PropertyAddress, GSNotifyDebugPostTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostTickCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPostTickCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostTickCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPostTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPostTickCS_ReturnValue_PropertyAddress, GSNotifyDebugPostTickCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostTickCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPostTickCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostTickCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPostTickCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPostTickCS_IsValid = GSNotifyDebugPostTickCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPostTickCS_NotifyParam_IsValid && GSNotifyDebugPostTickCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostTickCS", GSNotifyDebugPostTickCS_IsValid);
		GSNotifyDebugPostEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyDebugPostEndCS");
		GSNotifyDebugPostEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPostEndCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPostEndCS_NotifyParam_PropertyAddress, GSNotifyDebugPostEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostEndCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPostEndCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostEndCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPostEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPostEndCS_ReturnValue_PropertyAddress, GSNotifyDebugPostEndCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostEndCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPostEndCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostEndCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPostEndCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPostEndCS_IsValid = GSNotifyDebugPostEndCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPostEndCS_NotifyParam_IsValid && GSNotifyDebugPostEndCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostEndCS", GSNotifyDebugPostEndCS_IsValid);
		GSNotifyDebugPostBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyDebugPostBeginCS");
		GSNotifyDebugPostBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyDebugPostBeginCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPostBeginCS_NotifyParam_PropertyAddress, GSNotifyDebugPostBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostBeginCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPostBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyDebugPostBeginCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPostBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyDebugPostBeginCS_ReturnValue_PropertyAddress, GSNotifyDebugPostBeginCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostBeginCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyDebugPostBeginCS_FunctionAddress, "ReturnValue");
		GSNotifyDebugPostBeginCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyDebugPostBeginCS_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GSNotifyDebugPostBeginCS_IsValid = GSNotifyDebugPostBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyDebugPostBeginCS_NotifyParam_IsValid && GSNotifyDebugPostBeginCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyDebugPostBeginCS", GSNotifyDebugPostBeginCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GSNotifyBeginCS_TotalDuration_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflectionCached.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSAllowCrossSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAllowCrossSection");
		GSAllowCrossSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAllowCrossSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSAllowCrossSection_ReturnValue_PropertyAddress, GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GSAllowCrossSection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSAllowCrossSection_IsValid = GSAllowCrossSection_FunctionAddress != IntPtr.Zero && GSAllowCrossSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GSAllowCrossSection", GSAllowCrossSection_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GetSoftReferences", GetSoftReferences_IsValid);
		GetPreloadedAssets_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPreloadedAssets");
		GetPreloadedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreloadedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreloadedAssets_ReturnValue_PropertyAddress, GetPreloadedAssets_FunctionAddress, "ReturnValue");
		GetPreloadedAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreloadedAssets_FunctionAddress, "ReturnValue");
		GetPreloadedAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreloadedAssets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetPreloadedAssets_IsValid = GetPreloadedAssets_FunctionAddress != IntPtr.Zero && GetPreloadedAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GetPreloadedAssets", GetPreloadedAssets_IsValid);
		GetModifySpeedRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetModifySpeedRate");
		GetModifySpeedRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetModifySpeedRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetModifySpeedRate_ReturnValue_PropertyAddress, GetModifySpeedRate_FunctionAddress, "ReturnValue");
		GetModifySpeedRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetModifySpeedRate_FunctionAddress, "ReturnValue");
		GetModifySpeedRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetModifySpeedRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetModifySpeedRate_IsValid = GetModifySpeedRate_FunctionAddress != IntPtr.Zero && GetModifySpeedRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GetModifySpeedRate", GetModifySpeedRate_IsValid);
		GetJumpableSectionPrefix_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetJumpableSectionPrefix");
		GetJumpableSectionPrefix_ParamsSize = NativeReflection.GetFunctionParamsSize(GetJumpableSectionPrefix_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetJumpableSectionPrefix_ReturnValue_PropertyAddress, GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue");
		GetJumpableSectionPrefix_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetJumpableSectionPrefix_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetJumpableSectionPrefix_IsValid = GetJumpableSectionPrefix_FunctionAddress != IntPtr.Zero && GetJumpableSectionPrefix_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GetJumpableSectionPrefix", GetJumpableSectionPrefix_IsValid);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:GetAnimNSType", GetAnimNSType_IsValid);
		AddPreloadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPreloadedAsset");
		AddPreloadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPreloadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPreloadedAsset_Obj_PropertyAddress, AddPreloadedAsset_FunctionAddress, "Obj");
		AddPreloadedAsset_Obj_Offset = NativeReflectionCached.GetPropertyOffset(AddPreloadedAsset_FunctionAddress, "Obj");
		AddPreloadedAsset_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPreloadedAsset_FunctionAddress, "Obj", Classes.FObjectProperty);
		AddPreloadedAsset_IsValid = AddPreloadedAsset_FunctionAddress != IntPtr.Zero && AddPreloadedAsset_Obj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.AnimNotifyState_GSBase:AddPreloadedAsset", AddPreloadedAsset_IsValid);
	}
}
