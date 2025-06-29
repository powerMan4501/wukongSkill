using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[NotBlueprintable]
[DisplayName("Final")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_StateNode_Final")]
public class BED_StateNode_Final : BED_StateNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.Final;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_Final");
	}

	static BED_StateNode_Final()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_Final)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_Final));
	}
}
