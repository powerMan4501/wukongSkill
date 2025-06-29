using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Reroute")]
[Placeable(false)]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BossRushNode_Reroute")]
public class BED_BossRushNode_Reroute : BED_BossRushNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BossRushNode.Reroute;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BossRushNode_Reroute");
	}

	static BED_BossRushNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BossRushNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BossRushNode_Reroute));
	}
}
