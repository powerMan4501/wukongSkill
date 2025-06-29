using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("【无用节点！一定失败】TargetBeyondPursuitRange")]
[UClass]
[USharpPath("/Script/b1-Managed.BAID_TargetBeyondPursuitRange")]
public class BAID_TargetBeyondPursuitRange : BAID_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！一定失败！看到麻烦删除！】TargetBeyondPursuitRange");
		SetNodeNameInCS(nodeNameInCS);
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_TargetBeyondPursuitRange");
	}

	static BAID_TargetBeyondPursuitRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_TargetBeyondPursuitRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_TargetBeyondPursuitRange));
	}
}
