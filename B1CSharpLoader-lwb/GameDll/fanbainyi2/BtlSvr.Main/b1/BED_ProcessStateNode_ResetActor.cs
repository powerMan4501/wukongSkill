using System;
using b1.Plugins.Calliope;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(false)]
[DisplayName("Reset Actor")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ResetActor")]
public class BED_ProcessStateNode_ResetActor : BED_ProcessStateNode
{
	private static bool ResetType_IsValid;

	private static int ResetType_Offset;

	private static FFieldAddress ResetType_PropertyAddress;

	[EditAnywhere]
	[DisplayName("重置类型")]
	[Category("ResetActor")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_ResetActor:ResetType")]
	public EBGUResetType ResetType
	{
		get
		{
			CheckDestroyed();
			if (!ResetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ResetActor:ResetType");
				return EBGUResetType.No;
			}
			return EnumMarshaler<EBGUResetType>.FromNative(IntPtr.Add(base.Address, ResetType_Offset), 0, ResetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_ResetActor:ResetType");
			}
			else
			{
				EnumMarshaler<EBGUResetType>.ToNative(IntPtr.Add(base.Address, ResetType_Offset), 0, ResetType_PropertyAddress.Address, value);
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
		return "Process.State.ResetActor";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_ResetActor");
		NativeReflection.GetPropertyRef(ref ResetType_PropertyAddress, unrealStruct, "ResetType");
		ResetType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ResetType");
		ResetType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ResetType", Classes.FEnumProperty);
	}

	static BED_ProcessStateNode_ResetActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_ResetActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_ResetActor));
	}
}
