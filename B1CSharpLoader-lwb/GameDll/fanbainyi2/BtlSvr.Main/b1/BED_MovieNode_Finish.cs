using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("流程结束")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_Finish")]
internal class BED_MovieNode_Finish : BED_MovieNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		SetNodeCategory("Route");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
		base.OutputPins.Clear();
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.Finish;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_Finish");
	}

	static BED_MovieNode_Finish()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_Finish)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_Finish));
	}
}
