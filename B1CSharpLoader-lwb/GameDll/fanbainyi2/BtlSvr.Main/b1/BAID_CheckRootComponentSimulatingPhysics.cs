using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckRootComponentSimulatingPhysics")]
internal class BAID_CheckRootComponentSimulatingPhysics : BAID_Base
{
	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		USceneComponent rootComponent = OwnerActor.GetRootComponent();
		if (rootComponent == null)
		{
			return false;
		}
		return rootComponent.IsAnySimulatingPhysics();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckRootComponentSimulatingPhysics");
	}

	static BAID_CheckRootComponentSimulatingPhysics()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckRootComponentSimulatingPhysics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckRootComponentSimulatingPhysics));
	}
}
