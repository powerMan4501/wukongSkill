using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[NotBlueprintable]
[DisplayName("Reroute")]
[USharpPath("/Script/b1-Managed.BED_FSMNode_Reroute")]
public class BED_FSMNode_Reroute : BED_FSMNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_FSMNode_Reroute");
	}

	static BED_FSMNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_FSMNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_FSMNode_Reroute));
	}
}
