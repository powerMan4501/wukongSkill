using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Terminate")]
[NotBlueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BED_StateNode_Terminate")]
public class BED_StateNode_Terminate : BED_StateNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.Terminate;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_Terminate");
	}

	static BED_StateNode_Terminate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_Terminate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_Terminate));
	}
}
