using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("Start")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_SkillNode_Start")]
internal class BED_SkillNode_Start : b1.BED_SkillNode
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.InputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.SkillNode.Start;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_SkillNode_Start");
	}

	static BED_SkillNode_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_SkillNode_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_SkillNode_Start));
	}
}
