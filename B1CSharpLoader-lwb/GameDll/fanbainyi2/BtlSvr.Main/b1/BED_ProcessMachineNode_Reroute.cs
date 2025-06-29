using System;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[UClass]
[DisplayName("Reroute")]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Reroute")]
public class BED_ProcessMachineNode_Reroute : BED_ProcessMachineNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Reroute;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Reroute");
	}

	static BED_ProcessMachineNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Reroute));
	}
}
