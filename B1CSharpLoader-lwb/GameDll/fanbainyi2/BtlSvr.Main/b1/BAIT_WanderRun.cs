using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_WanderRun")]
internal class BAIT_WanderRun : BAIT_Base
{
	private bool bEQSDone;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	private static bool OwnerCharacter_IsValid;

	private static int OwnerCharacter_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_WanderRun:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_WanderRun:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:AcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptableRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_WanderRun:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_WanderRun:OwnerCharacter")]
	private ACharacter OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_WanderRun:OwnerCharacter");
			}
			else
			{
				UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(base.Address, OwnerCharacter_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		bEQSDone = false;
		OwnerCharacter = OwnerActor as ACharacter;
		BGS_EventCollectionCS.Get(this).Evt_BGS_EQSObjRun.Invoke(EQSTemplate, OwnerActor, EBGURunEQSObjReason.None, default(FGSEQSExParam), OnEQSFinish);
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter == null)
		{
			FinishExecute(bSuccess: false);
		}
		else if (bEQSDone && !BGUFuncLibForMove.IsMoveActive(aCharacter))
		{
			FinishExecute(bSuccess: true);
		}
	}

	public override void ReceiveAbort(AActor OwnerActor)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter == null)
		{
			FinishAbort();
			return;
		}
		BGUFuncLibForMove.CancelMove(aCharacter);
		FinishAbort();
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		bEQSDone = true;
		if (Result.Count > 0)
		{
			if (!BGUFuncLibForMove.BeginMoveToPos(OwnerCharacter, Result[0], AcceptableRadius, EAIMoveSpeedType.JOG, MoveAIType, IncludeSelfRadius: false, IncludeTargetRadius: false, out var _))
			{
				FinishExecute(bSuccess: false);
			}
		}
		else
		{
			FinishExecute(bSuccess: false);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_WanderRun");
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, unrealStruct, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAIType", Classes.FEnumProperty);
		OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OwnerCharacter", Classes.FObjectProperty);
	}

	static BAIT_WanderRun()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_WanderRun)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_WanderRun));
	}
}
