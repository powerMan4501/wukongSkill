using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("【无用节点！一定失败！】CheckSurpriseSkill")]
[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckSurpriseSkill")]
internal class BAID_CheckSurpriseSkill : BAID_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！一定失败！看到麻烦删除！】CheckSurpriseSkill");
		SetNodeNameInCS(nodeNameInCS);
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckSurpriseSkill");
	}

	static BAID_CheckSurpriseSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckSurpriseSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckSurpriseSkill));
	}
}
