using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_MoveToPerceivedTarget")]
internal class BAIT_MoveToPerceivedTarget : BAIT_Base
{
	private AActor AICharacter;

	private AActor PlayerCharacter;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveToPerceivedTarget:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToPerceivedTarget:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveToPerceivedTarget:AcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptableRadius_Offset), value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		PlayerCharacter = OwnerActor;
		UBUC_AIComponent unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<UBUC_AIComponent>(PlayerCharacter);
		BUS_EventCollectionCS.Get(PlayerCharacter).Evt_AIPerceptionSetting.Invoke(P1: true);
		AIFuncLib.SetAISenseConfig(unPersistentReadOnlyData.PerceptionComp.Address, 1000f, 4000f, 5000f, 90f, 0f, IsSightDominantSense: true, out var _, out var IsSightSet);
		if (unPersistentReadOnlyData == null && unPersistentReadOnlyData.PerceptionComp == null)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter == null)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		List<AActor> OutActors = new List<AActor>();
		if (IsSightSet)
		{
			unPersistentReadOnlyData.PerceptionComp.GetPerceivedHostileActors(out OutActors);
		}
		foreach (AActor item in OutActors)
		{
			if (BGU_DataUtil.GetActorType(item) == BGU_ActorType.CharacterAI)
			{
				AICharacter = item;
				break;
			}
		}
		int RequestIdx;
		if (OutActors.Count == 0)
		{
			FinishExecute(bSuccess: false);
		}
		else if (!BGUFuncLibForMove.BeginMoveToTarget(aCharacter, AICharacter, 500f, EAIMoveSpeedType.RUN, EBGUMoveAIType.KeepFacingTarget, IncludeSelfRadius: true, IncludeTargetRadius: true, out RequestIdx))
		{
			FinishExecute(bSuccess: false);
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		if (AICharacter == null || PlayerCharacter == null)
		{
			FinishExecute(bSuccess: false);
		}
		FVector2D fVector2D = AICharacter.GetActorLocation().Conv_VectorToVector2D();
		FVector2D fVector2D2 = PlayerCharacter.GetActorLocation().Conv_VectorToVector2D();
		if ((fVector2D - fVector2D2).Size() <= AcceptableRadius)
		{
			FinishExecute(bSuccess: true);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_MoveToPerceivedTarget");
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
	}

	static BAIT_MoveToPerceivedTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_MoveToPerceivedTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_MoveToPerceivedTarget));
	}
}
