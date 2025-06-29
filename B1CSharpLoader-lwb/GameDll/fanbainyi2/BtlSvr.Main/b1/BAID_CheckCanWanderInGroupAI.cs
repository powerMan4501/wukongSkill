using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("【无用节点！一定失败】CheckCanWanderInGroupAI")]
[USharpPath("/Script/b1-Managed.BAID_CheckCanWanderInGroupAI")]
internal class BAID_CheckCanWanderInGroupAI : BAID_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！一定失败！看到麻烦删除！】CheckCanWanderInGroupAI");
		SetNodeNameInCS(nodeNameInCS);
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCanWanderInGroupAI");
	}

	static BAID_CheckCanWanderInGroupAI()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCanWanderInGroupAI)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCanWanderInGroupAI));
	}
}
