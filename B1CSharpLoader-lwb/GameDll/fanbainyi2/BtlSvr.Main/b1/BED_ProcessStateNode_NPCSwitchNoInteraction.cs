using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("NPC切换无交互")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCSwitchNoInteraction")]
public class BED_ProcessStateNode_NPCSwitchNoInteraction : BED_ProcessStateNode
{
	private static bool bIsRecover_IsValid;

	private static int bIsRecover_Offset;

	private static FFieldAddress bIsRecover_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SwitchNPCInteraction")]
	[DisplayName("恢复当前交互状态")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NPCSwitchNoInteraction:bIsRecover")]
	public bool bIsRecover
	{
		get
		{
			CheckDestroyed();
			if (!bIsRecover_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCSwitchNoInteraction:bIsRecover");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsRecover_Offset), 0, bIsRecover_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsRecover_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NPCSwitchNoInteraction:bIsRecover");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsRecover_Offset), 0, bIsRecover_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bIsRecover = false;
	}

	public override string GetNodeName()
	{
		return "Process.State.NPCSwitchNoInteraction";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_NPCSwitchNoInteraction");
		NativeReflection.GetPropertyRef(ref bIsRecover_PropertyAddress, unrealStruct, "bIsRecover");
		bIsRecover_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bIsRecover");
		bIsRecover_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bIsRecover", Classes.FBoolProperty);
	}

	static BED_ProcessStateNode_NPCSwitchNoInteraction()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_NPCSwitchNoInteraction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_NPCSwitchNoInteraction));
	}
}
