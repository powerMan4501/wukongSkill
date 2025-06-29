using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.AI.Task;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill")]
internal class BAIT_MoveToSceneItemAndCastSkill : BAIT_Base
{
	private int CastingSkillID = -1;

	private bool IsBeingAbort;

	private bool IsCastFailed;

	private static bool BeginRotateAngle_IsValid;

	private static int BeginRotateAngle_Offset;

	private static bool IsUseSkillForTurn_IsValid;

	private static int IsUseSkillForTurn_Offset;

	private static FFieldAddress IsUseSkillForTurn_PropertyAddress;

	private static bool MoveToSceneItemCastSkill_IsValid;

	private static int MoveToSceneItemCastSkill_Offset;

	private static bool EnableRetryAimToSceneItem_IsValid;

	private static int EnableRetryAimToSceneItem_Offset;

	private static FFieldAddress EnableRetryAimToSceneItem_PropertyAddress;

	private static bool RetryAimToSceneItemLimitTime_IsValid;

	private static int RetryAimToSceneItemLimitTime_Offset;

	private static bool MoveToBuff_IsValid;

	private static int MoveToBuff_Offset;

	private static bool MoveToBuffDuration_IsValid;

	private static int MoveToBuffDuration_Offset;

	private static bool SignatrueBuff_IsValid;

	private static int SignatrueBuff_Offset;

	private static bool MoveToAllowOffset_IsValid;

	private static int MoveToAllowOffset_Offset;

	[Category("移动对准")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:BeginRotateAngle")]
	public float BeginRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:BeginRotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:BeginRotateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset), value);
			}
		}
	}

	[Category("移动对准")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("使用技能旋转")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:IsUseSkillForTurn")]
	public bool IsUseSkillForTurn
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:IsUseSkillForTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:IsUseSkillForTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address, value);
			}
		}
	}

	[Category("移动对准")]
	[DisplayName("移动至SceneItem的技能")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToSceneItemCastSkill")]
	public int MoveToSceneItemCastSkill
	{
		get
		{
			CheckDestroyed();
			if (!MoveToSceneItemCastSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToSceneItemCastSkill");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MoveToSceneItemCastSkill_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveToSceneItemCastSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToSceneItemCastSkill");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MoveToSceneItemCastSkill_Offset), value);
			}
		}
	}

	[Category("移动对准")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("对准失败时(例如被打断)会再次对准")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:EnableRetryAimToSceneItem")]
	public bool EnableRetryAimToSceneItem
	{
		get
		{
			CheckDestroyed();
			if (!EnableRetryAimToSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:EnableRetryAimToSceneItem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRetryAimToSceneItem_Offset), 0, EnableRetryAimToSceneItem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRetryAimToSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:EnableRetryAimToSceneItem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRetryAimToSceneItem_Offset), 0, EnableRetryAimToSceneItem_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("对准失败时再次对准次数上限")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("移动对准")]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:RetryAimToSceneItemLimitTime")]
	public int RetryAimToSceneItemLimitTime
	{
		get
		{
			CheckDestroyed();
			if (!RetryAimToSceneItemLimitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:RetryAimToSceneItemLimitTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RetryAimToSceneItemLimitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RetryAimToSceneItemLimitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:RetryAimToSceneItemLimitTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RetryAimToSceneItemLimitTime_Offset), value);
			}
		}
	}

	[Category("BUFF")]
	[DisplayName("移动对准过程中上的buff")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToBuff")]
	public int MoveToBuff
	{
		get
		{
			CheckDestroyed();
			if (!MoveToBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToBuff");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MoveToBuff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveToBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToBuff");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MoveToBuff_Offset), value);
			}
		}
	}

	[Category("BUFF")]
	[BlueprintReadWrite]
	[DisplayName("移动对准过程中上的buff时长")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToBuffDuration")]
	public float MoveToBuffDuration
	{
		get
		{
			CheckDestroyed();
			if (!MoveToBuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToBuffDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveToBuffDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveToBuffDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToBuffDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveToBuffDuration_Offset), value);
			}
		}
	}

	[DisplayName("当前节点标志buff")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BUFF")]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:SignatrueBuff")]
	public int SignatrueBuff
	{
		get
		{
			CheckDestroyed();
			if (!SignatrueBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:SignatrueBuff");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SignatrueBuff_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SignatrueBuff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:SignatrueBuff");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SignatrueBuff_Offset), value);
			}
		}
	}

	[Category("移动对准")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("移动对准位置误差容许值")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToAllowOffset")]
	public float MoveToAllowOffset
	{
		get
		{
			CheckDestroyed();
			if (!MoveToAllowOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToAllowOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveToAllowOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveToAllowOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill:MoveToAllowOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveToAllowOffset_Offset), value);
			}
		}
	}

	private EMoveToSceneItemAndCastSkillState State { get; set; }

	private IBUC_SceneItemData SceneItemData { get; set; }

	private int RetryTimes { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		IsBeingAbort = false;
		IsCastFailed = false;
		State = EMoveToSceneItemAndCastSkillState.None;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		SceneItemData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(aCharacter);
		if (SceneItemData != null && SceneItemData.HasSceneItemCatch())
		{
			BGUFunctionLibraryCS.BGUAddBuff(aCharacter, aCharacter, SignatrueBuff, EBuffSourceType.BAIT, -1f);
			BGUFunctionLibraryCS.BGUAddBuff(aCharacter, aCharacter, MoveToBuff, EBuffSourceType.BAIT, MoveToBuffDuration);
			TryBeginRotateToSceneItem(aCharacter);
		}
		else
		{
			State = EMoveToSceneItemAndCastSkillState.None;
			IsCastFailed = true;
			BGUFunctionLibraryCS.BGURemoveBuff(aCharacter, MoveToBuff, EBuffEffectTriggerType.None, 1);
			FinishExecute(bSuccess: false);
		}
	}

	private bool TryBeginRotateToSceneItem(ACharacter OwnerCharacter)
	{
		if (SceneItemData == null || !SceneItemData.HasSceneItemCatch())
		{
			State = EMoveToSceneItemAndCastSkillState.None;
			BGUFunctionLibraryCS.BGURemoveBuff(OwnerCharacter, MoveToBuff, EBuffEffectTriggerType.None, 1);
			IsCastFailed = true;
			return false;
		}
		FVector finalLocation = GetFinalLocation(OwnerCharacter as ABGUCharacter, BGUFuncLibActorTransformCS.BGUGetActorTransform(SceneItemData.SceneItemCatch).GetLocation());
		AIFuncLibForCS.GetTurnAngle(OwnerCharacter, finalLocation, out var AbsDegValue, out var IsClockwise);
		if (AbsDegValue > BeginRotateAngle)
		{
			if (IsUseSkillForTurn)
			{
				int turnSkillIDByAngle = AIFuncLibForCS.GetTurnSkillIDByAngle(OwnerCharacter, AbsDegValue, IsClockwise);
				BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(OwnerCharacter, turnSkillIDByAngle, ECastSkillSourceType.BT);
			}
			else
			{
				float turnSpeed = AIFuncLibForCS.GetTurnSpeed(OwnerCharacter, AbsDegValue);
				BGUFuncLibForMove.BeginRotateToTargetPos(OwnerCharacter, finalLocation, turnSpeed, out var _);
			}
			State = EMoveToSceneItemAndCastSkillState.RotateToSceneItem;
			return true;
		}
		State = EMoveToSceneItemAndCastSkillState.MoveToSceneItem;
		return false;
	}

	private bool TryBeginMoveToSceneItem(ABGUCharacter OwnerCharacter)
	{
		if (TryCastSkillMoveToSceneItem(OwnerCharacter))
		{
			State = EMoveToSceneItemAndCastSkillState.MoveToSceneItem;
			return true;
		}
		State = EMoveToSceneItemAndCastSkillState.MoveToSceneItem;
		return false;
	}

	private bool TryCastSkillMoveToSceneItem(ABGUCharacter OwnerCharacter)
	{
		int num = InitSkillID(ESkillIDSource.Custom, MoveToSceneItemCastSkill);
		if (num <= 0)
		{
			return false;
		}
		return CastWithSkillID(OwnerCharacter, num);
	}

	private bool TryCastSkillFromSceneItem(ABGUCharacter OwnerCharacter)
	{
		int num = InitSkillID(ESkillIDSource.FromSceneItem, 0);
		if (num <= 0 || !CastWithSkillID(OwnerCharacter, num))
		{
			if (BGUFunctionLibraryCS.BGUHasUnitState(OwnerCharacter, EBGUUnitState.Attacking))
			{
				State = EMoveToSceneItemAndCastSkillState.TryCastSkill;
				return false;
			}
			CastingSkillID = -1;
			State = EMoveToSceneItemAndCastSkillState.None;
			BGUFunctionLibraryCS.BGURemoveBuff(OwnerCharacter, MoveToBuff, EBuffEffectTriggerType.None, 1);
			IsCastFailed = true;
			return false;
		}
		CastingSkillID = num;
		State = EMoveToSceneItemAndCastSkillState.CastingSkill;
		return true;
	}

	private int InitSkillID(ESkillIDSource SkillIDSource, int SkillID)
	{
		if (SkillIDSource != ESkillIDSource.Custom && SkillIDSource == ESkillIDSource.FromSceneItem && SceneItemData != null)
		{
			BUC_SceneItemCommData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(SceneItemData.SceneItemCatch);
			if (readOnlyData != null)
			{
				SkillID = readOnlyData.SkillID;
			}
		}
		return SkillID;
	}

	private bool CastWithSkillID(ABGUCharacter Unit, int SkillID)
	{
		if (BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(Unit, SkillID, ECastSkillSourceType.BT) > 0)
		{
			SetGlobalLastAttackInfo(Unit);
			return true;
		}
		return false;
	}

	private void SetGlobalLastAttackInfo(ABGUCharacter Unit)
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Unit);
		if (USystemLibrary.IsValid(aActor))
		{
			float timeSeconds = UGameplayStatics.GetTimeSeconds(this);
			BUS_EventCollectionCS.Get(Unit).Evt_SetLastAttackTime.Invoke(timeSeconds);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetBeHitTime.Invoke(timeSeconds);
				bUS_GSEventCollection.Evt_SetLastAttackerID.Invoke(Unit);
			}
		}
	}

	private FVector GetFinalLocation(ABGUCharacter CharacterCS, FVector InTargetLocation)
	{
		FVector result = InTargetLocation;
		UCapsuleComponent uCapsuleComponent = CharacterCS.GetRootComponent() as UCapsuleComponent;
		if (uCapsuleComponent == null)
		{
			return result;
		}
		float scaledCapsuleHalfHeight = uCapsuleComponent.GetScaledCapsuleHalfHeight();
		float scaledCapsuleHalfHeight2 = uCapsuleComponent.GetScaledCapsuleHalfHeight();
		float num = 2.4f;
		FVector start = InTargetLocation + FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
		FVector end = InTargetLocation - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
		if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(this, start, end, scaledCapsuleHalfHeight2, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, CharacterCS, out var OutHitLocation))
		{
			result = OutHitLocation + num;
		}
		return result;
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (IsBeingAbort)
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking))
			{
				RetryTimes = 0;
				State = EMoveToSceneItemAndCastSkillState.None;
				BGUFunctionLibraryCS.BGURemoveBuff(OwnerActor, MoveToBuff, EBuffEffectTriggerType.None, 1);
				FinishAbort();
			}
			return;
		}
		if (SceneItemData == null || !SceneItemData.HasSceneItemCatch())
		{
			State = EMoveToSceneItemAndCastSkillState.None;
			BGUFunctionLibraryCS.BGURemoveBuff(OwnerActor, MoveToBuff, EBuffEffectTriggerType.None, 1);
			IsCastFailed = true;
		}
		if (IsCastFailed)
		{
			RetryTimes = 0;
			State = EMoveToSceneItemAndCastSkillState.None;
			BGUFunctionLibraryCS.BGURemoveBuff(OwnerActor, MoveToBuff, EBuffEffectTriggerType.None, 1);
			FinishExecute(bSuccess: false);
			return;
		}
		FVector finalLocation = GetFinalLocation(aBGUCharacter, BGUFuncLibActorTransformCS.BGUGetActorTransform(SceneItemData.SceneItemCatch).GetLocation());
		switch (State)
		{
		case EMoveToSceneItemAndCastSkillState.RotateToSceneItem:
		{
			if (BGUFuncLibForMove.IsMoveActive(aBGUCharacter))
			{
				break;
			}
			AIFuncLibForCS.GetTurnAngle(aBGUCharacter, finalLocation, out var AbsDegValue2, out var _);
			if (AbsDegValue2 > BeginRotateAngle)
			{
				if (!EnableRetryAimToSceneItem || RetryTimes > RetryAimToSceneItemLimitTime)
				{
					State = EMoveToSceneItemAndCastSkillState.None;
					BGUFunctionLibraryCS.BGURemoveBuff(OwnerActor, MoveToBuff, EBuffEffectTriggerType.None, 1);
					IsCastFailed = true;
				}
				else
				{
					TryBeginRotateToSceneItem(aBGUCharacter);
					RetryTimes++;
				}
			}
			else
			{
				TryBeginMoveToSceneItem(aBGUCharacter);
			}
			break;
		}
		case EMoveToSceneItemAndCastSkillState.MoveToSceneItem:
		{
			if (BGUFuncLibForMove.IsMoveActive(aBGUCharacter))
			{
				break;
			}
			AIFuncLibForCS.GetTurnAngle(aBGUCharacter, finalLocation, out var _, out var _);
			if ((finalLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(aBGUCharacter)).Size() > MoveToAllowOffset)
			{
				if (!EnableRetryAimToSceneItem || RetryTimes > RetryAimToSceneItemLimitTime)
				{
					State = EMoveToSceneItemAndCastSkillState.None;
					BGUFunctionLibraryCS.BGURemoveBuff(OwnerActor, MoveToBuff, EBuffEffectTriggerType.None, 1);
					IsCastFailed = true;
					break;
				}
				if (TryBeginMoveToSceneItem(aBGUCharacter))
				{
					break;
				}
			}
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking) || BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.InComboWindow))
			{
				TryCastSkillFromSceneItem(aBGUCharacter);
			}
			break;
		}
		case EMoveToSceneItemAndCastSkillState.TryCastSkill:
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking) || BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.InComboWindow))
			{
				TryCastSkillFromSceneItem(aBGUCharacter);
			}
			break;
		case EMoveToSceneItemAndCastSkillState.CastingSkill:
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking) || BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.InComboWindow))
			{
				FinishExecute(bSuccess: true);
			}
			break;
		case (EMoveToSceneItemAndCastSkillState)1:
			break;
		case EMoveToSceneItemAndCastSkillState.None:
			break;
		}
	}

	public override void ReceiveAbort(AActor OwnerActor)
	{
		IsBeingAbort = true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_MoveToSceneItemAndCastSkill");
		BeginRotateAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginRotateAngle");
		BeginRotateAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginRotateAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsUseSkillForTurn_PropertyAddress, unrealStruct, "IsUseSkillForTurn");
		IsUseSkillForTurn_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsUseSkillForTurn");
		IsUseSkillForTurn_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsUseSkillForTurn", Classes.FBoolProperty);
		MoveToSceneItemCastSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveToSceneItemCastSkill");
		MoveToSceneItemCastSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveToSceneItemCastSkill", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EnableRetryAimToSceneItem_PropertyAddress, unrealStruct, "EnableRetryAimToSceneItem");
		EnableRetryAimToSceneItem_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableRetryAimToSceneItem");
		EnableRetryAimToSceneItem_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableRetryAimToSceneItem", Classes.FBoolProperty);
		RetryAimToSceneItemLimitTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RetryAimToSceneItemLimitTime");
		RetryAimToSceneItemLimitTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RetryAimToSceneItemLimitTime", Classes.FIntProperty);
		MoveToBuff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveToBuff");
		MoveToBuff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveToBuff", Classes.FIntProperty);
		MoveToBuffDuration_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveToBuffDuration");
		MoveToBuffDuration_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveToBuffDuration", Classes.FFloatProperty);
		SignatrueBuff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SignatrueBuff");
		SignatrueBuff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SignatrueBuff", Classes.FIntProperty);
		MoveToAllowOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveToAllowOffset");
		MoveToAllowOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveToAllowOffset", Classes.FFloatProperty);
	}

	static BAIT_MoveToSceneItemAndCastSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGU.AI.Task.BAIT_MoveToSceneItemAndCastSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGU.AI.Task.BAIT_MoveToSceneItemAndCastSkill));
	}
}
