using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Placeable(true)]
[DisplayName("Idle")]
[USharpPath("/Script/b1-Managed.BED_ComboNode_Idle")]
public class BED_ComboNode_Idle : BED_ComboNode_State
{
	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "Route";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Add(GetDefaultInputPin());
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.ComboNode.Idle;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ComboNode_Idle");
	}

	static BED_ComboNode_Idle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ComboNode_Idle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ComboNode_Idle));
	}
}
