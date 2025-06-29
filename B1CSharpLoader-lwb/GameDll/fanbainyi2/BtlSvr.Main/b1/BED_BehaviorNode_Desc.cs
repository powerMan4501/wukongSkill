using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Desc")]
[UClass]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Desc")]
internal class BED_BehaviorNode_Desc : BED_BehaviorNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Unused");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.Desc;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_Desc");
	}

	static BED_BehaviorNode_Desc()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_Desc)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_Desc));
	}
}
