using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("进入状态")]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_EnterAction")]
public class BED_ProcessStateNode_EnterAction : BED_ProcessStateNode
{
	private static bool bOverride_IsValid;

	private static int bOverride_Offset;

	private static FFieldAddress bOverride_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否覆盖原有逻辑")]
	[Category("State")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_EnterAction:bOverride")]
	public bool bOverride
	{
		get
		{
			CheckDestroyed();
			if (!bOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_EnterAction:bOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bOverride_Offset), 0, bOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_EnterAction:bOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bOverride_Offset), 0, bOverride_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "Input";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Clear();
		bOverride = true;
	}

	public override string GetNodeName()
	{
		return "Process.State.EnterAction";
	}

	public override byte[] GetCustomData()
	{
		return new ProcessStateCustom_EnterAction
		{
			IsOverrideParent = bOverride
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_EnterAction");
		NativeReflection.GetPropertyRef(ref bOverride_PropertyAddress, unrealStruct, "bOverride");
		bOverride_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bOverride");
		bOverride_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bOverride", Classes.FBoolProperty);
	}

	static BED_ProcessStateNode_EnterAction()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_EnterAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_EnterAction));
	}
}
