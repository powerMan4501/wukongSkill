using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("NPC切换Leisure动画")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeLeisureAnim")]
public class BED_ProcessStateNode_NPCChangeLeisureAnim : BED_ProcessStateNode
{
	private static bool NeedChangeLeisureAnimIdx_IsValid;

	private static int NeedChangeLeisureAnimIdx_Offset;

	[DisplayName("切换Leisure动画序号")]
	[Category("NPCChangeLeisureAnim")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeLeisureAnim:NeedChangeLeisureAnimIdx")]
	protected int NeedChangeLeisureAnimIdx
	{
		get
		{
			CheckDestroyed();
			if (!NeedChangeLeisureAnimIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeLeisureAnim:NeedChangeLeisureAnimIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NeedChangeLeisureAnimIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NeedChangeLeisureAnimIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeLeisureAnim:NeedChangeLeisureAnimIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NeedChangeLeisureAnimIdx_Offset), value);
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
		return "Process.State.NPCChangeLeisureAnim";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_NPCChangeLeisureAnim");
		NeedChangeLeisureAnimIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedChangeLeisureAnimIdx");
		NeedChangeLeisureAnimIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedChangeLeisureAnimIdx", Classes.FIntProperty);
	}

	static BED_ProcessStateNode_NPCChangeLeisureAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_NPCChangeLeisureAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_NPCChangeLeisureAnim));
	}
}
