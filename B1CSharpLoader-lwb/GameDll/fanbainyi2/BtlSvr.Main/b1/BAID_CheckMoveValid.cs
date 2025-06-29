using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckMoveValid")]
internal class BAID_CheckMoveValid : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		if (!BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS, EBGUUnitState.Attacking))
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckMoveValid");
	}

	static BAID_CheckMoveValid()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckMoveValid)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckMoveValid));
	}
}
