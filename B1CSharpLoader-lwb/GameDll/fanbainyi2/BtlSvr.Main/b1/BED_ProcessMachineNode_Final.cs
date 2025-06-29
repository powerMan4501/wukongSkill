using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[Placeable(false)]
[UClass]
[DisplayName("Final State")]
[USharpPath("/Script/b1-Managed.BED_ProcessMachineNode_Final")]
public class BED_ProcessMachineNode_Final : BED_ProcessMachineNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Machine Nodes");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ProcessMachineNode.Final;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessMachineNode_Final");
	}

	static BED_ProcessMachineNode_Final()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessMachineNode_Final)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessMachineNode_Final));
	}
}
