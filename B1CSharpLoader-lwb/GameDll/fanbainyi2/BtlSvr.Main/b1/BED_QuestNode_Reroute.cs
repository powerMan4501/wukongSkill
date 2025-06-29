using System;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[DisplayName("Reroute")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_QuestNode_Reroute")]
public class BED_QuestNode_Reroute : BED_QuestNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.QuestNode.Reroute;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_QuestNode_Reroute");
	}

	static BED_QuestNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_QuestNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_QuestNode_Reroute));
	}
}
