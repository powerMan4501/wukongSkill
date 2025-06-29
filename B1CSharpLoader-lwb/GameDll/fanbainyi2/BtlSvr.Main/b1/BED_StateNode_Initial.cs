using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Initial")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_StateNode_Initial")]
public class BED_StateNode_Initial : BED_StateNode
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.Initial;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Route";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Clear();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_Initial");
	}

	static BED_StateNode_Initial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_Initial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_Initial));
	}
}
