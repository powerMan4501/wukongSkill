using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[UClass]
[DisplayName("Start")]
[USharpPath("/Script/b1-Managed.BED_TaskNode_Start")]
public class BED_TaskNode_Start : BED_TaskNode
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Start;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_Start");
	}

	static BED_TaskNode_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_Start));
	}
}
