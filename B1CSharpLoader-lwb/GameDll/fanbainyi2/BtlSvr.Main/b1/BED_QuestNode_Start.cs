using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Start")]
[Placeable(false)]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_Start")]
public class BED_QuestNode_Start : BED_QuestNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Start;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_Start");
	}

	static BED_QuestNode_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_Start));
	}
}
