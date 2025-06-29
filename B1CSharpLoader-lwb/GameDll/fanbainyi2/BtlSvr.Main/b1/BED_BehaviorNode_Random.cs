using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("按概率随机")]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Random")]
internal class BED_BehaviorNode_Random : BED_BehaviorNode
{
	private static bool SuccessRate_IsValid;

	private static int SuccessRate_Offset;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool IsSupportViewType_IsValid;

	private static IntPtr IsSupportViewType_FunctionAddress;

	private static int IsSupportViewType_ParamsSize;

	private static bool IsSupportViewType_InViewType_IsValid;

	private static int IsSupportViewType_InViewType_Offset;

	private static FFieldAddress IsSupportViewType_InViewType_PropertyAddress;

	private static bool IsSupportViewType_ReturnValue_IsValid;

	private static int IsSupportViewType_ReturnValue_Offset;

	private static FFieldAddress IsSupportViewType_ReturnValue_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[DisplayName("成功率")]
	[UMeta(MDProp.ClampMin, 0f)]
	[UMeta(MDProp.ClampMax, 1f)]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Random:SuccessRate")]
	public float SuccessRate
	{
		get
		{
			CheckDestroyed();
			if (!SuccessRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Random:SuccessRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SuccessRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SuccessRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Random:SuccessRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SuccessRate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否反转条件")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Random:bReverseCondition")]
	public bool bReverseCondition
	{
		get
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Random:bReverseCondition");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bReverseCondition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_Random:bReverseCondition");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bReverseCondition = false;
		SetNodeCategory("ConditionOnce");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
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

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.Random;
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Random:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (bReverseCondition)
		{
			stringBuilder.Append($"失败率：{SuccessRate * 100f}%");
		}
		else
		{
			stringBuilder.Append($"成功率：{SuccessRate * 100f}%");
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_Random
		{
			IsReverseCondition = bReverseCondition,
			SuccessRate = SuccessRate
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_Random:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_Random:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_Random bED_BehaviorNode_Random = GCHelper.Find<b1.BED_BehaviorNode_Random>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_Random.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_Random:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_Random bED_BehaviorNode_Random = GCHelper.Find<b1.BED_BehaviorNode_Random>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_Random.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_Random");
		SuccessRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessRate");
		SuccessRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessRate", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_Random:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_Random:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_Random()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_Random)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_Random));
	}
}
