using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Active Unit")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ActiveUnit")]
public class BED_ProcessStateNode_ActiveUnit : BED_ProcessStateNode
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "Notify";
		base.NodeStyle = ECalliopeNodeStyle.Default;
	}

	public override string GetNodeName()
	{
		return "Process.State.ActiveUnit";
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_ActiveUnit");
	}

	static BED_ProcessStateNode_ActiveUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_ActiveUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_ActiveUnit));
	}
}
