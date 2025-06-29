using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_TurnToTarget")]
internal class BAIT_TurnToTarget : BAIT_Base
{
	private bool IsBeingAbort;

	private static bool BTTargetType_IsValid;

	private static int BTTargetType_Offset;

	private static FFieldAddress BTTargetType_PropertyAddress;

	private static bool BeginRotateAngle_IsValid;

	private static int BeginRotateAngle_Offset;

	private static bool IsUseSkillForTurn_IsValid;

	private static int IsUseSkillForTurn_Offset;

	private static FFieldAddress IsUseSkillForTurn_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("如果选择Player，是指选择距离最近的Player")]
	[USharpPath("/Script/b1-Managed.BAIT_TurnToTarget:BTTargetType")]
	public EBTTargetType BTTargetType
	{
		get
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TurnToTarget:BTTargetType");
				return EBTTargetType.Target;
			}
			return EnumMarshaler<EBTTargetType>.FromNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TurnToTarget:BTTargetType");
			}
			else
			{
				EnumMarshaler<EBTTargetType>.ToNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_TurnToTarget:BeginRotateAngle")]
	public float BeginRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TurnToTarget:BeginRotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TurnToTarget:BeginRotateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_TurnToTarget:IsUseSkillForTurn")]
	public bool IsUseSkillForTurn
	{
		get
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TurnToTarget:IsUseSkillForTurn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUseSkillForTurn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TurnToTarget:IsUseSkillForTurn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUseSkillForTurn_Offset), 0, IsUseSkillForTurn_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		BTTargetType = EBTTargetType.Target;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitState(OwnerActor, EBGUUnitState.Attacking) || BGUFunctionLibraryCS.BGUHasUnitState(OwnerActor, EBGUUnitState.Beatback))
		{
			FinishExecute(bSuccess: true);
			return;
		}
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter != null)
		{
			IsBeingAbort = false;
			AActor aActor = null;
			switch (BTTargetType)
			{
			case EBTTargetType.Target:
				aActor = BGUFunctionLibraryCS.BGUGetTarget(aCharacter);
				break;
			case EBTTargetType.Player:
				aActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(this, BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter));
				break;
			case EBTTargetType.SceneItem:
			{
				BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(aCharacter);
				if (readOnlyData != null)
				{
					aActor = readOnlyData.SceneItemCatch;
				}
				break;
			}
			}
			if (aActor == null)
			{
				USystemLibrary.PrintString(this, "BAIT_TurnToTarget Failed, RotateToTarget is null!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
				FinishExecute(bSuccess: false);
			}
			else
			{
				BeginRotateTo(aCharacter, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor));
			}
		}
		else
		{
			USystemLibrary.PrintString(this, "BAIT_TurnToTarget Failed, OwnerCharacter is null!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
			FinishExecute(bSuccess: false);
		}
	}

	private void BeginRotateTo(ACharacter OwnerCharacter, FVector TargetPos)
	{
		AIFuncLibForCS.GetTurnAngle(OwnerCharacter, TargetPos, out var AbsDegValue, out var IsClockwise);
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
				BGUFuncLibForMove.BeginRotateToTargetPos(OwnerCharacter, TargetPos, turnSpeed, out var _);
			}
		}
		else
		{
			FinishExecute(bSuccess: true);
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (IsBeingAbort)
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking))
			{
				FinishAbort();
			}
		}
		else if (IsUseSkillForTurn)
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking))
			{
				FinishExecute(bSuccess: true);
			}
		}
		else if (!BGUFuncLibForMove.IsMoveActive(aBGUCharacter))
		{
			FinishExecute(bSuccess: true);
		}
	}

	public override void ReceiveAbort(AActor OwnerActor)
	{
		IsBeingAbort = true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_TurnToTarget");
		NativeReflection.GetPropertyRef(ref BTTargetType_PropertyAddress, unrealStruct, "BTTargetType");
		BTTargetType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BTTargetType");
		BTTargetType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BTTargetType", Classes.FEnumProperty);
		BeginRotateAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginRotateAngle");
		BeginRotateAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginRotateAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsUseSkillForTurn_PropertyAddress, unrealStruct, "IsUseSkillForTurn");
		IsUseSkillForTurn_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsUseSkillForTurn");
		IsUseSkillForTurn_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsUseSkillForTurn", Classes.FBoolProperty);
	}

	static BAIT_TurnToTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_TurnToTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_TurnToTarget));
	}
}
