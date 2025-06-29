using System;
using b1.ECS;
using b1.Plugins.AsyncLoadingScreen;
using b1.Plugins.GSInput;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibInput")]
public class BGUFuncLibInput : UBlueprintFunctionLibrary
{
	private static bool IsGamepadType_IsValid;

	private static IntPtr IsGamepadType_FunctionAddress;

	private static int IsGamepadType_ParamsSize;

	private static bool IsGamepadType_ReturnValue_IsValid;

	private static int IsGamepadType_ReturnValue_Offset;

	private static FFieldAddress IsGamepadType_ReturnValue_PropertyAddress;

	private static bool SetSuperUserInputMode_IsValid;

	private static IntPtr SetSuperUserInputMode_FunctionAddress;

	private static int SetSuperUserInputMode_ParamsSize;

	private static bool SetSuperUserInputMode_WorldContext_IsValid;

	private static int SetSuperUserInputMode_WorldContext_Offset;

	private static bool SetSuperUserInputMode_IsOpen_IsValid;

	private static int SetSuperUserInputMode_IsOpen_Offset;

	private static FFieldAddress SetSuperUserInputMode_IsOpen_PropertyAddress;

	private static bool SetSuperUserInputMode_ChangeReason_IsValid;

	private static int SetSuperUserInputMode_ChangeReason_Offset;

	private static FFieldAddress SetSuperUserInputMode_ChangeReason_PropertyAddress;

	private static bool OpenAcceptNavigationAction_IsValid;

	private static IntPtr OpenAcceptNavigationAction_FunctionAddress;

	private static int OpenAcceptNavigationAction_ParamsSize;

	private static bool OpenAcceptNavigationAction_bOpen_IsValid;

	private static int OpenAcceptNavigationAction_bOpen_Offset;

	private static FFieldAddress OpenAcceptNavigationAction_bOpen_PropertyAddress;

	[BlueprintCallable]
	[Category("BGU|Input")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibInput:SetSuperUserInputMode")]
	public static void SetSuperUserInputMode(UObject WorldContext, bool IsOpen, EGSInputModeChangeReason ChangeReason)
	{
		BGW_EventCollection.Get(WorldContext).Evt_SetSuperUserInputMode(IsOpen, ChangeReason);
	}

	[Category("BGU|Input")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibInput:IsGamepadType")]
	public static bool IsGamepadType()
	{
		return FInputTypeTracker.CurInputType == EGSInputType.Gamepad;
	}

	[Category("BGU|Input")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibInput:OpenAcceptNavigationAction")]
	public static void OpenAcceptNavigationAction(bool bOpen)
	{
		if (bOpen)
		{
			UGSE_UINavigationFuncLib.AddNavigationActionKey(EUINavigationAction.Accept, new FName(EKeys.Gamepad_FaceButton_Bottom.ToString()));
		}
		else
		{
			UGSE_UINavigationFuncLib.ClearNavigationActionKey(new FName(EKeys.Gamepad_FaceButton_Bottom.ToString()));
		}
	}

	public static bool BGUIsCanReceiveBattleInputByActionType(AActor Unit, EInputActionType ActionType)
	{
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Unit);
		IBUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Unit);
		IBUC_ABPCharacterData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(Unit);
		switch (ActionType)
		{
		case EInputActionType.SpinMode:
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreSpinLightInput))
			{
				return false;
			}
			break;
		case EInputActionType.Interact:
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreInteractInput))
			{
				return false;
			}
			break;
		case EInputActionType.SwitchMoveSpeedState:
		case EInputActionType.Move:
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreMoveInput))
			{
				return false;
			}
			break;
		case EInputActionType.Jump:
		{
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreJumpInput) || readOnlyData.HasSimpleState(EBGUSimpleState.Frozen))
			{
				return false;
			}
			IBUC_HardMoveData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_HardMoveData, b1.BUC_HardMoveData>(Unit);
			if (readOnlyData3 != null && readOnlyData3.IsHardMoving())
			{
				return false;
			}
			break;
		}
		case EInputActionType.LightAttack:
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreLightAttackInput))
			{
				return false;
			}
			break;
		case EInputActionType.HeavyAttack:
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreHeavyAttackInput))
			{
				return false;
			}
			break;
		case EInputActionType.ToggleCloudMove:
			if (BGUFunctionLibraryCS.BGUIsUnitInBattle(Unit))
			{
				return false;
			}
			break;
		case EInputActionType.UseVigorSkill:
			if (readOnlyData2.HasState(EBGUUnitState.JumpMoving))
			{
				return false;
			}
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreVigorSkill) || readOnlyData.HasSimpleState(EBGUSimpleState.CantInVigorSkill))
			{
				return false;
			}
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.IsFalling)
			{
				return false;
			}
			break;
		case EInputActionType.UseShortcutItem:
			if (readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreUseItem))
			{
				return false;
			}
			break;
		}
		return true;
	}

	public static bool BGUCanReceiveXAxisInput(AActor Unit, float InputAxisValue)
	{
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Unit);
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreXAxisMoveInput))
		{
			return false;
		}
		return true;
	}

	public static bool BGUCanReceiveYAxisInput(AActor Unit, float InputAxisValue)
	{
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Unit);
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.IgnoreMoveBackInput) && InputAxisValue < 0f)
		{
			return false;
		}
		return true;
	}

	public static bool BGUIsCanReceiveBattleMouseInput(AActor Unit)
	{
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Unit);
		IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Unit);
		IBUC_FallDyingData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>(Unit);
		if (readOnlyData == null || readOnlyData2 == null || readOnlyData3 == null)
		{
			return false;
		}
		if (readOnlyData.HasState(EBGUUnitState.Dead) || readOnlyData3.GetFallDyingState() != EFallDyingState.Alive || readOnlyData2.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (readOnlyData2.HasSimpleState(EBGUSimpleState.IgnoreAllInput))
		{
			return false;
		}
		BGWGameInstanceCS bGWGameInstanceCS = BGWGameInstanceCS.Get(Unit);
		if ((object)bGWGameInstanceCS == null || bGWGameInstanceCS.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			return false;
		}
		return true;
	}

	public static bool BGUIsCanReceiveBattleInput(AActor Unit, bool bSkilIgnoreInputJudge = false)
	{
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Unit);
		IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Unit);
		IBUC_FallDyingData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>(Unit);
		if (readOnlyData == null || readOnlyData2 == null || readOnlyData3 == null)
		{
			return false;
		}
		if (readOnlyData.HasState(EBGUUnitState.Dead) || readOnlyData3.GetFallDyingState() != EFallDyingState.Alive)
		{
			return false;
		}
		if (readOnlyData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || readOnlyData.HasState(EBGUUnitState.LifeSavingHair_Rebirth))
		{
			return false;
		}
		if (readOnlyData2.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (!bSkilIgnoreInputJudge)
		{
			if (readOnlyData2.HasSimpleState(EBGUSimpleState.IgnoreAllInput))
			{
				return false;
			}
			if (readOnlyData2.HasSimpleState(EBGUSimpleState.BanInputButCamera))
			{
				return false;
			}
		}
		BGWGameInstanceCS bGWGameInstanceCS = BGWGameInstanceCS.Get(Unit);
		if ((object)bGWGameInstanceCS == null || bGWGameInstanceCS.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			return false;
		}
		return true;
	}

	public static UnitLockTargetInfo SelectCameraLockTarget(AActor Owner, AActor PreferActor = null, float PreferActorDisTolerance = 0f)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter.IsNullOrDestroyed())
		{
			return null;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PlayerCantLock))
		{
			return null;
		}
		IBUC_PlayerInputConfigData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(Owner);
		if (unPersistentReadOnlyData == null)
		{
			return null;
		}
		return BGUFuncLibSelectTargetsCS.BGUSelectLockTargetInRange(aCharacter, unPersistentReadOnlyData.GSCameraAutoLockSetting.MaxCamLockTargetDistance, EBSelectTargetRangeType.CameraLock, unPersistentReadOnlyData.GSCameraAutoLockSetting.CamLockAngleMax, aCharacter.GetControlRotation(), unPersistentReadOnlyData.GSCameraAutoLockSetting.DistScoreRate, PreferActor, PreferActorDisTolerance);
	}

	public static void BGUInputCameraLockTarget(AActor Owner, AActor PreferActor = null, float PreferActorDisTolerance = 0f)
	{
		if (!BGUIsCanReceiveBattleInput(Owner))
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter.IsNullOrDestroyed() || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Owner, EBGUSimpleState.PlayerCantLock))
		{
			return;
		}
		UnitLockTargetInfo unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(Owner);
		if (unitLockTargetInfo.LockTargetEntity != Entity.Null && unitLockTargetInfo.LockTargetWayType == ELockTargetWayType.Manual)
		{
			BUS_EventCollectionCS.Get(Owner).Evt_ClearCameraLock.Invoke();
			return;
		}
		IBUC_PlayerInputConfigData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(Owner);
		if (unPersistentReadOnlyData != null)
		{
			UnitLockTargetInfo unitLockTargetInfo2 = BGUFuncLibSelectTargetsCS.BGUSelectLockTargetInRange(aCharacter, unPersistentReadOnlyData.GSCameraAutoLockSetting.MaxCamLockTargetDistance, EBSelectTargetRangeType.CameraLock, unPersistentReadOnlyData.GSCameraAutoLockSetting.CamLockAngleMax, aCharacter.GetControlRotation(), unPersistentReadOnlyData.GSCameraAutoLockSetting.DistScoreRate, PreferActor, PreferActorDisTolerance);
			if (unitLockTargetInfo2 == null)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_ClearCameraLock.Invoke();
			}
			else
			{
				BUS_EventCollectionCS.Get(Owner).Evt_CameraLockTarget.Invoke(unitLockTargetInfo2);
			}
		}
	}

	public static ESkillDirection CalcInputDir(float Hor, float Ver, float DodgeInputFixLine)
	{
		ESkillDirection result = ESkillDirection.Forward;
		float num = FMath.Sqrt(Hor * Hor + Ver * Ver);
		float num2 = Hor / num;
		float num3 = Ver / num;
		float num4 = ((DodgeInputFixLine == 0f) ? 0.7071f : DodgeInputFixLine);
		if (num2 >= num4)
		{
			result = ESkillDirection.Right;
		}
		else if (num2 <= 0f - num4)
		{
			result = ESkillDirection.Left;
		}
		else if (num3 > num4)
		{
			result = ESkillDirection.Forward;
		}
		else if (num3 < 0f - num4)
		{
			result = ESkillDirection.Backward;
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibInput:IsGamepadType")]
	private static void IsGamepadType__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool value = IsGamepadType();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsGamepadType_ReturnValue_Offset), 0, IsGamepadType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibInput:SetSuperUserInputMode")]
	private static void SetSuperUserInputMode__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SetSuperUserInputMode_WorldContext_Offset));
		bool isOpen = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetSuperUserInputMode_IsOpen_Offset), 0, SetSuperUserInputMode_IsOpen_PropertyAddress.Address);
		EGSInputModeChangeReason changeReason = EnumMarshaler<EGSInputModeChangeReason>.FromNative(IntPtr.Add(buffer, SetSuperUserInputMode_ChangeReason_Offset), 0, SetSuperUserInputMode_ChangeReason_PropertyAddress.Address);
		SetSuperUserInputMode(worldContext, isOpen, changeReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibInput:OpenAcceptNavigationAction")]
	private static void OpenAcceptNavigationAction__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool bOpen = BoolMarshaler.FromNative(IntPtr.Add(buffer, OpenAcceptNavigationAction_bOpen_Offset), 0, OpenAcceptNavigationAction_bOpen_PropertyAddress.Address);
		OpenAcceptNavigationAction(bOpen);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibInput");
		IsGamepadType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsGamepadType");
		IsGamepadType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGamepadType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsGamepadType_ReturnValue_PropertyAddress, IsGamepadType_FunctionAddress, "ReturnValue");
		IsGamepadType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsGamepadType_FunctionAddress, "ReturnValue");
		IsGamepadType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsGamepadType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGamepadType_IsValid = IsGamepadType_FunctionAddress != IntPtr.Zero && IsGamepadType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibInput:IsGamepadType", IsGamepadType_IsValid);
		SetSuperUserInputMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSuperUserInputMode");
		SetSuperUserInputMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSuperUserInputMode_FunctionAddress);
		SetSuperUserInputMode_WorldContext_Offset = NativeReflection.GetPropertyOffset(SetSuperUserInputMode_FunctionAddress, "WorldContext");
		SetSuperUserInputMode_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(SetSuperUserInputMode_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetSuperUserInputMode_IsOpen_PropertyAddress, SetSuperUserInputMode_FunctionAddress, "IsOpen");
		SetSuperUserInputMode_IsOpen_Offset = NativeReflection.GetPropertyOffset(SetSuperUserInputMode_FunctionAddress, "IsOpen");
		SetSuperUserInputMode_IsOpen_IsValid = NativeReflection.ValidatePropertyClass(SetSuperUserInputMode_FunctionAddress, "IsOpen", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetSuperUserInputMode_ChangeReason_PropertyAddress, SetSuperUserInputMode_FunctionAddress, "ChangeReason");
		SetSuperUserInputMode_ChangeReason_Offset = NativeReflection.GetPropertyOffset(SetSuperUserInputMode_FunctionAddress, "ChangeReason");
		SetSuperUserInputMode_ChangeReason_IsValid = NativeReflection.ValidatePropertyClass(SetSuperUserInputMode_FunctionAddress, "ChangeReason", Classes.FEnumProperty);
		SetSuperUserInputMode_IsValid = SetSuperUserInputMode_FunctionAddress != IntPtr.Zero && SetSuperUserInputMode_WorldContext_IsValid && SetSuperUserInputMode_IsOpen_IsValid && SetSuperUserInputMode_ChangeReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibInput:SetSuperUserInputMode", SetSuperUserInputMode_IsValid);
		OpenAcceptNavigationAction_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OpenAcceptNavigationAction");
		OpenAcceptNavigationAction_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenAcceptNavigationAction_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OpenAcceptNavigationAction_bOpen_PropertyAddress, OpenAcceptNavigationAction_FunctionAddress, "bOpen");
		OpenAcceptNavigationAction_bOpen_Offset = NativeReflection.GetPropertyOffset(OpenAcceptNavigationAction_FunctionAddress, "bOpen");
		OpenAcceptNavigationAction_bOpen_IsValid = NativeReflection.ValidatePropertyClass(OpenAcceptNavigationAction_FunctionAddress, "bOpen", Classes.FBoolProperty);
		OpenAcceptNavigationAction_IsValid = OpenAcceptNavigationAction_FunctionAddress != IntPtr.Zero && OpenAcceptNavigationAction_bOpen_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibInput:OpenAcceptNavigationAction", OpenAcceptNavigationAction_IsValid);
	}

	static BGUFuncLibInput()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibInput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibInput));
	}
}
