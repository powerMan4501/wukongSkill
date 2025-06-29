using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("【无用节点！一定成功】CheckIsUnitActive")]
[USharpPath("/Script/b1-Managed.BAID_CheckIsUnitActive")]
internal class BAID_CheckIsUnitActive : BAID_Base
{
	public override void Initialize(FObjectInitializer initializer)
	{
		string nodeNameInCS = (base.CustomDescription = "【无用节点！一定成功！看到麻烦删除！】CheckIsUnitActive");
		SetNodeNameInCS(nodeNameInCS);
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckIsUnitActive");
	}

	static BAID_CheckIsUnitActive()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckIsUnitActive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckIsUnitActive));
	}
}
