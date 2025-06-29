using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("【无用节点！一定成功】CheckAttackValid")]
[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckAttackValid")]
internal class BAID_CheckAttackValid : BAID_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！一定成功！看到麻烦删除！】CheckAttackValid");
		SetNodeNameInCS(nodeNameInCS);
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckAttackValid");
	}

	static BAID_CheckAttackValid()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckAttackValid)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckAttackValid));
	}
}
