using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("【无用节点！一定成功】HasValidTarget")]
[USharpPath("/Script/b1-Managed.BAID_HasValidTarget")]
public class BAID_HasValidTarget : BAID_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！一定成功！看到麻烦删除！】HasValidTarget");
		SetNodeNameInCS(nodeNameInCS);
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_HasValidTarget");
	}

	static BAID_HasValidTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_HasValidTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_HasValidTarget));
	}
}
