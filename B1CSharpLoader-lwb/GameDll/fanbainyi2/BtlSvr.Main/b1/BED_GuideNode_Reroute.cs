using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Placeable(false)]
[DisplayName("Reroute")]
[USharpPath("/Script/b1-Managed.BED_GuideNode_Reroute")]
public class BED_GuideNode_Reroute : BED_GuideNode_Base
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Route");
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.GuideNode.Reroute;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_GuideNode_Reroute");
	}

	static BED_GuideNode_Reroute()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_GuideNode_Reroute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_GuideNode_Reroute));
	}
}
