using System;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibSkillCS")]
public class BGUFuncLibSkillCS : UBlueprintFunctionLibrary
{
	private static bool BGUGetLastSkillID_IsValid;

	private static IntPtr BGUGetLastSkillID_FunctionAddress;

	private static int BGUGetLastSkillID_ParamsSize;

	private static bool BGUGetLastSkillID_Unit_IsValid;

	private static int BGUGetLastSkillID_Unit_Offset;

	private static bool BGUGetLastSkillID_ReturnValue_IsValid;

	private static int BGUGetLastSkillID_ReturnValue_Offset;

	private static bool BGUGetCastingSkillID_IsValid;

	private static IntPtr BGUGetCastingSkillID_FunctionAddress;

	private static int BGUGetCastingSkillID_ParamsSize;

	private static bool BGUGetCastingSkillID_Unit_IsValid;

	private static int BGUGetCastingSkillID_Unit_Offset;

	private static bool BGUGetCastingSkillID_ReturnValue_IsValid;

	private static int BGUGetCastingSkillID_ReturnValue_Offset;

	private static bool BGUGetLastSkillCastTime_IsValid;

	private static IntPtr BGUGetLastSkillCastTime_FunctionAddress;

	private static int BGUGetLastSkillCastTime_ParamsSize;

	private static bool BGUGetLastSkillCastTime_Unit_IsValid;

	private static int BGUGetLastSkillCastTime_Unit_Offset;

	private static bool BGUGetLastSkillCastTime_SkillID_IsValid;

	private static int BGUGetLastSkillCastTime_SkillID_Offset;

	private static bool BGUGetLastSkillCastTime_ReturnValue_IsValid;

	private static int BGUGetLastSkillCastTime_ReturnValue_Offset;

	private static bool BGUCalcSkillMontageScaleRate_IsValid;

	private static IntPtr BGUCalcSkillMontageScaleRate_FunctionAddress;

	private static int BGUCalcSkillMontageScaleRate_ParamsSize;

	private static bool BGUCalcSkillMontageScaleRate_Unit_IsValid;

	private static int BGUCalcSkillMontageScaleRate_Unit_Offset;

	private static bool BGUCalcSkillMontageScaleRate_TargetPos_IsValid;

	private static int BGUCalcSkillMontageScaleRate_TargetPos_Offset;

	private static FFieldAddress BGUCalcSkillMontageScaleRate_TargetPos_PropertyAddress;

	private static bool BGUCalcSkillMontageScaleRate_NotifyBeginTime_IsValid;

	private static int BGUCalcSkillMontageScaleRate_NotifyBeginTime_Offset;

	private static bool BGUCalcSkillMontageScaleRate_NotifyEndTime_IsValid;

	private static int BGUCalcSkillMontageScaleRate_NotifyEndTime_Offset;

	private static bool BGUCalcSkillMontageScaleRate_AMScaleMinRate_IsValid;

	private static int BGUCalcSkillMontageScaleRate_AMScaleMinRate_Offset;

	private static bool BGUCalcSkillMontageScaleRate_AMScaleMaxRate_IsValid;

	private static int BGUCalcSkillMontageScaleRate_AMScaleMaxRate_Offset;

	private static bool BGUCalcSkillMontageScaleRate_AMScaleMoveOffset_IsValid;

	private static int BGUCalcSkillMontageScaleRate_AMScaleMoveOffset_Offset;

	private static bool BGUCalcSkillMontageScaleRate_AMScaleMoveOffsetZ_IsValid;

	private static int BGUCalcSkillMontageScaleRate_AMScaleMoveOffsetZ_Offset;

	private static bool BGUCalcSkillMontageScaleRate_EnableDebug_IsValid;

	private static int BGUCalcSkillMontageScaleRate_EnableDebug_Offset;

	private static FFieldAddress BGUCalcSkillMontageScaleRate_EnableDebug_PropertyAddress;

	private static bool BGUCalcSkillMontageScaleRate_ReturnValue_IsValid;

	private static int BGUCalcSkillMontageScaleRate_ReturnValue_Offset;

	private static FFieldAddress BGUCalcSkillMontageScaleRate_ReturnValue_PropertyAddress;

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Skill")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetLastSkillID")]
	public static int BGUGetLastSkillID(AActor Unit)
	{
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit)?.GetLastSkillID() ?? 0;
	}

	[UFunction]
	[BlueprintPure]
	[Category("BGU|Skill")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetLastSkillCastTime")]
	public static float BGUGetLastSkillCastTime(AActor Unit, int SkillID)
	{
		if (Unit == null)
		{
			return 0f;
		}
		return BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Unit)?.GetLastSkillCastTime(SkillID) ?? 0f;
	}

	[Category("BGU|Skill")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetCastingSkillID")]
	public static int BGUGetCastingSkillID(ACharacter Unit)
	{
		UAnimInstance uAnimInstance = null;
		USkeletalMeshComponent mesh = Unit.Mesh;
		if (mesh != null)
		{
			uAnimInstance = mesh.GetAnimInstance();
		}
		int num = AnimFuncLib.GetActiveMontageInstanceID(uAnimInstance.Address);
		if (num > -1)
		{
			BUC_AnimNotifyAndStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AnimNotifyAndStateData>(Unit);
			if (unPersistentReadOnlyData != null)
			{
				return unPersistentReadOnlyData.FindBindingSkillID(num);
			}
		}
		return -1;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Skill")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibSkillCS:BGUCalcSkillMontageScaleRate")]
	public static FVector BGUCalcSkillMontageScaleRate(ACharacter Unit, FVector TargetPos, float NotifyBeginTime, float NotifyEndTime, float AMScaleMinRate = 0f, float AMScaleMaxRate = 0f, float AMScaleMoveOffset = 0f, float AMScaleMoveOffsetZ = 0f, bool EnableDebug = false)
	{
		float num = 1f;
		float num2 = 1f;
		UAnimInstance uAnimInstance = null;
		USkeletalMeshComponent mesh = Unit.Mesh;
		if (mesh != null)
		{
			uAnimInstance = mesh.GetAnimInstance();
		}
		int num3 = AnimFuncLib.GetActiveMontageInstanceID(uAnimInstance.Address);
		if (num3 > -1)
		{
			BUC_AnimNotifyAndStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AnimNotifyAndStateData>(Unit);
			if (unPersistentReadOnlyData != null)
			{
				UAnimMontage currentActiveMontage = uAnimInstance.GetCurrentActiveMontage();
				if (currentActiveMontage != null)
				{
					FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
					float num4 = (fVector - TargetPos).Size2D();
					float num5 = FMath.Abs(fVector.Z - TargetPos.Z);
					FVector OutStartPos;
					FVector OutEndPos;
					float num6 = (UGSE_AnimFuncLib.AnimMontageGetRootMotionLocationForScale(currentActiveMontage, out OutStartPos, out OutEndPos, NotifyBeginTime, NotifyEndTime) ? (OutEndPos - OutStartPos) : FVector.ZeroVector).Size2D();
					float num7 = FMath.Abs(OutStartPos.Z - OutEndPos.Z);
					float num8 = ((mesh.RelativeScale3D.X > 0f) ? mesh.RelativeScale3D.X : 1f);
					float num9 = ((Unit.CapsuleComponent.RelativeScale3D.X > 0f) ? Unit.CapsuleComponent.RelativeScale3D.X : 1f);
					num4 += AMScaleMoveOffset;
					num5 += AMScaleMoveOffsetZ;
					num4 = ((num4 > 0f) ? num4 : 0f);
					num5 = ((num5 > 0f) ? num5 : 0f);
					if (num6 != 0f)
					{
						num = num4 / num6;
					}
					if (num7 != 0f)
					{
						num2 = num5 / num7;
					}
					num /= num8 * num9;
					num2 /= num8 * num9;
					FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(unPersistentReadOnlyData.FindBindingSkillID(num3), Unit);
					if (AMScaleMaxRate <= 0f)
					{
						if (skillSDesc != null)
						{
							num = ((num < skillSDesc.MoveSkillDisMaxRate) ? num : skillSDesc.MoveSkillDisMaxRate);
							num2 = ((num2 < skillSDesc.MoveSkillDisMaxRate) ? num2 : skillSDesc.MoveSkillDisMaxRate);
						}
					}
					else
					{
						num = ((num < AMScaleMaxRate) ? num : AMScaleMaxRate);
						num2 = ((num2 < AMScaleMaxRate) ? num2 : AMScaleMaxRate);
					}
					if (AMScaleMinRate <= 0f)
					{
						if (skillSDesc != null)
						{
							num = ((num > skillSDesc.MoveSkillDisMinRate) ? num : skillSDesc.MoveSkillDisMinRate);
							num2 = ((num2 > skillSDesc.MoveSkillDisMinRate) ? num2 : skillSDesc.MoveSkillDisMinRate);
						}
					}
					else
					{
						num = ((num > AMScaleMinRate) ? num : AMScaleMinRate);
						num2 = ((num2 > AMScaleMinRate) ? num2 : AMScaleMinRate);
					}
					if (EnableDebug)
					{
						FVector safeNormal = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Unit).GetSafeNormal();
						USystemLibrary.DrawDebugArrow(Unit, fVector, TargetPos, 20f, FLinearColor.Green, 10f, 10f);
						USystemLibrary.DrawDebugArrow(Unit, fVector, fVector + safeNormal * num6, 40f, FLinearColor.Red, 10f, 15f);
						USystemLibrary.DrawDebugArrow(Unit, fVector, fVector + safeNormal * num4, 30f, FLinearColor.Black, 10f, 20f);
					}
				}
			}
		}
		return new FVector(num, 1.0, num2);
	}

	public static int BGUGetSkillIDByMapping(AActor Owner, int SkillID)
	{
		if (Owner == null)
		{
			return SkillID;
		}
		int num = SkillID;
		BUS_EventCollectionCS.Get(Owner).Evt_OnSkillMappingStart.Invoke(SkillID);
		IBUC_SkillMappingData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillMappingData, BUC_SkillMappingData>(Owner);
		if (readOnlyData != null)
		{
			num = readOnlyData.GetCurResultSkillID(SkillID);
		}
		if (num == -1)
		{
			num = SkillID;
		}
		return num;
	}

	public static FGSMeleeAutoLockSetting BGUGetCurrentMeleeAutoLockSetting(AActor Owner, int SkillID)
	{
		if (Owner.IsNullOrDestroyed())
		{
			return default(FGSMeleeAutoLockSetting);
		}
		BUC_PlayerCameraData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(Owner);
		IBUC_PlayerInputConfigData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(Owner);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null)
		{
			return default(FGSMeleeAutoLockSetting);
		}
		if (unPersistentReadOnlyData.IsInG4Mode())
		{
			return unPersistentReadOnlyData2.G4MeleeAutoLockSetting;
		}
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc != null)
		{
			return new FGSMeleeAutoLockSetting(playerSkillCtrlDesc.AttackRange, playerSkillCtrlDesc.SelectShapeParam3, unPersistentReadOnlyData2.NormalMeleeAutoLockSetting.TurnSpeed, unPersistentReadOnlyData2.NormalMeleeAutoLockSetting.PreferActorDistTolerance, playerSkillCtrlDesc.DistScoreRating, playerSkillCtrlDesc.HeightScoreRating, playerSkillCtrlDesc.AngleScoreRating, playerSkillCtrlDesc.AttackSelectZLimit, playerSkillCtrlDesc.PelvisExtraScore, playerSkillCtrlDesc.AutoLockPreferPelvis == EGSYesNo.Yes);
		}
		return default(FGSMeleeAutoLockSetting);
	}

	public static float GetSkillCDTimePercent(AActor SkillOwner, int SkillID, in IBUC_SkillInstsData SkillInstsData)
	{
		if (SkillInstsData == null)
		{
			return 0f;
		}
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, SkillOwner);
		if (skillSDesc != null)
		{
			float cooldownTime = skillSDesc.CooldownTime;
			float preCooldownTime = skillSDesc.PreCooldownTime;
			if (cooldownTime <= 0f && cooldownTime <= 0f)
			{
				return 0f;
			}
			SkillInstsData.GetSkillCooldownTime(SkillID, out var RemainingCooldownTime, out var RemainingPreCooldownTime);
			if (RemainingCooldownTime > 0f)
			{
				return RemainingCooldownTime / cooldownTime;
			}
			if (RemainingPreCooldownTime > 0f)
			{
				return RemainingPreCooldownTime / preCooldownTime;
			}
		}
		return 0f;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetLastSkillID")]
	private static void BGUGetLastSkillID__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetLastSkillID_Unit_Offset));
		int value = BGUGetLastSkillID(unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetLastSkillID_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetCastingSkillID")]
	private static void BGUGetCastingSkillID__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACharacter unit = UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(buffer, BGUGetCastingSkillID_Unit_Offset));
		int value = BGUGetCastingSkillID(unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetCastingSkillID_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetLastSkillCastTime")]
	private static void BGUGetLastSkillCastTime__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetLastSkillCastTime_Unit_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUGetLastSkillCastTime_SkillID_Offset));
		float value = BGUGetLastSkillCastTime(unit, skillID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, BGUGetLastSkillCastTime_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibSkillCS:BGUCalcSkillMontageScaleRate")]
	private static void BGUCalcSkillMontageScaleRate__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACharacter unit = UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_Unit_Offset));
		FVector targetPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_TargetPos_Offset));
		float notifyBeginTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_NotifyBeginTime_Offset));
		float notifyEndTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_NotifyEndTime_Offset));
		float aMScaleMinRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_AMScaleMinRate_Offset));
		float aMScaleMaxRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_AMScaleMaxRate_Offset));
		float aMScaleMoveOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_AMScaleMoveOffset_Offset));
		float aMScaleMoveOffsetZ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_AMScaleMoveOffsetZ_Offset));
		bool enableDebug = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_EnableDebug_Offset), 0, BGUCalcSkillMontageScaleRate_EnableDebug_PropertyAddress.Address);
		FVector value = BGUCalcSkillMontageScaleRate(unit, targetPos, notifyBeginTime, notifyEndTime, aMScaleMinRate, aMScaleMaxRate, aMScaleMoveOffset, aMScaleMoveOffsetZ, enableDebug);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, BGUCalcSkillMontageScaleRate_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibSkillCS");
		BGUGetLastSkillID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetLastSkillID");
		BGUGetLastSkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetLastSkillID_FunctionAddress);
		BGUGetLastSkillID_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGetLastSkillID_FunctionAddress, "Unit");
		BGUGetLastSkillID_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLastSkillID_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUGetLastSkillID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetLastSkillID_FunctionAddress, "ReturnValue");
		BGUGetLastSkillID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLastSkillID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetLastSkillID_IsValid = BGUGetLastSkillID_FunctionAddress != IntPtr.Zero && BGUGetLastSkillID_Unit_IsValid && BGUGetLastSkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetLastSkillID", BGUGetLastSkillID_IsValid);
		BGUGetCastingSkillID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetCastingSkillID");
		BGUGetCastingSkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetCastingSkillID_FunctionAddress);
		BGUGetCastingSkillID_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGetCastingSkillID_FunctionAddress, "Unit");
		BGUGetCastingSkillID_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGetCastingSkillID_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUGetCastingSkillID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetCastingSkillID_FunctionAddress, "ReturnValue");
		BGUGetCastingSkillID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetCastingSkillID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetCastingSkillID_IsValid = BGUGetCastingSkillID_FunctionAddress != IntPtr.Zero && BGUGetCastingSkillID_Unit_IsValid && BGUGetCastingSkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetCastingSkillID", BGUGetCastingSkillID_IsValid);
		BGUGetLastSkillCastTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetLastSkillCastTime");
		BGUGetLastSkillCastTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetLastSkillCastTime_FunctionAddress);
		BGUGetLastSkillCastTime_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGetLastSkillCastTime_FunctionAddress, "Unit");
		BGUGetLastSkillCastTime_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLastSkillCastTime_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUGetLastSkillCastTime_SkillID_Offset = NativeReflection.GetPropertyOffset(BGUGetLastSkillCastTime_FunctionAddress, "SkillID");
		BGUGetLastSkillCastTime_SkillID_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLastSkillCastTime_FunctionAddress, "SkillID", Classes.FIntProperty);
		BGUGetLastSkillCastTime_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetLastSkillCastTime_FunctionAddress, "ReturnValue");
		BGUGetLastSkillCastTime_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLastSkillCastTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetLastSkillCastTime_IsValid = BGUGetLastSkillCastTime_FunctionAddress != IntPtr.Zero && BGUGetLastSkillCastTime_Unit_IsValid && BGUGetLastSkillCastTime_SkillID_IsValid && BGUGetLastSkillCastTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibSkillCS:BGUGetLastSkillCastTime", BGUGetLastSkillCastTime_IsValid);
		BGUCalcSkillMontageScaleRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCalcSkillMontageScaleRate");
		BGUCalcSkillMontageScaleRate_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCalcSkillMontageScaleRate_FunctionAddress);
		BGUCalcSkillMontageScaleRate_Unit_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "Unit");
		BGUCalcSkillMontageScaleRate_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUCalcSkillMontageScaleRate_TargetPos_PropertyAddress, BGUCalcSkillMontageScaleRate_FunctionAddress, "TargetPos");
		BGUCalcSkillMontageScaleRate_TargetPos_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "TargetPos");
		BGUCalcSkillMontageScaleRate_TargetPos_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "TargetPos", Classes.FStructProperty);
		BGUCalcSkillMontageScaleRate_NotifyBeginTime_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "NotifyBeginTime");
		BGUCalcSkillMontageScaleRate_NotifyBeginTime_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "NotifyBeginTime", Classes.FFloatProperty);
		BGUCalcSkillMontageScaleRate_NotifyEndTime_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "NotifyEndTime");
		BGUCalcSkillMontageScaleRate_NotifyEndTime_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "NotifyEndTime", Classes.FFloatProperty);
		BGUCalcSkillMontageScaleRate_AMScaleMinRate_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMinRate");
		BGUCalcSkillMontageScaleRate_AMScaleMinRate_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMinRate", Classes.FFloatProperty);
		BGUCalcSkillMontageScaleRate_AMScaleMaxRate_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMaxRate");
		BGUCalcSkillMontageScaleRate_AMScaleMaxRate_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMaxRate", Classes.FFloatProperty);
		BGUCalcSkillMontageScaleRate_AMScaleMoveOffset_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMoveOffset");
		BGUCalcSkillMontageScaleRate_AMScaleMoveOffset_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMoveOffset", Classes.FFloatProperty);
		BGUCalcSkillMontageScaleRate_AMScaleMoveOffsetZ_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMoveOffsetZ");
		BGUCalcSkillMontageScaleRate_AMScaleMoveOffsetZ_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "AMScaleMoveOffsetZ", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BGUCalcSkillMontageScaleRate_EnableDebug_PropertyAddress, BGUCalcSkillMontageScaleRate_FunctionAddress, "EnableDebug");
		BGUCalcSkillMontageScaleRate_EnableDebug_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "EnableDebug");
		BGUCalcSkillMontageScaleRate_EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "EnableDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BGUCalcSkillMontageScaleRate_ReturnValue_PropertyAddress, BGUCalcSkillMontageScaleRate_FunctionAddress, "ReturnValue");
		BGUCalcSkillMontageScaleRate_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUCalcSkillMontageScaleRate_FunctionAddress, "ReturnValue");
		BGUCalcSkillMontageScaleRate_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcSkillMontageScaleRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BGUCalcSkillMontageScaleRate_IsValid = BGUCalcSkillMontageScaleRate_FunctionAddress != IntPtr.Zero && BGUCalcSkillMontageScaleRate_Unit_IsValid && BGUCalcSkillMontageScaleRate_TargetPos_IsValid && BGUCalcSkillMontageScaleRate_NotifyBeginTime_IsValid && BGUCalcSkillMontageScaleRate_NotifyEndTime_IsValid && BGUCalcSkillMontageScaleRate_AMScaleMinRate_IsValid && BGUCalcSkillMontageScaleRate_AMScaleMaxRate_IsValid && BGUCalcSkillMontageScaleRate_AMScaleMoveOffset_IsValid && BGUCalcSkillMontageScaleRate_AMScaleMoveOffsetZ_IsValid && BGUCalcSkillMontageScaleRate_EnableDebug_IsValid && BGUCalcSkillMontageScaleRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibSkillCS:BGUCalcSkillMontageScaleRate", BGUCalcSkillMontageScaleRate_IsValid);
	}

	static BGUFuncLibSkillCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibSkillCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibSkillCS));
	}
}
