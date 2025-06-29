using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("End State")]
[Placeable(false)]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BossRushNode_End")]
public class BED_BossRushNode_End : BED_BossRushNode
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.BossRushNode.End;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Machine Nodes";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.OutputPins.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BossRushNode_End");
	}

	static BED_BossRushNode_End()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BossRushNode_End)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BossRushNode_End));
	}
}
