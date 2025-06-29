using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSafeLandArea")]
internal class BGUSafeLandArea : BGUAreaBase
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_SafeLandLogicComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.CreateDataContainer(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSafeLandArea");
	}

	static BGUSafeLandArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUSafeLandArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUSafeLandArea));
	}
}
