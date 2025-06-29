using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUForceOriginalFormOuterTriggerArea")]
internal class BGUForceOriginalFormOuterTriggerArea : BGUAreaBase
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ForceOriginalFormOuterAreaLogicComp());
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUForceOriginalFormOuterTriggerArea");
	}

	static BGUForceOriginalFormOuterTriggerArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUForceOriginalFormOuterTriggerArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUForceOriginalFormOuterTriggerArea));
	}
}
