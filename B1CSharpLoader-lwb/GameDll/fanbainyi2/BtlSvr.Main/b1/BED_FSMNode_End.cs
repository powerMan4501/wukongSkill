using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Placeable(true)]
[DisplayName("End")]
[USharpPath("/Script/b1-Managed.BED_FSMNode_End")]
public class BED_FSMNode_End : BED_FSMNode
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.OutputPins.Clear();
		SetNodeCategory("Comm");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_End");
	}

	static BED_FSMNode_End()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_End)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_End));
	}
}
