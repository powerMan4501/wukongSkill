using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("检查自身是否在战斗状态内")]
[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckOwnerIsInBattleState")]
internal class BAID_CheckOwnerIsInBattleState : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		return BGUFunctionLibraryCS.BGUIsUnitInBattle(bGUCharacterCS);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckOwnerIsInBattleState");
	}

	static BAID_CheckOwnerIsInBattleState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckOwnerIsInBattleState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckOwnerIsInBattleState));
	}
}
