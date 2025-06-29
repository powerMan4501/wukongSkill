using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("【无用节点！一定失败】CheckCanCastStalemateSkill")]
[USharpPath("/Script/b1-Managed.BAID_CheckCanCastStalemateSkill")]
internal class BAID_CheckCanCastStalemateSkill : BAID_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！一定失败！看到麻烦删除！】CheckCanCastStalemateSkill");
		SetNodeNameInCS(nodeNameInCS);
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCanCastStalemateSkill");
	}

	static BAID_CheckCanCastStalemateSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCanCastStalemateSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCanCastStalemateSkill));
	}
}
