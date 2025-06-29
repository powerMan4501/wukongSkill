using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUBattleFieldPerformanceOptArea")]
internal class BGUBattleFieldPerformanceOptArea : BGUAreaBase
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.SimpleTrigger;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_BattleFieldPerformanceOptAreaLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BattleFieldPerformanceOptAreaDataComp>(this, B1GlobalFNames.DataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUBattleFieldPerformanceOptArea");
	}

	static BGUBattleFieldPerformanceOptArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUBattleFieldPerformanceOptArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUBattleFieldPerformanceOptArea));
	}
}
