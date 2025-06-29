using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("更新交互组信息")]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_UpdateInteractGroup")]
public class BED_ProcessStateNode_UpdateInteractGroup : BED_ProcessStateNode
{
	private static bool InteractGroupID_IsValid;

	private static int InteractGroupID_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("UpdateInteractGroup")]
	[BlueprintReadWrite]
	[DisplayName("更新的交互组ID")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_UpdateInteractGroup:InteractGroupID")]
	public int InteractGroupID
	{
		get
		{
			CheckDestroyed();
			if (!InteractGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_UpdateInteractGroup:InteractGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InteractGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InteractGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_UpdateInteractGroup:InteractGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InteractGroupID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		InteractGroupID = -1;
	}

	public override string GetNodeName()
	{
		return "Process.State.UpdateInteractGroup";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_UpdateInteractGroup");
		InteractGroupID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InteractGroupID");
		InteractGroupID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InteractGroupID", Classes.FIntProperty);
	}

	static BED_ProcessStateNode_UpdateInteractGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_UpdateInteractGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_UpdateInteractGroup));
	}
}
