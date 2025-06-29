using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("检测单个单位")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectUnit")]
public class BED_BehaviorNode_DetectUnit : BED_BehaviorNode_Condition
{
	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool SmartUnit_IsValid;

	private static int SmartUnit_Offset;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	private TArrayReadWriteMarshaler<FDetectCondition> Conditions_Marshaler;

	private static bool ConditionalRelation_IsValid;

	private static int ConditionalRelation_Offset;

	private static FFieldAddress ConditionalRelation_PropertyAddress;

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

	[DisplayName("检测的单位")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:UnitType")]
	public EDetectedUnitType UnitType
	{
		get
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:UnitType");
				return EDetectedUnitType.Self;
			}
			return EnumMarshaler<EDetectedUnitType>.FromNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnitType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:UnitType");
			}
			else
			{
				EnumMarshaler<EDetectedUnitType>.ToNative(IntPtr.Add(base.Address, UnitType_Offset), 0, UnitType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("SmartUnit")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:SmartUnit")]
	public FGsSmartParam SmartUnit
	{
		get
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:SmartUnit");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, SmartUnit_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SmartUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:SmartUnit");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, SmartUnit_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("检测条件")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:Conditions")]
	public TArrayReadWrite<FDetectCondition> Conditions
	{
		get
		{
			CheckDestroyed();
			if (!Conditions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:Conditions");
				return null;
			}
			if (Conditions_Marshaler == null)
			{
				Conditions_Marshaler = new TArrayReadWriteMarshaler<FDetectCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.FromNative, CachedMarshalingDelegates<FDetectCondition, FDetectCondition>.ToNative);
			}
			return Conditions_Marshaler.FromNative(IntPtr.Add(base.Address, Conditions_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("条件逻辑关系")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:ConditionalRelation")]
	public EConditionalRelation ConditionalRelation
	{
		get
		{
			CheckDestroyed();
			if (!ConditionalRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:ConditionalRelation");
				return EConditionalRelation.And;
			}
			return EnumMarshaler<EConditionalRelation>.FromNative(IntPtr.Add(base.Address, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConditionalRelation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:ConditionalRelation");
			}
			else
			{
				EnumMarshaler<EConditionalRelation>.ToNative(IntPtr.Add(base.Address, ConditionalRelation_Offset), 0, ConditionalRelation_PropertyAddress.Address, value);
			}
		}
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.DetectUnit;
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (UnitType)
		{
		case EDetectedUnitType.Self:
			stringBuilder.AppendLine("检测自身");
			break;
		case EDetectedUnitType.Target:
			stringBuilder.AppendLine("检测目标");
			break;
		case EDetectedUnitType.Master:
			stringBuilder.AppendLine("检测Master");
			break;
		case EDetectedUnitType.Player:
			stringBuilder.AppendLine("检测主角");
			break;
		case EDetectedUnitType.UseSmartUnit:
			stringBuilder.AppendLine("检测SmartUnit");
			break;
		}
		stringBuilder.AppendLine($"条件数量{Conditions.Count}");
		if (base.bReverseCondition)
		{
			stringBuilder.Append("失败条件：");
		}
		else
		{
			stringBuilder.Append("成功条件：");
		}
		switch (ConditionalRelation)
		{
		case EConditionalRelation.And:
			stringBuilder.Append("同时满足所有条件");
			break;
		case EConditionalRelation.Or:
			stringBuilder.Append("满足任意条件");
			break;
		}
		return stringBuilder.ToString();
	}

	public override byte[] GetCustomData()
	{
		BehaviorCustom_DetectUnit behaviorCustom_DetectUnit = new BehaviorCustom_DetectUnit();
		behaviorCustom_DetectUnit.IsReverseCondition = base.bReverseCondition;
		behaviorCustom_DetectUnit.ConditionCoolDownTimeMs = base.ConditionCoolDownTimeMs;
		behaviorCustom_DetectUnit.UnitType = (int)UnitType;
		foreach (FDetectCondition condition in Conditions)
		{
			behaviorCustom_DetectUnit.Conditions.Add(condition.GetSerializableObject());
		}
		behaviorCustom_DetectUnit.ConditionalRelation = (int)ConditionalRelation;
		behaviorCustom_DetectUnit.SmartUnitGuid = ConvertGUID_UnitCollection(SmartUnit.ConfigGuid);
		return behaviorCustom_DetectUnit.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:IsSupportViewType")]
	protected override bool IsSupportViewType_Implementation(ECalliopeViewType InViewType)
	{
		if (InViewType == ECalliopeViewType.Dialogue || InViewType == ECalliopeViewType.Behavior)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:IsSupportViewType")]
	private static void IsSupportViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_DetectUnit bED_BehaviorNode_DetectUnit = GCHelper.Find<BED_BehaviorNode_DetectUnit>(obj);
		ECalliopeViewType inViewType = EnumMarshaler<ECalliopeViewType>.FromNative(IntPtr.Add(buffer, IsSupportViewType_InViewType_Offset), 0, IsSupportViewType_InViewType_PropertyAddress.Address);
		bool value = bED_BehaviorNode_DetectUnit.IsSupportViewType_Implementation(inViewType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsSupportViewType_ReturnValue_Offset), 0, IsSupportViewType_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BehaviorNode_DetectUnit bED_BehaviorNode_DetectUnit = GCHelper.Find<BED_BehaviorNode_DetectUnit>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_DetectUnit.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_DetectUnit");
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		SmartUnit_Offset = NativeReflection.GetPropertyOffset(intPtr, "SmartUnit");
		SmartUnit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SmartUnit", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ConditionalRelation_PropertyAddress, intPtr, "ConditionalRelation");
		ConditionalRelation_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionalRelation");
		ConditionalRelation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionalRelation", Classes.FEnumProperty);
		IsSupportViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsSupportViewType");
		IsSupportViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSupportViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_InViewType_PropertyAddress, IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "InViewType");
		IsSupportViewType_InViewType_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "InViewType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsSupportViewType_ReturnValue_PropertyAddress, IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsSupportViewType_FunctionAddress, "ReturnValue");
		IsSupportViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsSupportViewType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSupportViewType_IsValid = IsSupportViewType_FunctionAddress != IntPtr.Zero && IsSupportViewType_InViewType_IsValid && IsSupportViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:IsSupportViewType", IsSupportViewType_IsValid);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_DetectUnit:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_DetectUnit()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BehaviorNode_DetectUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BehaviorNode_DetectUnit));
	}
}
