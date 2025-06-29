using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Reroute")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ComboNode_Reroute")]
public class BED_ComboNode_Reroute : BED_ComboNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Reroute");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ComboNode.Reroute;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ComboNode_Reroute");
	}

	static BED_ComboNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ComboNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ComboNode_Reroute));
	}
}
