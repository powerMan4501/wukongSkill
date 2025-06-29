using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("NPC切换Idle动画")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeIdleAnim")]
public class BED_ProcessStateNode_NPCChangeIdleAnim : BED_ProcessStateNode
{
	private static bool NeedChangeIdleAnimIdx_IsValid;

	private static int NeedChangeIdleAnimIdx_Offset;

	[UProperty]
	[Category("NPCChangeIdleAnim")]
	[DisplayName("切换Idle动画序号")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeIdleAnim:NeedChangeIdleAnimIdx")]
	protected int NeedChangeIdleAnimIdx
	{
		get
		{
			CheckDestroyed();
			if (!NeedChangeIdleAnimIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeIdleAnim:NeedChangeIdleAnimIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NeedChangeIdleAnimIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NeedChangeIdleAnimIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeIdleAnim:NeedChangeIdleAnimIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NeedChangeIdleAnimIdx_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "Notify";
		base.NodeStyle = ECalliopeNodeStyle.Default;
	}

	public override string GetNodeName()
	{
		return "Process.State.NPCChangeIdleAnim";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeIdleAnim");
		NeedChangeIdleAnimIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedChangeIdleAnimIdx");
		NeedChangeIdleAnimIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedChangeIdleAnimIdx", Classes.FIntProperty);
	}

	static BED_ProcessStateNode_NPCChangeIdleAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_NPCChangeIdleAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_NPCChangeIdleAnim));
	}
}
