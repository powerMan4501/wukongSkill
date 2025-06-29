using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDamageCaster")]
internal class BGUDamageCaster : BGUActorBaseCS
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_TriggerEffectComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_TriggerEffectCompSvr(), 128, 1024);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_DamageCastDataComp>(this, B1GlobalFNames.DamageCastDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDamageCaster");
	}

	static BGUDamageCaster()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUDamageCaster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUDamageCaster));
	}
}
