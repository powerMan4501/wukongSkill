using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Reroute")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_Reroute")]
public class BED_ProcessStateNode_Reroute : BED_ProcessStateNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	public override string GetNodeName()
	{
		return "Process.State.Reroute";
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_Reroute");
	}

	static BED_ProcessStateNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_Reroute));
	}
}
