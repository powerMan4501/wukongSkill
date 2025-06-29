using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUMedicineBasketActor")]
public class BGUMedicineBasketActor : BGUInteractiveActorBase
{
	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_MedicineBasketComp());
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUMedicineBasketActor");
	}

	static BGUMedicineBasketActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUMedicineBasketActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUMedicineBasketActor));
	}
}
