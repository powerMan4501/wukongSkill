using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_StandAndFace")]
internal class BAIT_StandAndFace : BAIT_Base
{
	public override void ReceiveExecute(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		if (!BGUFuncLibForMove.IsMoveActive(bGUCharacterCS))
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(OwnerActor);
			if (aActor != null)
			{
				BGUFuncLibForMove.BeginRotateToTargetPos(bGUCharacterCS, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor), 200f, out var _);
			}
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIT_StandAndFace");
	}

	static BAIT_StandAndFace()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_StandAndFace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_StandAndFace));
	}
}
