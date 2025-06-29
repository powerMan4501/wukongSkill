using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Reroute")]
[USharpPath("/Script/b1-Managed.BED_StateNode_Reroute")]
public class BED_StateNode_Reroute : BED_StateNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Reroute");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.StateNode.Reroute;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_StateNode_Reroute");
	}

	static BED_StateNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_StateNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_StateNode_Reroute));
	}
}
