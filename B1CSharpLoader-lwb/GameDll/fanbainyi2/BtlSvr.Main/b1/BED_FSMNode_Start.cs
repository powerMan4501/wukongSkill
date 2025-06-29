using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("Start")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_FSMNode_Start")]
public class BED_FSMNode_Start : BED_FSMNode
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
		SetNodeCategory("Comm");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_Start");
	}

	static BED_FSMNode_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_Start));
	}
}
