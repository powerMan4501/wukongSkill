using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Finish")]
[NotBlueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_Finish")]
public class BED_QuestNode_Finish : BED_QuestNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Finish;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_Finish");
	}

	static BED_QuestNode_Finish()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_Finish)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_Finish));
	}
}
