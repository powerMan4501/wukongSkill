using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("NPC显示/隐藏")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCShow")]
public class BED_ProcessStateNode_NPCShow : BED_ProcessStateNode
{
	private static bool bIsShow_IsValid;

	private static int bIsShow_Offset;

	private static FFieldAddress bIsShow_PropertyAddress;

	[UProperty]
	[EditDefaultsOnly]
	[Category("NPCShow")]
	[DisplayName("NPC是否显示")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCShow:bIsShow")]
	protected bool bIsShow
	{
		get
		{
			CheckDestroyed();
			if (!bIsShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCShow:bIsShow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsShow_Offset), 0, bIsShow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsShow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCShow:bIsShow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsShow_Offset), 0, bIsShow_PropertyAddress.Address, value);
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
		return "Process.State.NPCShow";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_NPCShow");
		NativeReflection.GetPropertyRef(ref bIsShow_PropertyAddress, unrealStruct, "bIsShow");
		bIsShow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bIsShow");
		bIsShow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bIsShow", Classes.FBoolProperty);
	}

	static BED_ProcessStateNode_NPCShow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_NPCShow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_NPCShow));
	}
}
