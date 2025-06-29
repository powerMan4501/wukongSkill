using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_MontageRootMotionMove")]
internal class BAIT_MontageRootMotionMove : BAIT_Base
{
	private static bool ScaleRate_IsValid;

	private static int ScaleRate_Offset;

	private static bool MoveMontage_IsValid;

	private static int MoveMontage_Offset;

	private static bool BK_Target_IsValid;

	private static int BK_Target_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MontageRootMotionMove:ScaleRate")]
	public float ScaleRate
	{
		get
		{
			CheckDestroyed();
			if (!ScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MontageRootMotionMove:ScaleRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScaleRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MontageRootMotionMove:ScaleRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScaleRate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_MontageRootMotionMove:MoveMontage")]
	public UAnimMontage MoveMontage
	{
		get
		{
			CheckDestroyed();
			if (!MoveMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MontageRootMotionMove:MoveMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, MoveMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MontageRootMotionMove:MoveMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, MoveMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MontageRootMotionMove:BK_Target")]
	public FBlackboardKeySelector BK_Target
	{
		get
		{
			CheckDestroyed();
			if (!BK_Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MontageRootMotionMove:BK_Target");
				return default(FBlackboardKeySelector);
			}
			return FBlackboardKeySelector.FromNative(IntPtr.Add(base.Address, BK_Target_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BK_Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MontageRootMotionMove:BK_Target");
			}
			else
			{
				FBlackboardKeySelector.ToNative(IntPtr.Add(base.Address, BK_Target_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter == null)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		if (ScaleRate > 0f)
		{
			if (!BGUFuncLibForMove.BeginMontageScaleMove(aCharacter, MoveMontage, ScaleRate, 1f, 0f, out var _))
			{
				FinishExecute(bSuccess: false);
			}
			return;
		}
		AActor blackboardValueAsActor = UBTFunctionLibrary.GetBlackboardValueAsActor(this, BK_Target);
		if (blackboardValueAsActor != null)
		{
			if (!BGUFuncLibForMove.BeginMontageMoveToTarget(aCharacter, MoveMontage, blackboardValueAsActor, 1f, 0f, out var _))
			{
				FinishExecute(bSuccess: false);
			}
			return;
		}
		FVector blackboardValueAsVector = UBTFunctionLibrary.GetBlackboardValueAsVector(this, BK_Target);
		if (!BGUFuncLibForMove.BeginMontageMoveToPos(aCharacter, MoveMontage, blackboardValueAsVector, 1f, 0f, out var _))
		{
			FinishExecute(bSuccess: false);
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter == null)
		{
			FinishExecute(bSuccess: false);
		}
		else if (!BGUFuncLibForMove.IsMoveActive(aCharacter))
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

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_MontageRootMotionMove");
		ScaleRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScaleRate");
		ScaleRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScaleRate", Classes.FFloatProperty);
		MoveMontage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveMontage");
		MoveMontage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveMontage", Classes.FObjectProperty);
		BK_Target_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BK_Target");
		BK_Target_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BK_Target", Classes.FStructProperty);
	}

	static BAIT_MontageRootMotionMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_MontageRootMotionMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_MontageRootMotionMove));
	}
}
