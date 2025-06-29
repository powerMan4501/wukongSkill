using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

public static class UAIHelperLibrary_CsExtensions
{
	public static void UnlockAIResourcesWithAnimation(this UAnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic)
	{
		UAIHelperLibrary.UnlockAIResourcesWithAnimation(AnimInstance, bUnlockMovement, UnlockAILogic);
	}

	public static APawn SpawnAIFromClass(this UWorld WorldContextObject, TSubclassOf<APawn> PawnClass, UBehaviorTree BehaviorTree, FVector Location, FRotator Rotation, bool bNoCollisionFail, AActor Owner)
	{
		return UAIHelperLibrary.SpawnAIFromClass(WorldContextObject, PawnClass, BehaviorTree, Location, Rotation, bNoCollisionFail, Owner);
	}

	public static void SendAIMessage(this UObject MessageSource, APawn Target, FName Message, bool bSuccess = true)
	{
		UAIHelperLibrary.SendAIMessage(Target, Message, MessageSource, bSuccess);
	}

	public static void LockAIResourcesWithAnimation(this UAnimInstance AnimInstance, bool bLockMovement, bool LockAILogic)
	{
		UAIHelperLibrary.LockAIResourcesWithAnimation(AnimInstance, bLockMovement, LockAILogic);
	}

	public static UBlackboardComponent GetBlackboard(this AActor Target)
	{
		return UAIHelperLibrary.GetBlackboard(Target);
	}
}
