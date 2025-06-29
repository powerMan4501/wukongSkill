using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Condition")]
public class BED_BehaviorNode_Condition : BED_BehaviorNode
{
	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool ConditionCoolDownTimeMs_IsValid;

	private static int ConditionCoolDownTimeMs_Offset;

	public override EBehaviorNodeSide NodeSide => EBehaviorNodeSide.LeftNode;

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否反转条件")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Condition:bReverseCondition")]
	public bool bReverseCondition
	{
		get
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Condition:bReverseCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Condition:bReverseCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("如果大于0, 条件满足后会进入冷却时间不再检测")]
	[EditAnywhere]
	[DisplayName("条件冷却时间（毫秒）")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Condition:ConditionCoolDownTimeMs")]
	public int ConditionCoolDownTimeMs
	{
		get
		{
			CheckDestroyed();
			if (!ConditionCoolDownTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Condition:ConditionCoolDownTimeMs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ConditionCoolDownTimeMs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConditionCoolDownTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Condition:ConditionCoolDownTimeMs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ConditionCoolDownTimeMs_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bReverseCondition = false;
		ConditionCoolDownTimeMs = 0;
		SetNodeCategory("Condition");
		SetNodeStyle(ECalliopeNodeStyle.Condition);
		base.InputPins.Clear();
		base.OutputPins.Clear();
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Success
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Failed
		});
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_Condition
		{
			IsReverseCondition = bReverseCondition,
			ConditionCoolDownTimeMs = ConditionCoolDownTimeMs
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_Condition");
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, unrealStruct, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bReverseCondition", Classes.FBoolProperty);
		ConditionCoolDownTimeMs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConditionCoolDownTimeMs");
		ConditionCoolDownTimeMs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConditionCoolDownTimeMs", Classes.FIntProperty);
	}

	static BED_BehaviorNode_Condition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_Condition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_Condition));
	}
}
